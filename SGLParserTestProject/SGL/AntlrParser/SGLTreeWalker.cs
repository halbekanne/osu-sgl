// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g 2011-08-10 19:11:25

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


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
		"STRING", 
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
		"'while'", 
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

    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int SGLIDDigit = 27;
    public const int IntType = 15;
    public const int ID_LIST = 8;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int Identifier = 14;
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
    public const int StringType = 17;
    public const int T__59 = 59;
    public const int SpriteAnimation = 23;
    public const int COMMENT = 32;
    public const int VARDEF = 9;
    public const int T__50 = 50;
    public const int BooleanType = 16;
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
    public const int IntegerAtom = 20;
    public const int FloatType = 18;
    public const int StringAtom = 24;
    public const int NEGATE = 11;
    public const int HEX_DIGIT = 30;
    public const int BooleanAtom = 22;
    public const int T__33 = 33;
    public const int WS = 31;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 28;
    public const int BLOCK = 4;
    public const int ASSIGN = 10;
    public const int STATEMENTS = 5;
    public const int ObjectType = 19;
    public const int FloatAtom = 21;
    public const int EscapeSequence = 25;
    public const int Letter = 26;
    public const int OctalEscape = 29;
    public const int STRING = 13;

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:42:1: compilationUnit returns [SGLNode node] : block ;
    public SGLNode compilationUnit() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode block1 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:43:2: ( block )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:43:4: block
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:53:1: block returns [SGLNode node] : ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
    public SGLNode block() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode statement2 = default(SGLNode);


         
          BlockNode bn = new BlockNode(); 
          node = bn; 
          Scope scope = new Scope(currentScope); 
          currentScope = scope; 

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:63:2: ( ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:63:4: ^( BLOCK ^( STATEMENTS ( statement )* ) )
            {
            	Match(input,BLOCK,FOLLOW_BLOCK_in_block95); 

            	Match(input, Token.DOWN, null); 
            	Match(input,STATEMENTS,FOLLOW_STATEMENTS_in_block111); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:64:24: ( statement )*
            	    do 
            	    {
            	        int alt1 = 2;
            	        int LA1_0 = input.LA(1);

            	        if ( (LA1_0 == IF || (LA1_0 >= VARDEF && LA1_0 <= ASSIGN)) )
            	        {
            	            alt1 = 1;
            	        }


            	        switch (alt1) 
            	    	{
            	    		case 1 :
            	    		    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:64:25: statement
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:68:1: statement returns [SGLNode node] : ( variableDeclaration | variableAssignment | ifStatement );
    public SGLNode statement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode variableDeclaration3 = default(SGLNode);

        SGLNode variableAssignment4 = default(SGLNode);

        SGLNode ifStatement5 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:70:2: ( variableDeclaration | variableAssignment | ifStatement )
            int alt2 = 3;
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
            case IF:
            	{
                alt2 = 3;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:70:4: variableDeclaration
                    {
                    	PushFollow(FOLLOW_variableDeclaration_in_statement155);
                    	variableDeclaration3 = variableDeclaration();
                    	state.followingStackPointer--;

                    	 node = variableDeclaration3; 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:71:4: variableAssignment
                    {
                    	PushFollow(FOLLOW_variableAssignment_in_statement163);
                    	variableAssignment4 = variableAssignment();
                    	state.followingStackPointer--;

                    	 node = variableAssignment4; 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:73:4: ifStatement
                    {
                    	PushFollow(FOLLOW_ifStatement_in_statement173);
                    	ifStatement5 = ifStatement();
                    	state.followingStackPointer--;

                    	 node = ifStatement5; 

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


    // $ANTLR start "ifStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:83:1: ifStatement returns [SGLNode node] : ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) ;
    public SGLNode ifStatement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode b1 = default(SGLNode);

        SGLNode b2 = default(SGLNode);

        SGLNode expression6 = default(SGLNode);


         
          IfNode ifNode = new IfNode(); 
          node = ifNode; 

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:88:3: ( ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:88:6: ^( IF ( ^( EXP expression b1= block ) )+ ( ^( EXP b2= block ) )? )
            {
            	Match(input,IF,FOLLOW_IF_in_ifStatement205); 

            	Match(input, Token.DOWN, null); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:89:8: ( ^( EXP expression b1= block ) )+
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

            	            if ( (LA3_3 == NEGATE || LA3_3 == Identifier || (LA3_3 >= IntegerAtom && LA3_3 <= BooleanAtom) || LA3_3 == StringAtom || LA3_3 == 44 || (LA3_3 >= 46 && LA3_3 <= 58)) )
            	            {
            	                alt3 = 1;
            	            }


            	        }


            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:89:9: ^( EXP expression b1= block )
            			    {
            			    	Match(input,EXP,FOLLOW_EXP_in_ifStatement219); 

            			    	Match(input, Token.DOWN, null); 
            			    	PushFollow(FOLLOW_expression_in_ifStatement221);
            			    	expression6 = expression();
            			    	state.followingStackPointer--;

            			    	PushFollow(FOLLOW_block_in_ifStatement225);
            			    	b1 = block();
            			    	state.followingStackPointer--;


            			    	Match(input, Token.UP, null); 
            			    	 ifNode.AddChoice(expression6,b1); 

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

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:90:8: ( ^( EXP b2= block ) )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == EXP) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:90:9: ^( EXP b2= block )
            	        {
            	        	Match(input,EXP,FOLLOW_EXP_in_ifStatement245); 

            	        	Match(input, Token.DOWN, null); 
            	        	PushFollow(FOLLOW_block_in_ifStatement249);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:98:1: variableDeclaration returns [SGLNode node] : ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) );
    public SGLNode variableDeclaration() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        String variableType7 = default(String);

        String variableName8 = default(String);

        SGLNode expression9 = default(SGLNode);

        String variableType10 = default(String);

        String variableName11 = default(String);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:99:2: ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) )
            int alt5 = 2;
            alt5 = dfa5.Predict(input);
            switch (alt5) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:99:4: ^( VARDEF variableType variableName expression )
                    {
                    	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclaration291); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableType_in_variableDeclaration293);
                    	variableType7 = variableType();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_variableName_in_variableDeclaration295);
                    	variableName8 = variableName();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_variableDeclaration297);
                    	expression9 = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NewLocalVariableNode(variableType7,variableName8,expression9,currentScope); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:102:5: ^( VARDEF variableType variableName )
                    {
                    	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclaration321); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableType_in_variableDeclaration323);
                    	variableType10 = variableType();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_variableName_in_variableDeclaration325);
                    	variableName11 = variableName();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new NewLocalVariableNode(variableType10,variableName11,new AtomNode(null),currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:111:1: variableAssignment returns [SGLNode node] : ^( ASSIGN variableName expression ) ;
    public SGLNode variableAssignment() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        String variableName12 = default(String);

        SGLNode expression13 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:112:2: ( ^( ASSIGN variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:112:4: ^( ASSIGN variableName expression )
            {
            	Match(input,ASSIGN,FOLLOW_ASSIGN_in_variableAssignment354); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableName_in_variableAssignment356);
            	variableName12 = variableName();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_expression_in_variableAssignment358);
            	expression13 = expression();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 node = new AssignVariableNode(variableName12,expression13, currentScope); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:117:1: variableName returns [String txt] : Identifier ;
    public String variableName() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree Identifier14 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:118:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:118:4: Identifier
            {
            	Identifier14=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableName381); 
            	 txt = ((Identifier14 != null) ? Identifier14.Text : null); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:121:1: variableType returns [String txt] : ( IntType | BooleanType | StringType | FloatType );
    public String variableType() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree IntType15 = null;
        CommonTree BooleanType16 = null;
        CommonTree StringType17 = null;
        CommonTree FloatType18 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:122:2: ( IntType | BooleanType | StringType | FloatType )
            int alt6 = 4;
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
            	default:
            	    NoViableAltException nvae_d6s0 =
            	        new NoViableAltException("", 6, 0, input);

            	    throw nvae_d6s0;
            }

            switch (alt6) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:122:4: IntType
                    {
                    	IntType15=(CommonTree)Match(input,IntType,FOLLOW_IntType_in_variableType399); 
                    	 txt = ((IntType15 != null) ? IntType15.Text : null); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:123:4: BooleanType
                    {
                    	BooleanType16=(CommonTree)Match(input,BooleanType,FOLLOW_BooleanType_in_variableType406); 
                    	 txt = ((BooleanType16 != null) ? BooleanType16.Text : null); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:124:4: StringType
                    {
                    	StringType17=(CommonTree)Match(input,StringType,FOLLOW_StringType_in_variableType413); 
                    	 txt = ((StringType17 != null) ? StringType17.Text : null); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:125:4: FloatType
                    {
                    	FloatType18=(CommonTree)Match(input,FloatType,FOLLOW_FloatType_in_variableType420); 
                    	 txt = ((FloatType18 != null) ? FloatType18.Text : null); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:135:1: expression returns [SGLNode node] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | StringAtom | lookup );
    public SGLNode expression() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree IntegerAtom19 = null;
        CommonTree FloatAtom20 = null;
        CommonTree BooleanAtom21 = null;
        CommonTree StringAtom22 = null;
        SGLNode a = default(SGLNode);

        SGLNode b = default(SGLNode);

        SGLNode c = default(SGLNode);

        SGLNode lookup23 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:136:2: ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | IntegerAtom | FloatAtom | BooleanAtom | StringAtom | lookup )
            int alt7 = 20;
            switch ( input.LA(1) ) 
            {
            case 54:
            	{
                alt7 = 1;
                }
                break;
            case 55:
            	{
                alt7 = 2;
                }
                break;
            case 56:
            	{
                alt7 = 3;
                }
                break;
            case 57:
            	{
                alt7 = 4;
                }
                break;
            case 58:
            	{
                alt7 = 5;
                }
                break;
            case NEGATE:
            	{
                alt7 = 6;
                }
                break;
            case 50:
            	{
                alt7 = 7;
                }
                break;
            case 52:
            	{
                alt7 = 8;
                }
                break;
            case 51:
            	{
                alt7 = 9;
                }
                break;
            case 53:
            	{
                alt7 = 10;
                }
                break;
            case 49:
            	{
                alt7 = 11;
                }
                break;
            case 48:
            	{
                alt7 = 12;
                }
                break;
            case 47:
            	{
                alt7 = 13;
                }
                break;
            case 46:
            	{
                alt7 = 14;
                }
                break;
            case 44:
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
            case StringAtom:
            	{
                alt7 = 19;
                }
                break;
            case Identifier:
            	{
                alt7 = 20;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:136:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,54,FOLLOW_54_in_expression460); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression464);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression468);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MAddNode(a, b); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:137:4: ^( '-' a= expression b= expression )
                    {
                    	Match(input,55,FOLLOW_55_in_expression477); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression481);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression485);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MSubNode(a, b); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:138:4: ^( '*' a= expression b= expression )
                    {
                    	Match(input,56,FOLLOW_56_in_expression494); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression498);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression502);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MMultNode(a, b); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:139:4: ^( '/' a= expression b= expression )
                    {
                    	Match(input,57,FOLLOW_57_in_expression511); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression515);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression519);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MDivNode(a, b); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:140:4: ^( '%' a= expression b= expression )
                    {
                    	Match(input,58,FOLLOW_58_in_expression528); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression532);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression536);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MModNode(a, b); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:141:4: ^( NEGATE a= expression )
                    {
                    	Match(input,NEGATE,FOLLOW_NEGATE_in_expression545); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression549);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MNegateNode(a); 

                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:142:4: ^( '<' a= expression b= expression )
                    {
                    	Match(input,50,FOLLOW_50_in_expression558); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression562);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression566);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CLTNode(a, b); 

                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:143:4: ^( '<=' a= expression b= expression )
                    {
                    	Match(input,52,FOLLOW_52_in_expression575); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression579);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression583);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CLTEqualsNode(a, b); 

                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:144:4: ^( '>' a= expression b= expression )
                    {
                    	Match(input,51,FOLLOW_51_in_expression592); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression596);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression600);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CGTNode(a, b); 

                    }
                    break;
                case 10 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:145:4: ^( '>=' a= expression b= expression )
                    {
                    	Match(input,53,FOLLOW_53_in_expression609); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression613);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression617);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CGTEqualsNode(a, b); 

                    }
                    break;
                case 11 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:146:4: ^( '!=' a= expression b= expression )
                    {
                    	Match(input,49,FOLLOW_49_in_expression626); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression630);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression634);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CNotEqualsNode(a, b); 

                    }
                    break;
                case 12 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:147:4: ^( '==' a= expression b= expression )
                    {
                    	Match(input,48,FOLLOW_48_in_expression643); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression647);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression651);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CEqualsNode(a, b); 

                    }
                    break;
                case 13 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:148:4: ^( '&&' a= expression b= expression )
                    {
                    	Match(input,47,FOLLOW_47_in_expression660); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression664);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression668);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new CAndNode(a, b); 

                    }
                    break;
                case 14 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:149:4: ^( '||' a= expression b= expression )
                    {
                    	Match(input,46,FOLLOW_46_in_expression677); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression681);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression685);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new COrNode(a, b); 

                    }
                    break;
                case 15 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:150:4: ^( '?' a= expression b= expression c= expression )
                    {
                    	Match(input,44,FOLLOW_44_in_expression694); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression698);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression702);
                    	b = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression706);
                    	c = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new TernaryNode(a, b, c); 

                    }
                    break;
                case 16 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:151:6: IntegerAtom
                    {
                    	IntegerAtom19=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_expression716); 
                    	 node = new AtomNode(int.Parse(((IntegerAtom19 != null) ? IntegerAtom19.Text : null), System.Globalization.CultureInfo.InvariantCulture)); 

                    }
                    break;
                case 17 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:152:4: FloatAtom
                    {
                    	FloatAtom20=(CommonTree)Match(input,FloatAtom,FOLLOW_FloatAtom_in_expression723); 
                    	 node = new AtomNode(Double.Parse(((FloatAtom20 != null) ? FloatAtom20.Text : null), System.Globalization.CultureInfo.InvariantCulture)); 

                    }
                    break;
                case 18 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:153:6: BooleanAtom
                    {
                    	BooleanAtom21=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression732); 
                    	 node = new AtomNode(Boolean.Parse(((BooleanAtom21 != null) ? BooleanAtom21.Text : null))); 

                    }
                    break;
                case 19 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:154:4: StringAtom
                    {
                    	StringAtom22=(CommonTree)Match(input,StringAtom,FOLLOW_StringAtom_in_expression739); 
                    	 node = new AtomNode(((StringAtom22 != null) ? StringAtom22.Text : null)); 

                    }
                    break;
                case 20 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:155:4: lookup
                    {
                    	PushFollow(FOLLOW_lookup_in_expression746);
                    	lookup23 = lookup();
                    	state.followingStackPointer--;

                    	 node = lookup23; 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:160:1: lookup returns [SGLNode node] : Identifier ;
    public SGLNode lookup() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree Identifier24 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:161:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:161:4: Identifier
            {
            	Identifier24=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_lookup784); 
            	 node = new IdentifierNode(((Identifier24 != null) ? Identifier24.Text : null), currentScope); 

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


    // $ANTLR start "arguments"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:168:1: arguments : '(' ( expressionList )? ')' ;
    public void arguments() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:169:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:169:9: '(' ( expressionList )? ')'
            {
            	Match(input,36,FOLLOW_36_in_arguments819); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:169:13: ( expressionList )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == NEGATE || LA8_0 == Identifier || (LA8_0 >= IntegerAtom && LA8_0 <= BooleanAtom) || LA8_0 == StringAtom || LA8_0 == 44 || (LA8_0 >= 46 && LA8_0 <= 58)) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:169:13: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments821);
            	        	expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Match(input,37,FOLLOW_37_in_arguments824); 

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
    // $ANTLR end "arguments"


    // $ANTLR start "expressionList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:172:1: expressionList : expression ( ',' expression )* ;
    public void expressionList() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:173:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:173:9: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList843);
            	expression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:173:20: ( ',' expression )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 39) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:173:21: ',' expression
            			    {
            			    	Match(input,39,FOLLOW_39_in_expressionList846); 
            			    	PushFollow(FOLLOW_expression_in_expressionList848);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:178:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public void literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:179:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:
            {
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == StringAtom || input.LA(1) == 63 ) 
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
        "\x0a\uffff";
    const string DFA5_eofS =
        "\x0a\uffff";
    const string DFA5_minS =
        "\x01\x09\x01\x02\x01\x0f\x04\x0e\x01\x03\x02\uffff";
    const string DFA5_maxS =
        "\x01\x09\x01\x02\x01\x12\x04\x0e\x01\x3a\x02\uffff";
    const string DFA5_acceptS =
        "\x08\uffff\x01\x01\x01\x02";
    const string DFA5_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x01\x01",
            "\x01\x02",
            "\x01\x03\x01\x04\x01\x05\x01\x06",
            "\x01\x07",
            "\x01\x07",
            "\x01\x07",
            "\x01\x07",
            "\x01\x09\x07\uffff\x01\x08\x02\uffff\x01\x08\x05\uffff\x03"+
            "\x08\x01\uffff\x01\x08\x13\uffff\x01\x08\x01\uffff\x0d\x08",
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
            get { return "98:1: variableDeclaration returns [SGLNode node] : ( ^( VARDEF variableType variableName expression ) | ^( VARDEF variableType variableName ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_block_in_compilationUnit60 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BLOCK_in_block95 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_STATEMENTS_in_block111 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_block114 = new BitSet(new ulong[]{0x0000000000000648UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_statement155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_statement163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement173 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IF_in_ifStatement205 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement219 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_ifStatement221 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement225 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_EXP_in_ifStatement245 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_block_in_ifStatement249 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclaration291 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration293 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration295 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclaration297 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclaration321 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration323 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration325 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_variableAssignment354 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableName_in_variableAssignment356 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_variableAssignment358 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName381 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_variableType399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_variableType406 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringType_in_variableType413 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatType_in_variableType420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_54_in_expression460 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression464 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression468 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_55_in_expression477 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression481 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression485 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_56_in_expression494 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression498 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression502 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_57_in_expression511 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression515 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression519 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_58_in_expression528 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression532 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression536 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEGATE_in_expression545 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression549 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_50_in_expression558 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression562 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression566 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_52_in_expression575 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression579 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression583 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_51_in_expression592 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression596 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression600 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_53_in_expression609 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression613 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression617 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_49_in_expression626 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression630 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression634 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_48_in_expression643 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression647 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression651 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_47_in_expression660 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression664 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression668 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_46_in_expression677 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression681 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression685 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_44_in_expression694 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression698 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression702 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expression706 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_expression716 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_expression723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_expression732 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringAtom_in_expression739 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookup_in_expression746 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_lookup784 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_arguments819 = new BitSet(new ulong[]{0x07FFD02001704800UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments821 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_arguments824 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList843 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_39_in_expressionList846 = new BitSet(new ulong[]{0x07FFD00001704800UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList848 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}