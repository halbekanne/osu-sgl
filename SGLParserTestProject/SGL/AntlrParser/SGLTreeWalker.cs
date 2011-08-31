// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g 2011-08-31 23:18:28

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
		"';'", 
		"','", 
		"'='", 
		"'.'", 
		"'while'", 
		"'for'", 
		"'if'", 
		"'else'", 
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
		"'!'", 
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
    public const int Origin = 31;
    public const int SGLIDDigit = 35;
    public const int IntType = 21;
    public const int ID_LIST = 8;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int Identifier = 20;
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
    public const int StringType = 23;
    public const int PRINTLN = 19;
    public const int T__59 = 59;
    public const int SpriteAnimation = 29;
    public const int COMMENT = 40;
    public const int STRINGNOQUOTES = 18;
    public const int VARDEF = 9;
    public const int T__50 = 50;
    public const int BooleanType = 22;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int LIBMETHOD = 12;
    public const int IntegerAtom = 26;
    public const int FORDEC = 15;
    public const int FloatType = 24;
    public const int StringAtom = 32;
    public const int NEGATE = 11;
    public const int HEX_DIGIT = 38;
    public const int BooleanAtom = 28;
    public const int T__71 = 71;
    public const int FORCOND = 16;
    public const int WS = 39;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int UnicodeEscape = 36;
    public const int BLOCK = 4;
    public const int ASSIGN = 10;
    public const int Layer = 30;
    public const int STATEMENTS = 5;
    public const int ObjectType = 25;
    public const int FloatAtom = 27;
    public const int T__74 = 74;
    public const int T__73 = 73;
    public const int EscapeSequence = 33;
    public const int Letter = 34;
    public const int OctalEscape = 37;
    public const int STRING = 14;

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:73:1: compilationUnit returns [SGLNode node] : block ;
    public SGLNode compilationUnit() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode block1 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:74:2: ( block )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:74:4: block
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:84:1: block returns [SGLNode node] : ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:94:2: ( ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:94:4: ^( BLOCK ^( STATEMENTS ( statement )* ) )
            {
            	Match(input,BLOCK,FOLLOW_BLOCK_in_block95); 

            	Match(input, Token.DOWN, null); 
            	Match(input,STATEMENTS,FOLLOW_STATEMENTS_in_block111); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:95:24: ( statement )*
            	    do 
            	    {
            	        int alt1 = 2;
            	        int LA1_0 = input.LA(1);

            	        if ( (LA1_0 == IF || (LA1_0 >= VARDEF && LA1_0 <= ASSIGN) || LA1_0 == OBJMETHOD || LA1_0 == PRINTLN || LA1_0 == 50) )
            	        {
            	            alt1 = 1;
            	        }


            	        switch (alt1) 
            	    	{
            	    		case 1 :
            	    		    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:95:25: statement
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:99:1: statement returns [SGLNode node] : ( variableDeclaration | variableAssignment | staticMethod | objectMethod | ifStatement | whileLoop );
    public SGLNode statement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode variableDeclaration3 = default(SGLNode);

        SGLNode variableAssignment4 = default(SGLNode);

        SGLNode staticMethod5 = default(SGLNode);

        SGLNode objectMethod6 = default(SGLNode);

        SGLNode ifStatement7 = default(SGLNode);

        SGLNode whileLoop8 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:101:2: ( variableDeclaration | variableAssignment | staticMethod | objectMethod | ifStatement | whileLoop )
            int alt2 = 6;
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
            case PRINTLN:
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
            case 50:
            	{
                alt2 = 6;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:101:4: variableDeclaration
                    {
                    	PushFollow(FOLLOW_variableDeclaration_in_statement155);
                    	variableDeclaration3 = variableDeclaration();
                    	state.followingStackPointer--;

                    	 node = variableDeclaration3; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:102:4: variableAssignment
                    {
                    	PushFollow(FOLLOW_variableAssignment_in_statement163);
                    	variableAssignment4 = variableAssignment();
                    	state.followingStackPointer--;

                    	 node = variableAssignment4; 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:103:4: staticMethod
                    {
                    	PushFollow(FOLLOW_staticMethod_in_statement171);
                    	staticMethod5 = staticMethod();
                    	state.followingStackPointer--;

                    	 node = staticMethod5; 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:104:4: objectMethod
                    {
                    	PushFollow(FOLLOW_objectMethod_in_statement179);
                    	objectMethod6 = objectMethod();
                    	state.followingStackPointer--;

                    	 node = objectMethod6; 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:105:4: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_statement187);
                    	ifStatement7 = ifStatement();
                    	state.followingStackPointer--;

                    	 node = ifStatement7; 

                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:106:4: whileLoop
                    {
                    	PushFollow(FOLLOW_whileLoop_in_statement195);
                    	whileLoop8 = whileLoop();
                    	state.followingStackPointer--;

                    	 node = whileLoop8; 

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


    // $ANTLR start "staticMethod"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:109:1: staticMethod returns [SGLNode node] : ^( PRINTLN expression ) ;
    public SGLNode staticMethod() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode expression9 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:110:2: ( ^( PRINTLN expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:110:4: ^( PRINTLN expression )
            {
            	Match(input,PRINTLN,FOLLOW_PRINTLN_in_staticMethod215); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_staticMethod217);
            	expression9 = expression();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new PrintlnNode(storyboardCode, expression9); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:113:1: objectMethod returns [SGLNode node] : ^( OBJMETHOD variableName Identifier arguments ) ;
    public SGLNode objectMethod() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier11 = null;
        String variableName10 = default(String);

        List<SGLNode> arguments12 = default(List<SGLNode>);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:114:2: ( ^( OBJMETHOD variableName Identifier arguments ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:114:4: ^( OBJMETHOD variableName Identifier arguments )
            {
            	Match(input,OBJMETHOD,FOLLOW_OBJMETHOD_in_objectMethod237); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableName_in_objectMethod239);
            	variableName10 = variableName();
            	state.followingStackPointer--;

            	Identifier11=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_objectMethod241); 
            	PushFollow(FOLLOW_arguments_in_objectMethod243);
            	arguments12 = arguments();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new ObjectMehtodNode(variableName10, ((Identifier11 != null) ? Identifier11.Text : null), arguments12, currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:118:1: whileLoop returns [SGLNode node] : ^( 'while' expression block ) ;
    public SGLNode whileLoop() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode expression13 = default(SGLNode);

        SGLNode block14 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:119:2: ( ^( 'while' expression block ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:119:4: ^( 'while' expression block )
            {
            	Match(input,50,FOLLOW_50_in_whileLoop265); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_whileLoop267);
            	expression13 = expression();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_block_in_whileLoop269);
            	block14 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new WhileNode(expression13, block14); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:124:1: ifStatement returns [SGLNode node] : ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) ;
    public SGLNode ifStatement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode b1 = default(SGLNode);

        SGLNode b2 = default(SGLNode);

        SGLNode expression15 = default(SGLNode);


         
          IfNode ifNode = new IfNode(); 
          node = ifNode; 

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:129:3: ( ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:129:6: ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? )
            {
            	Match(input,IF,FOLLOW_IF_in_ifStatement302); 

            	Match(input, Token.DOWN, null); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:130:8: ( ^( EXP expression b1= block ) )+
            	int cnt3 = 0;
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0 == EXP) )
            	    {
            	        int LA3_1 = input.LA(2);

            	        if ( (LA3_1 == DOWN) )
            	        {
            	            int LA3_3 = input.LA(3);

            	            if ( (LA3_3 == NEGATE || LA3_3 == STRING || LA3_3 == STRINGNOQUOTES || LA3_3 == Identifier || (LA3_3 >= IntegerAtom && LA3_3 <= SpriteAnimation) || LA3_3 == 55 || (LA3_3 >= 57 && LA3_3 <= 69)) )
            	            {
            	                alt3 = 1;
            	            }


            	        }


            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:130:9: ^( EXP expression b1= block )
            			    {
            			    	Match(input,EXP,FOLLOW_EXP_in_ifStatement316); 

            			    	Match(input, Token.DOWN, null); 
            			    	PushFollow(FOLLOW_expression_in_ifStatement318);
            			    	expression15 = expression();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_block_in_ifStatement322);
            			    	b1 = block();
            			    	state.followingStackPointer--;


            			    	Match(input, Token.UP, null); 
            			    	 ifNode.AddChoice(expression15,b1); 

            			    }
            			    break;

            			default:
            			    if ( cnt3 >= 1 ) goto loop3;
            		            EarlyExitException eee3 =
            		                new EarlyExitException(3, input);
            		            throw eee3;
            	    }
            	    cnt3++;
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:131:8: ( ^( EXP b2= block ) )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == EXP) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:131:9: ^( EXP b2= block )
            	        {
            	        	Match(input,EXP,FOLLOW_EXP_in_ifStatement342); 

            	        	Match(input, Token.DOWN, null); 
            	        	PushFollow(FOLLOW_block_in_ifStatement346);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:139:1: variableDeclaration returns [SGLNode node] : ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) );
    public SGLNode variableDeclaration() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        String variableType16 = default(String);

        String variableName17 = default(String);

        SGLNode expression18 = default(SGLNode);

        String variableType19 = default(String);

        String variableName20 = default(String);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:140:2: ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) )
            int alt5 = 2;
            alt5 = dfa5.Predict(input);
            switch (alt5) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:140:4: ^( VARDEF variableType variableName expression )
                    {
                    	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclaration388); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableType_in_variableDeclaration390);
                    	variableType16 = variableType();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_variableName_in_variableDeclaration392);
                    	variableName17 = variableName();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_variableDeclaration394);
                    	expression18 = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NewLocalVariableNode(variableType16,variableName17,expression18,currentScope); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:143:5: ^( VARDEF variableType variableName )
                    {
                    	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclaration418); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableType_in_variableDeclaration420);
                    	variableType19 = variableType();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_variableName_in_variableDeclaration422);
                    	variableName20 = variableName();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NewLocalVariableNode(variableType19,variableName20,new AtomNode(null),currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:152:1: variableAssignment returns [SGLNode node] : ^( ASSIGN variableName expression ) ;
    public SGLNode variableAssignment() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        String variableName21 = default(String);

        SGLNode expression22 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:153:2: ( ^( ASSIGN variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:153:4: ^( ASSIGN variableName expression )
            {
            	Match(input,ASSIGN,FOLLOW_ASSIGN_in_variableAssignment451); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableName_in_variableAssignment453);
            	variableName21 = variableName();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_expression_in_variableAssignment455);
            	expression22 = expression();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new AssignVariableNode(variableName21,expression22, currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:158:1: variableName returns [String txt] : Identifier ;
    public String variableName() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree Identifier23 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:159:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:159:4: Identifier
            {
            	Identifier23=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableName478); 
            	 txt = ((Identifier23 != null) ? Identifier23.Text : null); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:162:1: variableType returns [String txt] : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public String variableType() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree IntType24 = null;
        CommonTree BooleanType25 = null;
        CommonTree StringType26 = null;
        CommonTree FloatType27 = null;
        CommonTree ObjectType28 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:163:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
            int alt6 = 5;
            switch ( input.LA(1) ) 
            {
            case IntType:
            	{
                alt6 = 1;
                }
                break;
            case BooleanType:
            	{
                alt6 = 2;
                }
                break;
            case StringType:
            	{
                alt6 = 3;
                }
                break;
            case FloatType:
            	{
                alt6 = 4;
                }
                break;
            case ObjectType:
            	{
                alt6 = 5;
                }
                break;
            	default:
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("", 6, 0, input);

            	    throw nvae_d6s0;
            }

            switch (alt6) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:163:4: IntType
                    {
                    	IntType24=(CommonTree)Match(input,IntType,FOLLOW_IntType_in_variableType496); 
                    	 txt = ((IntType24 != null) ? IntType24.Text : null); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:164:4: BooleanType
                    {
                    	BooleanType25=(CommonTree)Match(input,BooleanType,FOLLOW_BooleanType_in_variableType503); 
                    	 txt = ((BooleanType25 != null) ? BooleanType25.Text : null); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:165:4: StringType
                    {
                    	StringType26=(CommonTree)Match(input,StringType,FOLLOW_StringType_in_variableType510); 
                    	 txt = ((StringType26 != null) ? StringType26.Text : null); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:166:4: FloatType
                    {
                    	FloatType27=(CommonTree)Match(input,FloatType,FOLLOW_FloatType_in_variableType517); 
                    	 txt = ((FloatType27 != null) ? FloatType27.Text : null); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:167:4: ObjectType
                    {
                    	ObjectType28=(CommonTree)Match(input,ObjectType,FOLLOW_ObjectType_in_variableType524); 
                    	 txt = ((ObjectType28 != null) ? ObjectType28.Text : null); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:177:1: expression returns [SGLNode node] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | ^( STRINGNOQUOTES Layer ) | ^( STRINGNOQUOTES Origin ) | spriteObject | lookup );
    public SGLNode expression() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree IntegerAtom29 = null;
        CommonTree FloatAtom30 = null;
        CommonTree BooleanAtom31 = null;
        CommonTree StringAtom32 = null;
        CommonTree Layer33 = null;
        CommonTree Origin34 = null;
        SGLNode a = default(SGLNode);

        SGLNode b = default(SGLNode);

        SGLNode c = default(SGLNode);

        SGLNode spriteObject35 = default(SGLNode);

        SGLNode lookup36 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:178:2: ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | ^( STRINGNOQUOTES Layer ) | ^( STRINGNOQUOTES Origin ) | spriteObject | lookup )
            int alt7 = 23;
            alt7 = dfa7.Predict(input);
            switch (alt7) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:178:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,65,FOLLOW_65_in_expression564); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression568);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression572);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MAddNode(a, b); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:179:4: ^( '-' a= expression b= expression )
                    {
                    	Match(input,66,FOLLOW_66_in_expression581); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression585);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression589);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MSubNode(a, b); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:180:4: ^( '*' a= expression b= expression )
                    {
                    	Match(input,67,FOLLOW_67_in_expression598); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression602);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression606);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MMultNode(a, b); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:181:4: ^( '/' a= expression b= expression )
                    {
                    	Match(input,68,FOLLOW_68_in_expression615); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression619);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression623);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MDivNode(a, b); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:182:4: ^( '%' a= expression b= expression )
                    {
                    	Match(input,69,FOLLOW_69_in_expression632); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression636);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression640);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MModNode(a, b); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:183:4: ^( NEGATE a= expression )
                    {
                    	Match(input,NEGATE,FOLLOW_NEGATE_in_expression649); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression653);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MNegateNode(a); 

                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:184:4: ^( '<' a= expression b= expression )
                    {
                    	Match(input,61,FOLLOW_61_in_expression662); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression666);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression670);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CLTNode(a, b); 

                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:185:4: ^( '<=' a= expression b= expression )
                    {
                    	Match(input,63,FOLLOW_63_in_expression679); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression683);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression687);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CLTEqualsNode(a, b); 

                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:186:4: ^( '>' a= expression b= expression )
                    {
                    	Match(input,62,FOLLOW_62_in_expression696); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression700);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression704);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CGTNode(a, b); 

                    }
                    break;
                case 10 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:187:4: ^( '>=' a= expression b= expression )
                    {
                    	Match(input,64,FOLLOW_64_in_expression713); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression717);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression721);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CGTEqualsNode(a, b); 

                    }
                    break;
                case 11 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:188:4: ^( '!=' a= expression b= expression )
                    {
                    	Match(input,60,FOLLOW_60_in_expression730); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression734);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression738);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CNotEqualsNode(a, b); 

                    }
                    break;
                case 12 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:189:4: ^( '==' a= expression b= expression )
                    {
                    	Match(input,59,FOLLOW_59_in_expression747); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression751);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression755);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CEqualsNode(a, b); 

                    }
                    break;
                case 13 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:190:4: ^( '&&' a= expression b= expression )
                    {
                    	Match(input,58,FOLLOW_58_in_expression764); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression768);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression772);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CAndNode(a, b); 

                    }
                    break;
                case 14 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:191:4: ^( '||' a= expression b= expression )
                    {
                    	Match(input,57,FOLLOW_57_in_expression781); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression785);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression789);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new COrNode(a, b); 

                    }
                    break;
                case 15 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:192:4: ^( '?' a= expression b= expression c= expression )
                    {
                    	Match(input,55,FOLLOW_55_in_expression798); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression802);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression806);
                    	b = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression810);
                    	c = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new TernaryNode(a, b, c); 

                    }
                    break;
                case 16 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:193:6: IntegerAtom
                    {
                    	IntegerAtom29=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_expression820); 
                    	 node = new AtomNode(int.Parse(((IntegerAtom29 != null) ? IntegerAtom29.Text : null), System.Globalization.CultureInfo.InvariantCulture)); 

                    }
                    break;
                case 17 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:194:4: FloatAtom
                    {
                    	FloatAtom30=(CommonTree)Match(input,FloatAtom,FOLLOW_FloatAtom_in_expression827); 
                    	 node = new AtomNode(Double.Parse(((FloatAtom30 != null) ? FloatAtom30.Text : null), System.Globalization.CultureInfo.InvariantCulture)); 

                    }
                    break;
                case 18 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:195:6: BooleanAtom
                    {
                    	BooleanAtom31=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression836); 
                    	 node = new AtomNode(Boolean.Parse(((BooleanAtom31 != null) ? BooleanAtom31.Text : null))); 

                    }
                    break;
                case 19 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:196:4: ^( STRING StringAtom )
                    {
                    	Match(input,STRING,FOLLOW_STRING_in_expression844); 

                    	Match(input, Token.DOWN, null); 
                    	StringAtom32=(CommonTree)Match(input,StringAtom,FOLLOW_StringAtom_in_expression846); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode((((StringAtom32 != null) ? StringAtom32.Text : null)).Substring(1, (((StringAtom32 != null) ? StringAtom32.Text : null)).Length-2)); 

                    }
                    break;
                case 20 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:197:4: ^( STRINGNOQUOTES Layer )
                    {
                    	Match(input,STRINGNOQUOTES,FOLLOW_STRINGNOQUOTES_in_expression855); 

                    	Match(input, Token.DOWN, null); 
                    	Layer33=(CommonTree)Match(input,Layer,FOLLOW_Layer_in_expression857); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode(((Layer33 != null) ? Layer33.Text : null)); 

                    }
                    break;
                case 21 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:198:4: ^( STRINGNOQUOTES Origin )
                    {
                    	Match(input,STRINGNOQUOTES,FOLLOW_STRINGNOQUOTES_in_expression866); 

                    	Match(input, Token.DOWN, null); 
                    	Origin34=(CommonTree)Match(input,Origin,FOLLOW_Origin_in_expression868); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode(((Origin34 != null) ? Origin34.Text : null)); 

                    }
                    break;
                case 22 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:199:4: spriteObject
                    {
                    	PushFollow(FOLLOW_spriteObject_in_expression876);
                    	spriteObject35 = spriteObject();
                    	state.followingStackPointer--;

                    	 node = spriteObject35; 

                    }
                    break;
                case 23 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:200:4: lookup
                    {
                    	PushFollow(FOLLOW_lookup_in_expression883);
                    	lookup36 = lookup();
                    	state.followingStackPointer--;

                    	 node = lookup36; 

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


    // $ANTLR start "lookup"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:205:1: lookup returns [SGLNode node] : Identifier ;
    public SGLNode lookup() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier37 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:206:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:206:4: Identifier
            {
            	Identifier37=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_lookup921); 
            	 node = new IdentifierNode(((Identifier37 != null) ? Identifier37.Text : null), currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:209:1: spriteObject returns [SGLNode node] : ^( SpriteAnimation arguments ) ;
    public SGLNode spriteObject() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        List<SGLNode> arguments38 = default(List<SGLNode>);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:210:2: ( ^( SpriteAnimation arguments ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:210:6: ^( SpriteAnimation arguments )
            {
            	Match(input,SpriteAnimation,FOLLOW_SpriteAnimation_in_spriteObject950); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    PushFollow(FOLLOW_arguments_in_spriteObject952);
            	    arguments38 = arguments();
            	    state.followingStackPointer--;


            	    Match(input, Token.UP, null); 
            	}
            	  node = new SpriteNode(arguments38); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:217:1: arguments returns [List<SGLNode> list] : ( expression )* ;
    public List<SGLNode> arguments() // throws RecognitionException [1]
    {   
        List<SGLNode> list = default(List<SGLNode>);

        SGLNode expression39 = default(SGLNode);


         list = new List<SGLNode>(); 
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:219:5: ( ( expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:219:9: ( expression )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:219:9: ( expression )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == NEGATE || LA8_0 == STRING || LA8_0 == STRINGNOQUOTES || LA8_0 == Identifier || (LA8_0 >= IntegerAtom && LA8_0 <= SpriteAnimation) || LA8_0 == 55 || (LA8_0 >= 57 && LA8_0 <= 69)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:219:10: expression
            			    {
            			    	PushFollow(FOLLOW_expression_in_arguments992);
            			    	expression39 = expression();
            			    	state.followingStackPointer--;

            			    	list.Add(expression39);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:222:1: expressionList : expression ( ',' expression )* ;
    public void expressionList() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:223:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:223:9: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList1015);
            	expression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:223:20: ( ',' expression )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 47) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:223:21: ',' expression
            			    {
            			    	Match(input,47,FOLLOW_47_in_expressionList1018); 
            			    	PushFollow(FOLLOW_expression_in_expressionList1020);
            			    	expression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:228:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public void literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:229:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:
            {
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == StringAtom || input.LA(1) == 74 ) 
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


   	protected DFA5 dfa5;
   	protected DFA7 dfa7;
	private void InitializeCyclicDFAs()
	{
    	this.dfa5 = new DFA5(this);
    	this.dfa7 = new DFA7(this);
	}

    const string DFA5_eotS =
        "\x0b\uffff";
    const string DFA5_eofS =
        "\x0b\uffff";
    const string DFA5_minS =
        "\x01\x09\x01\x02\x01\x15\x05\x14\x01\x03\x02\uffff";
    const string DFA5_maxS =
        "\x01\x09\x01\x02\x01\x19\x05\x14\x01\x45\x02\uffff";
    const string DFA5_acceptS =
        "\x09\uffff\x01\x01\x01\x02";
    const string DFA5_specialS =
        "\x0b\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x01\x01",
            "\x01\x02",
            "\x01\x03\x01\x04\x01\x05\x01\x06\x01\x07",
            "\x01\x08",
            "\x01\x08",
            "\x01\x08",
            "\x01\x08",
            "\x01\x08",
            "\x01\x0a\x07\uffff\x01\x09\x02\uffff\x01\x09\x03\uffff\x01"+
            "\x09\x01\uffff\x01\x09\x05\uffff\x04\x09\x19\uffff\x01\x09\x01"+
            "\uffff\x0d\x09",
            "",
            ""
    };

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "139:1: variableDeclaration returns [SGLNode node] : ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) );"; }
        }

    }

    const string DFA7_eotS =
        "\x1a\uffff";
    const string DFA7_eofS =
        "\x1a\uffff";
    const string DFA7_minS =
        "\x01\x0b\x13\uffff\x01\x02\x02\uffff\x01\x1e\x02\uffff";
    const string DFA7_maxS =
        "\x01\x45\x13\uffff\x01\x02\x02\uffff\x01\x1f\x02\uffff";
    const string DFA7_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x01\x08\x01\x09\x01\x0a\x01\x0b\x01\x0c\x01\x0d\x01\x0e\x01"+
        "\x0f\x01\x10\x01\x11\x01\x12\x01\x13\x01\uffff\x01\x16\x01\x17\x01"+
        "\uffff\x01\x14\x01\x15";
    const string DFA7_specialS =
        "\x1a\uffff}>";
    static readonly string[] DFA7_transitionS = {
            "\x01\x06\x02\uffff\x01\x13\x03\uffff\x01\x14\x01\uffff\x01"+
            "\x16\x05\uffff\x01\x10\x01\x11\x01\x12\x01\x15\x19\uffff\x01"+
            "\x0f\x01\uffff\x01\x0e\x01\x0d\x01\x0c\x01\x0b\x01\x07\x01\x09"+
            "\x01\x08\x01\x0a\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05",
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
            "\x01\x17",
            "",
            "",
            "\x01\x18\x01\x19",
            "",
            ""
    };

    static readonly short[] DFA7_eot = DFA.UnpackEncodedString(DFA7_eotS);
    static readonly short[] DFA7_eof = DFA.UnpackEncodedString(DFA7_eofS);
    static readonly char[] DFA7_min = DFA.UnpackEncodedStringToUnsignedChars(DFA7_minS);
    static readonly char[] DFA7_max = DFA.UnpackEncodedStringToUnsignedChars(DFA7_maxS);
    static readonly short[] DFA7_accept = DFA.UnpackEncodedString(DFA7_acceptS);
    static readonly short[] DFA7_special = DFA.UnpackEncodedString(DFA7_specialS);
    static readonly short[][] DFA7_transition = DFA.UnpackEncodedStringArray(DFA7_transitionS);

    protected class DFA7 : DFA
    {
        public DFA7(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 7;
            this.eot = DFA7_eot;
            this.eof = DFA7_eof;
            this.min = DFA7_min;
            this.max = DFA7_max;
            this.accept = DFA7_accept;
            this.special = DFA7_special;
            this.transition = DFA7_transition;

        }

        override public string Description
        {
            get { return "177:1: expression returns [SGLNode node] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | ^( STRINGNOQUOTES Layer ) | ^( STRINGNOQUOTES Origin ) | spriteObject | lookup );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_block_in_compilationUnit60 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BLOCK_in_block95 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_STATEMENTS_in_block111 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_block114 = new BitSet(new ulong[]{0x0004000000082648UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_statement155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_statement163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_staticMethod_in_statement171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethod_in_statement179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement187 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement195 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PRINTLN_in_staticMethod215 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_staticMethod217 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_OBJMETHOD_in_objectMethod237 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableName_in_objectMethod239 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethod241 = new BitSet(new ulong[]{0xFE8000003C144808UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_arguments_in_objectMethod243 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_50_in_whileLoop265 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop267 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_whileLoop269 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IF_in_ifStatement302 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement316 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_ifStatement318 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement322 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement342 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement346 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclaration388 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration390 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration392 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclaration394 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclaration418 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration420 = new BitSet(new ulong[]{0x0000000000100000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration422 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_variableAssignment451 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableName_in_variableAssignment453 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_variableAssignment455 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_variableType496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_variableType503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringType_in_variableType510 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatType_in_variableType517 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ObjectType_in_variableType524 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_expression564 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression568 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression572 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_66_in_expression581 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression585 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression589 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_67_in_expression598 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression602 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression606 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_68_in_expression615 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression619 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression623 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_69_in_expression632 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression636 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression640 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEGATE_in_expression649 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression653 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_61_in_expression662 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression666 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression670 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_63_in_expression679 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression683 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression687 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_62_in_expression696 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression700 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression704 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_64_in_expression713 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression717 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression721 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_60_in_expression730 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression734 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression738 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_59_in_expression747 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression751 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression755 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_58_in_expression764 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression768 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression772 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_57_in_expression781 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression785 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression789 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_55_in_expression798 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression802 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression806 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expression810 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_expression820 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_expression827 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_expression836 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_expression844 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_StringAtom_in_expression846 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRINGNOQUOTES_in_expression855 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Layer_in_expression857 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_STRINGNOQUOTES_in_expression866 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_Origin_in_expression868 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_spriteObject_in_expression876 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookup_in_expression883 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_lookup921 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SpriteAnimation_in_spriteObject950 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_arguments_in_spriteObject952 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_expression_in_arguments992 = new BitSet(new ulong[]{0xFE8000003C144802UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1015 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_47_in_expressionList1018 = new BitSet(new ulong[]{0xFE8000003C144800UL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1020 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}