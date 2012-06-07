// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\sgl4c#\\NewSGLGramma\\SGL.g 2012-06-07 20:44:53

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
public partial class SGLParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"BLOCK", 
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
		"ColorAtom", 
		"Null", 
		"VarStartInit", 
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
		"'global'", 
		"'='", 
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
    public const int CLASS = 28;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int VAR_LIST = 16;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int IntAtom = 31;
    public const int LoopTypeAtom = 36;
    public const int EXP_LIST = 15;
    public const int UTF8Letter = 42;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int HexDigit = 40;
    public const int BREAK = 19;
    public const int Identifier = 29;
    public const int IF = 22;
    public const int FUNC_CALL = 17;
    public const int AT = 21;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int Comment = 44;
    public const int EXP = 23;
    public const int OBJ_FUNC_CALL = 18;
    public const int FORITER = 26;
    public const int T__59 = 59;
    public const int INT_NEGATE = 7;
    public const int UTF8Digit = 43;
    public const int RETURN = 20;
    public const int WhiteSpace = 45;
    public const int T__50 = 50;
    public const int VARDEC = 10;
    public const int Null = 38;
    public const int OriginAtom = 35;
    public const int LayerAtom = 34;
    public const int GLOBAL_ASSIGN = 27;
    public const int T__46 = 46;
    public const int T__80 = 80;
    public const int T__47 = 47;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int FORDEC = 24;
    public const int StringAtom = 30;
    public const int INDEXES = 12;
    public const int ColorAtom = 37;
    public const int LIST = 14;
    public const int T__84 = 84;
    public const int BooleanAtom = 33;
    public const int BOOL_NEGATE = 8;
    public const int LOOKUP = 13;
    public const int FORCOND = 25;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int VARIABLE = 11;
    public const int T__70 = 70;
    public const int BLOCK = 4;
    public const int VarStartInit = 39;
    public const int ASSIGN = 5;
    public const int FloatAtom = 32;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int VARINC = 9;
    public const int T__74 = 74;
    public const int EscapeSequence = 41;
    public const int T__73 = 73;
    public const int T__79 = 79;
    public const int STRING = 6;
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
            this.state.ruleMemo = new Hashtable[113+1];
             
             
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
		get { return "D:\\sgl4c#\\NewSGLGramma\\SGL.g"; }
    }



            //public Dictionary<String,Method> methods = new Dictionary<String,Method>();
            //public Dictionary<String,ObjectMethod> objectMethods = new Dictionary<String,ObjectMethod>();
    /*
        	private void RegisterMethod(String name, Object idList, Object block) {
                    // 'idList' is possibly null!  Create an empty tree in that case.  
                    CommonTree idListTree = idList == null ? new CommonTree() : (CommonTree)idList;
    				List<String> methodParameters = ParametersToList(idListTree);

                    // 'block' is never null 
                    CommonTree blockTree = (CommonTree)block;
                    CommonTreeNodeStream methodNodes = new CommonTreeNodeStream(block);

                    // The method name with the exact same type of parameters after it, is the unique key 
                    //String key = id + " " + idListTree.ChildCount;

                    Console.WriteLine("method found: " + name);
                    
                    //idListTree.GetChild(1).ChildCount;
                    
                    // (String, List<String>, CommonTreeNodeStream)
                    GlobalMemory.Instance.RegisterMethod(name, new UserMethod(name, methodParameters, methodNodes));
                    //methods.Add(id, new Method(id, idListTree, blockTree));
            }*/
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
            
            	
    		public override void EmitErrorMessage(string msg)
            {
            	//throw new SGLCompilerException(-1, "Antlr.Parser", msg);
            	throw new Exception(msg);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:151:1: main : mainBlock ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:152:5: ( mainBlock )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:152:7: mainBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mainBlock_in_main234);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:159:1: mainBlock : ( mainStatement | methodDef )* -> ^( BLOCK ( mainStatement )* ) ;
    public SGLParser.mainBlock_return mainBlock() // throws RecognitionException [1]
    {   
        SGLParser.mainBlock_return retval = new SGLParser.mainBlock_return();
        retval.Start = input.LT(1);
        int mainBlock_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.mainStatement_return mainStatement2 = default(SGLParser.mainStatement_return);

        SGLParser.methodDef_return methodDef3 = default(SGLParser.methodDef_return);


        RewriteRuleSubtreeStream stream_methodDef = new RewriteRuleSubtreeStream(adaptor,"rule methodDef");
        RewriteRuleSubtreeStream stream_mainStatement = new RewriteRuleSubtreeStream(adaptor,"rule mainStatement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:161:2: ( ( mainStatement | methodDef )* -> ^( BLOCK ( mainStatement )* ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:161:4: ( mainStatement | methodDef )*
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:161:4: ( mainStatement | methodDef )*
            	do 
            	{
            	    int alt1 = 3;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == Identifier || LA1_0 == VarStartInit || LA1_0 == 50 || (LA1_0 >= 78 && LA1_0 <= 82) || LA1_0 == 84) )
            	    {
            	        alt1 = 1;
            	    }
            	    else if ( (LA1_0 == 57) )
            	    {
            	        alt1 = 2;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:161:5: mainStatement
            			    {
            			    	PushFollow(FOLLOW_mainStatement_in_mainBlock254);
            			    	mainStatement2 = mainStatement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_mainStatement.Add(mainStatement2.Tree);

            			    }
            			    break;
            			case 2 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:161:21: methodDef
            			    {
            			    	PushFollow(FOLLOW_methodDef_in_mainBlock258);
            			    	methodDef3 = methodDef();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_methodDef.Add(methodDef3.Tree);

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
            	// 162:8: -> ^( BLOCK ( mainStatement )* )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:162:11: ^( BLOCK ( mainStatement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:162:20: ( mainStatement )*
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:166:1: block : ( statement )* -> ^( BLOCK ( statement )* ) ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:167:2: ( ( statement )* -> ^( BLOCK ( statement )* ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:167:4: ( statement )*
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:167:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == Identifier || LA2_0 == VarStartInit || (LA2_0 >= 78 && LA2_0 <= 82) || LA2_0 == 84) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block295);
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
            	// 168:3: -> ^( BLOCK ( statement )* )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:168:6: ^( BLOCK ( statement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:168:14: ( statement )*
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:172:1: singleBlock : semicolonStatement -> ^( BLOCK semicolonStatement ) ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:173:2: ( semicolonStatement -> ^( BLOCK semicolonStatement ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:173:4: semicolonStatement
            {
            	PushFollow(FOLLOW_semicolonStatement_in_singleBlock320);
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
            	// 174:3: -> ^( BLOCK semicolonStatement )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:174:6: ^( BLOCK semicolonStatement )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:178:1: commonBlock : ( singleBlock | '{' block '}' );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:179:2: ( singleBlock | '{' block '}' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == Identifier || LA3_0 == VarStartInit || (LA3_0 >= 78 && LA3_0 <= 79)) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == 46) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:179:4: singleBlock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_singleBlock_in_commonBlock343);
                    	singleBlock6 = singleBlock();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, singleBlock6.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:180:4: '{' block '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal7=(IToken)Match(input,46,FOLLOW_46_in_commonBlock348); if (state.failed) return retval;
                    	PushFollow(FOLLOW_block_in_commonBlock351);
                    	block8 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block8.Tree);
                    	char_literal9=(IToken)Match(input,47,FOLLOW_47_in_commonBlock353); if (state.failed) return retval;

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:185:1: mainStatement : ( statement | globalAssignmentList ';' );
    public SGLParser.mainStatement_return mainStatement() // throws RecognitionException [1]
    {   
        SGLParser.mainStatement_return retval = new SGLParser.mainStatement_return();
        retval.Start = input.LT(1);
        int mainStatement_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal12 = null;
        SGLParser.statement_return statement10 = default(SGLParser.statement_return);

        SGLParser.globalAssignmentList_return globalAssignmentList11 = default(SGLParser.globalAssignmentList_return);


        object char_literal12_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:186:2: ( statement | globalAssignmentList ';' )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == Identifier || LA4_0 == VarStartInit || (LA4_0 >= 78 && LA4_0 <= 82) || LA4_0 == 84) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == 50) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:186:4: statement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_mainStatement370);
                    	statement10 = statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement10.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:187:4: globalAssignmentList ';'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_globalAssignmentList_in_mainStatement375);
                    	globalAssignmentList11 = globalAssignmentList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, globalAssignmentList11.Tree);
                    	char_literal12=(IToken)Match(input,48,FOLLOW_48_in_mainStatement377); if (state.failed) return retval;

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:190:1: statement : ( semicolonStatement | ifStatement | atStatement | whileLoop | forLoop );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:191:2: ( semicolonStatement | ifStatement | atStatement | whileLoop | forLoop )
            int alt5 = 5;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            case VarStartInit:
            case 78:
            case 79:
            	{
                alt5 = 1;
                }
                break;
            case 82:
            	{
                alt5 = 2;
                }
                break;
            case 84:
            	{
                alt5 = 3;
                }
                break;
            case 80:
            	{
                alt5 = 4;
                }
                break;
            case 81:
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:191:4: semicolonStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_semicolonStatement_in_statement392);
                    	semicolonStatement13 = semicolonStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, semicolonStatement13.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:192:4: ifStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statement397);
                    	ifStatement14 = ifStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifStatement14.Tree);

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:193:4: atStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_atStatement_in_statement402);
                    	atStatement15 = atStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, atStatement15.Tree);

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:194:4: whileLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileLoop_in_statement407);
                    	whileLoop16 = whileLoop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileLoop16.Tree);

                    }
                    break;
                case 5 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:195:4: forLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forLoop_in_statement412);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:198:1: semicolonStatement : ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat ) ';' ;
    public SGLParser.semicolonStatement_return semicolonStatement() // throws RecognitionException [1]
    {   
        SGLParser.semicolonStatement_return retval = new SGLParser.semicolonStatement_return();
        retval.Start = input.LT(1);
        int semicolonStatement_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal24 = null;
        SGLParser.objectMethodCall_return objectMethodCall18 = default(SGLParser.objectMethodCall_return);

        SGLParser.methodCall_return methodCall19 = default(SGLParser.methodCall_return);

        SGLParser.assignmentList_return assignmentList20 = default(SGLParser.assignmentList_return);

        SGLParser.unaryExpression_return unaryExpression21 = default(SGLParser.unaryExpression_return);

        SGLParser.breakStat_return breakStat22 = default(SGLParser.breakStat_return);

        SGLParser.returnStat_return returnStat23 = default(SGLParser.returnStat_return);


        object char_literal24_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:199:2: ( ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat ) ';' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:199:4: ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat ) ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:199:4: ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat )
            	int alt6 = 6;
            	switch ( input.LA(1) ) 
            	{
            	case Identifier:
            		{
            	    switch ( input.LA(2) ) 
            	    {
            	    case 55:
            	    	{
            	        alt6 = 2;
            	        }
            	        break;
            	    case 75:
            	    case 76:
            	    	{
            	        alt6 = 4;
            	        }
            	        break;
            	    case 52:
            	    case 54:
            	    	{
            	        alt6 = 1;
            	        }
            	        break;
            	    	default:
            	    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    	    NoViableAltException nvae_d6s1 =
            	    	        new NoViableAltException("", 6, 1, input);

            	    	    throw nvae_d6s1;
            	    }

            	    }
            	    break;
            	case VarStartInit:
            		{
            	    alt6 = 3;
            	    }
            	    break;
            	case 78:
            		{
            	    alt6 = 5;
            	    }
            	    break;
            	case 79:
            		{
            	    alt6 = 6;
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:199:5: objectMethodCall
            	        {
            	        	PushFollow(FOLLOW_objectMethodCall_in_semicolonStatement425);
            	        	objectMethodCall18 = objectMethodCall();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectMethodCall18.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:200:4: methodCall
            	        {
            	        	PushFollow(FOLLOW_methodCall_in_semicolonStatement430);
            	        	methodCall19 = methodCall();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodCall19.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:201:4: assignmentList
            	        {
            	        	PushFollow(FOLLOW_assignmentList_in_semicolonStatement436);
            	        	assignmentList20 = assignmentList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentList20.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:202:4: unaryExpression
            	        {
            	        	PushFollow(FOLLOW_unaryExpression_in_semicolonStatement442);
            	        	unaryExpression21 = unaryExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression21.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:203:4: breakStat
            	        {
            	        	PushFollow(FOLLOW_breakStat_in_semicolonStatement448);
            	        	breakStat22 = breakStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, breakStat22.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:204:4: returnStat
            	        {
            	        	PushFollow(FOLLOW_returnStat_in_semicolonStatement453);
            	        	returnStat23 = returnStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnStat23.Tree);

            	        }
            	        break;

            	}

            	char_literal24=(IToken)Match(input,48,FOLLOW_48_in_semicolonStatement458); if (state.failed) return retval;

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:208:1: oneLineStatement : ( assignmentList | unaryExpression );
    public SGLParser.oneLineStatement_return oneLineStatement() // throws RecognitionException [1]
    {   
        SGLParser.oneLineStatement_return retval = new SGLParser.oneLineStatement_return();
        retval.Start = input.LT(1);
        int oneLineStatement_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.assignmentList_return assignmentList25 = default(SGLParser.assignmentList_return);

        SGLParser.unaryExpression_return unaryExpression26 = default(SGLParser.unaryExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:209:2: ( assignmentList | unaryExpression )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:209:4: assignmentList
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignmentList_in_oneLineStatement471);
                    	assignmentList25 = assignmentList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentList25.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:210:4: unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpression_in_oneLineStatement476);
                    	unaryExpression26 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression26.Tree);

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

    public class assignmentList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "assignmentList"
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:213:1: assignmentList : 'var' assignment ( ',' assignment )* ;
    public SGLParser.assignmentList_return assignmentList() // throws RecognitionException [1]
    {   
        SGLParser.assignmentList_return retval = new SGLParser.assignmentList_return();
        retval.Start = input.LT(1);
        int assignmentList_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal27 = null;
        IToken char_literal29 = null;
        SGLParser.assignment_return assignment28 = default(SGLParser.assignment_return);

        SGLParser.assignment_return assignment30 = default(SGLParser.assignment_return);


        object string_literal27_tree=null;
        object char_literal29_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:214:2: ( 'var' assignment ( ',' assignment )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:214:4: 'var' assignment ( ',' assignment )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal27=(IToken)Match(input,VarStartInit,FOLLOW_VarStartInit_in_assignmentList491); if (state.failed) return retval;
            	PushFollow(FOLLOW_assignment_in_assignmentList494);
            	assignment28 = assignment();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment28.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:214:22: ( ',' assignment )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == 49) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:214:23: ',' assignment
            			    {
            			    	char_literal29=(IToken)Match(input,49,FOLLOW_49_in_assignmentList497); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_assignment_in_assignmentList500);
            			    	assignment30 = assignment();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment30.Tree);

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
            	Memoize(input, 10, assignmentList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "assignmentList"

    public class globalAssignmentList_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "globalAssignmentList"
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:218:1: globalAssignmentList : 'global' 'var' globalAssignment ( ',' globalAssignment )* ;
    public SGLParser.globalAssignmentList_return globalAssignmentList() // throws RecognitionException [1]
    {   
        SGLParser.globalAssignmentList_return retval = new SGLParser.globalAssignmentList_return();
        retval.Start = input.LT(1);
        int globalAssignmentList_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal31 = null;
        IToken string_literal32 = null;
        IToken char_literal34 = null;
        SGLParser.globalAssignment_return globalAssignment33 = default(SGLParser.globalAssignment_return);

        SGLParser.globalAssignment_return globalAssignment35 = default(SGLParser.globalAssignment_return);


        object string_literal31_tree=null;
        object string_literal32_tree=null;
        object char_literal34_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:219:2: ( 'global' 'var' globalAssignment ( ',' globalAssignment )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:219:4: 'global' 'var' globalAssignment ( ',' globalAssignment )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal31=(IToken)Match(input,50,FOLLOW_50_in_globalAssignmentList516); if (state.failed) return retval;
            	string_literal32=(IToken)Match(input,VarStartInit,FOLLOW_VarStartInit_in_globalAssignmentList519); if (state.failed) return retval;
            	PushFollow(FOLLOW_globalAssignment_in_globalAssignmentList522);
            	globalAssignment33 = globalAssignment();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, globalAssignment33.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:219:38: ( ',' globalAssignment )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 49) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:219:39: ',' globalAssignment
            			    {
            			    	char_literal34=(IToken)Match(input,49,FOLLOW_49_in_globalAssignmentList525); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_globalAssignment_in_globalAssignmentList528);
            			    	globalAssignment35 = globalAssignment();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, globalAssignment35.Tree);

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
            	Memoize(input, 11, globalAssignmentList_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "globalAssignmentList"

    public class globalAssignment_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "globalAssignment"
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:222:1: globalAssignment : variable ( indexes )? ( '=' expression )? -> ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? ) ;
    public SGLParser.globalAssignment_return globalAssignment() // throws RecognitionException [1]
    {   
        SGLParser.globalAssignment_return retval = new SGLParser.globalAssignment_return();
        retval.Start = input.LT(1);
        int globalAssignment_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal38 = null;
        SGLParser.variable_return variable36 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes37 = default(SGLParser.indexes_return);

        SGLParser.expression_return expression39 = default(SGLParser.expression_return);


        object char_literal38_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_indexes = new RewriteRuleSubtreeStream(adaptor,"rule indexes");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:223:2: ( variable ( indexes )? ( '=' expression )? -> ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:223:4: variable ( indexes )? ( '=' expression )?
            {
            	PushFollow(FOLLOW_variable_in_globalAssignment542);
            	variable36 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable36.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:223:13: ( indexes )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == 52) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_globalAssignment544);
            	        	indexes37 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes37.Tree);

            	        }
            	        break;

            	}

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:223:22: ( '=' expression )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 51) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:223:23: '=' expression
            	        {
            	        	char_literal38=(IToken)Match(input,51,FOLLOW_51_in_globalAssignment548); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_51.Add(char_literal38);

            	        	PushFollow(FOLLOW_expression_in_globalAssignment550);
            	        	expression39 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression39.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          expression, variable, indexes
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 223:41: -> ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:223:44: ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(GLOBAL_ASSIGN, "GLOBAL_ASSIGN"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:223:69: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:223:78: ( expression )?
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
            	Memoize(input, 12, globalAssignment_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "globalAssignment"

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:226:1: assignment : variable ( indexes )? ( '=' expression )? -> ^( ASSIGN variable ( indexes )? ( expression )? ) ;
    public SGLParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        SGLParser.assignment_return retval = new SGLParser.assignment_return();
        retval.Start = input.LT(1);
        int assignment_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal42 = null;
        SGLParser.variable_return variable40 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes41 = default(SGLParser.indexes_return);

        SGLParser.expression_return expression43 = default(SGLParser.expression_return);


        object char_literal42_tree=null;
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_indexes = new RewriteRuleSubtreeStream(adaptor,"rule indexes");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:227:2: ( variable ( indexes )? ( '=' expression )? -> ^( ASSIGN variable ( indexes )? ( expression )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:227:4: variable ( indexes )? ( '=' expression )?
            {
            	PushFollow(FOLLOW_variable_in_assignment581);
            	variable40 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable40.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:227:13: ( indexes )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == 52) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_assignment583);
            	        	indexes41 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes41.Tree);

            	        }
            	        break;

            	}

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:227:22: ( '=' expression )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == 51) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:227:23: '=' expression
            	        {
            	        	char_literal42=(IToken)Match(input,51,FOLLOW_51_in_assignment587); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_51.Add(char_literal42);

            	        	PushFollow(FOLLOW_expression_in_assignment589);
            	        	expression43 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression43.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          variable, expression, indexes
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 227:41: -> ^( ASSIGN variable ( indexes )? ( expression )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:227:44: ^( ASSIGN variable ( indexes )? ( expression )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASSIGN, "ASSIGN"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:227:62: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:227:71: ( expression )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:230:1: indexes : ( '[' expression ']' )+ -> ^( INDEXES ( expression )+ ) ;
    public SGLParser.indexes_return indexes() // throws RecognitionException [1]
    {   
        SGLParser.indexes_return retval = new SGLParser.indexes_return();
        retval.Start = input.LT(1);
        int indexes_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal44 = null;
        IToken char_literal46 = null;
        SGLParser.expression_return expression45 = default(SGLParser.expression_return);


        object char_literal44_tree=null;
        object char_literal46_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:231:4: ( ( '[' expression ']' )+ -> ^( INDEXES ( expression )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:231:8: ( '[' expression ']' )+
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:231:8: ( '[' expression ']' )+
            	int cnt14 = 0;
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 52) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:231:9: '[' expression ']'
            			    {
            			    	char_literal44=(IToken)Match(input,52,FOLLOW_52_in_indexes624); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_52.Add(char_literal44);

            			    	PushFollow(FOLLOW_expression_in_indexes626);
            			    	expression45 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression45.Tree);
            			    	char_literal46=(IToken)Match(input,53,FOLLOW_53_in_indexes628); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_53.Add(char_literal46);


            			    }
            			    break;

            			default:
            			    if ( cnt14 >= 1 ) goto loop14;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee14 =
            		                new EarlyExitException(14, input);
            		            throw eee14;
            	    }
            	    cnt14++;
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements



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
            	// 231:30: -> ^( INDEXES ( expression )+ )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:231:33: ^( INDEXES ( expression )+ )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:234:1: objectMethodCall : variable ( indexes )? '.' Identifier '(' ( expressionList )? ')' -> ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? ) ;
    public SGLParser.objectMethodCall_return objectMethodCall() // throws RecognitionException [1]
    {   
        SGLParser.objectMethodCall_return retval = new SGLParser.objectMethodCall_return();
        retval.Start = input.LT(1);
        int objectMethodCall_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal49 = null;
        IToken Identifier50 = null;
        IToken char_literal51 = null;
        IToken char_literal53 = null;
        SGLParser.variable_return variable47 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes48 = default(SGLParser.indexes_return);

        SGLParser.expressionList_return expressionList52 = default(SGLParser.expressionList_return);


        object char_literal49_tree=null;
        object Identifier50_tree=null;
        object char_literal51_tree=null;
        object char_literal53_tree=null;
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_expressionList = new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        RewriteRuleSubtreeStream stream_indexes = new RewriteRuleSubtreeStream(adaptor,"rule indexes");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 15) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:235:2: ( variable ( indexes )? '.' Identifier '(' ( expressionList )? ')' -> ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:235:4: variable ( indexes )? '.' Identifier '(' ( expressionList )? ')'
            {
            	PushFollow(FOLLOW_variable_in_objectMethodCall655);
            	variable47 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable47.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:235:13: ( indexes )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == 52) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_objectMethodCall657);
            	        	indexes48 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes48.Tree);

            	        }
            	        break;

            	}

            	char_literal49=(IToken)Match(input,54,FOLLOW_54_in_objectMethodCall660); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_54.Add(char_literal49);

            	Identifier50=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_objectMethodCall662); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier50);

            	char_literal51=(IToken)Match(input,55,FOLLOW_55_in_objectMethodCall664); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(char_literal51);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:235:41: ( expressionList )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( ((LA16_0 >= Identifier && LA16_0 <= Null) || LA16_0 == 55 || LA16_0 == 69 || LA16_0 == 74 || LA16_0 == 77) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_objectMethodCall666);
            	        	expressionList52 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList52.Tree);

            	        }
            	        break;

            	}

            	char_literal53=(IToken)Match(input,56,FOLLOW_56_in_objectMethodCall669); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(char_literal53);



            	// AST REWRITE
            	// elements:          variable, indexes, Identifier, expressionList
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 235:61: -> ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:235:64: ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(OBJ_FUNC_CALL, "OBJ_FUNC_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:235:89: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:235:109: ( expressionList )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:239:1: variable : Identifier -> Identifier ;
    public SGLParser.variable_return variable() // throws RecognitionException [1]
    {   
        SGLParser.variable_return retval = new SGLParser.variable_return();
        retval.Start = input.LT(1);
        int variable_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier54 = null;

        object Identifier54_tree=null;
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:240:2: ( Identifier -> Identifier )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:240:4: Identifier
            {
            	Identifier54=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable703); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier54);



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
            	// 240:15: -> Identifier
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:245:1: stringAtom : StringAtom -> ^( STRING StringAtom ) ;
    public SGLParser.stringAtom_return stringAtom() // throws RecognitionException [1]
    {   
        SGLParser.stringAtom_return retval = new SGLParser.stringAtom_return();
        retval.Start = input.LT(1);
        int stringAtom_StartIndex = input.Index();
        object root_0 = null;

        IToken StringAtom55 = null;

        object StringAtom55_tree=null;
        RewriteRuleTokenStream stream_StringAtom = new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:246:2: ( StringAtom -> ^( STRING StringAtom ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:246:6: StringAtom
            {
            	StringAtom55=(IToken)Match(input,StringAtom,FOLLOW_StringAtom_in_stringAtom726); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_StringAtom.Add(StringAtom55);



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
            	// 246:17: -> ^( STRING StringAtom )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:246:20: ^( STRING StringAtom )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:251:1: methodDef : 'function' Identifier '(' ( variableList )? ')' commonBlock ;
    public SGLParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        SGLParser.methodDef_return retval = new SGLParser.methodDef_return();
        retval.Start = input.LT(1);
        int methodDef_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal56 = null;
        IToken Identifier57 = null;
        IToken char_literal58 = null;
        IToken char_literal60 = null;
        SGLParser.variableList_return variableList59 = default(SGLParser.variableList_return);

        SGLParser.commonBlock_return commonBlock61 = default(SGLParser.commonBlock_return);


        object string_literal56_tree=null;
        object Identifier57_tree=null;
        object char_literal58_tree=null;
        object char_literal60_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:252:2: ( 'function' Identifier '(' ( variableList )? ')' commonBlock )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:252:4: 'function' Identifier '(' ( variableList )? ')' commonBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal56=(IToken)Match(input,57,FOLLOW_57_in_methodDef747); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal56_tree = (object)adaptor.Create(string_literal56);
            		adaptor.AddChild(root_0, string_literal56_tree);
            	}
            	Identifier57=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodDef749); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier57_tree = (object)adaptor.Create(Identifier57);
            		adaptor.AddChild(root_0, Identifier57_tree);
            	}
            	char_literal58=(IToken)Match(input,55,FOLLOW_55_in_methodDef751); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal58_tree = (object)adaptor.Create(char_literal58);
            		adaptor.AddChild(root_0, char_literal58_tree);
            	}
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:252:30: ( variableList )?
            	int alt17 = 2;
            	int LA17_0 = input.LA(1);

            	if ( (LA17_0 == Identifier) )
            	{
            	    alt17 = 1;
            	}
            	switch (alt17) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: variableList
            	        {
            	        	PushFollow(FOLLOW_variableList_in_methodDef753);
            	        	variableList59 = variableList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableList59.Tree);

            	        }
            	        break;

            	}

            	char_literal60=(IToken)Match(input,56,FOLLOW_56_in_methodDef756); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal60_tree = (object)adaptor.Create(char_literal60);
            		adaptor.AddChild(root_0, char_literal60_tree);
            	}
            	PushFollow(FOLLOW_commonBlock_in_methodDef758);
            	commonBlock61 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, commonBlock61.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   /*DefineMethod(((Identifier57 != null) ? Identifier57.Text : null), ((variableList59 != null) ? ((object)variableList59.Tree) : null), ((commonBlock61 != null) ? ((object)commonBlock61.Tree) : null));*/ 
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
            	Memoize(input, 18, methodDef_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "methodDef"

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:271:1: expression : ( instantiateClass | conditionalExpression );
    public SGLParser.expression_return expression() // throws RecognitionException [1]
    {   
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.instantiateClass_return instantiateClass62 = default(SGLParser.instantiateClass_return);

        SGLParser.conditionalExpression_return conditionalExpression63 = default(SGLParser.conditionalExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:272:5: ( instantiateClass | conditionalExpression )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == 77) )
            {
                alt18 = 1;
            }
            else if ( ((LA18_0 >= Identifier && LA18_0 <= Null) || LA18_0 == 55 || LA18_0 == 69 || LA18_0 == 74) )
            {
                alt18 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d18s0 =
                    new NoViableAltException("", 18, 0, input);

                throw nvae_d18s0;
            }
            switch (alt18) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:272:7: instantiateClass
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_instantiateClass_in_expression795);
                    	instantiateClass62 = instantiateClass();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, instantiateClass62.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:273:7: conditionalExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalExpression_in_expression805);
                    	conditionalExpression63 = conditionalExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression63.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:278:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public SGLParser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.Start = input.LT(1);
        int conditionalExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal65 = null;
        IToken char_literal67 = null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression64 = default(SGLParser.conditionalOrExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression66 = default(SGLParser.conditionalExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression68 = default(SGLParser.conditionalExpression_return);


        object char_literal65_tree=null;
        object char_literal67_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:279:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:279:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression831);
            	conditionalOrExpression64 = conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression64.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:279:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == 58) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:279:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	char_literal65=(IToken)Match(input,58,FOLLOW_58_in_conditionalExpression835); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal65_tree = (object)adaptor.Create(char_literal65);
            	        		root_0 = (object)adaptor.BecomeRoot(char_literal65_tree, root_0);
            	        	}
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression838);
            	        	conditionalExpression66 = conditionalExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression66.Tree);
            	        	char_literal67=(IToken)Match(input,59,FOLLOW_59_in_conditionalExpression840); if (state.failed) return retval;
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression843);
            	        	conditionalExpression68 = conditionalExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression68.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:284:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public SGLParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);
        int conditionalOrExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal70 = null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression69 = default(SGLParser.conditionalAndExpression_return);

        SGLParser.conditionalAndExpression_return conditionalAndExpression71 = default(SGLParser.conditionalAndExpression_return);


        object string_literal70_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:285:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:285:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression886);
            	conditionalAndExpression69 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression69.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:285:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == 60) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:285:36: '||' conditionalAndExpression
            			    {
            			    	string_literal70=(IToken)Match(input,60,FOLLOW_60_in_conditionalOrExpression890); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal70_tree = (object)adaptor.Create(string_literal70);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal70_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression893);
            			    	conditionalAndExpression71 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression71.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:289:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public SGLParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);
        int conditionalAndExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal73 = null;
        SGLParser.equalityExpression_return equalityExpression72 = default(SGLParser.equalityExpression_return);

        SGLParser.equalityExpression_return equalityExpression74 = default(SGLParser.equalityExpression_return);


        object string_literal73_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:290:5: ( equalityExpression ( '&&' equalityExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:290:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression924);
            	equalityExpression72 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression72.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:290:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == 61) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:290:30: '&&' equalityExpression
            			    {
            			    	string_literal73=(IToken)Match(input,61,FOLLOW_61_in_conditionalAndExpression928); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal73_tree = (object)adaptor.Create(string_literal73);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal73_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression931);
            			    	equalityExpression74 = equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression74.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:294:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public SGLParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.Start = input.LT(1);
        int equalityExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal76 = null;
        IToken string_literal77 = null;
        SGLParser.relationalExpression_return relationalExpression75 = default(SGLParser.relationalExpression_return);

        SGLParser.relationalExpression_return relationalExpression78 = default(SGLParser.relationalExpression_return);


        object string_literal76_tree=null;
        object string_literal77_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression958);
            	relationalExpression75 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression75.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( ((LA23_0 >= 62 && LA23_0 <= 63)) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:32: ( '==' | '!=' )
            			    	int alt22 = 2;
            			    	int LA22_0 = input.LA(1);

            			    	if ( (LA22_0 == 62) )
            			    	{
            			    	    alt22 = 1;
            			    	}
            			    	else if ( (LA22_0 == 63) )
            			    	{
            			    	    alt22 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    NoViableAltException nvae_d22s0 =
            			    	        new NoViableAltException("", 22, 0, input);

            			    	    throw nvae_d22s0;
            			    	}
            			    	switch (alt22) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:33: '=='
            			    	        {
            			    	        	string_literal76=(IToken)Match(input,62,FOLLOW_62_in_equalityExpression963); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal76_tree = (object)adaptor.Create(string_literal76);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal76_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:41: '!='
            			    	        {
            			    	        	string_literal77=(IToken)Match(input,63,FOLLOW_63_in_equalityExpression968); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal77_tree = (object)adaptor.Create(string_literal77);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal77_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression972);
            			    	relationalExpression78 = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression78.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:299:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public SGLParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.Start = input.LT(1);
        int relationalExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal80 = null;
        IToken char_literal81 = null;
        IToken string_literal82 = null;
        IToken string_literal83 = null;
        SGLParser.additiveExpression_return additiveExpression79 = default(SGLParser.additiveExpression_return);

        SGLParser.additiveExpression_return additiveExpression84 = default(SGLParser.additiveExpression_return);


        object char_literal80_tree=null;
        object char_literal81_tree=null;
        object string_literal82_tree=null;
        object string_literal83_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1003);
            	additiveExpression79 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression79.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( ((LA25_0 >= 64 && LA25_0 <= 67)) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:29: ( '<' | '>' | '<=' | '>=' )
            			    	int alt24 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 64:
            			    		{
            			    	    alt24 = 1;
            			    	    }
            			    	    break;
            			    	case 65:
            			    		{
            			    	    alt24 = 2;
            			    	    }
            			    	    break;
            			    	case 66:
            			    		{
            			    	    alt24 = 3;
            			    	    }
            			    	    break;
            			    	case 67:
            			    		{
            			    	    alt24 = 4;
            			    	    }
            			    	    break;
            			    		default:
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    NoViableAltException nvae_d24s0 =
            			    		        new NoViableAltException("", 24, 0, input);

            			    		    throw nvae_d24s0;
            			    	}

            			    	switch (alt24) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:30: '<'
            			    	        {
            			    	        	char_literal80=(IToken)Match(input,64,FOLLOW_64_in_relationalExpression1007); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal80_tree = (object)adaptor.Create(char_literal80);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal80_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:35: '>'
            			    	        {
            			    	        	char_literal81=(IToken)Match(input,65,FOLLOW_65_in_relationalExpression1010); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal81_tree = (object)adaptor.Create(char_literal81);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal81_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:40: '<='
            			    	        {
            			    	        	string_literal82=(IToken)Match(input,66,FOLLOW_66_in_relationalExpression1013); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal82_tree = (object)adaptor.Create(string_literal82);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal82_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:46: '>='
            			    	        {
            			    	        	string_literal83=(IToken)Match(input,67,FOLLOW_67_in_relationalExpression1016); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal83_tree = (object)adaptor.Create(string_literal83);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal83_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1020);
            			    	additiveExpression84 = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression84.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:304:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public SGLParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.Start = input.LT(1);
        int additiveExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal86 = null;
        IToken char_literal87 = null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression85 = default(SGLParser.multiplicativeExpression_return);

        SGLParser.multiplicativeExpression_return multiplicativeExpression88 = default(SGLParser.multiplicativeExpression_return);


        object char_literal86_tree=null;
        object char_literal87_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1058);
            	multiplicativeExpression85 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression85.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( ((LA27_0 >= 68 && LA27_0 <= 69)) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:35: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:35: ( '+' | '-' )
            			    	int alt26 = 2;
            			    	int LA26_0 = input.LA(1);

            			    	if ( (LA26_0 == 68) )
            			    	{
            			    	    alt26 = 1;
            			    	}
            			    	else if ( (LA26_0 == 69) )
            			    	{
            			    	    alt26 = 2;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    NoViableAltException nvae_d26s0 =
            			    	        new NoViableAltException("", 26, 0, input);

            			    	    throw nvae_d26s0;
            			    	}
            			    	switch (alt26) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:36: '+'
            			    	        {
            			    	        	char_literal86=(IToken)Match(input,68,FOLLOW_68_in_additiveExpression1062); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal86_tree = (object)adaptor.Create(char_literal86);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal86_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:41: '-'
            			    	        {
            			    	        	char_literal87=(IToken)Match(input,69,FOLLOW_69_in_additiveExpression1065); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal87_tree = (object)adaptor.Create(char_literal87);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal87_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1069);
            			    	multiplicativeExpression88 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression88.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:309:1: multiplicativeExpression : powExpression ( ( '*' | '/' | '%' ) powExpression )* ;
    public SGLParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal90 = null;
        IToken char_literal91 = null;
        IToken char_literal92 = null;
        SGLParser.powExpression_return powExpression89 = default(SGLParser.powExpression_return);

        SGLParser.powExpression_return powExpression93 = default(SGLParser.powExpression_return);


        object char_literal90_tree=null;
        object char_literal91_tree=null;
        object char_literal92_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:310:5: ( powExpression ( ( '*' | '/' | '%' ) powExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:310:9: powExpression ( ( '*' | '/' | '%' ) powExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_powExpression_in_multiplicativeExpression1103);
            	powExpression89 = powExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, powExpression89.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:310:23: ( ( '*' | '/' | '%' ) powExpression )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( ((LA29_0 >= 70 && LA29_0 <= 72)) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:310:24: ( '*' | '/' | '%' ) powExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:310:24: ( '*' | '/' | '%' )
            			    	int alt28 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 70:
            			    		{
            			    	    alt28 = 1;
            			    	    }
            			    	    break;
            			    	case 71:
            			    		{
            			    	    alt28 = 2;
            			    	    }
            			    	    break;
            			    	case 72:
            			    		{
            			    	    alt28 = 3;
            			    	    }
            			    	    break;
            			    		default:
            			    		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    		    NoViableAltException nvae_d28s0 =
            			    		        new NoViableAltException("", 28, 0, input);

            			    		    throw nvae_d28s0;
            			    	}

            			    	switch (alt28) 
            			    	{
            			    	    case 1 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:310:25: '*'
            			    	        {
            			    	        	char_literal90=(IToken)Match(input,70,FOLLOW_70_in_multiplicativeExpression1107); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal90_tree = (object)adaptor.Create(char_literal90);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal90_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:310:30: '/'
            			    	        {
            			    	        	char_literal91=(IToken)Match(input,71,FOLLOW_71_in_multiplicativeExpression1110); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal91_tree = (object)adaptor.Create(char_literal91);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal91_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:310:35: '%'
            			    	        {
            			    	        	char_literal92=(IToken)Match(input,72,FOLLOW_72_in_multiplicativeExpression1113); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal92_tree = (object)adaptor.Create(char_literal92);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal92_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_powExpression_in_multiplicativeExpression1117);
            			    	powExpression93 = powExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, powExpression93.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:313:1: powExpression : negateExpression ( '^' negateExpression )* ;
    public SGLParser.powExpression_return powExpression() // throws RecognitionException [1]
    {   
        SGLParser.powExpression_return retval = new SGLParser.powExpression_return();
        retval.Start = input.LT(1);
        int powExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal95 = null;
        SGLParser.negateExpression_return negateExpression94 = default(SGLParser.negateExpression_return);

        SGLParser.negateExpression_return negateExpression96 = default(SGLParser.negateExpression_return);


        object char_literal95_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:314:2: ( negateExpression ( '^' negateExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:314:4: negateExpression ( '^' negateExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_negateExpression_in_powExpression1137);
            	negateExpression94 = negateExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negateExpression94.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:314:21: ( '^' negateExpression )*
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( (LA30_0 == 73) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:314:22: '^' negateExpression
            			    {
            			    	char_literal95=(IToken)Match(input,73,FOLLOW_73_in_powExpression1140); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal95_tree = (object)adaptor.Create(char_literal95);
            			    		root_0 = (object)adaptor.BecomeRoot(char_literal95_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_negateExpression_in_powExpression1143);
            			    	negateExpression96 = negateExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negateExpression96.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:318:1: negateExpression : ( '-' mathAtom -> ^( INT_NEGATE mathAtom ) | '!' mathAtom -> ^( BOOL_NEGATE mathAtom ) | unaryExpression | mathAtom );
    public SGLParser.negateExpression_return negateExpression() // throws RecognitionException [1]
    {   
        SGLParser.negateExpression_return retval = new SGLParser.negateExpression_return();
        retval.Start = input.LT(1);
        int negateExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal97 = null;
        IToken char_literal99 = null;
        SGLParser.mathAtom_return mathAtom98 = default(SGLParser.mathAtom_return);

        SGLParser.mathAtom_return mathAtom100 = default(SGLParser.mathAtom_return);

        SGLParser.unaryExpression_return unaryExpression101 = default(SGLParser.unaryExpression_return);

        SGLParser.mathAtom_return mathAtom102 = default(SGLParser.mathAtom_return);


        object char_literal97_tree=null;
        object char_literal99_tree=null;
        RewriteRuleTokenStream stream_69 = new RewriteRuleTokenStream(adaptor,"token 69");
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleSubtreeStream stream_mathAtom = new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:319:2: ( '-' mathAtom -> ^( INT_NEGATE mathAtom ) | '!' mathAtom -> ^( BOOL_NEGATE mathAtom ) | unaryExpression | mathAtom )
            int alt31 = 4;
            switch ( input.LA(1) ) 
            {
            case 69:
            	{
                alt31 = 1;
                }
                break;
            case 74:
            	{
                alt31 = 2;
                }
                break;
            case Identifier:
            	{
                int LA31_3 = input.LA(2);

                if ( (LA31_3 == EOF || LA31_3 == Identifier || LA31_3 == VarStartInit || LA31_3 == 46 || (LA31_3 >= 48 && LA31_3 <= 49) || (LA31_3 >= 52 && LA31_3 <= 56) || (LA31_3 >= 58 && LA31_3 <= 73) || (LA31_3 >= 78 && LA31_3 <= 79)) )
                {
                    alt31 = 4;
                }
                else if ( ((LA31_3 >= 75 && LA31_3 <= 76)) )
                {
                    alt31 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d31s3 =
                        new NoViableAltException("", 31, 3, input);

                    throw nvae_d31s3;
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
            case ColorAtom:
            case Null:
            case 55:
            	{
                alt31 = 4;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d31s0 =
            	        new NoViableAltException("", 31, 0, input);

            	    throw nvae_d31s0;
            }

            switch (alt31) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:319:4: '-' mathAtom
                    {
                    	char_literal97=(IToken)Match(input,69,FOLLOW_69_in_negateExpression1161); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_69.Add(char_literal97);

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1163);
                    	mathAtom98 = mathAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_mathAtom.Add(mathAtom98.Tree);


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
                    	// 319:17: -> ^( INT_NEGATE mathAtom )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:319:20: ^( INT_NEGATE mathAtom )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:320:4: '!' mathAtom
                    {
                    	char_literal99=(IToken)Match(input,74,FOLLOW_74_in_negateExpression1176); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_74.Add(char_literal99);

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1178);
                    	mathAtom100 = mathAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_mathAtom.Add(mathAtom100.Tree);


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
                    	// 320:17: -> ^( BOOL_NEGATE mathAtom )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:320:20: ^( BOOL_NEGATE mathAtom )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:321:4: unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpression_in_negateExpression1191);
                    	unaryExpression101 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression101.Tree);

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:322:4: mathAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1196);
                    	mathAtom102 = mathAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathAtom102.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:326:1: unaryExpression : variable ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) ) ;
    public SGLParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.Start = input.LT(1);
        int unaryExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal104 = null;
        IToken string_literal105 = null;
        SGLParser.variable_return variable103 = default(SGLParser.variable_return);


        object string_literal104_tree=null;
        object string_literal105_tree=null;
        RewriteRuleTokenStream stream_75 = new RewriteRuleTokenStream(adaptor,"token 75");
        RewriteRuleTokenStream stream_76 = new RewriteRuleTokenStream(adaptor,"token 76");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:327:5: ( variable ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:327:9: variable ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) )
            {
            	PushFollow(FOLLOW_variable_in_unaryExpression1214);
            	variable103 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable103.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:327:18: ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) )
            	int alt32 = 2;
            	int LA32_0 = input.LA(1);

            	if ( (LA32_0 == 75) )
            	{
            	    alt32 = 1;
            	}
            	else if ( (LA32_0 == 76) )
            	{
            	    alt32 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d32s0 =
            	        new NoViableAltException("", 32, 0, input);

            	    throw nvae_d32s0;
            	}
            	switch (alt32) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:327:19: '++'
            	        {
            	        	string_literal104=(IToken)Match(input,75,FOLLOW_75_in_unaryExpression1217); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_75.Add(string_literal104);



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
            	        	// 327:24: -> ^( VARINC variable )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:327:27: ^( VARINC variable )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARINC, "VARINC"), root_1);

            	        	    adaptor.AddChild(root_1, stream_variable.NextTree());

            	        	    adaptor.AddChild(root_0, root_1);
            	        	    }

            	        	}

            	        	retval.Tree = root_0;retval.Tree = root_0;}
            	        }
            	        break;
            	    case 2 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:328:4: '--'
            	        {
            	        	string_literal105=(IToken)Match(input,76,FOLLOW_76_in_unaryExpression1230); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_76.Add(string_literal105);



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
            	        	// 328:9: -> ^( VARDEC variable )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:328:12: ^( VARDEC variable )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(VARDEC, "VARDEC"), root_1);

            	        	    adaptor.AddChild(root_1, stream_variable.NextTree());

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:333:1: mathAtom : ( '(' expression ')' | IntAtom | FloatAtom | BooleanAtom | stringAtom | LayerAtom | OriginAtom | LoopTypeAtom | ColorAtom | Null | lookup );
    public SGLParser.mathAtom_return mathAtom() // throws RecognitionException [1]
    {   
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.Start = input.LT(1);
        int mathAtom_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal106 = null;
        IToken char_literal108 = null;
        IToken IntAtom109 = null;
        IToken FloatAtom110 = null;
        IToken BooleanAtom111 = null;
        IToken LayerAtom113 = null;
        IToken OriginAtom114 = null;
        IToken LoopTypeAtom115 = null;
        IToken ColorAtom116 = null;
        IToken Null117 = null;
        SGLParser.expression_return expression107 = default(SGLParser.expression_return);

        SGLParser.stringAtom_return stringAtom112 = default(SGLParser.stringAtom_return);

        SGLParser.lookup_return lookup118 = default(SGLParser.lookup_return);


        object char_literal106_tree=null;
        object char_literal108_tree=null;
        object IntAtom109_tree=null;
        object FloatAtom110_tree=null;
        object BooleanAtom111_tree=null;
        object LayerAtom113_tree=null;
        object OriginAtom114_tree=null;
        object LoopTypeAtom115_tree=null;
        object ColorAtom116_tree=null;
        object Null117_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:334:2: ( '(' expression ')' | IntAtom | FloatAtom | BooleanAtom | stringAtom | LayerAtom | OriginAtom | LoopTypeAtom | ColorAtom | Null | lookup )
            int alt33 = 11;
            switch ( input.LA(1) ) 
            {
            case 55:
            	{
                alt33 = 1;
                }
                break;
            case IntAtom:
            	{
                alt33 = 2;
                }
                break;
            case FloatAtom:
            	{
                alt33 = 3;
                }
                break;
            case BooleanAtom:
            	{
                alt33 = 4;
                }
                break;
            case StringAtom:
            	{
                alt33 = 5;
                }
                break;
            case LayerAtom:
            	{
                alt33 = 6;
                }
                break;
            case OriginAtom:
            	{
                alt33 = 7;
                }
                break;
            case LoopTypeAtom:
            	{
                alt33 = 8;
                }
                break;
            case ColorAtom:
            	{
                alt33 = 9;
                }
                break;
            case Null:
            	{
                alt33 = 10;
                }
                break;
            case Identifier:
            	{
                alt33 = 11;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d33s0 =
            	        new NoViableAltException("", 33, 0, input);

            	    throw nvae_d33s0;
            }

            switch (alt33) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:334:4: '(' expression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal106=(IToken)Match(input,55,FOLLOW_55_in_mathAtom1264); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expression_in_mathAtom1267);
                    	expression107 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression107.Tree);
                    	char_literal108=(IToken)Match(input,56,FOLLOW_56_in_mathAtom1269); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:335:7: IntAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IntAtom109=(IToken)Match(input,IntAtom,FOLLOW_IntAtom_in_mathAtom1281); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IntAtom109_tree = (object)adaptor.Create(IntAtom109);
                    		adaptor.AddChild(root_0, IntAtom109_tree);
                    	}

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:336:7: FloatAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FloatAtom110=(IToken)Match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1296); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FloatAtom110_tree = (object)adaptor.Create(FloatAtom110);
                    		adaptor.AddChild(root_0, FloatAtom110_tree);
                    	}

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:337:9: BooleanAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BooleanAtom111=(IToken)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1312); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BooleanAtom111_tree = (object)adaptor.Create(BooleanAtom111);
                    		adaptor.AddChild(root_0, BooleanAtom111_tree);
                    	}

                    }
                    break;
                case 5 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:338:4: stringAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stringAtom_in_mathAtom1323);
                    	stringAtom112 = stringAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, stringAtom112.Tree);

                    }
                    break;
                case 6 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:339:4: LayerAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LayerAtom113=(IToken)Match(input,LayerAtom,FOLLOW_LayerAtom_in_mathAtom1334); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LayerAtom113_tree = (object)adaptor.Create(LayerAtom113);
                    		adaptor.AddChild(root_0, LayerAtom113_tree);
                    	}

                    }
                    break;
                case 7 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:340:4: OriginAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	OriginAtom114=(IToken)Match(input,OriginAtom,FOLLOW_OriginAtom_in_mathAtom1345); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OriginAtom114_tree = (object)adaptor.Create(OriginAtom114);
                    		adaptor.AddChild(root_0, OriginAtom114_tree);
                    	}

                    }
                    break;
                case 8 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:341:4: LoopTypeAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LoopTypeAtom115=(IToken)Match(input,LoopTypeAtom,FOLLOW_LoopTypeAtom_in_mathAtom1356); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LoopTypeAtom115_tree = (object)adaptor.Create(LoopTypeAtom115);
                    		adaptor.AddChild(root_0, LoopTypeAtom115_tree);
                    	}

                    }
                    break;
                case 9 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:342:4: ColorAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ColorAtom116=(IToken)Match(input,ColorAtom,FOLLOW_ColorAtom_in_mathAtom1369); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ColorAtom116_tree = (object)adaptor.Create(ColorAtom116);
                    		adaptor.AddChild(root_0, ColorAtom116_tree);
                    	}

                    }
                    break;
                case 10 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:343:4: Null
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	Null117=(IToken)Match(input,Null,FOLLOW_Null_in_mathAtom1380); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Null117_tree = (object)adaptor.Create(Null117);
                    		adaptor.AddChild(root_0, Null117_tree);
                    	}

                    }
                    break;
                case 11 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:345:4: lookup
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lookup_in_mathAtom1394);
                    	lookup118 = lookup();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lookup118.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:348:1: lookup : ( objectMethodCall ( indexes )? -> ^( LOOKUP objectMethodCall ( indexes )? ) | methodCall ( indexes )? -> ^( LOOKUP methodCall ( indexes )? ) | variable ( indexes )? -> ^( LOOKUP variable ( indexes )? ) );
    public SGLParser.lookup_return lookup() // throws RecognitionException [1]
    {   
        SGLParser.lookup_return retval = new SGLParser.lookup_return();
        retval.Start = input.LT(1);
        int lookup_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.objectMethodCall_return objectMethodCall119 = default(SGLParser.objectMethodCall_return);

        SGLParser.indexes_return indexes120 = default(SGLParser.indexes_return);

        SGLParser.methodCall_return methodCall121 = default(SGLParser.methodCall_return);

        SGLParser.indexes_return indexes122 = default(SGLParser.indexes_return);

        SGLParser.variable_return variable123 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes124 = default(SGLParser.indexes_return);


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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:349:2: ( objectMethodCall ( indexes )? -> ^( LOOKUP objectMethodCall ( indexes )? ) | methodCall ( indexes )? -> ^( LOOKUP methodCall ( indexes )? ) | variable ( indexes )? -> ^( LOOKUP variable ( indexes )? ) )
            int alt37 = 3;
            int LA37_0 = input.LA(1);

            if ( (LA37_0 == Identifier) )
            {
                int LA37_1 = input.LA(2);

                if ( (synpred57_SGL()) )
                {
                    alt37 = 1;
                }
                else if ( (synpred59_SGL()) )
                {
                    alt37 = 2;
                }
                else if ( (true) )
                {
                    alt37 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d37s1 =
                        new NoViableAltException("", 37, 1, input);

                    throw nvae_d37s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d37s0 =
                    new NoViableAltException("", 37, 0, input);

                throw nvae_d37s0;
            }
            switch (alt37) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:349:4: objectMethodCall ( indexes )?
                    {
                    	PushFollow(FOLLOW_objectMethodCall_in_lookup1413);
                    	objectMethodCall119 = objectMethodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_objectMethodCall.Add(objectMethodCall119.Tree);
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:349:21: ( indexes )?
                    	int alt34 = 2;
                    	int LA34_0 = input.LA(1);

                    	if ( (LA34_0 == 52) )
                    	{
                    	    alt34 = 1;
                    	}
                    	switch (alt34) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1415);
                    	        	indexes120 = indexes();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes120.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          indexes, objectMethodCall
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 349:30: -> ^( LOOKUP objectMethodCall ( indexes )? )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:349:33: ^( LOOKUP objectMethodCall ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_objectMethodCall.NextTree());
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:349:59: ( indexes )?
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:350:4: methodCall ( indexes )?
                    {
                    	PushFollow(FOLLOW_methodCall_in_lookup1432);
                    	methodCall121 = methodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_methodCall.Add(methodCall121.Tree);
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:350:15: ( indexes )?
                    	int alt35 = 2;
                    	int LA35_0 = input.LA(1);

                    	if ( (LA35_0 == 52) )
                    	{
                    	    alt35 = 1;
                    	}
                    	switch (alt35) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1434);
                    	        	indexes122 = indexes();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes122.Tree);

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
                    	// 350:24: -> ^( LOOKUP methodCall ( indexes )? )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:350:27: ^( LOOKUP methodCall ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_methodCall.NextTree());
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:350:47: ( indexes )?
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:351:4: variable ( indexes )?
                    {
                    	PushFollow(FOLLOW_variable_in_lookup1452);
                    	variable123 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_variable.Add(variable123.Tree);
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:351:13: ( indexes )?
                    	int alt36 = 2;
                    	int LA36_0 = input.LA(1);

                    	if ( (LA36_0 == 52) )
                    	{
                    	    alt36 = 1;
                    	}
                    	switch (alt36) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1454);
                    	        	indexes124 = indexes();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes124.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          variable, indexes
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 351:22: -> ^( LOOKUP variable ( indexes )? )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:351:25: ^( LOOKUP variable ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_variable.NextTree());
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:351:43: ( indexes )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:358:1: instantiateClass : 'new' Identifier '(' ( expressionList )? ')' -> ^( CLASS Identifier ( expressionList )? ) ;
    public SGLParser.instantiateClass_return instantiateClass() // throws RecognitionException [1]
    {   
        SGLParser.instantiateClass_return retval = new SGLParser.instantiateClass_return();
        retval.Start = input.LT(1);
        int instantiateClass_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal125 = null;
        IToken Identifier126 = null;
        IToken char_literal127 = null;
        IToken char_literal129 = null;
        SGLParser.expressionList_return expressionList128 = default(SGLParser.expressionList_return);


        object string_literal125_tree=null;
        object Identifier126_tree=null;
        object char_literal127_tree=null;
        object char_literal129_tree=null;
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_expressionList = new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:359:2: ( 'new' Identifier '(' ( expressionList )? ')' -> ^( CLASS Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:359:4: 'new' Identifier '(' ( expressionList )? ')'
            {
            	string_literal125=(IToken)Match(input,77,FOLLOW_77_in_instantiateClass1498); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_77.Add(string_literal125);

            	Identifier126=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_instantiateClass1500); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier126);

            	char_literal127=(IToken)Match(input,55,FOLLOW_55_in_instantiateClass1502); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(char_literal127);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:359:25: ( expressionList )?
            	int alt38 = 2;
            	int LA38_0 = input.LA(1);

            	if ( ((LA38_0 >= Identifier && LA38_0 <= Null) || LA38_0 == 55 || LA38_0 == 69 || LA38_0 == 74 || LA38_0 == 77) )
            	{
            	    alt38 = 1;
            	}
            	switch (alt38) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_instantiateClass1504);
            	        	expressionList128 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList128.Tree);

            	        }
            	        break;

            	}

            	char_literal129=(IToken)Match(input,56,FOLLOW_56_in_instantiateClass1507); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(char_literal129);



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
            	// 359:45: -> ^( CLASS Identifier ( expressionList )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:359:48: ^( CLASS Identifier ( expressionList )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(CLASS, "CLASS"), root_1);

            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:359:67: ( expressionList )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:374:1: expressionList : expression ( ',' expression )* -> ^( EXP_LIST ( expression )+ ) ;
    public SGLParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.Start = input.LT(1);
        int expressionList_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal131 = null;
        SGLParser.expression_return expression130 = default(SGLParser.expression_return);

        SGLParser.expression_return expression132 = default(SGLParser.expression_return);


        object char_literal131_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:375:3: ( expression ( ',' expression )* -> ^( EXP_LIST ( expression )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:375:7: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList1548);
            	expression130 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression130.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:375:18: ( ',' expression )*
            	do 
            	{
            	    int alt39 = 2;
            	    int LA39_0 = input.LA(1);

            	    if ( (LA39_0 == 49) )
            	    {
            	        alt39 = 1;
            	    }


            	    switch (alt39) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:375:19: ',' expression
            			    {
            			    	char_literal131=(IToken)Match(input,49,FOLLOW_49_in_expressionList1551); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_49.Add(char_literal131);

            			    	PushFollow(FOLLOW_expression_in_expressionList1553);
            			    	expression132 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression132.Tree);

            			    }
            			    break;

            			default:
            			    goto loop39;
            	    }
            	} while (true);

            	loop39:
            		;	// Stops C# compiler whining that label 'loop39' has no statements



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
            	// 375:36: -> ^( EXP_LIST ( expression )+ )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:375:39: ^( EXP_LIST ( expression )+ )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:379:1: variableList : variable ( ',' variable )* -> ^( VAR_LIST ( variable )+ ) ;
    public SGLParser.variableList_return variableList() // throws RecognitionException [1]
    {   
        SGLParser.variableList_return retval = new SGLParser.variableList_return();
        retval.Start = input.LT(1);
        int variableList_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal134 = null;
        SGLParser.variable_return variable133 = default(SGLParser.variable_return);

        SGLParser.variable_return variable135 = default(SGLParser.variable_return);


        object char_literal134_tree=null;
        RewriteRuleTokenStream stream_49 = new RewriteRuleTokenStream(adaptor,"token 49");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:380:3: ( variable ( ',' variable )* -> ^( VAR_LIST ( variable )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:380:5: variable ( ',' variable )*
            {
            	PushFollow(FOLLOW_variable_in_variableList1581);
            	variable133 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable133.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:380:14: ( ',' variable )*
            	do 
            	{
            	    int alt40 = 2;
            	    int LA40_0 = input.LA(1);

            	    if ( (LA40_0 == 49) )
            	    {
            	        alt40 = 1;
            	    }


            	    switch (alt40) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:380:15: ',' variable
            			    {
            			    	char_literal134=(IToken)Match(input,49,FOLLOW_49_in_variableList1584); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_49.Add(char_literal134);

            			    	PushFollow(FOLLOW_variable_in_variableList1586);
            			    	variable135 = variable();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_variable.Add(variable135.Tree);

            			    }
            			    break;

            			default:
            			    goto loop40;
            	    }
            	} while (true);

            	loop40:
            		;	// Stops C# compiler whining that label 'loop40' has no statements



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
            	// 380:30: -> ^( VAR_LIST ( variable )+ )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:380:33: ^( VAR_LIST ( variable )+ )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:383:1: methodCall : Identifier '(' ( expressionList )? ')' -> ^( FUNC_CALL Identifier ( expressionList )? ) ;
    public SGLParser.methodCall_return methodCall() // throws RecognitionException [1]
    {   
        SGLParser.methodCall_return retval = new SGLParser.methodCall_return();
        retval.Start = input.LT(1);
        int methodCall_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier136 = null;
        IToken char_literal137 = null;
        IToken char_literal139 = null;
        SGLParser.expressionList_return expressionList138 = default(SGLParser.expressionList_return);


        object Identifier136_tree=null;
        object char_literal137_tree=null;
        object char_literal139_tree=null;
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_expressionList = new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:384:2: ( Identifier '(' ( expressionList )? ')' -> ^( FUNC_CALL Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:384:4: Identifier '(' ( expressionList )? ')'
            {
            	Identifier136=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodCall1609); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier136);

            	char_literal137=(IToken)Match(input,55,FOLLOW_55_in_methodCall1611); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(char_literal137);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:384:19: ( expressionList )?
            	int alt41 = 2;
            	int LA41_0 = input.LA(1);

            	if ( ((LA41_0 >= Identifier && LA41_0 <= Null) || LA41_0 == 55 || LA41_0 == 69 || LA41_0 == 74 || LA41_0 == 77) )
            	{
            	    alt41 = 1;
            	}
            	switch (alt41) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_methodCall1613);
            	        	expressionList138 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList138.Tree);

            	        }
            	        break;

            	}

            	char_literal139=(IToken)Match(input,56,FOLLOW_56_in_methodCall1616); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(char_literal139);



            	// AST REWRITE
            	// elements:          expressionList, Identifier
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 384:39: -> ^( FUNC_CALL Identifier ( expressionList )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:384:42: ^( FUNC_CALL Identifier ( expressionList )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:384:65: ( expressionList )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:389:1: breakStat : 'break' -> BREAK ;
    public SGLParser.breakStat_return breakStat() // throws RecognitionException [1]
    {   
        SGLParser.breakStat_return retval = new SGLParser.breakStat_return();
        retval.Start = input.LT(1);
        int breakStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal140 = null;

        object string_literal140_tree=null;
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:390:2: ( 'break' -> BREAK )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:390:4: 'break'
            {
            	string_literal140=(IToken)Match(input,78,FOLLOW_78_in_breakStat1643); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_78.Add(string_literal140);



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
            	// 390:12: -> BREAK
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:393:1: returnStat : 'return' expression -> ^( RETURN expression ) ;
    public SGLParser.returnStat_return returnStat() // throws RecognitionException [1]
    {   
        SGLParser.returnStat_return retval = new SGLParser.returnStat_return();
        retval.Start = input.LT(1);
        int returnStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal141 = null;
        SGLParser.expression_return expression142 = default(SGLParser.expression_return);


        object string_literal141_tree=null;
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:394:2: ( 'return' expression -> ^( RETURN expression ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:394:4: 'return' expression
            {
            	string_literal141=(IToken)Match(input,79,FOLLOW_79_in_returnStat1658); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_79.Add(string_literal141);

            	PushFollow(FOLLOW_expression_in_returnStat1660);
            	expression142 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression142.Tree);


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
            	// 394:24: -> ^( RETURN expression )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:394:27: ^( RETURN expression )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:1: whileLoop : 'while' expression commonBlock -> ^( 'while' expression commonBlock ) ;
    public SGLParser.whileLoop_return whileLoop() // throws RecognitionException [1]
    {   
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.Start = input.LT(1);
        int whileLoop_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal143 = null;
        SGLParser.expression_return expression144 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock145 = default(SGLParser.commonBlock_return);


        object string_literal143_tree=null;
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:399:2: ( 'while' expression commonBlock -> ^( 'while' expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:399:4: 'while' expression commonBlock
            {
            	string_literal143=(IToken)Match(input,80,FOLLOW_80_in_whileLoop1683); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_80.Add(string_literal143);

            	PushFollow(FOLLOW_expression_in_whileLoop1685);
            	expression144 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression144.Tree);
            	PushFollow(FOLLOW_commonBlock_in_whileLoop1687);
            	commonBlock145 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock145.Tree);


            	// AST REWRITE
            	// elements:          80, expression, commonBlock
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 399:35: -> ^( 'while' expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:399:38: ^( 'while' expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_80.NextNode(), root_1);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:1: forLoop : 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) ;
    public SGLParser.forLoop_return forLoop() // throws RecognitionException [1]
    {   
        SGLParser.forLoop_return retval = new SGLParser.forLoop_return();
        retval.Start = input.LT(1);
        int forLoop_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal146 = null;
        IToken char_literal147 = null;
        IToken char_literal148 = null;
        IToken char_literal149 = null;
        IToken char_literal150 = null;
        SGLParser.oneLineStatement_return dec = default(SGLParser.oneLineStatement_return);

        SGLParser.expression_return cond = default(SGLParser.expression_return);

        SGLParser.oneLineStatement_return iter = default(SGLParser.oneLineStatement_return);

        SGLParser.commonBlock_return commonBlock151 = default(SGLParser.commonBlock_return);


        object string_literal146_tree=null;
        object char_literal147_tree=null;
        object char_literal148_tree=null;
        object char_literal149_tree=null;
        object char_literal150_tree=null;
        RewriteRuleTokenStream stream_48 = new RewriteRuleTokenStream(adaptor,"token 48");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        RewriteRuleSubtreeStream stream_oneLineStatement = new RewriteRuleSubtreeStream(adaptor,"rule oneLineStatement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:403:2: ( 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:403:4: 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock
            {
            	string_literal146=(IToken)Match(input,81,FOLLOW_81_in_forLoop1709); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_81.Add(string_literal146);

            	char_literal147=(IToken)Match(input,55,FOLLOW_55_in_forLoop1711); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_55.Add(char_literal147);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:403:17: (dec= oneLineStatement )?
            	int alt42 = 2;
            	int LA42_0 = input.LA(1);

            	if ( (LA42_0 == Identifier || LA42_0 == VarStartInit) )
            	{
            	    alt42 = 1;
            	}
            	switch (alt42) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: dec= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop1715);
            	        	dec = oneLineStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_oneLineStatement.Add(dec.Tree);

            	        }
            	        break;

            	}

            	char_literal148=(IToken)Match(input,48,FOLLOW_48_in_forLoop1718); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_48.Add(char_literal148);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:403:44: (cond= expression )?
            	int alt43 = 2;
            	int LA43_0 = input.LA(1);

            	if ( ((LA43_0 >= Identifier && LA43_0 <= Null) || LA43_0 == 55 || LA43_0 == 69 || LA43_0 == 74 || LA43_0 == 77) )
            	{
            	    alt43 = 1;
            	}
            	switch (alt43) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: cond= expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forLoop1722);
            	        	cond = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(cond.Tree);

            	        }
            	        break;

            	}

            	char_literal149=(IToken)Match(input,48,FOLLOW_48_in_forLoop1725); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_48.Add(char_literal149);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:403:65: (iter= oneLineStatement )?
            	int alt44 = 2;
            	int LA44_0 = input.LA(1);

            	if ( (LA44_0 == Identifier || LA44_0 == VarStartInit) )
            	{
            	    alt44 = 1;
            	}
            	switch (alt44) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: iter= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop1729);
            	        	iter = oneLineStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_oneLineStatement.Add(iter.Tree);

            	        }
            	        break;

            	}

            	char_literal150=(IToken)Match(input,56,FOLLOW_56_in_forLoop1732); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_56.Add(char_literal150);

            	PushFollow(FOLLOW_commonBlock_in_forLoop1734);
            	commonBlock151 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock151.Tree);


            	// AST REWRITE
            	// elements:          commonBlock, dec, cond, 81, iter
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
            	// 404:2: -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:404:5: ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_81.NextNode(), root_1);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:404:13: ^( FORDEC ( $dec)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORDEC, "FORDEC"), root_2);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:404:22: ( $dec)?
            	    if ( stream_dec.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_dec.NextTree());

            	    }
            	    stream_dec.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:404:29: ^( FORCOND ( $cond)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORCOND, "FORCOND"), root_2);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:404:39: ( $cond)?
            	    if ( stream_cond.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_cond.NextTree());

            	    }
            	    stream_cond.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:404:47: ^( FORITER ( $iter)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORITER, "FORITER"), root_2);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:404:57: ( $iter)?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:407:1: ifStatement : ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) ;
    public SGLParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        SGLParser.ifStatement_return retval = new SGLParser.ifStatement_return();
        retval.Start = input.LT(1);
        int ifStatement_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.ifStat_return ifStat152 = default(SGLParser.ifStat_return);

        SGLParser.elseIfStat_return elseIfStat153 = default(SGLParser.elseIfStat_return);

        SGLParser.elseStat_return elseStat154 = default(SGLParser.elseStat_return);


        RewriteRuleSubtreeStream stream_elseIfStat = new RewriteRuleSubtreeStream(adaptor,"rule elseIfStat");
        RewriteRuleSubtreeStream stream_ifStat = new RewriteRuleSubtreeStream(adaptor,"rule ifStat");
        RewriteRuleSubtreeStream stream_elseStat = new RewriteRuleSubtreeStream(adaptor,"rule elseStat");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:408:2: ( ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:408:4: ifStat ( elseIfStat )* ( elseStat )?
            {
            	PushFollow(FOLLOW_ifStat_in_ifStatement1779);
            	ifStat152 = ifStat();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ifStat.Add(ifStat152.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:408:11: ( elseIfStat )*
            	do 
            	{
            	    int alt45 = 2;
            	    int LA45_0 = input.LA(1);

            	    if ( (LA45_0 == 83) )
            	    {
            	        int LA45_1 = input.LA(2);

            	        if ( (LA45_1 == 82) )
            	        {
            	            alt45 = 1;
            	        }


            	    }


            	    switch (alt45) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: elseIfStat
            			    {
            			    	PushFollow(FOLLOW_elseIfStat_in_ifStatement1781);
            			    	elseIfStat153 = elseIfStat();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_elseIfStat.Add(elseIfStat153.Tree);

            			    }
            			    break;

            			default:
            			    goto loop45;
            	    }
            	} while (true);

            	loop45:
            		;	// Stops C# compiler whining that label 'loop45' has no statements

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:408:23: ( elseStat )?
            	int alt46 = 2;
            	int LA46_0 = input.LA(1);

            	if ( (LA46_0 == 83) )
            	{
            	    alt46 = 1;
            	}
            	switch (alt46) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: elseStat
            	        {
            	        	PushFollow(FOLLOW_elseStat_in_ifStatement1784);
            	        	elseStat154 = elseStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_elseStat.Add(elseStat154.Tree);

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
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 408:33: -> ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:408:36: ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF, "IF"), root_1);

            	    adaptor.AddChild(root_1, stream_ifStat.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:408:48: ( elseIfStat )*
            	    while ( stream_elseIfStat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_elseIfStat.NextTree());

            	    }
            	    stream_elseIfStat.Reset();
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:408:60: ( elseStat )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:410:1: ifStat : 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.ifStat_return ifStat() // throws RecognitionException [1]
    {   
        SGLParser.ifStat_return retval = new SGLParser.ifStat_return();
        retval.Start = input.LT(1);
        int ifStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal155 = null;
        SGLParser.expression_return expression156 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock157 = default(SGLParser.commonBlock_return);


        object string_literal155_tree=null;
        RewriteRuleTokenStream stream_82 = new RewriteRuleTokenStream(adaptor,"token 82");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:411:2: ( 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:411:4: 'if' expression commonBlock
            {
            	string_literal155=(IToken)Match(input,82,FOLLOW_82_in_ifStat1809); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_82.Add(string_literal155);

            	PushFollow(FOLLOW_expression_in_ifStat1811);
            	expression156 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression156.Tree);
            	PushFollow(FOLLOW_commonBlock_in_ifStat1813);
            	commonBlock157 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock157.Tree);


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
            	// 411:32: -> ^( EXP expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:411:35: ^( EXP expression commonBlock )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:414:1: elseIfStat : 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.elseIfStat_return elseIfStat() // throws RecognitionException [1]
    {   
        SGLParser.elseIfStat_return retval = new SGLParser.elseIfStat_return();
        retval.Start = input.LT(1);
        int elseIfStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal158 = null;
        IToken string_literal159 = null;
        SGLParser.expression_return expression160 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock161 = default(SGLParser.commonBlock_return);


        object string_literal158_tree=null;
        object string_literal159_tree=null;
        RewriteRuleTokenStream stream_82 = new RewriteRuleTokenStream(adaptor,"token 82");
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:415:2: ( 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:415:4: 'else' 'if' expression commonBlock
            {
            	string_literal158=(IToken)Match(input,83,FOLLOW_83_in_elseIfStat1834); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(string_literal158);

            	string_literal159=(IToken)Match(input,82,FOLLOW_82_in_elseIfStat1836); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_82.Add(string_literal159);

            	PushFollow(FOLLOW_expression_in_elseIfStat1838);
            	expression160 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression160.Tree);
            	PushFollow(FOLLOW_commonBlock_in_elseIfStat1840);
            	commonBlock161 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock161.Tree);


            	// AST REWRITE
            	// elements:          expression, commonBlock
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 415:39: -> ^( EXP expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:415:42: ^( EXP expression commonBlock )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:418:1: elseStat : 'else' commonBlock -> ^( EXP commonBlock ) ;
    public SGLParser.elseStat_return elseStat() // throws RecognitionException [1]
    {   
        SGLParser.elseStat_return retval = new SGLParser.elseStat_return();
        retval.Start = input.LT(1);
        int elseStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal162 = null;
        SGLParser.commonBlock_return commonBlock163 = default(SGLParser.commonBlock_return);


        object string_literal162_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:419:2: ( 'else' commonBlock -> ^( EXP commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:419:4: 'else' commonBlock
            {
            	string_literal162=(IToken)Match(input,83,FOLLOW_83_in_elseStat1862); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(string_literal162);

            	PushFollow(FOLLOW_commonBlock_in_elseStat1864);
            	commonBlock163 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock163.Tree);


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
            	// 419:23: -> ^( EXP commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:419:26: ^( EXP commonBlock )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:426:1: atStatement : 'at' expression commonBlock -> ^( AT expression commonBlock ) ;
    public SGLParser.atStatement_return atStatement() // throws RecognitionException [1]
    {   
        SGLParser.atStatement_return retval = new SGLParser.atStatement_return();
        retval.Start = input.LT(1);
        int atStatement_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal164 = null;
        SGLParser.expression_return expression165 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock166 = default(SGLParser.commonBlock_return);


        object string_literal164_tree=null;
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:427:2: ( 'at' expression commonBlock -> ^( AT expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:427:4: 'at' expression commonBlock
            {
            	string_literal164=(IToken)Match(input,84,FOLLOW_84_in_atStatement1889); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_84.Add(string_literal164);

            	PushFollow(FOLLOW_expression_in_atStatement1891);
            	expression165 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression165.Tree);
            	PushFollow(FOLLOW_commonBlock_in_atStatement1893);
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
            	// 427:32: -> ^( AT expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:427:35: ^( AT expression commonBlock )
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

    // $ANTLR start "synpred57_SGL"
    public void synpred57_SGL_fragment() {
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:349:4: ( objectMethodCall ( indexes )? )
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:349:4: objectMethodCall ( indexes )?
        {
        	PushFollow(FOLLOW_objectMethodCall_in_synpred57_SGL1413);
        	objectMethodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:349:21: ( indexes )?
        	int alt47 = 2;
        	int LA47_0 = input.LA(1);

        	if ( (LA47_0 == 52) )
        	{
        	    alt47 = 1;
        	}
        	switch (alt47) 
        	{
        	    case 1 :
        	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
        	        {
        	        	PushFollow(FOLLOW_indexes_in_synpred57_SGL1415);
        	        	indexes();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred57_SGL"

    // $ANTLR start "synpred59_SGL"
    public void synpred59_SGL_fragment() {
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:350:4: ( methodCall ( indexes )? )
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:350:4: methodCall ( indexes )?
        {
        	PushFollow(FOLLOW_methodCall_in_synpred59_SGL1432);
        	methodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:350:15: ( indexes )?
        	int alt48 = 2;
        	int LA48_0 = input.LA(1);

        	if ( (LA48_0 == 52) )
        	{
        	    alt48 = 1;
        	}
        	switch (alt48) 
        	{
        	    case 1 :
        	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
        	        {
        	        	PushFollow(FOLLOW_indexes_in_synpred59_SGL1434);
        	        	indexes();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred59_SGL"

    // Delegated rules

   	public bool synpred59_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred59_SGL_fragment(); // can never throw exception
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
   	public bool synpred57_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred57_SGL_fragment(); // can never throw exception
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

 

    public static readonly BitSet FOLLOW_mainBlock_in_main234 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mainStatement_in_mainBlock254 = new BitSet(new ulong[]{0x0204008020000002UL,0x000000000017C000UL});
    public static readonly BitSet FOLLOW_methodDef_in_mainBlock258 = new BitSet(new ulong[]{0x0204008020000002UL,0x000000000017C000UL});
    public static readonly BitSet FOLLOW_statement_in_block295 = new BitSet(new ulong[]{0x0000008020000002UL,0x000000000017C000UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_singleBlock320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_singleBlock_in_commonBlock343 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_46_in_commonBlock348 = new BitSet(new ulong[]{0x0000808020000000UL,0x000000000017C000UL});
    public static readonly BitSet FOLLOW_block_in_commonBlock351 = new BitSet(new ulong[]{0x0000800000000000UL});
    public static readonly BitSet FOLLOW_47_in_commonBlock353 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_mainStatement370 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_globalAssignmentList_in_mainStatement375 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_mainStatement377 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_statement392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement397 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atStatement_in_statement402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forLoop_in_statement412 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_semicolonStatement425 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_methodCall_in_semicolonStatement430 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_assignmentList_in_semicolonStatement436 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_semicolonStatement442 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_breakStat_in_semicolonStatement448 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_returnStat_in_semicolonStatement453 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_semicolonStatement458 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignmentList_in_oneLineStatement471 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_oneLineStatement476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VarStartInit_in_assignmentList491 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_assignment_in_assignmentList494 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_49_in_assignmentList497 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_assignment_in_assignmentList500 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_50_in_globalAssignmentList516 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_VarStartInit_in_globalAssignmentList519 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_globalAssignment_in_globalAssignmentList522 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_49_in_globalAssignmentList525 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_globalAssignment_in_globalAssignmentList528 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_globalAssignment542 = new BitSet(new ulong[]{0x0018000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_globalAssignment544 = new BitSet(new ulong[]{0x0008000000000002UL});
    public static readonly BitSet FOLLOW_51_in_globalAssignment548 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expression_in_globalAssignment550 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment581 = new BitSet(new ulong[]{0x0018000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_assignment583 = new BitSet(new ulong[]{0x0008000000000002UL});
    public static readonly BitSet FOLLOW_51_in_assignment587 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expression_in_assignment589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_52_in_indexes624 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expression_in_indexes626 = new BitSet(new ulong[]{0x0020000000000000UL});
    public static readonly BitSet FOLLOW_53_in_indexes628 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_objectMethodCall655 = new BitSet(new ulong[]{0x0050000000000000UL});
    public static readonly BitSet FOLLOW_indexes_in_objectMethodCall657 = new BitSet(new ulong[]{0x0040000000000000UL});
    public static readonly BitSet FOLLOW_54_in_objectMethodCall660 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethodCall662 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_objectMethodCall664 = new BitSet(new ulong[]{0x0180007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expressionList_in_objectMethodCall666 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_objectMethodCall669 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable703 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringAtom_in_stringAtom726 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_57_in_methodDef747 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodDef749 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_methodDef751 = new BitSet(new ulong[]{0x0100000020000000UL});
    public static readonly BitSet FOLLOW_variableList_in_methodDef753 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_methodDef756 = new BitSet(new ulong[]{0x0000408020000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_methodDef758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_instantiateClass_in_expression795 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression805 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression831 = new BitSet(new ulong[]{0x0400000000000002UL});
    public static readonly BitSet FOLLOW_58_in_conditionalExpression835 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression838 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_conditionalExpression840 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression843 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression886 = new BitSet(new ulong[]{0x1000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_conditionalOrExpression890 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression893 = new BitSet(new ulong[]{0x1000000000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression924 = new BitSet(new ulong[]{0x2000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_conditionalAndExpression928 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression931 = new BitSet(new ulong[]{0x2000000000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression958 = new BitSet(new ulong[]{0xC000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_equalityExpression963 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_63_in_equalityExpression968 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression972 = new BitSet(new ulong[]{0xC000000000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1003 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_64_in_relationalExpression1007 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_65_in_relationalExpression1010 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_66_in_relationalExpression1013 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_67_in_relationalExpression1016 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1020 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000FUL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1058 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_68_in_additiveExpression1062 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_69_in_additiveExpression1065 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1069 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000030UL});
    public static readonly BitSet FOLLOW_powExpression_in_multiplicativeExpression1103 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_70_in_multiplicativeExpression1107 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_71_in_multiplicativeExpression1110 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_72_in_multiplicativeExpression1113 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_powExpression_in_multiplicativeExpression1117 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000001C0UL});
    public static readonly BitSet FOLLOW_negateExpression_in_powExpression1137 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_73_in_powExpression1140 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_negateExpression_in_powExpression1143 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_69_in_negateExpression1161 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1163 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_74_in_negateExpression1176 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1178 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_negateExpression1191 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1196 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_unaryExpression1214 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000001800UL});
    public static readonly BitSet FOLLOW_75_in_unaryExpression1217 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_76_in_unaryExpression1230 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_mathAtom1264 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expression_in_mathAtom1267 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_mathAtom1269 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntAtom_in_mathAtom1281 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_mathAtom1296 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_mathAtom1312 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stringAtom_in_mathAtom1323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LayerAtom_in_mathAtom1334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OriginAtom_in_mathAtom1345 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LoopTypeAtom_in_mathAtom1356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ColorAtom_in_mathAtom1369 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Null_in_mathAtom1380 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookup_in_mathAtom1394 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_lookup1413 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1415 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_lookup1432 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_lookup1452 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1454 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_77_in_instantiateClass1498 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_instantiateClass1500 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_instantiateClass1502 = new BitSet(new ulong[]{0x0180007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1504 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_instantiateClass1507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1548 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_49_in_expressionList1551 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1553 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_variableList1581 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_49_in_variableList1584 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_variable_in_variableList1586 = new BitSet(new ulong[]{0x0002000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodCall1609 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_methodCall1611 = new BitSet(new ulong[]{0x0180007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expressionList_in_methodCall1613 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_methodCall1616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_78_in_breakStat1643 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_returnStat1658 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expression_in_returnStat1660 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_whileLoop1683 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop1685 = new BitSet(new ulong[]{0x0000408020000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_whileLoop1687 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_forLoop1709 = new BitSet(new ulong[]{0x0080000000000000UL});
    public static readonly BitSet FOLLOW_55_in_forLoop1711 = new BitSet(new ulong[]{0x0001008020000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop1715 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_forLoop1718 = new BitSet(new ulong[]{0x0081007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop1722 = new BitSet(new ulong[]{0x0001000000000000UL});
    public static readonly BitSet FOLLOW_48_in_forLoop1725 = new BitSet(new ulong[]{0x0100008020000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop1729 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_forLoop1732 = new BitSet(new ulong[]{0x0000408020000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_forLoop1734 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStat_in_ifStatement1779 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_elseIfStat_in_ifStatement1781 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000080000UL});
    public static readonly BitSet FOLLOW_elseStat_in_ifStatement1784 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_ifStat1809 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expression_in_ifStat1811 = new BitSet(new ulong[]{0x0000408020000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_ifStat1813 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_elseIfStat1834 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000040000UL});
    public static readonly BitSet FOLLOW_82_in_elseIfStat1836 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expression_in_elseIfStat1838 = new BitSet(new ulong[]{0x0000408020000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseIfStat1840 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_elseStat1862 = new BitSet(new ulong[]{0x0000408020000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseStat1864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_atStatement1889 = new BitSet(new ulong[]{0x0080007FE0000000UL,0x0000000000002420UL});
    public static readonly BitSet FOLLOW_expression_in_atStatement1891 = new BitSet(new ulong[]{0x0000408020000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_atStatement1893 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_synpred57_SGL1413 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_synpred57_SGL1415 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_synpred59_SGL1432 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_synpred59_SGL1434 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}