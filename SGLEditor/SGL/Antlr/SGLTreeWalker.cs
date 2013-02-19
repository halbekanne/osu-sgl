// $ANTLR 3.2 Sep 23, 2009 12:02:23 E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g 2013-02-20 00:38:15

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
internal partial class SGLTreeWalker : TreeParser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"BLOCK", 
		"DEF", 
		"GLOBALDEF", 
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
		"CLASS", 
		"Identifier", 
		"StringAtom", 
		"IntAtom", 
		"FloatAtom", 
		"BooleanAtom", 
		"LayerAtom", 
		"OriginAtom", 
		"LoopTypeAtom", 
		"LoopTriggerAtom", 
		"ColorAtom", 
		"Null", 
		"VarStartInit", 
		"Array", 
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
		"'='", 
		"'global'", 
		"'['", 
		"']'", 
		"'.'", 
		"'('", 
		"')'", 
		"'function'", 
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
    public const int CLASS = 30;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int DEF = 5;
    public const int T__62 = 62;
    public const int VAR_LIST = 18;
    public const int T__63 = 63;
    public const int Array = 43;
    public const int IntAtom = 33;
    public const int EXP_LIST = 17;
    public const int LoopTypeAtom = 38;
    public const int UTF8Letter = 46;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int HexDigit = 44;
    public const int BREAK = 21;
    public const int Identifier = 31;
    public const int IF = 24;
    public const int FUNC_CALL = 19;
    public const int AT = 23;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int Comment = 48;
    public const int EXP = 25;
    public const int OBJ_FUNC_CALL = 20;
    public const int FORITER = 28;
    public const int T__59 = 59;
    public const int INT_NEGATE = 9;
    public const int RETURN = 22;
    public const int UTF8Digit = 47;
    public const int WhiteSpace = 49;
    public const int T__50 = 50;
    public const int VARDEC = 12;
    public const int OriginAtom = 37;
    public const int Null = 41;
    public const int LayerAtom = 36;
    public const int GLOBAL_ASSIGN = 29;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int FORDEC = 26;
    public const int StringAtom = 32;
    public const int INDEXES = 14;
    public const int LoopTriggerAtom = 39;
    public const int ColorAtom = 40;
    public const int T__85 = 85;
    public const int T__84 = 84;
    public const int LIST = 16;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int T__88 = 88;
    public const int BOOL_NEGATE = 10;
    public const int BooleanAtom = 35;
    public const int LOOKUP = 15;
    public const int T__71 = 71;
    public const int FORCOND = 27;
    public const int T__72 = 72;
    public const int VARIABLE = 13;
    public const int T__70 = 70;
    public const int BLOCK = 4;
    public const int ASSIGN = 7;
    public const int VarStartInit = 42;
    public const int GLOBALDEF = 6;
    public const int T__76 = 76;
    public const int FloatAtom = 34;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int VARINC = 11;
    public const int T__73 = 73;
    public const int EscapeSequence = 45;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int STRING = 8;
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
		get { return "E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g"; }
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
        
       	public override String GetErrorMessage(RecognitionException e, String[] tokenNames) {
      		String message = base.GetErrorMessage(e, tokenNames);
      		throw new CompilerException(e, message); 
      	}
        
        /*  
    	public override void EmitErrorMessage(string msg)
    	{
    		throw new CompilerException(-1, 101, msg);
    		//throw new Exception(msg);
        }      */
    	
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:131:1: main returns [AbstractNode node] : block ;
    public AbstractNode main() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode block1 = default(AbstractNode);


        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:132:2: ( block )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:132:4: block
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:136:1: block returns [AbstractNode node] : ^( BLOCK ( statement )* ) ;
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:146:2: ( ^( BLOCK ( statement )* ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:146:4: ^( BLOCK ( statement )* )
            {
            	Match(input,BLOCK,FOLLOW_BLOCK_in_block104); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:147:10: ( statement )*
            	    do 
            	    {
            	        int alt1 = 2;
            	        int LA1_0 = input.LA(1);

            	        if ( ((LA1_0 >= DEF && LA1_0 <= ASSIGN) || (LA1_0 >= VARINC && LA1_0 <= VARDEC) || (LA1_0 >= FUNC_CALL && LA1_0 <= IF) || (LA1_0 >= 84 && LA1_0 <= 85)) )
            	        {
            	            alt1 = 1;
            	        }


            	        switch (alt1) 
            	    	{
            	    		case 1 :
            	    		    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:147:11: statement
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

             
              currentScope = currentScope.Parent; 

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:152:1: statement returns [AbstractNode node] : ( definition | assignment | unaryExpression | functionCall | objectFunctionCall | ifStatement | atStatement | whileLoop | forLoop | breakStat | returnStat );
    public AbstractNode statement() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode definition3 = default(AbstractNode);

        AbstractNode assignment4 = default(AbstractNode);

        AbstractNode unaryExpression5 = default(AbstractNode);

        AbstractNode functionCall6 = default(AbstractNode);

        AbstractNode objectFunctionCall7 = default(AbstractNode);

        AbstractNode ifStatement8 = default(AbstractNode);

        AbstractNode atStatement9 = default(AbstractNode);

        AbstractNode whileLoop10 = default(AbstractNode);

        AbstractNode forLoop11 = default(AbstractNode);

        AbstractNode breakStat12 = default(AbstractNode);

        AbstractNode returnStat13 = default(AbstractNode);


        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:154:2: ( definition | assignment | unaryExpression | functionCall | objectFunctionCall | ifStatement | atStatement | whileLoop | forLoop | breakStat | returnStat )
            int alt2 = 11;
            switch ( input.LA(1) ) 
            {
            case DEF:
            case GLOBALDEF:
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
            case FUNC_CALL:
            	{
                alt2 = 4;
                }
                break;
            case OBJ_FUNC_CALL:
            	{
                alt2 = 5;
                }
                break;
            case IF:
            	{
                alt2 = 6;
                }
                break;
            case AT:
            	{
                alt2 = 7;
                }
                break;
            case 84:
            	{
                alt2 = 8;
                }
                break;
            case 85:
            	{
                alt2 = 9;
                }
                break;
            case BREAK:
            	{
                alt2 = 10;
                }
                break;
            case RETURN:
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
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:154:4: definition
                    {
                    	PushFollow(FOLLOW_definition_in_statement163);
                    	definition3 = definition();
                    	state.followingStackPointer--;

                    	 node = definition3; 

                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:155:4: assignment
                    {
                    	PushFollow(FOLLOW_assignment_in_statement170);
                    	assignment4 = assignment();
                    	state.followingStackPointer--;

                    	 node = assignment4; 

                    }
                    break;
                case 3 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:156:4: unaryExpression
                    {
                    	PushFollow(FOLLOW_unaryExpression_in_statement178);
                    	unaryExpression5 = unaryExpression();
                    	state.followingStackPointer--;

                    	 node = unaryExpression5; 

                    }
                    break;
                case 4 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:157:4: functionCall
                    {
                    	PushFollow(FOLLOW_functionCall_in_statement185);
                    	functionCall6 = functionCall();
                    	state.followingStackPointer--;

                    	 node = functionCall6; 

                    }
                    break;
                case 5 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:158:4: objectFunctionCall
                    {
                    	PushFollow(FOLLOW_objectFunctionCall_in_statement193);
                    	objectFunctionCall7 = objectFunctionCall();
                    	state.followingStackPointer--;

                    	 node = objectFunctionCall7; 

                    }
                    break;
                case 6 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:159:4: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_statement201);
                    	ifStatement8 = ifStatement();
                    	state.followingStackPointer--;

                    	 node = ifStatement8; 

                    }
                    break;
                case 7 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:160:4: atStatement
                    {
                    	PushFollow(FOLLOW_atStatement_in_statement208);
                    	atStatement9 = atStatement();
                    	state.followingStackPointer--;

                    	 node = atStatement9; 

                    }
                    break;
                case 8 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:161:4: whileLoop
                    {
                    	PushFollow(FOLLOW_whileLoop_in_statement216);
                    	whileLoop10 = whileLoop();
                    	state.followingStackPointer--;

                    	 node = whileLoop10; 

                    }
                    break;
                case 9 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:162:4: forLoop
                    {
                    	PushFollow(FOLLOW_forLoop_in_statement223);
                    	forLoop11 = forLoop();
                    	state.followingStackPointer--;

                    	 node = forLoop11; 

                    }
                    break;
                case 10 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:163:4: breakStat
                    {
                    	PushFollow(FOLLOW_breakStat_in_statement230);
                    	breakStat12 = breakStat();
                    	state.followingStackPointer--;

                    	 node = breakStat12; 

                    }
                    break;
                case 11 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:164:4: returnStat
                    {
                    	PushFollow(FOLLOW_returnStat_in_statement237);
                    	returnStat13 = returnStat();
                    	state.followingStackPointer--;

                    	 node = returnStat13; 

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:168:1: atStatement returns [AbstractNode node] : ^( AT expression block ) ;
    public AbstractNode atStatement() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode expression14 = default(AbstractNode);

        AbstractNode block15 = default(AbstractNode);


        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:169:2: ( ^( AT expression block ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:169:4: ^( AT expression block )
            {
            	Match(input,AT,FOLLOW_AT_in_atStatement262); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_atStatement264);
            	expression14 = expression();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_block_in_atStatement266);
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:172:1: returnStat returns [AbstractNode node] : ^( RETURN ( expression )? ) ;
    public AbstractNode returnStat() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode expression16 = default(AbstractNode);


        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:173:2: ( ^( RETURN ( expression )? ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:173:4: ^( RETURN ( expression )? )
            {
            	Match(input,RETURN,FOLLOW_RETURN_in_returnStat286); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:173:13: ( expression )?
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= STRING && LA3_0 <= VARDEC) || LA3_0 == LOOKUP || LA3_0 == CLASS || (LA3_0 >= IntAtom && LA3_0 <= LoopTriggerAtom) || LA3_0 == Null || LA3_0 == 62 || (LA3_0 >= 64 && LA3_0 <= 77)) )
            	    {
            	        alt3 = 1;
            	    }
            	    switch (alt3) 
            	    {
            	        case 1 :
            	            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:173:13: expression
            	            {
            	            	PushFollow(FOLLOW_expression_in_returnStat288);
            	            	expression16 = expression();
            	            	state.followingStackPointer--;


            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
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


    // $ANTLR start "functionCall"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:176:1: functionCall returns [AbstractNode node] : ^( FUNC_CALL Identifier ( expressionList )? ) ;
    public AbstractNode functionCall() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier17 = null;
        List<AbstractNode> expressionList18 = default(List<AbstractNode>);


        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:177:2: ( ^( FUNC_CALL Identifier ( expressionList )? ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:177:4: ^( FUNC_CALL Identifier ( expressionList )? )
            {
            	Match(input,FUNC_CALL,FOLLOW_FUNC_CALL_in_functionCall311); 

            	Match(input, Token.DOWN, null); 
            	Identifier17=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_functionCall313); 
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:177:27: ( expressionList )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == EXP_LIST) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:177:27: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_functionCall315);
            	        	expressionList18 = expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); 
            	 node = new InvokeFunctionNode(((Identifier17 != null) ? Identifier17.Text : null), expressionList18, Identifier17.Line); 

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:180:1: breakStat returns [AbstractNode node] : BREAK ;
    public AbstractNode breakStat() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree BREAK19 = null;

        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:181:2: ( BREAK )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:181:4: BREAK
            {
            	BREAK19=(CommonTree)Match(input,BREAK,FOLLOW_BREAK_in_breakStat336); 
            	 node = new BreakNode(BREAK19.Line); 

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:184:1: objectFunctionCall returns [AbstractNode node] : ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? ) ;
    public AbstractNode objectFunctionCall() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier22 = null;
        String variable20 = default(String);

        List<AbstractNode> indexes21 = default(List<AbstractNode>);

        List<AbstractNode> expressionList23 = default(List<AbstractNode>);


        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:185:2: ( ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:185:4: ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? )
            {
            	Match(input,OBJ_FUNC_CALL,FOLLOW_OBJ_FUNC_CALL_in_objectFunctionCall355); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variable_in_objectFunctionCall357);
            	variable20 = variable();
            	state.followingStackPointer--;

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:185:29: ( indexes )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == INDEXES) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:185:29: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_objectFunctionCall359);
            	        	indexes21 = indexes();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Identifier22=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_objectFunctionCall362); 
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:185:49: ( expressionList )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == EXP_LIST) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:185:49: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_objectFunctionCall364);
            	        	expressionList23 = expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); 
            	 node = new InvokeFunctionNode(variable20, indexes21, ((Identifier22 != null) ? Identifier22.Text : null), expressionList23, currentScope, Identifier22.Line); 

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:189:1: whileLoop returns [AbstractNode node] : ^( 'while' expression block ) ;
    public AbstractNode whileLoop() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode expression24 = default(AbstractNode);

        AbstractNode block25 = default(AbstractNode);


        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:190:2: ( ^( 'while' expression block ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:190:4: ^( 'while' expression block )
            {
            	Match(input,84,FOLLOW_84_in_whileLoop387); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_whileLoop389);
            	expression24 = expression();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_block_in_whileLoop391);
            	block25 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new WhileNode(expression24, block25); 

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:194:1: ifStatement returns [AbstractNode node] : ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) ;
    public AbstractNode ifStatement() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode b1 = default(AbstractNode);

        AbstractNode b2 = default(AbstractNode);

        AbstractNode expression26 = default(AbstractNode);


         
          IfNode ifNode = new IfNode(); 
          node = ifNode; 

        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:199:3: ( ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:199:6: ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? )
            {
            	Match(input,IF,FOLLOW_IF_in_ifStatement424); 

            	Match(input, Token.DOWN, null); 
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:200:8: ( ^( EXP expression b1= block ) )+
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

            	            if ( ((LA7_3 >= STRING && LA7_3 <= VARDEC) || LA7_3 == LOOKUP || LA7_3 == CLASS || (LA7_3 >= IntAtom && LA7_3 <= LoopTriggerAtom) || LA7_3 == Null || LA7_3 == 62 || (LA7_3 >= 64 && LA7_3 <= 77)) )
            	            {
            	                alt7 = 1;
            	            }


            	        }


            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:200:9: ^( EXP expression b1= block )
            			    {
            			    	Match(input,EXP,FOLLOW_EXP_in_ifStatement438); 

            			    	Match(input, Token.DOWN, null); 
            			    	PushFollow(FOLLOW_expression_in_ifStatement440);
            			    	expression26 = expression();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_block_in_ifStatement444);
            			    	b1 = block();
            			    	state.followingStackPointer--;


            			    	Match(input, Token.UP, null); 
            			    	 ifNode.AddChoice(expression26,b1); 

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

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:201:8: ( ^( EXP b2= block ) )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == EXP) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:201:9: ^( EXP b2= block )
            	        {
            	        	Match(input,EXP,FOLLOW_EXP_in_ifStatement464); 

            	        	Match(input, Token.DOWN, null); 
            	        	PushFollow(FOLLOW_block_in_ifStatement468);
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:205:1: forLoop returns [AbstractNode node] : ^( 'for' ^( FORDEC (dec= statement )* ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block ) ;
    public AbstractNode forLoop() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        AbstractNode dec = default(AbstractNode);

        AbstractNode cond = default(AbstractNode);

        AbstractNode iter = default(AbstractNode);

        AbstractNode block27 = default(AbstractNode);



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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:2: ( ^( 'for' ^( FORDEC (dec= statement )* ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:4: ^( 'for' ^( FORDEC (dec= statement )* ) ^( FORCOND (cond= expression )? ) ^( FORITER (iter= statement )? ) block )
            {
            	Match(input,85,FOLLOW_85_in_forLoop517); 

            	Match(input, Token.DOWN, null); 
            	Match(input,FORDEC,FOLLOW_FORDEC_in_forLoop520); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:21: (dec= statement )*
            	    do 
            	    {
            	        int alt9 = 2;
            	        int LA9_0 = input.LA(1);

            	        if ( ((LA9_0 >= DEF && LA9_0 <= ASSIGN) || (LA9_0 >= VARINC && LA9_0 <= VARDEC) || (LA9_0 >= FUNC_CALL && LA9_0 <= IF) || (LA9_0 >= 84 && LA9_0 <= 85)) )
            	        {
            	            alt9 = 1;
            	        }


            	        switch (alt9) 
            	    	{
            	    		case 1 :
            	    		    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:22: dec= statement
            	    		    {
            	    		    	PushFollow(FOLLOW_statement_in_forLoop525);
            	    		    	dec = statement();
            	    		    	state.followingStackPointer--;

            	    		    	 forNode.Init = dec; 

            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop9;
            	        }
            	    } while (true);

            	    loop9:
            	    	;	// Stops C# compiler whining that label 'loop9' has no statements


            	    Match(input, Token.UP, null); 
            	}
            	Match(input,FORCOND,FOLLOW_FORCOND_in_forLoop534); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:80: (cond= expression )?
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= STRING && LA10_0 <= VARDEC) || LA10_0 == LOOKUP || LA10_0 == CLASS || (LA10_0 >= IntAtom && LA10_0 <= LoopTriggerAtom) || LA10_0 == Null || LA10_0 == 62 || (LA10_0 >= 64 && LA10_0 <= 77)) )
            	    {
            	        alt10 = 1;
            	    }
            	    switch (alt10) 
            	    {
            	        case 1 :
            	            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:81: cond= expression
            	            {
            	            	PushFollow(FOLLOW_expression_in_forLoop539);
            	            	cond = expression();
            	            	state.followingStackPointer--;

            	            	 forNode.Condition = cond; 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	Match(input,FORITER,FOLLOW_FORITER_in_forLoop547); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:146: (iter= statement )?
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= DEF && LA11_0 <= ASSIGN) || (LA11_0 >= VARINC && LA11_0 <= VARDEC) || (LA11_0 >= FUNC_CALL && LA11_0 <= IF) || (LA11_0 >= 84 && LA11_0 <= 85)) )
            	    {
            	        alt11 = 1;
            	    }
            	    switch (alt11) 
            	    {
            	        case 1 :
            	            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:223:147: iter= statement
            	            {
            	            	PushFollow(FOLLOW_statement_in_forLoop552);
            	            	iter = statement();
            	            	state.followingStackPointer--;

            	            	 forNode.Iteration = iter; 

            	            }
            	            break;

            	    }


            	    Match(input, Token.UP, null); 
            	}
            	PushFollow(FOLLOW_block_in_forLoop559);
            	block27 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 forNode.Block = block27; 

            }

             
              currentScope = currentScope.Parent; 

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:228:1: expressionList returns [List<AbstractNode> list] : ^( EXP_LIST ( expression )+ ) ;
    public List<AbstractNode> expressionList() // throws RecognitionException [1]
    {   
        List<AbstractNode> list = default(List<AbstractNode>);

        AbstractNode expression28 = default(AbstractNode);


         list = new List<AbstractNode>(); 
        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:230:5: ( ^( EXP_LIST ( expression )+ ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:230:7: ^( EXP_LIST ( expression )+ )
            {
            	Match(input,EXP_LIST,FOLLOW_EXP_LIST_in_expressionList591); 

            	Match(input, Token.DOWN, null); 
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:231:7: ( expression )+
            	int cnt12 = 0;
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= STRING && LA12_0 <= VARDEC) || LA12_0 == LOOKUP || LA12_0 == CLASS || (LA12_0 >= IntAtom && LA12_0 <= LoopTriggerAtom) || LA12_0 == Null || LA12_0 == 62 || (LA12_0 >= 64 && LA12_0 <= 77)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:231:8: expression
            			    {
            			    	PushFollow(FOLLOW_expression_in_expressionList603);
            			    	expression28 = expression();
            			    	state.followingStackPointer--;

            			    	list.Add(expression28);

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:235:1: indexes returns [List<AbstractNode> list] : ^( INDEXES ( expression )+ ) ;
    public List<AbstractNode> indexes() // throws RecognitionException [1]
    {   
        List<AbstractNode> list = default(List<AbstractNode>);

        AbstractNode expression29 = default(AbstractNode);


         list = new List<AbstractNode>(); 
        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:237:3: ( ^( INDEXES ( expression )+ ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:237:6: ^( INDEXES ( expression )+ )
            {
            	Match(input,INDEXES,FOLLOW_INDEXES_in_indexes641); 

            	Match(input, Token.DOWN, null); 
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:238:5: ( expression )+
            	int cnt13 = 0;
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= STRING && LA13_0 <= VARDEC) || LA13_0 == LOOKUP || LA13_0 == CLASS || (LA13_0 >= IntAtom && LA13_0 <= LoopTriggerAtom) || LA13_0 == Null || LA13_0 == 62 || (LA13_0 >= 64 && LA13_0 <= 77)) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:238:6: expression
            			    {
            			    	PushFollow(FOLLOW_expression_in_indexes649);
            			    	expression29 = expression();
            			    	state.followingStackPointer--;

            			    	list.Add(expression29);

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:242:1: variable returns [String txt] : Identifier ;
    public String variable() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree Identifier30 = null;

        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:243:2: ( Identifier )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:243:4: Identifier
            {
            	Identifier30=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variable680); 
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
    // $ANTLR end "variable"


    // $ANTLR start "assignment"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:246:1: assignment returns [AbstractNode node] : ^( ASSIGN Identifier ( indexes )? expression ) ;
    public AbstractNode assignment() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier31 = null;
        List<AbstractNode> indexes32 = default(List<AbstractNode>);

        AbstractNode expression33 = default(AbstractNode);


        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:247:2: ( ^( ASSIGN Identifier ( indexes )? expression ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:247:4: ^( ASSIGN Identifier ( indexes )? expression )
            {
            	Match(input,ASSIGN,FOLLOW_ASSIGN_in_assignment699); 

            	Match(input, Token.DOWN, null); 
            	Identifier31=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_assignment701); 
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:247:24: ( indexes )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == INDEXES) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:247:24: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_assignment703);
            	        	indexes32 = indexes();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_expression_in_assignment706);
            	expression33 = expression();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new AssignVariableNode(((Identifier31 != null) ? Identifier31.Text : null),indexes32,expression33,currentScope,Identifier31.Line); 

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


    // $ANTLR start "definition"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:259:1: definition returns [AbstractNode node] : ( ^( DEF Identifier ) | ^( GLOBALDEF Identifier ) );
    public AbstractNode definition() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier34 = null;
        CommonTree Identifier35 = null;

        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:260:2: ( ^( DEF Identifier ) | ^( GLOBALDEF Identifier ) )
            int alt15 = 2;
            int LA15_0 = input.LA(1);

            if ( (LA15_0 == DEF) )
            {
                alt15 = 1;
            }
            else if ( (LA15_0 == GLOBALDEF) )
            {
                alt15 = 2;
            }
            else 
            {
                NoViableAltException nvae_d15s0 =
                    new NoViableAltException("", 15, 0, input);

                throw nvae_d15s0;
            }
            switch (alt15) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:260:4: ^( DEF Identifier )
                    {
                    	Match(input,DEF,FOLLOW_DEF_in_definition762); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier34=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_definition764); 

                    	Match(input, Token.UP, null); 
                    	 node = new DefineVariableNode(((Identifier34 != null) ? Identifier34.Text : null),currentScope,Identifier34.Line); 

                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:262:4: ^( GLOBALDEF Identifier )
                    {
                    	Match(input,GLOBALDEF,FOLLOW_GLOBALDEF_in_definition785); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier35=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_definition787); 

                    	Match(input, Token.UP, null); 
                    	 node = new DefineVariableNode(((Identifier35 != null) ? Identifier35.Text : null),Identifier35.Line); 

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
    // $ANTLR end "definition"


    // $ANTLR start "expression"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:270:1: expression returns [AbstractNode node] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( '^' a= expression b= expression ) | ^( INT_NEGATE a= expression ) | ^( BOOL_NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | LayerAtom | OriginAtom | LoopTypeAtom | LoopTriggerAtom | Null | instantiateClass | lookup | unaryExpression );
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
        CommonTree LoopTriggerAtom43 = null;
        CommonTree Null44 = null;
        AbstractNode a = default(AbstractNode);

        AbstractNode b = default(AbstractNode);

        AbstractNode c = default(AbstractNode);

        AbstractNode instantiateClass45 = default(AbstractNode);

        AbstractNode lookup46 = default(AbstractNode);

        AbstractNode unaryExpression47 = default(AbstractNode);


        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:271:2: ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( '^' a= expression b= expression ) | ^( INT_NEGATE a= expression ) | ^( BOOL_NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | LayerAtom | OriginAtom | LoopTypeAtom | LoopTriggerAtom | Null | instantiateClass | lookup | unaryExpression )
            int alt16 = 29;
            switch ( input.LA(1) ) 
            {
            case 72:
            	{
                alt16 = 1;
                }
                break;
            case 73:
            	{
                alt16 = 2;
                }
                break;
            case 74:
            	{
                alt16 = 3;
                }
                break;
            case 75:
            	{
                alt16 = 4;
                }
                break;
            case 76:
            	{
                alt16 = 5;
                }
                break;
            case 77:
            	{
                alt16 = 6;
                }
                break;
            case INT_NEGATE:
            	{
                alt16 = 7;
                }
                break;
            case BOOL_NEGATE:
            	{
                alt16 = 8;
                }
                break;
            case 68:
            	{
                alt16 = 9;
                }
                break;
            case 70:
            	{
                alt16 = 10;
                }
                break;
            case 69:
            	{
                alt16 = 11;
                }
                break;
            case 71:
            	{
                alt16 = 12;
                }
                break;
            case 67:
            	{
                alt16 = 13;
                }
                break;
            case 66:
            	{
                alt16 = 14;
                }
                break;
            case 65:
            	{
                alt16 = 15;
                }
                break;
            case 64:
            	{
                alt16 = 16;
                }
                break;
            case 62:
            	{
                alt16 = 17;
                }
                break;
            case IntAtom:
            	{
                alt16 = 18;
                }
                break;
            case FloatAtom:
            	{
                alt16 = 19;
                }
                break;
            case BooleanAtom:
            	{
                alt16 = 20;
                }
                break;
            case STRING:
            	{
                alt16 = 21;
                }
                break;
            case LayerAtom:
            	{
                alt16 = 22;
                }
                break;
            case OriginAtom:
            	{
                alt16 = 23;
                }
                break;
            case LoopTypeAtom:
            	{
                alt16 = 24;
                }
                break;
            case LoopTriggerAtom:
            	{
                alt16 = 25;
                }
                break;
            case Null:
            	{
                alt16 = 26;
                }
                break;
            case CLASS:
            	{
                alt16 = 27;
                }
                break;
            case LOOKUP:
            	{
                alt16 = 28;
                }
                break;
            case VARINC:
            case VARDEC:
            	{
                alt16 = 29;
                }
                break;
            	default:
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            }

            switch (alt16) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:271:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,72,FOLLOW_72_in_expression828); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression832);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression836);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new AddNode(a, b); 

                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:272:4: ^( '-' a= expression b= expression )
                    {
                    	Match(input,73,FOLLOW_73_in_expression845); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression849);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression853);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new SubNode(a, b); 

                    }
                    break;
                case 3 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:273:4: ^( '*' a= expression b= expression )
                    {
                    	Match(input,74,FOLLOW_74_in_expression862); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression866);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression870);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MultNode(a, b); 

                    }
                    break;
                case 4 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:274:4: ^( '/' a= expression b= expression )
                    {
                    	Match(input,75,FOLLOW_75_in_expression879); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression883);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression887);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new DivNode(a, b); 

                    }
                    break;
                case 5 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:275:4: ^( '%' a= expression b= expression )
                    {
                    	Match(input,76,FOLLOW_76_in_expression896); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression900);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression904);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new ModNode(a, b); 

                    }
                    break;
                case 6 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:276:4: ^( '^' a= expression b= expression )
                    {
                    	Match(input,77,FOLLOW_77_in_expression913); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression917);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression921);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new PowNode(a, b); 

                    }
                    break;
                case 7 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:277:4: ^( INT_NEGATE a= expression )
                    {
                    	Match(input,INT_NEGATE,FOLLOW_INT_NEGATE_in_expression930); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression934);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NegateIntNode(a); 

                    }
                    break;
                case 8 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:278:4: ^( BOOL_NEGATE a= expression )
                    {
                    	Match(input,BOOL_NEGATE,FOLLOW_BOOL_NEGATE_in_expression943); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression947);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NegateBoolNode(a); 

                    }
                    break;
                case 9 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:279:4: ^( '<' a= expression b= expression )
                    {
                    	Match(input,68,FOLLOW_68_in_expression956); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression960);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression964);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new LowerThanNode(a, b); 

                    }
                    break;
                case 10 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:280:4: ^( '<=' a= expression b= expression )
                    {
                    	Match(input,70,FOLLOW_70_in_expression973); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression977);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression981);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new LowerThanEqualsNode(a, b); 

                    }
                    break;
                case 11 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:281:4: ^( '>' a= expression b= expression )
                    {
                    	Match(input,69,FOLLOW_69_in_expression990); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression994);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression998);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new GreaterThanNode(a, b); 

                    }
                    break;
                case 12 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:282:4: ^( '>=' a= expression b= expression )
                    {
                    	Match(input,71,FOLLOW_71_in_expression1007); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression1011);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1015);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new GreaterThanEqualsNode(a, b); 

                    }
                    break;
                case 13 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:283:4: ^( '!=' a= expression b= expression )
                    {
                    	Match(input,67,FOLLOW_67_in_expression1024); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression1028);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1032);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NotEqualsNode(a, b); 

                    }
                    break;
                case 14 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:284:4: ^( '==' a= expression b= expression )
                    {
                    	Match(input,66,FOLLOW_66_in_expression1041); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression1045);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1049);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new EqualsNode(a, b); 

                    }
                    break;
                case 15 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:285:4: ^( '&&' a= expression b= expression )
                    {
                    	Match(input,65,FOLLOW_65_in_expression1058); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression1062);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1066);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new AndNode(a, b); 

                    }
                    break;
                case 16 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:286:4: ^( '||' a= expression b= expression )
                    {
                    	Match(input,64,FOLLOW_64_in_expression1075); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression1079);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1083);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new OrNode(a, b); 

                    }
                    break;
                case 17 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:287:4: ^( '?' a= expression b= expression c= expression )
                    {
                    	Match(input,62,FOLLOW_62_in_expression1092); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression1096);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1100);
                    	b = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression1104);
                    	c = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new ConditionalNode(a, b, c); 

                    }
                    break;
                case 18 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:288:6: IntAtom
                    {
                    	IntAtom36=(CommonTree)Match(input,IntAtom,FOLLOW_IntAtom_in_expression1114); 
                    	 node = new AtomNode(int.Parse(((IntAtom36 != null) ? IntAtom36.Text : null), System.Globalization.CultureInfo.InvariantCulture), ValType.Integer, IntAtom36.Line); 

                    }
                    break;
                case 19 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:289:4: FloatAtom
                    {
                    	FloatAtom37=(CommonTree)Match(input,FloatAtom,FOLLOW_FloatAtom_in_expression1121); 
                    	 node = new AtomNode(Double.Parse(((FloatAtom37 != null) ? FloatAtom37.Text : null), System.Globalization.CultureInfo.InvariantCulture), ValType.Double,  FloatAtom37.Line); 

                    }
                    break;
                case 20 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:290:6: BooleanAtom
                    {
                    	BooleanAtom38=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression1130); 
                    	 node = new AtomNode(Boolean.Parse(((BooleanAtom38 != null) ? BooleanAtom38.Text : null)), ValType.Boolean, BooleanAtom38.Line); 

                    }
                    break;
                case 21 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:291:4: ^( STRING StringAtom )
                    {
                    	Match(input,STRING,FOLLOW_STRING_in_expression1138); 

                    	Match(input, Token.DOWN, null); 
                    	StringAtom39=(CommonTree)Match(input,StringAtom,FOLLOW_StringAtom_in_expression1140); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode((((StringAtom39 != null) ? StringAtom39.Text : null)).Substring(1, (((StringAtom39 != null) ? StringAtom39.Text : null)).Length-2), ValType.String, StringAtom39.Line); 

                    }
                    break;
                case 22 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:292:4: LayerAtom
                    {
                    	LayerAtom40=(CommonTree)Match(input,LayerAtom,FOLLOW_LayerAtom_in_expression1148); 
                    	 node = new AtomNode(((LayerAtom40 != null) ? LayerAtom40.Text : null), ValType.Layer, LayerAtom40.Line); 

                    }
                    break;
                case 23 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:293:4: OriginAtom
                    {
                    	OriginAtom41=(CommonTree)Match(input,OriginAtom,FOLLOW_OriginAtom_in_expression1155); 
                    	 node = new AtomNode(((OriginAtom41 != null) ? OriginAtom41.Text : null), ValType.Origin, OriginAtom41.Line); 

                    }
                    break;
                case 24 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:294:4: LoopTypeAtom
                    {
                    	LoopTypeAtom42=(CommonTree)Match(input,LoopTypeAtom,FOLLOW_LoopTypeAtom_in_expression1162); 
                    	 node = new AtomNode(((LoopTypeAtom42 != null) ? LoopTypeAtom42.Text : null), ValType.LoopType, LoopTypeAtom42.Line); 

                    }
                    break;
                case 25 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:295:4: LoopTriggerAtom
                    {
                    	LoopTriggerAtom43=(CommonTree)Match(input,LoopTriggerAtom,FOLLOW_LoopTriggerAtom_in_expression1169); 
                    	 node = new AtomNode(((LoopTriggerAtom43 != null) ? LoopTriggerAtom43.Text : null), ValType.LoopTrigger, LoopTriggerAtom43.Line); 

                    }
                    break;
                case 26 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:297:4: Null
                    {
                    	Null44=(CommonTree)Match(input,Null,FOLLOW_Null_in_expression1178); 
                    	 node = new AtomNode(((Null44 != null) ? Null44.Text : null), ValType.Null,  Null44.Line); 

                    }
                    break;
                case 27 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:298:4: instantiateClass
                    {
                    	PushFollow(FOLLOW_instantiateClass_in_expression1185);
                    	instantiateClass45 = instantiateClass();
                    	state.followingStackPointer--;

                    	 node = instantiateClass45; 

                    }
                    break;
                case 28 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:299:4: lookup
                    {
                    	PushFollow(FOLLOW_lookup_in_expression1192);
                    	lookup46 = lookup();
                    	state.followingStackPointer--;

                    	 node = lookup46; 

                    }
                    break;
                case 29 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:300:4: unaryExpression
                    {
                    	PushFollow(FOLLOW_unaryExpression_in_expression1199);
                    	unaryExpression47 = unaryExpression();
                    	state.followingStackPointer--;

                    	 node = unaryExpression47; 

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:304:1: unaryExpression returns [AbstractNode node] : ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) );
    public AbstractNode unaryExpression() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier48 = null;
        CommonTree Identifier49 = null;

        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:305:5: ( ^( VARINC Identifier ) | ^( VARDEC Identifier ) )
            int alt17 = 2;
            int LA17_0 = input.LA(1);

            if ( (LA17_0 == VARINC) )
            {
                alt17 = 1;
            }
            else if ( (LA17_0 == VARDEC) )
            {
                alt17 = 2;
            }
            else 
            {
                NoViableAltException nvae_d17s0 =
                    new NoViableAltException("", 17, 0, input);

                throw nvae_d17s0;
            }
            switch (alt17) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:305:9: ^( VARINC Identifier )
                    {
                    	Match(input,VARINC,FOLLOW_VARINC_in_unaryExpression1237); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier48=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_unaryExpression1239); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarIncNode(((Identifier48 != null) ? Identifier48.Text : null), currentScope, Identifier48.Line); 

                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:306:4: ^( VARDEC Identifier )
                    {
                    	Match(input,VARDEC,FOLLOW_VARDEC_in_unaryExpression1248); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier49=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_unaryExpression1250); 

                    	Match(input, Token.UP, null); 
                    	 node = new VarDecNode(((Identifier49 != null) ? Identifier49.Text : null), currentScope, Identifier49.Line); 

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:310:1: instantiateClass returns [AbstractNode node] : ^( CLASS Identifier ( expressionList )? ) ;
    public AbstractNode instantiateClass() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier50 = null;
        List<AbstractNode> expressionList51 = default(List<AbstractNode>);


        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:311:2: ( ^( CLASS Identifier ( expressionList )? ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:311:4: ^( CLASS Identifier ( expressionList )? )
            {
            	Match(input,CLASS,FOLLOW_CLASS_in_instantiateClass1272); 

            	Match(input, Token.DOWN, null); 
            	Identifier50=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_instantiateClass1274); 
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:311:23: ( expressionList )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == EXP_LIST) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:311:23: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_instantiateClass1276);
            	        	expressionList51 = expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}


            	Match(input, Token.UP, null); 
            	  node = new InstanciateClassNode(((Identifier50 != null) ? Identifier50.Text : null), expressionList51, Identifier50.Line); 

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:314:1: lookup returns [AbstractNode node] : ( ^( LOOKUP objectFunctionCall (i= indexes )? ) | ^( LOOKUP Identifier (i= indexes )? ) | ^( LOOKUP functionCall (i= indexes )? ) );
    public AbstractNode lookup() // throws RecognitionException [1]
    {   
        AbstractNode node = default(AbstractNode);

        CommonTree Identifier53 = null;
        List<AbstractNode> i = default(List<AbstractNode>);

        AbstractNode objectFunctionCall52 = default(AbstractNode);

        AbstractNode functionCall54 = default(AbstractNode);


        try 
    	{
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:315:3: ( ^( LOOKUP objectFunctionCall (i= indexes )? ) | ^( LOOKUP Identifier (i= indexes )? ) | ^( LOOKUP functionCall (i= indexes )? ) )
            int alt22 = 3;
            int LA22_0 = input.LA(1);

            if ( (LA22_0 == LOOKUP) )
            {
                int LA22_1 = input.LA(2);

                if ( (LA22_1 == DOWN) )
                {
                    switch ( input.LA(3) ) 
                    {
                    case Identifier:
                    	{
                        alt22 = 2;
                        }
                        break;
                    case FUNC_CALL:
                    	{
                        alt22 = 3;
                        }
                        break;
                    case OBJ_FUNC_CALL:
                    	{
                        alt22 = 1;
                        }
                        break;
                    	default:
                    	    NoViableAltException nvae_d22s2 =
                    	        new NoViableAltException("", 22, 2, input);

                    	    throw nvae_d22s2;
                    }

                }
                else 
                {
                    NoViableAltException nvae_d22s1 =
                        new NoViableAltException("", 22, 1, input);

                    throw nvae_d22s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d22s0 =
                    new NoViableAltException("", 22, 0, input);

                throw nvae_d22s0;
            }
            switch (alt22) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:315:6: ^( LOOKUP objectFunctionCall (i= indexes )? )
                    {
                    	Match(input,LOOKUP,FOLLOW_LOOKUP_in_lookup1303); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_objectFunctionCall_in_lookup1305);
                    	objectFunctionCall52 = objectFunctionCall();
                    	state.followingStackPointer--;

                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:315:35: (i= indexes )?
                    	int alt19 = 2;
                    	int LA19_0 = input.LA(1);

                    	if ( (LA19_0 == INDEXES) )
                    	{
                    	    alt19 = 1;
                    	}
                    	switch (alt19) 
                    	{
                    	    case 1 :
                    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:315:35: i= indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1309);
                    	        	i = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	node = i != null ? new LookupNode(objectFunctionCall52, i) : objectFunctionCall52;

                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:316:6: ^( LOOKUP Identifier (i= indexes )? )
                    {
                    	Match(input,LOOKUP,FOLLOW_LOOKUP_in_lookup1321); 

                    	Match(input, Token.DOWN, null); 
                    	Identifier53=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_lookup1323); 
                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:316:27: (i= indexes )?
                    	int alt20 = 2;
                    	int LA20_0 = input.LA(1);

                    	if ( (LA20_0 == INDEXES) )
                    	{
                    	    alt20 = 1;
                    	}
                    	switch (alt20) 
                    	{
                    	    case 1 :
                    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:316:27: i= indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1327);
                    	        	i = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	AbstractNode identNode = new IdentifierNode(((Identifier53 != null) ? Identifier53.Text : null), currentScope, Identifier53.Line);
                    	  	node = i != null ? new LookupNode(identNode, i) : identNode;

                    }
                    break;
                case 3 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:319:6: ^( LOOKUP functionCall (i= indexes )? )
                    {
                    	Match(input,LOOKUP,FOLLOW_LOOKUP_in_lookup1350); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_functionCall_in_lookup1352);
                    	functionCall54 = functionCall();
                    	state.followingStackPointer--;

                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:319:29: (i= indexes )?
                    	int alt21 = 2;
                    	int LA21_0 = input.LA(1);

                    	if ( (LA21_0 == INDEXES) )
                    	{
                    	    alt21 = 1;
                    	}
                    	switch (alt21) 
                    	{
                    	    case 1 :
                    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGLTreeWalker.g:319:29: i= indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1356);
                    	        	i = indexes();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    	Match(input, Token.UP, null); 
                    	node = i != null ? new LookupNode(functionCall54, i) : node = functionCall54;

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
    public static readonly BitSet FOLLOW_statement_in_block119 = new BitSet(new ulong[]{0x0000000001F818E8UL,0x0000000000300000UL});
    public static readonly BitSet FOLLOW_definition_in_statement163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_statement170 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_statement178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_functionCall_in_statement185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectFunctionCall_in_statement193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement201 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atStatement_in_statement208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forLoop_in_statement223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_breakStat_in_statement230 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_returnStat_in_statement237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_AT_in_atStatement262 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_atStatement264 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_atStatement266 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_RETURN_in_returnStat286 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_returnStat288 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FUNC_CALL_in_functionCall311 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionCall313 = new BitSet(new ulong[]{0x0000000000020008UL});
    public static readonly BitSet FOLLOW_expressionList_in_functionCall315 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BREAK_in_breakStat336 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJ_FUNC_CALL_in_objectFunctionCall355 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variable_in_objectFunctionCall357 = new BitSet(new ulong[]{0x0000000080004000UL});
    public static readonly BitSet FOLLOW_indexes_in_objectFunctionCall359 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectFunctionCall362 = new BitSet(new ulong[]{0x0000000000020008UL});
    public static readonly BitSet FOLLOW_expressionList_in_objectFunctionCall364 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_84_in_whileLoop387 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop389 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_whileLoop391 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IF_in_ifStatement424 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement438 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_ifStatement440 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement444 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement464 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement468 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_85_in_forLoop517 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_FORDEC_in_forLoop520 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_forLoop525 = new BitSet(new ulong[]{0x0000000001F818E8UL,0x0000000000300000UL});
    public static readonly BitSet FOLLOW_FORCOND_in_forLoop534 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop539 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_FORITER_in_forLoop547 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_forLoop552 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_block_in_forLoop559 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXP_LIST_in_expressionList591 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList603 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_INDEXES_in_indexes641 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_indexes649 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_Identifier_in_variable680 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_assignment699 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_assignment701 = new BitSet(new ulong[]{0x400002FE4000DF08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_indexes_in_assignment703 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_assignment706 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_DEF_in_definition762 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_definition764 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_GLOBALDEF_in_definition785 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_definition787 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_72_in_expression828 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression832 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression836 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_73_in_expression845 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression849 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression853 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_74_in_expression862 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression866 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression870 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_75_in_expression879 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression883 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression887 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_76_in_expression896 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression900 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression904 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_77_in_expression913 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression917 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression921 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_INT_NEGATE_in_expression930 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression934 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_BOOL_NEGATE_in_expression943 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression947 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_68_in_expression956 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression960 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression964 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_70_in_expression973 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression977 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression981 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_69_in_expression990 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression994 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression998 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_71_in_expression1007 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1011 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression1015 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_expression1024 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1028 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression1032 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_66_in_expression1041 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1045 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression1049 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_65_in_expression1058 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1062 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression1066 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_64_in_expression1075 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1079 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression1083 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_62_in_expression1092 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression1096 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression1100 = new BitSet(new ulong[]{0x400002FE40009F08UL,0x0000000000003FFFUL});
    public static readonly BitSet FOLLOW_expression_in_expression1104 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IntAtom_in_expression1114 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_expression1121 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_expression1130 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_expression1138 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_StringAtom_in_expression1140 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LayerAtom_in_expression1148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OriginAtom_in_expression1155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LoopTypeAtom_in_expression1162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LoopTriggerAtom_in_expression1169 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Null_in_expression1178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_instantiateClass_in_expression1185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookup_in_expression1192 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_expression1199 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARINC_in_unaryExpression1237 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_unaryExpression1239 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEC_in_unaryExpression1248 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_unaryExpression1250 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_CLASS_in_instantiateClass1272 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_instantiateClass1274 = new BitSet(new ulong[]{0x0000000000020008UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1276 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LOOKUP_in_lookup1303 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_objectFunctionCall_in_lookup1305 = new BitSet(new ulong[]{0x0000000000004008UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1309 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LOOKUP_in_lookup1321 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Identifier_in_lookup1323 = new BitSet(new ulong[]{0x0000000000004008UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1327 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_LOOKUP_in_lookup1350 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_functionCall_in_lookup1352 = new BitSet(new ulong[]{0x0000000000004008UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1356 = new BitSet(new ulong[]{0x0000000000000008UL});

}
}