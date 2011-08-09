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
	:	^('+' a=expression b=expression) { node = new MAddNode($a.node, $b.node); }
	|	^('-' a=expression b=expression) { node = new MSubNode($a.node, $b.node); }
	|	^('*' a=expression b=expression) { node = new MMultNode($a.node, $b.node); }
	|	^('/' a=expression b=expression) { node = new MDivNode($a.node, $b.node); }
	|	^('%' a=expression b=expression) { node = new MModNode($a.node, $b.node); }
	|	^(NEGATE a=expression) { node = new MNegateNode($a.node); }
	|	^('<' a=expression b=expression) { node = new CLTNode($a.node, $b.node); }
	|	^('<=' a=expression b=expression) { node = new CLTEqualsNode($a.node, $b.node); }
	|	^('>' a=expression b=expression) { node = new CGTNode($a.node, $b.node); }
	|	^('>=' a=expression b=expression) { node = new CGTEqualsNode($a.node, $b.node); }
	|	^('!=' a=expression b=expression) { node = new CNotEqualsNode($a.node, $b.node); }
	|	^('==' a=expression b=expression) { node = new CEqualsNode($a.node, $b.node); }
	|	^('&&' a=expression b=expression) { node = new CAndNode($a.node, $b.node); }
	|	^('||' a=expression b=expression) { node = new COrNode($a.node, $b.node); }
	|	^('?' a=expression b=expression c=expression) { node = new TernaryNode($a.node, $b.node, $c.node); }
	|  	IntegerAtom { node = new AtomNode(int.Parse($IntegerAtom.text)); }
	|	FloatAtom { node = new AtomNode(float.Parse($FloatAtom.text)); }
	|  	BooleanAtom { node = new AtomNode(Boolean.Parse($BooleanAtom.text)); }
	|	StringAtom { node = new AtomNode($StringAtom.text); }
	|	lookup { node = $lookup.node; }
    //|	mathExpression
    ;    
    
    
lookup returns [SGLNode node]
	:	Identifier { node = new IdentifierNode($Identifier.text, currentScope); }
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





