// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g 2011-07-07 23:08:03

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
    public const int COMMENT = 22;
    public const int VARDEF = 4;
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
    public const int EscapeSequence = 14;
    public const int Letter = 16;
    public const int OctalEscape = 19;

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:58:1: compilationUnit : ( statement )+ EOF ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:59:2: ( ( statement )+ EOF )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:59:4: ( statement )+ EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:59:4: ( statement )+
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:59:4: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_compilationUnit83);
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

            	EOF2=(IToken)Match(input,EOF,FOLLOW_EOF_in_compilationUnit86); 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:63:1: statement : variableDefinitionList ;
    public SGLParser.statement_return statement() // throws RecognitionException [1]
    {   
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.variableDefinitionList_return variableDefinitionList3 = default(SGLParser.variableDefinitionList_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:65:2: ( variableDefinitionList )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:65:5: variableDefinitionList
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableDefinitionList_in_statement101);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:72:1: variableDefinitionList : variableType variableDefinition ( ',' variableDefinition )* -> ( ^( VARDEF variableType variableDefinition ) )+ ;
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
        RewriteRuleTokenStream stream_23 = new RewriteRuleTokenStream(adaptor,"token 23");
        RewriteRuleSubtreeStream stream_variableType = new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableDefinition = new RewriteRuleSubtreeStream(adaptor,"rule variableDefinition");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:2: ( variableType variableDefinition ( ',' variableDefinition )* -> ( ^( VARDEF variableType variableDefinition ) )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:4: variableType variableDefinition ( ',' variableDefinition )*
            {
            	PushFollow(FOLLOW_variableType_in_variableDefinitionList117);
            	variableType4 = variableType();
            	state.followingStackPointer--;

            	stream_variableType.Add(variableType4.Tree);
            	PushFollow(FOLLOW_variableDefinition_in_variableDefinitionList119);
            	variableDefinition5 = variableDefinition();
            	state.followingStackPointer--;

            	stream_variableDefinition.Add(variableDefinition5.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:36: ( ',' variableDefinition )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == 23) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:37: ',' variableDefinition
            			    {
            			    	char_literal6=(IToken)Match(input,23,FOLLOW_23_in_variableDefinitionList122);  
            			    	stream_23.Add(char_literal6);

            			    	PushFollow(FOLLOW_variableDefinition_in_variableDefinitionList124);
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
            	// 73:62: -> ( ^( VARDEF variableType variableDefinition ) )+
            	{
            	    if ( !(stream_variableDefinition.HasNext() || stream_variableType.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_variableDefinition.HasNext() || stream_variableType.HasNext() )
            	    {
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:65: ^( VARDEF variableType variableDefinition )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:76:1: variableDefinition : variableName ( '=' expression )? -> variableName ( expression )? ;
    public SGLParser.variableDefinition_return variableDefinition() // throws RecognitionException [1]
    {   
        SGLParser.variableDefinition_return retval = new SGLParser.variableDefinition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal9 = null;
        SGLParser.variableName_return variableName8 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression10 = default(SGLParser.expression_return);


        object char_literal9_tree=null;
        RewriteRuleTokenStream stream_24 = new RewriteRuleTokenStream(adaptor,"token 24");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:4: variableName ( '=' expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableDefinition148);
            	variableName8 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName8.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:17: ( '=' expression )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == 24) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:18: '=' expression
            	        {
            	        	char_literal9=(IToken)Match(input,24,FOLLOW_24_in_variableDefinition151);  
            	        	stream_24.Add(char_literal9);

            	        	PushFollow(FOLLOW_expression_in_variableDefinition153);
            	        	expression10 = expression();
            	        	state.followingStackPointer--;

            	        	stream_expression.Add(expression10.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          variableName, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 77:36: -> variableName ( expression )?
            	{
            	    adaptor.AddChild(root_0, stream_variableName.NextTree());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:52: ( expression )?
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:80:1: simpleVariableDefinition : variableType ;
    public SGLParser.simpleVariableDefinition_return simpleVariableDefinition() // throws RecognitionException [1]
    {   
        SGLParser.simpleVariableDefinition_return retval = new SGLParser.simpleVariableDefinition_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.variableType_return variableType11 = default(SGLParser.variableType_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:81:2: ( variableType )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:81:4: variableType
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableType_in_simpleVariableDefinition175);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:84:1: localVariableDeclarationStatement : ( 'boolean' variableName ( '=' expression )? | 'int' variableName ( '=' expression )? );
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:2: ( 'boolean' variableName ( '=' expression )? | 'int' variableName ( '=' expression )? )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:5: 'boolean' variableName ( '=' expression )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal12=(IToken)Match(input,BooleanType,FOLLOW_BooleanType_in_localVariableDeclarationStatement187); 
                    		string_literal12_tree = (object)adaptor.Create(string_literal12);
                    		adaptor.AddChild(root_0, string_literal12_tree);

                    	PushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement189);
                    	variableName13 = variableName();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableName13.Tree);
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:28: ( '=' expression )?
                    	int alt4 = 2;
                    	int LA4_0 = input.LA(1);

                    	if ( (LA4_0 == 24) )
                    	{
                    	    alt4 = 1;
                    	}
                    	switch (alt4) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:29: '=' expression
                    	        {
                    	        	char_literal14=(IToken)Match(input,24,FOLLOW_24_in_localVariableDeclarationStatement192); 
                    	        		char_literal14_tree = (object)adaptor.Create(char_literal14);
                    	        		adaptor.AddChild(root_0, char_literal14_tree);

                    	        	PushFollow(FOLLOW_expression_in_localVariableDeclarationStatement194);
                    	        	expression15 = expression();
                    	        	state.followingStackPointer--;

                    	        	adaptor.AddChild(root_0, expression15.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:86:4: 'int' variableName ( '=' expression )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal16=(IToken)Match(input,IntType,FOLLOW_IntType_in_localVariableDeclarationStatement201); 
                    		string_literal16_tree = (object)adaptor.Create(string_literal16);
                    		adaptor.AddChild(root_0, string_literal16_tree);

                    	PushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement203);
                    	variableName17 = variableName();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableName17.Tree);
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:86:23: ( '=' expression )?
                    	int alt5 = 2;
                    	int LA5_0 = input.LA(1);

                    	if ( (LA5_0 == 24) )
                    	{
                    	    alt5 = 1;
                    	}
                    	switch (alt5) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:86:24: '=' expression
                    	        {
                    	        	char_literal18=(IToken)Match(input,24,FOLLOW_24_in_localVariableDeclarationStatement206); 
                    	        		char_literal18_tree = (object)adaptor.Create(char_literal18);
                    	        		adaptor.AddChild(root_0, char_literal18_tree);

                    	        	PushFollow(FOLLOW_expression_in_localVariableDeclarationStatement208);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:90:1: variableAssignmentStatement : variableDeclaration ;
    public SGLParser.variableAssignmentStatement_return variableAssignmentStatement() // throws RecognitionException [1]
    {   
        SGLParser.variableAssignmentStatement_return retval = new SGLParser.variableAssignmentStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.variableDeclaration_return variableDeclaration20 = default(SGLParser.variableDeclaration_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:91:2: ( variableDeclaration )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:91:4: variableDeclaration
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableDeclaration_in_variableAssignmentStatement223);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:99:1: variableDeclaration : variableName ( '=' expression )? ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:100:2: ( variableName ( '=' expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:100:4: variableName ( '=' expression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_variableName_in_variableDeclaration242);
            	variableName21 = variableName();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variableName21.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:100:17: ( '=' expression )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == 24) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:100:18: '=' expression
            	        {
            	        	char_literal22=(IToken)Match(input,24,FOLLOW_24_in_variableDeclaration245); 
            	        		char_literal22_tree = (object)adaptor.Create(char_literal22);
            	        		adaptor.AddChild(root_0, char_literal22_tree);

            	        	PushFollow(FOLLOW_expression_in_variableDeclaration247);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:104:1: variableName : Identifier ;
    public SGLParser.variableName_return variableName() // throws RecognitionException [1]
    {   
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier24 = null;

        object Identifier24_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:105:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:105:4: Identifier
            {
            	root_0 = (object)adaptor.GetNilNode();

            	Identifier24=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableName263); 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:108:1: variableType : ( IntType | BooleanType | StringType | FloatType );
    public SGLParser.variableType_return variableType() // throws RecognitionException [1]
    {   
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set25 = null;

        object set25_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:109:2: ( IntType | BooleanType | StringType | FloatType )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:122:1: expression : conditionalExpression ;
    public SGLParser.expression_return expression() // throws RecognitionException [1]
    {   
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression26 = default(SGLParser.conditionalExpression_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:123:5: ( conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:123:8: conditionalExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalExpression_in_expression327);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:132:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:133:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:133:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression368);
            	conditionalOrExpression27 = conditionalOrExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalOrExpression27.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:133:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == 25) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:133:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	char_literal28=(IToken)Match(input,25,FOLLOW_25_in_conditionalExpression372); 
            	        		char_literal28_tree = (object)adaptor.Create(char_literal28);
            	        		adaptor.AddChild(root_0, char_literal28_tree);

            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression374);
            	        	conditionalExpression29 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression29.Tree);
            	        	char_literal30=(IToken)Match(input,26,FOLLOW_26_in_conditionalExpression376); 
            	        		char_literal30_tree = (object)adaptor.Create(char_literal30);
            	        		adaptor.AddChild(root_0, char_literal30_tree);

            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression377);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:138:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:139:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:139:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression420);
            	conditionalAndExpression32 = conditionalAndExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalAndExpression32.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:139:34: ( '||' conditionalAndExpression )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:139:36: '||' conditionalAndExpression
            			    {
            			    	string_literal33=(IToken)Match(input,27,FOLLOW_27_in_conditionalOrExpression424); 
            			    		string_literal33_tree = (object)adaptor.Create(string_literal33);
            			    		adaptor.AddChild(root_0, string_literal33_tree);

            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression426);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:143:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:144:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:144:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression457);
            	equalityExpression35 = equalityExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, equalityExpression35.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:144:28: ( '&&' equalityExpression )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:144:30: '&&' equalityExpression
            			    {
            			    	string_literal36=(IToken)Match(input,28,FOLLOW_28_in_conditionalAndExpression461); 
            			    		string_literal36_tree = (object)adaptor.Create(string_literal36);
            			    		adaptor.AddChild(root_0, string_literal36_tree);

            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression463);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:148:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public SGLParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set39 = null;
        SGLParser.relationalExpression_return relationalExpression38 = default(SGLParser.relationalExpression_return);

        SGLParser.relationalExpression_return relationalExpression40 = default(SGLParser.relationalExpression_return);


        object set39_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:149:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:149:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression490);
            	relationalExpression38 = relationalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, relationalExpression38.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:149:30: ( ( '==' | '!=' ) relationalExpression )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:149:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	set39 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 29 && input.LA(1) <= 30) ) 
            			    	{
            			    	    input.Consume();
            			    	    adaptor.AddChild(root_0, (object)adaptor.Create(set39));
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression502);
            			    	relationalExpression40 = relationalExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, relationalExpression40.Tree);

            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:153:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public SGLParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set42 = null;
        SGLParser.additiveExpression_return additiveExpression41 = default(SGLParser.additiveExpression_return);

        SGLParser.additiveExpression_return additiveExpression43 = default(SGLParser.additiveExpression_return);


        object set42_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:154:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:154:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression533);
            	additiveExpression41 = additiveExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additiveExpression41.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:154:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:154:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	set42 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= 31 && input.LA(1) <= 34) ) 
            			    	{
            			    	    input.Consume();
            			    	    adaptor.AddChild(root_0, (object)adaptor.Create(set42));
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression546);
            			    	additiveExpression43 = additiveExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, additiveExpression43.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:158:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public SGLParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal45 = null;
        IToken char_literal46 = null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression44 = default(SGLParser.multiplicativeExpression_return);

        SGLParser.multiplicativeExpression_return multiplicativeExpression47 = default(SGLParser.multiplicativeExpression_return);


        object char_literal45_tree=null;
        object char_literal46_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression584);
            	multiplicativeExpression44 = multiplicativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multiplicativeExpression44.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= 35 && LA14_0 <= 36)) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:35: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:35: ( '+' | '-' )
            			    	int alt13 = 2;
            			    	int LA13_0 = input.LA(1);

            			    	if ( (LA13_0 == 35) )
            			    	{
            			    	    alt13 = 1;
            			    	}
            			    	else if ( (LA13_0 == 36) )
            			    	{
            			    	    alt13 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d13s0 =
            			    	        new NoViableAltException("", 13, 0, input);

            			    	    throw nvae_d13s0;
            			    	}
            			    	switch (alt13) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:36: '+'
            			    	        {
            			    	        	char_literal45=(IToken)Match(input,35,FOLLOW_35_in_additiveExpression588); 
            			    	        		char_literal45_tree = (object)adaptor.Create(char_literal45);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal45_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:41: '-'
            			    	        {
            			    	        	char_literal46=(IToken)Match(input,36,FOLLOW_36_in_additiveExpression591); 
            			    	        		char_literal46_tree = (object)adaptor.Create(char_literal46);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal46_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression595);
            			    	multiplicativeExpression47 = multiplicativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multiplicativeExpression47.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:163:1: multiplicativeExpression : e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* ;
    public SGLParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal48 = null;
        IToken char_literal49 = null;
        IToken char_literal50 = null;
        SGLParser.mathAtom_return e = default(SGLParser.mathAtom_return);


        object char_literal48_tree=null;
        object char_literal49_tree=null;
        object char_literal50_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:164:5: (e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:164:9: e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression631);
            	e = mathAtom();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, e.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:165:5: ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            	do 
            	{
            	    int alt15 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 37:
            	    	{
            	        alt15 = 1;
            	        }
            	        break;
            	    case 38:
            	    	{
            	        alt15 = 2;
            	        }
            	        break;
            	    case 39:
            	    	{
            	        alt15 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:165:7: '*' e= mathAtom
            			    {
            			    	char_literal48=(IToken)Match(input,37,FOLLOW_37_in_multiplicativeExpression639); 
            			    		char_literal48_tree = (object)adaptor.Create(char_literal48);
            			    		adaptor.AddChild(root_0, char_literal48_tree);

            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression643);
            			    	e = mathAtom();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, e.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:7: '/' e= mathAtom
            			    {
            			    	char_literal49=(IToken)Match(input,38,FOLLOW_38_in_multiplicativeExpression651); 
            			    		char_literal49_tree = (object)adaptor.Create(char_literal49);
            			    		adaptor.AddChild(root_0, char_literal49_tree);

            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression655);
            			    	e = mathAtom();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, e.Tree);

            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:167:7: '%' e= mathAtom
            			    {
            			    	char_literal50=(IToken)Match(input,39,FOLLOW_39_in_multiplicativeExpression663); 
            			    		char_literal50_tree = (object)adaptor.Create(char_literal50);
            			    		adaptor.AddChild(root_0, char_literal50_tree);

            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression667);
            			    	e = mathAtom();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, e.Tree);

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public SGLParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal51 = null;
        IToken string_literal53 = null;
        SGLParser.unaryExpression_return unaryExpression52 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpression_return unaryExpression54 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus55 = default(SGLParser.unaryExpressionNotPlusMinus_return);


        object string_literal51_tree=null;
        object string_literal53_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:172:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt16 = 3;
            switch ( input.LA(1) ) 
            {
            case 40:
            	{
                alt16 = 1;
                }
                break;
            case 41:
            	{
                alt16 = 2;
                }
                break;
            case IntegerAtom:
            case 36:
            case 42:
            case 43:
            	{
                alt16 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d16s0 =
            	        new NoViableAltException("", 16, 0, input);

            	    throw nvae_d16s0;
            }

            switch (alt16) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:172:7: '++' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal51=(IToken)Match(input,40,FOLLOW_40_in_unaryExpression695); 
                    		string_literal51_tree = (object)adaptor.Create(string_literal51);
                    		adaptor.AddChild(root_0, string_literal51_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression697);
                    	unaryExpression52 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression52.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:173:9: '--' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal53=(IToken)Match(input,41,FOLLOW_41_in_unaryExpression707); 
                    		string_literal53_tree = (object)adaptor.Create(string_literal53);
                    		adaptor.AddChild(root_0, string_literal53_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression709);
                    	unaryExpression54 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression54.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:174:9: unaryExpressionNotPlusMinus
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression719);
                    	unaryExpressionNotPlusMinus55 = unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpressionNotPlusMinus55.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:178:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal56 = null;
        IToken set60 = null;
        SGLParser.unaryExpression_return unaryExpression57 = default(SGLParser.unaryExpression_return);

        SGLParser.castExpression_return castExpression58 = default(SGLParser.castExpression_return);

        SGLParser.mathAtom_return mathAtom59 = default(SGLParser.mathAtom_return);


        object char_literal56_tree=null;
        object set60_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt18 = 3;
            switch ( input.LA(1) ) 
            {
            case 42:
            	{
                alt18 = 1;
                }
                break;
            case 43:
            	{
                int LA18_2 = input.LA(2);

                if ( (LA18_2 == IntegerAtom || LA18_2 == 36 || LA18_2 == 43) )
                {
                    alt18 = 3;
                }
                else if ( ((LA18_2 >= IntType && LA18_2 <= FloatType)) )
                {
                    alt18 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d18s2 =
                        new NoViableAltException("", 18, 2, input);

                    throw nvae_d18s2;
                }
                }
                break;
            case IntegerAtom:
            case 36:
            	{
                alt18 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d18s0 =
            	        new NoViableAltException("", 18, 0, input);

            	    throw nvae_d18s0;
            }

            switch (alt18) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:9: '!' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal56=(IToken)Match(input,42,FOLLOW_42_in_unaryExpressionNotPlusMinus740); 
                    		char_literal56_tree = (object)adaptor.Create(char_literal56);
                    		adaptor.AddChild(root_0, char_literal56_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus742);
                    	unaryExpression57 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression57.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:180:9: castExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus752);
                    	castExpression58 = castExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, castExpression58.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:182:9: mathAtom ( '++' | '--' )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus767);
                    	mathAtom59 = mathAtom();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, mathAtom59.Tree);
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:182:18: ( '++' | '--' )?
                    	int alt17 = 2;
                    	int LA17_0 = input.LA(1);

                    	if ( ((LA17_0 >= 40 && LA17_0 <= 41)) )
                    	{
                    	    alt17 = 1;
                    	}
                    	switch (alt17) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
                    	        {
                    	        	set60 = (IToken)input.LT(1);
                    	        	if ( (input.LA(1) >= 40 && input.LA(1) <= 41) ) 
                    	        	{
                    	        	    input.Consume();
                    	        	    adaptor.AddChild(root_0, (object)adaptor.Create(set60));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:186:1: castExpression : '(' variableType ')' unaryExpression ;
    public SGLParser.castExpression_return castExpression() // throws RecognitionException [1]
    {   
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal61 = null;
        IToken char_literal63 = null;
        SGLParser.variableType_return variableType62 = default(SGLParser.variableType_return);

        SGLParser.unaryExpression_return unaryExpression64 = default(SGLParser.unaryExpression_return);


        object char_literal61_tree=null;
        object char_literal63_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:187:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:187:8: '(' variableType ')' unaryExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal61=(IToken)Match(input,43,FOLLOW_43_in_castExpression800); 
            		char_literal61_tree = (object)adaptor.Create(char_literal61);
            		adaptor.AddChild(root_0, char_literal61_tree);

            	PushFollow(FOLLOW_variableType_in_castExpression802);
            	variableType62 = variableType();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variableType62.Tree);
            	char_literal63=(IToken)Match(input,44,FOLLOW_44_in_castExpression804); 
            		char_literal63_tree = (object)adaptor.Create(char_literal63);
            		adaptor.AddChild(root_0, char_literal63_tree);

            	PushFollow(FOLLOW_unaryExpression_in_castExpression806);
            	unaryExpression64 = unaryExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, unaryExpression64.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:191:1: mathAtom : ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) ;
    public SGLParser.mathAtom_return mathAtom() // throws RecognitionException [1]
    {   
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken i = null;
        IToken char_literal65 = null;
        IToken char_literal66 = null;
        IToken char_literal67 = null;
        SGLParser.additiveExpression_return e = default(SGLParser.additiveExpression_return);


        object i_tree=null;
        object char_literal65_tree=null;
        object char_literal66_tree=null;
        object char_literal67_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:192:5: ( ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:192:9: ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom )
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:192:9: ( '-' )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == 36) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:192:10: '-'
            	        {
            	        	char_literal65=(IToken)Match(input,36,FOLLOW_36_in_mathAtom829); 
            	        		char_literal65_tree = (object)adaptor.Create(char_literal65);
            	        		adaptor.AddChild(root_0, char_literal65_tree);


            	        }
            	        break;

            	}

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:193:5: ( '(' e= additiveExpression ')' | i= IntegerAtom )
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == 43) )
            	{
            	    alt20 = 1;
            	}
            	else if ( (LA20_0 == IntegerAtom) )
            	{
            	    alt20 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d20s0 =
            	        new NoViableAltException("", 20, 0, input);

            	    throw nvae_d20s0;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:193:7: '(' e= additiveExpression ')'
            	        {
            	        	char_literal66=(IToken)Match(input,43,FOLLOW_43_in_mathAtom840); 
            	        		char_literal66_tree = (object)adaptor.Create(char_literal66);
            	        		adaptor.AddChild(root_0, char_literal66_tree);

            	        	PushFollow(FOLLOW_additiveExpression_in_mathAtom844);
            	        	e = additiveExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, e.Tree);
            	        	char_literal67=(IToken)Match(input,44,FOLLOW_44_in_mathAtom846); 
            	        		char_literal67_tree = (object)adaptor.Create(char_literal67);
            	        		adaptor.AddChild(root_0, char_literal67_tree);


            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:194:9: i= IntegerAtom
            	        {
            	        	i=(IToken)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom858); 
            	        		i_tree = (object)adaptor.Create(i);
            	        		adaptor.AddChild(root_0, i_tree);


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:202:1: arguments : '(' ( expressionList )? ')' ;
    public SGLParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal68 = null;
        IToken char_literal70 = null;
        SGLParser.expressionList_return expressionList69 = default(SGLParser.expressionList_return);


        object char_literal68_tree=null;
        object char_literal70_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:9: '(' ( expressionList )? ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal68=(IToken)Match(input,43,FOLLOW_43_in_arguments895); 
            		char_literal68_tree = (object)adaptor.Create(char_literal68);
            		adaptor.AddChild(root_0, char_literal68_tree);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:13: ( expressionList )?
            	int alt21 = 2;
            	int LA21_0 = input.LA(1);

            	if ( (LA21_0 == IntegerAtom || LA21_0 == 36 || LA21_0 == 43) )
            	{
            	    alt21 = 1;
            	}
            	switch (alt21) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:13: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments897);
            	        	expressionList69 = expressionList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expressionList69.Tree);

            	        }
            	        break;

            	}

            	char_literal70=(IToken)Match(input,44,FOLLOW_44_in_arguments900); 
            		char_literal70_tree = (object)adaptor.Create(char_literal70);
            		adaptor.AddChild(root_0, char_literal70_tree);


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:206:1: expressionList : expression ( ',' expression )* ;
    public SGLParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal72 = null;
        SGLParser.expression_return expression71 = default(SGLParser.expression_return);

        SGLParser.expression_return expression73 = default(SGLParser.expression_return);


        object char_literal72_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:207:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:207:9: expression ( ',' expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionList919);
            	expression71 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression71.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:207:20: ( ',' expression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == 23) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:207:21: ',' expression
            			    {
            			    	char_literal72=(IToken)Match(input,23,FOLLOW_23_in_expressionList922); 
            			    		char_literal72_tree = (object)adaptor.Create(char_literal72);
            			    		adaptor.AddChild(root_0, char_literal72_tree);

            			    	PushFollow(FOLLOW_expression_in_expressionList924);
            			    	expression73 = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expression73.Tree);

            			    }
            			    break;

            			default:
            			    goto loop22;
            	    }
            	} while (true);

            	loop22:
            		;	// Stops C# compiler whining that label 'loop22' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:212:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public SGLParser.literal_return literal() // throws RecognitionException [1]
    {   
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set74 = null;

        object set74_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:213:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set74 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == 45 ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set74));
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

 

    public static readonly BitSet FOLLOW_statement_in_compilationUnit83 = new BitSet(new ulong[]{0x00000000000003C0UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit86 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDefinitionList_in_statement101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDefinitionList117 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_variableDefinition_in_variableDefinitionList119 = new BitSet(new ulong[]{0x0000000000800002UL});
    public static readonly BitSet FOLLOW_23_in_variableDefinitionList122 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_variableDefinition_in_variableDefinitionList124 = new BitSet(new ulong[]{0x0000000000800002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDefinition148 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_24_in_variableDefinition151 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_expression_in_variableDefinition153 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_simpleVariableDefinition175 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_localVariableDeclarationStatement187 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_variableName_in_localVariableDeclarationStatement189 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_24_in_localVariableDeclarationStatement192 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_expression_in_localVariableDeclarationStatement194 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_localVariableDeclarationStatement201 = new BitSet(new ulong[]{0x0000000000000020UL});
    public static readonly BitSet FOLLOW_variableName_in_localVariableDeclarationStatement203 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_24_in_localVariableDeclarationStatement206 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_expression_in_localVariableDeclarationStatement208 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_variableAssignmentStatement223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration242 = new BitSet(new ulong[]{0x0000000001000002UL});
    public static readonly BitSet FOLLOW_24_in_variableDeclaration245 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclaration247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName263 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_variableType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression327 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression368 = new BitSet(new ulong[]{0x0000000002000002UL});
    public static readonly BitSet FOLLOW_25_in_conditionalExpression372 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression374 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_26_in_conditionalExpression376 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression420 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_27_in_conditionalOrExpression424 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression426 = new BitSet(new ulong[]{0x0000000008000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression457 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_28_in_conditionalAndExpression461 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression463 = new BitSet(new ulong[]{0x0000000010000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression490 = new BitSet(new ulong[]{0x0000000060000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpression494 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression502 = new BitSet(new ulong[]{0x0000000060000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression533 = new BitSet(new ulong[]{0x0000000780000002UL});
    public static readonly BitSet FOLLOW_set_in_relationalExpression536 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression546 = new BitSet(new ulong[]{0x0000000780000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression584 = new BitSet(new ulong[]{0x0000001800000002UL});
    public static readonly BitSet FOLLOW_35_in_additiveExpression588 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_36_in_additiveExpression591 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression595 = new BitSet(new ulong[]{0x0000001800000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression631 = new BitSet(new ulong[]{0x000000E000000002UL});
    public static readonly BitSet FOLLOW_37_in_multiplicativeExpression639 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression643 = new BitSet(new ulong[]{0x000000E000000002UL});
    public static readonly BitSet FOLLOW_38_in_multiplicativeExpression651 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression655 = new BitSet(new ulong[]{0x000000E000000002UL});
    public static readonly BitSet FOLLOW_39_in_multiplicativeExpression663 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression667 = new BitSet(new ulong[]{0x000000E000000002UL});
    public static readonly BitSet FOLLOW_40_in_unaryExpression695 = new BitSet(new ulong[]{0x00000F1000000400UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression697 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_unaryExpression707 = new BitSet(new ulong[]{0x00000F1000000400UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression709 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression719 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_unaryExpressionNotPlusMinus740 = new BitSet(new ulong[]{0x00000F1000000400UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus752 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus767 = new BitSet(new ulong[]{0x0000030000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus769 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_castExpression800 = new BitSet(new ulong[]{0x00000000000003C0UL});
    public static readonly BitSet FOLLOW_variableType_in_castExpression802 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_castExpression804 = new BitSet(new ulong[]{0x00000F1000000400UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression806 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_mathAtom829 = new BitSet(new ulong[]{0x0000080000000400UL});
    public static readonly BitSet FOLLOW_43_in_mathAtom840 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_mathAtom844 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_mathAtom846 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom858 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_arguments895 = new BitSet(new ulong[]{0x0000181000000400UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments897 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_arguments900 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList919 = new BitSet(new ulong[]{0x0000000000800002UL});
    public static readonly BitSet FOLLOW_23_in_expressionList922 = new BitSet(new ulong[]{0x0000081000000400UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList924 = new BitSet(new ulong[]{0x0000000000800002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}