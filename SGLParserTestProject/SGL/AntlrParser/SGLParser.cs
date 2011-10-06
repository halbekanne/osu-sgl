// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g 2011-10-06 21:26:47

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


// -------------------------------------------------------------------------------------------------
//                This is a generated file, please don't change anything in here!
// -------------------------------------------------------------------------------------------------

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
		"AT", 
		"IF", 
		"EXP", 
		"ID_LIST", 
		"VARDEF", 
		"GLOBVARDEF", 
		"ASSIGN", 
		"NEGATE", 
		"OBJMETHOD", 
		"STRING", 
		"FORDEC", 
		"FORCOND", 
		"FORITER", 
		"STRINGNOQUOTES", 
		"VARINC", 
		"VARDEC", 
		"BREAK", 
		"PARAM_TYPE_LIST", 
		"PARAM_NAME_LIST", 
		"METH_CALL", 
		"RETURN", 
		"Identifier", 
		"IntType", 
		"BooleanType", 
		"StringType", 
		"FloatType", 
		"ObjectType", 
		"IntegerAtom", 
		"FloatAtom", 
		"BooleanAtom", 
		"Sprite", 
		"Animation", 
		"Layer", 
		"Origin", 
		"LoopType", 
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
		"'global'", 
		"'='", 
		"'.'", 
		"'while'", 
		"'for'", 
		"'if'", 
		"'else'", 
		"'at'", 
		"'break'", 
		"'return'", 
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
    public const int OBJMETHOD = 14;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int Origin = 39;
    public const int SGLIDDigit = 44;
    public const int Sprite = 36;
    public const int PARAM_NAME_LIST = 24;
    public const int IntType = 28;
    public const int ID_LIST = 9;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int BREAK = 22;
    public const int Identifier = 27;
    public const int IF = 7;
    public const int T__55 = 55;
    public const int AT = 6;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int Animation = 37;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int EXP = 8;
    public const int FORITER = 18;
    public const int StringType = 30;
    public const int T__59 = 59;
    public const int LoopType = 40;
    public const int RETURN = 26;
    public const int COMMENT = 49;
    public const int STRINGNOQUOTES = 19;
    public const int VARDEF = 10;
    public const int T__50 = 50;
    public const int BooleanType = 29;
    public const int VARDEC = 21;
    public const int GLOBVARDEF = 11;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int IntegerAtom = 33;
    public const int FloatType = 31;
    public const int FORDEC = 16;
    public const int StringAtom = 41;
    public const int PARAM_TYPE_LIST = 23;
    public const int METH_CALL = 25;
    public const int HEX_DIGIT = 47;
    public const int NEGATE = 13;
    public const int T__85 = 85;
    public const int T__84 = 84;
    public const int T__86 = 86;
    public const int BooleanAtom = 35;
    public const int WS = 48;
    public const int FORCOND = 17;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int UnicodeEscape = 45;
    public const int BLOCK = 4;
    public const int ASSIGN = 12;
    public const int Layer = 38;
    public const int STATEMENTS = 5;
    public const int ObjectType = 32;
    public const int FloatAtom = 34;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int VARINC = 20;
    public const int T__74 = 74;
    public const int OctalEscape = 46;
    public const int Letter = 43;
    public const int EscapeSequence = 42;
    public const int T__73 = 73;
    public const int T__79 = 79;
    public const int STRING = 15;
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



            public Dictionary<String,Method> methods = new Dictionary<String,Method>();

        	private void DefineMethod(String id, Object type, Object idList, Object block) {
                    // 'idList' is possibly null!  Create an empty tree in that case.  
                    CommonTree idListTree = idList == null ? new CommonTree() : (CommonTree)idList;

                    // 'type' is never null
                    String typeString = ((CommonTree)type).ToString();

                    // 'block' is never null 
                    CommonTree blockTree = (CommonTree)block;

                    // The method name with the exact same type of parameters after it, is the unique key 
                    String key = id;

    					if (idListTree.ChildCount > 0)
                        {
                            for (int a = 0; a < idListTree.GetChild(0).ChildCount; a++)
                            {
                                key += "-" + idListTree.GetChild(0).GetChild(a).ToString();
                            }
                        }
                    
                    Console.WriteLine("method found: " + key);
                    
                    //idListTree.GetChild(1).ChildCount;
                    methods.Add(key, new Method(id, typeString, idListTree, blockTree));
            	}
            	
    		public override void EmitErrorMessage(string msg)
                	{
                    	throw new SGLCompilerException(-1, "Antlr.Parser", msg);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:138:1: compilationUnit : mainBlock ;
    public SGLParser.compilationUnit_return compilationUnit() // throws RecognitionException [1]
    {   
        SGLParser.compilationUnit_return retval = new SGLParser.compilationUnit_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.mainBlock_return mainBlock1 = default(SGLParser.mainBlock_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:139:2: ( mainBlock )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:139:4: mainBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mainBlock_in_compilationUnit193);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:142:1: mainBlock : ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:143:2: ( ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:143:4: ( mainStatement | methodDef )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:143:4: ( mainStatement | methodDef )*
            	do 
            	{
            	    int alt1 = 3;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= Identifier && LA1_0 <= ObjectType) || LA1_0 == 58 || (LA1_0 >= 61 && LA1_0 <= 63) || (LA1_0 >= 65 && LA1_0 <= 67)) )
            	    {
            	        alt1 = 1;
            	    }
            	    else if ( (LA1_0 == 52) )
            	    {
            	        alt1 = 2;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:143:5: mainStatement
            			    {
            			    	PushFollow(FOLLOW_mainStatement_in_mainBlock206);
            			    	mainStatement2 = mainStatement();
            			    	state.followingStackPointer--;

            			    	stream_mainStatement.Add(mainStatement2.Tree);

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:143:21: methodDef
            			    {
            			    	PushFollow(FOLLOW_methodDef_in_mainBlock210);
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
            	// 144:8: -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:144:11: ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:144:19: ^( STATEMENTS ( mainStatement )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATEMENTS, "STATEMENTS"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:144:32: ( mainStatement )*
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:147:1: block : ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
    public SGLParser.block_return block() // throws RecognitionException [1]
    {   
        SGLParser.block_return retval = new SGLParser.block_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.statement_return statement4 = default(SGLParser.statement_return);


        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:148:2: ( ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:148:4: ( statement )*
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:148:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( ((LA2_0 >= Identifier && LA2_0 <= ObjectType) || LA2_0 == 58 || (LA2_0 >= 61 && LA2_0 <= 63) || (LA2_0 >= 65 && LA2_0 <= 67)) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:148:4: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block258);
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
            	// 149:3: -> ^( BLOCK ^( STATEMENTS ( statement )* ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:149:6: ^( BLOCK ^( STATEMENTS ( statement )* ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:149:14: ^( STATEMENTS ( statement )* )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(STATEMENTS, "STATEMENTS"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:149:27: ( statement )*
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:152:1: singleBlock : semicolonStatement -> ^( BLOCK ^( STATEMENTS semicolonStatement ) ) ;
    public SGLParser.singleBlock_return singleBlock() // throws RecognitionException [1]
    {   
        SGLParser.singleBlock_return retval = new SGLParser.singleBlock_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement5 = default(SGLParser.semicolonStatement_return);


        RewriteRuleSubtreeStream stream_semicolonStatement = new RewriteRuleSubtreeStream(adaptor,"rule semicolonStatement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:153:2: ( semicolonStatement -> ^( BLOCK ^( STATEMENTS semicolonStatement ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:153:4: semicolonStatement
            {
            	PushFollow(FOLLOW_semicolonStatement_in_singleBlock286);
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
            	// 154:3: -> ^( BLOCK ^( STATEMENTS semicolonStatement ) )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:154:6: ^( BLOCK ^( STATEMENTS semicolonStatement ) )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:154:14: ^( STATEMENTS semicolonStatement )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:157:1: commonBlock : ( singleBlock | '{' block '}' );
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:158:2: ( singleBlock | '{' block '}' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0 >= Identifier && LA3_0 <= ObjectType) || LA3_0 == 58 || (LA3_0 >= 66 && LA3_0 <= 67)) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == 50) )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:158:4: singleBlock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_singleBlock_in_commonBlock312);
                    	singleBlock6 = singleBlock();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, singleBlock6.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:159:4: '{' block '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal7=(IToken)Match(input,50,FOLLOW_50_in_commonBlock317); 
                    	PushFollow(FOLLOW_block_in_commonBlock320);
                    	block8 = block();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, block8.Tree);
                    	char_literal9=(IToken)Match(input,51,FOLLOW_51_in_commonBlock322); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:163:1: methodDef : 'method' methodType Identifier '(' ( paramList )? ')' commonBlock ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:3: ( 'method' methodType Identifier '(' ( paramList )? ')' commonBlock )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:5: 'method' methodType Identifier '(' ( paramList )? ')' commonBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal10=(IToken)Match(input,52,FOLLOW_52_in_methodDef352); 
            		string_literal10_tree = (object)adaptor.Create(string_literal10);
            		adaptor.AddChild(root_0, string_literal10_tree);

            	PushFollow(FOLLOW_methodType_in_methodDef354);
            	methodType11 = methodType();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, methodType11.Tree);
            	Identifier12=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodDef356); 
            		Identifier12_tree = (object)adaptor.Create(Identifier12);
            		adaptor.AddChild(root_0, Identifier12_tree);

            	char_literal13=(IToken)Match(input,53,FOLLOW_53_in_methodDef358); 
            		char_literal13_tree = (object)adaptor.Create(char_literal13);
            		adaptor.AddChild(root_0, char_literal13_tree);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:40: ( paramList )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( ((LA4_0 >= IntType && LA4_0 <= ObjectType)) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:40: paramList
            	        {
            	        	PushFollow(FOLLOW_paramList_in_methodDef360);
            	        	paramList14 = paramList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, paramList14.Tree);

            	        }
            	        break;

            	}

            	char_literal15=(IToken)Match(input,54,FOLLOW_54_in_methodDef363); 
            		char_literal15_tree = (object)adaptor.Create(char_literal15);
            		adaptor.AddChild(root_0, char_literal15_tree);

            	PushFollow(FOLLOW_commonBlock_in_methodDef365);
            	commonBlock16 = commonBlock();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, commonBlock16.Tree);
            	 DefineMethod(((Identifier12 != null) ? Identifier12.Text : null), ((methodType11 != null) ? ((object)methodType11.Tree) : null), ((paramList14 != null) ? ((object)paramList14.Tree) : null), ((commonBlock16 != null) ? ((object)commonBlock16.Tree) : null)); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:168:1: methodType : ( variableType | 'void' );
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:169:2: ( variableType | 'void' )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( ((LA5_0 >= IntType && LA5_0 <= ObjectType)) )
            {
                alt5 = 1;
            }
            else if ( (LA5_0 == 55) )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:169:4: variableType
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableType_in_methodType385);
                    	variableType17 = variableType();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableType17.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:170:4: 'void'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal18=(IToken)Match(input,55,FOLLOW_55_in_methodType390); 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:173:1: mainStatement : statement ;
    public SGLParser.mainStatement_return mainStatement() // throws RecognitionException [1]
    {   
        SGLParser.mainStatement_return retval = new SGLParser.mainStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.statement_return statement19 = default(SGLParser.statement_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:2: ( statement )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:4: statement
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_statement_in_mainStatement414);
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:177:1: semicolonStatement : ( variableDeclarationList | variableAssignment | variableUnaryChange | methodCall | objectMethod | breakStat | returnStat ) ';' ;
    public SGLParser.semicolonStatement_return semicolonStatement() // throws RecognitionException [1]
    {   
        SGLParser.semicolonStatement_return retval = new SGLParser.semicolonStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal27 = null;
        SGLParser.variableDeclarationList_return variableDeclarationList20 = default(SGLParser.variableDeclarationList_return);

        SGLParser.variableAssignment_return variableAssignment21 = default(SGLParser.variableAssignment_return);

        SGLParser.variableUnaryChange_return variableUnaryChange22 = default(SGLParser.variableUnaryChange_return);

        SGLParser.methodCall_return methodCall23 = default(SGLParser.methodCall_return);

        SGLParser.objectMethod_return objectMethod24 = default(SGLParser.objectMethod_return);

        SGLParser.breakStat_return breakStat25 = default(SGLParser.breakStat_return);

        SGLParser.returnStat_return returnStat26 = default(SGLParser.returnStat_return);


        object char_literal27_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:2: ( ( variableDeclarationList | variableAssignment | variableUnaryChange | methodCall | objectMethod | breakStat | returnStat ) ';' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:4: ( variableDeclarationList | variableAssignment | variableUnaryChange | methodCall | objectMethod | breakStat | returnStat ) ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:4: ( variableDeclarationList | variableAssignment | variableUnaryChange | methodCall | objectMethod | breakStat | returnStat )
            	int alt6 = 7;
            	switch ( input.LA(1) ) 
            	{
            	case IntType:
            	case BooleanType:
            	case StringType:
            	case FloatType:
            	case ObjectType:
            	case 58:
            		{
            	    alt6 = 1;
            	    }
            	    break;
            	case Identifier:
            		{
            	    switch ( input.LA(2) ) 
            	    {
            	    case 53:
            	    	{
            	        alt6 = 4;
            	        }
            	        break;
            	    case 59:
            	    	{
            	        alt6 = 2;
            	        }
            	        break;
            	    case 83:
            	    case 84:
            	    	{
            	        alt6 = 3;
            	        }
            	        break;
            	    case 60:
            	    	{
            	        alt6 = 5;
            	        }
            	        break;
            	    	default:
            	    	    NoViableAltException nvae_d6s2 =
            	    	        new NoViableAltException("", 6, 2, input);

            	    	    throw nvae_d6s2;
            	    }

            	    }
            	    break;
            	case 66:
            		{
            	    alt6 = 6;
            	    }
            	    break;
            	case 67:
            		{
            	    alt6 = 7;
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
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:178:5: variableDeclarationList
            	        {
            	        	PushFollow(FOLLOW_variableDeclarationList_in_semicolonStatement427);
            	        	variableDeclarationList20 = variableDeclarationList();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variableDeclarationList20.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:179:4: variableAssignment
            	        {
            	        	PushFollow(FOLLOW_variableAssignment_in_semicolonStatement433);
            	        	variableAssignment21 = variableAssignment();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variableAssignment21.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:180:4: variableUnaryChange
            	        {
            	        	PushFollow(FOLLOW_variableUnaryChange_in_semicolonStatement439);
            	        	variableUnaryChange22 = variableUnaryChange();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, variableUnaryChange22.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:181:4: methodCall
            	        {
            	        	PushFollow(FOLLOW_methodCall_in_semicolonStatement445);
            	        	methodCall23 = methodCall();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, methodCall23.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:182:4: objectMethod
            	        {
            	        	PushFollow(FOLLOW_objectMethod_in_semicolonStatement450);
            	        	objectMethod24 = objectMethod();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, objectMethod24.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:4: breakStat
            	        {
            	        	PushFollow(FOLLOW_breakStat_in_semicolonStatement455);
            	        	breakStat25 = breakStat();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, breakStat25.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:184:4: returnStat
            	        {
            	        	PushFollow(FOLLOW_returnStat_in_semicolonStatement460);
            	        	returnStat26 = returnStat();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, returnStat26.Tree);

            	        }
            	        break;

            	}

            	char_literal27=(IToken)Match(input,56,FOLLOW_56_in_semicolonStatement465); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:188:1: oneLineStatement : ( variableDeclarationList | variableAssignment | variableUnaryChange );
    public SGLParser.oneLineStatement_return oneLineStatement() // throws RecognitionException [1]
    {   
        SGLParser.oneLineStatement_return retval = new SGLParser.oneLineStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.variableDeclarationList_return variableDeclarationList28 = default(SGLParser.variableDeclarationList_return);

        SGLParser.variableAssignment_return variableAssignment29 = default(SGLParser.variableAssignment_return);

        SGLParser.variableUnaryChange_return variableUnaryChange30 = default(SGLParser.variableUnaryChange_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:189:2: ( variableDeclarationList | variableAssignment | variableUnaryChange )
            int alt7 = 3;
            int LA7_0 = input.LA(1);

            if ( ((LA7_0 >= IntType && LA7_0 <= ObjectType) || LA7_0 == 58) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == Identifier) )
            {
                int LA7_2 = input.LA(2);

                if ( (LA7_2 == 59) )
                {
                    alt7 = 2;
                }
                else if ( ((LA7_2 >= 83 && LA7_2 <= 84)) )
                {
                    alt7 = 3;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:189:4: variableDeclarationList
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableDeclarationList_in_oneLineStatement478);
                    	variableDeclarationList28 = variableDeclarationList();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableDeclarationList28.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:4: variableAssignment
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableAssignment_in_oneLineStatement483);
                    	variableAssignment29 = variableAssignment();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableAssignment29.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:191:4: variableUnaryChange
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_variableUnaryChange_in_oneLineStatement488);
                    	variableUnaryChange30 = variableUnaryChange();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, variableUnaryChange30.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:195:1: statement : ( semicolonStatement | ifStatement | atStatement | whileLoop | forLoop );
    public SGLParser.statement_return statement() // throws RecognitionException [1]
    {   
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement31 = default(SGLParser.semicolonStatement_return);

        SGLParser.ifStatement_return ifStatement32 = default(SGLParser.ifStatement_return);

        SGLParser.atStatement_return atStatement33 = default(SGLParser.atStatement_return);

        SGLParser.whileLoop_return whileLoop34 = default(SGLParser.whileLoop_return);

        SGLParser.forLoop_return forLoop35 = default(SGLParser.forLoop_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:197:2: ( semicolonStatement | ifStatement | atStatement | whileLoop | forLoop )
            int alt8 = 5;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            case IntType:
            case BooleanType:
            case StringType:
            case FloatType:
            case ObjectType:
            case 58:
            case 66:
            case 67:
            	{
                alt8 = 1;
                }
                break;
            case 63:
            	{
                alt8 = 2;
                }
                break;
            case 65:
            	{
                alt8 = 3;
                }
                break;
            case 61:
            	{
                alt8 = 4;
                }
                break;
            case 62:
            	{
                alt8 = 5;
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:197:4: semicolonStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_semicolonStatement_in_statement504);
                    	semicolonStatement31 = semicolonStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, semicolonStatement31.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:198:4: ifStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statement509);
                    	ifStatement32 = ifStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, ifStatement32.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:199:4: atStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_atStatement_in_statement514);
                    	atStatement33 = atStatement();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, atStatement33.Tree);

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:4: whileLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileLoop_in_statement519);
                    	whileLoop34 = whileLoop();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, whileLoop34.Tree);

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:201:4: forLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forLoop_in_statement524);
                    	forLoop35 = forLoop();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, forLoop35.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:208:1: variableDeclarationList : ( variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( VARDEF variableType variableDecAssignment ) )+ | 'global' variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( GLOBVARDEF variableType variableDecAssignment ) )+ );
    public SGLParser.variableDeclarationList_return variableDeclarationList() // throws RecognitionException [1]
    {   
        SGLParser.variableDeclarationList_return retval = new SGLParser.variableDeclarationList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal38 = null;
        IToken string_literal40 = null;
        IToken char_literal43 = null;
        SGLParser.variableType_return variableType36 = default(SGLParser.variableType_return);

        SGLParser.variableDecAssignment_return variableDecAssignment37 = default(SGLParser.variableDecAssignment_return);

        SGLParser.variableDecAssignment_return variableDecAssignment39 = default(SGLParser.variableDecAssignment_return);

        SGLParser.variableType_return variableType41 = default(SGLParser.variableType_return);

        SGLParser.variableDecAssignment_return variableDecAssignment42 = default(SGLParser.variableDecAssignment_return);

        SGLParser.variableDecAssignment_return variableDecAssignment44 = default(SGLParser.variableDecAssignment_return);


        object char_literal38_tree=null;
        object string_literal40_tree=null;
        object char_literal43_tree=null;
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleSubtreeStream stream_variableType = new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableDecAssignment = new RewriteRuleSubtreeStream(adaptor,"rule variableDecAssignment");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:209:2: ( variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( VARDEF variableType variableDecAssignment ) )+ | 'global' variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( GLOBVARDEF variableType variableDecAssignment ) )+ )
            int alt11 = 2;
            int LA11_0 = input.LA(1);

            if ( ((LA11_0 >= IntType && LA11_0 <= ObjectType)) )
            {
                alt11 = 1;
            }
            else if ( (LA11_0 == 58) )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:209:4: variableType variableDecAssignment ( ',' variableDecAssignment )*
                    {
                    	PushFollow(FOLLOW_variableType_in_variableDeclarationList540);
                    	variableType36 = variableType();
                    	state.followingStackPointer--;

                    	stream_variableType.Add(variableType36.Tree);
                    	PushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList542);
                    	variableDecAssignment37 = variableDecAssignment();
                    	state.followingStackPointer--;

                    	stream_variableDecAssignment.Add(variableDecAssignment37.Tree);
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:209:39: ( ',' variableDecAssignment )*
                    	do 
                    	{
                    	    int alt9 = 2;
                    	    int LA9_0 = input.LA(1);

                    	    if ( (LA9_0 == 57) )
                    	    {
                    	        alt9 = 1;
                    	    }


                    	    switch (alt9) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:209:40: ',' variableDecAssignment
                    			    {
                    			    	char_literal38=(IToken)Match(input,57,FOLLOW_57_in_variableDeclarationList545);  
                    			    	stream_57.Add(char_literal38);

                    			    	PushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList547);
                    			    	variableDecAssignment39 = variableDecAssignment();
                    			    	state.followingStackPointer--;

                    			    	stream_variableDecAssignment.Add(variableDecAssignment39.Tree);

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
                    	// 209:68: -> ( ^( VARDEF variableType variableDecAssignment ) )+
                    	{
                    	    if ( !(stream_variableDecAssignment.HasNext() || stream_variableType.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_variableDecAssignment.HasNext() || stream_variableType.HasNext() )
                    	    {
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:209:71: ^( VARDEF variableType variableDecAssignment )
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
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:4: 'global' variableType variableDecAssignment ( ',' variableDecAssignment )*
                    {
                    	string_literal40=(IToken)Match(input,58,FOLLOW_58_in_variableDeclarationList565);  
                    	stream_58.Add(string_literal40);

                    	PushFollow(FOLLOW_variableType_in_variableDeclarationList567);
                    	variableType41 = variableType();
                    	state.followingStackPointer--;

                    	stream_variableType.Add(variableType41.Tree);
                    	PushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList569);
                    	variableDecAssignment42 = variableDecAssignment();
                    	state.followingStackPointer--;

                    	stream_variableDecAssignment.Add(variableDecAssignment42.Tree);
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:48: ( ',' variableDecAssignment )*
                    	do 
                    	{
                    	    int alt10 = 2;
                    	    int LA10_0 = input.LA(1);

                    	    if ( (LA10_0 == 57) )
                    	    {
                    	        alt10 = 1;
                    	    }


                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:49: ',' variableDecAssignment
                    			    {
                    			    	char_literal43=(IToken)Match(input,57,FOLLOW_57_in_variableDeclarationList572);  
                    			    	stream_57.Add(char_literal43);

                    			    	PushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList574);
                    			    	variableDecAssignment44 = variableDecAssignment();
                    			    	state.followingStackPointer--;

                    			    	stream_variableDecAssignment.Add(variableDecAssignment44.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop10;
                    	    }
                    	} while (true);

                    	loop10:
                    		;	// Stops C# compiler whining that label 'loop10' has no statements



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
                    	// 210:77: -> ( ^( GLOBVARDEF variableType variableDecAssignment ) )+
                    	{
                    	    if ( !(stream_variableDecAssignment.HasNext() || stream_variableType.HasNext()) ) {
                    	        throw new RewriteEarlyExitException();
                    	    }
                    	    while ( stream_variableDecAssignment.HasNext() || stream_variableType.HasNext() )
                    	    {
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:80: ^( GLOBVARDEF variableType variableDecAssignment )
                    	        {
                    	        object root_1 = (object)adaptor.GetNilNode();
                    	        root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(GLOBVARDEF, "GLOBVARDEF"), root_1);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:213:1: variableDecAssignment : variableName ( '=' expression )? -> variableName ( expression )? ;
    public SGLParser.variableDecAssignment_return variableDecAssignment() // throws RecognitionException [1]
    {   
        SGLParser.variableDecAssignment_return retval = new SGLParser.variableDecAssignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal46 = null;
        SGLParser.variableName_return variableName45 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression47 = default(SGLParser.expression_return);


        object char_literal46_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:214:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:214:4: variableName ( '=' expression )?
            {
            	PushFollow(FOLLOW_variableName_in_variableDecAssignment598);
            	variableName45 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName45.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:214:17: ( '=' expression )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == 59) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:214:18: '=' expression
            	        {
            	        	char_literal46=(IToken)Match(input,59,FOLLOW_59_in_variableDecAssignment601);  
            	        	stream_59.Add(char_literal46);

            	        	PushFollow(FOLLOW_expression_in_variableDecAssignment603);
            	        	expression47 = expression();
            	        	state.followingStackPointer--;

            	        	stream_expression.Add(expression47.Tree);

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
            	// 214:36: -> variableName ( expression )?
            	{
            	    adaptor.AddChild(root_0, stream_variableName.NextTree());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:214:52: ( expression )?
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:217:1: variableAssignment : variableName '=' expression -> ^( ASSIGN variableName expression ) ;
    public SGLParser.variableAssignment_return variableAssignment() // throws RecognitionException [1]
    {   
        SGLParser.variableAssignment_return retval = new SGLParser.variableAssignment_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal49 = null;
        SGLParser.variableName_return variableName48 = default(SGLParser.variableName_return);

        SGLParser.expression_return expression50 = default(SGLParser.expression_return);


        object char_literal49_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:218:2: ( variableName '=' expression -> ^( ASSIGN variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:218:4: variableName '=' expression
            {
            	PushFollow(FOLLOW_variableName_in_variableAssignment624);
            	variableName48 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName48.Tree);
            	char_literal49=(IToken)Match(input,59,FOLLOW_59_in_variableAssignment626);  
            	stream_59.Add(char_literal49);

            	PushFollow(FOLLOW_expression_in_variableAssignment628);
            	expression50 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression50.Tree);


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
            	// 218:33: -> ^( ASSIGN variableName expression )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:218:36: ^( ASSIGN variableName expression )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:226:1: variableName : Identifier ;
    public SGLParser.variableName_return variableName() // throws RecognitionException [1]
    {   
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier51 = null;

        object Identifier51_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:227:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:227:4: Identifier
            {
            	root_0 = (object)adaptor.GetNilNode();

            	Identifier51=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableName659); 
            		Identifier51_tree = (object)adaptor.Create(Identifier51);
            		adaptor.AddChild(root_0, Identifier51_tree);


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:230:1: variableType : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public SGLParser.variableType_return variableType() // throws RecognitionException [1]
    {   
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set52 = null;

        object set52_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set52 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntType && input.LA(1) <= ObjectType) ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set52));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:239:1: objectMethod : variableName '.' Identifier '(' ( arguments )? ')' -> ^( OBJMETHOD variableName Identifier ( arguments )? ) ;
    public SGLParser.objectMethod_return objectMethod() // throws RecognitionException [1]
    {   
        SGLParser.objectMethod_return retval = new SGLParser.objectMethod_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal54 = null;
        IToken Identifier55 = null;
        IToken char_literal56 = null;
        IToken char_literal58 = null;
        SGLParser.variableName_return variableName53 = default(SGLParser.variableName_return);

        SGLParser.arguments_return arguments57 = default(SGLParser.arguments_return);


        object char_literal54_tree=null;
        object Identifier55_tree=null;
        object char_literal56_tree=null;
        object char_literal58_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:240:2: ( variableName '.' Identifier '(' ( arguments )? ')' -> ^( OBJMETHOD variableName Identifier ( arguments )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:240:4: variableName '.' Identifier '(' ( arguments )? ')'
            {
            	PushFollow(FOLLOW_variableName_in_objectMethod703);
            	variableName53 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName53.Tree);
            	char_literal54=(IToken)Match(input,60,FOLLOW_60_in_objectMethod705);  
            	stream_60.Add(char_literal54);

            	Identifier55=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_objectMethod707);  
            	stream_Identifier.Add(Identifier55);

            	char_literal56=(IToken)Match(input,53,FOLLOW_53_in_objectMethod709);  
            	stream_53.Add(char_literal56);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:240:36: ( arguments )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == Identifier || (LA13_0 >= IntegerAtom && LA13_0 <= BooleanAtom) || (LA13_0 >= Layer && LA13_0 <= StringAtom) || LA13_0 == 53 || LA13_0 == 79 || LA13_0 == 85) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:240:36: arguments
            	        {
            	        	PushFollow(FOLLOW_arguments_in_objectMethod711);
            	        	arguments57 = arguments();
            	        	state.followingStackPointer--;

            	        	stream_arguments.Add(arguments57.Tree);

            	        }
            	        break;

            	}

            	char_literal58=(IToken)Match(input,54,FOLLOW_54_in_objectMethod714);  
            	stream_54.Add(char_literal58);



            	// AST REWRITE
            	// elements:          variableName, arguments, Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 240:51: -> ^( OBJMETHOD variableName Identifier ( arguments )? )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:240:54: ^( OBJMETHOD variableName Identifier ( arguments )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(OBJMETHOD, "OBJMETHOD"), root_1);

            	    adaptor.AddChild(root_1, stream_variableName.NextTree());
            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:240:90: ( arguments )?
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:243:1: whileLoop : 'while' expression commonBlock -> ^( 'while' expression commonBlock ) ;
    public SGLParser.whileLoop_return whileLoop() // throws RecognitionException [1]
    {   
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal59 = null;
        SGLParser.expression_return expression60 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock61 = default(SGLParser.commonBlock_return);


        object string_literal59_tree=null;
        RewriteRuleTokenStream stream_61 = new RewriteRuleTokenStream(adaptor,"token 61");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:2: ( 'while' expression commonBlock -> ^( 'while' expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:4: 'while' expression commonBlock
            {
            	string_literal59=(IToken)Match(input,61,FOLLOW_61_in_whileLoop738);  
            	stream_61.Add(string_literal59);

            	PushFollow(FOLLOW_expression_in_whileLoop740);
            	expression60 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression60.Tree);
            	PushFollow(FOLLOW_commonBlock_in_whileLoop742);
            	commonBlock61 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock61.Tree);


            	// AST REWRITE
            	// elements:          expression, 61, commonBlock
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 244:35: -> ^( 'while' expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:38: ^( 'while' expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_61.NextNode(), root_1);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:1: forLoop : 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) ;
    public SGLParser.forLoop_return forLoop() // throws RecognitionException [1]
    {   
        SGLParser.forLoop_return retval = new SGLParser.forLoop_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal62 = null;
        IToken char_literal63 = null;
        IToken char_literal64 = null;
        IToken char_literal65 = null;
        IToken char_literal66 = null;
        SGLParser.oneLineStatement_return dec = default(SGLParser.oneLineStatement_return);

        SGLParser.expression_return cond = default(SGLParser.expression_return);

        SGLParser.oneLineStatement_return iter = default(SGLParser.oneLineStatement_return);

        SGLParser.commonBlock_return commonBlock67 = default(SGLParser.commonBlock_return);


        object string_literal62_tree=null;
        object char_literal63_tree=null;
        object char_literal64_tree=null;
        object char_literal65_tree=null;
        object char_literal66_tree=null;
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_62 = new RewriteRuleTokenStream(adaptor,"token 62");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        RewriteRuleSubtreeStream stream_oneLineStatement = new RewriteRuleSubtreeStream(adaptor,"rule oneLineStatement");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:2: ( 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:4: 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock
            {
            	string_literal62=(IToken)Match(input,62,FOLLOW_62_in_forLoop764);  
            	stream_62.Add(string_literal62);

            	char_literal63=(IToken)Match(input,53,FOLLOW_53_in_forLoop766);  
            	stream_53.Add(char_literal63);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:17: (dec= oneLineStatement )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( ((LA14_0 >= Identifier && LA14_0 <= ObjectType) || LA14_0 == 58) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:17: dec= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop770);
            	        	dec = oneLineStatement();
            	        	state.followingStackPointer--;

            	        	stream_oneLineStatement.Add(dec.Tree);

            	        }
            	        break;

            	}

            	char_literal64=(IToken)Match(input,56,FOLLOW_56_in_forLoop773);  
            	stream_56.Add(char_literal64);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:44: (cond= expression )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == Identifier || (LA15_0 >= IntegerAtom && LA15_0 <= BooleanAtom) || (LA15_0 >= Layer && LA15_0 <= StringAtom) || LA15_0 == 53 || LA15_0 == 79 || LA15_0 == 85) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:44: cond= expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forLoop777);
            	        	cond = expression();
            	        	state.followingStackPointer--;

            	        	stream_expression.Add(cond.Tree);

            	        }
            	        break;

            	}

            	char_literal65=(IToken)Match(input,56,FOLLOW_56_in_forLoop780);  
            	stream_56.Add(char_literal65);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:65: (iter= oneLineStatement )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( ((LA16_0 >= Identifier && LA16_0 <= ObjectType) || LA16_0 == 58) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:65: iter= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop784);
            	        	iter = oneLineStatement();
            	        	state.followingStackPointer--;

            	        	stream_oneLineStatement.Add(iter.Tree);

            	        }
            	        break;

            	}

            	char_literal66=(IToken)Match(input,54,FOLLOW_54_in_forLoop787);  
            	stream_54.Add(char_literal66);

            	PushFollow(FOLLOW_commonBlock_in_forLoop789);
            	commonBlock67 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock67.Tree);


            	// AST REWRITE
            	// elements:          iter, dec, 62, commonBlock, cond
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
            	// 249:2: -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:249:5: ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_62.NextNode(), root_1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:249:13: ^( FORDEC ( $dec)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORDEC, "FORDEC"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:249:22: ( $dec)?
            	    if ( stream_dec.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_dec.NextTree());

            	    }
            	    stream_dec.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:249:29: ^( FORCOND ( $cond)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORCOND, "FORCOND"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:249:39: ( $cond)?
            	    if ( stream_cond.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_cond.NextTree());

            	    }
            	    stream_cond.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:249:47: ^( FORITER ( $iter)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORITER, "FORITER"), root_2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:249:57: ( $iter)?
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:252:1: ifStatement : ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) ;
    public SGLParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        SGLParser.ifStatement_return retval = new SGLParser.ifStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.ifStat_return ifStat68 = default(SGLParser.ifStat_return);

        SGLParser.elseIfStat_return elseIfStat69 = default(SGLParser.elseIfStat_return);

        SGLParser.elseStat_return elseStat70 = default(SGLParser.elseStat_return);


        RewriteRuleSubtreeStream stream_elseIfStat = new RewriteRuleSubtreeStream(adaptor,"rule elseIfStat");
        RewriteRuleSubtreeStream stream_ifStat = new RewriteRuleSubtreeStream(adaptor,"rule ifStat");
        RewriteRuleSubtreeStream stream_elseStat = new RewriteRuleSubtreeStream(adaptor,"rule elseStat");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:2: ( ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:4: ifStat ( elseIfStat )* ( elseStat )?
            {
            	PushFollow(FOLLOW_ifStat_in_ifStatement834);
            	ifStat68 = ifStat();
            	state.followingStackPointer--;

            	stream_ifStat.Add(ifStat68.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:11: ( elseIfStat )*
            	do 
            	{
            	    int alt17 = 2;
            	    int LA17_0 = input.LA(1);

            	    if ( (LA17_0 == 64) )
            	    {
            	        int LA17_1 = input.LA(2);

            	        if ( (LA17_1 == 63) )
            	        {
            	            alt17 = 1;
            	        }


            	    }


            	    switch (alt17) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:11: elseIfStat
            			    {
            			    	PushFollow(FOLLOW_elseIfStat_in_ifStatement836);
            			    	elseIfStat69 = elseIfStat();
            			    	state.followingStackPointer--;

            			    	stream_elseIfStat.Add(elseIfStat69.Tree);

            			    }
            			    break;

            			default:
            			    goto loop17;
            	    }
            	} while (true);

            	loop17:
            		;	// Stops C# compiler whining that label 'loop17' has no statements

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:23: ( elseStat )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == 64) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:23: elseStat
            	        {
            	        	PushFollow(FOLLOW_elseStat_in_ifStatement839);
            	        	elseStat70 = elseStat();
            	        	state.followingStackPointer--;

            	        	stream_elseStat.Add(elseStat70.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          elseIfStat, elseStat, ifStat
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 253:33: -> ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:36: ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF, "IF"), root_1);

            	    adaptor.AddChild(root_1, stream_ifStat.NextTree());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:48: ( elseIfStat )*
            	    while ( stream_elseIfStat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_elseIfStat.NextTree());

            	    }
            	    stream_elseIfStat.Reset();
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:60: ( elseStat )?
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:255:1: ifStat : 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.ifStat_return ifStat() // throws RecognitionException [1]
    {   
        SGLParser.ifStat_return retval = new SGLParser.ifStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal71 = null;
        SGLParser.expression_return expression72 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock73 = default(SGLParser.commonBlock_return);


        object string_literal71_tree=null;
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:256:2: ( 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:256:4: 'if' expression commonBlock
            {
            	string_literal71=(IToken)Match(input,63,FOLLOW_63_in_ifStat864);  
            	stream_63.Add(string_literal71);

            	PushFollow(FOLLOW_expression_in_ifStat866);
            	expression72 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression72.Tree);
            	PushFollow(FOLLOW_commonBlock_in_ifStat868);
            	commonBlock73 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock73.Tree);


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
            	// 256:32: -> ^( EXP expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:256:35: ^( EXP expression commonBlock )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:259:1: elseIfStat : 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.elseIfStat_return elseIfStat() // throws RecognitionException [1]
    {   
        SGLParser.elseIfStat_return retval = new SGLParser.elseIfStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal74 = null;
        IToken string_literal75 = null;
        SGLParser.expression_return expression76 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock77 = default(SGLParser.commonBlock_return);


        object string_literal74_tree=null;
        object string_literal75_tree=null;
        RewriteRuleTokenStream stream_64 = new RewriteRuleTokenStream(adaptor,"token 64");
        RewriteRuleTokenStream stream_63 = new RewriteRuleTokenStream(adaptor,"token 63");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:260:2: ( 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:260:4: 'else' 'if' expression commonBlock
            {
            	string_literal74=(IToken)Match(input,64,FOLLOW_64_in_elseIfStat889);  
            	stream_64.Add(string_literal74);

            	string_literal75=(IToken)Match(input,63,FOLLOW_63_in_elseIfStat891);  
            	stream_63.Add(string_literal75);

            	PushFollow(FOLLOW_expression_in_elseIfStat893);
            	expression76 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression76.Tree);
            	PushFollow(FOLLOW_commonBlock_in_elseIfStat895);
            	commonBlock77 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock77.Tree);


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
            	// 260:39: -> ^( EXP expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:260:42: ^( EXP expression commonBlock )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:1: elseStat : 'else' commonBlock -> ^( EXP commonBlock ) ;
    public SGLParser.elseStat_return elseStat() // throws RecognitionException [1]
    {   
        SGLParser.elseStat_return retval = new SGLParser.elseStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal78 = null;
        SGLParser.commonBlock_return commonBlock79 = default(SGLParser.commonBlock_return);


        object string_literal78_tree=null;
        RewriteRuleTokenStream stream_64 = new RewriteRuleTokenStream(adaptor,"token 64");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:264:2: ( 'else' commonBlock -> ^( EXP commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:264:4: 'else' commonBlock
            {
            	string_literal78=(IToken)Match(input,64,FOLLOW_64_in_elseStat917);  
            	stream_64.Add(string_literal78);

            	PushFollow(FOLLOW_commonBlock_in_elseStat919);
            	commonBlock79 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock79.Tree);


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
            	// 264:23: -> ^( EXP commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:264:26: ^( EXP commonBlock )
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

    public class atStatement_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "atStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:271:1: atStatement : 'at' expression commonBlock -> ^( AT expression commonBlock ) ;
    public SGLParser.atStatement_return atStatement() // throws RecognitionException [1]
    {   
        SGLParser.atStatement_return retval = new SGLParser.atStatement_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal80 = null;
        SGLParser.expression_return expression81 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock82 = default(SGLParser.commonBlock_return);


        object string_literal80_tree=null;
        RewriteRuleTokenStream stream_65 = new RewriteRuleTokenStream(adaptor,"token 65");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:272:2: ( 'at' expression commonBlock -> ^( AT expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:272:4: 'at' expression commonBlock
            {
            	string_literal80=(IToken)Match(input,65,FOLLOW_65_in_atStatement944);  
            	stream_65.Add(string_literal80);

            	PushFollow(FOLLOW_expression_in_atStatement946);
            	expression81 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression81.Tree);
            	PushFollow(FOLLOW_commonBlock_in_atStatement948);
            	commonBlock82 = commonBlock();
            	state.followingStackPointer--;

            	stream_commonBlock.Add(commonBlock82.Tree);


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
            	// 272:32: -> ^( AT expression commonBlock )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:272:35: ^( AT expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(AT, "AT"), root_1);

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
    // $ANTLR end "atStatement"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:275:1: breakStat : 'break' -> BREAK ;
    public SGLParser.breakStat_return breakStat() // throws RecognitionException [1]
    {   
        SGLParser.breakStat_return retval = new SGLParser.breakStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal83 = null;

        object string_literal83_tree=null;
        RewriteRuleTokenStream stream_66 = new RewriteRuleTokenStream(adaptor,"token 66");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:276:2: ( 'break' -> BREAK )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:276:4: 'break'
            {
            	string_literal83=(IToken)Match(input,66,FOLLOW_66_in_breakStat970);  
            	stream_66.Add(string_literal83);



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
            	// 276:12: -> BREAK
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

    public class returnStat_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "returnStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:279:1: returnStat : 'return' expression -> ^( RETURN expression ) ;
    public SGLParser.returnStat_return returnStat() // throws RecognitionException [1]
    {   
        SGLParser.returnStat_return retval = new SGLParser.returnStat_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal84 = null;
        SGLParser.expression_return expression85 = default(SGLParser.expression_return);


        object string_literal84_tree=null;
        RewriteRuleTokenStream stream_67 = new RewriteRuleTokenStream(adaptor,"token 67");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:280:2: ( 'return' expression -> ^( RETURN expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:280:4: 'return' expression
            {
            	string_literal84=(IToken)Match(input,67,FOLLOW_67_in_returnStat985);  
            	stream_67.Add(string_literal84);

            	PushFollow(FOLLOW_expression_in_returnStat987);
            	expression85 = expression();
            	state.followingStackPointer--;

            	stream_expression.Add(expression85.Tree);


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
            	// 280:24: -> ^( RETURN expression )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:280:27: ^( RETURN expression )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURN, "RETURN"), root_1);

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
    // $ANTLR end "returnStat"

    public class methodCall_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "methodCall"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:283:1: methodCall : Identifier '(' ( expressionList )? ')' -> ^( METH_CALL Identifier ( expressionList )? ) ;
    public SGLParser.methodCall_return methodCall() // throws RecognitionException [1]
    {   
        SGLParser.methodCall_return retval = new SGLParser.methodCall_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier86 = null;
        IToken char_literal87 = null;
        IToken char_literal89 = null;
        SGLParser.expressionList_return expressionList88 = default(SGLParser.expressionList_return);


        object Identifier86_tree=null;
        object char_literal87_tree=null;
        object char_literal89_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_expressionList = new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:284:2: ( Identifier '(' ( expressionList )? ')' -> ^( METH_CALL Identifier ( expressionList )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:284:4: Identifier '(' ( expressionList )? ')'
            {
            	Identifier86=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodCall1006);  
            	stream_Identifier.Add(Identifier86);

            	char_literal87=(IToken)Match(input,53,FOLLOW_53_in_methodCall1008);  
            	stream_53.Add(char_literal87);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:284:19: ( expressionList )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == Identifier || (LA19_0 >= IntegerAtom && LA19_0 <= BooleanAtom) || (LA19_0 >= Layer && LA19_0 <= StringAtom) || LA19_0 == 53 || LA19_0 == 79 || LA19_0 == 85) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:284:19: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_methodCall1010);
            	        	expressionList88 = expressionList();
            	        	state.followingStackPointer--;

            	        	stream_expressionList.Add(expressionList88.Tree);

            	        }
            	        break;

            	}

            	char_literal89=(IToken)Match(input,54,FOLLOW_54_in_methodCall1013);  
            	stream_54.Add(char_literal89);



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
            	// 284:39: -> ^( METH_CALL Identifier ( expressionList )? )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:284:42: ^( METH_CALL Identifier ( expressionList )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METH_CALL, "METH_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:284:65: ( expressionList )?
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
    // $ANTLR end "methodCall"

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:303:1: expression : conditionalExpression ;
    public SGLParser.expression_return expression() // throws RecognitionException [1]
    {   
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression90 = default(SGLParser.conditionalExpression_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:304:5: ( conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:304:8: conditionalExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalExpression_in_expression1070);
            	conditionalExpression90 = conditionalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalExpression90.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:313:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public SGLParser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal92 = null;
        IToken char_literal94 = null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression91 = default(SGLParser.conditionalOrExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression93 = default(SGLParser.conditionalExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression95 = default(SGLParser.conditionalExpression_return);


        object char_literal92_tree=null;
        object char_literal94_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression1111);
            	conditionalOrExpression91 = conditionalOrExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalOrExpression91.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == 68) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	char_literal92=(IToken)Match(input,68,FOLLOW_68_in_conditionalExpression1115); 
            	        		char_literal92_tree = (object)adaptor.Create(char_literal92);
            	        		root_0 = (object)adaptor.BecomeRoot(char_literal92_tree, root_0);

            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression1118);
            	        	conditionalExpression93 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression93.Tree);
            	        	char_literal94=(IToken)Match(input,69,FOLLOW_69_in_conditionalExpression1120); 
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression1123);
            	        	conditionalExpression95 = conditionalExpression();
            	        	state.followingStackPointer--;

            	        	adaptor.AddChild(root_0, conditionalExpression95.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:319:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public SGLParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal97 = null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression96 = default(SGLParser.conditionalAndExpression_return);

        SGLParser.conditionalAndExpression_return conditionalAndExpression98 = default(SGLParser.conditionalAndExpression_return);


        object string_literal97_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:320:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:320:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1166);
            	conditionalAndExpression96 = conditionalAndExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, conditionalAndExpression96.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:320:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == 70) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:320:36: '||' conditionalAndExpression
            			    {
            			    	string_literal97=(IToken)Match(input,70,FOLLOW_70_in_conditionalOrExpression1170); 
            			    		string_literal97_tree = (object)adaptor.Create(string_literal97);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal97_tree, root_0);

            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1173);
            			    	conditionalAndExpression98 = conditionalAndExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, conditionalAndExpression98.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:324:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public SGLParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal100 = null;
        SGLParser.equalityExpression_return equalityExpression99 = default(SGLParser.equalityExpression_return);

        SGLParser.equalityExpression_return equalityExpression101 = default(SGLParser.equalityExpression_return);


        object string_literal100_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:325:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:325:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1204);
            	equalityExpression99 = equalityExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, equalityExpression99.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:325:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == 71) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:325:30: '&&' equalityExpression
            			    {
            			    	string_literal100=(IToken)Match(input,71,FOLLOW_71_in_conditionalAndExpression1208); 
            			    		string_literal100_tree = (object)adaptor.Create(string_literal100);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal100_tree, root_0);

            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1211);
            			    	equalityExpression101 = equalityExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, equalityExpression101.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:329:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public SGLParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal103 = null;
        IToken string_literal104 = null;
        SGLParser.relationalExpression_return relationalExpression102 = default(SGLParser.relationalExpression_return);

        SGLParser.relationalExpression_return relationalExpression105 = default(SGLParser.relationalExpression_return);


        object string_literal103_tree=null;
        object string_literal104_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:330:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:330:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1238);
            	relationalExpression102 = relationalExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, relationalExpression102.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:330:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( ((LA24_0 >= 72 && LA24_0 <= 73)) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:330:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:330:32: ( '==' | '!=' )
            			    	int alt23 = 2;
            			    	int LA23_0 = input.LA(1);

            			    	if ( (LA23_0 == 72) )
            			    	{
            			    	    alt23 = 1;
            			    	}
            			    	else if ( (LA23_0 == 73) )
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:330:33: '=='
            			    	        {
            			    	        	string_literal103=(IToken)Match(input,72,FOLLOW_72_in_equalityExpression1243); 
            			    	        		string_literal103_tree = (object)adaptor.Create(string_literal103);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal103_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:330:41: '!='
            			    	        {
            			    	        	string_literal104=(IToken)Match(input,73,FOLLOW_73_in_equalityExpression1248); 
            			    	        		string_literal104_tree = (object)adaptor.Create(string_literal104);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal104_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1252);
            			    	relationalExpression105 = relationalExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, relationalExpression105.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:334:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public SGLParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal107 = null;
        IToken char_literal108 = null;
        IToken string_literal109 = null;
        IToken string_literal110 = null;
        SGLParser.additiveExpression_return additiveExpression106 = default(SGLParser.additiveExpression_return);

        SGLParser.additiveExpression_return additiveExpression111 = default(SGLParser.additiveExpression_return);


        object char_literal107_tree=null;
        object char_literal108_tree=null;
        object string_literal109_tree=null;
        object string_literal110_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:335:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:335:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1283);
            	additiveExpression106 = additiveExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, additiveExpression106.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:335:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( ((LA26_0 >= 74 && LA26_0 <= 77)) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:335:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:335:29: ( '<' | '>' | '<=' | '>=' )
            			    	int alt25 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 74:
            			    		{
            			    	    alt25 = 1;
            			    	    }
            			    	    break;
            			    	case 75:
            			    		{
            			    	    alt25 = 2;
            			    	    }
            			    	    break;
            			    	case 76:
            			    		{
            			    	    alt25 = 3;
            			    	    }
            			    	    break;
            			    	case 77:
            			    		{
            			    	    alt25 = 4;
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:335:30: '<'
            			    	        {
            			    	        	char_literal107=(IToken)Match(input,74,FOLLOW_74_in_relationalExpression1287); 
            			    	        		char_literal107_tree = (object)adaptor.Create(char_literal107);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal107_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:335:35: '>'
            			    	        {
            			    	        	char_literal108=(IToken)Match(input,75,FOLLOW_75_in_relationalExpression1290); 
            			    	        		char_literal108_tree = (object)adaptor.Create(char_literal108);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal108_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:335:40: '<='
            			    	        {
            			    	        	string_literal109=(IToken)Match(input,76,FOLLOW_76_in_relationalExpression1293); 
            			    	        		string_literal109_tree = (object)adaptor.Create(string_literal109);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal109_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:335:46: '>='
            			    	        {
            			    	        	string_literal110=(IToken)Match(input,77,FOLLOW_77_in_relationalExpression1296); 
            			    	        		string_literal110_tree = (object)adaptor.Create(string_literal110);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal110_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1300);
            			    	additiveExpression111 = additiveExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, additiveExpression111.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:339:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public SGLParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal113 = null;
        IToken char_literal114 = null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression112 = default(SGLParser.multiplicativeExpression_return);

        SGLParser.multiplicativeExpression_return multiplicativeExpression115 = default(SGLParser.multiplicativeExpression_return);


        object char_literal113_tree=null;
        object char_literal114_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:340:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:340:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1338);
            	multiplicativeExpression112 = multiplicativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, multiplicativeExpression112.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:340:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( ((LA28_0 >= 78 && LA28_0 <= 79)) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:340:35: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:340:35: ( '+' | '-' )
            			    	int alt27 = 2;
            			    	int LA27_0 = input.LA(1);

            			    	if ( (LA27_0 == 78) )
            			    	{
            			    	    alt27 = 1;
            			    	}
            			    	else if ( (LA27_0 == 79) )
            			    	{
            			    	    alt27 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    NoViableAltException nvae_d27s0 =
            			    	        new NoViableAltException("", 27, 0, input);

            			    	    throw nvae_d27s0;
            			    	}
            			    	switch (alt27) 
            			    	{
            			    	    case 1 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:340:36: '+'
            			    	        {
            			    	        	char_literal113=(IToken)Match(input,78,FOLLOW_78_in_additiveExpression1342); 
            			    	        		char_literal113_tree = (object)adaptor.Create(char_literal113);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal113_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:340:41: '-'
            			    	        {
            			    	        	char_literal114=(IToken)Match(input,79,FOLLOW_79_in_additiveExpression1345); 
            			    	        		char_literal114_tree = (object)adaptor.Create(char_literal114);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal114_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1349);
            			    	multiplicativeExpression115 = multiplicativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, multiplicativeExpression115.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:344:1: multiplicativeExpression : negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* ;
    public SGLParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal117 = null;
        IToken char_literal118 = null;
        IToken char_literal119 = null;
        SGLParser.negativeExpression_return negativeExpression116 = default(SGLParser.negativeExpression_return);

        SGLParser.negativeExpression_return negativeExpression120 = default(SGLParser.negativeExpression_return);


        object char_literal117_tree=null;
        object char_literal118_tree=null;
        object char_literal119_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:345:5: ( negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:345:9: negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression1383);
            	negativeExpression116 = negativeExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, negativeExpression116.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:346:5: ( ( '*' | '/' | '%' ) negativeExpression )*
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( ((LA30_0 >= 80 && LA30_0 <= 82)) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:346:6: ( '*' | '/' | '%' ) negativeExpression
            			    {
            			    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:346:6: ( '*' | '/' | '%' )
            			    	int alt29 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 80:
            			    		{
            			    	    alt29 = 1;
            			    	    }
            			    	    break;
            			    	case 81:
            			    		{
            			    	    alt29 = 2;
            			    	    }
            			    	    break;
            			    	case 82:
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
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:346:7: '*'
            			    	        {
            			    	        	char_literal117=(IToken)Match(input,80,FOLLOW_80_in_multiplicativeExpression1391); 
            			    	        		char_literal117_tree = (object)adaptor.Create(char_literal117);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal117_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:346:12: '/'
            			    	        {
            			    	        	char_literal118=(IToken)Match(input,81,FOLLOW_81_in_multiplicativeExpression1394); 
            			    	        		char_literal118_tree = (object)adaptor.Create(char_literal118);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal118_tree, root_0);


            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:346:17: '%'
            			    	        {
            			    	        	char_literal119=(IToken)Match(input,82,FOLLOW_82_in_multiplicativeExpression1397); 
            			    	        		char_literal119_tree = (object)adaptor.Create(char_literal119);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal119_tree, root_0);


            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression1401);
            			    	negativeExpression120 = negativeExpression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, negativeExpression120.Tree);

            			    }
            			    break;

            			default:
            			    goto loop30;
            	    }
            	} while (true);

            	loop30:
            		;	// Stops C# compiler whining that label 'loop30' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:349:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public SGLParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken string_literal121 = null;
        IToken string_literal123 = null;
        SGLParser.unaryExpression_return unaryExpression122 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpression_return unaryExpression124 = default(SGLParser.unaryExpression_return);

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus125 = default(SGLParser.unaryExpressionNotPlusMinus_return);


        object string_literal121_tree=null;
        object string_literal123_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:350:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt31 = 3;
            switch ( input.LA(1) ) 
            {
            case 83:
            	{
                alt31 = 1;
                }
                break;
            case 84:
            	{
                alt31 = 2;
                }
                break;
            case Identifier:
            	{
                alt31 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d31s0 =
            	        new NoViableAltException("", 31, 0, input);

            	    throw nvae_d31s0;
            }

            switch (alt31) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:350:7: '++' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal121=(IToken)Match(input,83,FOLLOW_83_in_unaryExpression1424); 
                    		string_literal121_tree = (object)adaptor.Create(string_literal121);
                    		adaptor.AddChild(root_0, string_literal121_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1426);
                    	unaryExpression122 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression122.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:351:9: '--' unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	string_literal123=(IToken)Match(input,84,FOLLOW_84_in_unaryExpression1436); 
                    		string_literal123_tree = (object)adaptor.Create(string_literal123);
                    		adaptor.AddChild(root_0, string_literal123_tree);

                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression1438);
                    	unaryExpression124 = unaryExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpression124.Tree);

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:352:9: unaryExpressionNotPlusMinus
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1448);
                    	unaryExpressionNotPlusMinus125 = unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpressionNotPlusMinus125.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:356:1: unaryExpressionNotPlusMinus : Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) ;
    public SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier126 = null;
        IToken string_literal127 = null;
        IToken string_literal128 = null;

        object Identifier126_tree=null;
        object string_literal127_tree=null;
        object string_literal128_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:357:5: ( Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:357:9: Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            {
            	Identifier126=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_unaryExpressionNotPlusMinus1469);  
            	stream_Identifier.Add(Identifier126);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:357:20: ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            	int alt32 = 2;
            	int LA32_0 = input.LA(1);

            	if ( (LA32_0 == 83) )
            	{
            	    alt32 = 1;
            	}
            	else if ( (LA32_0 == 84) )
            	{
            	    alt32 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d32s0 =
            	        new NoViableAltException("", 32, 0, input);

            	    throw nvae_d32s0;
            	}
            	switch (alt32) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:357:21: '++'
            	        {
            	        	string_literal127=(IToken)Match(input,83,FOLLOW_83_in_unaryExpressionNotPlusMinus1472);  
            	        	stream_83.Add(string_literal127);



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
            	        	// 357:26: -> ^( VARINC Identifier )
            	        	{
            	        	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:357:29: ^( VARINC Identifier )
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
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:358:4: '--'
            	        {
            	        	string_literal128=(IToken)Match(input,84,FOLLOW_84_in_unaryExpressionNotPlusMinus1485);  
            	        	stream_84.Add(string_literal128);



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
            	        	// 358:9: -> ^( VARDEC Identifier )
            	        	{
            	        	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:358:12: ^( VARDEC Identifier )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:363:1: castExpression : '(' variableType ')' unaryExpression ;
    public SGLParser.castExpression_return castExpression() // throws RecognitionException [1]
    {   
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal129 = null;
        IToken char_literal131 = null;
        SGLParser.variableType_return variableType130 = default(SGLParser.variableType_return);

        SGLParser.unaryExpression_return unaryExpression132 = default(SGLParser.unaryExpression_return);


        object char_literal129_tree=null;
        object char_literal131_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:364:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:364:8: '(' variableType ')' unaryExpression
            {
            	root_0 = (object)adaptor.GetNilNode();

            	char_literal129=(IToken)Match(input,53,FOLLOW_53_in_castExpression1522); 
            		char_literal129_tree = (object)adaptor.Create(char_literal129);
            		adaptor.AddChild(root_0, char_literal129_tree);

            	PushFollow(FOLLOW_variableType_in_castExpression1524);
            	variableType130 = variableType();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, variableType130.Tree);
            	char_literal131=(IToken)Match(input,54,FOLLOW_54_in_castExpression1526); 
            		char_literal131_tree = (object)adaptor.Create(char_literal131);
            		adaptor.AddChild(root_0, char_literal131_tree);

            	PushFollow(FOLLOW_unaryExpression_in_castExpression1528);
            	unaryExpression132 = unaryExpression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, unaryExpression132.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:369:1: negativeExpression : ( mathAtom | '-' mathAtom -> ^( NEGATE mathAtom ) | unaryExpressionNotPlusMinus );
    public SGLParser.negativeExpression_return negativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.negativeExpression_return retval = new SGLParser.negativeExpression_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal134 = null;
        SGLParser.mathAtom_return mathAtom133 = default(SGLParser.mathAtom_return);

        SGLParser.mathAtom_return mathAtom135 = default(SGLParser.mathAtom_return);

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus136 = default(SGLParser.unaryExpressionNotPlusMinus_return);


        object char_literal134_tree=null;
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleSubtreeStream stream_mathAtom = new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:370:2: ( mathAtom | '-' mathAtom -> ^( NEGATE mathAtom ) | unaryExpressionNotPlusMinus )
            int alt33 = 3;
            switch ( input.LA(1) ) 
            {
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case Layer:
            case Origin:
            case LoopType:
            case StringAtom:
            case 53:
            case 85:
            	{
                alt33 = 1;
                }
                break;
            case Identifier:
            	{
                int LA33_2 = input.LA(2);

                if ( ((LA33_2 >= Identifier && LA33_2 <= ObjectType) || LA33_2 == 50 || (LA33_2 >= 53 && LA33_2 <= 54) || (LA33_2 >= 56 && LA33_2 <= 58) || LA33_2 == 60 || (LA33_2 >= 66 && LA33_2 <= 82)) )
                {
                    alt33 = 1;
                }
                else if ( ((LA33_2 >= 83 && LA33_2 <= 84)) )
                {
                    alt33 = 3;
                }
                else 
                {
                    NoViableAltException nvae_d33s2 =
                        new NoViableAltException("", 33, 2, input);

                    throw nvae_d33s2;
                }
                }
                break;
            case 79:
            	{
                alt33 = 2;
                }
                break;
            	default:
            	    NoViableAltException nvae_d33s0 =
            	        new NoViableAltException("", 33, 0, input);

            	    throw nvae_d33s0;
            }

            switch (alt33) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:370:4: mathAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mathAtom_in_negativeExpression1546);
                    	mathAtom133 = mathAtom();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, mathAtom133.Tree);

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:371:4: '-' mathAtom
                    {
                    	char_literal134=(IToken)Match(input,79,FOLLOW_79_in_negativeExpression1551);  
                    	stream_79.Add(char_literal134);

                    	PushFollow(FOLLOW_mathAtom_in_negativeExpression1553);
                    	mathAtom135 = mathAtom();
                    	state.followingStackPointer--;

                    	stream_mathAtom.Add(mathAtom135.Tree);


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
                    	// 371:17: -> ^( NEGATE mathAtom )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:371:20: ^( NEGATE mathAtom )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:372:4: unaryExpressionNotPlusMinus
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_negativeExpression1566);
                    	unaryExpressionNotPlusMinus136 = unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, unaryExpressionNotPlusMinus136.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:375:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' Sprite '(' ( arguments )? ')' -> ^( Sprite ( arguments )? ) | 'new' Animation '(' ( arguments )? ')' -> ^( Animation ( arguments )? ) | objectMethod | Identifier | methodCall | stringQuote | Layer -> ^( STRINGNOQUOTES Layer ) | Origin -> ^( STRINGNOQUOTES Origin ) | LoopType -> ^( STRINGNOQUOTES LoopType ) );
    public SGLParser.mathAtom_return mathAtom() // throws RecognitionException [1]
    {   
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal137 = null;
        IToken char_literal139 = null;
        IToken IntegerAtom140 = null;
        IToken FloatAtom141 = null;
        IToken BooleanAtom142 = null;
        IToken string_literal143 = null;
        IToken Sprite144 = null;
        IToken char_literal145 = null;
        IToken char_literal147 = null;
        IToken string_literal148 = null;
        IToken Animation149 = null;
        IToken char_literal150 = null;
        IToken char_literal152 = null;
        IToken Identifier154 = null;
        IToken Layer157 = null;
        IToken Origin158 = null;
        IToken LoopType159 = null;
        SGLParser.conditionalExpression_return conditionalExpression138 = default(SGLParser.conditionalExpression_return);

        SGLParser.arguments_return arguments146 = default(SGLParser.arguments_return);

        SGLParser.arguments_return arguments151 = default(SGLParser.arguments_return);

        SGLParser.objectMethod_return objectMethod153 = default(SGLParser.objectMethod_return);

        SGLParser.methodCall_return methodCall155 = default(SGLParser.methodCall_return);

        SGLParser.stringQuote_return stringQuote156 = default(SGLParser.stringQuote_return);


        object char_literal137_tree=null;
        object char_literal139_tree=null;
        object IntegerAtom140_tree=null;
        object FloatAtom141_tree=null;
        object BooleanAtom142_tree=null;
        object string_literal143_tree=null;
        object Sprite144_tree=null;
        object char_literal145_tree=null;
        object char_literal147_tree=null;
        object string_literal148_tree=null;
        object Animation149_tree=null;
        object char_literal150_tree=null;
        object char_literal152_tree=null;
        object Identifier154_tree=null;
        object Layer157_tree=null;
        object Origin158_tree=null;
        object LoopType159_tree=null;
        RewriteRuleTokenStream stream_Layer = new RewriteRuleTokenStream(adaptor,"token Layer");
        RewriteRuleTokenStream stream_Animation = new RewriteRuleTokenStream(adaptor,"token Animation");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_Origin = new RewriteRuleTokenStream(adaptor,"token Origin");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleTokenStream stream_LoopType = new RewriteRuleTokenStream(adaptor,"token LoopType");
        RewriteRuleTokenStream stream_Sprite = new RewriteRuleTokenStream(adaptor,"token Sprite");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleSubtreeStream stream_arguments = new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:376:5: ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' Sprite '(' ( arguments )? ')' -> ^( Sprite ( arguments )? ) | 'new' Animation '(' ( arguments )? ')' -> ^( Animation ( arguments )? ) | objectMethod | Identifier | methodCall | stringQuote | Layer -> ^( STRINGNOQUOTES Layer ) | Origin -> ^( STRINGNOQUOTES Origin ) | LoopType -> ^( STRINGNOQUOTES LoopType ) )
            int alt36 = 13;
            alt36 = dfa36.Predict(input);
            switch (alt36) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:376:7: '(' conditionalExpression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal137=(IToken)Match(input,53,FOLLOW_53_in_mathAtom1580); 
                    	PushFollow(FOLLOW_conditionalExpression_in_mathAtom1583);
                    	conditionalExpression138 = conditionalExpression();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, conditionalExpression138.Tree);
                    	char_literal139=(IToken)Match(input,54,FOLLOW_54_in_mathAtom1585); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:377:9: IntegerAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IntegerAtom140=(IToken)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom1596); 
                    		IntegerAtom140_tree = (object)adaptor.Create(IntegerAtom140);
                    		adaptor.AddChild(root_0, IntegerAtom140_tree);


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:378:7: FloatAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FloatAtom141=(IToken)Match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1604); 
                    		FloatAtom141_tree = (object)adaptor.Create(FloatAtom141);
                    		adaptor.AddChild(root_0, FloatAtom141_tree);


                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:379:9: BooleanAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BooleanAtom142=(IToken)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1614); 
                    		BooleanAtom142_tree = (object)adaptor.Create(BooleanAtom142);
                    		adaptor.AddChild(root_0, BooleanAtom142_tree);


                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:381:9: 'new' Sprite '(' ( arguments )? ')'
                    {
                    	string_literal143=(IToken)Match(input,85,FOLLOW_85_in_mathAtom1625);  
                    	stream_85.Add(string_literal143);

                    	Sprite144=(IToken)Match(input,Sprite,FOLLOW_Sprite_in_mathAtom1627);  
                    	stream_Sprite.Add(Sprite144);

                    	char_literal145=(IToken)Match(input,53,FOLLOW_53_in_mathAtom1629);  
                    	stream_53.Add(char_literal145);

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:381:26: ( arguments )?
                    	int alt34 = 2;
                    	int LA34_0 = input.LA(1);

                    	if ( (LA34_0 == Identifier || (LA34_0 >= IntegerAtom && LA34_0 <= BooleanAtom) || (LA34_0 >= Layer && LA34_0 <= StringAtom) || LA34_0 == 53 || LA34_0 == 79 || LA34_0 == 85) )
                    	{
                    	    alt34 = 1;
                    	}
                    	switch (alt34) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:381:26: arguments
                    	        {
                    	        	PushFollow(FOLLOW_arguments_in_mathAtom1631);
                    	        	arguments146 = arguments();
                    	        	state.followingStackPointer--;

                    	        	stream_arguments.Add(arguments146.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal147=(IToken)Match(input,54,FOLLOW_54_in_mathAtom1634);  
                    	stream_54.Add(char_literal147);



                    	// AST REWRITE
                    	// elements:          Sprite, arguments
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 381:41: -> ^( Sprite ( arguments )? )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:381:44: ^( Sprite ( arguments )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_Sprite.NextNode(), root_1);

                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:381:53: ( arguments )?
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:382:9: 'new' Animation '(' ( arguments )? ')'
                    {
                    	string_literal148=(IToken)Match(input,85,FOLLOW_85_in_mathAtom1653);  
                    	stream_85.Add(string_literal148);

                    	Animation149=(IToken)Match(input,Animation,FOLLOW_Animation_in_mathAtom1655);  
                    	stream_Animation.Add(Animation149);

                    	char_literal150=(IToken)Match(input,53,FOLLOW_53_in_mathAtom1657);  
                    	stream_53.Add(char_literal150);

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:382:29: ( arguments )?
                    	int alt35 = 2;
                    	int LA35_0 = input.LA(1);

                    	if ( (LA35_0 == Identifier || (LA35_0 >= IntegerAtom && LA35_0 <= BooleanAtom) || (LA35_0 >= Layer && LA35_0 <= StringAtom) || LA35_0 == 53 || LA35_0 == 79 || LA35_0 == 85) )
                    	{
                    	    alt35 = 1;
                    	}
                    	switch (alt35) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:382:29: arguments
                    	        {
                    	        	PushFollow(FOLLOW_arguments_in_mathAtom1659);
                    	        	arguments151 = arguments();
                    	        	state.followingStackPointer--;

                    	        	stream_arguments.Add(arguments151.Tree);

                    	        }
                    	        break;

                    	}

                    	char_literal152=(IToken)Match(input,54,FOLLOW_54_in_mathAtom1662);  
                    	stream_54.Add(char_literal152);



                    	// AST REWRITE
                    	// elements:          Animation, arguments
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 382:44: -> ^( Animation ( arguments )? )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:382:47: ^( Animation ( arguments )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot(stream_Animation.NextNode(), root_1);

                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:382:59: ( arguments )?
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
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:383:6: objectMethod
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objectMethod_in_mathAtom1678);
                    	objectMethod153 = objectMethod();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, objectMethod153.Tree);

                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:384:4: Identifier
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	Identifier154=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_mathAtom1683); 
                    		Identifier154_tree = (object)adaptor.Create(Identifier154);
                    		adaptor.AddChild(root_0, Identifier154_tree);


                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:385:4: methodCall
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_methodCall_in_mathAtom1688);
                    	methodCall155 = methodCall();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, methodCall155.Tree);

                    }
                    break;
                case 10 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:386:4: stringQuote
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stringQuote_in_mathAtom1693);
                    	stringQuote156 = stringQuote();
                    	state.followingStackPointer--;

                    	adaptor.AddChild(root_0, stringQuote156.Tree);

                    }
                    break;
                case 11 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:387:4: Layer
                    {
                    	Layer157=(IToken)Match(input,Layer,FOLLOW_Layer_in_mathAtom1698);  
                    	stream_Layer.Add(Layer157);



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
                    	// 387:10: -> ^( STRINGNOQUOTES Layer )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:387:13: ^( STRINGNOQUOTES Layer )
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
                case 12 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:388:4: Origin
                    {
                    	Origin158=(IToken)Match(input,Origin,FOLLOW_Origin_in_mathAtom1711);  
                    	stream_Origin.Add(Origin158);



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
                    	// 388:11: -> ^( STRINGNOQUOTES Origin )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:388:14: ^( STRINGNOQUOTES Origin )
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
                case 13 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:389:4: LoopType
                    {
                    	LoopType159=(IToken)Match(input,LoopType,FOLLOW_LoopType_in_mathAtom1724);  
                    	stream_LoopType.Add(LoopType159);



                    	// AST REWRITE
                    	// elements:          LoopType
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 389:13: -> ^( STRINGNOQUOTES LoopType )
                    	{
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:389:16: ^( STRINGNOQUOTES LoopType )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STRINGNOQUOTES, "STRINGNOQUOTES"), root_1);

                    	    adaptor.AddChild(root_1, stream_LoopType.NextNode());

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:392:1: variableUnaryChange : Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) ;
    public SGLParser.variableUnaryChange_return variableUnaryChange() // throws RecognitionException [1]
    {   
        SGLParser.variableUnaryChange_return retval = new SGLParser.variableUnaryChange_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken Identifier160 = null;
        IToken string_literal161 = null;
        IToken string_literal162 = null;

        object Identifier160_tree=null;
        object string_literal161_tree=null;
        object string_literal162_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:393:2: ( Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:393:4: Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            {
            	Identifier160=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variableUnaryChange1752);  
            	stream_Identifier.Add(Identifier160);

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:393:15: ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == 83) )
            	{
            	    alt37 = 1;
            	}
            	else if ( (LA37_0 == 84) )
            	{
            	    alt37 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d37s0 =
            	        new NoViableAltException("", 37, 0, input);

            	    throw nvae_d37s0;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:393:16: '++'
            	        {
            	        	string_literal161=(IToken)Match(input,83,FOLLOW_83_in_variableUnaryChange1755);  
            	        	stream_83.Add(string_literal161);



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
            	        	// 393:21: -> ^( VARINC Identifier )
            	        	{
            	        	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:393:24: ^( VARINC Identifier )
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
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:394:4: '--'
            	        {
            	        	string_literal162=(IToken)Match(input,84,FOLLOW_84_in_variableUnaryChange1768);  
            	        	stream_84.Add(string_literal162);



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
            	        	// 394:9: -> ^( VARDEC Identifier )
            	        	{
            	        	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:394:12: ^( VARDEC Identifier )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:402:1: arguments : expressionList ;
    public SGLParser.arguments_return arguments() // throws RecognitionException [1]
    {   
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        SGLParser.expressionList_return expressionList163 = default(SGLParser.expressionList_return);



        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:403:5: ( expressionList )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:403:10: expressionList
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expressionList_in_arguments1811);
            	expressionList163 = expressionList();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expressionList163.Tree);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:406:1: expressionList : expression ( ',' expression )* ;
    public SGLParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal165 = null;
        SGLParser.expression_return expression164 = default(SGLParser.expression_return);

        SGLParser.expression_return expression166 = default(SGLParser.expression_return);


        object char_literal165_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:407:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:407:9: expression ( ',' expression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_expression_in_expressionList1834);
            	expression164 = expression();
            	state.followingStackPointer--;

            	adaptor.AddChild(root_0, expression164.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:407:20: ( ',' expression )*
            	do 
            	{
            	    int alt38 = 2;
            	    int LA38_0 = input.LA(1);

            	    if ( (LA38_0 == 57) )
            	    {
            	        alt38 = 1;
            	    }


            	    switch (alt38) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:407:21: ',' expression
            			    {
            			    	char_literal165=(IToken)Match(input,57,FOLLOW_57_in_expressionList1837); 
            			    	PushFollow(FOLLOW_expression_in_expressionList1840);
            			    	expression166 = expression();
            			    	state.followingStackPointer--;

            			    	adaptor.AddChild(root_0, expression166.Tree);

            			    }
            			    break;

            			default:
            			    goto loop38;
            	    }
            	} while (true);

            	loop38:
            		;	// Stops C# compiler whining that label 'loop38' has no statements


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:410:1: paramList : variableType variableName ( ',' variableType variableName )* -> ^( PARAM_TYPE_LIST ( variableType )+ ) ^( PARAM_NAME_LIST ( variableName )+ ) ;
    public SGLParser.paramList_return paramList() // throws RecognitionException [1]
    {   
        SGLParser.paramList_return retval = new SGLParser.paramList_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken char_literal169 = null;
        SGLParser.variableType_return variableType167 = default(SGLParser.variableType_return);

        SGLParser.variableName_return variableName168 = default(SGLParser.variableName_return);

        SGLParser.variableType_return variableType170 = default(SGLParser.variableType_return);

        SGLParser.variableName_return variableName171 = default(SGLParser.variableName_return);


        object char_literal169_tree=null;
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleSubtreeStream stream_variableType = new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableName = new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:411:3: ( variableType variableName ( ',' variableType variableName )* -> ^( PARAM_TYPE_LIST ( variableType )+ ) ^( PARAM_NAME_LIST ( variableName )+ ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:411:6: variableType variableName ( ',' variableType variableName )*
            {
            	PushFollow(FOLLOW_variableType_in_paramList1858);
            	variableType167 = variableType();
            	state.followingStackPointer--;

            	stream_variableType.Add(variableType167.Tree);
            	PushFollow(FOLLOW_variableName_in_paramList1860);
            	variableName168 = variableName();
            	state.followingStackPointer--;

            	stream_variableName.Add(variableName168.Tree);
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:411:32: ( ',' variableType variableName )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( (LA39_0 == 57) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:411:33: ',' variableType variableName
            			    {
            			    	char_literal169=(IToken)Match(input,57,FOLLOW_57_in_paramList1863);  
            			    	stream_57.Add(char_literal169);

            			    	PushFollow(FOLLOW_variableType_in_paramList1865);
            			    	variableType170 = variableType();
            			    	state.followingStackPointer--;

            			    	stream_variableType.Add(variableType170.Tree);
            			    	PushFollow(FOLLOW_variableName_in_paramList1867);
            			    	variableName171 = variableName();
            			    	state.followingStackPointer--;

            			    	stream_variableName.Add(variableName171.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements



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
            	// 411:65: -> ^( PARAM_TYPE_LIST ( variableType )+ ) ^( PARAM_NAME_LIST ( variableName )+ )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:411:68: ^( PARAM_TYPE_LIST ( variableType )+ )
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
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:411:101: ^( PARAM_NAME_LIST ( variableName )+ )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:414:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public SGLParser.literal_return literal() // throws RecognitionException [1]
    {   
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken set172 = null;

        object set172_tree=null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:415:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            	root_0 = (object)adaptor.GetNilNode();

            	set172 = (IToken)input.LT(1);
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == StringAtom || input.LA(1) == 86 ) 
            	{
            	    input.Consume();
            	    adaptor.AddChild(root_0, (object)adaptor.Create(set172));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:423:1: stringQuote : StringAtom -> ^( STRING StringAtom ) ;
    public SGLParser.stringQuote_return stringQuote() // throws RecognitionException [1]
    {   
        SGLParser.stringQuote_return retval = new SGLParser.stringQuote_return();
        retval.Start = input.LT(1);

        object root_0 = null;

        IToken StringAtom173 = null;

        object StringAtom173_tree=null;
        RewriteRuleTokenStream stream_StringAtom = new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:424:2: ( StringAtom -> ^( STRING StringAtom ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:424:6: StringAtom
            {
            	StringAtom173=(IToken)Match(input,StringAtom,FOLLOW_StringAtom_in_stringQuote1978);  
            	stream_StringAtom.Add(StringAtom173);



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
            	// 424:17: -> ^( STRING StringAtom )
            	{
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:424:20: ^( STRING StringAtom )
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


   	protected DFA36 dfa36;
	private void InitializeCyclicDFAs()
	{
    	this.dfa36 = new DFA36(this);
	}

    const string DFA36_eotS =
        "\x10\uffff";
    const string DFA36_eofS =
        "\x10\uffff";
    const string DFA36_minS =
        "\x01\x1b\x04\uffff\x01\x24\x01\x1b\x09\uffff";
    const string DFA36_maxS =
        "\x01\x55\x04\uffff\x01\x25\x01\x52\x09\uffff";
    const string DFA36_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x02\uffff\x01\x0a\x01"+
        "\x0b\x01\x0c\x01\x0d\x01\x05\x01\x06\x01\x09\x01\x07\x01\x08";
    const string DFA36_specialS =
        "\x10\uffff}>";
    static readonly string[] DFA36_transitionS = {
            "\x01\x06\x05\uffff\x01\x02\x01\x03\x01\x04\x02\uffff\x01\x08"+
            "\x01\x09\x01\x0a\x01\x07\x0b\uffff\x01\x01\x1f\uffff\x01\x05",
            "",
            "",
            "",
            "",
            "\x01\x0b\x01\x0c",
            "\x06\x0f\x11\uffff\x01\x0f\x02\uffff\x01\x0d\x01\x0f\x01\uffff"+
            "\x03\x0f\x01\uffff\x01\x0e\x05\uffff\x11\x0f",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA36_eot = DFA.UnpackEncodedString(DFA36_eotS);
    static readonly short[] DFA36_eof = DFA.UnpackEncodedString(DFA36_eofS);
    static readonly char[] DFA36_min = DFA.UnpackEncodedStringToUnsignedChars(DFA36_minS);
    static readonly char[] DFA36_max = DFA.UnpackEncodedStringToUnsignedChars(DFA36_maxS);
    static readonly short[] DFA36_accept = DFA.UnpackEncodedString(DFA36_acceptS);
    static readonly short[] DFA36_special = DFA.UnpackEncodedString(DFA36_specialS);
    static readonly short[][] DFA36_transition = DFA.UnpackEncodedStringArray(DFA36_transitionS);

    protected class DFA36 : DFA
    {
        public DFA36(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 36;
            this.eot = DFA36_eot;
            this.eof = DFA36_eof;
            this.min = DFA36_min;
            this.max = DFA36_max;
            this.accept = DFA36_accept;
            this.special = DFA36_special;
            this.transition = DFA36_transition;

        }

        override public string Description
        {
            get { return "375:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' Sprite '(' ( arguments )? ')' -> ^( Sprite ( arguments )? ) | 'new' Animation '(' ( arguments )? ')' -> ^( Animation ( arguments )? ) | objectMethod | Identifier | methodCall | stringQuote | Layer -> ^( STRINGNOQUOTES Layer ) | Origin -> ^( STRINGNOQUOTES Origin ) | LoopType -> ^( STRINGNOQUOTES LoopType ) );"; }
        }

    }

 

    public static readonly BitSet FOLLOW_mainBlock_in_compilationUnit193 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mainStatement_in_mainBlock206 = new BitSet(new ulong[]{0xE4100001F8000002UL,0x000000000000000EUL});
    public static readonly BitSet FOLLOW_methodDef_in_mainBlock210 = new BitSet(new ulong[]{0xE4100001F8000002UL,0x000000000000000EUL});
    public static readonly BitSet FOLLOW_statement_in_block258 = new BitSet(new ulong[]{0xE4000001F8000002UL,0x000000000000000EUL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_singleBlock286 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_singleBlock_in_commonBlock312 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_commonBlock317 = new BitSet(new ulong[]{0xE4080001F8000000UL,0x000000000000000EUL});
    public static readonly BitSet FOLLOW_block_in_commonBlock320 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_commonBlock322 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_methodDef352 = new BitSet(new ulong[]{0x00800001F0000000UL});
    public static readonly BitSet FOLLOW_methodType_in_methodDef354 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodDef356 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_methodDef358 = new BitSet(new ulong[]{0x00400001F0000000UL});
    public static readonly BitSet FOLLOW_paramList_in_methodDef360 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_methodDef363 = new BitSet(new ulong[]{0x04040001F8000000UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_commonBlock_in_methodDef365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_methodType385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_methodType390 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_mainStatement414 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_semicolonStatement427 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_semicolonStatement433 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_variableUnaryChange_in_semicolonStatement439 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_methodCall_in_semicolonStatement445 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_objectMethod_in_semicolonStatement450 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_breakStat_in_semicolonStatement455 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_returnStat_in_semicolonStatement460 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_semicolonStatement465 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableDeclarationList_in_oneLineStatement478 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableAssignment_in_oneLineStatement483 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableUnaryChange_in_oneLineStatement488 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_statement504 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement509 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atStatement_in_statement514 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement519 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forLoop_in_statement524 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclarationList540 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList542 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_57_in_variableDeclarationList545 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList547 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_58_in_variableDeclarationList565 = new BitSet(new ulong[]{0x00000001F0000000UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclarationList567 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList569 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_57_in_variableDeclarationList572 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList574 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDecAssignment598 = new BitSet(new ulong[]{0x0800000000000002UL});
    public static readonly BitSet FOLLOW_59_in_variableDecAssignment601 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_expression_in_variableDecAssignment603 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_variableAssignment624 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_variableAssignment626 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_expression_in_variableAssignment628 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName659 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_variableType0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variableName_in_objectMethod703 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_objectMethod705 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethod707 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_objectMethod709 = new BitSet(new ulong[]{0x006003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_arguments_in_objectMethod711 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_objectMethod714 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_whileLoop738 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop740 = new BitSet(new ulong[]{0x04040001F8000000UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_commonBlock_in_whileLoop742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_forLoop764 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_forLoop766 = new BitSet(new ulong[]{0x05000001F8000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop770 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_forLoop773 = new BitSet(new ulong[]{0x012003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop777 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_forLoop780 = new BitSet(new ulong[]{0x04400001F8000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop784 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_forLoop787 = new BitSet(new ulong[]{0x04040001F8000000UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_commonBlock_in_forLoop789 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStat_in_ifStatement834 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_elseIfStat_in_ifStatement836 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_elseStat_in_ifStatement839 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_ifStat864 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_expression_in_ifStat866 = new BitSet(new ulong[]{0x04040001F8000000UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_commonBlock_in_ifStat868 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_elseIfStat889 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_elseIfStat891 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_expression_in_elseIfStat893 = new BitSet(new ulong[]{0x04040001F8000000UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseIfStat895 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_64_in_elseStat917 = new BitSet(new ulong[]{0x04040001F8000000UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseStat919 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_atStatement944 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_expression_in_atStatement946 = new BitSet(new ulong[]{0x04040001F8000000UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_commonBlock_in_atStatement948 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_66_in_breakStat970 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_67_in_returnStat985 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_expression_in_returnStat987 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodCall1006 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_methodCall1008 = new BitSet(new ulong[]{0x006003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_expressionList_in_methodCall1010 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_methodCall1013 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression1070 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression1111 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_68_in_conditionalExpression1115 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression1118 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_69_in_conditionalExpression1120 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression1123 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1166 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_70_in_conditionalOrExpression1170 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1173 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000040UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1204 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_71_in_conditionalAndExpression1208 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1211 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1238 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000300UL});
    public static readonly BitSet FOLLOW_72_in_equalityExpression1243 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_73_in_equalityExpression1248 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1252 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000300UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1283 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000003C00UL});
    public static readonly BitSet FOLLOW_74_in_relationalExpression1287 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_75_in_relationalExpression1290 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_76_in_relationalExpression1293 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_77_in_relationalExpression1296 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1300 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000003C00UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1338 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_78_in_additiveExpression1342 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_79_in_additiveExpression1345 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1349 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_negativeExpression_in_multiplicativeExpression1383 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000070000UL});
    public static readonly BitSet FOLLOW_80_in_multiplicativeExpression1391 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_81_in_multiplicativeExpression1394 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_82_in_multiplicativeExpression1397 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_negativeExpression_in_multiplicativeExpression1401 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000070000UL});
    public static readonly BitSet FOLLOW_83_in_unaryExpression1424 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000388000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_unaryExpression1436 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000388000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression1438 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1448 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_unaryExpressionNotPlusMinus1469 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_83_in_unaryExpressionNotPlusMinus1472 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_unaryExpressionNotPlusMinus1485 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_castExpression1522 = new BitSet(new ulong[]{0x00000001F0000000UL});
    public static readonly BitSet FOLLOW_variableType_in_castExpression1524 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_castExpression1526 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000388000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1528 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negativeExpression1546 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_negativeExpression1551 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negativeExpression1553 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_negativeExpression1566 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_53_in_mathAtom1580 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_mathAtom1583 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_mathAtom1585 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom1596 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_mathAtom1604 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_mathAtom1614 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_mathAtom1625 = new BitSet(new ulong[]{0x0000001000000000UL});
    public static readonly BitSet FOLLOW_Sprite_in_mathAtom1627 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_mathAtom1629 = new BitSet(new ulong[]{0x006003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_arguments_in_mathAtom1631 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_mathAtom1634 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_mathAtom1653 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_Animation_in_mathAtom1655 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_mathAtom1657 = new BitSet(new ulong[]{0x006003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_arguments_in_mathAtom1659 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_mathAtom1662 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethod_in_mathAtom1678 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_mathAtom1683 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_mathAtom1688 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stringQuote_in_mathAtom1693 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Layer_in_mathAtom1698 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Origin_in_mathAtom1711 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LoopType_in_mathAtom1724 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableUnaryChange1752 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_83_in_variableUnaryChange1755 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_variableUnaryChange1768 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1811 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1834 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_57_in_expressionList1837 = new BitSet(new ulong[]{0x002003CE08000000UL,0x0000000000208000UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1840 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_variableType_in_paramList1858 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_variableName_in_paramList1860 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_57_in_paramList1863 = new BitSet(new ulong[]{0x00000001F0000000UL});
    public static readonly BitSet FOLLOW_variableType_in_paramList1865 = new BitSet(new ulong[]{0x0000000008000000UL});
    public static readonly BitSet FOLLOW_variableName_in_paramList1867 = new BitSet(new ulong[]{0x0200000000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringAtom_in_stringQuote1978 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}