// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\sgl4c#\\NewSGLGramma\\SGL.g 2012-03-28 19:59:22

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
		"VarStartChar", 
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
    public const int VarStartChar = 42;
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
                    CommonTreeNodeStream methodNodes = new CommonTreeNodeStream(code);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:146:1: main : mainBlock ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:147:5: ( mainBlock )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:147:7: mainBlock
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:154:1: mainBlock : ( mainStatement | methodDef | objectMethodDef )* -> ^( BLOCK ( mainStatement )* ) ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:155:2: ( ( mainStatement | methodDef | objectMethodDef )* -> ^( BLOCK ( mainStatement )* ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:155:4: ( mainStatement | methodDef | objectMethodDef )*
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:155:4: ( mainStatement | methodDef | objectMethodDef )*
            	do 
            	{
            	    int alt1 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case Identifier:
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:155:5: mainStatement
            			    {
            			    	PushFollow(FOLLOW_mainStatement_in_mainBlock252);
            			    	mainStatement2 = mainStatement();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_mainStatement.Add(mainStatement2.Tree);

            			    }
            			    break;
            			case 2 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:155:21: methodDef
            			    {
            			    	PushFollow(FOLLOW_methodDef_in_mainBlock256);
            			    	methodDef3 = methodDef();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_methodDef.Add(methodDef3.Tree);

            			    }
            			    break;
            			case 3 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:155:33: objectMethodDef
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
            	// 156:8: -> ^( BLOCK ( mainStatement )* )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:156:11: ^( BLOCK ( mainStatement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:156:20: ( mainStatement )*
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:160:1: block : ( statement )* -> ^( BLOCK ( statement )* ) ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:161:2: ( ( statement )* -> ^( BLOCK ( statement )* ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:161:4: ( statement )*
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:161:4: ( statement )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == Identifier || (LA2_0 >= 83 && LA2_0 <= 87) || LA2_0 == 89) )
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
            	// 162:3: -> ^( BLOCK ( statement )* )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:162:6: ^( BLOCK ( statement )* )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:162:14: ( statement )*
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:166:1: singleBlock : semicolonStatement -> ^( BLOCK semicolonStatement ) ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:167:2: ( semicolonStatement -> ^( BLOCK semicolonStatement ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:167:4: semicolonStatement
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
            	// 168:3: -> ^( BLOCK semicolonStatement )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:168:6: ^( BLOCK semicolonStatement )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:172:1: commonBlock : ( singleBlock | '{' block '}' );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:173:2: ( singleBlock | '{' block '}' )
            int alt3 = 2;
            int LA3_0 = input.LA(1);

            if ( (LA3_0 == Identifier || (LA3_0 >= 83 && LA3_0 <= 84)) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:173:4: singleBlock
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:174:4: '{' block '}'
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:179:1: mainStatement : ( statement | globalAssignmentList ';' );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:180:2: ( statement | globalAssignmentList ';' )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == Identifier || (LA4_0 >= 83 && LA4_0 <= 87) || LA4_0 == 89) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:180:4: statement
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:181:4: globalAssignmentList ';'
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:184:1: statement : ( semicolonStatement | ifStatement | atStatement | whileLoop | forLoop );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:185:2: ( semicolonStatement | ifStatement | atStatement | whileLoop | forLoop )
            int alt5 = 5;
            switch ( input.LA(1) ) 
            {
            case Identifier:
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:185:4: semicolonStatement
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:186:4: ifStatement
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:187:4: atStatement
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:188:4: whileLoop
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:189:4: forLoop
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:192:1: semicolonStatement : ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat ) ';' ;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:193:2: ( ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat ) ';' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:193:4: ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat ) ';'
            {
            	root_0 = (object)adaptor.GetNilNode();

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:193:4: ( objectMethodCall | methodCall | assignmentList | unaryExpression | breakStat | returnStat )
            	int alt6 = 6;
            	switch ( input.LA(1) ) 
            	{
            	case Identifier:
            		{
            	    int LA6_1 = input.LA(2);

            	    if ( (synpred11_SGL()) )
            	    {
            	        alt6 = 1;
            	    }
            	    else if ( (synpred12_SGL()) )
            	    {
            	        alt6 = 2;
            	    }
            	    else if ( (synpred13_SGL()) )
            	    {
            	        alt6 = 3;
            	    }
            	    else if ( (synpred14_SGL()) )
            	    {
            	        alt6 = 4;
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:193:5: objectMethodCall
            	        {
            	        	PushFollow(FOLLOW_objectMethodCall_in_semicolonStatement430);
            	        	objectMethodCall19 = objectMethodCall();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectMethodCall19.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:194:4: methodCall
            	        {
            	        	PushFollow(FOLLOW_methodCall_in_semicolonStatement435);
            	        	methodCall20 = methodCall();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodCall20.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:195:4: assignmentList
            	        {
            	        	PushFollow(FOLLOW_assignmentList_in_semicolonStatement441);
            	        	assignmentList21 = assignmentList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignmentList21.Tree);

            	        }
            	        break;
            	    case 4 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:196:4: unaryExpression
            	        {
            	        	PushFollow(FOLLOW_unaryExpression_in_semicolonStatement447);
            	        	unaryExpression22 = unaryExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression22.Tree);

            	        }
            	        break;
            	    case 5 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:197:4: breakStat
            	        {
            	        	PushFollow(FOLLOW_breakStat_in_semicolonStatement453);
            	        	breakStat23 = breakStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, breakStat23.Tree);

            	        }
            	        break;
            	    case 6 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:198:4: returnStat
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:202:1: oneLineStatement : ( assignmentList | unaryExpression );
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:203:2: ( assignmentList | unaryExpression )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == Identifier) )
            {
                int LA7_1 = input.LA(2);

                if ( ((LA7_1 >= 80 && LA7_1 <= 81)) )
                {
                    alt7 = 2;
                }
                else if ( (LA7_1 == EOF || (LA7_1 >= 52 && LA7_1 <= 53) || (LA7_1 >= 55 && LA7_1 <= 56) || LA7_1 == 60) )
                {
                    alt7 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d7s1 =
                        new NoViableAltException("", 7, 1, input);

                    throw nvae_d7s1;
                }
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:203:4: assignmentList
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:204:4: unaryExpression
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:207:1: assignmentList : assignment ( ',' assignment )* ;
    public SGLParser.assignmentList_return assignmentList() // throws RecognitionException [1]
    {   
        SGLParser.assignmentList_return retval = new SGLParser.assignmentList_return();
        retval.Start = input.LT(1);
        int assignmentList_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal29 = null;
        SGLParser.assignment_return assignment28 = default(SGLParser.assignment_return);

        SGLParser.assignment_return assignment30 = default(SGLParser.assignment_return);


        object char_literal29_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 10) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:208:2: ( assignment ( ',' assignment )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:208:4: assignment ( ',' assignment )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_assignment_in_assignmentList496);
            	assignment28 = assignment();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment28.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:208:15: ( ',' assignment )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:208:16: ',' assignment
            			    {
            			    	char_literal29=(IToken)Match(input,53,FOLLOW_53_in_assignmentList499); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_assignment_in_assignmentList502);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:212:1: globalAssignmentList : 'global' globalAssignment ( ',' globalAssignment )* ;
    public SGLParser.globalAssignmentList_return globalAssignmentList() // throws RecognitionException [1]
    {   
        SGLParser.globalAssignmentList_return retval = new SGLParser.globalAssignmentList_return();
        retval.Start = input.LT(1);
        int globalAssignmentList_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal31 = null;
        IToken char_literal33 = null;
        SGLParser.globalAssignment_return globalAssignment32 = default(SGLParser.globalAssignment_return);

        SGLParser.globalAssignment_return globalAssignment34 = default(SGLParser.globalAssignment_return);


        object string_literal31_tree=null;
        object char_literal33_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 11) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:213:2: ( 'global' globalAssignment ( ',' globalAssignment )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:213:4: 'global' globalAssignment ( ',' globalAssignment )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal31=(IToken)Match(input,54,FOLLOW_54_in_globalAssignmentList518); if (state.failed) return retval;
            	PushFollow(FOLLOW_globalAssignment_in_globalAssignmentList521);
            	globalAssignment32 = globalAssignment();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, globalAssignment32.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:213:31: ( ',' globalAssignment )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:213:32: ',' globalAssignment
            			    {
            			    	char_literal33=(IToken)Match(input,53,FOLLOW_53_in_globalAssignmentList524); if (state.failed) return retval;
            			    	PushFollow(FOLLOW_globalAssignment_in_globalAssignmentList527);
            			    	globalAssignment34 = globalAssignment();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, globalAssignment34.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:216:1: globalAssignment : variable ( indexes )? ( '=' expression )? -> ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? ) ;
    public SGLParser.globalAssignment_return globalAssignment() // throws RecognitionException [1]
    {   
        SGLParser.globalAssignment_return retval = new SGLParser.globalAssignment_return();
        retval.Start = input.LT(1);
        int globalAssignment_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal37 = null;
        SGLParser.variable_return variable35 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes36 = default(SGLParser.indexes_return);

        SGLParser.expression_return expression38 = default(SGLParser.expression_return);


        object char_literal37_tree=null;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:2: ( variable ( indexes )? ( '=' expression )? -> ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:4: variable ( indexes )? ( '=' expression )?
            {
            	PushFollow(FOLLOW_variable_in_globalAssignment541);
            	variable35 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable35.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:13: ( indexes )?
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
            	        	PushFollow(FOLLOW_indexes_in_globalAssignment543);
            	        	indexes36 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes36.Tree);

            	        }
            	        break;

            	}

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:22: ( '=' expression )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == 55) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:23: '=' expression
            	        {
            	        	char_literal37=(IToken)Match(input,55,FOLLOW_55_in_globalAssignment547); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_55.Add(char_literal37);

            	        	PushFollow(FOLLOW_expression_in_globalAssignment549);
            	        	expression38 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression38.Tree);

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
            	// 217:41: -> ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:44: ^( GLOBAL_ASSIGN variable ( indexes )? ( expression )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(GLOBAL_ASSIGN, "GLOBAL_ASSIGN"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:69: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:217:78: ( expression )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:220:1: assignment : variable ( indexes )? ( '=' expression )? -> ^( ASSIGN variable ( indexes )? ( expression )? ) ;
    public SGLParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        SGLParser.assignment_return retval = new SGLParser.assignment_return();
        retval.Start = input.LT(1);
        int assignment_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal41 = null;
        SGLParser.variable_return variable39 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes40 = default(SGLParser.indexes_return);

        SGLParser.expression_return expression42 = default(SGLParser.expression_return);


        object char_literal41_tree=null;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:2: ( variable ( indexes )? ( '=' expression )? -> ^( ASSIGN variable ( indexes )? ( expression )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:4: variable ( indexes )? ( '=' expression )?
            {
            	PushFollow(FOLLOW_variable_in_assignment580);
            	variable39 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable39.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:13: ( indexes )?
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
            	        	PushFollow(FOLLOW_indexes_in_assignment582);
            	        	indexes40 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes40.Tree);

            	        }
            	        break;

            	}

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:22: ( '=' expression )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == 55) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:23: '=' expression
            	        {
            	        	char_literal41=(IToken)Match(input,55,FOLLOW_55_in_assignment586); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_55.Add(char_literal41);

            	        	PushFollow(FOLLOW_expression_in_assignment588);
            	        	expression42 = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(expression42.Tree);

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
            	// 221:41: -> ^( ASSIGN variable ( indexes )? ( expression )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:44: ^( ASSIGN variable ( indexes )? ( expression )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(ASSIGN, "ASSIGN"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:62: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:221:71: ( expression )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:224:1: indexes : ( '[' expression ']' )+ -> ^( INDEXES ( expression )+ ) ;
    public SGLParser.indexes_return indexes() // throws RecognitionException [1]
    {   
        SGLParser.indexes_return retval = new SGLParser.indexes_return();
        retval.Start = input.LT(1);
        int indexes_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal43 = null;
        IToken char_literal45 = null;
        SGLParser.expression_return expression44 = default(SGLParser.expression_return);


        object char_literal43_tree=null;
        object char_literal45_tree=null;
        RewriteRuleTokenStream stream_57 = new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleTokenStream stream_56 = new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 14) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:4: ( ( '[' expression ']' )+ -> ^( INDEXES ( expression )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:8: ( '[' expression ']' )+
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:8: ( '[' expression ']' )+
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:9: '[' expression ']'
            			    {
            			    	char_literal43=(IToken)Match(input,56,FOLLOW_56_in_indexes623); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_56.Add(char_literal43);

            			    	PushFollow(FOLLOW_expression_in_indexes625);
            			    	expression44 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression44.Tree);
            			    	char_literal45=(IToken)Match(input,57,FOLLOW_57_in_indexes627); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_57.Add(char_literal45);


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
            	// 225:30: -> ^( INDEXES ( expression )+ )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:225:33: ^( INDEXES ( expression )+ )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:228:1: objectMethodCall : variable ( indexes )? '.' Identifier '(' ( expressionList )? ')' -> ^( OBJ_METH_CALL variable ( indexes )? Identifier ( expressionList )? ) ;
    public SGLParser.objectMethodCall_return objectMethodCall() // throws RecognitionException [1]
    {   
        SGLParser.objectMethodCall_return retval = new SGLParser.objectMethodCall_return();
        retval.Start = input.LT(1);
        int objectMethodCall_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal48 = null;
        IToken Identifier49 = null;
        IToken char_literal50 = null;
        IToken char_literal52 = null;
        SGLParser.variable_return variable46 = default(SGLParser.variable_return);

        SGLParser.indexes_return indexes47 = default(SGLParser.indexes_return);

        SGLParser.expressionList_return expressionList51 = default(SGLParser.expressionList_return);


        object char_literal48_tree=null;
        object Identifier49_tree=null;
        object char_literal50_tree=null;
        object char_literal52_tree=null;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:2: ( variable ( indexes )? '.' Identifier '(' ( expressionList )? ')' -> ^( OBJ_METH_CALL variable ( indexes )? Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:4: variable ( indexes )? '.' Identifier '(' ( expressionList )? ')'
            {
            	PushFollow(FOLLOW_variable_in_objectMethodCall654);
            	variable46 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable46.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:13: ( indexes )?
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
            	        	PushFollow(FOLLOW_indexes_in_objectMethodCall656);
            	        	indexes47 = indexes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes47.Tree);

            	        }
            	        break;

            	}

            	char_literal48=(IToken)Match(input,58,FOLLOW_58_in_objectMethodCall659); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_58.Add(char_literal48);

            	Identifier49=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_objectMethodCall661); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier49);

            	char_literal50=(IToken)Match(input,59,FOLLOW_59_in_objectMethodCall663); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(char_literal50);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:41: ( expressionList )?
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
            	        	PushFollow(FOLLOW_expressionList_in_objectMethodCall665);
            	        	expressionList51 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList51.Tree);

            	        }
            	        break;

            	}

            	char_literal52=(IToken)Match(input,60,FOLLOW_60_in_objectMethodCall668); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_60.Add(char_literal52);



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
            	// 229:61: -> ^( OBJ_METH_CALL variable ( indexes )? Identifier ( expressionList )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:64: ^( OBJ_METH_CALL variable ( indexes )? Identifier ( expressionList )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(OBJ_METH_CALL, "OBJ_METH_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_variable.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:89: ( indexes )?
            	    if ( stream_indexes.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_indexes.NextTree());

            	    }
            	    stream_indexes.Reset();
            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:229:109: ( expressionList )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:233:1: variable : Identifier -> Identifier ;
    public SGLParser.variable_return variable() // throws RecognitionException [1]
    {   
        SGLParser.variable_return retval = new SGLParser.variable_return();
        retval.Start = input.LT(1);
        int variable_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier53 = null;

        object Identifier53_tree=null;
        RewriteRuleTokenStream stream_Identifier = new RewriteRuleTokenStream(adaptor,"token Identifier");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 16) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:234:2: ( Identifier -> Identifier )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:234:4: Identifier
            {
            	Identifier53=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_variable702); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier53);



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
            	// 234:15: -> Identifier
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:239:1: stringAtom : StringAtom -> ^( STRING StringAtom ) ;
    public SGLParser.stringAtom_return stringAtom() // throws RecognitionException [1]
    {   
        SGLParser.stringAtom_return retval = new SGLParser.stringAtom_return();
        retval.Start = input.LT(1);
        int stringAtom_StartIndex = input.Index();
        object root_0 = null;

        IToken StringAtom54 = null;

        object StringAtom54_tree=null;
        RewriteRuleTokenStream stream_StringAtom = new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 17) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:240:2: ( StringAtom -> ^( STRING StringAtom ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:240:6: StringAtom
            {
            	StringAtom54=(IToken)Match(input,StringAtom,FOLLOW_StringAtom_in_stringAtom725); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_StringAtom.Add(StringAtom54);



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
            	// 240:17: -> ^( STRING StringAtom )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:240:20: ^( STRING StringAtom )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:245:1: methodDef : 'method' Identifier '(' ( variableList )? ')' commonBlock ;
    public SGLParser.methodDef_return methodDef() // throws RecognitionException [1]
    {   
        SGLParser.methodDef_return retval = new SGLParser.methodDef_return();
        retval.Start = input.LT(1);
        int methodDef_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal55 = null;
        IToken Identifier56 = null;
        IToken char_literal57 = null;
        IToken char_literal59 = null;
        SGLParser.variableList_return variableList58 = default(SGLParser.variableList_return);

        SGLParser.commonBlock_return commonBlock60 = default(SGLParser.commonBlock_return);


        object string_literal55_tree=null;
        object Identifier56_tree=null;
        object char_literal57_tree=null;
        object char_literal59_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 18) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:246:2: ( 'method' Identifier '(' ( variableList )? ')' commonBlock )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:246:4: 'method' Identifier '(' ( variableList )? ')' commonBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal55=(IToken)Match(input,61,FOLLOW_61_in_methodDef746); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal55_tree = (object)adaptor.Create(string_literal55);
            		adaptor.AddChild(root_0, string_literal55_tree);
            	}
            	Identifier56=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodDef748); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier56_tree = (object)adaptor.Create(Identifier56);
            		adaptor.AddChild(root_0, Identifier56_tree);
            	}
            	char_literal57=(IToken)Match(input,59,FOLLOW_59_in_methodDef750); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal57_tree = (object)adaptor.Create(char_literal57);
            		adaptor.AddChild(root_0, char_literal57_tree);
            	}
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:246:28: ( variableList )?
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
            	        	PushFollow(FOLLOW_variableList_in_methodDef752);
            	        	variableList58 = variableList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableList58.Tree);

            	        }
            	        break;

            	}

            	char_literal59=(IToken)Match(input,60,FOLLOW_60_in_methodDef755); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal59_tree = (object)adaptor.Create(char_literal59);
            		adaptor.AddChild(root_0, char_literal59_tree);
            	}
            	PushFollow(FOLLOW_commonBlock_in_methodDef757);
            	commonBlock60 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, commonBlock60.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   DefineMethod(((Identifier56 != null) ? Identifier56.Text : null), ((variableList58 != null) ? ((object)variableList58.Tree) : null), ((commonBlock60 != null) ? ((object)commonBlock60.Tree) : null)); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:251:1: objectMethodDef : 'object method' Identifier '(' ( variableList )? ')' commonBlock ;
    public SGLParser.objectMethodDef_return objectMethodDef() // throws RecognitionException [1]
    {   
        SGLParser.objectMethodDef_return retval = new SGLParser.objectMethodDef_return();
        retval.Start = input.LT(1);
        int objectMethodDef_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal61 = null;
        IToken Identifier62 = null;
        IToken char_literal63 = null;
        IToken char_literal65 = null;
        SGLParser.variableList_return variableList64 = default(SGLParser.variableList_return);

        SGLParser.commonBlock_return commonBlock66 = default(SGLParser.commonBlock_return);


        object string_literal61_tree=null;
        object Identifier62_tree=null;
        object char_literal63_tree=null;
        object char_literal65_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 19) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:252:2: ( 'object method' Identifier '(' ( variableList )? ')' commonBlock )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:252:4: 'object method' Identifier '(' ( variableList )? ')' commonBlock
            {
            	root_0 = (object)adaptor.GetNilNode();

            	string_literal61=(IToken)Match(input,62,FOLLOW_62_in_objectMethodDef775); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal61_tree = (object)adaptor.Create(string_literal61);
            		adaptor.AddChild(root_0, string_literal61_tree);
            	}
            	Identifier62=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_objectMethodDef777); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{Identifier62_tree = (object)adaptor.Create(Identifier62);
            		adaptor.AddChild(root_0, Identifier62_tree);
            	}
            	char_literal63=(IToken)Match(input,59,FOLLOW_59_in_objectMethodDef779); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal63_tree = (object)adaptor.Create(char_literal63);
            		adaptor.AddChild(root_0, char_literal63_tree);
            	}
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:252:35: ( variableList )?
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
            	        	PushFollow(FOLLOW_variableList_in_objectMethodDef781);
            	        	variableList64 = variableList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, variableList64.Tree);

            	        }
            	        break;

            	}

            	char_literal65=(IToken)Match(input,60,FOLLOW_60_in_objectMethodDef784); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{char_literal65_tree = (object)adaptor.Create(char_literal65);
            		adaptor.AddChild(root_0, char_literal65_tree);
            	}
            	PushFollow(FOLLOW_commonBlock_in_objectMethodDef786);
            	commonBlock66 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, commonBlock66.Tree);
            	if ( (state.backtracking==0) )
            	{
            	   DefineObjectMethod(((Identifier62 != null) ? Identifier62.Text : null), ((variableList64 != null) ? ((object)variableList64.Tree) : null), ((commonBlock66 != null) ? ((object)commonBlock66.Tree) : null)); 
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:265:1: expression : ( instantiateClass | conditionalExpression );
    public SGLParser.expression_return expression() // throws RecognitionException [1]
    {   
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.Start = input.LT(1);
        int expression_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.instantiateClass_return instantiateClass67 = default(SGLParser.instantiateClass_return);

        SGLParser.conditionalExpression_return conditionalExpression68 = default(SGLParser.conditionalExpression_return);



        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 20) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:266:5: ( instantiateClass | conditionalExpression )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:266:7: instantiateClass
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_instantiateClass_in_expression817);
                    	instantiateClass67 = instantiateClass();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, instantiateClass67.Tree);

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:267:7: conditionalExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_conditionalExpression_in_expression827);
                    	conditionalExpression68 = conditionalExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression68.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:272:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public SGLParser.conditionalExpression_return conditionalExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.Start = input.LT(1);
        int conditionalExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal70 = null;
        IToken char_literal72 = null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression69 = default(SGLParser.conditionalOrExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression71 = default(SGLParser.conditionalExpression_return);

        SGLParser.conditionalExpression_return conditionalExpression73 = default(SGLParser.conditionalExpression_return);


        object char_literal70_tree=null;
        object char_literal72_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 21) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:273:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:273:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression853);
            	conditionalOrExpression69 = conditionalOrExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalOrExpression69.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:273:33: ( '?' conditionalExpression ':' conditionalExpression )?
            	int alt20 = 2;
            	int LA20_0 = input.LA(1);

            	if ( (LA20_0 == 63) )
            	{
            	    alt20 = 1;
            	}
            	switch (alt20) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:273:35: '?' conditionalExpression ':' conditionalExpression
            	        {
            	        	char_literal70=(IToken)Match(input,63,FOLLOW_63_in_conditionalExpression857); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{char_literal70_tree = (object)adaptor.Create(char_literal70);
            	        		root_0 = (object)adaptor.BecomeRoot(char_literal70_tree, root_0);
            	        	}
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression860);
            	        	conditionalExpression71 = conditionalExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression71.Tree);
            	        	char_literal72=(IToken)Match(input,64,FOLLOW_64_in_conditionalExpression862); if (state.failed) return retval;
            	        	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression865);
            	        	conditionalExpression73 = conditionalExpression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalExpression73.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:278:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public SGLParser.conditionalOrExpression_return conditionalOrExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.Start = input.LT(1);
        int conditionalOrExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal75 = null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression74 = default(SGLParser.conditionalAndExpression_return);

        SGLParser.conditionalAndExpression_return conditionalAndExpression76 = default(SGLParser.conditionalAndExpression_return);


        object string_literal75_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 22) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:279:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:279:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression908);
            	conditionalAndExpression74 = conditionalAndExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression74.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:279:34: ( '||' conditionalAndExpression )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:279:36: '||' conditionalAndExpression
            			    {
            			    	string_literal75=(IToken)Match(input,65,FOLLOW_65_in_conditionalOrExpression912); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal75_tree = (object)adaptor.Create(string_literal75);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal75_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression915);
            			    	conditionalAndExpression76 = conditionalAndExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, conditionalAndExpression76.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:283:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public SGLParser.conditionalAndExpression_return conditionalAndExpression() // throws RecognitionException [1]
    {   
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.Start = input.LT(1);
        int conditionalAndExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal78 = null;
        SGLParser.equalityExpression_return equalityExpression77 = default(SGLParser.equalityExpression_return);

        SGLParser.equalityExpression_return equalityExpression79 = default(SGLParser.equalityExpression_return);


        object string_literal78_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 23) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:284:5: ( equalityExpression ( '&&' equalityExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:284:9: equalityExpression ( '&&' equalityExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression946);
            	equalityExpression77 = equalityExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression77.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:284:28: ( '&&' equalityExpression )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:284:30: '&&' equalityExpression
            			    {
            			    	string_literal78=(IToken)Match(input,66,FOLLOW_66_in_conditionalAndExpression950); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{string_literal78_tree = (object)adaptor.Create(string_literal78);
            			    		root_0 = (object)adaptor.BecomeRoot(string_literal78_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression953);
            			    	equalityExpression79 = equalityExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, equalityExpression79.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:288:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public SGLParser.equalityExpression_return equalityExpression() // throws RecognitionException [1]
    {   
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.Start = input.LT(1);
        int equalityExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal81 = null;
        IToken string_literal82 = null;
        SGLParser.relationalExpression_return relationalExpression80 = default(SGLParser.relationalExpression_return);

        SGLParser.relationalExpression_return relationalExpression83 = default(SGLParser.relationalExpression_return);


        object string_literal81_tree=null;
        object string_literal82_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 24) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:289:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:289:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression980);
            	relationalExpression80 = relationalExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression80.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:289:30: ( ( '==' | '!=' ) relationalExpression )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:289:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:289:32: ( '==' | '!=' )
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
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:289:33: '=='
            			    	        {
            			    	        	string_literal81=(IToken)Match(input,67,FOLLOW_67_in_equalityExpression985); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal81_tree = (object)adaptor.Create(string_literal81);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal81_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:289:41: '!='
            			    	        {
            			    	        	string_literal82=(IToken)Match(input,68,FOLLOW_68_in_equalityExpression990); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal82_tree = (object)adaptor.Create(string_literal82);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal82_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression994);
            			    	relationalExpression83 = relationalExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relationalExpression83.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:293:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public SGLParser.relationalExpression_return relationalExpression() // throws RecognitionException [1]
    {   
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.Start = input.LT(1);
        int relationalExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal85 = null;
        IToken char_literal86 = null;
        IToken string_literal87 = null;
        IToken string_literal88 = null;
        SGLParser.additiveExpression_return additiveExpression84 = default(SGLParser.additiveExpression_return);

        SGLParser.additiveExpression_return additiveExpression89 = default(SGLParser.additiveExpression_return);


        object char_literal85_tree=null;
        object char_literal86_tree=null;
        object string_literal87_tree=null;
        object string_literal88_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 25) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:294:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:294:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1025);
            	additiveExpression84 = additiveExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression84.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:294:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:294:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:294:29: ( '<' | '>' | '<=' | '>=' )
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
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:294:30: '<'
            			    	        {
            			    	        	char_literal85=(IToken)Match(input,69,FOLLOW_69_in_relationalExpression1029); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal85_tree = (object)adaptor.Create(char_literal85);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal85_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:294:35: '>'
            			    	        {
            			    	        	char_literal86=(IToken)Match(input,70,FOLLOW_70_in_relationalExpression1032); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal86_tree = (object)adaptor.Create(char_literal86);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal86_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:294:40: '<='
            			    	        {
            			    	        	string_literal87=(IToken)Match(input,71,FOLLOW_71_in_relationalExpression1035); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal87_tree = (object)adaptor.Create(string_literal87);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal87_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 4 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:294:46: '>='
            			    	        {
            			    	        	string_literal88=(IToken)Match(input,72,FOLLOW_72_in_relationalExpression1038); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{string_literal88_tree = (object)adaptor.Create(string_literal88);
            			    	        		root_0 = (object)adaptor.BecomeRoot(string_literal88_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression1042);
            			    	additiveExpression89 = additiveExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, additiveExpression89.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:298:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public SGLParser.additiveExpression_return additiveExpression() // throws RecognitionException [1]
    {   
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.Start = input.LT(1);
        int additiveExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal91 = null;
        IToken char_literal92 = null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression90 = default(SGLParser.multiplicativeExpression_return);

        SGLParser.multiplicativeExpression_return multiplicativeExpression93 = default(SGLParser.multiplicativeExpression_return);


        object char_literal91_tree=null;
        object char_literal92_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 26) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:299:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:299:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1080);
            	multiplicativeExpression90 = multiplicativeExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression90.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:299:34: ( ( '+' | '-' ) multiplicativeExpression )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:299:35: ( '+' | '-' ) multiplicativeExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:299:35: ( '+' | '-' )
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
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:299:36: '+'
            			    	        {
            			    	        	char_literal91=(IToken)Match(input,73,FOLLOW_73_in_additiveExpression1084); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal91_tree = (object)adaptor.Create(char_literal91);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal91_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:299:41: '-'
            			    	        {
            			    	        	char_literal92=(IToken)Match(input,74,FOLLOW_74_in_additiveExpression1087); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal92_tree = (object)adaptor.Create(char_literal92);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal92_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1091);
            			    	multiplicativeExpression93 = multiplicativeExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, multiplicativeExpression93.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:303:1: multiplicativeExpression : powExpression ( ( '*' | '/' | '%' ) powExpression )* ;
    public SGLParser.multiplicativeExpression_return multiplicativeExpression() // throws RecognitionException [1]
    {   
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.Start = input.LT(1);
        int multiplicativeExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal95 = null;
        IToken char_literal96 = null;
        IToken char_literal97 = null;
        SGLParser.powExpression_return powExpression94 = default(SGLParser.powExpression_return);

        SGLParser.powExpression_return powExpression98 = default(SGLParser.powExpression_return);


        object char_literal95_tree=null;
        object char_literal96_tree=null;
        object char_literal97_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 27) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:304:5: ( powExpression ( ( '*' | '/' | '%' ) powExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:304:9: powExpression ( ( '*' | '/' | '%' ) powExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_powExpression_in_multiplicativeExpression1125);
            	powExpression94 = powExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, powExpression94.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:304:23: ( ( '*' | '/' | '%' ) powExpression )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:304:24: ( '*' | '/' | '%' ) powExpression
            			    {
            			    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:304:24: ( '*' | '/' | '%' )
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
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:304:25: '*'
            			    	        {
            			    	        	char_literal95=(IToken)Match(input,75,FOLLOW_75_in_multiplicativeExpression1129); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal95_tree = (object)adaptor.Create(char_literal95);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal95_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 2 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:304:30: '/'
            			    	        {
            			    	        	char_literal96=(IToken)Match(input,76,FOLLOW_76_in_multiplicativeExpression1132); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal96_tree = (object)adaptor.Create(char_literal96);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal96_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;
            			    	    case 3 :
            			    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:304:35: '%'
            			    	        {
            			    	        	char_literal97=(IToken)Match(input,77,FOLLOW_77_in_multiplicativeExpression1135); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{char_literal97_tree = (object)adaptor.Create(char_literal97);
            			    	        		root_0 = (object)adaptor.BecomeRoot(char_literal97_tree, root_0);
            			    	        	}

            			    	        }
            			    	        break;

            			    	}

            			    	PushFollow(FOLLOW_powExpression_in_multiplicativeExpression1139);
            			    	powExpression98 = powExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, powExpression98.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:307:1: powExpression : negateExpression ( '^' negateExpression )* ;
    public SGLParser.powExpression_return powExpression() // throws RecognitionException [1]
    {   
        SGLParser.powExpression_return retval = new SGLParser.powExpression_return();
        retval.Start = input.LT(1);
        int powExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal100 = null;
        SGLParser.negateExpression_return negateExpression99 = default(SGLParser.negateExpression_return);

        SGLParser.negateExpression_return negateExpression101 = default(SGLParser.negateExpression_return);


        object char_literal100_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 28) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:2: ( negateExpression ( '^' negateExpression )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:4: negateExpression ( '^' negateExpression )*
            {
            	root_0 = (object)adaptor.GetNilNode();

            	PushFollow(FOLLOW_negateExpression_in_powExpression1159);
            	negateExpression99 = negateExpression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negateExpression99.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:21: ( '^' negateExpression )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:308:22: '^' negateExpression
            			    {
            			    	char_literal100=(IToken)Match(input,78,FOLLOW_78_in_powExpression1162); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{char_literal100_tree = (object)adaptor.Create(char_literal100);
            			    		root_0 = (object)adaptor.BecomeRoot(char_literal100_tree, root_0);
            			    	}
            			    	PushFollow(FOLLOW_negateExpression_in_powExpression1165);
            			    	negateExpression101 = negateExpression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, negateExpression101.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:312:1: negateExpression : ( '-' mathAtom -> ^( INT_NEGATE mathAtom ) | '!' mathAtom -> ^( BOOL_NEGATE mathAtom ) | unaryExpression | mathAtom );
    public SGLParser.negateExpression_return negateExpression() // throws RecognitionException [1]
    {   
        SGLParser.negateExpression_return retval = new SGLParser.negateExpression_return();
        retval.Start = input.LT(1);
        int negateExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal102 = null;
        IToken char_literal104 = null;
        SGLParser.mathAtom_return mathAtom103 = default(SGLParser.mathAtom_return);

        SGLParser.mathAtom_return mathAtom105 = default(SGLParser.mathAtom_return);

        SGLParser.unaryExpression_return unaryExpression106 = default(SGLParser.unaryExpression_return);

        SGLParser.mathAtom_return mathAtom107 = default(SGLParser.mathAtom_return);


        object char_literal102_tree=null;
        object char_literal104_tree=null;
        RewriteRuleTokenStream stream_79 = new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_74 = new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleSubtreeStream stream_mathAtom = new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 29) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:313:2: ( '-' mathAtom -> ^( INT_NEGATE mathAtom ) | '!' mathAtom -> ^( BOOL_NEGATE mathAtom ) | unaryExpression | mathAtom )
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

                if ( (LA32_3 == EOF || LA32_3 == Identifier || LA32_3 == 50 || (LA32_3 >= 52 && LA32_3 <= 53) || (LA32_3 >= 56 && LA32_3 <= 60) || (LA32_3 >= 63 && LA32_3 <= 78) || (LA32_3 >= 83 && LA32_3 <= 84)) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:313:4: '-' mathAtom
                    {
                    	char_literal102=(IToken)Match(input,74,FOLLOW_74_in_negateExpression1183); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_74.Add(char_literal102);

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1185);
                    	mathAtom103 = mathAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_mathAtom.Add(mathAtom103.Tree);


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
                    	// 313:17: -> ^( INT_NEGATE mathAtom )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:313:20: ^( INT_NEGATE mathAtom )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:314:4: '!' mathAtom
                    {
                    	char_literal104=(IToken)Match(input,79,FOLLOW_79_in_negateExpression1198); if (state.failed) return retval; 
                    	if ( (state.backtracking==0) ) stream_79.Add(char_literal104);

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1200);
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
                    	// 314:17: -> ^( BOOL_NEGATE mathAtom )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:314:20: ^( BOOL_NEGATE mathAtom )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:315:4: unaryExpression
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_unaryExpression_in_negateExpression1213);
                    	unaryExpression106 = unaryExpression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, unaryExpression106.Tree);

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:316:4: mathAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_mathAtom_in_negateExpression1218);
                    	mathAtom107 = mathAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mathAtom107.Tree);

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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:320:1: unaryExpression : variable ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) ) ;
    public SGLParser.unaryExpression_return unaryExpression() // throws RecognitionException [1]
    {   
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.Start = input.LT(1);
        int unaryExpression_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal109 = null;
        IToken string_literal110 = null;
        SGLParser.variable_return variable108 = default(SGLParser.variable_return);


        object string_literal109_tree=null;
        object string_literal110_tree=null;
        RewriteRuleTokenStream stream_80 = new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_81 = new RewriteRuleTokenStream(adaptor,"token 81");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 30) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:321:5: ( variable ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:321:9: variable ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) )
            {
            	PushFollow(FOLLOW_variable_in_unaryExpression1236);
            	variable108 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable108.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:321:18: ( '++' -> ^( VARINC variable ) | '--' -> ^( VARDEC variable ) )
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:321:19: '++'
            	        {
            	        	string_literal109=(IToken)Match(input,80,FOLLOW_80_in_unaryExpression1239); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_80.Add(string_literal109);



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
            	        	// 321:24: -> ^( VARINC variable )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:321:27: ^( VARINC variable )
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:322:4: '--'
            	        {
            	        	string_literal110=(IToken)Match(input,81,FOLLOW_81_in_unaryExpression1252); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_81.Add(string_literal110);



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
            	        	// 322:9: -> ^( VARDEC variable )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:322:12: ^( VARDEC variable )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:327:1: mathAtom : ( '(' expression ')' | IntAtom | FloatAtom | BooleanAtom | stringAtom | LayerAtom | OriginAtom | LoopTypeAtom | ColorAtom | Null | lookup );
    public SGLParser.mathAtom_return mathAtom() // throws RecognitionException [1]
    {   
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.Start = input.LT(1);
        int mathAtom_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal111 = null;
        IToken char_literal113 = null;
        IToken IntAtom114 = null;
        IToken FloatAtom115 = null;
        IToken BooleanAtom116 = null;
        IToken LayerAtom118 = null;
        IToken OriginAtom119 = null;
        IToken LoopTypeAtom120 = null;
        IToken ColorAtom121 = null;
        IToken Null122 = null;
        SGLParser.expression_return expression112 = default(SGLParser.expression_return);

        SGLParser.stringAtom_return stringAtom117 = default(SGLParser.stringAtom_return);

        SGLParser.lookup_return lookup123 = default(SGLParser.lookup_return);


        object char_literal111_tree=null;
        object char_literal113_tree=null;
        object IntAtom114_tree=null;
        object FloatAtom115_tree=null;
        object BooleanAtom116_tree=null;
        object LayerAtom118_tree=null;
        object OriginAtom119_tree=null;
        object LoopTypeAtom120_tree=null;
        object ColorAtom121_tree=null;
        object Null122_tree=null;

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 31) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:328:2: ( '(' expression ')' | IntAtom | FloatAtom | BooleanAtom | stringAtom | LayerAtom | OriginAtom | LoopTypeAtom | ColorAtom | Null | lookup )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:328:4: '(' expression ')'
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	char_literal111=(IToken)Match(input,59,FOLLOW_59_in_mathAtom1286); if (state.failed) return retval;
                    	PushFollow(FOLLOW_expression_in_mathAtom1289);
                    	expression112 = expression();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expression112.Tree);
                    	char_literal113=(IToken)Match(input,60,FOLLOW_60_in_mathAtom1291); if (state.failed) return retval;

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:329:7: IntAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	IntAtom114=(IToken)Match(input,IntAtom,FOLLOW_IntAtom_in_mathAtom1303); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IntAtom114_tree = (object)adaptor.Create(IntAtom114);
                    		adaptor.AddChild(root_0, IntAtom114_tree);
                    	}

                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:330:7: FloatAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	FloatAtom115=(IToken)Match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1318); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FloatAtom115_tree = (object)adaptor.Create(FloatAtom115);
                    		adaptor.AddChild(root_0, FloatAtom115_tree);
                    	}

                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:331:9: BooleanAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	BooleanAtom116=(IToken)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1334); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BooleanAtom116_tree = (object)adaptor.Create(BooleanAtom116);
                    		adaptor.AddChild(root_0, BooleanAtom116_tree);
                    	}

                    }
                    break;
                case 5 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:332:4: stringAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_stringAtom_in_mathAtom1345);
                    	stringAtom117 = stringAtom();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, stringAtom117.Tree);

                    }
                    break;
                case 6 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:333:4: LayerAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LayerAtom118=(IToken)Match(input,LayerAtom,FOLLOW_LayerAtom_in_mathAtom1356); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LayerAtom118_tree = (object)adaptor.Create(LayerAtom118);
                    		adaptor.AddChild(root_0, LayerAtom118_tree);
                    	}

                    }
                    break;
                case 7 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:334:4: OriginAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	OriginAtom119=(IToken)Match(input,OriginAtom,FOLLOW_OriginAtom_in_mathAtom1367); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OriginAtom119_tree = (object)adaptor.Create(OriginAtom119);
                    		adaptor.AddChild(root_0, OriginAtom119_tree);
                    	}

                    }
                    break;
                case 8 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:335:4: LoopTypeAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	LoopTypeAtom120=(IToken)Match(input,LoopTypeAtom,FOLLOW_LoopTypeAtom_in_mathAtom1378); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LoopTypeAtom120_tree = (object)adaptor.Create(LoopTypeAtom120);
                    		adaptor.AddChild(root_0, LoopTypeAtom120_tree);
                    	}

                    }
                    break;
                case 9 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:336:4: ColorAtom
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	ColorAtom121=(IToken)Match(input,ColorAtom,FOLLOW_ColorAtom_in_mathAtom1391); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ColorAtom121_tree = (object)adaptor.Create(ColorAtom121);
                    		adaptor.AddChild(root_0, ColorAtom121_tree);
                    	}

                    }
                    break;
                case 10 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:337:4: Null
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	Null122=(IToken)Match(input,Null,FOLLOW_Null_in_mathAtom1402); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{Null122_tree = (object)adaptor.Create(Null122);
                    		adaptor.AddChild(root_0, Null122_tree);
                    	}

                    }
                    break;
                case 11 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:339:4: lookup
                    {
                    	root_0 = (object)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_lookup_in_mathAtom1416);
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:342:1: lookup : ( objectMethodCall ( indexes )? -> ^( LOOKUP objectMethodCall ( indexes )? ) | methodCall ( indexes )? -> ^( LOOKUP methodCall ( indexes )? ) | variable ( indexes )? -> ^( LOOKUP variable ( indexes )? ) );
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
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 32) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:343:2: ( objectMethodCall ( indexes )? -> ^( LOOKUP objectMethodCall ( indexes )? ) | methodCall ( indexes )? -> ^( LOOKUP methodCall ( indexes )? ) | variable ( indexes )? -> ^( LOOKUP variable ( indexes )? ) )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:343:4: objectMethodCall ( indexes )?
                    {
                    	PushFollow(FOLLOW_objectMethodCall_in_lookup1435);
                    	objectMethodCall124 = objectMethodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_objectMethodCall.Add(objectMethodCall124.Tree);
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:343:21: ( indexes )?
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
                    	        	PushFollow(FOLLOW_indexes_in_lookup1437);
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
                    	// 343:30: -> ^( LOOKUP objectMethodCall ( indexes )? )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:343:33: ^( LOOKUP objectMethodCall ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_objectMethodCall.NextTree());
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:343:59: ( indexes )?
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:4: methodCall ( indexes )?
                    {
                    	PushFollow(FOLLOW_methodCall_in_lookup1454);
                    	methodCall126 = methodCall();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_methodCall.Add(methodCall126.Tree);
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:15: ( indexes )?
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
                    	        	PushFollow(FOLLOW_indexes_in_lookup1456);
                    	        	indexes127 = indexes();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( (state.backtracking==0) ) stream_indexes.Add(indexes127.Tree);

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
                    	// 344:24: -> ^( LOOKUP methodCall ( indexes )? )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:27: ^( LOOKUP methodCall ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_methodCall.NextTree());
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:47: ( indexes )?
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:345:4: variable ( indexes )?
                    {
                    	PushFollow(FOLLOW_variable_in_lookup1474);
                    	variable128 = variable();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( (state.backtracking==0) ) stream_variable.Add(variable128.Tree);
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:345:13: ( indexes )?
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
                    	        	PushFollow(FOLLOW_indexes_in_lookup1476);
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
                    	// 345:22: -> ^( LOOKUP variable ( indexes )? )
                    	{
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:345:25: ^( LOOKUP variable ( indexes )? )
                    	    {
                    	    object root_1 = (object)adaptor.GetNilNode();
                    	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(LOOKUP, "LOOKUP"), root_1);

                    	    adaptor.AddChild(root_1, stream_variable.NextTree());
                    	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:345:43: ( indexes )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:352:1: instantiateClass : 'new' ( Sprite '(' ( expressionList )? ')' -> ^( Sprite ( expressionList )? ) | Animation '(' ( expressionList )? ')' -> ^( Animation ( expressionList )? ) | List '(' ( expressionList )? ')' -> ^( List ( expressionList )? ) ) ;
    public SGLParser.instantiateClass_return instantiateClass() // throws RecognitionException [1]
    {   
        SGLParser.instantiateClass_return retval = new SGLParser.instantiateClass_return();
        retval.Start = input.LT(1);
        int instantiateClass_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal130 = null;
        IToken Sprite131 = null;
        IToken char_literal132 = null;
        IToken char_literal134 = null;
        IToken Animation135 = null;
        IToken char_literal136 = null;
        IToken char_literal138 = null;
        IToken List139 = null;
        IToken char_literal140 = null;
        IToken char_literal142 = null;
        SGLParser.expressionList_return expressionList133 = default(SGLParser.expressionList_return);

        SGLParser.expressionList_return expressionList137 = default(SGLParser.expressionList_return);

        SGLParser.expressionList_return expressionList141 = default(SGLParser.expressionList_return);


        object string_literal130_tree=null;
        object Sprite131_tree=null;
        object char_literal132_tree=null;
        object char_literal134_tree=null;
        object Animation135_tree=null;
        object char_literal136_tree=null;
        object char_literal138_tree=null;
        object List139_tree=null;
        object char_literal140_tree=null;
        object char_literal142_tree=null;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:353:2: ( 'new' ( Sprite '(' ( expressionList )? ')' -> ^( Sprite ( expressionList )? ) | Animation '(' ( expressionList )? ')' -> ^( Animation ( expressionList )? ) | List '(' ( expressionList )? ')' -> ^( List ( expressionList )? ) ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:353:4: 'new' ( Sprite '(' ( expressionList )? ')' -> ^( Sprite ( expressionList )? ) | Animation '(' ( expressionList )? ')' -> ^( Animation ( expressionList )? ) | List '(' ( expressionList )? ')' -> ^( List ( expressionList )? ) )
            {
            	string_literal130=(IToken)Match(input,82,FOLLOW_82_in_instantiateClass1520); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_82.Add(string_literal130);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:354:2: ( Sprite '(' ( expressionList )? ')' -> ^( Sprite ( expressionList )? ) | Animation '(' ( expressionList )? ')' -> ^( Animation ( expressionList )? ) | List '(' ( expressionList )? ')' -> ^( List ( expressionList )? ) )
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:354:4: Sprite '(' ( expressionList )? ')'
            	        {
            	        	Sprite131=(IToken)Match(input,Sprite,FOLLOW_Sprite_in_instantiateClass1525); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_Sprite.Add(Sprite131);

            	        	char_literal132=(IToken)Match(input,59,FOLLOW_59_in_instantiateClass1527); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_59.Add(char_literal132);

            	        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:354:15: ( expressionList )?
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
            	        	        	PushFollow(FOLLOW_expressionList_in_instantiateClass1529);
            	        	        	expressionList133 = expressionList();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList133.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	char_literal134=(IToken)Match(input,60,FOLLOW_60_in_instantiateClass1532); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_60.Add(char_literal134);



            	        	// AST REWRITE
            	        	// elements:          expressionList, Sprite
            	        	// token labels:      
            	        	// rule labels:       retval
            	        	// token list labels: 
            	        	// rule list labels:  
            	        	// wildcard labels: 
            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = root_0;
            	        	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	        	root_0 = (object)adaptor.GetNilNode();
            	        	// 354:35: -> ^( Sprite ( expressionList )? )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:354:38: ^( Sprite ( expressionList )? )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot(stream_Sprite.NextNode(), root_1);

            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:354:47: ( expressionList )?
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:355:4: Animation '(' ( expressionList )? ')'
            	        {
            	        	Animation135=(IToken)Match(input,Animation,FOLLOW_Animation_in_instantiateClass1546); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_Animation.Add(Animation135);

            	        	char_literal136=(IToken)Match(input,59,FOLLOW_59_in_instantiateClass1548); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_59.Add(char_literal136);

            	        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:355:18: ( expressionList )?
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
            	        	        	PushFollow(FOLLOW_expressionList_in_instantiateClass1550);
            	        	        	expressionList137 = expressionList();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList137.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	char_literal138=(IToken)Match(input,60,FOLLOW_60_in_instantiateClass1553); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_60.Add(char_literal138);



            	        	// AST REWRITE
            	        	// elements:          Animation, expressionList
            	        	// token labels:      
            	        	// rule labels:       retval
            	        	// token list labels: 
            	        	// rule list labels:  
            	        	// wildcard labels: 
            	        	if ( (state.backtracking==0) ) {
            	        	retval.Tree = root_0;
            	        	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	        	root_0 = (object)adaptor.GetNilNode();
            	        	// 355:38: -> ^( Animation ( expressionList )? )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:355:41: ^( Animation ( expressionList )? )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot(stream_Animation.NextNode(), root_1);

            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:355:53: ( expressionList )?
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
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:356:4: List '(' ( expressionList )? ')'
            	        {
            	        	List139=(IToken)Match(input,List,FOLLOW_List_in_instantiateClass1567); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_List.Add(List139);

            	        	char_literal140=(IToken)Match(input,59,FOLLOW_59_in_instantiateClass1569); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_59.Add(char_literal140);

            	        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:356:13: ( expressionList )?
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
            	        	        	PushFollow(FOLLOW_expressionList_in_instantiateClass1571);
            	        	        	expressionList141 = expressionList();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList141.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	char_literal142=(IToken)Match(input,60,FOLLOW_60_in_instantiateClass1574); if (state.failed) return retval; 
            	        	if ( (state.backtracking==0) ) stream_60.Add(char_literal142);



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
            	        	// 356:33: -> ^( List ( expressionList )? )
            	        	{
            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:356:36: ^( List ( expressionList )? )
            	        	    {
            	        	    object root_1 = (object)adaptor.GetNilNode();
            	        	    root_1 = (object)adaptor.BecomeRoot(stream_List.NextNode(), root_1);

            	        	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:356:43: ( expressionList )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:368:1: expressionList : expression ( ',' expression )* -> ^( EXP_LIST ( expression )+ ) ;
    public SGLParser.expressionList_return expressionList() // throws RecognitionException [1]
    {   
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.Start = input.LT(1);
        int expressionList_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal144 = null;
        SGLParser.expression_return expression143 = default(SGLParser.expression_return);

        SGLParser.expression_return expression145 = default(SGLParser.expression_return);


        object char_literal144_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 34) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:369:3: ( expression ( ',' expression )* -> ^( EXP_LIST ( expression )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:369:7: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList1613);
            	expression143 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression143.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:369:18: ( ',' expression )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:369:19: ',' expression
            			    {
            			    	char_literal144=(IToken)Match(input,53,FOLLOW_53_in_expressionList1616); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_53.Add(char_literal144);

            			    	PushFollow(FOLLOW_expression_in_expressionList1618);
            			    	expression145 = expression();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_expression.Add(expression145.Tree);

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
            	// 369:36: -> ^( EXP_LIST ( expression )+ )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:369:39: ^( EXP_LIST ( expression )+ )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:373:1: variableList : variable ( ',' variable )* -> ^( VAR_LIST ( variable )+ ) ;
    public SGLParser.variableList_return variableList() // throws RecognitionException [1]
    {   
        SGLParser.variableList_return retval = new SGLParser.variableList_return();
        retval.Start = input.LT(1);
        int variableList_StartIndex = input.Index();
        object root_0 = null;

        IToken char_literal147 = null;
        SGLParser.variable_return variable146 = default(SGLParser.variable_return);

        SGLParser.variable_return variable148 = default(SGLParser.variable_return);


        object char_literal147_tree=null;
        RewriteRuleTokenStream stream_53 = new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleSubtreeStream stream_variable = new RewriteRuleSubtreeStream(adaptor,"rule variable");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 35) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:374:3: ( variable ( ',' variable )* -> ^( VAR_LIST ( variable )+ ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:374:5: variable ( ',' variable )*
            {
            	PushFollow(FOLLOW_variable_in_variableList1646);
            	variable146 = variable();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_variable.Add(variable146.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:374:14: ( ',' variable )*
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
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:374:15: ',' variable
            			    {
            			    	char_literal147=(IToken)Match(input,53,FOLLOW_53_in_variableList1649); if (state.failed) return retval; 
            			    	if ( (state.backtracking==0) ) stream_53.Add(char_literal147);

            			    	PushFollow(FOLLOW_variable_in_variableList1651);
            			    	variable148 = variable();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_variable.Add(variable148.Tree);

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
            	// 374:30: -> ^( VAR_LIST ( variable )+ )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:374:33: ^( VAR_LIST ( variable )+ )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:377:1: methodCall : Identifier '(' ( expressionList )? ')' -> ^( METH_CALL Identifier ( expressionList )? ) ;
    public SGLParser.methodCall_return methodCall() // throws RecognitionException [1]
    {   
        SGLParser.methodCall_return retval = new SGLParser.methodCall_return();
        retval.Start = input.LT(1);
        int methodCall_StartIndex = input.Index();
        object root_0 = null;

        IToken Identifier149 = null;
        IToken char_literal150 = null;
        IToken char_literal152 = null;
        SGLParser.expressionList_return expressionList151 = default(SGLParser.expressionList_return);


        object Identifier149_tree=null;
        object char_literal150_tree=null;
        object char_literal152_tree=null;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:378:2: ( Identifier '(' ( expressionList )? ')' -> ^( METH_CALL Identifier ( expressionList )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:378:4: Identifier '(' ( expressionList )? ')'
            {
            	Identifier149=(IToken)Match(input,Identifier,FOLLOW_Identifier_in_methodCall1674); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_Identifier.Add(Identifier149);

            	char_literal150=(IToken)Match(input,59,FOLLOW_59_in_methodCall1676); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(char_literal150);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:378:19: ( expressionList )?
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
            	        	PushFollow(FOLLOW_expressionList_in_methodCall1678);
            	        	expressionList151 = expressionList();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expressionList.Add(expressionList151.Tree);

            	        }
            	        break;

            	}

            	char_literal152=(IToken)Match(input,60,FOLLOW_60_in_methodCall1681); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_60.Add(char_literal152);



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
            	// 378:39: -> ^( METH_CALL Identifier ( expressionList )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:378:42: ^( METH_CALL Identifier ( expressionList )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(METH_CALL, "METH_CALL"), root_1);

            	    adaptor.AddChild(root_1, stream_Identifier.NextNode());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:378:65: ( expressionList )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:383:1: breakStat : 'break' -> BREAK ;
    public SGLParser.breakStat_return breakStat() // throws RecognitionException [1]
    {   
        SGLParser.breakStat_return retval = new SGLParser.breakStat_return();
        retval.Start = input.LT(1);
        int breakStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal153 = null;

        object string_literal153_tree=null;
        RewriteRuleTokenStream stream_83 = new RewriteRuleTokenStream(adaptor,"token 83");

        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 37) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:384:2: ( 'break' -> BREAK )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:384:4: 'break'
            {
            	string_literal153=(IToken)Match(input,83,FOLLOW_83_in_breakStat1708); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_83.Add(string_literal153);



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
            	// 384:12: -> BREAK
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:387:1: returnStat : 'return' expression -> ^( RETURN expression ) ;
    public SGLParser.returnStat_return returnStat() // throws RecognitionException [1]
    {   
        SGLParser.returnStat_return retval = new SGLParser.returnStat_return();
        retval.Start = input.LT(1);
        int returnStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal154 = null;
        SGLParser.expression_return expression155 = default(SGLParser.expression_return);


        object string_literal154_tree=null;
        RewriteRuleTokenStream stream_84 = new RewriteRuleTokenStream(adaptor,"token 84");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 38) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:388:2: ( 'return' expression -> ^( RETURN expression ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:388:4: 'return' expression
            {
            	string_literal154=(IToken)Match(input,84,FOLLOW_84_in_returnStat1723); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_84.Add(string_literal154);

            	PushFollow(FOLLOW_expression_in_returnStat1725);
            	expression155 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression155.Tree);


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
            	// 388:24: -> ^( RETURN expression )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:388:27: ^( RETURN expression )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:392:1: whileLoop : 'while' expression commonBlock -> ^( 'while' expression commonBlock ) ;
    public SGLParser.whileLoop_return whileLoop() // throws RecognitionException [1]
    {   
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.Start = input.LT(1);
        int whileLoop_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal156 = null;
        SGLParser.expression_return expression157 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock158 = default(SGLParser.commonBlock_return);


        object string_literal156_tree=null;
        RewriteRuleTokenStream stream_85 = new RewriteRuleTokenStream(adaptor,"token 85");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 39) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:393:2: ( 'while' expression commonBlock -> ^( 'while' expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:393:4: 'while' expression commonBlock
            {
            	string_literal156=(IToken)Match(input,85,FOLLOW_85_in_whileLoop1748); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_85.Add(string_literal156);

            	PushFollow(FOLLOW_expression_in_whileLoop1750);
            	expression157 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression157.Tree);
            	PushFollow(FOLLOW_commonBlock_in_whileLoop1752);
            	commonBlock158 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock158.Tree);


            	// AST REWRITE
            	// elements:          commonBlock, 85, expression
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 393:35: -> ^( 'while' expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:393:38: ^( 'while' expression commonBlock )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:396:1: forLoop : 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) ;
    public SGLParser.forLoop_return forLoop() // throws RecognitionException [1]
    {   
        SGLParser.forLoop_return retval = new SGLParser.forLoop_return();
        retval.Start = input.LT(1);
        int forLoop_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal159 = null;
        IToken char_literal160 = null;
        IToken char_literal161 = null;
        IToken char_literal162 = null;
        IToken char_literal163 = null;
        SGLParser.oneLineStatement_return dec = default(SGLParser.oneLineStatement_return);

        SGLParser.expression_return cond = default(SGLParser.expression_return);

        SGLParser.oneLineStatement_return iter = default(SGLParser.oneLineStatement_return);

        SGLParser.commonBlock_return commonBlock164 = default(SGLParser.commonBlock_return);


        object string_literal159_tree=null;
        object char_literal160_tree=null;
        object char_literal161_tree=null;
        object char_literal162_tree=null;
        object char_literal163_tree=null;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:397:2: ( 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:397:4: 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock
            {
            	string_literal159=(IToken)Match(input,86,FOLLOW_86_in_forLoop1774); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_86.Add(string_literal159);

            	char_literal160=(IToken)Match(input,59,FOLLOW_59_in_forLoop1776); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_59.Add(char_literal160);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:397:17: (dec= oneLineStatement )?
            	int alt46 = 2;
            	int LA46_0 = input.LA(1);

            	if ( (LA46_0 == Identifier) )
            	{
            	    alt46 = 1;
            	}
            	switch (alt46) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: dec= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop1780);
            	        	dec = oneLineStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_oneLineStatement.Add(dec.Tree);

            	        }
            	        break;

            	}

            	char_literal161=(IToken)Match(input,52,FOLLOW_52_in_forLoop1783); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal161);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:397:44: (cond= expression )?
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
            	        	PushFollow(FOLLOW_expression_in_forLoop1787);
            	        	cond = expression();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_expression.Add(cond.Tree);

            	        }
            	        break;

            	}

            	char_literal162=(IToken)Match(input,52,FOLLOW_52_in_forLoop1790); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_52.Add(char_literal162);

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:397:65: (iter= oneLineStatement )?
            	int alt48 = 2;
            	int LA48_0 = input.LA(1);

            	if ( (LA48_0 == Identifier) )
            	{
            	    alt48 = 1;
            	}
            	switch (alt48) 
            	{
            	    case 1 :
            	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:0:0: iter= oneLineStatement
            	        {
            	        	PushFollow(FOLLOW_oneLineStatement_in_forLoop1794);
            	        	iter = oneLineStatement();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_oneLineStatement.Add(iter.Tree);

            	        }
            	        break;

            	}

            	char_literal163=(IToken)Match(input,60,FOLLOW_60_in_forLoop1797); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_60.Add(char_literal163);

            	PushFollow(FOLLOW_commonBlock_in_forLoop1799);
            	commonBlock164 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock164.Tree);


            	// AST REWRITE
            	// elements:          commonBlock, iter, 86, cond, dec
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
            	// 398:2: -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:5: ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot(stream_86.NextNode(), root_1);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:13: ^( FORDEC ( $dec)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORDEC, "FORDEC"), root_2);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:22: ( $dec)?
            	    if ( stream_dec.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_dec.NextTree());

            	    }
            	    stream_dec.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:29: ^( FORCOND ( $cond)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORCOND, "FORCOND"), root_2);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:39: ( $cond)?
            	    if ( stream_cond.HasNext() )
            	    {
            	        adaptor.AddChild(root_2, stream_cond.NextTree());

            	    }
            	    stream_cond.Reset();

            	    adaptor.AddChild(root_1, root_2);
            	    }
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:47: ^( FORITER ( $iter)? )
            	    {
            	    object root_2 = (object)adaptor.GetNilNode();
            	    root_2 = (object)adaptor.BecomeRoot((object)adaptor.Create(FORITER, "FORITER"), root_2);

            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:398:57: ( $iter)?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:401:1: ifStatement : ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) ;
    public SGLParser.ifStatement_return ifStatement() // throws RecognitionException [1]
    {   
        SGLParser.ifStatement_return retval = new SGLParser.ifStatement_return();
        retval.Start = input.LT(1);
        int ifStatement_StartIndex = input.Index();
        object root_0 = null;

        SGLParser.ifStat_return ifStat165 = default(SGLParser.ifStat_return);

        SGLParser.elseIfStat_return elseIfStat166 = default(SGLParser.elseIfStat_return);

        SGLParser.elseStat_return elseStat167 = default(SGLParser.elseStat_return);


        RewriteRuleSubtreeStream stream_elseIfStat = new RewriteRuleSubtreeStream(adaptor,"rule elseIfStat");
        RewriteRuleSubtreeStream stream_ifStat = new RewriteRuleSubtreeStream(adaptor,"rule ifStat");
        RewriteRuleSubtreeStream stream_elseStat = new RewriteRuleSubtreeStream(adaptor,"rule elseStat");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 41) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:2: ( ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:4: ifStat ( elseIfStat )* ( elseStat )?
            {
            	PushFollow(FOLLOW_ifStat_in_ifStatement1844);
            	ifStat165 = ifStat();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_ifStat.Add(ifStat165.Tree);
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:11: ( elseIfStat )*
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
            			    	PushFollow(FOLLOW_elseIfStat_in_ifStatement1846);
            			    	elseIfStat166 = elseIfStat();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( (state.backtracking==0) ) stream_elseIfStat.Add(elseIfStat166.Tree);

            			    }
            			    break;

            			default:
            			    goto loop49;
            	    }
            	} while (true);

            	loop49:
            		;	// Stops C# compiler whining that label 'loop49' has no statements

            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:23: ( elseStat )?
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
            	        	PushFollow(FOLLOW_elseStat_in_ifStatement1849);
            	        	elseStat167 = elseStat();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( (state.backtracking==0) ) stream_elseStat.Add(elseStat167.Tree);

            	        }
            	        break;

            	}



            	// AST REWRITE
            	// elements:          elseIfStat, ifStat, elseStat
            	// token labels:      
            	// rule labels:       retval
            	// token list labels: 
            	// rule list labels:  
            	// wildcard labels: 
            	if ( (state.backtracking==0) ) {
            	retval.Tree = root_0;
            	RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval", retval!=null ? retval.Tree : null);

            	root_0 = (object)adaptor.GetNilNode();
            	// 402:33: -> ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:36: ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            	    {
            	    object root_1 = (object)adaptor.GetNilNode();
            	    root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(IF, "IF"), root_1);

            	    adaptor.AddChild(root_1, stream_ifStat.NextTree());
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:48: ( elseIfStat )*
            	    while ( stream_elseIfStat.HasNext() )
            	    {
            	        adaptor.AddChild(root_1, stream_elseIfStat.NextTree());

            	    }
            	    stream_elseIfStat.Reset();
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:402:60: ( elseStat )?
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:404:1: ifStat : 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.ifStat_return ifStat() // throws RecognitionException [1]
    {   
        SGLParser.ifStat_return retval = new SGLParser.ifStat_return();
        retval.Start = input.LT(1);
        int ifStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal168 = null;
        SGLParser.expression_return expression169 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock170 = default(SGLParser.commonBlock_return);


        object string_literal168_tree=null;
        RewriteRuleTokenStream stream_87 = new RewriteRuleTokenStream(adaptor,"token 87");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 42) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:405:2: ( 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:405:4: 'if' expression commonBlock
            {
            	string_literal168=(IToken)Match(input,87,FOLLOW_87_in_ifStat1874); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_87.Add(string_literal168);

            	PushFollow(FOLLOW_expression_in_ifStat1876);
            	expression169 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression169.Tree);
            	PushFollow(FOLLOW_commonBlock_in_ifStat1878);
            	commonBlock170 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock170.Tree);


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
            	// 405:32: -> ^( EXP expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:405:35: ^( EXP expression commonBlock )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:408:1: elseIfStat : 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public SGLParser.elseIfStat_return elseIfStat() // throws RecognitionException [1]
    {   
        SGLParser.elseIfStat_return retval = new SGLParser.elseIfStat_return();
        retval.Start = input.LT(1);
        int elseIfStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal171 = null;
        IToken string_literal172 = null;
        SGLParser.expression_return expression173 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock174 = default(SGLParser.commonBlock_return);


        object string_literal171_tree=null;
        object string_literal172_tree=null;
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:409:2: ( 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:409:4: 'else' 'if' expression commonBlock
            {
            	string_literal171=(IToken)Match(input,88,FOLLOW_88_in_elseIfStat1899); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_88.Add(string_literal171);

            	string_literal172=(IToken)Match(input,87,FOLLOW_87_in_elseIfStat1901); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_87.Add(string_literal172);

            	PushFollow(FOLLOW_expression_in_elseIfStat1903);
            	expression173 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression173.Tree);
            	PushFollow(FOLLOW_commonBlock_in_elseIfStat1905);
            	commonBlock174 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock174.Tree);


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
            	// 409:39: -> ^( EXP expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:409:42: ^( EXP expression commonBlock )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:412:1: elseStat : 'else' commonBlock -> ^( EXP commonBlock ) ;
    public SGLParser.elseStat_return elseStat() // throws RecognitionException [1]
    {   
        SGLParser.elseStat_return retval = new SGLParser.elseStat_return();
        retval.Start = input.LT(1);
        int elseStat_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal175 = null;
        SGLParser.commonBlock_return commonBlock176 = default(SGLParser.commonBlock_return);


        object string_literal175_tree=null;
        RewriteRuleTokenStream stream_88 = new RewriteRuleTokenStream(adaptor,"token 88");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 44) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:413:2: ( 'else' commonBlock -> ^( EXP commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:413:4: 'else' commonBlock
            {
            	string_literal175=(IToken)Match(input,88,FOLLOW_88_in_elseStat1927); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_88.Add(string_literal175);

            	PushFollow(FOLLOW_commonBlock_in_elseStat1929);
            	commonBlock176 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock176.Tree);


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
            	// 413:23: -> ^( EXP commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:413:26: ^( EXP commonBlock )
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
    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:420:1: atStatement : 'at' expression commonBlock -> ^( AT expression commonBlock ) ;
    public SGLParser.atStatement_return atStatement() // throws RecognitionException [1]
    {   
        SGLParser.atStatement_return retval = new SGLParser.atStatement_return();
        retval.Start = input.LT(1);
        int atStatement_StartIndex = input.Index();
        object root_0 = null;

        IToken string_literal177 = null;
        SGLParser.expression_return expression178 = default(SGLParser.expression_return);

        SGLParser.commonBlock_return commonBlock179 = default(SGLParser.commonBlock_return);


        object string_literal177_tree=null;
        RewriteRuleTokenStream stream_89 = new RewriteRuleTokenStream(adaptor,"token 89");
        RewriteRuleSubtreeStream stream_expression = new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock = new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try 
    	{
    	    if ( (state.backtracking > 0) && AlreadyParsedRule(input, 45) ) 
    	    {
    	    	return retval; 
    	    }
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:421:2: ( 'at' expression commonBlock -> ^( AT expression commonBlock ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:421:4: 'at' expression commonBlock
            {
            	string_literal177=(IToken)Match(input,89,FOLLOW_89_in_atStatement1954); if (state.failed) return retval; 
            	if ( (state.backtracking==0) ) stream_89.Add(string_literal177);

            	PushFollow(FOLLOW_expression_in_atStatement1956);
            	expression178 = expression();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_expression.Add(expression178.Tree);
            	PushFollow(FOLLOW_commonBlock_in_atStatement1958);
            	commonBlock179 = commonBlock();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( (state.backtracking==0) ) stream_commonBlock.Add(commonBlock179.Tree);


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
            	// 421:32: -> ^( AT expression commonBlock )
            	{
            	    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:421:35: ^( AT expression commonBlock )
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

    // $ANTLR start "synpred11_SGL"
    public void synpred11_SGL_fragment() {
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:193:5: ( objectMethodCall )
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:193:5: objectMethodCall
        {
        	PushFollow(FOLLOW_objectMethodCall_in_synpred11_SGL430);
        	objectMethodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred11_SGL"

    // $ANTLR start "synpred12_SGL"
    public void synpred12_SGL_fragment() {
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:194:4: ( methodCall )
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:194:4: methodCall
        {
        	PushFollow(FOLLOW_methodCall_in_synpred12_SGL435);
        	methodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred12_SGL"

    // $ANTLR start "synpred13_SGL"
    public void synpred13_SGL_fragment() {
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:195:4: ( assignmentList )
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:195:4: assignmentList
        {
        	PushFollow(FOLLOW_assignmentList_in_synpred13_SGL441);
        	assignmentList();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred13_SGL"

    // $ANTLR start "synpred14_SGL"
    public void synpred14_SGL_fragment() {
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:196:4: ( unaryExpression )
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:196:4: unaryExpression
        {
        	PushFollow(FOLLOW_unaryExpression_in_synpred14_SGL447);
        	unaryExpression();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred14_SGL"

    // $ANTLR start "synpred59_SGL"
    public void synpred59_SGL_fragment() {
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:343:4: ( objectMethodCall ( indexes )? )
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:343:4: objectMethodCall ( indexes )?
        {
        	PushFollow(FOLLOW_objectMethodCall_in_synpred59_SGL1435);
        	objectMethodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:343:21: ( indexes )?
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
        	        	PushFollow(FOLLOW_indexes_in_synpred59_SGL1437);
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
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:4: ( methodCall ( indexes )? )
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:4: methodCall ( indexes )?
        {
        	PushFollow(FOLLOW_methodCall_in_synpred61_SGL1454);
        	methodCall();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:344:15: ( indexes )?
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
        	        	PushFollow(FOLLOW_indexes_in_synpred61_SGL1456);
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
   	public bool synpred13_SGL() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred13_SGL_fragment(); // can never throw exception
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
    public static readonly BitSet FOLLOW_mainStatement_in_mainBlock252 = new BitSet(new ulong[]{0x6040000020000002UL,0x0000000002F80000UL});
    public static readonly BitSet FOLLOW_methodDef_in_mainBlock256 = new BitSet(new ulong[]{0x6040000020000002UL,0x0000000002F80000UL});
    public static readonly BitSet FOLLOW_objectMethodDef_in_mainBlock260 = new BitSet(new ulong[]{0x6040000020000002UL,0x0000000002F80000UL});
    public static readonly BitSet FOLLOW_statement_in_block300 = new BitSet(new ulong[]{0x0000000020000002UL,0x0000000002F80000UL});
    public static readonly BitSet FOLLOW_semicolonStatement_in_singleBlock325 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_singleBlock_in_commonBlock348 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_commonBlock353 = new BitSet(new ulong[]{0x0008000020000000UL,0x0000000002F80000UL});
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
    public static readonly BitSet FOLLOW_assignment_in_assignmentList496 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_assignmentList499 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_assignment_in_assignmentList502 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_54_in_globalAssignmentList518 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_globalAssignment_in_globalAssignmentList521 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_globalAssignmentList524 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_globalAssignment_in_globalAssignmentList527 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_globalAssignment541 = new BitSet(new ulong[]{0x0180000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_globalAssignment543 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_55_in_globalAssignment547 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_globalAssignment549 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_assignment580 = new BitSet(new ulong[]{0x0180000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_assignment582 = new BitSet(new ulong[]{0x0080000000000002UL});
    public static readonly BitSet FOLLOW_55_in_assignment586 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_assignment588 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_indexes623 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_indexes625 = new BitSet(new ulong[]{0x0200000000000000UL});
    public static readonly BitSet FOLLOW_57_in_indexes627 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_objectMethodCall654 = new BitSet(new ulong[]{0x0500000000000000UL});
    public static readonly BitSet FOLLOW_indexes_in_objectMethodCall656 = new BitSet(new ulong[]{0x0400000000000000UL});
    public static readonly BitSet FOLLOW_58_in_objectMethodCall659 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethodCall661 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_objectMethodCall663 = new BitSet(new ulong[]{0x1800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expressionList_in_objectMethodCall665 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_objectMethodCall668 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_variable702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringAtom_in_stringAtom725 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_61_in_methodDef746 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodDef748 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_methodDef750 = new BitSet(new ulong[]{0x1000000020000000UL});
    public static readonly BitSet FOLLOW_variableList_in_methodDef752 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_methodDef755 = new BitSet(new ulong[]{0x0004000020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_methodDef757 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_62_in_objectMethodDef775 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_Identifier_in_objectMethodDef777 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_objectMethodDef779 = new BitSet(new ulong[]{0x1000000020000000UL});
    public static readonly BitSet FOLLOW_variableList_in_objectMethodDef781 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_objectMethodDef784 = new BitSet(new ulong[]{0x0004000020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_objectMethodDef786 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_instantiateClass_in_expression817 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_expression827 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression853 = new BitSet(new ulong[]{0x8000000000000002UL});
    public static readonly BitSet FOLLOW_63_in_conditionalExpression857 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression860 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_64_in_conditionalExpression862 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression865 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression908 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_65_in_conditionalOrExpression912 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression915 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression946 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_66_in_conditionalAndExpression950 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression953 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression980 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000018UL});
    public static readonly BitSet FOLLOW_67_in_equalityExpression985 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_68_in_equalityExpression990 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression994 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000018UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1025 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000001E0UL});
    public static readonly BitSet FOLLOW_69_in_relationalExpression1029 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_70_in_relationalExpression1032 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_71_in_relationalExpression1035 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_72_in_relationalExpression1038 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression1042 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000001E0UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1080 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000600UL});
    public static readonly BitSet FOLLOW_73_in_additiveExpression1084 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_74_in_additiveExpression1087 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1091 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000600UL});
    public static readonly BitSet FOLLOW_powExpression_in_multiplicativeExpression1125 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000003800UL});
    public static readonly BitSet FOLLOW_75_in_multiplicativeExpression1129 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_76_in_multiplicativeExpression1132 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_77_in_multiplicativeExpression1135 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_powExpression_in_multiplicativeExpression1139 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000003800UL});
    public static readonly BitSet FOLLOW_negateExpression_in_powExpression1159 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_78_in_powExpression1162 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_negateExpression_in_powExpression1165 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000004000UL});
    public static readonly BitSet FOLLOW_74_in_negateExpression1183 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_79_in_negateExpression1198 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1200 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_negateExpression1213 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_negateExpression1218 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_unaryExpression1236 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000030000UL});
    public static readonly BitSet FOLLOW_80_in_unaryExpression1239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_81_in_unaryExpression1252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_59_in_mathAtom1286 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_mathAtom1289 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_mathAtom1291 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntAtom_in_mathAtom1303 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_mathAtom1318 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_mathAtom1334 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_stringAtom_in_mathAtom1345 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LayerAtom_in_mathAtom1356 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OriginAtom_in_mathAtom1367 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LoopTypeAtom_in_mathAtom1378 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ColorAtom_in_mathAtom1391 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Null_in_mathAtom1402 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_lookup_in_mathAtom1416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_lookup1435 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1437 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_lookup1454 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1456 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_lookup1474 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_lookup1476 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_82_in_instantiateClass1520 = new BitSet(new ulong[]{0x0000038000000000UL});
    public static readonly BitSet FOLLOW_Sprite_in_instantiateClass1525 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_instantiateClass1527 = new BitSet(new ulong[]{0x1800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1529 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_instantiateClass1532 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_Animation_in_instantiateClass1546 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_instantiateClass1548 = new BitSet(new ulong[]{0x1800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1550 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_instantiateClass1553 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_List_in_instantiateClass1567 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_instantiateClass1569 = new BitSet(new ulong[]{0x1800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expressionList_in_instantiateClass1571 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_instantiateClass1574 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1613 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_expressionList1616 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1618 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_variable_in_variableList1646 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_53_in_variableList1649 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_variable_in_variableList1651 = new BitSet(new ulong[]{0x0020000000000002UL});
    public static readonly BitSet FOLLOW_Identifier_in_methodCall1674 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_methodCall1676 = new BitSet(new ulong[]{0x1800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expressionList_in_methodCall1678 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_methodCall1681 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_83_in_breakStat1708 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_84_in_returnStat1723 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_returnStat1725 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_85_in_whileLoop1748 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_whileLoop1750 = new BitSet(new ulong[]{0x0004000020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_whileLoop1752 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_86_in_forLoop1774 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_59_in_forLoop1776 = new BitSet(new ulong[]{0x0010000020000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop1780 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_forLoop1783 = new BitSet(new ulong[]{0x0810007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_forLoop1787 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_52_in_forLoop1790 = new BitSet(new ulong[]{0x1000000020000000UL});
    public static readonly BitSet FOLLOW_oneLineStatement_in_forLoop1794 = new BitSet(new ulong[]{0x1000000000000000UL});
    public static readonly BitSet FOLLOW_60_in_forLoop1797 = new BitSet(new ulong[]{0x0004000020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_forLoop1799 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ifStat_in_ifStatement1844 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_elseIfStat_in_ifStatement1846 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_elseStat_in_ifStatement1849 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_87_in_ifStat1874 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_ifStat1876 = new BitSet(new ulong[]{0x0004000020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_ifStat1878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_88_in_elseIfStat1899 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000800000UL});
    public static readonly BitSet FOLLOW_87_in_elseIfStat1901 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_elseIfStat1903 = new BitSet(new ulong[]{0x0004000020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseIfStat1905 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_88_in_elseStat1927 = new BitSet(new ulong[]{0x0004000020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_elseStat1929 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_89_in_atStatement1954 = new BitSet(new ulong[]{0x0800007FE0000000UL,0x0000000000048400UL});
    public static readonly BitSet FOLLOW_expression_in_atStatement1956 = new BitSet(new ulong[]{0x0004000020000000UL,0x0000000000180000UL});
    public static readonly BitSet FOLLOW_commonBlock_in_atStatement1958 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_synpred11_SGL430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_synpred12_SGL435 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_assignmentList_in_synpred13_SGL441 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_synpred14_SGL447 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectMethodCall_in_synpred59_SGL1435 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_synpred59_SGL1437 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_methodCall_in_synpred61_SGL1454 = new BitSet(new ulong[]{0x0100000000000002UL});
    public static readonly BitSet FOLLOW_indexes_in_synpred61_SGL1456 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}