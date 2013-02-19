// $ANTLR 3.2 Sep 23, 2009 12:02:23 E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g 2013-02-20 00:37:16

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


// -------------------------------------------------------------------------------------------------
//                This is a generated file, please don't change anything in here!
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using SGL;
//using SGL.Methods;
using SGL.Elements;
using SGL.Library.Functions;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace  SGL.Antlr 
{
internal partial class SGLParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"BLOCK", 
		"DEF", 
		"GLOBALDEF", 
		"ASSIGN", 
		"STRING", 
		"INT_NEGATE", 
		"BOOL_NEGATE", 
		"VARINC", 
		"VARDEC", 
		"VARIABLE", 
		"INDEXES", 
		"LOOKUP", 
		"LIST", 
		"EXP_LIST", 
		"VAR_LIST", 
		"FUNC_CALL", 
		"OBJ_FUNC_CALL", 
		"BREAK", 
		"RETURN", 
		"AT", 
		"IF", 
		"EXP", 
		"FORDEC", 
		"FORCOND", 
		"FORITER", 
		"GLOBAL_ASSIGN", 
		"CLASS", 
		"Identifier", 
		"StringAtom", 
		"IntAtom", 
		"FloatAtom", 
		"BooleanAtom", 
		"LayerAtom", 
		"OriginAtom", 
		"LoopTypeAtom", 
		"LoopTriggerAtom", 
		"ColorAtom", 
		"Null", 
		"VarStartInit", 
		"Array", 
		"HexDigit", 
		"EscapeSequence", 
		"UTF8Letter", 
		"UTF8Digit", 
		"Comment", 
		"WhiteSpace", 
		"'{'", 
		"'}'", 
		"';'", 
		"','", 
		"'='", 
		"'global'", 
		"'['", 
		"']'", 
		"'.'", 
		"'('", 
		"')'", 
		"'function'", 
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
		"'^'", 
		"'!'", 
		"'++'", 
		"'--'", 
		"'new'", 
		"'break'", 
		"'return'", 
		"'while'", 
		"'for'", 
		"'if'", 
		"'else'", 
		"'at'"
    };

    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int CLASS = 30;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int DEF = 5;
    public const int T__65 = 65;
    public const int VAR_LIST = 18;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int Array = 43;
    public const int IntAtom = 33;
    public const int LoopTypeAtom = 38;
    public const int EXP_LIST = 17;
    public const int UTF8Letter = 46;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int HexDigit = 44;
    public const int BREAK = 21;
    public const int Identifier = 31;
    public const int IF = 24;
    public const int FUNC_CALL = 19;
    public const int AT = 23;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int Comment = 48;
    public const int EXP = 25;
    public const int OBJ_FUNC_CALL = 20;
    public const int FORITER = 28;
    public const int T__59 = 59;
    public const int INT_NEGATE = 9;
    public const int UTF8Digit = 47;
    public const int RETURN = 22;
    public const int WhiteSpace = 49;
    public const int T__50 = 50;
    public const int VARDEC = 12;
    public const int Null = 41;
    public const int OriginAtom = 37;
    public const int LayerAtom = 36;
    public const int GLOBAL_ASSIGN = 29;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int FORDEC = 26;
    public const int StringAtom = 32;
    public const int INDEXES = 14;
    public const int LoopTriggerAtom = 39;
    public const int ColorAtom = 40;
    public const int T__85 = 85;
    public const int LIST = 16;
    public const int T__84 = 84;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int T__88 = 88;
    public const int BooleanAtom = 35;
    public const int BOOL_NEGATE = 10;
    public const int LOOKUP = 15;
    public const int FORCOND = 27;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int VARIABLE = 13;
    public const int T__70 = 70;
    public const int BLOCK = 4;
    public const int VarStartInit = 42;
    public const int ASSIGN = 7;
    public const int GLOBALDEF = 6;
    public const int FloatAtom = 34;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int VARINC = 11;
    public const int T__74 = 74;
    public const int EscapeSequence = 45;
    public const int T__73 = 73;
    public const int T__79 = 79;
    public const int STRING = 8;
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
            this.state.ruleMemo = new Hashtable[116+1];
             
             
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
		get { return "E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g"; }
    }



            //public Dictionary<String,Method> methods = new Dictionary<String,Method>();
            //public Dictionary<String,ObjectMethod> objectMethods = new Dictionary<String,ObjectMethod>();

        	private void DefineFunction(String name, Object paramList, Object block, int defLine) {
                    // 'paramList' is possibly null!  Create an empty tree in that case.  
                    CommonTree paramListTree = paramList == null ? new CommonTree() : (CommonTree)paramList;
    				List<String> functionParameters = ParametersToList(paramListTree);

                    // 'block' is never null 
                    CommonTree blockTree = (CommonTree)block;
                    Console.WriteLine("HIER: " + blockTree.ToStringTree());
                    //CommonTreeNodeStream functionNodes = new CommonTreeNodeStream(blockTree);

                    // The method name with the exact same type of parameters after it, is the unique key 
                    //String key = id + " " + idListTree.ChildCount;

                    Console.WriteLine("function found: " + name);
                    
                    //idListTree.GetChild(1).ChildCount;
                    
                    // (String, List<String>, CommonTreeNodeStream)
                    GlobalMemory.Instance.RegisterFunction(name, new UserFunction(name, functionParameters, blockTree, defLine));
                    //methods.Add(id, new Method(id, idListTree, blockTree));
            }
            /*
            private void DefineObjectMethod(String id, Object idList, Object block) {
                    // 'idList' is possibly null!  Create an empty tree in that case.  
                    CommonTree idListTree = idList == null ? new CommonTree() : (CommonTree)idList;

                    // 'block' is never null 
                    CommonTree blockTree = (CommonTree)block;

                    // The method name with the exact same type of parameters after it, is the unique key 
                    //String key = id + " " + idListTree.ChildCount;

                    Console.WriteLine("method found: " + id);
                    
                    //idListTree.GetChild(1).ChildCount;
                    objectMethods.Add(id, new ObjectMethod(id, idListTree, blockTree));
            }*/
            
            private List<String> ParametersToList(CommonTree tree)
            {
                List<String> ids = new List<String>();
                // convert the tree to a List of Strings
                //Console.WriteLine("1: " + childNum);
                if (tree.ChildCount > 0)
                {
                    //Console.WriteLine("2: " + childNum);
                    for (int i = 0; i < tree.ChildCount; i++)
                    {
                        //Console.WriteLine("3: " + childNum);
                        CommonTree child = (CommonTree)tree.GetChild(i);
                        ids.Add(child.Text);
                        //Console.WriteLine("add to List (" + childNum + "): " + child.Text);
                    }
                    //Console.WriteLine("4: " + childNum);
                }
                return ids;
            }
            
    		public override String GetErrorMessage(RecognitionException e, String[] tokenNames) {
       			String message = base.GetErrorMessage(e, tokenNames);
       			throw new CompilerException(e, message); 
       		}



    public class main_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "main"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:153:1: main : mainBlock ;
    public SGLParser.main_return main() // throws RecognitionException [1]
    {   
        SGLParser.main_return retval = new SGLParser.main_return();
        retval.Start = input.LT(1);
        int main_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.mainBlock_return mainBlock1 = default(SGLParser.mainBlock_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 1) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:154:5: ( mainBlock )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:154:7: mainBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mainBlock_in_main242);
            	mainBlock1 = mainBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mainBlock1.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 1, main_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "main"

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:161:1: mainBlock : ( mainStatement | functionDef )* -> ^( BLOCK ( mainStatement )* ) ;
    public SGLParser.mainBlock_return mainBlock() // throws RecognitionException [1]
    {   
        SGLParser.mainBlock_return retval = new SGLParser.mainBlock_return();
        retval.Start = input.LT(1);
        int mainBlock_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.mainStatement_return mainStatement2 = default(SGLParser.mainStatement_return);

        SGLParser.functionDef_return functionDef3 = default(SGLParser.functionDef_return);


        RewriteRuleSubtreeStream stream_functionDef = new RewriteRuleSubtreeStream(adaptor,"rule functionDef");
        RewriteRuleSubtreeStream stream_mainStatement = new RewriteRuleSubtreeStream(adaptor,"rule mainStatement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:163:2: ( ( mainStatement | functionDef )* -> ^( BLOCK ( mainStatement )* ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:163:4: ( mainStatement | functionDef )*
            {
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:163:4: ( mainStatement | functionDef )*
            	do 
            	{
            	    int alt1 = 3;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == Identifier || LA1_0 == VarStartInit || LA1_0 == 55 || (LA1_0 >= 82 && LA1_0 <= 86) || LA1_0 == 88) )
            	    {
            	        alt1 = 1;
            	    }
            	    else if ( (LA1_0 == 61) )
            	    {
            	        alt1 = 2;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:163:5: mainStatement
            			    {
            			    	PushFollow(FOLLOW_mainStatement_in_mainBlock262);
            			    	mainStatement2 = mainStatement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_mainStatement.Add(mainStatement2.Tree);

            			    }
            			    break;
            			case 2 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:163:21: functionDef
            			    {
            			    	PushFollow(FOLLOW_functionDef_in_mainBlock266);
            			    	functionDef3 = functionDef();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_functionDef.Add(functionDef3.Tree);

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
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 164:8: -> ^( BLOCK ( mainStatement )* )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:164:11: ^( BLOCK ( mainStatement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:164:20: ( mainStatement )*
            	    while ( stream_mainStatement.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_mainStatement.NextTree());

            	    }
            	    stream_mainStatement.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 2, mainBlock_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:168:1: block : ( statement )* -> ^( BLOCK ( statement )* ) ;
    public SGLParser.block_return block() // throws RecognitionException [1]
    {   
        SGLParser.block_return retval = new SGLParser.block_return();
        retval.Start = input.LT(1);
        int block_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.statement_return statement4 = default(SGLParser.statement_return);


        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:169:2: ( ( statement )* -> ^( BLOCK ( statement )* ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:169:4: ( statement )*
            {
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:169:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == Identifier || LA2_0 == VarStartInit || (LA2_0 >= 82 && LA2_0 <= 86) || LA2_0 == 88) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block303);
            			    	statement4 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(statement4.Tree);

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
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 170:3: -> ^( BLOCK ( statement )* )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:170:6: ^( BLOCK ( statement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:170:14: ( statement )*
            	    while ( stream_statement.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_statement.NextTree());

            	    }
            	    stream_statement.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 3, block_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:174:1: singleBlock : semicolonStatement -> ^( BLOCK semicolonStatement ) ;
    public SGLParser.singleBlock_return singleBlock() // throws RecognitionException [1]
    {   
        SGLParser.singleBlock_return retval = new SGLParser.singleBlock_return();
        retval.Start = input.LT(1);
        int singleBlock_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement5 = default(SGLParser.semicolonStatement_return);


        RewriteRuleSubtreeStream stream_semicolonStatement = new RewriteRuleSubtreeStream(adaptor,"rule semicolonStatement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:175:2: ( semicolonStatement -> ^( BLOCK semicolonStatement ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:175:4: semicolonStatement
            {
            	PushFollow(FOLLOW_semicolonStatement_in_singleBlock328);
            	semicolonStatement5 = semicolonStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolonStatement.Add(semicolonStatement5.Tree);


            	// AST REWRITE
            	// elements:          semicolonStatement
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 176:3: -> ^( BLOCK semicolonStatement )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:176:6: ^( BLOCK semicolonStatement )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    adaptor.AddChild(root_1, stream_semicolonStatement.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 4, singleBlock_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:180:1: commonBlock : ( singleBlock | '{' block '}' );
    public SGLParser.commonBlock_return commonBlock() // throws RecognitionException [1]
    {   
        SGLParser.commonBlock_return retval = new SGLParser.commonBlock_return();
        retval.Start = input.LT(1);
        int commonBlock_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal7 = null;
        IToken char_literal9 = null;
        SGLParser.singleBlock_return singleBlock6 = default(SGLParser.singleBlock_return);

        SGLParser.block_return block8 = default(SGLParser.block_return);


        object char_literal7_tree=null;
        object char_literal9_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:181:2: ( singleBlock | '{' block '}' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == Identifier || LA3_0 == VarStartInit || (LA3_0 >= 82 && LA3_0 <= 83)) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == 50) )
            {
                alt3 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d3s0 =
                    new NoViableAltException("", 3, 0, input);

                throw nvae_d3s0;
            }
            switch (alt3) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:181:4: singleBlock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_singleBlock_in_commonBlock351);
                    	singleBlock6 = singleBlock();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, singleBlock6.Tree);

                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:182:4: '{' block '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal7=(IToken)Match(input,50,FOLLOW_50_in_commonBlock356); if (state.failed) return retval;
                    	PushFollow(FOLLOW_block_in_commonBlock359);
                    	block8 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block8.Tree);
                    	char_literal9=(IToken)Match(input,51,FOLLOW_51_in_commonBlock361); if (state.failed) return retval;

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 5, commonBlock_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "commonBlock"

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:187:1: mainStatement : ( statement | globalVarDefList ';' );
    public SGLParser.mainStatement_return mainStatement() // throws RecognitionException [1]
    {   
        SGLParser.mainStatement_return retval = new SGLParser.mainStatement_return();
        retval.Start = input.LT(1);
        int mainStatement_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal12 = null;
        SGLParser.statement_return statement10 = default(SGLParser.statement_return);

        SGLParser.globalVarDefList_return globalVarDefList11 = default(SGLParser.globalVarDefList_return);


        object char_literal12_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:188:2: ( statement | globalVarDefList ';' )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == Identifier || LA4_0 == VarStartInit || (LA4_0 >= 82 && LA4_0 <= 86) || LA4_0 == 88) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == 55) )
            {
                alt4 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:188:4: statement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_mainStatement378);
                    	statement10 = statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement10.Tree);

                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:189:4: globalVarDefList ';'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_globalVarDefList_in_mainStatement383);
                    	globalVarDefList11 = globalVarDefList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, globalVarDefList11.Tree);
                    	char_literal12=(IToken)Match(input,52,FOLLOW_52_in_mainStatement385); if (state.failed) return retval;

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 6, mainStatement_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:192:1: statement : ( semicolonStatement | ifStatement | atStatement | whileLoop | forLoop );
    public SGLParser.statement_return statement() // throws RecognitionException [1]
    {   
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.Start = input.LT(1);
        int statement_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement13 = default(SGLParser.semicolonStatement_return);

        SGLParser.ifStatement_return ifStatement14 = default(SGLParser.ifStatement_return);

        SGLParser.atStatement_return atStatement15 = default(SGLParser.atStatement_return);

        SGLParser.whileLoop_return whileLoop16 = default(SGLParser.whileLoop_return);

        SGLParser.forLoop_return forLoop17 = default(SGLParser.forLoop_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:193:2: ( semicolonStatement | ifStatement | atStatement | whileLoop | forLoop )
            int alt5 = 5;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            case VarStartInit:
            case 82:
            case 83:
            	{
                alt5 = 1;
                }
                break;
            case 86:
            	{
                alt5 = 2;
                }
                break;
            case 88:
            	{
                alt5 = 3;
                }
                break;
            case 84:
            	{
                alt5 = 4;
                }
                break;
            case 85:
            	{
                alt5 = 5;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d5s0 =
            	        new NoViableAltException("", 5, 0, input);

            	    throw nvae_d5s0;
            }

            switch (alt5) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:193:4: semicolonStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_semicolonStatement_in_statement400);
                    	semicolonStatement13 = semicolonStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, semicolonStatement13.Tree);

                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:194:4: ifStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statement405);
                    	ifStatement14 = ifStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifStatement14.Tree);

                    }
                    break;
                case 3 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:195:4: atStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_atStatement_in_statement410);
                    	atStatement15 = atStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, atStatement15.Tree);

                    }
                    break;
                case 4 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:196:4: whileLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileLoop_in_statement415);
                    	whileLoop16 = whileLoop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileLoop16.Tree);

                    }
                    break;
                case 5 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:197:4: forLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forLoop_in_statement420);
                    	forLoop17 = forLoop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forLoop17.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 7, statement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "statement"

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:200:1: semicolonStatement : ( unaryExpression | objectMethodCall | methodCall | varDefList | assignment | breakStat | returnStat ) ';' ;
    public SGLParser.semicolonStatement_return semicolonStatement() // throws RecognitionException [1]
    {   
        SGLParser.semicolonStatement_return retval = new SGLParser.semicolonStatement_return();
        retval.Start = input.LT(1);
        int semicolonStatement_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal25 = null;
        SGLParser.unaryExpression_return unaryExpression18 = default(SGLParser.unaryExpression_return);

        SGLParser.objectMethodCall_return objectMethodCall19 = default(SGLParser.objectMethodCall_return);

        SGLParser.methodCall_return methodCall20 = default(SGLParser.methodCall_return);

        SGLParser.varDefList_return varDefList21 = default(SGLParser.varDefList_return);

        SGLParser.assignment_return assignment22 = default(SGLParser.assignment_return);

        SGLParser.breakStat_return breakStat23 = default(SGLParser.breakStat_return);

        SGLParser.returnStat_return returnStat24 = default(SGLParser.returnStat_return);


        object char_literal25_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:201:2: ( ( unaryExpression | objectMethodCall | methodCall | varDefList | assignment | breakStat | returnStat ) ';' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:201:4: ( unaryExpression | objectMethodCall | methodCall | varDefList | assignment | breakStat | returnStat ) ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:201:4: ( unaryExpression | objectMethodCall | methodCall | varDefList | assignment | breakStat | returnStat )
            	int alt6 = 7;
            	switch ( input.LA(1) ) 
            	{
            	case Identifier:
            		{
            	    int LA6_1 = input.LA(2);

            	    if ( (synpred10_SGL()) )
            	    {
            	        alt6 = 1;
            	    }
            	    else if ( (synpred11_SGL()) )
            	    {
            	        alt6 = 2;
            	    }
            	    else if ( (synpred12_SGL()) )
            	    {
            	        alt6 = 3;
            	    }
            	    else if ( (synpred14_SGL()) )
            	    {
            	        alt6 = 5;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d6s1 =
            	            new NoViableAltException("", 6, 1, input);

            	        throw nvae_d6s1;
            	    }
            	    }
            	    break;
            	case VarStartInit:
            		{
            	    alt6 = 4;
            	    }
            	    break;
            	case 82:
            		{
            	    alt6 = 6;
            	    }
            	    break;
            	case 83:
            		{
            	    alt6 = 7;
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    NoViableAltException nvae_d6s0 =
            		        new NoViableAltException("", 6, 0, input);

            		    throw nvae_d6s0;
            	}

            	switch (alt6) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:201:5: unaryExpression
            	        {
            	        	PushFollow(FOLLOW_unaryExpression_in_semicolonStatement433);
            	        	unaryExpression18 = unaryExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression18.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:202:4: objectMethodCall
            	        {
            	        	PushFollow(FOLLOW_objectMethodCall_in_semicolonStatement439);
            	        	objectMethodCall19 = objectMethodCall();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectMethodCall19.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:203:4: methodCall
            	        {
            	        	PushFollow(FOLLOW_methodCall_in_semicolonStatement444);
            	        	methodCall20 = methodCall();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodCall20.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:204:4: varDefList
            	        {
            	        	PushFollow(FOLLOW_varDefList_in_semicolonStatement450);
            	        	varDefList21 = varDefList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDefList21.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:205:4: assignment
            	        {
            	        	PushFollow(FOLLOW_assignment_in_semicolonStatement456);
            	        	assignment22 = assignment();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment22.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:206:4: breakStat
            	        {
            	        	PushFollow(FOLLOW_breakStat_in_semicolonStatement463);
            	        	breakStat23 = breakStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, breakStat23.Tree);

            	        }
            	        break;
            	    case 7 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:207:4: returnStat
            	        {
            	        	PushFollow(FOLLOW_returnStat_in_semicolonStatement468);
            	        	returnStat24 = returnStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnStat24.Tree);

            	        }
            	        break;

            	}

            	char_literal25=(IToken)Match(input,52,FOLLOW_52_in_semicolonStatement473); if (state.failed) return retval;

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 8, semicolonStatement_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:211:1: oneLineStatement : ( varDefList | unaryExpression );
    public SGLParser.oneLineStatement_return oneLineStatement() // throws RecognitionException [1]
    {   
        SGLParser.oneLineStatement_return retval = new SGLParser.oneLineStatement_return();
        retval.Start = input.LT(1);
        int oneLineStatement_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.varDefList_return varDefList26 = default(SGLParser.varDefList_return);

        SGLParser.unaryExpression_return unaryExpression27 = default(SGLParser.unaryExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:212:2: ( varDefList | unaryExpression )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == VarStartInit) )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == Identifier) )
            {
                alt7 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:212:4: varDefList
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_varDefList_in_oneLineStatement486);
                    	varDefList26 = varDefList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDefList26.Tree);

                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:213:4: unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpression_in_oneLineStatement491);
                    	unaryExpression27 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression27.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 9, oneLineStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "oneLineStatement"

    public class varDefList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "varDefList"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:216:1: varDefList : ( 'var' varDef ) ( ',' varDef )* ;
    public SGLParser.varDefList_return varDefList() // throws RecognitionException [1]
    {   
        SGLParser.varDefList_return retval = new SGLParser.varDefList_return();
        retval.Start = input.LT(1);
        int varDefList_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal28 = null;
        IToken char_literal30 = null;
        SGLParser.varDef_return varDef29 = default(SGLParser.varDef_return);

        SGLParser.varDef_return varDef31 = default(SGLParser.varDef_return);


        object string_literal28_tree=null;
        object char_literal30_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:217:2: ( ( 'var' varDef ) ( ',' varDef )* )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:217:4: ( 'var' varDef ) ( ',' varDef )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:217:4: ( 'var' varDef )
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:217:5: 'var' varDef
            	{
            		string_literal28=(IToken)Match(input,VarStartInit,FOLLOW_VarStartInit_in_varDefList507); if (state.failed) return retval;
            		PushFollow(FOLLOW_varDef_in_varDefList510);
            		varDef29 = varDef();
            		state.followingStackPointer--;
            		if (state.failed) return retval;
            		if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef29.Tree);

            	}

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:218:3: ( ',' varDef )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == 53) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:218:4: ',' varDef
            			    {
            			    	char_literal30=(IToken)Match(input,53,FOLLOW_53_in_varDefList517); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_varDef_in_varDefList520);
            			    	varDef31 = varDef();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, varDef31.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 10, varDefList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "varDefList"

    public class varDef_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "varDef"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:222:1: varDef : variable ( '=' expression )* -> ^( DEF variable ) ( ^( ASSIGN variable expression ) )* ;
    public SGLParser.varDef_return varDef() // throws RecognitionException [1]
    {   
        SGLParser.varDef_return retval = new SGLParser.varDef_return();
        retval.Start = input.LT(1);
        int varDef_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal33 = null;
        SGLParser.variable_return variable32 = default(SGLParser.variable_return);

        SGLParser.expression_return expression34 = default(SGLParser.expression_return);


        object char_literal33_tree=null;
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:223:2: ( variable ( '=' expression )* -> ^( DEF variable ) ( ^( ASSIGN variable expression ) )* )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:223:4: variable ( '=' expression )*
            {
            	PushFollow(FOLLOW_variable_in_varDef536);
            	variable32 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable32.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:223:13: ( '=' expression )*
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
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:223:14: '=' expression
            			    {
            			    	char_literal33=(IToken)Match(input,54,FOLLOW_54_in_varDef539); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_54.Add(char_literal33);

            			    	PushFollow(FOLLOW_expression_in_varDef541);
            			    	expression34 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression34.Tree);

            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements



            	// AST REWRITE
            	// elements:          variable, expression, variable
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 223:31: -> ^( DEF variable ) ( ^( ASSIGN variable expression ) )*
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:223:34: ^( DEF variable )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(DEF, "DEF"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:223:50: ( ^( ASSIGN variable expression ) )*
            	    while ( stream_variable.HasNext() || stream_expression.HasNext() )
            	    {
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:223:51: ^( ASSIGN variable expression )
            	        {
            	        object root_1 = (object)adaptor.GetNilNode();
            	        root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASSIGN, "ASSIGN"), root_1);

            	        adaptor.AddChild(root_1, stream_variable.NextTree());
            	        adaptor.AddChild(root_1, stream_expression.NextTree());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_variable.Reset();
            	    stream_expression.Reset();

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 11, varDef_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "varDef"

    public class globalVarDefList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "globalVarDefList"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:226:1: globalVarDefList : 'global' 'var' variable ( '=' expression )? ( ',' variable ( '=' expression )? )* -> ( ^( GLOBALDEF variable ) )+ ( ^( ASSIGN variable ( expression )? ) )* ;
    public SGLParser.globalVarDefList_return globalVarDefList() // throws RecognitionException [1]
    {   
        SGLParser.globalVarDefList_return retval = new SGLParser.globalVarDefList_return();
        retval.Start = input.LT(1);
        int globalVarDefList_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal35 = null;
        IToken string_literal36 = null;
        IToken char_literal38 = null;
        IToken char_literal40 = null;
        IToken char_literal42 = null;
        SGLParser.variable_return variable37 = default(SGLParser.variable_return);

        SGLParser.expression_return expression39 = default(SGLParser.expression_return);

        SGLParser.variable_return variable41 = default(SGLParser.variable_return);

        SGLParser.expression_return expression43 = default(SGLParser.expression_return);


        object string_literal35_tree=null;
        object string_literal36_tree=null;
        object char_literal38_tree=null;
        object char_literal40_tree=null;
        object char_literal42_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleTokenStream stream_VarStartInit = new RewriteRuleTokenStream(adaptor,"token VarStartInit");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:227:2: ( 'global' 'var' variable ( '=' expression )? ( ',' variable ( '=' expression )? )* -> ( ^( GLOBALDEF variable ) )+ ( ^( ASSIGN variable ( expression )? ) )* )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:227:4: 'global' 'var' variable ( '=' expression )? ( ',' variable ( '=' expression )? )*
            {
            	string_literal35=(IToken)Match(input,55,FOLLOW_55_in_globalVarDefList574); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(string_literal35);

            	string_literal36=(IToken)Match(input,VarStartInit,FOLLOW_VarStartInit_in_globalVarDefList576); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_VarStartInit.Add(string_literal36);

            	PushFollow(FOLLOW_variable_in_globalVarDefList578);
            	variable37 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable37.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:227:28: ( '=' expression )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == 54) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:227:29: '=' expression
            	        {
            	        	char_literal38=(IToken)Match(input,54,FOLLOW_54_in_globalVarDefList581); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_54.Add(char_literal38);

            	        	PushFollow(FOLLOW_expression_in_globalVarDefList583);
            	        	expression39 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression39.Tree);

            	        }
            	        break;

            	}

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:227:46: ( ',' variable ( '=' expression )? )*
            	do 
            	{
            	    int alt12 = 2;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == 53) )
            	    {
            	        alt12 = 1;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:227:47: ',' variable ( '=' expression )?
            			    {
            			    	char_literal40=(IToken)Match(input,53,FOLLOW_53_in_globalVarDefList588); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_53.Add(char_literal40);

            			    	PushFollow(FOLLOW_variable_in_globalVarDefList590);
            			    	variable41 = variable();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_variable.Add(variable41.Tree);
            			    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:227:60: ( '=' expression )?
            			    	int alt11 = 2;
            			    	int LA11_0 = input.LA(1);

            			    	if ( (LA11_0 == 54) )
            			    	{
            			    	    alt11 = 1;
            			    	}
            			    	switch (alt11) 
            			    	{
            			    	    case 1 :
            			    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:227:61: '=' expression
            			    	        {
            			    	        	char_literal42=(IToken)Match(input,54,FOLLOW_54_in_globalVarDefList593); if (state.failed) return retval; 
            			    	        	if ( (state.backtracking==0) ) stream_54.Add(char_literal42);

            			    	        	PushFollow(FOLLOW_expression_in_globalVarDefList595);
            			    	        	expression43 = expression();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( (state.backtracking==0) ) stream_expression.Add(expression43.Tree);

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements



            	// AST REWRITE
            	// elements:          variable, variable, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 227:80: -> ( ^( GLOBALDEF variable ) )+ ( ^( ASSIGN variable ( expression )? ) )*
            	{
            	    if ( !(stream_variable.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_variable.HasNext() )
            	    {
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:227:83: ^( GLOBALDEF variable )
            	        {
            	        object root_1 = (object)adaptor.GetNilNode();
            	        root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(GLOBALDEF, "GLOBALDEF"), root_1);

            	        adaptor.AddChild(root_1, stream_variable.NextTree());

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_variable.Reset();
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:227:106: ( ^( ASSIGN variable ( expression )? ) )*
            	    while ( stream_variable.HasNext() )
            	    {
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:227:106: ^( ASSIGN variable ( expression )? )
            	        {
            	        object root_1 = (object)adaptor.GetNilNode();
            	        root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASSIGN, "ASSIGN"), root_1);

            	        adaptor.AddChild(root_1, stream_variable.NextTree());
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:227:124: ( expression )?
            	        if ( stream_expression.HasNext() )
            	        {
            	            adaptor.AddChild(root_1, stream_expression.NextTree());

            	        }
            	        stream_expression.Reset();

            	        adaptor.AddChild(root_0, root_1);
            	        }

            	    }
            	    stream_variable.Reset();

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 12, globalVarDefList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "globalVarDefList"

    public class assignment_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignment"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:234:1: assignment : variable ( indexes )? ( '=' expression )? -> ^( ASSIGN variable ( indexes )? ( expression )? ) ;
    public SGLParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        SGLParser.assignment_return retval = new SGLParser.assignment_return();
        retval.Start = input.LT(1);
        int assignment_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal46 = null;
        SGLParser.variable_return variable44 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes45 = default(SGLParser.indexes_return);

        SGLParser.expression_return expression47 = default(SGLParser.expression_return);


        object char_literal46_tree=null;
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_indexes = new RewriteRuleSubtreeStream(adaptor,"rule indexes");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:235:2: ( variable ( indexes )? ( '=' expression )? -> ^( ASSIGN variable ( indexes )? ( expression )? ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:235:4: variable ( indexes )? ( '=' expression )?
            {
            	PushFollow(FOLLOW_variable_in_assignment636);
            	variable44 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable44.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:235:13: ( indexes )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == 56) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_assignment638);
            	        	indexes45 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes45.Tree);

            	        }
            	        break;

            	}

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:235:22: ( '=' expression )?
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == 54) )
            	{
            	    alt14 = 1;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:235:23: '=' expression
            	        {
            	        	char_literal46=(IToken)Match(input,54,FOLLOW_54_in_assignment642); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_54.Add(char_literal46);

            	        	PushFollow(FOLLOW_expression_in_assignment644);
            	        	expression47 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression47.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          expression, indexes, variable
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 235:41: -> ^( ASSIGN variable ( indexes )? ( expression )? )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:235:44: ^( ASSIGN variable ( indexes )? ( expression )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASSIGN, "ASSIGN"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:235:62: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:235:71: ( expression )?
            	    if ( stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expression.NextTree());

            	    }
            	    stream_expression.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 13, assignment_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class indexes_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "indexes"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:238:1: indexes : ( '[' expression ']' )+ -> ^( INDEXES ( expression )+ ) ;
    public SGLParser.indexes_return indexes() // throws RecognitionException [1]
    {   
        SGLParser.indexes_return retval = new SGLParser.indexes_return();
        retval.Start = input.LT(1);
        int indexes_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal48 = null;
        IToken char_literal50 = null;
        SGLParser.expression_return expression49 = default(SGLParser.expression_return);


        object char_literal48_tree=null;
        object char_literal50_tree=null;
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:239:4: ( ( '[' expression ']' )+ -> ^( INDEXES ( expression )+ ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:239:8: ( '[' expression ']' )+
            {
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:239:8: ( '[' expression ']' )+
            	int cnt15 = 0;
            	do 
            	{
            	    int alt15 = 2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0 == 56) )
            	    {
            	        alt15 = 1;
            	    }


            	    switch (alt15) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:239:9: '[' expression ']'
            			    {
            			    	char_literal48=(IToken)Match(input,56,FOLLOW_56_in_indexes679); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_56.Add(char_literal48);

            			    	PushFollow(FOLLOW_expression_in_indexes681);
            			    	expression49 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression49.Tree);
            			    	char_literal50=(IToken)Match(input,57,FOLLOW_57_in_indexes683); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_57.Add(char_literal50);


            			    }
            			    break;

            			default:
            			    if ( cnt15 >= 1 ) goto loop15;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee15 =
            		                new EarlyExitException(15, input);
            		            throw eee15;
            	    }
            	    cnt15++;
            	} while (true);

            	loop15:
            		;	// Stops C# compiler whining that label 'loop15' has no statements



            	// AST REWRITE
            	// elements:          expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 239:30: -> ^( INDEXES ( expression )+ )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:239:33: ^( INDEXES ( expression )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INDEXES, "INDEXES"), root_1);

            	    if ( !(stream_expression.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expression.NextTree());

            	    }
            	    stream_expression.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 14, indexes_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "indexes"

    public class objectMethodCall_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objectMethodCall"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:242:1: objectMethodCall : variable ( indexes )? '.' Identifier '(' ( expressionList )? ')' -> ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? ) ;
    public SGLParser.objectMethodCall_return objectMethodCall() // throws RecognitionException [1]
    {   
        SGLParser.objectMethodCall_return retval = new SGLParser.objectMethodCall_return();
        retval.Start = input.LT(1);
        int objectMethodCall_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal53 = null;
        IToken Identifier54 = null;
        IToken char_literal55 = null;
        IToken char_literal57 = null;
        SGLParser.variable_return variable51 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes52 = default(SGLParser.indexes_return);

        SGLParser.expressionList_return expressionList56 = default(SGLParser.expressionList_return);


        object char_literal53_tree=null;
        object Identifier54_tree=null;
        object char_literal55_tree=null;
        object char_literal57_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleSubtreeStream stream_expressionList = new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        RewriteRuleSubtreeStream stream_indexes = new RewriteRuleSubtreeStream(adaptor,"rule indexes");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:243:2: ( variable ( indexes )? '.' Identifier '(' ( expressionList )? ')' -> ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:243:4: variable ( indexes )? '.' Identifier '(' ( expressionList )? ')'
            {
            	PushFollow(FOLLOW_variable_in_objectMethodCall710);
            	variable51 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable51.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:243:13: ( indexes )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( (LA16_0 == 56) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_objectMethodCall712);
            	        	indexes52 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes52.Tree);

            	        }
            	        break;

            	}

            	char_literal53=(IToken)Match(input,58,FOLLOW_58_in_objectMethodCall715); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_58.Add(char_literal53);

            	Identifier54=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_objectMethodCall717); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier54);

            	char_literal55=(IToken)Match(input,59,FOLLOW_59_in_objectMethodCall719); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(char_literal55);

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:243:41: ( expressionList )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( ((LA17_0 >= Identifier && LA17_0 <= Null) || LA17_0 == 59 || LA17_0 == 73 || LA17_0 == 78 || LA17_0 == 81) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_objectMethodCall721);
            	        	expressionList56 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList56.Tree);

            	        }
            	        break;

            	}

            	char_literal57=(IToken)Match(input,60,FOLLOW_60_in_objectMethodCall724); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_60.Add(char_literal57);



            	// AST REWRITE
            	// elements:          variable, indexes, expressionList, Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 243:61: -> ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:243:64: ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(OBJ_FUNC_CALL, "OBJ_FUNC_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:243:89: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:243:109: ( expressionList )?
            	    if ( stream_expressionList.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expressionList.NextTree());

            	    }
            	    stream_expressionList.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 15, objectMethodCall_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "objectMethodCall"

    public class variable_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variable"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:247:1: variable : Identifier -> Identifier ;
    public SGLParser.variable_return variable() // throws RecognitionException [1]
    {   
        SGLParser.variable_return retval = new SGLParser.variable_return();
        retval.Start = input.LT(1);
        int variable_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier58 = null;

        object Identifier58_tree=null;
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:248:2: ( Identifier -> Identifier )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:248:4: Identifier
            {
            	Identifier58=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable758); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier58);



            	// AST REWRITE
            	// elements:          Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 248:15: -> Identifier
            	{
            	    adaptor.AddChild(root_0, stream_Identifier.NextNode());

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 16, variable_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "variable"

    public class stringAtom_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "stringAtom"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:253:1: stringAtom : StringAtom -> ^( STRING StringAtom ) ;
    public SGLParser.stringAtom_return stringAtom() // throws RecognitionException [1]
    {   
        SGLParser.stringAtom_return retval = new SGLParser.stringAtom_return();
        retval.Start = input.LT(1);
        int stringAtom_StartIndex = input.Index();
        object root_0 = null;

        IToken StringAtom59 = null;

        object StringAtom59_tree=null;
        RewriteRuleTokenStream stream_StringAtom = new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:254:2: ( StringAtom -> ^( STRING StringAtom ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:254:6: StringAtom
            {
            	StringAtom59=(IToken)Match(input,StringAtom,FOLLOW_StringAtom_in_stringAtom781); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_StringAtom.Add(StringAtom59);



            	// AST REWRITE
            	// elements:          StringAtom
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 254:17: -> ^( STRING StringAtom )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:254:20: ^( STRING StringAtom )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STRING, "STRING"), root_1);

            	    adaptor.AddChild(root_1, stream_StringAtom.NextNode());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 17, stringAtom_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "stringAtom"

    public class functionDef_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "functionDef"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:259:1: functionDef : 'function' Identifier '(' ( variableList )? ')' commonBlock ;
    public SGLParser.functionDef_return functionDef() // throws RecognitionException [1]
    {   
        SGLParser.functionDef_return retval = new SGLParser.functionDef_return();
        retval.Start = input.LT(1);
        int functionDef_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal60 = null;
        IToken Identifier61 = null;
        IToken char_literal62 = null;
        IToken char_literal64 = null;
        SGLParser.variableList_return variableList63 = default(SGLParser.variableList_return);

        SGLParser.commonBlock_return commonBlock65 = default(SGLParser.commonBlock_return);


        object string_literal60_tree=null;
        object Identifier61_tree=null;
        object char_literal62_tree=null;
        object char_literal64_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:260:2: ( 'function' Identifier '(' ( variableList )? ')' commonBlock )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:260:4: 'function' Identifier '(' ( variableList )? ')' commonBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal60=(IToken)Match(input,61,FOLLOW_61_in_functionDef802); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal60_tree = (object)adaptor.Create(string_literal60);
            		adaptor.AddChild(root_0, string_literal60_tree);
            	}
            	Identifier61=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_functionDef804); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier61_tree = (object)adaptor.Create(Identifier61);
            		adaptor.AddChild(root_0, Identifier61_tree);
            	}
            	char_literal62=(IToken)Match(input,59,FOLLOW_59_in_functionDef806); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal62_tree = (object)adaptor.Create(char_literal62);
            		adaptor.AddChild(root_0, char_literal62_tree);
            	}
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:260:30: ( variableList )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == Identifier) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: variableList
            	        {
            	        	PushFollow(FOLLOW_variableList_in_functionDef808);
            	        	variableList63 = variableList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableList63.Tree);

            	        }
            	        break;

            	}

            	char_literal64=(IToken)Match(input,60,FOLLOW_60_in_functionDef811); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal64_tree = (object)adaptor.Create(char_literal64);
            		adaptor.AddChild(root_0, char_literal64_tree);
            	}
            	PushFollow(FOLLOW_commonBlock_in_functionDef813);
            	commonBlock65 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, commonBlock65.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   DefineFunction(((Identifier61 != null) ? Identifier61.Text : null), ((variableList63 != null) ? ((object)variableList63.Tree) : null), ((commonBlock65 != null) ? ((object)commonBlock65.Tree) : null), ((Identifier61 != null) ? Identifier61.Line : 0)); 
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 18, functionDef_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "functionDef"

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:279:1: expression : ( instantiateClass | conditionalExpression );
    public SGLParser.expression_return expression() // throws RecognitionException [1]
    {   
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.instantiateClass_return instantiateClass66 = default(SGLParser.instantiateClass_return);

        SGLParser.conditionalExpression_return conditionalExpression67 = default(SGLParser.conditionalExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:280:5: ( instantiateClass | conditionalExpression )
            int alt19 = 2;
            int LA19_0 = input.LA(1);

            if ( (LA19_0 == 81) )
            {
                alt19 = 1;
            }
            else if ( ((LA19_0 >= Identifier && LA19_0 <= Null) || LA19_0 == 59 || LA19_0 == 73 || LA19_0 == 78) )
            {
                alt19 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d19s0 =
                    new NoViableAltException("", 19, 0, input);

                throw nvae_d19s0;
            }
            switch (alt19) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:280:7: instantiateClass
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_instantiateClass_in_expression850);
                    	instantiateClass66 = instantiateClass();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, instantiateClass66.Tree);

                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:281:7: conditionalExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalExpression_in_expression860);
                    	conditionalExpression67 = conditionalExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression67.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 19, expression_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:286:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public SGLParser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.Start = input.LT(1);
        int conditionalExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal69 = null;
        IToken char_literal71 = null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression68 = default(SGLParser.conditionalOrExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression70 = default(SGLParser.conditionalExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression72 = default(SGLParser.conditionalExpression_return);


        object char_literal69_tree=null;
        object char_literal71_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:287:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:287:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression886);
            	conditionalOrExpression68 = conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression68.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:287:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == 62) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:287:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	char_literal69=(IToken)Match(input,62,FOLLOW_62_in_conditionalExpression890); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal69_tree = (object)adaptor.Create(char_literal69);
            	        		root_0 = (object)adaptor.BecomeRoot(char_literal69_tree, root_0);
            	        	}
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression893);
            	        	conditionalExpression70 = conditionalExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression70.Tree);
            	        	char_literal71=(IToken)Match(input,63,FOLLOW_63_in_conditionalExpression895); if (state.failed) return retval;
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression898);
            	        	conditionalExpression72 = conditionalExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression72.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 20, conditionalExpression_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:292:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public SGLParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);
        int conditionalOrExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal74 = null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression73 = default(SGLParser.conditionalAndExpression_return);

        SGLParser.conditionalAndExpression_return conditionalAndExpression75 = default(SGLParser.conditionalAndExpression_return);


        object string_literal74_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:293:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:293:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression941);
            	conditionalAndExpression73 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression73.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:293:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == 64) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:293:36: '||' conditionalAndExpression
            			    {
            			    	string_literal74=(IToken)Match(input,64,FOLLOW_64_in_conditionalOrExpression945); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal74_tree = (object)adaptor.Create(string_literal74);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal74_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression948);
            			    	conditionalAndExpression75 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression75.Tree);

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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 21, conditionalOrExpression_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:297:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public SGLParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);
        int conditionalAndExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal77 = null;
        SGLParser.equalityExpression_return equalityExpression76 = default(SGLParser.equalityExpression_return);

        SGLParser.equalityExpression_return equalityExpression78 = default(SGLParser.equalityExpression_return);


        object string_literal77_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:298:5: ( equalityExpression ( '&&' equalityExpression )* )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:298:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression979);
            	equalityExpression76 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression76.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:298:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == 65) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:298:30: '&&' equalityExpression
            			    {
            			    	string_literal77=(IToken)Match(input,65,FOLLOW_65_in_conditionalAndExpression983); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal77_tree = (object)adaptor.Create(string_literal77);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal77_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression986);
            			    	equalityExpression78 = equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression78.Tree);

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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 22, conditionalAndExpression_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:302:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public SGLParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.Start = input.LT(1);
        int equalityExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal80 = null;
        IToken string_literal81 = null;
        SGLParser.relationalExpression_return relationalExpression79 = default(SGLParser.relationalExpression_return);

        SGLParser.relationalExpression_return relationalExpression82 = default(SGLParser.relationalExpression_return);


        object string_literal80_tree=null;
        object string_literal81_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:303:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:303:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1013);
            	relationalExpression79 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression79.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:303:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( ((LA24_0 >= 66 && LA24_0 <= 67)) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:303:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:303:32: ( '==' | '!=' )
            			    	int alt23 = 2;
            			    	int LA23_0 = input.LA(1);

            			    	if ( (LA23_0 == 66) )
            			    	{
            			    	    alt23 = 1;
            			    	}
            			    	else if ( (LA23_0 == 67) )
            			    	{
            			    	    alt23 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    NoViableAltException nvae_d23s0 =
            			    	        new NoViableAltException("", 23, 0, input);

            			    	    throw nvae_d23s0;
            			    	}
            			    	switch (alt23) 
            			    	{
            			    	    case 1 :
            			    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:303:33: '=='
            			    	        {
            			    	        	string_literal80=(IToken)Match(input,66,FOLLOW_66_in_equalityExpression1018); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal80_tree = (object)adaptor.Create(string_literal80);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal80_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:303:41: '!='
            			    	        {
            			    	        	string_literal81=(IToken)Match(input,67,FOLLOW_67_in_equalityExpression1023); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal81_tree = (object)adaptor.Create(string_literal81);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal81_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1027);
            			    	relationalExpression82 = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression82.Tree);

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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 23, equalityExpression_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:307:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public SGLParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.Start = input.LT(1);
        int relationalExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal84 = null;
        IToken char_literal85 = null;
        IToken string_literal86 = null;
        IToken string_literal87 = null;
        SGLParser.additiveExpression_return additiveExpression83 = default(SGLParser.additiveExpression_return);

        SGLParser.additiveExpression_return additiveExpression88 = default(SGLParser.additiveExpression_return);


        object char_literal84_tree=null;
        object char_literal85_tree=null;
        object string_literal86_tree=null;
        object string_literal87_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:308:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:308:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1058);
            	additiveExpression83 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression83.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:308:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( ((LA26_0 >= 68 && LA26_0 <= 71)) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:308:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:308:29: ( '<' | '>' | '<=' | '>=' )
            			    	int alt25 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 68:
            			    		{
            			    	    alt25 = 1;
            			    	    }
            			    	    break;
            			    	case 69:
            			    		{
            			    	    alt25 = 2;
            			    	    }
            			    	    break;
            			    	case 70:
            			    		{
            			    	    alt25 = 3;
            			    	    }
            			    	    break;
            			    	case 71:
            			    		{
            			    	    alt25 = 4;
            			    	    }
            			    	    break;
            			    		default:
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    NoViableAltException nvae_d25s0 =
            			    		        new NoViableAltException("", 25, 0, input);

            			    		    throw nvae_d25s0;
            			    	}

            			    	switch (alt25) 
            			    	{
            			    	    case 1 :
            			    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:308:30: '<'
            			    	        {
            			    	        	char_literal84=(IToken)Match(input,68,FOLLOW_68_in_relationalExpression1062); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal84_tree = (object)adaptor.Create(char_literal84);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal84_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:308:35: '>'
            			    	        {
            			    	        	char_literal85=(IToken)Match(input,69,FOLLOW_69_in_relationalExpression1065); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal85_tree = (object)adaptor.Create(char_literal85);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal85_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:308:40: '<='
            			    	        {
            			    	        	string_literal86=(IToken)Match(input,70,FOLLOW_70_in_relationalExpression1068); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal86_tree = (object)adaptor.Create(string_literal86);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal86_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:308:46: '>='
            			    	        {
            			    	        	string_literal87=(IToken)Match(input,71,FOLLOW_71_in_relationalExpression1071); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal87_tree = (object)adaptor.Create(string_literal87);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal87_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1075);
            			    	additiveExpression88 = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression88.Tree);

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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 24, relationalExpression_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:312:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public SGLParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.Start = input.LT(1);
        int additiveExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal90 = null;
        IToken char_literal91 = null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression89 = default(SGLParser.multiplicativeExpression_return);

        SGLParser.multiplicativeExpression_return multiplicativeExpression92 = default(SGLParser.multiplicativeExpression_return);


        object char_literal90_tree=null;
        object char_literal91_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:313:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:313:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1113);
            	multiplicativeExpression89 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression89.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:313:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( ((LA28_0 >= 72 && LA28_0 <= 73)) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:313:35: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:313:35: ( '+' | '-' )
            			    	int alt27 = 2;
            			    	int LA27_0 = input.LA(1);

            			    	if ( (LA27_0 == 72) )
            			    	{
            			    	    alt27 = 1;
            			    	}
            			    	else if ( (LA27_0 == 73) )
            			    	{
            			    	    alt27 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    NoViableAltException nvae_d27s0 =
            			    	        new NoViableAltException("", 27, 0, input);

            			    	    throw nvae_d27s0;
            			    	}
            			    	switch (alt27) 
            			    	{
            			    	    case 1 :
            			    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:313:36: '+'
            			    	        {
            			    	        	char_literal90=(IToken)Match(input,72,FOLLOW_72_in_additiveExpression1117); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal90_tree = (object)adaptor.Create(char_literal90);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal90_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:313:41: '-'
            			    	        {
            			    	        	char_literal91=(IToken)Match(input,73,FOLLOW_73_in_additiveExpression1120); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal91_tree = (object)adaptor.Create(char_literal91);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal91_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1124);
            			    	multiplicativeExpression92 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression92.Tree);

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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 25, additiveExpression_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:317:1: multiplicativeExpression : powExpression ( ( '*' | '/' | '%' ) powExpression )* ;
    public SGLParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal94 = null;
        IToken char_literal95 = null;
        IToken char_literal96 = null;
        SGLParser.powExpression_return powExpression93 = default(SGLParser.powExpression_return);

        SGLParser.powExpression_return powExpression97 = default(SGLParser.powExpression_return);


        object char_literal94_tree=null;
        object char_literal95_tree=null;
        object char_literal96_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:318:5: ( powExpression ( ( '*' | '/' | '%' ) powExpression )* )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:318:9: powExpression ( ( '*' | '/' | '%' ) powExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_powExpression_in_multiplicativeExpression1158);
            	powExpression93 = powExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, powExpression93.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:318:23: ( ( '*' | '/' | '%' ) powExpression )*
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( ((LA30_0 >= 74 && LA30_0 <= 76)) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:318:24: ( '*' | '/' | '%' ) powExpression
            			    {
            			    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:318:24: ( '*' | '/' | '%' )
            			    	int alt29 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 74:
            			    		{
            			    	    alt29 = 1;
            			    	    }
            			    	    break;
            			    	case 75:
            			    		{
            			    	    alt29 = 2;
            			    	    }
            			    	    break;
            			    	case 76:
            			    		{
            			    	    alt29 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    NoViableAltException nvae_d29s0 =
            			    		        new NoViableAltException("", 29, 0, input);

            			    		    throw nvae_d29s0;
            			    	}

            			    	switch (alt29) 
            			    	{
            			    	    case 1 :
            			    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:318:25: '*'
            			    	        {
            			    	        	char_literal94=(IToken)Match(input,74,FOLLOW_74_in_multiplicativeExpression1162); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal94_tree = (object)adaptor.Create(char_literal94);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal94_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:318:30: '/'
            			    	        {
            			    	        	char_literal95=(IToken)Match(input,75,FOLLOW_75_in_multiplicativeExpression1165); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal95_tree = (object)adaptor.Create(char_literal95);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal95_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:318:35: '%'
            			    	        {
            			    	        	char_literal96=(IToken)Match(input,76,FOLLOW_76_in_multiplicativeExpression1168); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal96_tree = (object)adaptor.Create(char_literal96);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal96_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_powExpression_in_multiplicativeExpression1172);
            			    	powExpression97 = powExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, powExpression97.Tree);

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

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 26, multiplicativeExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "multiplicativeExpression"

    public class powExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "powExpression"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:321:1: powExpression : negateExpression ( '^' negateExpression )* ;
    public SGLParser.powExpression_return powExpression() // throws RecognitionException [1]
    {   
        SGLParser.powExpression_return retval = new SGLParser.powExpression_return();
        retval.Start = input.LT(1);
        int powExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal99 = null;
        SGLParser.negateExpression_return negateExpression98 = default(SGLParser.negateExpression_return);

        SGLParser.negateExpression_return negateExpression100 = default(SGLParser.negateExpression_return);


        object char_literal99_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:322:2: ( negateExpression ( '^' negateExpression )* )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:322:4: negateExpression ( '^' negateExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_negateExpression_in_powExpression1192);
            	negateExpression98 = negateExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negateExpression98.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:322:21: ( '^' negateExpression )*
            	do 
            	{
            	    int alt31 = 2;
            	    int LA31_0 = input.LA(1);

            	    if ( (LA31_0 == 77) )
            	    {
            	        alt31 = 1;
            	    }


            	    switch (alt31) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:322:22: '^' negateExpression
            			    {
            			    	char_literal99=(IToken)Match(input,77,FOLLOW_77_in_powExpression1195); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal99_tree = (object)adaptor.Create(char_literal99);
            			    		root_0 = (object)adaptor.BecomeRoot(char_literal99_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_negateExpression_in_powExpression1198);
            			    	negateExpression100 = negateExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negateExpression100.Tree);

            			    }
            			    break;

            			default:
            			    goto loop31;
            	    }
            	} while (true);

            	loop31:
            		;	// Stops C# compiler whining that label 'loop31' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 27, powExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "powExpression"

    public class negateExpression_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "negateExpression"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:326:1: negateExpression : ( '-' mathAtom -> ^( INT_NEGATE mathAtom ) | '!' mathAtom -> ^( BOOL_NEGATE mathAtom ) | unaryExpression | mathAtom );
    public SGLParser.negateExpression_return negateExpression() // throws RecognitionException [1]
    {   
        SGLParser.negateExpression_return retval = new SGLParser.negateExpression_return();
        retval.Start = input.LT(1);
        int negateExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal101 = null;
        IToken char_literal103 = null;
        SGLParser.mathAtom_return mathAtom102 = default(SGLParser.mathAtom_return);

        SGLParser.mathAtom_return mathAtom104 = default(SGLParser.mathAtom_return);

        SGLParser.unaryExpression_return unaryExpression105 = default(SGLParser.unaryExpression_return);

        SGLParser.mathAtom_return mathAtom106 = default(SGLParser.mathAtom_return);


        object char_literal101_tree=null;
        object char_literal103_tree=null;
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_73 = new RewriteRuleTokenStream(adaptor,"token 73");
        RewriteRuleSubtreeStream stream_mathAtom = new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:327:2: ( '-' mathAtom -> ^( INT_NEGATE mathAtom ) | '!' mathAtom -> ^( BOOL_NEGATE mathAtom ) | unaryExpression | mathAtom )
            int alt32 = 4;
            switch ( input.LA(1) ) 
            {
            case 73:
            	{
                alt32 = 1;
                }
                break;
            case 78:
            	{
                alt32 = 2;
                }
                break;
            case Identifier:
            	{
                int LA32_3 = input.LA(2);

                if ( (LA32_3 == EOF || LA32_3 == Identifier || LA32_3 == VarStartInit || LA32_3 == 50 || (LA32_3 >= 52 && LA32_3 <= 54) || (LA32_3 >= 56 && LA32_3 <= 60) || (LA32_3 >= 62 && LA32_3 <= 77) || (LA32_3 >= 82 && LA32_3 <= 83)) )
                {
                    alt32 = 4;
                }
                else if ( ((LA32_3 >= 79 && LA32_3 <= 80)) )
                {
                    alt32 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d32s3 =
                        new NoViableAltException("", 32, 3, input);

                    throw nvae_d32s3;
                }
                }
                break;
            case StringAtom:
            case IntAtom:
            case FloatAtom:
            case BooleanAtom:
            case LayerAtom:
            case OriginAtom:
            case LoopTypeAtom:
            case LoopTriggerAtom:
            case ColorAtom:
            case Null:
            case 59:
            	{
                alt32 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d32s0 =
            	        new NoViableAltException("", 32, 0, input);

            	    throw nvae_d32s0;
            }

            switch (alt32) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:327:4: '-' mathAtom
                    {
                    	char_literal101=(IToken)Match(input,73,FOLLOW_73_in_negateExpression1216); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_73.Add(char_literal101);

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1218);
                    	mathAtom102 = mathAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_mathAtom.Add(mathAtom102.Tree);


                    	// AST REWRITE
                    	// elements:          mathAtom
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 327:17: -> ^( INT_NEGATE mathAtom )
                    	{
                    	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:327:20: ^( INT_NEGATE mathAtom )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(INT_NEGATE, "INT_NEGATE"), root_1);

                    	    adaptor.AddChild(root_1, stream_mathAtom.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:328:4: '!' mathAtom
                    {
                    	char_literal103=(IToken)Match(input,78,FOLLOW_78_in_negateExpression1231); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_78.Add(char_literal103);

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1233);
                    	mathAtom104 = mathAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_mathAtom.Add(mathAtom104.Tree);


                    	// AST REWRITE
                    	// elements:          mathAtom
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 328:17: -> ^( BOOL_NEGATE mathAtom )
                    	{
                    	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:328:20: ^( BOOL_NEGATE mathAtom )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BOOL_NEGATE, "BOOL_NEGATE"), root_1);

                    	    adaptor.AddChild(root_1, stream_mathAtom.NextTree());

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:329:4: unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpression_in_negateExpression1246);
                    	unaryExpression105 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression105.Tree);

                    }
                    break;
                case 4 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:330:4: mathAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1251);
                    	mathAtom106 = mathAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathAtom106.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 28, negateExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "negateExpression"

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:334:1: unaryExpression : Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) ;
    public SGLParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.Start = input.LT(1);
        int unaryExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier107 = null;
        IToken string_literal108 = null;
        IToken string_literal109 = null;

        object Identifier107_tree=null;
        object string_literal108_tree=null;
        object string_literal109_tree=null;
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:335:5: ( Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:335:9: Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            {
            	Identifier107=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_unaryExpression1269); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier107);

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:335:20: ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            	int alt33 = 2;
            	int LA33_0 = input.LA(1);

            	if ( (LA33_0 == 79) )
            	{
            	    alt33 = 1;
            	}
            	else if ( (LA33_0 == 80) )
            	{
            	    alt33 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d33s0 =
            	        new NoViableAltException("", 33, 0, input);

            	    throw nvae_d33s0;
            	}
            	switch (alt33) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:335:21: '++'
            	        {
            	        	string_literal108=(IToken)Match(input,79,FOLLOW_79_in_unaryExpression1272); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_79.Add(string_literal108);



            	        	// AST REWRITE
            	        	// elements:          Identifier
            	        	// token labels:      
            	        	// rule labels:       retval
            	        	// token list labels: 
            	        	// rule list labels:  
            	        	// wildcard labels: 
            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = root_0;
            	        	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	        	root_0 = (object)adaptor.GetNilNode();
            	        	// 335:26: -> ^( VARINC Identifier )
            	        	{
            	        	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:335:29: ^( VARINC Identifier )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARINC, "VARINC"), root_1);

            	        	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

            	        	    adaptor.AddChild(root_0, root_1);
            	        	    }

            	        	}

            	        	retval.Tree = root_0;retval.Tree = root_0;}
            	        }
            	        break;
            	    case 2 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:336:4: '--'
            	        {
            	        	string_literal109=(IToken)Match(input,80,FOLLOW_80_in_unaryExpression1285); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_80.Add(string_literal109);



            	        	// AST REWRITE
            	        	// elements:          Identifier
            	        	// token labels:      
            	        	// rule labels:       retval
            	        	// token list labels: 
            	        	// rule list labels:  
            	        	// wildcard labels: 
            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = root_0;
            	        	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	        	root_0 = (object)adaptor.GetNilNode();
            	        	// 336:9: -> ^( VARDEC Identifier )
            	        	{
            	        	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:336:12: ^( VARDEC Identifier )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDEC, "VARDEC"), root_1);

            	        	    adaptor.AddChild(root_1, stream_Identifier.NextNode());

            	        	    adaptor.AddChild(root_0, root_1);
            	        	    }

            	        	}

            	        	retval.Tree = root_0;retval.Tree = root_0;}
            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 29, unaryExpression_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "unaryExpression"

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:341:1: mathAtom : ( '(' expression ')' | IntAtom | FloatAtom | BooleanAtom | stringAtom | LayerAtom | OriginAtom | LoopTypeAtom | LoopTriggerAtom | ColorAtom | Null | lookup );
    public SGLParser.mathAtom_return mathAtom() // throws RecognitionException [1]
    {   
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.Start = input.LT(1);
        int mathAtom_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal110 = null;
        IToken char_literal112 = null;
        IToken IntAtom113 = null;
        IToken FloatAtom114 = null;
        IToken BooleanAtom115 = null;
        IToken LayerAtom117 = null;
        IToken OriginAtom118 = null;
        IToken LoopTypeAtom119 = null;
        IToken LoopTriggerAtom120 = null;
        IToken ColorAtom121 = null;
        IToken Null122 = null;
        SGLParser.expression_return expression111 = default(SGLParser.expression_return);

        SGLParser.stringAtom_return stringAtom116 = default(SGLParser.stringAtom_return);

        SGLParser.lookup_return lookup123 = default(SGLParser.lookup_return);


        object char_literal110_tree=null;
        object char_literal112_tree=null;
        object IntAtom113_tree=null;
        object FloatAtom114_tree=null;
        object BooleanAtom115_tree=null;
        object LayerAtom117_tree=null;
        object OriginAtom118_tree=null;
        object LoopTypeAtom119_tree=null;
        object LoopTriggerAtom120_tree=null;
        object ColorAtom121_tree=null;
        object Null122_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:342:2: ( '(' expression ')' | IntAtom | FloatAtom | BooleanAtom | stringAtom | LayerAtom | OriginAtom | LoopTypeAtom | LoopTriggerAtom | ColorAtom | Null | lookup )
            int alt34 = 12;
            switch ( input.LA(1) ) 
            {
            case 59:
            	{
                alt34 = 1;
                }
                break;
            case IntAtom:
            	{
                alt34 = 2;
                }
                break;
            case FloatAtom:
            	{
                alt34 = 3;
                }
                break;
            case BooleanAtom:
            	{
                alt34 = 4;
                }
                break;
            case StringAtom:
            	{
                alt34 = 5;
                }
                break;
            case LayerAtom:
            	{
                alt34 = 6;
                }
                break;
            case OriginAtom:
            	{
                alt34 = 7;
                }
                break;
            case LoopTypeAtom:
            	{
                alt34 = 8;
                }
                break;
            case LoopTriggerAtom:
            	{
                alt34 = 9;
                }
                break;
            case ColorAtom:
            	{
                alt34 = 10;
                }
                break;
            case Null:
            	{
                alt34 = 11;
                }
                break;
            case Identifier:
            	{
                alt34 = 12;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d34s0 =
            	        new NoViableAltException("", 34, 0, input);

            	    throw nvae_d34s0;
            }

            switch (alt34) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:342:4: '(' expression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal110=(IToken)Match(input,59,FOLLOW_59_in_mathAtom1319); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expression_in_mathAtom1322);
                    	expression111 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression111.Tree);
                    	char_literal112=(IToken)Match(input,60,FOLLOW_60_in_mathAtom1324); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:343:7: IntAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IntAtom113=(IToken)Match(input,IntAtom,FOLLOW_IntAtom_in_mathAtom1336); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IntAtom113_tree = (object)adaptor.Create(IntAtom113);
                    		adaptor.AddChild(root_0, IntAtom113_tree);
                    	}

                    }
                    break;
                case 3 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:344:7: FloatAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FloatAtom114=(IToken)Match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1351); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FloatAtom114_tree = (object)adaptor.Create(FloatAtom114);
                    		adaptor.AddChild(root_0, FloatAtom114_tree);
                    	}

                    }
                    break;
                case 4 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:345:9: BooleanAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BooleanAtom115=(IToken)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1367); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BooleanAtom115_tree = (object)adaptor.Create(BooleanAtom115);
                    		adaptor.AddChild(root_0, BooleanAtom115_tree);
                    	}

                    }
                    break;
                case 5 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:346:4: stringAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stringAtom_in_mathAtom1378);
                    	stringAtom116 = stringAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, stringAtom116.Tree);

                    }
                    break;
                case 6 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:347:4: LayerAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LayerAtom117=(IToken)Match(input,LayerAtom,FOLLOW_LayerAtom_in_mathAtom1389); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LayerAtom117_tree = (object)adaptor.Create(LayerAtom117);
                    		adaptor.AddChild(root_0, LayerAtom117_tree);
                    	}

                    }
                    break;
                case 7 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:348:4: OriginAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	OriginAtom118=(IToken)Match(input,OriginAtom,FOLLOW_OriginAtom_in_mathAtom1400); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OriginAtom118_tree = (object)adaptor.Create(OriginAtom118);
                    		adaptor.AddChild(root_0, OriginAtom118_tree);
                    	}

                    }
                    break;
                case 8 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:349:4: LoopTypeAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LoopTypeAtom119=(IToken)Match(input,LoopTypeAtom,FOLLOW_LoopTypeAtom_in_mathAtom1411); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LoopTypeAtom119_tree = (object)adaptor.Create(LoopTypeAtom119);
                    		adaptor.AddChild(root_0, LoopTypeAtom119_tree);
                    	}

                    }
                    break;
                case 9 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:350:4: LoopTriggerAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LoopTriggerAtom120=(IToken)Match(input,LoopTriggerAtom,FOLLOW_LoopTriggerAtom_in_mathAtom1424); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LoopTriggerAtom120_tree = (object)adaptor.Create(LoopTriggerAtom120);
                    		adaptor.AddChild(root_0, LoopTriggerAtom120_tree);
                    	}

                    }
                    break;
                case 10 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:351:4: ColorAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ColorAtom121=(IToken)Match(input,ColorAtom,FOLLOW_ColorAtom_in_mathAtom1434); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ColorAtom121_tree = (object)adaptor.Create(ColorAtom121);
                    		adaptor.AddChild(root_0, ColorAtom121_tree);
                    	}

                    }
                    break;
                case 11 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:352:4: Null
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	Null122=(IToken)Match(input,Null,FOLLOW_Null_in_mathAtom1445); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Null122_tree = (object)adaptor.Create(Null122);
                    		adaptor.AddChild(root_0, Null122_tree);
                    	}

                    }
                    break;
                case 12 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:354:4: lookup
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lookup_in_mathAtom1459);
                    	lookup123 = lookup();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lookup123.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 30, mathAtom_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "mathAtom"

    public class lookup_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "lookup"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:357:1: lookup : ( objectMethodCall ( indexes )? -> ^( LOOKUP objectMethodCall ( indexes )? ) | methodCall ( indexes )? -> ^( LOOKUP methodCall ( indexes )? ) | variable ( indexes )? -> ^( LOOKUP variable ( indexes )? ) );
    public SGLParser.lookup_return lookup() // throws RecognitionException [1]
    {   
        SGLParser.lookup_return retval = new SGLParser.lookup_return();
        retval.Start = input.LT(1);
        int lookup_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.objectMethodCall_return objectMethodCall124 = default(SGLParser.objectMethodCall_return);

        SGLParser.indexes_return indexes125 = default(SGLParser.indexes_return);

        SGLParser.methodCall_return methodCall126 = default(SGLParser.methodCall_return);

        SGLParser.indexes_return indexes127 = default(SGLParser.indexes_return);

        SGLParser.variable_return variable128 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes129 = default(SGLParser.indexes_return);


        RewriteRuleSubtreeStream stream_objectMethodCall = new RewriteRuleSubtreeStream(adaptor,"rule objectMethodCall");
        RewriteRuleSubtreeStream stream_methodCall = new RewriteRuleSubtreeStream(adaptor,"rule methodCall");
        RewriteRuleSubtreeStream stream_indexes = new RewriteRuleSubtreeStream(adaptor,"rule indexes");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:358:2: ( objectMethodCall ( indexes )? -> ^( LOOKUP objectMethodCall ( indexes )? ) | methodCall ( indexes )? -> ^( LOOKUP methodCall ( indexes )? ) | variable ( indexes )? -> ^( LOOKUP variable ( indexes )? ) )
            int alt38 = 3;
            int LA38_0 = input.LA(1);

            if ( (LA38_0 == Identifier) )
            {
                int LA38_1 = input.LA(2);

                if ( (synpred60_SGL()) )
                {
                    alt38 = 1;
                }
                else if ( (synpred62_SGL()) )
                {
                    alt38 = 2;
                }
                else if ( (true) )
                {
                    alt38 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d38s1 =
                        new NoViableAltException("", 38, 1, input);

                    throw nvae_d38s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d38s0 =
                    new NoViableAltException("", 38, 0, input);

                throw nvae_d38s0;
            }
            switch (alt38) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:358:4: objectMethodCall ( indexes )?
                    {
                    	PushFollow(FOLLOW_objectMethodCall_in_lookup1478);
                    	objectMethodCall124 = objectMethodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_objectMethodCall.Add(objectMethodCall124.Tree);
                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:358:21: ( indexes )?
                    	int alt35 = 2;
                    	int LA35_0 = input.LA(1);

                    	if ( (LA35_0 == 56) )
                    	{
                    	    alt35 = 1;
                    	}
                    	switch (alt35) 
                    	{
                    	    case 1 :
                    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1480);
                    	        	indexes125 = indexes();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes125.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          objectMethodCall, indexes
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 358:30: -> ^( LOOKUP objectMethodCall ( indexes )? )
                    	{
                    	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:358:33: ^( LOOKUP objectMethodCall ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_objectMethodCall.NextTree());
                    	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:358:59: ( indexes )?
                    	    if ( stream_indexes.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_indexes.NextTree());

                    	    }
                    	    stream_indexes.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:359:4: methodCall ( indexes )?
                    {
                    	PushFollow(FOLLOW_methodCall_in_lookup1497);
                    	methodCall126 = methodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_methodCall.Add(methodCall126.Tree);
                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:359:15: ( indexes )?
                    	int alt36 = 2;
                    	int LA36_0 = input.LA(1);

                    	if ( (LA36_0 == 56) )
                    	{
                    	    alt36 = 1;
                    	}
                    	switch (alt36) 
                    	{
                    	    case 1 :
                    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1499);
                    	        	indexes127 = indexes();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes127.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          indexes, methodCall
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 359:24: -> ^( LOOKUP methodCall ( indexes )? )
                    	{
                    	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:359:27: ^( LOOKUP methodCall ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_methodCall.NextTree());
                    	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:359:47: ( indexes )?
                    	    if ( stream_indexes.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_indexes.NextTree());

                    	    }
                    	    stream_indexes.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;
                case 3 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:360:4: variable ( indexes )?
                    {
                    	PushFollow(FOLLOW_variable_in_lookup1517);
                    	variable128 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_variable.Add(variable128.Tree);
                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:360:13: ( indexes )?
                    	int alt37 = 2;
                    	int LA37_0 = input.LA(1);

                    	if ( (LA37_0 == 56) )
                    	{
                    	    alt37 = 1;
                    	}
                    	switch (alt37) 
                    	{
                    	    case 1 :
                    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1519);
                    	        	indexes129 = indexes();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes129.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          indexes, variable
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 360:22: -> ^( LOOKUP variable ( indexes )? )
                    	{
                    	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:360:25: ^( LOOKUP variable ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_variable.NextTree());
                    	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:360:43: ( indexes )?
                    	    if ( stream_indexes.HasNext() )
                    	    {
                    	        adaptor.AddChild(root_1, stream_indexes.NextTree());

                    	    }
                    	    stream_indexes.Reset();

                    	    adaptor.AddChild(root_0, root_1);
                    	    }

                    	}

                    	retval.Tree = root_0;retval.Tree = root_0;}
                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 31, lookup_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "lookup"

    public class instantiateClass_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "instantiateClass"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:367:1: instantiateClass : 'new' ( Identifier '(' ( expressionList )? ')' -> ^( CLASS Identifier ( expressionList )? ) ) ;
    public SGLParser.instantiateClass_return instantiateClass() // throws RecognitionException [1]
    {   
        SGLParser.instantiateClass_return retval = new SGLParser.instantiateClass_return();
        retval.Start = input.LT(1);
        int instantiateClass_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal130 = null;
        IToken Identifier131 = null;
        IToken char_literal132 = null;
        IToken char_literal134 = null;
        SGLParser.expressionList_return expressionList133 = default(SGLParser.expressionList_return);


        object string_literal130_tree=null;
        object Identifier131_tree=null;
        object char_literal132_tree=null;
        object char_literal134_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleSubtreeStream stream_expressionList = new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:368:2: ( 'new' ( Identifier '(' ( expressionList )? ')' -> ^( CLASS Identifier ( expressionList )? ) ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:368:4: 'new' ( Identifier '(' ( expressionList )? ')' -> ^( CLASS Identifier ( expressionList )? ) )
            {
            	string_literal130=(IToken)Match(input,81,FOLLOW_81_in_instantiateClass1563); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_81.Add(string_literal130);

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:369:2: ( Identifier '(' ( expressionList )? ')' -> ^( CLASS Identifier ( expressionList )? ) )
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:369:4: Identifier '(' ( expressionList )? ')'
            	{
            		Identifier131=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_instantiateClass1569); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier131);

            		char_literal132=(IToken)Match(input,59,FOLLOW_59_in_instantiateClass1571); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_59.Add(char_literal132);

            		// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:369:19: ( expressionList )?
            		int alt39 = 2;
            		int LA39_0 = input.LA(1);

            		if ( ((LA39_0 >= Identifier && LA39_0 <= Null) || LA39_0 == 59 || LA39_0 == 73 || LA39_0 == 78 || LA39_0 == 81) )
            		{
            		    alt39 = 1;
            		}
            		switch (alt39) 
            		{
            		    case 1 :
            		        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            		        {
            		        	PushFollow(FOLLOW_expressionList_in_instantiateClass1573);
            		        	expressionList133 = expressionList();
            		        	state.followingStackPointer--;
            		        	if (state.failed) return retval;
            		        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList133.Tree);

            		        }
            		        break;

            		}

            		char_literal134=(IToken)Match(input,60,FOLLOW_60_in_instantiateClass1576); if (state.failed) return retval; 
            		if ( (state.backtracking==0) ) stream_60.Add(char_literal134);



            		// AST REWRITE
            		// elements:          Identifier, expressionList
            		// token labels:      
            		// rule labels:       retval
            		// token list labels: 
            		// rule list labels:  
            		// wildcard labels: 
            		if ( (state.backtracking==0) ) {
            		retval.Tree = root_0;
            		RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            		root_0 = (object)adaptor.GetNilNode();
            		// 369:39: -> ^( CLASS Identifier ( expressionList )? )
            		{
            		    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:369:42: ^( CLASS Identifier ( expressionList )? )
            		    {
            		    object root_1 = (object)adaptor.GetNilNode();
            		    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CLASS, "CLASS"), root_1);

            		    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            		    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:369:61: ( expressionList )?
            		    if ( stream_expressionList.HasNext() )
            		    {
            		        adaptor.AddChild(root_1, stream_expressionList.NextTree());

            		    }
            		    stream_expressionList.Reset();

            		    adaptor.AddChild(root_0, root_1);
            		    }

            		}

            		retval.Tree = root_0;retval.Tree = root_0;}
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 32, instantiateClass_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "instantiateClass"

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:386:1: expressionList : expression ( ',' expression )* -> ^( EXP_LIST ( expression )+ ) ;
    public SGLParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.Start = input.LT(1);
        int expressionList_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal136 = null;
        SGLParser.expression_return expression135 = default(SGLParser.expression_return);

        SGLParser.expression_return expression137 = default(SGLParser.expression_return);


        object char_literal136_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:387:3: ( expression ( ',' expression )* -> ^( EXP_LIST ( expression )+ ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:387:7: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList1618);
            	expression135 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression135.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:387:18: ( ',' expression )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( (LA40_0 == 53) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:387:19: ',' expression
            			    {
            			    	char_literal136=(IToken)Match(input,53,FOLLOW_53_in_expressionList1621); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_53.Add(char_literal136);

            			    	PushFollow(FOLLOW_expression_in_expressionList1623);
            			    	expression137 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression137.Tree);

            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements



            	// AST REWRITE
            	// elements:          expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 387:36: -> ^( EXP_LIST ( expression )+ )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:387:39: ^( EXP_LIST ( expression )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXP_LIST, "EXP_LIST"), root_1);

            	    if ( !(stream_expression.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_expression.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expression.NextTree());

            	    }
            	    stream_expression.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 33, expressionList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "expressionList"

    public class variableList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "variableList"
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:391:1: variableList : variable ( ',' variable )* -> ^( VAR_LIST ( variable )+ ) ;
    public SGLParser.variableList_return variableList() // throws RecognitionException [1]
    {   
        SGLParser.variableList_return retval = new SGLParser.variableList_return();
        retval.Start = input.LT(1);
        int variableList_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal139 = null;
        SGLParser.variable_return variable138 = default(SGLParser.variable_return);

        SGLParser.variable_return variable140 = default(SGLParser.variable_return);


        object char_literal139_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:392:3: ( variable ( ',' variable )* -> ^( VAR_LIST ( variable )+ ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:392:5: variable ( ',' variable )*
            {
            	PushFollow(FOLLOW_variable_in_variableList1651);
            	variable138 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable138.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:392:14: ( ',' variable )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( (LA41_0 == 53) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:392:15: ',' variable
            			    {
            			    	char_literal139=(IToken)Match(input,53,FOLLOW_53_in_variableList1654); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_53.Add(char_literal139);

            			    	PushFollow(FOLLOW_variable_in_variableList1656);
            			    	variable140 = variable();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_variable.Add(variable140.Tree);

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements



            	// AST REWRITE
            	// elements:          variable
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 392:30: -> ^( VAR_LIST ( variable )+ )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:392:33: ^( VAR_LIST ( variable )+ )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VAR_LIST, "VAR_LIST"), root_1);

            	    if ( !(stream_variable.HasNext()) ) {
            	        throw new RewriteEarlyExitException();
            	    }
            	    while ( stream_variable.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_variable.NextTree());

            	    }
            	    stream_variable.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 34, variableList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "variableList"

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:395:1: methodCall : Identifier '(' ( expressionList )? ')' -> ^( FUNC_CALL Identifier ( expressionList )? ) ;
    public SGLParser.methodCall_return methodCall() // throws RecognitionException [1]
    {   
        SGLParser.methodCall_return retval = new SGLParser.methodCall_return();
        retval.Start = input.LT(1);
        int methodCall_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier141 = null;
        IToken char_literal142 = null;
        IToken char_literal144 = null;
        SGLParser.expressionList_return expressionList143 = default(SGLParser.expressionList_return);


        object Identifier141_tree=null;
        object char_literal142_tree=null;
        object char_literal144_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleSubtreeStream stream_expressionList = new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:396:2: ( Identifier '(' ( expressionList )? ')' -> ^( FUNC_CALL Identifier ( expressionList )? ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:396:4: Identifier '(' ( expressionList )? ')'
            {
            	Identifier141=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodCall1679); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier141);

            	char_literal142=(IToken)Match(input,59,FOLLOW_59_in_methodCall1681); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(char_literal142);

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:396:19: ( expressionList )?
            	int alt42 = 2;
            	int LA42_0 = input.LA(1);

            	if ( ((LA42_0 >= Identifier && LA42_0 <= Null) || LA42_0 == 59 || LA42_0 == 73 || LA42_0 == 78 || LA42_0 == 81) )
            	{
            	    alt42 = 1;
            	}
            	switch (alt42) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_methodCall1683);
            	        	expressionList143 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList143.Tree);

            	        }
            	        break;

            	}

            	char_literal144=(IToken)Match(input,60,FOLLOW_60_in_methodCall1686); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_60.Add(char_literal144);



            	// AST REWRITE
            	// elements:          Identifier, expressionList
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 396:39: -> ^( FUNC_CALL Identifier ( expressionList )? )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:396:42: ^( FUNC_CALL Identifier ( expressionList )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:396:65: ( expressionList )?
            	    if ( stream_expressionList.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_expressionList.NextTree());

            	    }
            	    stream_expressionList.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 35, methodCall_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "methodCall"

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:401:1: breakStat : 'break' -> BREAK ;
    public SGLParser.breakStat_return breakStat() // throws RecognitionException [1]
    {   
        SGLParser.breakStat_return retval = new SGLParser.breakStat_return();
        retval.Start = input.LT(1);
        int breakStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal145 = null;

        object string_literal145_tree=null;
        RewriteRuleTokenStream stream_82 = new RewriteRuleTokenStream(adaptor,"token 82");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:402:2: ( 'break' -> BREAK )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:402:4: 'break'
            {
            	string_literal145=(IToken)Match(input,82,FOLLOW_82_in_breakStat1713); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_82.Add(string_literal145);



            	// AST REWRITE
            	// elements:          
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 402:12: -> BREAK
            	{
            	    adaptor.AddChild(root_0, (object)adaptor.Create(BREAK, "BREAK"));

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 36, breakStat_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:405:1: returnStat : 'return' expression -> ^( RETURN expression ) ;
    public SGLParser.returnStat_return returnStat() // throws RecognitionException [1]
    {   
        SGLParser.returnStat_return retval = new SGLParser.returnStat_return();
        retval.Start = input.LT(1);
        int returnStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal146 = null;
        SGLParser.expression_return expression147 = default(SGLParser.expression_return);


        object string_literal146_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:406:2: ( 'return' expression -> ^( RETURN expression ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:406:4: 'return' expression
            {
            	string_literal146=(IToken)Match(input,83,FOLLOW_83_in_returnStat1728); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(string_literal146);

            	PushFollow(FOLLOW_expression_in_returnStat1730);
            	expression147 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression147.Tree);


            	// AST REWRITE
            	// elements:          expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 406:24: -> ^( RETURN expression )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:406:27: ^( RETURN expression )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(RETURN, "RETURN"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 37, returnStat_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "returnStat"

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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:410:1: whileLoop : 'while' expression commonBlock -> ^( 'while' expression commonBlock ) ;
    public SGLParser.whileLoop_return whileLoop() // throws RecognitionException [1]
    {   
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.Start = input.LT(1);
        int whileLoop_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal148 = null;
        SGLParser.expression_return expression149 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock150 = default(SGLParser.commonBlock_return);


        object string_literal148_tree=null;
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:411:2: ( 'while' expression commonBlock -> ^( 'while' expression commonBlock ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:411:4: 'while' expression commonBlock
            {
            	string_literal148=(IToken)Match(input,84,FOLLOW_84_in_whileLoop1753); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_84.Add(string_literal148);

            	PushFollow(FOLLOW_expression_in_whileLoop1755);
            	expression149 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression149.Tree);
            	PushFollow(FOLLOW_commonBlock_in_whileLoop1757);
            	commonBlock150 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock150.Tree);


            	// AST REWRITE
            	// elements:          commonBlock, 84, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 411:35: -> ^( 'while' expression commonBlock )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:411:38: ^( 'while' expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_84.NextNode(), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    adaptor.AddChild(root_1, stream_commonBlock.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 38, whileLoop_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:414:1: forLoop : 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) ;
    public SGLParser.forLoop_return forLoop() // throws RecognitionException [1]
    {   
        SGLParser.forLoop_return retval = new SGLParser.forLoop_return();
        retval.Start = input.LT(1);
        int forLoop_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal151 = null;
        IToken char_literal152 = null;
        IToken char_literal153 = null;
        IToken char_literal154 = null;
        IToken char_literal155 = null;
        SGLParser.oneLineStatement_return dec = default(SGLParser.oneLineStatement_return);

        SGLParser.expression_return cond = default(SGLParser.expression_return);

        SGLParser.oneLineStatement_return iter = default(SGLParser.oneLineStatement_return);

        SGLParser.commonBlock_return commonBlock156 = default(SGLParser.commonBlock_return);


        object string_literal151_tree=null;
        object char_literal152_tree=null;
        object char_literal153_tree=null;
        object char_literal154_tree=null;
        object char_literal155_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        RewriteRuleSubtreeStream stream_oneLineStatement = new RewriteRuleSubtreeStream(adaptor,"rule oneLineStatement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:415:2: ( 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:415:4: 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock
            {
            	string_literal151=(IToken)Match(input,85,FOLLOW_85_in_forLoop1779); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal151);

            	char_literal152=(IToken)Match(input,59,FOLLOW_59_in_forLoop1781); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(char_literal152);

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:415:17: (dec= oneLineStatement )?
            	int alt43 = 2;
            	int LA43_0 = input.LA(1);

            	if ( (LA43_0 == Identifier || LA43_0 == VarStartInit) )
            	{
            	    alt43 = 1;
            	}
            	switch (alt43) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: dec= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop1785);
            	        	dec = oneLineStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_oneLineStatement.Add(dec.Tree);

            	        }
            	        break;

            	}

            	char_literal153=(IToken)Match(input,52,FOLLOW_52_in_forLoop1788); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal153);

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:415:44: (cond= expression )?
            	int alt44 = 2;
            	int LA44_0 = input.LA(1);

            	if ( ((LA44_0 >= Identifier && LA44_0 <= Null) || LA44_0 == 59 || LA44_0 == 73 || LA44_0 == 78 || LA44_0 == 81) )
            	{
            	    alt44 = 1;
            	}
            	switch (alt44) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: cond= expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forLoop1792);
            	        	cond = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(cond.Tree);

            	        }
            	        break;

            	}

            	char_literal154=(IToken)Match(input,52,FOLLOW_52_in_forLoop1795); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal154);

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:415:65: (iter= oneLineStatement )?
            	int alt45 = 2;
            	int LA45_0 = input.LA(1);

            	if ( (LA45_0 == Identifier || LA45_0 == VarStartInit) )
            	{
            	    alt45 = 1;
            	}
            	switch (alt45) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: iter= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop1799);
            	        	iter = oneLineStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_oneLineStatement.Add(iter.Tree);

            	        }
            	        break;

            	}

            	char_literal155=(IToken)Match(input,60,FOLLOW_60_in_forLoop1802); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_60.Add(char_literal155);

            	PushFollow(FOLLOW_commonBlock_in_forLoop1804);
            	commonBlock156 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock156.Tree);


            	// AST REWRITE
            	// elements:          cond, 85, dec, commonBlock, iter
            	// token labels:      
            	// rule labels:       retval, dec, iter, cond
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);
            	RewriteRuleSubtreeStream stream_dec = new RewriteRuleSubtreeStream(adaptor, "rule dec", dec!=null ? dec.Tree : null);
            	RewriteRuleSubtreeStream stream_iter = new RewriteRuleSubtreeStream(adaptor, "rule iter", iter!=null ? iter.Tree : null);
            	RewriteRuleSubtreeStream stream_cond = new RewriteRuleSubtreeStream(adaptor, "rule cond", cond!=null ? cond.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 416:2: -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:416:5: ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_85.NextNode(), root_1);

            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:416:13: ^( FORDEC ( $dec)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORDEC, "FORDEC"), root_2);

            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:416:22: ( $dec)?
            	    if ( stream_dec.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_dec.NextTree());

            	    }
            	    stream_dec.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:416:29: ^( FORCOND ( $cond)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORCOND, "FORCOND"), root_2);

            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:416:39: ( $cond)?
            	    if ( stream_cond.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_cond.NextTree());

            	    }
            	    stream_cond.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:416:47: ^( FORITER ( $iter)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORITER, "FORITER"), root_2);

            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:416:57: ( $iter)?
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

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 39, forLoop_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:419:1: ifStatement : ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) ;
    public SGLParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        SGLParser.ifStatement_return retval = new SGLParser.ifStatement_return();
        retval.Start = input.LT(1);
        int ifStatement_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.ifStat_return ifStat157 = default(SGLParser.ifStat_return);

        SGLParser.elseIfStat_return elseIfStat158 = default(SGLParser.elseIfStat_return);

        SGLParser.elseStat_return elseStat159 = default(SGLParser.elseStat_return);


        RewriteRuleSubtreeStream stream_elseIfStat = new RewriteRuleSubtreeStream(adaptor,"rule elseIfStat");
        RewriteRuleSubtreeStream stream_ifStat = new RewriteRuleSubtreeStream(adaptor,"rule ifStat");
        RewriteRuleSubtreeStream stream_elseStat = new RewriteRuleSubtreeStream(adaptor,"rule elseStat");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:420:2: ( ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:420:4: ifStat ( elseIfStat )* ( elseStat )?
            {
            	PushFollow(FOLLOW_ifStat_in_ifStatement1849);
            	ifStat157 = ifStat();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ifStat.Add(ifStat157.Tree);
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:420:11: ( elseIfStat )*
            	do 
            	{
            	    int alt46 = 2;
            	    int LA46_0 = input.LA(1);

            	    if ( (LA46_0 == 87) )
            	    {
            	        int LA46_1 = input.LA(2);

            	        if ( (LA46_1 == 86) )
            	        {
            	            alt46 = 1;
            	        }


            	    }


            	    switch (alt46) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: elseIfStat
            			    {
            			    	PushFollow(FOLLOW_elseIfStat_in_ifStatement1851);
            			    	elseIfStat158 = elseIfStat();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_elseIfStat.Add(elseIfStat158.Tree);

            			    }
            			    break;

            			default:
            			    goto loop46;
            	    }
            	} while (true);

            	loop46:
            		;	// Stops C# compiler whining that label 'loop46' has no statements

            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:420:23: ( elseStat )?
            	int alt47 = 2;
            	int LA47_0 = input.LA(1);

            	if ( (LA47_0 == 87) )
            	{
            	    alt47 = 1;
            	}
            	switch (alt47) 
            	{
            	    case 1 :
            	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: elseStat
            	        {
            	        	PushFollow(FOLLOW_elseStat_in_ifStatement1854);
            	        	elseStat159 = elseStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_elseStat.Add(elseStat159.Tree);

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
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 420:33: -> ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:420:36: ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF, "IF"), root_1);

            	    adaptor.AddChild(root_1, stream_ifStat.NextTree());
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:420:48: ( elseIfStat )*
            	    while ( stream_elseIfStat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_elseIfStat.NextTree());

            	    }
            	    stream_elseIfStat.Reset();
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:420:60: ( elseStat )?
            	    if ( stream_elseStat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_elseStat.NextTree());

            	    }
            	    stream_elseStat.Reset();

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 40, ifStatement_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:422:1: ifStat : 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.ifStat_return ifStat() // throws RecognitionException [1]
    {   
        SGLParser.ifStat_return retval = new SGLParser.ifStat_return();
        retval.Start = input.LT(1);
        int ifStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal160 = null;
        SGLParser.expression_return expression161 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock162 = default(SGLParser.commonBlock_return);


        object string_literal160_tree=null;
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:423:2: ( 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:423:4: 'if' expression commonBlock
            {
            	string_literal160=(IToken)Match(input,86,FOLLOW_86_in_ifStat1879); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(string_literal160);

            	PushFollow(FOLLOW_expression_in_ifStat1881);
            	expression161 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression161.Tree);
            	PushFollow(FOLLOW_commonBlock_in_ifStat1883);
            	commonBlock162 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock162.Tree);


            	// AST REWRITE
            	// elements:          commonBlock, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 423:32: -> ^( EXP expression commonBlock )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:423:35: ^( EXP expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXP, "EXP"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    adaptor.AddChild(root_1, stream_commonBlock.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 41, ifStat_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:426:1: elseIfStat : 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.elseIfStat_return elseIfStat() // throws RecognitionException [1]
    {   
        SGLParser.elseIfStat_return retval = new SGLParser.elseIfStat_return();
        retval.Start = input.LT(1);
        int elseIfStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal163 = null;
        IToken string_literal164 = null;
        SGLParser.expression_return expression165 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock166 = default(SGLParser.commonBlock_return);


        object string_literal163_tree=null;
        object string_literal164_tree=null;
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:427:2: ( 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:427:4: 'else' 'if' expression commonBlock
            {
            	string_literal163=(IToken)Match(input,87,FOLLOW_87_in_elseIfStat1904); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_87.Add(string_literal163);

            	string_literal164=(IToken)Match(input,86,FOLLOW_86_in_elseIfStat1906); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(string_literal164);

            	PushFollow(FOLLOW_expression_in_elseIfStat1908);
            	expression165 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression165.Tree);
            	PushFollow(FOLLOW_commonBlock_in_elseIfStat1910);
            	commonBlock166 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock166.Tree);


            	// AST REWRITE
            	// elements:          commonBlock, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 427:39: -> ^( EXP expression commonBlock )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:427:42: ^( EXP expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXP, "EXP"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    adaptor.AddChild(root_1, stream_commonBlock.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 42, elseIfStat_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:430:1: elseStat : 'else' commonBlock -> ^( EXP commonBlock ) ;
    public SGLParser.elseStat_return elseStat() // throws RecognitionException [1]
    {   
        SGLParser.elseStat_return retval = new SGLParser.elseStat_return();
        retval.Start = input.LT(1);
        int elseStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal167 = null;
        SGLParser.commonBlock_return commonBlock168 = default(SGLParser.commonBlock_return);


        object string_literal167_tree=null;
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:431:2: ( 'else' commonBlock -> ^( EXP commonBlock ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:431:4: 'else' commonBlock
            {
            	string_literal167=(IToken)Match(input,87,FOLLOW_87_in_elseStat1932); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_87.Add(string_literal167);

            	PushFollow(FOLLOW_commonBlock_in_elseStat1934);
            	commonBlock168 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock168.Tree);


            	// AST REWRITE
            	// elements:          commonBlock
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 431:23: -> ^( EXP commonBlock )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:431:26: ^( EXP commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(EXP, "EXP"), root_1);

            	    adaptor.AddChild(root_1, stream_commonBlock.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 43, elseStat_StartIndex); 
            }
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
    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:438:1: atStatement : 'at' expression commonBlock -> ^( AT expression commonBlock ) ;
    public SGLParser.atStatement_return atStatement() // throws RecognitionException [1]
    {   
        SGLParser.atStatement_return retval = new SGLParser.atStatement_return();
        retval.Start = input.LT(1);
        int atStatement_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal169 = null;
        SGLParser.expression_return expression170 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock171 = default(SGLParser.commonBlock_return);


        object string_literal169_tree=null;
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:439:2: ( 'at' expression commonBlock -> ^( AT expression commonBlock ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:439:4: 'at' expression commonBlock
            {
            	string_literal169=(IToken)Match(input,88,FOLLOW_88_in_atStatement1959); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_88.Add(string_literal169);

            	PushFollow(FOLLOW_expression_in_atStatement1961);
            	expression170 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression170.Tree);
            	PushFollow(FOLLOW_commonBlock_in_atStatement1963);
            	commonBlock171 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock171.Tree);


            	// AST REWRITE
            	// elements:          commonBlock, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 439:32: -> ^( AT expression commonBlock )
            	{
            	    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:439:35: ^( AT expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(AT, "AT"), root_1);

            	    adaptor.AddChild(root_1, stream_expression.NextTree());
            	    adaptor.AddChild(root_1, stream_commonBlock.NextTree());

            	    adaptor.AddChild(root_0, root_1);
            	    }

            	}

            	retval.Tree = root_0;retval.Tree = root_0;}
            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (object)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
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
            if ( state.backtracking > 0 ) 
            {
            	Memoize(input, 44, atStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "atStatement"

    // $ANTLR start "synpred10_SGL"
    public void synpred10_SGL_fragment() {
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:201:5: ( unaryExpression )
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:201:5: unaryExpression
        {
        	PushFollow(FOLLOW_unaryExpression_in_synpred10_SGL433);
        	unaryExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred10_SGL"

    // $ANTLR start "synpred11_SGL"
    public void synpred11_SGL_fragment() {
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:202:4: ( objectMethodCall )
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:202:4: objectMethodCall
        {
        	PushFollow(FOLLOW_objectMethodCall_in_synpred11_SGL439);
        	objectMethodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred11_SGL"

    // $ANTLR start "synpred12_SGL"
    public void synpred12_SGL_fragment() {
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:203:4: ( methodCall )
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:203:4: methodCall
        {
        	PushFollow(FOLLOW_methodCall_in_synpred12_SGL444);
        	methodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred12_SGL"

    // $ANTLR start "synpred14_SGL"
    public void synpred14_SGL_fragment() {
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:205:4: ( assignment )
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:205:4: assignment
        {
        	PushFollow(FOLLOW_assignment_in_synpred14_SGL456);
        	assignment();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred14_SGL"

    // $ANTLR start "synpred60_SGL"
    public void synpred60_SGL_fragment() {
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:358:4: ( objectMethodCall ( indexes )? )
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:358:4: objectMethodCall ( indexes )?
        {
        	PushFollow(FOLLOW_objectMethodCall_in_synpred60_SGL1478);
        	objectMethodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:358:21: ( indexes )?
        	int alt49 = 2;
        	int LA49_0 = input.LA(1);

        	if ( (LA49_0 == 56) )
        	{
        	    alt49 = 1;
        	}
        	switch (alt49) 
        	{
        	    case 1 :
        	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
        	        {
        	        	PushFollow(FOLLOW_indexes_in_synpred60_SGL1480);
        	        	indexes();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred60_SGL"

    // $ANTLR start "synpred62_SGL"
    public void synpred62_SGL_fragment() {
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:359:4: ( methodCall ( indexes )? )
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:359:4: methodCall ( indexes )?
        {
        	PushFollow(FOLLOW_methodCall_in_synpred62_SGL1497);
        	methodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:359:15: ( indexes )?
        	int alt50 = 2;
        	int LA50_0 = input.LA(1);

        	if ( (LA50_0 == 56) )
        	{
        	    alt50 = 1;
        	}
        	switch (alt50) 
        	{
        	    case 1 :
        	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
        	        {
        	        	PushFollow(FOLLOW_indexes_in_synpred62_SGL1499);
        	        	indexes();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred62_SGL"

    // Delegated rules

   	public bool synpred10_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred10_SGL_fragment(); // can never throw exception
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
   	public bool synpred12_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred12_SGL_fragment(); // can never throw exception
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
   	public bool synpred11_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred11_SGL_fragment(); // can never throw exception
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
   	public bool synpred60_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred60_SGL_fragment(); // can never throw exception
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
   	public bool synpred62_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred62_SGL_fragment(); // can never throw exception
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

 

    public static readonly BitSet FOLLOW_mainBlock_in_main242 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mainStatement_in_mainBlock262 = new BitSet(new ulong[]{0x2080040080000002UL,0x00000000017C0000UL});
    public static readonly BitSet FOLLOW_functionDef_in_mainBlock266 = new BitSet(new ulong[]{0x2080040080000002UL,0x00000000017C0000UL});
    public static readonly BitSet FOLLOW_statement_in_block303 = new BitSet(new ulong[]{0x0000040080000002UL,0x00000000017C0000UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_singleBlock328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_singleBlock_in_commonBlock351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_commonBlock356 = new BitSet(new ulong[]{0x0008040080000000UL,0x00000000017C0000UL});
    public static readonly BitSet FOLLOW_block_in_commonBlock359 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_commonBlock361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_mainStatement378 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_globalVarDefList_in_mainStatement383 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_mainStatement385 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_statement400 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement405 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atStatement_in_statement410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement415 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forLoop_in_statement420 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_semicolonStatement433 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_semicolonStatement439 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_methodCall_in_semicolonStatement444 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_varDefList_in_semicolonStatement450 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_assignment_in_semicolonStatement456 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_breakStat_in_semicolonStatement463 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_returnStat_in_semicolonStatement468 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_semicolonStatement473 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_varDefList_in_oneLineStatement486 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_oneLineStatement491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VarStartInit_in_varDefList507 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_varDef_in_varDefList510 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_varDefList517 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_varDef_in_varDefList520 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_varDef536 = new BitSet(new ulong[]{0x0040000000000002UL});
    public static readonly BitSet FOLLOW_54_in_varDef539 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_varDef541 = new BitSet(new ulong[]{0x0040000000000002UL});
    public static readonly BitSet FOLLOW_55_in_globalVarDefList574 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_VarStartInit_in_globalVarDefList576 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_variable_in_globalVarDefList578 = new BitSet(new ulong[]{0x0060000000000002UL});
    public static readonly BitSet FOLLOW_54_in_globalVarDefList581 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_globalVarDefList583 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_globalVarDefList588 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_variable_in_globalVarDefList590 = new BitSet(new ulong[]{0x0060000000000002UL});
    public static readonly BitSet FOLLOW_54_in_globalVarDefList593 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_globalVarDefList595 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment636 = new BitSet(new ulong[]{0x0140000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_assignment638 = new BitSet(new ulong[]{0x0040000000000002UL});
    public static readonly BitSet FOLLOW_54_in_assignment642 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_assignment644 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_indexes679 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_indexes681 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_indexes683 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_objectMethodCall710 = new BitSet(new ulong[]{0x0500000000000000UL});
    public static readonly BitSet FOLLOW_indexes_in_objectMethodCall712 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_objectMethodCall715 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethodCall717 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_objectMethodCall719 = new BitSet(new ulong[]{0x180003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expressionList_in_objectMethodCall721 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_objectMethodCall724 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringAtom_in_stringAtom781 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_functionDef802 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_functionDef804 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_functionDef806 = new BitSet(new ulong[]{0x1000000080000000UL});
    public static readonly BitSet FOLLOW_variableList_in_functionDef808 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_functionDef811 = new BitSet(new ulong[]{0x0004040080000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_functionDef813 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_instantiateClass_in_expression850 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression860 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression886 = new BitSet(new ulong[]{0x4000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_conditionalExpression890 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression893 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_63_in_conditionalExpression895 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression898 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression941 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_conditionalOrExpression945 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression948 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression979 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_conditionalAndExpression983 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression986 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1013 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_66_in_equalityExpression1018 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_67_in_equalityExpression1023 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1027 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1058 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000000F0UL});
    public static readonly BitSet FOLLOW_68_in_relationalExpression1062 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_69_in_relationalExpression1065 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_70_in_relationalExpression1068 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_71_in_relationalExpression1071 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1075 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000000F0UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1113 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000300UL});
    public static readonly BitSet FOLLOW_72_in_additiveExpression1117 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_73_in_additiveExpression1120 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1124 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000300UL});
    public static readonly BitSet FOLLOW_powExpression_in_multiplicativeExpression1158 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000001C00UL});
    public static readonly BitSet FOLLOW_74_in_multiplicativeExpression1162 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_75_in_multiplicativeExpression1165 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_76_in_multiplicativeExpression1168 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_powExpression_in_multiplicativeExpression1172 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000001C00UL});
    public static readonly BitSet FOLLOW_negateExpression_in_powExpression1192 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_77_in_powExpression1195 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_negateExpression_in_powExpression1198 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_73_in_negateExpression1216 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_negateExpression1231 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1233 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_negateExpression1246 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1251 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_unaryExpression1269 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000018000UL});
    public static readonly BitSet FOLLOW_79_in_unaryExpression1272 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_unaryExpression1285 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_mathAtom1319 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_mathAtom1322 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_mathAtom1324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntAtom_in_mathAtom1336 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_mathAtom1351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_mathAtom1367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stringAtom_in_mathAtom1378 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LayerAtom_in_mathAtom1389 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OriginAtom_in_mathAtom1400 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LoopTypeAtom_in_mathAtom1411 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LoopTriggerAtom_in_mathAtom1424 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ColorAtom_in_mathAtom1434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Null_in_mathAtom1445 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookup_in_mathAtom1459 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_lookup1478 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1480 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_lookup1497 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1499 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_lookup1517 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1519 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_instantiateClass1563 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_instantiateClass1569 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_instantiateClass1571 = new BitSet(new ulong[]{0x180003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1573 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_instantiateClass1576 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1618 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_expressionList1621 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1623 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_variableList1651 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_variableList1654 = new BitSet(new ulong[]{0x0000000080000000UL});
    public static readonly BitSet FOLLOW_variable_in_variableList1656 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodCall1679 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_methodCall1681 = new BitSet(new ulong[]{0x180003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expressionList_in_methodCall1683 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_methodCall1686 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_breakStat1713 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_returnStat1728 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_returnStat1730 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_whileLoop1753 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop1755 = new BitSet(new ulong[]{0x0004040080000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_whileLoop1757 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_forLoop1779 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_forLoop1781 = new BitSet(new ulong[]{0x0010040080000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop1785 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_forLoop1788 = new BitSet(new ulong[]{0x081003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop1792 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_forLoop1795 = new BitSet(new ulong[]{0x1000040080000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop1799 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_forLoop1802 = new BitSet(new ulong[]{0x0004040080000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_forLoop1804 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStat_in_ifStatement1849 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_elseIfStat_in_ifStatement1851 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_elseStat_in_ifStatement1854 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_86_in_ifStat1879 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_ifStat1881 = new BitSet(new ulong[]{0x0004040080000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_ifStat1883 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_87_in_elseIfStat1904 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_86_in_elseIfStat1906 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_elseIfStat1908 = new BitSet(new ulong[]{0x0004040080000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseIfStat1910 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_87_in_elseStat1932 = new BitSet(new ulong[]{0x0004040080000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseStat1934 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_88_in_atStatement1959 = new BitSet(new ulong[]{0x080003FF80000000UL,0x0000000000024200UL});
    public static readonly BitSet FOLLOW_expression_in_atStatement1961 = new BitSet(new ulong[]{0x0004040080000000UL,0x00000000000C0000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_atStatement1963 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_synpred10_SGL433 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_synpred11_SGL439 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_synpred12_SGL444 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignment_in_synpred14_SGL456 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_synpred60_SGL1478 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_synpred60_SGL1480 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_synpred62_SGL1497 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_synpred62_SGL1499 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}