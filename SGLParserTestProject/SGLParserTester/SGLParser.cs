// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g 2011-05-15 17:22:46

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;
namespace  SGL 
{
public partial class SGLParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"Identifier", 
		"IntegerAtom", 
		"FloatAtom", 
		"StringAtom", 
		"BooleanAtom", 
		"EscapeSequence", 
		"Letter", 
		"SGLIDDigit", 
		"UnicodeEscape", 
		"OctalEscape", 
		"HEX_DIGIT", 
		"WS", 
		"COMMENT", 
		"';'", 
		"'boolean'", 
		"'='", 
		"'int'", 
		"'string'", 
		"'float'", 
		"'Object'", 
		"'Sprite'", 
		"'Animation'", 
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
		"','", 
		"'null'"
    };

    public const int T__29 = 29;
    public const int T__28 = 28;
    public const int T__27 = 27;
    public const int T__26 = 26;
    public const int T__25 = 25;
    public const int T__24 = 24;
    public const int T__23 = 23;
    public const int T__22 = 22;
    public const int T__21 = 21;
    public const int T__20 = 20;
    public const int SGLIDDigit = 11;
    public const int EOF = -1;
    public const int Identifier = 4;
    public const int T__19 = 19;
    public const int T__18 = 18;
    public const int T__17 = 17;
    public const int COMMENT = 16;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int IntegerAtom = 5;
    public const int StringAtom = 7;
    public const int HEX_DIGIT = 14;
    public const int BooleanAtom = 8;
    public const int T__30 = 30;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 15;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 12;
    public const int FloatAtom = 6;
    public const int OctalEscape = 13;
    public const int EscapeSequence = 9;
    public const int Letter = 10;

    // delegates
    // delegators



        public SGLParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SGLParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[72+1];
             
             
        }
        

    override public string[] TokenNames {
		get { return SGLParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g"; }
    }


    	String output;
    	public String GetOutput() {
    		return output;
    	}



    // $ANTLR start "compilationUnit"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:38:1: compilationUnit : ( statement )+ ;
    public void compilationUnit() // throws RecognitionException [1]
    {   
        int compilationUnit_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:39:2: ( ( statement )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:39:4: ( statement )+
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:39:4: ( statement )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == Identifier || LA1_0 == 18 || LA1_0 == 20) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_compilationUnit72);
            			    	statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            			    if ( state.backtracking > 0 ) {state.failed = true; return ;}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 1, compilationUnit_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "compilationUnit"


    // $ANTLR start "statement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:43:1: statement : ( localVariableDeclarationStatement | variableAssignmentStatement ) ';' ;
    public void statement() // throws RecognitionException [1]
    {   
        int statement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:44:2: ( ( localVariableDeclarationStatement | variableAssignmentStatement ) ';' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:44:4: ( localVariableDeclarationStatement | variableAssignmentStatement ) ';'
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:44:4: ( localVariableDeclarationStatement | variableAssignmentStatement )
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( (LA2_0 == 18 || LA2_0 == 20) )
            	{
            	    alt2 = 1;
            	}
            	else if ( (LA2_0 == Identifier) )
            	{
            	    alt2 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            	}
            	switch (alt2) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:45:3: localVariableDeclarationStatement
            	        {
            	        	PushFollow(FOLLOW_localVariableDeclarationStatement_in_statement89);
            	        	localVariableDeclarationStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:46:5: variableAssignmentStatement
            	        {
            	        	PushFollow(FOLLOW_variableAssignmentStatement_in_statement96);
            	        	variableAssignmentStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}

            	Match(input,17,FOLLOW_17_in_statement101); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 2, statement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "statement"


    // $ANTLR start "localVariableDeclarationStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:53:1: localVariableDeclarationStatement : ( 'boolean' variableName ( '=' booleanExpression )? | 'int' variableName ( '=' mathExpression )? );
    public void localVariableDeclarationStatement() // throws RecognitionException [1]
    {   
        int localVariableDeclarationStatement_StartIndex = input.Index();
        SGLParser.variableName_return variableName1 = default(SGLParser.variableName_return);

        int mathExpression2 = default(int);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:54:2: ( 'boolean' variableName ( '=' booleanExpression )? | 'int' variableName ( '=' mathExpression )? )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( (LA5_0 == 18) )
            {
                alt5 = 1;
            }
            else if ( (LA5_0 == 20) )
            {
                alt5 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:54:5: 'boolean' variableName ( '=' booleanExpression )?
                    {
                    	Match(input,18,FOLLOW_18_in_localVariableDeclarationStatement117); if (state.failed) return ;
                    	PushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement119);
                    	variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:54:28: ( '=' booleanExpression )?
                    	int alt3 = 2;
                    	int LA3_0 = input.LA(1);

                    	if ( (LA3_0 == 19) )
                    	{
                    	    alt3 = 1;
                    	}
                    	switch (alt3) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:54:29: '=' booleanExpression
                    	        {
                    	        	Match(input,19,FOLLOW_19_in_localVariableDeclarationStatement122); if (state.failed) return ;
                    	        	PushFollow(FOLLOW_booleanExpression_in_localVariableDeclarationStatement124);
                    	        	booleanExpression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return ;

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:55:4: 'int' variableName ( '=' mathExpression )?
                    {
                    	Match(input,20,FOLLOW_20_in_localVariableDeclarationStatement131); if (state.failed) return ;
                    	PushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement133);
                    	variableName1 = variableName();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:55:23: ( '=' mathExpression )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == 19) )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:55:24: '=' mathExpression
                    	        {
                    	        	Match(input,19,FOLLOW_19_in_localVariableDeclarationStatement136); if (state.failed) return ;
                    	        	PushFollow(FOLLOW_mathExpression_in_localVariableDeclarationStatement138);
                    	        	mathExpression2 = mathExpression();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return ;
                    	        	if ( (state.backtracking==0) )
                    	        	{
                    	        	  output += "Lege Variable " + ((variableName1 != null) ? input.ToString((IToken)(variableName1.Start),(IToken)(variableName1.Stop)) : null) + " an mit dem Wert " + mathExpression2 + "\n";
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 3, localVariableDeclarationStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "localVariableDeclarationStatement"


    // $ANTLR start "variableAssignmentStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:59:1: variableAssignmentStatement : variableDeclaration ;
    public void variableAssignmentStatement() // throws RecognitionException [1]
    {   
        int variableAssignmentStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:60:2: ( variableDeclaration )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:60:4: variableDeclaration
            {
            	PushFollow(FOLLOW_variableDeclaration_in_variableAssignmentStatement156);
            	variableDeclaration();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, variableAssignmentStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "variableAssignmentStatement"


    // $ANTLR start "variableDeclaration"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:68:1: variableDeclaration : variableName ( '=' variableInit )? ;
    public void variableDeclaration() // throws RecognitionException [1]
    {   
        int variableDeclaration_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:69:2: ( variableName ( '=' variableInit )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:69:4: variableName ( '=' variableInit )?
            {
            	PushFollow(FOLLOW_variableName_in_variableDeclaration175);
            	variableName();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:69:17: ( '=' variableInit )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == 19) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:69:18: '=' variableInit
            	        {
            	        	Match(input,19,FOLLOW_19_in_variableDeclaration178); if (state.failed) return ;
            	        	PushFollow(FOLLOW_variableInit_in_variableDeclaration180);
            	        	variableInit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 5, variableDeclaration_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "variableDeclaration"


    // $ANTLR start "variableInit"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:72:1: variableInit : expression ;
    public void variableInit() // throws RecognitionException [1]
    {   
        int variableInit_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:73:2: ( expression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:73:4: expression
            {
            	PushFollow(FOLLOW_expression_in_variableInit194);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 6, variableInit_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "variableInit"

    public class variableName_return : ParserRuleReturnScope
    {
    };

    // $ANTLR start "variableName"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:76:1: variableName : Identifier ;
    public SGLParser.variableName_return variableName() // throws RecognitionException [1]
    {   
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.Start = input.LT(1);
        int variableName_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:77:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:77:4: Identifier
            {
            	Match(input,Identifier,FOLLOW_Identifier_in_variableName207); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 7, variableName_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "variableName"


    // $ANTLR start "variableType"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:80:1: variableType : ( primitiveType | classType );
    public void variableType() // throws RecognitionException [1]
    {   
        int variableType_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:81:2: ( primitiveType | classType )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == 18 || (LA7_0 >= 20 && LA7_0 <= 22)) )
            {
                alt7 = 1;
            }
            else if ( ((LA7_0 >= 23 && LA7_0 <= 25)) )
            {
                alt7 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:81:4: primitiveType
                    {
                    	PushFollow(FOLLOW_primitiveType_in_variableType219);
                    	primitiveType();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:82:4: classType
                    {
                    	PushFollow(FOLLOW_classType_in_variableType224);
                    	classType();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 8, variableType_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "variableType"


    // $ANTLR start "primitiveType"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:86:1: primitiveType : ( 'boolean' | 'string' | 'int' | 'float' );
    public void primitiveType() // throws RecognitionException [1]
    {   
        int primitiveType_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:87:5: ( 'boolean' | 'string' | 'int' | 'float' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:
            {
            	if ( input.LA(1) == 18 || (input.LA(1) >= 20 && input.LA(1) <= 22) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 9, primitiveType_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "primitiveType"


    // $ANTLR start "classType"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:94:1: classType : ( 'Object' | 'Sprite' | 'Animation' );
    public void classType() // throws RecognitionException [1]
    {   
        int classType_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:95:2: ( 'Object' | 'Sprite' | 'Animation' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:
            {
            	if ( (input.LA(1) >= 23 && input.LA(1) <= 25) ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 10, classType_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "classType"


    // $ANTLR start "expression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:105:1: expression : ( mathConditionalExpression | mathExpression | booleanExpression );
    public void expression() // throws RecognitionException [1]
    {   
        int expression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:106:5: ( mathConditionalExpression | mathExpression | booleanExpression )
            int alt8 = 3;
            int LA8_0 = input.LA(1);

            if ( (LA8_0 == 44) )
            {
                int LA8_1 = input.LA(2);

                if ( (synpred13_SGL()) )
                {
                    alt8 = 1;
                }
                else if ( (synpred14_SGL()) )
                {
                    alt8 = 2;
                }
                else if ( (true) )
                {
                    alt8 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    NoViableAltException nvae_d8s1 =
                        new NoViableAltException("", 8, 1, input);

                    throw nvae_d8s1;
                }
            }
            else if ( (LA8_0 == IntegerAtom) )
            {
                int LA8_2 = input.LA(2);

                if ( (synpred13_SGL()) )
                {
                    alt8 = 1;
                }
                else if ( (synpred14_SGL()) )
                {
                    alt8 = 2;
                }
                else if ( (true) )
                {
                    alt8 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    NoViableAltException nvae_d8s2 =
                        new NoViableAltException("", 8, 2, input);

                    throw nvae_d8s2;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d8s0 =
                    new NoViableAltException("", 8, 0, input);

                throw nvae_d8s0;
            }
            switch (alt8) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:106:9: mathConditionalExpression
                    {
                    	PushFollow(FOLLOW_mathConditionalExpression_in_expression338);
                    	mathConditionalExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:107:7: mathExpression
                    {
                    	PushFollow(FOLLOW_mathExpression_in_expression346);
                    	mathExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:108:7: booleanExpression
                    {
                    	PushFollow(FOLLOW_booleanExpression_in_expression354);
                    	booleanExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 11, expression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "expression"


    // $ANTLR start "mathConditionalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:112:1: mathConditionalExpression : booleanExpression ( '?' ( mathConditionalExpression | mathExpression ) ':' ( mathConditionalExpression | mathExpression ) )? ;
    public void mathConditionalExpression() // throws RecognitionException [1]
    {   
        int mathConditionalExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:5: ( booleanExpression ( '?' ( mathConditionalExpression | mathExpression ) ':' ( mathConditionalExpression | mathExpression ) )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:9: booleanExpression ( '?' ( mathConditionalExpression | mathExpression ) ':' ( mathConditionalExpression | mathExpression ) )?
            {
            	PushFollow(FOLLOW_booleanExpression_in_mathConditionalExpression382);
            	booleanExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:27: ( '?' ( mathConditionalExpression | mathExpression ) ':' ( mathConditionalExpression | mathExpression ) )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 26) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:29: '?' ( mathConditionalExpression | mathExpression ) ':' ( mathConditionalExpression | mathExpression )
            	        {
            	        	Match(input,26,FOLLOW_26_in_mathConditionalExpression386); if (state.failed) return ;
            	        	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:33: ( mathConditionalExpression | mathExpression )
            	        	int alt9 = 2;
            	        	int LA9_0 = input.LA(1);

            	        	if ( (LA9_0 == 44) )
            	        	{
            	        	    int LA9_1 = input.LA(2);

            	        	    if ( (synpred15_SGL()) )
            	        	    {
            	        	        alt9 = 1;
            	        	    }
            	        	    else if ( (true) )
            	        	    {
            	        	        alt9 = 2;
            	        	    }
            	        	    else 
            	        	    {
            	        	        if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	        	        NoViableAltException nvae_d9s1 =
            	        	            new NoViableAltException("", 9, 1, input);

            	        	        throw nvae_d9s1;
            	        	    }
            	        	}
            	        	else if ( (LA9_0 == IntegerAtom) )
            	        	{
            	        	    int LA9_2 = input.LA(2);

            	        	    if ( (synpred15_SGL()) )
            	        	    {
            	        	        alt9 = 1;
            	        	    }
            	        	    else if ( (true) )
            	        	    {
            	        	        alt9 = 2;
            	        	    }
            	        	    else 
            	        	    {
            	        	        if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	        	        NoViableAltException nvae_d9s2 =
            	        	            new NoViableAltException("", 9, 2, input);

            	        	        throw nvae_d9s2;
            	        	    }
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	        	    NoViableAltException nvae_d9s0 =
            	        	        new NoViableAltException("", 9, 0, input);

            	        	    throw nvae_d9s0;
            	        	}
            	        	switch (alt9) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:34: mathConditionalExpression
            	        	        {
            	        	        	PushFollow(FOLLOW_mathConditionalExpression_in_mathConditionalExpression389);
            	        	        	mathConditionalExpression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return ;

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:62: mathExpression
            	        	        {
            	        	        	PushFollow(FOLLOW_mathExpression_in_mathConditionalExpression393);
            	        	        	mathExpression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return ;

            	        	        }
            	        	        break;

            	        	}

            	        	Match(input,27,FOLLOW_27_in_mathConditionalExpression396); if (state.failed) return ;
            	        	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:82: ( mathConditionalExpression | mathExpression )
            	        	int alt10 = 2;
            	        	int LA10_0 = input.LA(1);

            	        	if ( (LA10_0 == 44) )
            	        	{
            	        	    int LA10_1 = input.LA(2);

            	        	    if ( (synpred16_SGL()) )
            	        	    {
            	        	        alt10 = 1;
            	        	    }
            	        	    else if ( (true) )
            	        	    {
            	        	        alt10 = 2;
            	        	    }
            	        	    else 
            	        	    {
            	        	        if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	        	        NoViableAltException nvae_d10s1 =
            	        	            new NoViableAltException("", 10, 1, input);

            	        	        throw nvae_d10s1;
            	        	    }
            	        	}
            	        	else if ( (LA10_0 == IntegerAtom) )
            	        	{
            	        	    int LA10_2 = input.LA(2);

            	        	    if ( (synpred16_SGL()) )
            	        	    {
            	        	        alt10 = 1;
            	        	    }
            	        	    else if ( (true) )
            	        	    {
            	        	        alt10 = 2;
            	        	    }
            	        	    else 
            	        	    {
            	        	        if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	        	        NoViableAltException nvae_d10s2 =
            	        	            new NoViableAltException("", 10, 2, input);

            	        	        throw nvae_d10s2;
            	        	    }
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	        	    NoViableAltException nvae_d10s0 =
            	        	        new NoViableAltException("", 10, 0, input);

            	        	    throw nvae_d10s0;
            	        	}
            	        	switch (alt10) 
            	        	{
            	        	    case 1 :
            	        	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:83: mathConditionalExpression
            	        	        {
            	        	        	PushFollow(FOLLOW_mathConditionalExpression_in_mathConditionalExpression399);
            	        	        	mathConditionalExpression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return ;

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:111: mathExpression
            	        	        {
            	        	        	PushFollow(FOLLOW_mathExpression_in_mathConditionalExpression403);
            	        	        	mathExpression();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return ;

            	        	        }
            	        	        break;

            	        	}


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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 12, mathConditionalExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "mathConditionalExpression"


    // $ANTLR start "booleanConditionalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:116:1: booleanConditionalExpression : booleanExpression ( '?' booleanConditionalExpression ':' booleanConditionalExpression )? ;
    public void booleanConditionalExpression() // throws RecognitionException [1]
    {   
        int booleanConditionalExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:117:5: ( booleanExpression ( '?' booleanConditionalExpression ':' booleanConditionalExpression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:117:9: booleanExpression ( '?' booleanConditionalExpression ':' booleanConditionalExpression )?
            {
            	PushFollow(FOLLOW_booleanExpression_in_booleanConditionalExpression430);
            	booleanExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:117:27: ( '?' booleanConditionalExpression ':' booleanConditionalExpression )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == 26) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:117:29: '?' booleanConditionalExpression ':' booleanConditionalExpression
            	        {
            	        	Match(input,26,FOLLOW_26_in_booleanConditionalExpression434); if (state.failed) return ;
            	        	PushFollow(FOLLOW_booleanConditionalExpression_in_booleanConditionalExpression436);
            	        	booleanConditionalExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;
            	        	Match(input,27,FOLLOW_27_in_booleanConditionalExpression438); if (state.failed) return ;
            	        	PushFollow(FOLLOW_booleanConditionalExpression_in_booleanConditionalExpression440);
            	        	booleanConditionalExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 13, booleanConditionalExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "booleanConditionalExpression"


    // $ANTLR start "mathExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:120:1: mathExpression returns [int value] : e= additiveExpression ;
    public int mathExpression() // throws RecognitionException [1]
    {   
        int value = default(int);
        int mathExpression_StartIndex = input.Index();
        int e = default(int);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return value; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:121:2: (e= additiveExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:121:4: e= additiveExpression
            {
            	PushFollow(FOLLOW_additiveExpression_in_mathExpression474);
            	e = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	  value =  e;
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, mathExpression_StartIndex); 
            }
        }
        return value;
    }
    // $ANTLR end "mathExpression"


    // $ANTLR start "booleanExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:124:1: booleanExpression : conditionalOrExpression ;
    public void booleanExpression() // throws RecognitionException [1]
    {   
        int booleanExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:125:2: ( conditionalOrExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:125:4: conditionalOrExpression
            {
            	PushFollow(FOLLOW_conditionalOrExpression_in_booleanExpression489);
            	conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, booleanExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "booleanExpression"


    // $ANTLR start "conditionalOrExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:130:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public void conditionalOrExpression() // throws RecognitionException [1]
    {   
        int conditionalOrExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:131:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:131:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression522);
            	conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:131:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == 28) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:131:36: '||' conditionalAndExpression
            			    {
            			    	Match(input,28,FOLLOW_28_in_conditionalOrExpression526); if (state.failed) return ;
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression528);
            			    	conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 16, conditionalOrExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "conditionalOrExpression"


    // $ANTLR start "conditionalAndExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:135:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public void conditionalAndExpression() // throws RecognitionException [1]
    {   
        int conditionalAndExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:136:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:136:9: equalityExpression ( '&&' equalityExpression )*
            {
            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression559);
            	equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:136:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 29) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:136:30: '&&' equalityExpression
            			    {
            			    	Match(input,29,FOLLOW_29_in_conditionalAndExpression563); if (state.failed) return ;
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression565);
            			    	equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, conditionalAndExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "conditionalAndExpression"


    // $ANTLR start "equalityExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:140:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public void equalityExpression() // throws RecognitionException [1]
    {   
        int equalityExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:141:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:141:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression592);
            	relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:141:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( ((LA15_0 >= 30 && LA15_0 <= 31)) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:141:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	if ( (input.LA(1) >= 30 && input.LA(1) <= 31) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression604);
            			    	relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, equalityExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "equalityExpression"


    // $ANTLR start "relationalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:145:1: relationalExpression : mathExpression ( ( '<' | '>' | '<=' | '>=' ) mathExpression )* ;
    public void relationalExpression() // throws RecognitionException [1]
    {   
        int relationalExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:146:5: ( mathExpression ( ( '<' | '>' | '<=' | '>=' ) mathExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:146:9: mathExpression ( ( '<' | '>' | '<=' | '>=' ) mathExpression )*
            {
            	PushFollow(FOLLOW_mathExpression_in_relationalExpression635);
            	mathExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:146:24: ( ( '<' | '>' | '<=' | '>=' ) mathExpression )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( ((LA16_0 >= 32 && LA16_0 <= 35)) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:146:26: ( '<' | '>' | '<=' | '>=' ) mathExpression
            			    {
            			    	if ( (input.LA(1) >= 32 && input.LA(1) <= 35) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_mathExpression_in_relationalExpression649);
            			    	mathExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, relationalExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "relationalExpression"


    // $ANTLR start "additiveExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:150:1: additiveExpression returns [int value] : e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )* ;
    public int additiveExpression() // throws RecognitionException [1]
    {   
        int value = default(int);
        int additiveExpression_StartIndex = input.Index();
        int e = default(int);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return value; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:151:5: (e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:151:9: e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )*
            {
            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression694);
            	e = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	  value =  e;
            	}
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:152:5: ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )*
            	do 
            	{
            	    int alt17 = 3;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == 36) )
            	    {
            	        alt17 = 1;
            	    }
            	    else if ( (LA17_0 == 37) )
            	    {
            	        alt17 = 2;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:152:7: '+' e= multiplicativeExpression
            			    {
            			    	Match(input,36,FOLLOW_36_in_additiveExpression705); if (state.failed) return value;
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression709);
            			    	e = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	  value += e;
            			    	}

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:153:7: '-' e= multiplicativeExpression
            			    {
            			    	Match(input,37,FOLLOW_37_in_additiveExpression719); if (state.failed) return value;
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression723);
            			    	e = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	  value -= e;
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, additiveExpression_StartIndex); 
            }
        }
        return value;
    }
    // $ANTLR end "additiveExpression"


    // $ANTLR start "multiplicativeExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:158:1: multiplicativeExpression returns [int value] : e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* ;
    public int multiplicativeExpression() // throws RecognitionException [1]
    {   
        int value = default(int);
        int multiplicativeExpression_StartIndex = input.Index();
        int e = default(int);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return value; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:159:5: (e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:159:9: e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            {
            	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression770);
            	e = mathAtom();
            	state.followingStackPointer--;
            	if (state.failed) return value;
            	if ( (state.backtracking==0) )
            	{
            	  value =  e;
            	}
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:160:5: ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            	do 
            	{
            	    int alt18 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 38:
            	    	{
            	        alt18 = 1;
            	        }
            	        break;
            	    case 39:
            	    	{
            	        alt18 = 2;
            	        }
            	        break;
            	    case 40:
            	    	{
            	        alt18 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:160:7: '*' e= mathAtom
            			    {
            			    	Match(input,38,FOLLOW_38_in_multiplicativeExpression781); if (state.failed) return value;
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression785);
            			    	e = mathAtom();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	  value *= e;
            			    	}

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:161:7: '/' e= mathAtom
            			    {
            			    	Match(input,39,FOLLOW_39_in_multiplicativeExpression795); if (state.failed) return value;
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression799);
            			    	e = mathAtom();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	  value /= e;
            			    	}

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:162:7: '%' e= mathAtom
            			    {
            			    	Match(input,40,FOLLOW_40_in_multiplicativeExpression809); if (state.failed) return value;
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression813);
            			    	e = mathAtom();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return value;
            			    	if ( (state.backtracking==0) )
            			    	{
            			    	  value =  e;
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 21, multiplicativeExpression_StartIndex); 
            }
        }
        return value;
    }
    // $ANTLR end "multiplicativeExpression"


    // $ANTLR start "unaryExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:166:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public void unaryExpression() // throws RecognitionException [1]
    {   
        int unaryExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:167:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt19 = 3;
            switch ( input.LA(1) ) 
            {
            case 41:
            	{
                alt19 = 1;
                }
                break;
            case 42:
            	{
                alt19 = 2;
                }
                break;
            case IntegerAtom:
            case 43:
            case 44:
            	{
                alt19 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("", 19, 0, input);

            	    throw nvae_d19s0;
            }

            switch (alt19) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:167:7: '++' unaryExpression
                    {
                    	Match(input,41,FOLLOW_41_in_unaryExpression844); if (state.failed) return ;
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression846);
                    	unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:168:9: '--' unaryExpression
                    {
                    	Match(input,42,FOLLOW_42_in_unaryExpression856); if (state.failed) return ;
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression858);
                    	unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:169:9: unaryExpressionNotPlusMinus
                    {
                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression868);
                    	unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, unaryExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "unaryExpression"


    // $ANTLR start "unaryExpressionNotPlusMinus"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:173:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public void unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        int unaryExpressionNotPlusMinus_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:174:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt21 = 3;
            switch ( input.LA(1) ) 
            {
            case 43:
            	{
                alt21 = 1;
                }
                break;
            case 44:
            	{
                int LA21_2 = input.LA(2);

                if ( (LA21_2 == IntegerAtom || LA21_2 == 44) )
                {
                    alt21 = 3;
                }
                else if ( (LA21_2 == 18 || (LA21_2 >= 20 && LA21_2 <= 22)) )
                {
                    alt21 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    NoViableAltException nvae_d21s2 =
                        new NoViableAltException("", 21, 2, input);

                    throw nvae_d21s2;
                }
                }
                break;
            case IntegerAtom:
            	{
                alt21 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d21s0 =
            	        new NoViableAltException("", 21, 0, input);

            	    throw nvae_d21s0;
            }

            switch (alt21) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:174:9: '!' unaryExpression
                    {
                    	Match(input,43,FOLLOW_43_in_unaryExpressionNotPlusMinus889); if (state.failed) return ;
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus891);
                    	unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:175:9: castExpression
                    {
                    	PushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus901);
                    	castExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:177:9: mathAtom ( '++' | '--' )?
                    {
                    	PushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus916);
                    	mathAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:177:18: ( '++' | '--' )?
                    	int alt20 = 2;
                    	int LA20_0 = input.LA(1);

                    	if ( ((LA20_0 >= 41 && LA20_0 <= 42)) )
                    	{
                    	    alt20 = 1;
                    	}
                    	switch (alt20) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:
                    	        {
                    	        	if ( (input.LA(1) >= 41 && input.LA(1) <= 42) ) 
                    	        	{
                    	        	    input.Consume();
                    	        	    state.errorRecovery = false;state.failed = false;
                    	        	}
                    	        	else 
                    	        	{
                    	        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 23, unaryExpressionNotPlusMinus_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "unaryExpressionNotPlusMinus"


    // $ANTLR start "castExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:181:1: castExpression : '(' primitiveType ')' unaryExpression ;
    public void castExpression() // throws RecognitionException [1]
    {   
        int castExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:182:5: ( '(' primitiveType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:182:8: '(' primitiveType ')' unaryExpression
            {
            	Match(input,44,FOLLOW_44_in_castExpression949); if (state.failed) return ;
            	PushFollow(FOLLOW_primitiveType_in_castExpression951);
            	primitiveType();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	Match(input,45,FOLLOW_45_in_castExpression953); if (state.failed) return ;
            	PushFollow(FOLLOW_unaryExpression_in_castExpression955);
            	unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 24, castExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "castExpression"


    // $ANTLR start "mathAtom"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:186:1: mathAtom returns [int value] : ( '(' e= mathExpression ')' | i= IntegerAtom );
    public int mathAtom() // throws RecognitionException [1]
    {   
        int value = default(int);
        int mathAtom_StartIndex = input.Index();
        IToken i = null;
        int e = default(int);


        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return value; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:187:5: ( '(' e= mathExpression ')' | i= IntegerAtom )
            int alt22 = 2;
            int LA22_0 = input.LA(1);

            if ( (LA22_0 == 44) )
            {
                alt22 = 1;
            }
            else if ( (LA22_0 == IntegerAtom) )
            {
                alt22 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return value;}
                NoViableAltException nvae_d22s0 =
                    new NoViableAltException("", 22, 0, input);

                throw nvae_d22s0;
            }
            switch (alt22) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:187:9: '(' e= mathExpression ')'
                    {
                    	Match(input,44,FOLLOW_44_in_mathAtom981); if (state.failed) return value;
                    	PushFollow(FOLLOW_mathExpression_in_mathAtom985);
                    	e = mathExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return value;
                    	Match(input,45,FOLLOW_45_in_mathAtom987); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	  value =  e;
                    	}

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:188:9: i= IntegerAtom
                    {
                    	i=(IToken)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom1001); if (state.failed) return value;
                    	if ( (state.backtracking==0) )
                    	{
                    	  value =  Convert.ToInt32(((i != null) ? i.Text : null));
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 25, mathAtom_StartIndex); 
            }
        }
        return value;
    }
    // $ANTLR end "mathAtom"


    // $ANTLR start "arguments"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:195:1: arguments : '(' ( expressionList )? ')' ;
    public void arguments() // throws RecognitionException [1]
    {   
        int arguments_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:196:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:196:9: '(' ( expressionList )? ')'
            {
            	Match(input,44,FOLLOW_44_in_arguments1034); if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:196:13: ( expressionList )?
            	int alt23 = 2;
            	int LA23_0 = input.LA(1);

            	if ( (LA23_0 == IntegerAtom || LA23_0 == 44) )
            	{
            	    alt23 = 1;
            	}
            	switch (alt23) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments1036);
            	        	expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}

            	Match(input,45,FOLLOW_45_in_arguments1039); if (state.failed) return ;

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 26, arguments_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "arguments"


    // $ANTLR start "expressionList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:199:1: expressionList : expression ( ',' expression )* ;
    public void expressionList() // throws RecognitionException [1]
    {   
        int expressionList_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:200:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:200:9: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList1058);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:200:20: ( ',' expression )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( (LA24_0 == 46) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:200:21: ',' expression
            			    {
            			    	Match(input,46,FOLLOW_46_in_expressionList1061); if (state.failed) return ;
            			    	PushFollow(FOLLOW_expression_in_expressionList1063);
            			    	expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 27, expressionList_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "expressionList"


    // $ANTLR start "literal"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:205:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public void literal() // throws RecognitionException [1]
    {   
        int literal_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:206:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:
            {
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == 47 ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 28, literal_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "literal"

    // $ANTLR start "synpred13_SGL"
    public void synpred13_SGL_fragment() {
        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:106:9: ( mathConditionalExpression )
        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:106:9: mathConditionalExpression
        {
        	PushFollow(FOLLOW_mathConditionalExpression_in_synpred13_SGL338);
        	mathConditionalExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred13_SGL"

    // $ANTLR start "synpred14_SGL"
    public void synpred14_SGL_fragment() {
        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:107:7: ( mathExpression )
        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:107:7: mathExpression
        {
        	PushFollow(FOLLOW_mathExpression_in_synpred14_SGL346);
        	mathExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred14_SGL"

    // $ANTLR start "synpred15_SGL"
    public void synpred15_SGL_fragment() {
        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:34: ( mathConditionalExpression )
        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:34: mathConditionalExpression
        {
        	PushFollow(FOLLOW_mathConditionalExpression_in_synpred15_SGL389);
        	mathConditionalExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred15_SGL"

    // $ANTLR start "synpred16_SGL"
    public void synpred16_SGL_fragment() {
        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:83: ( mathConditionalExpression )
        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication4\\WindowsFormsApplication4\\SGL.g:113:83: mathConditionalExpression
        {
        	PushFollow(FOLLOW_mathConditionalExpression_in_synpred16_SGL399);
        	mathConditionalExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred16_SGL"

    // Delegated rules

   	public bool synpred16_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred16_SGL_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred15_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred15_SGL_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred14_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred14_SGL_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred13_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred13_SGL_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_statement_in_compilationUnit72 = new BitSet(new ulong[]{0x0000000000140012UL});
    public static readonly BitSet FOLLOW_localVariableDeclarationStatement_in_statement89 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_variableAssignmentStatement_in_statement96 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_statement101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_18_in_localVariableDeclarationStatement117 = new BitSet(new ulong[]{0x00000000001C0010UL});
    public static readonly BitSet FOLLOW_variableName_in_localVariableDeclarationStatement119 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_19_in_localVariableDeclarationStatement122 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_booleanExpression_in_localVariableDeclarationStatement124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_20_in_localVariableDeclarationStatement131 = new BitSet(new ulong[]{0x00000000001C0010UL});
    public static readonly BitSet FOLLOW_variableName_in_localVariableDeclarationStatement133 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_19_in_localVariableDeclarationStatement136 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_mathExpression_in_localVariableDeclarationStatement138 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_variableAssignmentStatement156 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration175 = new BitSet(new ulong[]{0x0000000000080002UL});
    public static readonly BitSet FOLLOW_19_in_variableDeclaration178 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_variableInit_in_variableDeclaration180 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_variableInit194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primitiveType_in_variableType219 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_classType_in_variableType224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_primitiveType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_classType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathConditionalExpression_in_expression338 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathExpression_in_expression346 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_booleanExpression_in_expression354 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_booleanExpression_in_mathConditionalExpression382 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_mathConditionalExpression386 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_mathConditionalExpression_in_mathConditionalExpression389 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_mathExpression_in_mathConditionalExpression393 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_mathConditionalExpression396 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_mathConditionalExpression_in_mathConditionalExpression399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathExpression_in_mathConditionalExpression403 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_booleanExpression_in_booleanConditionalExpression430 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_booleanConditionalExpression434 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_booleanConditionalExpression_in_booleanConditionalExpression436 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_booleanConditionalExpression438 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_booleanConditionalExpression_in_booleanConditionalExpression440 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_mathExpression474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_booleanExpression489 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression522 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_conditionalOrExpression526 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression528 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression559 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_29_in_conditionalAndExpression563 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression565 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression592 = new BitSet(new ulong[]{0x00000000C0000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpression596 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression604 = new BitSet(new ulong[]{0x00000000C0000002UL});
    public static readonly BitSet FOLLOW_mathExpression_in_relationalExpression635 = new BitSet(new ulong[]{0x0000000F00000002UL});
    public static readonly BitSet FOLLOW_set_in_relationalExpression639 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_mathExpression_in_relationalExpression649 = new BitSet(new ulong[]{0x0000000F00000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression694 = new BitSet(new ulong[]{0x0000003000000002UL});
    public static readonly BitSet FOLLOW_36_in_additiveExpression705 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression709 = new BitSet(new ulong[]{0x0000003000000002UL});
    public static readonly BitSet FOLLOW_37_in_additiveExpression719 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression723 = new BitSet(new ulong[]{0x0000003000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression770 = new BitSet(new ulong[]{0x000001C000000002UL});
    public static readonly BitSet FOLLOW_38_in_multiplicativeExpression781 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression785 = new BitSet(new ulong[]{0x000001C000000002UL});
    public static readonly BitSet FOLLOW_39_in_multiplicativeExpression795 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression799 = new BitSet(new ulong[]{0x000001C000000002UL});
    public static readonly BitSet FOLLOW_40_in_multiplicativeExpression809 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression813 = new BitSet(new ulong[]{0x000001C000000002UL});
    public static readonly BitSet FOLLOW_41_in_unaryExpression844 = new BitSet(new ulong[]{0x00001E0000000020UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression846 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_unaryExpression856 = new BitSet(new ulong[]{0x00001E0000000020UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression858 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression868 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_unaryExpressionNotPlusMinus889 = new BitSet(new ulong[]{0x00001E0000000020UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus891 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus901 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus916 = new BitSet(new ulong[]{0x0000060000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus918 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_castExpression949 = new BitSet(new ulong[]{0x0000000000740000UL});
    public static readonly BitSet FOLLOW_primitiveType_in_castExpression951 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_castExpression953 = new BitSet(new ulong[]{0x00001E0000000020UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression955 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_mathAtom981 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_mathExpression_in_mathAtom985 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_mathAtom987 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom1001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_arguments1034 = new BitSet(new ulong[]{0x0000300000000020UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1036 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_arguments1039 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1058 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_46_in_expressionList1061 = new BitSet(new ulong[]{0x0000100000000020UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1063 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathConditionalExpression_in_synpred13_SGL338 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathExpression_in_synpred14_SGL346 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathConditionalExpression_in_synpred15_SGL389 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathConditionalExpression_in_synpred16_SGL399 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}