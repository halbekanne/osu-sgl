// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g 2011-08-25 18:21:45

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
		"OBJMETHOD", 
		"STRING", 
		"FORDEC", 
		"FORCOND", 
		"FORITER", 
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
		"'.'", 
		"'while'", 
		"'for'", 
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

    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int OBJMETHOD = 13;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int SGLIDDigit = 31;
    public const int IntType = 19;
    public const int T__61 = 61;
    public const int ID_LIST = 8;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int Identifier = 18;
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
    public const int FORITER = 17;
    public const int StringType = 21;
    public const int T__59 = 59;
    public const int SpriteAnimation = 27;
    public const int COMMENT = 36;
    public const int VARDEF = 9;
    public const int T__50 = 50;
    public const int BooleanType = 20;
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
    public const int IntegerAtom = 24;
    public const int FloatType = 22;
    public const int FORDEC = 15;
    public const int StringAtom = 28;
    public const int HEX_DIGIT = 34;
    public const int NEGATE = 11;
    public const int BooleanAtom = 26;
    public const int WS = 35;
    public const int FORCOND = 16;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 32;
    public const int BLOCK = 4;
    public const int ASSIGN = 10;
    public const int STATEMENTS = 5;
    public const int ObjectType = 23;
    public const int FloatAtom = 25;
    public const int OctalEscape = 33;
    public const int Letter = 30;
    public const int EscapeSequence = 29;
    public const int STRING = 14;

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:80:1: compilationUnit : mainBlock ;
    public SGLParser.compilationUnit_return compilationUnit() // throws RecognitionException [1]
    {   
        SGLParser.compilationUnit_return retval = new SGLParser.compilationUnit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.mainBlock_return mainBlock1 = default(SGLParser.mainBlock_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:81:2: ( mainBlock )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:81:4: mainBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mainBlock_in_compilationUnit134);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:84:1: mainBlock : ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:2: ( ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:4: ( mainStatement | methodDef )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:4: ( mainStatement | methodDef )*
            	do 
            	{
            	    int alt1 = 3;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= Identifier && LA1_0 <= ObjectType) || (LA1_0 >= 46 && LA1_0 <= 48)) )
            	    {
            	        alt1 = 1;
            	    }
            	    else if ( (LA1_0 == 39) )
            	    {
            	        alt1 = 2;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:5: mainStatement
            			    {
            			    	PushFollow(FOLLOW_mainStatement_in_mainBlock147);
            			    	mainStatement2 = mainStatement();
            			    	state.followingStackPointer--;

            			    	stream_mainStatement.Add(mainStatement2.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:21: methodDef
            			    {
            			    	PushFollow(FOLLOW_methodDef_in_mainBlock151);
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
            	// 86:8: -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:86:11: ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:86:19: ^( STATEMENTS ( mainStatement )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATEMENTS, "STATEMENTS"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:86:32: ( mainStatement )*
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:89:1: block : ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
    public SGLParser.block_return block() // throws RecognitionException [1]
    {   
        SGLParser.block_return retval = new SGLParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.statement_return statement4 = default(SGLParser.statement_return);


        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:90:2: ( ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:90:4: ( statement )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:90:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= Identifier && LA2_0 <= ObjectType) || (LA2_0 >= 46 && LA2_0 <= 48)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:90:4: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block199);
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
            	// 91:3: -> ^( BLOCK ^( STATEMENTS ( statement )* ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:91:6: ^( BLOCK ^( STATEMENTS ( statement )* ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:91:14: ^( STATEMENTS ( statement )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATEMENTS, "STATEMENTS"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:91:27: ( statement )*
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:94:1: singleBlock : semicolonStatement -> ^( BLOCK ^( STATEMENTS semicolonStatement ) ) ;
    public SGLParser.singleBlock_return singleBlock() // throws RecognitionException [1]
    {   
        SGLParser.singleBlock_return retval = new SGLParser.singleBlock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement5 = default(SGLParser.semicolonStatement_return);


        RewriteRuleSubtreeStream stream_semicolonStatement = new RewriteRuleSubtreeStream(adaptor,"rule semicolonStatement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:95:2: ( semicolonStatement -> ^( BLOCK ^( STATEMENTS semicolonStatement ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:95:4: semicolonStatement
            {
            	PushFollow(FOLLOW_semicolonStatement_in_singleBlock227);
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
            	// 96:3: -> ^( BLOCK ^( STATEMENTS semicolonStatement ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:96:6: ^( BLOCK ^( STATEMENTS semicolonStatement ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:96:14: ^( STATEMENTS semicolonStatement )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:99:1: commonBlock : ( singleBlock | '{' block '}' );
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:100:2: ( singleBlock | '{' block '}' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= Identifier && LA3_0 <= ObjectType)) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == 37) )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:100:4: singleBlock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_singleBlock_in_commonBlock253);
                    	singleBlock6 = singleBlock();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, singleBlock6.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:101:4: '{' block '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal7=(IToken)Match(input,37,FOLLOW_37_in_commonBlock258); 
                    	PushFollow(FOLLOW_block_in_commonBlock261);
                    	block8 = block();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block8.Tree);
                    	char_literal9=(IToken)Match(input,38,FOLLOW_38_in_commonBlock263); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:105:1: methodDef : 'method' Identifier '(' ( idList )? ')' ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:106:3: ( 'method' Identifier '(' ( idList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:106:5: 'method' Identifier '(' ( idList )? ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal10=(IToken)Match(input,39,FOLLOW_39_in_methodDef297); 
            		string_literal10_tree = (object)adaptor.Create(string_literal10);
            		adaptor.AddChild(root_0, string_literal10_tree);

            	Identifier11=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodDef299); 
            		Identifier11_tree = (object)adaptor.Create(Identifier11);
            		adaptor.AddChild(root_0, Identifier11_tree);

            	char_literal12=(IToken)Match(input,40,FOLLOW_40_in_methodDef301); 
            		char_literal12_tree = (object)adaptor.Create(char_literal12);
            		adaptor.AddChild(root_0, char_literal12_tree);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:106:29: ( idList )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == Identifier) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:106:29: idList
            	        {
            	        	PushFollow(FOLLOW_idList_in_methodDef303);
            	        	idList13 = idList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, idList13.Tree);

            	        }
            	        break;

            	}

            	char_literal14=(IToken)Match(input,41,FOLLOW_41_in_methodDef306); 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:110:1: mainStatement : statement ;
    public SGLParser.mainStatement_return mainStatement() // throws RecognitionException [1]
    {   
        SGLParser.mainStatement_return retval = new SGLParser.mainStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.statement_return statement15 = default(SGLParser.statement_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:111:2: ( statement )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:111:4: statement
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_statement_in_mainStatement335);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:114:1: semicolonStatement : ( variableDeclarationList | variableAssignment | objectMethod ) ';' ;
    public SGLParser.semicolonStatement_return semicolonStatement() // throws RecognitionException [1]
    {   
        SGLParser.semicolonStatement_return retval = new SGLParser.semicolonStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal19 = null;
        SGLParser.variableDeclarationList_return variableDeclarationList16 = default(SGLParser.variableDeclarationList_return);

        SGLParser.variableAssignment_return variableAssignment17 = default(SGLParser.variableAssignment_return);

        SGLParser.objectMethod_return objectMethod18 = default(SGLParser.objectMethod_return);


        object char_literal19_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:115:2: ( ( variableDeclarationList | variableAssignment | objectMethod ) ';' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:115:4: ( variableDeclarationList | variableAssignment | objectMethod ) ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:115:4: ( variableDeclarationList | variableAssignment | objectMethod )
            	int alt5 = 3;
            	int LA5_0 = input.LA(1);

            	if ( ((LA5_0 >= IntType && LA5_0 <= ObjectType)) )
            	{
            	    alt5 = 1;
            	}
            	else if ( (LA5_0 == Identifier) )
            	{
            	    int LA5_2 = input.LA(2);

            	    if ( (LA5_2 == 45) )
            	    {
            	        alt5 = 3;
            	    }
            	    else if ( (LA5_2 == 44) )
            	    {
            	        alt5 = 2;
            	    }
            	    else 
            	    {
            	        NoViableAltException nvae_d5s2 =
            	            new NoViableAltException("", 5, 2, input);

            	        throw nvae_d5s2;
            	    }
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
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:115:5: variableDeclarationList
            	        {
            	        	PushFollow(FOLLOW_variableDeclarationList_in_semicolonStatement348);
            	        	variableDeclarationList16 = variableDeclarationList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variableDeclarationList16.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:116:4: variableAssignment
            	        {
            	        	PushFollow(FOLLOW_variableAssignment_in_semicolonStatement354);
            	        	variableAssignment17 = variableAssignment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variableAssignment17.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:117:4: objectMethod
            	        {
            	        	PushFollow(FOLLOW_objectMethod_in_semicolonStatement360);
            	        	objectMethod18 = objectMethod();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, objectMethod18.Tree);

            	        }
            	        break;

            	}

            	char_literal19=(IToken)Match(input,42,FOLLOW_42_in_semicolonStatement365); 

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

    public class oneLineStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "oneLineStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:121:1: oneLineStatement : ( variableDeclarationList | variableAssignment );
    public SGLParser.oneLineStatement_return oneLineStatement() // throws RecognitionException [1]
    {   
        SGLParser.oneLineStatement_return retval = new SGLParser.oneLineStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.variableDeclarationList_return variableDeclarationList20 = default(SGLParser.variableDeclarationList_return);

        SGLParser.variableAssignment_return variableAssignment21 = default(SGLParser.variableAssignment_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:2: ( variableDeclarationList | variableAssignment )
            int alt6 = 2;
            int LA6_0 = input.LA(1);

            if ( ((LA6_0 >= IntType && LA6_0 <= ObjectType)) )
            {
                alt6 = 1;
            }
            else if ( (LA6_0 == Identifier) )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:4: variableDeclarationList
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableDeclarationList_in_oneLineStatement378);
                    	variableDeclarationList20 = variableDeclarationList();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableDeclarationList20.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:123:4: variableAssignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableAssignment_in_oneLineStatement383);
                    	variableAssignment21 = variableAssignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableAssignment21.Tree);

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
    // $ANTLR end "oneLineStatement"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:127:1: statement : ( semicolonStatement | ifStatement | whileLoop | forLoop );
    public SGLParser.statement_return statement() // throws RecognitionException [1]
    {   
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement22 = default(SGLParser.semicolonStatement_return);

        SGLParser.ifStatement_return ifStatement23 = default(SGLParser.ifStatement_return);

        SGLParser.whileLoop_return whileLoop24 = default(SGLParser.whileLoop_return);

        SGLParser.forLoop_return forLoop25 = default(SGLParser.forLoop_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:129:2: ( semicolonStatement | ifStatement | whileLoop | forLoop )
            int alt7 = 4;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            case IntType:
            case BooleanType:
            case StringType:
            case FloatType:
            case ObjectType:
            	{
                alt7 = 1;
                }
                break;
            case 48:
            	{
                alt7 = 2;
                }
                break;
            case 46:
            	{
                alt7 = 3;
                }
                break;
            case 47:
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:129:4: semicolonStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_semicolonStatement_in_statement399);
                    	semicolonStatement22 = semicolonStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, semicolonStatement22.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:130:4: ifStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statement404);
                    	ifStatement23 = ifStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ifStatement23.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:131:4: whileLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileLoop_in_statement409);
                    	whileLoop24 = whileLoop();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, whileLoop24.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:132:4: forLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forLoop_in_statement414);
                    	forLoop25 = forLoop();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, forLoop25.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:139:1: variableDeclarationList : variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( VARDEF variableType variableDecAssignment ) )+ ;
    public SGLParser.variableDeclarationList_return variableDeclarationList() // throws RecognitionException [1]
    {   
        SGLParser.variableDeclarationList_return retval = new SGLParser.variableDeclarationList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal28 = null;
        SGLParser.variableType_return variableType26 = default(SGLParser.variableType_return);

        SGLParser.variableDecAssignment_return variableDecAssignment27 = default(SGLParser.variableDecAssignment_return);

        SGLParser.variableDecAssignment_return variableDecAssignment29 = default(SGLParser.variableDecAssignment_return);


        object char_literal28_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_variableType = new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableDecAssignment = new RewriteRuleSubtreeStream(adaptor,"rule variableDecAssignment");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:140:2: ( variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( VARDEF variableType variableDecAssignment ) )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:140:4: variableType variableDecAssignment ( ',' variableDecAssignment )*
            {
            	PushFollow(FOLLOW_variableType_in_variableDeclarationList430);
            	variableType26 = variableType();
            	state.followingStackPointer--;

            	stream_variableType.Add(variableType26.Tree);
            	PushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList432);
            	variableDecAssignment27 = variableDecAssignment();
            	state.followingStackPointer--;

            	stream_variableDecAssignment.Add(variableDecAssignment27.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:140:39: ( ',' variableDecAssignment )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == 43) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:140:40: ',' variableDecAssignment
            			    {
            			    	char_literal28=(IToken)Match(input,43,FOLLOW_43_in_variableDeclarationList435);  
            			    	stream_43.Add(char_literal28);

            			    	PushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList437);
            			    	variableDecAssignment29 = variableDecAssignment();
            			    	state.followingStackPointer--;

            			    	stream_variableDecAssignment.Add(variableDecAssignment29.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements



            	// AST REWRITE
            	// elements:          variableType, variableDecAssignment
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 140:68: -> ( ^( VARDEF variableType variableDecAssignment ) )+
            	{
            	    if ( !(stream_variableType.HasNext() || stream_variableDecAssignment.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_variableType.HasNext() || stream_variableDecAssignment.HasNext() )
            	    {
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:140:71: ^( VARDEF variableType variableDecAssignment )
            	        {
            	        object root_1 = (object)adaptor.GetNilNode();
            	        root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDEF, "VARDEF"), root_1);

            	        adaptor.AddChild(root_1, stream_variableType.NextTree());
            	        adaptor.AddChild(root_1, stream_variableDecAssignment.NextTree());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_variableType.Reset();
            	    stream_variableDecAssignment.Reset();

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:143:1: variableDecAssignment : variableName ( '=' expression )? -> variableName ( expression )? ;
    public SGLParser.variableDecAssignment_return variableDecAssignment() // throws RecognitionException [1]
    {   
        SGLParser.variableDecAssignment_return retval = new SGLParser.variableDecAssignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal31 = null;
        SGLParser.variableName_return variableName30 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression32 = default(SGLParser.expression_return);


        object char_literal31_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:144:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:144:4: variableName ( '=' expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableDecAssignment461);
            	variableName30 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName30.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:144:17: ( '=' expression )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == 44) )
            	{
            	    alt9 = 1;
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:144:18: '=' expression
            	        {
            	        	char_literal31=(IToken)Match(input,44,FOLLOW_44_in_variableDecAssignment464);  
            	        	stream_44.Add(char_literal31);

            	        	PushFollow(FOLLOW_expression_in_variableDecAssignment466);
            	        	expression32 = expression();
            	        	state.followingStackPointer--;

            	        	stream_expression.Add(expression32.Tree);

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
            	// 144:36: -> variableName ( expression )?
            	{
            	    adaptor.AddChild(root_0, stream_variableName.NextTree());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:144:52: ( expression )?
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:147:1: variableAssignment : variableName '=' expression -> ^( ASSIGN variableName expression ) ;
    public SGLParser.variableAssignment_return variableAssignment() // throws RecognitionException [1]
    {   
        SGLParser.variableAssignment_return retval = new SGLParser.variableAssignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal34 = null;
        SGLParser.variableName_return variableName33 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression35 = default(SGLParser.expression_return);


        object char_literal34_tree=null;
        RewriteRuleTokenStream stream_44 = new RewriteRuleTokenStream(adaptor,"token 44");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:148:2: ( variableName '=' expression -> ^( ASSIGN variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:148:4: variableName '=' expression
            {
            	PushFollow(FOLLOW_variableName_in_variableAssignment487);
            	variableName33 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName33.Tree);
            	char_literal34=(IToken)Match(input,44,FOLLOW_44_in_variableAssignment489);  
            	stream_44.Add(char_literal34);

            	PushFollow(FOLLOW_expression_in_variableAssignment491);
            	expression35 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression35.Tree);


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
            	// 148:33: -> ^( ASSIGN variableName expression )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:148:36: ^( ASSIGN variableName expression )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:156:1: variableName : Identifier ;
    public SGLParser.variableName_return variableName() // throws RecognitionException [1]
    {   
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier36 = null;

        object Identifier36_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:157:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:157:4: Identifier
            {
            	root_0 = (object)adaptor.GetNilNode();

            	Identifier36=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableName522); 
            		Identifier36_tree = (object)adaptor.Create(Identifier36);
            		adaptor.AddChild(root_0, Identifier36_tree);


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:160:1: variableType : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public SGLParser.variableType_return variableType() // throws RecognitionException [1]
    {   
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set37 = null;

        object set37_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:161:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set37 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntType && input.LA(1) <= ObjectType) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set37));
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

    public class objectMethod_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objectMethod"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:169:1: objectMethod : variableName '.' Identifier '(' ( arguments )? ')' -> ^( OBJMETHOD variableName Identifier ( arguments )? ) ;
    public SGLParser.objectMethod_return objectMethod() // throws RecognitionException [1]
    {   
        SGLParser.objectMethod_return retval = new SGLParser.objectMethod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal39 = null;
        IToken Identifier40 = null;
        IToken char_literal41 = null;
        IToken char_literal43 = null;
        SGLParser.variableName_return variableName38 = default(SGLParser.variableName_return);

        SGLParser.arguments_return arguments42 = default(SGLParser.arguments_return);


        object char_literal39_tree=null;
        object Identifier40_tree=null;
        object char_literal41_tree=null;
        object char_literal43_tree=null;
        RewriteRuleTokenStream stream_45 = new RewriteRuleTokenStream(adaptor,"token 45");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:170:2: ( variableName '.' Identifier '(' ( arguments )? ')' -> ^( OBJMETHOD variableName Identifier ( arguments )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:170:4: variableName '.' Identifier '(' ( arguments )? ')'
            {
            	PushFollow(FOLLOW_variableName_in_objectMethod566);
            	variableName38 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName38.Tree);
            	char_literal39=(IToken)Match(input,45,FOLLOW_45_in_objectMethod568);  
            	stream_45.Add(char_literal39);

            	Identifier40=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_objectMethod570);  
            	stream_Identifier.Add(Identifier40);

            	char_literal41=(IToken)Match(input,40,FOLLOW_40_in_objectMethod572);  
            	stream_40.Add(char_literal41);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:170:36: ( arguments )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == Identifier || (LA10_0 >= IntegerAtom && LA10_0 <= BooleanAtom) || LA10_0 == StringAtom || LA10_0 == 40 || LA10_0 == 61 || LA10_0 == 68) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:170:36: arguments
            	        {
            	        	PushFollow(FOLLOW_arguments_in_objectMethod574);
            	        	arguments42 = arguments();
            	        	state.followingStackPointer--;

            	        	stream_arguments.Add(arguments42.Tree);

            	        }
            	        break;

            	}

            	char_literal43=(IToken)Match(input,41,FOLLOW_41_in_objectMethod577);  
            	stream_41.Add(char_literal43);



            	// AST REWRITE
            	// elements:          arguments, Identifier, variableName
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 170:51: -> ^( OBJMETHOD variableName Identifier ( arguments )? )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:170:54: ^( OBJMETHOD variableName Identifier ( arguments )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(OBJMETHOD, "OBJMETHOD"), root_1);

            	    adaptor.AddChild(root_1, stream_variableName.NextTree());
            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:170:90: ( arguments )?
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
    // $ANTLR end "objectMethod"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:173:1: whileLoop : 'while' expression commonBlock -> ^( 'while' expression commonBlock ) ;
    public SGLParser.whileLoop_return whileLoop() // throws RecognitionException [1]
    {   
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal44 = null;
        SGLParser.expression_return expression45 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock46 = default(SGLParser.commonBlock_return);


        object string_literal44_tree=null;
        RewriteRuleTokenStream stream_46 = new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:2: ( 'while' expression commonBlock -> ^( 'while' expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:4: 'while' expression commonBlock
            {
            	string_literal44=(IToken)Match(input,46,FOLLOW_46_in_whileLoop601);  
            	stream_46.Add(string_literal44);

            	PushFollow(FOLLOW_expression_in_whileLoop603);
            	expression45 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression45.Tree);
            	PushFollow(FOLLOW_commonBlock_in_whileLoop605);
            	commonBlock46 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock46.Tree);


            	// AST REWRITE
            	// elements:          expression, commonBlock, 46
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 174:35: -> ^( 'while' expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:38: ^( 'while' expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_46.NextNode(), root_1);

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

    public class forLoop_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "forLoop"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:177:1: forLoop : 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ( ^( FORDEC $dec) )? ( ^( FORCOND $cond) )? ( ^( FORITER $iter) )? ) ;
    public SGLParser.forLoop_return forLoop() // throws RecognitionException [1]
    {   
        SGLParser.forLoop_return retval = new SGLParser.forLoop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal47 = null;
        IToken char_literal48 = null;
        IToken char_literal49 = null;
        IToken char_literal50 = null;
        IToken char_literal51 = null;
        SGLParser.oneLineStatement_return dec = default(SGLParser.oneLineStatement_return);

        SGLParser.expression_return cond = default(SGLParser.expression_return);

        SGLParser.oneLineStatement_return iter = default(SGLParser.oneLineStatement_return);

        SGLParser.commonBlock_return commonBlock52 = default(SGLParser.commonBlock_return);


        object string_literal47_tree=null;
        object char_literal48_tree=null;
        object char_literal49_tree=null;
        object char_literal50_tree=null;
        object char_literal51_tree=null;
        RewriteRuleTokenStream stream_42 = new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_47 = new RewriteRuleTokenStream(adaptor,"token 47");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        RewriteRuleSubtreeStream stream_oneLineStatement = new RewriteRuleSubtreeStream(adaptor,"rule oneLineStatement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:2: ( 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ( ^( FORDEC $dec) )? ( ^( FORCOND $cond) )? ( ^( FORITER $iter) )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:4: 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock
            {
            	string_literal47=(IToken)Match(input,47,FOLLOW_47_in_forLoop627);  
            	stream_47.Add(string_literal47);

            	char_literal48=(IToken)Match(input,40,FOLLOW_40_in_forLoop629);  
            	stream_40.Add(char_literal48);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:17: (dec= oneLineStatement )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( ((LA11_0 >= Identifier && LA11_0 <= ObjectType)) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:17: dec= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop633);
            	        	dec = oneLineStatement();
            	        	state.followingStackPointer--;

            	        	stream_oneLineStatement.Add(dec.Tree);

            	        }
            	        break;

            	}

            	char_literal49=(IToken)Match(input,42,FOLLOW_42_in_forLoop636);  
            	stream_42.Add(char_literal49);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:44: (cond= expression )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == Identifier || (LA12_0 >= IntegerAtom && LA12_0 <= BooleanAtom) || LA12_0 == StringAtom || LA12_0 == 40 || LA12_0 == 61 || LA12_0 == 68) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:44: cond= expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forLoop640);
            	        	cond = expression();
            	        	state.followingStackPointer--;

            	        	stream_expression.Add(cond.Tree);

            	        }
            	        break;

            	}

            	char_literal50=(IToken)Match(input,42,FOLLOW_42_in_forLoop643);  
            	stream_42.Add(char_literal50);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:65: (iter= oneLineStatement )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( ((LA13_0 >= Identifier && LA13_0 <= ObjectType)) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:65: iter= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop647);
            	        	iter = oneLineStatement();
            	        	state.followingStackPointer--;

            	        	stream_oneLineStatement.Add(iter.Tree);

            	        }
            	        break;

            	}

            	char_literal51=(IToken)Match(input,41,FOLLOW_41_in_forLoop650);  
            	stream_41.Add(char_literal51);

            	PushFollow(FOLLOW_commonBlock_in_forLoop652);
            	commonBlock52 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock52.Tree);


            	// AST REWRITE
            	// elements:          dec, iter, 47, cond
            	// token labels:      
            	// rule labels:       retval, dec, iter, cond
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_dec = new RewriteRuleSubtreeStream(adaptor, "rule dec", dec!=null ? dec.Tree : null);
            	RewriteRuleSubtreeStream stream_iter = new RewriteRuleSubtreeStream(adaptor, "rule iter", iter!=null ? iter.Tree : null);
            	RewriteRuleSubtreeStream stream_cond = new RewriteRuleSubtreeStream(adaptor, "rule cond", cond!=null ? cond.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 179:2: -> ^( 'for' ( ^( FORDEC $dec) )? ( ^( FORCOND $cond) )? ( ^( FORITER $iter) )? )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:179:5: ^( 'for' ( ^( FORDEC $dec) )? ( ^( FORCOND $cond) )? ( ^( FORITER $iter) )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_47.NextNode(), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:179:13: ( ^( FORDEC $dec) )?
            	    if ( stream_dec.HasNext() )
            	    {
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:179:13: ^( FORDEC $dec)
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORDEC, "FORDEC"), root_2);

            	        adaptor.AddChild(root_2, stream_dec.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_dec.Reset();
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:179:29: ( ^( FORCOND $cond) )?
            	    if ( stream_cond.HasNext() )
            	    {
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:179:29: ^( FORCOND $cond)
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORCOND, "FORCOND"), root_2);

            	        adaptor.AddChild(root_2, stream_cond.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_cond.Reset();
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:179:47: ( ^( FORITER $iter) )?
            	    if ( stream_iter.HasNext() )
            	    {
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:179:47: ^( FORITER $iter)
            	        {
            	        object root_2 = (object)adaptor.GetNilNode();
            	        root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORITER, "FORITER"), root_2);

            	        adaptor.AddChild(root_2, stream_iter.NextTree());

            	        adaptor.AddChild(root_1, root_2);
            	        }

            	    }
            	    stream_iter.Reset();

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
    // $ANTLR end "forLoop"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:182:1: ifStatement : ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) ;
    public SGLParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        SGLParser.ifStatement_return retval = new SGLParser.ifStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.ifStat_return ifStat53 = default(SGLParser.ifStat_return);

        SGLParser.elseIfStat_return elseIfStat54 = default(SGLParser.elseIfStat_return);

        SGLParser.elseStat_return elseStat55 = default(SGLParser.elseStat_return);


        RewriteRuleSubtreeStream stream_elseIfStat = new RewriteRuleSubtreeStream(adaptor,"rule elseIfStat");
        RewriteRuleSubtreeStream stream_ifStat = new RewriteRuleSubtreeStream(adaptor,"rule ifStat");
        RewriteRuleSubtreeStream stream_elseStat = new RewriteRuleSubtreeStream(adaptor,"rule elseStat");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:2: ( ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:4: ifStat ( elseIfStat )* ( elseStat )?
            {
            	PushFollow(FOLLOW_ifStat_in_ifStatement695);
            	ifStat53 = ifStat();
            	state.followingStackPointer--;

            	stream_ifStat.Add(ifStat53.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:11: ( elseIfStat )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 49) )
            	    {
            	        int LA14_1 = input.LA(2);

            	        if ( (LA14_1 == 48) )
            	        {
            	            alt14 = 1;
            	        }


            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:11: elseIfStat
            			    {
            			    	PushFollow(FOLLOW_elseIfStat_in_ifStatement697);
            			    	elseIfStat54 = elseIfStat();
            			    	state.followingStackPointer--;

            			    	stream_elseIfStat.Add(elseIfStat54.Tree);

            			    }
            			    break;

            			default:
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:23: ( elseStat )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == 49) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:23: elseStat
            	        {
            	        	PushFollow(FOLLOW_elseStat_in_ifStatement700);
            	        	elseStat55 = elseStat();
            	        	state.followingStackPointer--;

            	        	stream_elseStat.Add(elseStat55.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          elseStat, ifStat, elseIfStat
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 183:33: -> ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:36: ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF, "IF"), root_1);

            	    adaptor.AddChild(root_1, stream_ifStat.NextTree());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:48: ( elseIfStat )*
            	    while ( stream_elseIfStat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_elseIfStat.NextTree());

            	    }
            	    stream_elseIfStat.Reset();
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:60: ( elseStat )?
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:185:1: ifStat : 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.ifStat_return ifStat() // throws RecognitionException [1]
    {   
        SGLParser.ifStat_return retval = new SGLParser.ifStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal56 = null;
        SGLParser.expression_return expression57 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock58 = default(SGLParser.commonBlock_return);


        object string_literal56_tree=null;
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:186:2: ( 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:186:4: 'if' expression commonBlock
            {
            	string_literal56=(IToken)Match(input,48,FOLLOW_48_in_ifStat725);  
            	stream_48.Add(string_literal56);

            	PushFollow(FOLLOW_expression_in_ifStat727);
            	expression57 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression57.Tree);
            	PushFollow(FOLLOW_commonBlock_in_ifStat729);
            	commonBlock58 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock58.Tree);


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
            	// 186:32: -> ^( EXP expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:186:35: ^( EXP expression commonBlock )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:189:1: elseIfStat : 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.elseIfStat_return elseIfStat() // throws RecognitionException [1]
    {   
        SGLParser.elseIfStat_return retval = new SGLParser.elseIfStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal59 = null;
        IToken string_literal60 = null;
        SGLParser.expression_return expression61 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock62 = default(SGLParser.commonBlock_return);


        object string_literal59_tree=null;
        object string_literal60_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:2: ( 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:4: 'else' 'if' expression commonBlock
            {
            	string_literal59=(IToken)Match(input,49,FOLLOW_49_in_elseIfStat750);  
            	stream_49.Add(string_literal59);

            	string_literal60=(IToken)Match(input,48,FOLLOW_48_in_elseIfStat752);  
            	stream_48.Add(string_literal60);

            	PushFollow(FOLLOW_expression_in_elseIfStat754);
            	expression61 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression61.Tree);
            	PushFollow(FOLLOW_commonBlock_in_elseIfStat756);
            	commonBlock62 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock62.Tree);


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
            	// 190:39: -> ^( EXP expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:42: ^( EXP expression commonBlock )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:193:1: elseStat : 'else' commonBlock -> ^( EXP commonBlock ) ;
    public SGLParser.elseStat_return elseStat() // throws RecognitionException [1]
    {   
        SGLParser.elseStat_return retval = new SGLParser.elseStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal63 = null;
        SGLParser.commonBlock_return commonBlock64 = default(SGLParser.commonBlock_return);


        object string_literal63_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:194:2: ( 'else' commonBlock -> ^( EXP commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:194:4: 'else' commonBlock
            {
            	string_literal63=(IToken)Match(input,49,FOLLOW_49_in_elseStat778);  
            	stream_49.Add(string_literal63);

            	PushFollow(FOLLOW_commonBlock_in_elseStat780);
            	commonBlock64 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock64.Tree);


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
            	// 194:23: -> ^( EXP commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:194:26: ^( EXP commonBlock )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:220:1: expression : conditionalExpression ;
    public SGLParser.expression_return expression() // throws RecognitionException [1]
    {   
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression65 = default(SGLParser.conditionalExpression_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:221:5: ( conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:221:8: conditionalExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalExpression_in_expression843);
            	conditionalExpression65 = conditionalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalExpression65.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:230:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public SGLParser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal67 = null;
        IToken char_literal69 = null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression66 = default(SGLParser.conditionalOrExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression68 = default(SGLParser.conditionalExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression70 = default(SGLParser.conditionalExpression_return);


        object char_literal67_tree=null;
        object char_literal69_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression884);
            	conditionalOrExpression66 = conditionalOrExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalOrExpression66.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == 50) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	char_literal67=(IToken)Match(input,50,FOLLOW_50_in_conditionalExpression888); 
            	        		char_literal67_tree = (object)adaptor.Create(char_literal67);
            	        		root_0 = (object)adaptor.BecomeRoot(char_literal67_tree, root_0);

            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression891);
            	        	conditionalExpression68 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression68.Tree);
            	        	char_literal69=(IToken)Match(input,51,FOLLOW_51_in_conditionalExpression893); 
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression896);
            	        	conditionalExpression70 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression70.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public SGLParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal72 = null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression71 = default(SGLParser.conditionalAndExpression_return);

        SGLParser.conditionalAndExpression_return conditionalAndExpression73 = default(SGLParser.conditionalAndExpression_return);


        object string_literal72_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:237:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:237:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression939);
            	conditionalAndExpression71 = conditionalAndExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalAndExpression71.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:237:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == 52) )
            	    {
            	        alt17 = 1;
            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:237:36: '||' conditionalAndExpression
            			    {
            			    	string_literal72=(IToken)Match(input,52,FOLLOW_52_in_conditionalOrExpression943); 
            			    		string_literal72_tree = (object)adaptor.Create(string_literal72);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal72_tree, root_0);

            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression946);
            			    	conditionalAndExpression73 = conditionalAndExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, conditionalAndExpression73.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:241:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public SGLParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal75 = null;
        SGLParser.equalityExpression_return equalityExpression74 = default(SGLParser.equalityExpression_return);

        SGLParser.equalityExpression_return equalityExpression76 = default(SGLParser.equalityExpression_return);


        object string_literal75_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression977);
            	equalityExpression74 = equalityExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, equalityExpression74.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0 == 53) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:30: '&&' equalityExpression
            			    {
            			    	string_literal75=(IToken)Match(input,53,FOLLOW_53_in_conditionalAndExpression981); 
            			    		string_literal75_tree = (object)adaptor.Create(string_literal75);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal75_tree, root_0);

            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression984);
            			    	equalityExpression76 = equalityExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, equalityExpression76.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:246:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public SGLParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal78 = null;
        IToken string_literal79 = null;
        SGLParser.relationalExpression_return relationalExpression77 = default(SGLParser.relationalExpression_return);

        SGLParser.relationalExpression_return relationalExpression80 = default(SGLParser.relationalExpression_return);


        object string_literal78_tree=null;
        object string_literal79_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1011);
            	relationalExpression77 = relationalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, relationalExpression77.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( ((LA20_0 >= 54 && LA20_0 <= 55)) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:32: ( '==' | '!=' )
            			    	int alt19 = 2;
            			    	int LA19_0 = input.LA(1);

            			    	if ( (LA19_0 == 54) )
            			    	{
            			    	    alt19 = 1;
            			    	}
            			    	else if ( (LA19_0 == 55) )
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:33: '=='
            			    	        {
            			    	        	string_literal78=(IToken)Match(input,54,FOLLOW_54_in_equalityExpression1016); 
            			    	        		string_literal78_tree = (object)adaptor.Create(string_literal78);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal78_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:41: '!='
            			    	        {
            			    	        	string_literal79=(IToken)Match(input,55,FOLLOW_55_in_equalityExpression1021); 
            			    	        		string_literal79_tree = (object)adaptor.Create(string_literal79);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal79_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1025);
            			    	relationalExpression80 = relationalExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, relationalExpression80.Tree);

            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:251:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public SGLParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal82 = null;
        IToken char_literal83 = null;
        IToken string_literal84 = null;
        IToken string_literal85 = null;
        SGLParser.additiveExpression_return additiveExpression81 = default(SGLParser.additiveExpression_return);

        SGLParser.additiveExpression_return additiveExpression86 = default(SGLParser.additiveExpression_return);


        object char_literal82_tree=null;
        object char_literal83_tree=null;
        object string_literal84_tree=null;
        object string_literal85_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:252:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:252:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1056);
            	additiveExpression81 = additiveExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additiveExpression81.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:252:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( ((LA22_0 >= 56 && LA22_0 <= 59)) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:252:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:252:29: ( '<' | '>' | '<=' | '>=' )
            			    	int alt21 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 56:
            			    		{
            			    	    alt21 = 1;
            			    	    }
            			    	    break;
            			    	case 57:
            			    		{
            			    	    alt21 = 2;
            			    	    }
            			    	    break;
            			    	case 58:
            			    		{
            			    	    alt21 = 3;
            			    	    }
            			    	    break;
            			    	case 59:
            			    		{
            			    	    alt21 = 4;
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:252:30: '<'
            			    	        {
            			    	        	char_literal82=(IToken)Match(input,56,FOLLOW_56_in_relationalExpression1060); 
            			    	        		char_literal82_tree = (object)adaptor.Create(char_literal82);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal82_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:252:35: '>'
            			    	        {
            			    	        	char_literal83=(IToken)Match(input,57,FOLLOW_57_in_relationalExpression1063); 
            			    	        		char_literal83_tree = (object)adaptor.Create(char_literal83);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal83_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:252:40: '<='
            			    	        {
            			    	        	string_literal84=(IToken)Match(input,58,FOLLOW_58_in_relationalExpression1066); 
            			    	        		string_literal84_tree = (object)adaptor.Create(string_literal84);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal84_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:252:46: '>='
            			    	        {
            			    	        	string_literal85=(IToken)Match(input,59,FOLLOW_59_in_relationalExpression1069); 
            			    	        		string_literal85_tree = (object)adaptor.Create(string_literal85);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal85_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1073);
            			    	additiveExpression86 = additiveExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, additiveExpression86.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:256:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public SGLParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal88 = null;
        IToken char_literal89 = null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression87 = default(SGLParser.multiplicativeExpression_return);

        SGLParser.multiplicativeExpression_return multiplicativeExpression90 = default(SGLParser.multiplicativeExpression_return);


        object char_literal88_tree=null;
        object char_literal89_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:257:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:257:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1111);
            	multiplicativeExpression87 = multiplicativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multiplicativeExpression87.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:257:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( ((LA24_0 >= 60 && LA24_0 <= 61)) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:257:35: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:257:35: ( '+' | '-' )
            			    	int alt23 = 2;
            			    	int LA23_0 = input.LA(1);

            			    	if ( (LA23_0 == 60) )
            			    	{
            			    	    alt23 = 1;
            			    	}
            			    	else if ( (LA23_0 == 61) )
            			    	{
            			    	    alt23 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d23s0 =
            			    	        new NoViableAltException("", 23, 0, input);

            			    	    throw nvae_d23s0;
            			    	}
            			    	switch (alt23) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:257:36: '+'
            			    	        {
            			    	        	char_literal88=(IToken)Match(input,60,FOLLOW_60_in_additiveExpression1115); 
            			    	        		char_literal88_tree = (object)adaptor.Create(char_literal88);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal88_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:257:41: '-'
            			    	        {
            			    	        	char_literal89=(IToken)Match(input,61,FOLLOW_61_in_additiveExpression1118); 
            			    	        		char_literal89_tree = (object)adaptor.Create(char_literal89);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal89_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1122);
            			    	multiplicativeExpression90 = multiplicativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multiplicativeExpression90.Tree);

            			    }
            			    break;

            			default:
            			    goto loop24;
            	    }
            	} while (true);

            	loop24:
            		;	// Stops C# compiler whining that label 'loop24' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:261:1: multiplicativeExpression : negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* ;
    public SGLParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal92 = null;
        IToken char_literal93 = null;
        IToken char_literal94 = null;
        SGLParser.negativeExpression_return negativeExpression91 = default(SGLParser.negativeExpression_return);

        SGLParser.negativeExpression_return negativeExpression95 = default(SGLParser.negativeExpression_return);


        object char_literal92_tree=null;
        object char_literal93_tree=null;
        object char_literal94_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:262:5: ( negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:262:9: negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression1156);
            	negativeExpression91 = negativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, negativeExpression91.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:5: ( ( '*' | '/' | '%' ) negativeExpression )*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( ((LA26_0 >= 62 && LA26_0 <= 64)) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:6: ( '*' | '/' | '%' ) negativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:6: ( '*' | '/' | '%' )
            			    	int alt25 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 62:
            			    		{
            			    	    alt25 = 1;
            			    	    }
            			    	    break;
            			    	case 63:
            			    		{
            			    	    alt25 = 2;
            			    	    }
            			    	    break;
            			    	case 64:
            			    		{
            			    	    alt25 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d25s0 =
            			    		        new NoViableAltException("", 25, 0, input);

            			    		    throw nvae_d25s0;
            			    	}

            			    	switch (alt25) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:7: '*'
            			    	        {
            			    	        	char_literal92=(IToken)Match(input,62,FOLLOW_62_in_multiplicativeExpression1164); 
            			    	        		char_literal92_tree = (object)adaptor.Create(char_literal92);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal92_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:12: '/'
            			    	        {
            			    	        	char_literal93=(IToken)Match(input,63,FOLLOW_63_in_multiplicativeExpression1167); 
            			    	        		char_literal93_tree = (object)adaptor.Create(char_literal93);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal93_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:17: '%'
            			    	        {
            			    	        	char_literal94=(IToken)Match(input,64,FOLLOW_64_in_multiplicativeExpression1170); 
            			    	        		char_literal94_tree = (object)adaptor.Create(char_literal94);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal94_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression1174);
            			    	negativeExpression95 = negativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, negativeExpression95.Tree);

            			    }
            			    break;

            			default:
            			    goto loop26;
            	    }
            	} while (true);

            	loop26:
            		;	// Stops C# compiler whining that label 'loop26' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:266:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public SGLParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal96 = null;
        IToken string_literal98 = null;
        SGLParser.unaryExpression_return unaryExpression97 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpression_return unaryExpression99 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus100 = default(SGLParser.unaryExpressionNotPlusMinus_return);


        object string_literal96_tree=null;
        object string_literal98_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:267:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt27 = 3;
            switch ( input.LA(1) ) 
            {
            case 65:
            	{
                alt27 = 1;
                }
                break;
            case 66:
            	{
                alt27 = 2;
                }
                break;
            case Identifier:
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case StringAtom:
            case 40:
            case 67:
            case 68:
            	{
                alt27 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d27s0 =
            	        new NoViableAltException("", 27, 0, input);

            	    throw nvae_d27s0;
            }

            switch (alt27) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:267:7: '++' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal96=(IToken)Match(input,65,FOLLOW_65_in_unaryExpression1197); 
                    		string_literal96_tree = (object)adaptor.Create(string_literal96);
                    		adaptor.AddChild(root_0, string_literal96_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1199);
                    	unaryExpression97 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression97.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:9: '--' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal98=(IToken)Match(input,66,FOLLOW_66_in_unaryExpression1209); 
                    		string_literal98_tree = (object)adaptor.Create(string_literal98);
                    		adaptor.AddChild(root_0, string_literal98_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1211);
                    	unaryExpression99 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression99.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:269:9: unaryExpressionNotPlusMinus
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1221);
                    	unaryExpressionNotPlusMinus100 = unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpressionNotPlusMinus100.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:273:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal101 = null;
        IToken set105 = null;
        SGLParser.unaryExpression_return unaryExpression102 = default(SGLParser.unaryExpression_return);

        SGLParser.castExpression_return castExpression103 = default(SGLParser.castExpression_return);

        SGLParser.mathAtom_return mathAtom104 = default(SGLParser.mathAtom_return);


        object char_literal101_tree=null;
        object set105_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:274:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt29 = 3;
            switch ( input.LA(1) ) 
            {
            case 67:
            	{
                alt29 = 1;
                }
                break;
            case 40:
            	{
                int LA29_2 = input.LA(2);

                if ( ((LA29_2 >= IntType && LA29_2 <= ObjectType)) )
                {
                    alt29 = 2;
                }
                else if ( (LA29_2 == Identifier || (LA29_2 >= IntegerAtom && LA29_2 <= BooleanAtom) || LA29_2 == StringAtom || LA29_2 == 40 || LA29_2 == 61 || LA29_2 == 68) )
                {
                    alt29 = 3;
                }
                else 
                {
                    NoViableAltException nvae_d29s2 =
                        new NoViableAltException("", 29, 2, input);

                    throw nvae_d29s2;
                }
                }
                break;
            case Identifier:
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case StringAtom:
            case 68:
            	{
                alt29 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d29s0 =
            	        new NoViableAltException("", 29, 0, input);

            	    throw nvae_d29s0;
            }

            switch (alt29) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:274:9: '!' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal101=(IToken)Match(input,67,FOLLOW_67_in_unaryExpressionNotPlusMinus1242); 
                    		char_literal101_tree = (object)adaptor.Create(char_literal101);
                    		adaptor.AddChild(root_0, char_literal101_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1244);
                    	unaryExpression102 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression102.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:275:9: castExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus1254);
                    	castExpression103 = castExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, castExpression103.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:277:9: mathAtom ( '++' | '--' )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus1269);
                    	mathAtom104 = mathAtom();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, mathAtom104.Tree);
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:277:18: ( '++' | '--' )?
                    	int alt28 = 2;
                    	int LA28_0 = input.LA(1);

                    	if ( ((LA28_0 >= 65 && LA28_0 <= 66)) )
                    	{
                    	    alt28 = 1;
                    	}
                    	switch (alt28) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
                    	        {
                    	        	set105 = (IToken)input.LT(1);
                    	        	if ( (input.LA(1) >= 65 && input.LA(1) <= 66) ) 
                    	        	{
                    	        	    input.Consume();
                    	        	    adaptor.AddChild(root_0, (object)adaptor.Create(set105));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:281:1: castExpression : '(' variableType ')' unaryExpression ;
    public SGLParser.castExpression_return castExpression() // throws RecognitionException [1]
    {   
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal106 = null;
        IToken char_literal108 = null;
        SGLParser.variableType_return variableType107 = default(SGLParser.variableType_return);

        SGLParser.unaryExpression_return unaryExpression109 = default(SGLParser.unaryExpression_return);


        object char_literal106_tree=null;
        object char_literal108_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:282:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:282:8: '(' variableType ')' unaryExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal106=(IToken)Match(input,40,FOLLOW_40_in_castExpression1302); 
            		char_literal106_tree = (object)adaptor.Create(char_literal106);
            		adaptor.AddChild(root_0, char_literal106_tree);

            	PushFollow(FOLLOW_variableType_in_castExpression1304);
            	variableType107 = variableType();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variableType107.Tree);
            	char_literal108=(IToken)Match(input,41,FOLLOW_41_in_castExpression1306); 
            		char_literal108_tree = (object)adaptor.Create(char_literal108);
            		adaptor.AddChild(root_0, char_literal108_tree);

            	PushFollow(FOLLOW_unaryExpression_in_castExpression1308);
            	unaryExpression109 = unaryExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, unaryExpression109.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:287:1: negativeExpression : ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) );
    public SGLParser.negativeExpression_return negativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.negativeExpression_return retval = new SGLParser.negativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal111 = null;
        SGLParser.mathAtom_return mathAtom110 = default(SGLParser.mathAtom_return);

        SGLParser.mathAtom_return mathAtom112 = default(SGLParser.mathAtom_return);


        object char_literal111_tree=null;
        RewriteRuleTokenStream stream_61 = new RewriteRuleTokenStream(adaptor,"token 61");
        RewriteRuleSubtreeStream stream_mathAtom = new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:288:2: ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) )
            int alt30 = 2;
            int LA30_0 = input.LA(1);

            if ( (LA30_0 == Identifier || (LA30_0 >= IntegerAtom && LA30_0 <= BooleanAtom) || LA30_0 == StringAtom || LA30_0 == 40 || LA30_0 == 68) )
            {
                alt30 = 1;
            }
            else if ( (LA30_0 == 61) )
            {
                alt30 = 2;
            }
            else 
            {
                NoViableAltException nvae_d30s0 =
                    new NoViableAltException("", 30, 0, input);

                throw nvae_d30s0;
            }
            switch (alt30) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:288:4: mathAtom
                    {
                    	PushFollow(FOLLOW_mathAtom_in_negativeExpression1326);
                    	mathAtom110 = mathAtom();
                    	state.followingStackPointer--;

                    	stream_mathAtom.Add(mathAtom110.Tree);


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
                    	// 288:13: -> mathAtom
                    	{
                    	    adaptor.AddChild(root_0, stream_mathAtom.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:289:4: ( '-' ) mathAtom
                    {
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:289:4: ( '-' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:289:5: '-'
                    	{
                    		char_literal111=(IToken)Match(input,61,FOLLOW_61_in_negativeExpression1336);  
                    		stream_61.Add(char_literal111);


                    	}

                    	PushFollow(FOLLOW_mathAtom_in_negativeExpression1339);
                    	mathAtom112 = mathAtom();
                    	state.followingStackPointer--;

                    	stream_mathAtom.Add(mathAtom112.Tree);


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
                    	// 289:19: -> ^( NEGATE mathAtom )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:289:22: ^( NEGATE mathAtom )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:292:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation '(' ( arguments )? ')' -> ^( SpriteAnimation ( arguments )? ) | Identifier -> Identifier | Identifier '(' ( arguments )? ')' -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote );
    public SGLParser.mathAtom_return mathAtom() // throws RecognitionException [1]
    {   
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal113 = null;
        IToken char_literal115 = null;
        IToken IntegerAtom116 = null;
        IToken FloatAtom117 = null;
        IToken BooleanAtom118 = null;
        IToken string_literal119 = null;
        IToken SpriteAnimation120 = null;
        IToken char_literal121 = null;
        IToken char_literal123 = null;
        IToken Identifier124 = null;
        IToken Identifier125 = null;
        IToken char_literal126 = null;
        IToken char_literal128 = null;
        SGLParser.conditionalExpression_return conditionalExpression114 = default(SGLParser.conditionalExpression_return);

        SGLParser.arguments_return arguments122 = default(SGLParser.arguments_return);

        SGLParser.arguments_return arguments127 = default(SGLParser.arguments_return);

        SGLParser.stringQuote_return stringQuote129 = default(SGLParser.stringQuote_return);


        object char_literal113_tree=null;
        object char_literal115_tree=null;
        object IntegerAtom116_tree=null;
        object FloatAtom117_tree=null;
        object BooleanAtom118_tree=null;
        object string_literal119_tree=null;
        object SpriteAnimation120_tree=null;
        object char_literal121_tree=null;
        object char_literal123_tree=null;
        object Identifier124_tree=null;
        object Identifier125_tree=null;
        object char_literal126_tree=null;
        object char_literal128_tree=null;
        RewriteRuleTokenStream stream_SpriteAnimation = new RewriteRuleTokenStream(adaptor,"token SpriteAnimation");
        RewriteRuleTokenStream stream_68 = new RewriteRuleTokenStream(adaptor,"token 68");
        RewriteRuleTokenStream stream_41 = new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_40 = new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:293:5: ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation '(' ( arguments )? ')' -> ^( SpriteAnimation ( arguments )? ) | Identifier -> Identifier | Identifier '(' ( arguments )? ')' -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote )
            int alt33 = 8;
            alt33 = dfa33.Predict(input);
            switch (alt33) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:293:7: '(' conditionalExpression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal113=(IToken)Match(input,40,FOLLOW_40_in_mathAtom1361); 
                    	PushFollow(FOLLOW_conditionalExpression_in_mathAtom1364);
                    	conditionalExpression114 = conditionalExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, conditionalExpression114.Tree);
                    	char_literal115=(IToken)Match(input,41,FOLLOW_41_in_mathAtom1366); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:294:9: IntegerAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IntegerAtom116=(IToken)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom1377); 
                    		IntegerAtom116_tree = (object)adaptor.Create(IntegerAtom116);
                    		adaptor.AddChild(root_0, IntegerAtom116_tree);


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:295:7: FloatAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FloatAtom117=(IToken)Match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1385); 
                    		FloatAtom117_tree = (object)adaptor.Create(FloatAtom117);
                    		adaptor.AddChild(root_0, FloatAtom117_tree);


                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:296:9: BooleanAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BooleanAtom118=(IToken)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1395); 
                    		BooleanAtom118_tree = (object)adaptor.Create(BooleanAtom118);
                    		adaptor.AddChild(root_0, BooleanAtom118_tree);


                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:298:9: 'new' SpriteAnimation '(' ( arguments )? ')'
                    {
                    	string_literal119=(IToken)Match(input,68,FOLLOW_68_in_mathAtom1406);  
                    	stream_68.Add(string_literal119);

                    	SpriteAnimation120=(IToken)Match(input,SpriteAnimation,FOLLOW_SpriteAnimation_in_mathAtom1408);  
                    	stream_SpriteAnimation.Add(SpriteAnimation120);

                    	char_literal121=(IToken)Match(input,40,FOLLOW_40_in_mathAtom1410);  
                    	stream_40.Add(char_literal121);

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:298:35: ( arguments )?
                    	int alt31 = 2;
                    	int LA31_0 = input.LA(1);

                    	if ( (LA31_0 == Identifier || (LA31_0 >= IntegerAtom && LA31_0 <= BooleanAtom) || LA31_0 == StringAtom || LA31_0 == 40 || LA31_0 == 61 || LA31_0 == 68) )
                    	{
                    	    alt31 = 1;
                    	}
                    	switch (alt31) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:298:35: arguments
                    	        {
                    	        	PushFollow(FOLLOW_arguments_in_mathAtom1412);
                    	        	arguments122 = arguments();
                    	        	state.followingStackPointer--;

                    	        	stream_arguments.Add(arguments122.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal123=(IToken)Match(input,41,FOLLOW_41_in_mathAtom1415);  
                    	stream_41.Add(char_literal123);



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
                    	// 298:50: -> ^( SpriteAnimation ( arguments )? )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:298:53: ^( SpriteAnimation ( arguments )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_SpriteAnimation.NextNode(), root_1);

                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:298:71: ( arguments )?
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
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:300:4: Identifier
                    {
                    	Identifier124=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_mathAtom1431);  
                    	stream_Identifier.Add(Identifier124);



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
                    	// 300:15: -> Identifier
                    	{
                    	    adaptor.AddChild(root_0, stream_Identifier.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:301:4: Identifier '(' ( arguments )? ')'
                    {
                    	Identifier125=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_mathAtom1440);  
                    	stream_Identifier.Add(Identifier125);

                    	char_literal126=(IToken)Match(input,40,FOLLOW_40_in_mathAtom1442);  
                    	stream_40.Add(char_literal126);

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:301:19: ( arguments )?
                    	int alt32 = 2;
                    	int LA32_0 = input.LA(1);

                    	if ( (LA32_0 == Identifier || (LA32_0 >= IntegerAtom && LA32_0 <= BooleanAtom) || LA32_0 == StringAtom || LA32_0 == 40 || LA32_0 == 61 || LA32_0 == 68) )
                    	{
                    	    alt32 = 1;
                    	}
                    	switch (alt32) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:301:19: arguments
                    	        {
                    	        	PushFollow(FOLLOW_arguments_in_mathAtom1444);
                    	        	arguments127 = arguments();
                    	        	state.followingStackPointer--;

                    	        	stream_arguments.Add(arguments127.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal128=(IToken)Match(input,41,FOLLOW_41_in_mathAtom1447);  
                    	stream_41.Add(char_literal128);



                    	// AST REWRITE
                    	// elements:          arguments, Identifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 301:34: -> ^( LIBMETHOD Identifier ( arguments )? )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:301:37: ^( LIBMETHOD Identifier ( arguments )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LIBMETHOD, "LIBMETHOD"), root_1);

                    	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:301:60: ( arguments )?
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:302:4: stringQuote
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stringQuote_in_mathAtom1463);
                    	stringQuote129 = stringQuote();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, stringQuote129.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:306:1: arguments : expressionList ;
    public SGLParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.expressionList_return expressionList130 = default(SGLParser.expressionList_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:307:5: ( expressionList )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:307:10: expressionList
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expressionList_in_arguments1486);
            	expressionList130 = expressionList();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expressionList130.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:310:1: expressionList : expression ( ',' expression )* ;
    public SGLParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal132 = null;
        SGLParser.expression_return expression131 = default(SGLParser.expression_return);

        SGLParser.expression_return expression133 = default(SGLParser.expression_return);


        object char_literal132_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:311:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:311:9: expression ( ',' expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionList1509);
            	expression131 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression131.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:311:20: ( ',' expression )*
            	do 
            	{
            	    int alt34 = 2;
            	    int LA34_0 = input.LA(1);

            	    if ( (LA34_0 == 43) )
            	    {
            	        alt34 = 1;
            	    }


            	    switch (alt34) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:311:21: ',' expression
            			    {
            			    	char_literal132=(IToken)Match(input,43,FOLLOW_43_in_expressionList1512); 
            			    	PushFollow(FOLLOW_expression_in_expressionList1515);
            			    	expression133 = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expression133.Tree);

            			    }
            			    break;

            			default:
            			    goto loop34;
            	    }
            	} while (true);

            	loop34:
            		;	// Stops C# compiler whining that label 'loop34' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:1: idList : Identifier ( ',' Identifier )* -> ^( ID_LIST ( Identifier )+ ) ;
    public SGLParser.idList_return idList() // throws RecognitionException [1]
    {   
        SGLParser.idList_return retval = new SGLParser.idList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier134 = null;
        IToken char_literal135 = null;
        IToken Identifier136 = null;

        object Identifier134_tree=null;
        object char_literal135_tree=null;
        object Identifier136_tree=null;
        RewriteRuleTokenStream stream_43 = new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:315:3: ( Identifier ( ',' Identifier )* -> ^( ID_LIST ( Identifier )+ ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:315:6: Identifier ( ',' Identifier )*
            {
            	Identifier134=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_idList1534);  
            	stream_Identifier.Add(Identifier134);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:315:17: ( ',' Identifier )*
            	do 
            	{
            	    int alt35 = 2;
            	    int LA35_0 = input.LA(1);

            	    if ( (LA35_0 == 43) )
            	    {
            	        alt35 = 1;
            	    }


            	    switch (alt35) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:315:18: ',' Identifier
            			    {
            			    	char_literal135=(IToken)Match(input,43,FOLLOW_43_in_idList1537);  
            			    	stream_43.Add(char_literal135);

            			    	Identifier136=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_idList1539);  
            			    	stream_Identifier.Add(Identifier136);


            			    }
            			    break;

            			default:
            			    goto loop35;
            	    }
            	} while (true);

            	loop35:
            		;	// Stops C# compiler whining that label 'loop35' has no statements



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
            	// 315:35: -> ^( ID_LIST ( Identifier )+ )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:315:38: ^( ID_LIST ( Identifier )+ )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:318:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public SGLParser.literal_return literal() // throws RecognitionException [1]
    {   
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set137 = null;

        object set137_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:319:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set137 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == StringAtom || input.LA(1) == 69 ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set137));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:327:1: stringQuote : StringAtom -> ^( STRING StringAtom ) ;
    public SGLParser.stringQuote_return stringQuote() // throws RecognitionException [1]
    {   
        SGLParser.stringQuote_return retval = new SGLParser.stringQuote_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken StringAtom138 = null;

        object StringAtom138_tree=null;
        RewriteRuleTokenStream stream_StringAtom = new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:328:2: ( StringAtom -> ^( STRING StringAtom ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:328:6: StringAtom
            {
            	StringAtom138=(IToken)Match(input,StringAtom,FOLLOW_StringAtom_in_stringQuote1643);  
            	stream_StringAtom.Add(StringAtom138);



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
            	// 328:17: -> ^( STRING StringAtom )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:328:20: ^( STRING StringAtom )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STRING, "STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_StringAtom.NextNode());

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
    // $ANTLR end "stringQuote"

    // Delegated rules


   	protected DFA33 dfa33;
	private void InitializeCyclicDFAs()
	{
    	this.dfa33 = new DFA33(this);
	}

    const string DFA33_eotS =
        "\x0a\uffff";
    const string DFA33_eofS =
        "\x0a\uffff";
    const string DFA33_minS =
        "\x01\x12\x05\uffff\x01\x12\x03\uffff";
    const string DFA33_maxS =
        "\x01\x44\x05\uffff\x01\x42\x03\uffff";
    const string DFA33_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\uffff\x01"+
        "\x08\x01\x07\x01\x06";
    const string DFA33_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA33_transitionS = {
            "\x01\x06\x05\uffff\x01\x02\x01\x03\x01\x04\x01\uffff\x01\x07"+
            "\x0b\uffff\x01\x01\x1b\uffff\x01\x05",
            "",
            "",
            "",
            "",
            "",
            "\x06\x09\x0d\uffff\x01\x09\x02\uffff\x01\x08\x03\x09\x06\uffff"+
            "\x11\x09",
            "",
            "",
            ""
    };

    static readonly short[] DFA33_eot = DFA.UnpackEncodedString(DFA33_eotS);
    static readonly short[] DFA33_eof = DFA.UnpackEncodedString(DFA33_eofS);
    static readonly char[] DFA33_min = DFA.UnpackEncodedStringToUnsignedChars(DFA33_minS);
    static readonly char[] DFA33_max = DFA.UnpackEncodedStringToUnsignedChars(DFA33_maxS);
    static readonly short[] DFA33_accept = DFA.UnpackEncodedString(DFA33_acceptS);
    static readonly short[] DFA33_special = DFA.UnpackEncodedString(DFA33_specialS);
    static readonly short[][] DFA33_transition = DFA.UnpackEncodedStringArray(DFA33_transitionS);

    protected class DFA33 : DFA
    {
        public DFA33(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 33;
            this.eot = DFA33_eot;
            this.eof = DFA33_eof;
            this.min = DFA33_min;
            this.max = DFA33_max;
            this.accept = DFA33_accept;
            this.special = DFA33_special;
            this.transition = DFA33_transition;

        }

        override public string Description
        {
            get { return "292:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation '(' ( arguments )? ')' -> ^( SpriteAnimation ( arguments )? ) | Identifier -> Identifier | Identifier '(' ( arguments )? ')' -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_mainBlock_in_compilationUnit134 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mainStatement_in_mainBlock147 = new BitSet(new ulong[]{0x0001C08000FC0002UL});
    public static readonly BitSet FOLLOW_methodDef_in_mainBlock151 = new BitSet(new ulong[]{0x0001C08000FC0002UL});
    public static readonly BitSet FOLLOW_statement_in_block199 = new BitSet(new ulong[]{0x0001C00000FC0002UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_singleBlock227 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_singleBlock_in_commonBlock253 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_37_in_commonBlock258 = new BitSet(new ulong[]{0x0001C04000FC0000UL});
    public static readonly BitSet FOLLOW_block_in_commonBlock261 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_38_in_commonBlock263 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_39_in_methodDef297 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodDef299 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_methodDef301 = new BitSet(new ulong[]{0x0000020000040000UL});
    public static readonly BitSet FOLLOW_idList_in_methodDef303 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_methodDef306 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_mainStatement335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_semicolonStatement348 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_semicolonStatement354 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_objectMethod_in_semicolonStatement360 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_semicolonStatement365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_oneLineStatement378 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_oneLineStatement383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_statement399 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement404 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forLoop_in_statement414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclarationList430 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList432 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_43_in_variableDeclarationList435 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList437 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDecAssignment461 = new BitSet(new ulong[]{0x0000100000000002UL});
    public static readonly BitSet FOLLOW_44_in_variableDecAssignment464 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expression_in_variableDecAssignment466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableAssignment487 = new BitSet(new ulong[]{0x0000100000000000UL});
    public static readonly BitSet FOLLOW_44_in_variableAssignment489 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expression_in_variableAssignment491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName522 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_variableType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_objectMethod566 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_45_in_objectMethod568 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethod570 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_objectMethod572 = new BitSet(new ulong[]{0x2000030017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_arguments_in_objectMethod574 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_objectMethod577 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_whileLoop601 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop603 = new BitSet(new ulong[]{0x0000002000FC0000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_whileLoop605 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_forLoop627 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_forLoop629 = new BitSet(new ulong[]{0x0000040000FC0000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop633 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_forLoop636 = new BitSet(new ulong[]{0x2000050017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop640 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_42_in_forLoop643 = new BitSet(new ulong[]{0x0000020000FC0000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop647 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_forLoop650 = new BitSet(new ulong[]{0x0000002000FC0000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_forLoop652 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStat_in_ifStatement695 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_elseIfStat_in_ifStatement697 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_elseStat_in_ifStatement700 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_48_in_ifStat725 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expression_in_ifStat727 = new BitSet(new ulong[]{0x0000002000FC0000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_ifStat729 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_elseIfStat750 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_elseIfStat752 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expression_in_elseIfStat754 = new BitSet(new ulong[]{0x0000002000FC0000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseIfStat756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_elseStat778 = new BitSet(new ulong[]{0x0000002000FC0000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseStat780 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression843 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression884 = new BitSet(new ulong[]{0x0004000000000002UL});
    public static readonly BitSet FOLLOW_50_in_conditionalExpression888 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression891 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_conditionalExpression893 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression896 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression939 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_52_in_conditionalOrExpression943 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression946 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression977 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_conditionalAndExpression981 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression984 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1011 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_54_in_equalityExpression1016 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_55_in_equalityExpression1021 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1025 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1056 = new BitSet(new ulong[]{0x0F00000000000002UL});
    public static readonly BitSet FOLLOW_56_in_relationalExpression1060 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_57_in_relationalExpression1063 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_58_in_relationalExpression1066 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_59_in_relationalExpression1069 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1073 = new BitSet(new ulong[]{0x0F00000000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1111 = new BitSet(new ulong[]{0x3000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_additiveExpression1115 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_61_in_additiveExpression1118 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1122 = new BitSet(new ulong[]{0x3000000000000002UL});
    public static readonly BitSet FOLLOW_negativeExpression_in_multiplicativeExpression1156 = new BitSet(new ulong[]{0xC000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_62_in_multiplicativeExpression1164 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_63_in_multiplicativeExpression1167 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_64_in_multiplicativeExpression1170 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_negativeExpression_in_multiplicativeExpression1174 = new BitSet(new ulong[]{0xC000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_65_in_unaryExpression1197 = new BitSet(new ulong[]{0x0000010017040000UL,0x000000000000001EUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1199 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_unaryExpression1209 = new BitSet(new ulong[]{0x0000010017040000UL,0x000000000000001EUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1211 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1221 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_unaryExpressionNotPlusMinus1242 = new BitSet(new ulong[]{0x0000010017040000UL,0x000000000000001EUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1244 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus1254 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus1269 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000006UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus1271 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_castExpression1302 = new BitSet(new ulong[]{0x0000000000F80000UL});
    public static readonly BitSet FOLLOW_variableType_in_castExpression1304 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_castExpression1306 = new BitSet(new ulong[]{0x0000010017040000UL,0x000000000000001EUL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1308 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negativeExpression1326 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_negativeExpression1336 = new BitSet(new ulong[]{0x0000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negativeExpression1339 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_40_in_mathAtom1361 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_mathAtom1364 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_mathAtom1366 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom1377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_mathAtom1385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_mathAtom1395 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_68_in_mathAtom1406 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_SpriteAnimation_in_mathAtom1408 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_mathAtom1410 = new BitSet(new ulong[]{0x2000030017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_arguments_in_mathAtom1412 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_mathAtom1415 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_mathAtom1431 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_mathAtom1440 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_mathAtom1442 = new BitSet(new ulong[]{0x2000030017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_arguments_in_mathAtom1444 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_41_in_mathAtom1447 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stringQuote_in_mathAtom1463 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1486 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1509 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_43_in_expressionList1512 = new BitSet(new ulong[]{0x2000010017040000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1515 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_idList1534 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_43_in_idList1537 = new BitSet(new ulong[]{0x0000000000040000UL});
    public static readonly BitSet FOLLOW_Identifier_in_idList1539 = new BitSet(new ulong[]{0x0000080000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringAtom_in_stringQuote1643 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}