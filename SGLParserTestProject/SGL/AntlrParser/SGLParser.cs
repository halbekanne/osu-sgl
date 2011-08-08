// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g 2011-08-08 22:22:14

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
		"','", 
		"'='", 
		"'while'", 
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

    public const int SGLIDDigit = 25;
    public const int IntType = 13;
    public const int ID_LIST = 6;
    public const int EOF = -1;
    public const int Identifier = 12;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int StringType = 15;
    public const int SpriteAnimation = 21;
    public const int COMMENT = 30;
    public const int VARDEF = 7;
    public const int T__50 = 50;
    public const int BooleanType = 14;
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
    public const int LIBMETHOD = 10;
    public const int IntegerAtom = 18;
    public const int FloatType = 16;
    public const int StringAtom = 22;
    public const int HEX_DIGIT = 28;
    public const int NEGATE = 9;
    public const int BooleanAtom = 20;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 29;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 26;
    public const int BLOCK = 4;
    public const int ASSIGN = 8;
    public const int STATEMENTS = 5;
    public const int ObjectType = 17;
    public const int FloatAtom = 19;
    public const int OctalEscape = 27;
    public const int Letter = 24;
    public const int EscapeSequence = 23;
    public const int STRING = 11;

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:75:1: compilationUnit : mainBlock EOF ;
    public SGLParser.compilationUnit_return compilationUnit() // throws RecognitionException [1]
    {   
        SGLParser.compilationUnit_return retval = new SGLParser.compilationUnit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken EOF2 = null;
        SGLParser.mainBlock_return mainBlock1 = default(SGLParser.mainBlock_return);


        object EOF2_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:76:2: ( mainBlock EOF )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:76:4: mainBlock EOF
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mainBlock_in_compilationUnit111);
            	mainBlock1 = mainBlock();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, mainBlock1.Tree);
            	EOF2=(IToken)Match(input,EOF,FOLLOW_EOF_in_compilationUnit113); 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:79:1: mainBlock : ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) ;
    public SGLParser.mainBlock_return mainBlock() // throws RecognitionException [1]
    {   
        SGLParser.mainBlock_return retval = new SGLParser.mainBlock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.mainStatement_return mainStatement3 = default(SGLParser.mainStatement_return);

        SGLParser.methodDef_return methodDef4 = default(SGLParser.methodDef_return);


        RewriteRuleSubtreeStream stream_methodDef = new RewriteRuleSubtreeStream(adaptor,"rule methodDef");
        RewriteRuleSubtreeStream stream_mainStatement = new RewriteRuleSubtreeStream(adaptor,"rule mainStatement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:80:2: ( ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:80:4: ( mainStatement | methodDef )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:80:4: ( mainStatement | methodDef )*
            	do 
            	{
            	    int alt1 = 3;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= Identifier && LA1_0 <= ObjectType) || LA1_0 == 38) )
            	    {
            	        alt1 = 1;
            	    }
            	    else if ( (LA1_0 == 33) )
            	    {
            	        alt1 = 2;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:80:5: mainStatement
            			    {
            			    	PushFollow(FOLLOW_mainStatement_in_mainBlock126);
            			    	mainStatement3 = mainStatement();
            			    	state.followingStackPointer--;

            			    	stream_mainStatement.Add(mainStatement3.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:80:21: methodDef
            			    {
            			    	PushFollow(FOLLOW_methodDef_in_mainBlock130);
            			    	methodDef4 = methodDef();
            			    	state.followingStackPointer--;

            			    	stream_methodDef.Add(methodDef4.Tree);

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
            	// 81:8: -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:81:11: ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:81:19: ^( STATEMENTS ( mainStatement )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATEMENTS, "STATEMENTS"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:81:32: ( mainStatement )*
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:84:1: block : ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
    public SGLParser.block_return block() // throws RecognitionException [1]
    {   
        SGLParser.block_return retval = new SGLParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.statement_return statement5 = default(SGLParser.statement_return);


        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:2: ( ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:4: ( statement )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= Identifier && LA2_0 <= ObjectType) || LA2_0 == 38) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:4: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block178);
            			    	statement5 = statement();
            			    	state.followingStackPointer--;

            			    	stream_statement.Add(statement5.Tree);

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
            	// 86:3: -> ^( BLOCK ^( STATEMENTS ( statement )* ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:86:6: ^( BLOCK ^( STATEMENTS ( statement )* ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:86:14: ^( STATEMENTS ( statement )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATEMENTS, "STATEMENTS"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:86:27: ( statement )*
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:89:1: singleBlock : statement -> ^( BLOCK ^( STATEMENTS statement ) ) ;
    public SGLParser.singleBlock_return singleBlock() // throws RecognitionException [1]
    {   
        SGLParser.singleBlock_return retval = new SGLParser.singleBlock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.statement_return statement6 = default(SGLParser.statement_return);


        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:90:2: ( statement -> ^( BLOCK ^( STATEMENTS statement ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:90:4: statement
            {
            	PushFollow(FOLLOW_statement_in_singleBlock206);
            	statement6 = statement();
            	state.followingStackPointer--;

            	stream_statement.Add(statement6.Tree);


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
            	// 91:3: -> ^( BLOCK ^( STATEMENTS statement ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:91:6: ^( BLOCK ^( STATEMENTS statement ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:91:14: ^( STATEMENTS statement )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATEMENTS, "STATEMENTS"), root_2);

            	    adaptor.AddChild(root_2, stream_statement.NextTree());

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:94:1: commonBlock : ( singleBlock | '{' block '}' );
    public SGLParser.commonBlock_return commonBlock() // throws RecognitionException [1]
    {   
        SGLParser.commonBlock_return retval = new SGLParser.commonBlock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal8 = null;
        IToken char_literal10 = null;
        SGLParser.singleBlock_return singleBlock7 = default(SGLParser.singleBlock_return);

        SGLParser.block_return block9 = default(SGLParser.block_return);


        object char_literal8_tree=null;
        object char_literal10_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:95:2: ( singleBlock | '{' block '}' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= Identifier && LA3_0 <= ObjectType) || LA3_0 == 38) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == 31) )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:95:4: singleBlock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_singleBlock_in_commonBlock232);
                    	singleBlock7 = singleBlock();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, singleBlock7.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:96:4: '{' block '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal8=(IToken)Match(input,31,FOLLOW_31_in_commonBlock237); 
                    		char_literal8_tree = (object)adaptor.Create(char_literal8);
                    		adaptor.AddChild(root_0, char_literal8_tree);

                    	PushFollow(FOLLOW_block_in_commonBlock239);
                    	block9 = block();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block9.Tree);
                    	char_literal10=(IToken)Match(input,32,FOLLOW_32_in_commonBlock241); 
                    		char_literal10_tree = (object)adaptor.Create(char_literal10);
                    		adaptor.AddChild(root_0, char_literal10_tree);


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:100:1: methodDef : 'method' Identifier '(' ( idList )? ')' ;
    public SGLParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        SGLParser.methodDef_return retval = new SGLParser.methodDef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal11 = null;
        IToken Identifier12 = null;
        IToken char_literal13 = null;
        IToken char_literal15 = null;
        SGLParser.idList_return idList14 = default(SGLParser.idList_return);


        object string_literal11_tree=null;
        object Identifier12_tree=null;
        object char_literal13_tree=null;
        object char_literal15_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:101:3: ( 'method' Identifier '(' ( idList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:101:5: 'method' Identifier '(' ( idList )? ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal11=(IToken)Match(input,33,FOLLOW_33_in_methodDef274); 
            		string_literal11_tree = (object)adaptor.Create(string_literal11);
            		adaptor.AddChild(root_0, string_literal11_tree);

            	Identifier12=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodDef276); 
            		Identifier12_tree = (object)adaptor.Create(Identifier12);
            		adaptor.AddChild(root_0, Identifier12_tree);

            	char_literal13=(IToken)Match(input,34,FOLLOW_34_in_methodDef278); 
            		char_literal13_tree = (object)adaptor.Create(char_literal13);
            		adaptor.AddChild(root_0, char_literal13_tree);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:101:29: ( idList )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == Identifier) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:101:29: idList
            	        {
            	        	PushFollow(FOLLOW_idList_in_methodDef280);
            	        	idList14 = idList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, idList14.Tree);

            	        }
            	        break;

            	}

            	char_literal15=(IToken)Match(input,35,FOLLOW_35_in_methodDef283); 
            		char_literal15_tree = (object)adaptor.Create(char_literal15);
            		adaptor.AddChild(root_0, char_literal15_tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:105:1: mainStatement : statement ;
    public SGLParser.mainStatement_return mainStatement() // throws RecognitionException [1]
    {   
        SGLParser.mainStatement_return retval = new SGLParser.mainStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.statement_return statement16 = default(SGLParser.statement_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:106:2: ( statement )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:106:4: statement
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_statement_in_mainStatement312);
            	statement16 = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, statement16.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:110:1: statement : ( variableDeclarationList | variableAssignment -> ^( ASSIGN variableAssignment ) | whileLoop );
    public SGLParser.statement_return statement() // throws RecognitionException [1]
    {   
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.variableDeclarationList_return variableDeclarationList17 = default(SGLParser.variableDeclarationList_return);

        SGLParser.variableAssignment_return variableAssignment18 = default(SGLParser.variableAssignment_return);

        SGLParser.whileLoop_return whileLoop19 = default(SGLParser.whileLoop_return);


        RewriteRuleSubtreeStream stream_variableAssignment = new RewriteRuleSubtreeStream(adaptor,"rule variableAssignment");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:112:2: ( variableDeclarationList | variableAssignment -> ^( ASSIGN variableAssignment ) | whileLoop )
            int alt5 = 3;
            switch ( input.LA(1) ) 
            {
            case IntType:
            case BooleanType:
            case StringType:
            case FloatType:
            case ObjectType:
            	{
                alt5 = 1;
                }
                break;
            case Identifier:
            	{
                alt5 = 2;
                }
                break;
            case 38:
            	{
                alt5 = 3;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:112:4: variableDeclarationList
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableDeclarationList_in_statement327);
                    	variableDeclarationList17 = variableDeclarationList();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableDeclarationList17.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:113:4: variableAssignment
                    {
                    	PushFollow(FOLLOW_variableAssignment_in_statement333);
                    	variableAssignment18 = variableAssignment();
                    	state.followingStackPointer--;

                    	stream_variableAssignment.Add(variableAssignment18.Tree);


                    	// AST REWRITE
                    	// elements:          variableAssignment
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 113:23: -> ^( ASSIGN variableAssignment )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:113:26: ^( ASSIGN variableAssignment )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASSIGN, "ASSIGN"), root_1);

                    	    adaptor.AddChild(root_1, stream_variableAssignment.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:114:4: whileLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileLoop_in_statement346);
                    	whileLoop19 = whileLoop();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, whileLoop19.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:121:1: variableDeclarationList : variableType variableAssignment ( ',' variableAssignment )* -> ( ^( VARDEF variableType variableAssignment ) )+ ;
    public SGLParser.variableDeclarationList_return variableDeclarationList() // throws RecognitionException [1]
    {   
        SGLParser.variableDeclarationList_return retval = new SGLParser.variableDeclarationList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal22 = null;
        SGLParser.variableType_return variableType20 = default(SGLParser.variableType_return);

        SGLParser.variableAssignment_return variableAssignment21 = default(SGLParser.variableAssignment_return);

        SGLParser.variableAssignment_return variableAssignment23 = default(SGLParser.variableAssignment_return);


        object char_literal22_tree=null;
        RewriteRuleTokenStream stream_36 = new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleSubtreeStream stream_variableType = new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableAssignment = new RewriteRuleSubtreeStream(adaptor,"rule variableAssignment");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:2: ( variableType variableAssignment ( ',' variableAssignment )* -> ( ^( VARDEF variableType variableAssignment ) )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:4: variableType variableAssignment ( ',' variableAssignment )*
            {
            	PushFollow(FOLLOW_variableType_in_variableDeclarationList362);
            	variableType20 = variableType();
            	state.followingStackPointer--;

            	stream_variableType.Add(variableType20.Tree);
            	PushFollow(FOLLOW_variableAssignment_in_variableDeclarationList364);
            	variableAssignment21 = variableAssignment();
            	state.followingStackPointer--;

            	stream_variableAssignment.Add(variableAssignment21.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:36: ( ',' variableAssignment )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( (LA6_0 == 36) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:37: ',' variableAssignment
            			    {
            			    	char_literal22=(IToken)Match(input,36,FOLLOW_36_in_variableDeclarationList367);  
            			    	stream_36.Add(char_literal22);

            			    	PushFollow(FOLLOW_variableAssignment_in_variableDeclarationList369);
            			    	variableAssignment23 = variableAssignment();
            			    	state.followingStackPointer--;

            			    	stream_variableAssignment.Add(variableAssignment23.Tree);

            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements



            	// AST REWRITE
            	// elements:          variableAssignment, variableType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 122:62: -> ( ^( VARDEF variableType variableAssignment ) )+
            	{
            	    if ( !(stream_variableAssignment.HasNext() || stream_variableType.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_variableAssignment.HasNext() || stream_variableType.HasNext() )
            	    {
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:65: ^( VARDEF variableType variableAssignment )
            	        {
            	        object root_1 = (object)adaptor.GetNilNode();
            	        root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDEF, "VARDEF"), root_1);

            	        adaptor.AddChild(root_1, stream_variableType.NextTree());
            	        adaptor.AddChild(root_1, stream_variableAssignment.NextTree());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_variableAssignment.Reset();
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:125:1: variableAssignment : variableName ( '=' expression )? -> variableName ( expression )? ;
    public SGLParser.variableAssignment_return variableAssignment() // throws RecognitionException [1]
    {   
        SGLParser.variableAssignment_return retval = new SGLParser.variableAssignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal25 = null;
        SGLParser.variableName_return variableName24 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression26 = default(SGLParser.expression_return);


        object char_literal25_tree=null;
        RewriteRuleTokenStream stream_37 = new RewriteRuleTokenStream(adaptor,"token 37");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:126:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:126:4: variableName ( '=' expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableAssignment393);
            	variableName24 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName24.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:126:17: ( '=' expression )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == 37) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:126:18: '=' expression
            	        {
            	        	char_literal25=(IToken)Match(input,37,FOLLOW_37_in_variableAssignment396);  
            	        	stream_37.Add(char_literal25);

            	        	PushFollow(FOLLOW_expression_in_variableAssignment398);
            	        	expression26 = expression();
            	        	state.followingStackPointer--;

            	        	stream_expression.Add(expression26.Tree);

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
            	// 126:36: -> variableName ( expression )?
            	{
            	    adaptor.AddChild(root_0, stream_variableName.NextTree());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:126:52: ( expression )?
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:132:1: variableName : Identifier ;
    public SGLParser.variableName_return variableName() // throws RecognitionException [1]
    {   
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier27 = null;

        object Identifier27_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:133:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:133:4: Identifier
            {
            	root_0 = (object)adaptor.GetNilNode();

            	Identifier27=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableName426); 
            		Identifier27_tree = (object)adaptor.Create(Identifier27);
            		adaptor.AddChild(root_0, Identifier27_tree);


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:136:1: variableType : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public SGLParser.variableType_return variableType() // throws RecognitionException [1]
    {   
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set28 = null;

        object set28_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:137:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set28 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntType && input.LA(1) <= ObjectType) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set28));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:145:1: whileLoop : 'while' '(' expression ')' commonBlock -> ^( 'while' expression commonBlock ) ;
    public SGLParser.whileLoop_return whileLoop() // throws RecognitionException [1]
    {   
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal29 = null;
        IToken char_literal30 = null;
        IToken char_literal32 = null;
        SGLParser.expression_return expression31 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock33 = default(SGLParser.commonBlock_return);


        object string_literal29_tree=null;
        object char_literal30_tree=null;
        object char_literal32_tree=null;
        RewriteRuleTokenStream stream_35 = new RewriteRuleTokenStream(adaptor,"token 35");
        RewriteRuleTokenStream stream_34 = new RewriteRuleTokenStream(adaptor,"token 34");
        RewriteRuleTokenStream stream_38 = new RewriteRuleTokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:146:2: ( 'while' '(' expression ')' commonBlock -> ^( 'while' expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:146:4: 'while' '(' expression ')' commonBlock
            {
            	string_literal29=(IToken)Match(input,38,FOLLOW_38_in_whileLoop470);  
            	stream_38.Add(string_literal29);

            	char_literal30=(IToken)Match(input,34,FOLLOW_34_in_whileLoop472);  
            	stream_34.Add(char_literal30);

            	PushFollow(FOLLOW_expression_in_whileLoop474);
            	expression31 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression31.Tree);
            	char_literal32=(IToken)Match(input,35,FOLLOW_35_in_whileLoop476);  
            	stream_35.Add(char_literal32);

            	PushFollow(FOLLOW_commonBlock_in_whileLoop478);
            	commonBlock33 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock33.Tree);


            	// AST REWRITE
            	// elements:          38, expression, commonBlock
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 146:43: -> ^( 'while' expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:146:46: ^( 'while' expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_38.NextNode(), root_1);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:173:1: expression : conditionalExpression ;
    public SGLParser.expression_return expression() // throws RecognitionException [1]
    {   
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression34 = default(SGLParser.conditionalExpression_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:5: ( conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:8: conditionalExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalExpression_in_expression540);
            	conditionalExpression34 = conditionalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalExpression34.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public SGLParser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal36 = null;
        IToken char_literal38 = null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression35 = default(SGLParser.conditionalOrExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression37 = default(SGLParser.conditionalExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression39 = default(SGLParser.conditionalExpression_return);


        object char_literal36_tree=null;
        object char_literal38_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:184:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:184:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression581);
            	conditionalOrExpression35 = conditionalOrExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalOrExpression35.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:184:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt8 = 2;
            	int LA8_0 = input.LA(1);

            	if ( (LA8_0 == 39) )
            	{
            	    alt8 = 1;
            	}
            	switch (alt8) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:184:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	char_literal36=(IToken)Match(input,39,FOLLOW_39_in_conditionalExpression585); 
            	        		char_literal36_tree = (object)adaptor.Create(char_literal36);
            	        		root_0 = (object)adaptor.BecomeRoot(char_literal36_tree, root_0);

            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression588);
            	        	conditionalExpression37 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression37.Tree);
            	        	char_literal38=(IToken)Match(input,40,FOLLOW_40_in_conditionalExpression590); 
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression593);
            	        	conditionalExpression39 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression39.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:189:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public SGLParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal41 = null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression40 = default(SGLParser.conditionalAndExpression_return);

        SGLParser.conditionalAndExpression_return conditionalAndExpression42 = default(SGLParser.conditionalAndExpression_return);


        object string_literal41_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression636);
            	conditionalAndExpression40 = conditionalAndExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalAndExpression40.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 41) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:36: '||' conditionalAndExpression
            			    {
            			    	string_literal41=(IToken)Match(input,41,FOLLOW_41_in_conditionalOrExpression640); 
            			    		string_literal41_tree = (object)adaptor.Create(string_literal41);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal41_tree, root_0);

            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression643);
            			    	conditionalAndExpression42 = conditionalAndExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, conditionalAndExpression42.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:194:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public SGLParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal44 = null;
        SGLParser.equalityExpression_return equalityExpression43 = default(SGLParser.equalityExpression_return);

        SGLParser.equalityExpression_return equalityExpression45 = default(SGLParser.equalityExpression_return);


        object string_literal44_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:195:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:195:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression674);
            	equalityExpression43 = equalityExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, equalityExpression43.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:195:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == 42) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:195:30: '&&' equalityExpression
            			    {
            			    	string_literal44=(IToken)Match(input,42,FOLLOW_42_in_conditionalAndExpression678); 
            			    		string_literal44_tree = (object)adaptor.Create(string_literal44);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal44_tree, root_0);

            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression681);
            			    	equalityExpression45 = equalityExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, equalityExpression45.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:199:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public SGLParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal47 = null;
        IToken string_literal48 = null;
        SGLParser.relationalExpression_return relationalExpression46 = default(SGLParser.relationalExpression_return);

        SGLParser.relationalExpression_return relationalExpression49 = default(SGLParser.relationalExpression_return);


        object string_literal47_tree=null;
        object string_literal48_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression708);
            	relationalExpression46 = relationalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, relationalExpression46.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( ((LA12_0 >= 43 && LA12_0 <= 44)) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:32: ( '==' | '!=' )
            			    	int alt11 = 2;
            			    	int LA11_0 = input.LA(1);

            			    	if ( (LA11_0 == 43) )
            			    	{
            			    	    alt11 = 1;
            			    	}
            			    	else if ( (LA11_0 == 44) )
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:33: '=='
            			    	        {
            			    	        	string_literal47=(IToken)Match(input,43,FOLLOW_43_in_equalityExpression713); 
            			    	        		string_literal47_tree = (object)adaptor.Create(string_literal47);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal47_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:41: '!='
            			    	        {
            			    	        	string_literal48=(IToken)Match(input,44,FOLLOW_44_in_equalityExpression718); 
            			    	        		string_literal48_tree = (object)adaptor.Create(string_literal48);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal48_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression722);
            			    	relationalExpression49 = relationalExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, relationalExpression49.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:204:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public SGLParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal51 = null;
        IToken char_literal52 = null;
        IToken string_literal53 = null;
        IToken string_literal54 = null;
        SGLParser.additiveExpression_return additiveExpression50 = default(SGLParser.additiveExpression_return);

        SGLParser.additiveExpression_return additiveExpression55 = default(SGLParser.additiveExpression_return);


        object char_literal51_tree=null;
        object char_literal52_tree=null;
        object string_literal53_tree=null;
        object string_literal54_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression753);
            	additiveExpression50 = additiveExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additiveExpression50.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= 45 && LA14_0 <= 48)) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:29: ( '<' | '>' | '<=' | '>=' )
            			    	int alt13 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 45:
            			    		{
            			    	    alt13 = 1;
            			    	    }
            			    	    break;
            			    	case 46:
            			    		{
            			    	    alt13 = 2;
            			    	    }
            			    	    break;
            			    	case 47:
            			    		{
            			    	    alt13 = 3;
            			    	    }
            			    	    break;
            			    	case 48:
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:30: '<'
            			    	        {
            			    	        	char_literal51=(IToken)Match(input,45,FOLLOW_45_in_relationalExpression757); 
            			    	        		char_literal51_tree = (object)adaptor.Create(char_literal51);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal51_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:35: '>'
            			    	        {
            			    	        	char_literal52=(IToken)Match(input,46,FOLLOW_46_in_relationalExpression760); 
            			    	        		char_literal52_tree = (object)adaptor.Create(char_literal52);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal52_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:40: '<='
            			    	        {
            			    	        	string_literal53=(IToken)Match(input,47,FOLLOW_47_in_relationalExpression763); 
            			    	        		string_literal53_tree = (object)adaptor.Create(string_literal53);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal53_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:46: '>='
            			    	        {
            			    	        	string_literal54=(IToken)Match(input,48,FOLLOW_48_in_relationalExpression766); 
            			    	        		string_literal54_tree = (object)adaptor.Create(string_literal54);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal54_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression770);
            			    	additiveExpression55 = additiveExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, additiveExpression55.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:209:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public SGLParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal57 = null;
        IToken char_literal58 = null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression56 = default(SGLParser.multiplicativeExpression_return);

        SGLParser.multiplicativeExpression_return multiplicativeExpression59 = default(SGLParser.multiplicativeExpression_return);


        object char_literal57_tree=null;
        object char_literal58_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression808);
            	multiplicativeExpression56 = multiplicativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multiplicativeExpression56.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( ((LA16_0 >= 49 && LA16_0 <= 50)) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:35: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:35: ( '+' | '-' )
            			    	int alt15 = 2;
            			    	int LA15_0 = input.LA(1);

            			    	if ( (LA15_0 == 49) )
            			    	{
            			    	    alt15 = 1;
            			    	}
            			    	else if ( (LA15_0 == 50) )
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:36: '+'
            			    	        {
            			    	        	char_literal57=(IToken)Match(input,49,FOLLOW_49_in_additiveExpression812); 
            			    	        		char_literal57_tree = (object)adaptor.Create(char_literal57);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal57_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:41: '-'
            			    	        {
            			    	        	char_literal58=(IToken)Match(input,50,FOLLOW_50_in_additiveExpression815); 
            			    	        		char_literal58_tree = (object)adaptor.Create(char_literal58);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal58_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression819);
            			    	multiplicativeExpression59 = multiplicativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multiplicativeExpression59.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:214:1: multiplicativeExpression : negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* ;
    public SGLParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal61 = null;
        IToken char_literal62 = null;
        IToken char_literal63 = null;
        SGLParser.negativeExpression_return negativeExpression60 = default(SGLParser.negativeExpression_return);

        SGLParser.negativeExpression_return negativeExpression64 = default(SGLParser.negativeExpression_return);


        object char_literal61_tree=null;
        object char_literal62_tree=null;
        object char_literal63_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:215:5: ( negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:215:9: negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression853);
            	negativeExpression60 = negativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, negativeExpression60.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:5: ( ( '*' | '/' | '%' ) negativeExpression )*
            	do 
            	{
            	    int alt18 = 2;
            	    int LA18_0 = input.LA(1);

            	    if ( ((LA18_0 >= 51 && LA18_0 <= 53)) )
            	    {
            	        alt18 = 1;
            	    }


            	    switch (alt18) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:6: ( '*' | '/' | '%' ) negativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:6: ( '*' | '/' | '%' )
            			    	int alt17 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 51:
            			    		{
            			    	    alt17 = 1;
            			    	    }
            			    	    break;
            			    	case 52:
            			    		{
            			    	    alt17 = 2;
            			    	    }
            			    	    break;
            			    	case 53:
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:7: '*'
            			    	        {
            			    	        	char_literal61=(IToken)Match(input,51,FOLLOW_51_in_multiplicativeExpression861); 
            			    	        		char_literal61_tree = (object)adaptor.Create(char_literal61);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal61_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:12: '/'
            			    	        {
            			    	        	char_literal62=(IToken)Match(input,52,FOLLOW_52_in_multiplicativeExpression864); 
            			    	        		char_literal62_tree = (object)adaptor.Create(char_literal62);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal62_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:17: '%'
            			    	        {
            			    	        	char_literal63=(IToken)Match(input,53,FOLLOW_53_in_multiplicativeExpression867); 
            			    	        		char_literal63_tree = (object)adaptor.Create(char_literal63);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal63_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression871);
            			    	negativeExpression64 = negativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, negativeExpression64.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:219:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public SGLParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal65 = null;
        IToken string_literal67 = null;
        SGLParser.unaryExpression_return unaryExpression66 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpression_return unaryExpression68 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus69 = default(SGLParser.unaryExpressionNotPlusMinus_return);


        object string_literal65_tree=null;
        object string_literal67_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:220:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt19 = 3;
            switch ( input.LA(1) ) 
            {
            case 54:
            	{
                alt19 = 1;
                }
                break;
            case 55:
            	{
                alt19 = 2;
                }
                break;
            case Identifier:
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case StringAtom:
            case 34:
            case 56:
            case 57:
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:220:7: '++' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal65=(IToken)Match(input,54,FOLLOW_54_in_unaryExpression894); 
                    		string_literal65_tree = (object)adaptor.Create(string_literal65);
                    		adaptor.AddChild(root_0, string_literal65_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression896);
                    	unaryExpression66 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression66.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:221:9: '--' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal67=(IToken)Match(input,55,FOLLOW_55_in_unaryExpression906); 
                    		string_literal67_tree = (object)adaptor.Create(string_literal67);
                    		adaptor.AddChild(root_0, string_literal67_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression908);
                    	unaryExpression68 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression68.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:222:9: unaryExpressionNotPlusMinus
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression918);
                    	unaryExpressionNotPlusMinus69 = unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpressionNotPlusMinus69.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:226:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal70 = null;
        IToken set74 = null;
        SGLParser.unaryExpression_return unaryExpression71 = default(SGLParser.unaryExpression_return);

        SGLParser.castExpression_return castExpression72 = default(SGLParser.castExpression_return);

        SGLParser.mathAtom_return mathAtom73 = default(SGLParser.mathAtom_return);


        object char_literal70_tree=null;
        object set74_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:227:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt21 = 3;
            switch ( input.LA(1) ) 
            {
            case 56:
            	{
                alt21 = 1;
                }
                break;
            case 34:
            	{
                int LA21_2 = input.LA(2);

                if ( (LA21_2 == Identifier || (LA21_2 >= IntegerAtom && LA21_2 <= BooleanAtom) || LA21_2 == StringAtom || LA21_2 == 34 || LA21_2 == 50 || LA21_2 == 57) )
                {
                    alt21 = 3;
                }
                else if ( ((LA21_2 >= IntType && LA21_2 <= ObjectType)) )
                {
                    alt21 = 2;
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
            case FloatAtom:
            case BooleanAtom:
            case StringAtom:
            case 57:
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:227:9: '!' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal70=(IToken)Match(input,56,FOLLOW_56_in_unaryExpressionNotPlusMinus939); 
                    		char_literal70_tree = (object)adaptor.Create(char_literal70);
                    		adaptor.AddChild(root_0, char_literal70_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus941);
                    	unaryExpression71 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression71.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:9: castExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus951);
                    	castExpression72 = castExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, castExpression72.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:230:9: mathAtom ( '++' | '--' )?
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus966);
                    	mathAtom73 = mathAtom();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, mathAtom73.Tree);
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:230:18: ( '++' | '--' )?
                    	int alt20 = 2;
                    	int LA20_0 = input.LA(1);

                    	if ( ((LA20_0 >= 54 && LA20_0 <= 55)) )
                    	{
                    	    alt20 = 1;
                    	}
                    	switch (alt20) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
                    	        {
                    	        	set74 = (IToken)input.LT(1);
                    	        	if ( (input.LA(1) >= 54 && input.LA(1) <= 55) ) 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:234:1: castExpression : '(' variableType ')' unaryExpression ;
    public SGLParser.castExpression_return castExpression() // throws RecognitionException [1]
    {   
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal75 = null;
        IToken char_literal77 = null;
        SGLParser.variableType_return variableType76 = default(SGLParser.variableType_return);

        SGLParser.unaryExpression_return unaryExpression78 = default(SGLParser.unaryExpression_return);


        object char_literal75_tree=null;
        object char_literal77_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:235:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:235:8: '(' variableType ')' unaryExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal75=(IToken)Match(input,34,FOLLOW_34_in_castExpression999); 
            		char_literal75_tree = (object)adaptor.Create(char_literal75);
            		adaptor.AddChild(root_0, char_literal75_tree);

            	PushFollow(FOLLOW_variableType_in_castExpression1001);
            	variableType76 = variableType();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variableType76.Tree);
            	char_literal77=(IToken)Match(input,35,FOLLOW_35_in_castExpression1003); 
            		char_literal77_tree = (object)adaptor.Create(char_literal77);
            		adaptor.AddChild(root_0, char_literal77_tree);

            	PushFollow(FOLLOW_unaryExpression_in_castExpression1005);
            	unaryExpression78 = unaryExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, unaryExpression78.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:240:1: negativeExpression : ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) );
    public SGLParser.negativeExpression_return negativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.negativeExpression_return retval = new SGLParser.negativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal80 = null;
        SGLParser.mathAtom_return mathAtom79 = default(SGLParser.mathAtom_return);

        SGLParser.mathAtom_return mathAtom81 = default(SGLParser.mathAtom_return);


        object char_literal80_tree=null;
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_mathAtom = new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:241:2: ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) )
            int alt22 = 2;
            int LA22_0 = input.LA(1);

            if ( (LA22_0 == Identifier || (LA22_0 >= IntegerAtom && LA22_0 <= BooleanAtom) || LA22_0 == StringAtom || LA22_0 == 34 || LA22_0 == 57) )
            {
                alt22 = 1;
            }
            else if ( (LA22_0 == 50) )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:241:4: mathAtom
                    {
                    	PushFollow(FOLLOW_mathAtom_in_negativeExpression1023);
                    	mathAtom79 = mathAtom();
                    	state.followingStackPointer--;

                    	stream_mathAtom.Add(mathAtom79.Tree);


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
                    	// 241:13: -> mathAtom
                    	{
                    	    adaptor.AddChild(root_0, stream_mathAtom.NextTree());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:4: ( '-' ) mathAtom
                    {
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:4: ( '-' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:5: '-'
                    	{
                    		char_literal80=(IToken)Match(input,50,FOLLOW_50_in_negativeExpression1033);  
                    		stream_50.Add(char_literal80);


                    	}

                    	PushFollow(FOLLOW_mathAtom_in_negativeExpression1036);
                    	mathAtom81 = mathAtom();
                    	state.followingStackPointer--;

                    	stream_mathAtom.Add(mathAtom81.Tree);


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
                    	// 242:19: -> ^( NEGATE mathAtom )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:22: ^( NEGATE mathAtom )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:245:1: mathAtom : ( '(' additiveExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote );
    public SGLParser.mathAtom_return mathAtom() // throws RecognitionException [1]
    {   
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal82 = null;
        IToken char_literal84 = null;
        IToken IntegerAtom85 = null;
        IToken FloatAtom86 = null;
        IToken BooleanAtom87 = null;
        IToken string_literal88 = null;
        IToken SpriteAnimation89 = null;
        IToken Identifier91 = null;
        IToken Identifier92 = null;
        SGLParser.additiveExpression_return additiveExpression83 = default(SGLParser.additiveExpression_return);

        SGLParser.arguments_return arguments90 = default(SGLParser.arguments_return);

        SGLParser.arguments_return arguments93 = default(SGLParser.arguments_return);

        SGLParser.stringQuote_return stringQuote94 = default(SGLParser.stringQuote_return);


        object char_literal82_tree=null;
        object char_literal84_tree=null;
        object IntegerAtom85_tree=null;
        object FloatAtom86_tree=null;
        object BooleanAtom87_tree=null;
        object string_literal88_tree=null;
        object SpriteAnimation89_tree=null;
        object Identifier91_tree=null;
        object Identifier92_tree=null;
        RewriteRuleTokenStream stream_SpriteAnimation = new RewriteRuleTokenStream(adaptor,"token SpriteAnimation");
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:246:5: ( '(' additiveExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote )
            int alt23 = 8;
            alt23 = dfa23.Predict(input);
            switch (alt23) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:246:7: '(' additiveExpression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal82=(IToken)Match(input,34,FOLLOW_34_in_mathAtom1058); 
                    	PushFollow(FOLLOW_additiveExpression_in_mathAtom1061);
                    	additiveExpression83 = additiveExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, additiveExpression83.Tree);
                    	char_literal84=(IToken)Match(input,35,FOLLOW_35_in_mathAtom1063); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:9: IntegerAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IntegerAtom85=(IToken)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom1074); 
                    		IntegerAtom85_tree = (object)adaptor.Create(IntegerAtom85);
                    		adaptor.AddChild(root_0, IntegerAtom85_tree);


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:7: FloatAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FloatAtom86=(IToken)Match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1082); 
                    		FloatAtom86_tree = (object)adaptor.Create(FloatAtom86);
                    		adaptor.AddChild(root_0, FloatAtom86_tree);


                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:249:9: BooleanAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BooleanAtom87=(IToken)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1092); 
                    		BooleanAtom87_tree = (object)adaptor.Create(BooleanAtom87);
                    		adaptor.AddChild(root_0, BooleanAtom87_tree);


                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:251:9: 'new' SpriteAnimation arguments
                    {
                    	string_literal88=(IToken)Match(input,57,FOLLOW_57_in_mathAtom1103);  
                    	stream_57.Add(string_literal88);

                    	SpriteAnimation89=(IToken)Match(input,SpriteAnimation,FOLLOW_SpriteAnimation_in_mathAtom1105);  
                    	stream_SpriteAnimation.Add(SpriteAnimation89);

                    	PushFollow(FOLLOW_arguments_in_mathAtom1107);
                    	arguments90 = arguments();
                    	state.followingStackPointer--;

                    	stream_arguments.Add(arguments90.Tree);


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
                    	// 251:41: -> ^( SpriteAnimation arguments )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:251:44: ^( SpriteAnimation arguments )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:4: Identifier
                    {
                    	Identifier91=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_mathAtom1122);  
                    	stream_Identifier.Add(Identifier91);



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
                    	// 253:15: -> Identifier
                    	{
                    	    adaptor.AddChild(root_0, stream_Identifier.NextNode());

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:254:4: Identifier arguments
                    {
                    	Identifier92=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_mathAtom1131);  
                    	stream_Identifier.Add(Identifier92);

                    	PushFollow(FOLLOW_arguments_in_mathAtom1133);
                    	arguments93 = arguments();
                    	state.followingStackPointer--;

                    	stream_arguments.Add(arguments93.Tree);


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
                    	// 254:25: -> ^( LIBMETHOD Identifier ( arguments )? )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:254:28: ^( LIBMETHOD Identifier ( arguments )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LIBMETHOD, "LIBMETHOD"), root_1);

                    	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:254:51: ( arguments )?
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:255:4: stringQuote
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stringQuote_in_mathAtom1149);
                    	stringQuote94 = stringQuote();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, stringQuote94.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:259:1: arguments : '(' ( expressionList )? ')' ;
    public SGLParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal95 = null;
        IToken char_literal97 = null;
        SGLParser.expressionList_return expressionList96 = default(SGLParser.expressionList_return);


        object char_literal95_tree=null;
        object char_literal97_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:260:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:260:9: '(' ( expressionList )? ')'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal95=(IToken)Match(input,34,FOLLOW_34_in_arguments1171); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:260:14: ( expressionList )?
            	int alt24 = 2;
            	int LA24_0 = input.LA(1);

            	if ( (LA24_0 == Identifier || (LA24_0 >= IntegerAtom && LA24_0 <= BooleanAtom) || LA24_0 == StringAtom || LA24_0 == 34 || LA24_0 == 50 || LA24_0 == 57) )
            	{
            	    alt24 = 1;
            	}
            	switch (alt24) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:260:14: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments1174);
            	        	expressionList96 = expressionList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, expressionList96.Tree);

            	        }
            	        break;

            	}

            	char_literal97=(IToken)Match(input,35,FOLLOW_35_in_arguments1177); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:1: expressionList : expression ( ',' expression )* ;
    public SGLParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal99 = null;
        SGLParser.expression_return expression98 = default(SGLParser.expression_return);

        SGLParser.expression_return expression100 = default(SGLParser.expression_return);


        object char_literal99_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:264:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:264:9: expression ( ',' expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionList1201);
            	expression98 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression98.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:264:20: ( ',' expression )*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( (LA25_0 == 36) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:264:21: ',' expression
            			    {
            			    	char_literal99=(IToken)Match(input,36,FOLLOW_36_in_expressionList1204); 
            			    	PushFollow(FOLLOW_expression_in_expressionList1207);
            			    	expression100 = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expression100.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:267:1: idList : Identifier ( ',' Identifier )* -> ^( ID_LIST ( Identifier )+ ) ;
    public SGLParser.idList_return idList() // throws RecognitionException [1]
    {   
        SGLParser.idList_return retval = new SGLParser.idList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier101 = null;
        IToken char_literal102 = null;
        IToken Identifier103 = null;

        object Identifier101_tree=null;
        object char_literal102_tree=null;
        object Identifier103_tree=null;
        RewriteRuleTokenStream stream_36 = new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:3: ( Identifier ( ',' Identifier )* -> ^( ID_LIST ( Identifier )+ ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:6: Identifier ( ',' Identifier )*
            {
            	Identifier101=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_idList1226);  
            	stream_Identifier.Add(Identifier101);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:17: ( ',' Identifier )*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( (LA26_0 == 36) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:18: ',' Identifier
            			    {
            			    	char_literal102=(IToken)Match(input,36,FOLLOW_36_in_idList1229);  
            			    	stream_36.Add(char_literal102);

            			    	Identifier103=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_idList1231);  
            			    	stream_Identifier.Add(Identifier103);


            			    }
            			    break;

            			default:
            			    goto loop26;
            	    }
            	} while (true);

            	loop26:
            		;	// Stops C# compiler whining that label 'loop26' has no statements



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
            	// 268:35: -> ^( ID_LIST ( Identifier )+ )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:38: ^( ID_LIST ( Identifier )+ )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:271:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public SGLParser.literal_return literal() // throws RecognitionException [1]
    {   
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set104 = null;

        object set104_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:272:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set104 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == StringAtom || input.LA(1) == 58 ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set104));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:280:1: stringQuote : StringAtom -> ^( STRING StringAtom ) ;
    public SGLParser.stringQuote_return stringQuote() // throws RecognitionException [1]
    {   
        SGLParser.stringQuote_return retval = new SGLParser.stringQuote_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken StringAtom105 = null;

        object StringAtom105_tree=null;
        RewriteRuleTokenStream stream_StringAtom = new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:281:2: ( StringAtom -> ^( STRING StringAtom ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:281:8: StringAtom
            {
            	StringAtom105=(IToken)Match(input,StringAtom,FOLLOW_StringAtom_in_stringQuote1337);  
            	stream_StringAtom.Add(StringAtom105);



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
            	// 281:19: -> ^( STRING StringAtom )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:281:22: ^( STRING StringAtom )
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


   	protected DFA23 dfa23;
	private void InitializeCyclicDFAs()
	{
    	this.dfa23 = new DFA23(this);
	}

    const string DFA23_eotS =
        "\x0a\uffff";
    const string DFA23_eofS =
        "\x06\uffff\x01\x08\x03\uffff";
    const string DFA23_minS =
        "\x01\x0c\x05\uffff\x01\x0c\x03\uffff";
    const string DFA23_maxS =
        "\x01\x39\x05\uffff\x01\x37\x03\uffff";
    const string DFA23_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\uffff\x01"+
        "\x08\x01\x06\x01\x07";
    const string DFA23_specialS =
        "\x0a\uffff}>";
    static readonly string[] DFA23_transitionS = {
            "\x01\x06\x05\uffff\x01\x02\x01\x03\x01\x04\x01\uffff\x01\x07"+
            "\x0b\uffff\x01\x01\x16\uffff\x01\x05",
            "",
            "",
            "",
            "",
            "",
            "\x06\x08\x0e\uffff\x02\x08\x01\x09\x02\x08\x01\uffff\x12\x08",
            "",
            "",
            ""
    };

    static readonly short[] DFA23_eot = DFA.UnpackEncodedString(DFA23_eotS);
    static readonly short[] DFA23_eof = DFA.UnpackEncodedString(DFA23_eofS);
    static readonly char[] DFA23_min = DFA.UnpackEncodedStringToUnsignedChars(DFA23_minS);
    static readonly char[] DFA23_max = DFA.UnpackEncodedStringToUnsignedChars(DFA23_maxS);
    static readonly short[] DFA23_accept = DFA.UnpackEncodedString(DFA23_acceptS);
    static readonly short[] DFA23_special = DFA.UnpackEncodedString(DFA23_specialS);
    static readonly short[][] DFA23_transition = DFA.UnpackEncodedStringArray(DFA23_transitionS);

    protected class DFA23 : DFA
    {
        public DFA23(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 23;
            this.eot = DFA23_eot;
            this.eof = DFA23_eof;
            this.min = DFA23_min;
            this.max = DFA23_max;
            this.accept = DFA23_accept;
            this.special = DFA23_special;
            this.transition = DFA23_transition;

        }

        override public string Description
        {
            get { return "245:1: mathAtom : ( '(' additiveExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_mainBlock_in_compilationUnit111 = new BitSet(new ulong[]{0x0000000000000000UL});
    public static readonly BitSet FOLLOW_EOF_in_compilationUnit113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mainStatement_in_mainBlock126 = new BitSet(new ulong[]{0x000000420003F002UL});
    public static readonly BitSet FOLLOW_methodDef_in_mainBlock130 = new BitSet(new ulong[]{0x000000420003F002UL});
    public static readonly BitSet FOLLOW_statement_in_block178 = new BitSet(new ulong[]{0x000000400003F002UL});
    public static readonly BitSet FOLLOW_statement_in_singleBlock206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_singleBlock_in_commonBlock232 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_31_in_commonBlock237 = new BitSet(new ulong[]{0x000000410003F000UL});
    public static readonly BitSet FOLLOW_block_in_commonBlock239 = new BitSet(new ulong[]{0x0000000100000000UL});
    public static readonly BitSet FOLLOW_32_in_commonBlock241 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_33_in_methodDef274 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodDef276 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_34_in_methodDef278 = new BitSet(new ulong[]{0x0000000800001000UL});
    public static readonly BitSet FOLLOW_idList_in_methodDef280 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_methodDef283 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_mainStatement312 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_statement327 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_statement333 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement346 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclarationList362 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_variableDeclarationList364 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_36_in_variableDeclarationList367 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_variableDeclarationList369 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableAssignment393 = new BitSet(new ulong[]{0x0000002000000002UL});
    public static readonly BitSet FOLLOW_37_in_variableAssignment396 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_expression_in_variableAssignment398 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_variableType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_38_in_whileLoop470 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_34_in_whileLoop472 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop474 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_whileLoop476 = new BitSet(new ulong[]{0x000000408003F000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_whileLoop478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression540 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression581 = new BitSet(new ulong[]{0x0000008000000002UL});
    public static readonly BitSet FOLLOW_39_in_conditionalExpression585 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression588 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_conditionalExpression590 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression593 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression636 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_41_in_conditionalOrExpression640 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression643 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression674 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_42_in_conditionalAndExpression678 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression681 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression708 = new BitSet(new ulong[]{0x0000180000000002UL});
    public static readonly BitSet FOLLOW_43_in_equalityExpression713 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_44_in_equalityExpression718 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression722 = new BitSet(new ulong[]{0x0000180000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression753 = new BitSet(new ulong[]{0x0001E00000000002UL});
    public static readonly BitSet FOLLOW_45_in_relationalExpression757 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_46_in_relationalExpression760 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_47_in_relationalExpression763 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_48_in_relationalExpression766 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression770 = new BitSet(new ulong[]{0x0001E00000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression808 = new BitSet(new ulong[]{0x0006000000000002UL});
    public static readonly BitSet FOLLOW_49_in_additiveExpression812 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_50_in_additiveExpression815 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression819 = new BitSet(new ulong[]{0x0006000000000002UL});
    public static readonly BitSet FOLLOW_negativeExpression_in_multiplicativeExpression853 = new BitSet(new ulong[]{0x0038000000000002UL});
    public static readonly BitSet FOLLOW_51_in_multiplicativeExpression861 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_52_in_multiplicativeExpression864 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_53_in_multiplicativeExpression867 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_negativeExpression_in_multiplicativeExpression871 = new BitSet(new ulong[]{0x0038000000000002UL});
    public static readonly BitSet FOLLOW_54_in_unaryExpression894 = new BitSet(new ulong[]{0x03C00004005C1000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression896 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_unaryExpression906 = new BitSet(new ulong[]{0x03C00004005C1000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression908 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression918 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_unaryExpressionNotPlusMinus939 = new BitSet(new ulong[]{0x03C00004005C1000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus941 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus951 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus966 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus968 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_castExpression999 = new BitSet(new ulong[]{0x000000000003E000UL});
    public static readonly BitSet FOLLOW_variableType_in_castExpression1001 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_castExpression1003 = new BitSet(new ulong[]{0x03C00004005C1000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1005 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negativeExpression1023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_negativeExpression1033 = new BitSet(new ulong[]{0x02000004005C1000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negativeExpression1036 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_mathAtom1058 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_mathAtom1061 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_mathAtom1063 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom1074 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_mathAtom1082 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_mathAtom1092 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_mathAtom1103 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_SpriteAnimation_in_mathAtom1105 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_arguments_in_mathAtom1107 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_mathAtom1122 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_mathAtom1131 = new BitSet(new ulong[]{0x0000000400000000UL});
    public static readonly BitSet FOLLOW_arguments_in_mathAtom1133 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stringQuote_in_mathAtom1149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_arguments1171 = new BitSet(new ulong[]{0x0204000C005C1000UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1174 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_arguments1177 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1201 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_36_in_expressionList1204 = new BitSet(new ulong[]{0x02040004005C1000UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1207 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_idList1226 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_36_in_idList1229 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_Identifier_in_idList1231 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringAtom_in_stringQuote1337 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}