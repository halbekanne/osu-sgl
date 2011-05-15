grammar SGL;

// Goal: Building an AST for SGL

options {
	language = 'CSharp2'; 
	
	/* Backtracking: 
	 * 1. step - guessing: look which way to go (by trying all possible ways until it finds the right way to the exit)
	 * 2. step - executing: execute the path from step 1
	 * Only when LL fails
	 * Warning: it can turn the usual linear parsing complexity into an exponential algorithm.
	**/
	backtrack = true; 
	
	/* Memorization:
	 * This will optimise the backtracking at the cost of more memory being used.
	**/ 
	memoize = true;
}

@namespace { SGL }

@members{
	String output;
	public String GetOutput() {
		return output;
	}
}


/* Parser Rules 
 * --------------------------------------------------------------------------------------------------------------------------------------------------------------
**/


// This is the starting rule, and should only contain the very first root element/statement that could appear
compilationUnit
	:	statement+
	;


statement
	: (
		localVariableDeclarationStatement 
	| 	variableAssignmentStatement
	) ';'
	;

/* Statements */

// int t = 1
localVariableDeclarationStatement
	: 	'boolean' variableName ('=' booleanExpression)?
	|	'int' variableName ('=' mathExpression {output += "Lege Variable " + $variableName.text + " an mit dem Wert " + $mathExpression.value + "\n";} )?
	;
	
// t = t + 1	
variableAssignmentStatement
	:	variableDeclaration
	;
	
	
	


// Only used for the first time declaration of a new variable
variableDeclaration
	:	variableName ('=' variableInit)?
	;
	
variableInit
	:	expression
	;	
	
variableName
	:	Identifier
	;	

variableType
	:	primitiveType
	|	classType
	;

// primitive variable types
primitiveType
    :   'boolean'
    |   'string'
    |   'int'
    |   'float'
    ;
    
// types for Pictures/Animations    
classType
	:	'Object'
	|	'Sprite'
	|	'Animation'
	;    
    
    
    
/* Expressions */

// start rule for all sorts of expressions
expression
    :   mathConditionalExpression
    |	mathExpression
    |	booleanExpression
    ;    
    
// Simplified if-condition, (condition ? if-expression : else-expression)    
mathConditionalExpression
    :   booleanExpression ( '?' (mathConditionalExpression | mathExpression) ':' (mathConditionalExpression | mathExpression) )?
    ;
    
booleanConditionalExpression
    :   booleanExpression ( '?' booleanConditionalExpression ':' booleanConditionalExpression )?
    ;     
    
mathExpression returns [int value]
	:	e = additiveExpression {$value = $e.value;}
	; 
	
booleanExpression
	:	conditionalOrExpression
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
    :   mathExpression ( ('<'|'>'|'<='|'>=') mathExpression )*
    ;            
    
// + / -    
additiveExpression returns [int value]
    :   e=multiplicativeExpression {$value = $e.value;} 
    (	'+' e=multiplicativeExpression {$value += $e.value;}
    |	'-' e=multiplicativeExpression {$value -= $e.value;}
    )*
    ;        
    
// * / / / %    
multiplicativeExpression returns [int value]
    :   e=mathAtom {$value = $e.value;} 
    (	'*' e=mathAtom {$value *= $e.value;}
    |	'/' e=mathAtom {$value /= $e.value;}
    |	'%' e=mathAtom {$value = $e.value;} 
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
    :  '(' primitiveType ')' unaryExpression
    ;  

// (...) / value / variable / method like rand(...)  
mathAtom returns [int value]
    :   '(' e=mathExpression ')' {$value = $e.value;}
    |   i=IntegerAtom {$value = Convert.ToInt32($i.text);}
//    |	f=Float
    //|   'new' creator
//    |   Identifier ('.' Identifier)* arguments
    ;    

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
    
    
    
      
    

/* Lexer Rules 
 * --------------------------------------------------------------------------------------------------------------------------------------------------------------
**/

/* Format Types */

IntegerAtom
    :	'0'..'9'+
    ;

FloatAtom
    :   ('0'..'9')+ '.' ('0'..'9')*
    |   '.' ('0'..'9')+
    |   ('0'..'9')+
    ;

StringAtom
    :  '"' ( EscapeSequence | ~('\\'|'"') )* '"'
    ;
    
BooleanAtom
    :   'true'
    |   'false'
    ;


// Use this for variable names, method names, and so on
Identifier 
    :   Letter (Letter|SGLIDDigit)*
    ;
    
    
/* Fragments */    
    

/* I found this char range in JavaCC's grammar, but Letter and Digit overlap.
   Still works, but...
 */
fragment
Letter
    :  '\u0024' |
       '\u0041'..'\u005a' |
       '\u005f' |
       '\u0061'..'\u007a' |
       '\u00c0'..'\u00d6' |
       '\u00d8'..'\u00f6' |
       '\u00f8'..'\u00ff' |
       '\u0100'..'\u1fff' |
       '\u3040'..'\u318f' |
       '\u3300'..'\u337f' |
       '\u3400'..'\u3d2d' |
       '\u4e00'..'\u9fff' |
       '\uf900'..'\ufaff'
    ;

fragment
SGLIDDigit
    :  '\u0030'..'\u0039' |
       '\u0660'..'\u0669' |
       '\u06f0'..'\u06f9' |
       '\u0966'..'\u096f' |
       '\u09e6'..'\u09ef' |
       '\u0a66'..'\u0a6f' |
       '\u0ae6'..'\u0aef' |
       '\u0b66'..'\u0b6f' |
       '\u0be7'..'\u0bef' |
       '\u0c66'..'\u0c6f' |
       '\u0ce6'..'\u0cef' |
       '\u0d66'..'\u0d6f' |
       '\u0e50'..'\u0e59' |
       '\u0ed0'..'\u0ed9' |
       '\u1040'..'\u1049'
   ;

/* Escaptin Sequences */

fragment
EscapeSequence
    :   '\\' ('b'|'t'|'n'|'f'|'r'|'\"'|'\''|'\\')
    |   UnicodeEscape
    |   OctalEscape
    ;

fragment
OctalEscape
    :   '\\' ('0'..'3') ('0'..'7') ('0'..'7')
    |   '\\' ('0'..'7') ('0'..'7')
    |   '\\' ('0'..'7')
    ;

fragment
UnicodeEscape
    :   '\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
    ;

fragment
HEX_DIGIT : ('0'..'9'|'a'..'f'|'A'..'F') ;


/* HIDDEN */

// HIDDEN Whitespace
WS  :  (' '|'\r'|'\t'|'\u000C'|'\n') {$channel=HIDDEN;}
    ;

// HIDDEN Comments
COMMENT
    :   '//' ~('\n'|'\r')* '\r'? '\n' {$channel=HIDDEN;}
    |   '/*' ( options {greedy=false;} : . )* '*/' {$channel=HIDDEN;}
    ;
