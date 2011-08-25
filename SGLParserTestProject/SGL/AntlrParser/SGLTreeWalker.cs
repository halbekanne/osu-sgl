// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g 2011-08-25 18:28:39

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
    public const int SGLIDDigit = 31;
    public const int IntType = 19;
    public const int ID_LIST = 8;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int Identifier = 18;
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
    public const int StringType = 21;
    public const int T__59 = 59;
    public const int SpriteAnimation = 27;
    public const int COMMENT = 36;
    public const int VARDEF = 9;
    public const int T__50 = 50;
    public const int BooleanType = 20;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int LIBMETHOD = 12;
    public const int IntegerAtom = 24;
    public const int FORDEC = 15;
    public const int FloatType = 22;
    public const int StringAtom = 28;
    public const int NEGATE = 11;
    public const int HEX_DIGIT = 34;
    public const int BooleanAtom = 26;
    public const int FORCOND = 16;
    public const int WS = 35;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 32;
    public const int BLOCK = 4;
    public const int ASSIGN = 10;
    public const int STATEMENTS = 5;
    public const int ObjectType = 23;
    public const int FloatAtom = 25;
    public const int EscapeSequence = 29;
    public const int Letter = 30;
    public const int OctalEscape = 33;
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
        //private StringBuilder storyboardCode = new StringBuilder();
        	
        public StringBuilder GetStoryboardCode() {

        	StringBuilder storyboardCode = new StringBuilder();
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:63:1: compilationUnit returns [SGLNode node] : block ;
    public SGLNode compilationUnit() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode block1 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:64:2: ( block )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:64:4: block
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:74:1: block returns [SGLNode node] : ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:84:2: ( ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:84:4: ^( BLOCK ^( STATEMENTS ( statement )* ) )
            {
            	Match(input,BLOCK,FOLLOW_BLOCK_in_block95); 

            	Match(input, Token.DOWN, null); 
            	Match(input,STATEMENTS,FOLLOW_STATEMENTS_in_block111); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:85:24: ( statement )*
            	    do 
            	    {
            	        int alt1 = 2;
            	        int LA1_0 = input.LA(1);

            	        if ( (LA1_0 == IF || (LA1_0 >= VARDEF && LA1_0 <= ASSIGN) || LA1_0 == OBJMETHOD || LA1_0 == 46) )
            	        {
            	            alt1 = 1;
            	        }


            	        switch (alt1) 
            	    	{
            	    		case 1 :
            	    		    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:85:25: statement
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:89:1: statement returns [SGLNode node] : ( variableDeclaration | variableAssignment | objectMethod | ifStatement | whileLoop );
    public SGLNode statement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode variableDeclaration3 = default(SGLNode);

        SGLNode variableAssignment4 = default(SGLNode);

        SGLNode objectMethod5 = default(SGLNode);

        SGLNode ifStatement6 = default(SGLNode);

        SGLNode whileLoop7 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:91:2: ( variableDeclaration | variableAssignment | objectMethod | ifStatement | whileLoop )
            int alt2 = 5;
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
            case OBJMETHOD:
            	{
                alt2 = 3;
                }
                break;
            case IF:
            	{
                alt2 = 4;
                }
                break;
            case 46:
            	{
                alt2 = 5;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:91:4: variableDeclaration
                    {
                    	PushFollow(FOLLOW_variableDeclaration_in_statement155);
                    	variableDeclaration3 = variableDeclaration();
                    	state.followingStackPointer--;

                    	 node = variableDeclaration3; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:92:4: variableAssignment
                    {
                    	PushFollow(FOLLOW_variableAssignment_in_statement163);
                    	variableAssignment4 = variableAssignment();
                    	state.followingStackPointer--;

                    	 node = variableAssignment4; 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:93:4: objectMethod
                    {
                    	PushFollow(FOLLOW_objectMethod_in_statement171);
                    	objectMethod5 = objectMethod();
                    	state.followingStackPointer--;

                    	 node = objectMethod5; 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:94:4: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_statement179);
                    	ifStatement6 = ifStatement();
                    	state.followingStackPointer--;

                    	 node = ifStatement6; 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:95:4: whileLoop
                    {
                    	PushFollow(FOLLOW_whileLoop_in_statement187);
                    	whileLoop7 = whileLoop();
                    	state.followingStackPointer--;

                    	 node = whileLoop7; 

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


    // $ANTLR start "objectMethod"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:98:1: objectMethod returns [SGLNode node] : ^( OBJMETHOD variableName Identifier arguments ) ;
    public SGLNode objectMethod() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier9 = null;
        String variableName8 = default(String);

        List<SGLNode> arguments10 = default(List<SGLNode>);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:99:2: ( ^( OBJMETHOD variableName Identifier arguments ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:99:4: ^( OBJMETHOD variableName Identifier arguments )
            {
            	Match(input,OBJMETHOD,FOLLOW_OBJMETHOD_in_objectMethod207); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableName_in_objectMethod209);
            	variableName8 = variableName();
            	state.followingStackPointer--;

            	Identifier9=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_objectMethod211); 
            	PushFollow(FOLLOW_arguments_in_objectMethod213);
            	arguments10 = arguments();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new ObjectMehtodNode(variableName8, ((Identifier9 != null) ? Identifier9.Text : null), arguments10, currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:103:1: whileLoop returns [SGLNode node] : ^( 'while' expression block ) ;
    public SGLNode whileLoop() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode expression11 = default(SGLNode);

        SGLNode block12 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:104:2: ( ^( 'while' expression block ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:104:4: ^( 'while' expression block )
            {
            	Match(input,46,FOLLOW_46_in_whileLoop235); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_whileLoop237);
            	expression11 = expression();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_block_in_whileLoop239);
            	block12 = block();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new WhileNode(expression11, block12); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:109:1: ifStatement returns [SGLNode node] : ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) ;
    public SGLNode ifStatement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode b1 = default(SGLNode);

        SGLNode b2 = default(SGLNode);

        SGLNode expression13 = default(SGLNode);


         
          IfNode ifNode = new IfNode(); 
          node = ifNode; 

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:114:3: ( ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:114:6: ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? )
            {
            	Match(input,IF,FOLLOW_IF_in_ifStatement272); 

            	Match(input, Token.DOWN, null); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:115:8: ( ^( EXP expression b1= block ) )+
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

            	            if ( (LA3_3 == NEGATE || LA3_3 == STRING || LA3_3 == Identifier || (LA3_3 >= IntegerAtom && LA3_3 <= SpriteAnimation) || LA3_3 == 50 || (LA3_3 >= 52 && LA3_3 <= 64)) )
            	            {
            	                alt3 = 1;
            	            }


            	        }


            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:115:9: ^( EXP expression b1= block )
            			    {
            			    	Match(input,EXP,FOLLOW_EXP_in_ifStatement286); 

            			    	Match(input, Token.DOWN, null); 
            			    	PushFollow(FOLLOW_expression_in_ifStatement288);
            			    	expression13 = expression();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_block_in_ifStatement292);
            			    	b1 = block();
            			    	state.followingStackPointer--;


            			    	Match(input, Token.UP, null); 
            			    	 ifNode.AddChoice(expression13,b1); 

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

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:116:8: ( ^( EXP b2= block ) )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == EXP) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:116:9: ^( EXP b2= block )
            	        {
            	        	Match(input,EXP,FOLLOW_EXP_in_ifStatement312); 

            	        	Match(input, Token.DOWN, null); 
            	        	PushFollow(FOLLOW_block_in_ifStatement316);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:124:1: variableDeclaration returns [SGLNode node] : ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) );
    public SGLNode variableDeclaration() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        String variableType14 = default(String);

        String variableName15 = default(String);

        SGLNode expression16 = default(SGLNode);

        String variableType17 = default(String);

        String variableName18 = default(String);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:125:2: ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) )
            int alt5 = 2;
            alt5 = dfa5.Predict(input);
            switch (alt5) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:125:4: ^( VARDEF variableType variableName expression )
                    {
                    	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclaration358); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableType_in_variableDeclaration360);
                    	variableType14 = variableType();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_variableName_in_variableDeclaration362);
                    	variableName15 = variableName();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_variableDeclaration364);
                    	expression16 = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NewLocalVariableNode(variableType14,variableName15,expression16,currentScope); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:128:5: ^( VARDEF variableType variableName )
                    {
                    	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclaration388); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableType_in_variableDeclaration390);
                    	variableType17 = variableType();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_variableName_in_variableDeclaration392);
                    	variableName18 = variableName();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NewLocalVariableNode(variableType17,variableName18,new AtomNode(null),currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:137:1: variableAssignment returns [SGLNode node] : ^( ASSIGN variableName expression ) ;
    public SGLNode variableAssignment() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        String variableName19 = default(String);

        SGLNode expression20 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:138:2: ( ^( ASSIGN variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:138:4: ^( ASSIGN variableName expression )
            {
            	Match(input,ASSIGN,FOLLOW_ASSIGN_in_variableAssignment421); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableName_in_variableAssignment423);
            	variableName19 = variableName();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_expression_in_variableAssignment425);
            	expression20 = expression();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new AssignVariableNode(variableName19,expression20, currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:143:1: variableName returns [String txt] : Identifier ;
    public String variableName() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree Identifier21 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:144:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:144:4: Identifier
            {
            	Identifier21=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableName448); 
            	 txt = ((Identifier21 != null) ? Identifier21.Text : null); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:147:1: variableType returns [String txt] : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public String variableType() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree IntType22 = null;
        CommonTree BooleanType23 = null;
        CommonTree StringType24 = null;
        CommonTree FloatType25 = null;
        CommonTree ObjectType26 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:148:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:148:4: IntType
                    {
                    	IntType22=(CommonTree)Match(input,IntType,FOLLOW_IntType_in_variableType466); 
                    	 txt = ((IntType22 != null) ? IntType22.Text : null); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:149:4: BooleanType
                    {
                    	BooleanType23=(CommonTree)Match(input,BooleanType,FOLLOW_BooleanType_in_variableType473); 
                    	 txt = ((BooleanType23 != null) ? BooleanType23.Text : null); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:150:4: StringType
                    {
                    	StringType24=(CommonTree)Match(input,StringType,FOLLOW_StringType_in_variableType480); 
                    	 txt = ((StringType24 != null) ? StringType24.Text : null); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:151:4: FloatType
                    {
                    	FloatType25=(CommonTree)Match(input,FloatType,FOLLOW_FloatType_in_variableType487); 
                    	 txt = ((FloatType25 != null) ? FloatType25.Text : null); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:152:4: ObjectType
                    {
                    	ObjectType26=(CommonTree)Match(input,ObjectType,FOLLOW_ObjectType_in_variableType494); 
                    	 txt = ((ObjectType26 != null) ? ObjectType26.Text : null); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:162:1: expression returns [SGLNode node] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | spriteObject | lookup );
    public SGLNode expression() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree IntegerAtom27 = null;
        CommonTree FloatAtom28 = null;
        CommonTree BooleanAtom29 = null;
        CommonTree StringAtom30 = null;
        SGLNode a = default(SGLNode);

        SGLNode b = default(SGLNode);

        SGLNode c = default(SGLNode);

        SGLNode spriteObject31 = default(SGLNode);

        SGLNode lookup32 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:163:2: ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | ^( STRING StringAtom ) | spriteObject | lookup )
            int alt7 = 21;
            switch ( input.LA(1) ) 
            {
            case 60:
            	{
                alt7 = 1;
                }
                break;
            case 61:
            	{
                alt7 = 2;
                }
                break;
            case 62:
            	{
                alt7 = 3;
                }
                break;
            case 63:
            	{
                alt7 = 4;
                }
                break;
            case 64:
            	{
                alt7 = 5;
                }
                break;
            case NEGATE:
            	{
                alt7 = 6;
                }
                break;
            case 56:
            	{
                alt7 = 7;
                }
                break;
            case 58:
            	{
                alt7 = 8;
                }
                break;
            case 57:
            	{
                alt7 = 9;
                }
                break;
            case 59:
            	{
                alt7 = 10;
                }
                break;
            case 55:
            	{
                alt7 = 11;
                }
                break;
            case 54:
            	{
                alt7 = 12;
                }
                break;
            case 53:
            	{
                alt7 = 13;
                }
                break;
            case 52:
            	{
                alt7 = 14;
                }
                break;
            case 50:
            	{
                alt7 = 15;
                }
                break;
            case IntegerAtom:
            	{
                alt7 = 16;
                }
                break;
            case FloatAtom:
            	{
                alt7 = 17;
                }
                break;
            case BooleanAtom:
            	{
                alt7 = 18;
                }
                break;
            case STRING:
            	{
                alt7 = 19;
                }
                break;
            case SpriteAnimation:
            	{
                alt7 = 20;
                }
                break;
            case Identifier:
            	{
                alt7 = 21;
                }
                break;
            	default:
            	    NoViableAltException nvae_d7s0 =
            	        new NoViableAltException("", 7, 0, input);

            	    throw nvae_d7s0;
            }

            switch (alt7) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:163:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,60,FOLLOW_60_in_expression534); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression538);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression542);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MAddNode(a, b); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:164:4: ^( '-' a= expression b= expression )
                    {
                    	Match(input,61,FOLLOW_61_in_expression551); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression555);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression559);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MSubNode(a, b); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:165:4: ^( '*' a= expression b= expression )
                    {
                    	Match(input,62,FOLLOW_62_in_expression568); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression572);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression576);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MMultNode(a, b); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:166:4: ^( '/' a= expression b= expression )
                    {
                    	Match(input,63,FOLLOW_63_in_expression585); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression589);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression593);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MDivNode(a, b); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:167:4: ^( '%' a= expression b= expression )
                    {
                    	Match(input,64,FOLLOW_64_in_expression602); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression606);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression610);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MModNode(a, b); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:168:4: ^( NEGATE a= expression )
                    {
                    	Match(input,NEGATE,FOLLOW_NEGATE_in_expression619); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression623);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MNegateNode(a); 

                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:169:4: ^( '<' a= expression b= expression )
                    {
                    	Match(input,56,FOLLOW_56_in_expression632); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression636);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression640);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CLTNode(a, b); 

                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:170:4: ^( '<=' a= expression b= expression )
                    {
                    	Match(input,58,FOLLOW_58_in_expression649); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression653);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression657);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CLTEqualsNode(a, b); 

                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:171:4: ^( '>' a= expression b= expression )
                    {
                    	Match(input,57,FOLLOW_57_in_expression666); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression670);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression674);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CGTNode(a, b); 

                    }
                    break;
                case 10 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:172:4: ^( '>=' a= expression b= expression )
                    {
                    	Match(input,59,FOLLOW_59_in_expression683); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression687);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression691);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CGTEqualsNode(a, b); 

                    }
                    break;
                case 11 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:173:4: ^( '!=' a= expression b= expression )
                    {
                    	Match(input,55,FOLLOW_55_in_expression700); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression704);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression708);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CNotEqualsNode(a, b); 

                    }
                    break;
                case 12 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:174:4: ^( '==' a= expression b= expression )
                    {
                    	Match(input,54,FOLLOW_54_in_expression717); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression721);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression725);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CEqualsNode(a, b); 

                    }
                    break;
                case 13 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:175:4: ^( '&&' a= expression b= expression )
                    {
                    	Match(input,53,FOLLOW_53_in_expression734); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression738);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression742);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CAndNode(a, b); 

                    }
                    break;
                case 14 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:176:4: ^( '||' a= expression b= expression )
                    {
                    	Match(input,52,FOLLOW_52_in_expression751); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression755);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression759);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new COrNode(a, b); 

                    }
                    break;
                case 15 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:177:4: ^( '?' a= expression b= expression c= expression )
                    {
                    	Match(input,50,FOLLOW_50_in_expression768); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression772);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression776);
                    	b = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression780);
                    	c = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new TernaryNode(a, b, c); 

                    }
                    break;
                case 16 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:178:6: IntegerAtom
                    {
                    	IntegerAtom27=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_expression790); 
                    	 node = new AtomNode(int.Parse(((IntegerAtom27 != null) ? IntegerAtom27.Text : null), System.Globalization.CultureInfo.InvariantCulture)); 

                    }
                    break;
                case 17 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:179:4: FloatAtom
                    {
                    	FloatAtom28=(CommonTree)Match(input,FloatAtom,FOLLOW_FloatAtom_in_expression797); 
                    	 node = new AtomNode(Double.Parse(((FloatAtom28 != null) ? FloatAtom28.Text : null), System.Globalization.CultureInfo.InvariantCulture)); 

                    }
                    break;
                case 18 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:180:6: BooleanAtom
                    {
                    	BooleanAtom29=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression806); 
                    	 node = new AtomNode(Boolean.Parse(((BooleanAtom29 != null) ? BooleanAtom29.Text : null))); 

                    }
                    break;
                case 19 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:181:4: ^( STRING StringAtom )
                    {
                    	Match(input,STRING,FOLLOW_STRING_in_expression814); 

                    	Match(input, Token.DOWN, null); 
                    	StringAtom30=(CommonTree)Match(input,StringAtom,FOLLOW_StringAtom_in_expression816); 

                    	Match(input, Token.UP, null); 
                    	 node = new AtomNode((((StringAtom30 != null) ? StringAtom30.Text : null)).Substring(1, (((StringAtom30 != null) ? StringAtom30.Text : null)).Length-1)); 

                    }
                    break;
                case 20 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:182:4: spriteObject
                    {
                    	PushFollow(FOLLOW_spriteObject_in_expression824);
                    	spriteObject31 = spriteObject();
                    	state.followingStackPointer--;

                    	 node = spriteObject31; 

                    }
                    break;
                case 21 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:183:4: lookup
                    {
                    	PushFollow(FOLLOW_lookup_in_expression831);
                    	lookup32 = lookup();
                    	state.followingStackPointer--;

                    	 node = lookup32; 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:188:1: lookup returns [SGLNode node] : Identifier ;
    public SGLNode lookup() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier33 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:189:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:189:4: Identifier
            {
            	Identifier33=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_lookup869); 
            	 node = new IdentifierNode(((Identifier33 != null) ? Identifier33.Text : null), currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:192:1: spriteObject returns [SGLNode node] : SpriteAnimation ;
    public SGLNode spriteObject() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:193:2: ( SpriteAnimation )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:193:6: SpriteAnimation
            {
            	Match(input,SpriteAnimation,FOLLOW_SpriteAnimation_in_spriteObject897); 
            	 node = new SpriteNode(); 

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


    // $ANTLR start "spriteArguments"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:198:1: spriteArguments returns [SGLNode node] : filepath= expression ;
    public SGLNode spriteArguments() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode filepath = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:199:2: (filepath= expression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:199:4: filepath= expression
            {
            	PushFollow(FOLLOW_expression_in_spriteArguments923);
            	filepath = expression();
            	state.followingStackPointer--;

            	 node = new SpriteNode(filepath); 

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
    // $ANTLR end "spriteArguments"


    // $ANTLR start "arguments"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:205:1: arguments returns [List<SGLNode> list] : ( expression )* ;
    public List<SGLNode> arguments() // throws RecognitionException [1]
    {   
        List<SGLNode> list = default(List<SGLNode>);

        SGLNode expression34 = default(SGLNode);


         list = new List<SGLNode>(); 
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:207:5: ( ( expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:207:9: ( expression )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:207:9: ( expression )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == NEGATE || LA8_0 == STRING || LA8_0 == Identifier || (LA8_0 >= IntegerAtom && LA8_0 <= SpriteAnimation) || LA8_0 == 50 || (LA8_0 >= 52 && LA8_0 <= 64)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:207:10: expression
            			    {
            			    	PushFollow(FOLLOW_expression_in_arguments960);
            			    	expression34 = expression();
            			    	state.followingStackPointer--;

            			    	list.Add(expression34);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:210:1: expressionList : expression ( ',' expression )* ;
    public void expressionList() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:211:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:211:9: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList983);
            	expression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:211:20: ( ',' expression )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 43) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:211:21: ',' expression
            			    {
            			    	Match(input,43,FOLLOW_43_in_expressionList986); 
            			    	PushFollow(FOLLOW_expression_in_expressionList988);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:216:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public void literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:217:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:
            {
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == StringAtom || input.LA(1) == 69 ) 
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
	private void InitializeCyclicDFAs()
	{
    	this.dfa5 = new DFA5(this);
	}

    const string DFA5_eotS =
        "\x0b\uffff";
    const string DFA5_eofS =
        "\x0b\uffff";
    const string DFA5_minS =
        "\x01\x09\x01\x02\x01\x13\x05\x12\x01\x03\x02\uffff";
    const string DFA5_maxS =
        "\x01\x09\x01\x02\x01\x17\x05\x12\x01\x40\x02\uffff";
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
            "\x09\x05\uffff\x04\x09\x16\uffff\x01\x09\x01\uffff\x0d\x09",
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
            get { return "124:1: variableDeclaration returns [SGLNode node] : ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_block_in_compilationUnit60 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BLOCK_in_block95 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_STATEMENTS_in_block111 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_block114 = new BitSet(new ulong[]{0x0000400000002648UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_statement155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_statement163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethod_in_statement171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement179 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement187 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJMETHOD_in_objectMethod207 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableName_in_objectMethod209 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethod211 = new BitSet(new ulong[]{0xFFF400000F044808UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_arguments_in_objectMethod213 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_46_in_whileLoop235 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop237 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_whileLoop239 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IF_in_ifStatement272 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement286 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_ifStatement288 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement292 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement312 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement316 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclaration358 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration360 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration362 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclaration364 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclaration388 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration390 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration392 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_variableAssignment421 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableName_in_variableAssignment423 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_variableAssignment425 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_variableType466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_variableType473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringType_in_variableType480 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatType_in_variableType487 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ObjectType_in_variableType494 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_expression534 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression538 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression542 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_61_in_expression551 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression555 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression559 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_62_in_expression568 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression572 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression576 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_63_in_expression585 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression589 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression593 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_64_in_expression602 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression606 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression610 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEGATE_in_expression619 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression623 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_56_in_expression632 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression636 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression640 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_58_in_expression649 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression653 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression657 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_57_in_expression666 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression670 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression674 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_59_in_expression683 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression687 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression691 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_55_in_expression700 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression704 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression708 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_54_in_expression717 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression721 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression725 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_53_in_expression734 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression738 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression742 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_52_in_expression751 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression755 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression759 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_50_in_expression768 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression772 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression776 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expression780 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_expression790 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_expression797 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_expression806 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_STRING_in_expression814 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_StringAtom_in_expression816 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_spriteObject_in_expression824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookup_in_expression831 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_lookup869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SpriteAnimation_in_spriteObject897 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_spriteArguments923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_arguments960 = new BitSet(new ulong[]{0xFFF400000F044802UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList983 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_43_in_expressionList986 = new BitSet(new ulong[]{0xFFF400000F044800UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList988 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}