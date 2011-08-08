tree grammar SGLTreeWalker;

options {
	tokenVocab = SGL;
	language = 'CSharp2';
	ASTLabelType=CommonTree;
}

@namespace { SGL.AntlrParser }

@header {
	using System.Collections.Generic;
	using SGL.Node;
}

@members{
	Scope currentScope = null;
	// Error reporting
    //private StdErrReporter errorReporter = new StdErrReporter();
    //public override void EmitErrorMessage(String msg)
    //{
    //	errorReporter.ReportError(msg);
    //}

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
compilationUnit returns [SGLNode node]
	:	block { node = $block.node; }
	;	

/*	
mainStatement
	:	statement
	;	

*/

block returns [SGLNode node]
@init { 
  BlockNode bn = new BlockNode(); 
  node = bn; 
  Scope scope = new Scope(currentScope); 
  currentScope = scope; 
}  
@after { 
  currentScope = currentScope.Parent(); 
} 
	:	^(BLOCK   
        	^( STATEMENTS (statement  {bn.AddStatement($statement.node);})* )    
     	)  
  	; 

statement returns [SGLNode node]
	//:  	variableDefinitionList
	:	variableDeclaration { node = $variableDeclaration.node; } // int a = 1, b = 2, c
	//|	^(ASSIGN variableAssignment)// a = 4
	//|	whileLoop
	;
/*	
whileLoop
	:	^('while' expression statement*)
	{
	}
	;
*/	

/* Statements */

// int t = 1
//action.NewLocalVariable($variableType.text,$variableName.text,$expression.text); 
variableDeclaration returns [SGLNode node]
	:	^(VARDEF variableType variableName expression) { 	
		node = new NewLocalVariableNode($variableType.txt,$variableName.txt,$expression.node,currentScope); 
	}
	//|   ^(VARDEF variableType variableName)	{ 	action.NewLocalVariable($variableType.text,$variableName.text,"boo"); }
	;



// Only used for the first time declaration of a new variable
/*'
variableAssignment
	:	variableName expression? {
		action.AssignVariable($variableName.txt,$expression.txt);
	}
	;
*/	
	
variableName returns [String txt]
	:	Identifier { txt = $Identifier.text; }
	;	

variableType returns [String txt]
	:	IntType { txt = $IntType.text; }
	|	BooleanType { txt = $BooleanType.text; }
	|	StringType { txt = $StringType.text; }
	|	FloatType { txt = $FloatType.text; }
	;

  
    
    
    
/* Expressions */

// start rule for all sorts of expressions
expression returns [SGLNode node]
	:	^('+' a=expression b=expression) { node = new AddNode($a.node, $b.node); }
	|	^('-' a=expression b=expression) { node = new SubNode($a.node, $b.node); }
	|	^('*' a=expression b=expression) { node = new MultNode($a.node, $b.node); }
	|	^('/' a=expression b=expression) { node = new DivNode($a.node, $b.node); }
	|	^('%' a=expression b=expression) 
	|	^(NEGATE a=expression)
	|	^('<' a=expression b=expression)
	|	^('<=' a=expression b=expression)
	|	^('>' a=expression b=expression)
	|	^('>=' a=expression b=expression)
	|	^('!=' a=expression b=expression)
	|	^('==' a=expression b=expression)
	|	^('&&' a=expression b=expression)
	|	^('||' a=expression b=expression)
	|	^('?' a=expression b=expression c=expression)
	|	Identifier
	|  	IntegerAtom { node = new AtomNode(int.Parse($IntegerAtom.text)); }
	|	FloatAtom { node = new AtomNode(int.Parse($FloatAtom.text)); }
	|  	BooleanAtom { node = new AtomNode(int.Parse($BooleanAtom.text)); }
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





