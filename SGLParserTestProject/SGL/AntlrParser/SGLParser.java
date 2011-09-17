// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g 2011-09-14 19:27:42

	//using SGLParserTester;
	//using System.Collections.Generic;
	//using SGL;


import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;

import org.antlr.runtime.tree.*;

public class SGLParser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BLOCK", "STATEMENTS", "IF", "EXP", "ID_LIST", "VARDEF", "ASSIGN", "NEGATE", "OBJMETHOD", "STRING", "FORDEC", "FORCOND", "FORITER", "STRINGNOQUOTES", "VARINC", "VARDEC", "BREAK", "PARAM_TYPE_LIST", "PARAM_NAME_LIST", "METH_CALL", "RETURN", "Identifier", "IntType", "BooleanType", "StringType", "FloatType", "ObjectType", "IntegerAtom", "FloatAtom", "BooleanAtom", "Sprite", "Animation", "Layer", "Origin", "StringAtom", "EscapeSequence", "Letter", "SGLIDDigit", "UnicodeEscape", "OctalEscape", "HEX_DIGIT", "WS", "COMMENT", "'{'", "'}'", "'method'", "'('", "')'", "'void'", "';'", "','", "'='", "'.'", "'while'", "'for'", "'if'", "'else'", "'break'", "'return'", "'?'", "':'", "'||'", "'&&'", "'=='", "'!='", "'<'", "'>'", "'<='", "'>='", "'+'", "'-'", "'*'", "'/'", "'%'", "'++'", "'--'", "'new'", "'null'"
    };
    public static final int T__68=68;
    public static final int T__69=69;
    public static final int T__66=66;
    public static final int T__67=67;
    public static final int T__64=64;
    public static final int T__65=65;
    public static final int OBJMETHOD=12;
    public static final int T__62=62;
    public static final int T__63=63;
    public static final int Origin=37;
    public static final int SGLIDDigit=41;
    public static final int Sprite=34;
    public static final int PARAM_NAME_LIST=22;
    public static final int IntType=26;
    public static final int T__61=61;
    public static final int ID_LIST=8;
    public static final int T__60=60;
    public static final int EOF=-1;
    public static final int BREAK=20;
    public static final int Identifier=25;
    public static final int IF=6;
    public static final int T__55=55;
    public static final int T__56=56;
    public static final int T__57=57;
    public static final int T__58=58;
    public static final int T__51=51;
    public static final int Animation=35;
    public static final int T__52=52;
    public static final int T__53=53;
    public static final int T__54=54;
    public static final int EXP=7;
    public static final int FORITER=16;
    public static final int StringType=28;
    public static final int T__59=59;
    public static final int RETURN=24;
    public static final int COMMENT=46;
    public static final int STRINGNOQUOTES=17;
    public static final int VARDEF=9;
    public static final int T__50=50;
    public static final int BooleanType=27;
    public static final int VARDEC=19;
    public static final int T__80=80;
    public static final int T__47=47;
    public static final int T__81=81;
    public static final int T__48=48;
    public static final int T__49=49;
    public static final int IntegerAtom=31;
    public static final int FloatType=29;
    public static final int FORDEC=14;
    public static final int StringAtom=38;
    public static final int PARAM_TYPE_LIST=21;
    public static final int METH_CALL=23;
    public static final int HEX_DIGIT=44;
    public static final int NEGATE=11;
    public static final int BooleanAtom=33;
    public static final int WS=45;
    public static final int FORCOND=15;
    public static final int T__71=71;
    public static final int T__72=72;
    public static final int T__70=70;
    public static final int UnicodeEscape=42;
    public static final int BLOCK=4;
    public static final int ASSIGN=10;
    public static final int Layer=36;
    public static final int STATEMENTS=5;
    public static final int ObjectType=30;
    public static final int FloatAtom=32;
    public static final int T__76=76;
    public static final int T__75=75;
    public static final int VARINC=18;
    public static final int T__74=74;
    public static final int OctalEscape=43;
    public static final int Letter=40;
    public static final int EscapeSequence=39;
    public static final int T__73=73;
    public static final int T__79=79;
    public static final int STRING=13;
    public static final int T__78=78;
    public static final int T__77=77;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "returnStat", "methodType", "mainStatement", "castExpression", 
        "conditionalAndExpression", "variableAssignment", "relationalExpression", 
        "mainBlock", "methodDef", "elseStat", "paramList", "variableType", 
        "conditionalExpression", "elseIfStat", "statement", "block", "negativeExpression", 
        "multiplicativeExpression", "variableDeclarationList", "oneLineStatement", 
        "forLoop", "equalityExpression", "semicolonStatement", "variableName", 
        "methodCall", "compilationUnit", "variableDecAssignment", "expressionList", 
        "singleBlock", "unaryExpression", "conditionalOrExpression", "expression", 
        "variableUnaryChange", "breakStat", "unaryExpressionNotPlusMinus", 
        "commonBlock", "mathAtom", "additiveExpression", "whileLoop", "stringQuote", 
        "literal", "ifStat", "arguments", "objectMethod", "ifStatement"
    };
     
        public int ruleLevel = 0;
        public int getRuleLevel() { return ruleLevel; }
        public void incRuleLevel() { ruleLevel++; }
        public void decRuleLevel() { ruleLevel--; }
        public SGLParser(TokenStream input) {
            this(input, DebugEventSocketProxy.DEFAULT_DEBUGGER_PORT, new RecognizerSharedState());
        }
        public SGLParser(TokenStream input, int port, RecognizerSharedState state) {
            super(input, state);
            DebugEventSocketProxy proxy =
                new DebugEventSocketProxy(this,port,adaptor);
            setDebugListener(proxy);
            setTokenStream(new DebugTokenStream(input,proxy));
            try {
                proxy.handshake();
            }
            catch (IOException ioe) {
                reportError(ioe);
            }
            TreeAdaptor adap = new CommonTreeAdaptor();
            setTreeAdaptor(adap);
            proxy.setTreeAdaptor(adap);
        }
    public SGLParser(TokenStream input, DebugEventListener dbg) {
        super(input, dbg);

         
        TreeAdaptor adap = new CommonTreeAdaptor();
        setTreeAdaptor(adap);

    }
    protected boolean evalPredicate(boolean result, String predicate) {
        dbg.semanticPredicate(result, predicate);
        return result;
    }

    protected DebugTreeAdaptor adaptor;
    public void setTreeAdaptor(TreeAdaptor adaptor) {
        this.adaptor = new DebugTreeAdaptor(dbg,adaptor);

    }
    public TreeAdaptor getTreeAdaptor() {
        return adaptor;
    }


    public String[] getTokenNames() { return SGLParser.tokenNames; }
    public String getGrammarFileName() { return "C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g"; }


    /*
            public Dictionary<String,Method> methods = new Dictionary<String,Method>();

        	private void DefineMethod(String id, Object type, Object idList, Object block) {
                    // 'idList' is possibly null!  Create an empty tree in that case.  
                    CommonTree idListTree = idList == null ? new CommonTree() : (CommonTree)idList;

                    // 'type' is never null
                    String typeString = ((CommonTree)type).ToString();
                    Console.WriteLine("method found! Name: " + id + " returns " + typeString); 

                    // 'block' is never null 
                    CommonTree blockTree = (CommonTree)block;

                    // The method name with the exact same type of parameters after it, is the unique key 
                    String key = id;

                    Console.WriteLine("Adding the parameters:");
                    for (int a = 0; a < idListTree.GetChild(0).ChildCount; a++) {
                        key += "-" + idListTree.GetChild(0).GetChild(a).ToString();
                        Console.WriteLine("added " + idListTree.GetChild(0).GetChild(a).ToString());
                    }
                    //idListTree.GetChild(1).ChildCount;
                    methods.Add(key, new Method(id, typeString, idListTree, blockTree));
                    Console.WriteLine("Method " + id + " saved, unique key: " + key);
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


    public static class compilationUnit_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "compilationUnit"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:123:1: compilationUnit : mainBlock ;
    public final SGLParser.compilationUnit_return compilationUnit() throws RecognitionException {
        SGLParser.compilationUnit_return retval = new SGLParser.compilationUnit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.mainBlock_return mainBlock1 = null;



        try { dbg.enterRule(getGrammarFileName(), "compilationUnit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(123, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:124:2: ( mainBlock )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:124:4: mainBlock
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(124,4);
            pushFollow(FOLLOW_mainBlock_in_compilationUnit156);
            mainBlock1=mainBlock();

            state._fsp--;

            adaptor.addChild(root_0, mainBlock1.getTree());

            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(125, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "compilationUnit");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "compilationUnit"

    public static class mainBlock_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "mainBlock"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:127:1: mainBlock : ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) ;
    public final SGLParser.mainBlock_return mainBlock() throws RecognitionException {
        SGLParser.mainBlock_return retval = new SGLParser.mainBlock_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.mainStatement_return mainStatement2 = null;

        SGLParser.methodDef_return methodDef3 = null;


        RewriteRuleSubtreeStream stream_methodDef=new RewriteRuleSubtreeStream(adaptor,"rule methodDef");
        RewriteRuleSubtreeStream stream_mainStatement=new RewriteRuleSubtreeStream(adaptor,"rule mainStatement");
        try { dbg.enterRule(getGrammarFileName(), "mainBlock");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(127, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:128:2: ( ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:128:4: ( mainStatement | methodDef )*
            {
            dbg.location(128,4);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:128:4: ( mainStatement | methodDef )*
            try { dbg.enterSubRule(1);

            loop1:
            do {
                int alt1=3;
                try { dbg.enterDecision(1);

                int LA1_0 = input.LA(1);

                if ( ((LA1_0>=Identifier && LA1_0<=ObjectType)||(LA1_0>=57 && LA1_0<=59)||(LA1_0>=61 && LA1_0<=62)) ) {
                    alt1=1;
                }
                else if ( (LA1_0==49) ) {
                    alt1=2;
                }


                } finally {dbg.exitDecision(1);}

                switch (alt1) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:128:5: mainStatement
            	    {
            	    dbg.location(128,5);
            	    pushFollow(FOLLOW_mainStatement_in_mainBlock169);
            	    mainStatement2=mainStatement();

            	    state._fsp--;

            	    stream_mainStatement.add(mainStatement2.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:128:21: methodDef
            	    {
            	    dbg.location(128,21);
            	    pushFollow(FOLLOW_methodDef_in_mainBlock173);
            	    methodDef3=methodDef();

            	    state._fsp--;

            	    stream_methodDef.add(methodDef3.getTree());

            	    }
            	    break;

            	default :
            	    break loop1;
                }
            } while (true);
            } finally {dbg.exitSubRule(1);}



            // AST REWRITE
            // elements: mainStatement
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 129:8: -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            {
                dbg.location(129,11);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:129:11: ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(129,13);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(BLOCK, "BLOCK"), root_1);

                dbg.location(129,19);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:129:19: ^( STATEMENTS ( mainStatement )* )
                {
                Object root_2 = (Object)adaptor.nil();
                dbg.location(129,21);
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(STATEMENTS, "STATEMENTS"), root_2);

                dbg.location(129,32);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:129:32: ( mainStatement )*
                while ( stream_mainStatement.hasNext() ) {
                    dbg.location(129,32);
                    adaptor.addChild(root_2, stream_mainStatement.nextTree());

                }
                stream_mainStatement.reset();

                adaptor.addChild(root_1, root_2);
                }

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(130, 7);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "mainBlock");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "mainBlock"

    public static class block_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "block"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:132:1: block : ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
    public final SGLParser.block_return block() throws RecognitionException {
        SGLParser.block_return retval = new SGLParser.block_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.statement_return statement4 = null;


        RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try { dbg.enterRule(getGrammarFileName(), "block");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(132, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:133:2: ( ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:133:4: ( statement )*
            {
            dbg.location(133,4);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:133:4: ( statement )*
            try { dbg.enterSubRule(2);

            loop2:
            do {
                int alt2=2;
                try { dbg.enterDecision(2);

                int LA2_0 = input.LA(1);

                if ( ((LA2_0>=Identifier && LA2_0<=ObjectType)||(LA2_0>=57 && LA2_0<=59)||(LA2_0>=61 && LA2_0<=62)) ) {
                    alt2=1;
                }


                } finally {dbg.exitDecision(2);}

                switch (alt2) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:133:4: statement
            	    {
            	    dbg.location(133,4);
            	    pushFollow(FOLLOW_statement_in_block221);
            	    statement4=statement();

            	    state._fsp--;

            	    stream_statement.add(statement4.getTree());

            	    }
            	    break;

            	default :
            	    break loop2;
                }
            } while (true);
            } finally {dbg.exitSubRule(2);}



            // AST REWRITE
            // elements: statement
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 134:3: -> ^( BLOCK ^( STATEMENTS ( statement )* ) )
            {
                dbg.location(134,6);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:6: ^( BLOCK ^( STATEMENTS ( statement )* ) )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(134,8);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(BLOCK, "BLOCK"), root_1);

                dbg.location(134,14);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:14: ^( STATEMENTS ( statement )* )
                {
                Object root_2 = (Object)adaptor.nil();
                dbg.location(134,16);
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(STATEMENTS, "STATEMENTS"), root_2);

                dbg.location(134,27);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:27: ( statement )*
                while ( stream_statement.hasNext() ) {
                    dbg.location(134,27);
                    adaptor.addChild(root_2, stream_statement.nextTree());

                }
                stream_statement.reset();

                adaptor.addChild(root_1, root_2);
                }

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(135, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "block");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "block"

    public static class singleBlock_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "singleBlock"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:137:1: singleBlock : semicolonStatement -> ^( BLOCK ^( STATEMENTS semicolonStatement ) ) ;
    public final SGLParser.singleBlock_return singleBlock() throws RecognitionException {
        SGLParser.singleBlock_return retval = new SGLParser.singleBlock_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement5 = null;


        RewriteRuleSubtreeStream stream_semicolonStatement=new RewriteRuleSubtreeStream(adaptor,"rule semicolonStatement");
        try { dbg.enterRule(getGrammarFileName(), "singleBlock");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(137, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:138:2: ( semicolonStatement -> ^( BLOCK ^( STATEMENTS semicolonStatement ) ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:138:4: semicolonStatement
            {
            dbg.location(138,4);
            pushFollow(FOLLOW_semicolonStatement_in_singleBlock249);
            semicolonStatement5=semicolonStatement();

            state._fsp--;

            stream_semicolonStatement.add(semicolonStatement5.getTree());


            // AST REWRITE
            // elements: semicolonStatement
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 139:3: -> ^( BLOCK ^( STATEMENTS semicolonStatement ) )
            {
                dbg.location(139,6);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:139:6: ^( BLOCK ^( STATEMENTS semicolonStatement ) )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(139,8);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(BLOCK, "BLOCK"), root_1);

                dbg.location(139,14);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:139:14: ^( STATEMENTS semicolonStatement )
                {
                Object root_2 = (Object)adaptor.nil();
                dbg.location(139,16);
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(STATEMENTS, "STATEMENTS"), root_2);

                dbg.location(139,27);
                adaptor.addChild(root_2, stream_semicolonStatement.nextTree());

                adaptor.addChild(root_1, root_2);
                }

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(140, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "singleBlock");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "singleBlock"

    public static class commonBlock_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "commonBlock"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:142:1: commonBlock : ( singleBlock | '{' block '}' );
    public final SGLParser.commonBlock_return commonBlock() throws RecognitionException {
        SGLParser.commonBlock_return retval = new SGLParser.commonBlock_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal7=null;
        Token char_literal9=null;
        SGLParser.singleBlock_return singleBlock6 = null;

        SGLParser.block_return block8 = null;


        Object char_literal7_tree=null;
        Object char_literal9_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "commonBlock");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(142, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:143:2: ( singleBlock | '{' block '}' )
            int alt3=2;
            try { dbg.enterDecision(3);

            int LA3_0 = input.LA(1);

            if ( ((LA3_0>=Identifier && LA3_0<=ObjectType)||(LA3_0>=61 && LA3_0<=62)) ) {
                alt3=1;
            }
            else if ( (LA3_0==47) ) {
                alt3=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 3, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(3);}

            switch (alt3) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:143:4: singleBlock
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(143,4);
                    pushFollow(FOLLOW_singleBlock_in_commonBlock275);
                    singleBlock6=singleBlock();

                    state._fsp--;

                    adaptor.addChild(root_0, singleBlock6.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:144:4: '{' block '}'
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(144,7);
                    char_literal7=(Token)match(input,47,FOLLOW_47_in_commonBlock280); 
                    dbg.location(144,9);
                    pushFollow(FOLLOW_block_in_commonBlock283);
                    block8=block();

                    state._fsp--;

                    adaptor.addChild(root_0, block8.getTree());
                    dbg.location(144,18);
                    char_literal9=(Token)match(input,48,FOLLOW_48_in_commonBlock285); 

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(145, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "commonBlock");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "commonBlock"

    public static class methodDef_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "methodDef"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:148:1: methodDef : 'method' methodType Identifier '(' ( paramList )? ')' commonBlock ;
    public final SGLParser.methodDef_return methodDef() throws RecognitionException {
        SGLParser.methodDef_return retval = new SGLParser.methodDef_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal10=null;
        Token Identifier12=null;
        Token char_literal13=null;
        Token char_literal15=null;
        SGLParser.methodType_return methodType11 = null;

        SGLParser.paramList_return paramList14 = null;

        SGLParser.commonBlock_return commonBlock16 = null;


        Object string_literal10_tree=null;
        Object Identifier12_tree=null;
        Object char_literal13_tree=null;
        Object char_literal15_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "methodDef");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(148, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:149:3: ( 'method' methodType Identifier '(' ( paramList )? ')' commonBlock )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:149:5: 'method' methodType Identifier '(' ( paramList )? ')' commonBlock
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(149,5);
            string_literal10=(Token)match(input,49,FOLLOW_49_in_methodDef315); 
            string_literal10_tree = (Object)adaptor.create(string_literal10);
            adaptor.addChild(root_0, string_literal10_tree);

            dbg.location(149,14);
            pushFollow(FOLLOW_methodType_in_methodDef317);
            methodType11=methodType();

            state._fsp--;

            adaptor.addChild(root_0, methodType11.getTree());
            dbg.location(149,25);
            Identifier12=(Token)match(input,Identifier,FOLLOW_Identifier_in_methodDef319); 
            Identifier12_tree = (Object)adaptor.create(Identifier12);
            adaptor.addChild(root_0, Identifier12_tree);

            dbg.location(149,36);
            char_literal13=(Token)match(input,50,FOLLOW_50_in_methodDef321); 
            char_literal13_tree = (Object)adaptor.create(char_literal13);
            adaptor.addChild(root_0, char_literal13_tree);

            dbg.location(149,40);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:149:40: ( paramList )?
            int alt4=2;
            try { dbg.enterSubRule(4);
            try { dbg.enterDecision(4);

            int LA4_0 = input.LA(1);

            if ( ((LA4_0>=IntType && LA4_0<=ObjectType)) ) {
                alt4=1;
            }
            } finally {dbg.exitDecision(4);}

            switch (alt4) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:149:40: paramList
                    {
                    dbg.location(149,40);
                    pushFollow(FOLLOW_paramList_in_methodDef323);
                    paramList14=paramList();

                    state._fsp--;

                    adaptor.addChild(root_0, paramList14.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(4);}

            dbg.location(149,51);
            char_literal15=(Token)match(input,51,FOLLOW_51_in_methodDef326); 
            char_literal15_tree = (Object)adaptor.create(char_literal15);
            adaptor.addChild(root_0, char_literal15_tree);

            dbg.location(149,55);
            pushFollow(FOLLOW_commonBlock_in_methodDef328);
            commonBlock16=commonBlock();

            state._fsp--;

            adaptor.addChild(root_0, commonBlock16.getTree());
            dbg.location(150,3);
             /*DefineMethod((Identifier12!=null?Identifier12.getText():null), (methodType11!=null?((Object)methodType11.tree):null), (paramList14!=null?((Object)paramList14.tree):null), (commonBlock16!=null?((Object)commonBlock16.tree):null));*/ 

            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(151, 3);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "methodDef");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "methodDef"

    public static class methodType_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "methodType"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:153:1: methodType : ( variableType | 'void' );
    public final SGLParser.methodType_return methodType() throws RecognitionException {
        SGLParser.methodType_return retval = new SGLParser.methodType_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal18=null;
        SGLParser.variableType_return variableType17 = null;


        Object string_literal18_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "methodType");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(153, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:154:2: ( variableType | 'void' )
            int alt5=2;
            try { dbg.enterDecision(5);

            int LA5_0 = input.LA(1);

            if ( ((LA5_0>=IntType && LA5_0<=ObjectType)) ) {
                alt5=1;
            }
            else if ( (LA5_0==52) ) {
                alt5=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 5, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(5);}

            switch (alt5) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:154:4: variableType
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(154,4);
                    pushFollow(FOLLOW_variableType_in_methodType348);
                    variableType17=variableType();

                    state._fsp--;

                    adaptor.addChild(root_0, variableType17.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:155:4: 'void'
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(155,4);
                    string_literal18=(Token)match(input,52,FOLLOW_52_in_methodType353); 
                    string_literal18_tree = (Object)adaptor.create(string_literal18);
                    adaptor.addChild(root_0, string_literal18_tree);


                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(156, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "methodType");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "methodType"

    public static class mainStatement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "mainStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:158:1: mainStatement : statement ;
    public final SGLParser.mainStatement_return mainStatement() throws RecognitionException {
        SGLParser.mainStatement_return retval = new SGLParser.mainStatement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.statement_return statement19 = null;



        try { dbg.enterRule(getGrammarFileName(), "mainStatement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(158, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:159:2: ( statement )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:159:4: statement
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(159,4);
            pushFollow(FOLLOW_statement_in_mainStatement377);
            statement19=statement();

            state._fsp--;

            adaptor.addChild(root_0, statement19.getTree());

            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(160, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "mainStatement");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "mainStatement"

    public static class semicolonStatement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "semicolonStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:162:1: semicolonStatement : ( variableDeclarationList | variableAssignment | variableUnaryChange | methodCall | objectMethod | breakStat | returnStat ) ';' ;
    public final SGLParser.semicolonStatement_return semicolonStatement() throws RecognitionException {
        SGLParser.semicolonStatement_return retval = new SGLParser.semicolonStatement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal27=null;
        SGLParser.variableDeclarationList_return variableDeclarationList20 = null;

        SGLParser.variableAssignment_return variableAssignment21 = null;

        SGLParser.variableUnaryChange_return variableUnaryChange22 = null;

        SGLParser.methodCall_return methodCall23 = null;

        SGLParser.objectMethod_return objectMethod24 = null;

        SGLParser.breakStat_return breakStat25 = null;

        SGLParser.returnStat_return returnStat26 = null;


        Object char_literal27_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "semicolonStatement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(162, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:163:2: ( ( variableDeclarationList | variableAssignment | variableUnaryChange | methodCall | objectMethod | breakStat | returnStat ) ';' )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:163:4: ( variableDeclarationList | variableAssignment | variableUnaryChange | methodCall | objectMethod | breakStat | returnStat ) ';'
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(163,4);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:163:4: ( variableDeclarationList | variableAssignment | variableUnaryChange | methodCall | objectMethod | breakStat | returnStat )
            int alt6=7;
            try { dbg.enterSubRule(6);
            try { dbg.enterDecision(6);

            switch ( input.LA(1) ) {
            case IntType:
            case BooleanType:
            case StringType:
            case FloatType:
            case ObjectType:
                {
                alt6=1;
                }
                break;
            case Identifier:
                {
                switch ( input.LA(2) ) {
                case 50:
                    {
                    alt6=4;
                    }
                    break;
                case 78:
                case 79:
                    {
                    alt6=3;
                    }
                    break;
                case 56:
                    {
                    alt6=5;
                    }
                    break;
                case 55:
                    {
                    alt6=2;
                    }
                    break;
                default:
                    NoViableAltException nvae =
                        new NoViableAltException("", 6, 2, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }

                }
                break;
            case 61:
                {
                alt6=6;
                }
                break;
            case 62:
                {
                alt6=7;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 6, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(6);}

            switch (alt6) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:163:5: variableDeclarationList
                    {
                    dbg.location(163,5);
                    pushFollow(FOLLOW_variableDeclarationList_in_semicolonStatement390);
                    variableDeclarationList20=variableDeclarationList();

                    state._fsp--;

                    adaptor.addChild(root_0, variableDeclarationList20.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:4: variableAssignment
                    {
                    dbg.location(164,4);
                    pushFollow(FOLLOW_variableAssignment_in_semicolonStatement396);
                    variableAssignment21=variableAssignment();

                    state._fsp--;

                    adaptor.addChild(root_0, variableAssignment21.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:165:4: variableUnaryChange
                    {
                    dbg.location(165,4);
                    pushFollow(FOLLOW_variableUnaryChange_in_semicolonStatement402);
                    variableUnaryChange22=variableUnaryChange();

                    state._fsp--;

                    adaptor.addChild(root_0, variableUnaryChange22.getTree());

                    }
                    break;
                case 4 :
                    dbg.enterAlt(4);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:166:4: methodCall
                    {
                    dbg.location(166,4);
                    pushFollow(FOLLOW_methodCall_in_semicolonStatement408);
                    methodCall23=methodCall();

                    state._fsp--;

                    adaptor.addChild(root_0, methodCall23.getTree());

                    }
                    break;
                case 5 :
                    dbg.enterAlt(5);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:167:4: objectMethod
                    {
                    dbg.location(167,4);
                    pushFollow(FOLLOW_objectMethod_in_semicolonStatement413);
                    objectMethod24=objectMethod();

                    state._fsp--;

                    adaptor.addChild(root_0, objectMethod24.getTree());

                    }
                    break;
                case 6 :
                    dbg.enterAlt(6);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:168:4: breakStat
                    {
                    dbg.location(168,4);
                    pushFollow(FOLLOW_breakStat_in_semicolonStatement418);
                    breakStat25=breakStat();

                    state._fsp--;

                    adaptor.addChild(root_0, breakStat25.getTree());

                    }
                    break;
                case 7 :
                    dbg.enterAlt(7);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:169:4: returnStat
                    {
                    dbg.location(169,4);
                    pushFollow(FOLLOW_returnStat_in_semicolonStatement423);
                    returnStat26=returnStat();

                    state._fsp--;

                    adaptor.addChild(root_0, returnStat26.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(6);}

            dbg.location(170,7);
            char_literal27=(Token)match(input,53,FOLLOW_53_in_semicolonStatement428); 

            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(171, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "semicolonStatement");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "semicolonStatement"

    public static class oneLineStatement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "oneLineStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:173:1: oneLineStatement : ( variableDeclarationList | variableAssignment | variableUnaryChange );
    public final SGLParser.oneLineStatement_return oneLineStatement() throws RecognitionException {
        SGLParser.oneLineStatement_return retval = new SGLParser.oneLineStatement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.variableDeclarationList_return variableDeclarationList28 = null;

        SGLParser.variableAssignment_return variableAssignment29 = null;

        SGLParser.variableUnaryChange_return variableUnaryChange30 = null;



        try { dbg.enterRule(getGrammarFileName(), "oneLineStatement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(173, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:2: ( variableDeclarationList | variableAssignment | variableUnaryChange )
            int alt7=3;
            try { dbg.enterDecision(7);

            int LA7_0 = input.LA(1);

            if ( ((LA7_0>=IntType && LA7_0<=ObjectType)) ) {
                alt7=1;
            }
            else if ( (LA7_0==Identifier) ) {
                int LA7_2 = input.LA(2);

                if ( ((LA7_2>=78 && LA7_2<=79)) ) {
                    alt7=3;
                }
                else if ( (LA7_2==55) ) {
                    alt7=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 7, 2, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 7, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(7);}

            switch (alt7) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:4: variableDeclarationList
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(174,4);
                    pushFollow(FOLLOW_variableDeclarationList_in_oneLineStatement441);
                    variableDeclarationList28=variableDeclarationList();

                    state._fsp--;

                    adaptor.addChild(root_0, variableDeclarationList28.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:175:4: variableAssignment
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(175,4);
                    pushFollow(FOLLOW_variableAssignment_in_oneLineStatement446);
                    variableAssignment29=variableAssignment();

                    state._fsp--;

                    adaptor.addChild(root_0, variableAssignment29.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:176:4: variableUnaryChange
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(176,4);
                    pushFollow(FOLLOW_variableUnaryChange_in_oneLineStatement451);
                    variableUnaryChange30=variableUnaryChange();

                    state._fsp--;

                    adaptor.addChild(root_0, variableUnaryChange30.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(177, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "oneLineStatement");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "oneLineStatement"

    public static class statement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "statement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:180:1: statement : ( semicolonStatement | ifStatement | whileLoop | forLoop );
    public final SGLParser.statement_return statement() throws RecognitionException {
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement31 = null;

        SGLParser.ifStatement_return ifStatement32 = null;

        SGLParser.whileLoop_return whileLoop33 = null;

        SGLParser.forLoop_return forLoop34 = null;



        try { dbg.enterRule(getGrammarFileName(), "statement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(180, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:182:2: ( semicolonStatement | ifStatement | whileLoop | forLoop )
            int alt8=4;
            try { dbg.enterDecision(8);

            switch ( input.LA(1) ) {
            case Identifier:
            case IntType:
            case BooleanType:
            case StringType:
            case FloatType:
            case ObjectType:
            case 61:
            case 62:
                {
                alt8=1;
                }
                break;
            case 59:
                {
                alt8=2;
                }
                break;
            case 57:
                {
                alt8=3;
                }
                break;
            case 58:
                {
                alt8=4;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 8, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(8);}

            switch (alt8) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:182:4: semicolonStatement
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(182,4);
                    pushFollow(FOLLOW_semicolonStatement_in_statement467);
                    semicolonStatement31=semicolonStatement();

                    state._fsp--;

                    adaptor.addChild(root_0, semicolonStatement31.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:4: ifStatement
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(183,4);
                    pushFollow(FOLLOW_ifStatement_in_statement472);
                    ifStatement32=ifStatement();

                    state._fsp--;

                    adaptor.addChild(root_0, ifStatement32.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:184:4: whileLoop
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(184,4);
                    pushFollow(FOLLOW_whileLoop_in_statement477);
                    whileLoop33=whileLoop();

                    state._fsp--;

                    adaptor.addChild(root_0, whileLoop33.getTree());

                    }
                    break;
                case 4 :
                    dbg.enterAlt(4);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:185:4: forLoop
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(185,4);
                    pushFollow(FOLLOW_forLoop_in_statement482);
                    forLoop34=forLoop();

                    state._fsp--;

                    adaptor.addChild(root_0, forLoop34.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(186, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "statement");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "statement"

    public static class variableDeclarationList_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableDeclarationList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:192:1: variableDeclarationList : variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( VARDEF variableType variableDecAssignment ) )+ ;
    public final SGLParser.variableDeclarationList_return variableDeclarationList() throws RecognitionException {
        SGLParser.variableDeclarationList_return retval = new SGLParser.variableDeclarationList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal37=null;
        SGLParser.variableType_return variableType35 = null;

        SGLParser.variableDecAssignment_return variableDecAssignment36 = null;

        SGLParser.variableDecAssignment_return variableDecAssignment38 = null;


        Object char_literal37_tree=null;
        RewriteRuleTokenStream stream_54=new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_variableType=new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableDecAssignment=new RewriteRuleSubtreeStream(adaptor,"rule variableDecAssignment");
        try { dbg.enterRule(getGrammarFileName(), "variableDeclarationList");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(192, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:193:2: ( variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( VARDEF variableType variableDecAssignment ) )+ )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:193:4: variableType variableDecAssignment ( ',' variableDecAssignment )*
            {
            dbg.location(193,4);
            pushFollow(FOLLOW_variableType_in_variableDeclarationList498);
            variableType35=variableType();

            state._fsp--;

            stream_variableType.add(variableType35.getTree());
            dbg.location(193,17);
            pushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList500);
            variableDecAssignment36=variableDecAssignment();

            state._fsp--;

            stream_variableDecAssignment.add(variableDecAssignment36.getTree());
            dbg.location(193,39);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:193:39: ( ',' variableDecAssignment )*
            try { dbg.enterSubRule(9);

            loop9:
            do {
                int alt9=2;
                try { dbg.enterDecision(9);

                int LA9_0 = input.LA(1);

                if ( (LA9_0==54) ) {
                    alt9=1;
                }


                } finally {dbg.exitDecision(9);}

                switch (alt9) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:193:40: ',' variableDecAssignment
            	    {
            	    dbg.location(193,40);
            	    char_literal37=(Token)match(input,54,FOLLOW_54_in_variableDeclarationList503);  
            	    stream_54.add(char_literal37);

            	    dbg.location(193,44);
            	    pushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList505);
            	    variableDecAssignment38=variableDecAssignment();

            	    state._fsp--;

            	    stream_variableDecAssignment.add(variableDecAssignment38.getTree());

            	    }
            	    break;

            	default :
            	    break loop9;
                }
            } while (true);
            } finally {dbg.exitSubRule(9);}



            // AST REWRITE
            // elements: variableType, variableDecAssignment
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 193:68: -> ( ^( VARDEF variableType variableDecAssignment ) )+
            {
                dbg.location(193,71);
                if ( !(stream_variableType.hasNext()||stream_variableDecAssignment.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_variableType.hasNext()||stream_variableDecAssignment.hasNext() ) {
                    dbg.location(193,71);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:193:71: ^( VARDEF variableType variableDecAssignment )
                    {
                    Object root_1 = (Object)adaptor.nil();
                    dbg.location(193,73);
                    root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(VARDEF, "VARDEF"), root_1);

                    dbg.location(193,80);
                    adaptor.addChild(root_1, stream_variableType.nextTree());
                    dbg.location(193,93);
                    adaptor.addChild(root_1, stream_variableDecAssignment.nextTree());

                    adaptor.addChild(root_0, root_1);
                    }

                }
                stream_variableType.reset();
                stream_variableDecAssignment.reset();

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(194, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "variableDeclarationList");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "variableDeclarationList"

    public static class variableDecAssignment_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableDecAssignment"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:196:1: variableDecAssignment : variableName ( '=' expression )? -> variableName ( expression )? ;
    public final SGLParser.variableDecAssignment_return variableDecAssignment() throws RecognitionException {
        SGLParser.variableDecAssignment_return retval = new SGLParser.variableDecAssignment_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal40=null;
        SGLParser.variableName_return variableName39 = null;

        SGLParser.expression_return expression41 = null;


        Object char_literal40_tree=null;
        RewriteRuleTokenStream stream_55=new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName=new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try { dbg.enterRule(getGrammarFileName(), "variableDecAssignment");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(196, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:197:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:197:4: variableName ( '=' expression )?
            {
            dbg.location(197,4);
            pushFollow(FOLLOW_variableName_in_variableDecAssignment529);
            variableName39=variableName();

            state._fsp--;

            stream_variableName.add(variableName39.getTree());
            dbg.location(197,17);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:197:17: ( '=' expression )?
            int alt10=2;
            try { dbg.enterSubRule(10);
            try { dbg.enterDecision(10);

            int LA10_0 = input.LA(1);

            if ( (LA10_0==55) ) {
                alt10=1;
            }
            } finally {dbg.exitDecision(10);}

            switch (alt10) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:197:18: '=' expression
                    {
                    dbg.location(197,18);
                    char_literal40=(Token)match(input,55,FOLLOW_55_in_variableDecAssignment532);  
                    stream_55.add(char_literal40);

                    dbg.location(197,22);
                    pushFollow(FOLLOW_expression_in_variableDecAssignment534);
                    expression41=expression();

                    state._fsp--;

                    stream_expression.add(expression41.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(10);}



            // AST REWRITE
            // elements: variableName, expression
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 197:36: -> variableName ( expression )?
            {
                dbg.location(197,39);
                adaptor.addChild(root_0, stream_variableName.nextTree());
                dbg.location(197,52);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:197:52: ( expression )?
                if ( stream_expression.hasNext() ) {
                    dbg.location(197,52);
                    adaptor.addChild(root_0, stream_expression.nextTree());

                }
                stream_expression.reset();

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(198, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "variableDecAssignment");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "variableDecAssignment"

    public static class variableAssignment_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableAssignment"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:1: variableAssignment : variableName '=' expression -> ^( ASSIGN variableName expression ) ;
    public final SGLParser.variableAssignment_return variableAssignment() throws RecognitionException {
        SGLParser.variableAssignment_return retval = new SGLParser.variableAssignment_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal43=null;
        SGLParser.variableName_return variableName42 = null;

        SGLParser.expression_return expression44 = null;


        Object char_literal43_tree=null;
        RewriteRuleTokenStream stream_55=new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName=new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try { dbg.enterRule(getGrammarFileName(), "variableAssignment");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(200, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:201:2: ( variableName '=' expression -> ^( ASSIGN variableName expression ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:201:4: variableName '=' expression
            {
            dbg.location(201,4);
            pushFollow(FOLLOW_variableName_in_variableAssignment555);
            variableName42=variableName();

            state._fsp--;

            stream_variableName.add(variableName42.getTree());
            dbg.location(201,17);
            char_literal43=(Token)match(input,55,FOLLOW_55_in_variableAssignment557);  
            stream_55.add(char_literal43);

            dbg.location(201,21);
            pushFollow(FOLLOW_expression_in_variableAssignment559);
            expression44=expression();

            state._fsp--;

            stream_expression.add(expression44.getTree());


            // AST REWRITE
            // elements: variableName, expression
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 201:33: -> ^( ASSIGN variableName expression )
            {
                dbg.location(201,36);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:201:36: ^( ASSIGN variableName expression )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(201,38);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(ASSIGN, "ASSIGN"), root_1);

                dbg.location(201,45);
                adaptor.addChild(root_1, stream_variableName.nextTree());
                dbg.location(201,58);
                adaptor.addChild(root_1, stream_expression.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(202, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "variableAssignment");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "variableAssignment"

    public static class variableName_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableName"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:209:1: variableName : Identifier ;
    public final SGLParser.variableName_return variableName() throws RecognitionException {
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token Identifier45=null;

        Object Identifier45_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "variableName");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(209, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:2: ( Identifier )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:4: Identifier
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(210,4);
            Identifier45=(Token)match(input,Identifier,FOLLOW_Identifier_in_variableName590); 
            Identifier45_tree = (Object)adaptor.create(Identifier45);
            adaptor.addChild(root_0, Identifier45_tree);


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(211, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "variableName");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "variableName"

    public static class variableType_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableType"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:213:1: variableType : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public final SGLParser.variableType_return variableType() throws RecognitionException {
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set46=null;

        Object set46_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "variableType");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(213, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:214:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(214,2);
            set46=(Token)input.LT(1);
            if ( (input.LA(1)>=IntType && input.LA(1)<=ObjectType) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set46));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                dbg.recognitionException(mse);
                throw mse;
            }


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(219, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "variableType");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "variableType"

    public static class objectMethod_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "objectMethod"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:222:1: objectMethod : variableName '.' Identifier '(' ( arguments )? ')' -> ^( OBJMETHOD variableName Identifier ( arguments )? ) ;
    public final SGLParser.objectMethod_return objectMethod() throws RecognitionException {
        SGLParser.objectMethod_return retval = new SGLParser.objectMethod_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal48=null;
        Token Identifier49=null;
        Token char_literal50=null;
        Token char_literal52=null;
        SGLParser.variableName_return variableName47 = null;

        SGLParser.arguments_return arguments51 = null;


        Object char_literal48_tree=null;
        Object Identifier49_tree=null;
        Object char_literal50_tree=null;
        Object char_literal52_tree=null;
        RewriteRuleTokenStream stream_56=new RewriteRuleTokenStream(adaptor,"token 56");
        RewriteRuleTokenStream stream_51=new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_Identifier=new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_arguments=new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        RewriteRuleSubtreeStream stream_variableName=new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try { dbg.enterRule(getGrammarFileName(), "objectMethod");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(222, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:2: ( variableName '.' Identifier '(' ( arguments )? ')' -> ^( OBJMETHOD variableName Identifier ( arguments )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:4: variableName '.' Identifier '(' ( arguments )? ')'
            {
            dbg.location(223,4);
            pushFollow(FOLLOW_variableName_in_objectMethod634);
            variableName47=variableName();

            state._fsp--;

            stream_variableName.add(variableName47.getTree());
            dbg.location(223,17);
            char_literal48=(Token)match(input,56,FOLLOW_56_in_objectMethod636);  
            stream_56.add(char_literal48);

            dbg.location(223,21);
            Identifier49=(Token)match(input,Identifier,FOLLOW_Identifier_in_objectMethod638);  
            stream_Identifier.add(Identifier49);

            dbg.location(223,32);
            char_literal50=(Token)match(input,50,FOLLOW_50_in_objectMethod640);  
            stream_50.add(char_literal50);

            dbg.location(223,36);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:36: ( arguments )?
            int alt11=2;
            try { dbg.enterSubRule(11);
            try { dbg.enterDecision(11);

            int LA11_0 = input.LA(1);

            if ( (LA11_0==Identifier||(LA11_0>=IntegerAtom && LA11_0<=BooleanAtom)||(LA11_0>=Layer && LA11_0<=StringAtom)||LA11_0==50||LA11_0==74||LA11_0==80) ) {
                alt11=1;
            }
            } finally {dbg.exitDecision(11);}

            switch (alt11) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:36: arguments
                    {
                    dbg.location(223,36);
                    pushFollow(FOLLOW_arguments_in_objectMethod642);
                    arguments51=arguments();

                    state._fsp--;

                    stream_arguments.add(arguments51.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(11);}

            dbg.location(223,47);
            char_literal52=(Token)match(input,51,FOLLOW_51_in_objectMethod645);  
            stream_51.add(char_literal52);



            // AST REWRITE
            // elements: arguments, Identifier, variableName
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 223:51: -> ^( OBJMETHOD variableName Identifier ( arguments )? )
            {
                dbg.location(223,54);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:54: ^( OBJMETHOD variableName Identifier ( arguments )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(223,56);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(OBJMETHOD, "OBJMETHOD"), root_1);

                dbg.location(223,66);
                adaptor.addChild(root_1, stream_variableName.nextTree());
                dbg.location(223,79);
                adaptor.addChild(root_1, stream_Identifier.nextNode());
                dbg.location(223,90);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:90: ( arguments )?
                if ( stream_arguments.hasNext() ) {
                    dbg.location(223,90);
                    adaptor.addChild(root_1, stream_arguments.nextTree());

                }
                stream_arguments.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(224, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "objectMethod");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "objectMethod"

    public static class whileLoop_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "whileLoop"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:226:1: whileLoop : 'while' expression commonBlock -> ^( 'while' expression commonBlock ) ;
    public final SGLParser.whileLoop_return whileLoop() throws RecognitionException {
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal53=null;
        SGLParser.expression_return expression54 = null;

        SGLParser.commonBlock_return commonBlock55 = null;


        Object string_literal53_tree=null;
        RewriteRuleTokenStream stream_57=new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock=new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try { dbg.enterRule(getGrammarFileName(), "whileLoop");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(226, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:227:2: ( 'while' expression commonBlock -> ^( 'while' expression commonBlock ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:227:4: 'while' expression commonBlock
            {
            dbg.location(227,4);
            string_literal53=(Token)match(input,57,FOLLOW_57_in_whileLoop669);  
            stream_57.add(string_literal53);

            dbg.location(227,12);
            pushFollow(FOLLOW_expression_in_whileLoop671);
            expression54=expression();

            state._fsp--;

            stream_expression.add(expression54.getTree());
            dbg.location(227,23);
            pushFollow(FOLLOW_commonBlock_in_whileLoop673);
            commonBlock55=commonBlock();

            state._fsp--;

            stream_commonBlock.add(commonBlock55.getTree());


            // AST REWRITE
            // elements: commonBlock, expression, 57
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 227:35: -> ^( 'while' expression commonBlock )
            {
                dbg.location(227,38);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:227:38: ^( 'while' expression commonBlock )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(227,40);
                root_1 = (Object)adaptor.becomeRoot(stream_57.nextNode(), root_1);

                dbg.location(227,48);
                adaptor.addChild(root_1, stream_expression.nextTree());
                dbg.location(227,59);
                adaptor.addChild(root_1, stream_commonBlock.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(228, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "whileLoop");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "whileLoop"

    public static class forLoop_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "forLoop"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:230:1: forLoop : 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) ;
    public final SGLParser.forLoop_return forLoop() throws RecognitionException {
        SGLParser.forLoop_return retval = new SGLParser.forLoop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal56=null;
        Token char_literal57=null;
        Token char_literal58=null;
        Token char_literal59=null;
        Token char_literal60=null;
        SGLParser.oneLineStatement_return dec = null;

        SGLParser.expression_return cond = null;

        SGLParser.oneLineStatement_return iter = null;

        SGLParser.commonBlock_return commonBlock61 = null;


        Object string_literal56_tree=null;
        Object char_literal57_tree=null;
        Object char_literal58_tree=null;
        Object char_literal59_tree=null;
        Object char_literal60_tree=null;
        RewriteRuleTokenStream stream_58=new RewriteRuleTokenStream(adaptor,"token 58");
        RewriteRuleTokenStream stream_51=new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_53=new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock=new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        RewriteRuleSubtreeStream stream_oneLineStatement=new RewriteRuleSubtreeStream(adaptor,"rule oneLineStatement");
        try { dbg.enterRule(getGrammarFileName(), "forLoop");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(230, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:2: ( 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:4: 'for' '(' (dec= oneLineStatement )? ';' (cond= expression )? ';' (iter= oneLineStatement )? ')' commonBlock
            {
            dbg.location(231,4);
            string_literal56=(Token)match(input,58,FOLLOW_58_in_forLoop695);  
            stream_58.add(string_literal56);

            dbg.location(231,10);
            char_literal57=(Token)match(input,50,FOLLOW_50_in_forLoop697);  
            stream_50.add(char_literal57);

            dbg.location(231,17);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:17: (dec= oneLineStatement )?
            int alt12=2;
            try { dbg.enterSubRule(12);
            try { dbg.enterDecision(12);

            int LA12_0 = input.LA(1);

            if ( ((LA12_0>=Identifier && LA12_0<=ObjectType)) ) {
                alt12=1;
            }
            } finally {dbg.exitDecision(12);}

            switch (alt12) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:17: dec= oneLineStatement
                    {
                    dbg.location(231,17);
                    pushFollow(FOLLOW_oneLineStatement_in_forLoop701);
                    dec=oneLineStatement();

                    state._fsp--;

                    stream_oneLineStatement.add(dec.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(12);}

            dbg.location(231,36);
            char_literal58=(Token)match(input,53,FOLLOW_53_in_forLoop704);  
            stream_53.add(char_literal58);

            dbg.location(231,44);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:44: (cond= expression )?
            int alt13=2;
            try { dbg.enterSubRule(13);
            try { dbg.enterDecision(13);

            int LA13_0 = input.LA(1);

            if ( (LA13_0==Identifier||(LA13_0>=IntegerAtom && LA13_0<=BooleanAtom)||(LA13_0>=Layer && LA13_0<=StringAtom)||LA13_0==50||LA13_0==74||LA13_0==80) ) {
                alt13=1;
            }
            } finally {dbg.exitDecision(13);}

            switch (alt13) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:44: cond= expression
                    {
                    dbg.location(231,44);
                    pushFollow(FOLLOW_expression_in_forLoop708);
                    cond=expression();

                    state._fsp--;

                    stream_expression.add(cond.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(13);}

            dbg.location(231,57);
            char_literal59=(Token)match(input,53,FOLLOW_53_in_forLoop711);  
            stream_53.add(char_literal59);

            dbg.location(231,65);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:65: (iter= oneLineStatement )?
            int alt14=2;
            try { dbg.enterSubRule(14);
            try { dbg.enterDecision(14);

            int LA14_0 = input.LA(1);

            if ( ((LA14_0>=Identifier && LA14_0<=ObjectType)) ) {
                alt14=1;
            }
            } finally {dbg.exitDecision(14);}

            switch (alt14) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:231:65: iter= oneLineStatement
                    {
                    dbg.location(231,65);
                    pushFollow(FOLLOW_oneLineStatement_in_forLoop715);
                    iter=oneLineStatement();

                    state._fsp--;

                    stream_oneLineStatement.add(iter.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(14);}

            dbg.location(231,84);
            char_literal60=(Token)match(input,51,FOLLOW_51_in_forLoop718);  
            stream_51.add(char_literal60);

            dbg.location(231,88);
            pushFollow(FOLLOW_commonBlock_in_forLoop720);
            commonBlock61=commonBlock();

            state._fsp--;

            stream_commonBlock.add(commonBlock61.getTree());


            // AST REWRITE
            // elements: dec, iter, 58, cond, commonBlock
            // token labels: 
            // rule labels: retval, dec, iter, cond
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);
            RewriteRuleSubtreeStream stream_dec=new RewriteRuleSubtreeStream(adaptor,"rule dec",dec!=null?dec.tree:null);
            RewriteRuleSubtreeStream stream_iter=new RewriteRuleSubtreeStream(adaptor,"rule iter",iter!=null?iter.tree:null);
            RewriteRuleSubtreeStream stream_cond=new RewriteRuleSubtreeStream(adaptor,"rule cond",cond!=null?cond.tree:null);

            root_0 = (Object)adaptor.nil();
            // 232:2: -> ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
            {
                dbg.location(232,5);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:232:5: ^( 'for' ^( FORDEC ( $dec)? ) ^( FORCOND ( $cond)? ) ^( FORITER ( $iter)? ) commonBlock )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(232,7);
                root_1 = (Object)adaptor.becomeRoot(stream_58.nextNode(), root_1);

                dbg.location(232,13);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:232:13: ^( FORDEC ( $dec)? )
                {
                Object root_2 = (Object)adaptor.nil();
                dbg.location(232,15);
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(FORDEC, "FORDEC"), root_2);

                dbg.location(232,22);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:232:22: ( $dec)?
                if ( stream_dec.hasNext() ) {
                    dbg.location(232,22);
                    adaptor.addChild(root_2, stream_dec.nextTree());

                }
                stream_dec.reset();

                adaptor.addChild(root_1, root_2);
                }
                dbg.location(232,29);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:232:29: ^( FORCOND ( $cond)? )
                {
                Object root_2 = (Object)adaptor.nil();
                dbg.location(232,31);
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(FORCOND, "FORCOND"), root_2);

                dbg.location(232,39);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:232:39: ( $cond)?
                if ( stream_cond.hasNext() ) {
                    dbg.location(232,39);
                    adaptor.addChild(root_2, stream_cond.nextTree());

                }
                stream_cond.reset();

                adaptor.addChild(root_1, root_2);
                }
                dbg.location(232,47);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:232:47: ^( FORITER ( $iter)? )
                {
                Object root_2 = (Object)adaptor.nil();
                dbg.location(232,49);
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(FORITER, "FORITER"), root_2);

                dbg.location(232,57);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:232:57: ( $iter)?
                if ( stream_iter.hasNext() ) {
                    dbg.location(232,57);
                    adaptor.addChild(root_2, stream_iter.nextTree());

                }
                stream_iter.reset();

                adaptor.addChild(root_1, root_2);
                }
                dbg.location(232,65);
                adaptor.addChild(root_1, stream_commonBlock.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(233, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "forLoop");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "forLoop"

    public static class ifStatement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "ifStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:235:1: ifStatement : ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) ;
    public final SGLParser.ifStatement_return ifStatement() throws RecognitionException {
        SGLParser.ifStatement_return retval = new SGLParser.ifStatement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.ifStat_return ifStat62 = null;

        SGLParser.elseIfStat_return elseIfStat63 = null;

        SGLParser.elseStat_return elseStat64 = null;


        RewriteRuleSubtreeStream stream_elseIfStat=new RewriteRuleSubtreeStream(adaptor,"rule elseIfStat");
        RewriteRuleSubtreeStream stream_ifStat=new RewriteRuleSubtreeStream(adaptor,"rule ifStat");
        RewriteRuleSubtreeStream stream_elseStat=new RewriteRuleSubtreeStream(adaptor,"rule elseStat");
        try { dbg.enterRule(getGrammarFileName(), "ifStatement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(235, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:2: ( ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:4: ifStat ( elseIfStat )* ( elseStat )?
            {
            dbg.location(236,4);
            pushFollow(FOLLOW_ifStat_in_ifStatement765);
            ifStat62=ifStat();

            state._fsp--;

            stream_ifStat.add(ifStat62.getTree());
            dbg.location(236,11);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:11: ( elseIfStat )*
            try { dbg.enterSubRule(15);

            loop15:
            do {
                int alt15=2;
                try { dbg.enterDecision(15);

                int LA15_0 = input.LA(1);

                if ( (LA15_0==60) ) {
                    int LA15_1 = input.LA(2);

                    if ( (LA15_1==59) ) {
                        alt15=1;
                    }


                }


                } finally {dbg.exitDecision(15);}

                switch (alt15) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:11: elseIfStat
            	    {
            	    dbg.location(236,11);
            	    pushFollow(FOLLOW_elseIfStat_in_ifStatement767);
            	    elseIfStat63=elseIfStat();

            	    state._fsp--;

            	    stream_elseIfStat.add(elseIfStat63.getTree());

            	    }
            	    break;

            	default :
            	    break loop15;
                }
            } while (true);
            } finally {dbg.exitSubRule(15);}

            dbg.location(236,23);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:23: ( elseStat )?
            int alt16=2;
            try { dbg.enterSubRule(16);
            try { dbg.enterDecision(16);

            int LA16_0 = input.LA(1);

            if ( (LA16_0==60) ) {
                alt16=1;
            }
            } finally {dbg.exitDecision(16);}

            switch (alt16) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:23: elseStat
                    {
                    dbg.location(236,23);
                    pushFollow(FOLLOW_elseStat_in_ifStatement770);
                    elseStat64=elseStat();

                    state._fsp--;

                    stream_elseStat.add(elseStat64.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(16);}



            // AST REWRITE
            // elements: elseStat, elseIfStat, ifStat
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 236:33: -> ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            {
                dbg.location(236,36);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:36: ^( IF ifStat ( elseIfStat )* ( elseStat )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(236,38);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IF, "IF"), root_1);

                dbg.location(236,41);
                adaptor.addChild(root_1, stream_ifStat.nextTree());
                dbg.location(236,48);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:48: ( elseIfStat )*
                while ( stream_elseIfStat.hasNext() ) {
                    dbg.location(236,48);
                    adaptor.addChild(root_1, stream_elseIfStat.nextTree());

                }
                stream_elseIfStat.reset();
                dbg.location(236,60);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:236:60: ( elseStat )?
                if ( stream_elseStat.hasNext() ) {
                    dbg.location(236,60);
                    adaptor.addChild(root_1, stream_elseStat.nextTree());

                }
                stream_elseStat.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(237, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "ifStatement");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "ifStatement"

    public static class ifStat_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "ifStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:1: ifStat : 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public final SGLParser.ifStat_return ifStat() throws RecognitionException {
        SGLParser.ifStat_return retval = new SGLParser.ifStat_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal65=null;
        SGLParser.expression_return expression66 = null;

        SGLParser.commonBlock_return commonBlock67 = null;


        Object string_literal65_tree=null;
        RewriteRuleTokenStream stream_59=new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock=new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try { dbg.enterRule(getGrammarFileName(), "ifStat");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(238, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:239:2: ( 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:239:4: 'if' expression commonBlock
            {
            dbg.location(239,4);
            string_literal65=(Token)match(input,59,FOLLOW_59_in_ifStat795);  
            stream_59.add(string_literal65);

            dbg.location(239,9);
            pushFollow(FOLLOW_expression_in_ifStat797);
            expression66=expression();

            state._fsp--;

            stream_expression.add(expression66.getTree());
            dbg.location(239,20);
            pushFollow(FOLLOW_commonBlock_in_ifStat799);
            commonBlock67=commonBlock();

            state._fsp--;

            stream_commonBlock.add(commonBlock67.getTree());


            // AST REWRITE
            // elements: commonBlock, expression
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 239:32: -> ^( EXP expression commonBlock )
            {
                dbg.location(239,35);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:239:35: ^( EXP expression commonBlock )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(239,37);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(EXP, "EXP"), root_1);

                dbg.location(239,41);
                adaptor.addChild(root_1, stream_expression.nextTree());
                dbg.location(239,52);
                adaptor.addChild(root_1, stream_commonBlock.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(240, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "ifStat");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "ifStat"

    public static class elseIfStat_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "elseIfStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:1: elseIfStat : 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public final SGLParser.elseIfStat_return elseIfStat() throws RecognitionException {
        SGLParser.elseIfStat_return retval = new SGLParser.elseIfStat_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal68=null;
        Token string_literal69=null;
        SGLParser.expression_return expression70 = null;

        SGLParser.commonBlock_return commonBlock71 = null;


        Object string_literal68_tree=null;
        Object string_literal69_tree=null;
        RewriteRuleTokenStream stream_59=new RewriteRuleTokenStream(adaptor,"token 59");
        RewriteRuleTokenStream stream_60=new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock=new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try { dbg.enterRule(getGrammarFileName(), "elseIfStat");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(242, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:243:2: ( 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:243:4: 'else' 'if' expression commonBlock
            {
            dbg.location(243,4);
            string_literal68=(Token)match(input,60,FOLLOW_60_in_elseIfStat820);  
            stream_60.add(string_literal68);

            dbg.location(243,11);
            string_literal69=(Token)match(input,59,FOLLOW_59_in_elseIfStat822);  
            stream_59.add(string_literal69);

            dbg.location(243,16);
            pushFollow(FOLLOW_expression_in_elseIfStat824);
            expression70=expression();

            state._fsp--;

            stream_expression.add(expression70.getTree());
            dbg.location(243,27);
            pushFollow(FOLLOW_commonBlock_in_elseIfStat826);
            commonBlock71=commonBlock();

            state._fsp--;

            stream_commonBlock.add(commonBlock71.getTree());


            // AST REWRITE
            // elements: commonBlock, expression
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 243:39: -> ^( EXP expression commonBlock )
            {
                dbg.location(243,42);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:243:42: ^( EXP expression commonBlock )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(243,44);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(EXP, "EXP"), root_1);

                dbg.location(243,48);
                adaptor.addChild(root_1, stream_expression.nextTree());
                dbg.location(243,59);
                adaptor.addChild(root_1, stream_commonBlock.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(244, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "elseIfStat");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "elseIfStat"

    public static class elseStat_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "elseStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:246:1: elseStat : 'else' commonBlock -> ^( EXP commonBlock ) ;
    public final SGLParser.elseStat_return elseStat() throws RecognitionException {
        SGLParser.elseStat_return retval = new SGLParser.elseStat_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal72=null;
        SGLParser.commonBlock_return commonBlock73 = null;


        Object string_literal72_tree=null;
        RewriteRuleTokenStream stream_60=new RewriteRuleTokenStream(adaptor,"token 60");
        RewriteRuleSubtreeStream stream_commonBlock=new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try { dbg.enterRule(getGrammarFileName(), "elseStat");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(246, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:2: ( 'else' commonBlock -> ^( EXP commonBlock ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:4: 'else' commonBlock
            {
            dbg.location(247,4);
            string_literal72=(Token)match(input,60,FOLLOW_60_in_elseStat848);  
            stream_60.add(string_literal72);

            dbg.location(247,11);
            pushFollow(FOLLOW_commonBlock_in_elseStat850);
            commonBlock73=commonBlock();

            state._fsp--;

            stream_commonBlock.add(commonBlock73.getTree());


            // AST REWRITE
            // elements: commonBlock
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 247:23: -> ^( EXP commonBlock )
            {
                dbg.location(247,26);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:26: ^( EXP commonBlock )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(247,28);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(EXP, "EXP"), root_1);

                dbg.location(247,32);
                adaptor.addChild(root_1, stream_commonBlock.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(248, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "elseStat");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "elseStat"

    public static class breakStat_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "breakStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:254:1: breakStat : 'break' -> BREAK ;
    public final SGLParser.breakStat_return breakStat() throws RecognitionException {
        SGLParser.breakStat_return retval = new SGLParser.breakStat_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal74=null;

        Object string_literal74_tree=null;
        RewriteRuleTokenStream stream_61=new RewriteRuleTokenStream(adaptor,"token 61");

        try { dbg.enterRule(getGrammarFileName(), "breakStat");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(254, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:255:2: ( 'break' -> BREAK )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:255:4: 'break'
            {
            dbg.location(255,4);
            string_literal74=(Token)match(input,61,FOLLOW_61_in_breakStat875);  
            stream_61.add(string_literal74);



            // AST REWRITE
            // elements: 
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 255:12: -> BREAK
            {
                dbg.location(255,15);
                adaptor.addChild(root_0, (Object)adaptor.create(BREAK, "BREAK"));

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(256, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "breakStat");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "breakStat"

    public static class returnStat_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "returnStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:258:1: returnStat : 'return' expression -> ^( RETURN expression ) ;
    public final SGLParser.returnStat_return returnStat() throws RecognitionException {
        SGLParser.returnStat_return retval = new SGLParser.returnStat_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal75=null;
        SGLParser.expression_return expression76 = null;


        Object string_literal75_tree=null;
        RewriteRuleTokenStream stream_62=new RewriteRuleTokenStream(adaptor,"token 62");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try { dbg.enterRule(getGrammarFileName(), "returnStat");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(258, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:259:2: ( 'return' expression -> ^( RETURN expression ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:259:4: 'return' expression
            {
            dbg.location(259,4);
            string_literal75=(Token)match(input,62,FOLLOW_62_in_returnStat890);  
            stream_62.add(string_literal75);

            dbg.location(259,13);
            pushFollow(FOLLOW_expression_in_returnStat892);
            expression76=expression();

            state._fsp--;

            stream_expression.add(expression76.getTree());


            // AST REWRITE
            // elements: expression
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 259:24: -> ^( RETURN expression )
            {
                dbg.location(259,27);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:259:27: ^( RETURN expression )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(259,29);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(RETURN, "RETURN"), root_1);

                dbg.location(259,36);
                adaptor.addChild(root_1, stream_expression.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(260, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "returnStat");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "returnStat"

    public static class methodCall_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "methodCall"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:262:1: methodCall : Identifier '(' ( expressionList )? ')' -> ^( METH_CALL Identifier ( expressionList )? ) ;
    public final SGLParser.methodCall_return methodCall() throws RecognitionException {
        SGLParser.methodCall_return retval = new SGLParser.methodCall_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token Identifier77=null;
        Token char_literal78=null;
        Token char_literal80=null;
        SGLParser.expressionList_return expressionList79 = null;


        Object Identifier77_tree=null;
        Object char_literal78_tree=null;
        Object char_literal80_tree=null;
        RewriteRuleTokenStream stream_51=new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_Identifier=new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_expressionList=new RewriteRuleSubtreeStream(adaptor,"rule expressionList");
        try { dbg.enterRule(getGrammarFileName(), "methodCall");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(262, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:2: ( Identifier '(' ( expressionList )? ')' -> ^( METH_CALL Identifier ( expressionList )? ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:4: Identifier '(' ( expressionList )? ')'
            {
            dbg.location(263,4);
            Identifier77=(Token)match(input,Identifier,FOLLOW_Identifier_in_methodCall911);  
            stream_Identifier.add(Identifier77);

            dbg.location(263,15);
            char_literal78=(Token)match(input,50,FOLLOW_50_in_methodCall913);  
            stream_50.add(char_literal78);

            dbg.location(263,19);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:19: ( expressionList )?
            int alt17=2;
            try { dbg.enterSubRule(17);
            try { dbg.enterDecision(17);

            int LA17_0 = input.LA(1);

            if ( (LA17_0==Identifier||(LA17_0>=IntegerAtom && LA17_0<=BooleanAtom)||(LA17_0>=Layer && LA17_0<=StringAtom)||LA17_0==50||LA17_0==74||LA17_0==80) ) {
                alt17=1;
            }
            } finally {dbg.exitDecision(17);}

            switch (alt17) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:19: expressionList
                    {
                    dbg.location(263,19);
                    pushFollow(FOLLOW_expressionList_in_methodCall915);
                    expressionList79=expressionList();

                    state._fsp--;

                    stream_expressionList.add(expressionList79.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(17);}

            dbg.location(263,35);
            char_literal80=(Token)match(input,51,FOLLOW_51_in_methodCall918);  
            stream_51.add(char_literal80);



            // AST REWRITE
            // elements: Identifier, expressionList
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 263:39: -> ^( METH_CALL Identifier ( expressionList )? )
            {
                dbg.location(263,42);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:42: ^( METH_CALL Identifier ( expressionList )? )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(263,44);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(METH_CALL, "METH_CALL"), root_1);

                dbg.location(263,54);
                adaptor.addChild(root_1, stream_Identifier.nextNode());
                dbg.location(263,65);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:65: ( expressionList )?
                if ( stream_expressionList.hasNext() ) {
                    dbg.location(263,65);
                    adaptor.addChild(root_1, stream_expressionList.nextTree());

                }
                stream_expressionList.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(264, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "methodCall");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "methodCall"

    public static class expression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "expression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:282:1: expression : conditionalExpression ;
    public final SGLParser.expression_return expression() throws RecognitionException {
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression81 = null;



        try { dbg.enterRule(getGrammarFileName(), "expression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(282, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:283:5: ( conditionalExpression )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:283:8: conditionalExpression
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(283,8);
            pushFollow(FOLLOW_conditionalExpression_in_expression975);
            conditionalExpression81=conditionalExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalExpression81.getTree());

            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(285, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "expression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "expression"

    public static class conditionalExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "conditionalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:292:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public final SGLParser.conditionalExpression_return conditionalExpression() throws RecognitionException {
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal83=null;
        Token char_literal85=null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression82 = null;

        SGLParser.conditionalExpression_return conditionalExpression84 = null;

        SGLParser.conditionalExpression_return conditionalExpression86 = null;


        Object char_literal83_tree=null;
        Object char_literal85_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "conditionalExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(292, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:293:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:293:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(293,9);
            pushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression1016);
            conditionalOrExpression82=conditionalOrExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalOrExpression82.getTree());
            dbg.location(293,33);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:293:33: ( '?' conditionalExpression ':' conditionalExpression )?
            int alt18=2;
            try { dbg.enterSubRule(18);
            try { dbg.enterDecision(18);

            int LA18_0 = input.LA(1);

            if ( (LA18_0==63) ) {
                alt18=1;
            }
            } finally {dbg.exitDecision(18);}

            switch (alt18) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:293:35: '?' conditionalExpression ':' conditionalExpression
                    {
                    dbg.location(293,38);
                    char_literal83=(Token)match(input,63,FOLLOW_63_in_conditionalExpression1020); 
                    char_literal83_tree = (Object)adaptor.create(char_literal83);
                    root_0 = (Object)adaptor.becomeRoot(char_literal83_tree, root_0);

                    dbg.location(293,40);
                    pushFollow(FOLLOW_conditionalExpression_in_conditionalExpression1023);
                    conditionalExpression84=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression84.getTree());
                    dbg.location(293,65);
                    char_literal85=(Token)match(input,64,FOLLOW_64_in_conditionalExpression1025); 
                    dbg.location(293,67);
                    pushFollow(FOLLOW_conditionalExpression_in_conditionalExpression1028);
                    conditionalExpression86=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression86.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(18);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(294, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "conditionalExpression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "conditionalExpression"

    public static class conditionalOrExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "conditionalOrExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:298:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public final SGLParser.conditionalOrExpression_return conditionalOrExpression() throws RecognitionException {
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal88=null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression87 = null;

        SGLParser.conditionalAndExpression_return conditionalAndExpression89 = null;


        Object string_literal88_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "conditionalOrExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(298, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:299:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:299:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(299,9);
            pushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1071);
            conditionalAndExpression87=conditionalAndExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalAndExpression87.getTree());
            dbg.location(299,34);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:299:34: ( '||' conditionalAndExpression )*
            try { dbg.enterSubRule(19);

            loop19:
            do {
                int alt19=2;
                try { dbg.enterDecision(19);

                int LA19_0 = input.LA(1);

                if ( (LA19_0==65) ) {
                    alt19=1;
                }


                } finally {dbg.exitDecision(19);}

                switch (alt19) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:299:36: '||' conditionalAndExpression
            	    {
            	    dbg.location(299,40);
            	    string_literal88=(Token)match(input,65,FOLLOW_65_in_conditionalOrExpression1075); 
            	    string_literal88_tree = (Object)adaptor.create(string_literal88);
            	    root_0 = (Object)adaptor.becomeRoot(string_literal88_tree, root_0);

            	    dbg.location(299,42);
            	    pushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression1078);
            	    conditionalAndExpression89=conditionalAndExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, conditionalAndExpression89.getTree());

            	    }
            	    break;

            	default :
            	    break loop19;
                }
            } while (true);
            } finally {dbg.exitSubRule(19);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(300, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "conditionalOrExpression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "conditionalOrExpression"

    public static class conditionalAndExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "conditionalAndExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:303:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public final SGLParser.conditionalAndExpression_return conditionalAndExpression() throws RecognitionException {
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal91=null;
        SGLParser.equalityExpression_return equalityExpression90 = null;

        SGLParser.equalityExpression_return equalityExpression92 = null;


        Object string_literal91_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "conditionalAndExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(303, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:304:5: ( equalityExpression ( '&&' equalityExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:304:9: equalityExpression ( '&&' equalityExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(304,9);
            pushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1109);
            equalityExpression90=equalityExpression();

            state._fsp--;

            adaptor.addChild(root_0, equalityExpression90.getTree());
            dbg.location(304,28);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:304:28: ( '&&' equalityExpression )*
            try { dbg.enterSubRule(20);

            loop20:
            do {
                int alt20=2;
                try { dbg.enterDecision(20);

                int LA20_0 = input.LA(1);

                if ( (LA20_0==66) ) {
                    alt20=1;
                }


                } finally {dbg.exitDecision(20);}

                switch (alt20) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:304:30: '&&' equalityExpression
            	    {
            	    dbg.location(304,34);
            	    string_literal91=(Token)match(input,66,FOLLOW_66_in_conditionalAndExpression1113); 
            	    string_literal91_tree = (Object)adaptor.create(string_literal91);
            	    root_0 = (Object)adaptor.becomeRoot(string_literal91_tree, root_0);

            	    dbg.location(304,36);
            	    pushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression1116);
            	    equalityExpression92=equalityExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, equalityExpression92.getTree());

            	    }
            	    break;

            	default :
            	    break loop20;
                }
            } while (true);
            } finally {dbg.exitSubRule(20);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(305, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "conditionalAndExpression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "conditionalAndExpression"

    public static class equalityExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "equalityExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:308:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public final SGLParser.equalityExpression_return equalityExpression() throws RecognitionException {
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal94=null;
        Token string_literal95=null;
        SGLParser.relationalExpression_return relationalExpression93 = null;

        SGLParser.relationalExpression_return relationalExpression96 = null;


        Object string_literal94_tree=null;
        Object string_literal95_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "equalityExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(308, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:309:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:309:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(309,9);
            pushFollow(FOLLOW_relationalExpression_in_equalityExpression1143);
            relationalExpression93=relationalExpression();

            state._fsp--;

            adaptor.addChild(root_0, relationalExpression93.getTree());
            dbg.location(309,30);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:309:30: ( ( '==' | '!=' ) relationalExpression )*
            try { dbg.enterSubRule(22);

            loop22:
            do {
                int alt22=2;
                try { dbg.enterDecision(22);

                int LA22_0 = input.LA(1);

                if ( ((LA22_0>=67 && LA22_0<=68)) ) {
                    alt22=1;
                }


                } finally {dbg.exitDecision(22);}

                switch (alt22) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:309:32: ( '==' | '!=' ) relationalExpression
            	    {
            	    dbg.location(309,32);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:309:32: ( '==' | '!=' )
            	    int alt21=2;
            	    try { dbg.enterSubRule(21);
            	    try { dbg.enterDecision(21);

            	    int LA21_0 = input.LA(1);

            	    if ( (LA21_0==67) ) {
            	        alt21=1;
            	    }
            	    else if ( (LA21_0==68) ) {
            	        alt21=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 21, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }
            	    } finally {dbg.exitDecision(21);}

            	    switch (alt21) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:309:33: '=='
            	            {
            	            dbg.location(309,37);
            	            string_literal94=(Token)match(input,67,FOLLOW_67_in_equalityExpression1148); 
            	            string_literal94_tree = (Object)adaptor.create(string_literal94);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal94_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:309:41: '!='
            	            {
            	            dbg.location(309,45);
            	            string_literal95=(Token)match(input,68,FOLLOW_68_in_equalityExpression1153); 
            	            string_literal95_tree = (Object)adaptor.create(string_literal95);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal95_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(21);}

            	    dbg.location(309,48);
            	    pushFollow(FOLLOW_relationalExpression_in_equalityExpression1157);
            	    relationalExpression96=relationalExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, relationalExpression96.getTree());

            	    }
            	    break;

            	default :
            	    break loop22;
                }
            } while (true);
            } finally {dbg.exitSubRule(22);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(310, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "equalityExpression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "equalityExpression"

    public static class relationalExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "relationalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:313:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public final SGLParser.relationalExpression_return relationalExpression() throws RecognitionException {
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal98=null;
        Token char_literal99=null;
        Token string_literal100=null;
        Token string_literal101=null;
        SGLParser.additiveExpression_return additiveExpression97 = null;

        SGLParser.additiveExpression_return additiveExpression102 = null;


        Object char_literal98_tree=null;
        Object char_literal99_tree=null;
        Object string_literal100_tree=null;
        Object string_literal101_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "relationalExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(313, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(314,9);
            pushFollow(FOLLOW_additiveExpression_in_relationalExpression1188);
            additiveExpression97=additiveExpression();

            state._fsp--;

            adaptor.addChild(root_0, additiveExpression97.getTree());
            dbg.location(314,28);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            try { dbg.enterSubRule(24);

            loop24:
            do {
                int alt24=2;
                try { dbg.enterDecision(24);

                int LA24_0 = input.LA(1);

                if ( ((LA24_0>=69 && LA24_0<=72)) ) {
                    alt24=1;
                }


                } finally {dbg.exitDecision(24);}

                switch (alt24) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            	    {
            	    dbg.location(314,29);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:29: ( '<' | '>' | '<=' | '>=' )
            	    int alt23=4;
            	    try { dbg.enterSubRule(23);
            	    try { dbg.enterDecision(23);

            	    switch ( input.LA(1) ) {
            	    case 69:
            	        {
            	        alt23=1;
            	        }
            	        break;
            	    case 70:
            	        {
            	        alt23=2;
            	        }
            	        break;
            	    case 71:
            	        {
            	        alt23=3;
            	        }
            	        break;
            	    case 72:
            	        {
            	        alt23=4;
            	        }
            	        break;
            	    default:
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 23, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }

            	    } finally {dbg.exitDecision(23);}

            	    switch (alt23) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:30: '<'
            	            {
            	            dbg.location(314,33);
            	            char_literal98=(Token)match(input,69,FOLLOW_69_in_relationalExpression1192); 
            	            char_literal98_tree = (Object)adaptor.create(char_literal98);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal98_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:35: '>'
            	            {
            	            dbg.location(314,38);
            	            char_literal99=(Token)match(input,70,FOLLOW_70_in_relationalExpression1195); 
            	            char_literal99_tree = (Object)adaptor.create(char_literal99);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal99_tree, root_0);


            	            }
            	            break;
            	        case 3 :
            	            dbg.enterAlt(3);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:40: '<='
            	            {
            	            dbg.location(314,44);
            	            string_literal100=(Token)match(input,71,FOLLOW_71_in_relationalExpression1198); 
            	            string_literal100_tree = (Object)adaptor.create(string_literal100);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal100_tree, root_0);


            	            }
            	            break;
            	        case 4 :
            	            dbg.enterAlt(4);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:314:46: '>='
            	            {
            	            dbg.location(314,50);
            	            string_literal101=(Token)match(input,72,FOLLOW_72_in_relationalExpression1201); 
            	            string_literal101_tree = (Object)adaptor.create(string_literal101);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal101_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(23);}

            	    dbg.location(314,53);
            	    pushFollow(FOLLOW_additiveExpression_in_relationalExpression1205);
            	    additiveExpression102=additiveExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, additiveExpression102.getTree());

            	    }
            	    break;

            	default :
            	    break loop24;
                }
            } while (true);
            } finally {dbg.exitSubRule(24);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(315, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "relationalExpression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "relationalExpression"

    public static class additiveExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "additiveExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:318:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public final SGLParser.additiveExpression_return additiveExpression() throws RecognitionException {
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal104=null;
        Token char_literal105=null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression103 = null;

        SGLParser.multiplicativeExpression_return multiplicativeExpression106 = null;


        Object char_literal104_tree=null;
        Object char_literal105_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "additiveExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(318, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:319:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:319:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(319,9);
            pushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1243);
            multiplicativeExpression103=multiplicativeExpression();

            state._fsp--;

            adaptor.addChild(root_0, multiplicativeExpression103.getTree());
            dbg.location(319,34);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:319:34: ( ( '+' | '-' ) multiplicativeExpression )*
            try { dbg.enterSubRule(26);

            loop26:
            do {
                int alt26=2;
                try { dbg.enterDecision(26);

                int LA26_0 = input.LA(1);

                if ( ((LA26_0>=73 && LA26_0<=74)) ) {
                    alt26=1;
                }


                } finally {dbg.exitDecision(26);}

                switch (alt26) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:319:35: ( '+' | '-' ) multiplicativeExpression
            	    {
            	    dbg.location(319,35);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:319:35: ( '+' | '-' )
            	    int alt25=2;
            	    try { dbg.enterSubRule(25);
            	    try { dbg.enterDecision(25);

            	    int LA25_0 = input.LA(1);

            	    if ( (LA25_0==73) ) {
            	        alt25=1;
            	    }
            	    else if ( (LA25_0==74) ) {
            	        alt25=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 25, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }
            	    } finally {dbg.exitDecision(25);}

            	    switch (alt25) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:319:36: '+'
            	            {
            	            dbg.location(319,39);
            	            char_literal104=(Token)match(input,73,FOLLOW_73_in_additiveExpression1247); 
            	            char_literal104_tree = (Object)adaptor.create(char_literal104);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal104_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:319:41: '-'
            	            {
            	            dbg.location(319,44);
            	            char_literal105=(Token)match(input,74,FOLLOW_74_in_additiveExpression1250); 
            	            char_literal105_tree = (Object)adaptor.create(char_literal105);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal105_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(25);}

            	    dbg.location(319,47);
            	    pushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression1254);
            	    multiplicativeExpression106=multiplicativeExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, multiplicativeExpression106.getTree());

            	    }
            	    break;

            	default :
            	    break loop26;
                }
            } while (true);
            } finally {dbg.exitSubRule(26);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(320, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "additiveExpression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "additiveExpression"

    public static class multiplicativeExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "multiplicativeExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:323:1: multiplicativeExpression : negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* ;
    public final SGLParser.multiplicativeExpression_return multiplicativeExpression() throws RecognitionException {
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal108=null;
        Token char_literal109=null;
        Token char_literal110=null;
        SGLParser.negativeExpression_return negativeExpression107 = null;

        SGLParser.negativeExpression_return negativeExpression111 = null;


        Object char_literal108_tree=null;
        Object char_literal109_tree=null;
        Object char_literal110_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "multiplicativeExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(323, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:324:5: ( negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:324:9: negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(324,9);
            pushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression1288);
            negativeExpression107=negativeExpression();

            state._fsp--;

            adaptor.addChild(root_0, negativeExpression107.getTree());
            dbg.location(325,5);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:325:5: ( ( '*' | '/' | '%' ) negativeExpression )*
            try { dbg.enterSubRule(28);

            loop28:
            do {
                int alt28=2;
                try { dbg.enterDecision(28);

                int LA28_0 = input.LA(1);

                if ( ((LA28_0>=75 && LA28_0<=77)) ) {
                    alt28=1;
                }


                } finally {dbg.exitDecision(28);}

                switch (alt28) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:325:6: ( '*' | '/' | '%' ) negativeExpression
            	    {
            	    dbg.location(325,6);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:325:6: ( '*' | '/' | '%' )
            	    int alt27=3;
            	    try { dbg.enterSubRule(27);
            	    try { dbg.enterDecision(27);

            	    switch ( input.LA(1) ) {
            	    case 75:
            	        {
            	        alt27=1;
            	        }
            	        break;
            	    case 76:
            	        {
            	        alt27=2;
            	        }
            	        break;
            	    case 77:
            	        {
            	        alt27=3;
            	        }
            	        break;
            	    default:
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 27, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }

            	    } finally {dbg.exitDecision(27);}

            	    switch (alt27) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:325:7: '*'
            	            {
            	            dbg.location(325,10);
            	            char_literal108=(Token)match(input,75,FOLLOW_75_in_multiplicativeExpression1296); 
            	            char_literal108_tree = (Object)adaptor.create(char_literal108);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal108_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:325:12: '/'
            	            {
            	            dbg.location(325,15);
            	            char_literal109=(Token)match(input,76,FOLLOW_76_in_multiplicativeExpression1299); 
            	            char_literal109_tree = (Object)adaptor.create(char_literal109);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal109_tree, root_0);


            	            }
            	            break;
            	        case 3 :
            	            dbg.enterAlt(3);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:325:17: '%'
            	            {
            	            dbg.location(325,20);
            	            char_literal110=(Token)match(input,77,FOLLOW_77_in_multiplicativeExpression1302); 
            	            char_literal110_tree = (Object)adaptor.create(char_literal110);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal110_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(27);}

            	    dbg.location(325,23);
            	    pushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression1306);
            	    negativeExpression111=negativeExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, negativeExpression111.getTree());

            	    }
            	    break;

            	default :
            	    break loop28;
                }
            } while (true);
            } finally {dbg.exitSubRule(28);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(326, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "multiplicativeExpression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "multiplicativeExpression"

    public static class unaryExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "unaryExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:328:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public final SGLParser.unaryExpression_return unaryExpression() throws RecognitionException {
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal112=null;
        Token string_literal114=null;
        SGLParser.unaryExpression_return unaryExpression113 = null;

        SGLParser.unaryExpression_return unaryExpression115 = null;

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus116 = null;


        Object string_literal112_tree=null;
        Object string_literal114_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unaryExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(328, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:329:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt29=3;
            try { dbg.enterDecision(29);

            switch ( input.LA(1) ) {
            case 78:
                {
                alt29=1;
                }
                break;
            case 79:
                {
                alt29=2;
                }
                break;
            case Identifier:
                {
                alt29=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 29, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(29);}

            switch (alt29) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:329:7: '++' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(329,7);
                    string_literal112=(Token)match(input,78,FOLLOW_78_in_unaryExpression1329); 
                    string_literal112_tree = (Object)adaptor.create(string_literal112);
                    adaptor.addChild(root_0, string_literal112_tree);

                    dbg.location(329,12);
                    pushFollow(FOLLOW_unaryExpression_in_unaryExpression1331);
                    unaryExpression113=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression113.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:330:9: '--' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(330,9);
                    string_literal114=(Token)match(input,79,FOLLOW_79_in_unaryExpression1341); 
                    string_literal114_tree = (Object)adaptor.create(string_literal114);
                    adaptor.addChild(root_0, string_literal114_tree);

                    dbg.location(330,14);
                    pushFollow(FOLLOW_unaryExpression_in_unaryExpression1343);
                    unaryExpression115=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression115.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:331:9: unaryExpressionNotPlusMinus
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(331,9);
                    pushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1353);
                    unaryExpressionNotPlusMinus116=unaryExpressionNotPlusMinus();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpressionNotPlusMinus116.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(332, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "unaryExpression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "unaryExpression"

    public static class unaryExpressionNotPlusMinus_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "unaryExpressionNotPlusMinus"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:335:1: unaryExpressionNotPlusMinus : Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) ;
    public final SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() throws RecognitionException {
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token Identifier117=null;
        Token string_literal118=null;
        Token string_literal119=null;

        Object Identifier117_tree=null;
        Object string_literal118_tree=null;
        Object string_literal119_tree=null;
        RewriteRuleTokenStream stream_79=new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_78=new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_Identifier=new RewriteRuleTokenStream(adaptor,"token Identifier");

        try { dbg.enterRule(getGrammarFileName(), "unaryExpressionNotPlusMinus");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(335, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:336:5: ( Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:336:9: Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            {
            dbg.location(336,9);
            Identifier117=(Token)match(input,Identifier,FOLLOW_Identifier_in_unaryExpressionNotPlusMinus1374);  
            stream_Identifier.add(Identifier117);

            dbg.location(336,20);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:336:20: ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            int alt30=2;
            try { dbg.enterSubRule(30);
            try { dbg.enterDecision(30);

            int LA30_0 = input.LA(1);

            if ( (LA30_0==78) ) {
                alt30=1;
            }
            else if ( (LA30_0==79) ) {
                alt30=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 30, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(30);}

            switch (alt30) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:336:21: '++'
                    {
                    dbg.location(336,21);
                    string_literal118=(Token)match(input,78,FOLLOW_78_in_unaryExpressionNotPlusMinus1377);  
                    stream_78.add(string_literal118);



                    // AST REWRITE
                    // elements: Identifier
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 336:26: -> ^( VARINC Identifier )
                    {
                        dbg.location(336,29);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:336:29: ^( VARINC Identifier )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(336,31);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(VARINC, "VARINC"), root_1);

                        dbg.location(336,38);
                        adaptor.addChild(root_1, stream_Identifier.nextNode());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:337:4: '--'
                    {
                    dbg.location(337,4);
                    string_literal119=(Token)match(input,79,FOLLOW_79_in_unaryExpressionNotPlusMinus1390);  
                    stream_79.add(string_literal119);



                    // AST REWRITE
                    // elements: Identifier
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 337:9: -> ^( VARDEC Identifier )
                    {
                        dbg.location(337,12);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:337:12: ^( VARDEC Identifier )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(337,14);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(VARDEC, "VARDEC"), root_1);

                        dbg.location(337,21);
                        adaptor.addChild(root_1, stream_Identifier.nextNode());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            } finally {dbg.exitSubRule(30);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(339, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "unaryExpressionNotPlusMinus");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "unaryExpressionNotPlusMinus"

    public static class castExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "castExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:342:1: castExpression : '(' variableType ')' unaryExpression ;
    public final SGLParser.castExpression_return castExpression() throws RecognitionException {
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal120=null;
        Token char_literal122=null;
        SGLParser.variableType_return variableType121 = null;

        SGLParser.unaryExpression_return unaryExpression123 = null;


        Object char_literal120_tree=null;
        Object char_literal122_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "castExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(342, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:343:5: ( '(' variableType ')' unaryExpression )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:343:8: '(' variableType ')' unaryExpression
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(343,8);
            char_literal120=(Token)match(input,50,FOLLOW_50_in_castExpression1427); 
            char_literal120_tree = (Object)adaptor.create(char_literal120);
            adaptor.addChild(root_0, char_literal120_tree);

            dbg.location(343,12);
            pushFollow(FOLLOW_variableType_in_castExpression1429);
            variableType121=variableType();

            state._fsp--;

            adaptor.addChild(root_0, variableType121.getTree());
            dbg.location(343,25);
            char_literal122=(Token)match(input,51,FOLLOW_51_in_castExpression1431); 
            char_literal122_tree = (Object)adaptor.create(char_literal122);
            adaptor.addChild(root_0, char_literal122_tree);

            dbg.location(343,29);
            pushFollow(FOLLOW_unaryExpression_in_castExpression1433);
            unaryExpression123=unaryExpression();

            state._fsp--;

            adaptor.addChild(root_0, unaryExpression123.getTree());

            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(344, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "castExpression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "castExpression"

    public static class negativeExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "negativeExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:348:1: negativeExpression : ( mathAtom | '-' mathAtom -> ^( NEGATE mathAtom ) | unaryExpressionNotPlusMinus );
    public final SGLParser.negativeExpression_return negativeExpression() throws RecognitionException {
        SGLParser.negativeExpression_return retval = new SGLParser.negativeExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal125=null;
        SGLParser.mathAtom_return mathAtom124 = null;

        SGLParser.mathAtom_return mathAtom126 = null;

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus127 = null;


        Object char_literal125_tree=null;
        RewriteRuleTokenStream stream_74=new RewriteRuleTokenStream(adaptor,"token 74");
        RewriteRuleSubtreeStream stream_mathAtom=new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try { dbg.enterRule(getGrammarFileName(), "negativeExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(348, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:349:2: ( mathAtom | '-' mathAtom -> ^( NEGATE mathAtom ) | unaryExpressionNotPlusMinus )
            int alt31=3;
            try { dbg.enterDecision(31);

            switch ( input.LA(1) ) {
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case Layer:
            case Origin:
            case StringAtom:
            case 50:
            case 80:
                {
                alt31=1;
                }
                break;
            case Identifier:
                {
                int LA31_2 = input.LA(2);

                if ( ((LA31_2>=Identifier && LA31_2<=ObjectType)||LA31_2==47||(LA31_2>=50 && LA31_2<=51)||(LA31_2>=53 && LA31_2<=54)||(LA31_2>=61 && LA31_2<=77)) ) {
                    alt31=1;
                }
                else if ( ((LA31_2>=78 && LA31_2<=79)) ) {
                    alt31=3;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 31, 2, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
                }
                break;
            case 74:
                {
                alt31=2;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 31, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(31);}

            switch (alt31) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:349:4: mathAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(349,4);
                    pushFollow(FOLLOW_mathAtom_in_negativeExpression1451);
                    mathAtom124=mathAtom();

                    state._fsp--;

                    adaptor.addChild(root_0, mathAtom124.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:350:4: '-' mathAtom
                    {
                    dbg.location(350,4);
                    char_literal125=(Token)match(input,74,FOLLOW_74_in_negativeExpression1456);  
                    stream_74.add(char_literal125);

                    dbg.location(350,8);
                    pushFollow(FOLLOW_mathAtom_in_negativeExpression1458);
                    mathAtom126=mathAtom();

                    state._fsp--;

                    stream_mathAtom.add(mathAtom126.getTree());


                    // AST REWRITE
                    // elements: mathAtom
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 350:17: -> ^( NEGATE mathAtom )
                    {
                        dbg.location(350,20);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:350:20: ^( NEGATE mathAtom )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(350,22);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(NEGATE, "NEGATE"), root_1);

                        dbg.location(350,29);
                        adaptor.addChild(root_1, stream_mathAtom.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:351:4: unaryExpressionNotPlusMinus
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(351,4);
                    pushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_negativeExpression1471);
                    unaryExpressionNotPlusMinus127=unaryExpressionNotPlusMinus();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpressionNotPlusMinus127.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(352, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "negativeExpression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "negativeExpression"

    public static class mathAtom_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "mathAtom"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:354:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' Sprite '(' ( arguments )? ')' -> ^( Sprite ( arguments )? ) | 'new' Animation '(' ( arguments )? ')' -> ^( Animation ( arguments )? ) | Identifier | methodCall | stringQuote | Layer -> ^( STRINGNOQUOTES Layer ) | Origin -> ^( STRINGNOQUOTES Origin ) );
    public final SGLParser.mathAtom_return mathAtom() throws RecognitionException {
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal128=null;
        Token char_literal130=null;
        Token IntegerAtom131=null;
        Token FloatAtom132=null;
        Token BooleanAtom133=null;
        Token string_literal134=null;
        Token Sprite135=null;
        Token char_literal136=null;
        Token char_literal138=null;
        Token string_literal139=null;
        Token Animation140=null;
        Token char_literal141=null;
        Token char_literal143=null;
        Token Identifier144=null;
        Token Layer147=null;
        Token Origin148=null;
        SGLParser.conditionalExpression_return conditionalExpression129 = null;

        SGLParser.arguments_return arguments137 = null;

        SGLParser.arguments_return arguments142 = null;

        SGLParser.methodCall_return methodCall145 = null;

        SGLParser.stringQuote_return stringQuote146 = null;


        Object char_literal128_tree=null;
        Object char_literal130_tree=null;
        Object IntegerAtom131_tree=null;
        Object FloatAtom132_tree=null;
        Object BooleanAtom133_tree=null;
        Object string_literal134_tree=null;
        Object Sprite135_tree=null;
        Object char_literal136_tree=null;
        Object char_literal138_tree=null;
        Object string_literal139_tree=null;
        Object Animation140_tree=null;
        Object char_literal141_tree=null;
        Object char_literal143_tree=null;
        Object Identifier144_tree=null;
        Object Layer147_tree=null;
        Object Origin148_tree=null;
        RewriteRuleTokenStream stream_Layer=new RewriteRuleTokenStream(adaptor,"token Layer");
        RewriteRuleTokenStream stream_Animation=new RewriteRuleTokenStream(adaptor,"token Animation");
        RewriteRuleTokenStream stream_51=new RewriteRuleTokenStream(adaptor,"token 51");
        RewriteRuleTokenStream stream_80=new RewriteRuleTokenStream(adaptor,"token 80");
        RewriteRuleTokenStream stream_Origin=new RewriteRuleTokenStream(adaptor,"token Origin");
        RewriteRuleTokenStream stream_Sprite=new RewriteRuleTokenStream(adaptor,"token Sprite");
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_arguments=new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try { dbg.enterRule(getGrammarFileName(), "mathAtom");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(354, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:355:5: ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' Sprite '(' ( arguments )? ')' -> ^( Sprite ( arguments )? ) | 'new' Animation '(' ( arguments )? ')' -> ^( Animation ( arguments )? ) | Identifier | methodCall | stringQuote | Layer -> ^( STRINGNOQUOTES Layer ) | Origin -> ^( STRINGNOQUOTES Origin ) )
            int alt34=11;
            try { dbg.enterDecision(34);

            try {
                isCyclicDecision = true;
                alt34 = dfa34.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(34);}

            switch (alt34) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:355:7: '(' conditionalExpression ')'
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(355,10);
                    char_literal128=(Token)match(input,50,FOLLOW_50_in_mathAtom1485); 
                    dbg.location(355,12);
                    pushFollow(FOLLOW_conditionalExpression_in_mathAtom1488);
                    conditionalExpression129=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression129.getTree());
                    dbg.location(355,37);
                    char_literal130=(Token)match(input,51,FOLLOW_51_in_mathAtom1490); 

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:356:9: IntegerAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(356,9);
                    IntegerAtom131=(Token)match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom1501); 
                    IntegerAtom131_tree = (Object)adaptor.create(IntegerAtom131);
                    adaptor.addChild(root_0, IntegerAtom131_tree);


                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:357:7: FloatAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(357,7);
                    FloatAtom132=(Token)match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1509); 
                    FloatAtom132_tree = (Object)adaptor.create(FloatAtom132);
                    adaptor.addChild(root_0, FloatAtom132_tree);


                    }
                    break;
                case 4 :
                    dbg.enterAlt(4);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:358:9: BooleanAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(358,9);
                    BooleanAtom133=(Token)match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1519); 
                    BooleanAtom133_tree = (Object)adaptor.create(BooleanAtom133);
                    adaptor.addChild(root_0, BooleanAtom133_tree);


                    }
                    break;
                case 5 :
                    dbg.enterAlt(5);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:360:9: 'new' Sprite '(' ( arguments )? ')'
                    {
                    dbg.location(360,9);
                    string_literal134=(Token)match(input,80,FOLLOW_80_in_mathAtom1530);  
                    stream_80.add(string_literal134);

                    dbg.location(360,15);
                    Sprite135=(Token)match(input,Sprite,FOLLOW_Sprite_in_mathAtom1532);  
                    stream_Sprite.add(Sprite135);

                    dbg.location(360,22);
                    char_literal136=(Token)match(input,50,FOLLOW_50_in_mathAtom1534);  
                    stream_50.add(char_literal136);

                    dbg.location(360,26);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:360:26: ( arguments )?
                    int alt32=2;
                    try { dbg.enterSubRule(32);
                    try { dbg.enterDecision(32);

                    int LA32_0 = input.LA(1);

                    if ( (LA32_0==Identifier||(LA32_0>=IntegerAtom && LA32_0<=BooleanAtom)||(LA32_0>=Layer && LA32_0<=StringAtom)||LA32_0==50||LA32_0==74||LA32_0==80) ) {
                        alt32=1;
                    }
                    } finally {dbg.exitDecision(32);}

                    switch (alt32) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:360:26: arguments
                            {
                            dbg.location(360,26);
                            pushFollow(FOLLOW_arguments_in_mathAtom1536);
                            arguments137=arguments();

                            state._fsp--;

                            stream_arguments.add(arguments137.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(32);}

                    dbg.location(360,37);
                    char_literal138=(Token)match(input,51,FOLLOW_51_in_mathAtom1539);  
                    stream_51.add(char_literal138);



                    // AST REWRITE
                    // elements: Sprite, arguments
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 360:41: -> ^( Sprite ( arguments )? )
                    {
                        dbg.location(360,44);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:360:44: ^( Sprite ( arguments )? )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(360,46);
                        root_1 = (Object)adaptor.becomeRoot(stream_Sprite.nextNode(), root_1);

                        dbg.location(360,53);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:360:53: ( arguments )?
                        if ( stream_arguments.hasNext() ) {
                            dbg.location(360,53);
                            adaptor.addChild(root_1, stream_arguments.nextTree());

                        }
                        stream_arguments.reset();

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 6 :
                    dbg.enterAlt(6);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:361:9: 'new' Animation '(' ( arguments )? ')'
                    {
                    dbg.location(361,9);
                    string_literal139=(Token)match(input,80,FOLLOW_80_in_mathAtom1558);  
                    stream_80.add(string_literal139);

                    dbg.location(361,15);
                    Animation140=(Token)match(input,Animation,FOLLOW_Animation_in_mathAtom1560);  
                    stream_Animation.add(Animation140);

                    dbg.location(361,25);
                    char_literal141=(Token)match(input,50,FOLLOW_50_in_mathAtom1562);  
                    stream_50.add(char_literal141);

                    dbg.location(361,29);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:361:29: ( arguments )?
                    int alt33=2;
                    try { dbg.enterSubRule(33);
                    try { dbg.enterDecision(33);

                    int LA33_0 = input.LA(1);

                    if ( (LA33_0==Identifier||(LA33_0>=IntegerAtom && LA33_0<=BooleanAtom)||(LA33_0>=Layer && LA33_0<=StringAtom)||LA33_0==50||LA33_0==74||LA33_0==80) ) {
                        alt33=1;
                    }
                    } finally {dbg.exitDecision(33);}

                    switch (alt33) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:361:29: arguments
                            {
                            dbg.location(361,29);
                            pushFollow(FOLLOW_arguments_in_mathAtom1564);
                            arguments142=arguments();

                            state._fsp--;

                            stream_arguments.add(arguments142.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(33);}

                    dbg.location(361,40);
                    char_literal143=(Token)match(input,51,FOLLOW_51_in_mathAtom1567);  
                    stream_51.add(char_literal143);



                    // AST REWRITE
                    // elements: Animation, arguments
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 361:44: -> ^( Animation ( arguments )? )
                    {
                        dbg.location(361,47);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:361:47: ^( Animation ( arguments )? )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(361,49);
                        root_1 = (Object)adaptor.becomeRoot(stream_Animation.nextNode(), root_1);

                        dbg.location(361,59);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:361:59: ( arguments )?
                        if ( stream_arguments.hasNext() ) {
                            dbg.location(361,59);
                            adaptor.addChild(root_1, stream_arguments.nextTree());

                        }
                        stream_arguments.reset();

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 7 :
                    dbg.enterAlt(7);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:363:4: Identifier
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(363,4);
                    Identifier144=(Token)match(input,Identifier,FOLLOW_Identifier_in_mathAtom1583); 
                    Identifier144_tree = (Object)adaptor.create(Identifier144);
                    adaptor.addChild(root_0, Identifier144_tree);


                    }
                    break;
                case 8 :
                    dbg.enterAlt(8);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:364:4: methodCall
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(364,4);
                    pushFollow(FOLLOW_methodCall_in_mathAtom1588);
                    methodCall145=methodCall();

                    state._fsp--;

                    adaptor.addChild(root_0, methodCall145.getTree());

                    }
                    break;
                case 9 :
                    dbg.enterAlt(9);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:365:4: stringQuote
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(365,4);
                    pushFollow(FOLLOW_stringQuote_in_mathAtom1593);
                    stringQuote146=stringQuote();

                    state._fsp--;

                    adaptor.addChild(root_0, stringQuote146.getTree());

                    }
                    break;
                case 10 :
                    dbg.enterAlt(10);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:366:4: Layer
                    {
                    dbg.location(366,4);
                    Layer147=(Token)match(input,Layer,FOLLOW_Layer_in_mathAtom1598);  
                    stream_Layer.add(Layer147);



                    // AST REWRITE
                    // elements: Layer
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 366:10: -> ^( STRINGNOQUOTES Layer )
                    {
                        dbg.location(366,13);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:366:13: ^( STRINGNOQUOTES Layer )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(366,15);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(STRINGNOQUOTES, "STRINGNOQUOTES"), root_1);

                        dbg.location(366,30);
                        adaptor.addChild(root_1, stream_Layer.nextNode());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 11 :
                    dbg.enterAlt(11);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:367:4: Origin
                    {
                    dbg.location(367,4);
                    Origin148=(Token)match(input,Origin,FOLLOW_Origin_in_mathAtom1611);  
                    stream_Origin.add(Origin148);



                    // AST REWRITE
                    // elements: Origin
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 367:11: -> ^( STRINGNOQUOTES Origin )
                    {
                        dbg.location(367,14);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:367:14: ^( STRINGNOQUOTES Origin )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(367,16);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(STRINGNOQUOTES, "STRINGNOQUOTES"), root_1);

                        dbg.location(367,31);
                        adaptor.addChild(root_1, stream_Origin.nextNode());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(368, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "mathAtom");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "mathAtom"

    public static class variableUnaryChange_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableUnaryChange"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:370:1: variableUnaryChange : Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) ;
    public final SGLParser.variableUnaryChange_return variableUnaryChange() throws RecognitionException {
        SGLParser.variableUnaryChange_return retval = new SGLParser.variableUnaryChange_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token Identifier149=null;
        Token string_literal150=null;
        Token string_literal151=null;

        Object Identifier149_tree=null;
        Object string_literal150_tree=null;
        Object string_literal151_tree=null;
        RewriteRuleTokenStream stream_79=new RewriteRuleTokenStream(adaptor,"token 79");
        RewriteRuleTokenStream stream_78=new RewriteRuleTokenStream(adaptor,"token 78");
        RewriteRuleTokenStream stream_Identifier=new RewriteRuleTokenStream(adaptor,"token Identifier");

        try { dbg.enterRule(getGrammarFileName(), "variableUnaryChange");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(370, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:371:2: ( Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:371:4: Identifier ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            {
            dbg.location(371,4);
            Identifier149=(Token)match(input,Identifier,FOLLOW_Identifier_in_variableUnaryChange1639);  
            stream_Identifier.add(Identifier149);

            dbg.location(371,15);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:371:15: ( '++' -> ^( VARINC Identifier ) | '--' -> ^( VARDEC Identifier ) )
            int alt35=2;
            try { dbg.enterSubRule(35);
            try { dbg.enterDecision(35);

            int LA35_0 = input.LA(1);

            if ( (LA35_0==78) ) {
                alt35=1;
            }
            else if ( (LA35_0==79) ) {
                alt35=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 35, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(35);}

            switch (alt35) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:371:16: '++'
                    {
                    dbg.location(371,16);
                    string_literal150=(Token)match(input,78,FOLLOW_78_in_variableUnaryChange1642);  
                    stream_78.add(string_literal150);



                    // AST REWRITE
                    // elements: Identifier
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 371:21: -> ^( VARINC Identifier )
                    {
                        dbg.location(371,24);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:371:24: ^( VARINC Identifier )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(371,26);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(VARINC, "VARINC"), root_1);

                        dbg.location(371,33);
                        adaptor.addChild(root_1, stream_Identifier.nextNode());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:372:4: '--'
                    {
                    dbg.location(372,4);
                    string_literal151=(Token)match(input,79,FOLLOW_79_in_variableUnaryChange1655);  
                    stream_79.add(string_literal151);



                    // AST REWRITE
                    // elements: Identifier
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 372:9: -> ^( VARDEC Identifier )
                    {
                        dbg.location(372,12);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:372:12: ^( VARDEC Identifier )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(372,14);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(VARDEC, "VARDEC"), root_1);

                        dbg.location(372,21);
                        adaptor.addChild(root_1, stream_Identifier.nextNode());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            } finally {dbg.exitSubRule(35);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(373, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "variableUnaryChange");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "variableUnaryChange"

    public static class arguments_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "arguments"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:380:1: arguments : expressionList ;
    public final SGLParser.arguments_return arguments() throws RecognitionException {
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.expressionList_return expressionList152 = null;



        try { dbg.enterRule(getGrammarFileName(), "arguments");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(380, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:381:5: ( expressionList )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:381:10: expressionList
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(381,10);
            pushFollow(FOLLOW_expressionList_in_arguments1698);
            expressionList152=expressionList();

            state._fsp--;

            adaptor.addChild(root_0, expressionList152.getTree());

            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(382, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "arguments");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "arguments"

    public static class expressionList_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "expressionList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:384:1: expressionList : expression ( ',' expression )* ;
    public final SGLParser.expressionList_return expressionList() throws RecognitionException {
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal154=null;
        SGLParser.expression_return expression153 = null;

        SGLParser.expression_return expression155 = null;


        Object char_literal154_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "expressionList");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(384, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:385:5: ( expression ( ',' expression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:385:9: expression ( ',' expression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(385,9);
            pushFollow(FOLLOW_expression_in_expressionList1721);
            expression153=expression();

            state._fsp--;

            adaptor.addChild(root_0, expression153.getTree());
            dbg.location(385,20);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:385:20: ( ',' expression )*
            try { dbg.enterSubRule(36);

            loop36:
            do {
                int alt36=2;
                try { dbg.enterDecision(36);

                int LA36_0 = input.LA(1);

                if ( (LA36_0==54) ) {
                    alt36=1;
                }


                } finally {dbg.exitDecision(36);}

                switch (alt36) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:385:21: ',' expression
            	    {
            	    dbg.location(385,24);
            	    char_literal154=(Token)match(input,54,FOLLOW_54_in_expressionList1724); 
            	    dbg.location(385,26);
            	    pushFollow(FOLLOW_expression_in_expressionList1727);
            	    expression155=expression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, expression155.getTree());

            	    }
            	    break;

            	default :
            	    break loop36;
                }
            } while (true);
            } finally {dbg.exitSubRule(36);}


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(386, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "expressionList");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "expressionList"

    public static class paramList_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "paramList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:388:1: paramList : variableType variableName ( ',' variableType variableName )* -> ^( PARAM_TYPE_LIST ( variableType )+ ) ^( PARAM_NAME_LIST ( variableName )+ ) ;
    public final SGLParser.paramList_return paramList() throws RecognitionException {
        SGLParser.paramList_return retval = new SGLParser.paramList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal158=null;
        SGLParser.variableType_return variableType156 = null;

        SGLParser.variableName_return variableName157 = null;

        SGLParser.variableType_return variableType159 = null;

        SGLParser.variableName_return variableName160 = null;


        Object char_literal158_tree=null;
        RewriteRuleTokenStream stream_54=new RewriteRuleTokenStream(adaptor,"token 54");
        RewriteRuleSubtreeStream stream_variableType=new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableName=new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try { dbg.enterRule(getGrammarFileName(), "paramList");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(388, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:389:3: ( variableType variableName ( ',' variableType variableName )* -> ^( PARAM_TYPE_LIST ( variableType )+ ) ^( PARAM_NAME_LIST ( variableName )+ ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:389:6: variableType variableName ( ',' variableType variableName )*
            {
            dbg.location(389,6);
            pushFollow(FOLLOW_variableType_in_paramList1745);
            variableType156=variableType();

            state._fsp--;

            stream_variableType.add(variableType156.getTree());
            dbg.location(389,19);
            pushFollow(FOLLOW_variableName_in_paramList1747);
            variableName157=variableName();

            state._fsp--;

            stream_variableName.add(variableName157.getTree());
            dbg.location(389,32);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:389:32: ( ',' variableType variableName )*
            try { dbg.enterSubRule(37);

            loop37:
            do {
                int alt37=2;
                try { dbg.enterDecision(37);

                int LA37_0 = input.LA(1);

                if ( (LA37_0==54) ) {
                    alt37=1;
                }


                } finally {dbg.exitDecision(37);}

                switch (alt37) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:389:33: ',' variableType variableName
            	    {
            	    dbg.location(389,33);
            	    char_literal158=(Token)match(input,54,FOLLOW_54_in_paramList1750);  
            	    stream_54.add(char_literal158);

            	    dbg.location(389,37);
            	    pushFollow(FOLLOW_variableType_in_paramList1752);
            	    variableType159=variableType();

            	    state._fsp--;

            	    stream_variableType.add(variableType159.getTree());
            	    dbg.location(389,50);
            	    pushFollow(FOLLOW_variableName_in_paramList1754);
            	    variableName160=variableName();

            	    state._fsp--;

            	    stream_variableName.add(variableName160.getTree());

            	    }
            	    break;

            	default :
            	    break loop37;
                }
            } while (true);
            } finally {dbg.exitSubRule(37);}



            // AST REWRITE
            // elements: variableName, variableType
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 389:65: -> ^( PARAM_TYPE_LIST ( variableType )+ ) ^( PARAM_NAME_LIST ( variableName )+ )
            {
                dbg.location(389,68);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:389:68: ^( PARAM_TYPE_LIST ( variableType )+ )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(389,70);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(PARAM_TYPE_LIST, "PARAM_TYPE_LIST"), root_1);

                dbg.location(389,86);
                if ( !(stream_variableType.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_variableType.hasNext() ) {
                    dbg.location(389,86);
                    adaptor.addChild(root_1, stream_variableType.nextTree());

                }
                stream_variableType.reset();

                adaptor.addChild(root_0, root_1);
                }
                dbg.location(389,101);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:389:101: ^( PARAM_NAME_LIST ( variableName )+ )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(389,103);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(PARAM_NAME_LIST, "PARAM_NAME_LIST"), root_1);

                dbg.location(389,119);
                if ( !(stream_variableName.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_variableName.hasNext() ) {
                    dbg.location(389,119);
                    adaptor.addChild(root_1, stream_variableName.nextTree());

                }
                stream_variableName.reset();

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(390, 3);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "paramList");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "paramList"

    public static class literal_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "literal"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:392:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public final SGLParser.literal_return literal() throws RecognitionException {
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set161=null;

        Object set161_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "literal");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(392, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:393:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(393,5);
            set161=(Token)input.LT(1);
            if ( (input.LA(1)>=IntegerAtom && input.LA(1)<=BooleanAtom)||input.LA(1)==StringAtom||input.LA(1)==81 ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set161));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                dbg.recognitionException(mse);
                throw mse;
            }


            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(398, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "literal");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "literal"

    public static class stringQuote_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "stringQuote"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:401:1: stringQuote : StringAtom -> ^( STRING StringAtom ) ;
    public final SGLParser.stringQuote_return stringQuote() throws RecognitionException {
        SGLParser.stringQuote_return retval = new SGLParser.stringQuote_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token StringAtom162=null;

        Object StringAtom162_tree=null;
        RewriteRuleTokenStream stream_StringAtom=new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try { dbg.enterRule(getGrammarFileName(), "stringQuote");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(401, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:402:2: ( StringAtom -> ^( STRING StringAtom ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:402:6: StringAtom
            {
            dbg.location(402,6);
            StringAtom162=(Token)match(input,StringAtom,FOLLOW_StringAtom_in_stringQuote1865);  
            stream_StringAtom.add(StringAtom162);



            // AST REWRITE
            // elements: StringAtom
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 402:17: -> ^( STRING StringAtom )
            {
                dbg.location(402,20);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:402:20: ^( STRING StringAtom )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(402,22);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(STRING, "STRING"), root_1);

                dbg.location(402,29);
                adaptor.addChild(root_1, stream_StringAtom.nextNode());

                adaptor.addChild(root_0, root_1);
                }

            }

            retval.tree = root_0;
            }

            retval.stop = input.LT(-1);

            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }
        finally {
        }
        dbg.location(403, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "stringQuote");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "stringQuote"

    // Delegated rules


    protected DFA34 dfa34 = new DFA34(this);
    static final String DFA34_eotS =
        "\16\uffff";
    static final String DFA34_eofS =
        "\16\uffff";
    static final String DFA34_minS =
        "\1\31\4\uffff\1\42\1\31\7\uffff";
    static final String DFA34_maxS =
        "\1\120\4\uffff\1\43\1\115\7\uffff";
    static final String DFA34_acceptS =
        "\1\uffff\1\1\1\2\1\3\1\4\2\uffff\1\11\1\12\1\13\1\5\1\6\1\10\1"+
        "\7";
    static final String DFA34_specialS =
        "\16\uffff}>";
    static final String[] DFA34_transitionS = {
            "\1\6\5\uffff\1\2\1\3\1\4\2\uffff\1\10\1\11\1\7\13\uffff\1\1"+
            "\35\uffff\1\5",
            "",
            "",
            "",
            "",
            "\1\12\1\13",
            "\6\15\20\uffff\1\15\2\uffff\1\14\1\15\1\uffff\2\15\6\uffff"+
            "\21\15",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static final short[] DFA34_eot = DFA.unpackEncodedString(DFA34_eotS);
    static final short[] DFA34_eof = DFA.unpackEncodedString(DFA34_eofS);
    static final char[] DFA34_min = DFA.unpackEncodedStringToUnsignedChars(DFA34_minS);
    static final char[] DFA34_max = DFA.unpackEncodedStringToUnsignedChars(DFA34_maxS);
    static final short[] DFA34_accept = DFA.unpackEncodedString(DFA34_acceptS);
    static final short[] DFA34_special = DFA.unpackEncodedString(DFA34_specialS);
    static final short[][] DFA34_transition;

    static {
        int numStates = DFA34_transitionS.length;
        DFA34_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA34_transition[i] = DFA.unpackEncodedString(DFA34_transitionS[i]);
        }
    }

    class DFA34 extends DFA {

        public DFA34(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 34;
            this.eot = DFA34_eot;
            this.eof = DFA34_eof;
            this.min = DFA34_min;
            this.max = DFA34_max;
            this.accept = DFA34_accept;
            this.special = DFA34_special;
            this.transition = DFA34_transition;
        }
        public String getDescription() {
            return "354:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' Sprite '(' ( arguments )? ')' -> ^( Sprite ( arguments )? ) | 'new' Animation '(' ( arguments )? ')' -> ^( Animation ( arguments )? ) | Identifier | methodCall | stringQuote | Layer -> ^( STRINGNOQUOTES Layer ) | Origin -> ^( STRINGNOQUOTES Origin ) );";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
 

    public static final BitSet FOLLOW_mainBlock_in_compilationUnit156 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mainStatement_in_mainBlock169 = new BitSet(new long[]{0x6E0200007E000002L});
    public static final BitSet FOLLOW_methodDef_in_mainBlock173 = new BitSet(new long[]{0x6E0200007E000002L});
    public static final BitSet FOLLOW_statement_in_block221 = new BitSet(new long[]{0x6E0000007E000002L});
    public static final BitSet FOLLOW_semicolonStatement_in_singleBlock249 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_singleBlock_in_commonBlock275 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_47_in_commonBlock280 = new BitSet(new long[]{0x6E0100007E000000L});
    public static final BitSet FOLLOW_block_in_commonBlock283 = new BitSet(new long[]{0x0001000000000000L});
    public static final BitSet FOLLOW_48_in_commonBlock285 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_49_in_methodDef315 = new BitSet(new long[]{0x001000007C000000L});
    public static final BitSet FOLLOW_methodType_in_methodDef317 = new BitSet(new long[]{0x0000000002000000L});
    public static final BitSet FOLLOW_Identifier_in_methodDef319 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_methodDef321 = new BitSet(new long[]{0x000800007C000000L});
    public static final BitSet FOLLOW_paramList_in_methodDef323 = new BitSet(new long[]{0x0008000000000000L});
    public static final BitSet FOLLOW_51_in_methodDef326 = new BitSet(new long[]{0x600080007E000000L});
    public static final BitSet FOLLOW_commonBlock_in_methodDef328 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableType_in_methodType348 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_52_in_methodType353 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_statement_in_mainStatement377 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableDeclarationList_in_semicolonStatement390 = new BitSet(new long[]{0x0020000000000000L});
    public static final BitSet FOLLOW_variableAssignment_in_semicolonStatement396 = new BitSet(new long[]{0x0020000000000000L});
    public static final BitSet FOLLOW_variableUnaryChange_in_semicolonStatement402 = new BitSet(new long[]{0x0020000000000000L});
    public static final BitSet FOLLOW_methodCall_in_semicolonStatement408 = new BitSet(new long[]{0x0020000000000000L});
    public static final BitSet FOLLOW_objectMethod_in_semicolonStatement413 = new BitSet(new long[]{0x0020000000000000L});
    public static final BitSet FOLLOW_breakStat_in_semicolonStatement418 = new BitSet(new long[]{0x0020000000000000L});
    public static final BitSet FOLLOW_returnStat_in_semicolonStatement423 = new BitSet(new long[]{0x0020000000000000L});
    public static final BitSet FOLLOW_53_in_semicolonStatement428 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableDeclarationList_in_oneLineStatement441 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableAssignment_in_oneLineStatement446 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableUnaryChange_in_oneLineStatement451 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_semicolonStatement_in_statement467 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ifStatement_in_statement472 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_whileLoop_in_statement477 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_forLoop_in_statement482 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableType_in_variableDeclarationList498 = new BitSet(new long[]{0x0000000002000000L});
    public static final BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList500 = new BitSet(new long[]{0x0040000000000002L});
    public static final BitSet FOLLOW_54_in_variableDeclarationList503 = new BitSet(new long[]{0x0000000002000000L});
    public static final BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList505 = new BitSet(new long[]{0x0040000000000002L});
    public static final BitSet FOLLOW_variableName_in_variableDecAssignment529 = new BitSet(new long[]{0x0080000000000002L});
    public static final BitSet FOLLOW_55_in_variableDecAssignment532 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_expression_in_variableDecAssignment534 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableName_in_variableAssignment555 = new BitSet(new long[]{0x0080000000000000L});
    public static final BitSet FOLLOW_55_in_variableAssignment557 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_expression_in_variableAssignment559 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_variableName590 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_variableType0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableName_in_objectMethod634 = new BitSet(new long[]{0x0100000000000000L});
    public static final BitSet FOLLOW_56_in_objectMethod636 = new BitSet(new long[]{0x0000000002000000L});
    public static final BitSet FOLLOW_Identifier_in_objectMethod638 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_objectMethod640 = new BitSet(new long[]{0x000C007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_arguments_in_objectMethod642 = new BitSet(new long[]{0x0008000000000000L});
    public static final BitSet FOLLOW_51_in_objectMethod645 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_57_in_whileLoop669 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_expression_in_whileLoop671 = new BitSet(new long[]{0x600080007E000000L});
    public static final BitSet FOLLOW_commonBlock_in_whileLoop673 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_58_in_forLoop695 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_forLoop697 = new BitSet(new long[]{0x002000007E000000L});
    public static final BitSet FOLLOW_oneLineStatement_in_forLoop701 = new BitSet(new long[]{0x0020000000000000L});
    public static final BitSet FOLLOW_53_in_forLoop704 = new BitSet(new long[]{0x0024007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_expression_in_forLoop708 = new BitSet(new long[]{0x0020000000000000L});
    public static final BitSet FOLLOW_53_in_forLoop711 = new BitSet(new long[]{0x000800007E000000L});
    public static final BitSet FOLLOW_oneLineStatement_in_forLoop715 = new BitSet(new long[]{0x0008000000000000L});
    public static final BitSet FOLLOW_51_in_forLoop718 = new BitSet(new long[]{0x600080007E000000L});
    public static final BitSet FOLLOW_commonBlock_in_forLoop720 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ifStat_in_ifStatement765 = new BitSet(new long[]{0x1000000000000002L});
    public static final BitSet FOLLOW_elseIfStat_in_ifStatement767 = new BitSet(new long[]{0x1000000000000002L});
    public static final BitSet FOLLOW_elseStat_in_ifStatement770 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_59_in_ifStat795 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_expression_in_ifStat797 = new BitSet(new long[]{0x600080007E000000L});
    public static final BitSet FOLLOW_commonBlock_in_ifStat799 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_60_in_elseIfStat820 = new BitSet(new long[]{0x0800000000000000L});
    public static final BitSet FOLLOW_59_in_elseIfStat822 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_expression_in_elseIfStat824 = new BitSet(new long[]{0x600080007E000000L});
    public static final BitSet FOLLOW_commonBlock_in_elseIfStat826 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_60_in_elseStat848 = new BitSet(new long[]{0x600080007E000000L});
    public static final BitSet FOLLOW_commonBlock_in_elseStat850 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_61_in_breakStat875 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_62_in_returnStat890 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_expression_in_returnStat892 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_methodCall911 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_methodCall913 = new BitSet(new long[]{0x000C007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_expressionList_in_methodCall915 = new BitSet(new long[]{0x0008000000000000L});
    public static final BitSet FOLLOW_51_in_methodCall918 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalExpression_in_expression975 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression1016 = new BitSet(new long[]{0x8000000000000002L});
    public static final BitSet FOLLOW_63_in_conditionalExpression1020 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_conditionalExpression_in_conditionalExpression1023 = new BitSet(new long[]{0x0000000000000000L,0x0000000000000001L});
    public static final BitSet FOLLOW_64_in_conditionalExpression1025 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_conditionalExpression_in_conditionalExpression1028 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1071 = new BitSet(new long[]{0x0000000000000002L,0x0000000000000002L});
    public static final BitSet FOLLOW_65_in_conditionalOrExpression1075 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression1078 = new BitSet(new long[]{0x0000000000000002L,0x0000000000000002L});
    public static final BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1109 = new BitSet(new long[]{0x0000000000000002L,0x0000000000000004L});
    public static final BitSet FOLLOW_66_in_conditionalAndExpression1113 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_equalityExpression_in_conditionalAndExpression1116 = new BitSet(new long[]{0x0000000000000002L,0x0000000000000004L});
    public static final BitSet FOLLOW_relationalExpression_in_equalityExpression1143 = new BitSet(new long[]{0x0000000000000002L,0x0000000000000018L});
    public static final BitSet FOLLOW_67_in_equalityExpression1148 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_68_in_equalityExpression1153 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_relationalExpression_in_equalityExpression1157 = new BitSet(new long[]{0x0000000000000002L,0x0000000000000018L});
    public static final BitSet FOLLOW_additiveExpression_in_relationalExpression1188 = new BitSet(new long[]{0x0000000000000002L,0x00000000000001E0L});
    public static final BitSet FOLLOW_69_in_relationalExpression1192 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_70_in_relationalExpression1195 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_71_in_relationalExpression1198 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_72_in_relationalExpression1201 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_additiveExpression_in_relationalExpression1205 = new BitSet(new long[]{0x0000000000000002L,0x00000000000001E0L});
    public static final BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1243 = new BitSet(new long[]{0x0000000000000002L,0x0000000000000600L});
    public static final BitSet FOLLOW_73_in_additiveExpression1247 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_74_in_additiveExpression1250 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_multiplicativeExpression_in_additiveExpression1254 = new BitSet(new long[]{0x0000000000000002L,0x0000000000000600L});
    public static final BitSet FOLLOW_negativeExpression_in_multiplicativeExpression1288 = new BitSet(new long[]{0x0000000000000002L,0x0000000000003800L});
    public static final BitSet FOLLOW_75_in_multiplicativeExpression1296 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_76_in_multiplicativeExpression1299 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_77_in_multiplicativeExpression1302 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_negativeExpression_in_multiplicativeExpression1306 = new BitSet(new long[]{0x0000000000000002L,0x0000000000003800L});
    public static final BitSet FOLLOW_78_in_unaryExpression1329 = new BitSet(new long[]{0x0004007382000000L,0x000000000001C400L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpression1331 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_79_in_unaryExpression1341 = new BitSet(new long[]{0x0004007382000000L,0x000000000001C400L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpression1343 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1353 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_unaryExpressionNotPlusMinus1374 = new BitSet(new long[]{0x0000000000000000L,0x000000000000C000L});
    public static final BitSet FOLLOW_78_in_unaryExpressionNotPlusMinus1377 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_79_in_unaryExpressionNotPlusMinus1390 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_50_in_castExpression1427 = new BitSet(new long[]{0x000000007C000000L});
    public static final BitSet FOLLOW_variableType_in_castExpression1429 = new BitSet(new long[]{0x0008000000000000L});
    public static final BitSet FOLLOW_51_in_castExpression1431 = new BitSet(new long[]{0x0004007382000000L,0x000000000001C400L});
    public static final BitSet FOLLOW_unaryExpression_in_castExpression1433 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mathAtom_in_negativeExpression1451 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_74_in_negativeExpression1456 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010000L});
    public static final BitSet FOLLOW_mathAtom_in_negativeExpression1458 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_unaryExpressionNotPlusMinus_in_negativeExpression1471 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_50_in_mathAtom1485 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_conditionalExpression_in_mathAtom1488 = new BitSet(new long[]{0x0008000000000000L});
    public static final BitSet FOLLOW_51_in_mathAtom1490 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_IntegerAtom_in_mathAtom1501 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FloatAtom_in_mathAtom1509 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BooleanAtom_in_mathAtom1519 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_80_in_mathAtom1530 = new BitSet(new long[]{0x0000000400000000L});
    public static final BitSet FOLLOW_Sprite_in_mathAtom1532 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_mathAtom1534 = new BitSet(new long[]{0x000C007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_arguments_in_mathAtom1536 = new BitSet(new long[]{0x0008000000000000L});
    public static final BitSet FOLLOW_51_in_mathAtom1539 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_80_in_mathAtom1558 = new BitSet(new long[]{0x0000000800000000L});
    public static final BitSet FOLLOW_Animation_in_mathAtom1560 = new BitSet(new long[]{0x0004000000000000L});
    public static final BitSet FOLLOW_50_in_mathAtom1562 = new BitSet(new long[]{0x000C007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_arguments_in_mathAtom1564 = new BitSet(new long[]{0x0008000000000000L});
    public static final BitSet FOLLOW_51_in_mathAtom1567 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_mathAtom1583 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_methodCall_in_mathAtom1588 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_stringQuote_in_mathAtom1593 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Layer_in_mathAtom1598 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Origin_in_mathAtom1611 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_variableUnaryChange1639 = new BitSet(new long[]{0x0000000000000000L,0x000000000000C000L});
    public static final BitSet FOLLOW_78_in_variableUnaryChange1642 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_79_in_variableUnaryChange1655 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_expressionList_in_arguments1698 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_expression_in_expressionList1721 = new BitSet(new long[]{0x0040000000000002L});
    public static final BitSet FOLLOW_54_in_expressionList1724 = new BitSet(new long[]{0x0004007382000000L,0x0000000000010400L});
    public static final BitSet FOLLOW_expression_in_expressionList1727 = new BitSet(new long[]{0x0040000000000002L});
    public static final BitSet FOLLOW_variableType_in_paramList1745 = new BitSet(new long[]{0x0000000002000000L});
    public static final BitSet FOLLOW_variableName_in_paramList1747 = new BitSet(new long[]{0x0040000000000002L});
    public static final BitSet FOLLOW_54_in_paramList1750 = new BitSet(new long[]{0x000000007C000000L});
    public static final BitSet FOLLOW_variableType_in_paramList1752 = new BitSet(new long[]{0x0000000002000000L});
    public static final BitSet FOLLOW_variableName_in_paramList1754 = new BitSet(new long[]{0x0040000000000002L});
    public static final BitSet FOLLOW_set_in_literal0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_StringAtom_in_stringQuote1865 = new BitSet(new long[]{0x0000000000000002L});

}