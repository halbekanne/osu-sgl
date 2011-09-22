// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g 2011-09-21 12:23:35

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


// -------------------------------------------------------------------------------------------------
//                This is a generated file, please don't change anything in here!
// -------------------------------------------------------------------------------------------------

using System.Text;
using System.Collections.Generic;
using SGL.Node;
using SGL.Node.Expression;


using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  SGL.AntlrParser 
{
public partial class SGLTreeWalker : TreeParser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"BLOCK", 
		"STATEMENTS", 
		"AT", 
		"IF", 
		"EXP", 
		"ID_LIST", 
		"VARDEF", 
		"GLOBVARDEF", 
		"ASSIGN", 
		"NEGATE", 
		"OBJMETHOD", 
		"STRING", 
		"FORDEC", 
		"FORCOND", 
		"FORITER", 
		"STRINGNOQUOTES", 
		"VARINC", 
		"VARDEC", 
		"BREAK", 
		"PARAM_TYPE_LIST", 
		"PARAM_NAME_LIST", 
		"METH_CALL", 
		"RETURN", 
		"Identifier", 
		"IntType", 
		"BooleanType", 
		"StringType", 
		"FloatType", 
		"ObjectType", 
		"IntegerAtom", 
		"FloatAtom", 
		"BooleanAtom", 
		"Sprite", 
		"Animation", 
		"Layer", 
		"Origin", 
		"LoopType", 
		"StringAtom", 
		"EscapeSequence", 
		"Letter", 
		"SGLIDDigit", 
		"UnicodeEscape", 
		"OctalEscape", 
		"HEX_DIGIT", 
		"WS", 
		"COMMENT", 
		"'{'", 
		"'}'", 
		"'method'", 
		"'('", 
		"')'", 
		"'void'", 
		"';'", 
		"','", 
		"'global'", 
		"'='", 
		"'.'", 
		"'while'", 
		"'for'", 
		"'if'", 
		"'else'", 
		"'at'", 
		"'break'", 
		"'return'", 
		"'?'", 
		"':'", 
		"'||'", 
		"'&&'", 
		"'=='", 
		"'!='", 
		"'<'", 
		"'>'", 
		"'<='", 
		"'>='", 
		"'+'", 
		"'-'", 
		"'*'", 
		"'/'", 
		"'%'", 
		"'++'", 
		"'--'", 
		"'new'", 
		"'null'"
    };

    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int OBJMETHOD = 14;
    public const int T__63 = 63;
    public const int Origin = 39;
    public const int Sprite = 36;
    public const int SGLIDDigit = 44;
    public const int PARAM_NAME_LIST = 24;
    public const int IntType = 28;
    public const int T__61 = 61;
    public const int ID_LIST = 9;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int BREAK = 22;
    public const int Identifier = 27;
    public const int IF = 7;
    public const int T__55 = 55;
    public const int AT = 6;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int Animation = 37;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int EXP = 8;
    public const int FORITER = 18;
    public const int StringType = 30;
    public const int T__59 = 59;
    public const int LoopType = 40;
    public const int RETURN = 26;
    public const int COMMENT = 49;
    public const int STRINGNOQUOTES = 19;
    public const int VARDEF = 10;
    public const int T__50 = 50;
    public const int GLOBVARDEF = 11;
    public const int VARDEC = 21;
    public const int BooleanType = 29;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int IntegerAtom = 33;
    public const int FORDEC = 16;
    public const int FloatType = 31;
    public const int PARAM_TYPE_LIST = 23;
    public const int StringAtom = 41;
    public const int METH_CALL = 25;
    public const int NEGATE = 13;
    public const int HEX_DIGIT = 47;
    public const int T__85 = 85;
    public const int T__84 = 84;
    public const int T__86 = 86;
    public const int BooleanAtom = 35;
    public const int T__71 = 71;
    public const int FORCOND = 17;
    public const int WS = 48;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int UnicodeEscape = 45;
    public const int BLOCK = 4;
    public const int ASSIGN = 12;
    public const int Layer = 38;
    public const int STATEMENTS = 5;
    public const int ObjectType = 32;
    public const int T__76 = 76;
    public const int FloatAtom = 34;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int VARINC = 20;
    public const int T__73 = 73;
    public const int EscapeSequence = 42;
    public const int Letter = 43;
    public const int OctalEscape = 46;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int STRING = 15;
    public const int T__77 = 77;

    // delegates
    // delegators



        public SGLTreeWalker(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SGLTreeWalker(ITreeNodeStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        

    override public string[] TokenNames {
		get { return SGLTreeWalker.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g"; }
    }



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



    // $ANTLR start "compilationUnit"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:109:1: compilationUnit returns [SGLNode node] : block ;
    public SGLNode compilationUnit() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode block1 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:110:2: ( block )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:110:4: block
            {
            	PushFollow(FOLLOW_block_in_compilationUnit60);
            	block1 = block();
            	state.followingStackPointer--;

            	 node = block1; 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "compilationUnit"


    // $ANTLR start "block"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:120:1: block returns [SGLNode node] : ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
    public SGLNode block() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode statement2 = default(SGLNode);


         
          Scope scope = new Scope(currentScope); 
          currentScope = scope;
          BlockNode bn = new BlockNode(spriteObjects, currentScope); 
          node = bn;  

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:130:2: ( ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:130:4: ^( BLOCK ^( STATEMENTS ( statement )* ) )
            {
            	Match(input,BLOCK,FOLLOW_BLOCK_in_block95); 

            	Match(input, Token.DOWN, null); 
            	Match(input,STATEMENTS,FOLLOW_STATEMENTS_in_block111); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:131:24: ( statement )*
            	    do 
            	    {
            	        int alt1 = 2;
            	        int LA1_0 = input.LA(1);

            	        if ( ((LA1_0 >= AT && LA1_0 <= IF) || (LA1_0 >= VARDEF && LA1_0 <= ASSIGN) || LA1_0 == OBJMETHOD || (LA1_0 >= VARINC && LA1_0 <= BREAK) || (LA1_0 >= METH_CALL && LA1_0 <= RETURN) || (LA1_0 >= 61 && LA1_0 <= 62)) )
            	        {
            	            alt1 = 1;
            	        }


            	        switch (alt1) 
            	    	{
            	    		case 1 :
            	    		    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:131:25: statement
            	    		    {
            	    		    	PushFollow(FOLLOW_statement_in_block114);
            	    		    	statement2 = statement();
            	    		    	state.followingStackPointer--;

            	    		    	bn.AddStatement(statement2);

            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop1;
            	        }
            	    } while (true);

            	    loop1:
            	    	;	// Stops C# compiler whining that label 'loop1' has no statements


            	    Match(input, Token.UP, null); 
            	}

            	Match(input, Token.UP, null); 

            }

             
              currentScope = currentScope.Parent(); 

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "block"


    // $ANTLR start "statement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:135:1: statement returns [SGLNode node] : ( variableDeclaration | variableAssignment | variableUnaryChangeStatement | objectMethod | ifStatement | atStatement | whileLoop | forLoop | breakStat | returnStat | methodCall );
    public SGLNode statement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode variableDeclaration3 = default(SGLNode);

        SGLNode variableAssignment4 = default(SGLNode);

        SGLNode variableUnaryChangeStatement5 = default(SGLNode);

        SGLNode objectMethod6 = default(SGLNode);

        SGLNode ifStatement7 = default(SGLNode);

        SGLNode atStatement8 = default(SGLNode);

        SGLNode whileLoop9 = default(SGLNode);

        SGLNode forLoop10 = default(SGLNode);

        SGLNode breakStat11 = default(SGLNode);

        SGLNode returnStat12 = default(SGLNode);

        SGLNode methodCall13 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:137:2: ( variableDeclaration | variableAssignment | variableUnaryChangeStatement | objectMethod | ifStatement | atStatement | whileLoop | forLoop | breakStat | returnStat | methodCall )
            int alt2 = 11;
            switch ( input.LA(1) ) 
            {
            case VARDEF:
            case GLOBVARDEF:
            	{
                alt2 = 1;
                }
                break;
            case ASSIGN:
            	{
                alt2 = 2;
                }
                break;
            case VARINC:
            case VARDEC:
            	{
                alt2 = 3;
                }
                break;
            case OBJMETHOD:
            	{
                alt2 = 4;
                }
                break;
            case IF:
            	{
                alt2 = 5;
                }
                break;
            case AT:
            	{
                alt2 = 6;
                }
                break;
            case 61:
            	{
                alt2 = 7;
                }
                break;
            case 62:
            	{
                alt2 = 8;
                }
                break;
            case BREAK:
            	{
                alt2 = 9;
                }
                break;
            case RETURN:
            	{
                alt2 = 10;
                }
                break;
            case METH_CALL:
            	{
                alt2 = 11;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:137:4: variableDeclaration
                    {
                    	PushFollow(FOLLOW_variableDeclaration_in_statement155);
                    	variableDeclaration3 = variableDeclaration();
                    	state.followingStackPointer--;

                    	 node = variableDeclaration3; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:138:4: variableAssignment
                    {
                    	PushFollow(FOLLOW_variableAssignment_in_statement163);
                    	variableAssignment4 = variableAssignment();
                    	state.followingStackPointer--;

                    	 node = variableAssignment4; 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:139:4: variableUnaryChangeStatement
                    {
                    	PushFollow(FOLLOW_variableUnaryChangeStatement_in_statement171);
                    	variableUnaryChangeStatement5 = variableUnaryChangeStatement();
                    	state.followingStackPointer--;

                    	 node = variableUnaryChangeStatement5; 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:140:4: objectMethod
                    {
                    	PushFollow(FOLLOW_objectMethod_in_statement178);
                    	objectMethod6 = objectMethod();
                    	state.followingStackPointer--;

                    	 node = objectMethod6; 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:141:4: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_statement186);
                    	ifStatement7 = ifStatement();
                    	state.followingStackPointer--;

                    	 node = ifStatement7; 

                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:142:4: atStatement
                    {
                    	PushFollow(FOLLOW_atStatement_in_statement193);
                    	atStatement8 = atStatement();
                    	state.followingStackPointer--;

                    	 node = atStatement8; 

                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:143:4: whileLoop
                    {
                    	PushFollow(FOLLOW_whileLoop_in_statement201);
                    	whileLoop9 = whileLoop();
                    	state.followingStackPointer--;

                    	 node = whileLoop9; 

                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:144:4: forLoop
                    {
                    	PushFollow(FOLLOW_forLoop_in_statement208);
                    	forLoop10 = forLoop();
                    	state.followingStackPointer--;

                    	 node = forLoop10; 

                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:145:4: breakStat
                    {
                    	PushFollow(FOLLOW_breakStat_in_statement215);
                    	breakStat11 = breakStat();
                    	state.followingStackPointer--;

                    	 node = breakStat11; 

                    }
                    break;
                case 10 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:146:4: returnStat
                    {
                    	PushFollow(FOLLOW_returnStat_in_statement222);
                    	returnStat12 = returnStat();
                    	state.followingStackPointer--;

                    	 node = returnStat12; 

                    }
                    break;
                case 11 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:147:6: methodCall
                    {
                    	PushFollow(FOLLOW_methodCall_in_statement231);
                    	methodCall13 = methodCall();
                    	state.followingStackPointer--;

                    	node = methodCall13;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "statement"


    // $ANTLR start "atStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:150:1: atStatement returns [SGLNode node] : ^( AT expression block ) ;
    public SGLNode atStatement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode expression14 = default(SGLNode);

        SGLNode block15 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:151:2: ( ^( AT expression block ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:151:4: ^( AT expression block )
            {
            	Match(input,AT,FOLLOW_AT_in_atStatement252); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_atStatement254);
            	expression14 = expression();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_block_in_atStatement256);
            	block15 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new AtNode(expression14, block15); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "atStatement"


    // $ANTLR start "returnStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:154:1: returnStat returns [SGLNode node] : ^( RETURN expression ) ;
    public SGLNode returnStat() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode expression16 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:155:2: ( ^( RETURN expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:155:4: ^( RETURN expression )
            {
            	Match(input,RETURN,FOLLOW_RETURN_in_returnStat276); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_returnStat278);
            	expression16 = expression();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new ReturnNode(expression16); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "returnStat"


    // $ANTLR start "methodCall"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:158:1: methodCall returns [SGLNode node] : ^( METH_CALL Identifier arguments ) ;
    public SGLNode methodCall() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier17 = null;
        List<SGLNode> arguments18 = default(List<SGLNode>);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:159:2: ( ^( METH_CALL Identifier arguments ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:159:4: ^( METH_CALL Identifier arguments )
            {
            	Match(input,METH_CALL,FOLLOW_METH_CALL_in_methodCall300); 

            	Match(input, Token.DOWN, null); 
            	Identifier17=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_methodCall302); 
            	PushFollow(FOLLOW_arguments_in_methodCall304);
            	arguments18 = arguments();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new MethodCallNode(((Identifier17 != null) ? Identifier17.Text : null), arguments18, methods, storyboardCode, globalScope, random, Identifier17.Line); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "methodCall"


    // $ANTLR start "breakStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:162:1: breakStat returns [SGLNode node] : BREAK ;
    public SGLNode breakStat() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:163:2: ( BREAK )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:163:4: BREAK
            {
            	Match(input,BREAK,FOLLOW_BREAK_in_breakStat324); 
            	 node = new BreakNode(); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "breakStat"


    // $ANTLR start "objectMethod"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:166:1: objectMethod returns [SGLNode node] : ^( OBJMETHOD variableName Identifier arguments ) ;
    public SGLNode objectMethod() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier20 = null;
        String variableName19 = default(String);

        List<SGLNode> arguments21 = default(List<SGLNode>);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:167:2: ( ^( OBJMETHOD variableName Identifier arguments ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:167:4: ^( OBJMETHOD variableName Identifier arguments )
            {
            	Match(input,OBJMETHOD,FOLLOW_OBJMETHOD_in_objectMethod343); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableName_in_objectMethod345);
            	variableName19 = variableName();
            	state.followingStackPointer--;

            	Identifier20=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_objectMethod347); 
            	PushFollow(FOLLOW_arguments_in_objectMethod349);
            	arguments21 = arguments();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new ObjectMehtodNode(variableName19, ((Identifier20 != null) ? Identifier20.Text : null), arguments21, currentScope, Identifier20.Line); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "objectMethod"


    // $ANTLR start "whileLoop"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:171:1: whileLoop returns [SGLNode node] : ^( 'while' expression block ) ;
    public SGLNode whileLoop() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode expression22 = default(SGLNode);

        SGLNode block23 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:172:2: ( ^( 'while' expression block ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:172:4: ^( 'while' expression block )
            {
            	Match(input,61,FOLLOW_61_in_whileLoop371); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_whileLoop373);
            	expression22 = expression();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_block_in_whileLoop375);
            	block23 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new WhileNode(expression22, block23); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "whileLoop"


    // $ANTLR start "forLoop"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:176:1: forLoop returns [SGLNode node] : ^( 'for' ^( FORDEC (dec= statement )? ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block ) ;
    public SGLNode forLoop() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode dec = default(SGLNode);

        SGLNode cond = default(SGLNode);

        SGLNode iter = default(SGLNode);

        SGLNode block24 = default(SGLNode);



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

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:194:2: ( ^( 'for' ^( FORDEC (dec= statement )? ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:194:4: ^( 'for' ^( FORDEC (dec= statement )? ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block )
            {
            	Match(input,62,FOLLOW_62_in_forLoop408); 

            	Match(input, Token.DOWN, null); 
            	Match(input,FORDEC,FOLLOW_FORDEC_in_forLoop411); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:194:21: (dec= statement )?
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= AT && LA3_0 <= IF) || (LA3_0 >= VARDEF && LA3_0 <= ASSIGN) || LA3_0 == OBJMETHOD || (LA3_0 >= VARINC && LA3_0 <= BREAK) || (LA3_0 >= METH_CALL && LA3_0 <= RETURN) || (LA3_0 >= 61 && LA3_0 <= 62)) )
            	    {
            	        alt3 = 1;
            	    }
            	    switch (alt3) 
            	    {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:194:22: dec= statement
            	            {
            	            	PushFollow(FOLLOW_statement_in_forLoop416);
            	            	dec = statement();
            	            	state.followingStackPointer--;

            	            	 forNode.SetInit(dec); 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	Match(input,FORCOND,FOLLOW_FORCOND_in_forLoop425); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:194:82: (cond= expression )?
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == NEGATE || LA4_0 == STRING || (LA4_0 >= STRINGNOQUOTES && LA4_0 <= VARDEC) || LA4_0 == METH_CALL || LA4_0 == Identifier || (LA4_0 >= IntegerAtom && LA4_0 <= Animation) || LA4_0 == 68 || (LA4_0 >= 70 && LA4_0 <= 82)) )
            	    {
            	        alt4 = 1;
            	    }
            	    switch (alt4) 
            	    {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:194:83: cond= expression
            	            {
            	            	PushFollow(FOLLOW_expression_in_forLoop430);
            	            	cond = expression();
            	            	state.followingStackPointer--;

            	            	 forNode.SetCondition(cond); 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	Match(input,FORITER,FOLLOW_FORITER_in_forLoop438); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:194:150: (iter= statement )?
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( ((LA5_0 >= AT && LA5_0 <= IF) || (LA5_0 >= VARDEF && LA5_0 <= ASSIGN) || LA5_0 == OBJMETHOD || (LA5_0 >= VARINC && LA5_0 <= BREAK) || (LA5_0 >= METH_CALL && LA5_0 <= RETURN) || (LA5_0 >= 61 && LA5_0 <= 62)) )
            	    {
            	        alt5 = 1;
            	    }
            	    switch (alt5) 
            	    {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:194:151: iter= statement
            	            {
            	            	PushFollow(FOLLOW_statement_in_forLoop443);
            	            	iter = statement();
            	            	state.followingStackPointer--;

            	            	 forNode.SetIteration(iter); 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	PushFollow(FOLLOW_block_in_forLoop450);
            	block24 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 forNode.SetBlock(block24); 

            }

             
              currentScope = currentScope.Parent(); 

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "forLoop"


    // $ANTLR start "ifStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:199:1: ifStatement returns [SGLNode node] : ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) ;
    public SGLNode ifStatement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode b1 = default(SGLNode);

        SGLNode b2 = default(SGLNode);

        SGLNode expression25 = default(SGLNode);


         
          IfNode ifNode = new IfNode(); 
          node = ifNode; 

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:204:3: ( ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:204:6: ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? )
            {
            	Match(input,IF,FOLLOW_IF_in_ifStatement483); 

            	Match(input, Token.DOWN, null); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:205:8: ( ^( EXP expression b1= block ) )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == EXP) )
            	    {
            	        int LA6_1 = input.LA(2);

            	        if ( (LA6_1 == DOWN) )
            	        {
            	            int LA6_3 = input.LA(3);

            	            if ( (LA6_3 == NEGATE || LA6_3 == STRING || (LA6_3 >= STRINGNOQUOTES && LA6_3 <= VARDEC) || LA6_3 == METH_CALL || LA6_3 == Identifier || (LA6_3 >= IntegerAtom && LA6_3 <= Animation) || LA6_3 == 68 || (LA6_3 >= 70 && LA6_3 <= 82)) )
            	            {
            	                alt6 = 1;
            	            }


            	        }


            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:205:9: ^( EXP expression b1= block )
            			    {
            			    	Match(input,EXP,FOLLOW_EXP_in_ifStatement497); 

            			    	Match(input, Token.DOWN, null); 
            			    	PushFollow(FOLLOW_expression_in_ifStatement499);
            			    	expression25 = expression();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_block_in_ifStatement503);
            			    	b1 = block();
            			    	state.followingStackPointer--;


            			    	Match(input, Token.UP, null); 
            			    	 ifNode.AddChoice(expression25,b1); 

            			    }
            			    break;

            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            		            EarlyExitException eee6 =
            		                new EarlyExitException(6, input);
            		            throw eee6;
            	    }
            	    cnt6++;
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:206:8: ( ^( EXP b2= block ) )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == EXP) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:206:9: ^( EXP b2= block )
            	        {
            	        	Match(input,EXP,FOLLOW_EXP_in_ifStatement523); 

            	        	Match(input, Token.DOWN, null); 
            	        	PushFollow(FOLLOW_block_in_ifStatement527);
            	        	b2 = block();
            	        	state.followingStackPointer--;


            	        	Match(input, Token.UP, null); 
            	        	 ifNode.AddChoice(new AtomNode(true),b2); 

            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "ifStatement"


    // $ANTLR start "variableDeclaration"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:214:1: variableDeclaration returns [SGLNode node] : ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) | ^( GLOBVARDEF variableType variableName expression ) | ^( GLOBVARDEF variableType variableName ) );
    public SGLNode variableDeclaration() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        String variableType26 = default(String);

        String variableName27 = default(String);

        SGLNode expression28 = default(SGLNode);

        String variableType29 = default(String);

        String variableName30 = default(String);

        String variableType31 = default(String);

        String variableName32 = default(String);

        SGLNode expression33 = default(SGLNode);

        String variableType34 = default(String);

        String variableName35 = default(String);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:215:2: ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) | ^( GLOBVARDEF variableType variableName expression ) | ^( GLOBVARDEF variableType variableName ) )
            int alt8 = 4;
            alt8 = dfa8.Predict(input);
            switch (alt8) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:215:4: ^( VARDEF variableType variableName expression )
                    {
                    	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclaration569); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableType_in_variableDeclaration571);
                    	variableType26 = variableType();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_variableName_in_variableDeclaration573);
                    	variableName27 = variableName();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_variableDeclaration575);
                    	expression28 = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new DeclareVariableNode(variableType26,variableName27,expression28,currentScope); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:218:5: ^( VARDEF variableType variableName )
                    {
                    	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclaration599); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableType_in_variableDeclaration601);
                    	variableType29 = variableType();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_variableName_in_variableDeclaration603);
                    	variableName30 = variableName();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new DeclareVariableNode(variableType29,variableName30,new AtomNode(null),currentScope); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:221:4: ^( GLOBVARDEF variableType variableName expression )
                    {
                    	Match(input,GLOBVARDEF,FOLLOW_GLOBVARDEF_in_variableDeclaration619); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableType_in_variableDeclaration621);
                    	variableType31 = variableType();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_variableName_in_variableDeclaration623);
                    	variableName32 = variableName();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_variableDeclaration625);
                    	expression33 = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new DeclareVariableNode(variableType31,variableName32,expression33,globalScope); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:224:5: ^( GLOBVARDEF variableType variableName )
                    {
                    	Match(input,GLOBVARDEF,FOLLOW_GLOBVARDEF_in_variableDeclaration649); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableType_in_variableDeclaration651);
                    	variableType34 = variableType();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_variableName_in_variableDeclaration653);
                    	variableName35 = variableName();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new DeclareVariableNode(variableType34,variableName35,new AtomNode(null),globalScope); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "variableDeclaration"


    // $ANTLR start "variableAssignment"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:232:1: variableAssignment returns [SGLNode node] : ^( ASSIGN variableName expression ) ;
    public SGLNode variableAssignment() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        String variableName36 = default(String);

        SGLNode expression37 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:233:2: ( ^( ASSIGN variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:233:4: ^( ASSIGN variableName expression )
            {
            	Match(input,ASSIGN,FOLLOW_ASSIGN_in_variableAssignment680); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableName_in_variableAssignment682);
            	variableName36 = variableName();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_expression_in_variableAssignment684);
            	expression37 = expression();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new AssignVariableNode(variableName36,expression37, spriteObjects, currentScope); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "variableAssignment"


    // $ANTLR start "variableName"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:238:1: variableName returns [String txt] : Identifier ;
    public String variableName() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree Identifier38 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:239:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:239:4: Identifier
            {
            	Identifier38=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableName707); 
            	 txt = ((Identifier38 != null) ? Identifier38.Text : null); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return txt;
    }
    // $ANTLR end "variableName"


    // $ANTLR start "variableType"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:242:1: variableType returns [String txt] : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public String variableType() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree IntType39 = null;
        CommonTree BooleanType40 = null;
        CommonTree StringType41 = null;
        CommonTree FloatType42 = null;
        CommonTree ObjectType43 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:243:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
            int alt9 = 5;
            switch ( input.LA(1) ) 
            {
            case IntType:
            	{
                alt9 = 1;
                }
                break;
            case BooleanType:
            	{
                alt9 = 2;
                }
                break;
            case StringType:
            	{
                alt9 = 3;
                }
                break;
            case FloatType:
            	{
                alt9 = 4;
                }
                break;
            case ObjectType:
            	{
                alt9 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d9s0 =
            	        new NoViableAltException("", 9, 0, input);

            	    throw nvae_d9s0;
            }

            switch (alt9) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:243:4: IntType
                    {
                    	IntType39=(CommonTree)Match(input,IntType,FOLLOW_IntType_in_variableType725); 
                    	 txt = ((IntType39 != null) ? IntType39.Text : null); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:244:4: BooleanType
                    {
                    	BooleanType40=(CommonTree)Match(input,BooleanType,FOLLOW_BooleanType_in_variableType732); 
                    	 txt = ((BooleanType40 != null) ? BooleanType40.Text : null); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:245:4: StringType
                    {
                    	StringType41=(CommonTree)Match(input,StringType,FOLLOW_StringType_in_variableType739); 
                    	 txt = ((StringType41 != null) ? StringType41.Text : null); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:246:4: FloatType
                    {
                    	FloatType42=(CommonTree)Match(input,FloatType,FOLLOW_FloatType_in_variableType746); 
                    	 txt = ((FloatType42 != null) ? FloatType42.Text : null); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:247:4: ObjectType
                    {
                    	ObjectType43=(CommonTree)Match(input,ObjectType,FOLLOW_ObjectType_in_variableType753); 
                    	 txt = ((ObjectType43 != null) ? ObjectType43.Text : null); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return txt;
    }
    // $ANTLR end "variableType"


    // $ANTLR start "expression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:257:1: expression returns [SGLNode node] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | ^( STRINGNOQUOTES Layer ) | ^( STRINGNOQUOTES Origin ) | ^( STRINGNOQUOTES LoopType ) | sbObject | lookup | variableUnaryChangeExpression | methodCall );
    public SGLNode expression() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree IntegerAtom44 = null;
        CommonTree FloatAtom45 = null;
        CommonTree BooleanAtom46 = null;
        CommonTree StringAtom47 = null;
        CommonTree Layer48 = null;
        CommonTree Origin49 = null;
        CommonTree LoopType50 = null;
        SGLNode a = default(SGLNode);

        SGLNode b = default(SGLNode);

        SGLNode c = default(SGLNode);

        SGLNode sbObject51 = default(SGLNode);

        SGLNode lookup52 = default(SGLNode);

        SGLNode variableUnaryChangeExpression53 = default(SGLNode);

        SGLNode methodCall54 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:258:2: ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | ^( STRINGNOQUOTES Layer ) | ^( STRINGNOQUOTES Origin ) | ^( STRINGNOQUOTES LoopType ) | sbObject | lookup | variableUnaryChangeExpression | methodCall )
            int alt10 = 26;
            alt10 = dfa10.Predict(input);
            switch (alt10) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:258:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,78,FOLLOW_78_in_expression793); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression797);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression801);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new AddNode(a, b); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:259:4: ^( '-' a= expression b= expression )
                    {
                    	Match(input,79,FOLLOW_79_in_expression810); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression814);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression818);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new SubNode(a, b); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:260:4: ^( '*' a= expression b= expression )
                    {
                    	Match(input,80,FOLLOW_80_in_expression827); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression831);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression835);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MultNode(a, b); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:261:4: ^( '/' a= expression b= expression )
                    {
                    	Match(input,81,FOLLOW_81_in_expression844); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression848);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression852);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new DivNode(a, b); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:262:4: ^( '%' a= expression b= expression )
                    {
                    	Match(input,82,FOLLOW_82_in_expression861); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression865);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression869);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new ModNode(a, b); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:263:4: ^( NEGATE a= expression )
                    {
                    	Match(input,NEGATE,FOLLOW_NEGATE_in_expression878); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression882);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NegateNode(a); 

                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:264:4: ^( '<' a= expression b= expression )
                    {
                    	Match(input,74,FOLLOW_74_in_expression891); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression895);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression899);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new LTNode(a, b); 

                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:265:4: ^( '<=' a= expression b= expression )
                    {
                    	Match(input,76,FOLLOW_76_in_expression908); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression912);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression916);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new LTEqualsNode(a, b); 

                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:266:4: ^( '>' a= expression b= expression )
                    {
                    	Match(input,75,FOLLOW_75_in_expression925); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression929);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression933);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new GTNode(a, b); 

                    }
                    break;
                case 10 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:267:4: ^( '>=' a= expression b= expression )
                    {
                    	Match(input,77,FOLLOW_77_in_expression942); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression946);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression950);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new GTEqualsNode(a, b); 

                    }
                    break;
                case 11 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:268:4: ^( '!=' a= expression b= expression )
                    {
                    	Match(input,73,FOLLOW_73_in_expression959); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression963);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression967);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NotEqualsNode(a, b); 

                    }
                    break;
                case 12 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:269:4: ^( '==' a= expression b= expression )
                    {
                    	Match(input,72,FOLLOW_72_in_expression976); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression980);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression984);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new EqualsNode(a, b); 

                    }
                    break;
                case 13 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:270:4: ^( '&&' a= expression b= expression )
                    {
                    	Match(input,71,FOLLOW_71_in_expression993); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression997);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1001);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new AndNode(a, b); 

                    }
                    break;
                case 14 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:271:4: ^( '||' a= expression b= expression )
                    {
                    	Match(input,70,FOLLOW_70_in_expression1010); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression1014);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1018);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new OrNode(a, b); 

                    }
                    break;
                case 15 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:272:4: ^( '?' a= expression b= expression c= expression )
                    {
                    	Match(input,68,FOLLOW_68_in_expression1027); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression1031);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1035);
                    	b = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1039);
                    	c = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new TernaryNode(a, b, c); 

                    }
                    break;
                case 16 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:273:6: IntegerAtom
                    {
                    	IntegerAtom44=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_expression1049); 
                    	 node = new AtomNode(int.Parse(((IntegerAtom44 != null) ? IntegerAtom44.Text : null), System.Globalization.CultureInfo.InvariantCulture), IntegerAtom44.Line); 

                    }
                    break;
                case 17 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:274:4: FloatAtom
                    {
                    	FloatAtom45=(CommonTree)Match(input,FloatAtom,FOLLOW_FloatAtom_in_expression1056); 
                    	 node = new AtomNode(Double.Parse(((FloatAtom45 != null) ? FloatAtom45.Text : null), System.Globalization.CultureInfo.InvariantCulture), FloatAtom45.Line); 

                    }
                    break;
                case 18 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:275:6: BooleanAtom
                    {
                    	BooleanAtom46=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression1065); 
                    	 node = new AtomNode(Boolean.Parse(((BooleanAtom46 != null) ? BooleanAtom46.Text : null)), BooleanAtom46.Line); 

                    }
                    break;
                case 19 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:276:4: ^( STRING StringAtom )
                    {
                    	Match(input,STRING,FOLLOW_STRING_in_expression1073); 

                    	Match(input, Token.DOWN, null); 
                    	StringAtom47=(CommonTree)Match(input,StringAtom,FOLLOW_StringAtom_in_expression1075); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode((((StringAtom47 != null) ? StringAtom47.Text : null)).Substring(1, (((StringAtom47 != null) ? StringAtom47.Text : null)).Length-2), StringAtom47.Line); 

                    }
                    break;
                case 20 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:277:4: ^( STRINGNOQUOTES Layer )
                    {
                    	Match(input,STRINGNOQUOTES,FOLLOW_STRINGNOQUOTES_in_expression1084); 

                    	Match(input, Token.DOWN, null); 
                    	Layer48=(CommonTree)Match(input,Layer,FOLLOW_Layer_in_expression1086); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode(((Layer48 != null) ? Layer48.Text : null), Layer48.Line); 

                    }
                    break;
                case 21 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:278:4: ^( STRINGNOQUOTES Origin )
                    {
                    	Match(input,STRINGNOQUOTES,FOLLOW_STRINGNOQUOTES_in_expression1095); 

                    	Match(input, Token.DOWN, null); 
                    	Origin49=(CommonTree)Match(input,Origin,FOLLOW_Origin_in_expression1097); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode(((Origin49 != null) ? Origin49.Text : null), Origin49.Line); 

                    }
                    break;
                case 22 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:279:4: ^( STRINGNOQUOTES LoopType )
                    {
                    	Match(input,STRINGNOQUOTES,FOLLOW_STRINGNOQUOTES_in_expression1106); 

                    	Match(input, Token.DOWN, null); 
                    	LoopType50=(CommonTree)Match(input,LoopType,FOLLOW_LoopType_in_expression1108); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode(((LoopType50 != null) ? LoopType50.Text : null), LoopType50.Line); 

                    }
                    break;
                case 23 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:280:4: sbObject
                    {
                    	PushFollow(FOLLOW_sbObject_in_expression1116);
                    	sbObject51 = sbObject();
                    	state.followingStackPointer--;

                    	 node = sbObject51; 

                    }
                    break;
                case 24 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:281:4: lookup
                    {
                    	PushFollow(FOLLOW_lookup_in_expression1123);
                    	lookup52 = lookup();
                    	state.followingStackPointer--;

                    	 node = lookup52; 

                    }
                    break;
                case 25 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:282:4: variableUnaryChangeExpression
                    {
                    	PushFollow(FOLLOW_variableUnaryChangeExpression_in_expression1130);
                    	variableUnaryChangeExpression53 = variableUnaryChangeExpression();
                    	state.followingStackPointer--;

                    	 node = variableUnaryChangeExpression53; 

                    }
                    break;
                case 26 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:283:4: methodCall
                    {
                    	PushFollow(FOLLOW_methodCall_in_expression1137);
                    	methodCall54 = methodCall();
                    	state.followingStackPointer--;

                    	node = methodCall54;

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "expression"


    // $ANTLR start "variableUnaryChangeStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:288:1: variableUnaryChangeStatement returns [SGLNode node] : ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) );
    public SGLNode variableUnaryChangeStatement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier55 = null;
        CommonTree Identifier56 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:289:2: ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) )
            int alt11 = 2;
            int LA11_0 = input.LA(1);

            if ( (LA11_0 == VARINC) )
            {
                alt11 = 1;
            }
            else if ( (LA11_0 == VARDEC) )
            {
                alt11 = 2;
            }
            else 
            {
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("", 11, 0, input);

                throw nvae_d11s0;
            }
            switch (alt11) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:289:4: ^( VARINC Identifier )
                    {
                    	Match(input,VARINC,FOLLOW_VARINC_in_variableUnaryChangeStatement1178); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier55=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableUnaryChangeStatement1180); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarIncNode(((Identifier55 != null) ? Identifier55.Text : null), currentScope, false, Identifier55.Line); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:290:4: ^( VARDEC Identifier )
                    {
                    	Match(input,VARDEC,FOLLOW_VARDEC_in_variableUnaryChangeStatement1189); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier56=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableUnaryChangeStatement1191); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarDecNode(((Identifier56 != null) ? Identifier56.Text : null), currentScope, false, Identifier56.Line); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "variableUnaryChangeStatement"


    // $ANTLR start "variableUnaryChangeExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:293:1: variableUnaryChangeExpression returns [SGLNode node] : ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) );
    public SGLNode variableUnaryChangeExpression() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier57 = null;
        CommonTree Identifier58 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:294:2: ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) )
            int alt12 = 2;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == VARINC) )
            {
                alt12 = 1;
            }
            else if ( (LA12_0 == VARDEC) )
            {
                alt12 = 2;
            }
            else 
            {
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:294:4: ^( VARINC Identifier )
                    {
                    	Match(input,VARINC,FOLLOW_VARINC_in_variableUnaryChangeExpression1211); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier57=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableUnaryChangeExpression1213); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarIncNode(((Identifier57 != null) ? Identifier57.Text : null), currentScope, true, Identifier57.Line); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:295:4: ^( VARDEC Identifier )
                    {
                    	Match(input,VARDEC,FOLLOW_VARDEC_in_variableUnaryChangeExpression1222); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier58=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableUnaryChangeExpression1224); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarDecNode(((Identifier58 != null) ? Identifier58.Text : null), currentScope, true, Identifier58.Line); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "variableUnaryChangeExpression"


    // $ANTLR start "lookup"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:299:1: lookup returns [SGLNode node] : Identifier ;
    public SGLNode lookup() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier59 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:300:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:300:4: Identifier
            {
            	Identifier59=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_lookup1256); 
            	 node = new IdentifierNode(((Identifier59 != null) ? Identifier59.Text : null), currentScope, Identifier59.Line); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "lookup"


    // $ANTLR start "sbObject"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:303:1: sbObject returns [SGLNode node] : ( ^( Sprite arguments ) | ^( Animation arguments ) );
    public SGLNode sbObject() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        List<SGLNode> arguments60 = default(List<SGLNode>);

        List<SGLNode> arguments61 = default(List<SGLNode>);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:304:2: ( ^( Sprite arguments ) | ^( Animation arguments ) )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == Sprite) )
            {
                alt13 = 1;
            }
            else if ( (LA13_0 == Animation) )
            {
                alt13 = 2;
            }
            else 
            {
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:304:4: ^( Sprite arguments )
                    {
                    	Match(input,Sprite,FOLLOW_Sprite_in_sbObject1283); 

                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); 
                    	    PushFollow(FOLLOW_arguments_in_sbObject1285);
                    	    arguments60 = arguments();
                    	    state.followingStackPointer--;


                    	    Match(input, Token.UP, null); 
                    	}
                    	  node = new SpriteNode(arguments60); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:305:4: ^( Animation arguments )
                    {
                    	Match(input,Animation,FOLLOW_Animation_in_sbObject1294); 

                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); 
                    	    PushFollow(FOLLOW_arguments_in_sbObject1296);
                    	    arguments61 = arguments();
                    	    state.followingStackPointer--;


                    	    Match(input, Token.UP, null); 
                    	}
                    	  node = new AnimationNode(arguments61); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "sbObject"


    // $ANTLR start "arguments"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:310:1: arguments returns [List<SGLNode> list] : ( expression )* ;
    public List<SGLNode> arguments() // throws RecognitionException [1]
    {   
        List<SGLNode> list = default(List<SGLNode>);

        SGLNode expression62 = default(SGLNode);


         list = new List<SGLNode>(); 
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:312:5: ( ( expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:312:9: ( expression )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:312:9: ( expression )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == NEGATE || LA14_0 == STRING || (LA14_0 >= STRINGNOQUOTES && LA14_0 <= VARDEC) || LA14_0 == METH_CALL || LA14_0 == Identifier || (LA14_0 >= IntegerAtom && LA14_0 <= Animation) || LA14_0 == 68 || (LA14_0 >= 70 && LA14_0 <= 82)) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:312:10: expression
            			    {
            			    	PushFollow(FOLLOW_expression_in_arguments1332);
            			    	expression62 = expression();
            			    	state.followingStackPointer--;

            			    	list.Add(expression62); 

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return list;
    }
    // $ANTLR end "arguments"


    // $ANTLR start "expressionList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:315:1: expressionList : ( expression )+ ;
    public void expressionList() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:316:5: ( ( expression )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:316:9: ( expression )+
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:316:9: ( expression )+
            	int cnt15 = 0;
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == NEGATE || LA15_0 == STRING || (LA15_0 >= STRINGNOQUOTES && LA15_0 <= VARDEC) || LA15_0 == METH_CALL || LA15_0 == Identifier || (LA15_0 >= IntegerAtom && LA15_0 <= Animation) || LA15_0 == 68 || (LA15_0 >= 70 && LA15_0 <= 82)) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:316:9: expression
            			    {
            			    	PushFollow(FOLLOW_expression_in_expressionList1355);
            			    	expression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt15 >= 1 ) goto loop15;
            		            EarlyExitException eee15 =
            		                new EarlyExitException(15, input);
            		            throw eee15;
            	    }
            	    cnt15++;
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "expressionList"


    // $ANTLR start "literal"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:321:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public void literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:322:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:
            {
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == StringAtom || input.LA(1) == 86 ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "literal"

    // Delegated rules


   	protected DFA8 dfa8;
   	protected DFA10 dfa10;
	private void InitializeCyclicDFAs()
	{
    	this.dfa8 = new DFA8(this);
    	this.dfa10 = new DFA10(this);
	}

    const string DFA8_eotS =
        "\x15\uffff";
    const string DFA8_eofS =
        "\x15\uffff";
    const string DFA8_minS =
        "\x01\x0a\x02\x02\x02\x1c\x0a\x1b\x02\x03\x04\uffff";
    const string DFA8_maxS =
        "\x01\x0b\x02\x02\x02\x20\x0a\x1b\x02\x52\x04\uffff";
    const string DFA8_acceptS =
        "\x11\uffff\x01\x01\x01\x02\x01\x04\x01\x03";
    const string DFA8_specialS =
        "\x15\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x01\x01\x01\x02",
            "\x01\x03",
            "\x01\x04",
            "\x01\x05\x01\x06\x01\x07\x01\x08\x01\x09",
            "\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e",
            "\x01\x0f",
            "\x01\x0f",
            "\x01\x0f",
            "\x01\x0f",
            "\x01\x0f",
            "\x01\x10",
            "\x01\x10",
            "\x01\x10",
            "\x01\x10",
            "\x01\x10",
            "\x01\x12\x09\uffff\x01\x11\x01\uffff\x01\x11\x03\uffff\x03"+
            "\x11\x03\uffff\x01\x11\x01\uffff\x01\x11\x05\uffff\x05\x11\x1e"+
            "\uffff\x01\x11\x01\uffff\x0d\x11",
            "\x01\x13\x09\uffff\x01\x14\x01\uffff\x01\x14\x03\uffff\x03"+
            "\x14\x03\uffff\x01\x14\x01\uffff\x01\x14\x05\uffff\x05\x14\x1e"+
            "\uffff\x01\x14\x01\uffff\x0d\x14",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA8_eot = DFA.UnpackEncodedString(DFA8_eotS);
    static readonly short[] DFA8_eof = DFA.UnpackEncodedString(DFA8_eofS);
    static readonly char[] DFA8_min = DFA.UnpackEncodedStringToUnsignedChars(DFA8_minS);
    static readonly char[] DFA8_max = DFA.UnpackEncodedStringToUnsignedChars(DFA8_maxS);
    static readonly short[] DFA8_accept = DFA.UnpackEncodedString(DFA8_acceptS);
    static readonly short[] DFA8_special = DFA.UnpackEncodedString(DFA8_specialS);
    static readonly short[][] DFA8_transition = DFA.UnpackEncodedStringArray(DFA8_transitionS);

    protected class DFA8 : DFA
    {
        public DFA8(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 8;
            this.eot = DFA8_eot;
            this.eof = DFA8_eof;
            this.min = DFA8_min;
            this.max = DFA8_max;
            this.accept = DFA8_accept;
            this.special = DFA8_special;
            this.transition = DFA8_transition;

        }

        override public string Description
        {
            get { return "214:1: variableDeclaration returns [SGLNode node] : ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) | ^( GLOBVARDEF variableType variableName expression ) | ^( GLOBVARDEF variableType variableName ) );"; }
        }

    }

    const string DFA10_eotS =
        "\x1d\uffff";
    const string DFA10_eofS =
        "\x1d\uffff";
    const string DFA10_minS =
        "\x01\x0d\x13\uffff\x01\x02\x04\uffff\x01\x26\x03\uffff";
    const string DFA10_maxS =
        "\x01\x52\x13\uffff\x01\x02\x04\uffff\x01\x28\x03\uffff";
    const string DFA10_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01"+
        "\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\uffff\x01\x17\x01\x18\x01"+
        "\x19\x01\x1a\x01\uffff\x01\x14\x01\x15\x01\x16";
    const string DFA10_specialS =
        "\x1d\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x01\x06\x01\uffff\x01\x13\x03\uffff\x01\x14\x02\x17\x03\uffff"+
            "\x01\x18\x01\uffff\x01\x16\x05\uffff\x01\x10\x01\x11\x01\x12"+
            "\x02\x15\x1e\uffff\x01\x0f\x01\uffff\x01\x0e\x01\x0d\x01\x0c"+
            "\x01\x0b\x01\x07\x01\x09\x01\x08\x01\x0a\x01\x01\x01\x02\x01"+
            "\x03\x01\x04\x01\x05",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x19",
            "",
            "",
            "",
            "",
            "\x01\x1a\x01\x1b\x01\x1c",
            "",
            "",
            ""
    };

    static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
    static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
    static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
    static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
    static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
    static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
    static readonly short[][] DFA10_transition = DFA.UnpackEncodedStringArray(DFA10_transitionS);

    protected class DFA10 : DFA
    {
        public DFA10(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 10;
            this.eot = DFA10_eot;
            this.eof = DFA10_eof;
            this.min = DFA10_min;
            this.max = DFA10_max;
            this.accept = DFA10_accept;
            this.special = DFA10_special;
            this.transition = DFA10_transition;

        }

        override public string Description
        {
            get { return "257:1: expression returns [SGLNode node] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | ^( STRINGNOQUOTES Layer ) | ^( STRINGNOQUOTES Origin ) | ^( STRINGNOQUOTES LoopType ) | sbObject | lookup | variableUnaryChangeExpression | methodCall );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_block_in_compilationUnit60 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BLOCK_in_block95 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_STATEMENTS_in_block111 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_block114 = new BitSet(new ulong[]{0x6000000006705CC8UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_statement155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_statement163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableUnaryChangeStatement_in_statement171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethod_in_statement178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atStatement_in_statement193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forLoop_in_statement208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_breakStat_in_statement215 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_returnStat_in_statement222 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_statement231 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AT_in_atStatement252 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_atStatement254 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_atStatement256 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_RETURN_in_returnStat276 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_returnStat278 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_METH_CALL_in_methodCall300 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodCall302 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_arguments_in_methodCall304 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BREAK_in_breakStat324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJMETHOD_in_objectMethod343 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableName_in_objectMethod345 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethod347 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_arguments_in_objectMethod349 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_61_in_whileLoop371 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop373 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_whileLoop375 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_62_in_forLoop408 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_FORDEC_in_forLoop411 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_forLoop416 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FORCOND_in_forLoop425 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop430 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FORITER_in_forLoop438 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_forLoop443 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_block_in_forLoop450 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IF_in_ifStatement483 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement497 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_ifStatement499 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement503 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement523 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement527 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclaration569 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration571 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration573 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclaration575 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclaration599 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration601 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration603 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_GLOBVARDEF_in_variableDeclaration619 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration621 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration623 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclaration625 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_GLOBVARDEF_in_variableDeclaration649 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration651 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration653 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_variableAssignment680 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableName_in_variableAssignment682 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_variableAssignment684 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName707 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_variableType725 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_variableType732 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringType_in_variableType739 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatType_in_variableType746 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ObjectType_in_variableType753 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_expression793 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression797 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression801 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_79_in_expression810 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression814 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression818 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_80_in_expression827 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression831 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression835 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_81_in_expression844 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression848 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression852 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_82_in_expression861 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression865 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression869 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEGATE_in_expression878 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression882 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_74_in_expression891 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression895 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression899 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_76_in_expression908 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression912 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression916 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_75_in_expression925 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression929 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression933 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_77_in_expression942 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression946 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression950 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_73_in_expression959 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression963 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression967 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_72_in_expression976 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression980 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression984 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_71_in_expression993 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression997 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression1001 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_70_in_expression1010 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1014 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression1018 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_68_in_expression1027 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1031 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression1035 = new BitSet(new ulong[]{0x6000003E0E78FCC8UL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expression1039 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_expression1049 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_expression1056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_expression1065 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_expression1073 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_StringAtom_in_expression1075 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRINGNOQUOTES_in_expression1084 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Layer_in_expression1086 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRINGNOQUOTES_in_expression1095 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Origin_in_expression1097 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRINGNOQUOTES_in_expression1106 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_LoopType_in_expression1108 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_sbObject_in_expression1116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookup_in_expression1123 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableUnaryChangeExpression_in_expression1130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_expression1137 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARINC_in_variableUnaryChangeStatement1178 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableUnaryChangeStatement1180 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEC_in_variableUnaryChangeStatement1189 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableUnaryChangeStatement1191 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARINC_in_variableUnaryChangeExpression1211 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableUnaryChangeExpression1213 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEC_in_variableUnaryChangeExpression1222 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableUnaryChangeExpression1224 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Identifier_in_lookup1256 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Sprite_in_sbObject1283 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_arguments_in_sbObject1285 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Animation_in_sbObject1294 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_arguments_in_sbObject1296 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expression_in_arguments1332 = new BitSet(new ulong[]{0x6000003E0E78FCCAUL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1355 = new BitSet(new ulong[]{0x6000003E0E78FCCAUL,0x000000000007FFD0UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}