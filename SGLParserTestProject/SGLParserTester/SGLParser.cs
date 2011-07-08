// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g 2011-07-08 18:32:34

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


	//using SGLParserTester;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;

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
    public const int COMMENT = 24;
    public const int VARDEF = 4;
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
    public const int OctalEscape = 21;
    public const int EscapeSequence = 16;
    public const int Letter = 18;

    // delegates
    // delegators



        public SGLParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SGLParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return SGLParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g"; }
    }



    	// Error reporting
    	///*
        private StdErrReporter errorReporter = new StdErrReporter();
        public override void EmitErrorMessage(String msg)
        {
        	errorReporter.ReportError(msg);
        }
        //*/
        
    	// For global variables (accessable anywhere)
    	//NullableDictionnary globalVariables = new NullableDictionnary();
    	
    	// For main variables (accessable anywhere but methods)
    	//Stack<NullableDictionnary> localVariables = new Stack<NullableDictionnary>();
    	//NullableDictionnary mainVariables = new NullableDictionnary();
    	
    	// This should tell the statements where they have to look up variables
    	//NullableDictionnary variableAccess = mainVariables;

    	//String output;
    	//public String GetOutput() {
    	//	return output;
    	//}


    public class compilationUnit_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "compilationUnit"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:70:1: compilationUnit : ( statement )+ EOF ;
    public SGLParser.compilationUnit_return compilationUnit() // throws RecognitionException [1]
    {   
        SGLParser.compilationUnit_return retval = new SGLParser.compilationUnit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF2 = null;
        SGLParser.statement_return statement1 = default(SGLParser.statement_return);


        object EOF2_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:71:2: ( ( statement )+ EOF )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:71:4: ( statement )+ EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:71:4: ( statement )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= IntType && LA1_0 <= FloatType)) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:71:4: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_compilationUnit91);
            			    	statement1 = statement();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, statement1.Tree);

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

            	EOF2=(IToken)Match(input,EOF,FOLLOW_EOF_in_compilationUnit94); 
            		EOF2_tree = (object)adaptor.Create(EOF2);
            		adaptor.AddChild(root_0, EOF2_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "compilationUnit"

    public class statement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "statement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:75:1: statement : variableDefinitionList ;
    public SGLParser.statement_return statement() // throws RecognitionException [1]
    {   
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.variableDefinitionList_return variableDefinitionList3 = default(SGLParser.variableDefinitionList_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:2: ( variableDefinitionList )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:5: variableDefinitionList
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableDefinitionList_in_statement109);
            	variableDefinitionList3 = variableDefinitionList();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variableDefinitionList3.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class variableDefinitionList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableDefinitionList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:84:1: variableDefinitionList : variableType variableDefinition ( ',' variableDefinition )* -> ( ^( VARDEF variableType variableDefinition ) )+ ;
    public SGLParser.variableDefinitionList_return variableDefinitionList() // throws RecognitionException [1]
    {   
        SGLParser.variableDefinitionList_return retval = new SGLParser.variableDefinitionList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal6 = null;
        SGLParser.variableType_return variableType4 = default(SGLParser.variableType_return);

        SGLParser.variableDefinition_return variableDefinition5 = default(SGLParser.variableDefinition_return);

        SGLParser.variableDefinition_return variableDefinition7 = default(SGLParser.variableDefinition_return);


        object char_literal6_tree=null;
        RewriteRuleTokenStream stream_25 = new RewriteRuleTokenStream(adaptor,"token 25");
        RewriteRuleSubtreeStream stream_variableType = new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableDefinition = new RewriteRuleSubtreeStream(adaptor,"rule variableDefinition");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:2: ( variableType variableDefinition ( ',' variableDefinition )* -> ( ^( VARDEF variableType variableDefinition ) )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:4: variableType variableDefinition ( ',' variableDefinition )*
            {
            	PushFollow(FOLLOW_variableType_in_variableDefinitionList125);
            	variableType4 = variableType();
            	state.followingStackPointer--;

            	stream_variableType.Add(variableType4.Tree);
            	PushFollow(FOLLOW_variableDefinition_in_variableDefinitionList127);
            	variableDefinition5 = variableDefinition();
            	state.followingStackPointer--;

            	stream_variableDefinition.Add(variableDefinition5.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:36: ( ',' variableDefinition )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == 25) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:37: ',' variableDefinition
            			    {
            			    	char_literal6=(IToken)Match(input,25,FOLLOW_25_in_variableDefinitionList130);  
            			    	stream_25.Add(char_literal6);

            			    	PushFollow(FOLLOW_variableDefinition_in_variableDefinitionList132);
            			    	variableDefinition7 = variableDefinition();
            			    	state.followingStackPointer--;

            			    	stream_variableDefinition.Add(variableDefinition7.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements



            	// AST REWRITE
            	// elements:          variableDefinition, variableType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 85:62: -> ( ^( VARDEF variableType variableDefinition ) )+
            	{
            	    if ( !(stream_variableDefinition.HasNext() || stream_variableType.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_variableDefinition.HasNext() || stream_variableType.HasNext() )
            	    {
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:65: ^( VARDEF variableType variableDefinition )
            	        {
            	        object root_1 = (object)adaptor.GetNilNode();
            	        root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDEF, "VARDEF"), root_1);

            	        adaptor.AddChild(root_1, stream_variableType.NextTree());
            	        adaptor.AddChild(root_1, stream_variableDefinition.NextTree());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_variableDefinition.Reset();
            	    stream_variableType.Reset();

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableDefinitionList"

    public class variableDefinition_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableDefinition"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:88:1: variableDefinition : variableName ( '=' expression )? -> variableName ( expression )? ;
    public SGLParser.variableDefinition_return variableDefinition() // throws RecognitionException [1]
    {   
        SGLParser.variableDefinition_return retval = new SGLParser.variableDefinition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal9 = null;
        SGLParser.variableName_return variableName8 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression10 = default(SGLParser.expression_return);


        object char_literal9_tree=null;
        RewriteRuleTokenStream stream_26 = new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:89:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:89:4: variableName ( '=' expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableDefinition156);
            	variableName8 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName8.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:89:17: ( '=' expression )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == 26) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:89:18: '=' expression
            	        {
            	        	char_literal9=(IToken)Match(input,26,FOLLOW_26_in_variableDefinition159);  
            	        	stream_26.Add(char_literal9);

            	        	PushFollow(FOLLOW_expression_in_variableDefinition161);
            	        	expression10 = expression();
            	        	state.followingStackPointer--;

            	        	stream_expression.Add(expression10.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          expression, variableName
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 89:36: -> variableName ( expression )?
            	{
            	    adaptor.AddChild(root_0, stream_variableName.NextTree());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:89:52: ( expression )?
            	    if ( stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_0, stream_expression.NextTree());

            	    }
            	    stream_expression.Reset();

            	}

            	retval.Tree = root_0;retval.Tree = root_0;
            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableDefinition"

    public class simpleVariableDefinition_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "simpleVariableDefinition"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:92:1: simpleVariableDefinition : variableType ;
    public SGLParser.simpleVariableDefinition_return simpleVariableDefinition() // throws RecognitionException [1]
    {   
        SGLParser.simpleVariableDefinition_return retval = new SGLParser.simpleVariableDefinition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.variableType_return variableType11 = default(SGLParser.variableType_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:93:2: ( variableType )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:93:4: variableType
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableType_in_simpleVariableDefinition183);
            	variableType11 = variableType();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variableType11.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "simpleVariableDefinition"

    public class localVariableDeclarationStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "localVariableDeclarationStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:96:1: localVariableDeclarationStatement : ( 'boolean' variableName ( '=' expression )? | 'int' variableName ( '=' expression )? );
    public SGLParser.localVariableDeclarationStatement_return localVariableDeclarationStatement() // throws RecognitionException [1]
    {   
        SGLParser.localVariableDeclarationStatement_return retval = new SGLParser.localVariableDeclarationStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal12 = null;
        IToken char_literal14 = null;
        IToken string_literal16 = null;
        IToken char_literal18 = null;
        SGLParser.variableName_return variableName13 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression15 = default(SGLParser.expression_return);

        SGLParser.variableName_return variableName17 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression19 = default(SGLParser.expression_return);


        object string_literal12_tree=null;
        object char_literal14_tree=null;
        object string_literal16_tree=null;
        object char_literal18_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:2: ( 'boolean' variableName ( '=' expression )? | 'int' variableName ( '=' expression )? )
            int alt6 = 2;
            int LA6_0 = input.LA(1);

            if ( (LA6_0 == BooleanType) )
            {
                alt6 = 1;
            }
            else if ( (LA6_0 == IntType) )
            {
                alt6 = 2;
            }
            else 
            {
                NoViableAltException nvae_d6s0 =
                    new NoViableAltException("", 6, 0, input);

                throw nvae_d6s0;
            }
            switch (alt6) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:5: 'boolean' variableName ( '=' expression )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal12=(IToken)Match(input,BooleanType,FOLLOW_BooleanType_in_localVariableDeclarationStatement195); 
                    		string_literal12_tree = (object)adaptor.Create(string_literal12);
                    		adaptor.AddChild(root_0, string_literal12_tree);

                    	PushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement197);
                    	variableName13 = variableName();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableName13.Tree);
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:28: ( '=' expression )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == 26) )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:29: '=' expression
                    	        {
                    	        	char_literal14=(IToken)Match(input,26,FOLLOW_26_in_localVariableDeclarationStatement200); 
                    	        		char_literal14_tree = (object)adaptor.Create(char_literal14);
                    	        		adaptor.AddChild(root_0, char_literal14_tree);

                    	        	PushFollow(FOLLOW_expression_in_localVariableDeclarationStatement202);
                    	        	expression15 = expression();
                    	        	state.followingStackPointer--;

                    	        	adaptor.AddChild(root_0, expression15.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:98:4: 'int' variableName ( '=' expression )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal16=(IToken)Match(input,IntType,FOLLOW_IntType_in_localVariableDeclarationStatement209); 
                    		string_literal16_tree = (object)adaptor.Create(string_literal16);
                    		adaptor.AddChild(root_0, string_literal16_tree);

                    	PushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement211);
                    	variableName17 = variableName();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableName17.Tree);
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:98:23: ( '=' expression )?
                    	int alt5 = 2;
                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == 26) )
                    	{
                    	    alt5 = 1;
                    	}
                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:98:24: '=' expression
                    	        {
                    	        	char_literal18=(IToken)Match(input,26,FOLLOW_26_in_localVariableDeclarationStatement214); 
                    	        		char_literal18_tree = (object)adaptor.Create(char_literal18);
                    	        		adaptor.AddChild(root_0, char_literal18_tree);

                    	        	PushFollow(FOLLOW_expression_in_localVariableDeclarationStatement216);
                    	        	expression19 = expression();
                    	        	state.followingStackPointer--;

                    	        	adaptor.AddChild(root_0, expression19.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "localVariableDeclarationStatement"

    public class variableAssignmentStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableAssignmentStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:102:1: variableAssignmentStatement : variableDeclaration ;
    public SGLParser.variableAssignmentStatement_return variableAssignmentStatement() // throws RecognitionException [1]
    {   
        SGLParser.variableAssignmentStatement_return retval = new SGLParser.variableAssignmentStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.variableDeclaration_return variableDeclaration20 = default(SGLParser.variableDeclaration_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:103:2: ( variableDeclaration )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:103:4: variableDeclaration
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableDeclaration_in_variableAssignmentStatement231);
            	variableDeclaration20 = variableDeclaration();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variableDeclaration20.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableAssignmentStatement"

    public class variableDeclaration_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableDeclaration"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:111:1: variableDeclaration : variableName ( '=' expression )? ;
    public SGLParser.variableDeclaration_return variableDeclaration() // throws RecognitionException [1]
    {   
        SGLParser.variableDeclaration_return retval = new SGLParser.variableDeclaration_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal22 = null;
        SGLParser.variableName_return variableName21 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression23 = default(SGLParser.expression_return);


        object char_literal22_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:112:2: ( variableName ( '=' expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:112:4: variableName ( '=' expression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableName_in_variableDeclaration250);
            	variableName21 = variableName();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variableName21.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:112:17: ( '=' expression )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == 26) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:112:18: '=' expression
            	        {
            	        	char_literal22=(IToken)Match(input,26,FOLLOW_26_in_variableDeclaration253); 
            	        		char_literal22_tree = (object)adaptor.Create(char_literal22);
            	        		adaptor.AddChild(root_0, char_literal22_tree);

            	        	PushFollow(FOLLOW_expression_in_variableDeclaration255);
            	        	expression23 = expression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expression23.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableDeclaration"

    public class variableName_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableName"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:116:1: variableName : Identifier ;
    public SGLParser.variableName_return variableName() // throws RecognitionException [1]
    {   
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier24 = null;

        object Identifier24_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:117:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:117:4: Identifier
            {
            	root_0 = (object)adaptor.GetNilNode();

            	Identifier24=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableName271); 
            		Identifier24_tree = (object)adaptor.Create(Identifier24);
            		adaptor.AddChild(root_0, Identifier24_tree);


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableName"

    public class variableType_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableType"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:120:1: variableType : ( IntType | BooleanType | StringType | FloatType );
    public SGLParser.variableType_return variableType() // throws RecognitionException [1]
    {   
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set25 = null;

        object set25_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:121:2: ( IntType | BooleanType | StringType | FloatType )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set25 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntType && input.LA(1) <= FloatType) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set25));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "variableType"

    public class expression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:134:1: expression : conditionalExpression ;
    public SGLParser.expression_return expression() // throws RecognitionException [1]
    {   
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression26 = default(SGLParser.conditionalExpression_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:135:5: ( conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:135:8: conditionalExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalExpression_in_expression335);
            	conditionalExpression26 = conditionalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalExpression26.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expression"

    public class conditionalExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "conditionalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:144:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public SGLParser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal28 = null;
        IToken char_literal30 = null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression27 = default(SGLParser.conditionalOrExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression29 = default(SGLParser.conditionalExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression31 = default(SGLParser.conditionalExpression_return);


        object char_literal28_tree=null;
        object char_literal30_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:145:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:145:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression376);
            	conditionalOrExpression27 = conditionalOrExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalOrExpression27.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:145:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == 27) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:145:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	char_literal28=(IToken)Match(input,27,FOLLOW_27_in_conditionalExpression380); 
            	        		char_literal28_tree = (object)adaptor.Create(char_literal28);
            	        		root_0 = (object)adaptor.BecomeRoot(char_literal28_tree, root_0);

            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression383);
            	        	conditionalExpression29 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression29.Tree);
            	        	char_literal30=(IToken)Match(input,28,FOLLOW_28_in_conditionalExpression385); 
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression388);
            	        	conditionalExpression31 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression31.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "conditionalExpression"

    public class conditionalOrExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "conditionalOrExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:150:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public SGLParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal33 = null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression32 = default(SGLParser.conditionalAndExpression_return);

        SGLParser.conditionalAndExpression_return conditionalAndExpression34 = default(SGLParser.conditionalAndExpression_return);


        object string_literal33_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:151:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:151:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression431);
            	conditionalAndExpression32 = conditionalAndExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalAndExpression32.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:151:34: ( '||' conditionalAndExpression )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:151:36: '||' conditionalAndExpression
            			    {
            			    	string_literal33=(IToken)Match(input,29,FOLLOW_29_in_conditionalOrExpression435); 
            			    		string_literal33_tree = (object)adaptor.Create(string_literal33);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal33_tree, root_0);

            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression438);
            			    	conditionalAndExpression34 = conditionalAndExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, conditionalAndExpression34.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "conditionalOrExpression"

    public class conditionalAndExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "conditionalAndExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:155:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public SGLParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal36 = null;
        SGLParser.equalityExpression_return equalityExpression35 = default(SGLParser.equalityExpression_return);

        SGLParser.equalityExpression_return equalityExpression37 = default(SGLParser.equalityExpression_return);


        object string_literal36_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:156:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:156:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression469);
            	equalityExpression35 = equalityExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, equalityExpression35.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:156:28: ( '&&' equalityExpression )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:156:30: '&&' equalityExpression
            			    {
            			    	string_literal36=(IToken)Match(input,30,FOLLOW_30_in_conditionalAndExpression473); 
            			    		string_literal36_tree = (object)adaptor.Create(string_literal36);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal36_tree, root_0);

            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression476);
            			    	equalityExpression37 = equalityExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, equalityExpression37.Tree);

            			    }
            			    break;

            			default:
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "conditionalAndExpression"

    public class equalityExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "equalityExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:160:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public SGLParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal39 = null;
        IToken string_literal40 = null;
        SGLParser.relationalExpression_return relationalExpression38 = default(SGLParser.relationalExpression_return);

        SGLParser.relationalExpression_return relationalExpression41 = default(SGLParser.relationalExpression_return);


        object string_literal39_tree=null;
        object string_literal40_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression503);
            	relationalExpression38 = relationalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, relationalExpression38.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= 31 && LA12_0 <= 32)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:32: ( '==' | '!=' )
            			    	int alt11 = 2;
            			    	int LA11_0 = input.LA(1);

            			    	if ( (LA11_0 == 31) )
            			    	{
            			    	    alt11 = 1;
            			    	}
            			    	else if ( (LA11_0 == 32) )
            			    	{
            			    	    alt11 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d11s0 =
            			    	        new NoViableAltException("", 11, 0, input);

            			    	    throw nvae_d11s0;
            			    	}
            			    	switch (alt11) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:33: '=='
            			    	        {
            			    	        	string_literal39=(IToken)Match(input,31,FOLLOW_31_in_equalityExpression508); 
            			    	        		string_literal39_tree = (object)adaptor.Create(string_literal39);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal39_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:41: '!='
            			    	        {
            			    	        	string_literal40=(IToken)Match(input,32,FOLLOW_32_in_equalityExpression513); 
            			    	        		string_literal40_tree = (object)adaptor.Create(string_literal40);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal40_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression517);
            			    	relationalExpression41 = relationalExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, relationalExpression41.Tree);

            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "equalityExpression"

    public class relationalExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "relationalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:165:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public SGLParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal43 = null;
        IToken char_literal44 = null;
        IToken string_literal45 = null;
        IToken string_literal46 = null;
        SGLParser.additiveExpression_return additiveExpression42 = default(SGLParser.additiveExpression_return);

        SGLParser.additiveExpression_return additiveExpression47 = default(SGLParser.additiveExpression_return);


        object char_literal43_tree=null;
        object char_literal44_tree=null;
        object string_literal45_tree=null;
        object string_literal46_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression548);
            	additiveExpression42 = additiveExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additiveExpression42.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= 33 && LA14_0 <= 36)) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:29: ( '<' | '>' | '<=' | '>=' )
            			    	int alt13 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 33:
            			    		{
            			    	    alt13 = 1;
            			    	    }
            			    	    break;
            			    	case 34:
            			    		{
            			    	    alt13 = 2;
            			    	    }
            			    	    break;
            			    	case 35:
            			    		{
            			    	    alt13 = 3;
            			    	    }
            			    	    break;
            			    	case 36:
            			    		{
            			    	    alt13 = 4;
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:30: '<'
            			    	        {
            			    	        	char_literal43=(IToken)Match(input,33,FOLLOW_33_in_relationalExpression552); 
            			    	        		char_literal43_tree = (object)adaptor.Create(char_literal43);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal43_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:35: '>'
            			    	        {
            			    	        	char_literal44=(IToken)Match(input,34,FOLLOW_34_in_relationalExpression555); 
            			    	        		char_literal44_tree = (object)adaptor.Create(char_literal44);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal44_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:40: '<='
            			    	        {
            			    	        	string_literal45=(IToken)Match(input,35,FOLLOW_35_in_relationalExpression558); 
            			    	        		string_literal45_tree = (object)adaptor.Create(string_literal45);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal45_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:46: '>='
            			    	        {
            			    	        	string_literal46=(IToken)Match(input,36,FOLLOW_36_in_relationalExpression561); 
            			    	        		string_literal46_tree = (object)adaptor.Create(string_literal46);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal46_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression565);
            			    	additiveExpression47 = additiveExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, additiveExpression47.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "relationalExpression"

    public class additiveExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "additiveExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:170:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public SGLParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal49 = null;
        IToken char_literal50 = null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression48 = default(SGLParser.multiplicativeExpression_return);

        SGLParser.multiplicativeExpression_return multiplicativeExpression51 = default(SGLParser.multiplicativeExpression_return);


        object char_literal49_tree=null;
        object char_literal50_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression603);
            	multiplicativeExpression48 = multiplicativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multiplicativeExpression48.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( ((LA16_0 >= 37 && LA16_0 <= 38)) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:35: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:35: ( '+' | '-' )
            			    	int alt15 = 2;
            			    	int LA15_0 = input.LA(1);

            			    	if ( (LA15_0 == 37) )
            			    	{
            			    	    alt15 = 1;
            			    	}
            			    	else if ( (LA15_0 == 38) )
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:36: '+'
            			    	        {
            			    	        	char_literal49=(IToken)Match(input,37,FOLLOW_37_in_additiveExpression607); 
            			    	        		char_literal49_tree = (object)adaptor.Create(char_literal49);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal49_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:41: '-'
            			    	        {
            			    	        	char_literal50=(IToken)Match(input,38,FOLLOW_38_in_additiveExpression610); 
            			    	        		char_literal50_tree = (object)adaptor.Create(char_literal50);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal50_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression614);
            			    	multiplicativeExpression51 = multiplicativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multiplicativeExpression51.Tree);

            			    }
            			    break;

            			default:
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "additiveExpression"

    public class multiplicativeExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "multiplicativeExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:175:1: multiplicativeExpression : negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* ;
    public SGLParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal53 = null;
        IToken char_literal54 = null;
        IToken char_literal55 = null;
        SGLParser.negativeExpression_return negativeExpression52 = default(SGLParser.negativeExpression_return);

        SGLParser.negativeExpression_return negativeExpression56 = default(SGLParser.negativeExpression_return);


        object char_literal53_tree=null;
        object char_literal54_tree=null;
        object char_literal55_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:176:5: ( negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:176:9: negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression648);
            	negativeExpression52 = negativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, negativeExpression52.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:177:5: ( ( '*' | '/' | '%' ) negativeExpression )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( ((LA18_0 >= 39 && LA18_0 <= 41)) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:177:6: ( '*' | '/' | '%' ) negativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:177:6: ( '*' | '/' | '%' )
            			    	int alt17 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 39:
            			    		{
            			    	    alt17 = 1;
            			    	    }
            			    	    break;
            			    	case 40:
            			    		{
            			    	    alt17 = 2;
            			    	    }
            			    	    break;
            			    	case 41:
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:177:7: '*'
            			    	        {
            			    	        	char_literal53=(IToken)Match(input,39,FOLLOW_39_in_multiplicativeExpression656); 
            			    	        		char_literal53_tree = (object)adaptor.Create(char_literal53);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal53_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:177:12: '/'
            			    	        {
            			    	        	char_literal54=(IToken)Match(input,40,FOLLOW_40_in_multiplicativeExpression659); 
            			    	        		char_literal54_tree = (object)adaptor.Create(char_literal54);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal54_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:177:17: '%'
            			    	        {
            			    	        	char_literal55=(IToken)Match(input,41,FOLLOW_41_in_multiplicativeExpression662); 
            			    	        		char_literal55_tree = (object)adaptor.Create(char_literal55);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal55_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression666);
            			    	negativeExpression56 = negativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, negativeExpression56.Tree);

            			    }
            			    break;

            			default:
            			    goto loop18;
            	    }
            	} while (true);

            	loop18:
            		;	// Stops C# compiler whining that label 'loop18' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "multiplicativeExpression"

    public class unaryExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unaryExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:180:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public SGLParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal57 = null;
        IToken string_literal59 = null;
        SGLParser.unaryExpression_return unaryExpression58 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpression_return unaryExpression60 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus61 = default(SGLParser.unaryExpressionNotPlusMinus_return);


        object string_literal57_tree=null;
        object string_literal59_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:181:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt19 = 3;
            switch ( input.LA(1) ) 
            {
            case 42:
            	{
                alt19 = 1;
                }
                break;
            case 43:
            	{
                alt19 = 2;
                }
                break;
            case Identifier:
            case IntegerAtom:
            case 44:
            case 45:
            	{
                alt19 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("", 19, 0, input);

            	    throw nvae_d19s0;
            }

            switch (alt19) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:181:7: '++' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal57=(IToken)Match(input,42,FOLLOW_42_in_unaryExpression689); 
                    		string_literal57_tree = (object)adaptor.Create(string_literal57);
                    		adaptor.AddChild(root_0, string_literal57_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression691);
                    	unaryExpression58 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression58.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:182:9: '--' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal59=(IToken)Match(input,43,FOLLOW_43_in_unaryExpression701); 
                    		string_literal59_tree = (object)adaptor.Create(string_literal59);
                    		adaptor.AddChild(root_0, string_literal59_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression703);
                    	unaryExpression60 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression60.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:183:9: unaryExpressionNotPlusMinus
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression713);
                    	unaryExpressionNotPlusMinus61 = unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpressionNotPlusMinus61.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unaryExpression"

    public class unaryExpressionNotPlusMinus_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "unaryExpressionNotPlusMinus"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:187:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal62 = null;
        IToken set66 = null;
        SGLParser.unaryExpression_return unaryExpression63 = default(SGLParser.unaryExpression_return);

        SGLParser.castExpression_return castExpression64 = default(SGLParser.castExpression_return);

        SGLParser.mathAtom_return mathAtom65 = default(SGLParser.mathAtom_return);


        object char_literal62_tree=null;
        object set66_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:188:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt21 = 3;
            switch ( input.LA(1) ) 
            {
            case 44:
            	{
                alt21 = 1;
                }
                break;
            case 45:
            	{
                int LA21_2 = input.LA(2);

                if ( ((LA21_2 >= IntType && LA21_2 <= FloatType)) )
                {
                    alt21 = 2;
                }
                else if ( (LA21_2 == Identifier || LA21_2 == IntegerAtom || LA21_2 == 38 || LA21_2 == 45) )
                {
                    alt21 = 3;
                }
                else 
                {
                    NoViableAltException nvae_d21s2 =
                        new NoViableAltException("", 21, 2, input);

                    throw nvae_d21s2;
                }
                }
                break;
            case Identifier:
            case IntegerAtom:
            	{
                alt21 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d21s0 =
            	        new NoViableAltException("", 21, 0, input);

            	    throw nvae_d21s0;
            }

            switch (alt21) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:188:9: '!' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal62=(IToken)Match(input,44,FOLLOW_44_in_unaryExpressionNotPlusMinus734); 
                    		char_literal62_tree = (object)adaptor.Create(char_literal62);
                    		adaptor.AddChild(root_0, char_literal62_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus736);
                    	unaryExpression63 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression63.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:189:9: castExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus746);
                    	castExpression64 = castExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, castExpression64.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:191:9: mathAtom ( '++' | '--' )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus761);
                    	mathAtom65 = mathAtom();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, mathAtom65.Tree);
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:191:18: ( '++' | '--' )?
                    	int alt20 = 2;
                    	int LA20_0 = input.LA(1);

                    	if ( ((LA20_0 >= 42 && LA20_0 <= 43)) )
                    	{
                    	    alt20 = 1;
                    	}
                    	switch (alt20) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
                    	        {
                    	        	set66 = (IToken)input.LT(1);
                    	        	if ( (input.LA(1) >= 42 && input.LA(1) <= 43) ) 
                    	        	{
                    	        	    input.Consume();
                    	        	    adaptor.AddChild(root_0, (object)adaptor.Create(set66));
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
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "unaryExpressionNotPlusMinus"

    public class castExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "castExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:195:1: castExpression : '(' variableType ')' unaryExpression ;
    public SGLParser.castExpression_return castExpression() // throws RecognitionException [1]
    {   
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal67 = null;
        IToken char_literal69 = null;
        SGLParser.variableType_return variableType68 = default(SGLParser.variableType_return);

        SGLParser.unaryExpression_return unaryExpression70 = default(SGLParser.unaryExpression_return);


        object char_literal67_tree=null;
        object char_literal69_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:196:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:196:8: '(' variableType ')' unaryExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal67=(IToken)Match(input,45,FOLLOW_45_in_castExpression794); 
            		char_literal67_tree = (object)adaptor.Create(char_literal67);
            		adaptor.AddChild(root_0, char_literal67_tree);

            	PushFollow(FOLLOW_variableType_in_castExpression796);
            	variableType68 = variableType();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variableType68.Tree);
            	char_literal69=(IToken)Match(input,46,FOLLOW_46_in_castExpression798); 
            		char_literal69_tree = (object)adaptor.Create(char_literal69);
            		adaptor.AddChild(root_0, char_literal69_tree);

            	PushFollow(FOLLOW_unaryExpression_in_castExpression800);
            	unaryExpression70 = unaryExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, unaryExpression70.Tree);

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "castExpression"

    public class negativeExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "negativeExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:201:1: negativeExpression : ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) );
    public SGLParser.negativeExpression_return negativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.negativeExpression_return retval = new SGLParser.negativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal72 = null;
        SGLParser.mathAtom_return mathAtom71 = default(SGLParser.mathAtom_return);

        SGLParser.mathAtom_return mathAtom73 = default(SGLParser.mathAtom_return);


        object char_literal72_tree=null;
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_mathAtom = new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:202:2: ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) )
            int alt22 = 2;
            int LA22_0 = input.LA(1);

            if ( (LA22_0 == Identifier || LA22_0 == IntegerAtom || LA22_0 == 45) )
            {
                alt22 = 1;
            }
            else if ( (LA22_0 == 38) )
            {
                alt22 = 2;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:202:4: mathAtom
                    {
                    	PushFollow(FOLLOW_mathAtom_in_negativeExpression818);
                    	mathAtom71 = mathAtom();
                    	state.followingStackPointer--;

                    	stream_mathAtom.Add(mathAtom71.Tree);


                    	// AST REWRITE
                    	// elements:          mathAtom
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 202:13: -> mathAtom
                    	{
                    	    adaptor.AddChild(root_0, stream_mathAtom.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:4: ( '-' ) mathAtom
                    {
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:4: ( '-' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:5: '-'
                    	{
                    		char_literal72=(IToken)Match(input,38,FOLLOW_38_in_negativeExpression828);  
                    		stream_38.Add(char_literal72);


                    	}

                    	PushFollow(FOLLOW_mathAtom_in_negativeExpression831);
                    	mathAtom73 = mathAtom();
                    	state.followingStackPointer--;

                    	stream_mathAtom.Add(mathAtom73.Tree);


                    	// AST REWRITE
                    	// elements:          mathAtom
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 203:19: -> ^( NEGATE mathAtom )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:22: ^( NEGATE mathAtom )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(NEGATE, "NEGATE"), root_1);

                    	    adaptor.AddChild(root_1, stream_mathAtom.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "negativeExpression"

    public class mathAtom_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mathAtom"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:206:1: mathAtom : ( '(' additiveExpression ')' | IntegerAtom | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) );
    public SGLParser.mathAtom_return mathAtom() // throws RecognitionException [1]
    {   
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal74 = null;
        IToken char_literal76 = null;
        IToken IntegerAtom77 = null;
        IToken Identifier78 = null;
        SGLParser.additiveExpression_return additiveExpression75 = default(SGLParser.additiveExpression_return);

        SGLParser.arguments_return arguments79 = default(SGLParser.arguments_return);


        object char_literal74_tree=null;
        object char_literal76_tree=null;
        object IntegerAtom77_tree=null;
        object Identifier78_tree=null;
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:207:5: ( '(' additiveExpression ')' | IntegerAtom | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) )
            int alt23 = 3;
            switch ( input.LA(1) ) 
            {
            case 45:
            	{
                alt23 = 1;
                }
                break;
            case IntegerAtom:
            	{
                alt23 = 2;
                }
                break;
            case Identifier:
            	{
                alt23 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d23s0 =
            	        new NoViableAltException("", 23, 0, input);

            	    throw nvae_d23s0;
            }

            switch (alt23) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:207:7: '(' additiveExpression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal74=(IToken)Match(input,45,FOLLOW_45_in_mathAtom853); 
                    	PushFollow(FOLLOW_additiveExpression_in_mathAtom856);
                    	additiveExpression75 = additiveExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, additiveExpression75.Tree);
                    	char_literal76=(IToken)Match(input,46,FOLLOW_46_in_mathAtom858); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:208:9: IntegerAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IntegerAtom77=(IToken)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom869); 
                    		IntegerAtom77_tree = (object)adaptor.Create(IntegerAtom77);
                    		adaptor.AddChild(root_0, IntegerAtom77_tree);


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:213:4: Identifier arguments
                    {
                    	Identifier78=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_mathAtom887);  
                    	stream_Identifier.Add(Identifier78);

                    	PushFollow(FOLLOW_arguments_in_mathAtom889);
                    	arguments79 = arguments();
                    	state.followingStackPointer--;

                    	stream_arguments.Add(arguments79.Tree);


                    	// AST REWRITE
                    	// elements:          Identifier, arguments
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 213:25: -> ^( LIBMETHOD Identifier ( arguments )? )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:213:28: ^( LIBMETHOD Identifier ( arguments )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LIBMETHOD, "LIBMETHOD"), root_1);

                    	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:213:51: ( arguments )?
                    	    if ( stream_arguments.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_arguments.NextTree());

                    	    }
                    	    stream_arguments.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "mathAtom"

    public class arguments_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "arguments"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:217:1: arguments : '(' ( expressionList )? ')' ;
    public SGLParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal80 = null;
        IToken char_literal82 = null;
        SGLParser.expressionList_return expressionList81 = default(SGLParser.expressionList_return);


        object char_literal80_tree=null;
        object char_literal82_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:218:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:218:9: '(' ( expressionList )? ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal80=(IToken)Match(input,45,FOLLOW_45_in_arguments922); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:218:14: ( expressionList )?
            	int alt24 = 2;
            	int LA24_0 = input.LA(1);

            	if ( (LA24_0 == Identifier || LA24_0 == IntegerAtom || LA24_0 == 38 || LA24_0 == 45) )
            	{
            	    alt24 = 1;
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:218:14: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments925);
            	        	expressionList81 = expressionList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expressionList81.Tree);

            	        }
            	        break;

            	}

            	char_literal82=(IToken)Match(input,46,FOLLOW_46_in_arguments928); 

            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "arguments"

    public class expressionList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "expressionList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:221:1: expressionList : expression ( ',' expression )* ;
    public SGLParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal84 = null;
        SGLParser.expression_return expression83 = default(SGLParser.expression_return);

        SGLParser.expression_return expression85 = default(SGLParser.expression_return);


        object char_literal84_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:222:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:222:9: expression ( ',' expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionList948);
            	expression83 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression83.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:222:20: ( ',' expression )*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( (LA25_0 == 25) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:222:21: ',' expression
            			    {
            			    	char_literal84=(IToken)Match(input,25,FOLLOW_25_in_expressionList951); 
            			    	PushFollow(FOLLOW_expression_in_expressionList954);
            			    	expression85 = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expression85.Tree);

            			    }
            			    break;

            			default:
            			    goto loop25;
            	    }
            	} while (true);

            	loop25:
            		;	// Stops C# compiler whining that label 'loop25' has no statements


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "expressionList"

    public class literal_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "literal"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:227:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public SGLParser.literal_return literal() // throws RecognitionException [1]
    {   
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set86 = null;

        object set86_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:228:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set86 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == 47 ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set86));
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (object)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "literal"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_statement_in_compilationUnit91 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit94 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDefinitionList_in_statement109 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDefinitionList125 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variableDefinition_in_variableDefinitionList127 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_25_in_variableDefinitionList130 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variableDefinition_in_variableDefinitionList132 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDefinition156 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_variableDefinition159 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_expression_in_variableDefinition161 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_simpleVariableDefinition183 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_localVariableDeclarationStatement195 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variableName_in_localVariableDeclarationStatement197 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_localVariableDeclarationStatement200 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_expression_in_localVariableDeclarationStatement202 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_localVariableDeclarationStatement209 = new BitSet(new ulong[]{0x0000000000000080UL});
    public static readonly BitSet FOLLOW_variableName_in_localVariableDeclarationStatement211 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_localVariableDeclarationStatement214 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_expression_in_localVariableDeclarationStatement216 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_variableAssignmentStatement231 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration250 = new BitSet(new ulong[]{0x0000000004000002UL});
    public static readonly BitSet FOLLOW_26_in_variableDeclaration253 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclaration255 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName271 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_variableType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression376 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_27_in_conditionalExpression380 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression383 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_28_in_conditionalExpression385 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression388 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression431 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_29_in_conditionalOrExpression435 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression438 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression469 = new BitSet(new ulong[]{0x0000000040000002UL});
    public static readonly BitSet FOLLOW_30_in_conditionalAndExpression473 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression476 = new BitSet(new ulong[]{0x0000000040000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression503 = new BitSet(new ulong[]{0x0000000180000002UL});
    public static readonly BitSet FOLLOW_31_in_equalityExpression508 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_32_in_equalityExpression513 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression517 = new BitSet(new ulong[]{0x0000000180000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression548 = new BitSet(new ulong[]{0x0000001E00000002UL});
    public static readonly BitSet FOLLOW_33_in_relationalExpression552 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_34_in_relationalExpression555 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_35_in_relationalExpression558 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_36_in_relationalExpression561 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression565 = new BitSet(new ulong[]{0x0000001E00000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression603 = new BitSet(new ulong[]{0x0000006000000002UL});
    public static readonly BitSet FOLLOW_37_in_additiveExpression607 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_38_in_additiveExpression610 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression614 = new BitSet(new ulong[]{0x0000006000000002UL});
    public static readonly BitSet FOLLOW_negativeExpression_in_multiplicativeExpression648 = new BitSet(new ulong[]{0x0000038000000002UL});
    public static readonly BitSet FOLLOW_39_in_multiplicativeExpression656 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_40_in_multiplicativeExpression659 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_41_in_multiplicativeExpression662 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_negativeExpression_in_multiplicativeExpression666 = new BitSet(new ulong[]{0x0000038000000002UL});
    public static readonly BitSet FOLLOW_42_in_unaryExpression689 = new BitSet(new ulong[]{0x00003C0000001080UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression691 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_unaryExpression701 = new BitSet(new ulong[]{0x00003C0000001080UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression703 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_44_in_unaryExpressionNotPlusMinus734 = new BitSet(new ulong[]{0x00003C0000001080UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus736 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus746 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus761 = new BitSet(new ulong[]{0x00000C0000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus763 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_castExpression794 = new BitSet(new ulong[]{0x0000000000000F00UL});
    public static readonly BitSet FOLLOW_variableType_in_castExpression796 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_castExpression798 = new BitSet(new ulong[]{0x00003C0000001080UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression800 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negativeExpression818 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_negativeExpression828 = new BitSet(new ulong[]{0x0000200000001080UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negativeExpression831 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_mathAtom853 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_mathAtom856 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_mathAtom858 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom869 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_mathAtom887 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_arguments_in_mathAtom889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_45_in_arguments922 = new BitSet(new ulong[]{0x0000604000001080UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments925 = new BitSet(new ulong[]{0x0000400000000000UL});
    public static readonly BitSet FOLLOW_46_in_arguments928 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList948 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_25_in_expressionList951 = new BitSet(new ulong[]{0x0000204000001080UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList954 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}