// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g 2011-07-07 23:24:10

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


	using SGLParserTester;
	using System.Collections.Generic;


using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  SGL 
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
		"Identifier", 
		"IntType", 
		"BooleanType", 
		"StringType", 
		"FloatType", 
		"IntegerAtom", 
		"FloatAtom", 
		"StringAtom", 
		"BooleanAtom", 
		"EscapeSequence", 
		"ClassType", 
		"Letter", 
		"SGLIDDigit", 
		"UnicodeEscape", 
		"OctalEscape", 
		"HEX_DIGIT", 
		"WS", 
		"COMMENT", 
		"','", 
		"'='", 
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
		"'('", 
		"')'", 
		"'null'"
    };

    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int SGLIDDigit = 17;
    public const int IntType = 6;
    public const int EOF = -1;
    public const int Identifier = 5;
    public const int StringType = 8;
    public const int VARDEF = 4;
    public const int COMMENT = 22;
    public const int BooleanType = 7;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int IntegerAtom = 10;
    public const int FloatType = 9;
    public const int StringAtom = 12;
    public const int HEX_DIGIT = 20;
    public const int BooleanAtom = 13;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 21;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 18;
    public const int ClassType = 15;
    public const int FloatAtom = 11;
    public const int OctalEscape = 19;
    public const int Letter = 16;
    public const int EscapeSequence = 14;

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:37:1: compilationUnit : ( statement )+ ;
    public void compilationUnit() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:38:2: ( ( statement )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:38:4: ( statement )+
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:38:4: ( statement )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == VARDEF) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:38:5: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_compilationUnit58);
            			    	statement();
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


    // $ANTLR start "statement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:42:1: statement : variableDefinitionList ;
    public void statement() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:43:2: ( variableDefinitionList )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:43:6: variableDefinitionList
            {
            	PushFollow(FOLLOW_variableDefinitionList_in_statement74);
            	variableDefinitionList();
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
    // $ANTLR end "statement"


    // $ANTLR start "variableDefinitionList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:50:1: variableDefinitionList : ^( VARDEF variableType variableName expression ) ;
    public void variableDefinitionList() // throws RecognitionException [1]
    {   
        string variableType1 = default(string);

        string variableName2 = default(string);

        string expression3 = default(string);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:51:2: ( ^( VARDEF variableType variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:51:4: ^( VARDEF variableType variableName expression )
            {
            	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDefinitionList91); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableType_in_variableDefinitionList93);
            	variableType1 = variableType();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_variableName_in_variableDefinitionList95);
            	variableName2 = variableName();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_expression_in_variableDefinitionList97);
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
    // $ANTLR end "variableDefinitionList"


    // $ANTLR start "variableDefinition"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:57:1: variableDefinition : variableName ( expression )? ;
    public void variableDefinition() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:58:2: ( variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:58:4: variableName ( expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableDefinition113);
            	variableName();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:58:17: ( expression )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == IntegerAtom || LA2_0 == BooleanAtom || LA2_0 == 35) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:58:17: expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_variableDefinition115);
            	        	expression();
            	        	state.followingStackPointer--;


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
    // $ANTLR end "variableDefinition"


    // $ANTLR start "localVariableDeclarationStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:61:1: localVariableDeclarationStatement : ( 'boolean' variableName ( '=' expression )? | 'int' variableName ( '=' expression )? );
    public void localVariableDeclarationStatement() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:62:2: ( 'boolean' variableName ( '=' expression )? | 'int' variableName ( '=' expression )? )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( (LA5_0 == BooleanType) )
            {
                alt5 = 1;
            }
            else if ( (LA5_0 == IntType) )
            {
                alt5 = 2;
            }
            else 
            {
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:62:5: 'boolean' variableName ( '=' expression )?
                    {
                    	Match(input,BooleanType,FOLLOW_BooleanType_in_localVariableDeclarationStatement128); 
                    	PushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement130);
                    	variableName();
                    	state.followingStackPointer--;

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:62:28: ( '=' expression )?
                    	int alt3 = 2;
                    	int LA3_0 = input.LA(1);

                    	if ( (LA3_0 == 24) )
                    	{
                    	    alt3 = 1;
                    	}
                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:62:29: '=' expression
                    	        {
                    	        	Match(input,24,FOLLOW_24_in_localVariableDeclarationStatement133); 
                    	        	PushFollow(FOLLOW_expression_in_localVariableDeclarationStatement135);
                    	        	expression();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:63:4: 'int' variableName ( '=' expression )?
                    {
                    	Match(input,IntType,FOLLOW_IntType_in_localVariableDeclarationStatement142); 
                    	PushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement144);
                    	variableName();
                    	state.followingStackPointer--;

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:63:23: ( '=' expression )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == 24) )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:63:24: '=' expression
                    	        {
                    	        	Match(input,24,FOLLOW_24_in_localVariableDeclarationStatement147); 
                    	        	PushFollow(FOLLOW_expression_in_localVariableDeclarationStatement149);
                    	        	expression();
                    	        	state.followingStackPointer--;


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
    // $ANTLR end "localVariableDeclarationStatement"


    // $ANTLR start "variableAssignmentStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:67:1: variableAssignmentStatement : variableDeclaration ;
    public void variableAssignmentStatement() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:68:2: ( variableDeclaration )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:68:4: variableDeclaration
            {
            	PushFollow(FOLLOW_variableDeclaration_in_variableAssignmentStatement164);
            	variableDeclaration();
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
    // $ANTLR end "variableAssignmentStatement"


    // $ANTLR start "variableDeclaration"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:76:1: variableDeclaration : variableName ( '=' expression )? ;
    public void variableDeclaration() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:77:2: ( variableName ( '=' expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:77:4: variableName ( '=' expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableDeclaration183);
            	variableName();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:77:17: ( '=' expression )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == 24) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:77:18: '=' expression
            	        {
            	        	Match(input,24,FOLLOW_24_in_variableDeclaration186); 
            	        	PushFollow(FOLLOW_expression_in_variableDeclaration188);
            	        	expression();
            	        	state.followingStackPointer--;


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
    // $ANTLR end "variableDeclaration"


    // $ANTLR start "variableName"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:81:1: variableName returns [string txt] : Identifier ;
    public string variableName() // throws RecognitionException [1]
    {   
        string txt = default(string);

        CommonTree Identifier4 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:82:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:82:4: Identifier
            {
            	Identifier4=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableName208); 
            	txt =  ((Identifier4 != null) ? Identifier4.Text : null);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:85:1: variableType returns [string txt] : ( IntType | BooleanType | StringType | FloatType );
    public string variableType() // throws RecognitionException [1]
    {   
        string txt = default(string);

        CommonTree IntType5 = null;
        CommonTree BooleanType6 = null;
        CommonTree StringType7 = null;
        CommonTree FloatType8 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:86:2: ( IntType | BooleanType | StringType | FloatType )
            int alt7 = 4;
            switch ( input.LA(1) ) 
            {
            case IntType:
            	{
                alt7 = 1;
                }
                break;
            case BooleanType:
            	{
                alt7 = 2;
                }
                break;
            case StringType:
            	{
                alt7 = 3;
                }
                break;
            case FloatType:
            	{
                alt7 = 4;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:86:4: IntType
                    {
                    	IntType5=(CommonTree)Match(input,IntType,FOLLOW_IntType_in_variableType226); 
                    	txt =  ((IntType5 != null) ? IntType5.Text : null);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:87:4: BooleanType
                    {
                    	BooleanType6=(CommonTree)Match(input,BooleanType,FOLLOW_BooleanType_in_variableType233); 
                    	txt =  ((BooleanType6 != null) ? BooleanType6.Text : null);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:88:4: StringType
                    {
                    	StringType7=(CommonTree)Match(input,StringType,FOLLOW_StringType_in_variableType240); 
                    	txt =  ((StringType7 != null) ? StringType7.Text : null);

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:89:4: FloatType
                    {
                    	FloatType8=(CommonTree)Match(input,FloatType,FOLLOW_FloatType_in_variableType247); 
                    	txt =  ((FloatType8 != null) ? FloatType8.Text : null);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:99:1: expression returns [string txt] : ( ^( '+' a= expression b= expression ) | IntegerAtom | BooleanAtom );
    public string expression() // throws RecognitionException [1]
    {   
        string txt = default(string);

        CommonTree IntegerAtom9 = null;
        CommonTree BooleanAtom10 = null;
        string a = default(string);

        string b = default(string);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:100:2: ( ^( '+' a= expression b= expression ) | IntegerAtom | BooleanAtom )
            int alt8 = 3;
            switch ( input.LA(1) ) 
            {
            case 35:
            	{
                alt8 = 1;
                }
                break;
            case IntegerAtom:
            	{
                alt8 = 2;
                }
                break;
            case BooleanAtom:
            	{
                alt8 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d8s0 =
            	        new NoViableAltException("", 8, 0, input);

            	    throw nvae_d8s0;
            }

            switch (alt8) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:100:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,35,FOLLOW_35_in_expression287); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression291);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression295);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.Add(a,b); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:101:9: IntegerAtom
                    {
                    	IntegerAtom9=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_expression308); 
                    	 txt =  ((IntegerAtom9 != null) ? IntegerAtom9.Text : null); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:102:9: BooleanAtom
                    {
                    	BooleanAtom10=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression320); 
                    	 txt =  ((BooleanAtom10 != null) ? BooleanAtom10.Text : null); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:111:1: conditionalExpression : conditionalOrExpression '?' conditionalExpression ':' conditionalExpression ;
    public void conditionalExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:112:5: ( conditionalOrExpression '?' conditionalExpression ':' conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:112:10: conditionalOrExpression '?' conditionalExpression ':' conditionalExpression
            {
            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression364);
            	conditionalOrExpression();
            	state.followingStackPointer--;

            	Match(input,25,FOLLOW_25_in_conditionalExpression366); 
            	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression368);
            	conditionalExpression();
            	state.followingStackPointer--;

            	Match(input,26,FOLLOW_26_in_conditionalExpression370); 
            	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression371);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:117:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public void conditionalOrExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:118:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:118:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression411);
            	conditionalAndExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:118:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 27) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:118:36: '||' conditionalAndExpression
            			    {
            			    	Match(input,27,FOLLOW_27_in_conditionalOrExpression415); 
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression417);
            			    	conditionalAndExpression();
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
    // $ANTLR end "conditionalOrExpression"


    // $ANTLR start "conditionalAndExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:122:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public void conditionalAndExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:123:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:123:9: equalityExpression ( '&&' equalityExpression )*
            {
            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression448);
            	equalityExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:123:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == 28) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:123:30: '&&' equalityExpression
            			    {
            			    	Match(input,28,FOLLOW_28_in_conditionalAndExpression452); 
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression454);
            			    	equalityExpression();
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
    // $ANTLR end "conditionalAndExpression"


    // $ANTLR start "equalityExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:127:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public void equalityExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:128:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:128:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression481);
            	relationalExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:128:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= 29 && LA11_0 <= 30)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:128:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	if ( (input.LA(1) >= 29 && input.LA(1) <= 30) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression493);
            			    	relationalExpression();
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
    // $ANTLR end "equalityExpression"


    // $ANTLR start "relationalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:132:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public void relationalExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:133:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:133:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression524);
            	additiveExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:133:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= 31 && LA12_0 <= 34)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:133:30: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	if ( (input.LA(1) >= 31 && input.LA(1) <= 34) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression538);
            			    	additiveExpression();
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
    // $ANTLR end "relationalExpression"


    // $ANTLR start "additiveExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:137:1: additiveExpression : e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )* ;
    public void additiveExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:138:5: (e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:138:9: e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )*
            {
            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression579);
            	multiplicativeExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:139:5: ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )*
            	do 
            	{
            	    int alt13 = 3;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == 35) )
            	    {
            	        alt13 = 1;
            	    }
            	    else if ( (LA13_0 == 36) )
            	    {
            	        alt13 = 2;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:139:7: '+' e= multiplicativeExpression
            			    {
            			    	Match(input,35,FOLLOW_35_in_additiveExpression587); 
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression591);
            			    	multiplicativeExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:140:7: '-' e= multiplicativeExpression
            			    {
            			    	Match(input,36,FOLLOW_36_in_additiveExpression600); 
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression604);
            			    	multiplicativeExpression();
            			    	state.followingStackPointer--;


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
        return ;
    }
    // $ANTLR end "additiveExpression"


    // $ANTLR start "multiplicativeExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:145:1: multiplicativeExpression : e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* ;
    public void multiplicativeExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:146:5: (e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:146:9: e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            {
            	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression645);
            	mathAtom();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:147:5: ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            	do 
            	{
            	    int alt14 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 37:
            	    	{
            	        alt14 = 1;
            	        }
            	        break;
            	    case 38:
            	    	{
            	        alt14 = 2;
            	        }
            	        break;
            	    case 39:
            	    	{
            	        alt14 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:147:7: '*' e= mathAtom
            			    {
            			    	Match(input,37,FOLLOW_37_in_multiplicativeExpression653); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression657);
            			    	mathAtom();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:148:7: '/' e= mathAtom
            			    {
            			    	Match(input,38,FOLLOW_38_in_multiplicativeExpression665); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression669);
            			    	mathAtom();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:149:7: '%' e= mathAtom
            			    {
            			    	Match(input,39,FOLLOW_39_in_multiplicativeExpression677); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression681);
            			    	mathAtom();
            			    	state.followingStackPointer--;


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
        return ;
    }
    // $ANTLR end "multiplicativeExpression"


    // $ANTLR start "unaryExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:153:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public void unaryExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:154:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt15 = 3;
            switch ( input.LA(1) ) 
            {
            case 40:
            	{
                alt15 = 1;
                }
                break;
            case 41:
            	{
                alt15 = 2;
                }
                break;
            case IntegerAtom:
            case 36:
            case 42:
            case 43:
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:154:7: '++' unaryExpression
                    {
                    	Match(input,40,FOLLOW_40_in_unaryExpression709); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression711);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:155:9: '--' unaryExpression
                    {
                    	Match(input,41,FOLLOW_41_in_unaryExpression721); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression723);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:156:9: unaryExpressionNotPlusMinus
                    {
                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression733);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:160:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public void unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:161:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt17 = 3;
            switch ( input.LA(1) ) 
            {
            case 42:
            	{
                alt17 = 1;
                }
                break;
            case 43:
            	{
                int LA17_2 = input.LA(2);

                if ( (LA17_2 == IntegerAtom || LA17_2 == 36 || LA17_2 == 43) )
                {
                    alt17 = 3;
                }
                else if ( ((LA17_2 >= IntType && LA17_2 <= FloatType)) )
                {
                    alt17 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d17s2 =
                        new NoViableAltException("", 17, 2, input);

                    throw nvae_d17s2;
                }
                }
                break;
            case IntegerAtom:
            case 36:
            	{
                alt17 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d17s0 =
            	        new NoViableAltException("", 17, 0, input);

            	    throw nvae_d17s0;
            }

            switch (alt17) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:161:9: '!' unaryExpression
                    {
                    	Match(input,42,FOLLOW_42_in_unaryExpressionNotPlusMinus754); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus756);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:162:9: castExpression
                    {
                    	PushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus766);
                    	castExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:164:9: mathAtom ( '++' | '--' )?
                    {
                    	PushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus781);
                    	mathAtom();
                    	state.followingStackPointer--;

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:164:18: ( '++' | '--' )?
                    	int alt16 = 2;
                    	int LA16_0 = input.LA(1);

                    	if ( ((LA16_0 >= 40 && LA16_0 <= 41)) )
                    	{
                    	    alt16 = 1;
                    	}
                    	switch (alt16) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:
                    	        {
                    	        	if ( (input.LA(1) >= 40 && input.LA(1) <= 41) ) 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:168:1: castExpression : '(' variableType ')' unaryExpression ;
    public void castExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:169:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:169:8: '(' variableType ')' unaryExpression
            {
            	Match(input,43,FOLLOW_43_in_castExpression814); 
            	PushFollow(FOLLOW_variableType_in_castExpression816);
            	variableType();
            	state.followingStackPointer--;

            	Match(input,44,FOLLOW_44_in_castExpression818); 
            	PushFollow(FOLLOW_unaryExpression_in_castExpression820);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:173:1: mathAtom : ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) ;
    public void mathAtom() // throws RecognitionException [1]
    {   
        CommonTree i = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:174:5: ( ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:174:9: ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom )
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:174:9: ( '-' )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == 36) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:174:10: '-'
            	        {
            	        	Match(input,36,FOLLOW_36_in_mathAtom843); 

            	        }
            	        break;

            	}

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:175:5: ( '(' e= additiveExpression ')' | i= IntegerAtom )
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == 43) )
            	{
            	    alt19 = 1;
            	}
            	else if ( (LA19_0 == IntegerAtom) )
            	{
            	    alt19 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("", 19, 0, input);

            	    throw nvae_d19s0;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:175:7: '(' e= additiveExpression ')'
            	        {
            	        	Match(input,43,FOLLOW_43_in_mathAtom854); 
            	        	PushFollow(FOLLOW_additiveExpression_in_mathAtom858);
            	        	additiveExpression();
            	        	state.followingStackPointer--;

            	        	Match(input,44,FOLLOW_44_in_mathAtom860); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:176:9: i= IntegerAtom
            	        {
            	        	i=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom872); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:184:1: arguments : '(' ( expressionList )? ')' ;
    public void arguments() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:185:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:185:9: '(' ( expressionList )? ')'
            {
            	Match(input,43,FOLLOW_43_in_arguments909); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:185:13: ( expressionList )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == IntegerAtom || LA20_0 == BooleanAtom || LA20_0 == 35) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:185:13: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments911);
            	        	expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Match(input,44,FOLLOW_44_in_arguments914); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:188:1: expressionList : expression ( ',' expression )* ;
    public void expressionList() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:189:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:189:9: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList933);
            	expression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:189:20: ( ',' expression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == 23) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:189:21: ',' expression
            			    {
            			    	Match(input,23,FOLLOW_23_in_expressionList936); 
            			    	PushFollow(FOLLOW_expression_in_expressionList938);
            			    	expression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop21;
            	    }
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whining that label 'loop21' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:194:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public void literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:195:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:
            {
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == 45 ) 
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

 

    public static readonly BitSet FOLLOW_statement_in_compilationUnit58 = new BitSet(new ulong[]{0x0000000000000012UL});
    public static readonly BitSet FOLLOW_variableDefinitionList_in_statement74 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDefinitionList91 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDefinitionList93 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDefinitionList95 = new BitSet(new ulong[]{0x0000000800002400UL});
    public static readonly BitSet FOLLOW_expression_in_variableDefinitionList97 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDefinition113 = new BitSet(new ulong[]{0x0000000800002402UL});
    public static readonly BitSet FOLLOW_expression_in_variableDefinition115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_localVariableDeclarationStatement128 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_variableName_in_localVariableDeclarationStatement130 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_24_in_localVariableDeclarationStatement133 = new BitSet(new ulong[]{0x0000000800002400UL});
    public static readonly BitSet FOLLOW_expression_in_localVariableDeclarationStatement135 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_localVariableDeclarationStatement142 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_variableName_in_localVariableDeclarationStatement144 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_24_in_localVariableDeclarationStatement147 = new BitSet(new ulong[]{0x0000000800002400UL});
    public static readonly BitSet FOLLOW_expression_in_localVariableDeclarationStatement149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_variableAssignmentStatement164 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration183 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_24_in_variableDeclaration186 = new BitSet(new ulong[]{0x0000000800002400UL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclaration188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_variableType226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_variableType233 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringType_in_variableType240 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatType_in_variableType247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_expression287 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression291 = new BitSet(new ulong[]{0x0000000800002400UL});
    public static readonly BitSet FOLLOW_expression_in_expression295 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_expression308 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_expression320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression364 = new BitSet(new ulong[]{0x0000000002000000UL});
    public static readonly BitSet FOLLOW_25_in_conditionalExpression366 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression368 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_conditionalExpression370 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression411 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_27_in_conditionalOrExpression415 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression417 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression448 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_conditionalAndExpression452 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression454 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression481 = new BitSet(new ulong[]{0x0000000060000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpression485 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression493 = new BitSet(new ulong[]{0x0000000060000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression524 = new BitSet(new ulong[]{0x0000000780000002UL});
    public static readonly BitSet FOLLOW_set_in_relationalExpression528 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression538 = new BitSet(new ulong[]{0x0000000780000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression579 = new BitSet(new ulong[]{0x0000001800000002UL});
    public static readonly BitSet FOLLOW_35_in_additiveExpression587 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression591 = new BitSet(new ulong[]{0x0000001800000002UL});
    public static readonly BitSet FOLLOW_36_in_additiveExpression600 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression604 = new BitSet(new ulong[]{0x0000001800000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression645 = new BitSet(new ulong[]{0x000000E000000002UL});
    public static readonly BitSet FOLLOW_37_in_multiplicativeExpression653 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression657 = new BitSet(new ulong[]{0x000000E000000002UL});
    public static readonly BitSet FOLLOW_38_in_multiplicativeExpression665 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression669 = new BitSet(new ulong[]{0x000000E000000002UL});
    public static readonly BitSet FOLLOW_39_in_multiplicativeExpression677 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression681 = new BitSet(new ulong[]{0x000000E000000002UL});
    public static readonly BitSet FOLLOW_40_in_unaryExpression709 = new BitSet(new ulong[]{0x00000F1000000400UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression711 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_unaryExpression721 = new BitSet(new ulong[]{0x00000F1000000400UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression723 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression733 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_unaryExpressionNotPlusMinus754 = new BitSet(new ulong[]{0x00000F1000000400UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus781 = new BitSet(new ulong[]{0x0000030000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus783 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_castExpression814 = new BitSet(new ulong[]{0x00000000000003C0UL});
    public static readonly BitSet FOLLOW_variableType_in_castExpression816 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_castExpression818 = new BitSet(new ulong[]{0x00000F1000000400UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression820 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_mathAtom843 = new BitSet(new ulong[]{0x0000080000000400UL});
    public static readonly BitSet FOLLOW_43_in_mathAtom854 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_mathAtom858 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_mathAtom860 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom872 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_arguments909 = new BitSet(new ulong[]{0x0000100800002400UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments911 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_arguments914 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList933 = new BitSet(new ulong[]{0x0000000000800002UL});
    public static readonly BitSet FOLLOW_23_in_expressionList936 = new BitSet(new ulong[]{0x0000000800002400UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList938 = new BitSet(new ulong[]{0x0000000000800002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}