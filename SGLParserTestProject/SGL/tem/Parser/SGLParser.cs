// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\sgl4c#\\NewSGLGramma\\SGL.g 2012-05-24 13:23:17

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


// -------------------------------------------------------------------------------------------------
//                This is a generated file, please don't change anything in here!
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using SGL;
using SGL.Nodes.Methods;


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

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
		"METH_CALL", 
		"OBJ_METH_CALL", 
		"BREAK", 
		"RETURN", 
		"AT", 
		"IF", 
		"EXP", 
		"FORDEC", 
		"FORCOND", 
		"FORITER", 
		"GLOBAL", 
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
		"'object method'", 
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
    public const int Sprite = 39;
    public const int IntAtom = 31;
    public const int LoopTypeAtom = 36;
    public const int EXP_LIST = 15;
    public const int UTF8Letter = 46;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int HexDigit = 44;
    public const int BREAK = 19;
    public const int Identifier = 29;
    public const int Lyrics = 43;
    public const int IF = 22;
    public const int AT = 21;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int Animation = 40;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int Comment = 48;
    public const int EXP = 23;
    public const int FORITER = 26;
    public const int T__59 = 59;
    public const int INT_NEGATE = 7;
    public const int UTF8Digit = 47;
    public const int RETURN = 20;
    public const int WhiteSpace = 49;
    public const int T__50 = 50;
    public const int VARDEC = 10;
    public const int Null = 38;
    public const int OriginAtom = 35;
    public const int LayerAtom = 34;
    public const int GLOBAL_ASSIGN = 28;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int FORDEC = 24;
    public const int StringAtom = 30;
    public const int METH_CALL = 17;
    public const int INDEXES = 12;
    public const int ColorAtom = 37;
    public const int T__85 = 85;
    public const int LIST = 14;
    public const int T__84 = 84;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int List = 41;
    public const int T__89 = 89;
    public const int T__88 = 88;
    public const int BooleanAtom = 33;
    public const int BOOL_NEGATE = 8;
    public const int LOOKUP = 13;
    public const int FORCOND = 25;
    public const int T__71 = 71;
    public const int T__72 = 72;
    public const int VARIABLE = 11;
    public const int T__70 = 70;
    public const int BLOCK = 4;
    public const int VarStartInit = 42;
    public const int ASSIGN = 5;
    public const int OBJ_METH_CALL = 18;
    public const int FloatAtom = 32;
    public const int GLOBAL = 27;
    public const int T__76 = 76;
    public const int T__75 = 75;
    public const int VARINC = 9;
    public const int T__74 = 74;
    public const int EscapeSequence = 45;
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
            this.state.ruleMemo = new Hashtable[120+1];
             
             
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

        	private void RegisterMethod(String id, Object idList, Object block) {
                    // 'idList' is possibly null!  Create an empty tree in that case.  
                    CommonTree idListTree = idList == null ? new CommonTree() : (CommonTree)idList;
    				List<String> methodParameters = ParametersToList(idListTree);

                    // 'block' is never null 
                    CommonTree blockTree = (CommonTree)block;
                    CommonTreeNodeStream methodNodes = new CommonTreeNodeStream(block);

                    // The method name with the exact same type of parameters after it, is the unique key 
                    //String key = id + " " + idListTree.ChildCount;

                    Console.WriteLine("method found: " + id);
                    
                    //idListTree.GetChild(1).ChildCount;
                    Global.GetInstance().RegisterMethod(new UserMethod(id, methodParameters, methodNodes))
                    //methods.Add(id, new Method(id, idListTree, blockTree));
            }
            
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
            }
            
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
            	throw new SGLCompilerException(-1, "Antlr.Parser", msg);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:147:1: main : mainBlock ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:148:5: ( mainBlock )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:148:7: mainBlock
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:155:1: mainBlock : ( mainStatement | methodDef | objectMethodDef )* -> ^( BLOCK ( mainStatement )* ) ;
    public SGLParser.mainBlock_return mainBlock() // throws RecognitionException [1]
    {   
        SGLParser.mainBlock_return retval = new SGLParser.mainBlock_return();
        retval.Start = input.LT(1);
        int mainBlock_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.mainStatement_return mainStatement2 = default(SGLParser.mainStatement_return);

        SGLParser.methodDef_return methodDef3 = default(SGLParser.methodDef_return);

        SGLParser.objectMethodDef_return objectMethodDef4 = default(SGLParser.objectMethodDef_return);


        RewriteRuleSubtreeStream stream_methodDef = new RewriteRuleSubtreeStream(adaptor,"rule methodDef");
        RewriteRuleSubtreeStream stream_mainStatement = new RewriteRuleSubtreeStream(adaptor,"rule mainStatement");
        RewriteRuleSubtreeStream stream_objectMethodDef = new RewriteRuleSubtreeStream(adaptor,"rule objectMethodDef");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 2) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:156:2: ( ( mainStatement | methodDef | objectMethodDef )* -> ^( BLOCK ( mainStatement )* ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:156:4: ( mainStatement | methodDef | objectMethodDef )*
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:156:4: ( mainStatement | methodDef | objectMethodDef )*
            	do 
            	{
            	    int alt1 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case Identifier:
            	    case VarStartInit:
            	    case 54:
            	    case 83:
            	    case 84:
            	    case 85:
            	    case 86:
            	    case 87:
            	    case 89:
            	    	{
            	        alt1 = 1;
            	        }
            	        break;
            	    case 61:
            	    	{
            	        alt1 = 2;
            	        }
            	        break;
            	    case 62:
            	    	{
            	        alt1 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt1) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:156:5: mainStatement
            			    {
            			    	PushFollow(FOLLOW_mainStatement_in_mainBlock252);
            			    	mainStatement2 = mainStatement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_mainStatement.Add(mainStatement2.Tree);

            			    }
            			    break;
            			case 2 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:156:21: methodDef
            			    {
            			    	PushFollow(FOLLOW_methodDef_in_mainBlock256);
            			    	methodDef3 = methodDef();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_methodDef.Add(methodDef3.Tree);

            			    }
            			    break;
            			case 3 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:156:33: objectMethodDef
            			    {
            			    	PushFollow(FOLLOW_objectMethodDef_in_mainBlock260);
            			    	objectMethodDef4 = objectMethodDef();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_objectMethodDef.Add(objectMethodDef4.Tree);

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
            	// 157:8: -> ^( BLOCK ( mainStatement )* )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:157:11: ^( BLOCK ( mainStatement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:157:20: ( mainStatement )*
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:161:1: block : ( statement )* -> ^( BLOCK ( statement )* ) ;
    public SGLParser.block_return block() // throws RecognitionException [1]
    {   
        SGLParser.block_return retval = new SGLParser.block_return();
        retval.Start = input.LT(1);
        int block_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.statement_return statement5 = default(SGLParser.statement_return);


        RewriteRuleSubtreeStream stream_statement = new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 3) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:162:2: ( ( statement )* -> ^( BLOCK ( statement )* ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:162:4: ( statement )*
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:162:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == Identifier || LA2_0 == VarStartInit || (LA2_0 >= 83 && LA2_0 <= 87) || LA2_0 == 89) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: statement
            			    {
            			    	PushFollow(FOLLOW_statement_in_block300);
            			    	statement5 = statement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_statement.Add(statement5.Tree);

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
            	// 163:3: -> ^( BLOCK ( statement )* )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:163:6: ^( BLOCK ( statement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:163:14: ( statement )*
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:167:1: singleBlock : semicolonStatement -> ^( BLOCK semicolonStatement ) ;
    public SGLParser.singleBlock_return singleBlock() // throws RecognitionException [1]
    {   
        SGLParser.singleBlock_return retval = new SGLParser.singleBlock_return();
        retval.Start = input.LT(1);
        int singleBlock_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement6 = default(SGLParser.semicolonStatement_return);


        RewriteRuleSubtreeStream stream_semicolonStatement = new RewriteRuleSubtreeStream(adaptor,"rule semicolonStatement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 4) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:168:2: ( semicolonStatement -> ^( BLOCK semicolonStatement ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:168:4: semicolonStatement
            {
            	PushFollow(FOLLOW_semicolonStatement_in_singleBlock325);
            	semicolonStatement6 = semicolonStatement();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_semicolonStatement.Add(semicolonStatement6.Tree);


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
            	// 169:3: -> ^( BLOCK semicolonStatement )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:169:6: ^( BLOCK semicolonStatement )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:173:1: commonBlock : ( singleBlock | '{' block '}' );
    public SGLParser.commonBlock_return commonBlock() // throws RecognitionException [1]
    {   
        SGLParser.commonBlock_return retval = new SGLParser.commonBlock_return();
        retval.Start = input.LT(1);
        int commonBlock_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal8 = null;
        IToken char_literal10 = null;
        SGLParser.singleBlock_return singleBlock7 = default(SGLParser.singleBlock_return);

        SGLParser.block_return block9 = default(SGLParser.block_return);


        object char_literal8_tree=null;
        object char_literal10_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 5) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:174:2: ( singleBlock | '{' block '}' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == Identifier || LA3_0 == VarStartInit || (LA3_0 >= 83 && LA3_0 <= 84)) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:174:4: singleBlock
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_singleBlock_in_commonBlock348);
                    	singleBlock7 = singleBlock();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, singleBlock7.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:175:4: '{' block '}'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal8=(IToken)Match(input,50,FOLLOW_50_in_commonBlock353); if (state.failed) return retval;
                    	PushFollow(FOLLOW_block_in_commonBlock356);
                    	block9 = block();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, block9.Tree);
                    	char_literal10=(IToken)Match(input,51,FOLLOW_51_in_commonBlock358); if (state.failed) return retval;

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:180:1: mainStatement : ( statement | globalAssignmentList ';' );
    public SGLParser.mainStatement_return mainStatement() // throws RecognitionException [1]
    {   
        SGLParser.mainStatement_return retval = new SGLParser.mainStatement_return();
        retval.Start = input.LT(1);
        int mainStatement_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal13 = null;
        SGLParser.statement_return statement11 = default(SGLParser.statement_return);

        SGLParser.globalAssignmentList_return globalAssignmentList12 = default(SGLParser.globalAssignmentList_return);


        object char_literal13_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 6) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:181:2: ( statement | globalAssignmentList ';' )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == Identifier || LA4_0 == VarStartInit || (LA4_0 >= 83 && LA4_0 <= 87) || LA4_0 == 89) )
            {
                alt4 = 1;
            }
            else if ( (LA4_0 == 54) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:181:4: statement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_statement_in_mainStatement375);
                    	statement11 = statement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, statement11.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:182:4: globalAssignmentList ';'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_globalAssignmentList_in_mainStatement380);
                    	globalAssignmentList12 = globalAssignmentList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, globalAssignmentList12.Tree);
                    	char_literal13=(IToken)Match(input,52,FOLLOW_52_in_mainStatement382); if (state.failed) return retval;

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:185:1: statement : ( semicolonStatement | ifStatement | atStatement | whileLoop | forLoop );
    public SGLParser.statement_return statement() // throws RecognitionException [1]
    {   
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.Start = input.LT(1);
        int statement_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement14 = default(SGLParser.semicolonStatement_return);

        SGLParser.ifStatement_return ifStatement15 = default(SGLParser.ifStatement_return);

        SGLParser.atStatement_return atStatement16 = default(SGLParser.atStatement_return);

        SGLParser.whileLoop_return whileLoop17 = default(SGLParser.whileLoop_return);

        SGLParser.forLoop_return forLoop18 = default(SGLParser.forLoop_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 7) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:186:2: ( semicolonStatement | ifStatement | atStatement | whileLoop | forLoop )
            int alt5 = 5;
            switch ( input.LA(1) ) 
            {
            case Identifier:
            case VarStartInit:
            case 83:
            case 84:
            	{
                alt5 = 1;
                }
                break;
            case 87:
            	{
                alt5 = 2;
                }
                break;
            case 89:
            	{
                alt5 = 3;
                }
                break;
            case 85:
            	{
                alt5 = 4;
                }
                break;
            case 86:
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:186:4: semicolonStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_semicolonStatement_in_statement397);
                    	semicolonStatement14 = semicolonStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, semicolonStatement14.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:187:4: ifStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_ifStatement_in_statement402);
                    	ifStatement15 = ifStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, ifStatement15.Tree);

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:188:4: atStatement
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_atStatement_in_statement407);
                    	atStatement16 = atStatement();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, atStatement16.Tree);

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:189:4: whileLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_whileLoop_in_statement412);
                    	whileLoop17 = whileLoop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, whileLoop17.Tree);

                    }
                    break;
                case 5 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:190:4: forLoop
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_forLoop_in_statement417);
                    	forLoop18 = forLoop();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, forLoop18.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:193:1: semicolonStatement : ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat ) ';' ;
    public SGLParser.semicolonStatement_return semicolonStatement() // throws RecognitionException [1]
    {   
        SGLParser.semicolonStatement_return retval = new SGLParser.semicolonStatement_return();
        retval.Start = input.LT(1);
        int semicolonStatement_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal25 = null;
        SGLParser.objectMethodCall_return objectMethodCall19 = default(SGLParser.objectMethodCall_return);

        SGLParser.methodCall_return methodCall20 = default(SGLParser.methodCall_return);

        SGLParser.assignmentList_return assignmentList21 = default(SGLParser.assignmentList_return);

        SGLParser.unaryExpression_return unaryExpression22 = default(SGLParser.unaryExpression_return);

        SGLParser.breakStat_return breakStat23 = default(SGLParser.breakStat_return);

        SGLParser.returnStat_return returnStat24 = default(SGLParser.returnStat_return);


        object char_literal25_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 8) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:194:2: ( ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat ) ';' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:194:4: ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat ) ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:194:4: ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat )
            	int alt6 = 6;
            	switch ( input.LA(1) ) 
            	{
            	case Identifier:
            		{
            	    switch ( input.LA(2) ) 
            	    {
            	    case 59:
            	    	{
            	        alt6 = 2;
            	        }
            	        break;
            	    case 80:
            	    case 81:
            	    	{
            	        alt6 = 4;
            	        }
            	        break;
            	    case 56:
            	    case 58:
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
            	case 83:
            		{
            	    alt6 = 5;
            	    }
            	    break;
            	case 84:
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:194:5: objectMethodCall
            	        {
            	        	PushFollow(FOLLOW_objectMethodCall_in_semicolonStatement430);
            	        	objectMethodCall19 = objectMethodCall();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectMethodCall19.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:195:4: methodCall
            	        {
            	        	PushFollow(FOLLOW_methodCall_in_semicolonStatement435);
            	        	methodCall20 = methodCall();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodCall20.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:196:4: assignmentList
            	        {
            	        	PushFollow(FOLLOW_assignmentList_in_semicolonStatement441);
            	        	assignmentList21 = assignmentList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentList21.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:197:4: unaryExpression
            	        {
            	        	PushFollow(FOLLOW_unaryExpression_in_semicolonStatement447);
            	        	unaryExpression22 = unaryExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression22.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:198:4: breakStat
            	        {
            	        	PushFollow(FOLLOW_breakStat_in_semicolonStatement453);
            	        	breakStat23 = breakStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, breakStat23.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:199:4: returnStat
            	        {
            	        	PushFollow(FOLLOW_returnStat_in_semicolonStatement458);
            	        	returnStat24 = returnStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, returnStat24.Tree);

            	        }
            	        break;

            	}

            	char_literal25=(IToken)Match(input,52,FOLLOW_52_in_semicolonStatement463); if (state.failed) return retval;

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:203:1: oneLineStatement : ( assignmentList | unaryExpression );
    public SGLParser.oneLineStatement_return oneLineStatement() // throws RecognitionException [1]
    {   
        SGLParser.oneLineStatement_return retval = new SGLParser.oneLineStatement_return();
        retval.Start = input.LT(1);
        int oneLineStatement_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.assignmentList_return assignmentList26 = default(SGLParser.assignmentList_return);

        SGLParser.unaryExpression_return unaryExpression27 = default(SGLParser.unaryExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 9) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:204:2: ( assignmentList | unaryExpression )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:204:4: assignmentList
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_assignmentList_in_oneLineStatement476);
                    	assignmentList26 = assignmentList();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentList26.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:205:4: unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpression_in_oneLineStatement481);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:208:1: assignmentList : 'var' assignment ( ',' assignment )* ;
    public SGLParser.assignmentList_return assignmentList() // throws RecognitionException [1]
    {   
        SGLParser.assignmentList_return retval = new SGLParser.assignmentList_return();
        retval.Start = input.LT(1);
        int assignmentList_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal28 = null;
        IToken char_literal30 = null;
        SGLParser.assignment_return assignment29 = default(SGLParser.assignment_return);

        SGLParser.assignment_return assignment31 = default(SGLParser.assignment_return);


        object string_literal28_tree=null;
        object char_literal30_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:209:2: ( 'var' assignment ( ',' assignment )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:209:4: 'var' assignment ( ',' assignment )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal28=(IToken)Match(input,VarStartInit,FOLLOW_VarStartInit_in_assignmentList496); if (state.failed) return retval;
            	PushFollow(FOLLOW_assignment_in_assignmentList499);
            	assignment29 = assignment();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment29.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:209:22: ( ',' assignment )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:209:23: ',' assignment
            			    {
            			    	char_literal30=(IToken)Match(input,53,FOLLOW_53_in_assignmentList502); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_assignment_in_assignmentList505);
            			    	assignment31 = assignment();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment31.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:213:1: globalAssignmentList : 'global' 'var' globalAssignment ( ',' globalAssignment )* ;
    public SGLParser.globalAssignmentList_return globalAssignmentList() // throws RecognitionException [1]
    {   
        SGLParser.globalAssignmentList_return retval = new SGLParser.globalAssignmentList_return();
        retval.Start = input.LT(1);
        int globalAssignmentList_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal32 = null;
        IToken string_literal33 = null;
        IToken char_literal35 = null;
        SGLParser.globalAssignment_return globalAssignment34 = default(SGLParser.globalAssignment_return);

        SGLParser.globalAssignment_return globalAssignment36 = default(SGLParser.globalAssignment_return);


        object string_literal32_tree=null;
        object string_literal33_tree=null;
        object char_literal35_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:214:2: ( 'global' 'var' globalAssignment ( ',' globalAssignment )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:214:4: 'global' 'var' globalAssignment ( ',' globalAssignment )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal32=(IToken)Match(input,54,FOLLOW_54_in_globalAssignmentList521); if (state.failed) return retval;
            	string_literal33=(IToken)Match(input,VarStartInit,FOLLOW_VarStartInit_in_globalAssignmentList524); if (state.failed) return retval;
            	PushFollow(FOLLOW_globalAssignment_in_globalAssignmentList527);
            	globalAssignment34 = globalAssignment();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, globalAssignment34.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:214:38: ( ',' globalAssignment )*
            	do 
            	{
            	    int alt9 = 2;
            	    int LA9_0 = input.LA(1);

            	    if ( (LA9_0 == 53) )
            	    {
            	        alt9 = 1;
            	    }


            	    switch (alt9) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:214:39: ',' globalAssignment
            			    {
            			    	char_literal35=(IToken)Match(input,53,FOLLOW_53_in_globalAssignmentList530); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_globalAssignment_in_globalAssignmentList533);
            			    	globalAssignment36 = globalAssignment();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, globalAssignment36.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:1: globalAssignment : variable ( indexes )? ( '=' expression )? -> ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? ) ;
    public SGLParser.globalAssignment_return globalAssignment() // throws RecognitionException [1]
    {   
        SGLParser.globalAssignment_return retval = new SGLParser.globalAssignment_return();
        retval.Start = input.LT(1);
        int globalAssignment_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal39 = null;
        SGLParser.variable_return variable37 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes38 = default(SGLParser.indexes_return);

        SGLParser.expression_return expression40 = default(SGLParser.expression_return);


        object char_literal39_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_indexes = new RewriteRuleSubtreeStream(adaptor,"rule indexes");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 12) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:218:2: ( variable ( indexes )? ( '=' expression )? -> ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:218:4: variable ( indexes )? ( '=' expression )?
            {
            	PushFollow(FOLLOW_variable_in_globalAssignment547);
            	variable37 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable37.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:218:13: ( indexes )?
            	int alt10 = 2;
            	int LA10_0 = input.LA(1);

            	if ( (LA10_0 == 56) )
            	{
            	    alt10 = 1;
            	}
            	switch (alt10) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_globalAssignment549);
            	        	indexes38 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes38.Tree);

            	        }
            	        break;

            	}

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:218:22: ( '=' expression )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 55) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:218:23: '=' expression
            	        {
            	        	char_literal39=(IToken)Match(input,55,FOLLOW_55_in_globalAssignment553); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_55.Add(char_literal39);

            	        	PushFollow(FOLLOW_expression_in_globalAssignment555);
            	        	expression40 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression40.Tree);

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
            	// 218:41: -> ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:218:44: ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(GLOBAL_ASSIGN, "GLOBAL_ASSIGN"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:218:69: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:218:78: ( expression )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:1: assignment : variable ( indexes )? ( '=' expression )? -> ^( ASSIGN variable ( indexes )? ( expression )? ) ;
    public SGLParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        SGLParser.assignment_return retval = new SGLParser.assignment_return();
        retval.Start = input.LT(1);
        int assignment_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal43 = null;
        SGLParser.variable_return variable41 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes42 = default(SGLParser.indexes_return);

        SGLParser.expression_return expression44 = default(SGLParser.expression_return);


        object char_literal43_tree=null;
        RewriteRuleTokenStream stream_55 = new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_indexes = new RewriteRuleSubtreeStream(adaptor,"rule indexes");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 13) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:222:2: ( variable ( indexes )? ( '=' expression )? -> ^( ASSIGN variable ( indexes )? ( expression )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:222:4: variable ( indexes )? ( '=' expression )?
            {
            	PushFollow(FOLLOW_variable_in_assignment586);
            	variable41 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable41.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:222:13: ( indexes )?
            	int alt12 = 2;
            	int LA12_0 = input.LA(1);

            	if ( (LA12_0 == 56) )
            	{
            	    alt12 = 1;
            	}
            	switch (alt12) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_assignment588);
            	        	indexes42 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes42.Tree);

            	        }
            	        break;

            	}

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:222:22: ( '=' expression )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == 55) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:222:23: '=' expression
            	        {
            	        	char_literal43=(IToken)Match(input,55,FOLLOW_55_in_assignment592); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_55.Add(char_literal43);

            	        	PushFollow(FOLLOW_expression_in_assignment594);
            	        	expression44 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression44.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          indexes, expression, variable
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 222:41: -> ^( ASSIGN variable ( indexes )? ( expression )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:222:44: ^( ASSIGN variable ( indexes )? ( expression )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASSIGN, "ASSIGN"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:222:62: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:222:71: ( expression )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:1: indexes : ( '[' expression ']' )+ -> ^( INDEXES ( expression )+ ) ;
    public SGLParser.indexes_return indexes() // throws RecognitionException [1]
    {   
        SGLParser.indexes_return retval = new SGLParser.indexes_return();
        retval.Start = input.LT(1);
        int indexes_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal45 = null;
        IToken char_literal47 = null;
        SGLParser.expression_return expression46 = default(SGLParser.expression_return);


        object char_literal45_tree=null;
        object char_literal47_tree=null;
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:226:4: ( ( '[' expression ']' )+ -> ^( INDEXES ( expression )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:226:8: ( '[' expression ']' )+
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:226:8: ( '[' expression ']' )+
            	int cnt14 = 0;
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0 == 56) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:226:9: '[' expression ']'
            			    {
            			    	char_literal45=(IToken)Match(input,56,FOLLOW_56_in_indexes629); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_56.Add(char_literal45);

            			    	PushFollow(FOLLOW_expression_in_indexes631);
            			    	expression46 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression46.Tree);
            			    	char_literal47=(IToken)Match(input,57,FOLLOW_57_in_indexes633); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_57.Add(char_literal47);


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
            	// 226:30: -> ^( INDEXES ( expression )+ )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:226:33: ^( INDEXES ( expression )+ )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:1: objectMethodCall : variable ( indexes )? '.' Identifier '(' ( expressionList )? ')' -> ^( OBJ_METH_CALL variable ( indexes )? Identifier ( expressionList )? ) ;
    public SGLParser.objectMethodCall_return objectMethodCall() // throws RecognitionException [1]
    {   
        SGLParser.objectMethodCall_return retval = new SGLParser.objectMethodCall_return();
        retval.Start = input.LT(1);
        int objectMethodCall_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal50 = null;
        IToken Identifier51 = null;
        IToken char_literal52 = null;
        IToken char_literal54 = null;
        SGLParser.variable_return variable48 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes49 = default(SGLParser.indexes_return);

        SGLParser.expressionList_return expressionList53 = default(SGLParser.expressionList_return);


        object char_literal50_tree=null;
        object Identifier51_tree=null;
        object char_literal52_tree=null;
        object char_literal54_tree=null;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:230:2: ( variable ( indexes )? '.' Identifier '(' ( expressionList )? ')' -> ^( OBJ_METH_CALL variable ( indexes )? Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:230:4: variable ( indexes )? '.' Identifier '(' ( expressionList )? ')'
            {
            	PushFollow(FOLLOW_variable_in_objectMethodCall660);
            	variable48 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable48.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:230:13: ( indexes )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == 56) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
            	        {
            	        	PushFollow(FOLLOW_indexes_in_objectMethodCall662);
            	        	indexes49 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes49.Tree);

            	        }
            	        break;

            	}

            	char_literal50=(IToken)Match(input,58,FOLLOW_58_in_objectMethodCall665); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_58.Add(char_literal50);

            	Identifier51=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_objectMethodCall667); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier51);

            	char_literal52=(IToken)Match(input,59,FOLLOW_59_in_objectMethodCall669); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(char_literal52);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:230:41: ( expressionList )?
            	int alt16 = 2;
            	int LA16_0 = input.LA(1);

            	if ( ((LA16_0 >= Identifier && LA16_0 <= Null) || LA16_0 == 59 || LA16_0 == 74 || LA16_0 == 79 || LA16_0 == 82) )
            	{
            	    alt16 = 1;
            	}
            	switch (alt16) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_objectMethodCall671);
            	        	expressionList53 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList53.Tree);

            	        }
            	        break;

            	}

            	char_literal54=(IToken)Match(input,60,FOLLOW_60_in_objectMethodCall674); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_60.Add(char_literal54);



            	// AST REWRITE
            	// elements:          expressionList, Identifier, variable, indexes
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 230:61: -> ^( OBJ_METH_CALL variable ( indexes )? Identifier ( expressionList )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:230:64: ^( OBJ_METH_CALL variable ( indexes )? Identifier ( expressionList )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(OBJ_METH_CALL, "OBJ_METH_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:230:89: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:230:109: ( expressionList )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:234:1: variable : Identifier -> Identifier ;
    public SGLParser.variable_return variable() // throws RecognitionException [1]
    {   
        SGLParser.variable_return retval = new SGLParser.variable_return();
        retval.Start = input.LT(1);
        int variable_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier55 = null;

        object Identifier55_tree=null;
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:235:2: ( Identifier -> Identifier )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:235:4: Identifier
            {
            	Identifier55=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable708); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier55);



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
            	// 235:15: -> Identifier
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:240:1: stringAtom : StringAtom -> ^( STRING StringAtom ) ;
    public SGLParser.stringAtom_return stringAtom() // throws RecognitionException [1]
    {   
        SGLParser.stringAtom_return retval = new SGLParser.stringAtom_return();
        retval.Start = input.LT(1);
        int stringAtom_StartIndex = input.Index();
        object root_0 = null;

        IToken StringAtom56 = null;

        object StringAtom56_tree=null;
        RewriteRuleTokenStream stream_StringAtom = new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:241:2: ( StringAtom -> ^( STRING StringAtom ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:241:6: StringAtom
            {
            	StringAtom56=(IToken)Match(input,StringAtom,FOLLOW_StringAtom_in_stringAtom731); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_StringAtom.Add(StringAtom56);



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
            	// 241:17: -> ^( STRING StringAtom )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:241:20: ^( STRING StringAtom )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:246:1: methodDef : 'method' Identifier '(' ( variableList )? ')' commonBlock ;
    public SGLParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        SGLParser.methodDef_return retval = new SGLParser.methodDef_return();
        retval.Start = input.LT(1);
        int methodDef_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal57 = null;
        IToken Identifier58 = null;
        IToken char_literal59 = null;
        IToken char_literal61 = null;
        SGLParser.variableList_return variableList60 = default(SGLParser.variableList_return);

        SGLParser.commonBlock_return commonBlock62 = default(SGLParser.commonBlock_return);


        object string_literal57_tree=null;
        object Identifier58_tree=null;
        object char_literal59_tree=null;
        object char_literal61_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:247:2: ( 'method' Identifier '(' ( variableList )? ')' commonBlock )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:247:4: 'method' Identifier '(' ( variableList )? ')' commonBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal57=(IToken)Match(input,61,FOLLOW_61_in_methodDef752); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal57_tree = (object)adaptor.Create(string_literal57);
            		adaptor.AddChild(root_0, string_literal57_tree);
            	}
            	Identifier58=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodDef754); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier58_tree = (object)adaptor.Create(Identifier58);
            		adaptor.AddChild(root_0, Identifier58_tree);
            	}
            	char_literal59=(IToken)Match(input,59,FOLLOW_59_in_methodDef756); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal59_tree = (object)adaptor.Create(char_literal59);
            		adaptor.AddChild(root_0, char_literal59_tree);
            	}
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:247:28: ( variableList )?
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
            	        	PushFollow(FOLLOW_variableList_in_methodDef758);
            	        	variableList60 = variableList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableList60.Tree);

            	        }
            	        break;

            	}

            	char_literal61=(IToken)Match(input,60,FOLLOW_60_in_methodDef761); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal61_tree = (object)adaptor.Create(char_literal61);
            		adaptor.AddChild(root_0, char_literal61_tree);
            	}
            	PushFollow(FOLLOW_commonBlock_in_methodDef763);
            	commonBlock62 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, commonBlock62.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   DefineMethod(((Identifier58 != null) ? Identifier58.Text : null), ((variableList60 != null) ? ((object)variableList60.Tree) : null), ((commonBlock62 != null) ? ((object)commonBlock62.Tree) : null)); 
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

    public class objectMethodDef_return : ParserRuleReturnScope
    {
        private object tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (object) value; }
        }
    };

    // $ANTLR start "objectMethodDef"
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:252:1: objectMethodDef : 'object method' Identifier '(' ( variableList )? ')' commonBlock ;
    public SGLParser.objectMethodDef_return objectMethodDef() // throws RecognitionException [1]
    {   
        SGLParser.objectMethodDef_return retval = new SGLParser.objectMethodDef_return();
        retval.Start = input.LT(1);
        int objectMethodDef_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal63 = null;
        IToken Identifier64 = null;
        IToken char_literal65 = null;
        IToken char_literal67 = null;
        SGLParser.variableList_return variableList66 = default(SGLParser.variableList_return);

        SGLParser.commonBlock_return commonBlock68 = default(SGLParser.commonBlock_return);


        object string_literal63_tree=null;
        object Identifier64_tree=null;
        object char_literal65_tree=null;
        object char_literal67_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:253:2: ( 'object method' Identifier '(' ( variableList )? ')' commonBlock )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:253:4: 'object method' Identifier '(' ( variableList )? ')' commonBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal63=(IToken)Match(input,62,FOLLOW_62_in_objectMethodDef781); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal63_tree = (object)adaptor.Create(string_literal63);
            		adaptor.AddChild(root_0, string_literal63_tree);
            	}
            	Identifier64=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_objectMethodDef783); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier64_tree = (object)adaptor.Create(Identifier64);
            		adaptor.AddChild(root_0, Identifier64_tree);
            	}
            	char_literal65=(IToken)Match(input,59,FOLLOW_59_in_objectMethodDef785); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal65_tree = (object)adaptor.Create(char_literal65);
            		adaptor.AddChild(root_0, char_literal65_tree);
            	}
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:253:35: ( variableList )?
            	int alt18 = 2;
            	int LA18_0 = input.LA(1);

            	if ( (LA18_0 == Identifier) )
            	{
            	    alt18 = 1;
            	}
            	switch (alt18) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: variableList
            	        {
            	        	PushFollow(FOLLOW_variableList_in_objectMethodDef787);
            	        	variableList66 = variableList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableList66.Tree);

            	        }
            	        break;

            	}

            	char_literal67=(IToken)Match(input,60,FOLLOW_60_in_objectMethodDef790); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal67_tree = (object)adaptor.Create(char_literal67);
            		adaptor.AddChild(root_0, char_literal67_tree);
            	}
            	PushFollow(FOLLOW_commonBlock_in_objectMethodDef792);
            	commonBlock68 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, commonBlock68.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   DefineObjectMethod(((Identifier64 != null) ? Identifier64.Text : null), ((variableList66 != null) ? ((object)variableList66.Tree) : null), ((commonBlock68 != null) ? ((object)commonBlock68.Tree) : null)); 
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
            	Memoize(input, 19, objectMethodDef_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "objectMethodDef"

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:266:1: expression : ( instantiateClass | conditionalExpression );
    public SGLParser.expression_return expression() // throws RecognitionException [1]
    {   
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.instantiateClass_return instantiateClass69 = default(SGLParser.instantiateClass_return);

        SGLParser.conditionalExpression_return conditionalExpression70 = default(SGLParser.conditionalExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:267:5: ( instantiateClass | conditionalExpression )
            int alt19 = 2;
            int LA19_0 = input.LA(1);

            if ( (LA19_0 == 82) )
            {
                alt19 = 1;
            }
            else if ( ((LA19_0 >= Identifier && LA19_0 <= Null) || LA19_0 == 59 || LA19_0 == 74 || LA19_0 == 79) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:267:7: instantiateClass
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_instantiateClass_in_expression823);
                    	instantiateClass69 = instantiateClass();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, instantiateClass69.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:268:7: conditionalExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalExpression_in_expression833);
                    	conditionalExpression70 = conditionalExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression70.Tree);

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
            	Memoize(input, 20, expression_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:273:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public SGLParser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.Start = input.LT(1);
        int conditionalExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal72 = null;
        IToken char_literal74 = null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression71 = default(SGLParser.conditionalOrExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression73 = default(SGLParser.conditionalExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression75 = default(SGLParser.conditionalExpression_return);


        object char_literal72_tree=null;
        object char_literal74_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:274:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:274:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression859);
            	conditionalOrExpression71 = conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression71.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:274:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == 63) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:274:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	char_literal72=(IToken)Match(input,63,FOLLOW_63_in_conditionalExpression863); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal72_tree = (object)adaptor.Create(char_literal72);
            	        		root_0 = (object)adaptor.BecomeRoot(char_literal72_tree, root_0);
            	        	}
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression866);
            	        	conditionalExpression73 = conditionalExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression73.Tree);
            	        	char_literal74=(IToken)Match(input,64,FOLLOW_64_in_conditionalExpression868); if (state.failed) return retval;
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression871);
            	        	conditionalExpression75 = conditionalExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression75.Tree);

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
            	Memoize(input, 21, conditionalExpression_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:279:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public SGLParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);
        int conditionalOrExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal77 = null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression76 = default(SGLParser.conditionalAndExpression_return);

        SGLParser.conditionalAndExpression_return conditionalAndExpression78 = default(SGLParser.conditionalAndExpression_return);


        object string_literal77_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:280:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:280:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression914);
            	conditionalAndExpression76 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression76.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:280:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt21 = 2;
            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0 == 65) )
            	    {
            	        alt21 = 1;
            	    }


            	    switch (alt21) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:280:36: '||' conditionalAndExpression
            			    {
            			    	string_literal77=(IToken)Match(input,65,FOLLOW_65_in_conditionalOrExpression918); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal77_tree = (object)adaptor.Create(string_literal77);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal77_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression921);
            			    	conditionalAndExpression78 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression78.Tree);

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
            	Memoize(input, 22, conditionalOrExpression_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:284:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public SGLParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);
        int conditionalAndExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal80 = null;
        SGLParser.equalityExpression_return equalityExpression79 = default(SGLParser.equalityExpression_return);

        SGLParser.equalityExpression_return equalityExpression81 = default(SGLParser.equalityExpression_return);


        object string_literal80_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:285:5: ( equalityExpression ( '&&' equalityExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:285:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression952);
            	equalityExpression79 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression79.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:285:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt22 = 2;
            	    int LA22_0 = input.LA(1);

            	    if ( (LA22_0 == 66) )
            	    {
            	        alt22 = 1;
            	    }


            	    switch (alt22) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:285:30: '&&' equalityExpression
            			    {
            			    	string_literal80=(IToken)Match(input,66,FOLLOW_66_in_conditionalAndExpression956); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal80_tree = (object)adaptor.Create(string_literal80);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal80_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression959);
            			    	equalityExpression81 = equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression81.Tree);

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
            	Memoize(input, 23, conditionalAndExpression_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:289:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public SGLParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.Start = input.LT(1);
        int equalityExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal83 = null;
        IToken string_literal84 = null;
        SGLParser.relationalExpression_return relationalExpression82 = default(SGLParser.relationalExpression_return);

        SGLParser.relationalExpression_return relationalExpression85 = default(SGLParser.relationalExpression_return);


        object string_literal83_tree=null;
        object string_literal84_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:290:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:290:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression986);
            	relationalExpression82 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression82.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:290:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt24 = 2;
            	    int LA24_0 = input.LA(1);

            	    if ( ((LA24_0 >= 67 && LA24_0 <= 68)) )
            	    {
            	        alt24 = 1;
            	    }


            	    switch (alt24) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:290:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:290:32: ( '==' | '!=' )
            			    	int alt23 = 2;
            			    	int LA23_0 = input.LA(1);

            			    	if ( (LA23_0 == 67) )
            			    	{
            			    	    alt23 = 1;
            			    	}
            			    	else if ( (LA23_0 == 68) )
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
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:290:33: '=='
            			    	        {
            			    	        	string_literal83=(IToken)Match(input,67,FOLLOW_67_in_equalityExpression991); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal83_tree = (object)adaptor.Create(string_literal83);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal83_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:290:41: '!='
            			    	        {
            			    	        	string_literal84=(IToken)Match(input,68,FOLLOW_68_in_equalityExpression996); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal84_tree = (object)adaptor.Create(string_literal84);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal84_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression1000);
            			    	relationalExpression85 = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression85.Tree);

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
            	Memoize(input, 24, equalityExpression_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:294:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public SGLParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.Start = input.LT(1);
        int relationalExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal87 = null;
        IToken char_literal88 = null;
        IToken string_literal89 = null;
        IToken string_literal90 = null;
        SGLParser.additiveExpression_return additiveExpression86 = default(SGLParser.additiveExpression_return);

        SGLParser.additiveExpression_return additiveExpression91 = default(SGLParser.additiveExpression_return);


        object char_literal87_tree=null;
        object char_literal88_tree=null;
        object string_literal89_tree=null;
        object string_literal90_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1031);
            	additiveExpression86 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression86.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt26 = 2;
            	    int LA26_0 = input.LA(1);

            	    if ( ((LA26_0 >= 69 && LA26_0 <= 72)) )
            	    {
            	        alt26 = 1;
            	    }


            	    switch (alt26) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:29: ( '<' | '>' | '<=' | '>=' )
            			    	int alt25 = 4;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 69:
            			    		{
            			    	    alt25 = 1;
            			    	    }
            			    	    break;
            			    	case 70:
            			    		{
            			    	    alt25 = 2;
            			    	    }
            			    	    break;
            			    	case 71:
            			    		{
            			    	    alt25 = 3;
            			    	    }
            			    	    break;
            			    	case 72:
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
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:30: '<'
            			    	        {
            			    	        	char_literal87=(IToken)Match(input,69,FOLLOW_69_in_relationalExpression1035); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal87_tree = (object)adaptor.Create(char_literal87);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal87_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:35: '>'
            			    	        {
            			    	        	char_literal88=(IToken)Match(input,70,FOLLOW_70_in_relationalExpression1038); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal88_tree = (object)adaptor.Create(char_literal88);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal88_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:40: '<='
            			    	        {
            			    	        	string_literal89=(IToken)Match(input,71,FOLLOW_71_in_relationalExpression1041); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal89_tree = (object)adaptor.Create(string_literal89);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal89_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:295:46: '>='
            			    	        {
            			    	        	string_literal90=(IToken)Match(input,72,FOLLOW_72_in_relationalExpression1044); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal90_tree = (object)adaptor.Create(string_literal90);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal90_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1048);
            			    	additiveExpression91 = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression91.Tree);

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
            	Memoize(input, 25, relationalExpression_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:299:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public SGLParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.Start = input.LT(1);
        int additiveExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal93 = null;
        IToken char_literal94 = null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression92 = default(SGLParser.multiplicativeExpression_return);

        SGLParser.multiplicativeExpression_return multiplicativeExpression95 = default(SGLParser.multiplicativeExpression_return);


        object char_literal93_tree=null;
        object char_literal94_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1086);
            	multiplicativeExpression92 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression92.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:34: ( ( '+' | '-' ) multiplicativeExpression )*
            	do 
            	{
            	    int alt28 = 2;
            	    int LA28_0 = input.LA(1);

            	    if ( ((LA28_0 >= 73 && LA28_0 <= 74)) )
            	    {
            	        alt28 = 1;
            	    }


            	    switch (alt28) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:35: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:35: ( '+' | '-' )
            			    	int alt27 = 2;
            			    	int LA27_0 = input.LA(1);

            			    	if ( (LA27_0 == 73) )
            			    	{
            			    	    alt27 = 1;
            			    	}
            			    	else if ( (LA27_0 == 74) )
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
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:36: '+'
            			    	        {
            			    	        	char_literal93=(IToken)Match(input,73,FOLLOW_73_in_additiveExpression1090); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal93_tree = (object)adaptor.Create(char_literal93);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal93_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:300:41: '-'
            			    	        {
            			    	        	char_literal94=(IToken)Match(input,74,FOLLOW_74_in_additiveExpression1093); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal94_tree = (object)adaptor.Create(char_literal94);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal94_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1097);
            			    	multiplicativeExpression95 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression95.Tree);

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
            	Memoize(input, 26, additiveExpression_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:304:1: multiplicativeExpression : powExpression ( ( '*' | '/' | '%' ) powExpression )* ;
    public SGLParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal97 = null;
        IToken char_literal98 = null;
        IToken char_literal99 = null;
        SGLParser.powExpression_return powExpression96 = default(SGLParser.powExpression_return);

        SGLParser.powExpression_return powExpression100 = default(SGLParser.powExpression_return);


        object char_literal97_tree=null;
        object char_literal98_tree=null;
        object char_literal99_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:5: ( powExpression ( ( '*' | '/' | '%' ) powExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:9: powExpression ( ( '*' | '/' | '%' ) powExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_powExpression_in_multiplicativeExpression1131);
            	powExpression96 = powExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, powExpression96.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:23: ( ( '*' | '/' | '%' ) powExpression )*
            	do 
            	{
            	    int alt30 = 2;
            	    int LA30_0 = input.LA(1);

            	    if ( ((LA30_0 >= 75 && LA30_0 <= 77)) )
            	    {
            	        alt30 = 1;
            	    }


            	    switch (alt30) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:24: ( '*' | '/' | '%' ) powExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:24: ( '*' | '/' | '%' )
            			    	int alt29 = 3;
            			    	switch ( input.LA(1) ) 
            			    	{
            			    	case 75:
            			    		{
            			    	    alt29 = 1;
            			    	    }
            			    	    break;
            			    	case 76:
            			    		{
            			    	    alt29 = 2;
            			    	    }
            			    	    break;
            			    	case 77:
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
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:25: '*'
            			    	        {
            			    	        	char_literal97=(IToken)Match(input,75,FOLLOW_75_in_multiplicativeExpression1135); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal97_tree = (object)adaptor.Create(char_literal97);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal97_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:30: '/'
            			    	        {
            			    	        	char_literal98=(IToken)Match(input,76,FOLLOW_76_in_multiplicativeExpression1138); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal98_tree = (object)adaptor.Create(char_literal98);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal98_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:305:35: '%'
            			    	        {
            			    	        	char_literal99=(IToken)Match(input,77,FOLLOW_77_in_multiplicativeExpression1141); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal99_tree = (object)adaptor.Create(char_literal99);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal99_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_powExpression_in_multiplicativeExpression1145);
            			    	powExpression100 = powExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, powExpression100.Tree);

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
            	Memoize(input, 27, multiplicativeExpression_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:1: powExpression : negateExpression ( '^' negateExpression )* ;
    public SGLParser.powExpression_return powExpression() // throws RecognitionException [1]
    {   
        SGLParser.powExpression_return retval = new SGLParser.powExpression_return();
        retval.Start = input.LT(1);
        int powExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal102 = null;
        SGLParser.negateExpression_return negateExpression101 = default(SGLParser.negateExpression_return);

        SGLParser.negateExpression_return negateExpression103 = default(SGLParser.negateExpression_return);


        object char_literal102_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:309:2: ( negateExpression ( '^' negateExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:309:4: negateExpression ( '^' negateExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_negateExpression_in_powExpression1165);
            	negateExpression101 = negateExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negateExpression101.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:309:21: ( '^' negateExpression )*
            	do 
            	{
            	    int alt31 = 2;
            	    int LA31_0 = input.LA(1);

            	    if ( (LA31_0 == 78) )
            	    {
            	        alt31 = 1;
            	    }


            	    switch (alt31) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:309:22: '^' negateExpression
            			    {
            			    	char_literal102=(IToken)Match(input,78,FOLLOW_78_in_powExpression1168); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal102_tree = (object)adaptor.Create(char_literal102);
            			    		root_0 = (object)adaptor.BecomeRoot(char_literal102_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_negateExpression_in_powExpression1171);
            			    	negateExpression103 = negateExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negateExpression103.Tree);

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
            	Memoize(input, 28, powExpression_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:313:1: negateExpression : ( '-' mathAtom -> ^( INT_NEGATE mathAtom ) | '!' mathAtom -> ^( BOOL_NEGATE mathAtom ) | unaryExpression | mathAtom );
    public SGLParser.negateExpression_return negateExpression() // throws RecognitionException [1]
    {   
        SGLParser.negateExpression_return retval = new SGLParser.negateExpression_return();
        retval.Start = input.LT(1);
        int negateExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal104 = null;
        IToken char_literal106 = null;
        SGLParser.mathAtom_return mathAtom105 = default(SGLParser.mathAtom_return);

        SGLParser.mathAtom_return mathAtom107 = default(SGLParser.mathAtom_return);

        SGLParser.unaryExpression_return unaryExpression108 = default(SGLParser.unaryExpression_return);

        SGLParser.mathAtom_return mathAtom109 = default(SGLParser.mathAtom_return);


        object char_literal104_tree=null;
        object char_literal106_tree=null;
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleSubtreeStream stream_mathAtom = new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:314:2: ( '-' mathAtom -> ^( INT_NEGATE mathAtom ) | '!' mathAtom -> ^( BOOL_NEGATE mathAtom ) | unaryExpression | mathAtom )
            int alt32 = 4;
            switch ( input.LA(1) ) 
            {
            case 74:
            	{
                alt32 = 1;
                }
                break;
            case 79:
            	{
                alt32 = 2;
                }
                break;
            case Identifier:
            	{
                int LA32_3 = input.LA(2);

                if ( (LA32_3 == EOF || LA32_3 == Identifier || LA32_3 == VarStartInit || LA32_3 == 50 || (LA32_3 >= 52 && LA32_3 <= 53) || (LA32_3 >= 56 && LA32_3 <= 60) || (LA32_3 >= 63 && LA32_3 <= 78) || (LA32_3 >= 83 && LA32_3 <= 84)) )
                {
                    alt32 = 4;
                }
                else if ( ((LA32_3 >= 80 && LA32_3 <= 81)) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:314:4: '-' mathAtom
                    {
                    	char_literal104=(IToken)Match(input,74,FOLLOW_74_in_negateExpression1189); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_74.Add(char_literal104);

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1191);
                    	mathAtom105 = mathAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_mathAtom.Add(mathAtom105.Tree);


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
                    	// 314:17: -> ^( INT_NEGATE mathAtom )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:314:20: ^( INT_NEGATE mathAtom )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:315:4: '!' mathAtom
                    {
                    	char_literal106=(IToken)Match(input,79,FOLLOW_79_in_negateExpression1204); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_79.Add(char_literal106);

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1206);
                    	mathAtom107 = mathAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_mathAtom.Add(mathAtom107.Tree);


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
                    	// 315:17: -> ^( BOOL_NEGATE mathAtom )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:315:20: ^( BOOL_NEGATE mathAtom )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:316:4: unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpression_in_negateExpression1219);
                    	unaryExpression108 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression108.Tree);

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:317:4: mathAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1224);
                    	mathAtom109 = mathAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathAtom109.Tree);

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
            	Memoize(input, 29, negateExpression_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:321:1: unaryExpression : variable ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) ) ;
    public SGLParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.Start = input.LT(1);
        int unaryExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal111 = null;
        IToken string_literal112 = null;
        SGLParser.variable_return variable110 = default(SGLParser.variable_return);


        object string_literal111_tree=null;
        object string_literal112_tree=null;
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:322:5: ( variable ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:322:9: variable ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) )
            {
            	PushFollow(FOLLOW_variable_in_unaryExpression1242);
            	variable110 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable110.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:322:18: ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) )
            	int alt33 = 2;
            	int LA33_0 = input.LA(1);

            	if ( (LA33_0 == 80) )
            	{
            	    alt33 = 1;
            	}
            	else if ( (LA33_0 == 81) )
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:322:19: '++'
            	        {
            	        	string_literal111=(IToken)Match(input,80,FOLLOW_80_in_unaryExpression1245); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_80.Add(string_literal111);



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
            	        	// 322:24: -> ^( VARINC variable )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:322:27: ^( VARINC variable )
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:323:4: '--'
            	        {
            	        	string_literal112=(IToken)Match(input,81,FOLLOW_81_in_unaryExpression1258); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_81.Add(string_literal112);



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
            	        	// 323:9: -> ^( VARDEC variable )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:323:12: ^( VARDEC variable )
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
            	Memoize(input, 30, unaryExpression_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:328:1: mathAtom : ( '(' expression ')' | IntAtom | FloatAtom | BooleanAtom | stringAtom | LayerAtom | OriginAtom | LoopTypeAtom | ColorAtom | Null | lookup );
    public SGLParser.mathAtom_return mathAtom() // throws RecognitionException [1]
    {   
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.Start = input.LT(1);
        int mathAtom_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal113 = null;
        IToken char_literal115 = null;
        IToken IntAtom116 = null;
        IToken FloatAtom117 = null;
        IToken BooleanAtom118 = null;
        IToken LayerAtom120 = null;
        IToken OriginAtom121 = null;
        IToken LoopTypeAtom122 = null;
        IToken ColorAtom123 = null;
        IToken Null124 = null;
        SGLParser.expression_return expression114 = default(SGLParser.expression_return);

        SGLParser.stringAtom_return stringAtom119 = default(SGLParser.stringAtom_return);

        SGLParser.lookup_return lookup125 = default(SGLParser.lookup_return);


        object char_literal113_tree=null;
        object char_literal115_tree=null;
        object IntAtom116_tree=null;
        object FloatAtom117_tree=null;
        object BooleanAtom118_tree=null;
        object LayerAtom120_tree=null;
        object OriginAtom121_tree=null;
        object LoopTypeAtom122_tree=null;
        object ColorAtom123_tree=null;
        object Null124_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:329:2: ( '(' expression ')' | IntAtom | FloatAtom | BooleanAtom | stringAtom | LayerAtom | OriginAtom | LoopTypeAtom | ColorAtom | Null | lookup )
            int alt34 = 11;
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
            case ColorAtom:
            	{
                alt34 = 9;
                }
                break;
            case Null:
            	{
                alt34 = 10;
                }
                break;
            case Identifier:
            	{
                alt34 = 11;
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:329:4: '(' expression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal113=(IToken)Match(input,59,FOLLOW_59_in_mathAtom1292); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expression_in_mathAtom1295);
                    	expression114 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression114.Tree);
                    	char_literal115=(IToken)Match(input,60,FOLLOW_60_in_mathAtom1297); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:330:7: IntAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IntAtom116=(IToken)Match(input,IntAtom,FOLLOW_IntAtom_in_mathAtom1309); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IntAtom116_tree = (object)adaptor.Create(IntAtom116);
                    		adaptor.AddChild(root_0, IntAtom116_tree);
                    	}

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:331:7: FloatAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FloatAtom117=(IToken)Match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1324); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FloatAtom117_tree = (object)adaptor.Create(FloatAtom117);
                    		adaptor.AddChild(root_0, FloatAtom117_tree);
                    	}

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:332:9: BooleanAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BooleanAtom118=(IToken)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1340); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BooleanAtom118_tree = (object)adaptor.Create(BooleanAtom118);
                    		adaptor.AddChild(root_0, BooleanAtom118_tree);
                    	}

                    }
                    break;
                case 5 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:333:4: stringAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stringAtom_in_mathAtom1351);
                    	stringAtom119 = stringAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, stringAtom119.Tree);

                    }
                    break;
                case 6 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:334:4: LayerAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LayerAtom120=(IToken)Match(input,LayerAtom,FOLLOW_LayerAtom_in_mathAtom1362); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LayerAtom120_tree = (object)adaptor.Create(LayerAtom120);
                    		adaptor.AddChild(root_0, LayerAtom120_tree);
                    	}

                    }
                    break;
                case 7 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:335:4: OriginAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	OriginAtom121=(IToken)Match(input,OriginAtom,FOLLOW_OriginAtom_in_mathAtom1373); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OriginAtom121_tree = (object)adaptor.Create(OriginAtom121);
                    		adaptor.AddChild(root_0, OriginAtom121_tree);
                    	}

                    }
                    break;
                case 8 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:336:4: LoopTypeAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LoopTypeAtom122=(IToken)Match(input,LoopTypeAtom,FOLLOW_LoopTypeAtom_in_mathAtom1384); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LoopTypeAtom122_tree = (object)adaptor.Create(LoopTypeAtom122);
                    		adaptor.AddChild(root_0, LoopTypeAtom122_tree);
                    	}

                    }
                    break;
                case 9 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:337:4: ColorAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ColorAtom123=(IToken)Match(input,ColorAtom,FOLLOW_ColorAtom_in_mathAtom1397); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ColorAtom123_tree = (object)adaptor.Create(ColorAtom123);
                    		adaptor.AddChild(root_0, ColorAtom123_tree);
                    	}

                    }
                    break;
                case 10 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:338:4: Null
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	Null124=(IToken)Match(input,Null,FOLLOW_Null_in_mathAtom1408); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Null124_tree = (object)adaptor.Create(Null124);
                    		adaptor.AddChild(root_0, Null124_tree);
                    	}

                    }
                    break;
                case 11 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:340:4: lookup
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lookup_in_mathAtom1422);
                    	lookup125 = lookup();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, lookup125.Tree);

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
            	Memoize(input, 31, mathAtom_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:343:1: lookup : ( objectMethodCall ( indexes )? -> ^( LOOKUP objectMethodCall ( indexes )? ) | methodCall ( indexes )? -> ^( LOOKUP methodCall ( indexes )? ) | variable ( indexes )? -> ^( LOOKUP variable ( indexes )? ) );
    public SGLParser.lookup_return lookup() // throws RecognitionException [1]
    {   
        SGLParser.lookup_return retval = new SGLParser.lookup_return();
        retval.Start = input.LT(1);
        int lookup_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.objectMethodCall_return objectMethodCall126 = default(SGLParser.objectMethodCall_return);

        SGLParser.indexes_return indexes127 = default(SGLParser.indexes_return);

        SGLParser.methodCall_return methodCall128 = default(SGLParser.methodCall_return);

        SGLParser.indexes_return indexes129 = default(SGLParser.indexes_return);

        SGLParser.variable_return variable130 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes131 = default(SGLParser.indexes_return);


        RewriteRuleSubtreeStream stream_objectMethodCall = new RewriteRuleSubtreeStream(adaptor,"rule objectMethodCall");
        RewriteRuleSubtreeStream stream_methodCall = new RewriteRuleSubtreeStream(adaptor,"rule methodCall");
        RewriteRuleSubtreeStream stream_indexes = new RewriteRuleSubtreeStream(adaptor,"rule indexes");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:2: ( objectMethodCall ( indexes )? -> ^( LOOKUP objectMethodCall ( indexes )? ) | methodCall ( indexes )? -> ^( LOOKUP methodCall ( indexes )? ) | variable ( indexes )? -> ^( LOOKUP variable ( indexes )? ) )
            int alt38 = 3;
            int LA38_0 = input.LA(1);

            if ( (LA38_0 == Identifier) )
            {
                int LA38_1 = input.LA(2);

                if ( (synpred59_SGL()) )
                {
                    alt38 = 1;
                }
                else if ( (synpred61_SGL()) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:4: objectMethodCall ( indexes )?
                    {
                    	PushFollow(FOLLOW_objectMethodCall_in_lookup1441);
                    	objectMethodCall126 = objectMethodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_objectMethodCall.Add(objectMethodCall126.Tree);
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:21: ( indexes )?
                    	int alt35 = 2;
                    	int LA35_0 = input.LA(1);

                    	if ( (LA35_0 == 56) )
                    	{
                    	    alt35 = 1;
                    	}
                    	switch (alt35) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1443);
                    	        	indexes127 = indexes();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes127.Tree);

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
                    	// 344:30: -> ^( LOOKUP objectMethodCall ( indexes )? )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:33: ^( LOOKUP objectMethodCall ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_objectMethodCall.NextTree());
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:59: ( indexes )?
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:345:4: methodCall ( indexes )?
                    {
                    	PushFollow(FOLLOW_methodCall_in_lookup1460);
                    	methodCall128 = methodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_methodCall.Add(methodCall128.Tree);
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:345:15: ( indexes )?
                    	int alt36 = 2;
                    	int LA36_0 = input.LA(1);

                    	if ( (LA36_0 == 56) )
                    	{
                    	    alt36 = 1;
                    	}
                    	switch (alt36) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1462);
                    	        	indexes129 = indexes();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes129.Tree);

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
                    	// 345:24: -> ^( LOOKUP methodCall ( indexes )? )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:345:27: ^( LOOKUP methodCall ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_methodCall.NextTree());
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:345:47: ( indexes )?
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:346:4: variable ( indexes )?
                    {
                    	PushFollow(FOLLOW_variable_in_lookup1480);
                    	variable130 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_variable.Add(variable130.Tree);
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:346:13: ( indexes )?
                    	int alt37 = 2;
                    	int LA37_0 = input.LA(1);

                    	if ( (LA37_0 == 56) )
                    	{
                    	    alt37 = 1;
                    	}
                    	switch (alt37) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
                    	        {
                    	        	PushFollow(FOLLOW_indexes_in_lookup1482);
                    	        	indexes131 = indexes();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes131.Tree);

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
                    	// 346:22: -> ^( LOOKUP variable ( indexes )? )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:346:25: ^( LOOKUP variable ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_variable.NextTree());
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:346:43: ( indexes )?
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
            	Memoize(input, 32, lookup_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:353:1: instantiateClass : 'new' ( Sprite '(' ( expressionList )? ')' -> ^( Sprite ( expressionList )? ) | Animation '(' ( expressionList )? ')' -> ^( Animation ( expressionList )? ) | List '(' ( expressionList )? ')' -> ^( List ( expressionList )? ) ) ;
    public SGLParser.instantiateClass_return instantiateClass() // throws RecognitionException [1]
    {   
        SGLParser.instantiateClass_return retval = new SGLParser.instantiateClass_return();
        retval.Start = input.LT(1);
        int instantiateClass_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal132 = null;
        IToken Sprite133 = null;
        IToken char_literal134 = null;
        IToken char_literal136 = null;
        IToken Animation137 = null;
        IToken char_literal138 = null;
        IToken char_literal140 = null;
        IToken List141 = null;
        IToken char_literal142 = null;
        IToken char_literal144 = null;
        SGLParser.expressionList_return expressionList135 = default(SGLParser.expressionList_return);

        SGLParser.expressionList_return expressionList139 = default(SGLParser.expressionList_return);

        SGLParser.expressionList_return expressionList143 = default(SGLParser.expressionList_return);


        object string_literal132_tree=null;
        object Sprite133_tree=null;
        object char_literal134_tree=null;
        object char_literal136_tree=null;
        object Animation137_tree=null;
        object char_literal138_tree=null;
        object char_literal140_tree=null;
        object List141_tree=null;
        object char_literal142_tree=null;
        object char_literal144_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_Animation = new RewriteRuleTokenStream(adaptor,"token Animation");
        RewriteRuleTokenStream stream_82 = new RewriteRuleTokenStream(adaptor,"token 82");
        RewriteRuleTokenStream stream_List = new RewriteRuleTokenStream(adaptor,"token List");
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleTokenStream stream_Sprite = new RewriteRuleTokenStream(adaptor,"token Sprite");
        RewriteRuleSubtreeStream stream_expressionList = new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 33) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:354:2: ( 'new' ( Sprite '(' ( expressionList )? ')' -> ^( Sprite ( expressionList )? ) | Animation '(' ( expressionList )? ')' -> ^( Animation ( expressionList )? ) | List '(' ( expressionList )? ')' -> ^( List ( expressionList )? ) ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:354:4: 'new' ( Sprite '(' ( expressionList )? ')' -> ^( Sprite ( expressionList )? ) | Animation '(' ( expressionList )? ')' -> ^( Animation ( expressionList )? ) | List '(' ( expressionList )? ')' -> ^( List ( expressionList )? ) )
            {
            	string_literal132=(IToken)Match(input,82,FOLLOW_82_in_instantiateClass1526); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_82.Add(string_literal132);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:355:2: ( Sprite '(' ( expressionList )? ')' -> ^( Sprite ( expressionList )? ) | Animation '(' ( expressionList )? ')' -> ^( Animation ( expressionList )? ) | List '(' ( expressionList )? ')' -> ^( List ( expressionList )? ) )
            	int alt42 = 3;
            	switch ( input.LA(1) ) 
            	{
            	case Sprite:
            		{
            	    alt42 = 1;
            	    }
            	    break;
            	case Animation:
            		{
            	    alt42 = 2;
            	    }
            	    break;
            	case List:
            		{
            	    alt42 = 3;
            	    }
            	    break;
            		default:
            		    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		    NoViableAltException nvae_d42s0 =
            		        new NoViableAltException("", 42, 0, input);

            		    throw nvae_d42s0;
            	}

            	switch (alt42) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:355:4: Sprite '(' ( expressionList )? ')'
            	        {
            	        	Sprite133=(IToken)Match(input,Sprite,FOLLOW_Sprite_in_instantiateClass1531); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_Sprite.Add(Sprite133);

            	        	char_literal134=(IToken)Match(input,59,FOLLOW_59_in_instantiateClass1533); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_59.Add(char_literal134);

            	        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:355:15: ( expressionList )?
            	        	int alt39 = 2;
            	        	int LA39_0 = input.LA(1);

            	        	if ( ((LA39_0 >= Identifier && LA39_0 <= Null) || LA39_0 == 59 || LA39_0 == 74 || LA39_0 == 79 || LA39_0 == 82) )
            	        	{
            	        	    alt39 = 1;
            	        	}
            	        	switch (alt39) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        	        {
            	        	        	PushFollow(FOLLOW_expressionList_in_instantiateClass1535);
            	        	        	expressionList135 = expressionList();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList135.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	char_literal136=(IToken)Match(input,60,FOLLOW_60_in_instantiateClass1538); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_60.Add(char_literal136);



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
            	        	// 355:35: -> ^( Sprite ( expressionList )? )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:355:38: ^( Sprite ( expressionList )? )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot(stream_Sprite.NextNode(), root_1);

            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:355:47: ( expressionList )?
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:356:4: Animation '(' ( expressionList )? ')'
            	        {
            	        	Animation137=(IToken)Match(input,Animation,FOLLOW_Animation_in_instantiateClass1552); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_Animation.Add(Animation137);

            	        	char_literal138=(IToken)Match(input,59,FOLLOW_59_in_instantiateClass1554); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_59.Add(char_literal138);

            	        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:356:18: ( expressionList )?
            	        	int alt40 = 2;
            	        	int LA40_0 = input.LA(1);

            	        	if ( ((LA40_0 >= Identifier && LA40_0 <= Null) || LA40_0 == 59 || LA40_0 == 74 || LA40_0 == 79 || LA40_0 == 82) )
            	        	{
            	        	    alt40 = 1;
            	        	}
            	        	switch (alt40) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        	        {
            	        	        	PushFollow(FOLLOW_expressionList_in_instantiateClass1556);
            	        	        	expressionList139 = expressionList();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList139.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	char_literal140=(IToken)Match(input,60,FOLLOW_60_in_instantiateClass1559); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_60.Add(char_literal140);



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
            	        	// 356:38: -> ^( Animation ( expressionList )? )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:356:41: ^( Animation ( expressionList )? )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot(stream_Animation.NextNode(), root_1);

            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:356:53: ( expressionList )?
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:357:4: List '(' ( expressionList )? ')'
            	        {
            	        	List141=(IToken)Match(input,List,FOLLOW_List_in_instantiateClass1573); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_List.Add(List141);

            	        	char_literal142=(IToken)Match(input,59,FOLLOW_59_in_instantiateClass1575); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_59.Add(char_literal142);

            	        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:357:13: ( expressionList )?
            	        	int alt41 = 2;
            	        	int LA41_0 = input.LA(1);

            	        	if ( ((LA41_0 >= Identifier && LA41_0 <= Null) || LA41_0 == 59 || LA41_0 == 74 || LA41_0 == 79 || LA41_0 == 82) )
            	        	{
            	        	    alt41 = 1;
            	        	}
            	        	switch (alt41) 
            	        	{
            	        	    case 1 :
            	        	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        	        {
            	        	        	PushFollow(FOLLOW_expressionList_in_instantiateClass1577);
            	        	        	expressionList143 = expressionList();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList143.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	char_literal144=(IToken)Match(input,60,FOLLOW_60_in_instantiateClass1580); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_60.Add(char_literal144);



            	        	// AST REWRITE
            	        	// elements:          expressionList, List
            	        	// token labels:      
            	        	// rule labels:       retval
            	        	// token list labels: 
            	        	// rule list labels:  
            	        	// wildcard labels: 
            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = root_0;
            	        	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	        	root_0 = (object)adaptor.GetNilNode();
            	        	// 357:33: -> ^( List ( expressionList )? )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:357:36: ^( List ( expressionList )? )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot(stream_List.NextNode(), root_1);

            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:357:43: ( expressionList )?
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
            	Memoize(input, 33, instantiateClass_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:369:1: expressionList : expression ( ',' expression )* -> ^( EXP_LIST ( expression )+ ) ;
    public SGLParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.Start = input.LT(1);
        int expressionList_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal146 = null;
        SGLParser.expression_return expression145 = default(SGLParser.expression_return);

        SGLParser.expression_return expression147 = default(SGLParser.expression_return);


        object char_literal146_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:370:3: ( expression ( ',' expression )* -> ^( EXP_LIST ( expression )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:370:7: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList1619);
            	expression145 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression145.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:370:18: ( ',' expression )*
            	do 
            	{
            	    int alt43 = 2;
            	    int LA43_0 = input.LA(1);

            	    if ( (LA43_0 == 53) )
            	    {
            	        alt43 = 1;
            	    }


            	    switch (alt43) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:370:19: ',' expression
            			    {
            			    	char_literal146=(IToken)Match(input,53,FOLLOW_53_in_expressionList1622); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_53.Add(char_literal146);

            			    	PushFollow(FOLLOW_expression_in_expressionList1624);
            			    	expression147 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression147.Tree);

            			    }
            			    break;

            			default:
            			    goto loop43;
            	    }
            	} while (true);

            	loop43:
            		;	// Stops C# compiler whining that label 'loop43' has no statements



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
            	// 370:36: -> ^( EXP_LIST ( expression )+ )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:370:39: ^( EXP_LIST ( expression )+ )
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
            	Memoize(input, 34, expressionList_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:374:1: variableList : variable ( ',' variable )* -> ^( VAR_LIST ( variable )+ ) ;
    public SGLParser.variableList_return variableList() // throws RecognitionException [1]
    {   
        SGLParser.variableList_return retval = new SGLParser.variableList_return();
        retval.Start = input.LT(1);
        int variableList_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal149 = null;
        SGLParser.variable_return variable148 = default(SGLParser.variable_return);

        SGLParser.variable_return variable150 = default(SGLParser.variable_return);


        object char_literal149_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:375:3: ( variable ( ',' variable )* -> ^( VAR_LIST ( variable )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:375:5: variable ( ',' variable )*
            {
            	PushFollow(FOLLOW_variable_in_variableList1652);
            	variable148 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable148.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:375:14: ( ',' variable )*
            	do 
            	{
            	    int alt44 = 2;
            	    int LA44_0 = input.LA(1);

            	    if ( (LA44_0 == 53) )
            	    {
            	        alt44 = 1;
            	    }


            	    switch (alt44) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:375:15: ',' variable
            			    {
            			    	char_literal149=(IToken)Match(input,53,FOLLOW_53_in_variableList1655); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_53.Add(char_literal149);

            			    	PushFollow(FOLLOW_variable_in_variableList1657);
            			    	variable150 = variable();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_variable.Add(variable150.Tree);

            			    }
            			    break;

            			default:
            			    goto loop44;
            	    }
            	} while (true);

            	loop44:
            		;	// Stops C# compiler whining that label 'loop44' has no statements



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
            	// 375:30: -> ^( VAR_LIST ( variable )+ )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:375:33: ^( VAR_LIST ( variable )+ )
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
            	Memoize(input, 35, variableList_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:378:1: methodCall : Identifier '(' ( expressionList )? ')' -> ^( METH_CALL Identifier ( expressionList )? ) ;
    public SGLParser.methodCall_return methodCall() // throws RecognitionException [1]
    {   
        SGLParser.methodCall_return retval = new SGLParser.methodCall_return();
        retval.Start = input.LT(1);
        int methodCall_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier151 = null;
        IToken char_literal152 = null;
        IToken char_literal154 = null;
        SGLParser.expressionList_return expressionList153 = default(SGLParser.expressionList_return);


        object Identifier151_tree=null;
        object char_literal152_tree=null;
        object char_literal154_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleSubtreeStream stream_expressionList = new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 36) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:379:2: ( Identifier '(' ( expressionList )? ')' -> ^( METH_CALL Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:379:4: Identifier '(' ( expressionList )? ')'
            {
            	Identifier151=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodCall1680); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier151);

            	char_literal152=(IToken)Match(input,59,FOLLOW_59_in_methodCall1682); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(char_literal152);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:379:19: ( expressionList )?
            	int alt45 = 2;
            	int LA45_0 = input.LA(1);

            	if ( ((LA45_0 >= Identifier && LA45_0 <= Null) || LA45_0 == 59 || LA45_0 == 74 || LA45_0 == 79 || LA45_0 == 82) )
            	{
            	    alt45 = 1;
            	}
            	switch (alt45) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_methodCall1684);
            	        	expressionList153 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList153.Tree);

            	        }
            	        break;

            	}

            	char_literal154=(IToken)Match(input,60,FOLLOW_60_in_methodCall1687); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_60.Add(char_literal154);



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
            	// 379:39: -> ^( METH_CALL Identifier ( expressionList )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:379:42: ^( METH_CALL Identifier ( expressionList )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METH_CALL, "METH_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:379:65: ( expressionList )?
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
            	Memoize(input, 36, methodCall_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:384:1: breakStat : 'break' -> BREAK ;
    public SGLParser.breakStat_return breakStat() // throws RecognitionException [1]
    {   
        SGLParser.breakStat_return retval = new SGLParser.breakStat_return();
        retval.Start = input.LT(1);
        int breakStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal155 = null;

        object string_literal155_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:385:2: ( 'break' -> BREAK )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:385:4: 'break'
            {
            	string_literal155=(IToken)Match(input,83,FOLLOW_83_in_breakStat1714); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(string_literal155);



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
            	// 385:12: -> BREAK
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
            	Memoize(input, 37, breakStat_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:388:1: returnStat : 'return' expression -> ^( RETURN expression ) ;
    public SGLParser.returnStat_return returnStat() // throws RecognitionException [1]
    {   
        SGLParser.returnStat_return retval = new SGLParser.returnStat_return();
        retval.Start = input.LT(1);
        int returnStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal156 = null;
        SGLParser.expression_return expression157 = default(SGLParser.expression_return);


        object string_literal156_tree=null;
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:389:2: ( 'return' expression -> ^( RETURN expression ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:389:4: 'return' expression
            {
            	string_literal156=(IToken)Match(input,84,FOLLOW_84_in_returnStat1729); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_84.Add(string_literal156);

            	PushFollow(FOLLOW_expression_in_returnStat1731);
            	expression157 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression157.Tree);


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
            	// 389:24: -> ^( RETURN expression )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:389:27: ^( RETURN expression )
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
            	Memoize(input, 38, returnStat_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:393:1: whileLoop : 'while' expression commonBlock -> ^( 'while' expression commonBlock ) ;
    public SGLParser.whileLoop_return whileLoop() // throws RecognitionException [1]
    {   
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.Start = input.LT(1);
        int whileLoop_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal158 = null;
        SGLParser.expression_return expression159 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock160 = default(SGLParser.commonBlock_return);


        object string_literal158_tree=null;
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:394:2: ( 'while' expression commonBlock -> ^( 'while' expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:394:4: 'while' expression commonBlock
            {
            	string_literal158=(IToken)Match(input,85,FOLLOW_85_in_whileLoop1754); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal158);

            	PushFollow(FOLLOW_expression_in_whileLoop1756);
            	expression159 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression159.Tree);
            	PushFollow(FOLLOW_commonBlock_in_whileLoop1758);
            	commonBlock160 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock160.Tree);


            	// AST REWRITE
            	// elements:          expression, commonBlock, 85
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 394:35: -> ^( 'while' expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:394:38: ^( 'while' expression commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_85.NextNode(), root_1);

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
            	Memoize(input, 39, whileLoop_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:397:1: forLoop : 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) ;
    public SGLParser.forLoop_return forLoop() // throws RecognitionException [1]
    {   
        SGLParser.forLoop_return retval = new SGLParser.forLoop_return();
        retval.Start = input.LT(1);
        int forLoop_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal161 = null;
        IToken char_literal162 = null;
        IToken char_literal163 = null;
        IToken char_literal164 = null;
        IToken char_literal165 = null;
        SGLParser.oneLineStatement_return dec = default(SGLParser.oneLineStatement_return);

        SGLParser.expression_return cond = default(SGLParser.expression_return);

        SGLParser.oneLineStatement_return iter = default(SGLParser.oneLineStatement_return);

        SGLParser.commonBlock_return commonBlock166 = default(SGLParser.commonBlock_return);


        object string_literal161_tree=null;
        object char_literal162_tree=null;
        object char_literal163_tree=null;
        object char_literal164_tree=null;
        object char_literal165_tree=null;
        RewriteRuleTokenStream stream_59 = new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_52 = new RewriteRuleTokenStream(adaptor,"token 52");
        RewriteRuleTokenStream stream_60 = new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleTokenStream stream_86 = new RewriteRuleTokenStream(adaptor,"token 86");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        RewriteRuleSubtreeStream stream_oneLineStatement = new RewriteRuleSubtreeStream(adaptor,"rule oneLineStatement");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 40) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:2: ( 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:4: 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock
            {
            	string_literal161=(IToken)Match(input,86,FOLLOW_86_in_forLoop1780); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(string_literal161);

            	char_literal162=(IToken)Match(input,59,FOLLOW_59_in_forLoop1782); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(char_literal162);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:17: (dec= oneLineStatement )?
            	int alt46 = 2;
            	int LA46_0 = input.LA(1);

            	if ( (LA46_0 == Identifier || LA46_0 == VarStartInit) )
            	{
            	    alt46 = 1;
            	}
            	switch (alt46) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: dec= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop1786);
            	        	dec = oneLineStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_oneLineStatement.Add(dec.Tree);

            	        }
            	        break;

            	}

            	char_literal163=(IToken)Match(input,52,FOLLOW_52_in_forLoop1789); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal163);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:44: (cond= expression )?
            	int alt47 = 2;
            	int LA47_0 = input.LA(1);

            	if ( ((LA47_0 >= Identifier && LA47_0 <= Null) || LA47_0 == 59 || LA47_0 == 74 || LA47_0 == 79 || LA47_0 == 82) )
            	{
            	    alt47 = 1;
            	}
            	switch (alt47) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: cond= expression
            	        {
            	        	PushFollow(FOLLOW_expression_in_forLoop1793);
            	        	cond = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(cond.Tree);

            	        }
            	        break;

            	}

            	char_literal164=(IToken)Match(input,52,FOLLOW_52_in_forLoop1796); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal164);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:65: (iter= oneLineStatement )?
            	int alt48 = 2;
            	int LA48_0 = input.LA(1);

            	if ( (LA48_0 == Identifier || LA48_0 == VarStartInit) )
            	{
            	    alt48 = 1;
            	}
            	switch (alt48) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: iter= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop1800);
            	        	iter = oneLineStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_oneLineStatement.Add(iter.Tree);

            	        }
            	        break;

            	}

            	char_literal165=(IToken)Match(input,60,FOLLOW_60_in_forLoop1803); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_60.Add(char_literal165);

            	PushFollow(FOLLOW_commonBlock_in_forLoop1805);
            	commonBlock166 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock166.Tree);


            	// AST REWRITE
            	// elements:          iter, dec, commonBlock, cond, 86
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
            	// 399:2: -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:399:5: ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_86.NextNode(), root_1);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:399:13: ^( FORDEC ( $dec)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORDEC, "FORDEC"), root_2);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:399:22: ( $dec)?
            	    if ( stream_dec.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_dec.NextTree());

            	    }
            	    stream_dec.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:399:29: ^( FORCOND ( $cond)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORCOND, "FORCOND"), root_2);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:399:39: ( $cond)?
            	    if ( stream_cond.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_cond.NextTree());

            	    }
            	    stream_cond.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:399:47: ^( FORITER ( $iter)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORITER, "FORITER"), root_2);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:399:57: ( $iter)?
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
            	Memoize(input, 40, forLoop_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:1: ifStatement : ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) ;
    public SGLParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        SGLParser.ifStatement_return retval = new SGLParser.ifStatement_return();
        retval.Start = input.LT(1);
        int ifStatement_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.ifStat_return ifStat167 = default(SGLParser.ifStat_return);

        SGLParser.elseIfStat_return elseIfStat168 = default(SGLParser.elseIfStat_return);

        SGLParser.elseStat_return elseStat169 = default(SGLParser.elseStat_return);


        RewriteRuleSubtreeStream stream_elseIfStat = new RewriteRuleSubtreeStream(adaptor,"rule elseIfStat");
        RewriteRuleSubtreeStream stream_ifStat = new RewriteRuleSubtreeStream(adaptor,"rule ifStat");
        RewriteRuleSubtreeStream stream_elseStat = new RewriteRuleSubtreeStream(adaptor,"rule elseStat");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:403:2: ( ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:403:4: ifStat ( elseIfStat )* ( elseStat )?
            {
            	PushFollow(FOLLOW_ifStat_in_ifStatement1850);
            	ifStat167 = ifStat();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ifStat.Add(ifStat167.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:403:11: ( elseIfStat )*
            	do 
            	{
            	    int alt49 = 2;
            	    int LA49_0 = input.LA(1);

            	    if ( (LA49_0 == 88) )
            	    {
            	        int LA49_1 = input.LA(2);

            	        if ( (LA49_1 == 87) )
            	        {
            	            alt49 = 1;
            	        }


            	    }


            	    switch (alt49) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: elseIfStat
            			    {
            			    	PushFollow(FOLLOW_elseIfStat_in_ifStatement1852);
            			    	elseIfStat168 = elseIfStat();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_elseIfStat.Add(elseIfStat168.Tree);

            			    }
            			    break;

            			default:
            			    goto loop49;
            	    }
            	} while (true);

            	loop49:
            		;	// Stops C# compiler whining that label 'loop49' has no statements

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:403:23: ( elseStat )?
            	int alt50 = 2;
            	int LA50_0 = input.LA(1);

            	if ( (LA50_0 == 88) )
            	{
            	    alt50 = 1;
            	}
            	switch (alt50) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: elseStat
            	        {
            	        	PushFollow(FOLLOW_elseStat_in_ifStatement1855);
            	        	elseStat169 = elseStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_elseStat.Add(elseStat169.Tree);

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
            	// 403:33: -> ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:403:36: ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF, "IF"), root_1);

            	    adaptor.AddChild(root_1, stream_ifStat.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:403:48: ( elseIfStat )*
            	    while ( stream_elseIfStat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_elseIfStat.NextTree());

            	    }
            	    stream_elseIfStat.Reset();
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:403:60: ( elseStat )?
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
            	Memoize(input, 41, ifStatement_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:405:1: ifStat : 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.ifStat_return ifStat() // throws RecognitionException [1]
    {   
        SGLParser.ifStat_return retval = new SGLParser.ifStat_return();
        retval.Start = input.LT(1);
        int ifStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal170 = null;
        SGLParser.expression_return expression171 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock172 = default(SGLParser.commonBlock_return);


        object string_literal170_tree=null;
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:406:2: ( 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:406:4: 'if' expression commonBlock
            {
            	string_literal170=(IToken)Match(input,87,FOLLOW_87_in_ifStat1880); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_87.Add(string_literal170);

            	PushFollow(FOLLOW_expression_in_ifStat1882);
            	expression171 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression171.Tree);
            	PushFollow(FOLLOW_commonBlock_in_ifStat1884);
            	commonBlock172 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock172.Tree);


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
            	// 406:32: -> ^( EXP expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:406:35: ^( EXP expression commonBlock )
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
            	Memoize(input, 42, ifStat_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:409:1: elseIfStat : 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.elseIfStat_return elseIfStat() // throws RecognitionException [1]
    {   
        SGLParser.elseIfStat_return retval = new SGLParser.elseIfStat_return();
        retval.Start = input.LT(1);
        int elseIfStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal173 = null;
        IToken string_literal174 = null;
        SGLParser.expression_return expression175 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock176 = default(SGLParser.commonBlock_return);


        object string_literal173_tree=null;
        object string_literal174_tree=null;
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 43) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:410:2: ( 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:410:4: 'else' 'if' expression commonBlock
            {
            	string_literal173=(IToken)Match(input,88,FOLLOW_88_in_elseIfStat1905); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_88.Add(string_literal173);

            	string_literal174=(IToken)Match(input,87,FOLLOW_87_in_elseIfStat1907); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_87.Add(string_literal174);

            	PushFollow(FOLLOW_expression_in_elseIfStat1909);
            	expression175 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression175.Tree);
            	PushFollow(FOLLOW_commonBlock_in_elseIfStat1911);
            	commonBlock176 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock176.Tree);


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
            	// 410:39: -> ^( EXP expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:410:42: ^( EXP expression commonBlock )
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
            	Memoize(input, 43, elseIfStat_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:413:1: elseStat : 'else' commonBlock -> ^( EXP commonBlock ) ;
    public SGLParser.elseStat_return elseStat() // throws RecognitionException [1]
    {   
        SGLParser.elseStat_return retval = new SGLParser.elseStat_return();
        retval.Start = input.LT(1);
        int elseStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal177 = null;
        SGLParser.commonBlock_return commonBlock178 = default(SGLParser.commonBlock_return);


        object string_literal177_tree=null;
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:414:2: ( 'else' commonBlock -> ^( EXP commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:414:4: 'else' commonBlock
            {
            	string_literal177=(IToken)Match(input,88,FOLLOW_88_in_elseStat1933); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_88.Add(string_literal177);

            	PushFollow(FOLLOW_commonBlock_in_elseStat1935);
            	commonBlock178 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock178.Tree);


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
            	// 414:23: -> ^( EXP commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:414:26: ^( EXP commonBlock )
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
            	Memoize(input, 44, elseStat_StartIndex); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:421:1: atStatement : 'at' expression commonBlock -> ^( AT expression commonBlock ) ;
    public SGLParser.atStatement_return atStatement() // throws RecognitionException [1]
    {   
        SGLParser.atStatement_return retval = new SGLParser.atStatement_return();
        retval.Start = input.LT(1);
        int atStatement_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal179 = null;
        SGLParser.expression_return expression180 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock181 = default(SGLParser.commonBlock_return);


        object string_literal179_tree=null;
        RewriteRuleTokenStream stream_89 = new RewriteRuleTokenStream(adaptor,"token 89");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 45) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:422:2: ( 'at' expression commonBlock -> ^( AT expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:422:4: 'at' expression commonBlock
            {
            	string_literal179=(IToken)Match(input,89,FOLLOW_89_in_atStatement1960); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_89.Add(string_literal179);

            	PushFollow(FOLLOW_expression_in_atStatement1962);
            	expression180 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression180.Tree);
            	PushFollow(FOLLOW_commonBlock_in_atStatement1964);
            	commonBlock181 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock181.Tree);


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
            	// 422:32: -> ^( AT expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:422:35: ^( AT expression commonBlock )
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
            	Memoize(input, 45, atStatement_StartIndex); 
            }
        }
        return retval;
    }
    // $ANTLR end "atStatement"

    // $ANTLR start "synpred59_SGL"
    public void synpred59_SGL_fragment() {
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:4: ( objectMethodCall ( indexes )? )
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:4: objectMethodCall ( indexes )?
        {
        	PushFollow(FOLLOW_objectMethodCall_in_synpred59_SGL1441);
        	objectMethodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:21: ( indexes )?
        	int alt51 = 2;
        	int LA51_0 = input.LA(1);

        	if ( (LA51_0 == 56) )
        	{
        	    alt51 = 1;
        	}
        	switch (alt51) 
        	{
        	    case 1 :
        	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
        	        {
        	        	PushFollow(FOLLOW_indexes_in_synpred59_SGL1443);
        	        	indexes();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred59_SGL"

    // $ANTLR start "synpred61_SGL"
    public void synpred61_SGL_fragment() {
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:345:4: ( methodCall ( indexes )? )
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:345:4: methodCall ( indexes )?
        {
        	PushFollow(FOLLOW_methodCall_in_synpred61_SGL1460);
        	methodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:345:15: ( indexes )?
        	int alt52 = 2;
        	int LA52_0 = input.LA(1);

        	if ( (LA52_0 == 56) )
        	{
        	    alt52 = 1;
        	}
        	switch (alt52) 
        	{
        	    case 1 :
        	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: indexes
        	        {
        	        	PushFollow(FOLLOW_indexes_in_synpred61_SGL1462);
        	        	indexes();
        	        	state.followingStackPointer--;
        	        	if (state.failed) return ;

        	        }
        	        break;

        	}


        }
    }
    // $ANTLR end "synpred61_SGL"

    // Delegated rules

   	public bool synpred61_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred61_SGL_fragment(); // can never throw exception
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


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_mainBlock_in_main234 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mainStatement_in_mainBlock252 = new BitSet(new ulong[]{0x6040040020000002UL,0x0000000002F80000UL});
    public static readonly BitSet FOLLOW_methodDef_in_mainBlock256 = new BitSet(new ulong[]{0x6040040020000002UL,0x0000000002F80000UL});
    public static readonly BitSet FOLLOW_objectMethodDef_in_mainBlock260 = new BitSet(new ulong[]{0x6040040020000002UL,0x0000000002F80000UL});
    public static readonly BitSet FOLLOW_statement_in_block300 = new BitSet(new ulong[]{0x0000040020000002UL,0x0000000002F80000UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_singleBlock325 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_singleBlock_in_commonBlock348 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_commonBlock353 = new BitSet(new ulong[]{0x0008040020000000UL,0x0000000002F80000UL});
    public static readonly BitSet FOLLOW_block_in_commonBlock356 = new BitSet(new ulong[]{0x0008000000000000UL});
    public static readonly BitSet FOLLOW_51_in_commonBlock358 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_statement_in_mainStatement375 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_globalAssignmentList_in_mainStatement380 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_mainStatement382 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_statement397 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStatement_in_statement402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_atStatement_in_statement407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_whileLoop_in_statement412 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_forLoop_in_statement417 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_semicolonStatement430 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_methodCall_in_semicolonStatement435 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_assignmentList_in_semicolonStatement441 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_semicolonStatement447 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_breakStat_in_semicolonStatement453 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_returnStat_in_semicolonStatement458 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_semicolonStatement463 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignmentList_in_oneLineStatement476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_oneLineStatement481 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VarStartInit_in_assignmentList496 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_assignment_in_assignmentList499 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_assignmentList502 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_assignment_in_assignmentList505 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_54_in_globalAssignmentList521 = new BitSet(new ulong[]{0x0000040000000000UL});
    public static readonly BitSet FOLLOW_VarStartInit_in_globalAssignmentList524 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_globalAssignment_in_globalAssignmentList527 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_globalAssignmentList530 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_globalAssignment_in_globalAssignmentList533 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_globalAssignment547 = new BitSet(new ulong[]{0x0180000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_globalAssignment549 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_55_in_globalAssignment553 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_globalAssignment555 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment586 = new BitSet(new ulong[]{0x0180000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_assignment588 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_55_in_assignment592 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_assignment594 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_indexes629 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_indexes631 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_indexes633 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_objectMethodCall660 = new BitSet(new ulong[]{0x0500000000000000UL});
    public static readonly BitSet FOLLOW_indexes_in_objectMethodCall662 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_objectMethodCall665 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethodCall667 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_objectMethodCall669 = new BitSet(new ulong[]{0x1800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expressionList_in_objectMethodCall671 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_objectMethodCall674 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable708 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringAtom_in_stringAtom731 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_methodDef752 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodDef754 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_methodDef756 = new BitSet(new ulong[]{0x1000000020000000UL});
    public static readonly BitSet FOLLOW_variableList_in_methodDef758 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_methodDef761 = new BitSet(new ulong[]{0x0004040020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_methodDef763 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_objectMethodDef781 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethodDef783 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_objectMethodDef785 = new BitSet(new ulong[]{0x1000000020000000UL});
    public static readonly BitSet FOLLOW_variableList_in_objectMethodDef787 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_objectMethodDef790 = new BitSet(new ulong[]{0x0004040020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_objectMethodDef792 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_instantiateClass_in_expression823 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression833 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression859 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_conditionalExpression863 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression866 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_conditionalExpression868 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression871 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression914 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_conditionalOrExpression918 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression921 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression952 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_conditionalAndExpression956 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression959 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression986 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000018UL});
    public static readonly BitSet FOLLOW_67_in_equalityExpression991 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_68_in_equalityExpression996 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression1000 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000018UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1031 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000001E0UL});
    public static readonly BitSet FOLLOW_69_in_relationalExpression1035 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_70_in_relationalExpression1038 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_71_in_relationalExpression1041 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_72_in_relationalExpression1044 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1048 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000001E0UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1086 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000600UL});
    public static readonly BitSet FOLLOW_73_in_additiveExpression1090 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_74_in_additiveExpression1093 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1097 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000600UL});
    public static readonly BitSet FOLLOW_powExpression_in_multiplicativeExpression1131 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000003800UL});
    public static readonly BitSet FOLLOW_75_in_multiplicativeExpression1135 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_76_in_multiplicativeExpression1138 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_77_in_multiplicativeExpression1141 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_powExpression_in_multiplicativeExpression1145 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000003800UL});
    public static readonly BitSet FOLLOW_negateExpression_in_powExpression1165 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_powExpression1168 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_negateExpression_in_powExpression1171 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_74_in_negateExpression1189 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1191 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_negateExpression1204 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1206 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_negateExpression1219 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1224 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_unaryExpression1242 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000030000UL});
    public static readonly BitSet FOLLOW_80_in_unaryExpression1245 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_unaryExpression1258 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_mathAtom1292 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_mathAtom1295 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_mathAtom1297 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntAtom_in_mathAtom1309 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_mathAtom1324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_mathAtom1340 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stringAtom_in_mathAtom1351 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LayerAtom_in_mathAtom1362 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OriginAtom_in_mathAtom1373 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LoopTypeAtom_in_mathAtom1384 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ColorAtom_in_mathAtom1397 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Null_in_mathAtom1408 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookup_in_mathAtom1422 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_lookup1441 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1443 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_lookup1460 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1462 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_lookup1480 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1482 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_instantiateClass1526 = new BitSet(new ulong[]{0x0000038000000000UL});
    public static readonly BitSet FOLLOW_Sprite_in_instantiateClass1531 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_instantiateClass1533 = new BitSet(new ulong[]{0x1800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1535 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_instantiateClass1538 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Animation_in_instantiateClass1552 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_instantiateClass1554 = new BitSet(new ulong[]{0x1800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1556 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_instantiateClass1559 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_List_in_instantiateClass1573 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_instantiateClass1575 = new BitSet(new ulong[]{0x1800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1577 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_instantiateClass1580 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1619 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_expressionList1622 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1624 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_variableList1652 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_variableList1655 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_variable_in_variableList1657 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodCall1680 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_methodCall1682 = new BitSet(new ulong[]{0x1800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expressionList_in_methodCall1684 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_methodCall1687 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_breakStat1714 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_returnStat1729 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_returnStat1731 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_whileLoop1754 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop1756 = new BitSet(new ulong[]{0x0004040020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_whileLoop1758 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_86_in_forLoop1780 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_forLoop1782 = new BitSet(new ulong[]{0x0010040020000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop1786 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_forLoop1789 = new BitSet(new ulong[]{0x0810007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop1793 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_forLoop1796 = new BitSet(new ulong[]{0x1000040020000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop1800 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_forLoop1803 = new BitSet(new ulong[]{0x0004040020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_forLoop1805 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStat_in_ifStatement1850 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_elseIfStat_in_ifStatement1852 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_elseStat_in_ifStatement1855 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_87_in_ifStat1880 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_ifStat1882 = new BitSet(new ulong[]{0x0004040020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_ifStat1884 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_88_in_elseIfStat1905 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_87_in_elseIfStat1907 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_elseIfStat1909 = new BitSet(new ulong[]{0x0004040020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseIfStat1911 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_88_in_elseStat1933 = new BitSet(new ulong[]{0x0004040020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseStat1935 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_89_in_atStatement1960 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_atStatement1962 = new BitSet(new ulong[]{0x0004040020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_atStatement1964 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_synpred59_SGL1441 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_synpred59_SGL1443 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_synpred61_SGL1460 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_synpred61_SGL1462 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}