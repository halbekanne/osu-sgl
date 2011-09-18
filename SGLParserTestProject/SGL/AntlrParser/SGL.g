grammar SGL;

// Goal: Building an AST for SGL

options {
	output = 'AST';
	language = 'CSharp2';
	
	/* Backtracking: 
	 * 1. step - guessing: look which way to go (by trying all possible ways until it finds the right way to the exit)
	 * 2. step - executing: execute the path from step 1
	 * Only when LL fails
	 * Warning: it can turn the usual linear parsing complexity into an exponential algorithm.
	**/
	//backtrack = true; 
	
	/* Memorization:
	 * This will optimise the backtracking at the cost of more memory being used.
	**/ 
	//memoize = true;
}

tokens {
	BLOCK;
	STATEMENTS;
	AT;
	IF;
	EXP;
	ID_LIST;
	VARDEF;
	GLOBVARDEF;
	ASSIGN;
	NEGATE;
	OBJMETHOD;
	STRING;
	FORDEC;
	FORCOND;
	FORITER;
	STRINGNOQUOTES;
	VARINC;
	VARDEC;
	BREAK;
	PARAM_TYPE_LIST;
	PARAM_NAME_LIST;
	METH_CALL;
	RETURN;
}

@lexer::namespace { SGL.AntlrParser }
@parser::namespace { SGL.AntlrParser }

@lexer::header {
// -------------------------------------------------------------------------------------------------
//                This is a generated file, please don't change anything in here!
// -------------------------------------------------------------------------------------------------
}

@parser::header {
// -------------------------------------------------------------------------------------------------
//                This is a generated file, please don't change anything in here!
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using SGL;
}

@members {

        public Dictionary<String,Method> methods = new Dictionary<String,Method>();

    	private void DefineMethod(String id, Object type, Object idList, Object block) {
                // 'idList' is possibly null!  Create an empty tree in that case.  
                CommonTree idListTree = idList == null ? new CommonTree() : (CommonTree)idList;

                // 'type' is never null
                String typeString = ((CommonTree)type).ToString();

                // 'block' is never null 
                CommonTree blockTree = (CommonTree)block;

                // The method name with the exact same type of parameters after it, is the unique key 
                String key = id;

					if (idListTree.ChildCount > 0)
                    {
                        for (int a = 0; a < idListTree.GetChild(0).ChildCount; a++)
                        {
                            key += "-" + idListTree.GetChild(0).GetChild(a).ToString();
                        }
                    }
                
                Console.WriteLine("method found: " + key);
                
                //idListTree.GetChild(1).ChildCount;
                methods.Add(key, new Method(id, typeString, idListTree, blockTree));
        	}
        	
		public override void EmitErrorMessage(string msg)
            	{
                	throw new SGLCompilerException(-1, "Antlr.Parser", msg);
            	}	




	// Error reporting
	/*
    private StdErrReporter errorReporter = new StdErrReporter();
    public override void EmitErrorMessage(String msg)
    {
    	errorReporter.ReportError(msg);
    }
    */
    
	// For global variables (accessable anywhere)
	//NullableDictionnary globalVariables = new NullableDictionnary();
	
	// For main variables (accessable anywhere but methods)
	//Stack<NullableDictionnary> localVariables = new Stack<NullableDictionnary>();
	//NullableDictionnary mainVariables = new NullableDictionnary();
	
	// This should tell the statements where they have to look up variables
	//NullableDictionnary variableAccess = mainVariables;

	//String output;
	//public String GetOutput() {
	//	return output;
	//}
}


/* Parser Rules 
 * --------------------------------------------------------------------------------------------------------------------------------------------------------------
**/


// This is the starting rule, and should only contain the very first root element/statement that could appear
compilationUnit
	:	mainBlock
	;
	
mainBlock
	:	(mainStatement | methodDef)*   
     		-> ^(BLOCK ^(STATEMENTS mainStatement*)) 
     	;
     	
block
	:	statement*
		-> ^(BLOCK ^(STATEMENTS statement*))
	;
	
singleBlock
	:	semicolonStatement
		-> ^(BLOCK ^(STATEMENTS semicolonStatement))
	;
	
commonBlock
	:	singleBlock
	|	'{'! block '}'!
	;	
		 		     	
   	
methodDef
  :	'method' methodType Identifier '(' paramList? ')' commonBlock
  { DefineMethod($Identifier.text, $methodType.tree, $paramList.tree, $commonBlock.tree); }  
  ;
  
methodType
	:	variableType
	|	'void'
	;        		 	
	
mainStatement
	:	statement
	;	

semicolonStatement
	:	(variableDeclarationList // int a = 1, b = 2, c;
	|	variableAssignment // a = 4;
	|	variableUnaryChange // i++;
	|	methodCall
	|	objectMethod
	|	breakStat
	|	returnStat
	)	';'!
	;
	
oneLineStatement
	:	variableDeclarationList
	|	variableAssignment
	|	variableUnaryChange
	;	
	

statement
	//:  	variableDefinitionList
	:	semicolonStatement
	|	ifStatement
	|	atStatement
	|	whileLoop
	|	forLoop
	;

/* Statements */

// int t = 1

variableDeclarationList
	:	variableType variableDecAssignment (',' variableDecAssignment)* -> ^(VARDEF variableType variableDecAssignment)+
	|	'global' variableType variableDecAssignment (',' variableDecAssignment)* -> ^(GLOBVARDEF variableType variableDecAssignment)+
	;

variableDecAssignment
	: variableName ('=' expression)?  -> variableName expression?
	;

variableAssignment
	: variableName '=' expression  -> ^(ASSIGN variableName expression)
	;


	
	
	
	
variableName
	:	Identifier
	;	

variableType
	:	IntType
	|	BooleanType
	|	StringType
	|	FloatType
	|	ObjectType
	;


objectMethod
	:	variableName '.' Identifier '(' arguments? ')' -> ^(OBJMETHOD variableName Identifier arguments?)
	;

whileLoop
	:	'while' expression commonBlock -> ^('while' expression commonBlock)
	;
	
forLoop
	:	'for' '(' dec=oneLineStatement? ';' cond=expression? ';' iter=oneLineStatement? ')' commonBlock
	->	^('for' ^(FORDEC $dec?) ^(FORCOND $cond?) ^(FORITER $iter?) commonBlock)
	;	

ifStatement
	:	ifStat elseIfStat* elseStat? -> ^(IF ifStat elseIfStat* elseStat?)
	;
ifStat
	:	'if' expression commonBlock -> ^(EXP expression commonBlock)
	;

elseIfStat
	:	'else' 'if' expression commonBlock -> ^(EXP expression commonBlock)
	;
	
elseStat
	:	'else' commonBlock -> ^(EXP commonBlock)  
	;		
/*block
	:	'{' statement* '}' -> statement*
	;
*/

atStatement
	:	'at' expression commonBlock -> ^(AT expression commonBlock)
	;
	
breakStat
	:	'break' -> BREAK
	;

returnStat
	:	'return' expression -> ^(RETURN expression)
	;

methodCall
	:	Identifier '(' expressionList? ')' -> ^(METH_CALL Identifier expressionList?)
	;










  
    
    
    
/* Expressions */

// start rule for all sorts of expressions
expression
    :  conditionalExpression
    //|	mathExpression
    ;    
    
// Simplified if-condition, (condition ? if-expression : else-expression)    
//mathConditionalExpression
//    :   booleanExpression ( '?' (mathConditionalExpression | mathExpression) ':' (mathConditionalExpression | mathExpression) )?
//    ;
    
conditionalExpression
    :   conditionalOrExpression ( '?'^ conditionalExpression ':'! conditionalExpression )?
    ;        
       
    
// OR     
conditionalOrExpression
    :   conditionalAndExpression ( '||'^ conditionalAndExpression )*
    ;    
    
// AND    
conditionalAndExpression
    :   equalityExpression ( '&&'^ equalityExpression )*
    ;
    
// Is (not) equal to    
equalityExpression
    :   relationalExpression ( ('=='^ | '!='^) relationalExpression )*
    ;    
    
// Comparison <, > , <=, =>    
relationalExpression
    :   additiveExpression (('<'^|'>'^|'<='^|'>='^) additiveExpression)*
    ;            
    
// + / -    
additiveExpression
    :   multiplicativeExpression (('+'^|'-'^) multiplicativeExpression)*
    ;        
    
// * / / / %    
multiplicativeExpression
    :   negativeExpression
    (('*'^|'/'^|'%'^) negativeExpression)*
    ;
    
unaryExpression
    :	'++' unaryExpression
    |   '--' unaryExpression
    |   unaryExpressionNotPlusMinus
    ; 


unaryExpressionNotPlusMinus
    :   Identifier ('++' -> ^(VARINC Identifier)
	|	'--' -> ^(VARDEC Identifier))
	//'!' unaryExpression
    ;       

// Int -> Float, ...    
castExpression
    :  '(' variableType ')' unaryExpression
    ;  

// (...) / value / variable / method like rand(...)  

negativeExpression
	:	mathAtom
	|	'-' mathAtom -> ^(NEGATE mathAtom)
	|	unaryExpressionNotPlusMinus
	;

mathAtom
    :	'('! conditionalExpression ')'!
    |   IntegerAtom
    |	FloatAtom
    |   BooleanAtom
//    |	f=Float
    |   'new' Sprite '(' arguments? ')' -> ^(Sprite arguments?)
    |   'new' Animation '(' arguments? ')' -> ^(Animation arguments?)
	//|   Identifier ('.' Identifier)* arguments
	|	Identifier
	|	methodCall
	|	stringQuote
	|	Layer -> ^(STRINGNOQUOTES Layer)
	|	Origin -> ^(STRINGNOQUOTES Origin)
    ;  
    
variableUnaryChange
	:	Identifier ('++' -> ^(VARINC Identifier)
	|	'--' -> ^(VARDEC Identifier))
	;    
    
    


// arguments for methods aso.

arguments
    :    expressionList
    ;    

expressionList
    :   expression (','! expression)*
    ;

paramList
  :  variableType variableName (',' variableType variableName)* -> ^(PARAM_TYPE_LIST variableType+) ^(PARAM_NAME_LIST variableName+) 
  ; 
    
literal 
    :   IntegerAtom
    |   FloatAtom
    |   StringAtom
    |   BooleanAtom
    |   'null'
    ;    
    
    
stringQuote
	:   StringAtom -> ^(STRING StringAtom)
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

    
BooleanAtom
    :   'true'
    |   'false'
    ;
    
StringAtom
@after {
  //Text = (Text.Substring(0, Text.Length-1).Replace("\\\\(.)", "$1"));
  //setText(getText().substring(1, getText().length()-1).replaceAll("\\\\(.)", "$1"));
}
    :   '"' ( EscapeSequence | ~('\\'|'"') )* '"'
    ;  
    
   
IntType
	: 'int'
	; 
	
BooleanType
	: 'boolean'
	;	
	
StringType
	: 'string'
	;
	
FloatType
	: 'float'
	;		  
    
    
// types for Pictures/Animations    
ObjectType
	:	'Object'
	;
	
Sprite
	:	'Sprite'
	;
	
Animation
	:	'Animation'
	;		      

Layer
	:	'Background' 
	|	'Fail'
	|	'Pass'
	|	'Foreground'
	;
	
Origin
	:	'TopLeft'
	|	'TopCentre'
	|	'TopRight'
	|	'CentreLeft'
	|	'Centre'
	|	'CentreRight'
	|	'BottomLeft'
	|	'BottomCentre'
	|	'BottomRight'
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
