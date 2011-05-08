// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g 2011-05-08 18:57:08

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
public partial class SGLParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"Identifier", 
		"Integer", 
		"Float", 
		"String", 
		"Boolean", 
		"EscapeSequence", 
		"Letter", 
		"SGLIDDigit", 
		"UnicodeEscape", 
		"OctalEscape", 
		"HEX_DIGIT", 
		"WS", 
		"COMMENT", 
		"';'", 
		"'='", 
		"'boolean'", 
		"'string'", 
		"'int'", 
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
		"'.'", 
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
    public const int String = 7;
    public const int COMMENT = 16;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int HEX_DIGIT = 14;
    public const int Float = 6;
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
    public const int Boolean = 8;
    public const int OctalEscape = 13;
    public const int EscapeSequence = 9;
    public const int Letter = 10;
    public const int Integer = 5;

    // delegates
    // delegators



        public SGLParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SGLParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();
            this.state.ruleMemo = new Hashtable[64+1];
             
             
        }
        

    override public string[] TokenNames {
		get { return SGLParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g"; }
    }



    // $ANTLR start "compilationUnit"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:30:1: compilationUnit : ( statement )+ ;
    public void compilationUnit() // throws RecognitionException [1]
    {   
        int compilationUnit_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:31:2: ( ( statement )+ )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:31:4: ( statement )+
            {
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:31:4: ( statement )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == Identifier || (LA1_0 >= 19 && LA1_0 <= 25)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_compilationUnit62);
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
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:35:1: statement : ( localVariableDeclarationStatement | variableAssignmentStatement ) ';' ;
    public void statement() // throws RecognitionException [1]
    {   
        int statement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:36:2: ( ( localVariableDeclarationStatement | variableAssignmentStatement ) ';' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:36:4: ( localVariableDeclarationStatement | variableAssignmentStatement ) ';'
            {
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:36:4: ( localVariableDeclarationStatement | variableAssignmentStatement )
            	int alt2 = 2;
            	int LA2_0 = input.LA(1);

            	if ( ((LA2_0 >= 19 && LA2_0 <= 25)) )
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
            	        // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:37:3: localVariableDeclarationStatement
            	        {
            	        	PushFollow(FOLLOW_localVariableDeclarationStatement_in_statement79);
            	        	localVariableDeclarationStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:38:5: variableAssignmentStatement
            	        {
            	        	PushFollow(FOLLOW_variableAssignmentStatement_in_statement86);
            	        	variableAssignmentStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}

            	Match(input,17,FOLLOW_17_in_statement91); if (state.failed) return ;

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
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:45:1: localVariableDeclarationStatement : variableType variableDeclaration ;
    public void localVariableDeclarationStatement() // throws RecognitionException [1]
    {   
        int localVariableDeclarationStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:46:2: ( variableType variableDeclaration )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:46:5: variableType variableDeclaration
            {
            	PushFollow(FOLLOW_variableType_in_localVariableDeclarationStatement107);
            	variableType();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	PushFollow(FOLLOW_variableDeclaration_in_localVariableDeclarationStatement109);
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
            	Memoize(input, 3, localVariableDeclarationStatement_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "localVariableDeclarationStatement"


    // $ANTLR start "variableAssignmentStatement"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:50:1: variableAssignmentStatement : variableDeclaration ;
    public void variableAssignmentStatement() // throws RecognitionException [1]
    {   
        int variableAssignmentStatement_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:51:2: ( variableDeclaration )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:51:4: variableDeclaration
            {
            	PushFollow(FOLLOW_variableDeclaration_in_variableAssignmentStatement122);
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
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:59:1: variableDeclaration : variableName ( '=' variableInit )? ;
    public void variableDeclaration() // throws RecognitionException [1]
    {   
        int variableDeclaration_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:60:2: ( variableName ( '=' variableInit )? )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:60:4: variableName ( '=' variableInit )?
            {
            	PushFollow(FOLLOW_variableName_in_variableDeclaration141);
            	variableName();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:60:17: ( '=' variableInit )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == 18) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:60:18: '=' variableInit
            	        {
            	        	Match(input,18,FOLLOW_18_in_variableDeclaration144); if (state.failed) return ;
            	        	PushFollow(FOLLOW_variableInit_in_variableDeclaration146);
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
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:63:1: variableInit : expression ;
    public void variableInit() // throws RecognitionException [1]
    {   
        int variableInit_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:64:2: ( expression )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:64:4: expression
            {
            	PushFollow(FOLLOW_expression_in_variableInit160);
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


    // $ANTLR start "variableName"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:67:1: variableName : Identifier ;
    public void variableName() // throws RecognitionException [1]
    {   
        int variableName_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:68:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:68:4: Identifier
            {
            	Match(input,Identifier,FOLLOW_Identifier_in_variableName173); if (state.failed) return ;

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
            	Memoize(input, 7, variableName_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "variableName"


    // $ANTLR start "variableType"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:71:1: variableType : ( primitiveType | classType );
    public void variableType() // throws RecognitionException [1]
    {   
        int variableType_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:72:2: ( primitiveType | classType )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( ((LA4_0 >= 19 && LA4_0 <= 22)) )
            {
                alt4 = 1;
            }
            else if ( ((LA4_0 >= 23 && LA4_0 <= 25)) )
            {
                alt4 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return ;}
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:72:4: primitiveType
                    {
                    	PushFollow(FOLLOW_primitiveType_in_variableType185);
                    	primitiveType();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:73:4: classType
                    {
                    	PushFollow(FOLLOW_classType_in_variableType190);
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
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:77:1: primitiveType : ( 'boolean' | 'string' | 'int' | 'float' );
    public void primitiveType() // throws RecognitionException [1]
    {   
        int primitiveType_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:78:5: ( 'boolean' | 'string' | 'int' | 'float' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:
            {
            	if ( (input.LA(1) >= 19 && input.LA(1) <= 22) ) 
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
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:85:1: classType : ( 'Object' | 'Sprite' | 'Animation' );
    public void classType() // throws RecognitionException [1]
    {   
        int classType_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:86:2: ( 'Object' | 'Sprite' | 'Animation' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:
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
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:96:1: expression : conditionalExpression ;
    public void expression() // throws RecognitionException [1]
    {   
        int expression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:97:5: ( conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:97:9: conditionalExpression
            {
            	PushFollow(FOLLOW_conditionalExpression_in_expression304);
            	conditionalExpression();
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
            	Memoize(input, 11, expression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "expression"


    // $ANTLR start "conditionalExpression"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:101:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public void conditionalExpression() // throws RecognitionException [1]
    {   
        int conditionalExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:102:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:102:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression332);
            	conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:102:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == 26) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:102:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	Match(input,26,FOLLOW_26_in_conditionalExpression336); if (state.failed) return ;
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression338);
            	        	conditionalExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;
            	        	Match(input,27,FOLLOW_27_in_conditionalExpression340); if (state.failed) return ;
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression342);
            	        	conditionalExpression();
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
            	Memoize(input, 12, conditionalExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "conditionalExpression"


    // $ANTLR start "conditionalOrExpression"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:106:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public void conditionalOrExpression() // throws RecognitionException [1]
    {   
        int conditionalOrExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:107:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:107:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression373);
            	conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:107:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == 28) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:107:36: '||' conditionalAndExpression
            			    {
            			    	Match(input,28,FOLLOW_28_in_conditionalOrExpression377); if (state.failed) return ;
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression379);
            			    	conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


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
            	Memoize(input, 13, conditionalOrExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "conditionalOrExpression"


    // $ANTLR start "conditionalAndExpression"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:111:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public void conditionalAndExpression() // throws RecognitionException [1]
    {   
        int conditionalAndExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:112:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:112:9: equalityExpression ( '&&' equalityExpression )*
            {
            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression410);
            	equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:112:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == 29) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:112:30: '&&' equalityExpression
            			    {
            			    	Match(input,29,FOLLOW_29_in_conditionalAndExpression414); if (state.failed) return ;
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression416);
            			    	equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, conditionalAndExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "conditionalAndExpression"


    // $ANTLR start "equalityExpression"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:116:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public void equalityExpression() // throws RecognitionException [1]
    {   
        int equalityExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:117:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:117:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression443);
            	relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:117:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( ((LA8_0 >= 30 && LA8_0 <= 31)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:117:32: ( '==' | '!=' ) relationalExpression
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

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression455);
            			    	relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, equalityExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "equalityExpression"


    // $ANTLR start "relationalExpression"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:121:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public void relationalExpression() // throws RecognitionException [1]
    {   
        int relationalExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:122:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:122:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression486);
            	additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:122:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( ((LA9_0 >= 32 && LA9_0 <= 35)) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:122:30: ( '<' | '>' | '<=' | '>=' ) additiveExpression
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

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression500);
            			    	additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 16, relationalExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "relationalExpression"


    // $ANTLR start "additiveExpression"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:126:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public void additiveExpression() // throws RecognitionException [1]
    {   
        int additiveExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:127:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:127:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression539);
            	multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:127:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( ((LA10_0 >= 36 && LA10_0 <= 37)) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:127:36: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	if ( (input.LA(1) >= 36 && input.LA(1) <= 37) ) 
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

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression551);
            			    	multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, additiveExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "additiveExpression"


    // $ANTLR start "multiplicativeExpression"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:131:1: multiplicativeExpression : unaryExpression ( ( '*' | '/' | '%' ) unaryExpression )* ;
    public void multiplicativeExpression() // throws RecognitionException [1]
    {   
        int multiplicativeExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:132:5: ( unaryExpression ( ( '*' | '/' | '%' ) unaryExpression )* )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:132:9: unaryExpression ( ( '*' | '/' | '%' ) unaryExpression )*
            {
            	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression586);
            	unaryExpression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:132:25: ( ( '*' | '/' | '%' ) unaryExpression )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( ((LA11_0 >= 38 && LA11_0 <= 40)) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:132:27: ( '*' | '/' | '%' ) unaryExpression
            			    {
            			    	if ( (input.LA(1) >= 38 && input.LA(1) <= 40) ) 
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

            			    	PushFollow(FOLLOW_unaryExpression_in_multiplicativeExpression604);
            			    	unaryExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, multiplicativeExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "multiplicativeExpression"


    // $ANTLR start "unaryExpression"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:135:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public void unaryExpression() // throws RecognitionException [1]
    {   
        int unaryExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:136:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt12 = 3;
            switch ( input.LA(1) ) 
            {
            case 41:
            	{
                alt12 = 1;
                }
                break;
            case 42:
            	{
                alt12 = 2;
                }
                break;
            case Identifier:
            case Integer:
            case Float:
            case String:
            case Boolean:
            case 43:
            case 44:
            case 48:
            	{
                alt12 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d12s0 =
            	        new NoViableAltException("", 12, 0, input);

            	    throw nvae_d12s0;
            }

            switch (alt12) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:136:7: '++' unaryExpression
                    {
                    	Match(input,41,FOLLOW_41_in_unaryExpression628); if (state.failed) return ;
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression630);
                    	unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:137:9: '--' unaryExpression
                    {
                    	Match(input,42,FOLLOW_42_in_unaryExpression640); if (state.failed) return ;
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression642);
                    	unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:138:9: unaryExpressionNotPlusMinus
                    {
                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression652);
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
            	Memoize(input, 19, unaryExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "unaryExpression"


    // $ANTLR start "unaryExpressionNotPlusMinus"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:142:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | primary ( '++' | '--' )? );
    public void unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        int unaryExpressionNotPlusMinus_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:143:5: ( '!' unaryExpression | castExpression | primary ( '++' | '--' )? )
            int alt14 = 3;
            switch ( input.LA(1) ) 
            {
            case 43:
            	{
                alt14 = 1;
                }
                break;
            case 44:
            	{
                int LA14_2 = input.LA(2);

                if ( ((LA14_2 >= Identifier && LA14_2 <= Boolean) || (LA14_2 >= 41 && LA14_2 <= 44) || LA14_2 == 48) )
                {
                    alt14 = 3;
                }
                else if ( ((LA14_2 >= 19 && LA14_2 <= 22)) )
                {
                    alt14 = 2;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return ;}
                    NoViableAltException nvae_d14s2 =
                        new NoViableAltException("", 14, 2, input);

                    throw nvae_d14s2;
                }
                }
                break;
            case Identifier:
            case Integer:
            case Float:
            case String:
            case Boolean:
            case 48:
            	{
                alt14 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            }

            switch (alt14) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:143:9: '!' unaryExpression
                    {
                    	Match(input,43,FOLLOW_43_in_unaryExpressionNotPlusMinus673); if (state.failed) return ;
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus675);
                    	unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:144:9: castExpression
                    {
                    	PushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus685);
                    	castExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:146:9: primary ( '++' | '--' )?
                    {
                    	PushFollow(FOLLOW_primary_in_unaryExpressionNotPlusMinus700);
                    	primary();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:146:17: ( '++' | '--' )?
                    	int alt13 = 2;
                    	int LA13_0 = input.LA(1);

                    	if ( ((LA13_0 >= 41 && LA13_0 <= 42)) )
                    	{
                    	    alt13 = 1;
                    	}
                    	switch (alt13) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:
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
            	Memoize(input, 20, unaryExpressionNotPlusMinus_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "unaryExpressionNotPlusMinus"


    // $ANTLR start "castExpression"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:150:1: castExpression : '(' primitiveType ')' unaryExpression ;
    public void castExpression() // throws RecognitionException [1]
    {   
        int castExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:151:5: ( '(' primitiveType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:151:8: '(' primitiveType ')' unaryExpression
            {
            	Match(input,44,FOLLOW_44_in_castExpression733); if (state.failed) return ;
            	PushFollow(FOLLOW_primitiveType_in_castExpression735);
            	primitiveType();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	Match(input,45,FOLLOW_45_in_castExpression737); if (state.failed) return ;
            	PushFollow(FOLLOW_unaryExpression_in_castExpression739);
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
            	Memoize(input, 21, castExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "castExpression"


    // $ANTLR start "primary"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:155:1: primary : ( parExpression | literal | Identifier ( '.' Identifier )* arguments );
    public void primary() // throws RecognitionException [1]
    {   
        int primary_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:156:5: ( parExpression | literal | Identifier ( '.' Identifier )* arguments )
            int alt16 = 3;
            switch ( input.LA(1) ) 
            {
            case 44:
            	{
                alt16 = 1;
                }
                break;
            case Integer:
            case Float:
            case String:
            case Boolean:
            case 48:
            	{
                alt16 = 2;
                }
                break;
            case Identifier:
            	{
                alt16 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            }

            switch (alt16) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:156:9: parExpression
                    {
                    	PushFollow(FOLLOW_parExpression_in_primary761);
                    	parExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:157:9: literal
                    {
                    	PushFollow(FOLLOW_literal_in_primary771);
                    	literal();
                    	state.followingStackPointer--;
                    	if (state.failed) return ;

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:159:9: Identifier ( '.' Identifier )* arguments
                    {
                    	Match(input,Identifier,FOLLOW_Identifier_in_primary786); if (state.failed) return ;
                    	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:159:20: ( '.' Identifier )*
                    	do 
                    	{
                    	    int alt15 = 2;
                    	    int LA15_0 = input.LA(1);

                    	    if ( (LA15_0 == 46) )
                    	    {
                    	        alt15 = 1;
                    	    }


                    	    switch (alt15) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:159:21: '.' Identifier
                    			    {
                    			    	Match(input,46,FOLLOW_46_in_primary789); if (state.failed) return ;
                    			    	Match(input,Identifier,FOLLOW_Identifier_in_primary791); if (state.failed) return ;

                    			    }
                    			    break;

                    			default:
                    			    goto loop15;
                    	    }
                    	} while (true);

                    	loop15:
                    		;	// Stops C# compiler whining that label 'loop15' has no statements

                    	PushFollow(FOLLOW_arguments_in_primary795);
                    	arguments();
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
            	Memoize(input, 22, primary_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "primary"


    // $ANTLR start "parExpression"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:162:1: parExpression : '(' expression ')' ;
    public void parExpression() // throws RecognitionException [1]
    {   
        int parExpression_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:163:5: ( '(' expression ')' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:163:9: '(' expression ')'
            {
            	Match(input,44,FOLLOW_44_in_parExpression818); if (state.failed) return ;
            	PushFollow(FOLLOW_expression_in_parExpression820);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	Match(input,45,FOLLOW_45_in_parExpression822); if (state.failed) return ;

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
            	Memoize(input, 23, parExpression_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "parExpression"


    // $ANTLR start "arguments"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:167:1: arguments : '(' ( expressionList )? ')' ;
    public void arguments() // throws RecognitionException [1]
    {   
        int arguments_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:168:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:168:9: '(' ( expressionList )? ')'
            {
            	Match(input,44,FOLLOW_44_in_arguments842); if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:168:13: ( expressionList )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( ((LA17_0 >= Identifier && LA17_0 <= Boolean) || (LA17_0 >= 41 && LA17_0 <= 44) || LA17_0 == 48) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments844);
            	        	expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return ;

            	        }
            	        break;

            	}

            	Match(input,45,FOLLOW_45_in_arguments847); if (state.failed) return ;

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
            	Memoize(input, 24, arguments_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "arguments"


    // $ANTLR start "expressionList"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:171:1: expressionList : expression ( ',' expression )* ;
    public void expressionList() // throws RecognitionException [1]
    {   
        int expressionList_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:172:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:172:9: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList866);
            	expression();
            	state.followingStackPointer--;
            	if (state.failed) return ;
            	// C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:172:20: ( ',' expression )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == 47) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:172:21: ',' expression
            			    {
            			    	Match(input,47,FOLLOW_47_in_expressionList869); if (state.failed) return ;
            			    	PushFollow(FOLLOW_expression_in_expressionList871);
            			    	expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return ;

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
            	Memoize(input, 25, expressionList_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "expressionList"


    // $ANTLR start "literal"
    // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:177:1: literal : ( Integer | Float | String | Boolean | 'null' );
    public void literal() // throws RecognitionException [1]
    {   
        int literal_StartIndex = input.Index();
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return ; 
    	    }
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:178:5: ( Integer | Float | String | Boolean | 'null' )
            // C:\\Users\\Dominik Halfkann\\sgl4cs\\ANTLR Parser\\SGL.g:
            {
            	if ( (input.LA(1) >= Integer && input.LA(1) <= Boolean) || input.LA(1) == 48 ) 
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
            	Memoize(input, 26, literal_StartIndex); 
            }
        }
        return ;
    }
    // $ANTLR end "literal"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_statement_in_compilationUnit62 = new BitSet(new ulong[]{0x0000000003F80012UL});
    public static readonly BitSet FOLLOW_localVariableDeclarationStatement_in_statement79 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_variableAssignmentStatement_in_statement86 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_17_in_statement91 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_localVariableDeclarationStatement107 = new BitSet(new ulong[]{0x0000000003F80010UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_localVariableDeclarationStatement109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_variableAssignmentStatement122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration141 = new BitSet(new ulong[]{0x0000000000040002UL});
    public static readonly BitSet FOLLOW_18_in_variableDeclaration144 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_variableInit_in_variableDeclaration146 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_variableInit160 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName173 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primitiveType_in_variableType185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_classType_in_variableType190 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_primitiveType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_classType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression304 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression332 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_conditionalExpression336 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression338 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_27_in_conditionalExpression340 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression342 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression373 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_conditionalOrExpression377 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression379 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression410 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_29_in_conditionalAndExpression414 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression416 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression443 = new BitSet(new ulong[]{0x00000000C0000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpression447 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression455 = new BitSet(new ulong[]{0x00000000C0000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression486 = new BitSet(new ulong[]{0x0000000F00000002UL});
    public static readonly BitSet FOLLOW_set_in_relationalExpression490 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression500 = new BitSet(new ulong[]{0x0000000F00000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression539 = new BitSet(new ulong[]{0x0000003000000002UL});
    public static readonly BitSet FOLLOW_set_in_additiveExpression543 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression551 = new BitSet(new ulong[]{0x0000003000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression586 = new BitSet(new ulong[]{0x000001C000000002UL});
    public static readonly BitSet FOLLOW_set_in_multiplicativeExpression590 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_multiplicativeExpression604 = new BitSet(new ulong[]{0x000001C000000002UL});
    public static readonly BitSet FOLLOW_41_in_unaryExpression628 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression630 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_unaryExpression640 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression642 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression652 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_unaryExpressionNotPlusMinus673 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus675 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus685 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_primary_in_unaryExpressionNotPlusMinus700 = new BitSet(new ulong[]{0x0000060000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_castExpression733 = new BitSet(new ulong[]{0x0000000000780000UL});
    public static readonly BitSet FOLLOW_primitiveType_in_castExpression735 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_castExpression737 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression739 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_parExpression_in_primary761 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_literal_in_primary771 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_primary786 = new BitSet(new ulong[]{0x0000500000000000UL});
    public static readonly BitSet FOLLOW_46_in_primary789 = new BitSet(new ulong[]{0x0000000000000010UL});
    public static readonly BitSet FOLLOW_Identifier_in_primary791 = new BitSet(new ulong[]{0x0000500000000000UL});
    public static readonly BitSet FOLLOW_arguments_in_primary795 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_parExpression818 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_expression_in_parExpression820 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_parExpression822 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_arguments842 = new BitSet(new ulong[]{0x00013E00000001F0UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments844 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_arguments847 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList866 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_47_in_expressionList869 = new BitSet(new ulong[]{0x00011E00000001F0UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList871 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
