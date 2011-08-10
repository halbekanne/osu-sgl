// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g 2011-08-10 19:09:05

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

namespace  SGL.AntlrParser 
{
public partial class SGLParser : Parser
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
    public const int T__61 = 61;
    public const int ID_LIST = 8;
    public const int EOF = -1;
    public const int T__60 = 60;
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
    public const int HEX_DIGIT = 30;
    public const int NEGATE = 11;
    public const int BooleanAtom = 22;
    public const int WS = 31;
    public const int T__33 = 33;
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
    public const int OctalEscape = 29;
    public const int Letter = 26;
    public const int EscapeSequence = 25;
    public const int STRING = 13;

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
		get { return "C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g"; }
    }



    	// Error reporting
    	/*
        private StdErrReporter errorReporter = new StdErrReporter();
        public override void EmitErrorMessage(String msg)
        {
        	errorReporter.ReportError(msg);
        }
        */
        
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:77:1: compilationUnit : mainBlock ;
    public SGLParser.compilationUnit_return compilationUnit() // throws RecognitionException [1]
    {   
        SGLParser.compilationUnit_return retval = new SGLParser.compilationUnit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.mainBlock_return mainBlock1 = default(SGLParser.mainBlock_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:78:2: ( mainBlock )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:78:4: mainBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mainBlock_in_compilationUnit119);
            	mainBlock1 = mainBlock();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, mainBlock1.Tree);

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

    public class mainBlock_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mainBlock"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:81:1: mainBlock : ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) ;
    public SGLParser.mainBlock_return mainBlock() // throws RecognitionException [1]
    {   
        SGLParser.mainBlock_return retval = new SGLParser.mainBlock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.mainStatement_return mainStatement2 = default(SGLParser.mainStatement_return);

        SGLParser.methodDef_return methodDef3 = default(SGLParser.methodDef_return);


        RewriteRuleSubtreeStream stream_methodDef = new RewriteRuleSubtreeStream(adaptor,"rule methodDef");
        RewriteRuleSubtreeStream stream_mainStatement = new RewriteRuleSubtreeStream(adaptor,"rule mainStatement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:82:2: ( ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:82:4: ( mainStatement | methodDef )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:82:4: ( mainStatement | methodDef )*
            	do 
            	{
            	    int alt1 = 3;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= Identifier && LA1_0 <= ObjectType) || (LA1_0 >= 41 && LA1_0 <= 42)) )
            	    {
            	        alt1 = 1;
            	    }
            	    else if ( (LA1_0 == 35) )
            	    {
            	        alt1 = 2;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:82:5: mainStatement
            			    {
            			    	PushFollow(FOLLOW_mainStatement_in_mainBlock132);
            			    	mainStatement2 = mainStatement();
            			    	state.followingStackPointer--;

            			    	stream_mainStatement.Add(mainStatement2.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:82:21: methodDef
            			    {
            			    	PushFollow(FOLLOW_methodDef_in_mainBlock136);
            			    	methodDef3 = methodDef();
            			    	state.followingStackPointer--;

            			    	stream_methodDef.Add(methodDef3.Tree);

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements



            	// AST REWRITE
            	// elements:          mainStatement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 83:8: -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:83:11: ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:83:19: ^( STATEMENTS ( mainStatement )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATEMENTS, "STATEMENTS"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:83:32: ( mainStatement )*
            	    while ( stream_mainStatement.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_mainStatement.NextTree());

            	    }
            	    stream_mainStatement.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

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
    // $ANTLR end "mainBlock"

    public class block_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "block"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:86:1: block : ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
    public SGLParser.block_return block() // throws RecognitionException [1]
    {   
        SGLParser.block_return retval = new SGLParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.statement_return statement4 = default(SGLParser.statement_return);


        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:87:2: ( ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:87:4: ( statement )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:87:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= Identifier && LA2_0 <= ObjectType) || (LA2_0 >= 41 && LA2_0 <= 42)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:87:4: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block184);
            			    	statement4 = statement();
            			    	state.followingStackPointer--;

            			    	stream_statement.Add(statement4.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements



            	// AST REWRITE
            	// elements:          statement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 88:3: -> ^( BLOCK ^( STATEMENTS ( statement )* ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:88:6: ^( BLOCK ^( STATEMENTS ( statement )* ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:88:14: ^( STATEMENTS ( statement )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATEMENTS, "STATEMENTS"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:88:27: ( statement )*
            	    while ( stream_statement.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_statement.NextTree());

            	    }
            	    stream_statement.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

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
    // $ANTLR end "block"

    public class singleBlock_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "singleBlock"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:91:1: singleBlock : semicolonStatement -> ^( BLOCK ^( STATEMENTS semicolonStatement ) ) ;
    public SGLParser.singleBlock_return singleBlock() // throws RecognitionException [1]
    {   
        SGLParser.singleBlock_return retval = new SGLParser.singleBlock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement5 = default(SGLParser.semicolonStatement_return);


        RewriteRuleSubtreeStream stream_semicolonStatement = new RewriteRuleSubtreeStream(adaptor,"rule semicolonStatement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:92:2: ( semicolonStatement -> ^( BLOCK ^( STATEMENTS semicolonStatement ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:92:4: semicolonStatement
            {
            	PushFollow(FOLLOW_semicolonStatement_in_singleBlock212);
            	semicolonStatement5 = semicolonStatement();
            	state.followingStackPointer--;

            	stream_semicolonStatement.Add(semicolonStatement5.Tree);


            	// AST REWRITE
            	// elements:          semicolonStatement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 93:3: -> ^( BLOCK ^( STATEMENTS semicolonStatement ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:93:6: ^( BLOCK ^( STATEMENTS semicolonStatement ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:93:14: ^( STATEMENTS semicolonStatement )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATEMENTS, "STATEMENTS"), root_2);

            	    adaptor.AddChild(root_2, stream_semicolonStatement.NextTree());

            	    adaptor.AddChild(root_1, root_2);
            	    }

            	    adaptor.AddChild(root_0, root_1);
            	    }

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
    // $ANTLR end "singleBlock"

    public class commonBlock_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "commonBlock"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:96:1: commonBlock : ( singleBlock | '{' block '}' );
    public SGLParser.commonBlock_return commonBlock() // throws RecognitionException [1]
    {   
        SGLParser.commonBlock_return retval = new SGLParser.commonBlock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal7 = null;
        IToken char_literal9 = null;
        SGLParser.singleBlock_return singleBlock6 = default(SGLParser.singleBlock_return);

        SGLParser.block_return block8 = default(SGLParser.block_return);


        object char_literal7_tree=null;
        object char_literal9_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:97:2: ( singleBlock | '{' block '}' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= Identifier && LA3_0 <= ObjectType)) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == 33) )
            {
                alt3 = 2;
            }
            else 
            {
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:97:4: singleBlock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_singleBlock_in_commonBlock238);
                    	singleBlock6 = singleBlock();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, singleBlock6.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:98:4: '{' block '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal7=(IToken)Match(input,33,FOLLOW_33_in_commonBlock243); 
                    	PushFollow(FOLLOW_block_in_commonBlock246);
                    	block8 = block();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block8.Tree);
                    	char_literal9=(IToken)Match(input,34,FOLLOW_34_in_commonBlock248); 

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
    // $ANTLR end "commonBlock"

    public class methodDef_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "methodDef"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:102:1: methodDef : 'method' Identifier '(' ( idList )? ')' ;
    public SGLParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        SGLParser.methodDef_return retval = new SGLParser.methodDef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal10 = null;
        IToken Identifier11 = null;
        IToken char_literal12 = null;
        IToken char_literal14 = null;
        SGLParser.idList_return idList13 = default(SGLParser.idList_return);


        object string_literal10_tree=null;
        object Identifier11_tree=null;
        object char_literal12_tree=null;
        object char_literal14_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:103:3: ( 'method' Identifier '(' ( idList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:103:5: 'method' Identifier '(' ( idList )? ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal10=(IToken)Match(input,35,FOLLOW_35_in_methodDef282); 
            		string_literal10_tree = (object)adaptor.Create(string_literal10);
            		adaptor.AddChild(root_0, string_literal10_tree);

            	Identifier11=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodDef284); 
            		Identifier11_tree = (object)adaptor.Create(Identifier11);
            		adaptor.AddChild(root_0, Identifier11_tree);

            	char_literal12=(IToken)Match(input,36,FOLLOW_36_in_methodDef286); 
            		char_literal12_tree = (object)adaptor.Create(char_literal12);
            		adaptor.AddChild(root_0, char_literal12_tree);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:103:29: ( idList )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == Identifier) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:103:29: idList
            	        {
            	        	PushFollow(FOLLOW_idList_in_methodDef288);
            	        	idList13 = idList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, idList13.Tree);

            	        }
            	        break;

            	}

            	char_literal14=(IToken)Match(input,37,FOLLOW_37_in_methodDef291); 
            		char_literal14_tree = (object)adaptor.Create(char_literal14);
            		adaptor.AddChild(root_0, char_literal14_tree);

            	 /* implemented later */ 

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
    // $ANTLR end "methodDef"

    public class mainStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "mainStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:107:1: mainStatement : statement ;
    public SGLParser.mainStatement_return mainStatement() // throws RecognitionException [1]
    {   
        SGLParser.mainStatement_return retval = new SGLParser.mainStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.statement_return statement15 = default(SGLParser.statement_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:108:2: ( statement )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:108:4: statement
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_statement_in_mainStatement320);
            	statement15 = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, statement15.Tree);

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
    // $ANTLR end "mainStatement"

    public class semicolonStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "semicolonStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:111:1: semicolonStatement : ( variableDeclarationList | variableAssignment ) ';' ;
    public SGLParser.semicolonStatement_return semicolonStatement() // throws RecognitionException [1]
    {   
        SGLParser.semicolonStatement_return retval = new SGLParser.semicolonStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal18 = null;
        SGLParser.variableDeclarationList_return variableDeclarationList16 = default(SGLParser.variableDeclarationList_return);

        SGLParser.variableAssignment_return variableAssignment17 = default(SGLParser.variableAssignment_return);


        object char_literal18_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:112:2: ( ( variableDeclarationList | variableAssignment ) ';' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:112:4: ( variableDeclarationList | variableAssignment ) ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:112:4: ( variableDeclarationList | variableAssignment )
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( ((LA5_0 >= IntType && LA5_0 <= ObjectType)) )
            	{
            	    alt5 = 1;
            	}
            	else if ( (LA5_0 == Identifier) )
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
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:112:5: variableDeclarationList
            	        {
            	        	PushFollow(FOLLOW_variableDeclarationList_in_semicolonStatement333);
            	        	variableDeclarationList16 = variableDeclarationList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variableDeclarationList16.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:113:4: variableAssignment
            	        {
            	        	PushFollow(FOLLOW_variableAssignment_in_semicolonStatement339);
            	        	variableAssignment17 = variableAssignment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variableAssignment17.Tree);

            	        }
            	        break;

            	}

            	char_literal18=(IToken)Match(input,38,FOLLOW_38_in_semicolonStatement345); 

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
    // $ANTLR end "semicolonStatement"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:118:1: statement : ( semicolonStatement | ifStatement | whileLoop );
    public SGLParser.statement_return statement() // throws RecognitionException [1]
    {   
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement19 = default(SGLParser.semicolonStatement_return);

        SGLParser.ifStatement_return ifStatement20 = default(SGLParser.ifStatement_return);

        SGLParser.whileLoop_return whileLoop21 = default(SGLParser.whileLoop_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:120:2: ( semicolonStatement | ifStatement | whileLoop )
            int alt6 = 3;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            case IntType:
            case BooleanType:
            case StringType:
            case FloatType:
            case ObjectType:
            	{
                alt6 = 1;
                }
                break;
            case 42:
            	{
                alt6 = 2;
                }
                break;
            case 41:
            	{
                alt6 = 3;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:120:4: semicolonStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_semicolonStatement_in_statement361);
                    	semicolonStatement19 = semicolonStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, semicolonStatement19.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:121:4: ifStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statement366);
                    	ifStatement20 = ifStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ifStatement20.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:4: whileLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileLoop_in_statement371);
                    	whileLoop21 = whileLoop();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, whileLoop21.Tree);

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
    // $ANTLR end "statement"

    public class variableDeclarationList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableDeclarationList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:129:1: variableDeclarationList : variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( VARDEF variableType variableDecAssignment ) )+ ;
    public SGLParser.variableDeclarationList_return variableDeclarationList() // throws RecognitionException [1]
    {   
        SGLParser.variableDeclarationList_return retval = new SGLParser.variableDeclarationList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal24 = null;
        SGLParser.variableType_return variableType22 = default(SGLParser.variableType_return);

        SGLParser.variableDecAssignment_return variableDecAssignment23 = default(SGLParser.variableDecAssignment_return);

        SGLParser.variableDecAssignment_return variableDecAssignment25 = default(SGLParser.variableDecAssignment_return);


        object char_literal24_tree=null;
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleSubtreeStream stream_variableType = new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableDecAssignment = new RewriteRuleSubtreeStream(adaptor,"rule variableDecAssignment");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:130:2: ( variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( VARDEF variableType variableDecAssignment ) )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:130:4: variableType variableDecAssignment ( ',' variableDecAssignment )*
            {
            	PushFollow(FOLLOW_variableType_in_variableDeclarationList387);
            	variableType22 = variableType();
            	state.followingStackPointer--;

            	stream_variableType.Add(variableType22.Tree);
            	PushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList389);
            	variableDecAssignment23 = variableDecAssignment();
            	state.followingStackPointer--;

            	stream_variableDecAssignment.Add(variableDecAssignment23.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:130:39: ( ',' variableDecAssignment )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( (LA7_0 == 39) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:130:40: ',' variableDecAssignment
            			    {
            			    	char_literal24=(IToken)Match(input,39,FOLLOW_39_in_variableDeclarationList392);  
            			    	stream_39.Add(char_literal24);

            			    	PushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList394);
            			    	variableDecAssignment25 = variableDecAssignment();
            			    	state.followingStackPointer--;

            			    	stream_variableDecAssignment.Add(variableDecAssignment25.Tree);

            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements



            	// AST REWRITE
            	// elements:          variableDecAssignment, variableType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 130:68: -> ( ^( VARDEF variableType variableDecAssignment ) )+
            	{
            	    if ( !(stream_variableDecAssignment.HasNext() || stream_variableType.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_variableDecAssignment.HasNext() || stream_variableType.HasNext() )
            	    {
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:130:71: ^( VARDEF variableType variableDecAssignment )
            	        {
            	        object root_1 = (object)adaptor.GetNilNode();
            	        root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDEF, "VARDEF"), root_1);

            	        adaptor.AddChild(root_1, stream_variableType.NextTree());
            	        adaptor.AddChild(root_1, stream_variableDecAssignment.NextTree());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_variableDecAssignment.Reset();
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
    // $ANTLR end "variableDeclarationList"

    public class variableDecAssignment_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableDecAssignment"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:133:1: variableDecAssignment : variableName ( '=' expression )? -> variableName ( expression )? ;
    public SGLParser.variableDecAssignment_return variableDecAssignment() // throws RecognitionException [1]
    {   
        SGLParser.variableDecAssignment_return retval = new SGLParser.variableDecAssignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal27 = null;
        SGLParser.variableName_return variableName26 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression28 = default(SGLParser.expression_return);


        object char_literal27_tree=null;
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:4: variableName ( '=' expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableDecAssignment418);
            	variableName26 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName26.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:17: ( '=' expression )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == 40) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:18: '=' expression
            	        {
            	        	char_literal27=(IToken)Match(input,40,FOLLOW_40_in_variableDecAssignment421);  
            	        	stream_40.Add(char_literal27);

            	        	PushFollow(FOLLOW_expression_in_variableDecAssignment423);
            	        	expression28 = expression();
            	        	state.followingStackPointer--;

            	        	stream_expression.Add(expression28.Tree);

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
            	// 134:36: -> variableName ( expression )?
            	{
            	    adaptor.AddChild(root_0, stream_variableName.NextTree());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:52: ( expression )?
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
    // $ANTLR end "variableDecAssignment"

    public class variableAssignment_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableAssignment"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:137:1: variableAssignment : variableName '=' expression -> ^( ASSIGN variableName expression ) ;
    public SGLParser.variableAssignment_return variableAssignment() // throws RecognitionException [1]
    {   
        SGLParser.variableAssignment_return retval = new SGLParser.variableAssignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal30 = null;
        SGLParser.variableName_return variableName29 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression31 = default(SGLParser.expression_return);


        object char_literal30_tree=null;
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:138:2: ( variableName '=' expression -> ^( ASSIGN variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:138:4: variableName '=' expression
            {
            	PushFollow(FOLLOW_variableName_in_variableAssignment444);
            	variableName29 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName29.Tree);
            	char_literal30=(IToken)Match(input,40,FOLLOW_40_in_variableAssignment446);  
            	stream_40.Add(char_literal30);

            	PushFollow(FOLLOW_expression_in_variableAssignment448);
            	expression31 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression31.Tree);


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
            	// 138:33: -> ^( ASSIGN variableName expression )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:138:36: ^( ASSIGN variableName expression )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASSIGN, "ASSIGN"), root_1);

            	    adaptor.AddChild(root_1, stream_variableName.NextTree());
            	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

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
    // $ANTLR end "variableAssignment"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:146:1: variableName : Identifier ;
    public SGLParser.variableName_return variableName() // throws RecognitionException [1]
    {   
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier32 = null;

        object Identifier32_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:147:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:147:4: Identifier
            {
            	root_0 = (object)adaptor.GetNilNode();

            	Identifier32=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableName479); 
            		Identifier32_tree = (object)adaptor.Create(Identifier32);
            		adaptor.AddChild(root_0, Identifier32_tree);


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:150:1: variableType : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public SGLParser.variableType_return variableType() // throws RecognitionException [1]
    {   
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set33 = null;

        object set33_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:151:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set33 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntType && input.LA(1) <= ObjectType) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set33));
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

    public class whileLoop_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "whileLoop"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:159:1: whileLoop : 'while' '(' expression ')' commonBlock -> ^( 'while' expression commonBlock ) ;
    public SGLParser.whileLoop_return whileLoop() // throws RecognitionException [1]
    {   
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal34 = null;
        IToken char_literal35 = null;
        IToken char_literal37 = null;
        SGLParser.expression_return expression36 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock38 = default(SGLParser.commonBlock_return);


        object string_literal34_tree=null;
        object char_literal35_tree=null;
        object char_literal37_tree=null;
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_36 = new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleTokenStream stream_37 = new RewriteRuleTokenStream(adaptor,"token 37");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:160:2: ( 'while' '(' expression ')' commonBlock -> ^( 'while' expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:160:4: 'while' '(' expression ')' commonBlock
            {
            	string_literal34=(IToken)Match(input,41,FOLLOW_41_in_whileLoop523);  
            	stream_41.Add(string_literal34);

            	char_literal35=(IToken)Match(input,36,FOLLOW_36_in_whileLoop525);  
            	stream_36.Add(char_literal35);

            	PushFollow(FOLLOW_expression_in_whileLoop527);
            	expression36 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression36.Tree);
            	char_literal37=(IToken)Match(input,37,FOLLOW_37_in_whileLoop529);  
            	stream_37.Add(char_literal37);

            	PushFollow(FOLLOW_commonBlock_in_whileLoop531);
            	commonBlock38 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock38.Tree);


            	// AST REWRITE
            	// elements:          expression, 41, commonBlock
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 160:43: -> ^( 'while' expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:160:46: ^( 'while' expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_41.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    adaptor.AddChild(root_1, stream_commonBlock.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

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
    // $ANTLR end "whileLoop"

    public class ifStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ifStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:163:1: ifStatement : ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) ;
    public SGLParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        SGLParser.ifStatement_return retval = new SGLParser.ifStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.ifStat_return ifStat39 = default(SGLParser.ifStat_return);

        SGLParser.elseIfStat_return elseIfStat40 = default(SGLParser.elseIfStat_return);

        SGLParser.elseStat_return elseStat41 = default(SGLParser.elseStat_return);


        RewriteRuleSubtreeStream stream_elseIfStat = new RewriteRuleSubtreeStream(adaptor,"rule elseIfStat");
        RewriteRuleSubtreeStream stream_ifStat = new RewriteRuleSubtreeStream(adaptor,"rule ifStat");
        RewriteRuleSubtreeStream stream_elseStat = new RewriteRuleSubtreeStream(adaptor,"rule elseStat");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:2: ( ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:4: ifStat ( elseIfStat )* ( elseStat )?
            {
            	PushFollow(FOLLOW_ifStat_in_ifStatement552);
            	ifStat39 = ifStat();
            	state.followingStackPointer--;

            	stream_ifStat.Add(ifStat39.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:11: ( elseIfStat )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 43) )
            	    {
            	        int LA9_1 = input.LA(2);

            	        if ( (LA9_1 == 42) )
            	        {
            	            alt9 = 1;
            	        }


            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:11: elseIfStat
            			    {
            			    	PushFollow(FOLLOW_elseIfStat_in_ifStatement554);
            			    	elseIfStat40 = elseIfStat();
            			    	state.followingStackPointer--;

            			    	stream_elseIfStat.Add(elseIfStat40.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:23: ( elseStat )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == 43) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:23: elseStat
            	        {
            	        	PushFollow(FOLLOW_elseStat_in_ifStatement557);
            	        	elseStat41 = elseStat();
            	        	state.followingStackPointer--;

            	        	stream_elseStat.Add(elseStat41.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          ifStat, elseStat, elseIfStat
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 164:33: -> ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:36: ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF, "IF"), root_1);

            	    adaptor.AddChild(root_1, stream_ifStat.NextTree());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:48: ( elseIfStat )*
            	    while ( stream_elseIfStat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_elseIfStat.NextTree());

            	    }
            	    stream_elseIfStat.Reset();
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:60: ( elseStat )?
            	    if ( stream_elseStat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_elseStat.NextTree());

            	    }
            	    stream_elseStat.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

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
    // $ANTLR end "ifStatement"

    public class ifStat_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "ifStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:166:1: ifStat : 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.ifStat_return ifStat() // throws RecognitionException [1]
    {   
        SGLParser.ifStat_return retval = new SGLParser.ifStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal42 = null;
        SGLParser.expression_return expression43 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock44 = default(SGLParser.commonBlock_return);


        object string_literal42_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:167:2: ( 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:167:4: 'if' expression commonBlock
            {
            	string_literal42=(IToken)Match(input,42,FOLLOW_42_in_ifStat582);  
            	stream_42.Add(string_literal42);

            	PushFollow(FOLLOW_expression_in_ifStat584);
            	expression43 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression43.Tree);
            	PushFollow(FOLLOW_commonBlock_in_ifStat586);
            	commonBlock44 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock44.Tree);


            	// AST REWRITE
            	// elements:          commonBlock, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 167:32: -> ^( EXP expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:167:35: ^( EXP expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXP, "EXP"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    adaptor.AddChild(root_1, stream_commonBlock.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

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
    // $ANTLR end "ifStat"

    public class elseIfStat_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "elseIfStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:170:1: elseIfStat : 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.elseIfStat_return elseIfStat() // throws RecognitionException [1]
    {   
        SGLParser.elseIfStat_return retval = new SGLParser.elseIfStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal45 = null;
        IToken string_literal46 = null;
        SGLParser.expression_return expression47 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock48 = default(SGLParser.commonBlock_return);


        object string_literal45_tree=null;
        object string_literal46_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:171:2: ( 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:171:4: 'else' 'if' expression commonBlock
            {
            	string_literal45=(IToken)Match(input,43,FOLLOW_43_in_elseIfStat607);  
            	stream_43.Add(string_literal45);

            	string_literal46=(IToken)Match(input,42,FOLLOW_42_in_elseIfStat609);  
            	stream_42.Add(string_literal46);

            	PushFollow(FOLLOW_expression_in_elseIfStat611);
            	expression47 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression47.Tree);
            	PushFollow(FOLLOW_commonBlock_in_elseIfStat613);
            	commonBlock48 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock48.Tree);


            	// AST REWRITE
            	// elements:          commonBlock, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 171:39: -> ^( EXP expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:171:42: ^( EXP expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXP, "EXP"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    adaptor.AddChild(root_1, stream_commonBlock.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

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
    // $ANTLR end "elseIfStat"

    public class elseStat_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "elseStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:1: elseStat : 'else' commonBlock -> ^( EXP commonBlock ) ;
    public SGLParser.elseStat_return elseStat() // throws RecognitionException [1]
    {   
        SGLParser.elseStat_return retval = new SGLParser.elseStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal49 = null;
        SGLParser.commonBlock_return commonBlock50 = default(SGLParser.commonBlock_return);


        object string_literal49_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:175:2: ( 'else' commonBlock -> ^( EXP commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:175:4: 'else' commonBlock
            {
            	string_literal49=(IToken)Match(input,43,FOLLOW_43_in_elseStat635);  
            	stream_43.Add(string_literal49);

            	PushFollow(FOLLOW_commonBlock_in_elseStat637);
            	commonBlock50 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock50.Tree);


            	// AST REWRITE
            	// elements:          commonBlock
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 175:23: -> ^( EXP commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:175:26: ^( EXP commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXP, "EXP"), root_1);

            	    adaptor.AddChild(root_1, stream_commonBlock.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

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
    // $ANTLR end "elseStat"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:201:1: expression : conditionalExpression ;
    public SGLParser.expression_return expression() // throws RecognitionException [1]
    {   
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression51 = default(SGLParser.conditionalExpression_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:202:5: ( conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:202:8: conditionalExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalExpression_in_expression700);
            	conditionalExpression51 = conditionalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalExpression51.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:211:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public SGLParser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal53 = null;
        IToken char_literal55 = null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression52 = default(SGLParser.conditionalOrExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression54 = default(SGLParser.conditionalExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression56 = default(SGLParser.conditionalExpression_return);


        object char_literal53_tree=null;
        object char_literal55_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:212:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:212:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression741);
            	conditionalOrExpression52 = conditionalOrExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalOrExpression52.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:212:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 44) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:212:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	char_literal53=(IToken)Match(input,44,FOLLOW_44_in_conditionalExpression745); 
            	        		char_literal53_tree = (object)adaptor.Create(char_literal53);
            	        		root_0 = (object)adaptor.BecomeRoot(char_literal53_tree, root_0);

            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression748);
            	        	conditionalExpression54 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression54.Tree);
            	        	char_literal55=(IToken)Match(input,45,FOLLOW_45_in_conditionalExpression750); 
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression753);
            	        	conditionalExpression56 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression56.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:217:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public SGLParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal58 = null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression57 = default(SGLParser.conditionalAndExpression_return);

        SGLParser.conditionalAndExpression_return conditionalAndExpression59 = default(SGLParser.conditionalAndExpression_return);


        object string_literal58_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:218:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:218:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression796);
            	conditionalAndExpression57 = conditionalAndExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalAndExpression57.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:218:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == 46) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:218:36: '||' conditionalAndExpression
            			    {
            			    	string_literal58=(IToken)Match(input,46,FOLLOW_46_in_conditionalOrExpression800); 
            			    		string_literal58_tree = (object)adaptor.Create(string_literal58);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal58_tree, root_0);

            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression803);
            			    	conditionalAndExpression59 = conditionalAndExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, conditionalAndExpression59.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:222:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public SGLParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal61 = null;
        SGLParser.equalityExpression_return equalityExpression60 = default(SGLParser.equalityExpression_return);

        SGLParser.equalityExpression_return equalityExpression62 = default(SGLParser.equalityExpression_return);


        object string_literal61_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression834);
            	equalityExpression60 = equalityExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, equalityExpression60.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == 47) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:30: '&&' equalityExpression
            			    {
            			    	string_literal61=(IToken)Match(input,47,FOLLOW_47_in_conditionalAndExpression838); 
            			    		string_literal61_tree = (object)adaptor.Create(string_literal61);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal61_tree, root_0);

            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression841);
            			    	equalityExpression62 = equalityExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, equalityExpression62.Tree);

            			    }
            			    break;

            			default:
            			    goto loop13;
            	    }
            	} while (true);

            	loop13:
            		;	// Stops C# compiler whining that label 'loop13' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:227:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public SGLParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal64 = null;
        IToken string_literal65 = null;
        SGLParser.relationalExpression_return relationalExpression63 = default(SGLParser.relationalExpression_return);

        SGLParser.relationalExpression_return relationalExpression66 = default(SGLParser.relationalExpression_return);


        object string_literal64_tree=null;
        object string_literal65_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression868);
            	relationalExpression63 = relationalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, relationalExpression63.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( ((LA15_0 >= 48 && LA15_0 <= 49)) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:32: ( '==' | '!=' )
            			    	int alt14 = 2;
            			    	int LA14_0 = input.LA(1);

            			    	if ( (LA14_0 == 48) )
            			    	{
            			    	    alt14 = 1;
            			    	}
            			    	else if ( (LA14_0 == 49) )
            			    	{
            			    	    alt14 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d14s0 =
            			    	        new NoViableAltException("", 14, 0, input);

            			    	    throw nvae_d14s0;
            			    	}
            			    	switch (alt14) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:33: '=='
            			    	        {
            			    	        	string_literal64=(IToken)Match(input,48,FOLLOW_48_in_equalityExpression873); 
            			    	        		string_literal64_tree = (object)adaptor.Create(string_literal64);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal64_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:41: '!='
            			    	        {
            			    	        	string_literal65=(IToken)Match(input,49,FOLLOW_49_in_equalityExpression878); 
            			    	        		string_literal65_tree = (object)adaptor.Create(string_literal65);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal65_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression882);
            			    	relationalExpression66 = relationalExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, relationalExpression66.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:232:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public SGLParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal68 = null;
        IToken char_literal69 = null;
        IToken string_literal70 = null;
        IToken string_literal71 = null;
        SGLParser.additiveExpression_return additiveExpression67 = default(SGLParser.additiveExpression_return);

        SGLParser.additiveExpression_return additiveExpression72 = default(SGLParser.additiveExpression_return);


        object char_literal68_tree=null;
        object char_literal69_tree=null;
        object string_literal70_tree=null;
        object string_literal71_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression913);
            	additiveExpression67 = additiveExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additiveExpression67.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( ((LA17_0 >= 50 && LA17_0 <= 53)) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:29: ( '<' | '>' | '<=' | '>=' )
            			    	int alt16 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 50:
            			    		{
            			    	    alt16 = 1;
            			    	    }
            			    	    break;
            			    	case 51:
            			    		{
            			    	    alt16 = 2;
            			    	    }
            			    	    break;
            			    	case 52:
            			    		{
            			    	    alt16 = 3;
            			    	    }
            			    	    break;
            			    	case 53:
            			    		{
            			    	    alt16 = 4;
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:30: '<'
            			    	        {
            			    	        	char_literal68=(IToken)Match(input,50,FOLLOW_50_in_relationalExpression917); 
            			    	        		char_literal68_tree = (object)adaptor.Create(char_literal68);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal68_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:35: '>'
            			    	        {
            			    	        	char_literal69=(IToken)Match(input,51,FOLLOW_51_in_relationalExpression920); 
            			    	        		char_literal69_tree = (object)adaptor.Create(char_literal69);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal69_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:40: '<='
            			    	        {
            			    	        	string_literal70=(IToken)Match(input,52,FOLLOW_52_in_relationalExpression923); 
            			    	        		string_literal70_tree = (object)adaptor.Create(string_literal70);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal70_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:46: '>='
            			    	        {
            			    	        	string_literal71=(IToken)Match(input,53,FOLLOW_53_in_relationalExpression926); 
            			    	        		string_literal71_tree = (object)adaptor.Create(string_literal71);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal71_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression930);
            			    	additiveExpression72 = additiveExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, additiveExpression72.Tree);

            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:237:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public SGLParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal74 = null;
        IToken char_literal75 = null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression73 = default(SGLParser.multiplicativeExpression_return);

        SGLParser.multiplicativeExpression_return multiplicativeExpression76 = default(SGLParser.multiplicativeExpression_return);


        object char_literal74_tree=null;
        object char_literal75_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression968);
            	multiplicativeExpression73 = multiplicativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multiplicativeExpression73.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt19 = 2;
            	    int LA19_0 = input.LA(1);

            	    if ( ((LA19_0 >= 54 && LA19_0 <= 55)) )
            	    {
            	        alt19 = 1;
            	    }


            	    switch (alt19) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:35: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:35: ( '+' | '-' )
            			    	int alt18 = 2;
            			    	int LA18_0 = input.LA(1);

            			    	if ( (LA18_0 == 54) )
            			    	{
            			    	    alt18 = 1;
            			    	}
            			    	else if ( (LA18_0 == 55) )
            			    	{
            			    	    alt18 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d18s0 =
            			    	        new NoViableAltException("", 18, 0, input);

            			    	    throw nvae_d18s0;
            			    	}
            			    	switch (alt18) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:36: '+'
            			    	        {
            			    	        	char_literal74=(IToken)Match(input,54,FOLLOW_54_in_additiveExpression972); 
            			    	        		char_literal74_tree = (object)adaptor.Create(char_literal74);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal74_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:41: '-'
            			    	        {
            			    	        	char_literal75=(IToken)Match(input,55,FOLLOW_55_in_additiveExpression975); 
            			    	        		char_literal75_tree = (object)adaptor.Create(char_literal75);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal75_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression979);
            			    	multiplicativeExpression76 = multiplicativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multiplicativeExpression76.Tree);

            			    }
            			    break;

            			default:
            			    goto loop19;
            	    }
            	} while (true);

            	loop19:
            		;	// Stops C# compiler whining that label 'loop19' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:1: multiplicativeExpression : negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* ;
    public SGLParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal78 = null;
        IToken char_literal79 = null;
        IToken char_literal80 = null;
        SGLParser.negativeExpression_return negativeExpression77 = default(SGLParser.negativeExpression_return);

        SGLParser.negativeExpression_return negativeExpression81 = default(SGLParser.negativeExpression_return);


        object char_literal78_tree=null;
        object char_literal79_tree=null;
        object char_literal80_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:243:5: ( negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:243:9: negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression1013);
            	negativeExpression77 = negativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, negativeExpression77.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:5: ( ( '*' | '/' | '%' ) negativeExpression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( ((LA21_0 >= 56 && LA21_0 <= 58)) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:6: ( '*' | '/' | '%' ) negativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:6: ( '*' | '/' | '%' )
            			    	int alt20 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 56:
            			    		{
            			    	    alt20 = 1;
            			    	    }
            			    	    break;
            			    	case 57:
            			    		{
            			    	    alt20 = 2;
            			    	    }
            			    	    break;
            			    	case 58:
            			    		{
            			    	    alt20 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d20s0 =
            			    		        new NoViableAltException("", 20, 0, input);

            			    		    throw nvae_d20s0;
            			    	}

            			    	switch (alt20) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:7: '*'
            			    	        {
            			    	        	char_literal78=(IToken)Match(input,56,FOLLOW_56_in_multiplicativeExpression1021); 
            			    	        		char_literal78_tree = (object)adaptor.Create(char_literal78);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal78_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:12: '/'
            			    	        {
            			    	        	char_literal79=(IToken)Match(input,57,FOLLOW_57_in_multiplicativeExpression1024); 
            			    	        		char_literal79_tree = (object)adaptor.Create(char_literal79);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal79_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:17: '%'
            			    	        {
            			    	        	char_literal80=(IToken)Match(input,58,FOLLOW_58_in_multiplicativeExpression1027); 
            			    	        		char_literal80_tree = (object)adaptor.Create(char_literal80);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal80_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression1031);
            			    	negativeExpression81 = negativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, negativeExpression81.Tree);

            			    }
            			    break;

            			default:
            			    goto loop21;
            	    }
            	} while (true);

            	loop21:
            		;	// Stops C# compiler whining that label 'loop21' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public SGLParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal82 = null;
        IToken string_literal84 = null;
        SGLParser.unaryExpression_return unaryExpression83 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpression_return unaryExpression85 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus86 = default(SGLParser.unaryExpressionNotPlusMinus_return);


        object string_literal82_tree=null;
        object string_literal84_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt22 = 3;
            switch ( input.LA(1) ) 
            {
            case 59:
            	{
                alt22 = 1;
                }
                break;
            case 60:
            	{
                alt22 = 2;
                }
                break;
            case Identifier:
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case StringAtom:
            case 36:
            case 61:
            case 62:
            	{
                alt22 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d22s0 =
            	        new NoViableAltException("", 22, 0, input);

            	    throw nvae_d22s0;
            }

            switch (alt22) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:7: '++' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal82=(IToken)Match(input,59,FOLLOW_59_in_unaryExpression1054); 
                    		string_literal82_tree = (object)adaptor.Create(string_literal82);
                    		adaptor.AddChild(root_0, string_literal82_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1056);
                    	unaryExpression83 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression83.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:249:9: '--' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal84=(IToken)Match(input,60,FOLLOW_60_in_unaryExpression1066); 
                    		string_literal84_tree = (object)adaptor.Create(string_literal84);
                    		adaptor.AddChild(root_0, string_literal84_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1068);
                    	unaryExpression85 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression85.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:250:9: unaryExpressionNotPlusMinus
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1078);
                    	unaryExpressionNotPlusMinus86 = unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpressionNotPlusMinus86.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:254:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal87 = null;
        IToken set91 = null;
        SGLParser.unaryExpression_return unaryExpression88 = default(SGLParser.unaryExpression_return);

        SGLParser.castExpression_return castExpression89 = default(SGLParser.castExpression_return);

        SGLParser.mathAtom_return mathAtom90 = default(SGLParser.mathAtom_return);


        object char_literal87_tree=null;
        object set91_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:255:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt24 = 3;
            switch ( input.LA(1) ) 
            {
            case 61:
            	{
                alt24 = 1;
                }
                break;
            case 36:
            	{
                int LA24_2 = input.LA(2);

                if ( (LA24_2 == Identifier || (LA24_2 >= IntegerAtom && LA24_2 <= BooleanAtom) || LA24_2 == StringAtom || LA24_2 == 36 || LA24_2 == 55 || LA24_2 == 62) )
                {
                    alt24 = 3;
                }
                else if ( ((LA24_2 >= IntType && LA24_2 <= ObjectType)) )
                {
                    alt24 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d24s2 =
                        new NoViableAltException("", 24, 2, input);

                    throw nvae_d24s2;
                }
                }
                break;
            case Identifier:
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case StringAtom:
            case 62:
            	{
                alt24 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d24s0 =
            	        new NoViableAltException("", 24, 0, input);

            	    throw nvae_d24s0;
            }

            switch (alt24) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:255:9: '!' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal87=(IToken)Match(input,61,FOLLOW_61_in_unaryExpressionNotPlusMinus1099); 
                    		char_literal87_tree = (object)adaptor.Create(char_literal87);
                    		adaptor.AddChild(root_0, char_literal87_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1101);
                    	unaryExpression88 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression88.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:256:9: castExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus1111);
                    	castExpression89 = castExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, castExpression89.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:258:9: mathAtom ( '++' | '--' )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus1126);
                    	mathAtom90 = mathAtom();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, mathAtom90.Tree);
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:258:18: ( '++' | '--' )?
                    	int alt23 = 2;
                    	int LA23_0 = input.LA(1);

                    	if ( ((LA23_0 >= 59 && LA23_0 <= 60)) )
                    	{
                    	    alt23 = 1;
                    	}
                    	switch (alt23) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
                    	        {
                    	        	set91 = (IToken)input.LT(1);
                    	        	if ( (input.LA(1) >= 59 && input.LA(1) <= 60) ) 
                    	        	{
                    	        	    input.Consume();
                    	        	    adaptor.AddChild(root_0, (object)adaptor.Create(set91));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:262:1: castExpression : '(' variableType ')' unaryExpression ;
    public SGLParser.castExpression_return castExpression() // throws RecognitionException [1]
    {   
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal92 = null;
        IToken char_literal94 = null;
        SGLParser.variableType_return variableType93 = default(SGLParser.variableType_return);

        SGLParser.unaryExpression_return unaryExpression95 = default(SGLParser.unaryExpression_return);


        object char_literal92_tree=null;
        object char_literal94_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:8: '(' variableType ')' unaryExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal92=(IToken)Match(input,36,FOLLOW_36_in_castExpression1159); 
            		char_literal92_tree = (object)adaptor.Create(char_literal92);
            		adaptor.AddChild(root_0, char_literal92_tree);

            	PushFollow(FOLLOW_variableType_in_castExpression1161);
            	variableType93 = variableType();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variableType93.Tree);
            	char_literal94=(IToken)Match(input,37,FOLLOW_37_in_castExpression1163); 
            		char_literal94_tree = (object)adaptor.Create(char_literal94);
            		adaptor.AddChild(root_0, char_literal94_tree);

            	PushFollow(FOLLOW_unaryExpression_in_castExpression1165);
            	unaryExpression95 = unaryExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, unaryExpression95.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:1: negativeExpression : ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) );
    public SGLParser.negativeExpression_return negativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.negativeExpression_return retval = new SGLParser.negativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal97 = null;
        SGLParser.mathAtom_return mathAtom96 = default(SGLParser.mathAtom_return);

        SGLParser.mathAtom_return mathAtom98 = default(SGLParser.mathAtom_return);


        object char_literal97_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleSubtreeStream stream_mathAtom = new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:269:2: ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) )
            int alt25 = 2;
            int LA25_0 = input.LA(1);

            if ( (LA25_0 == Identifier || (LA25_0 >= IntegerAtom && LA25_0 <= BooleanAtom) || LA25_0 == StringAtom || LA25_0 == 36 || LA25_0 == 62) )
            {
                alt25 = 1;
            }
            else if ( (LA25_0 == 55) )
            {
                alt25 = 2;
            }
            else 
            {
                NoViableAltException nvae_d25s0 =
                    new NoViableAltException("", 25, 0, input);

                throw nvae_d25s0;
            }
            switch (alt25) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:269:4: mathAtom
                    {
                    	PushFollow(FOLLOW_mathAtom_in_negativeExpression1183);
                    	mathAtom96 = mathAtom();
                    	state.followingStackPointer--;

                    	stream_mathAtom.Add(mathAtom96.Tree);


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
                    	// 269:13: -> mathAtom
                    	{
                    	    adaptor.AddChild(root_0, stream_mathAtom.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:270:4: ( '-' ) mathAtom
                    {
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:270:4: ( '-' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:270:5: '-'
                    	{
                    		char_literal97=(IToken)Match(input,55,FOLLOW_55_in_negativeExpression1193);  
                    		stream_55.Add(char_literal97);


                    	}

                    	PushFollow(FOLLOW_mathAtom_in_negativeExpression1196);
                    	mathAtom98 = mathAtom();
                    	state.followingStackPointer--;

                    	stream_mathAtom.Add(mathAtom98.Tree);


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
                    	// 270:19: -> ^( NEGATE mathAtom )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:270:22: ^( NEGATE mathAtom )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:273:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote );
    public SGLParser.mathAtom_return mathAtom() // throws RecognitionException [1]
    {   
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal99 = null;
        IToken char_literal101 = null;
        IToken IntegerAtom102 = null;
        IToken FloatAtom103 = null;
        IToken BooleanAtom104 = null;
        IToken string_literal105 = null;
        IToken SpriteAnimation106 = null;
        IToken Identifier108 = null;
        IToken Identifier109 = null;
        SGLParser.conditionalExpression_return conditionalExpression100 = default(SGLParser.conditionalExpression_return);

        SGLParser.arguments_return arguments107 = default(SGLParser.arguments_return);

        SGLParser.arguments_return arguments110 = default(SGLParser.arguments_return);

        SGLParser.stringQuote_return stringQuote111 = default(SGLParser.stringQuote_return);


        object char_literal99_tree=null;
        object char_literal101_tree=null;
        object IntegerAtom102_tree=null;
        object FloatAtom103_tree=null;
        object BooleanAtom104_tree=null;
        object string_literal105_tree=null;
        object SpriteAnimation106_tree=null;
        object Identifier108_tree=null;
        object Identifier109_tree=null;
        RewriteRuleTokenStream stream_SpriteAnimation = new RewriteRuleTokenStream(adaptor,"token SpriteAnimation");
        RewriteRuleTokenStream stream_62 = new RewriteRuleTokenStream(adaptor,"token 62");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:274:5: ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote )
            int alt26 = 8;
            alt26 = dfa26.Predict(input);
            switch (alt26) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:274:7: '(' conditionalExpression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal99=(IToken)Match(input,36,FOLLOW_36_in_mathAtom1218); 
                    	PushFollow(FOLLOW_conditionalExpression_in_mathAtom1221);
                    	conditionalExpression100 = conditionalExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, conditionalExpression100.Tree);
                    	char_literal101=(IToken)Match(input,37,FOLLOW_37_in_mathAtom1223); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:275:9: IntegerAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IntegerAtom102=(IToken)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom1234); 
                    		IntegerAtom102_tree = (object)adaptor.Create(IntegerAtom102);
                    		adaptor.AddChild(root_0, IntegerAtom102_tree);


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:276:7: FloatAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FloatAtom103=(IToken)Match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1242); 
                    		FloatAtom103_tree = (object)adaptor.Create(FloatAtom103);
                    		adaptor.AddChild(root_0, FloatAtom103_tree);


                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:277:9: BooleanAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BooleanAtom104=(IToken)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1252); 
                    		BooleanAtom104_tree = (object)adaptor.Create(BooleanAtom104);
                    		adaptor.AddChild(root_0, BooleanAtom104_tree);


                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:279:9: 'new' SpriteAnimation arguments
                    {
                    	string_literal105=(IToken)Match(input,62,FOLLOW_62_in_mathAtom1263);  
                    	stream_62.Add(string_literal105);

                    	SpriteAnimation106=(IToken)Match(input,SpriteAnimation,FOLLOW_SpriteAnimation_in_mathAtom1265);  
                    	stream_SpriteAnimation.Add(SpriteAnimation106);

                    	PushFollow(FOLLOW_arguments_in_mathAtom1267);
                    	arguments107 = arguments();
                    	state.followingStackPointer--;

                    	stream_arguments.Add(arguments107.Tree);


                    	// AST REWRITE
                    	// elements:          arguments, SpriteAnimation
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 279:41: -> ^( SpriteAnimation arguments )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:279:44: ^( SpriteAnimation arguments )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_SpriteAnimation.NextNode(), root_1);

                    	    adaptor.AddChild(root_1, stream_arguments.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:281:4: Identifier
                    {
                    	Identifier108=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_mathAtom1282);  
                    	stream_Identifier.Add(Identifier108);



                    	// AST REWRITE
                    	// elements:          Identifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 281:15: -> Identifier
                    	{
                    	    adaptor.AddChild(root_0, stream_Identifier.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:282:4: Identifier arguments
                    {
                    	Identifier109=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_mathAtom1291);  
                    	stream_Identifier.Add(Identifier109);

                    	PushFollow(FOLLOW_arguments_in_mathAtom1293);
                    	arguments110 = arguments();
                    	state.followingStackPointer--;

                    	stream_arguments.Add(arguments110.Tree);


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
                    	// 282:25: -> ^( LIBMETHOD Identifier ( arguments )? )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:282:28: ^( LIBMETHOD Identifier ( arguments )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LIBMETHOD, "LIBMETHOD"), root_1);

                    	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:282:51: ( arguments )?
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
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:283:4: stringQuote
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stringQuote_in_mathAtom1309);
                    	stringQuote111 = stringQuote();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, stringQuote111.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:287:1: arguments : '(' ( expressionList )? ')' ;
    public SGLParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal112 = null;
        IToken char_literal114 = null;
        SGLParser.expressionList_return expressionList113 = default(SGLParser.expressionList_return);


        object char_literal112_tree=null;
        object char_literal114_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:288:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:288:9: '(' ( expressionList )? ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal112=(IToken)Match(input,36,FOLLOW_36_in_arguments1331); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:288:14: ( expressionList )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( (LA27_0 == Identifier || (LA27_0 >= IntegerAtom && LA27_0 <= BooleanAtom) || LA27_0 == StringAtom || LA27_0 == 36 || LA27_0 == 55 || LA27_0 == 62) )
            	{
            	    alt27 = 1;
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:288:14: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments1334);
            	        	expressionList113 = expressionList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expressionList113.Tree);

            	        }
            	        break;

            	}

            	char_literal114=(IToken)Match(input,37,FOLLOW_37_in_arguments1337); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:291:1: expressionList : expression ( ',' expression )* ;
    public SGLParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal116 = null;
        SGLParser.expression_return expression115 = default(SGLParser.expression_return);

        SGLParser.expression_return expression117 = default(SGLParser.expression_return);


        object char_literal116_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:292:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:292:9: expression ( ',' expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionList1361);
            	expression115 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression115.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:292:20: ( ',' expression )*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( (LA28_0 == 39) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:292:21: ',' expression
            			    {
            			    	char_literal116=(IToken)Match(input,39,FOLLOW_39_in_expressionList1364); 
            			    	PushFollow(FOLLOW_expression_in_expressionList1367);
            			    	expression117 = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expression117.Tree);

            			    }
            			    break;

            			default:
            			    goto loop28;
            	    }
            	} while (true);

            	loop28:
            		;	// Stops C# compiler whining that label 'loop28' has no statements


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

    public class idList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "idList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:295:1: idList : Identifier ( ',' Identifier )* -> ^( ID_LIST ( Identifier )+ ) ;
    public SGLParser.idList_return idList() // throws RecognitionException [1]
    {   
        SGLParser.idList_return retval = new SGLParser.idList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier118 = null;
        IToken char_literal119 = null;
        IToken Identifier120 = null;

        object Identifier118_tree=null;
        object char_literal119_tree=null;
        object Identifier120_tree=null;
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_39 = new RewriteRuleTokenStream(adaptor,"token 39");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:296:3: ( Identifier ( ',' Identifier )* -> ^( ID_LIST ( Identifier )+ ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:296:6: Identifier ( ',' Identifier )*
            {
            	Identifier118=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_idList1386);  
            	stream_Identifier.Add(Identifier118);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:296:17: ( ',' Identifier )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( (LA29_0 == 39) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:296:18: ',' Identifier
            			    {
            			    	char_literal119=(IToken)Match(input,39,FOLLOW_39_in_idList1389);  
            			    	stream_39.Add(char_literal119);

            			    	Identifier120=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_idList1391);  
            			    	stream_Identifier.Add(Identifier120);


            			    }
            			    break;

            			default:
            			    goto loop29;
            	    }
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements



            	// AST REWRITE
            	// elements:          Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 296:35: -> ^( ID_LIST ( Identifier )+ )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:296:38: ^( ID_LIST ( Identifier )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ID_LIST, "ID_LIST"), root_1);

            	    if ( !(stream_Identifier.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_Identifier.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_Identifier.NextNode());

            	    }
            	    stream_Identifier.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

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
    // $ANTLR end "idList"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:299:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public SGLParser.literal_return literal() // throws RecognitionException [1]
    {   
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set121 = null;

        object set121_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:300:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set121 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == StringAtom || input.LA(1) == 63 ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set121));
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

    public class stringQuote_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "stringQuote"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:308:1: stringQuote : StringAtom -> StringAtom ;
    public SGLParser.stringQuote_return stringQuote() // throws RecognitionException [1]
    {   
        SGLParser.stringQuote_return retval = new SGLParser.stringQuote_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken StringAtom122 = null;

        object StringAtom122_tree=null;
        RewriteRuleTokenStream stream_StringAtom = new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:309:2: ( StringAtom -> StringAtom )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:309:8: StringAtom
            {
            	StringAtom122=(IToken)Match(input,StringAtom,FOLLOW_StringAtom_in_stringQuote1497);  
            	stream_StringAtom.Add(StringAtom122);



            	// AST REWRITE
            	// elements:          StringAtom
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 309:19: -> StringAtom
            	{
            	    adaptor.AddChild(root_0, stream_StringAtom.NextNode());

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
    // $ANTLR end "stringQuote"

    // Delegated rules


   	protected DFA26 dfa26;
	private void InitializeCyclicDFAs()
	{
    	this.dfa26 = new DFA26(this);
	}

    const string DFA26_eotS =
        "\x0a\uffff";
    const string DFA26_eofS =
        "\x0a\uffff";
    const string DFA26_minS =
        "\x01\x0e\x05\uffff\x01\x0e\x03\uffff";
    const string DFA26_maxS =
        "\x01\x3e\x05\uffff\x01\x3c\x03\uffff";
    const string DFA26_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\uffff\x01"+
        "\x08\x01\x06\x01\x07";
    const string DFA26_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA26_transitionS = {
            "\x01\x06\x05\uffff\x01\x02\x01\x03\x01\x04\x01\uffff\x01\x07"+
            "\x0b\uffff\x01\x01\x19\uffff\x01\x05",
            "",
            "",
            "",
            "",
            "",
            "\x06\x08\x0d\uffff\x01\x08\x02\uffff\x01\x09\x03\x08\x04\uffff"+
            "\x11\x08",
            "",
            "",
            ""
    };

    static readonly short[] DFA26_eot = DFA.UnpackEncodedString(DFA26_eotS);
    static readonly short[] DFA26_eof = DFA.UnpackEncodedString(DFA26_eofS);
    static readonly char[] DFA26_min = DFA.UnpackEncodedStringToUnsignedChars(DFA26_minS);
    static readonly char[] DFA26_max = DFA.UnpackEncodedStringToUnsignedChars(DFA26_maxS);
    static readonly short[] DFA26_accept = DFA.UnpackEncodedString(DFA26_acceptS);
    static readonly short[] DFA26_special = DFA.UnpackEncodedString(DFA26_specialS);
    static readonly short[][] DFA26_transition = DFA.UnpackEncodedStringArray(DFA26_transitionS);

    protected class DFA26 : DFA
    {
        public DFA26(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 26;
            this.eot = DFA26_eot;
            this.eof = DFA26_eof;
            this.min = DFA26_min;
            this.max = DFA26_max;
            this.accept = DFA26_accept;
            this.special = DFA26_special;
            this.transition = DFA26_transition;

        }

        override public string Description
        {
            get { return "273:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_mainBlock_in_compilationUnit119 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mainStatement_in_mainBlock132 = new BitSet(new ulong[]{0x00000608000FC002UL});
    public static readonly BitSet FOLLOW_methodDef_in_mainBlock136 = new BitSet(new ulong[]{0x00000608000FC002UL});
    public static readonly BitSet FOLLOW_statement_in_block184 = new BitSet(new ulong[]{0x00000600000FC002UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_singleBlock212 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_singleBlock_in_commonBlock238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_commonBlock243 = new BitSet(new ulong[]{0x00000604000FC000UL});
    public static readonly BitSet FOLLOW_block_in_commonBlock246 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_34_in_commonBlock248 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_35_in_methodDef282 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodDef284 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_36_in_methodDef286 = new BitSet(new ulong[]{0x0000002000004000UL});
    public static readonly BitSet FOLLOW_idList_in_methodDef288 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_methodDef291 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_mainStatement320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_semicolonStatement333 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_semicolonStatement339 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_semicolonStatement345 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_statement361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement366 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement371 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclarationList387 = new BitSet(new ulong[]{0x00000000000FC000UL});
    public static readonly BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList389 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_39_in_variableDeclarationList392 = new BitSet(new ulong[]{0x00000000000FC000UL});
    public static readonly BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList394 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDecAssignment418 = new BitSet(new ulong[]{0x0000010000000002UL});
    public static readonly BitSet FOLLOW_40_in_variableDecAssignment421 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_expression_in_variableDecAssignment423 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableAssignment444 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_variableAssignment446 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_expression_in_variableAssignment448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_variableType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_41_in_whileLoop523 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_36_in_whileLoop525 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop527 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_whileLoop529 = new BitSet(new ulong[]{0x00000002000FC000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_whileLoop531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStat_in_ifStatement552 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_elseIfStat_in_ifStatement554 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_elseStat_in_ifStatement557 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_42_in_ifStat582 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_expression_in_ifStat584 = new BitSet(new ulong[]{0x00000002000FC000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_ifStat586 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_elseIfStat607 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_elseIfStat609 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_expression_in_elseIfStat611 = new BitSet(new ulong[]{0x00000002000FC000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseIfStat613 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_43_in_elseStat635 = new BitSet(new ulong[]{0x00000002000FC000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseStat637 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression700 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression741 = new BitSet(new ulong[]{0x0000100000000002UL});
    public static readonly BitSet FOLLOW_44_in_conditionalExpression745 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression748 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_conditionalExpression750 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression753 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression796 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_46_in_conditionalOrExpression800 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression803 = new BitSet(new ulong[]{0x0000400000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression834 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_47_in_conditionalAndExpression838 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression841 = new BitSet(new ulong[]{0x0000800000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression868 = new BitSet(new ulong[]{0x0003000000000002UL});
    public static readonly BitSet FOLLOW_48_in_equalityExpression873 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_49_in_equalityExpression878 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression882 = new BitSet(new ulong[]{0x0003000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression913 = new BitSet(new ulong[]{0x003C000000000002UL});
    public static readonly BitSet FOLLOW_50_in_relationalExpression917 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_51_in_relationalExpression920 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_52_in_relationalExpression923 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_53_in_relationalExpression926 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression930 = new BitSet(new ulong[]{0x003C000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression968 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_54_in_additiveExpression972 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_55_in_additiveExpression975 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression979 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_negativeExpression_in_multiplicativeExpression1013 = new BitSet(new ulong[]{0x0700000000000002UL});
    public static readonly BitSet FOLLOW_56_in_multiplicativeExpression1021 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_57_in_multiplicativeExpression1024 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_58_in_multiplicativeExpression1027 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_negativeExpression_in_multiplicativeExpression1031 = new BitSet(new ulong[]{0x0700000000000002UL});
    public static readonly BitSet FOLLOW_59_in_unaryExpression1054 = new BitSet(new ulong[]{0x7800001001704000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_unaryExpression1066 = new BitSet(new ulong[]{0x7800001001704000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1068 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1078 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_unaryExpressionNotPlusMinus1099 = new BitSet(new ulong[]{0x7800001001704000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1101 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus1111 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus1126 = new BitSet(new ulong[]{0x1800000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus1128 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_castExpression1159 = new BitSet(new ulong[]{0x00000000000F8000UL});
    public static readonly BitSet FOLLOW_variableType_in_castExpression1161 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_castExpression1163 = new BitSet(new ulong[]{0x7800001001704000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1165 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negativeExpression1183 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_negativeExpression1193 = new BitSet(new ulong[]{0x4000001001704000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negativeExpression1196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_mathAtom1218 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_mathAtom1221 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_mathAtom1223 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom1234 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_mathAtom1242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_mathAtom1252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_mathAtom1263 = new BitSet(new ulong[]{0x0000000000800000UL});
    public static readonly BitSet FOLLOW_SpriteAnimation_in_mathAtom1265 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_arguments_in_mathAtom1267 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_mathAtom1282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_mathAtom1291 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_arguments_in_mathAtom1293 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stringQuote_in_mathAtom1309 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_36_in_arguments1331 = new BitSet(new ulong[]{0x4080003001704000UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1334 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_37_in_arguments1337 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1361 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_39_in_expressionList1364 = new BitSet(new ulong[]{0x4080001001704000UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1367 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_idList1386 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_39_in_idList1389 = new BitSet(new ulong[]{0x0000000000004000UL});
    public static readonly BitSet FOLLOW_Identifier_in_idList1391 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringAtom_in_stringQuote1497 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}