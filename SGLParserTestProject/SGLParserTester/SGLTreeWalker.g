tree grammar SGLTreeWalker;

options {
	tokenVocab = SGL;
	language = 'CSharp2';
	ASTLabelType=CommonTree;
}

@namespace { SGL.Parser }

@header {
	using System.Collections.Generic;
}

@members{
	SGLActions action = new SGLActions();
	
	// Error reporting
    private StdErrReporter errorReporter = new StdErrReporter();
    public override void EmitErrorMessage(String msg)
    {
    	errorReporter.ReportError(msg);
    }

	// For global variables (accessable anywhere)
	//NullableDictionnary globalVariables = new NullableDictionnary();
	
	// For main variables (accessable anywhere but methods)
	
	
	
	//NullableDictionnary mainVariables = new NullableDictionnary();
	
	// This should tell the statements where they have to look up variables
	//NullableDictionnary variableAccess = mainVariables;

	//String output;
	//public String GetOutput() {
	//	return output;
	//}
}
compilationUnit [SGLNode node]
@init { 
  BlockNode bn = new BlockNode(); 
  node = bn; 
  Scope scope = new Scope(currentScope); 
  currentScope = scope; 
}  
@after { 
  currentScope = currentScope.parent(); 
}  
	:	mainStatement+ EOF { node = $mainStatement}
	;	
	
mainStatement [SGLNode node]
	:	statement
	;	


statement [SGLNode node]
	//:  	variableDefinitionList
	:	variableDeclarationList // int a = 1, b = 2, c
	|	^(ASSIGN variableAssignment)// a = 4
	|	whileLoop
	;
	
whileLoop [SGLNode node]
	:	^('while' expression statement*)
	{
	}
	;
	

/* Statements */

// int t = 1
//action.NewLocalVariable($variableType.text,$variableName.text,$expression.text); 
variableDeclarationList
	:	^(VARDEF variableType variableName expression) { 	
		action.NewLocalVariable($variableType.txt,$variableName.txt,$expression.txt); 
	}
	//|   ^(VARDEF variableType variableName)	{ 	action.NewLocalVariable($variableType.text,$variableName.text,"boo"); }
	;



// Only used for the first time declaration of a new variable
variableAssignment
	:	variableName expression? {
		action.AssignVariable($variableName.txt,$expression.txt);
	}
	;
	
	
variableName returns [string txt]
	:	Identifier {$txt = $Identifier.text;}
	;	

variableType returns [string txt]
	:	IntType {$txt = $IntType.text;}
	|	BooleanType {$txt = $BooleanType.text;}
	|	StringType {$txt = $StringType.text;}
	|	FloatType {$txt = $FloatType.text;}
	;

  
    
    
    
/* Expressions */

// start rule for all sorts of expressions
expression returns [string txt]
	:	^('+' a=expression b=expression) { $txt = action.Add($a.txt,$b.txt); }
	|	^('-' a=expression b=expression) { $txt = action.Sub($a.txt,$b.txt); }
	|	^('*' a=expression b=expression) { $txt = action.Mult($a.txt,$b.txt); }
	|	^('/' a=expression b=expression) { $txt = action.Div($a.txt,$b.txt); }
	|	^('%' a=expression b=expression) { $txt = action.Remainder($a.txt,$b.txt); } 
	|	^(NEGATE a=expression) { $txt = action.Mult($a.txt,"-1"); }
	|	^('<' a=expression b=expression) { $txt = action.ConditionLess($a.txt,$b.txt); }
	|	^('<=' a=expression b=expression) { $txt = action.ConditionLessOrEqual($a.txt,$b.txt); }
	|	^('>' a=expression b=expression) { $txt = action.ConditionGreater($a.txt,$b.txt); }
	|	^('>=' a=expression b=expression) { $txt = action.ConditionGreaterOrEqual($a.txt,$b.txt); }
	|	^('!=' a=expression b=expression) { $txt = action.ConditionNotEqual($a.txt,$b.txt); }
	|	^('==' a=expression b=expression) { $txt = action.ConditionEqual($a.txt,$b.txt); }
	|	^('&&' a=expression b=expression) { $txt = action.ConnectiveAnd($a.txt,$b.txt); }
	|	^('||' a=expression b=expression) { $txt = action.ConnectiveOr($a.txt,$b.txt); }
	|	^('?' a=expression b=expression c=expression) { $txt = action.ConditionBranch($a.txt,$b.txt,$c.txt); }
	|	Identifier { $txt = action.GetVariable($Identifier.text); }
	|  	IntegerAtom { $txt = $IntegerAtom.text; }
	|  	BooleanAtom { $txt = $BooleanAtom.text; }
    //|	mathExpression
    ;    
    
// Simplified if-condition, (condition ? if-expression : else-expression)    
//mathConditionalExpression
//    :   booleanExpression ( '?' (mathConditionalExpression | mathExpression) ':' (mathConditionalExpression | mathExpression) )?
//    ;
    
conditionalExpression
    :    conditionalOrExpression '?' conditionalExpression ':'conditionalExpression
    ;        
       
    
// OR     
conditionalOrExpression
    :   conditionalAndExpression ( '||' conditionalAndExpression )*
    ;    
    
// AND     
conditionalAndExpression
    :   equalityExpression ( '&&' equalityExpression )*
    ;
    
// Is (not) equal to    
equalityExpression
    :   relationalExpression ( ('==' | '!=') relationalExpression )*
    ;    
    
// Comparison <, > , <=, =>    
relationalExpression
    :   additiveExpression ( ('<'|'>'|'<='|'>=') additiveExpression )*
    ;            
    
// + / -    
additiveExpression
    :   e=multiplicativeExpression
    (	'+' e=multiplicativeExpression 
    |	'-' e=multiplicativeExpression
    )*
    ;        
    
// * / / / %    
multiplicativeExpression
    :   e=mathAtom
    (	'*' e=mathAtom
    |	'/' e=mathAtom
    |	'%' e=mathAtom
    )*
    ;
    
unaryExpression
    :	'++' unaryExpression
    |   '--' unaryExpression
    |   unaryExpressionNotPlusMinus
    ; 


unaryExpressionNotPlusMinus
    :   '!' unaryExpression
    |   castExpression
    //|   primary selector* ('++'|'--')?
    |   mathAtom ('++'|'--')?
    ;       

// Int -> Float, ...    
castExpression
    :  '(' variableType ')' unaryExpression
    ;  

// (...) / value / variable / method like rand(...)  
mathAtom
    :   ('-')? 
    (	'(' e=additiveExpression ')'
    |   i=IntegerAtom
    
//    |	f=Float
    //|   'new' creator
//    |   Identifier ('.' Identifier)* arguments
    );    

// arguments for methods aso.
arguments
    :   '(' expressionList? ')'
    ;

expressionList
    :   expression (',' expression)*
    ;


    
literal 
    :   IntegerAtom
    |   FloatAtom
    |   StringAtom
    |   BooleanAtom
    |   'null'
    ;    





