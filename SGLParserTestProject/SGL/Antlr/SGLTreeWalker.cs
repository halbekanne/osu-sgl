// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g 2012-06-07 14:29:11

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


// -------------------------------------------------------------------------------------------------
//                This is a generated file, please don't change anything in here!
// -------------------------------------------------------------------------------------------------

using System.Text;
using System.Collections.Generic;
using SGL.Elements;
using SGL.Nodes;
using SGL.Nodes.Actions;
using SGL.Nodes.ControlFlow;
using SGL.Nodes.Operators;
using SGL.Nodes.Operators.Arithmetical;
using SGL.Nodes.Operators.Logical;
using SGL.Nodes.Operators.Misc;
using SGL.Nodes.Values;


using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  SGL.Antlr 
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
		"FUNC_CALL", 
		"OBJ_FUNC_CALL", 
		"BREAK", 
		"RETURN", 
		"AT", 
		"IF", 
		"EXP", 
		"FORDEC", 
		"FORCOND", 
		"FORITER", 
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
    public const int IntAtom = 30;
    public const int Sprite = 38;
    public const int EXP_LIST = 15;
    public const int LoopTypeAtom = 35;
    public const int T__61 = 61;
    public const int UTF8Letter = 45;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int HexDigit = 43;
    public const int BREAK = 19;
    public const int Identifier = 28;
    public const int Lyrics = 42;
    public const int IF = 22;
    public const int FUNC_CALL = 17;
    public const int AT = 21;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int Animation = 39;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int Comment = 47;
    public const int EXP = 23;
    public const int OBJ_FUNC_CALL = 18;
    public const int FORITER = 26;
    public const int T__59 = 59;
    public const int INT_NEGATE = 7;
    public const int UTF8Digit = 46;
    public const int RETURN = 20;
    public const int WhiteSpace = 48;
    public const int T__50 = 50;
    public const int VARDEC = 10;
    public const int OriginAtom = 34;
    public const int Null = 37;
    public const int LayerAtom = 33;
    public const int GLOBAL_ASSIGN = 27;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int T__49 = 49;
    public const int FORDEC = 24;
    public const int StringAtom = 29;
    public const int INDEXES = 12;
    public const int ColorAtom = 36;
    public const int T__85 = 85;
    public const int T__84 = 84;
    public const int LIST = 14;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int List = 40;
    public const int BOOL_NEGATE = 8;
    public const int BooleanAtom = 32;
    public const int LOOKUP = 13;
    public const int T__71 = 71;
    public const int FORCOND = 25;
    public const int T__72 = 72;
    public const int VARIABLE = 11;
    public const int T__70 = 70;
    public const int BLOCK = 4;
    public const int ASSIGN = 5;
    public const int VarStartInit = 41;
    public const int T__76 = 76;
    public const int FloatAtom = 31;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int VARINC = 9;
    public const int T__73 = 73;
    public const int EscapeSequence = 44;
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



    	Scope currentScope;
    	
    	private Boolean isMain = false;
          
    	public SGLTreeWalker(CommonTreeNodeStream nodes, Boolean isMain) : this(nodes) {
        	this.currentScope = new Scope();
        	this.isMain = isMain;
        }
        
        public SGLTreeWalker(CommonTreeNodeStream nodes, Scope sc) : this(nodes) {
        	this.currentScope = sc;
        }
          
    	public override void EmitErrorMessage(string msg)
    	{
    		throw new CompilerException(-1, 101, msg);
    		//throw new Exception(msg);
        }      
    	
    	// Sprite objects
        
        //Debug
        //private TextBox debugConsole;
        
        //public void SetDebugTextBox(TextBox tb) {
        //	debugConsole = tb;
        //}
        
        //private StringBuilder storyboardCode = new StringBuilder();
        /*	
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
                        }
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
                    }
                }

        	return storyboardCode;
        }*/
        
        
          //public Dictionary<String, Method> methods = null;
          //public Dictionary<String, ObjectMethod> objectMethods = null;
      



    // $ANTLR start "main"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:125:1: main returns [AbstractNode node] : block ;
    public AbstractNode main() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode block1 = default(AbstractNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:126:2: ( block )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:126:4: block
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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:130:1: block returns [AbstractNode node] : ^( BLOCK ( statement )* ) ;
    public AbstractNode block() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode statement2 = default(AbstractNode);


         
          Scope scope = new Scope(currentScope); 
          currentScope = scope;
          BlockNode bn = new BlockNode(currentScope); 
          node = bn;  

        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:140:2: ( ^( BLOCK ( statement )* ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:140:4: ^( BLOCK ( statement )* )
            {
            	Match(input,BLOCK,FOLLOW_BLOCK_in_block104); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:141:10: ( statement )*
            	    do 
            	    {
            	        int alt1 = 2;
            	        int LA1_0 = input.LA(1);

            	        if ( (LA1_0 == ASSIGN || (LA1_0 >= VARINC && LA1_0 <= VARDEC) || (LA1_0 >= FUNC_CALL && LA1_0 <= IF) || LA1_0 == GLOBAL_ASSIGN || (LA1_0 >= 83 && LA1_0 <= 84)) )
            	        {
            	            alt1 = 1;
            	        }


            	        switch (alt1) 
            	    	{
            	    		case 1 :
            	    		    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:141:11: statement
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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:146:1: statement returns [AbstractNode node] : ( assignment | unaryExpression | functionCall | objectFunctionCall | ifStatement | atStatement | whileLoop | forLoop | breakStat | returnStat );
    public AbstractNode statement() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode assignment3 = default(AbstractNode);

        AbstractNode unaryExpression4 = default(AbstractNode);

        AbstractNode functionCall5 = default(AbstractNode);

        AbstractNode objectFunctionCall6 = default(AbstractNode);

        AbstractNode ifStatement7 = default(AbstractNode);

        AbstractNode atStatement8 = default(AbstractNode);

        AbstractNode whileLoop9 = default(AbstractNode);

        AbstractNode forLoop10 = default(AbstractNode);

        AbstractNode breakStat11 = default(AbstractNode);

        AbstractNode returnStat12 = default(AbstractNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:148:2: ( assignment | unaryExpression | functionCall | objectFunctionCall | ifStatement | atStatement | whileLoop | forLoop | breakStat | returnStat )
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
            case FUNC_CALL:
            	{
                alt2 = 3;
                }
                break;
            case OBJ_FUNC_CALL:
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
            case 83:
            	{
                alt2 = 7;
                }
                break;
            case 84:
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:148:4: assignment
                    {
                    	PushFollow(FOLLOW_assignment_in_statement163);
                    	assignment3 = assignment();
                    	state.followingStackPointer--;

                    	 node = assignment3; 

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:149:4: unaryExpression
                    {
                    	PushFollow(FOLLOW_unaryExpression_in_statement171);
                    	unaryExpression4 = unaryExpression();
                    	state.followingStackPointer--;

                    	 node = unaryExpression4; 

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:150:4: functionCall
                    {
                    	PushFollow(FOLLOW_functionCall_in_statement178);
                    	functionCall5 = functionCall();
                    	state.followingStackPointer--;

                    	 node = functionCall5; 

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:151:4: objectFunctionCall
                    {
                    	PushFollow(FOLLOW_objectFunctionCall_in_statement186);
                    	objectFunctionCall6 = objectFunctionCall();
                    	state.followingStackPointer--;

                    	 node = objectFunctionCall6; 

                    }
                    break;
                case 5 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:152:4: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_statement194);
                    	ifStatement7 = ifStatement();
                    	state.followingStackPointer--;

                    	 node = ifStatement7; 

                    }
                    break;
                case 6 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:153:4: atStatement
                    {
                    	PushFollow(FOLLOW_atStatement_in_statement201);
                    	atStatement8 = atStatement();
                    	state.followingStackPointer--;

                    	 node = atStatement8; 

                    }
                    break;
                case 7 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:154:4: whileLoop
                    {
                    	PushFollow(FOLLOW_whileLoop_in_statement209);
                    	whileLoop9 = whileLoop();
                    	state.followingStackPointer--;

                    	 node = whileLoop9; 

                    }
                    break;
                case 8 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:155:4: forLoop
                    {
                    	PushFollow(FOLLOW_forLoop_in_statement216);
                    	forLoop10 = forLoop();
                    	state.followingStackPointer--;

                    	 node = forLoop10; 

                    }
                    break;
                case 9 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:156:4: breakStat
                    {
                    	PushFollow(FOLLOW_breakStat_in_statement223);
                    	breakStat11 = breakStat();
                    	state.followingStackPointer--;

                    	 node = breakStat11; 

                    }
                    break;
                case 10 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:157:4: returnStat
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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:161:1: atStatement returns [AbstractNode node] : ^( AT expression block ) ;
    public AbstractNode atStatement() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode expression13 = default(AbstractNode);

        AbstractNode block14 = default(AbstractNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:162:2: ( ^( AT expression block ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:162:4: ^( AT expression block )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:165:1: returnStat returns [AbstractNode node] : ^( RETURN ( expression )? ) ;
    public AbstractNode returnStat() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode expression15 = default(AbstractNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:166:2: ( ^( RETURN ( expression )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:166:4: ^( RETURN ( expression )? )
            {
            	Match(input,RETURN,FOLLOW_RETURN_in_returnStat279); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:166:13: ( expression )?
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= STRING && LA3_0 <= VARDEC) || LA3_0 == LOOKUP || LA3_0 == Identifier || (LA3_0 >= IntAtom && LA3_0 <= LoopTypeAtom) || LA3_0 == Null || LA3_0 == 61 || (LA3_0 >= 63 && LA3_0 <= 76)) )
            	    {
            	        alt3 = 1;
            	    }
            	    switch (alt3) 
            	    {
            	        case 1 :
            	            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:166:13: expression
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


    // $ANTLR start "functionCall"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:169:1: functionCall returns [AbstractNode node] : ^( FUNC_CALL Identifier ( expressionList )? ) ;
    public AbstractNode functionCall() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier16 = null;
        List<AbstractNode> expressionList17 = default(List<AbstractNode>);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:170:2: ( ^( FUNC_CALL Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:170:4: ^( FUNC_CALL Identifier ( expressionList )? )
            {
            	Match(input,FUNC_CALL,FOLLOW_FUNC_CALL_in_functionCall304); 

            	Match(input, Token.DOWN, null); 
            	Identifier16=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_functionCall306); 
            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:170:27: ( expressionList )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == EXP_LIST) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:170:27: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_functionCall308);
            	        	expressionList17 = expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); 
            	 node = new InvokeFunctionNode(((Identifier16 != null) ? Identifier16.Text : null), expressionList17, Identifier16.Line); 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:173:1: breakStat returns [AbstractNode node] : BREAK ;
    public AbstractNode breakStat() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree BREAK18 = null;

        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:174:2: ( BREAK )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:174:4: BREAK
            {
            	BREAK18=(CommonTree)Match(input,BREAK,FOLLOW_BREAK_in_breakStat329); 
            	 node = new BreakNode(BREAK18.Line); 

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


    // $ANTLR start "objectFunctionCall"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:177:1: objectFunctionCall returns [AbstractNode node] : ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? ) ;
    public AbstractNode objectFunctionCall() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier21 = null;
        String variable19 = default(String);

        List<AbstractNode> indexes20 = default(List<AbstractNode>);

        List<AbstractNode> expressionList22 = default(List<AbstractNode>);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:178:2: ( ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:178:4: ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? )
            {
            	Match(input,OBJ_FUNC_CALL,FOLLOW_OBJ_FUNC_CALL_in_objectFunctionCall348); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variable_in_objectFunctionCall350);
            	variable19 = variable();
            	state.followingStackPointer--;

            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:178:29: ( indexes )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == INDEXES) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:178:29: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_objectFunctionCall352);
            	        	indexes20 = indexes();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Identifier21=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_objectFunctionCall355); 
            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:178:49: ( expressionList )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == EXP_LIST) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:178:49: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_objectFunctionCall357);
            	        	expressionList22 = expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); 
            	 node = new InvokeFunctionNode(variable19, indexes20, ((Identifier21 != null) ? Identifier21.Text : null), expressionList22, Identifier21.Line); 

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
    // $ANTLR end "objectFunctionCall"


    // $ANTLR start "whileLoop"
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:182:1: whileLoop returns [AbstractNode node] : ^( 'while' expression block ) ;
    public AbstractNode whileLoop() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode expression23 = default(AbstractNode);

        AbstractNode block24 = default(AbstractNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:183:2: ( ^( 'while' expression block ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:183:4: ^( 'while' expression block )
            {
            	Match(input,83,FOLLOW_83_in_whileLoop380); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_whileLoop382);
            	expression23 = expression();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_block_in_whileLoop384);
            	block24 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new WhileNode(expression23, block24); 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:187:1: ifStatement returns [AbstractNode node] : ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) ;
    public AbstractNode ifStatement() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode b1 = default(AbstractNode);

        AbstractNode b2 = default(AbstractNode);

        AbstractNode expression25 = default(AbstractNode);


         
          IfNode ifNode = new IfNode(); 
          node = ifNode; 

        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:192:3: ( ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:192:6: ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? )
            {
            	Match(input,IF,FOLLOW_IF_in_ifStatement417); 

            	Match(input, Token.DOWN, null); 
            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:193:8: ( ^( EXP expression b1= block ) )+
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

            	            if ( ((LA7_3 >= STRING && LA7_3 <= VARDEC) || LA7_3 == LOOKUP || LA7_3 == Identifier || (LA7_3 >= IntAtom && LA7_3 <= LoopTypeAtom) || LA7_3 == Null || LA7_3 == 61 || (LA7_3 >= 63 && LA7_3 <= 76)) )
            	            {
            	                alt7 = 1;
            	            }


            	        }


            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:193:9: ^( EXP expression b1= block )
            			    {
            			    	Match(input,EXP,FOLLOW_EXP_in_ifStatement431); 

            			    	Match(input, Token.DOWN, null); 
            			    	PushFollow(FOLLOW_expression_in_ifStatement433);
            			    	expression25 = expression();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_block_in_ifStatement437);
            			    	b1 = block();
            			    	state.followingStackPointer--;


            			    	Match(input, Token.UP, null); 
            			    	 ifNode.AddChoice(expression25,b1); 

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

            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:194:8: ( ^( EXP b2= block ) )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == EXP) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:194:9: ^( EXP b2= block )
            	        {
            	        	Match(input,EXP,FOLLOW_EXP_in_ifStatement457); 

            	        	Match(input, Token.DOWN, null); 
            	        	PushFollow(FOLLOW_block_in_ifStatement461);
            	        	b2 = block();
            	        	state.followingStackPointer--;


            	        	Match(input, Token.UP, null); 
            	        	 ifNode.AddChoice(new AtomNode(true, ValType.Boolean),b2); 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:198:1: forLoop returns [AbstractNode node] : ^( 'for' ^( FORDEC (dec= statement )? ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block ) ;
    public AbstractNode forLoop() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode dec = default(AbstractNode);

        AbstractNode cond = default(AbstractNode);

        AbstractNode iter = default(AbstractNode);

        AbstractNode block26 = default(AbstractNode);



          // We have to use 2 Blocks for the for-Node to work correctly
          // Create new block for the beginning of the for-Loop
          Scope scope = new Scope(currentScope); 
          currentScope = scope;
          BlockNode bn = new BlockNode(currentScope); 
          
          //Create the For-Node and add it to the block
          ForNode forNode = new ForNode();
          bn.AddStatement(forNode);
          
          // Return the block node
          node = bn;

        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:216:2: ( ^( 'for' ^( FORDEC (dec= statement )? ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:216:4: ^( 'for' ^( FORDEC (dec= statement )? ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block )
            {
            	Match(input,84,FOLLOW_84_in_forLoop510); 

            	Match(input, Token.DOWN, null); 
            	Match(input,FORDEC,FOLLOW_FORDEC_in_forLoop513); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:216:21: (dec= statement )?
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == ASSIGN || (LA9_0 >= VARINC && LA9_0 <= VARDEC) || (LA9_0 >= FUNC_CALL && LA9_0 <= IF) || LA9_0 == GLOBAL_ASSIGN || (LA9_0 >= 83 && LA9_0 <= 84)) )
            	    {
            	        alt9 = 1;
            	    }
            	    switch (alt9) 
            	    {
            	        case 1 :
            	            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:216:22: dec= statement
            	            {
            	            	PushFollow(FOLLOW_statement_in_forLoop518);
            	            	dec = statement();
            	            	state.followingStackPointer--;

            	            	 forNode.Init = dec; 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	Match(input,FORCOND,FOLLOW_FORCOND_in_forLoop527); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:216:80: (cond= expression )?
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= STRING && LA10_0 <= VARDEC) || LA10_0 == LOOKUP || LA10_0 == Identifier || (LA10_0 >= IntAtom && LA10_0 <= LoopTypeAtom) || LA10_0 == Null || LA10_0 == 61 || (LA10_0 >= 63 && LA10_0 <= 76)) )
            	    {
            	        alt10 = 1;
            	    }
            	    switch (alt10) 
            	    {
            	        case 1 :
            	            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:216:81: cond= expression
            	            {
            	            	PushFollow(FOLLOW_expression_in_forLoop532);
            	            	cond = expression();
            	            	state.followingStackPointer--;

            	            	 forNode.Condition = cond; 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	Match(input,FORITER,FOLLOW_FORITER_in_forLoop540); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:216:146: (iter= statement )?
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == ASSIGN || (LA11_0 >= VARINC && LA11_0 <= VARDEC) || (LA11_0 >= FUNC_CALL && LA11_0 <= IF) || LA11_0 == GLOBAL_ASSIGN || (LA11_0 >= 83 && LA11_0 <= 84)) )
            	    {
            	        alt11 = 1;
            	    }
            	    switch (alt11) 
            	    {
            	        case 1 :
            	            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:216:147: iter= statement
            	            {
            	            	PushFollow(FOLLOW_statement_in_forLoop545);
            	            	iter = statement();
            	            	state.followingStackPointer--;

            	            	 forNode.Iteration = iter; 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	PushFollow(FOLLOW_block_in_forLoop552);
            	block26 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 forNode.Block = block26; 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:221:1: expressionList returns [List<AbstractNode> list] : ^( EXP_LIST ( expression )+ ) ;
    public List<AbstractNode> expressionList() // throws RecognitionException [1]
    {   
        List<AbstractNode> list = default(List<AbstractNode>);

        AbstractNode expression27 = default(AbstractNode);


         list = new List<AbstractNode>(); 
        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:5: ( ^( EXP_LIST ( expression )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:7: ^( EXP_LIST ( expression )+ )
            {
            	Match(input,EXP_LIST,FOLLOW_EXP_LIST_in_expressionList584); 

            	Match(input, Token.DOWN, null); 
            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:224:7: ( expression )+
            	int cnt12 = 0;
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= STRING && LA12_0 <= VARDEC) || LA12_0 == LOOKUP || LA12_0 == Identifier || (LA12_0 >= IntAtom && LA12_0 <= LoopTypeAtom) || LA12_0 == Null || LA12_0 == 61 || (LA12_0 >= 63 && LA12_0 <= 76)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:224:8: expression
            			    {
            			    	PushFollow(FOLLOW_expression_in_expressionList596);
            			    	expression27 = expression();
            			    	state.followingStackPointer--;

            			    	list.Add(expression27);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:228:1: indexes returns [List<AbstractNode> list] : ^( INDEXES ( expression )+ ) ;
    public List<AbstractNode> indexes() // throws RecognitionException [1]
    {   
        List<AbstractNode> list = default(List<AbstractNode>);

        AbstractNode expression28 = default(AbstractNode);


         list = new List<AbstractNode>(); 
        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:230:3: ( ^( INDEXES ( expression )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:230:6: ^( INDEXES ( expression )+ )
            {
            	Match(input,INDEXES,FOLLOW_INDEXES_in_indexes634); 

            	Match(input, Token.DOWN, null); 
            	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:231:5: ( expression )+
            	int cnt13 = 0;
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= STRING && LA13_0 <= VARDEC) || LA13_0 == LOOKUP || LA13_0 == Identifier || (LA13_0 >= IntAtom && LA13_0 <= LoopTypeAtom) || LA13_0 == Null || LA13_0 == 61 || (LA13_0 >= 63 && LA13_0 <= 76)) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:231:6: expression
            			    {
            			    	PushFollow(FOLLOW_expression_in_indexes642);
            			    	expression28 = expression();
            			    	state.followingStackPointer--;

            			    	list.Add(expression28);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:235:1: variable returns [String txt] : Identifier ;
    public String variable() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree Identifier29 = null;

        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:236:2: ( Identifier )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:236:4: Identifier
            {
            	Identifier29=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variable673); 
            	 txt = ((Identifier29 != null) ? Identifier29.Text : null); 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:239:1: assignment returns [AbstractNode node] : ( ^( ASSIGN Identifier ( indexes )? ( expression )? ) | ^( GLOBAL_ASSIGN Identifier ( indexes )? ( expression )? ) );
    public AbstractNode assignment() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier30 = null;
        CommonTree Identifier33 = null;
        List<AbstractNode> indexes31 = default(List<AbstractNode>);

        AbstractNode expression32 = default(AbstractNode);

        List<AbstractNode> indexes34 = default(List<AbstractNode>);

        AbstractNode expression35 = default(AbstractNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:240:2: ( ^( ASSIGN Identifier ( indexes )? ( expression )? ) | ^( GLOBAL_ASSIGN Identifier ( indexes )? ( expression )? ) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:240:4: ^( ASSIGN Identifier ( indexes )? ( expression )? )
                    {
                    	Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment692); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier30=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_assignment694); 
                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:240:24: ( indexes )?
                    	int alt14 = 2;
                    	int LA14_0 = input.LA(1);

                    	if ( (LA14_0 == INDEXES) )
                    	{
                    	    alt14 = 1;
                    	}
                    	switch (alt14) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:240:24: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_assignment696);
                    	        	indexes31 = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}

                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:240:33: ( expression )?
                    	int alt15 = 2;
                    	int LA15_0 = input.LA(1);

                    	if ( ((LA15_0 >= STRING && LA15_0 <= VARDEC) || LA15_0 == LOOKUP || LA15_0 == Identifier || (LA15_0 >= IntAtom && LA15_0 <= LoopTypeAtom) || LA15_0 == Null || LA15_0 == 61 || (LA15_0 >= 63 && LA15_0 <= 76)) )
                    	{
                    	    alt15 = 1;
                    	}
                    	switch (alt15) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:240:33: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_assignment699);
                    	        	expression32 = expression();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	 node = new AssignVariableNode(((Identifier30 != null) ? Identifier30.Text : null),indexes31,expression32,currentScope,Identifier30.Line); 

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:243:4: ^( GLOBAL_ASSIGN Identifier ( indexes )? ( expression )? )
                    {
                    	Match(input,GLOBAL_ASSIGN,FOLLOW_GLOBAL_ASSIGN_in_assignment724); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier33=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_assignment726); 
                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:243:31: ( indexes )?
                    	int alt16 = 2;
                    	int LA16_0 = input.LA(1);

                    	if ( (LA16_0 == INDEXES) )
                    	{
                    	    alt16 = 1;
                    	}
                    	switch (alt16) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:243:31: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_assignment728);
                    	        	indexes34 = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}

                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:243:40: ( expression )?
                    	int alt17 = 2;
                    	int LA17_0 = input.LA(1);

                    	if ( ((LA17_0 >= STRING && LA17_0 <= VARDEC) || LA17_0 == LOOKUP || LA17_0 == Identifier || (LA17_0 >= IntAtom && LA17_0 <= LoopTypeAtom) || LA17_0 == Null || LA17_0 == 61 || (LA17_0 >= 63 && LA17_0 <= 76)) )
                    	{
                    	    alt17 = 1;
                    	}
                    	switch (alt17) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:243:40: expression
                    	        {
                    	        	PushFollow(FOLLOW_expression_in_assignment731);
                    	        	expression35 = expression();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	 node = new AssignVariableNode(((Identifier33 != null) ? Identifier33.Text : null),indexes34,expression35,Identifier33.Line); 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:248:1: expression returns [AbstractNode node] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( '^' a= expression b= expression ) | ^( INT_NEGATE a= expression ) | ^( BOOL_NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | LayerAtom | OriginAtom | LoopTypeAtom | Null | instantiateClass | lookup | unaryExpression );
    public AbstractNode expression() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree IntAtom36 = null;
        CommonTree FloatAtom37 = null;
        CommonTree BooleanAtom38 = null;
        CommonTree StringAtom39 = null;
        CommonTree LayerAtom40 = null;
        CommonTree OriginAtom41 = null;
        CommonTree LoopTypeAtom42 = null;
        CommonTree Null43 = null;
        AbstractNode a = default(AbstractNode);

        AbstractNode b = default(AbstractNode);

        AbstractNode c = default(AbstractNode);

        AbstractNode instantiateClass44 = default(AbstractNode);

        AbstractNode lookup45 = default(AbstractNode);

        AbstractNode unaryExpression46 = default(AbstractNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:249:2: ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( '^' a= expression b= expression ) | ^( INT_NEGATE a= expression ) | ^( BOOL_NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | LayerAtom | OriginAtom | LoopTypeAtom | Null | instantiateClass | lookup | unaryExpression )
            int alt19 = 28;
            switch ( input.LA(1) ) 
            {
            case 71:
            	{
                alt19 = 1;
                }
                break;
            case 72:
            	{
                alt19 = 2;
                }
                break;
            case 73:
            	{
                alt19 = 3;
                }
                break;
            case 74:
            	{
                alt19 = 4;
                }
                break;
            case 75:
            	{
                alt19 = 5;
                }
                break;
            case 76:
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
            case 67:
            	{
                alt19 = 9;
                }
                break;
            case 69:
            	{
                alt19 = 10;
                }
                break;
            case 68:
            	{
                alt19 = 11;
                }
                break;
            case 70:
            	{
                alt19 = 12;
                }
                break;
            case 66:
            	{
                alt19 = 13;
                }
                break;
            case 65:
            	{
                alt19 = 14;
                }
                break;
            case 64:
            	{
                alt19 = 15;
                }
                break;
            case 63:
            	{
                alt19 = 16;
                }
                break;
            case 61:
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
            case Identifier:
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:249:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,71,FOLLOW_71_in_expression766); 

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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:250:4: ^( '-' a= expression b= expression )
                    {
                    	Match(input,72,FOLLOW_72_in_expression783); 

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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:251:4: ^( '*' a= expression b= expression )
                    {
                    	Match(input,73,FOLLOW_73_in_expression800); 

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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:252:4: ^( '/' a= expression b= expression )
                    {
                    	Match(input,74,FOLLOW_74_in_expression817); 

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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:253:4: ^( '%' a= expression b= expression )
                    {
                    	Match(input,75,FOLLOW_75_in_expression834); 

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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:254:4: ^( '^' a= expression b= expression )
                    {
                    	Match(input,76,FOLLOW_76_in_expression851); 

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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:255:4: ^( INT_NEGATE a= expression )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:256:4: ^( BOOL_NEGATE a= expression )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:257:4: ^( '<' a= expression b= expression )
                    {
                    	Match(input,67,FOLLOW_67_in_expression894); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression898);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression902);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new LowerThanNode(a, b); 

                    }
                    break;
                case 10 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:258:4: ^( '<=' a= expression b= expression )
                    {
                    	Match(input,69,FOLLOW_69_in_expression911); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression915);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression919);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new LowerThanEqualsNode(a, b); 

                    }
                    break;
                case 11 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:259:4: ^( '>' a= expression b= expression )
                    {
                    	Match(input,68,FOLLOW_68_in_expression928); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression932);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression936);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new GreaterThanNode(a, b); 

                    }
                    break;
                case 12 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:260:4: ^( '>=' a= expression b= expression )
                    {
                    	Match(input,70,FOLLOW_70_in_expression945); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression949);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression953);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new GreaterThanEqualsNode(a, b); 

                    }
                    break;
                case 13 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:261:4: ^( '!=' a= expression b= expression )
                    {
                    	Match(input,66,FOLLOW_66_in_expression962); 

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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:262:4: ^( '==' a= expression b= expression )
                    {
                    	Match(input,65,FOLLOW_65_in_expression979); 

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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:263:4: ^( '&&' a= expression b= expression )
                    {
                    	Match(input,64,FOLLOW_64_in_expression996); 

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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:264:4: ^( '||' a= expression b= expression )
                    {
                    	Match(input,63,FOLLOW_63_in_expression1013); 

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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:265:4: ^( '?' a= expression b= expression c= expression )
                    {
                    	Match(input,61,FOLLOW_61_in_expression1030); 

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
                    	 node = new ConditionalNode(a, b, c); 

                    }
                    break;
                case 18 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:266:6: IntAtom
                    {
                    	IntAtom36=(CommonTree)Match(input,IntAtom,FOLLOW_IntAtom_in_expression1052); 
                    	 node = new AtomNode(int.Parse(((IntAtom36 != null) ? IntAtom36.Text : null), System.Globalization.CultureInfo.InvariantCulture), ValType.Integer, IntAtom36.Line); 

                    }
                    break;
                case 19 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:267:4: FloatAtom
                    {
                    	FloatAtom37=(CommonTree)Match(input,FloatAtom,FOLLOW_FloatAtom_in_expression1059); 
                    	 node = new AtomNode(Double.Parse(((FloatAtom37 != null) ? FloatAtom37.Text : null), System.Globalization.CultureInfo.InvariantCulture), ValType.Double,  FloatAtom37.Line); 

                    }
                    break;
                case 20 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:268:6: BooleanAtom
                    {
                    	BooleanAtom38=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression1068); 
                    	 node = new AtomNode(Boolean.Parse(((BooleanAtom38 != null) ? BooleanAtom38.Text : null)), ValType.Boolean, BooleanAtom38.Line); 

                    }
                    break;
                case 21 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:269:4: ^( STRING StringAtom )
                    {
                    	Match(input,STRING,FOLLOW_STRING_in_expression1076); 

                    	Match(input, Token.DOWN, null); 
                    	StringAtom39=(CommonTree)Match(input,StringAtom,FOLLOW_StringAtom_in_expression1078); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode((((StringAtom39 != null) ? StringAtom39.Text : null)).Substring(1, (((StringAtom39 != null) ? StringAtom39.Text : null)).Length-2), ValType.String, StringAtom39.Line); 

                    }
                    break;
                case 22 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:270:4: LayerAtom
                    {
                    	LayerAtom40=(CommonTree)Match(input,LayerAtom,FOLLOW_LayerAtom_in_expression1086); 
                    	 node = new AtomNode(((LayerAtom40 != null) ? LayerAtom40.Text : null), ValType.Layer, LayerAtom40.Line); 

                    }
                    break;
                case 23 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:271:4: OriginAtom
                    {
                    	OriginAtom41=(CommonTree)Match(input,OriginAtom,FOLLOW_OriginAtom_in_expression1093); 
                    	 node = new AtomNode(((OriginAtom41 != null) ? OriginAtom41.Text : null), ValType.Origin, OriginAtom41.Line); 

                    }
                    break;
                case 24 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:272:4: LoopTypeAtom
                    {
                    	LoopTypeAtom42=(CommonTree)Match(input,LoopTypeAtom,FOLLOW_LoopTypeAtom_in_expression1100); 
                    	 node = new AtomNode(((LoopTypeAtom42 != null) ? LoopTypeAtom42.Text : null), ValType.LoopType, LoopTypeAtom42.Line); 

                    }
                    break;
                case 25 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:274:4: Null
                    {
                    	Null43=(CommonTree)Match(input,Null,FOLLOW_Null_in_expression1109); 
                    	 node = new AtomNode(((Null43 != null) ? Null43.Text : null), Null43.Line); 

                    }
                    break;
                case 26 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:275:4: instantiateClass
                    {
                    	PushFollow(FOLLOW_instantiateClass_in_expression1116);
                    	instantiateClass44 = instantiateClass();
                    	state.followingStackPointer--;

                    	 node = instantiateClass44; 

                    }
                    break;
                case 27 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:276:4: lookup
                    {
                    	PushFollow(FOLLOW_lookup_in_expression1123);
                    	lookup45 = lookup();
                    	state.followingStackPointer--;

                    	 node = lookup45; 

                    }
                    break;
                case 28 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:277:4: unaryExpression
                    {
                    	PushFollow(FOLLOW_unaryExpression_in_expression1130);
                    	unaryExpression46 = unaryExpression();
                    	state.followingStackPointer--;

                    	 node = unaryExpression46; 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:281:1: unaryExpression returns [AbstractNode node] : ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) );
    public AbstractNode unaryExpression() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier47 = null;
        CommonTree Identifier48 = null;

        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:282:5: ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:282:9: ^( VARINC Identifier )
                    {
                    	Match(input,VARINC,FOLLOW_VARINC_in_unaryExpression1168); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier47=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_unaryExpression1170); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarIncNode(((Identifier47 != null) ? Identifier47.Text : null), currentScope, Identifier47.Line); 

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:283:4: ^( VARDEC Identifier )
                    {
                    	Match(input,VARDEC,FOLLOW_VARDEC_in_unaryExpression1179); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier48=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_unaryExpression1181); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarDecNode(((Identifier48 != null) ? Identifier48.Text : null), currentScope, Identifier48.Line); 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:287:1: instantiateClass returns [AbstractNode node] : ^( Identifier ( expressionList )? ) ;
    public AbstractNode instantiateClass() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier49 = null;
        List<AbstractNode> expressionList50 = default(List<AbstractNode>);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:288:2: ( ^( Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:288:4: ^( Identifier ( expressionList )? )
            {
            	Identifier49=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_instantiateClass1203); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:288:17: ( expressionList )?
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == EXP_LIST) )
            	    {
            	        alt21 = 1;
            	    }
            	    switch (alt21) 
            	    {
            	        case 1 :
            	            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:288:17: expressionList
            	            {
            	            	PushFollow(FOLLOW_expressionList_in_instantiateClass1205);
            	            	expressionList50 = expressionList();
            	            	state.followingStackPointer--;


            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	  node = new InstanciateClassNode(((Identifier49 != null) ? Identifier49.Text : null), expressionList50, Identifier49.Line); 

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
    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:291:1: lookup returns [AbstractNode node] : ( ^( LOOKUP objectFunctionCall (i= indexes )? ) | ^( LOOKUP Identifier (i= indexes )? ) | ^( LOOKUP functionCall (i= indexes )? ) );
    public AbstractNode lookup() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier52 = null;
        List<AbstractNode> i = default(List<AbstractNode>);

        AbstractNode objectFunctionCall51 = default(AbstractNode);

        AbstractNode functionCall53 = default(AbstractNode);


        try 
    	{
            // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:292:3: ( ^( LOOKUP objectFunctionCall (i= indexes )? ) | ^( LOOKUP Identifier (i= indexes )? ) | ^( LOOKUP functionCall (i= indexes )? ) )
            int alt25 = 3;
            int LA25_0 = input.LA(1);

            if ( (LA25_0 == LOOKUP) )
            {
                int LA25_1 = input.LA(2);

                if ( (LA25_1 == DOWN) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case Identifier:
                    	{
                        alt25 = 2;
                        }
                        break;
                    case OBJ_FUNC_CALL:
                    	{
                        alt25 = 1;
                        }
                        break;
                    case FUNC_CALL:
                    	{
                        alt25 = 3;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d25s2 =
                    	        new NoViableAltException("", 25, 2, input);

                    	    throw nvae_d25s2;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d25s1 =
                        new NoViableAltException("", 25, 1, input);

                    throw nvae_d25s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d25s0 =
                    new NoViableAltException("", 25, 0, input);

                throw nvae_d25s0;
            }
            switch (alt25) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:292:6: ^( LOOKUP objectFunctionCall (i= indexes )? )
                    {
                    	Match(input,LOOKUP,FOLLOW_LOOKUP_in_lookup1232); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_objectFunctionCall_in_lookup1234);
                    	objectFunctionCall51 = objectFunctionCall();
                    	state.followingStackPointer--;

                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:292:35: (i= indexes )?
                    	int alt22 = 2;
                    	int LA22_0 = input.LA(1);

                    	if ( (LA22_0 == INDEXES) )
                    	{
                    	    alt22 = 1;
                    	}
                    	switch (alt22) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:292:35: i= indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1238);
                    	        	i = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	node = i != null ? new LookupNode(objectFunctionCall51, i) : objectFunctionCall51;

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:293:6: ^( LOOKUP Identifier (i= indexes )? )
                    {
                    	Match(input,LOOKUP,FOLLOW_LOOKUP_in_lookup1250); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier52=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_lookup1252); 
                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:293:27: (i= indexes )?
                    	int alt23 = 2;
                    	int LA23_0 = input.LA(1);

                    	if ( (LA23_0 == INDEXES) )
                    	{
                    	    alt23 = 1;
                    	}
                    	switch (alt23) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:293:27: i= indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1256);
                    	        	i = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	AbstractNode identNode = new IdentifierNode(((Identifier52 != null) ? Identifier52.Text : null), currentScope, Identifier52.Line);
                    	  	node = i != null ? new LookupNode(identNode, i) : identNode;

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:296:6: ^( LOOKUP functionCall (i= indexes )? )
                    {
                    	Match(input,LOOKUP,FOLLOW_LOOKUP_in_lookup1279); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_functionCall_in_lookup1281);
                    	functionCall53 = functionCall();
                    	state.followingStackPointer--;

                    	// D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:296:29: (i= indexes )?
                    	int alt24 = 2;
                    	int LA24_0 = input.LA(1);

                    	if ( (LA24_0 == INDEXES) )
                    	{
                    	    alt24 = 1;
                    	}
                    	switch (alt24) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:296:29: i= indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1285);
                    	        	i = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	node = i != null ? new LookupNode(functionCall53, i) : node = functionCall53;

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
    public static readonly BitSet FOLLOW_statement_in_block119 = new BitSet(new ulong[]{0x00000000087E0628UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_assignment_in_statement163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_statement171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionCall_in_statement178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectFunctionCall_in_statement186 = new BitSet(new ulong[]{0x0000000000000002UL});
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
    public static readonly BitSet FOLLOW_FUNC_CALL_in_functionCall304 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionCall306 = new BitSet(new ulong[]{0x0000000000008008UL});
    public static readonly BitSet FOLLOW_expressionList_in_functionCall308 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BREAK_in_breakStat329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJ_FUNC_CALL_in_objectFunctionCall348 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variable_in_objectFunctionCall350 = new BitSet(new ulong[]{0x0000000010001000UL});
    public static readonly BitSet FOLLOW_indexes_in_objectFunctionCall352 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectFunctionCall355 = new BitSet(new ulong[]{0x0000000000008008UL});
    public static readonly BitSet FOLLOW_expressionList_in_objectFunctionCall357 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_83_in_whileLoop380 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop382 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_whileLoop384 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IF_in_ifStatement417 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement431 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_ifStatement433 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement437 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement457 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement461 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_84_in_forLoop510 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_FORDEC_in_forLoop513 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_forLoop518 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FORCOND_in_forLoop527 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop532 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FORITER_in_forLoop540 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_forLoop545 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_block_in_forLoop552 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXP_LIST_in_expressionList584 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList596 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_INDEXES_in_indexes634 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_indexes642 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_Identifier_in_variable673 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment692 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_assignment694 = new BitSet(new ulong[]{0xA000002FD00037C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_indexes_in_assignment696 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_assignment699 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_GLOBAL_ASSIGN_in_assignment724 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_assignment726 = new BitSet(new ulong[]{0xA000002FD00037C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_indexes_in_assignment728 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_assignment731 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_71_in_expression766 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression770 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression774 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_72_in_expression783 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression787 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression791 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_73_in_expression800 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression804 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression808 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_74_in_expression817 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression821 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression825 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_75_in_expression834 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression838 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression842 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_76_in_expression851 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression855 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression859 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_INT_NEGATE_in_expression868 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression872 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BOOL_NEGATE_in_expression881 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression885 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_expression894 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression898 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression902 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_69_in_expression911 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression915 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression919 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_68_in_expression928 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression932 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression936 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_70_in_expression945 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression949 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression953 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_66_in_expression962 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression966 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression970 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_65_in_expression979 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression983 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression987 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_64_in_expression996 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1000 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression1004 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_63_in_expression1013 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1017 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression1021 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_61_in_expression1030 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1034 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression1038 = new BitSet(new ulong[]{0xA000002FD00027C8UL,0x0000000000001FFFUL});
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
    public static readonly BitSet FOLLOW_Identifier_in_instantiateClass1203 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1205 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LOOKUP_in_lookup1232 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_objectFunctionCall_in_lookup1234 = new BitSet(new ulong[]{0x0000000000001008UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1238 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LOOKUP_in_lookup1250 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_lookup1252 = new BitSet(new ulong[]{0x0000000000001008UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1256 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LOOKUP_in_lookup1279 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_functionCall_in_lookup1281 = new BitSet(new ulong[]{0x0000000000001008UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1285 = new BitSet(new ulong[]{0x0000000000000008UL});

}
}