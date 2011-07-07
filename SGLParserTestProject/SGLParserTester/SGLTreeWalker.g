tree grammar SGLTreeWalker;

options {
	tokenVocab = SGL;
	language = 'CSharp2';
	ASTLabelType=CommonTree;
}

@namespace { SGL }

@header {
	using SGLParserTester;
	using System.Collections.Generic;
}

@members{
	SGLActions action = new SGLActions();

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

compilationUnit
	:	(statement)+
	;


statement
	:  	variableDefinitionList
	;

/* Statements */

// int t = 1
//action.NewLocalVariable($variableType.text,$variableName.text,$expression.text); 
variableDefinitionList
	:	^(VARDEF variableType variableName expression) { 	
		action.NewLocalVariable($variableType.txt,$variableName.txt,$expression.txt); 
	}
	//|   ^(VARDEF variableType variableName)	{ 	action.NewLocalVariable($variableType.text,$variableName.text,"boo"); }
	;

variableDefinition
	: variableName expression?
	;

localVariableDeclarationStatement
	: 	'boolean' variableName ('=' expression)?
	|	'int' variableName ('=' expression)?
	;
	
// t = t + 1	
variableAssignmentStatement
	:	variableDeclaration
	;
	
	
	


// Only used for the first time declaration of a new variable
variableDeclaration
	:	variableName ('=' expression)?
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





