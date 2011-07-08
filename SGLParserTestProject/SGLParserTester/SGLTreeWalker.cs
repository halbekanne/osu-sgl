// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g 2011-07-08 18:34:55

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
		"NEGATE", 
		"LIBMETHOD", 
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
    public const int SGLIDDigit = 19;
    public const int IntType = 8;
    public const int EOF = -1;
    public const int Identifier = 7;
    public const int StringType = 10;
    public const int VARDEF = 4;
    public const int COMMENT = 24;
    public const int BooleanType = 9;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int LIBMETHOD = 6;
    public const int IntegerAtom = 12;
    public const int FloatType = 11;
    public const int StringAtom = 14;
    public const int HEX_DIGIT = 22;
    public const int NEGATE = 5;
    public const int BooleanAtom = 15;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 23;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 20;
    public const int ClassType = 17;
    public const int FloatAtom = 13;
    public const int Letter = 18;
    public const int EscapeSequence = 16;
    public const int OctalEscape = 21;

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:43:1: compilationUnit : ( statement )+ ;
    public void compilationUnit() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:44:2: ( ( statement )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:44:4: ( statement )+
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:44:4: ( statement )+
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:44:5: statement
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:48:1: statement : variableDefinitionList ;
    public void statement() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:49:2: ( variableDefinitionList )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:49:6: variableDefinitionList
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:56:1: variableDefinitionList : ^( VARDEF variableType variableName expression ) ;
    public void variableDefinitionList() // throws RecognitionException [1]
    {   
        string variableType1 = default(string);

        string variableName2 = default(string);

        string expression3 = default(string);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:57:2: ( ^( VARDEF variableType variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:57:4: ^( VARDEF variableType variableName expression )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:63:1: variableDefinition : variableName ( expression )? ;
    public void variableDefinition() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:64:2: ( variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:64:4: variableName ( expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableDefinition113);
            	variableName();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:64:17: ( expression )?
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == NEGATE || LA2_0 == IntegerAtom || LA2_0 == BooleanAtom || (LA2_0 >= 37 && LA2_0 <= 41)) )
            	{
            	    alt2 = 1;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:64:17: expression
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:67:1: localVariableDeclarationStatement : ( 'boolean' variableName ( '=' expression )? | 'int' variableName ( '=' expression )? );
    public void localVariableDeclarationStatement() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:68:2: ( 'boolean' variableName ( '=' expression )? | 'int' variableName ( '=' expression )? )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:68:5: 'boolean' variableName ( '=' expression )?
                    {
                    	Match(input,BooleanType,FOLLOW_BooleanType_in_localVariableDeclarationStatement128); 
                    	PushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement130);
                    	variableName();
                    	state.followingStackPointer--;

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:68:28: ( '=' expression )?
                    	int alt3 = 2;
                    	int LA3_0 = input.LA(1);

                    	if ( (LA3_0 == 26) )
                    	{
                    	    alt3 = 1;
                    	}
                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:68:29: '=' expression
                    	        {
                    	        	Match(input,26,FOLLOW_26_in_localVariableDeclarationStatement133); 
                    	        	PushFollow(FOLLOW_expression_in_localVariableDeclarationStatement135);
                    	        	expression();
                    	        	state.followingStackPointer--;


                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:69:4: 'int' variableName ( '=' expression )?
                    {
                    	Match(input,IntType,FOLLOW_IntType_in_localVariableDeclarationStatement142); 
                    	PushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement144);
                    	variableName();
                    	state.followingStackPointer--;

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:69:23: ( '=' expression )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == 26) )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:69:24: '=' expression
                    	        {
                    	        	Match(input,26,FOLLOW_26_in_localVariableDeclarationStatement147); 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:73:1: variableAssignmentStatement : variableDeclaration ;
    public void variableAssignmentStatement() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:74:2: ( variableDeclaration )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:74:4: variableDeclaration
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:82:1: variableDeclaration : variableName ( '=' expression )? ;
    public void variableDeclaration() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:83:2: ( variableName ( '=' expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:83:4: variableName ( '=' expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableDeclaration183);
            	variableName();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:83:17: ( '=' expression )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == 26) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:83:18: '=' expression
            	        {
            	        	Match(input,26,FOLLOW_26_in_variableDeclaration186); 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:87:1: variableName returns [string txt] : Identifier ;
    public string variableName() // throws RecognitionException [1]
    {   
        string txt = default(string);

        CommonTree Identifier4 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:88:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:88:4: Identifier
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:91:1: variableType returns [string txt] : ( IntType | BooleanType | StringType | FloatType );
    public string variableType() // throws RecognitionException [1]
    {   
        string txt = default(string);

        CommonTree IntType5 = null;
        CommonTree BooleanType6 = null;
        CommonTree StringType7 = null;
        CommonTree FloatType8 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:92:2: ( IntType | BooleanType | StringType | FloatType )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:92:4: IntType
                    {
                    	IntType5=(CommonTree)Match(input,IntType,FOLLOW_IntType_in_variableType226); 
                    	txt =  ((IntType5 != null) ? IntType5.Text : null);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:93:4: BooleanType
                    {
                    	BooleanType6=(CommonTree)Match(input,BooleanType,FOLLOW_BooleanType_in_variableType233); 
                    	txt =  ((BooleanType6 != null) ? BooleanType6.Text : null);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:94:4: StringType
                    {
                    	StringType7=(CommonTree)Match(input,StringType,FOLLOW_StringType_in_variableType240); 
                    	txt =  ((StringType7 != null) ? StringType7.Text : null);

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:95:4: FloatType
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:105:1: expression returns [string txt] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | IntegerAtom | BooleanAtom );
    public string expression() // throws RecognitionException [1]
    {   
        string txt = default(string);

        CommonTree IntegerAtom9 = null;
        CommonTree BooleanAtom10 = null;
        string a = default(string);

        string b = default(string);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:106:2: ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | IntegerAtom | BooleanAtom )
            int alt8 = 8;
            switch ( input.LA(1) ) 
            {
            case 37:
            	{
                alt8 = 1;
                }
                break;
            case 38:
            	{
                alt8 = 2;
                }
                break;
            case 39:
            	{
                alt8 = 3;
                }
                break;
            case 40:
            	{
                alt8 = 4;
                }
                break;
            case 41:
            	{
                alt8 = 5;
                }
                break;
            case NEGATE:
            	{
                alt8 = 6;
                }
                break;
            case IntegerAtom:
            	{
                alt8 = 7;
                }
                break;
            case BooleanAtom:
            	{
                alt8 = 8;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:106:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,37,FOLLOW_37_in_expression287); 

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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:107:4: ^( '-' a= expression b= expression )
                    {
                    	Match(input,38,FOLLOW_38_in_expression304); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression308);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression312);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.Sub(a,b); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:108:4: ^( '*' a= expression b= expression )
                    {
                    	Match(input,39,FOLLOW_39_in_expression321); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression325);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression329);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.Mult(a,b); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:109:4: ^( '/' a= expression b= expression )
                    {
                    	Match(input,40,FOLLOW_40_in_expression338); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression342);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression346);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.Div(a,b); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:110:4: ^( '%' a= expression b= expression )
                    {
                    	Match(input,41,FOLLOW_41_in_expression355); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression359);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression363);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:111:4: ^( NEGATE a= expression )
                    {
                    	Match(input,NEGATE,FOLLOW_NEGATE_in_expression371); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression375);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 txt =  action.Mult(a,"-1"); 

                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:112:9: IntegerAtom
                    {
                    	IntegerAtom9=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_expression388); 
                    	 txt =  ((IntegerAtom9 != null) ? IntegerAtom9.Text : null); 

                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:113:9: BooleanAtom
                    {
                    	BooleanAtom10=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression400); 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:122:1: conditionalExpression : conditionalOrExpression '?' conditionalExpression ':' conditionalExpression ;
    public void conditionalExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:123:5: ( conditionalOrExpression '?' conditionalExpression ':' conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:123:10: conditionalOrExpression '?' conditionalExpression ':' conditionalExpression
            {
            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression444);
            	conditionalOrExpression();
            	state.followingStackPointer--;

            	Match(input,27,FOLLOW_27_in_conditionalExpression446); 
            	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression448);
            	conditionalExpression();
            	state.followingStackPointer--;

            	Match(input,28,FOLLOW_28_in_conditionalExpression450); 
            	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression451);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:128:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public void conditionalOrExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:129:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:129:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression491);
            	conditionalAndExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:129:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 29) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:129:36: '||' conditionalAndExpression
            			    {
            			    	Match(input,29,FOLLOW_29_in_conditionalOrExpression495); 
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression497);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:133:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public void conditionalAndExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:134:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:134:9: equalityExpression ( '&&' equalityExpression )*
            {
            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression528);
            	equalityExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:134:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == 30) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:134:30: '&&' equalityExpression
            			    {
            			    	Match(input,30,FOLLOW_30_in_conditionalAndExpression532); 
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression534);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:138:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public void equalityExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:139:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:139:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression561);
            	relationalExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:139:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= 31 && LA11_0 <= 32)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:139:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	if ( (input.LA(1) >= 31 && input.LA(1) <= 32) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression573);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:143:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public void relationalExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:144:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:144:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression604);
            	additiveExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:144:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= 33 && LA12_0 <= 36)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:144:30: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	if ( (input.LA(1) >= 33 && input.LA(1) <= 36) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression618);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:148:1: additiveExpression : e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )* ;
    public void additiveExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:149:5: (e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:149:9: e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )*
            {
            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression659);
            	multiplicativeExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:150:5: ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )*
            	do 
            	{
            	    int alt13 = 3;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == 37) )
            	    {
            	        alt13 = 1;
            	    }
            	    else if ( (LA13_0 == 38) )
            	    {
            	        alt13 = 2;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:150:7: '+' e= multiplicativeExpression
            			    {
            			    	Match(input,37,FOLLOW_37_in_additiveExpression667); 
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression671);
            			    	multiplicativeExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:151:7: '-' e= multiplicativeExpression
            			    {
            			    	Match(input,38,FOLLOW_38_in_additiveExpression680); 
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression684);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:156:1: multiplicativeExpression : e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* ;
    public void multiplicativeExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:157:5: (e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:157:9: e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            {
            	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression725);
            	mathAtom();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:158:5: ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            	do 
            	{
            	    int alt14 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 39:
            	    	{
            	        alt14 = 1;
            	        }
            	        break;
            	    case 40:
            	    	{
            	        alt14 = 2;
            	        }
            	        break;
            	    case 41:
            	    	{
            	        alt14 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:158:7: '*' e= mathAtom
            			    {
            			    	Match(input,39,FOLLOW_39_in_multiplicativeExpression733); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression737);
            			    	mathAtom();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:159:7: '/' e= mathAtom
            			    {
            			    	Match(input,40,FOLLOW_40_in_multiplicativeExpression745); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression749);
            			    	mathAtom();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:160:7: '%' e= mathAtom
            			    {
            			    	Match(input,41,FOLLOW_41_in_multiplicativeExpression757); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression761);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:164:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public void unaryExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:165:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt15 = 3;
            switch ( input.LA(1) ) 
            {
            case 42:
            	{
                alt15 = 1;
                }
                break;
            case 43:
            	{
                alt15 = 2;
                }
                break;
            case IntegerAtom:
            case 38:
            case 44:
            case 45:
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:165:7: '++' unaryExpression
                    {
                    	Match(input,42,FOLLOW_42_in_unaryExpression789); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression791);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:166:9: '--' unaryExpression
                    {
                    	Match(input,43,FOLLOW_43_in_unaryExpression801); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression803);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:167:9: unaryExpressionNotPlusMinus
                    {
                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression813);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:171:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public void unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:172:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt17 = 3;
            switch ( input.LA(1) ) 
            {
            case 44:
            	{
                alt17 = 1;
                }
                break;
            case 45:
            	{
                int LA17_2 = input.LA(2);

                if ( ((LA17_2 >= IntType && LA17_2 <= FloatType)) )
                {
                    alt17 = 2;
                }
                else if ( (LA17_2 == IntegerAtom || LA17_2 == 38 || LA17_2 == 45) )
                {
                    alt17 = 3;
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
            case 38:
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:172:9: '!' unaryExpression
                    {
                    	Match(input,44,FOLLOW_44_in_unaryExpressionNotPlusMinus834); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus836);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:173:9: castExpression
                    {
                    	PushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus846);
                    	castExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:175:9: mathAtom ( '++' | '--' )?
                    {
                    	PushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus861);
                    	mathAtom();
                    	state.followingStackPointer--;

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:175:18: ( '++' | '--' )?
                    	int alt16 = 2;
                    	int LA16_0 = input.LA(1);

                    	if ( ((LA16_0 >= 42 && LA16_0 <= 43)) )
                    	{
                    	    alt16 = 1;
                    	}
                    	switch (alt16) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:
                    	        {
                    	        	if ( (input.LA(1) >= 42 && input.LA(1) <= 43) ) 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:179:1: castExpression : '(' variableType ')' unaryExpression ;
    public void castExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:180:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:180:8: '(' variableType ')' unaryExpression
            {
            	Match(input,45,FOLLOW_45_in_castExpression894); 
            	PushFollow(FOLLOW_variableType_in_castExpression896);
            	variableType();
            	state.followingStackPointer--;

            	Match(input,46,FOLLOW_46_in_castExpression898); 
            	PushFollow(FOLLOW_unaryExpression_in_castExpression900);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:184:1: mathAtom : ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) ;
    public void mathAtom() // throws RecognitionException [1]
    {   
        CommonTree i = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:185:5: ( ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:185:9: ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom )
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:185:9: ( '-' )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == 38) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:185:10: '-'
            	        {
            	        	Match(input,38,FOLLOW_38_in_mathAtom923); 

            	        }
            	        break;

            	}

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:186:5: ( '(' e= additiveExpression ')' | i= IntegerAtom )
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == 45) )
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
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:186:7: '(' e= additiveExpression ')'
            	        {
            	        	Match(input,45,FOLLOW_45_in_mathAtom934); 
            	        	PushFollow(FOLLOW_additiveExpression_in_mathAtom938);
            	        	additiveExpression();
            	        	state.followingStackPointer--;

            	        	Match(input,46,FOLLOW_46_in_mathAtom940); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:187:9: i= IntegerAtom
            	        {
            	        	i=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom952); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:195:1: arguments : '(' ( expressionList )? ')' ;
    public void arguments() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:196:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:196:9: '(' ( expressionList )? ')'
            {
            	Match(input,45,FOLLOW_45_in_arguments989); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:196:13: ( expressionList )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == NEGATE || LA20_0 == IntegerAtom || LA20_0 == BooleanAtom || (LA20_0 >= 37 && LA20_0 <= 41)) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:196:13: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments991);
            	        	expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Match(input,46,FOLLOW_46_in_arguments994); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:199:1: expressionList : expression ( ',' expression )* ;
    public void expressionList() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:200:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:200:9: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList1013);
            	expression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:200:20: ( ',' expression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == 25) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:200:21: ',' expression
            			    {
            			    	Match(input,25,FOLLOW_25_in_expressionList1016); 
            			    	PushFollow(FOLLOW_expression_in_expressionList1018);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:205:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public void literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:206:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGLTreeWalker.g:
            {
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == 47 ) 
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
    public static readonly BitSet FOLLOW_variableType_in_variableDefinitionList93 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDefinitionList95 = new BitSet(new ulong[]{0x000003E000009020UL});
    public static readonly BitSet FOLLOW_expression_in_variableDefinitionList97 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDefinition113 = new BitSet(new ulong[]{0x000003E000009022UL});
    public static readonly BitSet FOLLOW_expression_in_variableDefinition115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_localVariableDeclarationStatement128 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variableName_in_localVariableDeclarationStatement130 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_localVariableDeclarationStatement133 = new BitSet(new ulong[]{0x000003E000009020UL});
    public static readonly BitSet FOLLOW_expression_in_localVariableDeclarationStatement135 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_localVariableDeclarationStatement142 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variableName_in_localVariableDeclarationStatement144 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_localVariableDeclarationStatement147 = new BitSet(new ulong[]{0x000003E000009020UL});
    public static readonly BitSet FOLLOW_expression_in_localVariableDeclarationStatement149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_variableAssignmentStatement164 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration183 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_variableDeclaration186 = new BitSet(new ulong[]{0x000003E000009020UL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclaration188 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_variableType226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_variableType233 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringType_in_variableType240 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatType_in_variableType247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_expression287 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression291 = new BitSet(new ulong[]{0x000003E000009020UL});
    public static readonly BitSet FOLLOW_expression_in_expression295 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_38_in_expression304 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression308 = new BitSet(new ulong[]{0x000003E000009020UL});
    public static readonly BitSet FOLLOW_expression_in_expression312 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_39_in_expression321 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression325 = new BitSet(new ulong[]{0x000003E000009020UL});
    public static readonly BitSet FOLLOW_expression_in_expression329 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_40_in_expression338 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression342 = new BitSet(new ulong[]{0x000003E000009020UL});
    public static readonly BitSet FOLLOW_expression_in_expression346 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_41_in_expression355 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression359 = new BitSet(new ulong[]{0x000003E000009020UL});
    public static readonly BitSet FOLLOW_expression_in_expression363 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEGATE_in_expression371 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression375 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_expression388 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_expression400 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression444 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_conditionalExpression446 = new BitSet(new ulong[]{0x0000204000001000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression448 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_conditionalExpression450 = new BitSet(new ulong[]{0x0000204000001000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression451 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression491 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_29_in_conditionalOrExpression495 = new BitSet(new ulong[]{0x0000204000001000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression497 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression528 = new BitSet(new ulong[]{0x0000000040000002UL});
    public static readonly BitSet FOLLOW_30_in_conditionalAndExpression532 = new BitSet(new ulong[]{0x0000204000001000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression534 = new BitSet(new ulong[]{0x0000000040000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression561 = new BitSet(new ulong[]{0x0000000180000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpression565 = new BitSet(new ulong[]{0x0000204000001000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression573 = new BitSet(new ulong[]{0x0000000180000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression604 = new BitSet(new ulong[]{0x0000001E00000002UL});
    public static readonly BitSet FOLLOW_set_in_relationalExpression608 = new BitSet(new ulong[]{0x0000204000001000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression618 = new BitSet(new ulong[]{0x0000001E00000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression659 = new BitSet(new ulong[]{0x0000006000000002UL});
    public static readonly BitSet FOLLOW_37_in_additiveExpression667 = new BitSet(new ulong[]{0x0000204000001000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression671 = new BitSet(new ulong[]{0x0000006000000002UL});
    public static readonly BitSet FOLLOW_38_in_additiveExpression680 = new BitSet(new ulong[]{0x0000204000001000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression684 = new BitSet(new ulong[]{0x0000006000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression725 = new BitSet(new ulong[]{0x0000038000000002UL});
    public static readonly BitSet FOLLOW_39_in_multiplicativeExpression733 = new BitSet(new ulong[]{0x0000204000001000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression737 = new BitSet(new ulong[]{0x0000038000000002UL});
    public static readonly BitSet FOLLOW_40_in_multiplicativeExpression745 = new BitSet(new ulong[]{0x0000204000001000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression749 = new BitSet(new ulong[]{0x0000038000000002UL});
    public static readonly BitSet FOLLOW_41_in_multiplicativeExpression757 = new BitSet(new ulong[]{0x0000204000001000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression761 = new BitSet(new ulong[]{0x0000038000000002UL});
    public static readonly BitSet FOLLOW_42_in_unaryExpression789 = new BitSet(new ulong[]{0x00003C4000001000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression791 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_unaryExpression801 = new BitSet(new ulong[]{0x00003C4000001000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression803 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression813 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_unaryExpressionNotPlusMinus834 = new BitSet(new ulong[]{0x00003C4000001000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus836 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus846 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus861 = new BitSet(new ulong[]{0x00000C0000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus863 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_castExpression894 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_variableType_in_castExpression896 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_castExpression898 = new BitSet(new ulong[]{0x00003C4000001000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression900 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_mathAtom923 = new BitSet(new ulong[]{0x0000200000001000UL});
    public static readonly BitSet FOLLOW_45_in_mathAtom934 = new BitSet(new ulong[]{0x0000204000001000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_mathAtom938 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_mathAtom940 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom952 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_arguments989 = new BitSet(new ulong[]{0x000043E000009020UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments991 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_arguments994 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1013 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_25_in_expressionList1016 = new BitSet(new ulong[]{0x000003E000009020UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1018 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}