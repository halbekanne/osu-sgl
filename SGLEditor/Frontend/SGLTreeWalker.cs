// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g 2011-08-08 01:41:25

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


namespace  SGL.Parser 
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
		get { return "C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g"; }
    }


    	SGLActions action = new SGLActions();
    	
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:42:1: compilationUnit : ( mainStatement )+ EOF ;
    public void compilationUnit() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:43:2: ( ( mainStatement )+ EOF )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:43:4: ( mainStatement )+ EOF
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:43:4: ( mainStatement )+
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:43:4: mainStatement
            			    {
            			    	PushFollow(FOLLOW_mainStatement_in_compilationUnit56);
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

            	Match(input,EOF,FOLLOW_EOF_in_compilationUnit59); 

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
    // $ANTLR end "compilationUnit"


    // $ANTLR start "mainStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:46:1: mainStatement : statement ;
    public void mainStatement() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:47:2: ( statement )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:47:4: statement
            {
            	PushFollow(FOLLOW_statement_in_mainStatement71);
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

    public class statement_return : TreeRuleReturnScope
    {
    };

    // $ANTLR start "statement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:51:1: statement : ( variableDeclarationList | ^( ASSIGN variableAssignment ) | whileLoop );
    public SGLTreeWalker.statement_return statement() // throws RecognitionException [1]
    {   
        SGLTreeWalker.statement_return retval = new SGLTreeWalker.statement_return();
        retval.Start = input.LT(1);

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:53:2: ( variableDeclarationList | ^( ASSIGN variableAssignment ) | whileLoop )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:53:4: variableDeclarationList
                    {
                    	PushFollow(FOLLOW_variableDeclarationList_in_statement86);
                    	variableDeclarationList();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:54:4: ^( ASSIGN variableAssignment )
                    {
                    	Match(input,ASSIGN,FOLLOW_ASSIGN_in_statement93); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_variableAssignment_in_statement95);
                    	variableAssignment();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:55:4: whileLoop
                    {
                    	PushFollow(FOLLOW_whileLoop_in_statement101);
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
        return retval;
    }
    // $ANTLR end "statement"


    // $ANTLR start "whileLoop"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:58:1: whileLoop : ^( 'while' expression ( statement )* ) ;
    public void whileLoop() // throws RecognitionException [1]
    {   
        SGLTreeWalker.expression_return expression1 = default(SGLTreeWalker.expression_return);

        SGLTreeWalker.statement_return statement2 = default(SGLTreeWalker.statement_return);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:59:2: ( ^( 'while' expression ( statement )* ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:59:4: ^( 'while' expression ( statement )* )
            {
            	Match(input,30,FOLLOW_30_in_whileLoop114); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_expression_in_whileLoop116);
            	expression1 = expression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:59:25: ( statement )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:59:25: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_whileLoop118);
            			    	statement2 = statement();
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

            			Console.WriteLine("0");
            			int next = input.Index(); // index of node following WHILE
            			Console.WriteLine("1");
            			input.Seek(((expression1 != null) ? ((CommonTree)expression1.Start) : null).Index);
            			Console.WriteLine("2");
            			Object condition = expression();
            			Console.WriteLine("3");
            			while((Boolean) condition) {
            				Console.WriteLine("4");
            				input.Seek(((statement2 != null) ? ((CommonTree)statement2.Start) : null).startIndex);
            				Console.WriteLine("5");
            				statement();
            				Console.WriteLine("6");
            				input.Seek(((expression1 != null) ? ((CommonTree)expression1.Start) : null).startIndex);
            				Console.WriteLine("7");
            	            		condition = expression();
            	            		Console.WriteLine("8");
            			}
            			Console.WriteLine("9");
            			input.Seek(next);
            			Console.WriteLine("10");
            		

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:90:1: variableDeclarationList : ^( VARDEF variableType variableName expression ) ;
    public void variableDeclarationList() // throws RecognitionException [1]
    {   
        string variableType3 = default(string);

        string variableName4 = default(string);

        SGLTreeWalker.expression_return expression5 = default(SGLTreeWalker.expression_return);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:91:2: ( ^( VARDEF variableType variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:91:4: ^( VARDEF variableType variableName expression )
            {
            	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclarationList142); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableType_in_variableDeclarationList144);
            	variableType3 = variableType();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_variableName_in_variableDeclarationList146);
            	variableName4 = variableName();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_expression_in_variableDeclarationList148);
            	expression5 = expression();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 	
            			action.NewLocalVariable(variableType3,variableName4,((expression5 != null) ? expression5.txt : default(string))); 
            		

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:100:1: variableAssignment : variableName ( expression )? ;
    public void variableAssignment() // throws RecognitionException [1]
    {   
        string variableName6 = default(string);

        SGLTreeWalker.expression_return expression7 = default(SGLTreeWalker.expression_return);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:101:2: ( variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:101:4: variableName ( expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableAssignment167);
            	variableName6 = variableName();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:101:17: ( expression )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == NEGATE || LA4_0 == Identifier || LA4_0 == IntegerAtom || LA4_0 == BooleanAtom || LA4_0 == 35 || (LA4_0 >= 37 && LA4_0 <= 49)) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:101:17: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_variableAssignment169);
            	        	expression7 = expression();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}


            			action.AssignVariable(variableName6,((expression7 != null) ? expression7.txt : default(string)));
            		

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:107:1: variableName returns [string txt] : Identifier ;
    public string variableName() // throws RecognitionException [1]
    {   
        string txt = default(string);

        CommonTree Identifier8 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:108:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:108:4: Identifier
            {
            	Identifier8=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableName190); 
            	txt =  ((Identifier8 != null) ? Identifier8.Text : null);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:111:1: variableType returns [string txt] : ( IntType | BooleanType | StringType | FloatType );
    public string variableType() // throws RecognitionException [1]
    {   
        string txt = default(string);

        CommonTree IntType9 = null;
        CommonTree BooleanType10 = null;
        CommonTree StringType11 = null;
        CommonTree FloatType12 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:112:2: ( IntType | BooleanType | StringType | FloatType )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:112:4: IntType
                    {
                    	IntType9=(CommonTree)Match(input,IntType,FOLLOW_IntType_in_variableType208); 
                    	txt =  ((IntType9 != null) ? IntType9.Text : null);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:113:4: BooleanType
                    {
                    	BooleanType10=(CommonTree)Match(input,BooleanType,FOLLOW_BooleanType_in_variableType215); 
                    	txt =  ((BooleanType10 != null) ? BooleanType10.Text : null);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:114:4: StringType
                    {
                    	StringType11=(CommonTree)Match(input,StringType,FOLLOW_StringType_in_variableType222); 
                    	txt =  ((StringType11 != null) ? StringType11.Text : null);

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:115:4: FloatType
                    {
                    	FloatType12=(CommonTree)Match(input,FloatType,FOLLOW_FloatType_in_variableType229); 
                    	txt =  ((FloatType12 != null) ? FloatType12.Text : null);

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

    public class expression_return : TreeRuleReturnScope
    {
        public string txt;
    };

    // $ANTLR start "expression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:125:1: expression returns [string txt] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | Identifier | IntegerAtom | BooleanAtom );
    public SGLTreeWalker.expression_return expression() // throws RecognitionException [1]
    {   
        SGLTreeWalker.expression_return retval = new SGLTreeWalker.expression_return();
        retval.Start = input.LT(1);

        CommonTree Identifier13 = null;
        CommonTree IntegerAtom14 = null;
        CommonTree BooleanAtom15 = null;
        SGLTreeWalker.expression_return a = default(SGLTreeWalker.expression_return);

        SGLTreeWalker.expression_return b = default(SGLTreeWalker.expression_return);

        SGLTreeWalker.expression_return c = default(SGLTreeWalker.expression_return);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:126:2: ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | Identifier | IntegerAtom | BooleanAtom )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:126:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,45,FOLLOW_45_in_expression269); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression273);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression277);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.Add(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:127:4: ^( '-' a= expression b= expression )
                    {
                    	Match(input,46,FOLLOW_46_in_expression286); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression290);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression294);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.Sub(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:128:4: ^( '*' a= expression b= expression )
                    {
                    	Match(input,47,FOLLOW_47_in_expression303); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression307);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression311);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.Mult(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:129:4: ^( '/' a= expression b= expression )
                    {
                    	Match(input,48,FOLLOW_48_in_expression320); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression324);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression328);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.Div(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:130:4: ^( '%' a= expression b= expression )
                    {
                    	Match(input,49,FOLLOW_49_in_expression337); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression341);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression345);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.Remainder(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:131:4: ^( NEGATE a= expression )
                    {
                    	Match(input,NEGATE,FOLLOW_NEGATE_in_expression355); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression359);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.Mult(((a != null) ? a.txt : default(string)),"-1"); 

                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:132:4: ^( '<' a= expression b= expression )
                    {
                    	Match(input,41,FOLLOW_41_in_expression368); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression372);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression376);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.ConditionLess(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:133:4: ^( '<=' a= expression b= expression )
                    {
                    	Match(input,43,FOLLOW_43_in_expression385); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression389);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression393);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.ConditionLessOrEqual(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:134:4: ^( '>' a= expression b= expression )
                    {
                    	Match(input,42,FOLLOW_42_in_expression402); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression406);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression410);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.ConditionGreater(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 10 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:135:4: ^( '>=' a= expression b= expression )
                    {
                    	Match(input,44,FOLLOW_44_in_expression419); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression423);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression427);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.ConditionGreaterOrEqual(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 11 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:136:4: ^( '!=' a= expression b= expression )
                    {
                    	Match(input,40,FOLLOW_40_in_expression436); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression440);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression444);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.ConditionNotEqual(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 12 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:137:4: ^( '==' a= expression b= expression )
                    {
                    	Match(input,39,FOLLOW_39_in_expression453); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression457);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression461);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.ConditionEqual(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 13 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:138:4: ^( '&&' a= expression b= expression )
                    {
                    	Match(input,38,FOLLOW_38_in_expression470); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression474);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression478);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.ConnectiveAnd(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 14 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:139:4: ^( '||' a= expression b= expression )
                    {
                    	Match(input,37,FOLLOW_37_in_expression487); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression491);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression495);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.ConnectiveOr(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string))); 

                    }
                    break;
                case 15 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:140:4: ^( '?' a= expression b= expression c= expression )
                    {
                    	Match(input,35,FOLLOW_35_in_expression504); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression508);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression512);
                    	b = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression516);
                    	c = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 retval.txt =  action.ConditionBranch(((a != null) ? a.txt : default(string)),((b != null) ? b.txt : default(string)),((c != null) ? c.txt : default(string))); 

                    }
                    break;
                case 16 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:141:4: Identifier
                    {
                    	Identifier13=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_expression524); 
                    	 retval.txt =  action.GetVariable(((Identifier13 != null) ? Identifier13.Text : null)); 

                    }
                    break;
                case 17 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:142:6: IntegerAtom
                    {
                    	IntegerAtom14=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_expression533); 
                    	 retval.txt =  ((IntegerAtom14 != null) ? IntegerAtom14.Text : null); 

                    }
                    break;
                case 18 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:143:6: BooleanAtom
                    {
                    	BooleanAtom15=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression542); 
                    	 retval.txt =  ((BooleanAtom15 != null) ? BooleanAtom15.Text : null); 

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
        return retval;
    }
    // $ANTLR end "expression"


    // $ANTLR start "conditionalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:152:1: conditionalExpression : conditionalOrExpression '?' conditionalExpression ':' conditionalExpression ;
    public void conditionalExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:153:5: ( conditionalOrExpression '?' conditionalExpression ':' conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:153:10: conditionalOrExpression '?' conditionalExpression ':' conditionalExpression
            {
            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression586);
            	conditionalOrExpression();
            	state.followingStackPointer--;

            	Match(input,35,FOLLOW_35_in_conditionalExpression588); 
            	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression590);
            	conditionalExpression();
            	state.followingStackPointer--;

            	Match(input,36,FOLLOW_36_in_conditionalExpression592); 
            	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression593);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:158:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public void conditionalOrExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:159:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:159:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression633);
            	conditionalAndExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:159:34: ( '||' conditionalAndExpression )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:159:36: '||' conditionalAndExpression
            			    {
            			    	Match(input,37,FOLLOW_37_in_conditionalOrExpression637); 
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression639);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:163:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public void conditionalAndExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:164:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:164:9: equalityExpression ( '&&' equalityExpression )*
            {
            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression670);
            	equalityExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:164:28: ( '&&' equalityExpression )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:164:30: '&&' equalityExpression
            			    {
            			    	Match(input,38,FOLLOW_38_in_conditionalAndExpression674); 
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression676);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:168:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public void equalityExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:169:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:169:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression703);
            	relationalExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:169:30: ( ( '==' | '!=' ) relationalExpression )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:169:32: ( '==' | '!=' ) relationalExpression
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

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression715);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:173:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public void relationalExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:174:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:174:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression746);
            	additiveExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:174:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:174:30: ( '<' | '>' | '<=' | '>=' ) additiveExpression
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

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression760);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:178:1: additiveExpression : e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )* ;
    public void additiveExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:179:5: (e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:179:9: e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )*
            {
            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression801);
            	multiplicativeExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:180:5: ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:180:7: '+' e= multiplicativeExpression
            			    {
            			    	Match(input,45,FOLLOW_45_in_additiveExpression809); 
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression813);
            			    	multiplicativeExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:181:7: '-' e= multiplicativeExpression
            			    {
            			    	Match(input,46,FOLLOW_46_in_additiveExpression822); 
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression826);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:186:1: multiplicativeExpression : e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* ;
    public void multiplicativeExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:187:5: (e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:187:9: e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            {
            	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression867);
            	mathAtom();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:188:5: ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:188:7: '*' e= mathAtom
            			    {
            			    	Match(input,47,FOLLOW_47_in_multiplicativeExpression875); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression879);
            			    	mathAtom();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:189:7: '/' e= mathAtom
            			    {
            			    	Match(input,48,FOLLOW_48_in_multiplicativeExpression887); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression891);
            			    	mathAtom();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:190:7: '%' e= mathAtom
            			    {
            			    	Match(input,49,FOLLOW_49_in_multiplicativeExpression899); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression903);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:194:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public void unaryExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:195:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:195:7: '++' unaryExpression
                    {
                    	Match(input,50,FOLLOW_50_in_unaryExpression931); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression933);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:196:9: '--' unaryExpression
                    {
                    	Match(input,51,FOLLOW_51_in_unaryExpression943); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression945);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:197:9: unaryExpressionNotPlusMinus
                    {
                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression955);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:201:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public void unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:202:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:202:9: '!' unaryExpression
                    {
                    	Match(input,52,FOLLOW_52_in_unaryExpressionNotPlusMinus976); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus978);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:203:9: castExpression
                    {
                    	PushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus988);
                    	castExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:205:9: mathAtom ( '++' | '--' )?
                    {
                    	PushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus1003);
                    	mathAtom();
                    	state.followingStackPointer--;

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:205:18: ( '++' | '--' )?
                    	int alt14 = 2;
                    	int LA14_0 = input.LA(1);

                    	if ( ((LA14_0 >= 50 && LA14_0 <= 51)) )
                    	{
                    	    alt14 = 1;
                    	}
                    	switch (alt14) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:209:1: castExpression : '(' variableType ')' unaryExpression ;
    public void castExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:210:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:210:8: '(' variableType ')' unaryExpression
            {
            	Match(input,31,FOLLOW_31_in_castExpression1036); 
            	PushFollow(FOLLOW_variableType_in_castExpression1038);
            	variableType();
            	state.followingStackPointer--;

            	Match(input,32,FOLLOW_32_in_castExpression1040); 
            	PushFollow(FOLLOW_unaryExpression_in_castExpression1042);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:214:1: mathAtom : ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) ;
    public void mathAtom() // throws RecognitionException [1]
    {   
        CommonTree i = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:215:5: ( ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:215:9: ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom )
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:215:9: ( '-' )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == 46) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:215:10: '-'
            	        {
            	        	Match(input,46,FOLLOW_46_in_mathAtom1065); 

            	        }
            	        break;

            	}

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:216:5: ( '(' e= additiveExpression ')' | i= IntegerAtom )
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
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:216:7: '(' e= additiveExpression ')'
            	        {
            	        	Match(input,31,FOLLOW_31_in_mathAtom1076); 
            	        	PushFollow(FOLLOW_additiveExpression_in_mathAtom1080);
            	        	additiveExpression();
            	        	state.followingStackPointer--;

            	        	Match(input,32,FOLLOW_32_in_mathAtom1082); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:217:9: i= IntegerAtom
            	        {
            	        	i=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom1094); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:225:1: arguments : '(' ( expressionList )? ')' ;
    public void arguments() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:226:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:226:9: '(' ( expressionList )? ')'
            {
            	Match(input,31,FOLLOW_31_in_arguments1131); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:226:13: ( expressionList )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == NEGATE || LA18_0 == Identifier || LA18_0 == IntegerAtom || LA18_0 == BooleanAtom || LA18_0 == 35 || (LA18_0 >= 37 && LA18_0 <= 49)) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:226:13: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments1133);
            	        	expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Match(input,32,FOLLOW_32_in_arguments1136); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:229:1: expressionList : expression ( ',' expression )* ;
    public void expressionList() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:230:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:230:9: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList1155);
            	expression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:230:20: ( ',' expression )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:230:21: ',' expression
            			    {
            			    	Match(input,28,FOLLOW_28_in_expressionList1158); 
            			    	PushFollow(FOLLOW_expression_in_expressionList1160);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:235:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public void literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:236:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:
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

 

    public static readonly BitSet FOLLOW_mainStatement_in_compilationUnit56 = new BitSet(new ulong[]{0x0000000040000030UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit59 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_mainStatement71 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_statement86 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ASSIGN_in_statement93 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_statement95 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_30_in_whileLoop114 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop116 = new BitSet(new ulong[]{0x0000000040000038UL});
    public static readonly BitSet FOLLOW_statement_in_whileLoop118 = new BitSet(new ulong[]{0x0000000040000038UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclarationList142 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclarationList144 = new BitSet(new ulong[]{0x0000000000000200UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclarationList146 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclarationList148 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_variableName_in_variableAssignment167 = new BitSet(new ulong[]{0x0003FFE800028242UL});
    public static readonly BitSet FOLLOW_expression_in_variableAssignment169 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName190 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_variableType208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_variableType215 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringType_in_variableType222 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatType_in_variableType229 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_expression269 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression273 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression277 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_46_in_expression286 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression290 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression294 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_47_in_expression303 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression307 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression311 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_48_in_expression320 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression324 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression328 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_49_in_expression337 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression341 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression345 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEGATE_in_expression355 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression359 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_41_in_expression368 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression372 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression376 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_43_in_expression385 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression389 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression393 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_42_in_expression402 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression406 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression410 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_44_in_expression419 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression423 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression427 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_40_in_expression436 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression440 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression444 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_39_in_expression453 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression457 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression461 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_38_in_expression470 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression474 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression478 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_37_in_expression487 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression491 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression495 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_35_in_expression504 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression508 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression512 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expression516 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Identifier_in_expression524 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_expression533 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_expression542 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression586 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_conditionalExpression588 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression590 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_36_in_conditionalExpression592 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression593 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression633 = new BitSet(new ulong[]{0x0000002000000002UL});
    public static readonly BitSet FOLLOW_37_in_conditionalOrExpression637 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression639 = new BitSet(new ulong[]{0x0000002000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression670 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_38_in_conditionalAndExpression674 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression676 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression703 = new BitSet(new ulong[]{0x0000018000000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpression707 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression715 = new BitSet(new ulong[]{0x0000018000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression746 = new BitSet(new ulong[]{0x00001E0000000002UL});
    public static readonly BitSet FOLLOW_set_in_relationalExpression750 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression760 = new BitSet(new ulong[]{0x00001E0000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression801 = new BitSet(new ulong[]{0x0000600000000002UL});
    public static readonly BitSet FOLLOW_45_in_additiveExpression809 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression813 = new BitSet(new ulong[]{0x0000600000000002UL});
    public static readonly BitSet FOLLOW_46_in_additiveExpression822 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression826 = new BitSet(new ulong[]{0x0000600000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression867 = new BitSet(new ulong[]{0x0003800000000002UL});
    public static readonly BitSet FOLLOW_47_in_multiplicativeExpression875 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression879 = new BitSet(new ulong[]{0x0003800000000002UL});
    public static readonly BitSet FOLLOW_48_in_multiplicativeExpression887 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression891 = new BitSet(new ulong[]{0x0003800000000002UL});
    public static readonly BitSet FOLLOW_49_in_multiplicativeExpression899 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression903 = new BitSet(new ulong[]{0x0003800000000002UL});
    public static readonly BitSet FOLLOW_50_in_unaryExpression931 = new BitSet(new ulong[]{0x001C400080008000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression933 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_51_in_unaryExpression943 = new BitSet(new ulong[]{0x001C400080008000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression945 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression955 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_unaryExpressionNotPlusMinus976 = new BitSet(new ulong[]{0x001C400080008000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus978 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus988 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus1003 = new BitSet(new ulong[]{0x000C000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus1005 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_castExpression1036 = new BitSet(new ulong[]{0x0000000000003C00UL});
    public static readonly BitSet FOLLOW_variableType_in_castExpression1038 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_castExpression1040 = new BitSet(new ulong[]{0x001C400080008000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1042 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_mathAtom1065 = new BitSet(new ulong[]{0x0000000080008000UL});
    public static readonly BitSet FOLLOW_31_in_mathAtom1076 = new BitSet(new ulong[]{0x0000400080008000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_mathAtom1080 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_mathAtom1082 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom1094 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_arguments1131 = new BitSet(new ulong[]{0x0003FFE900028240UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1133 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_arguments1136 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1155 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_expressionList1158 = new BitSet(new ulong[]{0x0003FFE800028240UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1160 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}