// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g 2011-07-08 18:35:30

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
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "VARDEF", "NEGATE", "LIBMETHOD", "Identifier", "IntType", "BooleanType", "StringType", "FloatType", "IntegerAtom", "FloatAtom", "StringAtom", "BooleanAtom", "EscapeSequence", "ClassType", "Letter", "SGLIDDigit", "UnicodeEscape", "OctalEscape", "HEX_DIGIT", "WS", "COMMENT", "','", "'='", "'?'", "':'", "'||'", "'&&'", "'=='", "'!='", "'<'", "'>'", "'<='", "'>='", "'+'", "'-'", "'*'", "'/'", "'%'", "'++'", "'--'", "'!'", "'('", "')'", "'null'"
    };
    public static final int T__29=29;
    public static final int T__28=28;
    public static final int T__27=27;
    public static final int T__26=26;
    public static final int T__25=25;
    public static final int SGLIDDigit=19;
    public static final int IntType=8;
    public static final int EOF=-1;
    public static final int Identifier=7;
    public static final int StringType=10;
    public static final int COMMENT=24;
    public static final int VARDEF=4;
    public static final int BooleanType=9;
    public static final int T__42=42;
    public static final int T__43=43;
    public static final int T__40=40;
    public static final int T__41=41;
    public static final int T__46=46;
    public static final int T__47=47;
    public static final int T__44=44;
    public static final int T__45=45;
    public static final int LIBMETHOD=6;
    public static final int IntegerAtom=12;
    public static final int FloatType=11;
    public static final int StringAtom=14;
    public static final int HEX_DIGIT=22;
    public static final int NEGATE=5;
    public static final int BooleanAtom=15;
    public static final int T__30=30;
    public static final int T__31=31;
    public static final int T__32=32;
    public static final int WS=23;
    public static final int T__33=33;
    public static final int T__34=34;
    public static final int T__35=35;
    public static final int T__36=36;
    public static final int T__37=37;
    public static final int T__38=38;
    public static final int T__39=39;
    public static final int UnicodeEscape=20;
    public static final int ClassType=17;
    public static final int FloatAtom=13;
    public static final int OctalEscape=21;
    public static final int EscapeSequence=16;
    public static final int Letter=18;

    // delegates
    // delegators

    public static final String[] ruleNames = new String[] {
        "invalidRule", "localVariableDeclarationStatement", "negativeExpression", 
        "variableType", "variableDefinition", "mathAtom", "expressionList", 
        "conditionalExpression", "expression", "simpleVariableDefinition", 
        "relationalExpression", "variableAssignmentStatement", "literal", 
        "variableName", "compilationUnit", "multiplicativeExpression", "variableDefinitionList", 
        "statement", "conditionalAndExpression", "conditionalOrExpression", 
        "equalityExpression", "arguments", "additiveExpression", "variableDeclaration", 
        "unaryExpression", "castExpression", "unaryExpressionNotPlusMinus"
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:70:1: compilationUnit : ( statement )+ EOF ;
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
        dbg.location(70, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:71:2: ( ( statement )+ EOF )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:71:4: ( statement )+ EOF
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(71,4);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:71:4: ( statement )+
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

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:71:4: statement
            	    {
            	    dbg.location(71,4);
            	    pushFollow(FOLLOW_statement_in_compilationUnit84);
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

            dbg.location(71,15);
            EOF2=(Token)match(input,EOF,FOLLOW_EOF_in_compilationUnit87); 
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
        dbg.location(72, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:75:1: statement : variableDefinitionList ;
    public final SGLParser.statement_return statement() throws RecognitionException {
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.variableDefinitionList_return variableDefinitionList3 = null;



        try { dbg.enterRule(getGrammarFileName(), "statement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(75, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:2: ( variableDefinitionList )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:77:5: variableDefinitionList
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(77,5);
            pushFollow(FOLLOW_variableDefinitionList_in_statement102);
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
        dbg.location(78, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:84:1: variableDefinitionList : variableType variableDefinition ( ',' variableDefinition )* -> ( ^( VARDEF variableType variableDefinition ) )+ ;
    public final SGLParser.variableDefinitionList_return variableDefinitionList() throws RecognitionException {
        SGLParser.variableDefinitionList_return retval = new SGLParser.variableDefinitionList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal6=null;
        SGLParser.variableType_return variableType4 = null;

        SGLParser.variableDefinition_return variableDefinition5 = null;

        SGLParser.variableDefinition_return variableDefinition7 = null;


        Object char_literal6_tree=null;
        RewriteRuleTokenStream stream_25=new RewriteRuleTokenStream(adaptor,"token 25");
        RewriteRuleSubtreeStream stream_variableType=new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableDefinition=new RewriteRuleSubtreeStream(adaptor,"rule variableDefinition");
        try { dbg.enterRule(getGrammarFileName(), "variableDefinitionList");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(84, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:2: ( variableType variableDefinition ( ',' variableDefinition )* -> ( ^( VARDEF variableType variableDefinition ) )+ )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:4: variableType variableDefinition ( ',' variableDefinition )*
            {
            dbg.location(85,4);
            pushFollow(FOLLOW_variableType_in_variableDefinitionList118);
            variableType4=variableType();

            state._fsp--;

            stream_variableType.add(variableType4.getTree());
            dbg.location(85,17);
            pushFollow(FOLLOW_variableDefinition_in_variableDefinitionList120);
            variableDefinition5=variableDefinition();

            state._fsp--;

            stream_variableDefinition.add(variableDefinition5.getTree());
            dbg.location(85,36);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:36: ( ',' variableDefinition )*
            try { dbg.enterSubRule(2);

            loop2:
            do {
                int alt2=2;
                try { dbg.enterDecision(2);

                int LA2_0 = input.LA(1);

                if ( (LA2_0==25) ) {
                    alt2=1;
                }


                } finally {dbg.exitDecision(2);}

                switch (alt2) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:37: ',' variableDefinition
            	    {
            	    dbg.location(85,37);
            	    char_literal6=(Token)match(input,25,FOLLOW_25_in_variableDefinitionList123);  
            	    stream_25.add(char_literal6);

            	    dbg.location(85,41);
            	    pushFollow(FOLLOW_variableDefinition_in_variableDefinitionList125);
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
            // elements: variableType, variableDefinition
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 85:62: -> ( ^( VARDEF variableType variableDefinition ) )+
            {
                dbg.location(85,65);
                if ( !(stream_variableType.hasNext()||stream_variableDefinition.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_variableType.hasNext()||stream_variableDefinition.hasNext() ) {
                    dbg.location(85,65);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:85:65: ^( VARDEF variableType variableDefinition )
                    {
                    Object root_1 = (Object)adaptor.nil();
                    dbg.location(85,67);
                    root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(VARDEF, "VARDEF"), root_1);

                    dbg.location(85,74);
                    adaptor.addChild(root_1, stream_variableType.nextTree());
                    dbg.location(85,87);
                    adaptor.addChild(root_1, stream_variableDefinition.nextTree());

                    adaptor.addChild(root_0, root_1);
                    }

                }
                stream_variableType.reset();
                stream_variableDefinition.reset();

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
        dbg.location(86, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:88:1: variableDefinition : variableName ( '=' expression )? -> variableName ( expression )? ;
    public final SGLParser.variableDefinition_return variableDefinition() throws RecognitionException {
        SGLParser.variableDefinition_return retval = new SGLParser.variableDefinition_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal9=null;
        SGLParser.variableName_return variableName8 = null;

        SGLParser.expression_return expression10 = null;


        Object char_literal9_tree=null;
        RewriteRuleTokenStream stream_26=new RewriteRuleTokenStream(adaptor,"token 26");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName=new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try { dbg.enterRule(getGrammarFileName(), "variableDefinition");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(88, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:89:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:89:4: variableName ( '=' expression )?
            {
            dbg.location(89,4);
            pushFollow(FOLLOW_variableName_in_variableDefinition149);
            variableName8=variableName();

            state._fsp--;

            stream_variableName.add(variableName8.getTree());
            dbg.location(89,17);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:89:17: ( '=' expression )?
            int alt3=2;
            try { dbg.enterSubRule(3);
            try { dbg.enterDecision(3);

            int LA3_0 = input.LA(1);

            if ( (LA3_0==26) ) {
                alt3=1;
            }
            } finally {dbg.exitDecision(3);}

            switch (alt3) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:89:18: '=' expression
                    {
                    dbg.location(89,18);
                    char_literal9=(Token)match(input,26,FOLLOW_26_in_variableDefinition152);  
                    stream_26.add(char_literal9);

                    dbg.location(89,22);
                    pushFollow(FOLLOW_expression_in_variableDefinition154);
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
            // 89:36: -> variableName ( expression )?
            {
                dbg.location(89,39);
                adaptor.addChild(root_0, stream_variableName.nextTree());
                dbg.location(89,52);
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:89:52: ( expression )?
                if ( stream_expression.hasNext() ) {
                    dbg.location(89,52);
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
        dbg.location(90, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:92:1: simpleVariableDefinition : variableType ;
    public final SGLParser.simpleVariableDefinition_return simpleVariableDefinition() throws RecognitionException {
        SGLParser.simpleVariableDefinition_return retval = new SGLParser.simpleVariableDefinition_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.variableType_return variableType11 = null;



        try { dbg.enterRule(getGrammarFileName(), "simpleVariableDefinition");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(92, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:93:2: ( variableType )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:93:4: variableType
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(93,4);
            pushFollow(FOLLOW_variableType_in_simpleVariableDefinition176);
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
        dbg.location(94, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:96:1: localVariableDeclarationStatement : ( 'boolean' variableName ( '=' expression )? | 'int' variableName ( '=' expression )? );
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
        dbg.location(96, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:2: ( 'boolean' variableName ( '=' expression )? | 'int' variableName ( '=' expression )? )
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

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:5: 'boolean' variableName ( '=' expression )?
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(97,5);
                    string_literal12=(Token)match(input,BooleanType,FOLLOW_BooleanType_in_localVariableDeclarationStatement188); 
                    string_literal12_tree = (Object)adaptor.create(string_literal12);
                    adaptor.addChild(root_0, string_literal12_tree);

                    dbg.location(97,15);
                    pushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement190);
                    variableName13=variableName();

                    state._fsp--;

                    adaptor.addChild(root_0, variableName13.getTree());
                    dbg.location(97,28);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:28: ( '=' expression )?
                    int alt4=2;
                    try { dbg.enterSubRule(4);
                    try { dbg.enterDecision(4);

                    int LA4_0 = input.LA(1);

                    if ( (LA4_0==26) ) {
                        alt4=1;
                    }
                    } finally {dbg.exitDecision(4);}

                    switch (alt4) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:97:29: '=' expression
                            {
                            dbg.location(97,29);
                            char_literal14=(Token)match(input,26,FOLLOW_26_in_localVariableDeclarationStatement193); 
                            char_literal14_tree = (Object)adaptor.create(char_literal14);
                            adaptor.addChild(root_0, char_literal14_tree);

                            dbg.location(97,33);
                            pushFollow(FOLLOW_expression_in_localVariableDeclarationStatement195);
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

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:98:4: 'int' variableName ( '=' expression )?
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(98,4);
                    string_literal16=(Token)match(input,IntType,FOLLOW_IntType_in_localVariableDeclarationStatement202); 
                    string_literal16_tree = (Object)adaptor.create(string_literal16);
                    adaptor.addChild(root_0, string_literal16_tree);

                    dbg.location(98,10);
                    pushFollow(FOLLOW_variableName_in_localVariableDeclarationStatement204);
                    variableName17=variableName();

                    state._fsp--;

                    adaptor.addChild(root_0, variableName17.getTree());
                    dbg.location(98,23);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:98:23: ( '=' expression )?
                    int alt5=2;
                    try { dbg.enterSubRule(5);
                    try { dbg.enterDecision(5);

                    int LA5_0 = input.LA(1);

                    if ( (LA5_0==26) ) {
                        alt5=1;
                    }
                    } finally {dbg.exitDecision(5);}

                    switch (alt5) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:98:24: '=' expression
                            {
                            dbg.location(98,24);
                            char_literal18=(Token)match(input,26,FOLLOW_26_in_localVariableDeclarationStatement207); 
                            char_literal18_tree = (Object)adaptor.create(char_literal18);
                            adaptor.addChild(root_0, char_literal18_tree);

                            dbg.location(98,28);
                            pushFollow(FOLLOW_expression_in_localVariableDeclarationStatement209);
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
        dbg.location(99, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:102:1: variableAssignmentStatement : variableDeclaration ;
    public final SGLParser.variableAssignmentStatement_return variableAssignmentStatement() throws RecognitionException {
        SGLParser.variableAssignmentStatement_return retval = new SGLParser.variableAssignmentStatement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.variableDeclaration_return variableDeclaration20 = null;



        try { dbg.enterRule(getGrammarFileName(), "variableAssignmentStatement");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(102, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:103:2: ( variableDeclaration )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:103:4: variableDeclaration
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(103,4);
            pushFollow(FOLLOW_variableDeclaration_in_variableAssignmentStatement224);
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
        dbg.location(104, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:111:1: variableDeclaration : variableName ( '=' expression )? ;
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
        dbg.location(111, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:112:2: ( variableName ( '=' expression )? )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:112:4: variableName ( '=' expression )?
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(112,4);
            pushFollow(FOLLOW_variableName_in_variableDeclaration243);
            variableName21=variableName();

            state._fsp--;

            adaptor.addChild(root_0, variableName21.getTree());
            dbg.location(112,17);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:112:17: ( '=' expression )?
            int alt7=2;
            try { dbg.enterSubRule(7);
            try { dbg.enterDecision(7);

            int LA7_0 = input.LA(1);

            if ( (LA7_0==26) ) {
                alt7=1;
            }
            } finally {dbg.exitDecision(7);}

            switch (alt7) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:112:18: '=' expression
                    {
                    dbg.location(112,18);
                    char_literal22=(Token)match(input,26,FOLLOW_26_in_variableDeclaration246); 
                    char_literal22_tree = (Object)adaptor.create(char_literal22);
                    adaptor.addChild(root_0, char_literal22_tree);

                    dbg.location(112,22);
                    pushFollow(FOLLOW_expression_in_variableDeclaration248);
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
        dbg.location(113, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:116:1: variableName : Identifier ;
    public final SGLParser.variableName_return variableName() throws RecognitionException {
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token Identifier24=null;

        Object Identifier24_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "variableName");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(116, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:117:2: ( Identifier )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:117:4: Identifier
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(117,4);
            Identifier24=(Token)match(input,Identifier,FOLLOW_Identifier_in_variableName264); 
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
        dbg.location(118, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:120:1: variableType : ( IntType | BooleanType | StringType | FloatType );
    public final SGLParser.variableType_return variableType() throws RecognitionException {
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set25=null;

        Object set25_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "variableType");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(120, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:121:2: ( IntType | BooleanType | StringType | FloatType )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(121,2);
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
        dbg.location(125, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:134:1: expression : conditionalExpression ;
    public final SGLParser.expression_return expression() throws RecognitionException {
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression26 = null;



        try { dbg.enterRule(getGrammarFileName(), "expression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(134, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:135:5: ( conditionalExpression )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:135:8: conditionalExpression
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(135,8);
            pushFollow(FOLLOW_conditionalExpression_in_expression328);
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
        dbg.location(137, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:144:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
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
        dbg.location(144, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:145:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:145:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(145,9);
            pushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression369);
            conditionalOrExpression27=conditionalOrExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalOrExpression27.getTree());
            dbg.location(145,33);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:145:33: ( '?' conditionalExpression ':' conditionalExpression )?
            int alt8=2;
            try { dbg.enterSubRule(8);
            try { dbg.enterDecision(8);

            int LA8_0 = input.LA(1);

            if ( (LA8_0==27) ) {
                alt8=1;
            }
            } finally {dbg.exitDecision(8);}

            switch (alt8) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:145:35: '?' conditionalExpression ':' conditionalExpression
                    {
                    dbg.location(145,38);
                    char_literal28=(Token)match(input,27,FOLLOW_27_in_conditionalExpression373); 
                    char_literal28_tree = (Object)adaptor.create(char_literal28);
                    root_0 = (Object)adaptor.becomeRoot(char_literal28_tree, root_0);

                    dbg.location(145,40);
                    pushFollow(FOLLOW_conditionalExpression_in_conditionalExpression376);
                    conditionalExpression29=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression29.getTree());
                    dbg.location(145,65);
                    char_literal30=(Token)match(input,28,FOLLOW_28_in_conditionalExpression378); 
                    dbg.location(145,67);
                    pushFollow(FOLLOW_conditionalExpression_in_conditionalExpression381);
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
        dbg.location(146, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:150:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
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
        dbg.location(150, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:151:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:151:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(151,9);
            pushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression424);
            conditionalAndExpression32=conditionalAndExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalAndExpression32.getTree());
            dbg.location(151,34);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:151:34: ( '||' conditionalAndExpression )*
            try { dbg.enterSubRule(9);

            loop9:
            do {
                int alt9=2;
                try { dbg.enterDecision(9);

                int LA9_0 = input.LA(1);

                if ( (LA9_0==29) ) {
                    alt9=1;
                }


                } finally {dbg.exitDecision(9);}

                switch (alt9) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:151:36: '||' conditionalAndExpression
            	    {
            	    dbg.location(151,40);
            	    string_literal33=(Token)match(input,29,FOLLOW_29_in_conditionalOrExpression428); 
            	    string_literal33_tree = (Object)adaptor.create(string_literal33);
            	    root_0 = (Object)adaptor.becomeRoot(string_literal33_tree, root_0);

            	    dbg.location(151,42);
            	    pushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression431);
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
        dbg.location(152, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:155:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
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
        dbg.location(155, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:156:5: ( equalityExpression ( '&&' equalityExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:156:9: equalityExpression ( '&&' equalityExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(156,9);
            pushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression462);
            equalityExpression35=equalityExpression();

            state._fsp--;

            adaptor.addChild(root_0, equalityExpression35.getTree());
            dbg.location(156,28);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:156:28: ( '&&' equalityExpression )*
            try { dbg.enterSubRule(10);

            loop10:
            do {
                int alt10=2;
                try { dbg.enterDecision(10);

                int LA10_0 = input.LA(1);

                if ( (LA10_0==30) ) {
                    alt10=1;
                }


                } finally {dbg.exitDecision(10);}

                switch (alt10) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:156:30: '&&' equalityExpression
            	    {
            	    dbg.location(156,34);
            	    string_literal36=(Token)match(input,30,FOLLOW_30_in_conditionalAndExpression466); 
            	    string_literal36_tree = (Object)adaptor.create(string_literal36);
            	    root_0 = (Object)adaptor.becomeRoot(string_literal36_tree, root_0);

            	    dbg.location(156,36);
            	    pushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression469);
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
        dbg.location(157, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:160:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public final SGLParser.equalityExpression_return equalityExpression() throws RecognitionException {
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal39=null;
        Token string_literal40=null;
        SGLParser.relationalExpression_return relationalExpression38 = null;

        SGLParser.relationalExpression_return relationalExpression41 = null;


        Object string_literal39_tree=null;
        Object string_literal40_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "equalityExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(160, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(161,9);
            pushFollow(FOLLOW_relationalExpression_in_equalityExpression496);
            relationalExpression38=relationalExpression();

            state._fsp--;

            adaptor.addChild(root_0, relationalExpression38.getTree());
            dbg.location(161,30);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:30: ( ( '==' | '!=' ) relationalExpression )*
            try { dbg.enterSubRule(12);

            loop12:
            do {
                int alt12=2;
                try { dbg.enterDecision(12);

                int LA12_0 = input.LA(1);

                if ( ((LA12_0>=31 && LA12_0<=32)) ) {
                    alt12=1;
                }


                } finally {dbg.exitDecision(12);}

                switch (alt12) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:32: ( '==' | '!=' ) relationalExpression
            	    {
            	    dbg.location(161,32);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:32: ( '==' | '!=' )
            	    int alt11=2;
            	    try { dbg.enterSubRule(11);
            	    try { dbg.enterDecision(11);

            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0==31) ) {
            	        alt11=1;
            	    }
            	    else if ( (LA11_0==32) ) {
            	        alt11=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 11, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }
            	    } finally {dbg.exitDecision(11);}

            	    switch (alt11) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:33: '=='
            	            {
            	            dbg.location(161,37);
            	            string_literal39=(Token)match(input,31,FOLLOW_31_in_equalityExpression501); 
            	            string_literal39_tree = (Object)adaptor.create(string_literal39);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal39_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:161:41: '!='
            	            {
            	            dbg.location(161,45);
            	            string_literal40=(Token)match(input,32,FOLLOW_32_in_equalityExpression506); 
            	            string_literal40_tree = (Object)adaptor.create(string_literal40);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal40_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(11);}

            	    dbg.location(161,48);
            	    pushFollow(FOLLOW_relationalExpression_in_equalityExpression510);
            	    relationalExpression41=relationalExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, relationalExpression41.getTree());

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
        dbg.location(162, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:165:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public final SGLParser.relationalExpression_return relationalExpression() throws RecognitionException {
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal43=null;
        Token char_literal44=null;
        Token string_literal45=null;
        Token string_literal46=null;
        SGLParser.additiveExpression_return additiveExpression42 = null;

        SGLParser.additiveExpression_return additiveExpression47 = null;


        Object char_literal43_tree=null;
        Object char_literal44_tree=null;
        Object string_literal45_tree=null;
        Object string_literal46_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "relationalExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(165, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(166,9);
            pushFollow(FOLLOW_additiveExpression_in_relationalExpression541);
            additiveExpression42=additiveExpression();

            state._fsp--;

            adaptor.addChild(root_0, additiveExpression42.getTree());
            dbg.location(166,28);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            try { dbg.enterSubRule(14);

            loop14:
            do {
                int alt14=2;
                try { dbg.enterDecision(14);

                int LA14_0 = input.LA(1);

                if ( ((LA14_0>=33 && LA14_0<=36)) ) {
                    alt14=1;
                }


                } finally {dbg.exitDecision(14);}

                switch (alt14) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            	    {
            	    dbg.location(166,29);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:29: ( '<' | '>' | '<=' | '>=' )
            	    int alt13=4;
            	    try { dbg.enterSubRule(13);
            	    try { dbg.enterDecision(13);

            	    switch ( input.LA(1) ) {
            	    case 33:
            	        {
            	        alt13=1;
            	        }
            	        break;
            	    case 34:
            	        {
            	        alt13=2;
            	        }
            	        break;
            	    case 35:
            	        {
            	        alt13=3;
            	        }
            	        break;
            	    case 36:
            	        {
            	        alt13=4;
            	        }
            	        break;
            	    default:
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 13, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }

            	    } finally {dbg.exitDecision(13);}

            	    switch (alt13) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:30: '<'
            	            {
            	            dbg.location(166,33);
            	            char_literal43=(Token)match(input,33,FOLLOW_33_in_relationalExpression545); 
            	            char_literal43_tree = (Object)adaptor.create(char_literal43);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal43_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:35: '>'
            	            {
            	            dbg.location(166,38);
            	            char_literal44=(Token)match(input,34,FOLLOW_34_in_relationalExpression548); 
            	            char_literal44_tree = (Object)adaptor.create(char_literal44);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal44_tree, root_0);


            	            }
            	            break;
            	        case 3 :
            	            dbg.enterAlt(3);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:40: '<='
            	            {
            	            dbg.location(166,44);
            	            string_literal45=(Token)match(input,35,FOLLOW_35_in_relationalExpression551); 
            	            string_literal45_tree = (Object)adaptor.create(string_literal45);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal45_tree, root_0);


            	            }
            	            break;
            	        case 4 :
            	            dbg.enterAlt(4);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:166:46: '>='
            	            {
            	            dbg.location(166,50);
            	            string_literal46=(Token)match(input,36,FOLLOW_36_in_relationalExpression554); 
            	            string_literal46_tree = (Object)adaptor.create(string_literal46);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal46_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(13);}

            	    dbg.location(166,53);
            	    pushFollow(FOLLOW_additiveExpression_in_relationalExpression558);
            	    additiveExpression47=additiveExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, additiveExpression47.getTree());

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
        dbg.location(167, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:170:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public final SGLParser.additiveExpression_return additiveExpression() throws RecognitionException {
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal49=null;
        Token char_literal50=null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression48 = null;

        SGLParser.multiplicativeExpression_return multiplicativeExpression51 = null;


        Object char_literal49_tree=null;
        Object char_literal50_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "additiveExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(170, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(171,9);
            pushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression596);
            multiplicativeExpression48=multiplicativeExpression();

            state._fsp--;

            adaptor.addChild(root_0, multiplicativeExpression48.getTree());
            dbg.location(171,34);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:34: ( ( '+' | '-' ) multiplicativeExpression )*
            try { dbg.enterSubRule(16);

            loop16:
            do {
                int alt16=2;
                try { dbg.enterDecision(16);

                int LA16_0 = input.LA(1);

                if ( ((LA16_0>=37 && LA16_0<=38)) ) {
                    alt16=1;
                }


                } finally {dbg.exitDecision(16);}

                switch (alt16) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:35: ( '+' | '-' ) multiplicativeExpression
            	    {
            	    dbg.location(171,35);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:35: ( '+' | '-' )
            	    int alt15=2;
            	    try { dbg.enterSubRule(15);
            	    try { dbg.enterDecision(15);

            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0==37) ) {
            	        alt15=1;
            	    }
            	    else if ( (LA15_0==38) ) {
            	        alt15=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 15, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }
            	    } finally {dbg.exitDecision(15);}

            	    switch (alt15) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:36: '+'
            	            {
            	            dbg.location(171,39);
            	            char_literal49=(Token)match(input,37,FOLLOW_37_in_additiveExpression600); 
            	            char_literal49_tree = (Object)adaptor.create(char_literal49);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal49_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:171:41: '-'
            	            {
            	            dbg.location(171,44);
            	            char_literal50=(Token)match(input,38,FOLLOW_38_in_additiveExpression603); 
            	            char_literal50_tree = (Object)adaptor.create(char_literal50);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal50_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(15);}

            	    dbg.location(171,47);
            	    pushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression607);
            	    multiplicativeExpression51=multiplicativeExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, multiplicativeExpression51.getTree());

            	    }
            	    break;

            	default :
            	    break loop16;
                }
            } while (true);
            } finally {dbg.exitSubRule(16);}


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
        dbg.location(172, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:175:1: multiplicativeExpression : negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* ;
    public final SGLParser.multiplicativeExpression_return multiplicativeExpression() throws RecognitionException {
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal53=null;
        Token char_literal54=null;
        Token char_literal55=null;
        SGLParser.negativeExpression_return negativeExpression52 = null;

        SGLParser.negativeExpression_return negativeExpression56 = null;


        Object char_literal53_tree=null;
        Object char_literal54_tree=null;
        Object char_literal55_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "multiplicativeExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(175, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:176:5: ( negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:176:9: negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(176,9);
            pushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression641);
            negativeExpression52=negativeExpression();

            state._fsp--;

            adaptor.addChild(root_0, negativeExpression52.getTree());
            dbg.location(177,5);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:177:5: ( ( '*' | '/' | '%' ) negativeExpression )*
            try { dbg.enterSubRule(18);

            loop18:
            do {
                int alt18=2;
                try { dbg.enterDecision(18);

                int LA18_0 = input.LA(1);

                if ( ((LA18_0>=39 && LA18_0<=41)) ) {
                    alt18=1;
                }


                } finally {dbg.exitDecision(18);}

                switch (alt18) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:177:6: ( '*' | '/' | '%' ) negativeExpression
            	    {
            	    dbg.location(177,6);
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:177:6: ( '*' | '/' | '%' )
            	    int alt17=3;
            	    try { dbg.enterSubRule(17);
            	    try { dbg.enterDecision(17);

            	    switch ( input.LA(1) ) {
            	    case 39:
            	        {
            	        alt17=1;
            	        }
            	        break;
            	    case 40:
            	        {
            	        alt17=2;
            	        }
            	        break;
            	    case 41:
            	        {
            	        alt17=3;
            	        }
            	        break;
            	    default:
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 17, 0, input);

            	        dbg.recognitionException(nvae);
            	        throw nvae;
            	    }

            	    } finally {dbg.exitDecision(17);}

            	    switch (alt17) {
            	        case 1 :
            	            dbg.enterAlt(1);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:177:7: '*'
            	            {
            	            dbg.location(177,10);
            	            char_literal53=(Token)match(input,39,FOLLOW_39_in_multiplicativeExpression649); 
            	            char_literal53_tree = (Object)adaptor.create(char_literal53);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal53_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            dbg.enterAlt(2);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:177:12: '/'
            	            {
            	            dbg.location(177,15);
            	            char_literal54=(Token)match(input,40,FOLLOW_40_in_multiplicativeExpression652); 
            	            char_literal54_tree = (Object)adaptor.create(char_literal54);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal54_tree, root_0);


            	            }
            	            break;
            	        case 3 :
            	            dbg.enterAlt(3);

            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:177:17: '%'
            	            {
            	            dbg.location(177,20);
            	            char_literal55=(Token)match(input,41,FOLLOW_41_in_multiplicativeExpression655); 
            	            char_literal55_tree = (Object)adaptor.create(char_literal55);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal55_tree, root_0);


            	            }
            	            break;

            	    }
            	    } finally {dbg.exitSubRule(17);}

            	    dbg.location(177,23);
            	    pushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression659);
            	    negativeExpression56=negativeExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, negativeExpression56.getTree());

            	    }
            	    break;

            	default :
            	    break loop18;
                }
            } while (true);
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
        dbg.location(178, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:180:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public final SGLParser.unaryExpression_return unaryExpression() throws RecognitionException {
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal57=null;
        Token string_literal59=null;
        SGLParser.unaryExpression_return unaryExpression58 = null;

        SGLParser.unaryExpression_return unaryExpression60 = null;

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus61 = null;


        Object string_literal57_tree=null;
        Object string_literal59_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unaryExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(180, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:181:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt19=3;
            try { dbg.enterDecision(19);

            switch ( input.LA(1) ) {
            case 42:
                {
                alt19=1;
                }
                break;
            case 43:
                {
                alt19=2;
                }
                break;
            case Identifier:
            case IntegerAtom:
            case 44:
            case 45:
                {
                alt19=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 19, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(19);}

            switch (alt19) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:181:7: '++' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(181,7);
                    string_literal57=(Token)match(input,42,FOLLOW_42_in_unaryExpression682); 
                    string_literal57_tree = (Object)adaptor.create(string_literal57);
                    adaptor.addChild(root_0, string_literal57_tree);

                    dbg.location(181,12);
                    pushFollow(FOLLOW_unaryExpression_in_unaryExpression684);
                    unaryExpression58=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression58.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:182:9: '--' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(182,9);
                    string_literal59=(Token)match(input,43,FOLLOW_43_in_unaryExpression694); 
                    string_literal59_tree = (Object)adaptor.create(string_literal59);
                    adaptor.addChild(root_0, string_literal59_tree);

                    dbg.location(182,14);
                    pushFollow(FOLLOW_unaryExpression_in_unaryExpression696);
                    unaryExpression60=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression60.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:183:9: unaryExpressionNotPlusMinus
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(183,9);
                    pushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression706);
                    unaryExpressionNotPlusMinus61=unaryExpressionNotPlusMinus();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpressionNotPlusMinus61.getTree());

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
        dbg.location(184, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:187:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public final SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() throws RecognitionException {
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal62=null;
        Token set66=null;
        SGLParser.unaryExpression_return unaryExpression63 = null;

        SGLParser.castExpression_return castExpression64 = null;

        SGLParser.mathAtom_return mathAtom65 = null;


        Object char_literal62_tree=null;
        Object set66_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "unaryExpressionNotPlusMinus");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(187, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:188:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt21=3;
            try { dbg.enterDecision(21);

            switch ( input.LA(1) ) {
            case 44:
                {
                alt21=1;
                }
                break;
            case 45:
                {
                int LA21_2 = input.LA(2);

                if ( ((LA21_2>=IntType && LA21_2<=FloatType)) ) {
                    alt21=2;
                }
                else if ( (LA21_2==Identifier||LA21_2==IntegerAtom||LA21_2==38||LA21_2==45) ) {
                    alt21=3;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 21, 2, input);

                    dbg.recognitionException(nvae);
                    throw nvae;
                }
                }
                break;
            case Identifier:
            case IntegerAtom:
                {
                alt21=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 21, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }

            } finally {dbg.exitDecision(21);}

            switch (alt21) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:188:9: '!' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(188,9);
                    char_literal62=(Token)match(input,44,FOLLOW_44_in_unaryExpressionNotPlusMinus727); 
                    char_literal62_tree = (Object)adaptor.create(char_literal62);
                    adaptor.addChild(root_0, char_literal62_tree);

                    dbg.location(188,13);
                    pushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus729);
                    unaryExpression63=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression63.getTree());

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:189:9: castExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(189,9);
                    pushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus739);
                    castExpression64=castExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, castExpression64.getTree());

                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:191:9: mathAtom ( '++' | '--' )?
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(191,9);
                    pushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus754);
                    mathAtom65=mathAtom();

                    state._fsp--;

                    adaptor.addChild(root_0, mathAtom65.getTree());
                    dbg.location(191,18);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:191:18: ( '++' | '--' )?
                    int alt20=2;
                    try { dbg.enterSubRule(20);
                    try { dbg.enterDecision(20);

                    int LA20_0 = input.LA(1);

                    if ( ((LA20_0>=42 && LA20_0<=43)) ) {
                        alt20=1;
                    }
                    } finally {dbg.exitDecision(20);}

                    switch (alt20) {
                        case 1 :
                            dbg.enterAlt(1);

                            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
                            {
                            dbg.location(191,18);
                            set66=(Token)input.LT(1);
                            if ( (input.LA(1)>=42 && input.LA(1)<=43) ) {
                                input.consume();
                                adaptor.addChild(root_0, (Object)adaptor.create(set66));
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
                    } finally {dbg.exitSubRule(20);}


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
        dbg.location(192, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:195:1: castExpression : '(' variableType ')' unaryExpression ;
    public final SGLParser.castExpression_return castExpression() throws RecognitionException {
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal67=null;
        Token char_literal69=null;
        SGLParser.variableType_return variableType68 = null;

        SGLParser.unaryExpression_return unaryExpression70 = null;


        Object char_literal67_tree=null;
        Object char_literal69_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "castExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(195, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:196:5: ( '(' variableType ')' unaryExpression )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:196:8: '(' variableType ')' unaryExpression
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(196,8);
            char_literal67=(Token)match(input,45,FOLLOW_45_in_castExpression787); 
            char_literal67_tree = (Object)adaptor.create(char_literal67);
            adaptor.addChild(root_0, char_literal67_tree);

            dbg.location(196,12);
            pushFollow(FOLLOW_variableType_in_castExpression789);
            variableType68=variableType();

            state._fsp--;

            adaptor.addChild(root_0, variableType68.getTree());
            dbg.location(196,25);
            char_literal69=(Token)match(input,46,FOLLOW_46_in_castExpression791); 
            char_literal69_tree = (Object)adaptor.create(char_literal69);
            adaptor.addChild(root_0, char_literal69_tree);

            dbg.location(196,29);
            pushFollow(FOLLOW_unaryExpression_in_castExpression793);
            unaryExpression70=unaryExpression();

            state._fsp--;

            adaptor.addChild(root_0, unaryExpression70.getTree());

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:201:1: negativeExpression : ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) );
    public final SGLParser.negativeExpression_return negativeExpression() throws RecognitionException {
        SGLParser.negativeExpression_return retval = new SGLParser.negativeExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal72=null;
        SGLParser.mathAtom_return mathAtom71 = null;

        SGLParser.mathAtom_return mathAtom73 = null;


        Object char_literal72_tree=null;
        RewriteRuleTokenStream stream_38=new RewriteRuleTokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_mathAtom=new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try { dbg.enterRule(getGrammarFileName(), "negativeExpression");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(201, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:202:2: ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) )
            int alt22=2;
            try { dbg.enterDecision(22);

            int LA22_0 = input.LA(1);

            if ( (LA22_0==Identifier||LA22_0==IntegerAtom||LA22_0==45) ) {
                alt22=1;
            }
            else if ( (LA22_0==38) ) {
                alt22=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 22, 0, input);

                dbg.recognitionException(nvae);
                throw nvae;
            }
            } finally {dbg.exitDecision(22);}

            switch (alt22) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:202:4: mathAtom
                    {
                    dbg.location(202,4);
                    pushFollow(FOLLOW_mathAtom_in_negativeExpression811);
                    mathAtom71=mathAtom();

                    state._fsp--;

                    stream_mathAtom.add(mathAtom71.getTree());


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
                    // 202:13: -> mathAtom
                    {
                        dbg.location(202,16);
                        adaptor.addChild(root_0, stream_mathAtom.nextTree());

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:4: ( '-' ) mathAtom
                    {
                    dbg.location(203,4);
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:4: ( '-' )
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:5: '-'
                    {
                    dbg.location(203,5);
                    char_literal72=(Token)match(input,38,FOLLOW_38_in_negativeExpression821);  
                    stream_38.add(char_literal72);


                    }

                    dbg.location(203,10);
                    pushFollow(FOLLOW_mathAtom_in_negativeExpression824);
                    mathAtom73=mathAtom();

                    state._fsp--;

                    stream_mathAtom.add(mathAtom73.getTree());


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
                    // 203:19: -> ^( NEGATE mathAtom )
                    {
                        dbg.location(203,22);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:203:22: ^( NEGATE mathAtom )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(203,24);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(NEGATE, "NEGATE"), root_1);

                        dbg.location(203,31);
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
        dbg.location(204, 2);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:206:1: mathAtom : ( '(' additiveExpression ')' | IntegerAtom | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) );
    public final SGLParser.mathAtom_return mathAtom() throws RecognitionException {
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal74=null;
        Token char_literal76=null;
        Token IntegerAtom77=null;
        Token Identifier78=null;
        SGLParser.additiveExpression_return additiveExpression75 = null;

        SGLParser.arguments_return arguments79 = null;


        Object char_literal74_tree=null;
        Object char_literal76_tree=null;
        Object IntegerAtom77_tree=null;
        Object Identifier78_tree=null;
        RewriteRuleTokenStream stream_Identifier=new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments=new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try { dbg.enterRule(getGrammarFileName(), "mathAtom");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(206, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:207:5: ( '(' additiveExpression ')' | IntegerAtom | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) )
            int alt23=3;
            try { dbg.enterDecision(23);

            switch ( input.LA(1) ) {
            case 45:
                {
                alt23=1;
                }
                break;
            case IntegerAtom:
                {
                alt23=2;
                }
                break;
            case Identifier:
                {
                alt23=3;
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

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:207:7: '(' additiveExpression ')'
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(207,10);
                    char_literal74=(Token)match(input,45,FOLLOW_45_in_mathAtom846); 
                    dbg.location(207,12);
                    pushFollow(FOLLOW_additiveExpression_in_mathAtom849);
                    additiveExpression75=additiveExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, additiveExpression75.getTree());
                    dbg.location(207,34);
                    char_literal76=(Token)match(input,46,FOLLOW_46_in_mathAtom851); 

                    }
                    break;
                case 2 :
                    dbg.enterAlt(2);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:208:9: IntegerAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    dbg.location(208,9);
                    IntegerAtom77=(Token)match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom862); 
                    IntegerAtom77_tree = (Object)adaptor.create(IntegerAtom77);
                    adaptor.addChild(root_0, IntegerAtom77_tree);


                    }
                    break;
                case 3 :
                    dbg.enterAlt(3);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:213:4: Identifier arguments
                    {
                    dbg.location(213,4);
                    Identifier78=(Token)match(input,Identifier,FOLLOW_Identifier_in_mathAtom880);  
                    stream_Identifier.add(Identifier78);

                    dbg.location(213,15);
                    pushFollow(FOLLOW_arguments_in_mathAtom882);
                    arguments79=arguments();

                    state._fsp--;

                    stream_arguments.add(arguments79.getTree());


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
                    // 213:25: -> ^( LIBMETHOD Identifier ( arguments )? )
                    {
                        dbg.location(213,28);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:213:28: ^( LIBMETHOD Identifier ( arguments )? )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        dbg.location(213,30);
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(LIBMETHOD, "LIBMETHOD"), root_1);

                        dbg.location(213,40);
                        adaptor.addChild(root_1, stream_Identifier.nextNode());
                        dbg.location(213,51);
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:213:51: ( arguments )?
                        if ( stream_arguments.hasNext() ) {
                            dbg.location(213,51);
                            adaptor.addChild(root_1, stream_arguments.nextTree());

                        }
                        stream_arguments.reset();

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
        dbg.location(214, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:217:1: arguments : '(' ( expressionList )? ')' ;
    public final SGLParser.arguments_return arguments() throws RecognitionException {
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal80=null;
        Token char_literal82=null;
        SGLParser.expressionList_return expressionList81 = null;


        Object char_literal80_tree=null;
        Object char_literal82_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "arguments");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(217, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:218:5: ( '(' ( expressionList )? ')' )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:218:9: '(' ( expressionList )? ')'
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(218,12);
            char_literal80=(Token)match(input,45,FOLLOW_45_in_arguments915); 
            dbg.location(218,14);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:218:14: ( expressionList )?
            int alt24=2;
            try { dbg.enterSubRule(24);
            try { dbg.enterDecision(24);

            int LA24_0 = input.LA(1);

            if ( (LA24_0==Identifier||LA24_0==IntegerAtom||LA24_0==38||LA24_0==45) ) {
                alt24=1;
            }
            } finally {dbg.exitDecision(24);}

            switch (alt24) {
                case 1 :
                    dbg.enterAlt(1);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:218:14: expressionList
                    {
                    dbg.location(218,14);
                    pushFollow(FOLLOW_expressionList_in_arguments918);
                    expressionList81=expressionList();

                    state._fsp--;

                    adaptor.addChild(root_0, expressionList81.getTree());

                    }
                    break;

            }
            } finally {dbg.exitSubRule(24);}

            dbg.location(218,33);
            char_literal82=(Token)match(input,46,FOLLOW_46_in_arguments921); 

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
        dbg.location(219, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:221:1: expressionList : expression ( ',' expression )* ;
    public final SGLParser.expressionList_return expressionList() throws RecognitionException {
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal84=null;
        SGLParser.expression_return expression83 = null;

        SGLParser.expression_return expression85 = null;


        Object char_literal84_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "expressionList");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(221, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:222:5: ( expression ( ',' expression )* )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:222:9: expression ( ',' expression )*
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(222,9);
            pushFollow(FOLLOW_expression_in_expressionList941);
            expression83=expression();

            state._fsp--;

            adaptor.addChild(root_0, expression83.getTree());
            dbg.location(222,20);
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:222:20: ( ',' expression )*
            try { dbg.enterSubRule(25);

            loop25:
            do {
                int alt25=2;
                try { dbg.enterDecision(25);

                int LA25_0 = input.LA(1);

                if ( (LA25_0==25) ) {
                    alt25=1;
                }


                } finally {dbg.exitDecision(25);}

                switch (alt25) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:222:21: ',' expression
            	    {
            	    dbg.location(222,24);
            	    char_literal84=(Token)match(input,25,FOLLOW_25_in_expressionList944); 
            	    dbg.location(222,26);
            	    pushFollow(FOLLOW_expression_in_expressionList947);
            	    expression85=expression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, expression85.getTree());

            	    }
            	    break;

            	default :
            	    break loop25;
                }
            } while (true);
            } finally {dbg.exitSubRule(25);}


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
        dbg.location(223, 5);

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:227:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public final SGLParser.literal_return literal() throws RecognitionException {
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set86=null;

        Object set86_tree=null;

        try { dbg.enterRule(getGrammarFileName(), "literal");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(227, 1);

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:228:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            dbg.enterAlt(1);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
            {
            root_0 = (Object)adaptor.nil();

            dbg.location(228,5);
            set86=(Token)input.LT(1);
            if ( (input.LA(1)>=IntegerAtom && input.LA(1)<=BooleanAtom)||input.LA(1)==47 ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set86));
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
        dbg.location(233, 5);

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


 

    public static final BitSet FOLLOW_statement_in_compilationUnit84 = new BitSet(new long[]{0x0000000000000F00L});
    public static final BitSet FOLLOW_EOF_in_compilationUnit87 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableDefinitionList_in_statement102 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableType_in_variableDefinitionList118 = new BitSet(new long[]{0x0000000000000080L});
    public static final BitSet FOLLOW_variableDefinition_in_variableDefinitionList120 = new BitSet(new long[]{0x0000000002000002L});
    public static final BitSet FOLLOW_25_in_variableDefinitionList123 = new BitSet(new long[]{0x0000000000000080L});
    public static final BitSet FOLLOW_variableDefinition_in_variableDefinitionList125 = new BitSet(new long[]{0x0000000002000002L});
    public static final BitSet FOLLOW_variableName_in_variableDefinition149 = new BitSet(new long[]{0x0000000004000002L});
    public static final BitSet FOLLOW_26_in_variableDefinition152 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_expression_in_variableDefinition154 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableType_in_simpleVariableDefinition176 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BooleanType_in_localVariableDeclarationStatement188 = new BitSet(new long[]{0x0000000000000080L});
    public static final BitSet FOLLOW_variableName_in_localVariableDeclarationStatement190 = new BitSet(new long[]{0x0000000004000002L});
    public static final BitSet FOLLOW_26_in_localVariableDeclarationStatement193 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_expression_in_localVariableDeclarationStatement195 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_IntType_in_localVariableDeclarationStatement202 = new BitSet(new long[]{0x0000000000000080L});
    public static final BitSet FOLLOW_variableName_in_localVariableDeclarationStatement204 = new BitSet(new long[]{0x0000000004000002L});
    public static final BitSet FOLLOW_26_in_localVariableDeclarationStatement207 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_expression_in_localVariableDeclarationStatement209 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableDeclaration_in_variableAssignmentStatement224 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableName_in_variableDeclaration243 = new BitSet(new long[]{0x0000000004000002L});
    public static final BitSet FOLLOW_26_in_variableDeclaration246 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_expression_in_variableDeclaration248 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_variableName264 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_variableType0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalExpression_in_expression328 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression369 = new BitSet(new long[]{0x0000000008000002L});
    public static final BitSet FOLLOW_27_in_conditionalExpression373 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_conditionalExpression_in_conditionalExpression376 = new BitSet(new long[]{0x0000000010000000L});
    public static final BitSet FOLLOW_28_in_conditionalExpression378 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_conditionalExpression_in_conditionalExpression381 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression424 = new BitSet(new long[]{0x0000000020000002L});
    public static final BitSet FOLLOW_29_in_conditionalOrExpression428 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression431 = new BitSet(new long[]{0x0000000020000002L});
    public static final BitSet FOLLOW_equalityExpression_in_conditionalAndExpression462 = new BitSet(new long[]{0x0000000040000002L});
    public static final BitSet FOLLOW_30_in_conditionalAndExpression466 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_equalityExpression_in_conditionalAndExpression469 = new BitSet(new long[]{0x0000000040000002L});
    public static final BitSet FOLLOW_relationalExpression_in_equalityExpression496 = new BitSet(new long[]{0x0000000180000002L});
    public static final BitSet FOLLOW_31_in_equalityExpression501 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_32_in_equalityExpression506 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_relationalExpression_in_equalityExpression510 = new BitSet(new long[]{0x0000000180000002L});
    public static final BitSet FOLLOW_additiveExpression_in_relationalExpression541 = new BitSet(new long[]{0x0000001E00000002L});
    public static final BitSet FOLLOW_33_in_relationalExpression545 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_34_in_relationalExpression548 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_35_in_relationalExpression551 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_36_in_relationalExpression554 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_additiveExpression_in_relationalExpression558 = new BitSet(new long[]{0x0000001E00000002L});
    public static final BitSet FOLLOW_multiplicativeExpression_in_additiveExpression596 = new BitSet(new long[]{0x0000006000000002L});
    public static final BitSet FOLLOW_37_in_additiveExpression600 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_38_in_additiveExpression603 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_multiplicativeExpression_in_additiveExpression607 = new BitSet(new long[]{0x0000006000000002L});
    public static final BitSet FOLLOW_negativeExpression_in_multiplicativeExpression641 = new BitSet(new long[]{0x0000038000000002L});
    public static final BitSet FOLLOW_39_in_multiplicativeExpression649 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_40_in_multiplicativeExpression652 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_41_in_multiplicativeExpression655 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_negativeExpression_in_multiplicativeExpression659 = new BitSet(new long[]{0x0000038000000002L});
    public static final BitSet FOLLOW_42_in_unaryExpression682 = new BitSet(new long[]{0x00003C0000001080L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpression684 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_43_in_unaryExpression694 = new BitSet(new long[]{0x00003C0000001080L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpression696 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression706 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_44_in_unaryExpressionNotPlusMinus727 = new BitSet(new long[]{0x00003C0000001080L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus729 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus739 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus754 = new BitSet(new long[]{0x00000C0000000002L});
    public static final BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus756 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_45_in_castExpression787 = new BitSet(new long[]{0x0000000000000F00L});
    public static final BitSet FOLLOW_variableType_in_castExpression789 = new BitSet(new long[]{0x0000400000000000L});
    public static final BitSet FOLLOW_46_in_castExpression791 = new BitSet(new long[]{0x00003C0000001080L});
    public static final BitSet FOLLOW_unaryExpression_in_castExpression793 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mathAtom_in_negativeExpression811 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_38_in_negativeExpression821 = new BitSet(new long[]{0x0000200000001080L});
    public static final BitSet FOLLOW_mathAtom_in_negativeExpression824 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_45_in_mathAtom846 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_additiveExpression_in_mathAtom849 = new BitSet(new long[]{0x0000400000000000L});
    public static final BitSet FOLLOW_46_in_mathAtom851 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_IntegerAtom_in_mathAtom862 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_mathAtom880 = new BitSet(new long[]{0x0000200000000000L});
    public static final BitSet FOLLOW_arguments_in_mathAtom882 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_45_in_arguments915 = new BitSet(new long[]{0x0000604000001080L});
    public static final BitSet FOLLOW_expressionList_in_arguments918 = new BitSet(new long[]{0x0000400000000000L});
    public static final BitSet FOLLOW_46_in_arguments921 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_expression_in_expressionList941 = new BitSet(new long[]{0x0000000002000002L});
    public static final BitSet FOLLOW_25_in_expressionList944 = new BitSet(new long[]{0x0000204000001080L});
    public static final BitSet FOLLOW_expression_in_expressionList947 = new BitSet(new long[]{0x0000000002000002L});
    public static final BitSet FOLLOW_set_in_literal0 = new BitSet(new long[]{0x0000000000000002L});

}