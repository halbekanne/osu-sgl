// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g 2011-09-03 21:40:23

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


	using System.Text;
	using System.Collections.Generic;
	using SGL.Node;


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
		"IF", 
		"EXP", 
		"ID_LIST", 
		"VARDEF", 
		"ASSIGN", 
		"NEGATE", 
		"LIBMETHOD", 
		"OBJMETHOD", 
		"STRING", 
		"FORDEC", 
		"FORCOND", 
		"FORITER", 
		"STRINGNOQUOTES", 
		"PRINTLN", 
		"VARINC", 
		"VARDEC", 
		"BREAK", 
		"PARAM_TYPE_LIST", 
		"PARAM_NAME_LIST", 
		"FUNC_CALL", 
		"Identifier", 
		"IntType", 
		"BooleanType", 
		"StringType", 
		"FloatType", 
		"ObjectType", 
		"IntegerAtom", 
		"FloatAtom", 
		"BooleanAtom", 
		"SpriteAnimation", 
		"Layer", 
		"Origin", 
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
		"'='", 
		"'.'", 
		"'while'", 
		"'for'", 
		"'if'", 
		"'else'", 
		"'break'", 
		"'println'", 
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
    public const int OBJMETHOD = 13;
    public const int T__63 = 63;
    public const int Origin = 37;
    public const int SGLIDDigit = 41;
    public const int PARAM_NAME_LIST = 24;
    public const int IntType = 27;
    public const int ID_LIST = 8;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int BREAK = 22;
    public const int Identifier = 26;
    public const int FUNC_CALL = 25;
    public const int IF = 6;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int EXP = 7;
    public const int FORITER = 17;
    public const int StringType = 29;
    public const int PRINTLN = 19;
    public const int T__59 = 59;
    public const int SpriteAnimation = 35;
    public const int COMMENT = 46;
    public const int STRINGNOQUOTES = 18;
    public const int VARDEF = 9;
    public const int T__50 = 50;
    public const int BooleanType = 28;
    public const int VARDEC = 21;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__47 = 47;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int LIBMETHOD = 12;
    public const int IntegerAtom = 32;
    public const int FORDEC = 15;
    public const int FloatType = 30;
    public const int PARAM_TYPE_LIST = 23;
    public const int StringAtom = 38;
    public const int NEGATE = 11;
    public const int HEX_DIGIT = 44;
    public const int BooleanAtom = 34;
    public const int T__71 = 71;
    public const int FORCOND = 16;
    public const int WS = 45;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int UnicodeEscape = 42;
    public const int BLOCK = 4;
    public const int ASSIGN = 10;
    public const int Layer = 36;
    public const int STATEMENTS = 5;
    public const int ObjectType = 31;
    public const int T__76 = 76;
    public const int FloatAtom = 33;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int VARINC = 20;
    public const int T__73 = 73;
    public const int EscapeSequence = 39;
    public const int Letter = 40;
    public const int OctalEscape = 43;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int STRING = 14;
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


    	Scope currentScope = null;
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
            }

        	return storyboardCode;
        }
        
        
          public Dictionary<String, Function> functions = null;
          
          public SGLTreeWalker(CommonTreeNodeStream nodes, Dictionary<String, Function> fns) : this(nodes, null, fns) {
            
          }
          
          public SGLTreeWalker(CommonTreeNodeStream nds, Scope sc, Dictionary<String, Function> fns) : this(nds) {
            currentScope = sc;
            functions = fns;
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:85:1: compilationUnit returns [SGLNode node] : block ;
    public SGLNode compilationUnit() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode block1 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:86:2: ( block )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:86:4: block
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:96:1: block returns [SGLNode node] : ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:106:2: ( ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:106:4: ^( BLOCK ^( STATEMENTS ( statement )* ) )
            {
            	Match(input,BLOCK,FOLLOW_BLOCK_in_block95); 

            	Match(input, Token.DOWN, null); 
            	Match(input,STATEMENTS,FOLLOW_STATEMENTS_in_block111); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:107:24: ( statement )*
            	    do 
            	    {
            	        int alt1 = 2;
            	        int LA1_0 = input.LA(1);

            	        if ( (LA1_0 == IF || (LA1_0 >= VARDEF && LA1_0 <= ASSIGN) || LA1_0 == OBJMETHOD || (LA1_0 >= PRINTLN && LA1_0 <= BREAK) || LA1_0 == FUNC_CALL || (LA1_0 >= 57 && LA1_0 <= 58)) )
            	        {
            	            alt1 = 1;
            	        }


            	        switch (alt1) 
            	    	{
            	    		case 1 :
            	    		    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:107:25: statement
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:111:1: statement returns [SGLNode node] : ( variableDeclaration | variableAssignment | variableUnaryChangeStatement | staticMethod | objectMethod | ifStatement | whileLoop | forLoop | breakStat | functionCall );
    public SGLNode statement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode variableDeclaration3 = default(SGLNode);

        SGLNode variableAssignment4 = default(SGLNode);

        SGLNode variableUnaryChangeStatement5 = default(SGLNode);

        SGLNode staticMethod6 = default(SGLNode);

        SGLNode objectMethod7 = default(SGLNode);

        SGLNode ifStatement8 = default(SGLNode);

        SGLNode whileLoop9 = default(SGLNode);

        SGLNode forLoop10 = default(SGLNode);

        SGLNode breakStat11 = default(SGLNode);

        SGLNode functionCall12 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:113:2: ( variableDeclaration | variableAssignment | variableUnaryChangeStatement | staticMethod | objectMethod | ifStatement | whileLoop | forLoop | breakStat | functionCall )
            int alt2 = 10;
            switch ( input.LA(1) ) 
            {
            case VARDEF:
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
            case PRINTLN:
            	{
                alt2 = 4;
                }
                break;
            case OBJMETHOD:
            	{
                alt2 = 5;
                }
                break;
            case IF:
            	{
                alt2 = 6;
                }
                break;
            case 57:
            	{
                alt2 = 7;
                }
                break;
            case 58:
            	{
                alt2 = 8;
                }
                break;
            case BREAK:
            	{
                alt2 = 9;
                }
                break;
            case FUNC_CALL:
            	{
                alt2 = 10;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:113:4: variableDeclaration
                    {
                    	PushFollow(FOLLOW_variableDeclaration_in_statement155);
                    	variableDeclaration3 = variableDeclaration();
                    	state.followingStackPointer--;

                    	 node = variableDeclaration3; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:114:4: variableAssignment
                    {
                    	PushFollow(FOLLOW_variableAssignment_in_statement163);
                    	variableAssignment4 = variableAssignment();
                    	state.followingStackPointer--;

                    	 node = variableAssignment4; 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:115:4: variableUnaryChangeStatement
                    {
                    	PushFollow(FOLLOW_variableUnaryChangeStatement_in_statement171);
                    	variableUnaryChangeStatement5 = variableUnaryChangeStatement();
                    	state.followingStackPointer--;

                    	 node = variableUnaryChangeStatement5; 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:116:4: staticMethod
                    {
                    	PushFollow(FOLLOW_staticMethod_in_statement178);
                    	staticMethod6 = staticMethod();
                    	state.followingStackPointer--;

                    	 node = staticMethod6; 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:117:4: objectMethod
                    {
                    	PushFollow(FOLLOW_objectMethod_in_statement186);
                    	objectMethod7 = objectMethod();
                    	state.followingStackPointer--;

                    	 node = objectMethod7; 

                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:118:4: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_statement194);
                    	ifStatement8 = ifStatement();
                    	state.followingStackPointer--;

                    	 node = ifStatement8; 

                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:119:4: whileLoop
                    {
                    	PushFollow(FOLLOW_whileLoop_in_statement202);
                    	whileLoop9 = whileLoop();
                    	state.followingStackPointer--;

                    	 node = whileLoop9; 

                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:120:4: forLoop
                    {
                    	PushFollow(FOLLOW_forLoop_in_statement209);
                    	forLoop10 = forLoop();
                    	state.followingStackPointer--;

                    	 node = forLoop10; 

                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:121:4: breakStat
                    {
                    	PushFollow(FOLLOW_breakStat_in_statement216);
                    	breakStat11 = breakStat();
                    	state.followingStackPointer--;

                    	 node = breakStat11; 

                    }
                    break;
                case 10 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:122:6: functionCall
                    {
                    	PushFollow(FOLLOW_functionCall_in_statement225);
                    	functionCall12 = functionCall();
                    	state.followingStackPointer--;

                    	node = functionCall12;

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


    // $ANTLR start "functionCall"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:126:1: functionCall returns [SGLNode node] : ^( FUNC_CALL Identifier arguments ) ;
    public SGLNode functionCall() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier13 = null;
        List<SGLNode> arguments14 = default(List<SGLNode>);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:127:2: ( ^( FUNC_CALL Identifier arguments ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:127:4: ^( FUNC_CALL Identifier arguments )
            {
            	Match(input,FUNC_CALL,FOLLOW_FUNC_CALL_in_functionCall248); 

            	Match(input, Token.DOWN, null); 
            	Identifier13=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_functionCall250); 
            	PushFollow(FOLLOW_arguments_in_functionCall252);
            	arguments14 = arguments();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new FunctionCallNode(((Identifier13 != null) ? Identifier13.Text : null), arguments14, functions, storyboardCode); 

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
    // $ANTLR end "functionCall"


    // $ANTLR start "breakStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:130:1: breakStat returns [SGLNode node] : BREAK ;
    public SGLNode breakStat() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:131:2: ( BREAK )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:131:4: BREAK
            {
            	Match(input,BREAK,FOLLOW_BREAK_in_breakStat272); 
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


    // $ANTLR start "staticMethod"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:134:1: staticMethod returns [SGLNode node] : ^( PRINTLN expression ) ;
    public SGLNode staticMethod() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode expression15 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:135:2: ( ^( PRINTLN expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:135:4: ^( PRINTLN expression )
            {
            	Match(input,PRINTLN,FOLLOW_PRINTLN_in_staticMethod292); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_staticMethod294);
            	expression15 = expression();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new PrintlnNode(storyboardCode, expression15); 

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
    // $ANTLR end "staticMethod"


    // $ANTLR start "objectMethod"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:138:1: objectMethod returns [SGLNode node] : ^( OBJMETHOD variableName Identifier arguments ) ;
    public SGLNode objectMethod() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier17 = null;
        String variableName16 = default(String);

        List<SGLNode> arguments18 = default(List<SGLNode>);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:139:2: ( ^( OBJMETHOD variableName Identifier arguments ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:139:4: ^( OBJMETHOD variableName Identifier arguments )
            {
            	Match(input,OBJMETHOD,FOLLOW_OBJMETHOD_in_objectMethod314); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableName_in_objectMethod316);
            	variableName16 = variableName();
            	state.followingStackPointer--;

            	Identifier17=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_objectMethod318); 
            	PushFollow(FOLLOW_arguments_in_objectMethod320);
            	arguments18 = arguments();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new ObjectMehtodNode(variableName16, ((Identifier17 != null) ? Identifier17.Text : null), arguments18, currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:143:1: whileLoop returns [SGLNode node] : ^( 'while' expression block ) ;
    public SGLNode whileLoop() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode expression19 = default(SGLNode);

        SGLNode block20 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:144:2: ( ^( 'while' expression block ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:144:4: ^( 'while' expression block )
            {
            	Match(input,57,FOLLOW_57_in_whileLoop342); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_whileLoop344);
            	expression19 = expression();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_block_in_whileLoop346);
            	block20 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new WhileNode(expression19, block20); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:148:1: forLoop returns [SGLNode node] : ^( 'for' ^( FORDEC (dec= statement )? ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block ) ;
    public SGLNode forLoop() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode dec = default(SGLNode);

        SGLNode cond = default(SGLNode);

        SGLNode iter = default(SGLNode);

        SGLNode block21 = default(SGLNode);


         
          ForNode forNode = new ForNode(); 
          node = forNode;  

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:153:2: ( ^( 'for' ^( FORDEC (dec= statement )? ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:153:4: ^( 'for' ^( FORDEC (dec= statement )? ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block )
            {
            	Match(input,58,FOLLOW_58_in_forLoop373); 

            	Match(input, Token.DOWN, null); 
            	Match(input,FORDEC,FOLLOW_FORDEC_in_forLoop376); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:153:21: (dec= statement )?
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == IF || (LA3_0 >= VARDEF && LA3_0 <= ASSIGN) || LA3_0 == OBJMETHOD || (LA3_0 >= PRINTLN && LA3_0 <= BREAK) || LA3_0 == FUNC_CALL || (LA3_0 >= 57 && LA3_0 <= 58)) )
            	    {
            	        alt3 = 1;
            	    }
            	    switch (alt3) 
            	    {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:153:22: dec= statement
            	            {
            	            	PushFollow(FOLLOW_statement_in_forLoop381);
            	            	dec = statement();
            	            	state.followingStackPointer--;

            	            	 forNode.SetInit(dec); 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	Match(input,FORCOND,FOLLOW_FORCOND_in_forLoop390); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:153:82: (cond= expression )?
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == NEGATE || LA4_0 == STRING || LA4_0 == STRINGNOQUOTES || (LA4_0 >= VARINC && LA4_0 <= VARDEC) || LA4_0 == Identifier || (LA4_0 >= IntegerAtom && LA4_0 <= SpriteAnimation) || LA4_0 == 63 || (LA4_0 >= 65 && LA4_0 <= 77)) )
            	    {
            	        alt4 = 1;
            	    }
            	    switch (alt4) 
            	    {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:153:83: cond= expression
            	            {
            	            	PushFollow(FOLLOW_expression_in_forLoop395);
            	            	cond = expression();
            	            	state.followingStackPointer--;

            	            	 forNode.SetCondition(cond); 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	Match(input,FORITER,FOLLOW_FORITER_in_forLoop403); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:153:150: (iter= statement )?
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == IF || (LA5_0 >= VARDEF && LA5_0 <= ASSIGN) || LA5_0 == OBJMETHOD || (LA5_0 >= PRINTLN && LA5_0 <= BREAK) || LA5_0 == FUNC_CALL || (LA5_0 >= 57 && LA5_0 <= 58)) )
            	    {
            	        alt5 = 1;
            	    }
            	    switch (alt5) 
            	    {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:153:151: iter= statement
            	            {
            	            	PushFollow(FOLLOW_statement_in_forLoop408);
            	            	iter = statement();
            	            	state.followingStackPointer--;

            	            	 forNode.SetIteration(iter); 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	PushFollow(FOLLOW_block_in_forLoop415);
            	block21 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 forNode.SetBlock(block21); 

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
    // $ANTLR end "forLoop"


    // $ANTLR start "ifStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:158:1: ifStatement returns [SGLNode node] : ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) ;
    public SGLNode ifStatement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode b1 = default(SGLNode);

        SGLNode b2 = default(SGLNode);

        SGLNode expression22 = default(SGLNode);


         
          IfNode ifNode = new IfNode(); 
          node = ifNode; 

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:163:3: ( ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:163:6: ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? )
            {
            	Match(input,IF,FOLLOW_IF_in_ifStatement448); 

            	Match(input, Token.DOWN, null); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:164:8: ( ^( EXP expression b1= block ) )+
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

            	            if ( (LA6_3 == NEGATE || LA6_3 == STRING || LA6_3 == STRINGNOQUOTES || (LA6_3 >= VARINC && LA6_3 <= VARDEC) || LA6_3 == Identifier || (LA6_3 >= IntegerAtom && LA6_3 <= SpriteAnimation) || LA6_3 == 63 || (LA6_3 >= 65 && LA6_3 <= 77)) )
            	            {
            	                alt6 = 1;
            	            }


            	        }


            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:164:9: ^( EXP expression b1= block )
            			    {
            			    	Match(input,EXP,FOLLOW_EXP_in_ifStatement462); 

            			    	Match(input, Token.DOWN, null); 
            			    	PushFollow(FOLLOW_expression_in_ifStatement464);
            			    	expression22 = expression();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_block_in_ifStatement468);
            			    	b1 = block();
            			    	state.followingStackPointer--;


            			    	Match(input, Token.UP, null); 
            			    	 ifNode.AddChoice(expression22,b1); 

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

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:165:8: ( ^( EXP b2= block ) )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == EXP) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:165:9: ^( EXP b2= block )
            	        {
            	        	Match(input,EXP,FOLLOW_EXP_in_ifStatement488); 

            	        	Match(input, Token.DOWN, null); 
            	        	PushFollow(FOLLOW_block_in_ifStatement492);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:173:1: variableDeclaration returns [SGLNode node] : ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) );
    public SGLNode variableDeclaration() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        String variableType23 = default(String);

        String variableName24 = default(String);

        SGLNode expression25 = default(SGLNode);

        String variableType26 = default(String);

        String variableName27 = default(String);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:174:2: ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) )
            int alt8 = 2;
            alt8 = dfa8.Predict(input);
            switch (alt8) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:174:4: ^( VARDEF variableType variableName expression )
                    {
                    	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclaration534); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableType_in_variableDeclaration536);
                    	variableType23 = variableType();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_variableName_in_variableDeclaration538);
                    	variableName24 = variableName();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_variableDeclaration540);
                    	expression25 = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NewLocalVariableNode(variableType23,variableName24,expression25,currentScope); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:177:5: ^( VARDEF variableType variableName )
                    {
                    	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclaration564); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableType_in_variableDeclaration566);
                    	variableType26 = variableType();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_variableName_in_variableDeclaration568);
                    	variableName27 = variableName();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NewLocalVariableNode(variableType26,variableName27,new AtomNode(null),currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:186:1: variableAssignment returns [SGLNode node] : ^( ASSIGN variableName expression ) ;
    public SGLNode variableAssignment() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        String variableName28 = default(String);

        SGLNode expression29 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:187:2: ( ^( ASSIGN variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:187:4: ^( ASSIGN variableName expression )
            {
            	Match(input,ASSIGN,FOLLOW_ASSIGN_in_variableAssignment597); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableName_in_variableAssignment599);
            	variableName28 = variableName();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_expression_in_variableAssignment601);
            	expression29 = expression();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new AssignVariableNode(variableName28,expression29, currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:192:1: variableName returns [String txt] : Identifier ;
    public String variableName() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree Identifier30 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:193:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:193:4: Identifier
            {
            	Identifier30=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableName624); 
            	 txt = ((Identifier30 != null) ? Identifier30.Text : null); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:196:1: variableType returns [String txt] : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public String variableType() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree IntType31 = null;
        CommonTree BooleanType32 = null;
        CommonTree StringType33 = null;
        CommonTree FloatType34 = null;
        CommonTree ObjectType35 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:197:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:197:4: IntType
                    {
                    	IntType31=(CommonTree)Match(input,IntType,FOLLOW_IntType_in_variableType642); 
                    	 txt = ((IntType31 != null) ? IntType31.Text : null); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:198:4: BooleanType
                    {
                    	BooleanType32=(CommonTree)Match(input,BooleanType,FOLLOW_BooleanType_in_variableType649); 
                    	 txt = ((BooleanType32 != null) ? BooleanType32.Text : null); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:199:4: StringType
                    {
                    	StringType33=(CommonTree)Match(input,StringType,FOLLOW_StringType_in_variableType656); 
                    	 txt = ((StringType33 != null) ? StringType33.Text : null); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:200:4: FloatType
                    {
                    	FloatType34=(CommonTree)Match(input,FloatType,FOLLOW_FloatType_in_variableType663); 
                    	 txt = ((FloatType34 != null) ? FloatType34.Text : null); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:201:4: ObjectType
                    {
                    	ObjectType35=(CommonTree)Match(input,ObjectType,FOLLOW_ObjectType_in_variableType670); 
                    	 txt = ((ObjectType35 != null) ? ObjectType35.Text : null); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:211:1: expression returns [SGLNode node] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | ^( STRINGNOQUOTES Layer ) | ^( STRINGNOQUOTES Origin ) | spriteObject | lookup | variableUnaryChangeExpression );
    public SGLNode expression() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree IntegerAtom36 = null;
        CommonTree FloatAtom37 = null;
        CommonTree BooleanAtom38 = null;
        CommonTree StringAtom39 = null;
        CommonTree Layer40 = null;
        CommonTree Origin41 = null;
        SGLNode a = default(SGLNode);

        SGLNode b = default(SGLNode);

        SGLNode c = default(SGLNode);

        SGLNode spriteObject42 = default(SGLNode);

        SGLNode lookup43 = default(SGLNode);

        SGLNode variableUnaryChangeExpression44 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:212:2: ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | ^( STRINGNOQUOTES Layer ) | ^( STRINGNOQUOTES Origin ) | spriteObject | lookup | variableUnaryChangeExpression )
            int alt10 = 24;
            alt10 = dfa10.Predict(input);
            switch (alt10) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:212:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,73,FOLLOW_73_in_expression710); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression714);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression718);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MAddNode(a, b); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:213:4: ^( '-' a= expression b= expression )
                    {
                    	Match(input,74,FOLLOW_74_in_expression727); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression731);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression735);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MSubNode(a, b); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:214:4: ^( '*' a= expression b= expression )
                    {
                    	Match(input,75,FOLLOW_75_in_expression744); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression748);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression752);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MMultNode(a, b); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:215:4: ^( '/' a= expression b= expression )
                    {
                    	Match(input,76,FOLLOW_76_in_expression761); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression765);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression769);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MDivNode(a, b); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:216:4: ^( '%' a= expression b= expression )
                    {
                    	Match(input,77,FOLLOW_77_in_expression778); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression782);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression786);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MModNode(a, b); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:217:4: ^( NEGATE a= expression )
                    {
                    	Match(input,NEGATE,FOLLOW_NEGATE_in_expression795); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression799);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MNegateNode(a); 

                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:218:4: ^( '<' a= expression b= expression )
                    {
                    	Match(input,69,FOLLOW_69_in_expression808); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression812);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression816);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CLTNode(a, b); 

                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:219:4: ^( '<=' a= expression b= expression )
                    {
                    	Match(input,71,FOLLOW_71_in_expression825); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression829);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression833);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CLTEqualsNode(a, b); 

                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:220:4: ^( '>' a= expression b= expression )
                    {
                    	Match(input,70,FOLLOW_70_in_expression842); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression846);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression850);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CGTNode(a, b); 

                    }
                    break;
                case 10 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:221:4: ^( '>=' a= expression b= expression )
                    {
                    	Match(input,72,FOLLOW_72_in_expression859); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression863);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression867);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CGTEqualsNode(a, b); 

                    }
                    break;
                case 11 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:222:4: ^( '!=' a= expression b= expression )
                    {
                    	Match(input,68,FOLLOW_68_in_expression876); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression880);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression884);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CNotEqualsNode(a, b); 

                    }
                    break;
                case 12 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:223:4: ^( '==' a= expression b= expression )
                    {
                    	Match(input,67,FOLLOW_67_in_expression893); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression897);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression901);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CEqualsNode(a, b); 

                    }
                    break;
                case 13 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:224:4: ^( '&&' a= expression b= expression )
                    {
                    	Match(input,66,FOLLOW_66_in_expression910); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression914);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression918);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CAndNode(a, b); 

                    }
                    break;
                case 14 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:225:4: ^( '||' a= expression b= expression )
                    {
                    	Match(input,65,FOLLOW_65_in_expression927); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression931);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression935);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new COrNode(a, b); 

                    }
                    break;
                case 15 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:226:4: ^( '?' a= expression b= expression c= expression )
                    {
                    	Match(input,63,FOLLOW_63_in_expression944); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression948);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression952);
                    	b = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression956);
                    	c = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new TernaryNode(a, b, c); 

                    }
                    break;
                case 16 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:227:6: IntegerAtom
                    {
                    	IntegerAtom36=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_expression966); 
                    	 node = new AtomNode(int.Parse(((IntegerAtom36 != null) ? IntegerAtom36.Text : null), System.Globalization.CultureInfo.InvariantCulture)); 

                    }
                    break;
                case 17 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:228:4: FloatAtom
                    {
                    	FloatAtom37=(CommonTree)Match(input,FloatAtom,FOLLOW_FloatAtom_in_expression973); 
                    	 node = new AtomNode(Double.Parse(((FloatAtom37 != null) ? FloatAtom37.Text : null), System.Globalization.CultureInfo.InvariantCulture)); 

                    }
                    break;
                case 18 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:229:6: BooleanAtom
                    {
                    	BooleanAtom38=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression982); 
                    	 node = new AtomNode(Boolean.Parse(((BooleanAtom38 != null) ? BooleanAtom38.Text : null))); 

                    }
                    break;
                case 19 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:230:4: ^( STRING StringAtom )
                    {
                    	Match(input,STRING,FOLLOW_STRING_in_expression990); 

                    	Match(input, Token.DOWN, null); 
                    	StringAtom39=(CommonTree)Match(input,StringAtom,FOLLOW_StringAtom_in_expression992); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode((((StringAtom39 != null) ? StringAtom39.Text : null)).Substring(1, (((StringAtom39 != null) ? StringAtom39.Text : null)).Length-2)); 

                    }
                    break;
                case 20 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:231:4: ^( STRINGNOQUOTES Layer )
                    {
                    	Match(input,STRINGNOQUOTES,FOLLOW_STRINGNOQUOTES_in_expression1001); 

                    	Match(input, Token.DOWN, null); 
                    	Layer40=(CommonTree)Match(input,Layer,FOLLOW_Layer_in_expression1003); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode(((Layer40 != null) ? Layer40.Text : null)); 

                    }
                    break;
                case 21 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:232:4: ^( STRINGNOQUOTES Origin )
                    {
                    	Match(input,STRINGNOQUOTES,FOLLOW_STRINGNOQUOTES_in_expression1012); 

                    	Match(input, Token.DOWN, null); 
                    	Origin41=(CommonTree)Match(input,Origin,FOLLOW_Origin_in_expression1014); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode(((Origin41 != null) ? Origin41.Text : null)); 

                    }
                    break;
                case 22 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:233:4: spriteObject
                    {
                    	PushFollow(FOLLOW_spriteObject_in_expression1022);
                    	spriteObject42 = spriteObject();
                    	state.followingStackPointer--;

                    	 node = spriteObject42; 

                    }
                    break;
                case 23 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:234:4: lookup
                    {
                    	PushFollow(FOLLOW_lookup_in_expression1029);
                    	lookup43 = lookup();
                    	state.followingStackPointer--;

                    	 node = lookup43; 

                    }
                    break;
                case 24 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:235:4: variableUnaryChangeExpression
                    {
                    	PushFollow(FOLLOW_variableUnaryChangeExpression_in_expression1036);
                    	variableUnaryChangeExpression44 = variableUnaryChangeExpression();
                    	state.followingStackPointer--;

                    	 node = variableUnaryChangeExpression44; 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:240:1: variableUnaryChangeStatement returns [SGLNode node] : ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) );
    public SGLNode variableUnaryChangeStatement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier45 = null;
        CommonTree Identifier46 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:241:2: ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:241:4: ^( VARINC Identifier )
                    {
                    	Match(input,VARINC,FOLLOW_VARINC_in_variableUnaryChangeStatement1075); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier45=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableUnaryChangeStatement1077); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarIncNode(((Identifier45 != null) ? Identifier45.Text : null), currentScope, false); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:242:4: ^( VARDEC Identifier )
                    {
                    	Match(input,VARDEC,FOLLOW_VARDEC_in_variableUnaryChangeStatement1086); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier46=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableUnaryChangeStatement1088); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarIncNode(((Identifier46 != null) ? Identifier46.Text : null), currentScope, false); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:245:1: variableUnaryChangeExpression returns [SGLNode node] : ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) );
    public SGLNode variableUnaryChangeExpression() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier47 = null;
        CommonTree Identifier48 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:246:2: ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:246:4: ^( VARINC Identifier )
                    {
                    	Match(input,VARINC,FOLLOW_VARINC_in_variableUnaryChangeExpression1108); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier47=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableUnaryChangeExpression1110); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarIncNode(((Identifier47 != null) ? Identifier47.Text : null), currentScope, true); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:247:4: ^( VARDEC Identifier )
                    {
                    	Match(input,VARDEC,FOLLOW_VARDEC_in_variableUnaryChangeExpression1119); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier48=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableUnaryChangeExpression1121); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarIncNode(((Identifier48 != null) ? Identifier48.Text : null), currentScope, true); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:251:1: lookup returns [SGLNode node] : Identifier ;
    public SGLNode lookup() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier49 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:252:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:252:4: Identifier
            {
            	Identifier49=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_lookup1153); 
            	 node = new IdentifierNode(((Identifier49 != null) ? Identifier49.Text : null), currentScope); 

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


    // $ANTLR start "spriteObject"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:255:1: spriteObject returns [SGLNode node] : ^( SpriteAnimation arguments ) ;
    public SGLNode spriteObject() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        List<SGLNode> arguments50 = default(List<SGLNode>);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:256:2: ( ^( SpriteAnimation arguments ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:256:6: ^( SpriteAnimation arguments )
            {
            	Match(input,SpriteAnimation,FOLLOW_SpriteAnimation_in_spriteObject1182); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    PushFollow(FOLLOW_arguments_in_spriteObject1184);
            	    arguments50 = arguments();
            	    state.followingStackPointer--;


            	    Match(input, Token.UP, null); 
            	}
            	  node = new SpriteNode(arguments50); 

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
    // $ANTLR end "spriteObject"


    // $ANTLR start "arguments"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:263:1: arguments returns [List<SGLNode> list] : ( expression )* ;
    public List<SGLNode> arguments() // throws RecognitionException [1]
    {   
        List<SGLNode> list = default(List<SGLNode>);

        SGLNode expression51 = default(SGLNode);


         list = new List<SGLNode>(); 
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:265:5: ( ( expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:265:9: ( expression )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:265:9: ( expression )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == NEGATE || LA13_0 == STRING || LA13_0 == STRINGNOQUOTES || (LA13_0 >= VARINC && LA13_0 <= VARDEC) || LA13_0 == Identifier || (LA13_0 >= IntegerAtom && LA13_0 <= SpriteAnimation) || LA13_0 == 63 || (LA13_0 >= 65 && LA13_0 <= 77)) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:265:10: expression
            			    {
            			    	PushFollow(FOLLOW_expression_in_arguments1224);
            			    	expression51 = expression();
            			    	state.followingStackPointer--;

            			    	list.Add(expression51); 

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:268:1: expressionList : ( expression )+ ;
    public void expressionList() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:269:5: ( ( expression )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:269:9: ( expression )+
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:269:9: ( expression )+
            	int cnt14 = 0;
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == NEGATE || LA14_0 == STRING || LA14_0 == STRINGNOQUOTES || (LA14_0 >= VARINC && LA14_0 <= VARDEC) || LA14_0 == Identifier || (LA14_0 >= IntegerAtom && LA14_0 <= SpriteAnimation) || LA14_0 == 63 || (LA14_0 >= 65 && LA14_0 <= 77)) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:269:9: expression
            			    {
            			    	PushFollow(FOLLOW_expression_in_expressionList1247);
            			    	expression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt14 >= 1 ) goto loop14;
            		            EarlyExitException eee14 =
            		                new EarlyExitException(14, input);
            		            throw eee14;
            	    }
            	    cnt14++;
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
        return ;
    }
    // $ANTLR end "expressionList"


    // $ANTLR start "literal"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:274:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public void literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:275:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:
            {
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == StringAtom || input.LA(1) == 81 ) 
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
        "\x0b\uffff";
    const string DFA8_eofS =
        "\x0b\uffff";
    const string DFA8_minS =
        "\x01\x09\x01\x02\x01\x1b\x05\x1a\x01\x03\x02\uffff";
    const string DFA8_maxS =
        "\x01\x09\x01\x02\x01\x1f\x05\x1a\x01\x4d\x02\uffff";
    const string DFA8_acceptS =
        "\x09\uffff\x01\x02\x01\x01";
    const string DFA8_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA8_transitionS = {
            "\x01\x01",
            "\x01\x02",
            "\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07",
            "\x01\x08",
            "\x01\x08",
            "\x01\x08",
            "\x01\x08",
            "\x01\x08",
            "\x01\x09\x07\uffff\x01\x0a\x02\uffff\x01\x0a\x03\uffff\x01"+
            "\x0a\x01\uffff\x02\x0a\x04\uffff\x01\x0a\x05\uffff\x04\x0a\x1b"+
            "\uffff\x01\x0a\x01\uffff\x0d\x0a",
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
            get { return "173:1: variableDeclaration returns [SGLNode node] : ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) );"; }
        }

    }

    const string DFA10_eotS =
        "\x1b\uffff";
    const string DFA10_eofS =
        "\x1b\uffff";
    const string DFA10_minS =
        "\x01\x0b\x13\uffff\x01\x02\x03\uffff\x01\x24\x02\uffff";
    const string DFA10_maxS =
        "\x01\x4d\x13\uffff\x01\x02\x03\uffff\x01\x25\x02\uffff";
    const string DFA10_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01"+
        "\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\uffff\x01\x16\x01\x17\x01"+
        "\x18\x01\uffff\x01\x14\x01\x15";
    const string DFA10_specialS =
        "\x1b\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x01\x06\x02\uffff\x01\x13\x03\uffff\x01\x14\x01\uffff\x02"+
            "\x17\x04\uffff\x01\x16\x05\uffff\x01\x10\x01\x11\x01\x12\x01"+
            "\x15\x1b\uffff\x01\x0f\x01\uffff\x01\x0e\x01\x0d\x01\x0c\x01"+
            "\x0b\x01\x07\x01\x09\x01\x08\x01\x0a\x01\x01\x01\x02\x01\x03"+
            "\x01\x04\x01\x05",
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
            "\x01\x18",
            "",
            "",
            "",
            "\x01\x19\x01\x1a",
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
            get { return "211:1: expression returns [SGLNode node] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | ^( STRINGNOQUOTES Layer ) | ^( STRINGNOQUOTES Origin ) | spriteObject | lookup | variableUnaryChangeExpression );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_block_in_compilationUnit60 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BLOCK_in_block95 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_STATEMENTS_in_block111 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_block114 = new BitSet(new ulong[]{0x0600000002782648UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_statement155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_statement163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableUnaryChangeStatement_in_statement171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_staticMethod_in_statement178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethod_in_statement186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement202 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forLoop_in_statement209 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_breakStat_in_statement216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionCall_in_statement225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FUNC_CALL_in_functionCall248 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionCall250 = new BitSet(new ulong[]{0x8000000F04344808UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_arguments_in_functionCall252 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BREAK_in_breakStat272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PRINTLN_in_staticMethod292 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_staticMethod294 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_OBJMETHOD_in_objectMethod314 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableName_in_objectMethod316 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethod318 = new BitSet(new ulong[]{0x8000000F04344808UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_arguments_in_objectMethod320 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_57_in_whileLoop342 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop344 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_whileLoop346 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_58_in_forLoop373 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_FORDEC_in_forLoop376 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_forLoop381 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FORCOND_in_forLoop390 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop395 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FORITER_in_forLoop403 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_forLoop408 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_block_in_forLoop415 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IF_in_ifStatement448 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement462 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_ifStatement464 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement468 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement488 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement492 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclaration534 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration536 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration538 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclaration540 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclaration564 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration566 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration568 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_variableAssignment597 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableName_in_variableAssignment599 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_variableAssignment601 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName624 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_variableType642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_variableType649 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringType_in_variableType656 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatType_in_variableType663 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ObjectType_in_variableType670 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_73_in_expression710 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression714 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression718 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_74_in_expression727 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression731 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression735 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_75_in_expression744 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression748 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression752 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_76_in_expression761 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression765 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression769 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_77_in_expression778 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression782 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression786 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEGATE_in_expression795 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression799 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_69_in_expression808 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression812 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression816 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_71_in_expression825 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression829 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression833 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_70_in_expression842 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression846 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression850 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_72_in_expression859 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression863 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression867 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_68_in_expression876 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression880 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression884 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_expression893 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression897 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression901 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_66_in_expression910 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression914 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression918 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_65_in_expression927 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression931 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression935 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_63_in_expression944 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression948 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression952 = new BitSet(new ulong[]{0x8000000F04344800UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression956 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_expression966 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_expression973 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_expression982 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_expression990 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_StringAtom_in_expression992 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRINGNOQUOTES_in_expression1001 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Layer_in_expression1003 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRINGNOQUOTES_in_expression1012 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Origin_in_expression1014 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_spriteObject_in_expression1022 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookup_in_expression1029 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableUnaryChangeExpression_in_expression1036 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARINC_in_variableUnaryChangeStatement1075 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableUnaryChangeStatement1077 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEC_in_variableUnaryChangeStatement1086 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableUnaryChangeStatement1088 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARINC_in_variableUnaryChangeExpression1108 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableUnaryChangeExpression1110 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEC_in_variableUnaryChangeExpression1119 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableUnaryChangeExpression1121 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Identifier_in_lookup1153 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SpriteAnimation_in_spriteObject1182 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_arguments_in_spriteObject1184 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expression_in_arguments1224 = new BitSet(new ulong[]{0x8000000F04344802UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1247 = new BitSet(new ulong[]{0x8000000F04344802UL,0x0000000000003FFEUL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}