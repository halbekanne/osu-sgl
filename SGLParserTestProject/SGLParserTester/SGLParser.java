// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g 2011-08-07 18:23:28

	//using SGLParserTester;


import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;

import org.antlr.runtime.tree.*;

public class SGLParser extends DebugParser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "VARDEF", "ASSIGN", "NEGATE", "LIBMETHOD", "STRING", "Identifier", "IntType", "BooleanType", "StringType", "FloatType", "ObjectType", "IntegerAtom", "FloatAtom", "BooleanAtom", "SpriteAnimation", "StringAtom", "EscapeSequence", "Letter", "SGLIDDigit", "UnicodeEscape", "OctalEscape", "HEX_DIGIT", "WS", "COMMENT", "','", "'='", "'while'", "'('", "')'", "'{'", "'}'", "'?'", "':'", "'||'", "'&&'", "'=='", "'!='", "'<'", "'>'", "'<='", "'>='", "'+'", "'-'", "'*'", "'/'", "'%'", "'++'", "'--'", "'!'", "'new'", "'null'"
    };
    public static final int T__29=29;
    public static final int T__28=28;
    public static final int SGLIDDigit=22;
    public static final int IntType=10;
    public static final int EOF=-1;
    public static final int Identifier=9;
    public static final int T__51=51;
    public static final int T__52=52;
    public static final int T__53=53;
    public static final int T__54=54;
    public static final int StringType=12;
    public static final int SpriteAnimation=18;
    public static final int COMMENT=27;
    public static final int VARDEF=4;
    public static final int T__50=50;
    public static final int BooleanType=11;
    public static final int T__42=42;
    public static final int T__43=43;
    public static final int T__40=40;
    public static final int T__41=41;
    public static final int T__46=46;
    public static final int T__47=47;
    public static final int T__44=44;
    public static final int T__45=45;
    public static final int T__48=48;
    public static final int T__49=49;
    public static final int LIBMETHOD=7;
    public static final int IntegerAtom=15;
    public static final int FloatType=13;
    public static final int StringAtom=19;
    public static final int HEX_DIGIT=25;
    public static final int NEGATE=6;
    public static final int BooleanAtom=17;
    public static final int T__30=30;
    public static final int T__31=31;
    public static final int T__32=32;
    public static final int WS=26;
    public static final int T__33=33;
    public static final int T__34=34;
    public static final int T__35=35;
    public static final int T__36=36;
    public static final int T__37=37;
    public static final int T__38=38;
    public static final int T__39=39;
    public static final int UnicodeEscape=23;
    public static final int ASSIGN=5;
    public static final int ObjectType=14;
    public static final int FloatAtom=16;
    public static final int OctalEscape=24;
    public static final int Letter=21;
    public static final int EscapeSequence=20;
    public static final int STRING=8;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "compilationUnit", "unaryExpressionNotPlusMinus", 
        "mathAtom", "literal", "whileLoop", "castExpression", "negativeExpression", 
        "variableAssignment", "mainStatement", "unaryExpression", "variableName", 
        "arguments", "relationalExpression", "expressionList", "block", 
        "variableType", "conditionalAndExpression", "stringQuote", "conditionalOrExpression", 
        "statement", "additiveExpression", "conditionalExpression", "equalityExpression", 
        "variableDeclarationList", "multiplicativeExpression", "expression"
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
    public String getGrammarFileName() { return "C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g"; }



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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:72:1: compilationUnit : ( mainStatement )+ EOF ;
    public final SGLParser.compilationUnit_return compilationUnit() throws RecognitionException {
        SGLParser.compilationUnit_return retval = new SGLParser.compilationUnit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token EOF2=null;
        SGLParser.mainStatement_return mainStatement1 = null;


        Object EOF2_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "compilationUnit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(72, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:2: ( ( mainStatement )+ EOF )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:4: ( mainStatement )+ EOF
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(73,4);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:4: ( mainStatement )+
            int cnt1=0;
            try { dbg.enterSubRule(1);

            loop1:
            do {
                int alt1=2;
                try { dbg.enterDecision(1);

                int LA1_0 = input.LA(1);

                if ( ((LA1_0>=Identifier && LA1_0<=ObjectType)||LA1_0==30) ) {
                    alt1=1;
                }


                } finally {dbg.exitDecision(1);}

                switch (alt1) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:4: mainStatement
            	    {
            	    dbg.location(73,4);
            	    pushFollow(FOLLOW_mainStatement_in_compilationUnit92);
            	    mainStatement1=mainStatement();

            	    state._fsp--;

            	    adaptor.addChild(root_0, mainStatement1.getTree());

            	    }
            	    break;

            	default :
            	    if ( cnt1 >= 1 ) break loop1;
                        EarlyExitException eee =
                            new EarlyExitException(1, input);
                        dbg.recognitionException(eee);

                        throw eee;
                }
                cnt1++;
            } while (true);
            } finally {dbg.exitSubRule(1);}

            dbg.location(73,19);
            EOF2=(Token)match(input,EOF,FOLLOW_EOF_in_compilationUnit95); 
            EOF2_tree = (Object)adaptor.create(EOF2);
            adaptor.addChild(root_0, EOF2_tree);


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
        dbg.location(74, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "compilationUnit");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "compilationUnit"

    public static class mainStatement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "mainStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:76:1: mainStatement : statement ;
    public final SGLParser.mainStatement_return mainStatement() throws RecognitionException {
        SGLParser.mainStatement_return retval = new SGLParser.mainStatement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.statement_return statement3 = null;



        try { dbg.enterRule(getGrammarFileName(), "mainStatement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(76, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:2: ( statement )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:4: statement
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(77,4);
            pushFollow(FOLLOW_statement_in_mainStatement107);
            statement3=statement();

            state._fsp--;

            adaptor.addChild(root_0, statement3.getTree());

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
        dbg.location(78, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "mainStatement");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "mainStatement"

    public static class statement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "statement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:81:1: statement : ( variableDeclarationList | variableAssignment -> ^( ASSIGN variableAssignment ) | whileLoop );
    public final SGLParser.statement_return statement() throws RecognitionException {
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.variableDeclarationList_return variableDeclarationList4 = null;

        SGLParser.variableAssignment_return variableAssignment5 = null;

        SGLParser.whileLoop_return whileLoop6 = null;


        RewriteRuleSubtreeStream stream_variableAssignment=new RewriteRuleSubtreeStream(adaptor,"rule variableAssignment");
        try { dbg.enterRule(getGrammarFileName(), "statement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(81, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:83:2: ( variableDeclarationList | variableAssignment -> ^( ASSIGN variableAssignment ) | whileLoop )
            int alt2=3;
            try { dbg.enterDecision(2);

            switch ( input.LA(1) ) {
            case IntType:
            case BooleanType:
            case StringType:
            case FloatType:
            case ObjectType:
                {
                alt2=1;
                }
                break;
            case Identifier:
                {
                alt2=2;
                }
                break;
            case 30:
                {
                alt2=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 2, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(2);}

            switch (alt2) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:83:4: variableDeclarationList
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(83,4);
                    pushFollow(FOLLOW_variableDeclarationList_in_statement122);
                    variableDeclarationList4=variableDeclarationList();

                    state._fsp--;

                    adaptor.addChild(root_0, variableDeclarationList4.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:84:4: variableAssignment
                    {
                    dbg.location(84,4);
                    pushFollow(FOLLOW_variableAssignment_in_statement128);
                    variableAssignment5=variableAssignment();

                    state._fsp--;

                    stream_variableAssignment.add(variableAssignment5.getTree());


                    // AST REWRITE
                    // elements: variableAssignment
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 84:23: -> ^( ASSIGN variableAssignment )
                    {
                        dbg.location(84,26);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:84:26: ^( ASSIGN variableAssignment )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(84,28);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(ASSIGN, "ASSIGN"), root_1);

                        dbg.location(84,35);
                        adaptor.addChild(root_1, stream_variableAssignment.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:4: whileLoop
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(85,4);
                    pushFollow(FOLLOW_whileLoop_in_statement141);
                    whileLoop6=whileLoop();

                    state._fsp--;

                    adaptor.addChild(root_0, whileLoop6.getTree());

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
        dbg.location(86, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:92:1: variableDeclarationList : variableType variableAssignment ( ',' variableAssignment )* -> ( ^( VARDEF variableType variableAssignment ) )+ ;
    public final SGLParser.variableDeclarationList_return variableDeclarationList() throws RecognitionException {
        SGLParser.variableDeclarationList_return retval = new SGLParser.variableDeclarationList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal9=null;
        SGLParser.variableType_return variableType7 = null;

        SGLParser.variableAssignment_return variableAssignment8 = null;

        SGLParser.variableAssignment_return variableAssignment10 = null;


        Object char_literal9_tree=null;
        RewriteRuleTokenStream stream_28=new RewriteRuleTokenStream(adaptor,"token 28");
        RewriteRuleSubtreeStream stream_variableType=new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableAssignment=new RewriteRuleSubtreeStream(adaptor,"rule variableAssignment");
        try { dbg.enterRule(getGrammarFileName(), "variableDeclarationList");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(92, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:93:2: ( variableType variableAssignment ( ',' variableAssignment )* -> ( ^( VARDEF variableType variableAssignment ) )+ )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:93:4: variableType variableAssignment ( ',' variableAssignment )*
            {
            dbg.location(93,4);
            pushFollow(FOLLOW_variableType_in_variableDeclarationList157);
            variableType7=variableType();

            state._fsp--;

            stream_variableType.add(variableType7.getTree());
            dbg.location(93,17);
            pushFollow(FOLLOW_variableAssignment_in_variableDeclarationList159);
            variableAssignment8=variableAssignment();

            state._fsp--;

            stream_variableAssignment.add(variableAssignment8.getTree());
            dbg.location(93,36);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:93:36: ( ',' variableAssignment )*
            try { dbg.enterSubRule(3);

            loop3:
            do {
                int alt3=2;
                try { dbg.enterDecision(3);

                int LA3_0 = input.LA(1);

                if ( (LA3_0==28) ) {
                    alt3=1;
                }


                } finally {dbg.exitDecision(3);}

                switch (alt3) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:93:37: ',' variableAssignment
            	    {
            	    dbg.location(93,37);
            	    char_literal9=(Token)match(input,28,FOLLOW_28_in_variableDeclarationList162);  
            	    stream_28.add(char_literal9);

            	    dbg.location(93,41);
            	    pushFollow(FOLLOW_variableAssignment_in_variableDeclarationList164);
            	    variableAssignment10=variableAssignment();

            	    state._fsp--;

            	    stream_variableAssignment.add(variableAssignment10.getTree());

            	    }
            	    break;

            	default :
            	    break loop3;
                }
            } while (true);
            } finally {dbg.exitSubRule(3);}



            // AST REWRITE
            // elements: variableAssignment, variableType
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 93:62: -> ( ^( VARDEF variableType variableAssignment ) )+
            {
                dbg.location(93,65);
                if ( !(stream_variableAssignment.hasNext()||stream_variableType.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_variableAssignment.hasNext()||stream_variableType.hasNext() ) {
                    dbg.location(93,65);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:93:65: ^( VARDEF variableType variableAssignment )
                    {
                    Object root_1 = (Object)adaptor.nil();
                    dbg.location(93,67);
                    root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(VARDEF, "VARDEF"), root_1);

                    dbg.location(93,74);
                    adaptor.addChild(root_1, stream_variableType.nextTree());
                    dbg.location(93,87);
                    adaptor.addChild(root_1, stream_variableAssignment.nextTree());

                    adaptor.addChild(root_0, root_1);
                    }

                }
                stream_variableAssignment.reset();
                stream_variableType.reset();

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
        dbg.location(94, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "variableDeclarationList");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "variableDeclarationList"

    public static class variableAssignment_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableAssignment"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:96:1: variableAssignment : variableName ( '=' expression )? -> variableName ( expression )? ;
    public final SGLParser.variableAssignment_return variableAssignment() throws RecognitionException {
        SGLParser.variableAssignment_return retval = new SGLParser.variableAssignment_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal12=null;
        SGLParser.variableName_return variableName11 = null;

        SGLParser.expression_return expression13 = null;


        Object char_literal12_tree=null;
        RewriteRuleTokenStream stream_29=new RewriteRuleTokenStream(adaptor,"token 29");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName=new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try { dbg.enterRule(getGrammarFileName(), "variableAssignment");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(96, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:4: variableName ( '=' expression )?
            {
            dbg.location(97,4);
            pushFollow(FOLLOW_variableName_in_variableAssignment188);
            variableName11=variableName();

            state._fsp--;

            stream_variableName.add(variableName11.getTree());
            dbg.location(97,17);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:17: ( '=' expression )?
            int alt4=2;
            try { dbg.enterSubRule(4);
            try { dbg.enterDecision(4);

            int LA4_0 = input.LA(1);

            if ( (LA4_0==29) ) {
                alt4=1;
            }
            } finally {dbg.exitDecision(4);}

            switch (alt4) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:18: '=' expression
                    {
                    dbg.location(97,18);
                    char_literal12=(Token)match(input,29,FOLLOW_29_in_variableAssignment191);  
                    stream_29.add(char_literal12);

                    dbg.location(97,22);
                    pushFollow(FOLLOW_expression_in_variableAssignment193);
                    expression13=expression();

                    state._fsp--;

                    stream_expression.add(expression13.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(4);}



            // AST REWRITE
            // elements: expression, variableName
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 97:36: -> variableName ( expression )?
            {
                dbg.location(97,39);
                adaptor.addChild(root_0, stream_variableName.nextTree());
                dbg.location(97,52);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:52: ( expression )?
                if ( stream_expression.hasNext() ) {
                    dbg.location(97,52);
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
        dbg.location(98, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:103:1: variableName : Identifier ;
    public final SGLParser.variableName_return variableName() throws RecognitionException {
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token Identifier14=null;

        Object Identifier14_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "variableName");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(103, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:104:2: ( Identifier )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:104:4: Identifier
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(104,4);
            Identifier14=(Token)match(input,Identifier,FOLLOW_Identifier_in_variableName221); 
            Identifier14_tree = (Object)adaptor.create(Identifier14);
            adaptor.addChild(root_0, Identifier14_tree);


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
        dbg.location(105, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:107:1: variableType : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public final SGLParser.variableType_return variableType() throws RecognitionException {
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set15=null;

        Object set15_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "variableType");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(107, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:108:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(108,2);
            set15=(Token)input.LT(1);
            if ( (input.LA(1)>=IntType && input.LA(1)<=ObjectType) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set15));
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
        dbg.location(113, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "variableType");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "variableType"

    public static class whileLoop_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "whileLoop"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:116:1: whileLoop : 'while' '(' expression ')' ( statement -> ^( 'while' expression statement ) | block -> ^( 'while' expression block ) ) ;
    public final SGLParser.whileLoop_return whileLoop() throws RecognitionException {
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal16=null;
        Token char_literal17=null;
        Token char_literal19=null;
        SGLParser.expression_return expression18 = null;

        SGLParser.statement_return statement20 = null;

        SGLParser.block_return block21 = null;


        Object string_literal16_tree=null;
        Object char_literal17_tree=null;
        Object char_literal19_tree=null;
        RewriteRuleTokenStream stream_30=new RewriteRuleTokenStream(adaptor,"token 30");
        RewriteRuleTokenStream stream_32=new RewriteRuleTokenStream(adaptor,"token 32");
        RewriteRuleTokenStream stream_31=new RewriteRuleTokenStream(adaptor,"token 31");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
        RewriteRuleSubtreeStream stream_block=new RewriteRuleSubtreeStream(adaptor,"rule block");
        try { dbg.enterRule(getGrammarFileName(), "whileLoop");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(116, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:117:2: ( 'while' '(' expression ')' ( statement -> ^( 'while' expression statement ) | block -> ^( 'while' expression block ) ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:117:4: 'while' '(' expression ')' ( statement -> ^( 'while' expression statement ) | block -> ^( 'while' expression block ) )
            {
            dbg.location(117,4);
            string_literal16=(Token)match(input,30,FOLLOW_30_in_whileLoop265);  
            stream_30.add(string_literal16);

            dbg.location(117,12);
            char_literal17=(Token)match(input,31,FOLLOW_31_in_whileLoop267);  
            stream_31.add(char_literal17);

            dbg.location(117,16);
            pushFollow(FOLLOW_expression_in_whileLoop269);
            expression18=expression();

            state._fsp--;

            stream_expression.add(expression18.getTree());
            dbg.location(117,27);
            char_literal19=(Token)match(input,32,FOLLOW_32_in_whileLoop271);  
            stream_32.add(char_literal19);

            dbg.location(118,2);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:118:2: ( statement -> ^( 'while' expression statement ) | block -> ^( 'while' expression block ) )
            int alt5=2;
            try { dbg.enterSubRule(5);
            try { dbg.enterDecision(5);

            int LA5_0 = input.LA(1);

            if ( ((LA5_0>=Identifier && LA5_0<=ObjectType)||LA5_0==30) ) {
                alt5=1;
            }
            else if ( (LA5_0==33) ) {
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

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:118:4: statement
                    {
                    dbg.location(118,4);
                    pushFollow(FOLLOW_statement_in_whileLoop277);
                    statement20=statement();

                    state._fsp--;

                    stream_statement.add(statement20.getTree());


                    // AST REWRITE
                    // elements: statement, 30, expression
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 118:14: -> ^( 'while' expression statement )
                    {
                        dbg.location(118,17);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:118:17: ^( 'while' expression statement )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(118,19);
                        root_1 = (Object)adaptor.becomeRoot(stream_30.nextNode(), root_1);

                        dbg.location(118,27);
                        adaptor.addChild(root_1, stream_expression.nextTree());
                        dbg.location(118,38);
                        adaptor.addChild(root_1, stream_statement.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:119:4: block
                    {
                    dbg.location(119,4);
                    pushFollow(FOLLOW_block_in_whileLoop292);
                    block21=block();

                    state._fsp--;

                    stream_block.add(block21.getTree());


                    // AST REWRITE
                    // elements: expression, 30, block
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 119:10: -> ^( 'while' expression block )
                    {
                        dbg.location(119,13);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:119:13: ^( 'while' expression block )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(119,15);
                        root_1 = (Object)adaptor.becomeRoot(stream_30.nextNode(), root_1);

                        dbg.location(119,23);
                        adaptor.addChild(root_1, stream_expression.nextTree());
                        dbg.location(119,34);
                        adaptor.addChild(root_1, stream_block.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;

            }
            } finally {dbg.exitSubRule(5);}


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
        dbg.location(121, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "whileLoop");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "whileLoop"

    public static class block_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "block"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:123:1: block : '{' ( statement )* '}' -> ( statement )* ;
    public final SGLParser.block_return block() throws RecognitionException {
        SGLParser.block_return retval = new SGLParser.block_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal22=null;
        Token char_literal24=null;
        SGLParser.statement_return statement23 = null;


        Object char_literal22_tree=null;
        Object char_literal24_tree=null;
        RewriteRuleTokenStream stream_33=new RewriteRuleTokenStream(adaptor,"token 33");
        RewriteRuleTokenStream stream_34=new RewriteRuleTokenStream(adaptor,"token 34");
        RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try { dbg.enterRule(getGrammarFileName(), "block");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(123, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:124:2: ( '{' ( statement )* '}' -> ( statement )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:124:4: '{' ( statement )* '}'
            {
            dbg.location(124,4);
            char_literal22=(Token)match(input,33,FOLLOW_33_in_block317);  
            stream_33.add(char_literal22);

            dbg.location(124,8);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:124:8: ( statement )*
            try { dbg.enterSubRule(6);

            loop6:
            do {
                int alt6=2;
                try { dbg.enterDecision(6);

                int LA6_0 = input.LA(1);

                if ( ((LA6_0>=Identifier && LA6_0<=ObjectType)||LA6_0==30) ) {
                    alt6=1;
                }


                } finally {dbg.exitDecision(6);}

                switch (alt6) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:124:8: statement
            	    {
            	    dbg.location(124,8);
            	    pushFollow(FOLLOW_statement_in_block319);
            	    statement23=statement();

            	    state._fsp--;

            	    stream_statement.add(statement23.getTree());

            	    }
            	    break;

            	default :
            	    break loop6;
                }
            } while (true);
            } finally {dbg.exitSubRule(6);}

            dbg.location(124,19);
            char_literal24=(Token)match(input,34,FOLLOW_34_in_block322);  
            stream_34.add(char_literal24);



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
            // 124:23: -> ( statement )*
            {
                dbg.location(124,26);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:124:26: ( statement )*
                while ( stream_statement.hasNext() ) {
                    dbg.location(124,26);
                    adaptor.addChild(root_0, stream_statement.nextTree());

                }
                stream_statement.reset();

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
        dbg.location(125, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "block");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "block"

    public static class expression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "expression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:147:1: expression : conditionalExpression ;
    public final SGLParser.expression_return expression() throws RecognitionException {
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression25 = null;



        try { dbg.enterRule(getGrammarFileName(), "expression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(147, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:148:5: ( conditionalExpression )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:148:8: conditionalExpression
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(148,8);
            pushFollow(FOLLOW_conditionalExpression_in_expression377);
            conditionalExpression25=conditionalExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalExpression25.getTree());

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
        dbg.location(150, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:157:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public final SGLParser.conditionalExpression_return conditionalExpression() throws RecognitionException {
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal27=null;
        Token char_literal29=null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression26 = null;

        SGLParser.conditionalExpression_return conditionalExpression28 = null;

        SGLParser.conditionalExpression_return conditionalExpression30 = null;


        Object char_literal27_tree=null;
        Object char_literal29_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "conditionalExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(157, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:158:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:158:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(158,9);
            pushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression418);
            conditionalOrExpression26=conditionalOrExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalOrExpression26.getTree());
            dbg.location(158,33);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:158:33: ( '?' conditionalExpression ':' conditionalExpression )?
            int alt7=2;
            try { dbg.enterSubRule(7);
            try { dbg.enterDecision(7);

            int LA7_0 = input.LA(1);

            if ( (LA7_0==35) ) {
                alt7=1;
            }
            } finally {dbg.exitDecision(7);}

            switch (alt7) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:158:35: '?' conditionalExpression ':' conditionalExpression
                    {
                    dbg.location(158,38);
                    char_literal27=(Token)match(input,35,FOLLOW_35_in_conditionalExpression422); 
                    char_literal27_tree = (Object)adaptor.create(char_literal27);
                    root_0 = (Object)adaptor.becomeRoot(char_literal27_tree, root_0);

                    dbg.location(158,40);
                    pushFollow(FOLLOW_conditionalExpression_in_conditionalExpression425);
                    conditionalExpression28=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression28.getTree());
                    dbg.location(158,65);
                    char_literal29=(Token)match(input,36,FOLLOW_36_in_conditionalExpression427); 
                    dbg.location(158,67);
                    pushFollow(FOLLOW_conditionalExpression_in_conditionalExpression430);
                    conditionalExpression30=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression30.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(7);}


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
        dbg.location(159, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:163:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public final SGLParser.conditionalOrExpression_return conditionalOrExpression() throws RecognitionException {
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal32=null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression31 = null;

        SGLParser.conditionalAndExpression_return conditionalAndExpression33 = null;


        Object string_literal32_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "conditionalOrExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(163, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:164:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:164:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(164,9);
            pushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression473);
            conditionalAndExpression31=conditionalAndExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalAndExpression31.getTree());
            dbg.location(164,34);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:164:34: ( '||' conditionalAndExpression )*
            try { dbg.enterSubRule(8);

            loop8:
            do {
                int alt8=2;
                try { dbg.enterDecision(8);

                int LA8_0 = input.LA(1);

                if ( (LA8_0==37) ) {
                    alt8=1;
                }


                } finally {dbg.exitDecision(8);}

                switch (alt8) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:164:36: '||' conditionalAndExpression
            	    {
            	    dbg.location(164,40);
            	    string_literal32=(Token)match(input,37,FOLLOW_37_in_conditionalOrExpression477); 
            	    string_literal32_tree = (Object)adaptor.create(string_literal32);
            	    root_0 = (Object)adaptor.becomeRoot(string_literal32_tree, root_0);

            	    dbg.location(164,42);
            	    pushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression480);
            	    conditionalAndExpression33=conditionalAndExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, conditionalAndExpression33.getTree());

            	    }
            	    break;

            	default :
            	    break loop8;
                }
            } while (true);
            } finally {dbg.exitSubRule(8);}


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
        dbg.location(165, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:168:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public final SGLParser.conditionalAndExpression_return conditionalAndExpression() throws RecognitionException {
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal35=null;
        SGLParser.equalityExpression_return equalityExpression34 = null;

        SGLParser.equalityExpression_return equalityExpression36 = null;


        Object string_literal35_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "conditionalAndExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(168, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:169:5: ( equalityExpression ( '&&' equalityExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:169:9: equalityExpression ( '&&' equalityExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(169,9);
            pushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression511);
            equalityExpression34=equalityExpression();

            state._fsp--;

            adaptor.addChild(root_0, equalityExpression34.getTree());
            dbg.location(169,28);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:169:28: ( '&&' equalityExpression )*
            try { dbg.enterSubRule(9);

            loop9:
            do {
                int alt9=2;
                try { dbg.enterDecision(9);

                int LA9_0 = input.LA(1);

                if ( (LA9_0==38) ) {
                    alt9=1;
                }


                } finally {dbg.exitDecision(9);}

                switch (alt9) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:169:30: '&&' equalityExpression
            	    {
            	    dbg.location(169,34);
            	    string_literal35=(Token)match(input,38,FOLLOW_38_in_conditionalAndExpression515); 
            	    string_literal35_tree = (Object)adaptor.create(string_literal35);
            	    root_0 = (Object)adaptor.becomeRoot(string_literal35_tree, root_0);

            	    dbg.location(169,36);
            	    pushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression518);
            	    equalityExpression36=equalityExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, equalityExpression36.getTree());

            	    }
            	    break;

            	default :
            	    break loop9;
                }
            } while (true);
            } finally {dbg.exitSubRule(9);}


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
        dbg.location(170, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:173:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public final SGLParser.equalityExpression_return equalityExpression() throws RecognitionException {
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal38=null;
        Token string_literal39=null;
        SGLParser.relationalExpression_return relationalExpression37 = null;

        SGLParser.relationalExpression_return relationalExpression40 = null;


        Object string_literal38_tree=null;
        Object string_literal39_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "equalityExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(173, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:174:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:174:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(174,9);
            pushFollow(FOLLOW_relationalExpression_in_equalityExpression545);
            relationalExpression37=relationalExpression();

            state._fsp--;

            adaptor.addChild(root_0, relationalExpression37.getTree());
            dbg.location(174,30);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:174:30: ( ( '==' | '!=' ) relationalExpression )*
            try { dbg.enterSubRule(11);

            loop11:
            do {
                int alt11=2;
                try { dbg.enterDecision(11);

                int LA11_0 = input.LA(1);

                if ( ((LA11_0>=39 && LA11_0<=40)) ) {
                    alt11=1;
                }


                } finally {dbg.exitDecision(11);}

                switch (alt11) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:174:32: ( '==' | '!=' ) relationalExpression
            	    {
            	    dbg.location(174,32);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:174:32: ( '==' | '!=' )
            	    int alt10=2;
            	    try { dbg.enterSubRule(10);
            	    try { dbg.enterDecision(10);

            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0==39) ) {
            	        alt10=1;
            	    }
            	    else if ( (LA10_0==40) ) {
            	        alt10=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 10, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }
            	    } finally {dbg.exitDecision(10);}

            	    switch (alt10) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:174:33: '=='
            	            {
            	            dbg.location(174,37);
            	            string_literal38=(Token)match(input,39,FOLLOW_39_in_equalityExpression550); 
            	            string_literal38_tree = (Object)adaptor.create(string_literal38);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal38_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:174:41: '!='
            	            {
            	            dbg.location(174,45);
            	            string_literal39=(Token)match(input,40,FOLLOW_40_in_equalityExpression555); 
            	            string_literal39_tree = (Object)adaptor.create(string_literal39);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal39_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(10);}

            	    dbg.location(174,48);
            	    pushFollow(FOLLOW_relationalExpression_in_equalityExpression559);
            	    relationalExpression40=relationalExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, relationalExpression40.getTree());

            	    }
            	    break;

            	default :
            	    break loop11;
                }
            } while (true);
            } finally {dbg.exitSubRule(11);}


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
        dbg.location(175, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:178:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public final SGLParser.relationalExpression_return relationalExpression() throws RecognitionException {
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal42=null;
        Token char_literal43=null;
        Token string_literal44=null;
        Token string_literal45=null;
        SGLParser.additiveExpression_return additiveExpression41 = null;

        SGLParser.additiveExpression_return additiveExpression46 = null;


        Object char_literal42_tree=null;
        Object char_literal43_tree=null;
        Object string_literal44_tree=null;
        Object string_literal45_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "relationalExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(178, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(179,9);
            pushFollow(FOLLOW_additiveExpression_in_relationalExpression590);
            additiveExpression41=additiveExpression();

            state._fsp--;

            adaptor.addChild(root_0, additiveExpression41.getTree());
            dbg.location(179,28);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            try { dbg.enterSubRule(13);

            loop13:
            do {
                int alt13=2;
                try { dbg.enterDecision(13);

                int LA13_0 = input.LA(1);

                if ( ((LA13_0>=41 && LA13_0<=44)) ) {
                    alt13=1;
                }


                } finally {dbg.exitDecision(13);}

                switch (alt13) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            	    {
            	    dbg.location(179,29);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:29: ( '<' | '>' | '<=' | '>=' )
            	    int alt12=4;
            	    try { dbg.enterSubRule(12);
            	    try { dbg.enterDecision(12);

            	    switch ( input.LA(1) ) {
            	    case 41:
            	        {
            	        alt12=1;
            	        }
            	        break;
            	    case 42:
            	        {
            	        alt12=2;
            	        }
            	        break;
            	    case 43:
            	        {
            	        alt12=3;
            	        }
            	        break;
            	    case 44:
            	        {
            	        alt12=4;
            	        }
            	        break;
            	    default:
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 12, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }

            	    } finally {dbg.exitDecision(12);}

            	    switch (alt12) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:30: '<'
            	            {
            	            dbg.location(179,33);
            	            char_literal42=(Token)match(input,41,FOLLOW_41_in_relationalExpression594); 
            	            char_literal42_tree = (Object)adaptor.create(char_literal42);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal42_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:35: '>'
            	            {
            	            dbg.location(179,38);
            	            char_literal43=(Token)match(input,42,FOLLOW_42_in_relationalExpression597); 
            	            char_literal43_tree = (Object)adaptor.create(char_literal43);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal43_tree, root_0);


            	            }
            	            break;
            	        case 3 :
            	            dbg.enterAlt(3);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:40: '<='
            	            {
            	            dbg.location(179,44);
            	            string_literal44=(Token)match(input,43,FOLLOW_43_in_relationalExpression600); 
            	            string_literal44_tree = (Object)adaptor.create(string_literal44);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal44_tree, root_0);


            	            }
            	            break;
            	        case 4 :
            	            dbg.enterAlt(4);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:46: '>='
            	            {
            	            dbg.location(179,50);
            	            string_literal45=(Token)match(input,44,FOLLOW_44_in_relationalExpression603); 
            	            string_literal45_tree = (Object)adaptor.create(string_literal45);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal45_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(12);}

            	    dbg.location(179,53);
            	    pushFollow(FOLLOW_additiveExpression_in_relationalExpression607);
            	    additiveExpression46=additiveExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, additiveExpression46.getTree());

            	    }
            	    break;

            	default :
            	    break loop13;
                }
            } while (true);
            } finally {dbg.exitSubRule(13);}


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
        dbg.location(180, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:183:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public final SGLParser.additiveExpression_return additiveExpression() throws RecognitionException {
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal48=null;
        Token char_literal49=null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression47 = null;

        SGLParser.multiplicativeExpression_return multiplicativeExpression50 = null;


        Object char_literal48_tree=null;
        Object char_literal49_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "additiveExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(183, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:184:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:184:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(184,9);
            pushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression645);
            multiplicativeExpression47=multiplicativeExpression();

            state._fsp--;

            adaptor.addChild(root_0, multiplicativeExpression47.getTree());
            dbg.location(184,34);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:184:34: ( ( '+' | '-' ) multiplicativeExpression )*
            try { dbg.enterSubRule(15);

            loop15:
            do {
                int alt15=2;
                try { dbg.enterDecision(15);

                int LA15_0 = input.LA(1);

                if ( ((LA15_0>=45 && LA15_0<=46)) ) {
                    alt15=1;
                }


                } finally {dbg.exitDecision(15);}

                switch (alt15) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:184:35: ( '+' | '-' ) multiplicativeExpression
            	    {
            	    dbg.location(184,35);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:184:35: ( '+' | '-' )
            	    int alt14=2;
            	    try { dbg.enterSubRule(14);
            	    try { dbg.enterDecision(14);

            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0==45) ) {
            	        alt14=1;
            	    }
            	    else if ( (LA14_0==46) ) {
            	        alt14=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 14, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }
            	    } finally {dbg.exitDecision(14);}

            	    switch (alt14) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:184:36: '+'
            	            {
            	            dbg.location(184,39);
            	            char_literal48=(Token)match(input,45,FOLLOW_45_in_additiveExpression649); 
            	            char_literal48_tree = (Object)adaptor.create(char_literal48);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal48_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:184:41: '-'
            	            {
            	            dbg.location(184,44);
            	            char_literal49=(Token)match(input,46,FOLLOW_46_in_additiveExpression652); 
            	            char_literal49_tree = (Object)adaptor.create(char_literal49);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal49_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(14);}

            	    dbg.location(184,47);
            	    pushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression656);
            	    multiplicativeExpression50=multiplicativeExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, multiplicativeExpression50.getTree());

            	    }
            	    break;

            	default :
            	    break loop15;
                }
            } while (true);
            } finally {dbg.exitSubRule(15);}


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
        dbg.location(185, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:188:1: multiplicativeExpression : negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* ;
    public final SGLParser.multiplicativeExpression_return multiplicativeExpression() throws RecognitionException {
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal52=null;
        Token char_literal53=null;
        Token char_literal54=null;
        SGLParser.negativeExpression_return negativeExpression51 = null;

        SGLParser.negativeExpression_return negativeExpression55 = null;


        Object char_literal52_tree=null;
        Object char_literal53_tree=null;
        Object char_literal54_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "multiplicativeExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(188, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:189:5: ( negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:189:9: negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(189,9);
            pushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression690);
            negativeExpression51=negativeExpression();

            state._fsp--;

            adaptor.addChild(root_0, negativeExpression51.getTree());
            dbg.location(190,5);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:190:5: ( ( '*' | '/' | '%' ) negativeExpression )*
            try { dbg.enterSubRule(17);

            loop17:
            do {
                int alt17=2;
                try { dbg.enterDecision(17);

                int LA17_0 = input.LA(1);

                if ( ((LA17_0>=47 && LA17_0<=49)) ) {
                    alt17=1;
                }


                } finally {dbg.exitDecision(17);}

                switch (alt17) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:190:6: ( '*' | '/' | '%' ) negativeExpression
            	    {
            	    dbg.location(190,6);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:190:6: ( '*' | '/' | '%' )
            	    int alt16=3;
            	    try { dbg.enterSubRule(16);
            	    try { dbg.enterDecision(16);

            	    switch ( input.LA(1) ) {
            	    case 47:
            	        {
            	        alt16=1;
            	        }
            	        break;
            	    case 48:
            	        {
            	        alt16=2;
            	        }
            	        break;
            	    case 49:
            	        {
            	        alt16=3;
            	        }
            	        break;
            	    default:
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 16, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }

            	    } finally {dbg.exitDecision(16);}

            	    switch (alt16) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:190:7: '*'
            	            {
            	            dbg.location(190,10);
            	            char_literal52=(Token)match(input,47,FOLLOW_47_in_multiplicativeExpression698); 
            	            char_literal52_tree = (Object)adaptor.create(char_literal52);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal52_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:190:12: '/'
            	            {
            	            dbg.location(190,15);
            	            char_literal53=(Token)match(input,48,FOLLOW_48_in_multiplicativeExpression701); 
            	            char_literal53_tree = (Object)adaptor.create(char_literal53);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal53_tree, root_0);


            	            }
            	            break;
            	        case 3 :
            	            dbg.enterAlt(3);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:190:17: '%'
            	            {
            	            dbg.location(190,20);
            	            char_literal54=(Token)match(input,49,FOLLOW_49_in_multiplicativeExpression704); 
            	            char_literal54_tree = (Object)adaptor.create(char_literal54);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal54_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(16);}

            	    dbg.location(190,23);
            	    pushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression708);
            	    negativeExpression55=negativeExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, negativeExpression55.getTree());

            	    }
            	    break;

            	default :
            	    break loop17;
                }
            } while (true);
            } finally {dbg.exitSubRule(17);}


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
        dbg.location(191, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:193:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public final SGLParser.unaryExpression_return unaryExpression() throws RecognitionException {
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal56=null;
        Token string_literal58=null;
        SGLParser.unaryExpression_return unaryExpression57 = null;

        SGLParser.unaryExpression_return unaryExpression59 = null;

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus60 = null;


        Object string_literal56_tree=null;
        Object string_literal58_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unaryExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(193, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:194:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt18=3;
            try { dbg.enterDecision(18);

            switch ( input.LA(1) ) {
            case 50:
                {
                alt18=1;
                }
                break;
            case 51:
                {
                alt18=2;
                }
                break;
            case Identifier:
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case StringAtom:
            case 31:
            case 52:
            case 53:
                {
                alt18=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 18, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(18);}

            switch (alt18) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:194:7: '++' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(194,7);
                    string_literal56=(Token)match(input,50,FOLLOW_50_in_unaryExpression731); 
                    string_literal56_tree = (Object)adaptor.create(string_literal56);
                    adaptor.addChild(root_0, string_literal56_tree);

                    dbg.location(194,12);
                    pushFollow(FOLLOW_unaryExpression_in_unaryExpression733);
                    unaryExpression57=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression57.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:195:9: '--' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(195,9);
                    string_literal58=(Token)match(input,51,FOLLOW_51_in_unaryExpression743); 
                    string_literal58_tree = (Object)adaptor.create(string_literal58);
                    adaptor.addChild(root_0, string_literal58_tree);

                    dbg.location(195,14);
                    pushFollow(FOLLOW_unaryExpression_in_unaryExpression745);
                    unaryExpression59=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression59.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:196:9: unaryExpressionNotPlusMinus
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(196,9);
                    pushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression755);
                    unaryExpressionNotPlusMinus60=unaryExpressionNotPlusMinus();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpressionNotPlusMinus60.getTree());

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
        dbg.location(197, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:200:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public final SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() throws RecognitionException {
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal61=null;
        Token set65=null;
        SGLParser.unaryExpression_return unaryExpression62 = null;

        SGLParser.castExpression_return castExpression63 = null;

        SGLParser.mathAtom_return mathAtom64 = null;


        Object char_literal61_tree=null;
        Object set65_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unaryExpressionNotPlusMinus");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(200, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:201:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt20=3;
            try { dbg.enterDecision(20);

            switch ( input.LA(1) ) {
            case 52:
                {
                alt20=1;
                }
                break;
            case 31:
                {
                int LA20_2 = input.LA(2);

                if ( ((LA20_2>=IntType && LA20_2<=ObjectType)) ) {
                    alt20=2;
                }
                else if ( (LA20_2==Identifier||(LA20_2>=IntegerAtom && LA20_2<=BooleanAtom)||LA20_2==StringAtom||LA20_2==31||LA20_2==46||LA20_2==53) ) {
                    alt20=3;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 20, 2, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
                }
                break;
            case Identifier:
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case StringAtom:
            case 53:
                {
                alt20=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 20, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(20);}

            switch (alt20) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:201:9: '!' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(201,9);
                    char_literal61=(Token)match(input,52,FOLLOW_52_in_unaryExpressionNotPlusMinus776); 
                    char_literal61_tree = (Object)adaptor.create(char_literal61);
                    adaptor.addChild(root_0, char_literal61_tree);

                    dbg.location(201,13);
                    pushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus778);
                    unaryExpression62=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression62.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:202:9: castExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(202,9);
                    pushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus788);
                    castExpression63=castExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, castExpression63.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:204:9: mathAtom ( '++' | '--' )?
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(204,9);
                    pushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus803);
                    mathAtom64=mathAtom();

                    state._fsp--;

                    adaptor.addChild(root_0, mathAtom64.getTree());
                    dbg.location(204,18);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:204:18: ( '++' | '--' )?
                    int alt19=2;
                    try { dbg.enterSubRule(19);
                    try { dbg.enterDecision(19);

                    int LA19_0 = input.LA(1);

                    if ( ((LA19_0>=50 && LA19_0<=51)) ) {
                        alt19=1;
                    }
                    } finally {dbg.exitDecision(19);}

                    switch (alt19) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
                            {
                            dbg.location(204,18);
                            set65=(Token)input.LT(1);
                            if ( (input.LA(1)>=50 && input.LA(1)<=51) ) {
                                input.consume();
                                adaptor.addChild(root_0, (Object)adaptor.create(set65));
                                state.errorRecovery=false;
                            }
                            else {
                                MismatchedSetException mse = new MismatchedSetException(null,input);
                                dbg.recognitionException(mse);
                                throw mse;
                            }


                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(19);}


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
        dbg.location(205, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:208:1: castExpression : '(' variableType ')' unaryExpression ;
    public final SGLParser.castExpression_return castExpression() throws RecognitionException {
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal66=null;
        Token char_literal68=null;
        SGLParser.variableType_return variableType67 = null;

        SGLParser.unaryExpression_return unaryExpression69 = null;


        Object char_literal66_tree=null;
        Object char_literal68_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "castExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(208, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:209:5: ( '(' variableType ')' unaryExpression )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:209:8: '(' variableType ')' unaryExpression
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(209,8);
            char_literal66=(Token)match(input,31,FOLLOW_31_in_castExpression836); 
            char_literal66_tree = (Object)adaptor.create(char_literal66);
            adaptor.addChild(root_0, char_literal66_tree);

            dbg.location(209,12);
            pushFollow(FOLLOW_variableType_in_castExpression838);
            variableType67=variableType();

            state._fsp--;

            adaptor.addChild(root_0, variableType67.getTree());
            dbg.location(209,25);
            char_literal68=(Token)match(input,32,FOLLOW_32_in_castExpression840); 
            char_literal68_tree = (Object)adaptor.create(char_literal68);
            adaptor.addChild(root_0, char_literal68_tree);

            dbg.location(209,29);
            pushFollow(FOLLOW_unaryExpression_in_castExpression842);
            unaryExpression69=unaryExpression();

            state._fsp--;

            adaptor.addChild(root_0, unaryExpression69.getTree());

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
        dbg.location(210, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:214:1: negativeExpression : ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) );
    public final SGLParser.negativeExpression_return negativeExpression() throws RecognitionException {
        SGLParser.negativeExpression_return retval = new SGLParser.negativeExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal71=null;
        SGLParser.mathAtom_return mathAtom70 = null;

        SGLParser.mathAtom_return mathAtom72 = null;


        Object char_literal71_tree=null;
        RewriteRuleTokenStream stream_46=new RewriteRuleTokenStream(adaptor,"token 46");
        RewriteRuleSubtreeStream stream_mathAtom=new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try { dbg.enterRule(getGrammarFileName(), "negativeExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(214, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:215:2: ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) )
            int alt21=2;
            try { dbg.enterDecision(21);

            int LA21_0 = input.LA(1);

            if ( (LA21_0==Identifier||(LA21_0>=IntegerAtom && LA21_0<=BooleanAtom)||LA21_0==StringAtom||LA21_0==31||LA21_0==53) ) {
                alt21=1;
            }
            else if ( (LA21_0==46) ) {
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

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:215:4: mathAtom
                    {
                    dbg.location(215,4);
                    pushFollow(FOLLOW_mathAtom_in_negativeExpression860);
                    mathAtom70=mathAtom();

                    state._fsp--;

                    stream_mathAtom.add(mathAtom70.getTree());


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
                    // 215:13: -> mathAtom
                    {
                        dbg.location(215,16);
                        adaptor.addChild(root_0, stream_mathAtom.nextTree());

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:216:4: ( '-' ) mathAtom
                    {
                    dbg.location(216,4);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:216:4: ( '-' )
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:216:5: '-'
                    {
                    dbg.location(216,5);
                    char_literal71=(Token)match(input,46,FOLLOW_46_in_negativeExpression870);  
                    stream_46.add(char_literal71);


                    }

                    dbg.location(216,10);
                    pushFollow(FOLLOW_mathAtom_in_negativeExpression873);
                    mathAtom72=mathAtom();

                    state._fsp--;

                    stream_mathAtom.add(mathAtom72.getTree());


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
                    // 216:19: -> ^( NEGATE mathAtom )
                    {
                        dbg.location(216,22);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:216:22: ^( NEGATE mathAtom )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(216,24);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(NEGATE, "NEGATE"), root_1);

                        dbg.location(216,31);
                        adaptor.addChild(root_1, stream_mathAtom.nextTree());

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
        dbg.location(217, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:219:1: mathAtom : ( '(' additiveExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote );
    public final SGLParser.mathAtom_return mathAtom() throws RecognitionException {
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal73=null;
        Token char_literal75=null;
        Token IntegerAtom76=null;
        Token FloatAtom77=null;
        Token BooleanAtom78=null;
        Token string_literal79=null;
        Token SpriteAnimation80=null;
        Token Identifier82=null;
        Token Identifier83=null;
        SGLParser.additiveExpression_return additiveExpression74 = null;

        SGLParser.arguments_return arguments81 = null;

        SGLParser.arguments_return arguments84 = null;

        SGLParser.stringQuote_return stringQuote85 = null;


        Object char_literal73_tree=null;
        Object char_literal75_tree=null;
        Object IntegerAtom76_tree=null;
        Object FloatAtom77_tree=null;
        Object BooleanAtom78_tree=null;
        Object string_literal79_tree=null;
        Object SpriteAnimation80_tree=null;
        Object Identifier82_tree=null;
        Object Identifier83_tree=null;
        RewriteRuleTokenStream stream_SpriteAnimation=new RewriteRuleTokenStream(adaptor,"token SpriteAnimation");
        RewriteRuleTokenStream stream_53=new RewriteRuleTokenStream(adaptor,"token 53");
        RewriteRuleTokenStream stream_Identifier=new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments=new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try { dbg.enterRule(getGrammarFileName(), "mathAtom");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(219, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:220:5: ( '(' additiveExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote )
            int alt22=8;
            try { dbg.enterDecision(22);

            try {
                isCyclicDecision = true;
                alt22 = dfa22.predict(input);
            }
            catch (NoViableAltException nvae) {
                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(22);}

            switch (alt22) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:220:7: '(' additiveExpression ')'
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(220,10);
                    char_literal73=(Token)match(input,31,FOLLOW_31_in_mathAtom895); 
                    dbg.location(220,12);
                    pushFollow(FOLLOW_additiveExpression_in_mathAtom898);
                    additiveExpression74=additiveExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, additiveExpression74.getTree());
                    dbg.location(220,34);
                    char_literal75=(Token)match(input,32,FOLLOW_32_in_mathAtom900); 

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:221:9: IntegerAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(221,9);
                    IntegerAtom76=(Token)match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom911); 
                    IntegerAtom76_tree = (Object)adaptor.create(IntegerAtom76);
                    adaptor.addChild(root_0, IntegerAtom76_tree);


                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:222:7: FloatAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(222,7);
                    FloatAtom77=(Token)match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom919); 
                    FloatAtom77_tree = (Object)adaptor.create(FloatAtom77);
                    adaptor.addChild(root_0, FloatAtom77_tree);


                    }
                    break;
                case 4 :
                    dbg.enterAlt(4);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:223:9: BooleanAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(223,9);
                    BooleanAtom78=(Token)match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom929); 
                    BooleanAtom78_tree = (Object)adaptor.create(BooleanAtom78);
                    adaptor.addChild(root_0, BooleanAtom78_tree);


                    }
                    break;
                case 5 :
                    dbg.enterAlt(5);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:225:9: 'new' SpriteAnimation arguments
                    {
                    dbg.location(225,9);
                    string_literal79=(Token)match(input,53,FOLLOW_53_in_mathAtom940);  
                    stream_53.add(string_literal79);

                    dbg.location(225,15);
                    SpriteAnimation80=(Token)match(input,SpriteAnimation,FOLLOW_SpriteAnimation_in_mathAtom942);  
                    stream_SpriteAnimation.add(SpriteAnimation80);

                    dbg.location(225,31);
                    pushFollow(FOLLOW_arguments_in_mathAtom944);
                    arguments81=arguments();

                    state._fsp--;

                    stream_arguments.add(arguments81.getTree());


                    // AST REWRITE
                    // elements: SpriteAnimation, arguments
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 225:41: -> ^( SpriteAnimation arguments )
                    {
                        dbg.location(225,44);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:225:44: ^( SpriteAnimation arguments )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(225,46);
                        root_1 = (Object)adaptor.becomeRoot(stream_SpriteAnimation.nextNode(), root_1);

                        dbg.location(225,62);
                        adaptor.addChild(root_1, stream_arguments.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 6 :
                    dbg.enterAlt(6);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:227:4: Identifier
                    {
                    dbg.location(227,4);
                    Identifier82=(Token)match(input,Identifier,FOLLOW_Identifier_in_mathAtom959);  
                    stream_Identifier.add(Identifier82);



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
                    // 227:15: -> Identifier
                    {
                        dbg.location(227,18);
                        adaptor.addChild(root_0, stream_Identifier.nextNode());

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 7 :
                    dbg.enterAlt(7);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:228:4: Identifier arguments
                    {
                    dbg.location(228,4);
                    Identifier83=(Token)match(input,Identifier,FOLLOW_Identifier_in_mathAtom968);  
                    stream_Identifier.add(Identifier83);

                    dbg.location(228,15);
                    pushFollow(FOLLOW_arguments_in_mathAtom970);
                    arguments84=arguments();

                    state._fsp--;

                    stream_arguments.add(arguments84.getTree());


                    // AST REWRITE
                    // elements: Identifier, arguments
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 228:25: -> ^( LIBMETHOD Identifier ( arguments )? )
                    {
                        dbg.location(228,28);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:228:28: ^( LIBMETHOD Identifier ( arguments )? )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(228,30);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(LIBMETHOD, "LIBMETHOD"), root_1);

                        dbg.location(228,40);
                        adaptor.addChild(root_1, stream_Identifier.nextNode());
                        dbg.location(228,51);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:228:51: ( arguments )?
                        if ( stream_arguments.hasNext() ) {
                            dbg.location(228,51);
                            adaptor.addChild(root_1, stream_arguments.nextTree());

                        }
                        stream_arguments.reset();

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 8 :
                    dbg.enterAlt(8);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:229:4: stringQuote
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(229,4);
                    pushFollow(FOLLOW_stringQuote_in_mathAtom986);
                    stringQuote85=stringQuote();

                    state._fsp--;

                    adaptor.addChild(root_0, stringQuote85.getTree());

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
        dbg.location(230, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "mathAtom");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "mathAtom"

    public static class arguments_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "arguments"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:233:1: arguments : '(' ( expressionList )? ')' ;
    public final SGLParser.arguments_return arguments() throws RecognitionException {
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal86=null;
        Token char_literal88=null;
        SGLParser.expressionList_return expressionList87 = null;


        Object char_literal86_tree=null;
        Object char_literal88_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "arguments");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(233, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:234:5: ( '(' ( expressionList )? ')' )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:234:9: '(' ( expressionList )? ')'
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(234,12);
            char_literal86=(Token)match(input,31,FOLLOW_31_in_arguments1008); 
            dbg.location(234,14);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:234:14: ( expressionList )?
            int alt23=2;
            try { dbg.enterSubRule(23);
            try { dbg.enterDecision(23);

            int LA23_0 = input.LA(1);

            if ( (LA23_0==Identifier||(LA23_0>=IntegerAtom && LA23_0<=BooleanAtom)||LA23_0==StringAtom||LA23_0==31||LA23_0==46||LA23_0==53) ) {
                alt23=1;
            }
            } finally {dbg.exitDecision(23);}

            switch (alt23) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:234:14: expressionList
                    {
                    dbg.location(234,14);
                    pushFollow(FOLLOW_expressionList_in_arguments1011);
                    expressionList87=expressionList();

                    state._fsp--;

                    adaptor.addChild(root_0, expressionList87.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(23);}

            dbg.location(234,33);
            char_literal88=(Token)match(input,32,FOLLOW_32_in_arguments1014); 

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
        dbg.location(235, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:237:1: expressionList : expression ( ',' expression )* ;
    public final SGLParser.expressionList_return expressionList() throws RecognitionException {
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal90=null;
        SGLParser.expression_return expression89 = null;

        SGLParser.expression_return expression91 = null;


        Object char_literal90_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "expressionList");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(237, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:238:5: ( expression ( ',' expression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:238:9: expression ( ',' expression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(238,9);
            pushFollow(FOLLOW_expression_in_expressionList1034);
            expression89=expression();

            state._fsp--;

            adaptor.addChild(root_0, expression89.getTree());
            dbg.location(238,20);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:238:20: ( ',' expression )*
            try { dbg.enterSubRule(24);

            loop24:
            do {
                int alt24=2;
                try { dbg.enterDecision(24);

                int LA24_0 = input.LA(1);

                if ( (LA24_0==28) ) {
                    alt24=1;
                }


                } finally {dbg.exitDecision(24);}

                switch (alt24) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:238:21: ',' expression
            	    {
            	    dbg.location(238,24);
            	    char_literal90=(Token)match(input,28,FOLLOW_28_in_expressionList1037); 
            	    dbg.location(238,26);
            	    pushFollow(FOLLOW_expression_in_expressionList1040);
            	    expression91=expression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, expression91.getTree());

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
        dbg.location(239, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "expressionList");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "expressionList"

    public static class literal_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "literal"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:243:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public final SGLParser.literal_return literal() throws RecognitionException {
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set92=null;

        Object set92_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "literal");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(243, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:244:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(244,5);
            set92=(Token)input.LT(1);
            if ( (input.LA(1)>=IntegerAtom && input.LA(1)<=BooleanAtom)||input.LA(1)==StringAtom||input.LA(1)==54 ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set92));
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
        dbg.location(249, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:252:1: stringQuote : StringAtom -> ^( STRING StringAtom ) ;
    public final SGLParser.stringQuote_return stringQuote() throws RecognitionException {
        SGLParser.stringQuote_return retval = new SGLParser.stringQuote_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token StringAtom93=null;

        Object StringAtom93_tree=null;
        RewriteRuleTokenStream stream_StringAtom=new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try { dbg.enterRule(getGrammarFileName(), "stringQuote");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(252, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:253:2: ( StringAtom -> ^( STRING StringAtom ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:253:8: StringAtom
            {
            dbg.location(253,8);
            StringAtom93=(Token)match(input,StringAtom,FOLLOW_StringAtom_in_stringQuote1139);  
            stream_StringAtom.add(StringAtom93);



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
            // 253:19: -> ^( STRING StringAtom )
            {
                dbg.location(253,22);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:253:22: ^( STRING StringAtom )
                {
                Object root_1 = (Object)adaptor.nil();
                dbg.location(253,24);
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(STRING, "STRING"), root_1);

                dbg.location(253,31);
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
        dbg.location(254, 2);

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


    protected DFA22 dfa22 = new DFA22(this);
    static final String DFA22_eotS =
        "\12\uffff";
    static final String DFA22_eofS =
        "\6\uffff\1\11\3\uffff";
    static final String DFA22_minS =
        "\1\11\5\uffff\1\11\3\uffff";
    static final String DFA22_maxS =
        "\1\65\5\uffff\1\63\3\uffff";
    static final String DFA22_acceptS =
        "\1\uffff\1\1\1\2\1\3\1\4\1\5\1\uffff\1\10\1\7\1\6";
    static final String DFA22_specialS =
        "\12\uffff}>";
    static final String[] DFA22_transitionS = {
            "\1\6\5\uffff\1\2\1\3\1\4\1\uffff\1\7\13\uffff\1\1\25\uffff"+
            "\1\5",
            "",
            "",
            "",
            "",
            "",
            "\6\11\15\uffff\1\11\1\uffff\1\11\1\10\1\11\1\uffff\22\11",
            "",
            "",
            ""
    };

    static final short[] DFA22_eot = DFA.unpackEncodedString(DFA22_eotS);
    static final short[] DFA22_eof = DFA.unpackEncodedString(DFA22_eofS);
    static final char[] DFA22_min = DFA.unpackEncodedStringToUnsignedChars(DFA22_minS);
    static final char[] DFA22_max = DFA.unpackEncodedStringToUnsignedChars(DFA22_maxS);
    static final short[] DFA22_accept = DFA.unpackEncodedString(DFA22_acceptS);
    static final short[] DFA22_special = DFA.unpackEncodedString(DFA22_specialS);
    static final short[][] DFA22_transition;

    static {
        int numStates = DFA22_transitionS.length;
        DFA22_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA22_transition[i] = DFA.unpackEncodedString(DFA22_transitionS[i]);
        }
    }

    class DFA22 extends DFA {

        public DFA22(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 22;
            this.eot = DFA22_eot;
            this.eof = DFA22_eof;
            this.min = DFA22_min;
            this.max = DFA22_max;
            this.accept = DFA22_accept;
            this.special = DFA22_special;
            this.transition = DFA22_transition;
        }
        public String getDescription() {
            return "219:1: mathAtom : ( '(' additiveExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote );";
        }
        public void error(NoViableAltException nvae) {
            dbg.recognitionException(nvae);
        }
    }
 

    public static final BitSet FOLLOW_mainStatement_in_compilationUnit92 = new BitSet(new long[]{0x0000000040007E00L});
    public static final BitSet FOLLOW_EOF_in_compilationUnit95 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_statement_in_mainStatement107 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableDeclarationList_in_statement122 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableAssignment_in_statement128 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_whileLoop_in_statement141 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableType_in_variableDeclarationList157 = new BitSet(new long[]{0x0000000000000200L});
    public static final BitSet FOLLOW_variableAssignment_in_variableDeclarationList159 = new BitSet(new long[]{0x0000000010000002L});
    public static final BitSet FOLLOW_28_in_variableDeclarationList162 = new BitSet(new long[]{0x0000000000000200L});
    public static final BitSet FOLLOW_variableAssignment_in_variableDeclarationList164 = new BitSet(new long[]{0x0000000010000002L});
    public static final BitSet FOLLOW_variableName_in_variableAssignment188 = new BitSet(new long[]{0x0000000020000002L});
    public static final BitSet FOLLOW_29_in_variableAssignment191 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_expression_in_variableAssignment193 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_variableName221 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_variableType0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_30_in_whileLoop265 = new BitSet(new long[]{0x0000000080000000L});
    public static final BitSet FOLLOW_31_in_whileLoop267 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_expression_in_whileLoop269 = new BitSet(new long[]{0x0000000100000000L});
    public static final BitSet FOLLOW_32_in_whileLoop271 = new BitSet(new long[]{0x0000000240007E00L});
    public static final BitSet FOLLOW_statement_in_whileLoop277 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_block_in_whileLoop292 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_33_in_block317 = new BitSet(new long[]{0x0000000440007E00L});
    public static final BitSet FOLLOW_statement_in_block319 = new BitSet(new long[]{0x0000000440007E00L});
    public static final BitSet FOLLOW_34_in_block322 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalExpression_in_expression377 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression418 = new BitSet(new long[]{0x0000000800000002L});
    public static final BitSet FOLLOW_35_in_conditionalExpression422 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_conditionalExpression_in_conditionalExpression425 = new BitSet(new long[]{0x0000001000000000L});
    public static final BitSet FOLLOW_36_in_conditionalExpression427 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_conditionalExpression_in_conditionalExpression430 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression473 = new BitSet(new long[]{0x0000002000000002L});
    public static final BitSet FOLLOW_37_in_conditionalOrExpression477 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression480 = new BitSet(new long[]{0x0000002000000002L});
    public static final BitSet FOLLOW_equalityExpression_in_conditionalAndExpression511 = new BitSet(new long[]{0x0000004000000002L});
    public static final BitSet FOLLOW_38_in_conditionalAndExpression515 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_equalityExpression_in_conditionalAndExpression518 = new BitSet(new long[]{0x0000004000000002L});
    public static final BitSet FOLLOW_relationalExpression_in_equalityExpression545 = new BitSet(new long[]{0x0000018000000002L});
    public static final BitSet FOLLOW_39_in_equalityExpression550 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_40_in_equalityExpression555 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_relationalExpression_in_equalityExpression559 = new BitSet(new long[]{0x0000018000000002L});
    public static final BitSet FOLLOW_additiveExpression_in_relationalExpression590 = new BitSet(new long[]{0x00001E0000000002L});
    public static final BitSet FOLLOW_41_in_relationalExpression594 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_42_in_relationalExpression597 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_43_in_relationalExpression600 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_44_in_relationalExpression603 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_additiveExpression_in_relationalExpression607 = new BitSet(new long[]{0x00001E0000000002L});
    public static final BitSet FOLLOW_multiplicativeExpression_in_additiveExpression645 = new BitSet(new long[]{0x0000600000000002L});
    public static final BitSet FOLLOW_45_in_additiveExpression649 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_46_in_additiveExpression652 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_multiplicativeExpression_in_additiveExpression656 = new BitSet(new long[]{0x0000600000000002L});
    public static final BitSet FOLLOW_negativeExpression_in_multiplicativeExpression690 = new BitSet(new long[]{0x0003800000000002L});
    public static final BitSet FOLLOW_47_in_multiplicativeExpression698 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_48_in_multiplicativeExpression701 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_49_in_multiplicativeExpression704 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_negativeExpression_in_multiplicativeExpression708 = new BitSet(new long[]{0x0003800000000002L});
    public static final BitSet FOLLOW_50_in_unaryExpression731 = new BitSet(new long[]{0x003C0000800B8200L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpression733 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_51_in_unaryExpression743 = new BitSet(new long[]{0x003C0000800B8200L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpression745 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression755 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_52_in_unaryExpressionNotPlusMinus776 = new BitSet(new long[]{0x003C0000800B8200L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus778 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus788 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus803 = new BitSet(new long[]{0x000C000000000002L});
    public static final BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus805 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_31_in_castExpression836 = new BitSet(new long[]{0x0000000000007C00L});
    public static final BitSet FOLLOW_variableType_in_castExpression838 = new BitSet(new long[]{0x0000000100000000L});
    public static final BitSet FOLLOW_32_in_castExpression840 = new BitSet(new long[]{0x003C0000800B8200L});
    public static final BitSet FOLLOW_unaryExpression_in_castExpression842 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mathAtom_in_negativeExpression860 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_46_in_negativeExpression870 = new BitSet(new long[]{0x00200000800B8200L});
    public static final BitSet FOLLOW_mathAtom_in_negativeExpression873 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_31_in_mathAtom895 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_additiveExpression_in_mathAtom898 = new BitSet(new long[]{0x0000000100000000L});
    public static final BitSet FOLLOW_32_in_mathAtom900 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_IntegerAtom_in_mathAtom911 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FloatAtom_in_mathAtom919 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BooleanAtom_in_mathAtom929 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_53_in_mathAtom940 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_SpriteAnimation_in_mathAtom942 = new BitSet(new long[]{0x0000000080000000L});
    public static final BitSet FOLLOW_arguments_in_mathAtom944 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_mathAtom959 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_mathAtom968 = new BitSet(new long[]{0x0000000080000000L});
    public static final BitSet FOLLOW_arguments_in_mathAtom970 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_stringQuote_in_mathAtom986 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_31_in_arguments1008 = new BitSet(new long[]{0x00204001800B8200L});
    public static final BitSet FOLLOW_expressionList_in_arguments1011 = new BitSet(new long[]{0x0000000100000000L});
    public static final BitSet FOLLOW_32_in_arguments1014 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_expression_in_expressionList1034 = new BitSet(new long[]{0x0000000010000002L});
    public static final BitSet FOLLOW_28_in_expressionList1037 = new BitSet(new long[]{0x00204000800B8200L});
    public static final BitSet FOLLOW_expression_in_expressionList1040 = new BitSet(new long[]{0x0000000010000002L});
    public static final BitSet FOLLOW_set_in_literal0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_StringAtom_in_stringQuote1139 = new BitSet(new long[]{0x0000000000000002L});

}