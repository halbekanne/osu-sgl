// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g 2011-07-07 23:06:08

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
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "VARDEF", "Identifier", "IntType", "BooleanType", "StringType", "FloatType", "IntegerAtom", "FloatAtom", "StringAtom", "BooleanAtom", "EscapeSequence", "ClassType", "Letter", "SGLIDDigit", "UnicodeEscape", "OctalEscape", "HEX_DIGIT", "WS", "COMMENT", "','", "'='", "'?'", "':'", "'||'", "'&&'", "'=='", "'!='", "'<'", "'>'", "'<='", "'>='", "'+'", "'-'", "'*'", "'/'", "'%'", "'++'", "'--'", "'!'", "'('", "')'", "'null'"
    };
    public static final int T__29=29;
    public static final int T__28=28;
    public static final int T__27=27;
    public static final int T__26=26;
    public static final int T__25=25;
    public static final int T__24=24;
    public static final int T__23=23;
    public static final int SGLIDDigit=17;
    public static final int IntType=6;
    public static final int EOF=-1;
    public static final int Identifier=5;
    public static final int StringType=8;
    public static final int COMMENT=22;
    public static final int VARDEF=4;
    public static final int BooleanType=7;
    public static final int T__42=42;
    public static final int T__43=43;
    public static final int T__40=40;
    public static final int T__41=41;
    public static final int T__44=44;
    public static final int T__45=45;
    public static final int IntegerAtom=10;
    public static final int FloatType=9;
    public static final int StringAtom=12;
    public static final int HEX_DIGIT=20;
    public static final int BooleanAtom=13;
    public static final int T__30=30;
    public static final int T__31=31;
    public static final int T__32=32;
    public static final int WS=21;
    public static final int T__33=33;
    public static final int T__34=34;
    public static final int T__35=35;
    public static final int T__36=36;
    public static final int T__37=37;
    public static final int T__38=38;
    public static final int T__39=39;
    public static final int UnicodeEscape=18;
    public static final int ClassType=15;
    public static final int FloatAtom=11;
    public static final int EscapeSequence=14;
    public static final int Letter=16;
    public static final int OctalEscape=19;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "variableName", "variableDefinition", "localVariableDeclarationStatement", 
        "unaryExpressionNotPlusMinus", "relationalExpression", "compilationUnit", 
        "mathAtom", "variableAssignmentStatement", "variableDefinitionList", 
        "equalityExpression", "variableDeclaration", "conditionalAndExpression", 
        "expression", "variableType", "unaryExpression", "conditionalExpression", 
        "simpleVariableDefinition", "multiplicativeExpression", "literal", 
        "additiveExpression", "statement", "castExpression", "conditionalOrExpression", 
        "arguments", "expressionList"
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:58:1: compilationUnit : ( statement )+ EOF ;
    public final SGLParser.compilationUnit_return compilationUnit() throws RecognitionException {
        SGLParser.compilationUnit_return retval = new SGLParser.compilationUnit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token EOF2=null;
        SGLParser.statement_return statement1 = null;


        Object EOF2_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "compilationUnit");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(58, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:59:2: ( ( statement )+ EOF )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:59:4: ( statement )+ EOF
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(59,4);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:59:4: ( statement )+
            int cnt1=0;
            try { dbg.enterSubRule(1);

            loop1:
            do {
                int alt1=2;
                try { dbg.enterDecision(1);

                int LA1_0 = input.LA(1);

                if ( ((LA1_0>=IntType && LA1_0<=FloatType)) ) {
                    alt1=1;
                }


                } finally {dbg.exitDecision(1);}

                switch (alt1) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:59:4: statement
            	    {
            	    dbg.location(59,4);
            	    pushFollow(FOLLOW_statement_in_compilationUnit76);
            	    statement1=statement();

            	    state._fsp--;

            	    adaptor.addChild(root_0, statement1.getTree());

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

            dbg.location(59,15);
            EOF2=(Token)match(input,EOF,FOLLOW_EOF_in_compilationUnit79); 
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
        dbg.location(60, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "compilationUnit");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "compilationUnit"

    public static class statement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "statement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:63:1: statement : variableDefinitionList ;
    public final SGLParser.statement_return statement() throws RecognitionException {
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.variableDefinitionList_return variableDefinitionList3 = null;



        try { dbg.enterRule(getGrammarFileName(), "statement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(63, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:65:2: ( variableDefinitionList )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:65:5: variableDefinitionList
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(65,5);
            pushFollow(FOLLOW_variableDefinitionList_in_statement94);
            variableDefinitionList3=variableDefinitionList();

            state._fsp--;

            adaptor.addChild(root_0, variableDefinitionList3.getTree());

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
        dbg.location(66, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "statement");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "statement"

    public static class variableDefinitionList_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableDefinitionList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:72:1: variableDefinitionList : variableType variableDefinition ( ',' variableDefinition )* -> ( ^( VARDEF variableType variableDefinition ) )+ ;
    public final SGLParser.variableDefinitionList_return variableDefinitionList() throws RecognitionException {
        SGLParser.variableDefinitionList_return retval = new SGLParser.variableDefinitionList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal6=null;
        SGLParser.variableType_return variableType4 = null;

        SGLParser.variableDefinition_return variableDefinition5 = null;

        SGLParser.variableDefinition_return variableDefinition7 = null;


        Object char_literal6_tree=null;
        RewriteRuleTokenStream stream_23=new RewriteRuleTokenStream(adaptor,"token 23");
        RewriteRuleSubtreeStream stream_variableType=new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableDefinition=new RewriteRuleSubtreeStream(adaptor,"rule variableDefinition");
        try { dbg.enterRule(getGrammarFileName(), "variableDefinitionList");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(72, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:2: ( variableType variableDefinition ( ',' variableDefinition )* -> ( ^( VARDEF variableType variableDefinition ) )+ )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:4: variableType variableDefinition ( ',' variableDefinition )*
            {
            dbg.location(73,4);
            pushFollow(FOLLOW_variableType_in_variableDefinitionList110);
            variableType4=variableType();

            state._fsp--;

            stream_variableType.add(variableType4.getTree());
            dbg.location(73,17);
            pushFollow(FOLLOW_variableDefinition_in_variableDefinitionList112);
            variableDefinition5=variableDefinition();

            state._fsp--;

            stream_variableDefinition.add(variableDefinition5.getTree());
            dbg.location(73,36);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:36: ( ',' variableDefinition )*
            try { dbg.enterSubRule(2);

            loop2:
            do {
                int alt2=2;
                try { dbg.enterDecision(2);

                int LA2_0 = input.LA(1);

                if ( (LA2_0==23) ) {
                    alt2=1;
                }


                } finally {dbg.exitDecision(2);}

                switch (alt2) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:37: ',' variableDefinition
            	    {
            	    dbg.location(73,37);
            	    char_literal6=(Token)match(input,23,FOLLOW_23_in_variableDefinitionList115);  
            	    stream_23.add(char_literal6);

            	    dbg.location(73,41);
            	    pushFollow(FOLLOW_variableDefinition_in_variableDefinitionList117);
            	    variableDefinition7=variableDefinition();

            	    state._fsp--;

            	    stream_variableDefinition.add(variableDefinition7.getTree());

            	    }
            	    break;

            	default :
            	    break loop2;
                }
            } while (true);
            } finally {dbg.exitSubRule(2);}



            // AST REWRITE
            // elements: variableDefinition, variableType
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 73:62: -> ( ^( VARDEF variableType variableDefinition ) )+
            {
                dbg.location(73,65);
                if ( !(stream_variableDefinition.hasNext()||stream_variableType.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_variableDefinition.hasNext()||stream_variableType.hasNext() ) {
                    dbg.location(73,65);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:73:65: ^( VARDEF variableType variableDefinition )
                    {
                    Object root_1 = (Object)adaptor.nil();
                    dbg.location(73,67);
                    root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(VARDEF, "VARDEF"), root_1);

                    dbg.location(73,74);
                    adaptor.addChild(root_1, stream_variableType.nextTree());
                    dbg.location(73,87);
                    adaptor.addChild(root_1, stream_variableDefinition.nextTree());

                    adaptor.addChild(root_0, root_1);
                    }

                }
                stream_variableDefinition.reset();
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
        dbg.location(74, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "variableDefinitionList");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "variableDefinitionList"

    public static class variableDefinition_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableDefinition"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:76:1: variableDefinition : variableName ( '=' expression )? -> variableName ( expression )? ;
    public final SGLParser.variableDefinition_return variableDefinition() throws RecognitionException {
        SGLParser.variableDefinition_return retval = new SGLParser.variableDefinition_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal9=null;
        SGLParser.variableName_return variableName8 = null;

        SGLParser.expression_return expression10 = null;


        Object char_literal9_tree=null;
        RewriteRuleTokenStream stream_24=new RewriteRuleTokenStream(adaptor,"token 24");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName=new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try { dbg.enterRule(getGrammarFileName(), "variableDefinition");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(76, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:4: variableName ( '=' expression )?
            {
            dbg.location(77,4);
            pushFollow(FOLLOW_variableName_in_variableDefinition141);
            variableName8=variableName();

            state._fsp--;

            stream_variableName.add(variableName8.getTree());
            dbg.location(77,17);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:17: ( '=' expression )?
            int alt3=2;
            try { dbg.enterSubRule(3);
            try { dbg.enterDecision(3);

            int LA3_0 = input.LA(1);

            if ( (LA3_0==24) ) {
                alt3=1;
            }
            } finally {dbg.exitDecision(3);}

            switch (alt3) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:18: '=' expression
                    {
                    dbg.location(77,18);
                    char_literal9=(Token)match(input,24,FOLLOW_24_in_variableDefinition144);  
                    stream_24.add(char_literal9);

                    dbg.location(77,22);
                    pushFollow(FOLLOW_expression_in_variableDefinition146);
                    expression10=expression();

                    state._fsp--;

                    stream_expression.add(expression10.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(3);}



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
            // 77:36: -> variableName ( expression )?
            {
                dbg.location(77,39);
                adaptor.addChild(root_0, stream_variableName.nextTree());
                dbg.location(77,52);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:52: ( expression )?
                if ( stream_expression.hasNext() ) {
                    dbg.location(77,52);
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
        dbg.location(78, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "variableDefinition");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "variableDefinition"

    public static class simpleVariableDefinition_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "simpleVariableDefinition"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:80:1: simpleVariableDefinition : variableType ;
    public final SGLParser.simpleVariableDefinition_return simpleVariableDefinition() throws RecognitionException {
        SGLParser.simpleVariableDefinition_return retval = new SGLParser.simpleVariableDefinition_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.variableType_return variableType11 = null;



        try { dbg.enterRule(getGrammarFileName(), "simpleVariableDefinition");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(80, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:81:2: ( variableType )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:81:4: variableType
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(81,4);
            pushFollow(FOLLOW_variableType_in_simpleVariableDefinition168);
            variableType11=variableType();

            state._fsp--;

            adaptor.addChild(root_0, variableType11.getTree());

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
        dbg.location(82, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "simpleVariableDefinition");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "simpleVariableDefinition"

    public static class localVariableDeclarationStatement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "localVariableDeclarationStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:84:1: localVariableDeclarationStatement : ( 'boolean' variableName ( '=' expression )? | 'int' variableName ( '=' expression )? );
    public final SGLParser.localVariableDeclarationStatement_return localVariableDeclarationStatement() throws RecognitionException {
        SGLParser.localVariableDeclarationStatement_return retval = new SGLParser.localVariableDeclarationStatement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal12=null;
        Token char_literal14=null;
        Token string_literal16=null;
        Token char_literal18=null;
        SGLParser.variableName_return variableName13 = null;

        SGLParser.expression_return expression15 = null;

        SGLParser.variableName_return variableName17 = null;

        SGLParser.expression_return expression19 = null;


        Object string_literal12_tree=null;
        Object char_literal14_tree=null;
        Object string_literal16_tree=null;
        Object char_literal18_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "localVariableDeclarationStatement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(84, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:2: ( 'boolean' variableName ( '=' expression )? | 'int' variableName ( '=' expression )? )
            int alt6=2;
            try { dbg.enterDecision(6);

            int LA6_0 = input.LA(1);

            if ( (LA6_0==BooleanType) ) {
                alt6=1;
            }
            else if ( (LA6_0==IntType) ) {
                alt6=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 6, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(6);}

            switch (alt6) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:5: 'boolean' variableName ( '=' expression )?
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(85,5);
                    string_literal12=(Token)match(input,BooleanType,FOLLOW_BooleanType_in_localVariableDeclarationStatement180); 
                    string_literal12_tree = (Object)adaptor.create(string_literal12);
                    adaptor.addChild(root_0, string_literal12_tree);

                    dbg.location(85,15);
                    pushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement182);
                    variableName13=variableName();

                    state._fsp--;

                    adaptor.addChild(root_0, variableName13.getTree());
                    dbg.location(85,28);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:28: ( '=' expression )?
                    int alt4=2;
                    try { dbg.enterSubRule(4);
                    try { dbg.enterDecision(4);

                    int LA4_0 = input.LA(1);

                    if ( (LA4_0==24) ) {
                        alt4=1;
                    }
                    } finally {dbg.exitDecision(4);}

                    switch (alt4) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:29: '=' expression
                            {
                            dbg.location(85,29);
                            char_literal14=(Token)match(input,24,FOLLOW_24_in_localVariableDeclarationStatement185); 
                            char_literal14_tree = (Object)adaptor.create(char_literal14);
                            adaptor.addChild(root_0, char_literal14_tree);

                            dbg.location(85,33);
                            pushFollow(FOLLOW_expression_in_localVariableDeclarationStatement187);
                            expression15=expression();

                            state._fsp--;

                            adaptor.addChild(root_0, expression15.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(4);}


                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:86:4: 'int' variableName ( '=' expression )?
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(86,4);
                    string_literal16=(Token)match(input,IntType,FOLLOW_IntType_in_localVariableDeclarationStatement194); 
                    string_literal16_tree = (Object)adaptor.create(string_literal16);
                    adaptor.addChild(root_0, string_literal16_tree);

                    dbg.location(86,10);
                    pushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement196);
                    variableName17=variableName();

                    state._fsp--;

                    adaptor.addChild(root_0, variableName17.getTree());
                    dbg.location(86,23);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:86:23: ( '=' expression )?
                    int alt5=2;
                    try { dbg.enterSubRule(5);
                    try { dbg.enterDecision(5);

                    int LA5_0 = input.LA(1);

                    if ( (LA5_0==24) ) {
                        alt5=1;
                    }
                    } finally {dbg.exitDecision(5);}

                    switch (alt5) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:86:24: '=' expression
                            {
                            dbg.location(86,24);
                            char_literal18=(Token)match(input,24,FOLLOW_24_in_localVariableDeclarationStatement199); 
                            char_literal18_tree = (Object)adaptor.create(char_literal18);
                            adaptor.addChild(root_0, char_literal18_tree);

                            dbg.location(86,28);
                            pushFollow(FOLLOW_expression_in_localVariableDeclarationStatement201);
                            expression19=expression();

                            state._fsp--;

                            adaptor.addChild(root_0, expression19.getTree());

                            }
                            break;

                    }
                    } finally {dbg.exitSubRule(5);}


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
        dbg.location(87, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "localVariableDeclarationStatement");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "localVariableDeclarationStatement"

    public static class variableAssignmentStatement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableAssignmentStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:90:1: variableAssignmentStatement : variableDeclaration ;
    public final SGLParser.variableAssignmentStatement_return variableAssignmentStatement() throws RecognitionException {
        SGLParser.variableAssignmentStatement_return retval = new SGLParser.variableAssignmentStatement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.variableDeclaration_return variableDeclaration20 = null;



        try { dbg.enterRule(getGrammarFileName(), "variableAssignmentStatement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(90, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:91:2: ( variableDeclaration )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:91:4: variableDeclaration
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(91,4);
            pushFollow(FOLLOW_variableDeclaration_in_variableAssignmentStatement216);
            variableDeclaration20=variableDeclaration();

            state._fsp--;

            adaptor.addChild(root_0, variableDeclaration20.getTree());

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
        dbg.location(92, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "variableAssignmentStatement");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "variableAssignmentStatement"

    public static class variableDeclaration_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableDeclaration"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:99:1: variableDeclaration : variableName ( '=' expression )? ;
    public final SGLParser.variableDeclaration_return variableDeclaration() throws RecognitionException {
        SGLParser.variableDeclaration_return retval = new SGLParser.variableDeclaration_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal22=null;
        SGLParser.variableName_return variableName21 = null;

        SGLParser.expression_return expression23 = null;


        Object char_literal22_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "variableDeclaration");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(99, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:100:2: ( variableName ( '=' expression )? )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:100:4: variableName ( '=' expression )?
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(100,4);
            pushFollow(FOLLOW_variableName_in_variableDeclaration235);
            variableName21=variableName();

            state._fsp--;

            adaptor.addChild(root_0, variableName21.getTree());
            dbg.location(100,17);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:100:17: ( '=' expression )?
            int alt7=2;
            try { dbg.enterSubRule(7);
            try { dbg.enterDecision(7);

            int LA7_0 = input.LA(1);

            if ( (LA7_0==24) ) {
                alt7=1;
            }
            } finally {dbg.exitDecision(7);}

            switch (alt7) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:100:18: '=' expression
                    {
                    dbg.location(100,18);
                    char_literal22=(Token)match(input,24,FOLLOW_24_in_variableDeclaration238); 
                    char_literal22_tree = (Object)adaptor.create(char_literal22);
                    adaptor.addChild(root_0, char_literal22_tree);

                    dbg.location(100,22);
                    pushFollow(FOLLOW_expression_in_variableDeclaration240);
                    expression23=expression();

                    state._fsp--;

                    adaptor.addChild(root_0, expression23.getTree());

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
        dbg.location(101, 2);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "variableDeclaration");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "variableDeclaration"

    public static class variableName_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableName"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:104:1: variableName : Identifier ;
    public final SGLParser.variableName_return variableName() throws RecognitionException {
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token Identifier24=null;

        Object Identifier24_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "variableName");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(104, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:105:2: ( Identifier )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:105:4: Identifier
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(105,4);
            Identifier24=(Token)match(input,Identifier,FOLLOW_Identifier_in_variableName256); 
            Identifier24_tree = (Object)adaptor.create(Identifier24);
            adaptor.addChild(root_0, Identifier24_tree);


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
        dbg.location(106, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:108:1: variableType : ( IntType | BooleanType | StringType | FloatType );
    public final SGLParser.variableType_return variableType() throws RecognitionException {
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set25=null;

        Object set25_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "variableType");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(108, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:109:2: ( IntType | BooleanType | StringType | FloatType )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(109,2);
            set25=(Token)input.LT(1);
            if ( (input.LA(1)>=IntType && input.LA(1)<=FloatType) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set25));
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

    public static class expression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "expression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:122:1: expression : conditionalExpression ;
    public final SGLParser.expression_return expression() throws RecognitionException {
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression26 = null;



        try { dbg.enterRule(getGrammarFileName(), "expression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(122, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:123:5: ( conditionalExpression )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:123:8: conditionalExpression
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(123,8);
            pushFollow(FOLLOW_conditionalExpression_in_expression320);
            conditionalExpression26=conditionalExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalExpression26.getTree());

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
        dbg.location(125, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:132:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public final SGLParser.conditionalExpression_return conditionalExpression() throws RecognitionException {
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal28=null;
        Token char_literal30=null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression27 = null;

        SGLParser.conditionalExpression_return conditionalExpression29 = null;

        SGLParser.conditionalExpression_return conditionalExpression31 = null;


        Object char_literal28_tree=null;
        Object char_literal30_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "conditionalExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(132, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:133:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:133:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(133,9);
            pushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression361);
            conditionalOrExpression27=conditionalOrExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalOrExpression27.getTree());
            dbg.location(133,33);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:133:33: ( '?' conditionalExpression ':' conditionalExpression )?
            int alt8=2;
            try { dbg.enterSubRule(8);
            try { dbg.enterDecision(8);

            int LA8_0 = input.LA(1);

            if ( (LA8_0==25) ) {
                alt8=1;
            }
            } finally {dbg.exitDecision(8);}

            switch (alt8) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:133:35: '?' conditionalExpression ':' conditionalExpression
                    {
                    dbg.location(133,35);
                    char_literal28=(Token)match(input,25,FOLLOW_25_in_conditionalExpression365); 
                    char_literal28_tree = (Object)adaptor.create(char_literal28);
                    adaptor.addChild(root_0, char_literal28_tree);

                    dbg.location(133,39);
                    pushFollow(FOLLOW_conditionalExpression_in_conditionalExpression367);
                    conditionalExpression29=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression29.getTree());
                    dbg.location(133,61);
                    char_literal30=(Token)match(input,26,FOLLOW_26_in_conditionalExpression369); 
                    char_literal30_tree = (Object)adaptor.create(char_literal30);
                    adaptor.addChild(root_0, char_literal30_tree);

                    dbg.location(133,64);
                    pushFollow(FOLLOW_conditionalExpression_in_conditionalExpression370);
                    conditionalExpression31=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression31.getTree());

                    }
                    break;

            }
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
        dbg.location(134, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:138:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public final SGLParser.conditionalOrExpression_return conditionalOrExpression() throws RecognitionException {
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal33=null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression32 = null;

        SGLParser.conditionalAndExpression_return conditionalAndExpression34 = null;


        Object string_literal33_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "conditionalOrExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(138, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:139:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:139:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(139,9);
            pushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression413);
            conditionalAndExpression32=conditionalAndExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalAndExpression32.getTree());
            dbg.location(139,34);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:139:34: ( '||' conditionalAndExpression )*
            try { dbg.enterSubRule(9);

            loop9:
            do {
                int alt9=2;
                try { dbg.enterDecision(9);

                int LA9_0 = input.LA(1);

                if ( (LA9_0==27) ) {
                    alt9=1;
                }


                } finally {dbg.exitDecision(9);}

                switch (alt9) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:139:36: '||' conditionalAndExpression
            	    {
            	    dbg.location(139,36);
            	    string_literal33=(Token)match(input,27,FOLLOW_27_in_conditionalOrExpression417); 
            	    string_literal33_tree = (Object)adaptor.create(string_literal33);
            	    adaptor.addChild(root_0, string_literal33_tree);

            	    dbg.location(139,41);
            	    pushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression419);
            	    conditionalAndExpression34=conditionalAndExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, conditionalAndExpression34.getTree());

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
        dbg.location(140, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:143:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public final SGLParser.conditionalAndExpression_return conditionalAndExpression() throws RecognitionException {
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal36=null;
        SGLParser.equalityExpression_return equalityExpression35 = null;

        SGLParser.equalityExpression_return equalityExpression37 = null;


        Object string_literal36_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "conditionalAndExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(143, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:144:5: ( equalityExpression ( '&&' equalityExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:144:9: equalityExpression ( '&&' equalityExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(144,9);
            pushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression450);
            equalityExpression35=equalityExpression();

            state._fsp--;

            adaptor.addChild(root_0, equalityExpression35.getTree());
            dbg.location(144,28);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:144:28: ( '&&' equalityExpression )*
            try { dbg.enterSubRule(10);

            loop10:
            do {
                int alt10=2;
                try { dbg.enterDecision(10);

                int LA10_0 = input.LA(1);

                if ( (LA10_0==28) ) {
                    alt10=1;
                }


                } finally {dbg.exitDecision(10);}

                switch (alt10) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:144:30: '&&' equalityExpression
            	    {
            	    dbg.location(144,30);
            	    string_literal36=(Token)match(input,28,FOLLOW_28_in_conditionalAndExpression454); 
            	    string_literal36_tree = (Object)adaptor.create(string_literal36);
            	    adaptor.addChild(root_0, string_literal36_tree);

            	    dbg.location(144,35);
            	    pushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression456);
            	    equalityExpression37=equalityExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, equalityExpression37.getTree());

            	    }
            	    break;

            	default :
            	    break loop10;
                }
            } while (true);
            } finally {dbg.exitSubRule(10);}


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
        dbg.location(145, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:148:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public final SGLParser.equalityExpression_return equalityExpression() throws RecognitionException {
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set39=null;
        SGLParser.relationalExpression_return relationalExpression38 = null;

        SGLParser.relationalExpression_return relationalExpression40 = null;


        Object set39_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "equalityExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(148, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:149:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:149:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(149,9);
            pushFollow(FOLLOW_relationalExpression_in_equalityExpression483);
            relationalExpression38=relationalExpression();

            state._fsp--;

            adaptor.addChild(root_0, relationalExpression38.getTree());
            dbg.location(149,30);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:149:30: ( ( '==' | '!=' ) relationalExpression )*
            try { dbg.enterSubRule(11);

            loop11:
            do {
                int alt11=2;
                try { dbg.enterDecision(11);

                int LA11_0 = input.LA(1);

                if ( ((LA11_0>=29 && LA11_0<=30)) ) {
                    alt11=1;
                }


                } finally {dbg.exitDecision(11);}

                switch (alt11) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:149:32: ( '==' | '!=' ) relationalExpression
            	    {
            	    dbg.location(149,32);
            	    set39=(Token)input.LT(1);
            	    if ( (input.LA(1)>=29 && input.LA(1)<=30) ) {
            	        input.consume();
            	        adaptor.addChild(root_0, (Object)adaptor.create(set39));
            	        state.errorRecovery=false;
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        dbg.recognitionException(mse);
            	        throw mse;
            	    }

            	    dbg.location(149,46);
            	    pushFollow(FOLLOW_relationalExpression_in_equalityExpression495);
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
        dbg.location(150, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:153:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public final SGLParser.relationalExpression_return relationalExpression() throws RecognitionException {
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set42=null;
        SGLParser.additiveExpression_return additiveExpression41 = null;

        SGLParser.additiveExpression_return additiveExpression43 = null;


        Object set42_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "relationalExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(153, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:154:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:154:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(154,9);
            pushFollow(FOLLOW_additiveExpression_in_relationalExpression526);
            additiveExpression41=additiveExpression();

            state._fsp--;

            adaptor.addChild(root_0, additiveExpression41.getTree());
            dbg.location(154,28);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:154:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            try { dbg.enterSubRule(12);

            loop12:
            do {
                int alt12=2;
                try { dbg.enterDecision(12);

                int LA12_0 = input.LA(1);

                if ( ((LA12_0>=31 && LA12_0<=34)) ) {
                    alt12=1;
                }


                } finally {dbg.exitDecision(12);}

                switch (alt12) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:154:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            	    {
            	    dbg.location(154,29);
            	    set42=(Token)input.LT(1);
            	    if ( (input.LA(1)>=31 && input.LA(1)<=34) ) {
            	        input.consume();
            	        adaptor.addChild(root_0, (Object)adaptor.create(set42));
            	        state.errorRecovery=false;
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        dbg.recognitionException(mse);
            	        throw mse;
            	    }

            	    dbg.location(154,49);
            	    pushFollow(FOLLOW_additiveExpression_in_relationalExpression539);
            	    additiveExpression43=additiveExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, additiveExpression43.getTree());

            	    }
            	    break;

            	default :
            	    break loop12;
                }
            } while (true);
            } finally {dbg.exitSubRule(12);}


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
        dbg.location(155, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:158:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public final SGLParser.additiveExpression_return additiveExpression() throws RecognitionException {
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal45=null;
        Token char_literal46=null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression44 = null;

        SGLParser.multiplicativeExpression_return multiplicativeExpression47 = null;


        Object char_literal45_tree=null;
        Object char_literal46_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "additiveExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(158, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(159,9);
            pushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression577);
            multiplicativeExpression44=multiplicativeExpression();

            state._fsp--;

            adaptor.addChild(root_0, multiplicativeExpression44.getTree());
            dbg.location(159,34);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:34: ( ( '+' | '-' ) multiplicativeExpression )*
            try { dbg.enterSubRule(14);

            loop14:
            do {
                int alt14=2;
                try { dbg.enterDecision(14);

                int LA14_0 = input.LA(1);

                if ( ((LA14_0>=35 && LA14_0<=36)) ) {
                    alt14=1;
                }


                } finally {dbg.exitDecision(14);}

                switch (alt14) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:35: ( '+' | '-' ) multiplicativeExpression
            	    {
            	    dbg.location(159,35);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:35: ( '+' | '-' )
            	    int alt13=2;
            	    try { dbg.enterSubRule(13);
            	    try { dbg.enterDecision(13);

            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0==35) ) {
            	        alt13=1;
            	    }
            	    else if ( (LA13_0==36) ) {
            	        alt13=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 13, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }
            	    } finally {dbg.exitDecision(13);}

            	    switch (alt13) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:36: '+'
            	            {
            	            dbg.location(159,39);
            	            char_literal45=(Token)match(input,35,FOLLOW_35_in_additiveExpression581); 
            	            char_literal45_tree = (Object)adaptor.create(char_literal45);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal45_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:159:41: '-'
            	            {
            	            dbg.location(159,44);
            	            char_literal46=(Token)match(input,36,FOLLOW_36_in_additiveExpression584); 
            	            char_literal46_tree = (Object)adaptor.create(char_literal46);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal46_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(13);}

            	    dbg.location(159,47);
            	    pushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression588);
            	    multiplicativeExpression47=multiplicativeExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, multiplicativeExpression47.getTree());

            	    }
            	    break;

            	default :
            	    break loop14;
                }
            } while (true);
            } finally {dbg.exitSubRule(14);}


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
        dbg.location(160, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:163:1: multiplicativeExpression : e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* ;
    public final SGLParser.multiplicativeExpression_return multiplicativeExpression() throws RecognitionException {
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal48=null;
        Token char_literal49=null;
        Token char_literal50=null;
        SGLParser.mathAtom_return e = null;


        Object char_literal48_tree=null;
        Object char_literal49_tree=null;
        Object char_literal50_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "multiplicativeExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(163, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:164:5: (e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:164:9: e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(164,10);
            pushFollow(FOLLOW_mathAtom_in_multiplicativeExpression624);
            e=mathAtom();

            state._fsp--;

            adaptor.addChild(root_0, e.getTree());
            dbg.location(165,5);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:165:5: ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            try { dbg.enterSubRule(15);

            loop15:
            do {
                int alt15=4;
                try { dbg.enterDecision(15);

                switch ( input.LA(1) ) {
                case 37:
                    {
                    alt15=1;
                    }
                    break;
                case 38:
                    {
                    alt15=2;
                    }
                    break;
                case 39:
                    {
                    alt15=3;
                    }
                    break;

                }

                } finally {dbg.exitDecision(15);}

                switch (alt15) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:165:7: '*' e= mathAtom
            	    {
            	    dbg.location(165,7);
            	    char_literal48=(Token)match(input,37,FOLLOW_37_in_multiplicativeExpression632); 
            	    char_literal48_tree = (Object)adaptor.create(char_literal48);
            	    adaptor.addChild(root_0, char_literal48_tree);

            	    dbg.location(165,12);
            	    pushFollow(FOLLOW_mathAtom_in_multiplicativeExpression636);
            	    e=mathAtom();

            	    state._fsp--;

            	    adaptor.addChild(root_0, e.getTree());

            	    }
            	    break;
            	case 2 :
            	    dbg.enterAlt(2);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:7: '/' e= mathAtom
            	    {
            	    dbg.location(166,7);
            	    char_literal49=(Token)match(input,38,FOLLOW_38_in_multiplicativeExpression644); 
            	    char_literal49_tree = (Object)adaptor.create(char_literal49);
            	    adaptor.addChild(root_0, char_literal49_tree);

            	    dbg.location(166,12);
            	    pushFollow(FOLLOW_mathAtom_in_multiplicativeExpression648);
            	    e=mathAtom();

            	    state._fsp--;

            	    adaptor.addChild(root_0, e.getTree());

            	    }
            	    break;
            	case 3 :
            	    dbg.enterAlt(3);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:167:7: '%' e= mathAtom
            	    {
            	    dbg.location(167,7);
            	    char_literal50=(Token)match(input,39,FOLLOW_39_in_multiplicativeExpression656); 
            	    char_literal50_tree = (Object)adaptor.create(char_literal50);
            	    adaptor.addChild(root_0, char_literal50_tree);

            	    dbg.location(167,12);
            	    pushFollow(FOLLOW_mathAtom_in_multiplicativeExpression660);
            	    e=mathAtom();

            	    state._fsp--;

            	    adaptor.addChild(root_0, e.getTree());

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
        dbg.location(169, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public final SGLParser.unaryExpression_return unaryExpression() throws RecognitionException {
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal51=null;
        Token string_literal53=null;
        SGLParser.unaryExpression_return unaryExpression52 = null;

        SGLParser.unaryExpression_return unaryExpression54 = null;

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus55 = null;


        Object string_literal51_tree=null;
        Object string_literal53_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unaryExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(171, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:172:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt16=3;
            try { dbg.enterDecision(16);

            switch ( input.LA(1) ) {
            case 40:
                {
                alt16=1;
                }
                break;
            case 41:
                {
                alt16=2;
                }
                break;
            case IntegerAtom:
            case 36:
            case 42:
            case 43:
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

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:172:7: '++' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(172,7);
                    string_literal51=(Token)match(input,40,FOLLOW_40_in_unaryExpression688); 
                    string_literal51_tree = (Object)adaptor.create(string_literal51);
                    adaptor.addChild(root_0, string_literal51_tree);

                    dbg.location(172,12);
                    pushFollow(FOLLOW_unaryExpression_in_unaryExpression690);
                    unaryExpression52=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression52.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:173:9: '--' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(173,9);
                    string_literal53=(Token)match(input,41,FOLLOW_41_in_unaryExpression700); 
                    string_literal53_tree = (Object)adaptor.create(string_literal53);
                    adaptor.addChild(root_0, string_literal53_tree);

                    dbg.location(173,14);
                    pushFollow(FOLLOW_unaryExpression_in_unaryExpression702);
                    unaryExpression54=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression54.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:174:9: unaryExpressionNotPlusMinus
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(174,9);
                    pushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression712);
                    unaryExpressionNotPlusMinus55=unaryExpressionNotPlusMinus();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpressionNotPlusMinus55.getTree());

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
        dbg.location(175, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:178:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public final SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() throws RecognitionException {
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal56=null;
        Token set60=null;
        SGLParser.unaryExpression_return unaryExpression57 = null;

        SGLParser.castExpression_return castExpression58 = null;

        SGLParser.mathAtom_return mathAtom59 = null;


        Object char_literal56_tree=null;
        Object set60_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unaryExpressionNotPlusMinus");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(178, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt18=3;
            try { dbg.enterDecision(18);

            switch ( input.LA(1) ) {
            case 42:
                {
                alt18=1;
                }
                break;
            case 43:
                {
                int LA18_2 = input.LA(2);

                if ( (LA18_2==IntegerAtom||LA18_2==36||LA18_2==43) ) {
                    alt18=3;
                }
                else if ( ((LA18_2>=IntType && LA18_2<=FloatType)) ) {
                    alt18=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 18, 2, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
                }
                break;
            case IntegerAtom:
            case 36:
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

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:179:9: '!' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(179,9);
                    char_literal56=(Token)match(input,42,FOLLOW_42_in_unaryExpressionNotPlusMinus733); 
                    char_literal56_tree = (Object)adaptor.create(char_literal56);
                    adaptor.addChild(root_0, char_literal56_tree);

                    dbg.location(179,13);
                    pushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus735);
                    unaryExpression57=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression57.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:180:9: castExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(180,9);
                    pushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus745);
                    castExpression58=castExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, castExpression58.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:182:9: mathAtom ( '++' | '--' )?
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(182,9);
                    pushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus760);
                    mathAtom59=mathAtom();

                    state._fsp--;

                    adaptor.addChild(root_0, mathAtom59.getTree());
                    dbg.location(182,18);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:182:18: ( '++' | '--' )?
                    int alt17=2;
                    try { dbg.enterSubRule(17);
                    try { dbg.enterDecision(17);

                    int LA17_0 = input.LA(1);

                    if ( ((LA17_0>=40 && LA17_0<=41)) ) {
                        alt17=1;
                    }
                    } finally {dbg.exitDecision(17);}

                    switch (alt17) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
                            {
                            dbg.location(182,18);
                            set60=(Token)input.LT(1);
                            if ( (input.LA(1)>=40 && input.LA(1)<=41) ) {
                                input.consume();
                                adaptor.addChild(root_0, (Object)adaptor.create(set60));
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
                    } finally {dbg.exitSubRule(17);}


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
        dbg.location(183, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:186:1: castExpression : '(' variableType ')' unaryExpression ;
    public final SGLParser.castExpression_return castExpression() throws RecognitionException {
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal61=null;
        Token char_literal63=null;
        SGLParser.variableType_return variableType62 = null;

        SGLParser.unaryExpression_return unaryExpression64 = null;


        Object char_literal61_tree=null;
        Object char_literal63_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "castExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(186, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:187:5: ( '(' variableType ')' unaryExpression )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:187:8: '(' variableType ')' unaryExpression
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(187,8);
            char_literal61=(Token)match(input,43,FOLLOW_43_in_castExpression793); 
            char_literal61_tree = (Object)adaptor.create(char_literal61);
            adaptor.addChild(root_0, char_literal61_tree);

            dbg.location(187,12);
            pushFollow(FOLLOW_variableType_in_castExpression795);
            variableType62=variableType();

            state._fsp--;

            adaptor.addChild(root_0, variableType62.getTree());
            dbg.location(187,25);
            char_literal63=(Token)match(input,44,FOLLOW_44_in_castExpression797); 
            char_literal63_tree = (Object)adaptor.create(char_literal63);
            adaptor.addChild(root_0, char_literal63_tree);

            dbg.location(187,29);
            pushFollow(FOLLOW_unaryExpression_in_castExpression799);
            unaryExpression64=unaryExpression();

            state._fsp--;

            adaptor.addChild(root_0, unaryExpression64.getTree());

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
        dbg.location(188, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "castExpression");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "castExpression"

    public static class mathAtom_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "mathAtom"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:191:1: mathAtom : ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) ;
    public final SGLParser.mathAtom_return mathAtom() throws RecognitionException {
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token i=null;
        Token char_literal65=null;
        Token char_literal66=null;
        Token char_literal67=null;
        SGLParser.additiveExpression_return e = null;


        Object i_tree=null;
        Object char_literal65_tree=null;
        Object char_literal66_tree=null;
        Object char_literal67_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "mathAtom");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(191, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:192:5: ( ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:192:9: ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom )
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(192,9);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:192:9: ( '-' )?
            int alt19=2;
            try { dbg.enterSubRule(19);
            try { dbg.enterDecision(19);

            int LA19_0 = input.LA(1);

            if ( (LA19_0==36) ) {
                alt19=1;
            }
            } finally {dbg.exitDecision(19);}

            switch (alt19) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:192:10: '-'
                    {
                    dbg.location(192,10);
                    char_literal65=(Token)match(input,36,FOLLOW_36_in_mathAtom822); 
                    char_literal65_tree = (Object)adaptor.create(char_literal65);
                    adaptor.addChild(root_0, char_literal65_tree);


                    }
                    break;

            }
            } finally {dbg.exitSubRule(19);}

            dbg.location(193,5);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:193:5: ( '(' e= additiveExpression ')' | i= IntegerAtom )
            int alt20=2;
            try { dbg.enterSubRule(20);
            try { dbg.enterDecision(20);

            int LA20_0 = input.LA(1);

            if ( (LA20_0==43) ) {
                alt20=1;
            }
            else if ( (LA20_0==IntegerAtom) ) {
                alt20=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 20, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(20);}

            switch (alt20) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:193:7: '(' e= additiveExpression ')'
                    {
                    dbg.location(193,7);
                    char_literal66=(Token)match(input,43,FOLLOW_43_in_mathAtom833); 
                    char_literal66_tree = (Object)adaptor.create(char_literal66);
                    adaptor.addChild(root_0, char_literal66_tree);

                    dbg.location(193,12);
                    pushFollow(FOLLOW_additiveExpression_in_mathAtom837);
                    e=additiveExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, e.getTree());
                    dbg.location(193,32);
                    char_literal67=(Token)match(input,44,FOLLOW_44_in_mathAtom839); 
                    char_literal67_tree = (Object)adaptor.create(char_literal67);
                    adaptor.addChild(root_0, char_literal67_tree);


                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:194:9: i= IntegerAtom
                    {
                    dbg.location(194,10);
                    i=(Token)match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom851); 
                    i_tree = (Object)adaptor.create(i);
                    adaptor.addChild(root_0, i_tree);


                    }
                    break;

            }
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
        dbg.location(199, 6);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:202:1: arguments : '(' ( expressionList )? ')' ;
    public final SGLParser.arguments_return arguments() throws RecognitionException {
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal68=null;
        Token char_literal70=null;
        SGLParser.expressionList_return expressionList69 = null;


        Object char_literal68_tree=null;
        Object char_literal70_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "arguments");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(202, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:5: ( '(' ( expressionList )? ')' )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:9: '(' ( expressionList )? ')'
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(203,9);
            char_literal68=(Token)match(input,43,FOLLOW_43_in_arguments888); 
            char_literal68_tree = (Object)adaptor.create(char_literal68);
            adaptor.addChild(root_0, char_literal68_tree);

            dbg.location(203,13);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:13: ( expressionList )?
            int alt21=2;
            try { dbg.enterSubRule(21);
            try { dbg.enterDecision(21);

            int LA21_0 = input.LA(1);

            if ( (LA21_0==IntegerAtom||LA21_0==36||LA21_0==43) ) {
                alt21=1;
            }
            } finally {dbg.exitDecision(21);}

            switch (alt21) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:13: expressionList
                    {
                    dbg.location(203,13);
                    pushFollow(FOLLOW_expressionList_in_arguments890);
                    expressionList69=expressionList();

                    state._fsp--;

                    adaptor.addChild(root_0, expressionList69.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(21);}

            dbg.location(203,29);
            char_literal70=(Token)match(input,44,FOLLOW_44_in_arguments893); 
            char_literal70_tree = (Object)adaptor.create(char_literal70);
            adaptor.addChild(root_0, char_literal70_tree);


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
        dbg.location(204, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:206:1: expressionList : expression ( ',' expression )* ;
    public final SGLParser.expressionList_return expressionList() throws RecognitionException {
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal72=null;
        SGLParser.expression_return expression71 = null;

        SGLParser.expression_return expression73 = null;


        Object char_literal72_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "expressionList");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(206, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:207:5: ( expression ( ',' expression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:207:9: expression ( ',' expression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(207,9);
            pushFollow(FOLLOW_expression_in_expressionList912);
            expression71=expression();

            state._fsp--;

            adaptor.addChild(root_0, expression71.getTree());
            dbg.location(207,20);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:207:20: ( ',' expression )*
            try { dbg.enterSubRule(22);

            loop22:
            do {
                int alt22=2;
                try { dbg.enterDecision(22);

                int LA22_0 = input.LA(1);

                if ( (LA22_0==23) ) {
                    alt22=1;
                }


                } finally {dbg.exitDecision(22);}

                switch (alt22) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:207:21: ',' expression
            	    {
            	    dbg.location(207,21);
            	    char_literal72=(Token)match(input,23,FOLLOW_23_in_expressionList915); 
            	    char_literal72_tree = (Object)adaptor.create(char_literal72);
            	    adaptor.addChild(root_0, char_literal72_tree);

            	    dbg.location(207,25);
            	    pushFollow(FOLLOW_expression_in_expressionList917);
            	    expression73=expression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, expression73.getTree());

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
        dbg.location(208, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:212:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public final SGLParser.literal_return literal() throws RecognitionException {
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set74=null;

        Object set74_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "literal");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(212, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:213:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(213,5);
            set74=(Token)input.LT(1);
            if ( (input.LA(1)>=IntegerAtom && input.LA(1)<=BooleanAtom)||input.LA(1)==45 ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set74));
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
        dbg.location(218, 5);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "literal");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "literal"

    // Delegated rules


 

    public static final BitSet FOLLOW_statement_in_compilationUnit76 = new BitSet(new long[]{0x00000000000003C0L});
    public static final BitSet FOLLOW_EOF_in_compilationUnit79 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableDefinitionList_in_statement94 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableType_in_variableDefinitionList110 = new BitSet(new long[]{0x0000000000000020L});
    public static final BitSet FOLLOW_variableDefinition_in_variableDefinitionList112 = new BitSet(new long[]{0x0000000000800002L});
    public static final BitSet FOLLOW_23_in_variableDefinitionList115 = new BitSet(new long[]{0x0000000000000020L});
    public static final BitSet FOLLOW_variableDefinition_in_variableDefinitionList117 = new BitSet(new long[]{0x0000000000800002L});
    public static final BitSet FOLLOW_variableName_in_variableDefinition141 = new BitSet(new long[]{0x0000000001000002L});
    public static final BitSet FOLLOW_24_in_variableDefinition144 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_expression_in_variableDefinition146 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableType_in_simpleVariableDefinition168 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BooleanType_in_localVariableDeclarationStatement180 = new BitSet(new long[]{0x0000000000000020L});
    public static final BitSet FOLLOW_variableName_in_localVariableDeclarationStatement182 = new BitSet(new long[]{0x0000000001000002L});
    public static final BitSet FOLLOW_24_in_localVariableDeclarationStatement185 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_expression_in_localVariableDeclarationStatement187 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_IntType_in_localVariableDeclarationStatement194 = new BitSet(new long[]{0x0000000000000020L});
    public static final BitSet FOLLOW_variableName_in_localVariableDeclarationStatement196 = new BitSet(new long[]{0x0000000001000002L});
    public static final BitSet FOLLOW_24_in_localVariableDeclarationStatement199 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_expression_in_localVariableDeclarationStatement201 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableDeclaration_in_variableAssignmentStatement216 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableName_in_variableDeclaration235 = new BitSet(new long[]{0x0000000001000002L});
    public static final BitSet FOLLOW_24_in_variableDeclaration238 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_expression_in_variableDeclaration240 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_variableName256 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_variableType0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalExpression_in_expression320 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression361 = new BitSet(new long[]{0x0000000002000002L});
    public static final BitSet FOLLOW_25_in_conditionalExpression365 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_conditionalExpression_in_conditionalExpression367 = new BitSet(new long[]{0x0000000004000000L});
    public static final BitSet FOLLOW_26_in_conditionalExpression369 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_conditionalExpression_in_conditionalExpression370 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression413 = new BitSet(new long[]{0x0000000008000002L});
    public static final BitSet FOLLOW_27_in_conditionalOrExpression417 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression419 = new BitSet(new long[]{0x0000000008000002L});
    public static final BitSet FOLLOW_equalityExpression_in_conditionalAndExpression450 = new BitSet(new long[]{0x0000000010000002L});
    public static final BitSet FOLLOW_28_in_conditionalAndExpression454 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_equalityExpression_in_conditionalAndExpression456 = new BitSet(new long[]{0x0000000010000002L});
    public static final BitSet FOLLOW_relationalExpression_in_equalityExpression483 = new BitSet(new long[]{0x0000000060000002L});
    public static final BitSet FOLLOW_set_in_equalityExpression487 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_relationalExpression_in_equalityExpression495 = new BitSet(new long[]{0x0000000060000002L});
    public static final BitSet FOLLOW_additiveExpression_in_relationalExpression526 = new BitSet(new long[]{0x0000000780000002L});
    public static final BitSet FOLLOW_set_in_relationalExpression529 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_additiveExpression_in_relationalExpression539 = new BitSet(new long[]{0x0000000780000002L});
    public static final BitSet FOLLOW_multiplicativeExpression_in_additiveExpression577 = new BitSet(new long[]{0x0000001800000002L});
    public static final BitSet FOLLOW_35_in_additiveExpression581 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_36_in_additiveExpression584 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_multiplicativeExpression_in_additiveExpression588 = new BitSet(new long[]{0x0000001800000002L});
    public static final BitSet FOLLOW_mathAtom_in_multiplicativeExpression624 = new BitSet(new long[]{0x000000E000000002L});
    public static final BitSet FOLLOW_37_in_multiplicativeExpression632 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_mathAtom_in_multiplicativeExpression636 = new BitSet(new long[]{0x000000E000000002L});
    public static final BitSet FOLLOW_38_in_multiplicativeExpression644 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_mathAtom_in_multiplicativeExpression648 = new BitSet(new long[]{0x000000E000000002L});
    public static final BitSet FOLLOW_39_in_multiplicativeExpression656 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_mathAtom_in_multiplicativeExpression660 = new BitSet(new long[]{0x000000E000000002L});
    public static final BitSet FOLLOW_40_in_unaryExpression688 = new BitSet(new long[]{0x00000F1000000400L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpression690 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_41_in_unaryExpression700 = new BitSet(new long[]{0x00000F1000000400L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpression702 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression712 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_42_in_unaryExpressionNotPlusMinus733 = new BitSet(new long[]{0x00000F1000000400L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus735 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus745 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus760 = new BitSet(new long[]{0x0000030000000002L});
    public static final BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus762 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_43_in_castExpression793 = new BitSet(new long[]{0x00000000000003C0L});
    public static final BitSet FOLLOW_variableType_in_castExpression795 = new BitSet(new long[]{0x0000100000000000L});
    public static final BitSet FOLLOW_44_in_castExpression797 = new BitSet(new long[]{0x00000F1000000400L});
    public static final BitSet FOLLOW_unaryExpression_in_castExpression799 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_36_in_mathAtom822 = new BitSet(new long[]{0x0000080000000400L});
    public static final BitSet FOLLOW_43_in_mathAtom833 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_additiveExpression_in_mathAtom837 = new BitSet(new long[]{0x0000100000000000L});
    public static final BitSet FOLLOW_44_in_mathAtom839 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_IntegerAtom_in_mathAtom851 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_43_in_arguments888 = new BitSet(new long[]{0x0000181000000400L});
    public static final BitSet FOLLOW_expressionList_in_arguments890 = new BitSet(new long[]{0x0000100000000000L});
    public static final BitSet FOLLOW_44_in_arguments893 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_expression_in_expressionList912 = new BitSet(new long[]{0x0000000000800002L});
    public static final BitSet FOLLOW_23_in_expressionList915 = new BitSet(new long[]{0x0000081000000400L});
    public static final BitSet FOLLOW_expression_in_expressionList917 = new BitSet(new long[]{0x0000000000800002L});
    public static final BitSet FOLLOW_set_in_literal0 = new BitSet(new long[]{0x0000000000000002L});

}