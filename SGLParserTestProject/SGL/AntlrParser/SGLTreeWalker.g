tree grammar SGLTreeWalker;

options {
	tokenVocab = SGL;
	language = 'CSharp2';
	ASTLabelType=CommonTree;
}

@namespace { SGL.AntlrParser }

@header {
// -------------------------------------------------------------------------------------------------
//                This is a generated file, please don't change anything in here!
// -------------------------------------------------------------------------------------------------

using System.Text;
using System.Collections.Generic;
using SGL.Node;
using SGL.Node.Expression;
}

@members{

	Scope globalScope;
	Scope currentScope;
	
	// Random object
	Random random = new Random();
	
    private List<SGLObject> spriteObjects = new List<SGLObject>();
    
    //Debug
    //private TextBox debugConsole;
    
    //public void SetDebugTextBox(TextBox tb) {
    //	debugConsole = tb;
    //}
    
    //private StringBuilder storyboardCode = new StringBuilder();
    	
    StringBuilder storyboardCode = new StringBuilder();	
    	
    public StringBuilder GetStoryboardCode() {

    	
        // sort the sprites and animations, lowest priority first
        spriteObjects.Sort();

        foreach (SGLObject currentObject in spriteObjects) {
        	if (currentObject is Sprite)
            {
            	Sprite cSprite = (Sprite)currentObject;
                cSprite.GenerateSbCode(storyboardCode);
            }
            else if (currentObject is Animation)
            {
            	Animation cAnimation = (Animation)currentObject;
                cAnimation.GenerateSbCode(storyboardCode);
            }
        }

    	return storyboardCode;
    }
    
    
      public Dictionary<String, Method> methods = null;
      
          public SGLTreeWalker(CommonTreeNodeStream nodes, Dictionary<String, Method> mths) : this(nodes) {
            globalScope = new Scope();
            currentScope = new Scope(globalScope);
            methods = mths;
          }
          
          public SGLTreeWalker(CommonTreeNodeStream nodes, Scope sc, Dictionary<String, Method> mths) : this(nodes) {
            currentScope = sc;
            globalScope = sc.Parent();
            methods = mths;
          }
      
	public override void EmitErrorMessage(string msg)
	{
		throw new SGLCompilerException(-1, "Antlr.Parser", msg);
        }	      
	
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
  Scope scope = new Scope(currentScope); 
  currentScope = scope;
  BlockNode bn = new BlockNode(spriteObjects, currentScope); 
  node = bn;  
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
	|	variableAssignment { node = $variableAssignment.node; } // a = 4
	|	variableUnaryChangeStatement { node = $variableUnaryChangeStatement.node; }
	|	objectMethod { node = $objectMethod.node; } // a.move(100,200)
	|	ifStatement { node = $ifStatement.node; }
	|	atStatement { node = $atStatement.node; } 
	|	whileLoop { node = $whileLoop.node; }
	|	forLoop { node = $forLoop.node; }
	|	breakStat { node = $breakStat.node; }
	|	returnStat { node = $returnStat.node; }
	|   methodCall   {node = $methodCall.node;}
	;
	
atStatement returns [SGLNode node]
	:	^(AT expression block) { node = new AtNode($expression.node, $block.node); }
	;
	
returnStat returns [SGLNode node]
	:	^(RETURN expression) { node = new ReturnNode($expression.node); }
	;	
		
methodCall returns [SGLNode node]
	:	^(METH_CALL Identifier arguments) { node = new MethodCallNode($Identifier.text, $arguments.list, methods, storyboardCode, globalScope, random, $Identifier.Line); }
	;	
	
breakStat returns [SGLNode node]
	:	BREAK { node = new BreakNode(); }
	;
	
objectMethod returns [SGLNode node]
	:	^(OBJMETHOD variableName Identifier arguments)
	{ node = new ObjectMehtodNode($variableName.txt, $Identifier.text, $arguments.list, currentScope, $Identifier.Line); }
	;	
	
whileLoop returns [SGLNode node]
	:	^('while' expression block)
	{ node = new WhileNode($expression.node, $block.node); }
	;

forLoop returns [SGLNode node]
@init {
  // We have to use 2 Blocks for the for-Node to work correctly
  // Create new block for the beginning of the for-Loop
  Scope scope = new Scope(currentScope); 
  currentScope = scope;
  BlockNode bn = new BlockNode(spriteObjects, currentScope); 
  
  //Create the For-Node and add it to the block
  ForNode forNode = new ForNode();
  bn.AddStatement(forNode);
  
  // Return the block node
  node = bn;
}  
@after { 
  currentScope = currentScope.Parent(); 
} 
	:	^('for' ^(FORDEC (dec=statement { forNode.SetInit($dec.node); } )?) ^(FORCOND (cond=expression { forNode.SetCondition($cond.node); })?) ^(FORITER (iter=statement { forNode.SetIteration($iter.node); })?) block)
	{ forNode.SetBlock($block.node); }
	;


ifStatement returns [SGLNode node] 
@init  { 
  IfNode ifNode = new IfNode(); 
  node = ifNode; 
}   
  :  ^(IF   
       (^(EXP expression b1=block) { ifNode.AddChoice($expression.node,$b1.node); } )+   
       (^(EXP b2=block) { ifNode.AddChoice(new AtomNode(true),$b2.node); } )?  
     )  
  ;  	

/* Statements */

// int t = 1
//action.NewLocalVariable($variableType.text,$variableName.text,$expression.text); 
variableDeclaration returns [SGLNode node]
	:	^(VARDEF variableType variableName expression)  	
	        { node = new DeclareVariableNode($variableType.txt,$variableName.txt,$expression.node,currentScope); }
	
	| 	^(VARDEF variableType variableName)  
		{ node = new DeclareVariableNode($variableType.txt,$variableName.txt,new AtomNode(null),currentScope); }
		
	|	^(GLOBVARDEF variableType variableName expression)  	
	        { node = new DeclareVariableNode($variableType.txt,$variableName.txt,$expression.node,globalScope); }
	
	| 	^(GLOBVARDEF variableType variableName)  
		{ node = new DeclareVariableNode($variableType.txt,$variableName.txt,new AtomNode(null),globalScope); }
	;



// Only used for the first time declaration of a new variable

variableAssignment returns [SGLNode node]
	:	^(ASSIGN variableName expression)
		{ node = new AssignVariableNode($variableName.txt,$expression.node, spriteObjects, currentScope); }
	;
	
	
variableName returns [String txt]
	:	Identifier { txt = $Identifier.text; }
	;	

variableType returns [String txt]
	:	IntType { txt = $IntType.text; }
	|	BooleanType { txt = $BooleanType.text; }
	|	StringType { txt = $StringType.text; }
	|	FloatType { txt = $FloatType.text; }
	|	ObjectType { txt = $ObjectType.text; }
	;

  
    
    
    
/* Expressions */

// start rule for all sorts of expressions
expression returns [SGLNode node]
	:	^('+' a=expression b=expression) { node = new AddNode($a.node, $b.node); }
	|	^('-' a=expression b=expression) { node = new SubNode($a.node, $b.node); }
	|	^('*' a=expression b=expression) { node = new MultNode($a.node, $b.node); }
	|	^('/' a=expression b=expression) { node = new DivNode($a.node, $b.node); }
	|	^('%' a=expression b=expression) { node = new ModNode($a.node, $b.node); }
	|	^(NEGATE a=expression) { node = new NegateNode($a.node); }
	|	^('<' a=expression b=expression) { node = new LTNode($a.node, $b.node); }
	|	^('<=' a=expression b=expression) { node = new LTEqualsNode($a.node, $b.node); }
	|	^('>' a=expression b=expression) { node = new GTNode($a.node, $b.node); }
	|	^('>=' a=expression b=expression) { node = new GTEqualsNode($a.node, $b.node); }
	|	^('!=' a=expression b=expression) { node = new NotEqualsNode($a.node, $b.node); }
	|	^('==' a=expression b=expression) { node = new EqualsNode($a.node, $b.node); }
	|	^('&&' a=expression b=expression) { node = new AndNode($a.node, $b.node); }
	|	^('||' a=expression b=expression) { node = new OrNode($a.node, $b.node); }
	|	^('?' a=expression b=expression c=expression) { node = new TernaryNode($a.node, $b.node, $c.node); }
	|  	IntegerAtom { node = new AtomNode(int.Parse($IntegerAtom.text, System.Globalization.CultureInfo.InvariantCulture), $IntegerAtom.Line); }
	|	FloatAtom { node = new AtomNode(Double.Parse($FloatAtom.text, System.Globalization.CultureInfo.InvariantCulture), $FloatAtom.Line); }
	|  	BooleanAtom { node = new AtomNode(Boolean.Parse($BooleanAtom.text), $BooleanAtom.Line); }
	|	^(STRING StringAtom) { node = new AtomNode(($StringAtom.text).Substring(1, ($StringAtom.text).Length-2), $StringAtom.Line); }
	|	^(STRINGNOQUOTES Layer) { node = new AtomNode($Layer.text, $Layer.Line); }
	|	^(STRINGNOQUOTES Origin) { node = new AtomNode($Origin.text, $Origin.Line); }
	|	^(STRINGNOQUOTES LoopType) { node = new AtomNode($LoopType.text, $LoopType.Line); }
	|	sbObject { node = $sbObject.node; }
	|	lookup { node = $lookup.node; }
	|	variableUnaryChangeExpression { node = $variableUnaryChangeExpression.node; }
	|	methodCall   {node = $methodCall.node;}
    //|	mathExpression
    ;    
    
    
variableUnaryChangeStatement returns [SGLNode node]
	:	^(VARINC Identifier) { node = new VarIncNode($Identifier.text, currentScope, false, $Identifier.Line); }
	|	^(VARDEC Identifier) { node = new VarDecNode($Identifier.text, currentScope, false, $Identifier.Line); }
	;
	
variableUnaryChangeExpression returns [SGLNode node]
	:	^(VARINC Identifier) { node = new VarIncNode($Identifier.text, currentScope, true, $Identifier.Line); }
	|	^(VARDEC Identifier) { node = new VarDecNode($Identifier.text, currentScope, true, $Identifier.Line); }
	;	    
    
    
lookup returns [SGLNode node]
	:	Identifier { node = new IdentifierNode($Identifier.text, currentScope, $Identifier.Line); }
	;	    
    
sbObject returns [SGLNode node]
	:	^(Sprite arguments) {  node = new SpriteNode($arguments.list); }
	|	^(Animation arguments) {  node = new AnimationNode($arguments.list); }
	;  	  


// arguments for methods aso.
arguments returns [List<SGLNode> list]
@init { list = new List<SGLNode>(); }
    :   (expression {list.Add($expression.node); })*
    ;

expressionList
    :   expression+
    ;


    
literal 
    :   IntegerAtom
    |   FloatAtom
    |   StringAtom
    |   BooleanAtom
    |   'null'
    ;    





