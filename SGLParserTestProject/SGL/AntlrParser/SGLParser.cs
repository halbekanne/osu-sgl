// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g 2011-09-03 20:29:19

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


	//using SGLParserTester;
	using System.Collections.Generic;
	using SGL;


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
		"STRINGNOQUOTES", 
		"PRINTLN", 
		"VARINC", 
		"VARDEC", 
		"BREAK", 
		"PARAM_TYPE_LIST", 
		"PARAM_NAME_LIST", 
		"FUNC_CALL", 
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
		"Layer", 
		"Origin", 
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
		"'void'", 
		"';'", 
		"','", 
		"'='", 
		"'.'", 
		"'while'", 
		"'for'", 
		"'if'", 
		"'else'", 
		"'break'", 
		"'println'", 
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
    public const int Origin = 37;
    public const int SGLIDDigit = 41;
    public const int PARAM_NAME_LIST = 24;
    public const int IntType = 27;
    public const int T__61 = 61;
    public const int ID_LIST = 8;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int BREAK = 22;
    public const int Identifier = 26;
    public const int FUNC_CALL = 25;
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
    public const int StringType = 29;
    public const int PRINTLN = 19;
    public const int T__59 = 59;
    public const int SpriteAnimation = 35;
    public const int COMMENT = 46;
    public const int STRINGNOQUOTES = 18;
    public const int VARDEF = 9;
    public const int T__50 = 50;
    public const int BooleanType = 28;
    public const int VARDEC = 21;
    public const int T__80 = 80;
    public const int T__47 = 47;
    public const int T__81 = 81;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int LIBMETHOD = 12;
    public const int IntegerAtom = 32;
    public const int FloatType = 30;
    public const int FORDEC = 15;
    public const int StringAtom = 38;
    public const int PARAM_TYPE_LIST = 23;
    public const int HEX_DIGIT = 44;
    public const int NEGATE = 11;
    public const int BooleanAtom = 34;
    public const int WS = 45;
    public const int FORCOND = 16;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int UnicodeEscape = 42;
    public const int BLOCK = 4;
    public const int ASSIGN = 10;
    public const int Layer = 36;
    public const int STATEMENTS = 5;
    public const int ObjectType = 31;
    public const int FloatAtom = 33;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int VARINC = 20;
    public const int T__74 = 74;
    public const int OctalEscape = 43;
    public const int Letter = 40;
    public const int EscapeSequence = 39;
    public const int T__73 = 73;
    public const int T__79 = 79;
    public const int STRING = 14;
    public const int T__78 = 78;
    public const int T__77 = 77;

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



            public Dictionary<String,Function> functions = new Dictionary<String,Function>();

        	private void DefineFunction(String id, Object type, Object idList, Object block) {
                    // 'idList' is possibly null!  Create an empty tree in that case.  
                    CommonTree idListTree = idList == null ? new CommonTree() : (CommonTree)idList;

                    // 'type' is never null
                    String typeString = ((CommonTree)type).ToString();
                    Console.WriteLine("function found! Name: " + id + " returns " + typeString); 

                    // 'block' is never null 
                    CommonTree blockTree = (CommonTree)block;

                    // The function name with the exact same type of parameters after it, is the unique key 
                    String key = id;

                    Console.WriteLine("Adding the parameters:");
                    for (int a = 0; a < idListTree.GetChild(0).ChildCount; a++) {
                        key += "-" + idListTree.GetChild(0).GetChild(a).ToString();
                        Console.WriteLine("added " + idListTree.GetChild(0).GetChild(a).ToString());
                    }
                    //idListTree.GetChild(1).ChildCount;
                    functions.Add(key, new Function(id, typeString, idListTree, blockTree));
                    Console.WriteLine("Function " + id + " saved, unique key: " + key);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:117:1: compilationUnit : mainBlock ;
    public SGLParser.compilationUnit_return compilationUnit() // throws RecognitionException [1]
    {   
        SGLParser.compilationUnit_return retval = new SGLParser.compilationUnit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.mainBlock_return mainBlock1 = default(SGLParser.mainBlock_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:118:2: ( mainBlock )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:118:4: mainBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mainBlock_in_compilationUnit166);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:121:1: mainBlock : ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:2: ( ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:4: ( mainStatement | methodDef )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:4: ( mainStatement | methodDef )*
            	do 
            	{
            	    int alt1 = 3;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= Identifier && LA1_0 <= ObjectType) || (LA1_0 >= 57 && LA1_0 <= 59) || (LA1_0 >= 61 && LA1_0 <= 62)) )
            	    {
            	        alt1 = 1;
            	    }
            	    else if ( (LA1_0 == 49) )
            	    {
            	        alt1 = 2;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:5: mainStatement
            			    {
            			    	PushFollow(FOLLOW_mainStatement_in_mainBlock179);
            			    	mainStatement2 = mainStatement();
            			    	state.followingStackPointer--;

            			    	stream_mainStatement.Add(mainStatement2.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:21: methodDef
            			    {
            			    	PushFollow(FOLLOW_methodDef_in_mainBlock183);
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
            	// 123:8: -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:123:11: ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:123:19: ^( STATEMENTS ( mainStatement )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATEMENTS, "STATEMENTS"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:123:32: ( mainStatement )*
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:126:1: block : ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
    public SGLParser.block_return block() // throws RecognitionException [1]
    {   
        SGLParser.block_return retval = new SGLParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.statement_return statement4 = default(SGLParser.statement_return);


        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:127:2: ( ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:127:4: ( statement )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:127:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= Identifier && LA2_0 <= ObjectType) || (LA2_0 >= 57 && LA2_0 <= 59) || (LA2_0 >= 61 && LA2_0 <= 62)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:127:4: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block231);
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
            	// 128:3: -> ^( BLOCK ^( STATEMENTS ( statement )* ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:128:6: ^( BLOCK ^( STATEMENTS ( statement )* ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:128:14: ^( STATEMENTS ( statement )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATEMENTS, "STATEMENTS"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:128:27: ( statement )*
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:131:1: singleBlock : semicolonStatement -> ^( BLOCK ^( STATEMENTS semicolonStatement ) ) ;
    public SGLParser.singleBlock_return singleBlock() // throws RecognitionException [1]
    {   
        SGLParser.singleBlock_return retval = new SGLParser.singleBlock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement5 = default(SGLParser.semicolonStatement_return);


        RewriteRuleSubtreeStream stream_semicolonStatement = new RewriteRuleSubtreeStream(adaptor,"rule semicolonStatement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:132:2: ( semicolonStatement -> ^( BLOCK ^( STATEMENTS semicolonStatement ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:132:4: semicolonStatement
            {
            	PushFollow(FOLLOW_semicolonStatement_in_singleBlock259);
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
            	// 133:3: -> ^( BLOCK ^( STATEMENTS semicolonStatement ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:133:6: ^( BLOCK ^( STATEMENTS semicolonStatement ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:133:14: ^( STATEMENTS semicolonStatement )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:136:1: commonBlock : ( singleBlock | '{' block '}' );
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:137:2: ( singleBlock | '{' block '}' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= Identifier && LA3_0 <= ObjectType) || (LA3_0 >= 61 && LA3_0 <= 62)) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == 47) )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:137:4: singleBlock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_singleBlock_in_commonBlock285);
                    	singleBlock6 = singleBlock();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, singleBlock6.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:138:4: '{' block '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal7=(IToken)Match(input,47,FOLLOW_47_in_commonBlock290); 
                    	PushFollow(FOLLOW_block_in_commonBlock293);
                    	block8 = block();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block8.Tree);
                    	char_literal9=(IToken)Match(input,48,FOLLOW_48_in_commonBlock295); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:142:1: methodDef : 'method' methodType Identifier '(' ( paramList )? ')' commonBlock ;
    public SGLParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        SGLParser.methodDef_return retval = new SGLParser.methodDef_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal10 = null;
        IToken Identifier12 = null;
        IToken char_literal13 = null;
        IToken char_literal15 = null;
        SGLParser.methodType_return methodType11 = default(SGLParser.methodType_return);

        SGLParser.paramList_return paramList14 = default(SGLParser.paramList_return);

        SGLParser.commonBlock_return commonBlock16 = default(SGLParser.commonBlock_return);


        object string_literal10_tree=null;
        object Identifier12_tree=null;
        object char_literal13_tree=null;
        object char_literal15_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:143:3: ( 'method' methodType Identifier '(' ( paramList )? ')' commonBlock )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:143:5: 'method' methodType Identifier '(' ( paramList )? ')' commonBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal10=(IToken)Match(input,49,FOLLOW_49_in_methodDef327); 
            		string_literal10_tree = (object)adaptor.Create(string_literal10);
            		adaptor.AddChild(root_0, string_literal10_tree);

            	PushFollow(FOLLOW_methodType_in_methodDef329);
            	methodType11 = methodType();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, methodType11.Tree);
            	Identifier12=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodDef331); 
            		Identifier12_tree = (object)adaptor.Create(Identifier12);
            		adaptor.AddChild(root_0, Identifier12_tree);

            	char_literal13=(IToken)Match(input,50,FOLLOW_50_in_methodDef333); 
            		char_literal13_tree = (object)adaptor.Create(char_literal13);
            		adaptor.AddChild(root_0, char_literal13_tree);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:143:40: ( paramList )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( ((LA4_0 >= IntType && LA4_0 <= ObjectType)) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:143:40: paramList
            	        {
            	        	PushFollow(FOLLOW_paramList_in_methodDef335);
            	        	paramList14 = paramList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, paramList14.Tree);

            	        }
            	        break;

            	}

            	char_literal15=(IToken)Match(input,51,FOLLOW_51_in_methodDef338); 
            		char_literal15_tree = (object)adaptor.Create(char_literal15);
            		adaptor.AddChild(root_0, char_literal15_tree);

            	PushFollow(FOLLOW_commonBlock_in_methodDef340);
            	commonBlock16 = commonBlock();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, commonBlock16.Tree);
            	 DefineFunction(((Identifier12 != null) ? Identifier12.Text : null), ((methodType11 != null) ? ((object)methodType11.Tree) : null), ((paramList14 != null) ? ((object)paramList14.Tree) : null), ((commonBlock16 != null) ? ((object)commonBlock16.Tree) : null)); 

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

    public class methodType_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "methodType"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:147:1: methodType : ( variableType | 'void' );
    public SGLParser.methodType_return methodType() // throws RecognitionException [1]
    {   
        SGLParser.methodType_return retval = new SGLParser.methodType_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal18 = null;
        SGLParser.variableType_return variableType17 = default(SGLParser.variableType_return);


        object string_literal18_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:148:2: ( variableType | 'void' )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( ((LA5_0 >= IntType && LA5_0 <= ObjectType)) )
            {
                alt5 = 1;
            }
            else if ( (LA5_0 == 52) )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:148:4: variableType
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableType_in_methodType360);
                    	variableType17 = variableType();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableType17.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:149:4: 'void'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal18=(IToken)Match(input,52,FOLLOW_52_in_methodType365); 
                    		string_literal18_tree = (object)adaptor.Create(string_literal18);
                    		adaptor.AddChild(root_0, string_literal18_tree);


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
    // $ANTLR end "methodType"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:152:1: mainStatement : statement ;
    public SGLParser.mainStatement_return mainStatement() // throws RecognitionException [1]
    {   
        SGLParser.mainStatement_return retval = new SGLParser.mainStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.statement_return statement19 = default(SGLParser.statement_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:153:2: ( statement )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:153:4: statement
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_statement_in_mainStatement389);
            	statement19 = statement();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, statement19.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:156:1: semicolonStatement : ( variableDeclarationList | variableAssignment | variableUnaryChange | functionCall | objectMethod | breakStat ) ';' ;
    public SGLParser.semicolonStatement_return semicolonStatement() // throws RecognitionException [1]
    {   
        SGLParser.semicolonStatement_return retval = new SGLParser.semicolonStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal26 = null;
        SGLParser.variableDeclarationList_return variableDeclarationList20 = default(SGLParser.variableDeclarationList_return);

        SGLParser.variableAssignment_return variableAssignment21 = default(SGLParser.variableAssignment_return);

        SGLParser.variableUnaryChange_return variableUnaryChange22 = default(SGLParser.variableUnaryChange_return);

        SGLParser.functionCall_return functionCall23 = default(SGLParser.functionCall_return);

        SGLParser.objectMethod_return objectMethod24 = default(SGLParser.objectMethod_return);

        SGLParser.breakStat_return breakStat25 = default(SGLParser.breakStat_return);


        object char_literal26_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:157:2: ( ( variableDeclarationList | variableAssignment | variableUnaryChange | functionCall | objectMethod | breakStat ) ';' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:157:4: ( variableDeclarationList | variableAssignment | variableUnaryChange | functionCall | objectMethod | breakStat ) ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:157:4: ( variableDeclarationList | variableAssignment | variableUnaryChange | functionCall | objectMethod | breakStat )
            	int alt6 = 6;
            	switch ( input.LA(1) ) 
            	{
            	case IntType:
            	case BooleanType:
            	case StringType:
            	case FloatType:
            	case ObjectType:
            		{
            	    alt6 = 1;
            	    }
            	    break;
            	case Identifier:
            		{
            	    switch ( input.LA(2) ) 
            	    {
            	    case 50:
            	    	{
            	        alt6 = 4;
            	        }
            	        break;
            	    case 55:
            	    	{
            	        alt6 = 2;
            	        }
            	        break;
            	    case 56:
            	    	{
            	        alt6 = 5;
            	        }
            	        break;
            	    case 78:
            	    case 79:
            	    	{
            	        alt6 = 3;
            	        }
            	        break;
            	    	default:
            	    	    NoViableAltException nvae_d6s2 =
            	    	        new NoViableAltException("", 6, 2, input);

            	    	    throw nvae_d6s2;
            	    }

            	    }
            	    break;
            	case 62:
            		{
            	    alt6 = 4;
            	    }
            	    break;
            	case 61:
            		{
            	    alt6 = 6;
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
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:157:5: variableDeclarationList
            	        {
            	        	PushFollow(FOLLOW_variableDeclarationList_in_semicolonStatement402);
            	        	variableDeclarationList20 = variableDeclarationList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variableDeclarationList20.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:158:4: variableAssignment
            	        {
            	        	PushFollow(FOLLOW_variableAssignment_in_semicolonStatement408);
            	        	variableAssignment21 = variableAssignment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variableAssignment21.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:159:4: variableUnaryChange
            	        {
            	        	PushFollow(FOLLOW_variableUnaryChange_in_semicolonStatement414);
            	        	variableUnaryChange22 = variableUnaryChange();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variableUnaryChange22.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:160:4: functionCall
            	        {
            	        	PushFollow(FOLLOW_functionCall_in_semicolonStatement420);
            	        	functionCall23 = functionCall();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, functionCall23.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:161:4: objectMethod
            	        {
            	        	PushFollow(FOLLOW_objectMethod_in_semicolonStatement425);
            	        	objectMethod24 = objectMethod();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, objectMethod24.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:162:4: breakStat
            	        {
            	        	PushFollow(FOLLOW_breakStat_in_semicolonStatement430);
            	        	breakStat25 = breakStat();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, breakStat25.Tree);

            	        }
            	        break;

            	}

            	char_literal26=(IToken)Match(input,53,FOLLOW_53_in_semicolonStatement435); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:166:1: oneLineStatement : ( variableDeclarationList | variableAssignment | variableUnaryChange );
    public SGLParser.oneLineStatement_return oneLineStatement() // throws RecognitionException [1]
    {   
        SGLParser.oneLineStatement_return retval = new SGLParser.oneLineStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.variableDeclarationList_return variableDeclarationList27 = default(SGLParser.variableDeclarationList_return);

        SGLParser.variableAssignment_return variableAssignment28 = default(SGLParser.variableAssignment_return);

        SGLParser.variableUnaryChange_return variableUnaryChange29 = default(SGLParser.variableUnaryChange_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:167:2: ( variableDeclarationList | variableAssignment | variableUnaryChange )
            int alt7 = 3;
            int LA7_0 = input.LA(1);

            if ( ((LA7_0 >= IntType && LA7_0 <= ObjectType)) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == Identifier) )
            {
                int LA7_2 = input.LA(2);

                if ( ((LA7_2 >= 78 && LA7_2 <= 79)) )
                {
                    alt7 = 3;
                }
                else if ( (LA7_2 == 55) )
                {
                    alt7 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d7s2 =
                        new NoViableAltException("", 7, 2, input);

                    throw nvae_d7s2;
                }
            }
            else 
            {
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:167:4: variableDeclarationList
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableDeclarationList_in_oneLineStatement448);
                    	variableDeclarationList27 = variableDeclarationList();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableDeclarationList27.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:168:4: variableAssignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableAssignment_in_oneLineStatement453);
                    	variableAssignment28 = variableAssignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableAssignment28.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:169:4: variableUnaryChange
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableUnaryChange_in_oneLineStatement458);
                    	variableUnaryChange29 = variableUnaryChange();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableUnaryChange29.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:173:1: statement : ( semicolonStatement | ifStatement | whileLoop | forLoop );
    public SGLParser.statement_return statement() // throws RecognitionException [1]
    {   
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement30 = default(SGLParser.semicolonStatement_return);

        SGLParser.ifStatement_return ifStatement31 = default(SGLParser.ifStatement_return);

        SGLParser.whileLoop_return whileLoop32 = default(SGLParser.whileLoop_return);

        SGLParser.forLoop_return forLoop33 = default(SGLParser.forLoop_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:175:2: ( semicolonStatement | ifStatement | whileLoop | forLoop )
            int alt8 = 4;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            case IntType:
            case BooleanType:
            case StringType:
            case FloatType:
            case ObjectType:
            case 61:
            case 62:
            	{
                alt8 = 1;
                }
                break;
            case 59:
            	{
                alt8 = 2;
                }
                break;
            case 57:
            	{
                alt8 = 3;
                }
                break;
            case 58:
            	{
                alt8 = 4;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:175:4: semicolonStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_semicolonStatement_in_statement474);
                    	semicolonStatement30 = semicolonStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, semicolonStatement30.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:176:4: ifStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statement479);
                    	ifStatement31 = ifStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ifStatement31.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:177:4: whileLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileLoop_in_statement484);
                    	whileLoop32 = whileLoop();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, whileLoop32.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:4: forLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forLoop_in_statement489);
                    	forLoop33 = forLoop();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, forLoop33.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:185:1: variableDeclarationList : variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( VARDEF variableType variableDecAssignment ) )+ ;
    public SGLParser.variableDeclarationList_return variableDeclarationList() // throws RecognitionException [1]
    {   
        SGLParser.variableDeclarationList_return retval = new SGLParser.variableDeclarationList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal36 = null;
        SGLParser.variableType_return variableType34 = default(SGLParser.variableType_return);

        SGLParser.variableDecAssignment_return variableDecAssignment35 = default(SGLParser.variableDecAssignment_return);

        SGLParser.variableDecAssignment_return variableDecAssignment37 = default(SGLParser.variableDecAssignment_return);


        object char_literal36_tree=null;
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_variableType = new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableDecAssignment = new RewriteRuleSubtreeStream(adaptor,"rule variableDecAssignment");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:186:2: ( variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( VARDEF variableType variableDecAssignment ) )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:186:4: variableType variableDecAssignment ( ',' variableDecAssignment )*
            {
            	PushFollow(FOLLOW_variableType_in_variableDeclarationList505);
            	variableType34 = variableType();
            	state.followingStackPointer--;

            	stream_variableType.Add(variableType34.Tree);
            	PushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList507);
            	variableDecAssignment35 = variableDecAssignment();
            	state.followingStackPointer--;

            	stream_variableDecAssignment.Add(variableDecAssignment35.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:186:39: ( ',' variableDecAssignment )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 54) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:186:40: ',' variableDecAssignment
            			    {
            			    	char_literal36=(IToken)Match(input,54,FOLLOW_54_in_variableDeclarationList510);  
            			    	stream_54.Add(char_literal36);

            			    	PushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList512);
            			    	variableDecAssignment37 = variableDecAssignment();
            			    	state.followingStackPointer--;

            			    	stream_variableDecAssignment.Add(variableDecAssignment37.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements



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
            	// 186:68: -> ( ^( VARDEF variableType variableDecAssignment ) )+
            	{
            	    if ( !(stream_variableDecAssignment.HasNext() || stream_variableType.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_variableDecAssignment.HasNext() || stream_variableType.HasNext() )
            	    {
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:186:71: ^( VARDEF variableType variableDecAssignment )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:189:1: variableDecAssignment : variableName ( '=' expression )? -> variableName ( expression )? ;
    public SGLParser.variableDecAssignment_return variableDecAssignment() // throws RecognitionException [1]
    {   
        SGLParser.variableDecAssignment_return retval = new SGLParser.variableDecAssignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal39 = null;
        SGLParser.variableName_return variableName38 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression40 = default(SGLParser.expression_return);


        object char_literal39_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:4: variableName ( '=' expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableDecAssignment536);
            	variableName38 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName38.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:17: ( '=' expression )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == 55) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:18: '=' expression
            	        {
            	        	char_literal39=(IToken)Match(input,55,FOLLOW_55_in_variableDecAssignment539);  
            	        	stream_55.Add(char_literal39);

            	        	PushFollow(FOLLOW_expression_in_variableDecAssignment541);
            	        	expression40 = expression();
            	        	state.followingStackPointer--;

            	        	stream_expression.Add(expression40.Tree);

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
            	// 190:36: -> variableName ( expression )?
            	{
            	    adaptor.AddChild(root_0, stream_variableName.NextTree());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:52: ( expression )?
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:193:1: variableAssignment : variableName '=' expression -> ^( ASSIGN variableName expression ) ;
    public SGLParser.variableAssignment_return variableAssignment() // throws RecognitionException [1]
    {   
        SGLParser.variableAssignment_return retval = new SGLParser.variableAssignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal42 = null;
        SGLParser.variableName_return variableName41 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression43 = default(SGLParser.expression_return);


        object char_literal42_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:194:2: ( variableName '=' expression -> ^( ASSIGN variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:194:4: variableName '=' expression
            {
            	PushFollow(FOLLOW_variableName_in_variableAssignment562);
            	variableName41 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName41.Tree);
            	char_literal42=(IToken)Match(input,55,FOLLOW_55_in_variableAssignment564);  
            	stream_55.Add(char_literal42);

            	PushFollow(FOLLOW_expression_in_variableAssignment566);
            	expression43 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression43.Tree);


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
            	// 194:33: -> ^( ASSIGN variableName expression )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:194:36: ^( ASSIGN variableName expression )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:202:1: variableName : Identifier ;
    public SGLParser.variableName_return variableName() // throws RecognitionException [1]
    {   
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier44 = null;

        object Identifier44_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:203:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:203:4: Identifier
            {
            	root_0 = (object)adaptor.GetNilNode();

            	Identifier44=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableName597); 
            		Identifier44_tree = (object)adaptor.Create(Identifier44);
            		adaptor.AddChild(root_0, Identifier44_tree);


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:206:1: variableType : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public SGLParser.variableType_return variableType() // throws RecognitionException [1]
    {   
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set45 = null;

        object set45_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:207:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set45 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntType && input.LA(1) <= ObjectType) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set45));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:215:1: objectMethod : variableName '.' Identifier '(' ( arguments )? ')' -> ^( OBJMETHOD variableName Identifier ( arguments )? ) ;
    public SGLParser.objectMethod_return objectMethod() // throws RecognitionException [1]
    {   
        SGLParser.objectMethod_return retval = new SGLParser.objectMethod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal47 = null;
        IToken Identifier48 = null;
        IToken char_literal49 = null;
        IToken char_literal51 = null;
        SGLParser.variableName_return variableName46 = default(SGLParser.variableName_return);

        SGLParser.arguments_return arguments50 = default(SGLParser.arguments_return);


        object char_literal47_tree=null;
        object Identifier48_tree=null;
        object char_literal49_tree=null;
        object char_literal51_tree=null;
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:2: ( variableName '.' Identifier '(' ( arguments )? ')' -> ^( OBJMETHOD variableName Identifier ( arguments )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:4: variableName '.' Identifier '(' ( arguments )? ')'
            {
            	PushFollow(FOLLOW_variableName_in_objectMethod641);
            	variableName46 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName46.Tree);
            	char_literal47=(IToken)Match(input,56,FOLLOW_56_in_objectMethod643);  
            	stream_56.Add(char_literal47);

            	Identifier48=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_objectMethod645);  
            	stream_Identifier.Add(Identifier48);

            	char_literal49=(IToken)Match(input,50,FOLLOW_50_in_objectMethod647);  
            	stream_50.Add(char_literal49);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:36: ( arguments )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == Identifier || (LA11_0 >= IntegerAtom && LA11_0 <= BooleanAtom) || (LA11_0 >= Layer && LA11_0 <= StringAtom) || LA11_0 == 50 || LA11_0 == 74 || LA11_0 == 80) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:36: arguments
            	        {
            	        	PushFollow(FOLLOW_arguments_in_objectMethod649);
            	        	arguments50 = arguments();
            	        	state.followingStackPointer--;

            	        	stream_arguments.Add(arguments50.Tree);

            	        }
            	        break;

            	}

            	char_literal51=(IToken)Match(input,51,FOLLOW_51_in_objectMethod652);  
            	stream_51.Add(char_literal51);



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
            	// 216:51: -> ^( OBJMETHOD variableName Identifier ( arguments )? )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:54: ^( OBJMETHOD variableName Identifier ( arguments )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(OBJMETHOD, "OBJMETHOD"), root_1);

            	    adaptor.AddChild(root_1, stream_variableName.NextTree());
            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:90: ( arguments )?
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:219:1: whileLoop : 'while' expression commonBlock -> ^( 'while' expression commonBlock ) ;
    public SGLParser.whileLoop_return whileLoop() // throws RecognitionException [1]
    {   
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal52 = null;
        SGLParser.expression_return expression53 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock54 = default(SGLParser.commonBlock_return);


        object string_literal52_tree=null;
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:220:2: ( 'while' expression commonBlock -> ^( 'while' expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:220:4: 'while' expression commonBlock
            {
            	string_literal52=(IToken)Match(input,57,FOLLOW_57_in_whileLoop676);  
            	stream_57.Add(string_literal52);

            	PushFollow(FOLLOW_expression_in_whileLoop678);
            	expression53 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression53.Tree);
            	PushFollow(FOLLOW_commonBlock_in_whileLoop680);
            	commonBlock54 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock54.Tree);


            	// AST REWRITE
            	// elements:          expression, commonBlock, 57
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 220:35: -> ^( 'while' expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:220:38: ^( 'while' expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_57.NextNode(), root_1);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:1: forLoop : 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) ;
    public SGLParser.forLoop_return forLoop() // throws RecognitionException [1]
    {   
        SGLParser.forLoop_return retval = new SGLParser.forLoop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal55 = null;
        IToken char_literal56 = null;
        IToken char_literal57 = null;
        IToken char_literal58 = null;
        IToken char_literal59 = null;
        SGLParser.oneLineStatement_return dec = default(SGLParser.oneLineStatement_return);

        SGLParser.expression_return cond = default(SGLParser.expression_return);

        SGLParser.oneLineStatement_return iter = default(SGLParser.oneLineStatement_return);

        SGLParser.commonBlock_return commonBlock60 = default(SGLParser.commonBlock_return);


        object string_literal55_tree=null;
        object char_literal56_tree=null;
        object char_literal57_tree=null;
        object char_literal58_tree=null;
        object char_literal59_tree=null;
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        RewriteRuleSubtreeStream stream_oneLineStatement = new RewriteRuleSubtreeStream(adaptor,"rule oneLineStatement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:224:2: ( 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:224:4: 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock
            {
            	string_literal55=(IToken)Match(input,58,FOLLOW_58_in_forLoop702);  
            	stream_58.Add(string_literal55);

            	char_literal56=(IToken)Match(input,50,FOLLOW_50_in_forLoop704);  
            	stream_50.Add(char_literal56);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:224:17: (dec= oneLineStatement )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( ((LA12_0 >= Identifier && LA12_0 <= ObjectType)) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:224:17: dec= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop708);
            	        	dec = oneLineStatement();
            	        	state.followingStackPointer--;

            	        	stream_oneLineStatement.Add(dec.Tree);

            	        }
            	        break;

            	}

            	char_literal57=(IToken)Match(input,53,FOLLOW_53_in_forLoop711);  
            	stream_53.Add(char_literal57);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:224:44: (cond= expression )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == Identifier || (LA13_0 >= IntegerAtom && LA13_0 <= BooleanAtom) || (LA13_0 >= Layer && LA13_0 <= StringAtom) || LA13_0 == 50 || LA13_0 == 74 || LA13_0 == 80) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:224:44: cond= expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forLoop715);
            	        	cond = expression();
            	        	state.followingStackPointer--;

            	        	stream_expression.Add(cond.Tree);

            	        }
            	        break;

            	}

            	char_literal58=(IToken)Match(input,53,FOLLOW_53_in_forLoop718);  
            	stream_53.Add(char_literal58);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:224:65: (iter= oneLineStatement )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( ((LA14_0 >= Identifier && LA14_0 <= ObjectType)) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:224:65: iter= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop722);
            	        	iter = oneLineStatement();
            	        	state.followingStackPointer--;

            	        	stream_oneLineStatement.Add(iter.Tree);

            	        }
            	        break;

            	}

            	char_literal59=(IToken)Match(input,51,FOLLOW_51_in_forLoop725);  
            	stream_51.Add(char_literal59);

            	PushFollow(FOLLOW_commonBlock_in_forLoop727);
            	commonBlock60 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock60.Tree);


            	// AST REWRITE
            	// elements:          58, dec, cond, commonBlock, iter
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
            	// 225:2: -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:225:5: ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_58.NextNode(), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:225:13: ^( FORDEC ( $dec)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORDEC, "FORDEC"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:225:22: ( $dec)?
            	    if ( stream_dec.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_dec.NextTree());

            	    }
            	    stream_dec.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:225:29: ^( FORCOND ( $cond)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORCOND, "FORCOND"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:225:39: ( $cond)?
            	    if ( stream_cond.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_cond.NextTree());

            	    }
            	    stream_cond.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:225:47: ^( FORITER ( $iter)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORITER, "FORITER"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:225:57: ( $iter)?
            	    if ( stream_iter.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_iter.NextTree());

            	    }
            	    stream_iter.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:1: ifStatement : ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) ;
    public SGLParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        SGLParser.ifStatement_return retval = new SGLParser.ifStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.ifStat_return ifStat61 = default(SGLParser.ifStat_return);

        SGLParser.elseIfStat_return elseIfStat62 = default(SGLParser.elseIfStat_return);

        SGLParser.elseStat_return elseStat63 = default(SGLParser.elseStat_return);


        RewriteRuleSubtreeStream stream_elseIfStat = new RewriteRuleSubtreeStream(adaptor,"rule elseIfStat");
        RewriteRuleSubtreeStream stream_ifStat = new RewriteRuleSubtreeStream(adaptor,"rule ifStat");
        RewriteRuleSubtreeStream stream_elseStat = new RewriteRuleSubtreeStream(adaptor,"rule elseStat");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:229:2: ( ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:229:4: ifStat ( elseIfStat )* ( elseStat )?
            {
            	PushFollow(FOLLOW_ifStat_in_ifStatement772);
            	ifStat61 = ifStat();
            	state.followingStackPointer--;

            	stream_ifStat.Add(ifStat61.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:229:11: ( elseIfStat )*
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == 60) )
            	    {
            	        int LA15_1 = input.LA(2);

            	        if ( (LA15_1 == 59) )
            	        {
            	            alt15 = 1;
            	        }


            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:229:11: elseIfStat
            			    {
            			    	PushFollow(FOLLOW_elseIfStat_in_ifStatement774);
            			    	elseIfStat62 = elseIfStat();
            			    	state.followingStackPointer--;

            			    	stream_elseIfStat.Add(elseIfStat62.Tree);

            			    }
            			    break;

            			default:
            			    goto loop15;
            	    }
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:229:23: ( elseStat )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == 60) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:229:23: elseStat
            	        {
            	        	PushFollow(FOLLOW_elseStat_in_ifStatement777);
            	        	elseStat63 = elseStat();
            	        	state.followingStackPointer--;

            	        	stream_elseStat.Add(elseStat63.Tree);

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
            	// 229:33: -> ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:229:36: ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF, "IF"), root_1);

            	    adaptor.AddChild(root_1, stream_ifStat.NextTree());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:229:48: ( elseIfStat )*
            	    while ( stream_elseIfStat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_elseIfStat.NextTree());

            	    }
            	    stream_elseIfStat.Reset();
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:229:60: ( elseStat )?
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:1: ifStat : 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.ifStat_return ifStat() // throws RecognitionException [1]
    {   
        SGLParser.ifStat_return retval = new SGLParser.ifStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal64 = null;
        SGLParser.expression_return expression65 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock66 = default(SGLParser.commonBlock_return);


        object string_literal64_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:232:2: ( 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:232:4: 'if' expression commonBlock
            {
            	string_literal64=(IToken)Match(input,59,FOLLOW_59_in_ifStat802);  
            	stream_59.Add(string_literal64);

            	PushFollow(FOLLOW_expression_in_ifStat804);
            	expression65 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression65.Tree);
            	PushFollow(FOLLOW_commonBlock_in_ifStat806);
            	commonBlock66 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock66.Tree);


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
            	// 232:32: -> ^( EXP expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:232:35: ^( EXP expression commonBlock )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:235:1: elseIfStat : 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.elseIfStat_return elseIfStat() // throws RecognitionException [1]
    {   
        SGLParser.elseIfStat_return retval = new SGLParser.elseIfStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal67 = null;
        IToken string_literal68 = null;
        SGLParser.expression_return expression69 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock70 = default(SGLParser.commonBlock_return);


        object string_literal67_tree=null;
        object string_literal68_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:2: ( 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:4: 'else' 'if' expression commonBlock
            {
            	string_literal67=(IToken)Match(input,60,FOLLOW_60_in_elseIfStat827);  
            	stream_60.Add(string_literal67);

            	string_literal68=(IToken)Match(input,59,FOLLOW_59_in_elseIfStat829);  
            	stream_59.Add(string_literal68);

            	PushFollow(FOLLOW_expression_in_elseIfStat831);
            	expression69 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression69.Tree);
            	PushFollow(FOLLOW_commonBlock_in_elseIfStat833);
            	commonBlock70 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock70.Tree);


            	// AST REWRITE
            	// elements:          expression, commonBlock
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 236:39: -> ^( EXP expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:42: ^( EXP expression commonBlock )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:239:1: elseStat : 'else' commonBlock -> ^( EXP commonBlock ) ;
    public SGLParser.elseStat_return elseStat() // throws RecognitionException [1]
    {   
        SGLParser.elseStat_return retval = new SGLParser.elseStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal71 = null;
        SGLParser.commonBlock_return commonBlock72 = default(SGLParser.commonBlock_return);


        object string_literal71_tree=null;
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:240:2: ( 'else' commonBlock -> ^( EXP commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:240:4: 'else' commonBlock
            {
            	string_literal71=(IToken)Match(input,60,FOLLOW_60_in_elseStat855);  
            	stream_60.Add(string_literal71);

            	PushFollow(FOLLOW_commonBlock_in_elseStat857);
            	commonBlock72 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock72.Tree);


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
            	// 240:23: -> ^( EXP commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:240:26: ^( EXP commonBlock )
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

    public class breakStat_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "breakStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:1: breakStat : 'break' -> BREAK ;
    public SGLParser.breakStat_return breakStat() // throws RecognitionException [1]
    {   
        SGLParser.breakStat_return retval = new SGLParser.breakStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal73 = null;

        object string_literal73_tree=null;
        RewriteRuleTokenStream stream_61 = new RewriteRuleTokenStream(adaptor,"token 61");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:2: ( 'break' -> BREAK )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:4: 'break'
            {
            	string_literal73=(IToken)Match(input,61,FOLLOW_61_in_breakStat882);  
            	stream_61.Add(string_literal73);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 248:12: -> BREAK
            	{
            	    adaptor.AddChild(root_0, (object)adaptor.Create(BREAK, "BREAK"));

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
    // $ANTLR end "breakStat"

    public class functionCall_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functionCall"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:252:1: functionCall : ( Identifier '(' ( expressionList )? ')' -> ^( FUNC_CALL Identifier ( expressionList )? ) | 'println' '(' expression ')' -> ^( PRINTLN expression ) );
    public SGLParser.functionCall_return functionCall() // throws RecognitionException [1]
    {   
        SGLParser.functionCall_return retval = new SGLParser.functionCall_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier74 = null;
        IToken char_literal75 = null;
        IToken char_literal77 = null;
        IToken string_literal78 = null;
        IToken char_literal79 = null;
        IToken char_literal81 = null;
        SGLParser.expressionList_return expressionList76 = default(SGLParser.expressionList_return);

        SGLParser.expression_return expression80 = default(SGLParser.expression_return);


        object Identifier74_tree=null;
        object char_literal75_tree=null;
        object char_literal77_tree=null;
        object string_literal78_tree=null;
        object char_literal79_tree=null;
        object char_literal81_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_62 = new RewriteRuleTokenStream(adaptor,"token 62");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_expressionList = new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:2: ( Identifier '(' ( expressionList )? ')' -> ^( FUNC_CALL Identifier ( expressionList )? ) | 'println' '(' expression ')' -> ^( PRINTLN expression ) )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == Identifier) )
            {
                alt18 = 1;
            }
            else if ( (LA18_0 == 62) )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:4: Identifier '(' ( expressionList )? ')'
                    {
                    	Identifier74=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionCall898);  
                    	stream_Identifier.Add(Identifier74);

                    	char_literal75=(IToken)Match(input,50,FOLLOW_50_in_functionCall900);  
                    	stream_50.Add(char_literal75);

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:19: ( expressionList )?
                    	int alt17 = 2;
                    	int LA17_0 = input.LA(1);

                    	if ( (LA17_0 == Identifier || (LA17_0 >= IntegerAtom && LA17_0 <= BooleanAtom) || (LA17_0 >= Layer && LA17_0 <= StringAtom) || LA17_0 == 50 || LA17_0 == 74 || LA17_0 == 80) )
                    	{
                    	    alt17 = 1;
                    	}
                    	switch (alt17) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:19: expressionList
                    	        {
                    	        	PushFollow(FOLLOW_expressionList_in_functionCall902);
                    	        	expressionList76 = expressionList();
                    	        	state.followingStackPointer--;

                    	        	stream_expressionList.Add(expressionList76.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal77=(IToken)Match(input,51,FOLLOW_51_in_functionCall905);  
                    	stream_51.Add(char_literal77);



                    	// AST REWRITE
                    	// elements:          expressionList, Identifier
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 253:39: -> ^( FUNC_CALL Identifier ( expressionList )? )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:42: ^( FUNC_CALL Identifier ( expressionList )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

                    	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:65: ( expressionList )?
                    	    if ( stream_expressionList.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_expressionList.NextTree());

                    	    }
                    	    stream_expressionList.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:254:4: 'println' '(' expression ')'
                    {
                    	string_literal78=(IToken)Match(input,62,FOLLOW_62_in_functionCall921);  
                    	stream_62.Add(string_literal78);

                    	char_literal79=(IToken)Match(input,50,FOLLOW_50_in_functionCall923);  
                    	stream_50.Add(char_literal79);

                    	PushFollow(FOLLOW_expression_in_functionCall925);
                    	expression80 = expression();
                    	state.followingStackPointer--;

                    	stream_expression.Add(expression80.Tree);
                    	char_literal81=(IToken)Match(input,51,FOLLOW_51_in_functionCall927);  
                    	stream_51.Add(char_literal81);



                    	// AST REWRITE
                    	// elements:          expression
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 254:33: -> ^( PRINTLN expression )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:254:36: ^( PRINTLN expression )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PRINTLN, "PRINTLN"), root_1);

                    	    adaptor.AddChild(root_1, stream_expression.NextTree());

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
    // $ANTLR end "functionCall"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:273:1: expression : conditionalExpression ;
    public SGLParser.expression_return expression() // throws RecognitionException [1]
    {   
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression82 = default(SGLParser.conditionalExpression_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:274:5: ( conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:274:8: conditionalExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalExpression_in_expression981);
            	conditionalExpression82 = conditionalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalExpression82.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:283:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public SGLParser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal84 = null;
        IToken char_literal86 = null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression83 = default(SGLParser.conditionalOrExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression85 = default(SGLParser.conditionalExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression87 = default(SGLParser.conditionalExpression_return);


        object char_literal84_tree=null;
        object char_literal86_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:284:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:284:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression1022);
            	conditionalOrExpression83 = conditionalOrExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalOrExpression83.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:284:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == 63) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:284:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	char_literal84=(IToken)Match(input,63,FOLLOW_63_in_conditionalExpression1026); 
            	        		char_literal84_tree = (object)adaptor.Create(char_literal84);
            	        		root_0 = (object)adaptor.BecomeRoot(char_literal84_tree, root_0);

            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression1029);
            	        	conditionalExpression85 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression85.Tree);
            	        	char_literal86=(IToken)Match(input,64,FOLLOW_64_in_conditionalExpression1031); 
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression1034);
            	        	conditionalExpression87 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression87.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:289:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public SGLParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal89 = null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression88 = default(SGLParser.conditionalAndExpression_return);

        SGLParser.conditionalAndExpression_return conditionalAndExpression90 = default(SGLParser.conditionalAndExpression_return);


        object string_literal89_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:290:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:290:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1077);
            	conditionalAndExpression88 = conditionalAndExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalAndExpression88.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:290:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == 65) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:290:36: '||' conditionalAndExpression
            			    {
            			    	string_literal89=(IToken)Match(input,65,FOLLOW_65_in_conditionalOrExpression1081); 
            			    		string_literal89_tree = (object)adaptor.Create(string_literal89);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal89_tree, root_0);

            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1084);
            			    	conditionalAndExpression90 = conditionalAndExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, conditionalAndExpression90.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:294:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public SGLParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal92 = null;
        SGLParser.equalityExpression_return equalityExpression91 = default(SGLParser.equalityExpression_return);

        SGLParser.equalityExpression_return equalityExpression93 = default(SGLParser.equalityExpression_return);


        object string_literal92_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:295:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:295:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1115);
            	equalityExpression91 = equalityExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, equalityExpression91.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:295:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == 66) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:295:30: '&&' equalityExpression
            			    {
            			    	string_literal92=(IToken)Match(input,66,FOLLOW_66_in_conditionalAndExpression1119); 
            			    		string_literal92_tree = (object)adaptor.Create(string_literal92);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal92_tree, root_0);

            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1122);
            			    	equalityExpression93 = equalityExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, equalityExpression93.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:299:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public SGLParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal95 = null;
        IToken string_literal96 = null;
        SGLParser.relationalExpression_return relationalExpression94 = default(SGLParser.relationalExpression_return);

        SGLParser.relationalExpression_return relationalExpression97 = default(SGLParser.relationalExpression_return);


        object string_literal95_tree=null;
        object string_literal96_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:300:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:300:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1149);
            	relationalExpression94 = relationalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, relationalExpression94.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:300:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( ((LA23_0 >= 67 && LA23_0 <= 68)) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:300:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:300:32: ( '==' | '!=' )
            			    	int alt22 = 2;
            			    	int LA22_0 = input.LA(1);

            			    	if ( (LA22_0 == 67) )
            			    	{
            			    	    alt22 = 1;
            			    	}
            			    	else if ( (LA22_0 == 68) )
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:300:33: '=='
            			    	        {
            			    	        	string_literal95=(IToken)Match(input,67,FOLLOW_67_in_equalityExpression1154); 
            			    	        		string_literal95_tree = (object)adaptor.Create(string_literal95);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal95_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:300:41: '!='
            			    	        {
            			    	        	string_literal96=(IToken)Match(input,68,FOLLOW_68_in_equalityExpression1159); 
            			    	        		string_literal96_tree = (object)adaptor.Create(string_literal96);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal96_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1163);
            			    	relationalExpression97 = relationalExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, relationalExpression97.Tree);

            			    }
            			    break;

            			default:
            			    goto loop23;
            	    }
            	} while (true);

            	loop23:
            		;	// Stops C# compiler whining that label 'loop23' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:304:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public SGLParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal99 = null;
        IToken char_literal100 = null;
        IToken string_literal101 = null;
        IToken string_literal102 = null;
        SGLParser.additiveExpression_return additiveExpression98 = default(SGLParser.additiveExpression_return);

        SGLParser.additiveExpression_return additiveExpression103 = default(SGLParser.additiveExpression_return);


        object char_literal99_tree=null;
        object char_literal100_tree=null;
        object string_literal101_tree=null;
        object string_literal102_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:305:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:305:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1194);
            	additiveExpression98 = additiveExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additiveExpression98.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:305:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( ((LA25_0 >= 69 && LA25_0 <= 72)) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:305:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:305:29: ( '<' | '>' | '<=' | '>=' )
            			    	int alt24 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 69:
            			    		{
            			    	    alt24 = 1;
            			    	    }
            			    	    break;
            			    	case 70:
            			    		{
            			    	    alt24 = 2;
            			    	    }
            			    	    break;
            			    	case 71:
            			    		{
            			    	    alt24 = 3;
            			    	    }
            			    	    break;
            			    	case 72:
            			    		{
            			    	    alt24 = 4;
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:305:30: '<'
            			    	        {
            			    	        	char_literal99=(IToken)Match(input,69,FOLLOW_69_in_relationalExpression1198); 
            			    	        		char_literal99_tree = (object)adaptor.Create(char_literal99);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal99_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:305:35: '>'
            			    	        {
            			    	        	char_literal100=(IToken)Match(input,70,FOLLOW_70_in_relationalExpression1201); 
            			    	        		char_literal100_tree = (object)adaptor.Create(char_literal100);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal100_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:305:40: '<='
            			    	        {
            			    	        	string_literal101=(IToken)Match(input,71,FOLLOW_71_in_relationalExpression1204); 
            			    	        		string_literal101_tree = (object)adaptor.Create(string_literal101);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal101_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:305:46: '>='
            			    	        {
            			    	        	string_literal102=(IToken)Match(input,72,FOLLOW_72_in_relationalExpression1207); 
            			    	        		string_literal102_tree = (object)adaptor.Create(string_literal102);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal102_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1211);
            			    	additiveExpression103 = additiveExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, additiveExpression103.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:309:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public SGLParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal105 = null;
        IToken char_literal106 = null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression104 = default(SGLParser.multiplicativeExpression_return);

        SGLParser.multiplicativeExpression_return multiplicativeExpression107 = default(SGLParser.multiplicativeExpression_return);


        object char_literal105_tree=null;
        object char_literal106_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:310:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:310:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1249);
            	multiplicativeExpression104 = multiplicativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multiplicativeExpression104.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:310:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( ((LA27_0 >= 73 && LA27_0 <= 74)) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:310:35: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:310:35: ( '+' | '-' )
            			    	int alt26 = 2;
            			    	int LA26_0 = input.LA(1);

            			    	if ( (LA26_0 == 73) )
            			    	{
            			    	    alt26 = 1;
            			    	}
            			    	else if ( (LA26_0 == 74) )
            			    	{
            			    	    alt26 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d26s0 =
            			    	        new NoViableAltException("", 26, 0, input);

            			    	    throw nvae_d26s0;
            			    	}
            			    	switch (alt26) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:310:36: '+'
            			    	        {
            			    	        	char_literal105=(IToken)Match(input,73,FOLLOW_73_in_additiveExpression1253); 
            			    	        		char_literal105_tree = (object)adaptor.Create(char_literal105);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal105_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:310:41: '-'
            			    	        {
            			    	        	char_literal106=(IToken)Match(input,74,FOLLOW_74_in_additiveExpression1256); 
            			    	        		char_literal106_tree = (object)adaptor.Create(char_literal106);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal106_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1260);
            			    	multiplicativeExpression107 = multiplicativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multiplicativeExpression107.Tree);

            			    }
            			    break;

            			default:
            			    goto loop27;
            	    }
            	} while (true);

            	loop27:
            		;	// Stops C# compiler whining that label 'loop27' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:1: multiplicativeExpression : negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* ;
    public SGLParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal109 = null;
        IToken char_literal110 = null;
        IToken char_literal111 = null;
        SGLParser.negativeExpression_return negativeExpression108 = default(SGLParser.negativeExpression_return);

        SGLParser.negativeExpression_return negativeExpression112 = default(SGLParser.negativeExpression_return);


        object char_literal109_tree=null;
        object char_literal110_tree=null;
        object char_literal111_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:315:5: ( negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:315:9: negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression1294);
            	negativeExpression108 = negativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, negativeExpression108.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:316:5: ( ( '*' | '/' | '%' ) negativeExpression )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( ((LA29_0 >= 75 && LA29_0 <= 77)) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:316:6: ( '*' | '/' | '%' ) negativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:316:6: ( '*' | '/' | '%' )
            			    	int alt28 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 75:
            			    		{
            			    	    alt28 = 1;
            			    	    }
            			    	    break;
            			    	case 76:
            			    		{
            			    	    alt28 = 2;
            			    	    }
            			    	    break;
            			    	case 77:
            			    		{
            			    	    alt28 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    NoViableAltException nvae_d28s0 =
            			    		        new NoViableAltException("", 28, 0, input);

            			    		    throw nvae_d28s0;
            			    	}

            			    	switch (alt28) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:316:7: '*'
            			    	        {
            			    	        	char_literal109=(IToken)Match(input,75,FOLLOW_75_in_multiplicativeExpression1302); 
            			    	        		char_literal109_tree = (object)adaptor.Create(char_literal109);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal109_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:316:12: '/'
            			    	        {
            			    	        	char_literal110=(IToken)Match(input,76,FOLLOW_76_in_multiplicativeExpression1305); 
            			    	        		char_literal110_tree = (object)adaptor.Create(char_literal110);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal110_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:316:17: '%'
            			    	        {
            			    	        	char_literal111=(IToken)Match(input,77,FOLLOW_77_in_multiplicativeExpression1308); 
            			    	        		char_literal111_tree = (object)adaptor.Create(char_literal111);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal111_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression1312);
            			    	negativeExpression112 = negativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, negativeExpression112.Tree);

            			    }
            			    break;

            			default:
            			    goto loop29;
            	    }
            	} while (true);

            	loop29:
            		;	// Stops C# compiler whining that label 'loop29' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:319:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public SGLParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal113 = null;
        IToken string_literal115 = null;
        SGLParser.unaryExpression_return unaryExpression114 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpression_return unaryExpression116 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus117 = default(SGLParser.unaryExpressionNotPlusMinus_return);


        object string_literal113_tree=null;
        object string_literal115_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:320:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt30 = 3;
            switch ( input.LA(1) ) 
            {
            case 78:
            	{
                alt30 = 1;
                }
                break;
            case 79:
            	{
                alt30 = 2;
                }
                break;
            case Identifier:
            	{
                alt30 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d30s0 =
            	        new NoViableAltException("", 30, 0, input);

            	    throw nvae_d30s0;
            }

            switch (alt30) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:320:7: '++' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal113=(IToken)Match(input,78,FOLLOW_78_in_unaryExpression1335); 
                    		string_literal113_tree = (object)adaptor.Create(string_literal113);
                    		adaptor.AddChild(root_0, string_literal113_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1337);
                    	unaryExpression114 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression114.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:321:9: '--' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal115=(IToken)Match(input,79,FOLLOW_79_in_unaryExpression1347); 
                    		string_literal115_tree = (object)adaptor.Create(string_literal115);
                    		adaptor.AddChild(root_0, string_literal115_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1349);
                    	unaryExpression116 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression116.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:322:9: unaryExpressionNotPlusMinus
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1359);
                    	unaryExpressionNotPlusMinus117 = unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpressionNotPlusMinus117.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:326:1: unaryExpressionNotPlusMinus : Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) ;
    public SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier118 = null;
        IToken string_literal119 = null;
        IToken string_literal120 = null;

        object Identifier118_tree=null;
        object string_literal119_tree=null;
        object string_literal120_tree=null;
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:327:5: ( Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:327:9: Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            {
            	Identifier118=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_unaryExpressionNotPlusMinus1380);  
            	stream_Identifier.Add(Identifier118);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:327:20: ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            	int alt31 = 2;
            	int LA31_0 = input.LA(1);

            	if ( (LA31_0 == 78) )
            	{
            	    alt31 = 1;
            	}
            	else if ( (LA31_0 == 79) )
            	{
            	    alt31 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d31s0 =
            	        new NoViableAltException("", 31, 0, input);

            	    throw nvae_d31s0;
            	}
            	switch (alt31) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:327:21: '++'
            	        {
            	        	string_literal119=(IToken)Match(input,78,FOLLOW_78_in_unaryExpressionNotPlusMinus1383);  
            	        	stream_78.Add(string_literal119);



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
            	        	// 327:26: -> ^( VARINC Identifier )
            	        	{
            	        	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:327:29: ^( VARINC Identifier )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARINC, "VARINC"), root_1);

            	        	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

            	        	    adaptor.AddChild(root_0, root_1);
            	        	    }

            	        	}

            	        	retval.Tree = root_0;retval.Tree = root_0;
            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:328:4: '--'
            	        {
            	        	string_literal120=(IToken)Match(input,79,FOLLOW_79_in_unaryExpressionNotPlusMinus1396);  
            	        	stream_79.Add(string_literal120);



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
            	        	// 328:9: -> ^( VARDEC Identifier )
            	        	{
            	        	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:328:12: ^( VARDEC Identifier )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDEC, "VARDEC"), root_1);

            	        	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

            	        	    adaptor.AddChild(root_0, root_1);
            	        	    }

            	        	}

            	        	retval.Tree = root_0;retval.Tree = root_0;
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:333:1: castExpression : '(' variableType ')' unaryExpression ;
    public SGLParser.castExpression_return castExpression() // throws RecognitionException [1]
    {   
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal121 = null;
        IToken char_literal123 = null;
        SGLParser.variableType_return variableType122 = default(SGLParser.variableType_return);

        SGLParser.unaryExpression_return unaryExpression124 = default(SGLParser.unaryExpression_return);


        object char_literal121_tree=null;
        object char_literal123_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:334:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:334:8: '(' variableType ')' unaryExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal121=(IToken)Match(input,50,FOLLOW_50_in_castExpression1433); 
            		char_literal121_tree = (object)adaptor.Create(char_literal121);
            		adaptor.AddChild(root_0, char_literal121_tree);

            	PushFollow(FOLLOW_variableType_in_castExpression1435);
            	variableType122 = variableType();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variableType122.Tree);
            	char_literal123=(IToken)Match(input,51,FOLLOW_51_in_castExpression1437); 
            		char_literal123_tree = (object)adaptor.Create(char_literal123);
            		adaptor.AddChild(root_0, char_literal123_tree);

            	PushFollow(FOLLOW_unaryExpression_in_castExpression1439);
            	unaryExpression124 = unaryExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, unaryExpression124.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:339:1: negativeExpression : ( mathAtom | '-' mathAtom -> ^( NEGATE mathAtom ) | unaryExpressionNotPlusMinus );
    public SGLParser.negativeExpression_return negativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.negativeExpression_return retval = new SGLParser.negativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal126 = null;
        SGLParser.mathAtom_return mathAtom125 = default(SGLParser.mathAtom_return);

        SGLParser.mathAtom_return mathAtom127 = default(SGLParser.mathAtom_return);

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus128 = default(SGLParser.unaryExpressionNotPlusMinus_return);


        object char_literal126_tree=null;
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleSubtreeStream stream_mathAtom = new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:340:2: ( mathAtom | '-' mathAtom -> ^( NEGATE mathAtom ) | unaryExpressionNotPlusMinus )
            int alt32 = 3;
            switch ( input.LA(1) ) 
            {
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case Layer:
            case Origin:
            case StringAtom:
            case 50:
            case 80:
            	{
                alt32 = 1;
                }
                break;
            case Identifier:
            	{
                int LA32_2 = input.LA(2);

                if ( ((LA32_2 >= Identifier && LA32_2 <= ObjectType) || LA32_2 == 47 || (LA32_2 >= 50 && LA32_2 <= 51) || (LA32_2 >= 53 && LA32_2 <= 54) || (LA32_2 >= 61 && LA32_2 <= 77)) )
                {
                    alt32 = 1;
                }
                else if ( ((LA32_2 >= 78 && LA32_2 <= 79)) )
                {
                    alt32 = 3;
                }
                else 
                {
                    NoViableAltException nvae_d32s2 =
                        new NoViableAltException("", 32, 2, input);

                    throw nvae_d32s2;
                }
                }
                break;
            case 74:
            	{
                alt32 = 2;
                }
                break;
            	default:
            	    NoViableAltException nvae_d32s0 =
            	        new NoViableAltException("", 32, 0, input);

            	    throw nvae_d32s0;
            }

            switch (alt32) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:340:4: mathAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mathAtom_in_negativeExpression1457);
                    	mathAtom125 = mathAtom();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, mathAtom125.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:341:4: '-' mathAtom
                    {
                    	char_literal126=(IToken)Match(input,74,FOLLOW_74_in_negativeExpression1462);  
                    	stream_74.Add(char_literal126);

                    	PushFollow(FOLLOW_mathAtom_in_negativeExpression1464);
                    	mathAtom127 = mathAtom();
                    	state.followingStackPointer--;

                    	stream_mathAtom.Add(mathAtom127.Tree);


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
                    	// 341:17: -> ^( NEGATE mathAtom )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:341:20: ^( NEGATE mathAtom )
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
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:342:4: unaryExpressionNotPlusMinus
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_negativeExpression1477);
                    	unaryExpressionNotPlusMinus128 = unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpressionNotPlusMinus128.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:345:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation '(' ( arguments )? ')' -> ^( SpriteAnimation ( arguments )? ) | Identifier | Identifier '(' ( arguments )? ')' -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote | Layer -> ^( STRINGNOQUOTES Layer ) | Origin -> ^( STRINGNOQUOTES Origin ) );
    public SGLParser.mathAtom_return mathAtom() // throws RecognitionException [1]
    {   
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal129 = null;
        IToken char_literal131 = null;
        IToken IntegerAtom132 = null;
        IToken FloatAtom133 = null;
        IToken BooleanAtom134 = null;
        IToken string_literal135 = null;
        IToken SpriteAnimation136 = null;
        IToken char_literal137 = null;
        IToken char_literal139 = null;
        IToken Identifier140 = null;
        IToken Identifier141 = null;
        IToken char_literal142 = null;
        IToken char_literal144 = null;
        IToken Layer146 = null;
        IToken Origin147 = null;
        SGLParser.conditionalExpression_return conditionalExpression130 = default(SGLParser.conditionalExpression_return);

        SGLParser.arguments_return arguments138 = default(SGLParser.arguments_return);

        SGLParser.arguments_return arguments143 = default(SGLParser.arguments_return);

        SGLParser.stringQuote_return stringQuote145 = default(SGLParser.stringQuote_return);


        object char_literal129_tree=null;
        object char_literal131_tree=null;
        object IntegerAtom132_tree=null;
        object FloatAtom133_tree=null;
        object BooleanAtom134_tree=null;
        object string_literal135_tree=null;
        object SpriteAnimation136_tree=null;
        object char_literal137_tree=null;
        object char_literal139_tree=null;
        object Identifier140_tree=null;
        object Identifier141_tree=null;
        object char_literal142_tree=null;
        object char_literal144_tree=null;
        object Layer146_tree=null;
        object Origin147_tree=null;
        RewriteRuleTokenStream stream_Layer = new RewriteRuleTokenStream(adaptor,"token Layer");
        RewriteRuleTokenStream stream_SpriteAnimation = new RewriteRuleTokenStream(adaptor,"token SpriteAnimation");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_Origin = new RewriteRuleTokenStream(adaptor,"token Origin");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_50 = new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:346:5: ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation '(' ( arguments )? ')' -> ^( SpriteAnimation ( arguments )? ) | Identifier | Identifier '(' ( arguments )? ')' -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote | Layer -> ^( STRINGNOQUOTES Layer ) | Origin -> ^( STRINGNOQUOTES Origin ) )
            int alt35 = 10;
            alt35 = dfa35.Predict(input);
            switch (alt35) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:346:7: '(' conditionalExpression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal129=(IToken)Match(input,50,FOLLOW_50_in_mathAtom1491); 
                    	PushFollow(FOLLOW_conditionalExpression_in_mathAtom1494);
                    	conditionalExpression130 = conditionalExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, conditionalExpression130.Tree);
                    	char_literal131=(IToken)Match(input,51,FOLLOW_51_in_mathAtom1496); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:347:9: IntegerAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IntegerAtom132=(IToken)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom1507); 
                    		IntegerAtom132_tree = (object)adaptor.Create(IntegerAtom132);
                    		adaptor.AddChild(root_0, IntegerAtom132_tree);


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:348:7: FloatAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FloatAtom133=(IToken)Match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1515); 
                    		FloatAtom133_tree = (object)adaptor.Create(FloatAtom133);
                    		adaptor.AddChild(root_0, FloatAtom133_tree);


                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:349:9: BooleanAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BooleanAtom134=(IToken)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1525); 
                    		BooleanAtom134_tree = (object)adaptor.Create(BooleanAtom134);
                    		adaptor.AddChild(root_0, BooleanAtom134_tree);


                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:351:9: 'new' SpriteAnimation '(' ( arguments )? ')'
                    {
                    	string_literal135=(IToken)Match(input,80,FOLLOW_80_in_mathAtom1536);  
                    	stream_80.Add(string_literal135);

                    	SpriteAnimation136=(IToken)Match(input,SpriteAnimation,FOLLOW_SpriteAnimation_in_mathAtom1538);  
                    	stream_SpriteAnimation.Add(SpriteAnimation136);

                    	char_literal137=(IToken)Match(input,50,FOLLOW_50_in_mathAtom1540);  
                    	stream_50.Add(char_literal137);

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:351:35: ( arguments )?
                    	int alt33 = 2;
                    	int LA33_0 = input.LA(1);

                    	if ( (LA33_0 == Identifier || (LA33_0 >= IntegerAtom && LA33_0 <= BooleanAtom) || (LA33_0 >= Layer && LA33_0 <= StringAtom) || LA33_0 == 50 || LA33_0 == 74 || LA33_0 == 80) )
                    	{
                    	    alt33 = 1;
                    	}
                    	switch (alt33) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:351:35: arguments
                    	        {
                    	        	PushFollow(FOLLOW_arguments_in_mathAtom1542);
                    	        	arguments138 = arguments();
                    	        	state.followingStackPointer--;

                    	        	stream_arguments.Add(arguments138.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal139=(IToken)Match(input,51,FOLLOW_51_in_mathAtom1545);  
                    	stream_51.Add(char_literal139);



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
                    	// 351:50: -> ^( SpriteAnimation ( arguments )? )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:351:53: ^( SpriteAnimation ( arguments )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_SpriteAnimation.NextNode(), root_1);

                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:351:71: ( arguments )?
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:353:4: Identifier
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	Identifier140=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_mathAtom1561); 
                    		Identifier140_tree = (object)adaptor.Create(Identifier140);
                    		adaptor.AddChild(root_0, Identifier140_tree);


                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:354:4: Identifier '(' ( arguments )? ')'
                    {
                    	Identifier141=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_mathAtom1566);  
                    	stream_Identifier.Add(Identifier141);

                    	char_literal142=(IToken)Match(input,50,FOLLOW_50_in_mathAtom1568);  
                    	stream_50.Add(char_literal142);

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:354:19: ( arguments )?
                    	int alt34 = 2;
                    	int LA34_0 = input.LA(1);

                    	if ( (LA34_0 == Identifier || (LA34_0 >= IntegerAtom && LA34_0 <= BooleanAtom) || (LA34_0 >= Layer && LA34_0 <= StringAtom) || LA34_0 == 50 || LA34_0 == 74 || LA34_0 == 80) )
                    	{
                    	    alt34 = 1;
                    	}
                    	switch (alt34) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:354:19: arguments
                    	        {
                    	        	PushFollow(FOLLOW_arguments_in_mathAtom1570);
                    	        	arguments143 = arguments();
                    	        	state.followingStackPointer--;

                    	        	stream_arguments.Add(arguments143.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal144=(IToken)Match(input,51,FOLLOW_51_in_mathAtom1573);  
                    	stream_51.Add(char_literal144);



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
                    	// 354:34: -> ^( LIBMETHOD Identifier ( arguments )? )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:354:37: ^( LIBMETHOD Identifier ( arguments )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LIBMETHOD, "LIBMETHOD"), root_1);

                    	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:354:60: ( arguments )?
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:355:4: stringQuote
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stringQuote_in_mathAtom1589);
                    	stringQuote145 = stringQuote();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, stringQuote145.Tree);

                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:356:4: Layer
                    {
                    	Layer146=(IToken)Match(input,Layer,FOLLOW_Layer_in_mathAtom1594);  
                    	stream_Layer.Add(Layer146);



                    	// AST REWRITE
                    	// elements:          Layer
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 356:10: -> ^( STRINGNOQUOTES Layer )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:356:13: ^( STRINGNOQUOTES Layer )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STRINGNOQUOTES, "STRINGNOQUOTES"), root_1);

                    	    adaptor.AddChild(root_1, stream_Layer.NextNode());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;
                    }
                    break;
                case 10 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:357:4: Origin
                    {
                    	Origin147=(IToken)Match(input,Origin,FOLLOW_Origin_in_mathAtom1607);  
                    	stream_Origin.Add(Origin147);



                    	// AST REWRITE
                    	// elements:          Origin
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 357:11: -> ^( STRINGNOQUOTES Origin )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:357:14: ^( STRINGNOQUOTES Origin )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STRINGNOQUOTES, "STRINGNOQUOTES"), root_1);

                    	    adaptor.AddChild(root_1, stream_Origin.NextNode());

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

    public class variableUnaryChange_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableUnaryChange"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:360:1: variableUnaryChange : Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) ;
    public SGLParser.variableUnaryChange_return variableUnaryChange() // throws RecognitionException [1]
    {   
        SGLParser.variableUnaryChange_return retval = new SGLParser.variableUnaryChange_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier148 = null;
        IToken string_literal149 = null;
        IToken string_literal150 = null;

        object Identifier148_tree=null;
        object string_literal149_tree=null;
        object string_literal150_tree=null;
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:361:2: ( Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:361:4: Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            {
            	Identifier148=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableUnaryChange1635);  
            	stream_Identifier.Add(Identifier148);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:361:15: ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            	int alt36 = 2;
            	int LA36_0 = input.LA(1);

            	if ( (LA36_0 == 78) )
            	{
            	    alt36 = 1;
            	}
            	else if ( (LA36_0 == 79) )
            	{
            	    alt36 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d36s0 =
            	        new NoViableAltException("", 36, 0, input);

            	    throw nvae_d36s0;
            	}
            	switch (alt36) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:361:16: '++'
            	        {
            	        	string_literal149=(IToken)Match(input,78,FOLLOW_78_in_variableUnaryChange1638);  
            	        	stream_78.Add(string_literal149);



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
            	        	// 361:21: -> ^( VARINC Identifier )
            	        	{
            	        	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:361:24: ^( VARINC Identifier )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARINC, "VARINC"), root_1);

            	        	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

            	        	    adaptor.AddChild(root_0, root_1);
            	        	    }

            	        	}

            	        	retval.Tree = root_0;retval.Tree = root_0;
            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:362:4: '--'
            	        {
            	        	string_literal150=(IToken)Match(input,79,FOLLOW_79_in_variableUnaryChange1651);  
            	        	stream_79.Add(string_literal150);



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
            	        	// 362:9: -> ^( VARDEC Identifier )
            	        	{
            	        	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:362:12: ^( VARDEC Identifier )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDEC, "VARDEC"), root_1);

            	        	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

            	        	    adaptor.AddChild(root_0, root_1);
            	        	    }

            	        	}

            	        	retval.Tree = root_0;retval.Tree = root_0;
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
    // $ANTLR end "variableUnaryChange"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:370:1: arguments : expressionList ;
    public SGLParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.expressionList_return expressionList151 = default(SGLParser.expressionList_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:371:5: ( expressionList )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:371:10: expressionList
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expressionList_in_arguments1694);
            	expressionList151 = expressionList();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expressionList151.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:374:1: expressionList : expression ( ',' expression )* ;
    public SGLParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal153 = null;
        SGLParser.expression_return expression152 = default(SGLParser.expression_return);

        SGLParser.expression_return expression154 = default(SGLParser.expression_return);


        object char_literal153_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:375:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:375:9: expression ( ',' expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionList1717);
            	expression152 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression152.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:375:20: ( ',' expression )*
            	do 
            	{
            	    int alt37 = 2;
            	    int LA37_0 = input.LA(1);

            	    if ( (LA37_0 == 54) )
            	    {
            	        alt37 = 1;
            	    }


            	    switch (alt37) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:375:21: ',' expression
            			    {
            			    	char_literal153=(IToken)Match(input,54,FOLLOW_54_in_expressionList1720); 
            			    	PushFollow(FOLLOW_expression_in_expressionList1723);
            			    	expression154 = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expression154.Tree);

            			    }
            			    break;

            			default:
            			    goto loop37;
            	    }
            	} while (true);

            	loop37:
            		;	// Stops C# compiler whining that label 'loop37' has no statements


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

    public class paramList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "paramList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:378:1: paramList : variableType variableName ( ',' variableType variableName )* -> ^( PARAM_TYPE_LIST ( variableType )+ ) ^( PARAM_NAME_LIST ( variableName )+ ) ;
    public SGLParser.paramList_return paramList() // throws RecognitionException [1]
    {   
        SGLParser.paramList_return retval = new SGLParser.paramList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal157 = null;
        SGLParser.variableType_return variableType155 = default(SGLParser.variableType_return);

        SGLParser.variableName_return variableName156 = default(SGLParser.variableName_return);

        SGLParser.variableType_return variableType158 = default(SGLParser.variableType_return);

        SGLParser.variableName_return variableName159 = default(SGLParser.variableName_return);


        object char_literal157_tree=null;
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_variableType = new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:379:3: ( variableType variableName ( ',' variableType variableName )* -> ^( PARAM_TYPE_LIST ( variableType )+ ) ^( PARAM_NAME_LIST ( variableName )+ ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:379:6: variableType variableName ( ',' variableType variableName )*
            {
            	PushFollow(FOLLOW_variableType_in_paramList1741);
            	variableType155 = variableType();
            	state.followingStackPointer--;

            	stream_variableType.Add(variableType155.Tree);
            	PushFollow(FOLLOW_variableName_in_paramList1743);
            	variableName156 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName156.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:379:32: ( ',' variableType variableName )*
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == 54) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:379:33: ',' variableType variableName
            			    {
            			    	char_literal157=(IToken)Match(input,54,FOLLOW_54_in_paramList1746);  
            			    	stream_54.Add(char_literal157);

            			    	PushFollow(FOLLOW_variableType_in_paramList1748);
            			    	variableType158 = variableType();
            			    	state.followingStackPointer--;

            			    	stream_variableType.Add(variableType158.Tree);
            			    	PushFollow(FOLLOW_variableName_in_paramList1750);
            			    	variableName159 = variableName();
            			    	state.followingStackPointer--;

            			    	stream_variableName.Add(variableName159.Tree);

            			    }
            			    break;

            			default:
            			    goto loop38;
            	    }
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whining that label 'loop38' has no statements



            	// AST REWRITE
            	// elements:          variableName, variableType
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 379:65: -> ^( PARAM_TYPE_LIST ( variableType )+ ) ^( PARAM_NAME_LIST ( variableName )+ )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:379:68: ^( PARAM_TYPE_LIST ( variableType )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAM_TYPE_LIST, "PARAM_TYPE_LIST"), root_1);

            	    if ( !(stream_variableType.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_variableType.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_variableType.NextTree());

            	    }
            	    stream_variableType.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:379:101: ^( PARAM_NAME_LIST ( variableName )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PARAM_NAME_LIST, "PARAM_NAME_LIST"), root_1);

            	    if ( !(stream_variableName.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_variableName.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_variableName.NextTree());

            	    }
            	    stream_variableName.Reset();

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
    // $ANTLR end "paramList"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:382:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public SGLParser.literal_return literal() // throws RecognitionException [1]
    {   
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set160 = null;

        object set160_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:383:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set160 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == StringAtom || input.LA(1) == 81 ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set160));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:391:1: stringQuote : StringAtom -> ^( STRING StringAtom ) ;
    public SGLParser.stringQuote_return stringQuote() // throws RecognitionException [1]
    {   
        SGLParser.stringQuote_return retval = new SGLParser.stringQuote_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken StringAtom161 = null;

        object StringAtom161_tree=null;
        RewriteRuleTokenStream stream_StringAtom = new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:392:2: ( StringAtom -> ^( STRING StringAtom ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:392:6: StringAtom
            {
            	StringAtom161=(IToken)Match(input,StringAtom,FOLLOW_StringAtom_in_stringQuote1861);  
            	stream_StringAtom.Add(StringAtom161);



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
            	// 392:17: -> ^( STRING StringAtom )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:392:20: ^( STRING StringAtom )
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


   	protected DFA35 dfa35;
	private void InitializeCyclicDFAs()
	{
    	this.dfa35 = new DFA35(this);
	}

    const string DFA35_eotS =
        "\x0c\uffff";
    const string DFA35_eofS =
        "\x0c\uffff";
    const string DFA35_minS =
        "\x01\x1a\x05\uffff\x01\x1a\x05\uffff";
    const string DFA35_maxS =
        "\x01\x50\x05\uffff\x01\x4d\x05\uffff";
    const string DFA35_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x01\x05\x01\uffff\x01"+
        "\x08\x01\x09\x01\x0a\x01\x07\x01\x06";
    const string DFA35_specialS =
        "\x0c\uffff}>";
    static readonly string[] DFA35_transitionS = {
            "\x01\x06\x05\uffff\x01\x02\x01\x03\x01\x04\x01\uffff\x01\x08"+
            "\x01\x09\x01\x07\x0b\uffff\x01\x01\x1d\uffff\x01\x05",
            "",
            "",
            "",
            "",
            "",
            "\x06\x0b\x0f\uffff\x01\x0b\x02\uffff\x01\x0a\x01\x0b\x01\uffff"+
            "\x02\x0b\x06\uffff\x11\x0b",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA35_eot = DFA.UnpackEncodedString(DFA35_eotS);
    static readonly short[] DFA35_eof = DFA.UnpackEncodedString(DFA35_eofS);
    static readonly char[] DFA35_min = DFA.UnpackEncodedStringToUnsignedChars(DFA35_minS);
    static readonly char[] DFA35_max = DFA.UnpackEncodedStringToUnsignedChars(DFA35_maxS);
    static readonly short[] DFA35_accept = DFA.UnpackEncodedString(DFA35_acceptS);
    static readonly short[] DFA35_special = DFA.UnpackEncodedString(DFA35_specialS);
    static readonly short[][] DFA35_transition = DFA.UnpackEncodedStringArray(DFA35_transitionS);

    protected class DFA35 : DFA
    {
        public DFA35(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 35;
            this.eot = DFA35_eot;
            this.eof = DFA35_eof;
            this.min = DFA35_min;
            this.max = DFA35_max;
            this.accept = DFA35_accept;
            this.special = DFA35_special;
            this.transition = DFA35_transition;

        }

        override public string Description
        {
            get { return "345:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation '(' ( arguments )? ')' -> ^( SpriteAnimation ( arguments )? ) | Identifier | Identifier '(' ( arguments )? ')' -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote | Layer -> ^( STRINGNOQUOTES Layer ) | Origin -> ^( STRINGNOQUOTES Origin ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_mainBlock_in_compilationUnit166 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mainStatement_in_mainBlock179 = new BitSet(new ulong[]{0x6E020000FC000002UL});
    public static readonly BitSet FOLLOW_methodDef_in_mainBlock183 = new BitSet(new ulong[]{0x6E020000FC000002UL});
    public static readonly BitSet FOLLOW_statement_in_block231 = new BitSet(new ulong[]{0x6E000000FC000002UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_singleBlock259 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_singleBlock_in_commonBlock285 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_47_in_commonBlock290 = new BitSet(new ulong[]{0x6E010000FC000000UL});
    public static readonly BitSet FOLLOW_block_in_commonBlock293 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_commonBlock295 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_methodDef327 = new BitSet(new ulong[]{0x00100000F8000000UL});
    public static readonly BitSet FOLLOW_methodType_in_methodDef329 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodDef331 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_methodDef333 = new BitSet(new ulong[]{0x00080000F8000000UL});
    public static readonly BitSet FOLLOW_paramList_in_methodDef335 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_methodDef338 = new BitSet(new ulong[]{0x60008000FC000000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_methodDef340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_methodType360 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_methodType365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_mainStatement389 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_semicolonStatement402 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_semicolonStatement408 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_variableUnaryChange_in_semicolonStatement414 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_functionCall_in_semicolonStatement420 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_objectMethod_in_semicolonStatement425 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_breakStat_in_semicolonStatement430 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_semicolonStatement435 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_oneLineStatement448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_oneLineStatement453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableUnaryChange_in_oneLineStatement458 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_statement474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement484 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forLoop_in_statement489 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclarationList505 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList507 = new BitSet(new ulong[]{0x0040000000000002UL});
    public static readonly BitSet FOLLOW_54_in_variableDeclarationList510 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList512 = new BitSet(new ulong[]{0x0040000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDecAssignment536 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_55_in_variableDecAssignment539 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_expression_in_variableDecAssignment541 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableAssignment562 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_variableAssignment564 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_expression_in_variableAssignment566 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName597 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_variableType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_objectMethod641 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_objectMethod643 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethod645 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_objectMethod647 = new BitSet(new ulong[]{0x000C007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_arguments_in_objectMethod649 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_objectMethod652 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_whileLoop676 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop678 = new BitSet(new ulong[]{0x60008000FC000000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_whileLoop680 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_forLoop702 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_forLoop704 = new BitSet(new ulong[]{0x00200000FC000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop708 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_forLoop711 = new BitSet(new ulong[]{0x0024007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop715 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_forLoop718 = new BitSet(new ulong[]{0x00080000FC000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop722 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_forLoop725 = new BitSet(new ulong[]{0x60008000FC000000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_forLoop727 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStat_in_ifStatement772 = new BitSet(new ulong[]{0x1000000000000002UL});
    public static readonly BitSet FOLLOW_elseIfStat_in_ifStatement774 = new BitSet(new ulong[]{0x1000000000000002UL});
    public static readonly BitSet FOLLOW_elseStat_in_ifStatement777 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_ifStat802 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_expression_in_ifStat804 = new BitSet(new ulong[]{0x60008000FC000000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_ifStat806 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_elseIfStat827 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_elseIfStat829 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_expression_in_elseIfStat831 = new BitSet(new ulong[]{0x60008000FC000000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseIfStat833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_elseStat855 = new BitSet(new ulong[]{0x60008000FC000000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseStat857 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_breakStat882 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionCall898 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_functionCall900 = new BitSet(new ulong[]{0x000C007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_expressionList_in_functionCall902 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_functionCall905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_functionCall921 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_functionCall923 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_expression_in_functionCall925 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_functionCall927 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression981 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression1022 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_conditionalExpression1026 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression1029 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_conditionalExpression1031 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression1034 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1077 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_conditionalOrExpression1081 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1084 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1115 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_conditionalAndExpression1119 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1122 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1149 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000018UL});
    public static readonly BitSet FOLLOW_67_in_equalityExpression1154 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_68_in_equalityExpression1159 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1163 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000018UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1194 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000001E0UL});
    public static readonly BitSet FOLLOW_69_in_relationalExpression1198 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_70_in_relationalExpression1201 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_71_in_relationalExpression1204 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_72_in_relationalExpression1207 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1211 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000001E0UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1249 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000600UL});
    public static readonly BitSet FOLLOW_73_in_additiveExpression1253 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_74_in_additiveExpression1256 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1260 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000600UL});
    public static readonly BitSet FOLLOW_negativeExpression_in_multiplicativeExpression1294 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000003800UL});
    public static readonly BitSet FOLLOW_75_in_multiplicativeExpression1302 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_76_in_multiplicativeExpression1305 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_77_in_multiplicativeExpression1308 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_negativeExpression_in_multiplicativeExpression1312 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000003800UL});
    public static readonly BitSet FOLLOW_78_in_unaryExpression1335 = new BitSet(new ulong[]{0x0004007704000000UL,0x000000000001C400UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1337 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_unaryExpression1347 = new BitSet(new ulong[]{0x0004007704000000UL,0x000000000001C400UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1349 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1359 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_unaryExpressionNotPlusMinus1380 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_78_in_unaryExpressionNotPlusMinus1383 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_unaryExpressionNotPlusMinus1396 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_castExpression1433 = new BitSet(new ulong[]{0x00000000F8000000UL});
    public static readonly BitSet FOLLOW_variableType_in_castExpression1435 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_castExpression1437 = new BitSet(new ulong[]{0x0004007704000000UL,0x000000000001C400UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negativeExpression1457 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_74_in_negativeExpression1462 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negativeExpression1464 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_negativeExpression1477 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_mathAtom1491 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_mathAtom1494 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_mathAtom1496 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom1507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_mathAtom1515 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_mathAtom1525 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_mathAtom1536 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_SpriteAnimation_in_mathAtom1538 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_mathAtom1540 = new BitSet(new ulong[]{0x000C007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_arguments_in_mathAtom1542 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_mathAtom1545 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_mathAtom1561 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_mathAtom1566 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_mathAtom1568 = new BitSet(new ulong[]{0x000C007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_arguments_in_mathAtom1570 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_mathAtom1573 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stringQuote_in_mathAtom1589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Layer_in_mathAtom1594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Origin_in_mathAtom1607 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableUnaryChange1635 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_78_in_variableUnaryChange1638 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_variableUnaryChange1651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1694 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1717 = new BitSet(new ulong[]{0x0040000000000002UL});
    public static readonly BitSet FOLLOW_54_in_expressionList1720 = new BitSet(new ulong[]{0x0004007704000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1723 = new BitSet(new ulong[]{0x0040000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_paramList1741 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_variableName_in_paramList1743 = new BitSet(new ulong[]{0x0040000000000002UL});
    public static readonly BitSet FOLLOW_54_in_paramList1746 = new BitSet(new ulong[]{0x00000000F8000000UL});
    public static readonly BitSet FOLLOW_variableType_in_paramList1748 = new BitSet(new ulong[]{0x0000000004000000UL});
    public static readonly BitSet FOLLOW_variableName_in_paramList1750 = new BitSet(new ulong[]{0x0040000000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringAtom_in_stringQuote1861 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}