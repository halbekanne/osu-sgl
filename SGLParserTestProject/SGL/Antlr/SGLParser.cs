// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\sgl4c#\\NewSGLGramma\\SGL.g 2012-05-30 19:13:15

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


// -------------------------------------------------------------------------------------------------
//                This is a generated file, please don't change anything in here!
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using SGL;
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
		"Sprite", 
		"Animation", 
		"List", 
		"VarStartInit", 
		"Lyrics", 
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
		"'method'", 
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
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int VAR_LIST = 16;
    public const int T__62 = 62;
    public const int T__63 = 63;
    public const int Sprite = 38;
    public const int IntAtom = 30;
    public const int LoopTypeAtom = 35;
    public const int EXP_LIST = 15;
    public const int UTF8Letter = 45;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int HexDigit = 43;
    public const int BREAK = 19;
    public const int Identifier = 28;
    public const int Lyrics = 42;
    public const int IF = 22;
    public const int FUNC_CALL = 17;
    public const int AT = 21;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int Animation = 39;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int Comment = 47;
    public const int EXP = 23;
    public const int OBJ_FUNC_CALL = 18;
    public const int FORITER = 26;
    public const int T__59 = 59;
    public const int INT_NEGATE = 7;
    public const int UTF8Digit = 46;
    public const int RETURN = 20;
    public const int WhiteSpace = 48;
    public const int T__50 = 50;
    public const int VARDEC = 10;
    public const int Null = 37;
    public const int OriginAtom = 34;
    public const int LayerAtom = 33;
    public const int GLOBAL_ASSIGN = 27;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int T__49 = 49;
    public const int FORDEC = 24;
    public const int StringAtom = 29;
    public const int INDEXES = 12;
    public const int ColorAtom = 36;
    public const int T__85 = 85;
    public const int LIST = 14;
    public const int T__84 = 84;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int List = 40;
    public const int BooleanAtom = 32;
    public const int BOOL_NEGATE = 8;
    public const int LOOKUP = 13;
    public const int FORCOND = 25;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int VARIABLE = 11;
    public const int T__70 = 70;
    public const int BLOCK = 4;
    public const int VarStartInit = 41;
    public const int ASSIGN = 5;
    public const int FloatAtom = 31;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int VARINC = 9;
    public const int T__74 = 74;
    public const int EscapeSequence = 44;
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
		get { return "D:\\sgl4c#\\NewSGLGramma\\SGL.g"; }
    }



            //public Dictionary<String,Method> methods = new Dictionary<String,Method>();
            //public Dictionary<String,ObjectMethod> objectMethods = new Dictionary<String,ObjectMethod>();

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
                    GlobalMemory.GetInstance().RegisterMethod(name, new UserFunction(name, methodParameters, methodNodes));
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:149:1: main : mainBlock ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:150:5: ( mainBlock )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:150:7: mainBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_mainBlock_in_main230);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:157:1: mainBlock : ( mainStatement | methodDef ) -> ^( BLOCK ( mainStatement )* ) ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:159:2: ( ( mainStatement | methodDef ) -> ^( BLOCK ( mainStatement )* ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:159:4: ( mainStatement | methodDef )
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:159:4: ( mainStatement | methodDef )
            	int alt1 = 2;
            	int LA1_0 = input.LA(1);

            	if ( (LA1_0 == Identifier || LA1_0 == VarStartInit || LA1_0 == 53 || (LA1_0 >= 81 && LA1_0 <= 85) || LA1_0 == 87) )
            	{
            	    alt1 = 1;
            	}
            	else if ( (LA1_0 == 60) )
            	{
            	    alt1 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d1s0 =
            	        new NoViableAltException("", 1, 0, input);

            	    throw nvae_d1s0;
            	}
            	switch (alt1) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:159:5: mainStatement
            	        {
            	        	PushFollow(FOLLOW_mainStatement_in_mainBlock250);
            	        	mainStatement2 = mainStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_mainStatement.Add(mainStatement2.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:159:21: methodDef
            	        {
            	        	PushFollow(FOLLOW_methodDef_in_mainBlock254);
            	        	methodDef3 = methodDef();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_methodDef.Add(methodDef3.Tree);

            	        }
            	        break;

            	}



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
            	// 160:8: -> ^( BLOCK ( mainStatement )* )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:160:11: ^( BLOCK ( mainStatement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:160:20: ( mainStatement )*
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:164:1: block : ( statement )* -> ^( BLOCK ( statement )* ) ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:165:2: ( ( statement )* -> ^( BLOCK ( statement )* ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:165:4: ( statement )*
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:165:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == Identifier || LA2_0 == VarStartInit || (LA2_0 >= 81 && LA2_0 <= 85) || LA2_0 == 87) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block290);
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
            	// 166:3: -> ^( BLOCK ( statement )* )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:166:6: ^( BLOCK ( statement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:166:14: ( statement )*
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:170:1: singleBlock : semicolonStatement -> ^( BLOCK semicolonStatement ) ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:171:2: ( semicolonStatement -> ^( BLOCK semicolonStatement ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:171:4: semicolonStatement
            {
            	PushFollow(FOLLOW_semicolonStatement_in_singleBlock315);
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
            	// 172:3: -> ^( BLOCK semicolonStatement )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:172:6: ^( BLOCK semicolonStatement )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:176:1: commonBlock : ( singleBlock | '{' block '}' );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:177:2: ( singleBlock | '{' block '}' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == Identifier || LA3_0 == VarStartInit || (LA3_0 >= 81 && LA3_0 <= 82)) )
            {
                alt3 = 1;
            }
            else if ( (LA3_0 == 49) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:177:4: singleBlock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_singleBlock_in_commonBlock338);
                    	singleBlock6 = singleBlock();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, singleBlock6.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:178:4: '{' block '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal7=(IToken)Match(input,49,FOLLOW_49_in_commonBlock343); if (state.failed) return retval;
                    	PushFollow(FOLLOW_block_in_commonBlock346);
                    	block8 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block8.Tree);
                    	char_literal9=(IToken)Match(input,50,FOLLOW_50_in_commonBlock348); if (state.failed) return retval;

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:183:1: mainStatement : ( statement | globalAssignmentList ';' );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:184:2: ( statement | globalAssignmentList ';' )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == Identifier || LA4_0 == VarStartInit || (LA4_0 >= 81 && LA4_0 <= 85) || LA4_0 == 87) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == 53) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:184:4: statement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_mainStatement365);
                    	statement10 = statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement10.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:185:4: globalAssignmentList ';'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_globalAssignmentList_in_mainStatement370);
                    	globalAssignmentList11 = globalAssignmentList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, globalAssignmentList11.Tree);
                    	char_literal12=(IToken)Match(input,51,FOLLOW_51_in_mainStatement372); if (state.failed) return retval;

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:188:1: statement : ( semicolonStatement | ifStatement | atStatement | whileLoop | forLoop );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:189:2: ( semicolonStatement | ifStatement | atStatement | whileLoop | forLoop )
            int alt5 = 5;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            case VarStartInit:
            case 81:
            case 82:
            	{
                alt5 = 1;
                }
                break;
            case 85:
            	{
                alt5 = 2;
                }
                break;
            case 87:
            	{
                alt5 = 3;
                }
                break;
            case 83:
            	{
                alt5 = 4;
                }
                break;
            case 84:
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:189:4: semicolonStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_semicolonStatement_in_statement387);
                    	semicolonStatement13 = semicolonStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, semicolonStatement13.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:190:4: ifStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statement392);
                    	ifStatement14 = ifStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifStatement14.Tree);

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:191:4: atStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_atStatement_in_statement397);
                    	atStatement15 = atStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, atStatement15.Tree);

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:192:4: whileLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileLoop_in_statement402);
                    	whileLoop16 = whileLoop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileLoop16.Tree);

                    }
                    break;
                case 5 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:193:4: forLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forLoop_in_statement407);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:196:1: semicolonStatement : ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat ) ';' ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:197:2: ( ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat ) ';' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:197:4: ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat ) ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:197:4: ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat )
            	int alt6 = 6;
            	switch ( input.LA(1) ) 
            	{
            	case Identifier:
            		{
            	    switch ( input.LA(2) ) 
            	    {
            	    case 58:
            	    	{
            	        alt6 = 2;
            	        }
            	        break;
            	    case 78:
            	    case 79:
            	    	{
            	        alt6 = 4;
            	        }
            	        break;
            	    case 55:
            	    case 57:
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
            	case 81:
            		{
            	    alt6 = 5;
            	    }
            	    break;
            	case 82:
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:197:5: objectMethodCall
            	        {
            	        	PushFollow(FOLLOW_objectMethodCall_in_semicolonStatement420);
            	        	objectMethodCall18 = objectMethodCall();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectMethodCall18.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:198:4: methodCall
            	        {
            	        	PushFollow(FOLLOW_methodCall_in_semicolonStatement425);
            	        	methodCall19 = methodCall();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodCall19.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:199:4: assignmentList
            	        {
            	        	PushFollow(FOLLOW_assignmentList_in_semicolonStatement431);
            	        	assignmentList20 = assignmentList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentList20.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:200:4: unaryExpression
            	        {
            	        	PushFollow(FOLLOW_unaryExpression_in_semicolonStatement437);
            	        	unaryExpression21 = unaryExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression21.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:201:4: breakStat
            	        {
            	        	PushFollow(FOLLOW_breakStat_in_semicolonStatement443);
            	        	breakStat22 = breakStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, breakStat22.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:202:4: returnStat
            	        {
            	        	PushFollow(FOLLOW_returnStat_in_semicolonStatement448);
            	        	returnStat23 = returnStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnStat23.Tree);

            	        }
            	        break;

            	}

            	char_literal24=(IToken)Match(input,51,FOLLOW_51_in_semicolonStatement453); if (state.failed) return retval;

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:206:1: oneLineStatement : ( assignmentList | unaryExpression );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:207:2: ( assignmentList | unaryExpression )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:207:4: assignmentList
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignmentList_in_oneLineStatement466);
                    	assignmentList25 = assignmentList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentList25.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:208:4: unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpression_in_oneLineStatement471);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:211:1: assignmentList : 'var' assignment ( ',' assignment )* ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:212:2: ( 'var' assignment ( ',' assignment )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:212:4: 'var' assignment ( ',' assignment )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal27=(IToken)Match(input,VarStartInit,FOLLOW_VarStartInit_in_assignmentList486); if (state.failed) return retval;
            	PushFollow(FOLLOW_assignment_in_assignmentList489);
            	assignment28 = assignment();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment28.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:212:22: ( ',' assignment )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == 52) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:212:23: ',' assignment
            			    {
            			    	char_literal29=(IToken)Match(input,52,FOLLOW_52_in_assignmentList492); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_assignment_in_assignmentList495);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:216:1: globalAssignmentList : 'global' 'var' globalAssignment ( ',' globalAssignment )* ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:2: ( 'global' 'var' globalAssignment ( ',' globalAssignment )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:4: 'global' 'var' globalAssignment ( ',' globalAssignment )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal31=(IToken)Match(input,53,FOLLOW_53_in_globalAssignmentList511); if (state.failed) return retval;
            	string_literal32=(IToken)Match(input,VarStartInit,FOLLOW_VarStartInit_in_globalAssignmentList514); if (state.failed) return retval;
            	PushFollow(FOLLOW_globalAssignment_in_globalAssignmentList517);
            	globalAssignment33 = globalAssignment();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, globalAssignment33.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:38: ( ',' globalAssignment )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 52) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:39: ',' globalAssignment
            			    {
            			    	char_literal34=(IToken)Match(input,52,FOLLOW_52_in_globalAssignmentList520); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_globalAssignment_in_globalAssignmentList523);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:220:1: globalAssignment : variable ( indexes )? ( '=' expression )? -> ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? ) ;
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
        RewriteRuleTokenStream stream_54 = new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_indexes = new RewriteRuleSubtreeStream(adaptor,"rule indexes");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:2: ( variable ( indexes )? ( '=' expression )? -> ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:4: variable ( indexes )? ( '=' expression )?
            {
            	PushFollow(FOLLOW_variable_in_globalAssignment537);
            	variable36 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable36.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:13: ( indexes )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == 55) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_globalAssignment539);
            	        	indexes37 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes37.Tree);

            	        }
            	        break;

            	}

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:22: ( '=' expression )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 54) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:23: '=' expression
            	        {
            	        	char_literal38=(IToken)Match(input,54,FOLLOW_54_in_globalAssignment543); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_54.Add(char_literal38);

            	        	PushFollow(FOLLOW_expression_in_globalAssignment545);
            	        	expression39 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression39.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          variable, indexes, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 221:41: -> ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:44: ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(GLOBAL_ASSIGN, "GLOBAL_ASSIGN"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:69: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:78: ( expression )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:224:1: assignment : variable ( indexes )? ( '=' expression )? -> ^( ASSIGN variable ( indexes )? ( expression )? ) ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:2: ( variable ( indexes )? ( '=' expression )? -> ^( ASSIGN variable ( indexes )? ( expression )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:4: variable ( indexes )? ( '=' expression )?
            {
            	PushFollow(FOLLOW_variable_in_assignment576);
            	variable40 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable40.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:13: ( indexes )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == 55) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_assignment578);
            	        	indexes41 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes41.Tree);

            	        }
            	        break;

            	}

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:22: ( '=' expression )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == 54) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:23: '=' expression
            	        {
            	        	char_literal42=(IToken)Match(input,54,FOLLOW_54_in_assignment582); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_54.Add(char_literal42);

            	        	PushFollow(FOLLOW_expression_in_assignment584);
            	        	expression43 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression43.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          indexes, variable, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 225:41: -> ^( ASSIGN variable ( indexes )? ( expression )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:44: ^( ASSIGN variable ( indexes )? ( expression )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASSIGN, "ASSIGN"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:62: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:71: ( expression )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:228:1: indexes : ( '[' expression ']' )+ -> ^( INDEXES ( expression )+ ) ;
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
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:4: ( ( '[' expression ']' )+ -> ^( INDEXES ( expression )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:8: ( '[' expression ']' )+
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:8: ( '[' expression ']' )+
            	int cnt14 = 0;
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 55) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:9: '[' expression ']'
            			    {
            			    	char_literal44=(IToken)Match(input,55,FOLLOW_55_in_indexes619); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_55.Add(char_literal44);

            			    	PushFollow(FOLLOW_expression_in_indexes621);
            			    	expression45 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression45.Tree);
            			    	char_literal46=(IToken)Match(input,56,FOLLOW_56_in_indexes623); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_56.Add(char_literal46);


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
            	// 229:30: -> ^( INDEXES ( expression )+ )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:33: ^( INDEXES ( expression )+ )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:232:1: objectMethodCall : variable ( indexes )? '.' Identifier '(' ( expressionList )? ')' -> ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? ) ;
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
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:233:2: ( variable ( indexes )? '.' Identifier '(' ( expressionList )? ')' -> ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:233:4: variable ( indexes )? '.' Identifier '(' ( expressionList )? ')'
            {
            	PushFollow(FOLLOW_variable_in_objectMethodCall650);
            	variable47 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable47.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:233:13: ( indexes )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == 55) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_objectMethodCall652);
            	        	indexes48 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes48.Tree);

            	        }
            	        break;

            	}

            	char_literal49=(IToken)Match(input,57,FOLLOW_57_in_objectMethodCall655); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_57.Add(char_literal49);

            	Identifier50=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_objectMethodCall657); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier50);

            	char_literal51=(IToken)Match(input,58,FOLLOW_58_in_objectMethodCall659); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_58.Add(char_literal51);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:233:41: ( expressionList )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( ((LA16_0 >= Identifier && LA16_0 <= Null) || LA16_0 == 58 || LA16_0 == 72 || LA16_0 == 77 || LA16_0 == 80) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_objectMethodCall661);
            	        	expressionList52 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList52.Tree);

            	        }
            	        break;

            	}

            	char_literal53=(IToken)Match(input,59,FOLLOW_59_in_objectMethodCall664); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(char_literal53);



            	// AST REWRITE
            	// elements:          expressionList, indexes, Identifier, variable
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 233:61: -> ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:233:64: ^( OBJ_FUNC_CALL variable ( indexes )? Identifier ( expressionList )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(OBJ_FUNC_CALL, "OBJ_FUNC_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:233:89: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:233:109: ( expressionList )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:237:1: variable : Identifier -> Identifier ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:238:2: ( Identifier -> Identifier )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:238:4: Identifier
            {
            	Identifier54=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable698); if (state.failed) return retval; 
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
            	// 238:15: -> Identifier
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:243:1: stringAtom : StringAtom -> ^( STRING StringAtom ) ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:244:2: ( StringAtom -> ^( STRING StringAtom ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:244:6: StringAtom
            {
            	StringAtom55=(IToken)Match(input,StringAtom,FOLLOW_StringAtom_in_stringAtom721); if (state.failed) return retval; 
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
            	// 244:17: -> ^( STRING StringAtom )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:244:20: ^( STRING StringAtom )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:249:1: methodDef : 'method' Identifier '(' ( variableList )? ')' commonBlock ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:250:2: ( 'method' Identifier '(' ( variableList )? ')' commonBlock )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:250:4: 'method' Identifier '(' ( variableList )? ')' commonBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal56=(IToken)Match(input,60,FOLLOW_60_in_methodDef742); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal56_tree = (object)adaptor.Create(string_literal56);
            		adaptor.AddChild(root_0, string_literal56_tree);
            	}
            	Identifier57=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodDef744); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier57_tree = (object)adaptor.Create(Identifier57);
            		adaptor.AddChild(root_0, Identifier57_tree);
            	}
            	char_literal58=(IToken)Match(input,58,FOLLOW_58_in_methodDef746); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal58_tree = (object)adaptor.Create(char_literal58);
            		adaptor.AddChild(root_0, char_literal58_tree);
            	}
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:250:28: ( variableList )?
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
            	        	PushFollow(FOLLOW_variableList_in_methodDef748);
            	        	variableList59 = variableList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableList59.Tree);

            	        }
            	        break;

            	}

            	char_literal60=(IToken)Match(input,59,FOLLOW_59_in_methodDef751); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal60_tree = (object)adaptor.Create(char_literal60);
            		adaptor.AddChild(root_0, char_literal60_tree);
            	}
            	PushFollow(FOLLOW_commonBlock_in_methodDef753);
            	commonBlock61 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, commonBlock61.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   DefineMethod(((Identifier57 != null) ? Identifier57.Text : null), ((variableList59 != null) ? ((object)variableList59.Tree) : null), ((commonBlock61 != null) ? ((object)commonBlock61.Tree) : null)); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:269:1: expression : ( instantiateClass | conditionalExpression );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:270:5: ( instantiateClass | conditionalExpression )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == 80) )
            {
                alt18 = 1;
            }
            else if ( ((LA18_0 >= Identifier && LA18_0 <= Null) || LA18_0 == 58 || LA18_0 == 72 || LA18_0 == 77) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:270:7: instantiateClass
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_instantiateClass_in_expression790);
                    	instantiateClass62 = instantiateClass();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, instantiateClass62.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:271:7: conditionalExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalExpression_in_expression800);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:276:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:277:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:277:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression826);
            	conditionalOrExpression64 = conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression64.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:277:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt19 = 2;
            	int LA19_0 = input.LA(1);

            	if ( (LA19_0 == 61) )
            	{
            	    alt19 = 1;
            	}
            	switch (alt19) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:277:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	char_literal65=(IToken)Match(input,61,FOLLOW_61_in_conditionalExpression830); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal65_tree = (object)adaptor.Create(char_literal65);
            	        		root_0 = (object)adaptor.BecomeRoot(char_literal65_tree, root_0);
            	        	}
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression833);
            	        	conditionalExpression66 = conditionalExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression66.Tree);
            	        	char_literal67=(IToken)Match(input,62,FOLLOW_62_in_conditionalExpression835); if (state.failed) return retval;
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression838);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:282:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:283:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:283:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression881);
            	conditionalAndExpression69 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression69.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:283:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == 63) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:283:36: '||' conditionalAndExpression
            			    {
            			    	string_literal70=(IToken)Match(input,63,FOLLOW_63_in_conditionalOrExpression885); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal70_tree = (object)adaptor.Create(string_literal70);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal70_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression888);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:287:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:288:5: ( equalityExpression ( '&&' equalityExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:288:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression919);
            	equalityExpression72 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression72.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:288:28: ( '&&' equalityExpression )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:288:30: '&&' equalityExpression
            			    {
            			    	string_literal73=(IToken)Match(input,64,FOLLOW_64_in_conditionalAndExpression923); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal73_tree = (object)adaptor.Create(string_literal73);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal73_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression926);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:292:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:293:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:293:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression953);
            	relationalExpression75 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression75.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:293:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt23 = 2;
            	    int LA23_0 = input.LA(1);

            	    if ( ((LA23_0 >= 65 && LA23_0 <= 66)) )
            	    {
            	        alt23 = 1;
            	    }


            	    switch (alt23) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:293:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:293:32: ( '==' | '!=' )
            			    	int alt22 = 2;
            			    	int LA22_0 = input.LA(1);

            			    	if ( (LA22_0 == 65) )
            			    	{
            			    	    alt22 = 1;
            			    	}
            			    	else if ( (LA22_0 == 66) )
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
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:293:33: '=='
            			    	        {
            			    	        	string_literal76=(IToken)Match(input,65,FOLLOW_65_in_equalityExpression958); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal76_tree = (object)adaptor.Create(string_literal76);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal76_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:293:41: '!='
            			    	        {
            			    	        	string_literal77=(IToken)Match(input,66,FOLLOW_66_in_equalityExpression963); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal77_tree = (object)adaptor.Create(string_literal77);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal77_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression967);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:297:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:298:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:298:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression998);
            	additiveExpression79 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression79.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:298:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt25 = 2;
            	    int LA25_0 = input.LA(1);

            	    if ( ((LA25_0 >= 67 && LA25_0 <= 70)) )
            	    {
            	        alt25 = 1;
            	    }


            	    switch (alt25) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:298:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:298:29: ( '<' | '>' | '<=' | '>=' )
            			    	int alt24 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 67:
            			    		{
            			    	    alt24 = 1;
            			    	    }
            			    	    break;
            			    	case 68:
            			    		{
            			    	    alt24 = 2;
            			    	    }
            			    	    break;
            			    	case 69:
            			    		{
            			    	    alt24 = 3;
            			    	    }
            			    	    break;
            			    	case 70:
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
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:298:30: '<'
            			    	        {
            			    	        	char_literal80=(IToken)Match(input,67,FOLLOW_67_in_relationalExpression1002); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal80_tree = (object)adaptor.Create(char_literal80);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal80_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:298:35: '>'
            			    	        {
            			    	        	char_literal81=(IToken)Match(input,68,FOLLOW_68_in_relationalExpression1005); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal81_tree = (object)adaptor.Create(char_literal81);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal81_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:298:40: '<='
            			    	        {
            			    	        	string_literal82=(IToken)Match(input,69,FOLLOW_69_in_relationalExpression1008); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal82_tree = (object)adaptor.Create(string_literal82);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal82_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:298:46: '>='
            			    	        {
            			    	        	string_literal83=(IToken)Match(input,70,FOLLOW_70_in_relationalExpression1011); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal83_tree = (object)adaptor.Create(string_literal83);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal83_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1015);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:302:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:303:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:303:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1053);
            	multiplicativeExpression85 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression85.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:303:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt27 = 2;
            	    int LA27_0 = input.LA(1);

            	    if ( ((LA27_0 >= 71 && LA27_0 <= 72)) )
            	    {
            	        alt27 = 1;
            	    }


            	    switch (alt27) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:303:35: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:303:35: ( '+' | '-' )
            			    	int alt26 = 2;
            			    	int LA26_0 = input.LA(1);

            			    	if ( (LA26_0 == 71) )
            			    	{
            			    	    alt26 = 1;
            			    	}
            			    	else if ( (LA26_0 == 72) )
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
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:303:36: '+'
            			    	        {
            			    	        	char_literal86=(IToken)Match(input,71,FOLLOW_71_in_additiveExpression1057); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal86_tree = (object)adaptor.Create(char_literal86);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal86_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:303:41: '-'
            			    	        {
            			    	        	char_literal87=(IToken)Match(input,72,FOLLOW_72_in_additiveExpression1060); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal87_tree = (object)adaptor.Create(char_literal87);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal87_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1064);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:307:1: multiplicativeExpression : powExpression ( ( '*' | '/' | '%' ) powExpression )* ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:5: ( powExpression ( ( '*' | '/' | '%' ) powExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:9: powExpression ( ( '*' | '/' | '%' ) powExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_powExpression_in_multiplicativeExpression1098);
            	powExpression89 = powExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, powExpression89.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:23: ( ( '*' | '/' | '%' ) powExpression )*
            	do 
            	{
            	    int alt29 = 2;
            	    int LA29_0 = input.LA(1);

            	    if ( ((LA29_0 >= 73 && LA29_0 <= 75)) )
            	    {
            	        alt29 = 1;
            	    }


            	    switch (alt29) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:24: ( '*' | '/' | '%' ) powExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:24: ( '*' | '/' | '%' )
            			    	int alt28 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 73:
            			    		{
            			    	    alt28 = 1;
            			    	    }
            			    	    break;
            			    	case 74:
            			    		{
            			    	    alt28 = 2;
            			    	    }
            			    	    break;
            			    	case 75:
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
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:25: '*'
            			    	        {
            			    	        	char_literal90=(IToken)Match(input,73,FOLLOW_73_in_multiplicativeExpression1102); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal90_tree = (object)adaptor.Create(char_literal90);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal90_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:30: '/'
            			    	        {
            			    	        	char_literal91=(IToken)Match(input,74,FOLLOW_74_in_multiplicativeExpression1105); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal91_tree = (object)adaptor.Create(char_literal91);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal91_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:35: '%'
            			    	        {
            			    	        	char_literal92=(IToken)Match(input,75,FOLLOW_75_in_multiplicativeExpression1108); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal92_tree = (object)adaptor.Create(char_literal92);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal92_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_powExpression_in_multiplicativeExpression1112);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:311:1: powExpression : negateExpression ( '^' negateExpression )* ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:312:2: ( negateExpression ( '^' negateExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:312:4: negateExpression ( '^' negateExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_negateExpression_in_powExpression1132);
            	negateExpression94 = negateExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negateExpression94.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:312:21: ( '^' negateExpression )*
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( (LA30_0 == 76) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:312:22: '^' negateExpression
            			    {
            			    	char_literal95=(IToken)Match(input,76,FOLLOW_76_in_powExpression1135); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal95_tree = (object)adaptor.Create(char_literal95);
            			    		root_0 = (object)adaptor.BecomeRoot(char_literal95_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_negateExpression_in_powExpression1138);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:316:1: negateExpression : ( '-' mathAtom -> ^( INT_NEGATE mathAtom ) | '!' mathAtom -> ^( BOOL_NEGATE mathAtom ) | unaryExpression | mathAtom );
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
        RewriteRuleTokenStream stream_77 = new RewriteRuleTokenStream(adaptor,"token 77");
        RewriteRuleTokenStream stream_72 = new RewriteRuleTokenStream(adaptor,"token 72");
        RewriteRuleSubtreeStream stream_mathAtom = new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:317:2: ( '-' mathAtom -> ^( INT_NEGATE mathAtom ) | '!' mathAtom -> ^( BOOL_NEGATE mathAtom ) | unaryExpression | mathAtom )
            int alt31 = 4;
            switch ( input.LA(1) ) 
            {
            case 72:
            	{
                alt31 = 1;
                }
                break;
            case 77:
            	{
                alt31 = 2;
                }
                break;
            case Identifier:
            	{
                int LA31_3 = input.LA(2);

                if ( (LA31_3 == EOF || LA31_3 == Identifier || LA31_3 == VarStartInit || LA31_3 == 49 || (LA31_3 >= 51 && LA31_3 <= 52) || (LA31_3 >= 55 && LA31_3 <= 59) || (LA31_3 >= 61 && LA31_3 <= 76) || (LA31_3 >= 81 && LA31_3 <= 82)) )
                {
                    alt31 = 4;
                }
                else if ( ((LA31_3 >= 78 && LA31_3 <= 79)) )
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
            case 58:
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:317:4: '-' mathAtom
                    {
                    	char_literal97=(IToken)Match(input,72,FOLLOW_72_in_negateExpression1156); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_72.Add(char_literal97);

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1158);
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
                    	// 317:17: -> ^( INT_NEGATE mathAtom )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:317:20: ^( INT_NEGATE mathAtom )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:318:4: '!' mathAtom
                    {
                    	char_literal99=(IToken)Match(input,77,FOLLOW_77_in_negateExpression1171); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_77.Add(char_literal99);

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1173);
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
                    	// 318:17: -> ^( BOOL_NEGATE mathAtom )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:318:20: ^( BOOL_NEGATE mathAtom )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:319:4: unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpression_in_negateExpression1186);
                    	unaryExpression101 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression101.Tree);

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:320:4: mathAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1191);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:324:1: unaryExpression : variable ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) ) ;
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
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_78 = new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:325:5: ( variable ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:325:9: variable ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) )
            {
            	PushFollow(FOLLOW_variable_in_unaryExpression1209);
            	variable103 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable103.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:325:18: ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) )
            	int alt32 = 2;
            	int LA32_0 = input.LA(1);

            	if ( (LA32_0 == 78) )
            	{
            	    alt32 = 1;
            	}
            	else if ( (LA32_0 == 79) )
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:325:19: '++'
            	        {
            	        	string_literal104=(IToken)Match(input,78,FOLLOW_78_in_unaryExpression1212); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_78.Add(string_literal104);



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
            	        	// 325:24: -> ^( VARINC variable )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:325:27: ^( VARINC variable )
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:326:4: '--'
            	        {
            	        	string_literal105=(IToken)Match(input,79,FOLLOW_79_in_unaryExpression1225); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_79.Add(string_literal105);



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
            	        	// 326:9: -> ^( VARDEC variable )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:326:12: ^( VARDEC variable )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:331:1: mathAtom : ( '(' expression ')' | IntAtom | FloatAtom | BooleanAtom | stringAtom | LayerAtom | OriginAtom | LoopTypeAtom | ColorAtom | Null | lookup );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:332:2: ( '(' expression ')' | IntAtom | FloatAtom | BooleanAtom | stringAtom | LayerAtom | OriginAtom | LoopTypeAtom | ColorAtom | Null | lookup )
            int alt33 = 11;
            switch ( input.LA(1) ) 
            {
            case 58:
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:332:4: '(' expression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal106=(IToken)Match(input,58,FOLLOW_58_in_mathAtom1259); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expression_in_mathAtom1262);
                    	expression107 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression107.Tree);
                    	char_literal108=(IToken)Match(input,59,FOLLOW_59_in_mathAtom1264); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:333:7: IntAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IntAtom109=(IToken)Match(input,IntAtom,FOLLOW_IntAtom_in_mathAtom1276); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IntAtom109_tree = (object)adaptor.Create(IntAtom109);
                    		adaptor.AddChild(root_0, IntAtom109_tree);
                    	}

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:334:7: FloatAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FloatAtom110=(IToken)Match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1291); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FloatAtom110_tree = (object)adaptor.Create(FloatAtom110);
                    		adaptor.AddChild(root_0, FloatAtom110_tree);
                    	}

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:335:9: BooleanAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BooleanAtom111=(IToken)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1307); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BooleanAtom111_tree = (object)adaptor.Create(BooleanAtom111);
                    		adaptor.AddChild(root_0, BooleanAtom111_tree);
                    	}

                    }
                    break;
                case 5 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:336:4: stringAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stringAtom_in_mathAtom1318);
                    	stringAtom112 = stringAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, stringAtom112.Tree);

                    }
                    break;
                case 6 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:337:4: LayerAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LayerAtom113=(IToken)Match(input,LayerAtom,FOLLOW_LayerAtom_in_mathAtom1329); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LayerAtom113_tree = (object)adaptor.Create(LayerAtom113);
                    		adaptor.AddChild(root_0, LayerAtom113_tree);
                    	}

                    }
                    break;
                case 7 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:338:4: OriginAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	OriginAtom114=(IToken)Match(input,OriginAtom,FOLLOW_OriginAtom_in_mathAtom1340); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OriginAtom114_tree = (object)adaptor.Create(OriginAtom114);
                    		adaptor.AddChild(root_0, OriginAtom114_tree);
                    	}

                    }
                    break;
                case 8 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:339:4: LoopTypeAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LoopTypeAtom115=(IToken)Match(input,LoopTypeAtom,FOLLOW_LoopTypeAtom_in_mathAtom1351); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LoopTypeAtom115_tree = (object)adaptor.Create(LoopTypeAtom115);
                    		adaptor.AddChild(root_0, LoopTypeAtom115_tree);
                    	}

                    }
                    break;
                case 9 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:340:4: ColorAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ColorAtom116=(IToken)Match(input,ColorAtom,FOLLOW_ColorAtom_in_mathAtom1364); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ColorAtom116_tree = (object)adaptor.Create(ColorAtom116);
                    		adaptor.AddChild(root_0, ColorAtom116_tree);
                    	}

                    }
                    break;
                case 10 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:341:4: Null
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	Null117=(IToken)Match(input,Null,FOLLOW_Null_in_mathAtom1375); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Null117_tree = (object)adaptor.Create(Null117);
                    		adaptor.AddChild(root_0, Null117_tree);
                    	}

                    }
                    break;
                case 11 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:343:4: lookup
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lookup_in_mathAtom1389);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:346:1: lookup : ( objectMethodCall ( indexes )? -> ^( LOOKUP objectMethodCall ( indexes )? ) | methodCall ( indexes )? -> ^( LOOKUP methodCall ( indexes )? ) | variable ( indexes )? -> ^( LOOKUP variable ( indexes )? ) );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:347:2: ( objectMethodCall ( indexes )? -> ^( LOOKUP objectMethodCall ( indexes )? ) | methodCall ( indexes )? -> ^( LOOKUP methodCall ( indexes )? ) | variable ( indexes )? -> ^( LOOKUP variable ( indexes )? ) )
            int alt37 = 3;
            int LA37_0 = input.LA(1);

            if ( (LA37_0 == Identifier) )
            {
                int LA37_1 = input.LA(2);

                if ( (synpred56_SGL()) )
                {
                    alt37 = 1;
                }
                else if ( (synpred58_SGL()) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:347:4: objectMethodCall ( indexes )?
                    {
                    	PushFollow(FOLLOW_objectMethodCall_in_lookup1408);
                    	objectMethodCall119 = objectMethodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_objectMethodCall.Add(objectMethodCall119.Tree);
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:347:21: ( indexes )?
                    	int alt34 = 2;
                    	int LA34_0 = input.LA(1);

                    	if ( (LA34_0 == 55) )
                    	{
                    	    alt34 = 1;
                    	}
                    	switch (alt34) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1410);
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
                    	// 347:30: -> ^( LOOKUP objectMethodCall ( indexes )? )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:347:33: ^( LOOKUP objectMethodCall ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_objectMethodCall.NextTree());
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:347:59: ( indexes )?
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:348:4: methodCall ( indexes )?
                    {
                    	PushFollow(FOLLOW_methodCall_in_lookup1427);
                    	methodCall121 = methodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_methodCall.Add(methodCall121.Tree);
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:348:15: ( indexes )?
                    	int alt35 = 2;
                    	int LA35_0 = input.LA(1);

                    	if ( (LA35_0 == 55) )
                    	{
                    	    alt35 = 1;
                    	}
                    	switch (alt35) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1429);
                    	        	indexes122 = indexes();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes122.Tree);

                    	        }
                    	        break;

                    	}



                    	// AST REWRITE
                    	// elements:          methodCall, indexes
                    	// token labels:      
                    	// rule labels:       retval
                    	// token list labels: 
                    	// rule list labels:  
                    	// wildcard labels: 
                    	if ( (state.backtracking==0) ) {
                    	retval.Tree = root_0;
                    	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

                    	root_0 = (object)adaptor.GetNilNode();
                    	// 348:24: -> ^( LOOKUP methodCall ( indexes )? )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:348:27: ^( LOOKUP methodCall ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_methodCall.NextTree());
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:348:47: ( indexes )?
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:349:4: variable ( indexes )?
                    {
                    	PushFollow(FOLLOW_variable_in_lookup1447);
                    	variable123 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_variable.Add(variable123.Tree);
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:349:13: ( indexes )?
                    	int alt36 = 2;
                    	int LA36_0 = input.LA(1);

                    	if ( (LA36_0 == 55) )
                    	{
                    	    alt36 = 1;
                    	}
                    	switch (alt36) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1449);
                    	        	indexes124 = indexes();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes124.Tree);

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
                    	// 349:22: -> ^( LOOKUP variable ( indexes )? )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:349:25: ^( LOOKUP variable ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_variable.NextTree());
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:349:43: ( indexes )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:356:1: instantiateClass : 'new' ( Sprite '(' ( expressionList )? ')' -> ^( Sprite ( expressionList )? ) | Animation '(' ( expressionList )? ')' -> ^( Animation ( expressionList )? ) | List '(' ( expressionList )? ')' -> ^( List ( expressionList )? ) ) ;
    public SGLParser.instantiateClass_return instantiateClass() // throws RecognitionException [1]
    {   
        SGLParser.instantiateClass_return retval = new SGLParser.instantiateClass_return();
        retval.Start = input.LT(1);
        int instantiateClass_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal125 = null;
        IToken Sprite126 = null;
        IToken char_literal127 = null;
        IToken char_literal129 = null;
        IToken Animation130 = null;
        IToken char_literal131 = null;
        IToken char_literal133 = null;
        IToken List134 = null;
        IToken char_literal135 = null;
        IToken char_literal137 = null;
        SGLParser.expressionList_return expressionList128 = default(SGLParser.expressionList_return);

        SGLParser.expressionList_return expressionList132 = default(SGLParser.expressionList_return);

        SGLParser.expressionList_return expressionList136 = default(SGLParser.expressionList_return);


        object string_literal125_tree=null;
        object Sprite126_tree=null;
        object char_literal127_tree=null;
        object char_literal129_tree=null;
        object Animation130_tree=null;
        object char_literal131_tree=null;
        object char_literal133_tree=null;
        object List134_tree=null;
        object char_literal135_tree=null;
        object char_literal137_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleTokenStream stream_Animation = new RewriteRuleTokenStream(adaptor,"token Animation");
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_List = new RewriteRuleTokenStream(adaptor,"token List");
        RewriteRuleTokenStream stream_Sprite = new RewriteRuleTokenStream(adaptor,"token Sprite");
        RewriteRuleSubtreeStream stream_expressionList = new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:357:2: ( 'new' ( Sprite '(' ( expressionList )? ')' -> ^( Sprite ( expressionList )? ) | Animation '(' ( expressionList )? ')' -> ^( Animation ( expressionList )? ) | List '(' ( expressionList )? ')' -> ^( List ( expressionList )? ) ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:357:4: 'new' ( Sprite '(' ( expressionList )? ')' -> ^( Sprite ( expressionList )? ) | Animation '(' ( expressionList )? ')' -> ^( Animation ( expressionList )? ) | List '(' ( expressionList )? ')' -> ^( List ( expressionList )? ) )
            {
            	string_literal125=(IToken)Match(input,80,FOLLOW_80_in_instantiateClass1493); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_80.Add(string_literal125);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:358:2: ( Sprite '(' ( expressionList )? ')' -> ^( Sprite ( expressionList )? ) | Animation '(' ( expressionList )? ')' -> ^( Animation ( expressionList )? ) | List '(' ( expressionList )? ')' -> ^( List ( expressionList )? ) )
            	int alt41 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case Sprite:
            		{
            	    alt41 = 1;
            	    }
            	    break;
            	case Animation:
            		{
            	    alt41 = 2;
            	    }
            	    break;
            	case List:
            		{
            	    alt41 = 3;
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    NoViableAltException nvae_d41s0 =
            		        new NoViableAltException("", 41, 0, input);

            		    throw nvae_d41s0;
            	}

            	switch (alt41) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:358:4: Sprite '(' ( expressionList )? ')'
            	        {
            	        	Sprite126=(IToken)Match(input,Sprite,FOLLOW_Sprite_in_instantiateClass1498); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_Sprite.Add(Sprite126);

            	        	char_literal127=(IToken)Match(input,58,FOLLOW_58_in_instantiateClass1500); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_58.Add(char_literal127);

            	        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:358:15: ( expressionList )?
            	        	int alt38 = 2;
            	        	int LA38_0 = input.LA(1);

            	        	if ( ((LA38_0 >= Identifier && LA38_0 <= Null) || LA38_0 == 58 || LA38_0 == 72 || LA38_0 == 77 || LA38_0 == 80) )
            	        	{
            	        	    alt38 = 1;
            	        	}
            	        	switch (alt38) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        	        {
            	        	        	PushFollow(FOLLOW_expressionList_in_instantiateClass1502);
            	        	        	expressionList128 = expressionList();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList128.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	char_literal129=(IToken)Match(input,59,FOLLOW_59_in_instantiateClass1505); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_59.Add(char_literal129);



            	        	// AST REWRITE
            	        	// elements:          Sprite, expressionList
            	        	// token labels:      
            	        	// rule labels:       retval
            	        	// token list labels: 
            	        	// rule list labels:  
            	        	// wildcard labels: 
            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = root_0;
            	        	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	        	root_0 = (object)adaptor.GetNilNode();
            	        	// 358:35: -> ^( Sprite ( expressionList )? )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:358:38: ^( Sprite ( expressionList )? )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot(stream_Sprite.NextNode(), root_1);

            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:358:47: ( expressionList )?
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
            	        break;
            	    case 2 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:359:4: Animation '(' ( expressionList )? ')'
            	        {
            	        	Animation130=(IToken)Match(input,Animation,FOLLOW_Animation_in_instantiateClass1519); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_Animation.Add(Animation130);

            	        	char_literal131=(IToken)Match(input,58,FOLLOW_58_in_instantiateClass1521); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_58.Add(char_literal131);

            	        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:359:18: ( expressionList )?
            	        	int alt39 = 2;
            	        	int LA39_0 = input.LA(1);

            	        	if ( ((LA39_0 >= Identifier && LA39_0 <= Null) || LA39_0 == 58 || LA39_0 == 72 || LA39_0 == 77 || LA39_0 == 80) )
            	        	{
            	        	    alt39 = 1;
            	        	}
            	        	switch (alt39) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        	        {
            	        	        	PushFollow(FOLLOW_expressionList_in_instantiateClass1523);
            	        	        	expressionList132 = expressionList();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList132.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	char_literal133=(IToken)Match(input,59,FOLLOW_59_in_instantiateClass1526); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_59.Add(char_literal133);



            	        	// AST REWRITE
            	        	// elements:          expressionList, Animation
            	        	// token labels:      
            	        	// rule labels:       retval
            	        	// token list labels: 
            	        	// rule list labels:  
            	        	// wildcard labels: 
            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = root_0;
            	        	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	        	root_0 = (object)adaptor.GetNilNode();
            	        	// 359:38: -> ^( Animation ( expressionList )? )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:359:41: ^( Animation ( expressionList )? )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot(stream_Animation.NextNode(), root_1);

            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:359:53: ( expressionList )?
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
            	        break;
            	    case 3 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:360:4: List '(' ( expressionList )? ')'
            	        {
            	        	List134=(IToken)Match(input,List,FOLLOW_List_in_instantiateClass1540); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_List.Add(List134);

            	        	char_literal135=(IToken)Match(input,58,FOLLOW_58_in_instantiateClass1542); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_58.Add(char_literal135);

            	        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:360:13: ( expressionList )?
            	        	int alt40 = 2;
            	        	int LA40_0 = input.LA(1);

            	        	if ( ((LA40_0 >= Identifier && LA40_0 <= Null) || LA40_0 == 58 || LA40_0 == 72 || LA40_0 == 77 || LA40_0 == 80) )
            	        	{
            	        	    alt40 = 1;
            	        	}
            	        	switch (alt40) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        	        {
            	        	        	PushFollow(FOLLOW_expressionList_in_instantiateClass1544);
            	        	        	expressionList136 = expressionList();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList136.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	char_literal137=(IToken)Match(input,59,FOLLOW_59_in_instantiateClass1547); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_59.Add(char_literal137);



            	        	// AST REWRITE
            	        	// elements:          List, expressionList
            	        	// token labels:      
            	        	// rule labels:       retval
            	        	// token list labels: 
            	        	// rule list labels:  
            	        	// wildcard labels: 
            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = root_0;
            	        	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	        	root_0 = (object)adaptor.GetNilNode();
            	        	// 360:33: -> ^( List ( expressionList )? )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:360:36: ^( List ( expressionList )? )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot(stream_List.NextNode(), root_1);

            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:360:43: ( expressionList )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:372:1: expressionList : expression ( ',' expression )* -> ^( EXP_LIST ( expression )+ ) ;
    public SGLParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.Start = input.LT(1);
        int expressionList_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal139 = null;
        SGLParser.expression_return expression138 = default(SGLParser.expression_return);

        SGLParser.expression_return expression140 = default(SGLParser.expression_return);


        object char_literal139_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:373:3: ( expression ( ',' expression )* -> ^( EXP_LIST ( expression )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:373:7: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList1586);
            	expression138 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression138.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:373:18: ( ',' expression )*
            	do 
            	{
            	    int alt42 = 2;
            	    int LA42_0 = input.LA(1);

            	    if ( (LA42_0 == 52) )
            	    {
            	        alt42 = 1;
            	    }


            	    switch (alt42) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:373:19: ',' expression
            			    {
            			    	char_literal139=(IToken)Match(input,52,FOLLOW_52_in_expressionList1589); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_52.Add(char_literal139);

            			    	PushFollow(FOLLOW_expression_in_expressionList1591);
            			    	expression140 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression140.Tree);

            			    }
            			    break;

            			default:
            			    goto loop42;
            	    }
            	} while (true);

            	loop42:
            		;	// Stops C# compiler whining that label 'loop42' has no statements



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
            	// 373:36: -> ^( EXP_LIST ( expression )+ )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:373:39: ^( EXP_LIST ( expression )+ )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:377:1: variableList : variable ( ',' variable )* -> ^( VAR_LIST ( variable )+ ) ;
    public SGLParser.variableList_return variableList() // throws RecognitionException [1]
    {   
        SGLParser.variableList_return retval = new SGLParser.variableList_return();
        retval.Start = input.LT(1);
        int variableList_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal142 = null;
        SGLParser.variable_return variable141 = default(SGLParser.variable_return);

        SGLParser.variable_return variable143 = default(SGLParser.variable_return);


        object char_literal142_tree=null;
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:378:3: ( variable ( ',' variable )* -> ^( VAR_LIST ( variable )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:378:5: variable ( ',' variable )*
            {
            	PushFollow(FOLLOW_variable_in_variableList1619);
            	variable141 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable141.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:378:14: ( ',' variable )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( (LA43_0 == 52) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:378:15: ',' variable
            			    {
            			    	char_literal142=(IToken)Match(input,52,FOLLOW_52_in_variableList1622); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_52.Add(char_literal142);

            			    	PushFollow(FOLLOW_variable_in_variableList1624);
            			    	variable143 = variable();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_variable.Add(variable143.Tree);

            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements



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
            	// 378:30: -> ^( VAR_LIST ( variable )+ )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:378:33: ^( VAR_LIST ( variable )+ )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:381:1: methodCall : Identifier '(' ( expressionList )? ')' -> ^( FUNC_CALL Identifier ( expressionList )? ) ;
    public SGLParser.methodCall_return methodCall() // throws RecognitionException [1]
    {   
        SGLParser.methodCall_return retval = new SGLParser.methodCall_return();
        retval.Start = input.LT(1);
        int methodCall_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier144 = null;
        IToken char_literal145 = null;
        IToken char_literal147 = null;
        SGLParser.expressionList_return expressionList146 = default(SGLParser.expressionList_return);


        object Identifier144_tree=null;
        object char_literal145_tree=null;
        object char_literal147_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_expressionList = new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:382:2: ( Identifier '(' ( expressionList )? ')' -> ^( FUNC_CALL Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:382:4: Identifier '(' ( expressionList )? ')'
            {
            	Identifier144=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodCall1647); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier144);

            	char_literal145=(IToken)Match(input,58,FOLLOW_58_in_methodCall1649); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_58.Add(char_literal145);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:382:19: ( expressionList )?
            	int alt44 = 2;
            	int LA44_0 = input.LA(1);

            	if ( ((LA44_0 >= Identifier && LA44_0 <= Null) || LA44_0 == 58 || LA44_0 == 72 || LA44_0 == 77 || LA44_0 == 80) )
            	{
            	    alt44 = 1;
            	}
            	switch (alt44) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_methodCall1651);
            	        	expressionList146 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList146.Tree);

            	        }
            	        break;

            	}

            	char_literal147=(IToken)Match(input,59,FOLLOW_59_in_methodCall1654); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(char_literal147);



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
            	// 382:39: -> ^( FUNC_CALL Identifier ( expressionList )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:382:42: ^( FUNC_CALL Identifier ( expressionList )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(FUNC_CALL, "FUNC_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:382:65: ( expressionList )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:387:1: breakStat : 'break' -> BREAK ;
    public SGLParser.breakStat_return breakStat() // throws RecognitionException [1]
    {   
        SGLParser.breakStat_return retval = new SGLParser.breakStat_return();
        retval.Start = input.LT(1);
        int breakStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal148 = null;

        object string_literal148_tree=null;
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:388:2: ( 'break' -> BREAK )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:388:4: 'break'
            {
            	string_literal148=(IToken)Match(input,81,FOLLOW_81_in_breakStat1681); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_81.Add(string_literal148);



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
            	// 388:12: -> BREAK
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:391:1: returnStat : 'return' expression -> ^( RETURN expression ) ;
    public SGLParser.returnStat_return returnStat() // throws RecognitionException [1]
    {   
        SGLParser.returnStat_return retval = new SGLParser.returnStat_return();
        retval.Start = input.LT(1);
        int returnStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal149 = null;
        SGLParser.expression_return expression150 = default(SGLParser.expression_return);


        object string_literal149_tree=null;
        RewriteRuleTokenStream stream_82 = new RewriteRuleTokenStream(adaptor,"token 82");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:392:2: ( 'return' expression -> ^( RETURN expression ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:392:4: 'return' expression
            {
            	string_literal149=(IToken)Match(input,82,FOLLOW_82_in_returnStat1696); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_82.Add(string_literal149);

            	PushFollow(FOLLOW_expression_in_returnStat1698);
            	expression150 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression150.Tree);


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
            	// 392:24: -> ^( RETURN expression )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:392:27: ^( RETURN expression )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:396:1: whileLoop : 'while' expression commonBlock -> ^( 'while' expression commonBlock ) ;
    public SGLParser.whileLoop_return whileLoop() // throws RecognitionException [1]
    {   
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.Start = input.LT(1);
        int whileLoop_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal151 = null;
        SGLParser.expression_return expression152 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock153 = default(SGLParser.commonBlock_return);


        object string_literal151_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:397:2: ( 'while' expression commonBlock -> ^( 'while' expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:397:4: 'while' expression commonBlock
            {
            	string_literal151=(IToken)Match(input,83,FOLLOW_83_in_whileLoop1721); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(string_literal151);

            	PushFollow(FOLLOW_expression_in_whileLoop1723);
            	expression152 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression152.Tree);
            	PushFollow(FOLLOW_commonBlock_in_whileLoop1725);
            	commonBlock153 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock153.Tree);


            	// AST REWRITE
            	// elements:          83, commonBlock, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 397:35: -> ^( 'while' expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:397:38: ^( 'while' expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_83.NextNode(), root_1);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:400:1: forLoop : 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) ;
    public SGLParser.forLoop_return forLoop() // throws RecognitionException [1]
    {   
        SGLParser.forLoop_return retval = new SGLParser.forLoop_return();
        retval.Start = input.LT(1);
        int forLoop_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal154 = null;
        IToken char_literal155 = null;
        IToken char_literal156 = null;
        IToken char_literal157 = null;
        IToken char_literal158 = null;
        SGLParser.oneLineStatement_return dec = default(SGLParser.oneLineStatement_return);

        SGLParser.expression_return cond = default(SGLParser.expression_return);

        SGLParser.oneLineStatement_return iter = default(SGLParser.oneLineStatement_return);

        SGLParser.commonBlock_return commonBlock159 = default(SGLParser.commonBlock_return);


        object string_literal154_tree=null;
        object char_literal155_tree=null;
        object char_literal156_tree=null;
        object char_literal157_tree=null;
        object char_literal158_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_58 = new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleTokenStream stream_51 = new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        RewriteRuleSubtreeStream stream_oneLineStatement = new RewriteRuleSubtreeStream(adaptor,"rule oneLineStatement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:401:2: ( 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:401:4: 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock
            {
            	string_literal154=(IToken)Match(input,84,FOLLOW_84_in_forLoop1747); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_84.Add(string_literal154);

            	char_literal155=(IToken)Match(input,58,FOLLOW_58_in_forLoop1749); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_58.Add(char_literal155);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:401:17: (dec= oneLineStatement )?
            	int alt45 = 2;
            	int LA45_0 = input.LA(1);

            	if ( (LA45_0 == Identifier || LA45_0 == VarStartInit) )
            	{
            	    alt45 = 1;
            	}
            	switch (alt45) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: dec= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop1753);
            	        	dec = oneLineStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_oneLineStatement.Add(dec.Tree);

            	        }
            	        break;

            	}

            	char_literal156=(IToken)Match(input,51,FOLLOW_51_in_forLoop1756); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal156);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:401:44: (cond= expression )?
            	int alt46 = 2;
            	int LA46_0 = input.LA(1);

            	if ( ((LA46_0 >= Identifier && LA46_0 <= Null) || LA46_0 == 58 || LA46_0 == 72 || LA46_0 == 77 || LA46_0 == 80) )
            	{
            	    alt46 = 1;
            	}
            	switch (alt46) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: cond= expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forLoop1760);
            	        	cond = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(cond.Tree);

            	        }
            	        break;

            	}

            	char_literal157=(IToken)Match(input,51,FOLLOW_51_in_forLoop1763); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_51.Add(char_literal157);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:401:65: (iter= oneLineStatement )?
            	int alt47 = 2;
            	int LA47_0 = input.LA(1);

            	if ( (LA47_0 == Identifier || LA47_0 == VarStartInit) )
            	{
            	    alt47 = 1;
            	}
            	switch (alt47) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: iter= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop1767);
            	        	iter = oneLineStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_oneLineStatement.Add(iter.Tree);

            	        }
            	        break;

            	}

            	char_literal158=(IToken)Match(input,59,FOLLOW_59_in_forLoop1770); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(char_literal158);

            	PushFollow(FOLLOW_commonBlock_in_forLoop1772);
            	commonBlock159 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock159.Tree);


            	// AST REWRITE
            	// elements:          cond, commonBlock, dec, iter, 84
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
            	// 402:2: -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:5: ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_84.NextNode(), root_1);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:13: ^( FORDEC ( $dec)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORDEC, "FORDEC"), root_2);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:22: ( $dec)?
            	    if ( stream_dec.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_dec.NextTree());

            	    }
            	    stream_dec.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:29: ^( FORCOND ( $cond)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORCOND, "FORCOND"), root_2);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:39: ( $cond)?
            	    if ( stream_cond.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_cond.NextTree());

            	    }
            	    stream_cond.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:47: ^( FORITER ( $iter)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORITER, "FORITER"), root_2);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:57: ( $iter)?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:405:1: ifStatement : ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) ;
    public SGLParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        SGLParser.ifStatement_return retval = new SGLParser.ifStatement_return();
        retval.Start = input.LT(1);
        int ifStatement_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.ifStat_return ifStat160 = default(SGLParser.ifStat_return);

        SGLParser.elseIfStat_return elseIfStat161 = default(SGLParser.elseIfStat_return);

        SGLParser.elseStat_return elseStat162 = default(SGLParser.elseStat_return);


        RewriteRuleSubtreeStream stream_elseIfStat = new RewriteRuleSubtreeStream(adaptor,"rule elseIfStat");
        RewriteRuleSubtreeStream stream_ifStat = new RewriteRuleSubtreeStream(adaptor,"rule ifStat");
        RewriteRuleSubtreeStream stream_elseStat = new RewriteRuleSubtreeStream(adaptor,"rule elseStat");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:406:2: ( ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:406:4: ifStat ( elseIfStat )* ( elseStat )?
            {
            	PushFollow(FOLLOW_ifStat_in_ifStatement1817);
            	ifStat160 = ifStat();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ifStat.Add(ifStat160.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:406:11: ( elseIfStat )*
            	do 
            	{
            	    int alt48 = 2;
            	    int LA48_0 = input.LA(1);

            	    if ( (LA48_0 == 86) )
            	    {
            	        int LA48_1 = input.LA(2);

            	        if ( (LA48_1 == 85) )
            	        {
            	            alt48 = 1;
            	        }


            	    }


            	    switch (alt48) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: elseIfStat
            			    {
            			    	PushFollow(FOLLOW_elseIfStat_in_ifStatement1819);
            			    	elseIfStat161 = elseIfStat();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_elseIfStat.Add(elseIfStat161.Tree);

            			    }
            			    break;

            			default:
            			    goto loop48;
            	    }
            	} while (true);

            	loop48:
            		;	// Stops C# compiler whining that label 'loop48' has no statements

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:406:23: ( elseStat )?
            	int alt49 = 2;
            	int LA49_0 = input.LA(1);

            	if ( (LA49_0 == 86) )
            	{
            	    alt49 = 1;
            	}
            	switch (alt49) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: elseStat
            	        {
            	        	PushFollow(FOLLOW_elseStat_in_ifStatement1822);
            	        	elseStat162 = elseStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_elseStat.Add(elseStat162.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          ifStat, elseIfStat, elseStat
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 406:33: -> ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:406:36: ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF, "IF"), root_1);

            	    adaptor.AddChild(root_1, stream_ifStat.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:406:48: ( elseIfStat )*
            	    while ( stream_elseIfStat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_elseIfStat.NextTree());

            	    }
            	    stream_elseIfStat.Reset();
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:406:60: ( elseStat )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:408:1: ifStat : 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.ifStat_return ifStat() // throws RecognitionException [1]
    {   
        SGLParser.ifStat_return retval = new SGLParser.ifStat_return();
        retval.Start = input.LT(1);
        int ifStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal163 = null;
        SGLParser.expression_return expression164 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock165 = default(SGLParser.commonBlock_return);


        object string_literal163_tree=null;
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:409:2: ( 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:409:4: 'if' expression commonBlock
            {
            	string_literal163=(IToken)Match(input,85,FOLLOW_85_in_ifStat1847); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal163);

            	PushFollow(FOLLOW_expression_in_ifStat1849);
            	expression164 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression164.Tree);
            	PushFollow(FOLLOW_commonBlock_in_ifStat1851);
            	commonBlock165 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock165.Tree);


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
            	// 409:32: -> ^( EXP expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:409:35: ^( EXP expression commonBlock )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:412:1: elseIfStat : 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.elseIfStat_return elseIfStat() // throws RecognitionException [1]
    {   
        SGLParser.elseIfStat_return retval = new SGLParser.elseIfStat_return();
        retval.Start = input.LT(1);
        int elseIfStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal166 = null;
        IToken string_literal167 = null;
        SGLParser.expression_return expression168 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock169 = default(SGLParser.commonBlock_return);


        object string_literal166_tree=null;
        object string_literal167_tree=null;
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:413:2: ( 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:413:4: 'else' 'if' expression commonBlock
            {
            	string_literal166=(IToken)Match(input,86,FOLLOW_86_in_elseIfStat1872); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(string_literal166);

            	string_literal167=(IToken)Match(input,85,FOLLOW_85_in_elseIfStat1874); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal167);

            	PushFollow(FOLLOW_expression_in_elseIfStat1876);
            	expression168 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression168.Tree);
            	PushFollow(FOLLOW_commonBlock_in_elseIfStat1878);
            	commonBlock169 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock169.Tree);


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
            	// 413:39: -> ^( EXP expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:413:42: ^( EXP expression commonBlock )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:416:1: elseStat : 'else' commonBlock -> ^( EXP commonBlock ) ;
    public SGLParser.elseStat_return elseStat() // throws RecognitionException [1]
    {   
        SGLParser.elseStat_return retval = new SGLParser.elseStat_return();
        retval.Start = input.LT(1);
        int elseStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal170 = null;
        SGLParser.commonBlock_return commonBlock171 = default(SGLParser.commonBlock_return);


        object string_literal170_tree=null;
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:417:2: ( 'else' commonBlock -> ^( EXP commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:417:4: 'else' commonBlock
            {
            	string_literal170=(IToken)Match(input,86,FOLLOW_86_in_elseStat1900); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(string_literal170);

            	PushFollow(FOLLOW_commonBlock_in_elseStat1902);
            	commonBlock171 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock171.Tree);


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
            	// 417:23: -> ^( EXP commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:417:26: ^( EXP commonBlock )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:424:1: atStatement : 'at' expression commonBlock -> ^( AT expression commonBlock ) ;
    public SGLParser.atStatement_return atStatement() // throws RecognitionException [1]
    {   
        SGLParser.atStatement_return retval = new SGLParser.atStatement_return();
        retval.Start = input.LT(1);
        int atStatement_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal172 = null;
        SGLParser.expression_return expression173 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock174 = default(SGLParser.commonBlock_return);


        object string_literal172_tree=null;
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:425:2: ( 'at' expression commonBlock -> ^( AT expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:425:4: 'at' expression commonBlock
            {
            	string_literal172=(IToken)Match(input,87,FOLLOW_87_in_atStatement1927); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_87.Add(string_literal172);

            	PushFollow(FOLLOW_expression_in_atStatement1929);
            	expression173 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression173.Tree);
            	PushFollow(FOLLOW_commonBlock_in_atStatement1931);
            	commonBlock174 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock174.Tree);


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
            	// 425:32: -> ^( AT expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:425:35: ^( AT expression commonBlock )
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

    // $ANTLR start "synpred56_SGL"
    public void synpred56_SGL_fragment() {
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:347:4: ( objectMethodCall ( indexes )? )
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:347:4: objectMethodCall ( indexes )?
        {
        	PushFollow(FOLLOW_objectMethodCall_in_synpred56_SGL1408);
        	objectMethodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:347:21: ( indexes )?
        	int alt50 = 2;
        	int LA50_0 = input.LA(1);

        	if ( (LA50_0 == 55) )
        	{
        	    alt50 = 1;
        	}
        	switch (alt50) 
        	{
        	    case 1 :
        	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
        	        {
        	        	PushFollow(FOLLOW_indexes_in_synpred56_SGL1410);
        	        	indexes();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred56_SGL"

    // $ANTLR start "synpred58_SGL"
    public void synpred58_SGL_fragment() {
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:348:4: ( methodCall ( indexes )? )
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:348:4: methodCall ( indexes )?
        {
        	PushFollow(FOLLOW_methodCall_in_synpred58_SGL1427);
        	methodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:348:15: ( indexes )?
        	int alt51 = 2;
        	int LA51_0 = input.LA(1);

        	if ( (LA51_0 == 55) )
        	{
        	    alt51 = 1;
        	}
        	switch (alt51) 
        	{
        	    case 1 :
        	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
        	        {
        	        	PushFollow(FOLLOW_indexes_in_synpred58_SGL1429);
        	        	indexes();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred58_SGL"

    // Delegated rules

   	public bool synpred56_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred56_SGL_fragment(); // can never throw exception
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
   	public bool synpred58_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred58_SGL_fragment(); // can never throw exception
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

 

    public static readonly BitSet FOLLOW_mainBlock_in_main230 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mainStatement_in_mainBlock250 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodDef_in_mainBlock254 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_block290 = new BitSet(new ulong[]{0x0000020010000002UL,0x0000000000BE0000UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_singleBlock315 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_singleBlock_in_commonBlock338 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_commonBlock343 = new BitSet(new ulong[]{0x0000020010000000UL,0x0000000000BE0000UL});
    public static readonly BitSet FOLLOW_block_in_commonBlock346 = new BitSet(new ulong[]{0x0004000000000000UL});
    public static readonly BitSet FOLLOW_50_in_commonBlock348 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_mainStatement365 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_globalAssignmentList_in_mainStatement370 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_mainStatement372 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_statement387 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atStatement_in_statement397 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forLoop_in_statement407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_semicolonStatement420 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_methodCall_in_semicolonStatement425 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_assignmentList_in_semicolonStatement431 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_semicolonStatement437 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_breakStat_in_semicolonStatement443 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_returnStat_in_semicolonStatement448 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_semicolonStatement453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignmentList_in_oneLineStatement466 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_oneLineStatement471 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VarStartInit_in_assignmentList486 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_assignment_in_assignmentList489 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_52_in_assignmentList492 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_assignment_in_assignmentList495 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_53_in_globalAssignmentList511 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_VarStartInit_in_globalAssignmentList514 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_globalAssignment_in_globalAssignmentList517 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_52_in_globalAssignmentList520 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_globalAssignment_in_globalAssignmentList523 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_globalAssignment537 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_globalAssignment539 = new BitSet(new ulong[]{0x0040000000000002UL});
    public static readonly BitSet FOLLOW_54_in_globalAssignment543 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expression_in_globalAssignment545 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment576 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_assignment578 = new BitSet(new ulong[]{0x0040000000000002UL});
    public static readonly BitSet FOLLOW_54_in_assignment582 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expression_in_assignment584 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_indexes619 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expression_in_indexes621 = new BitSet(new ulong[]{0x0100000000000000UL});
    public static readonly BitSet FOLLOW_56_in_indexes623 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_objectMethodCall650 = new BitSet(new ulong[]{0x0280000000000000UL});
    public static readonly BitSet FOLLOW_indexes_in_objectMethodCall652 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_objectMethodCall655 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethodCall657 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_objectMethodCall659 = new BitSet(new ulong[]{0x0C00003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expressionList_in_objectMethodCall661 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_objectMethodCall664 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable698 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringAtom_in_stringAtom721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_60_in_methodDef742 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodDef744 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_methodDef746 = new BitSet(new ulong[]{0x0800000010000000UL});
    public static readonly BitSet FOLLOW_variableList_in_methodDef748 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_methodDef751 = new BitSet(new ulong[]{0x0002020010000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_methodDef753 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_instantiateClass_in_expression790 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression800 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression826 = new BitSet(new ulong[]{0x2000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_conditionalExpression830 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression833 = new BitSet(new ulong[]{0x4000000000000000UL});
    public static readonly BitSet FOLLOW_62_in_conditionalExpression835 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression838 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression881 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_conditionalOrExpression885 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression888 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression919 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_conditionalAndExpression923 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression926 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression953 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000006UL});
    public static readonly BitSet FOLLOW_65_in_equalityExpression958 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_66_in_equalityExpression963 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression967 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000006UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression998 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000078UL});
    public static readonly BitSet FOLLOW_67_in_relationalExpression1002 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_68_in_relationalExpression1005 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_69_in_relationalExpression1008 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_70_in_relationalExpression1011 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1015 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000078UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1053 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000180UL});
    public static readonly BitSet FOLLOW_71_in_additiveExpression1057 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_72_in_additiveExpression1060 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1064 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000180UL});
    public static readonly BitSet FOLLOW_powExpression_in_multiplicativeExpression1098 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000E00UL});
    public static readonly BitSet FOLLOW_73_in_multiplicativeExpression1102 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_74_in_multiplicativeExpression1105 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_75_in_multiplicativeExpression1108 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_powExpression_in_multiplicativeExpression1112 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000E00UL});
    public static readonly BitSet FOLLOW_negateExpression_in_powExpression1132 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_76_in_powExpression1135 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_negateExpression_in_powExpression1138 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_72_in_negateExpression1156 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1158 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_77_in_negateExpression1171 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1173 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_negateExpression1186 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1191 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_unaryExpression1209 = new BitSet(new ulong[]{0x0000000000000000UL,0x000000000000C000UL});
    public static readonly BitSet FOLLOW_78_in_unaryExpression1212 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_unaryExpression1225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_58_in_mathAtom1259 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expression_in_mathAtom1262 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_mathAtom1264 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntAtom_in_mathAtom1276 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_mathAtom1291 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_mathAtom1307 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stringAtom_in_mathAtom1318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LayerAtom_in_mathAtom1329 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OriginAtom_in_mathAtom1340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LoopTypeAtom_in_mathAtom1351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ColorAtom_in_mathAtom1364 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Null_in_mathAtom1375 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookup_in_mathAtom1389 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_lookup1408 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_lookup1427 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1429 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_lookup1447 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1449 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_80_in_instantiateClass1493 = new BitSet(new ulong[]{0x000001C000000000UL});
    public static readonly BitSet FOLLOW_Sprite_in_instantiateClass1498 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_instantiateClass1500 = new BitSet(new ulong[]{0x0C00003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1502 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_instantiateClass1505 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Animation_in_instantiateClass1519 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_instantiateClass1521 = new BitSet(new ulong[]{0x0C00003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1523 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_instantiateClass1526 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_List_in_instantiateClass1540 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_instantiateClass1542 = new BitSet(new ulong[]{0x0C00003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1544 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_instantiateClass1547 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1586 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_52_in_expressionList1589 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1591 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_variableList1619 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_52_in_variableList1622 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_variable_in_variableList1624 = new BitSet(new ulong[]{0x0010000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodCall1647 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_methodCall1649 = new BitSet(new ulong[]{0x0C00003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expressionList_in_methodCall1651 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_methodCall1654 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_breakStat1681 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_returnStat1696 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expression_in_returnStat1698 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_whileLoop1721 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop1723 = new BitSet(new ulong[]{0x0002020010000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_whileLoop1725 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_forLoop1747 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_forLoop1749 = new BitSet(new ulong[]{0x0008020010000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop1753 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_forLoop1756 = new BitSet(new ulong[]{0x0408003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop1760 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_forLoop1763 = new BitSet(new ulong[]{0x0800020010000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop1767 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_forLoop1770 = new BitSet(new ulong[]{0x0002020010000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_forLoop1772 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStat_in_ifStatement1817 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_elseIfStat_in_ifStatement1819 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000400000UL});
    public static readonly BitSet FOLLOW_elseStat_in_ifStatement1822 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_ifStat1847 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expression_in_ifStat1849 = new BitSet(new ulong[]{0x0002020010000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_ifStat1851 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_86_in_elseIfStat1872 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_85_in_elseIfStat1874 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expression_in_elseIfStat1876 = new BitSet(new ulong[]{0x0002020010000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseIfStat1878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_86_in_elseStat1900 = new BitSet(new ulong[]{0x0002020010000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseStat1902 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_87_in_atStatement1927 = new BitSet(new ulong[]{0x0400003FF0000000UL,0x0000000000012100UL});
    public static readonly BitSet FOLLOW_expression_in_atStatement1929 = new BitSet(new ulong[]{0x0002020010000000UL,0x0000000000060000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_atStatement1931 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_synpred56_SGL1408 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_synpred56_SGL1410 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_synpred58_SGL1427 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_synpred58_SGL1429 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}