// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g 2011-08-08 16:16:51

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


	using System.Collections.Generic;


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
		"','", 
		"'='", 
		"'while'", 
		"'('", 
		"')'", 
		"'{'", 
		"'}'", 
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

    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int SGLIDDigit = 22;
    public const int IntType = 10;
    public const int EOF = -1;
    public const int Identifier = 9;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int StringType = 12;
    public const int SpriteAnimation = 18;
    public const int VARDEF = 4;
    public const int COMMENT = 27;
    public const int T__50 = 50;
    public const int BooleanType = 11;
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
    public const int LIBMETHOD = 7;
    public const int IntegerAtom = 15;
    public const int FloatType = 13;
    public const int StringAtom = 19;
    public const int HEX_DIGIT = 25;
    public const int NEGATE = 6;
    public const int BooleanAtom = 17;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 26;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 23;
    public const int ASSIGN = 5;
    public const int ObjectType = 14;
    public const int FloatAtom = 16;
    public const int EscapeSequence = 20;
    public const int Letter = 21;
    public const int OctalEscape = 24;
    public const int STRING = 8;

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
		get { return "C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g"; }
    }


    	
    	// Error reporting
        private StdErrReporter errorReporter = new StdErrReporter();
        public override void EmitErrorMessage(String msg)
        {
        	errorReporter.ReportError(msg);
        }

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:41:1: compilationUnit : ( mainStatement )+ EOF ;
    public void compilationUnit() // throws RecognitionException [1]
    {   
         
          BlockNode bn = new BlockNode(); 
          node = bn; 
          Scope scope = new Scope(currentScope); 
          currentScope = scope; 

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:51:2: ( ( mainStatement )+ EOF )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:51:4: ( mainStatement )+ EOF
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:51:4: ( mainStatement )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= VARDEF && LA1_0 <= ASSIGN) || LA1_0 == 30) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:51:4: mainStatement
            			    {
            			    	PushFollow(FOLLOW_mainStatement_in_compilationUnit70);
            			    	mainStatement();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	Match(input,EOF,FOLLOW_EOF_in_compilationUnit73); 

            }

             
              currentScope = currentScope.parent(); 

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
    // $ANTLR end "compilationUnit"


    // $ANTLR start "mainStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:54:1: mainStatement : statement ;
    public void mainStatement() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:55:2: ( statement )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:55:4: statement
            {
            	PushFollow(FOLLOW_statement_in_mainStatement86);
            	statement();
            	state.followingStackPointer--;


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
    // $ANTLR end "mainStatement"


    // $ANTLR start "statement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:59:1: statement : ( variableDeclarationList | ^( ASSIGN variableAssignment ) | whileLoop );
    public void statement() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:61:2: ( variableDeclarationList | ^( ASSIGN variableAssignment ) | whileLoop )
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
            case 30:
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:61:4: variableDeclarationList
                    {
                    	PushFollow(FOLLOW_variableDeclarationList_in_statement101);
                    	variableDeclarationList();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:62:4: ^( ASSIGN variableAssignment )
                    {
                    	Match(input,ASSIGN,FOLLOW_ASSIGN_in_statement108); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableAssignment_in_statement110);
                    	variableAssignment();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:63:4: whileLoop
                    {
                    	PushFollow(FOLLOW_whileLoop_in_statement116);
                    	whileLoop();
                    	state.followingStackPointer--;


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
        return ;
    }
    // $ANTLR end "statement"


    // $ANTLR start "whileLoop"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:66:1: whileLoop : ^( 'while' expression ( statement )* ) ;
    public void whileLoop() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:67:2: ( ^( 'while' expression ( statement )* ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:67:4: ^( 'while' expression ( statement )* )
            {
            	Match(input,30,FOLLOW_30_in_whileLoop129); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_whileLoop131);
            	expression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:67:25: ( statement )*
            	do 
            	{
            	    int alt3 = 2;
            	    int LA3_0 = input.LA(1);

            	    if ( ((LA3_0 >= VARDEF && LA3_0 <= ASSIGN) || LA3_0 == 30) )
            	    {
            	        alt3 = 1;
            	    }


            	    switch (alt3) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:67:25: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_whileLoop133);
            			    	statement();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop3;
            	    }
            	} while (true);

            	loop3:
            		;	// Stops C# compiler whining that label 'loop3' has no statements


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
        return ;
    }
    // $ANTLR end "whileLoop"


    // $ANTLR start "variableDeclarationList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:77:1: variableDeclarationList : ^( VARDEF variableType variableName expression ) ;
    public void variableDeclarationList() // throws RecognitionException [1]
    {   
        string variableType1 = default(string);

        string variableName2 = default(string);

        string expression3 = default(string);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:78:2: ( ^( VARDEF variableType variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:78:4: ^( VARDEF variableType variableName expression )
            {
            	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclarationList157); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableType_in_variableDeclarationList159);
            	variableType1 = variableType();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_variableName_in_variableDeclarationList161);
            	variableName2 = variableName();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_expression_in_variableDeclarationList163);
            	expression3 = expression();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 	
            			action.NewLocalVariable(variableType1,variableName2,expression3); 
            		

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
    // $ANTLR end "variableDeclarationList"


    // $ANTLR start "variableAssignment"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:87:1: variableAssignment : variableName ( expression )? ;
    public void variableAssignment() // throws RecognitionException [1]
    {   
        string variableName4 = default(string);

        string expression5 = default(string);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:88:2: ( variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:88:4: variableName ( expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableAssignment182);
            	variableName4 = variableName();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:88:17: ( expression )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == NEGATE || LA4_0 == Identifier || LA4_0 == IntegerAtom || LA4_0 == BooleanAtom || LA4_0 == 35 || (LA4_0 >= 37 && LA4_0 <= 49)) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:88:17: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_variableAssignment184);
            	        	expression5 = expression();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}


            			action.AssignVariable(variableName4,expression5);
            		

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
    // $ANTLR end "variableAssignment"


    // $ANTLR start "variableName"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:94:1: variableName returns [string txt] : Identifier ;
    public string variableName() // throws RecognitionException [1]
    {   
        string txt = default(string);

        CommonTree Identifier6 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:95:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:95:4: Identifier
            {
            	Identifier6=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableName205); 
            	txt =  ((Identifier6 != null) ? Identifier6.Text : null);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:98:1: variableType returns [string txt] : ( IntType | BooleanType | StringType | FloatType );
    public string variableType() // throws RecognitionException [1]
    {   
        string txt = default(string);

        CommonTree IntType7 = null;
        CommonTree BooleanType8 = null;
        CommonTree StringType9 = null;
        CommonTree FloatType10 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:99:2: ( IntType | BooleanType | StringType | FloatType )
            int alt5 = 4;
            switch ( input.LA(1) ) 
            {
            case IntType:
            	{
                alt5 = 1;
                }
                break;
            case BooleanType:
            	{
                alt5 = 2;
                }
                break;
            case StringType:
            	{
                alt5 = 3;
                }
                break;
            case FloatType:
            	{
                alt5 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("", 5, 0, input);

            	    throw nvae_d5s0;
            }

            switch (alt5) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:99:4: IntType
                    {
                    	IntType7=(CommonTree)Match(input,IntType,FOLLOW_IntType_in_variableType223); 
                    	txt =  ((IntType7 != null) ? IntType7.Text : null);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:100:4: BooleanType
                    {
                    	BooleanType8=(CommonTree)Match(input,BooleanType,FOLLOW_BooleanType_in_variableType230); 
                    	txt =  ((BooleanType8 != null) ? BooleanType8.Text : null);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:101:4: StringType
                    {
                    	StringType9=(CommonTree)Match(input,StringType,FOLLOW_StringType_in_variableType237); 
                    	txt =  ((StringType9 != null) ? StringType9.Text : null);

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:102:4: FloatType
                    {
                    	FloatType10=(CommonTree)Match(input,FloatType,FOLLOW_FloatType_in_variableType244); 
                    	txt =  ((FloatType10 != null) ? FloatType10.Text : null);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:112:1: expression returns [string txt] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | Identifier | IntegerAtom | BooleanAtom );
    public string expression() // throws RecognitionException [1]
    {   
        string txt = default(string);

        CommonTree Identifier11 = null;
        CommonTree IntegerAtom12 = null;
        CommonTree BooleanAtom13 = null;
        string a = default(string);

        string b = default(string);

        string c = default(string);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:113:2: ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | Identifier | IntegerAtom | BooleanAtom )
            int alt6 = 18;
            switch ( input.LA(1) ) 
            {
            case 45:
            	{
                alt6 = 1;
                }
                break;
            case 46:
            	{
                alt6 = 2;
                }
                break;
            case 47:
            	{
                alt6 = 3;
                }
                break;
            case 48:
            	{
                alt6 = 4;
                }
                break;
            case 49:
            	{
                alt6 = 5;
                }
                break;
            case NEGATE:
            	{
                alt6 = 6;
                }
                break;
            case 41:
            	{
                alt6 = 7;
                }
                break;
            case 43:
            	{
                alt6 = 8;
                }
                break;
            case 42:
            	{
                alt6 = 9;
                }
                break;
            case 44:
            	{
                alt6 = 10;
                }
                break;
            case 40:
            	{
                alt6 = 11;
                }
                break;
            case 39:
            	{
                alt6 = 12;
                }
                break;
            case 38:
            	{
                alt6 = 13;
                }
                break;
            case 37:
            	{
                alt6 = 14;
                }
                break;
            case 35:
            	{
                alt6 = 15;
                }
                break;
            case Identifier:
            	{
                alt6 = 16;
                }
                break;
            case IntegerAtom:
            	{
                alt6 = 17;
                }
                break;
            case BooleanAtom:
            	{
                alt6 = 18;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:113:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,45,FOLLOW_45_in_expression284); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression288);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression292);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.Add(a,b); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:114:4: ^( '-' a= expression b= expression )
                    {
                    	Match(input,46,FOLLOW_46_in_expression301); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression305);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression309);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.Sub(a,b); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:115:4: ^( '*' a= expression b= expression )
                    {
                    	Match(input,47,FOLLOW_47_in_expression318); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression322);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression326);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.Mult(a,b); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:116:4: ^( '/' a= expression b= expression )
                    {
                    	Match(input,48,FOLLOW_48_in_expression335); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression339);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression343);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.Div(a,b); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:117:4: ^( '%' a= expression b= expression )
                    {
                    	Match(input,49,FOLLOW_49_in_expression352); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression356);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression360);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.Remainder(a,b); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:118:4: ^( NEGATE a= expression )
                    {
                    	Match(input,NEGATE,FOLLOW_NEGATE_in_expression370); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression374);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.Mult(a,"-1"); 

                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:119:4: ^( '<' a= expression b= expression )
                    {
                    	Match(input,41,FOLLOW_41_in_expression383); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression387);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression391);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.ConditionLess(a,b); 

                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:120:4: ^( '<=' a= expression b= expression )
                    {
                    	Match(input,43,FOLLOW_43_in_expression400); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression404);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression408);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.ConditionLessOrEqual(a,b); 

                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:121:4: ^( '>' a= expression b= expression )
                    {
                    	Match(input,42,FOLLOW_42_in_expression417); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression421);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression425);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.ConditionGreater(a,b); 

                    }
                    break;
                case 10 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:122:4: ^( '>=' a= expression b= expression )
                    {
                    	Match(input,44,FOLLOW_44_in_expression434); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression438);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression442);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.ConditionGreaterOrEqual(a,b); 

                    }
                    break;
                case 11 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:123:4: ^( '!=' a= expression b= expression )
                    {
                    	Match(input,40,FOLLOW_40_in_expression451); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression455);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression459);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.ConditionNotEqual(a,b); 

                    }
                    break;
                case 12 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:124:4: ^( '==' a= expression b= expression )
                    {
                    	Match(input,39,FOLLOW_39_in_expression468); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression472);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression476);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.ConditionEqual(a,b); 

                    }
                    break;
                case 13 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:125:4: ^( '&&' a= expression b= expression )
                    {
                    	Match(input,38,FOLLOW_38_in_expression485); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression489);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression493);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.ConnectiveAnd(a,b); 

                    }
                    break;
                case 14 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:126:4: ^( '||' a= expression b= expression )
                    {
                    	Match(input,37,FOLLOW_37_in_expression502); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression506);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression510);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.ConnectiveOr(a,b); 

                    }
                    break;
                case 15 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:127:4: ^( '?' a= expression b= expression c= expression )
                    {
                    	Match(input,35,FOLLOW_35_in_expression519); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression523);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression527);
                    	b = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression531);
                    	c = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.ConditionBranch(a,b,c); 

                    }
                    break;
                case 16 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:128:4: Identifier
                    {
                    	Identifier11=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_expression539); 
                    	 txt =  action.GetVariable(((Identifier11 != null) ? Identifier11.Text : null)); 

                    }
                    break;
                case 17 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:129:6: IntegerAtom
                    {
                    	IntegerAtom12=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_expression548); 
                    	 txt =  ((IntegerAtom12 != null) ? IntegerAtom12.Text : null); 

                    }
                    break;
                case 18 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:130:6: BooleanAtom
                    {
                    	BooleanAtom13=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression557); 
                    	 txt =  ((BooleanAtom13 != null) ? BooleanAtom13.Text : null); 

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
    // $ANTLR end "expression"


    // $ANTLR start "conditionalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:139:1: conditionalExpression : conditionalOrExpression '?' conditionalExpression ':' conditionalExpression ;
    public void conditionalExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:140:5: ( conditionalOrExpression '?' conditionalExpression ':' conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:140:10: conditionalOrExpression '?' conditionalExpression ':' conditionalExpression
            {
            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression601);
            	conditionalOrExpression();
            	state.followingStackPointer--;

            	Match(input,35,FOLLOW_35_in_conditionalExpression603); 
            	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression605);
            	conditionalExpression();
            	state.followingStackPointer--;

            	Match(input,36,FOLLOW_36_in_conditionalExpression607); 
            	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression608);
            	conditionalExpression();
            	state.followingStackPointer--;


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
    // $ANTLR end "conditionalExpression"


    // $ANTLR start "conditionalOrExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:145:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public void conditionalOrExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:146:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:146:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression648);
            	conditionalAndExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:146:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == 37) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:146:36: '||' conditionalAndExpression
            			    {
            			    	Match(input,37,FOLLOW_37_in_conditionalOrExpression652); 
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression654);
            			    	conditionalAndExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


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
    // $ANTLR end "conditionalOrExpression"


    // $ANTLR start "conditionalAndExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:150:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public void conditionalAndExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:151:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:151:9: equalityExpression ( '&&' equalityExpression )*
            {
            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression685);
            	equalityExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:151:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == 38) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:151:30: '&&' equalityExpression
            			    {
            			    	Match(input,38,FOLLOW_38_in_conditionalAndExpression689); 
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression691);
            			    	equalityExpression();
            			    	state.followingStackPointer--;


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
        return ;
    }
    // $ANTLR end "conditionalAndExpression"


    // $ANTLR start "equalityExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:155:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public void equalityExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:156:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:156:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression718);
            	relationalExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:156:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= 39 && LA9_0 <= 40)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:156:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	if ( (input.LA(1) >= 39 && input.LA(1) <= 40) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression730);
            			    	relationalExpression();
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
    // $ANTLR end "equalityExpression"


    // $ANTLR start "relationalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:160:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public void relationalExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:161:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:161:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression761);
            	additiveExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:161:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= 41 && LA10_0 <= 44)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:161:30: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	if ( (input.LA(1) >= 41 && input.LA(1) <= 44) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression775);
            			    	additiveExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements


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
    // $ANTLR end "relationalExpression"


    // $ANTLR start "additiveExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:165:1: additiveExpression : e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )* ;
    public void additiveExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:166:5: (e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:166:9: e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )*
            {
            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression816);
            	multiplicativeExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:167:5: ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )*
            	do 
            	{
            	    int alt11 = 3;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == 45) )
            	    {
            	        alt11 = 1;
            	    }
            	    else if ( (LA11_0 == 46) )
            	    {
            	        alt11 = 2;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:167:7: '+' e= multiplicativeExpression
            			    {
            			    	Match(input,45,FOLLOW_45_in_additiveExpression824); 
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression828);
            			    	multiplicativeExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:168:7: '-' e= multiplicativeExpression
            			    {
            			    	Match(input,46,FOLLOW_46_in_additiveExpression837); 
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression841);
            			    	multiplicativeExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements


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
    // $ANTLR end "additiveExpression"


    // $ANTLR start "multiplicativeExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:173:1: multiplicativeExpression : e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* ;
    public void multiplicativeExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:174:5: (e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:174:9: e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            {
            	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression882);
            	mathAtom();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:175:5: ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            	do 
            	{
            	    int alt12 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 47:
            	    	{
            	        alt12 = 1;
            	        }
            	        break;
            	    case 48:
            	    	{
            	        alt12 = 2;
            	        }
            	        break;
            	    case 49:
            	    	{
            	        alt12 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:175:7: '*' e= mathAtom
            			    {
            			    	Match(input,47,FOLLOW_47_in_multiplicativeExpression890); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression894);
            			    	mathAtom();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:176:7: '/' e= mathAtom
            			    {
            			    	Match(input,48,FOLLOW_48_in_multiplicativeExpression902); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression906);
            			    	mathAtom();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:177:7: '%' e= mathAtom
            			    {
            			    	Match(input,49,FOLLOW_49_in_multiplicativeExpression914); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression918);
            			    	mathAtom();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


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
    // $ANTLR end "multiplicativeExpression"


    // $ANTLR start "unaryExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:181:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public void unaryExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:182:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt13 = 3;
            switch ( input.LA(1) ) 
            {
            case 50:
            	{
                alt13 = 1;
                }
                break;
            case 51:
            	{
                alt13 = 2;
                }
                break;
            case IntegerAtom:
            case 31:
            case 46:
            case 52:
            	{
                alt13 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d13s0 =
            	        new NoViableAltException("", 13, 0, input);

            	    throw nvae_d13s0;
            }

            switch (alt13) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:182:7: '++' unaryExpression
                    {
                    	Match(input,50,FOLLOW_50_in_unaryExpression946); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression948);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:183:9: '--' unaryExpression
                    {
                    	Match(input,51,FOLLOW_51_in_unaryExpression958); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression960);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:184:9: unaryExpressionNotPlusMinus
                    {
                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression970);
                    	unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;


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
        return ;
    }
    // $ANTLR end "unaryExpression"


    // $ANTLR start "unaryExpressionNotPlusMinus"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:188:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public void unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:189:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt15 = 3;
            switch ( input.LA(1) ) 
            {
            case 52:
            	{
                alt15 = 1;
                }
                break;
            case 31:
            	{
                int LA15_2 = input.LA(2);

                if ( ((LA15_2 >= IntType && LA15_2 <= FloatType)) )
                {
                    alt15 = 2;
                }
                else if ( (LA15_2 == IntegerAtom || LA15_2 == 31 || LA15_2 == 46) )
                {
                    alt15 = 3;
                }
                else 
                {
                    NoViableAltException nvae_d15s2 =
                        new NoViableAltException("", 15, 2, input);

                    throw nvae_d15s2;
                }
                }
                break;
            case IntegerAtom:
            case 46:
            	{
                alt15 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("", 15, 0, input);

            	    throw nvae_d15s0;
            }

            switch (alt15) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:189:9: '!' unaryExpression
                    {
                    	Match(input,52,FOLLOW_52_in_unaryExpressionNotPlusMinus991); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus993);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:190:9: castExpression
                    {
                    	PushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus1003);
                    	castExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:192:9: mathAtom ( '++' | '--' )?
                    {
                    	PushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus1018);
                    	mathAtom();
                    	state.followingStackPointer--;

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:192:18: ( '++' | '--' )?
                    	int alt14 = 2;
                    	int LA14_0 = input.LA(1);

                    	if ( ((LA14_0 >= 50 && LA14_0 <= 51)) )
                    	{
                    	    alt14 = 1;
                    	}
                    	switch (alt14) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:
                    	        {
                    	        	if ( (input.LA(1) >= 50 && input.LA(1) <= 51) ) 
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
                    	        break;

                    	}


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
        return ;
    }
    // $ANTLR end "unaryExpressionNotPlusMinus"


    // $ANTLR start "castExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:196:1: castExpression : '(' variableType ')' unaryExpression ;
    public void castExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:197:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:197:8: '(' variableType ')' unaryExpression
            {
            	Match(input,31,FOLLOW_31_in_castExpression1051); 
            	PushFollow(FOLLOW_variableType_in_castExpression1053);
            	variableType();
            	state.followingStackPointer--;

            	Match(input,32,FOLLOW_32_in_castExpression1055); 
            	PushFollow(FOLLOW_unaryExpression_in_castExpression1057);
            	unaryExpression();
            	state.followingStackPointer--;


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
    // $ANTLR end "castExpression"


    // $ANTLR start "mathAtom"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:201:1: mathAtom : ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) ;
    public void mathAtom() // throws RecognitionException [1]
    {   
        CommonTree i = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:202:5: ( ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:202:9: ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom )
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:202:9: ( '-' )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == 46) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:202:10: '-'
            	        {
            	        	Match(input,46,FOLLOW_46_in_mathAtom1080); 

            	        }
            	        break;

            	}

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:203:5: ( '(' e= additiveExpression ')' | i= IntegerAtom )
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == 31) )
            	{
            	    alt17 = 1;
            	}
            	else if ( (LA17_0 == IntegerAtom) )
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
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:203:7: '(' e= additiveExpression ')'
            	        {
            	        	Match(input,31,FOLLOW_31_in_mathAtom1091); 
            	        	PushFollow(FOLLOW_additiveExpression_in_mathAtom1095);
            	        	additiveExpression();
            	        	state.followingStackPointer--;

            	        	Match(input,32,FOLLOW_32_in_mathAtom1097); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:204:9: i= IntegerAtom
            	        {
            	        	i=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom1109); 

            	        }
            	        break;

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
    // $ANTLR end "mathAtom"


    // $ANTLR start "arguments"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:212:1: arguments : '(' ( expressionList )? ')' ;
    public void arguments() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:213:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:213:9: '(' ( expressionList )? ')'
            {
            	Match(input,31,FOLLOW_31_in_arguments1146); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:213:13: ( expressionList )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == NEGATE || LA18_0 == Identifier || LA18_0 == IntegerAtom || LA18_0 == BooleanAtom || LA18_0 == 35 || (LA18_0 >= 37 && LA18_0 <= 49)) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:213:13: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments1148);
            	        	expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Match(input,32,FOLLOW_32_in_arguments1151); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:216:1: expressionList : expression ( ',' expression )* ;
    public void expressionList() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:217:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:217:9: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList1170);
            	expression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:217:20: ( ',' expression )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( (LA19_0 == 28) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:217:21: ',' expression
            			    {
            			    	Match(input,28,FOLLOW_28_in_expressionList1173); 
            			    	PushFollow(FOLLOW_expression_in_expressionList1175);
            			    	expression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:222:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public void literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:223:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\SGLTreeWalker.g:
            {
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == StringAtom || input.LA(1) == 54 ) 
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


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_mainStatement_in_compilationUnit70 = new BitSet(new ulong[]{0x0000000040000030UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit73 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_mainStatement86 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_statement101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_statement108 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_statement110 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement116 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_whileLoop129 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop131 = new BitSet(new ulong[]{0x0000000040000038UL});
    public static readonly BitSet FOLLOW_statement_in_whileLoop133 = new BitSet(new ulong[]{0x0000000040000038UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclarationList157 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclarationList159 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclarationList161 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclarationList163 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_variableName_in_variableAssignment182 = new BitSet(new ulong[]{0x0003FFE800028242UL});
    public static readonly BitSet FOLLOW_expression_in_variableAssignment184 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName205 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_variableType223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_variableType230 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringType_in_variableType237 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatType_in_variableType244 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_expression284 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression288 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression292 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_46_in_expression301 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression305 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression309 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_47_in_expression318 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression322 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression326 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_48_in_expression335 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression339 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression343 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_49_in_expression352 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression356 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression360 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEGATE_in_expression370 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression374 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_41_in_expression383 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression387 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression391 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_43_in_expression400 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression404 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression408 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_42_in_expression417 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression421 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression425 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_44_in_expression434 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression438 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression442 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_40_in_expression451 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression455 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression459 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_39_in_expression468 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression472 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression476 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_38_in_expression485 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression489 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression493 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_37_in_expression502 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression506 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression510 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_35_in_expression519 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression523 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression527 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression531 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Identifier_in_expression539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_expression548 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_expression557 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression601 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_conditionalExpression603 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression605 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_36_in_conditionalExpression607 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression608 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression648 = new BitSet(new ulong[]{0x0000002000000002UL});
    public static readonly BitSet FOLLOW_37_in_conditionalOrExpression652 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression654 = new BitSet(new ulong[]{0x0000002000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression685 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_38_in_conditionalAndExpression689 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression691 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression718 = new BitSet(new ulong[]{0x0000018000000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpression722 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression730 = new BitSet(new ulong[]{0x0000018000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression761 = new BitSet(new ulong[]{0x00001E0000000002UL});
    public static readonly BitSet FOLLOW_set_in_relationalExpression765 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression775 = new BitSet(new ulong[]{0x00001E0000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression816 = new BitSet(new ulong[]{0x0000600000000002UL});
    public static readonly BitSet FOLLOW_45_in_additiveExpression824 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression828 = new BitSet(new ulong[]{0x0000600000000002UL});
    public static readonly BitSet FOLLOW_46_in_additiveExpression837 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression841 = new BitSet(new ulong[]{0x0000600000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression882 = new BitSet(new ulong[]{0x0003800000000002UL});
    public static readonly BitSet FOLLOW_47_in_multiplicativeExpression890 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression894 = new BitSet(new ulong[]{0x0003800000000002UL});
    public static readonly BitSet FOLLOW_48_in_multiplicativeExpression902 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression906 = new BitSet(new ulong[]{0x0003800000000002UL});
    public static readonly BitSet FOLLOW_49_in_multiplicativeExpression914 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression918 = new BitSet(new ulong[]{0x0003800000000002UL});
    public static readonly BitSet FOLLOW_50_in_unaryExpression946 = new BitSet(new ulong[]{0x001C400080008000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression948 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_unaryExpression958 = new BitSet(new ulong[]{0x001C400080008000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression960 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression970 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_unaryExpressionNotPlusMinus991 = new BitSet(new ulong[]{0x001C400080008000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus993 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus1003 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus1018 = new BitSet(new ulong[]{0x000C000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus1020 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_castExpression1051 = new BitSet(new ulong[]{0x0000000000003C00UL});
    public static readonly BitSet FOLLOW_variableType_in_castExpression1053 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_castExpression1055 = new BitSet(new ulong[]{0x001C400080008000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1057 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_mathAtom1080 = new BitSet(new ulong[]{0x0000000080008000UL});
    public static readonly BitSet FOLLOW_31_in_mathAtom1091 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_mathAtom1095 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_mathAtom1097 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom1109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_arguments1146 = new BitSet(new ulong[]{0x0003FFE900028240UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1148 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_arguments1151 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1170 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_expressionList1173 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1175 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}