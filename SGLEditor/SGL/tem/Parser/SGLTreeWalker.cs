// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g 2012-05-24 13:22:24

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


// -------------------------------------------------------------------------------------------------
//                This is a generated file, please don't change anything in here!
// -------------------------------------------------------------------------------------------------

using System.Text;
using System.Collections.Generic;
using SGL.Type;
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
		"ASSIGN", 
		"STRING", 
		"INT_NEGATE", 
		"BOOL_NEGATE", 
		"VARINC", 
		"VARDEC", 
		"VARIABLE", 
		"INDEXES", 
		"LOOKUP", 
		"LIST", 
		"EXP_LIST", 
		"VAR_LIST", 
		"METH_CALL", 
		"OBJ_METH_CALL", 
		"BREAK", 
		"RETURN", 
		"AT", 
		"IF", 
		"EXP", 
		"FORDEC", 
		"FORCOND", 
		"FORITER", 
		"GLOBAL", 
		"GLOBAL_ASSIGN", 
		"Identifier", 
		"StringAtom", 
		"IntAtom", 
		"FloatAtom", 
		"BooleanAtom", 
		"LayerAtom", 
		"OriginAtom", 
		"LoopTypeAtom", 
		"ColorAtom", 
		"Null", 
		"Sprite", 
		"Animation", 
		"List", 
		"VarStartInit", 
		"Lyrics", 
		"HexDigit", 
		"EscapeSequence", 
		"UTF8Letter", 
		"UTF8Digit", 
		"Comment", 
		"WhiteSpace", 
		"'{'", 
		"'}'", 
		"';'", 
		"','", 
		"'global'", 
		"'='", 
		"'['", 
		"']'", 
		"'.'", 
		"'('", 
		"')'", 
		"'method'", 
		"'object method'", 
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
		"'^'", 
		"'!'", 
		"'++'", 
		"'--'", 
		"'new'", 
		"'break'", 
		"'return'", 
		"'while'", 
		"'for'", 
		"'if'", 
		"'else'", 
		"'at'"
    };

    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int VAR_LIST = 16;
    public const int T__63 = 63;
    public const int IntAtom = 31;
    public const int Sprite = 39;
    public const int EXP_LIST = 15;
    public const int LoopTypeAtom = 36;
    public const int T__61 = 61;
    public const int UTF8Letter = 46;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int HexDigit = 44;
    public const int BREAK = 19;
    public const int Identifier = 29;
    public const int Lyrics = 43;
    public const int IF = 22;
    public const int AT = 21;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int Animation = 40;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int Comment = 48;
    public const int EXP = 23;
    public const int FORITER = 26;
    public const int T__59 = 59;
    public const int INT_NEGATE = 7;
    public const int UTF8Digit = 47;
    public const int RETURN = 20;
    public const int WhiteSpace = 49;
    public const int T__50 = 50;
    public const int VARDEC = 10;
    public const int OriginAtom = 35;
    public const int Null = 38;
    public const int LayerAtom = 34;
    public const int GLOBAL_ASSIGN = 28;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int FORDEC = 24;
    public const int StringAtom = 30;
    public const int METH_CALL = 17;
    public const int INDEXES = 12;
    public const int ColorAtom = 37;
    public const int T__85 = 85;
    public const int T__84 = 84;
    public const int LIST = 14;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int T__89 = 89;
    public const int List = 41;
    public const int T__88 = 88;
    public const int BOOL_NEGATE = 8;
    public const int BooleanAtom = 33;
    public const int LOOKUP = 13;
    public const int T__71 = 71;
    public const int FORCOND = 25;
    public const int T__72 = 72;
    public const int VARIABLE = 11;
    public const int T__70 = 70;
    public const int BLOCK = 4;
    public const int ASSIGN = 5;
    public const int VarStartInit = 42;
    public const int OBJ_METH_CALL = 18;
    public const int T__76 = 76;
    public const int GLOBAL = 27;
    public const int FloatAtom = 32;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int VARINC = 9;
    public const int T__73 = 73;
    public const int EscapeSequence = 45;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int STRING = 6;
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
		get { return "D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g"; }
    }



    	Scope globalScope;
    	Scope currentScope;
    	
    	// Random object
        Random random = new Random();

        public void SetRandomizer(Random ran)
        {
        	this.random = ran;
        }
    	
    	// Sprite objects
        private List<SpriteObject> spriteObjects = new List<SpriteObject>();
        
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

    			//storyboardCode.AppendLine("[Events]");
                //storyboardCode.AppendLine("//Background and Video events");
                //storyboardCode.AppendLine("//Storyboard Layer 0 (Background)");
                int currentLayer = 0;
                foreach (SpriteObject currentObject in spriteObjects) {
                    while (currentObject.GetLayerNumber() > currentLayer)
                    {
                        currentLayer++;
                        /*switch (currentLayer)
                        {
                            case 1: storyboardCode.AppendLine("//Storyboard Layer 1 (Fail)"); break;
                            case 2: storyboardCode.AppendLine("//Storyboard Layer 2 (Pass)"); break;
                            case 3: storyboardCode.AppendLine("//Storyboard Layer 3 (Foreground)"); break;
                            default: throw new Exception("Undefined layer type");
                        }*/
                    }
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
                while (3 > currentLayer)
                {
                    currentLayer++;
                    /*switch (currentLayer)
                    {
                        case 1: storyboardCode.AppendLine("//Storyboard Layer 1 (Fail)"); break;
                        case 2: storyboardCode.AppendLine("//Storyboard Layer 2 (Pass)"); break;
                        case 3: storyboardCode.AppendLine("//Storyboard Layer 3 (Foreground)"); break;
                        default: throw new Exception("Undefined layer type");
                    }*/
                }

        	return storyboardCode;
        }
        
        
          public Dictionary<String, Method> methods = null;
          public Dictionary<String, ObjectMethod> objectMethods = null;
          private Boolean isMain = false;
          
              public SGLTreeWalker(CommonTreeNodeStream nodes, Dictionary<String, Method> mths, Dictionary<String, ObjectMethod> objmths) : this(nodes) {
                globalScope = new Scope();
                currentScope = new Scope(globalScope);
                methods = mths;
                objectMethods = objmths;
                isMain = true;
              }
              
              public SGLTreeWalker(CommonTreeNodeStream nodes, Scope sc, Dictionary<String, Method> mths, Dictionary<String, ObjectMethod> objmths) : this(nodes) {
                currentScope = sc;
                globalScope = sc.Parent();
                methods = mths;
                objectMethods = objmths;
              }
          
    	public override void EmitErrorMessage(string msg)
    	{
    		throw new SGLCompilerException(-1, "Antlr.Parser", msg);
        }     



    // $ANTLR start "main"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:132:1: main returns [SGLNode node] : block ;
    public SGLNode main() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode block1 = default(SGLNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:133:2: ( block )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:133:4: block
            {
            	PushFollow(FOLLOW_block_in_main69);
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
    // $ANTLR end "main"


    // $ANTLR start "block"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:137:1: block returns [SGLNode node] : ^( BLOCK ( statement )* ) ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:147:2: ( ^( BLOCK ( statement )* ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:147:4: ^( BLOCK ( statement )* )
            {
            	Match(input,BLOCK,FOLLOW_BLOCK_in_block104); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:148:10: ( statement )*
            	    do 
            	    {
            	        int alt1 = 2;
            	        int LA1_0 = input.LA(1);

            	        if ( (LA1_0 == ASSIGN || (LA1_0 >= VARINC && LA1_0 <= VARDEC) || (LA1_0 >= METH_CALL && LA1_0 <= IF) || LA1_0 == GLOBAL_ASSIGN || (LA1_0 >= 85 && LA1_0 <= 86)) )
            	        {
            	            alt1 = 1;
            	        }


            	        switch (alt1) 
            	    	{
            	    		case 1 :
            	    		    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:148:11: statement
            	    		    {
            	    		    	PushFollow(FOLLOW_statement_in_block119);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:153:1: statement returns [SGLNode node] : ( assignment | unaryExpression | methodCall | objectMethodCall | ifStatement | atStatement | whileLoop | forLoop | breakStat | returnStat );
    public SGLNode statement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode assignment3 = default(SGLNode);

        SGLNode unaryExpression4 = default(SGLNode);

        SGLNode methodCall5 = default(SGLNode);

        SGLNode objectMethodCall6 = default(SGLNode);

        SGLNode ifStatement7 = default(SGLNode);

        SGLNode atStatement8 = default(SGLNode);

        SGLNode whileLoop9 = default(SGLNode);

        SGLNode forLoop10 = default(SGLNode);

        SGLNode breakStat11 = default(SGLNode);

        SGLNode returnStat12 = default(SGLNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:155:2: ( assignment | unaryExpression | methodCall | objectMethodCall | ifStatement | atStatement | whileLoop | forLoop | breakStat | returnStat )
            int alt2 = 10;
            switch ( input.LA(1) ) 
            {
            case ASSIGN:
            case GLOBAL_ASSIGN:
            	{
                alt2 = 1;
                }
                break;
            case VARINC:
            case VARDEC:
            	{
                alt2 = 2;
                }
                break;
            case METH_CALL:
            	{
                alt2 = 3;
                }
                break;
            case OBJ_METH_CALL:
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
            case 85:
            	{
                alt2 = 7;
                }
                break;
            case 86:
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
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:155:4: assignment
                    {
                    	PushFollow(FOLLOW_assignment_in_statement163);
                    	assignment3 = assignment();
                    	state.followingStackPointer--;

                    	 node = assignment3; 

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:156:4: unaryExpression
                    {
                    	PushFollow(FOLLOW_unaryExpression_in_statement171);
                    	unaryExpression4 = unaryExpression();
                    	state.followingStackPointer--;

                    	 node = unaryExpression4; 

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:157:4: methodCall
                    {
                    	PushFollow(FOLLOW_methodCall_in_statement178);
                    	methodCall5 = methodCall();
                    	state.followingStackPointer--;

                    	 node = methodCall5; 

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:158:4: objectMethodCall
                    {
                    	PushFollow(FOLLOW_objectMethodCall_in_statement186);
                    	objectMethodCall6 = objectMethodCall();
                    	state.followingStackPointer--;

                    	 node = objectMethodCall6; 

                    }
                    break;
                case 5 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:159:4: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_statement194);
                    	ifStatement7 = ifStatement();
                    	state.followingStackPointer--;

                    	 node = ifStatement7; 

                    }
                    break;
                case 6 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:160:4: atStatement
                    {
                    	PushFollow(FOLLOW_atStatement_in_statement201);
                    	atStatement8 = atStatement();
                    	state.followingStackPointer--;

                    	 node = atStatement8; 

                    }
                    break;
                case 7 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:161:4: whileLoop
                    {
                    	PushFollow(FOLLOW_whileLoop_in_statement209);
                    	whileLoop9 = whileLoop();
                    	state.followingStackPointer--;

                    	 node = whileLoop9; 

                    }
                    break;
                case 8 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:162:4: forLoop
                    {
                    	PushFollow(FOLLOW_forLoop_in_statement216);
                    	forLoop10 = forLoop();
                    	state.followingStackPointer--;

                    	 node = forLoop10; 

                    }
                    break;
                case 9 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:163:4: breakStat
                    {
                    	PushFollow(FOLLOW_breakStat_in_statement223);
                    	breakStat11 = breakStat();
                    	state.followingStackPointer--;

                    	 node = breakStat11; 

                    }
                    break;
                case 10 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:164:4: returnStat
                    {
                    	PushFollow(FOLLOW_returnStat_in_statement230);
                    	returnStat12 = returnStat();
                    	state.followingStackPointer--;

                    	 node = returnStat12; 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:168:1: atStatement returns [SGLNode node] : ^( AT expression block ) ;
    public SGLNode atStatement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode expression13 = default(SGLNode);

        SGLNode block14 = default(SGLNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:169:2: ( ^( AT expression block ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:169:4: ^( AT expression block )
            {
            	Match(input,AT,FOLLOW_AT_in_atStatement255); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_atStatement257);
            	expression13 = expression();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_block_in_atStatement259);
            	block14 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new AtNode(expression13, block14); 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:172:1: returnStat returns [SGLNode node] : ^( RETURN ( expression )? ) ;
    public SGLNode returnStat() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode expression15 = default(SGLNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:173:2: ( ^( RETURN ( expression )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:173:4: ^( RETURN ( expression )? )
            {
            	Match(input,RETURN,FOLLOW_RETURN_in_returnStat279); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:173:13: ( expression )?
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= STRING && LA3_0 <= VARDEC) || LA3_0 == LOOKUP || (LA3_0 >= IntAtom && LA3_0 <= LoopTypeAtom) || (LA3_0 >= Null && LA3_0 <= List) || LA3_0 == 63 || (LA3_0 >= 65 && LA3_0 <= 78)) )
            	    {
            	        alt3 = 1;
            	    }
            	    switch (alt3) 
            	    {
            	        case 1 :
            	            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:173:13: expression
            	            {
            	            	PushFollow(FOLLOW_expression_in_returnStat281);
            	            	expression15 = expression();
            	            	state.followingStackPointer--;


            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	 node = new ReturnNode(expression15); 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:176:1: methodCall returns [SGLNode node] : ^( METH_CALL Identifier ( expressionList )? ) ;
    public SGLNode methodCall() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier16 = null;
        List<SGLNode> expressionList17 = default(List<SGLNode>);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:177:2: ( ^( METH_CALL Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:177:4: ^( METH_CALL Identifier ( expressionList )? )
            {
            	Match(input,METH_CALL,FOLLOW_METH_CALL_in_methodCall304); 

            	Match(input, Token.DOWN, null); 
            	Identifier16=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_methodCall306); 
            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:177:27: ( expressionList )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == EXP_LIST) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:177:27: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_methodCall308);
            	        	expressionList17 = expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); 
            	 node = new MethodCallNode(((Identifier16 != null) ? Identifier16.Text : null), expressionList17, methods, objectMethods, storyboardCode, globalScope, random, Identifier16.Line); 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:180:1: breakStat returns [SGLNode node] : BREAK ;
    public SGLNode breakStat() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:181:2: ( BREAK )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:181:4: BREAK
            {
            	Match(input,BREAK,FOLLOW_BREAK_in_breakStat329); 
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


    // $ANTLR start "objectMethodCall"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:184:1: objectMethodCall returns [SGLNode node] : ^( OBJ_METH_CALL variable ( indexes )? Identifier ( expressionList )? ) ;
    public SGLNode objectMethodCall() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier20 = null;
        String variable18 = default(String);

        List<SGLNode> indexes19 = default(List<SGLNode>);

        List<SGLNode> expressionList21 = default(List<SGLNode>);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:185:2: ( ^( OBJ_METH_CALL variable ( indexes )? Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:185:4: ^( OBJ_METH_CALL variable ( indexes )? Identifier ( expressionList )? )
            {
            	Match(input,OBJ_METH_CALL,FOLLOW_OBJ_METH_CALL_in_objectMethodCall348); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variable_in_objectMethodCall350);
            	variable18 = variable();
            	state.followingStackPointer--;

            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:185:29: ( indexes )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == INDEXES) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:185:29: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_objectMethodCall352);
            	        	indexes19 = indexes();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Identifier20=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_objectMethodCall355); 
            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:185:49: ( expressionList )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == EXP_LIST) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:185:49: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_objectMethodCall357);
            	        	expressionList21 = expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); 
            	 node = new ObjectMethodCallNode(variable18, indexes19, ((Identifier20 != null) ? Identifier20.Text : null), expressionList21, methods, objectMethods, storyboardCode, globalScope, currentScope, random, Identifier20.Line); 

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
    // $ANTLR end "objectMethodCall"


    // $ANTLR start "whileLoop"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:189:1: whileLoop returns [SGLNode node] : ^( 'while' expression block ) ;
    public SGLNode whileLoop() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode expression22 = default(SGLNode);

        SGLNode block23 = default(SGLNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:190:2: ( ^( 'while' expression block ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:190:4: ^( 'while' expression block )
            {
            	Match(input,85,FOLLOW_85_in_whileLoop380); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_whileLoop382);
            	expression22 = expression();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_block_in_whileLoop384);
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


    // $ANTLR start "ifStatement"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:194:1: ifStatement returns [SGLNode node] : ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) ;
    public SGLNode ifStatement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode b1 = default(SGLNode);

        SGLNode b2 = default(SGLNode);

        SGLNode expression24 = default(SGLNode);


         
          IfNode ifNode = new IfNode(); 
          node = ifNode; 

        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:199:3: ( ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:199:6: ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? )
            {
            	Match(input,IF,FOLLOW_IF_in_ifStatement417); 

            	Match(input, Token.DOWN, null); 
            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:200:8: ( ^( EXP expression b1= block ) )+
            	int cnt7 = 0;
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == EXP) )
            	    {
            	        int LA7_1 = input.LA(2);

            	        if ( (LA7_1 == DOWN) )
            	        {
            	            int LA7_3 = input.LA(3);

            	            if ( ((LA7_3 >= STRING && LA7_3 <= VARDEC) || LA7_3 == LOOKUP || (LA7_3 >= IntAtom && LA7_3 <= LoopTypeAtom) || (LA7_3 >= Null && LA7_3 <= List) || LA7_3 == 63 || (LA7_3 >= 65 && LA7_3 <= 78)) )
            	            {
            	                alt7 = 1;
            	            }


            	        }


            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:200:9: ^( EXP expression b1= block )
            			    {
            			    	Match(input,EXP,FOLLOW_EXP_in_ifStatement431); 

            			    	Match(input, Token.DOWN, null); 
            			    	PushFollow(FOLLOW_expression_in_ifStatement433);
            			    	expression24 = expression();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_block_in_ifStatement437);
            			    	b1 = block();
            			    	state.followingStackPointer--;


            			    	Match(input, Token.UP, null); 
            			    	 ifNode.AddChoice(expression24,b1); 

            			    }
            			    break;

            			default:
            			    if ( cnt7 >= 1 ) goto loop7;
            		            EarlyExitException eee7 =
            		                new EarlyExitException(7, input);
            		            throw eee7;
            	    }
            	    cnt7++;
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements

            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:201:8: ( ^( EXP b2= block ) )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == EXP) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:201:9: ^( EXP b2= block )
            	        {
            	        	Match(input,EXP,FOLLOW_EXP_in_ifStatement457); 

            	        	Match(input, Token.DOWN, null); 
            	        	PushFollow(FOLLOW_block_in_ifStatement461);
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


    // $ANTLR start "forLoop"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:205:1: forLoop returns [SGLNode node] : ^( 'for' ^( FORDEC (dec= statement )? ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block ) ;
    public SGLNode forLoop() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode dec = default(SGLNode);

        SGLNode cond = default(SGLNode);

        SGLNode iter = default(SGLNode);

        SGLNode block25 = default(SGLNode);



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
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:2: ( ^( 'for' ^( FORDEC (dec= statement )? ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:4: ^( 'for' ^( FORDEC (dec= statement )? ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block )
            {
            	Match(input,86,FOLLOW_86_in_forLoop510); 

            	Match(input, Token.DOWN, null); 
            	Match(input,FORDEC,FOLLOW_FORDEC_in_forLoop513); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:21: (dec= statement )?
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == ASSIGN || (LA9_0 >= VARINC && LA9_0 <= VARDEC) || (LA9_0 >= METH_CALL && LA9_0 <= IF) || LA9_0 == GLOBAL_ASSIGN || (LA9_0 >= 85 && LA9_0 <= 86)) )
            	    {
            	        alt9 = 1;
            	    }
            	    switch (alt9) 
            	    {
            	        case 1 :
            	            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:22: dec= statement
            	            {
            	            	PushFollow(FOLLOW_statement_in_forLoop518);
            	            	dec = statement();
            	            	state.followingStackPointer--;

            	            	 forNode.SetInit(dec); 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	Match(input,FORCOND,FOLLOW_FORCOND_in_forLoop527); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:82: (cond= expression )?
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= STRING && LA10_0 <= VARDEC) || LA10_0 == LOOKUP || (LA10_0 >= IntAtom && LA10_0 <= LoopTypeAtom) || (LA10_0 >= Null && LA10_0 <= List) || LA10_0 == 63 || (LA10_0 >= 65 && LA10_0 <= 78)) )
            	    {
            	        alt10 = 1;
            	    }
            	    switch (alt10) 
            	    {
            	        case 1 :
            	            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:83: cond= expression
            	            {
            	            	PushFollow(FOLLOW_expression_in_forLoop532);
            	            	cond = expression();
            	            	state.followingStackPointer--;

            	            	 forNode.SetCondition(cond); 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	Match(input,FORITER,FOLLOW_FORITER_in_forLoop540); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:150: (iter= statement )?
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == ASSIGN || (LA11_0 >= VARINC && LA11_0 <= VARDEC) || (LA11_0 >= METH_CALL && LA11_0 <= IF) || LA11_0 == GLOBAL_ASSIGN || (LA11_0 >= 85 && LA11_0 <= 86)) )
            	    {
            	        alt11 = 1;
            	    }
            	    switch (alt11) 
            	    {
            	        case 1 :
            	            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:151: iter= statement
            	            {
            	            	PushFollow(FOLLOW_statement_in_forLoop545);
            	            	iter = statement();
            	            	state.followingStackPointer--;

            	            	 forNode.SetIteration(iter); 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	PushFollow(FOLLOW_block_in_forLoop552);
            	block25 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 forNode.SetBlock(block25); 

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


    // $ANTLR start "expressionList"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:228:1: expressionList returns [List<SGLNode> list] : ^( EXP_LIST ( expression )+ ) ;
    public List<SGLNode> expressionList() // throws RecognitionException [1]
    {   
        List<SGLNode> list = default(List<SGLNode>);

        SGLNode expression26 = default(SGLNode);


         list = new List<SGLNode>(); 
        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:230:5: ( ^( EXP_LIST ( expression )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:230:7: ^( EXP_LIST ( expression )+ )
            {
            	Match(input,EXP_LIST,FOLLOW_EXP_LIST_in_expressionList584); 

            	Match(input, Token.DOWN, null); 
            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:231:7: ( expression )+
            	int cnt12 = 0;
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= STRING && LA12_0 <= VARDEC) || LA12_0 == LOOKUP || (LA12_0 >= IntAtom && LA12_0 <= LoopTypeAtom) || (LA12_0 >= Null && LA12_0 <= List) || LA12_0 == 63 || (LA12_0 >= 65 && LA12_0 <= 78)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:231:8: expression
            			    {
            			    	PushFollow(FOLLOW_expression_in_expressionList596);
            			    	expression26 = expression();
            			    	state.followingStackPointer--;

            			    	list.Add(expression26);

            			    }
            			    break;

            			default:
            			    if ( cnt12 >= 1 ) goto loop12;
            		            EarlyExitException eee12 =
            		                new EarlyExitException(12, input);
            		            throw eee12;
            	    }
            	    cnt12++;
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


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
        return list;
    }
    // $ANTLR end "expressionList"


    // $ANTLR start "indexes"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:235:1: indexes returns [List<SGLNode> list] : ^( INDEXES ( expression )+ ) ;
    public List<SGLNode> indexes() // throws RecognitionException [1]
    {   
        List<SGLNode> list = default(List<SGLNode>);

        SGLNode expression27 = default(SGLNode);


         list = new List<SGLNode>(); 
        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:237:3: ( ^( INDEXES ( expression )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:237:6: ^( INDEXES ( expression )+ )
            {
            	Match(input,INDEXES,FOLLOW_INDEXES_in_indexes634); 

            	Match(input, Token.DOWN, null); 
            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:238:5: ( expression )+
            	int cnt13 = 0;
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= STRING && LA13_0 <= VARDEC) || LA13_0 == LOOKUP || (LA13_0 >= IntAtom && LA13_0 <= LoopTypeAtom) || (LA13_0 >= Null && LA13_0 <= List) || LA13_0 == 63 || (LA13_0 >= 65 && LA13_0 <= 78)) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:238:6: expression
            			    {
            			    	PushFollow(FOLLOW_expression_in_indexes642);
            			    	expression27 = expression();
            			    	state.followingStackPointer--;

            			    	list.Add(expression27);

            			    }
            			    break;

            			default:
            			    if ( cnt13 >= 1 ) goto loop13;
            		            EarlyExitException eee13 =
            		                new EarlyExitException(13, input);
            		            throw eee13;
            	    }
            	    cnt13++;
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements


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
        return list;
    }
    // $ANTLR end "indexes"


    // $ANTLR start "variable"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:242:1: variable returns [String txt] : Identifier ;
    public String variable() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree Identifier28 = null;

        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:243:2: ( Identifier )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:243:4: Identifier
            {
            	Identifier28=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variable673); 
            	 txt = ((Identifier28 != null) ? Identifier28.Text : null); 

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
    // $ANTLR end "variable"


    // $ANTLR start "assignment"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:246:1: assignment returns [SGLNode node] : ( ^( ASSIGN variable ( indexes )? ( expression )? ) | ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? ) );
    public SGLNode assignment() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        String variable29 = default(String);

        List<SGLNode> indexes30 = default(List<SGLNode>);

        SGLNode expression31 = default(SGLNode);

        String variable32 = default(String);

        List<SGLNode> indexes33 = default(List<SGLNode>);

        SGLNode expression34 = default(SGLNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:247:2: ( ^( ASSIGN variable ( indexes )? ( expression )? ) | ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? ) )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == ASSIGN) )
            {
                alt18 = 1;
            }
            else if ( (LA18_0 == GLOBAL_ASSIGN) )
            {
                alt18 = 2;
            }
            else 
            {
                NoViableAltException nvae_d18s0 =
                    new NoViableAltException("", 18, 0, input);

                throw nvae_d18s0;
            }
            switch (alt18) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:247:4: ^( ASSIGN variable ( indexes )? ( expression )? )
                    {
                    	Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment692); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variable_in_assignment694);
                    	variable29 = variable();
                    	state.followingStackPointer--;

                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:247:22: ( indexes )?
                    	int alt14 = 2;
                    	int LA14_0 = input.LA(1);

                    	if ( (LA14_0 == INDEXES) )
                    	{
                    	    alt14 = 1;
                    	}
                    	switch (alt14) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:247:22: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_assignment696);
                    	        	indexes30 = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}

                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:247:31: ( expression )?
                    	int alt15 = 2;
                    	int LA15_0 = input.LA(1);

                    	if ( ((LA15_0 >= STRING && LA15_0 <= VARDEC) || LA15_0 == LOOKUP || (LA15_0 >= IntAtom && LA15_0 <= LoopTypeAtom) || (LA15_0 >= Null && LA15_0 <= List) || LA15_0 == 63 || (LA15_0 >= 65 && LA15_0 <= 78)) )
                    	{
                    	    alt15 = 1;
                    	}
                    	switch (alt15) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:247:31: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_assignment699);
                    	        	expression31 = expression();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	 node = new AssignVariableNode(variable29,indexes30,expression31,spriteObjects,currentScope); 

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:250:4: ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? )
                    {
                    	Match(input,GLOBAL_ASSIGN,FOLLOW_GLOBAL_ASSIGN_in_assignment724); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variable_in_assignment726);
                    	variable32 = variable();
                    	state.followingStackPointer--;

                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:250:29: ( indexes )?
                    	int alt16 = 2;
                    	int LA16_0 = input.LA(1);

                    	if ( (LA16_0 == INDEXES) )
                    	{
                    	    alt16 = 1;
                    	}
                    	switch (alt16) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:250:29: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_assignment728);
                    	        	indexes33 = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}

                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:250:38: ( expression )?
                    	int alt17 = 2;
                    	int LA17_0 = input.LA(1);

                    	if ( ((LA17_0 >= STRING && LA17_0 <= VARDEC) || LA17_0 == LOOKUP || (LA17_0 >= IntAtom && LA17_0 <= LoopTypeAtom) || (LA17_0 >= Null && LA17_0 <= List) || LA17_0 == 63 || (LA17_0 >= 65 && LA17_0 <= 78)) )
                    	{
                    	    alt17 = 1;
                    	}
                    	switch (alt17) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:250:38: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_assignment731);
                    	        	expression34 = expression();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	 node = new AssignVariableNode(variable32,indexes33,expression34,spriteObjects,globalScope); 

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
    // $ANTLR end "assignment"


    // $ANTLR start "expression"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:255:1: expression returns [SGLNode node] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( '^' a= expression b= expression ) | ^( INT_NEGATE a= expression ) | ^( BOOL_NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | LayerAtom | OriginAtom | LoopTypeAtom | Null | instantiateClass | lookup | unaryExpression );
    public SGLNode expression() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree IntAtom35 = null;
        CommonTree FloatAtom36 = null;
        CommonTree BooleanAtom37 = null;
        CommonTree StringAtom38 = null;
        CommonTree LayerAtom39 = null;
        CommonTree OriginAtom40 = null;
        CommonTree LoopTypeAtom41 = null;
        CommonTree Null42 = null;
        SGLNode a = default(SGLNode);

        SGLNode b = default(SGLNode);

        SGLNode c = default(SGLNode);

        SGLNode instantiateClass43 = default(SGLNode);

        SGLNode lookup44 = default(SGLNode);

        SGLNode unaryExpression45 = default(SGLNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:256:2: ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( '^' a= expression b= expression ) | ^( INT_NEGATE a= expression ) | ^( BOOL_NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | LayerAtom | OriginAtom | LoopTypeAtom | Null | instantiateClass | lookup | unaryExpression )
            int alt19 = 28;
            switch ( input.LA(1) ) 
            {
            case 73:
            	{
                alt19 = 1;
                }
                break;
            case 74:
            	{
                alt19 = 2;
                }
                break;
            case 75:
            	{
                alt19 = 3;
                }
                break;
            case 76:
            	{
                alt19 = 4;
                }
                break;
            case 77:
            	{
                alt19 = 5;
                }
                break;
            case 78:
            	{
                alt19 = 6;
                }
                break;
            case INT_NEGATE:
            	{
                alt19 = 7;
                }
                break;
            case BOOL_NEGATE:
            	{
                alt19 = 8;
                }
                break;
            case 69:
            	{
                alt19 = 9;
                }
                break;
            case 71:
            	{
                alt19 = 10;
                }
                break;
            case 70:
            	{
                alt19 = 11;
                }
                break;
            case 72:
            	{
                alt19 = 12;
                }
                break;
            case 68:
            	{
                alt19 = 13;
                }
                break;
            case 67:
            	{
                alt19 = 14;
                }
                break;
            case 66:
            	{
                alt19 = 15;
                }
                break;
            case 65:
            	{
                alt19 = 16;
                }
                break;
            case 63:
            	{
                alt19 = 17;
                }
                break;
            case IntAtom:
            	{
                alt19 = 18;
                }
                break;
            case FloatAtom:
            	{
                alt19 = 19;
                }
                break;
            case BooleanAtom:
            	{
                alt19 = 20;
                }
                break;
            case STRING:
            	{
                alt19 = 21;
                }
                break;
            case LayerAtom:
            	{
                alt19 = 22;
                }
                break;
            case OriginAtom:
            	{
                alt19 = 23;
                }
                break;
            case LoopTypeAtom:
            	{
                alt19 = 24;
                }
                break;
            case Null:
            	{
                alt19 = 25;
                }
                break;
            case Sprite:
            case Animation:
            case List:
            	{
                alt19 = 26;
                }
                break;
            case LOOKUP:
            	{
                alt19 = 27;
                }
                break;
            case VARINC:
            case VARDEC:
            	{
                alt19 = 28;
                }
                break;
            	default:
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("", 19, 0, input);

            	    throw nvae_d19s0;
            }

            switch (alt19) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:256:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,73,FOLLOW_73_in_expression766); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression770);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression774);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new AddNode(a, b); 

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:257:4: ^( '-' a= expression b= expression )
                    {
                    	Match(input,74,FOLLOW_74_in_expression783); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression787);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression791);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new SubNode(a, b); 

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:258:4: ^( '*' a= expression b= expression )
                    {
                    	Match(input,75,FOLLOW_75_in_expression800); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression804);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression808);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MultNode(a, b); 

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:259:4: ^( '/' a= expression b= expression )
                    {
                    	Match(input,76,FOLLOW_76_in_expression817); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression821);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression825);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new DivNode(a, b); 

                    }
                    break;
                case 5 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:260:4: ^( '%' a= expression b= expression )
                    {
                    	Match(input,77,FOLLOW_77_in_expression834); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression838);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression842);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new ModNode(a, b); 

                    }
                    break;
                case 6 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:261:4: ^( '^' a= expression b= expression )
                    {
                    	Match(input,78,FOLLOW_78_in_expression851); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression855);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression859);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new PowNode(a, b); 

                    }
                    break;
                case 7 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:262:4: ^( INT_NEGATE a= expression )
                    {
                    	Match(input,INT_NEGATE,FOLLOW_INT_NEGATE_in_expression868); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression872);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NegateIntNode(a); 

                    }
                    break;
                case 8 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:263:4: ^( BOOL_NEGATE a= expression )
                    {
                    	Match(input,BOOL_NEGATE,FOLLOW_BOOL_NEGATE_in_expression881); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression885);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NegateBoolNode(a); 

                    }
                    break;
                case 9 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:264:4: ^( '<' a= expression b= expression )
                    {
                    	Match(input,69,FOLLOW_69_in_expression894); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression898);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression902);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new LTNode(a, b); 

                    }
                    break;
                case 10 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:265:4: ^( '<=' a= expression b= expression )
                    {
                    	Match(input,71,FOLLOW_71_in_expression911); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression915);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression919);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new LTEqualsNode(a, b); 

                    }
                    break;
                case 11 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:266:4: ^( '>' a= expression b= expression )
                    {
                    	Match(input,70,FOLLOW_70_in_expression928); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression932);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression936);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new GTNode(a, b); 

                    }
                    break;
                case 12 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:267:4: ^( '>=' a= expression b= expression )
                    {
                    	Match(input,72,FOLLOW_72_in_expression945); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression949);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression953);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new GTEqualsNode(a, b); 

                    }
                    break;
                case 13 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:268:4: ^( '!=' a= expression b= expression )
                    {
                    	Match(input,68,FOLLOW_68_in_expression962); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression966);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression970);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NotEqualsNode(a, b); 

                    }
                    break;
                case 14 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:269:4: ^( '==' a= expression b= expression )
                    {
                    	Match(input,67,FOLLOW_67_in_expression979); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression983);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression987);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new EqualsNode(a, b); 

                    }
                    break;
                case 15 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:270:4: ^( '&&' a= expression b= expression )
                    {
                    	Match(input,66,FOLLOW_66_in_expression996); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression1000);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1004);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new AndNode(a, b); 

                    }
                    break;
                case 16 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:271:4: ^( '||' a= expression b= expression )
                    {
                    	Match(input,65,FOLLOW_65_in_expression1013); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression1017);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1021);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new OrNode(a, b); 

                    }
                    break;
                case 17 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:272:4: ^( '?' a= expression b= expression c= expression )
                    {
                    	Match(input,63,FOLLOW_63_in_expression1030); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression1034);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1038);
                    	b = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1042);
                    	c = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new TernaryNode(a, b, c); 

                    }
                    break;
                case 18 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:273:6: IntAtom
                    {
                    	IntAtom35=(CommonTree)Match(input,IntAtom,FOLLOW_IntAtom_in_expression1052); 
                    	 node = new AtomNode(int.Parse(((IntAtom35 != null) ? IntAtom35.Text : null), System.Globalization.CultureInfo.InvariantCulture), ValueType.Integer, IntAtom35.Line); 

                    }
                    break;
                case 19 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:274:4: FloatAtom
                    {
                    	FloatAtom36=(CommonTree)Match(input,FloatAtom,FOLLOW_FloatAtom_in_expression1059); 
                    	 node = new AtomNode(Double.Parse(((FloatAtom36 != null) ? FloatAtom36.Text : null), System.Globalization.CultureInfo.InvariantCulture), ValueType.Double,  FloatAtom36.Line); 

                    }
                    break;
                case 20 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:275:6: BooleanAtom
                    {
                    	BooleanAtom37=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression1068); 
                    	 node = new AtomNode(Boolean.Parse(((BooleanAtom37 != null) ? BooleanAtom37.Text : null)), ValueType.Boolean, BooleanAtom37.Line); 

                    }
                    break;
                case 21 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:276:4: ^( STRING StringAtom )
                    {
                    	Match(input,STRING,FOLLOW_STRING_in_expression1076); 

                    	Match(input, Token.DOWN, null); 
                    	StringAtom38=(CommonTree)Match(input,StringAtom,FOLLOW_StringAtom_in_expression1078); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode((((StringAtom38 != null) ? StringAtom38.Text : null)).Substring(1, (((StringAtom38 != null) ? StringAtom38.Text : null)).Length-2), ValueType.String, StringAtom38.Line); 

                    }
                    break;
                case 22 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:277:4: LayerAtom
                    {
                    	LayerAtom39=(CommonTree)Match(input,LayerAtom,FOLLOW_LayerAtom_in_expression1086); 
                    	 node = new AtomNode(((LayerAtom39 != null) ? LayerAtom39.Text : null), ValueType.Layer, LayerAtom39.Line); 

                    }
                    break;
                case 23 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:278:4: OriginAtom
                    {
                    	OriginAtom40=(CommonTree)Match(input,OriginAtom,FOLLOW_OriginAtom_in_expression1093); 
                    	 node = new AtomNode(((OriginAtom40 != null) ? OriginAtom40.Text : null), ValueType.Origin, OriginAtom40.Line); 

                    }
                    break;
                case 24 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:279:4: LoopTypeAtom
                    {
                    	LoopTypeAtom41=(CommonTree)Match(input,LoopTypeAtom,FOLLOW_LoopTypeAtom_in_expression1100); 
                    	 node = new AtomNode(((LoopTypeAtom41 != null) ? LoopTypeAtom41.Text : null), ValueType.LoopType, LoopTypeAtom41.Line); 

                    }
                    break;
                case 25 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:281:4: Null
                    {
                    	Null42=(CommonTree)Match(input,Null,FOLLOW_Null_in_expression1109); 
                    	 node = new AtomNode(((Null42 != null) ? Null42.Text : null), Null42.Line); 

                    }
                    break;
                case 26 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:282:4: instantiateClass
                    {
                    	PushFollow(FOLLOW_instantiateClass_in_expression1116);
                    	instantiateClass43 = instantiateClass();
                    	state.followingStackPointer--;

                    	 node = instantiateClass43; 

                    }
                    break;
                case 27 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:283:4: lookup
                    {
                    	PushFollow(FOLLOW_lookup_in_expression1123);
                    	lookup44 = lookup();
                    	state.followingStackPointer--;

                    	 node = lookup44; 

                    }
                    break;
                case 28 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:284:4: unaryExpression
                    {
                    	PushFollow(FOLLOW_unaryExpression_in_expression1130);
                    	unaryExpression45 = unaryExpression();
                    	state.followingStackPointer--;

                    	 node = unaryExpression45; 

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


    // $ANTLR start "unaryExpression"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:288:1: unaryExpression returns [SGLNode node] : ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) );
    public SGLNode unaryExpression() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier46 = null;
        CommonTree Identifier47 = null;

        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:289:5: ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) )
            int alt20 = 2;
            int LA20_0 = input.LA(1);

            if ( (LA20_0 == VARINC) )
            {
                alt20 = 1;
            }
            else if ( (LA20_0 == VARDEC) )
            {
                alt20 = 2;
            }
            else 
            {
                NoViableAltException nvae_d20s0 =
                    new NoViableAltException("", 20, 0, input);

                throw nvae_d20s0;
            }
            switch (alt20) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:289:9: ^( VARINC Identifier )
                    {
                    	Match(input,VARINC,FOLLOW_VARINC_in_unaryExpression1168); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier46=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_unaryExpression1170); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarIncNode(((Identifier46 != null) ? Identifier46.Text : null), currentScope, Identifier46.Line); 

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:290:4: ^( VARDEC Identifier )
                    {
                    	Match(input,VARDEC,FOLLOW_VARDEC_in_unaryExpression1179); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier47=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_unaryExpression1181); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarDecNode(((Identifier47 != null) ? Identifier47.Text : null), currentScope, Identifier47.Line); 

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
    // $ANTLR end "unaryExpression"


    // $ANTLR start "instantiateClass"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:294:1: instantiateClass returns [SGLNode node] : ( ^( Sprite ( expressionList )? ) | ^( Animation ( expressionList )? ) | ^( List ( expressionList )? ) );
    public SGLNode instantiateClass() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        List<SGLNode> expressionList48 = default(List<SGLNode>);

        List<SGLNode> expressionList49 = default(List<SGLNode>);

        List<SGLNode> expressionList50 = default(List<SGLNode>);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:295:2: ( ^( Sprite ( expressionList )? ) | ^( Animation ( expressionList )? ) | ^( List ( expressionList )? ) )
            int alt24 = 3;
            switch ( input.LA(1) ) 
            {
            case Sprite:
            	{
                alt24 = 1;
                }
                break;
            case Animation:
            	{
                alt24 = 2;
                }
                break;
            case List:
            	{
                alt24 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d24s0 =
            	        new NoViableAltException("", 24, 0, input);

            	    throw nvae_d24s0;
            }

            switch (alt24) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:295:4: ^( Sprite ( expressionList )? )
                    {
                    	Match(input,Sprite,FOLLOW_Sprite_in_instantiateClass1203); 

                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); 
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:295:13: ( expressionList )?
                    	    int alt21 = 2;
                    	    int LA21_0 = input.LA(1);

                    	    if ( (LA21_0 == EXP_LIST) )
                    	    {
                    	        alt21 = 1;
                    	    }
                    	    switch (alt21) 
                    	    {
                    	        case 1 :
                    	            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:295:13: expressionList
                    	            {
                    	            	PushFollow(FOLLOW_expressionList_in_instantiateClass1205);
                    	            	expressionList48 = expressionList();
                    	            	state.followingStackPointer--;


                    	            }
                    	            break;

                    	    }


                    	    Match(input, Token.UP, null); 
                    	}
                    	  node = new SpriteNode(expressionList48); 

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:296:4: ^( Animation ( expressionList )? )
                    {
                    	Match(input,Animation,FOLLOW_Animation_in_instantiateClass1215); 

                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); 
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:296:16: ( expressionList )?
                    	    int alt22 = 2;
                    	    int LA22_0 = input.LA(1);

                    	    if ( (LA22_0 == EXP_LIST) )
                    	    {
                    	        alt22 = 1;
                    	    }
                    	    switch (alt22) 
                    	    {
                    	        case 1 :
                    	            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:296:16: expressionList
                    	            {
                    	            	PushFollow(FOLLOW_expressionList_in_instantiateClass1217);
                    	            	expressionList49 = expressionList();
                    	            	state.followingStackPointer--;


                    	            }
                    	            break;

                    	    }


                    	    Match(input, Token.UP, null); 
                    	}
                    	  node = new AnimationNode(expressionList49); 

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:297:4: ^( List ( expressionList )? )
                    {
                    	Match(input,List,FOLLOW_List_in_instantiateClass1227); 

                    	if ( input.LA(1) == Token.DOWN )
                    	{
                    	    Match(input, Token.DOWN, null); 
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:297:11: ( expressionList )?
                    	    int alt23 = 2;
                    	    int LA23_0 = input.LA(1);

                    	    if ( (LA23_0 == EXP_LIST) )
                    	    {
                    	        alt23 = 1;
                    	    }
                    	    switch (alt23) 
                    	    {
                    	        case 1 :
                    	            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:297:11: expressionList
                    	            {
                    	            	PushFollow(FOLLOW_expressionList_in_instantiateClass1229);
                    	            	expressionList50 = expressionList();
                    	            	state.followingStackPointer--;


                    	            }
                    	            break;

                    	    }


                    	    Match(input, Token.UP, null); 
                    	}
                    	  node = new ListNode(expressionList50); 

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
    // $ANTLR end "instantiateClass"


    // $ANTLR start "lookup"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:300:1: lookup returns [SGLNode node] : ( ^( LOOKUP objectMethodCall (i= indexes )? ) | ^( LOOKUP Identifier (i= indexes )? ) | ^( LOOKUP methodCall (i= indexes )? ) );
    public SGLNode lookup() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier52 = null;
        List<SGLNode> i = default(List<SGLNode>);

        SGLNode objectMethodCall51 = default(SGLNode);

        SGLNode methodCall53 = default(SGLNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:301:3: ( ^( LOOKUP objectMethodCall (i= indexes )? ) | ^( LOOKUP Identifier (i= indexes )? ) | ^( LOOKUP methodCall (i= indexes )? ) )
            int alt28 = 3;
            int LA28_0 = input.LA(1);

            if ( (LA28_0 == LOOKUP) )
            {
                int LA28_1 = input.LA(2);

                if ( (LA28_1 == DOWN) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case Identifier:
                    	{
                        alt28 = 2;
                        }
                        break;
                    case OBJ_METH_CALL:
                    	{
                        alt28 = 1;
                        }
                        break;
                    case METH_CALL:
                    	{
                        alt28 = 3;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d28s2 =
                    	        new NoViableAltException("", 28, 2, input);

                    	    throw nvae_d28s2;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d28s1 =
                        new NoViableAltException("", 28, 1, input);

                    throw nvae_d28s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d28s0 =
                    new NoViableAltException("", 28, 0, input);

                throw nvae_d28s0;
            }
            switch (alt28) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:301:6: ^( LOOKUP objectMethodCall (i= indexes )? )
                    {
                    	Match(input,LOOKUP,FOLLOW_LOOKUP_in_lookup1256); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_objectMethodCall_in_lookup1258);
                    	objectMethodCall51 = objectMethodCall();
                    	state.followingStackPointer--;

                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:301:33: (i= indexes )?
                    	int alt25 = 2;
                    	int LA25_0 = input.LA(1);

                    	if ( (LA25_0 == INDEXES) )
                    	{
                    	    alt25 = 1;
                    	}
                    	switch (alt25) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:301:33: i= indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1262);
                    	        	i = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	node = i != null ? new LookupNode(objectMethodCall51, i) : objectMethodCall51;

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:302:6: ^( LOOKUP Identifier (i= indexes )? )
                    {
                    	Match(input,LOOKUP,FOLLOW_LOOKUP_in_lookup1274); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier52=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_lookup1276); 
                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:302:27: (i= indexes )?
                    	int alt26 = 2;
                    	int LA26_0 = input.LA(1);

                    	if ( (LA26_0 == INDEXES) )
                    	{
                    	    alt26 = 1;
                    	}
                    	switch (alt26) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:302:27: i= indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1280);
                    	        	i = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	SGLNode identNode = new IdentifierNode(((Identifier52 != null) ? Identifier52.Text : null), currentScope, Identifier52.Line);
                    	  	node = i != null ? new LookupNode(identNode, i) : identNode;

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:305:6: ^( LOOKUP methodCall (i= indexes )? )
                    {
                    	Match(input,LOOKUP,FOLLOW_LOOKUP_in_lookup1303); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_methodCall_in_lookup1305);
                    	methodCall53 = methodCall();
                    	state.followingStackPointer--;

                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:305:27: (i= indexes )?
                    	int alt27 = 2;
                    	int LA27_0 = input.LA(1);

                    	if ( (LA27_0 == INDEXES) )
                    	{
                    	    alt27 = 1;
                    	}
                    	switch (alt27) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:305:27: i= indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1309);
                    	        	i = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	node = i != null ? new LookupNode(methodCall53, i) : node = methodCall53;

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
    // $ANTLR end "lookup"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_block_in_main69 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BLOCK_in_block104 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_block119 = new BitSet(new ulong[]{0x00000000107E0628UL,0x0000000000600000UL});
    public static readonly BitSet FOLLOW_assignment_in_statement163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_statement171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_statement178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_statement186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atStatement_in_statement201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement209 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forLoop_in_statement216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_breakStat_in_statement223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_returnStat_in_statement230 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AT_in_atStatement255 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_atStatement257 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_atStatement259 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_RETURN_in_returnStat279 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_returnStat281 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_METH_CALL_in_methodCall304 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodCall306 = new BitSet(new ulong[]{0x0000000000008008UL});
    public static readonly BitSet FOLLOW_expressionList_in_methodCall308 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BREAK_in_breakStat329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJ_METH_CALL_in_objectMethodCall348 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variable_in_objectMethodCall350 = new BitSet(new ulong[]{0x0000000020001000UL});
    public static readonly BitSet FOLLOW_indexes_in_objectMethodCall352 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethodCall355 = new BitSet(new ulong[]{0x0000000000008008UL});
    public static readonly BitSet FOLLOW_expressionList_in_objectMethodCall357 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_85_in_whileLoop380 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop382 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_whileLoop384 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IF_in_ifStatement417 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement431 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_ifStatement433 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement437 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement457 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement461 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_86_in_forLoop510 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_FORDEC_in_forLoop513 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_forLoop518 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FORCOND_in_forLoop527 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop532 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FORITER_in_forLoop540 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_forLoop545 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_block_in_forLoop552 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXP_LIST_in_expressionList584 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList596 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_INDEXES_in_indexes634 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_indexes642 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_Identifier_in_variable673 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment692 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variable_in_assignment694 = new BitSet(new ulong[]{0x800003DF800037C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_indexes_in_assignment696 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_assignment699 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_GLOBAL_ASSIGN_in_assignment724 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variable_in_assignment726 = new BitSet(new ulong[]{0x800003DF800037C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_indexes_in_assignment728 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_assignment731 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_73_in_expression766 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression770 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression774 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_74_in_expression783 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression787 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression791 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_75_in_expression800 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression804 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression808 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_76_in_expression817 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression821 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression825 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_77_in_expression834 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression838 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression842 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_78_in_expression851 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression855 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression859 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_INT_NEGATE_in_expression868 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression872 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BOOL_NEGATE_in_expression881 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression885 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_69_in_expression894 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression898 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression902 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_71_in_expression911 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression915 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression919 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_70_in_expression928 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression932 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression936 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_72_in_expression945 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression949 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression953 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_68_in_expression962 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression966 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression970 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_expression979 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression983 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression987 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_66_in_expression996 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1000 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression1004 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_65_in_expression1013 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1017 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression1021 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_63_in_expression1030 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1034 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression1038 = new BitSet(new ulong[]{0x800003DF800027C8UL,0x0000000000007FFEUL});
    public static readonly BitSet FOLLOW_expression_in_expression1042 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IntAtom_in_expression1052 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_expression1059 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_expression1068 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_expression1076 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_StringAtom_in_expression1078 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LayerAtom_in_expression1086 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OriginAtom_in_expression1093 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LoopTypeAtom_in_expression1100 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Null_in_expression1109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_instantiateClass_in_expression1116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookup_in_expression1123 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_expression1130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARINC_in_unaryExpression1168 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_unaryExpression1170 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEC_in_unaryExpression1179 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_unaryExpression1181 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Sprite_in_instantiateClass1203 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1205 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Animation_in_instantiateClass1215 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1217 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_List_in_instantiateClass1227 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1229 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LOOKUP_in_lookup1256 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_lookup1258 = new BitSet(new ulong[]{0x0000000000001008UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1262 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LOOKUP_in_lookup1274 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_lookup1276 = new BitSet(new ulong[]{0x0000000000001008UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1280 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LOOKUP_in_lookup1303 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_methodCall_in_lookup1305 = new BitSet(new ulong[]{0x0000000000001008UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1309 = new BitSet(new ulong[]{0x0000000000000008UL});

}
}