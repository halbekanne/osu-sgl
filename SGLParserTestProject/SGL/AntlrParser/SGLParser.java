// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g 2011-08-10 19:05:56

	//using SGLParserTester;


import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;


import org.antlr.runtime.tree.*;

public class SGLParser extends Parser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BLOCK", "STATEMENTS", "IF", "EXP", "ID_LIST", "VARDEF", "ASSIGN", "NEGATE", "LIBMETHOD", "STRING", "Identifier", "IntType", "BooleanType", "StringType", "FloatType", "ObjectType", "IntegerAtom", "FloatAtom", "BooleanAtom", "SpriteAnimation", "StringAtom", "EscapeSequence", "Letter", "SGLIDDigit", "UnicodeEscape", "OctalEscape", "HEX_DIGIT", "WS", "COMMENT", "'{'", "'}'", "'method'", "'('", "')'", "';'", "','", "'='", "'while'", "'if'", "'else'", "'?'", "':'", "'||'", "'&&'", "'=='", "'!='", "'<'", "'>'", "'<='", "'>='", "'+'", "'-'", "'*'", "'/'", "'%'", "'++'", "'--'", "'!'", "'new'", "'null'"
    };
    public static final int T__62=62;
    public static final int T__63=63;
    public static final int SGLIDDigit=27;
    public static final int IntType=15;
    public static final int T__61=61;
    public static final int ID_LIST=8;
    public static final int EOF=-1;
    public static final int T__60=60;
    public static final int Identifier=14;
    public static final int IF=6;
    public static final int T__55=55;
    public static final int T__56=56;
    public static final int T__57=57;
    public static final int T__58=58;
    public static final int T__51=51;
    public static final int T__52=52;
    public static final int T__53=53;
    public static final int T__54=54;
    public static final int EXP=7;
    public static final int StringType=17;
    public static final int T__59=59;
    public static final int SpriteAnimation=23;
    public static final int COMMENT=32;
    public static final int VARDEF=9;
    public static final int T__50=50;
    public static final int BooleanType=16;
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
    public static final int LIBMETHOD=12;
    public static final int IntegerAtom=20;
    public static final int FloatType=18;
    public static final int StringAtom=24;
    public static final int HEX_DIGIT=30;
    public static final int NEGATE=11;
    public static final int BooleanAtom=22;
    public static final int WS=31;
    public static final int T__33=33;
    public static final int T__34=34;
    public static final int T__35=35;
    public static final int T__36=36;
    public static final int T__37=37;
    public static final int T__38=38;
    public static final int T__39=39;
    public static final int UnicodeEscape=28;
    public static final int BLOCK=4;
    public static final int ASSIGN=10;
    public static final int STATEMENTS=5;
    public static final int ObjectType=19;
    public static final int FloatAtom=21;
    public static final int OctalEscape=29;
    public static final int Letter=26;
    public static final int EscapeSequence=25;
    public static final int STRING=13;

    // delegates
    // delegators


        public SGLParser(TokenStream input) {
            this(input, new RecognizerSharedState());
        }
        public SGLParser(TokenStream input, RecognizerSharedState state) {
            super(input, state);
             
        }
        
    protected TreeAdaptor adaptor = new CommonTreeAdaptor();

    public void setTreeAdaptor(TreeAdaptor adaptor) {
        this.adaptor = adaptor;
    }
    public TreeAdaptor getTreeAdaptor() {
        return adaptor;
    }

    public String[] getTokenNames() { return SGLParser.tokenNames; }
    public String getGrammarFileName() { return "C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g"; }



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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:77:1: compilationUnit : mainBlock EOF ;
    public final SGLParser.compilationUnit_return compilationUnit() throws RecognitionException {
        SGLParser.compilationUnit_return retval = new SGLParser.compilationUnit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token EOF2=null;
        SGLParser.mainBlock_return mainBlock1 = null;


        Object EOF2_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:78:2: ( mainBlock EOF )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:78:4: mainBlock EOF
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_mainBlock_in_compilationUnit112);
            mainBlock1=mainBlock();

            state._fsp--;

            adaptor.addChild(root_0, mainBlock1.getTree());
            EOF2=(Token)match(input,EOF,FOLLOW_EOF_in_compilationUnit114); 
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
        return retval;
    }
    // $ANTLR end "compilationUnit"

    public static class mainBlock_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "mainBlock"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:81:1: mainBlock : ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) ;
    public final SGLParser.mainBlock_return mainBlock() throws RecognitionException {
        SGLParser.mainBlock_return retval = new SGLParser.mainBlock_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.mainStatement_return mainStatement3 = null;

        SGLParser.methodDef_return methodDef4 = null;


        RewriteRuleSubtreeStream stream_methodDef=new RewriteRuleSubtreeStream(adaptor,"rule methodDef");
        RewriteRuleSubtreeStream stream_mainStatement=new RewriteRuleSubtreeStream(adaptor,"rule mainStatement");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:82:2: ( ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:82:4: ( mainStatement | methodDef )*
            {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:82:4: ( mainStatement | methodDef )*
            loop1:
            do {
                int alt1=3;
                int LA1_0 = input.LA(1);

                if ( ((LA1_0>=Identifier && LA1_0<=ObjectType)||(LA1_0>=41 && LA1_0<=42)) ) {
                    alt1=1;
                }
                else if ( (LA1_0==35) ) {
                    alt1=2;
                }


                switch (alt1) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:82:5: mainStatement
            	    {
            	    pushFollow(FOLLOW_mainStatement_in_mainBlock127);
            	    mainStatement3=mainStatement();

            	    state._fsp--;

            	    stream_mainStatement.add(mainStatement3.getTree());

            	    }
            	    break;
            	case 2 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:82:21: methodDef
            	    {
            	    pushFollow(FOLLOW_methodDef_in_mainBlock131);
            	    methodDef4=methodDef();

            	    state._fsp--;

            	    stream_methodDef.add(methodDef4.getTree());

            	    }
            	    break;

            	default :
            	    break loop1;
                }
            } while (true);



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
            // 83:8: -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:83:11: ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(BLOCK, "BLOCK"), root_1);

                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:83:19: ^( STATEMENTS ( mainStatement )* )
                {
                Object root_2 = (Object)adaptor.nil();
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(STATEMENTS, "STATEMENTS"), root_2);

                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:83:32: ( mainStatement )*
                while ( stream_mainStatement.hasNext() ) {
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
        return retval;
    }
    // $ANTLR end "mainBlock"

    public static class block_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "block"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:86:1: block : ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
    public final SGLParser.block_return block() throws RecognitionException {
        SGLParser.block_return retval = new SGLParser.block_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.statement_return statement5 = null;


        RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:87:2: ( ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:87:4: ( statement )*
            {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:87:4: ( statement )*
            loop2:
            do {
                int alt2=2;
                int LA2_0 = input.LA(1);

                if ( ((LA2_0>=Identifier && LA2_0<=ObjectType)||(LA2_0>=41 && LA2_0<=42)) ) {
                    alt2=1;
                }


                switch (alt2) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:87:4: statement
            	    {
            	    pushFollow(FOLLOW_statement_in_block179);
            	    statement5=statement();

            	    state._fsp--;

            	    stream_statement.add(statement5.getTree());

            	    }
            	    break;

            	default :
            	    break loop2;
                }
            } while (true);



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
            // 88:3: -> ^( BLOCK ^( STATEMENTS ( statement )* ) )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:88:6: ^( BLOCK ^( STATEMENTS ( statement )* ) )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(BLOCK, "BLOCK"), root_1);

                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:88:14: ^( STATEMENTS ( statement )* )
                {
                Object root_2 = (Object)adaptor.nil();
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(STATEMENTS, "STATEMENTS"), root_2);

                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:88:27: ( statement )*
                while ( stream_statement.hasNext() ) {
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
        return retval;
    }
    // $ANTLR end "block"

    public static class singleBlock_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "singleBlock"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:91:1: singleBlock : semicolonStatement -> ^( BLOCK ^( STATEMENTS semicolonStatement ) ) ;
    public final SGLParser.singleBlock_return singleBlock() throws RecognitionException {
        SGLParser.singleBlock_return retval = new SGLParser.singleBlock_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement6 = null;


        RewriteRuleSubtreeStream stream_semicolonStatement=new RewriteRuleSubtreeStream(adaptor,"rule semicolonStatement");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:92:2: ( semicolonStatement -> ^( BLOCK ^( STATEMENTS semicolonStatement ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:92:4: semicolonStatement
            {
            pushFollow(FOLLOW_semicolonStatement_in_singleBlock207);
            semicolonStatement6=semicolonStatement();

            state._fsp--;

            stream_semicolonStatement.add(semicolonStatement6.getTree());


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
            // 93:3: -> ^( BLOCK ^( STATEMENTS semicolonStatement ) )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:93:6: ^( BLOCK ^( STATEMENTS semicolonStatement ) )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(BLOCK, "BLOCK"), root_1);

                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:93:14: ^( STATEMENTS semicolonStatement )
                {
                Object root_2 = (Object)adaptor.nil();
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(STATEMENTS, "STATEMENTS"), root_2);

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
        return retval;
    }
    // $ANTLR end "singleBlock"

    public static class commonBlock_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "commonBlock"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:96:1: commonBlock : ( singleBlock | '{' block '}' );
    public final SGLParser.commonBlock_return commonBlock() throws RecognitionException {
        SGLParser.commonBlock_return retval = new SGLParser.commonBlock_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal8=null;
        Token char_literal10=null;
        SGLParser.singleBlock_return singleBlock7 = null;

        SGLParser.block_return block9 = null;


        Object char_literal8_tree=null;
        Object char_literal10_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:97:2: ( singleBlock | '{' block '}' )
            int alt3=2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0>=Identifier && LA3_0<=ObjectType)) ) {
                alt3=1;
            }
            else if ( (LA3_0==33) ) {
                alt3=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 3, 0, input);

                throw nvae;
            }
            switch (alt3) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:97:4: singleBlock
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_singleBlock_in_commonBlock233);
                    singleBlock7=singleBlock();

                    state._fsp--;

                    adaptor.addChild(root_0, singleBlock7.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:98:4: '{' block '}'
                    {
                    root_0 = (Object)adaptor.nil();

                    char_literal8=(Token)match(input,33,FOLLOW_33_in_commonBlock238); 
                    pushFollow(FOLLOW_block_in_commonBlock241);
                    block9=block();

                    state._fsp--;

                    adaptor.addChild(root_0, block9.getTree());
                    char_literal10=(Token)match(input,34,FOLLOW_34_in_commonBlock243); 

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
        return retval;
    }
    // $ANTLR end "commonBlock"

    public static class methodDef_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "methodDef"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:102:1: methodDef : 'method' Identifier '(' ( idList )? ')' ;
    public final SGLParser.methodDef_return methodDef() throws RecognitionException {
        SGLParser.methodDef_return retval = new SGLParser.methodDef_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal11=null;
        Token Identifier12=null;
        Token char_literal13=null;
        Token char_literal15=null;
        SGLParser.idList_return idList14 = null;


        Object string_literal11_tree=null;
        Object Identifier12_tree=null;
        Object char_literal13_tree=null;
        Object char_literal15_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:103:3: ( 'method' Identifier '(' ( idList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:103:5: 'method' Identifier '(' ( idList )? ')'
            {
            root_0 = (Object)adaptor.nil();

            string_literal11=(Token)match(input,35,FOLLOW_35_in_methodDef277); 
            string_literal11_tree = (Object)adaptor.create(string_literal11);
            adaptor.addChild(root_0, string_literal11_tree);

            Identifier12=(Token)match(input,Identifier,FOLLOW_Identifier_in_methodDef279); 
            Identifier12_tree = (Object)adaptor.create(Identifier12);
            adaptor.addChild(root_0, Identifier12_tree);

            char_literal13=(Token)match(input,36,FOLLOW_36_in_methodDef281); 
            char_literal13_tree = (Object)adaptor.create(char_literal13);
            adaptor.addChild(root_0, char_literal13_tree);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:103:29: ( idList )?
            int alt4=2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0==Identifier) ) {
                alt4=1;
            }
            switch (alt4) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:103:29: idList
                    {
                    pushFollow(FOLLOW_idList_in_methodDef283);
                    idList14=idList();

                    state._fsp--;

                    adaptor.addChild(root_0, idList14.getTree());

                    }
                    break;

            }

            char_literal15=(Token)match(input,37,FOLLOW_37_in_methodDef286); 
            char_literal15_tree = (Object)adaptor.create(char_literal15);
            adaptor.addChild(root_0, char_literal15_tree);

             /* implemented later */ 

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
        return retval;
    }
    // $ANTLR end "methodDef"

    public static class mainStatement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "mainStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:107:1: mainStatement : statement ;
    public final SGLParser.mainStatement_return mainStatement() throws RecognitionException {
        SGLParser.mainStatement_return retval = new SGLParser.mainStatement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.statement_return statement16 = null;



        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:108:2: ( statement )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:108:4: statement
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_statement_in_mainStatement315);
            statement16=statement();

            state._fsp--;

            adaptor.addChild(root_0, statement16.getTree());

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
        return retval;
    }
    // $ANTLR end "mainStatement"

    public static class semicolonStatement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "semicolonStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:111:1: semicolonStatement : ( variableDeclarationList | variableAssignment ) ';' ;
    public final SGLParser.semicolonStatement_return semicolonStatement() throws RecognitionException {
        SGLParser.semicolonStatement_return retval = new SGLParser.semicolonStatement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal19=null;
        SGLParser.variableDeclarationList_return variableDeclarationList17 = null;

        SGLParser.variableAssignment_return variableAssignment18 = null;


        Object char_literal19_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:112:2: ( ( variableDeclarationList | variableAssignment ) ';' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:112:4: ( variableDeclarationList | variableAssignment ) ';'
            {
            root_0 = (Object)adaptor.nil();

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:112:4: ( variableDeclarationList | variableAssignment )
            int alt5=2;
            int LA5_0 = input.LA(1);

            if ( ((LA5_0>=IntType && LA5_0<=ObjectType)) ) {
                alt5=1;
            }
            else if ( (LA5_0==Identifier) ) {
                alt5=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 5, 0, input);

                throw nvae;
            }
            switch (alt5) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:112:5: variableDeclarationList
                    {
                    pushFollow(FOLLOW_variableDeclarationList_in_semicolonStatement328);
                    variableDeclarationList17=variableDeclarationList();

                    state._fsp--;

                    adaptor.addChild(root_0, variableDeclarationList17.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:113:4: variableAssignment
                    {
                    pushFollow(FOLLOW_variableAssignment_in_semicolonStatement334);
                    variableAssignment18=variableAssignment();

                    state._fsp--;

                    adaptor.addChild(root_0, variableAssignment18.getTree());

                    }
                    break;

            }

            char_literal19=(Token)match(input,38,FOLLOW_38_in_semicolonStatement340); 

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
        return retval;
    }
    // $ANTLR end "semicolonStatement"

    public static class statement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "statement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:118:1: statement : ( semicolonStatement | ifStatement | whileLoop );
    public final SGLParser.statement_return statement() throws RecognitionException {
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.semicolonStatement_return semicolonStatement20 = null;

        SGLParser.ifStatement_return ifStatement21 = null;

        SGLParser.whileLoop_return whileLoop22 = null;



        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:120:2: ( semicolonStatement | ifStatement | whileLoop )
            int alt6=3;
            switch ( input.LA(1) ) {
            case Identifier:
            case IntType:
            case BooleanType:
            case StringType:
            case FloatType:
            case ObjectType:
                {
                alt6=1;
                }
                break;
            case 42:
                {
                alt6=2;
                }
                break;
            case 41:
                {
                alt6=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 6, 0, input);

                throw nvae;
            }

            switch (alt6) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:120:4: semicolonStatement
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_semicolonStatement_in_statement356);
                    semicolonStatement20=semicolonStatement();

                    state._fsp--;

                    adaptor.addChild(root_0, semicolonStatement20.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:121:4: ifStatement
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_ifStatement_in_statement361);
                    ifStatement21=ifStatement();

                    state._fsp--;

                    adaptor.addChild(root_0, ifStatement21.getTree());

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:4: whileLoop
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_whileLoop_in_statement366);
                    whileLoop22=whileLoop();

                    state._fsp--;

                    adaptor.addChild(root_0, whileLoop22.getTree());

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
        return retval;
    }
    // $ANTLR end "statement"

    public static class variableDeclarationList_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableDeclarationList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:129:1: variableDeclarationList : variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( VARDEF variableType variableDecAssignment ) )+ ;
    public final SGLParser.variableDeclarationList_return variableDeclarationList() throws RecognitionException {
        SGLParser.variableDeclarationList_return retval = new SGLParser.variableDeclarationList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal25=null;
        SGLParser.variableType_return variableType23 = null;

        SGLParser.variableDecAssignment_return variableDecAssignment24 = null;

        SGLParser.variableDecAssignment_return variableDecAssignment26 = null;


        Object char_literal25_tree=null;
        RewriteRuleTokenStream stream_39=new RewriteRuleTokenStream(adaptor,"token 39");
        RewriteRuleSubtreeStream stream_variableType=new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableDecAssignment=new RewriteRuleSubtreeStream(adaptor,"rule variableDecAssignment");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:130:2: ( variableType variableDecAssignment ( ',' variableDecAssignment )* -> ( ^( VARDEF variableType variableDecAssignment ) )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:130:4: variableType variableDecAssignment ( ',' variableDecAssignment )*
            {
            pushFollow(FOLLOW_variableType_in_variableDeclarationList382);
            variableType23=variableType();

            state._fsp--;

            stream_variableType.add(variableType23.getTree());
            pushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList384);
            variableDecAssignment24=variableDecAssignment();

            state._fsp--;

            stream_variableDecAssignment.add(variableDecAssignment24.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:130:39: ( ',' variableDecAssignment )*
            loop7:
            do {
                int alt7=2;
                int LA7_0 = input.LA(1);

                if ( (LA7_0==39) ) {
                    alt7=1;
                }


                switch (alt7) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:130:40: ',' variableDecAssignment
            	    {
            	    char_literal25=(Token)match(input,39,FOLLOW_39_in_variableDeclarationList387);  
            	    stream_39.add(char_literal25);

            	    pushFollow(FOLLOW_variableDecAssignment_in_variableDeclarationList389);
            	    variableDecAssignment26=variableDecAssignment();

            	    state._fsp--;

            	    stream_variableDecAssignment.add(variableDecAssignment26.getTree());

            	    }
            	    break;

            	default :
            	    break loop7;
                }
            } while (true);



            // AST REWRITE
            // elements: variableDecAssignment, variableType
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 130:68: -> ( ^( VARDEF variableType variableDecAssignment ) )+
            {
                if ( !(stream_variableDecAssignment.hasNext()||stream_variableType.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_variableDecAssignment.hasNext()||stream_variableType.hasNext() ) {
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:130:71: ^( VARDEF variableType variableDecAssignment )
                    {
                    Object root_1 = (Object)adaptor.nil();
                    root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(VARDEF, "VARDEF"), root_1);

                    adaptor.addChild(root_1, stream_variableType.nextTree());
                    adaptor.addChild(root_1, stream_variableDecAssignment.nextTree());

                    adaptor.addChild(root_0, root_1);
                    }

                }
                stream_variableDecAssignment.reset();
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
        return retval;
    }
    // $ANTLR end "variableDeclarationList"

    public static class variableDecAssignment_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableDecAssignment"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:133:1: variableDecAssignment : variableName ( '=' expression )? -> variableName ( expression )? ;
    public final SGLParser.variableDecAssignment_return variableDecAssignment() throws RecognitionException {
        SGLParser.variableDecAssignment_return retval = new SGLParser.variableDecAssignment_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal28=null;
        SGLParser.variableName_return variableName27 = null;

        SGLParser.expression_return expression29 = null;


        Object char_literal28_tree=null;
        RewriteRuleTokenStream stream_40=new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName=new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:4: variableName ( '=' expression )?
            {
            pushFollow(FOLLOW_variableName_in_variableDecAssignment413);
            variableName27=variableName();

            state._fsp--;

            stream_variableName.add(variableName27.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:17: ( '=' expression )?
            int alt8=2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0==40) ) {
                alt8=1;
            }
            switch (alt8) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:18: '=' expression
                    {
                    char_literal28=(Token)match(input,40,FOLLOW_40_in_variableDecAssignment416);  
                    stream_40.add(char_literal28);

                    pushFollow(FOLLOW_expression_in_variableDecAssignment418);
                    expression29=expression();

                    state._fsp--;

                    stream_expression.add(expression29.getTree());

                    }
                    break;

            }



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
            // 134:36: -> variableName ( expression )?
            {
                adaptor.addChild(root_0, stream_variableName.nextTree());
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:134:52: ( expression )?
                if ( stream_expression.hasNext() ) {
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
        return retval;
    }
    // $ANTLR end "variableDecAssignment"

    public static class variableAssignment_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableAssignment"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:137:1: variableAssignment : variableName '=' expression -> ^( ASSIGN variableName expression ) ;
    public final SGLParser.variableAssignment_return variableAssignment() throws RecognitionException {
        SGLParser.variableAssignment_return retval = new SGLParser.variableAssignment_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal31=null;
        SGLParser.variableName_return variableName30 = null;

        SGLParser.expression_return expression32 = null;


        Object char_literal31_tree=null;
        RewriteRuleTokenStream stream_40=new RewriteRuleTokenStream(adaptor,"token 40");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName=new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:138:2: ( variableName '=' expression -> ^( ASSIGN variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:138:4: variableName '=' expression
            {
            pushFollow(FOLLOW_variableName_in_variableAssignment439);
            variableName30=variableName();

            state._fsp--;

            stream_variableName.add(variableName30.getTree());
            char_literal31=(Token)match(input,40,FOLLOW_40_in_variableAssignment441);  
            stream_40.add(char_literal31);

            pushFollow(FOLLOW_expression_in_variableAssignment443);
            expression32=expression();

            state._fsp--;

            stream_expression.add(expression32.getTree());


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
            // 138:33: -> ^( ASSIGN variableName expression )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:138:36: ^( ASSIGN variableName expression )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(ASSIGN, "ASSIGN"), root_1);

                adaptor.addChild(root_1, stream_variableName.nextTree());
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
        return retval;
    }
    // $ANTLR end "variableAssignment"

    public static class variableName_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableName"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:146:1: variableName : Identifier ;
    public final SGLParser.variableName_return variableName() throws RecognitionException {
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token Identifier33=null;

        Object Identifier33_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:147:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:147:4: Identifier
            {
            root_0 = (Object)adaptor.nil();

            Identifier33=(Token)match(input,Identifier,FOLLOW_Identifier_in_variableName474); 
            Identifier33_tree = (Object)adaptor.create(Identifier33);
            adaptor.addChild(root_0, Identifier33_tree);


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
        return retval;
    }
    // $ANTLR end "variableName"

    public static class variableType_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableType"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:150:1: variableType : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public final SGLParser.variableType_return variableType() throws RecognitionException {
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set34=null;

        Object set34_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:151:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            root_0 = (Object)adaptor.nil();

            set34=(Token)input.LT(1);
            if ( (input.LA(1)>=IntType && input.LA(1)<=ObjectType) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set34));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
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
        return retval;
    }
    // $ANTLR end "variableType"

    public static class whileLoop_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "whileLoop"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:159:1: whileLoop : 'while' '(' expression ')' commonBlock -> ^( 'while' expression commonBlock ) ;
    public final SGLParser.whileLoop_return whileLoop() throws RecognitionException {
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal35=null;
        Token char_literal36=null;
        Token char_literal38=null;
        SGLParser.expression_return expression37 = null;

        SGLParser.commonBlock_return commonBlock39 = null;


        Object string_literal35_tree=null;
        Object char_literal36_tree=null;
        Object char_literal38_tree=null;
        RewriteRuleTokenStream stream_41=new RewriteRuleTokenStream(adaptor,"token 41");
        RewriteRuleTokenStream stream_36=new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleTokenStream stream_37=new RewriteRuleTokenStream(adaptor,"token 37");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock=new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:160:2: ( 'while' '(' expression ')' commonBlock -> ^( 'while' expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:160:4: 'while' '(' expression ')' commonBlock
            {
            string_literal35=(Token)match(input,41,FOLLOW_41_in_whileLoop518);  
            stream_41.add(string_literal35);

            char_literal36=(Token)match(input,36,FOLLOW_36_in_whileLoop520);  
            stream_36.add(char_literal36);

            pushFollow(FOLLOW_expression_in_whileLoop522);
            expression37=expression();

            state._fsp--;

            stream_expression.add(expression37.getTree());
            char_literal38=(Token)match(input,37,FOLLOW_37_in_whileLoop524);  
            stream_37.add(char_literal38);

            pushFollow(FOLLOW_commonBlock_in_whileLoop526);
            commonBlock39=commonBlock();

            state._fsp--;

            stream_commonBlock.add(commonBlock39.getTree());


            // AST REWRITE
            // elements: expression, commonBlock, 41
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 160:43: -> ^( 'while' expression commonBlock )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:160:46: ^( 'while' expression commonBlock )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot(stream_41.nextNode(), root_1);

                adaptor.addChild(root_1, stream_expression.nextTree());
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
        return retval;
    }
    // $ANTLR end "whileLoop"

    public static class ifStatement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "ifStatement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:163:1: ifStatement : ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) ;
    public final SGLParser.ifStatement_return ifStatement() throws RecognitionException {
        SGLParser.ifStatement_return retval = new SGLParser.ifStatement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.ifStat_return ifStat40 = null;

        SGLParser.elseIfStat_return elseIfStat41 = null;

        SGLParser.elseStat_return elseStat42 = null;


        RewriteRuleSubtreeStream stream_elseIfStat=new RewriteRuleSubtreeStream(adaptor,"rule elseIfStat");
        RewriteRuleSubtreeStream stream_ifStat=new RewriteRuleSubtreeStream(adaptor,"rule ifStat");
        RewriteRuleSubtreeStream stream_elseStat=new RewriteRuleSubtreeStream(adaptor,"rule elseStat");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:2: ( ifStat ( elseIfStat )* ( elseStat )? -> ^( IF ifStat ( elseIfStat )* ( elseStat )? ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:4: ifStat ( elseIfStat )* ( elseStat )?
            {
            pushFollow(FOLLOW_ifStat_in_ifStatement547);
            ifStat40=ifStat();

            state._fsp--;

            stream_ifStat.add(ifStat40.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:11: ( elseIfStat )*
            loop9:
            do {
                int alt9=2;
                int LA9_0 = input.LA(1);

                if ( (LA9_0==43) ) {
                    int LA9_1 = input.LA(2);

                    if ( (LA9_1==42) ) {
                        alt9=1;
                    }


                }


                switch (alt9) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:11: elseIfStat
            	    {
            	    pushFollow(FOLLOW_elseIfStat_in_ifStatement549);
            	    elseIfStat41=elseIfStat();

            	    state._fsp--;

            	    stream_elseIfStat.add(elseIfStat41.getTree());

            	    }
            	    break;

            	default :
            	    break loop9;
                }
            } while (true);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:23: ( elseStat )?
            int alt10=2;
            int LA10_0 = input.LA(1);

            if ( (LA10_0==43) ) {
                alt10=1;
            }
            switch (alt10) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:23: elseStat
                    {
                    pushFollow(FOLLOW_elseStat_in_ifStatement552);
                    elseStat42=elseStat();

                    state._fsp--;

                    stream_elseStat.add(elseStat42.getTree());

                    }
                    break;

            }



            // AST REWRITE
            // elements: ifStat, elseStat, elseIfStat
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 164:33: -> ^( IF ifStat ( elseIfStat )* ( elseStat )? )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:36: ^( IF ifStat ( elseIfStat )* ( elseStat )? )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(IF, "IF"), root_1);

                adaptor.addChild(root_1, stream_ifStat.nextTree());
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:48: ( elseIfStat )*
                while ( stream_elseIfStat.hasNext() ) {
                    adaptor.addChild(root_1, stream_elseIfStat.nextTree());

                }
                stream_elseIfStat.reset();
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:164:60: ( elseStat )?
                if ( stream_elseStat.hasNext() ) {
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
        return retval;
    }
    // $ANTLR end "ifStatement"

    public static class ifStat_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "ifStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:166:1: ifStat : 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public final SGLParser.ifStat_return ifStat() throws RecognitionException {
        SGLParser.ifStat_return retval = new SGLParser.ifStat_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal43=null;
        SGLParser.expression_return expression44 = null;

        SGLParser.commonBlock_return commonBlock45 = null;


        Object string_literal43_tree=null;
        RewriteRuleTokenStream stream_42=new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock=new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:167:2: ( 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:167:4: 'if' expression commonBlock
            {
            string_literal43=(Token)match(input,42,FOLLOW_42_in_ifStat577);  
            stream_42.add(string_literal43);

            pushFollow(FOLLOW_expression_in_ifStat579);
            expression44=expression();

            state._fsp--;

            stream_expression.add(expression44.getTree());
            pushFollow(FOLLOW_commonBlock_in_ifStat581);
            commonBlock45=commonBlock();

            state._fsp--;

            stream_commonBlock.add(commonBlock45.getTree());


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
            // 167:32: -> ^( EXP expression commonBlock )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:167:35: ^( EXP expression commonBlock )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(EXP, "EXP"), root_1);

                adaptor.addChild(root_1, stream_expression.nextTree());
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
        return retval;
    }
    // $ANTLR end "ifStat"

    public static class elseIfStat_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "elseIfStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:170:1: elseIfStat : 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) ;
    public final SGLParser.elseIfStat_return elseIfStat() throws RecognitionException {
        SGLParser.elseIfStat_return retval = new SGLParser.elseIfStat_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal46=null;
        Token string_literal47=null;
        SGLParser.expression_return expression48 = null;

        SGLParser.commonBlock_return commonBlock49 = null;


        Object string_literal46_tree=null;
        Object string_literal47_tree=null;
        RewriteRuleTokenStream stream_43=new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleTokenStream stream_42=new RewriteRuleTokenStream(adaptor,"token 42");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock=new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:171:2: ( 'else' 'if' expression commonBlock -> ^( EXP expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:171:4: 'else' 'if' expression commonBlock
            {
            string_literal46=(Token)match(input,43,FOLLOW_43_in_elseIfStat602);  
            stream_43.add(string_literal46);

            string_literal47=(Token)match(input,42,FOLLOW_42_in_elseIfStat604);  
            stream_42.add(string_literal47);

            pushFollow(FOLLOW_expression_in_elseIfStat606);
            expression48=expression();

            state._fsp--;

            stream_expression.add(expression48.getTree());
            pushFollow(FOLLOW_commonBlock_in_elseIfStat608);
            commonBlock49=commonBlock();

            state._fsp--;

            stream_commonBlock.add(commonBlock49.getTree());


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
            // 171:39: -> ^( EXP expression commonBlock )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:171:42: ^( EXP expression commonBlock )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(EXP, "EXP"), root_1);

                adaptor.addChild(root_1, stream_expression.nextTree());
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
        return retval;
    }
    // $ANTLR end "elseIfStat"

    public static class elseStat_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "elseStat"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:1: elseStat : 'else' commonBlock -> ^( EXP commonBlock ) ;
    public final SGLParser.elseStat_return elseStat() throws RecognitionException {
        SGLParser.elseStat_return retval = new SGLParser.elseStat_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal50=null;
        SGLParser.commonBlock_return commonBlock51 = null;


        Object string_literal50_tree=null;
        RewriteRuleTokenStream stream_43=new RewriteRuleTokenStream(adaptor,"token 43");
        RewriteRuleSubtreeStream stream_commonBlock=new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:175:2: ( 'else' commonBlock -> ^( EXP commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:175:4: 'else' commonBlock
            {
            string_literal50=(Token)match(input,43,FOLLOW_43_in_elseStat630);  
            stream_43.add(string_literal50);

            pushFollow(FOLLOW_commonBlock_in_elseStat632);
            commonBlock51=commonBlock();

            state._fsp--;

            stream_commonBlock.add(commonBlock51.getTree());


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
            // 175:23: -> ^( EXP commonBlock )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:175:26: ^( EXP commonBlock )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(EXP, "EXP"), root_1);

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
        return retval;
    }
    // $ANTLR end "elseStat"

    public static class expression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "expression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:201:1: expression : conditionalExpression ;
    public final SGLParser.expression_return expression() throws RecognitionException {
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression52 = null;



        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:202:5: ( conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:202:8: conditionalExpression
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_conditionalExpression_in_expression695);
            conditionalExpression52=conditionalExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalExpression52.getTree());

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
        return retval;
    }
    // $ANTLR end "expression"

    public static class conditionalExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "conditionalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:211:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public final SGLParser.conditionalExpression_return conditionalExpression() throws RecognitionException {
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal54=null;
        Token char_literal56=null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression53 = null;

        SGLParser.conditionalExpression_return conditionalExpression55 = null;

        SGLParser.conditionalExpression_return conditionalExpression57 = null;


        Object char_literal54_tree=null;
        Object char_literal56_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:212:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:212:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression736);
            conditionalOrExpression53=conditionalOrExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalOrExpression53.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:212:33: ( '?' conditionalExpression ':' conditionalExpression )?
            int alt11=2;
            int LA11_0 = input.LA(1);

            if ( (LA11_0==44) ) {
                alt11=1;
            }
            switch (alt11) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:212:35: '?' conditionalExpression ':' conditionalExpression
                    {
                    char_literal54=(Token)match(input,44,FOLLOW_44_in_conditionalExpression740); 
                    char_literal54_tree = (Object)adaptor.create(char_literal54);
                    root_0 = (Object)adaptor.becomeRoot(char_literal54_tree, root_0);

                    pushFollow(FOLLOW_conditionalExpression_in_conditionalExpression743);
                    conditionalExpression55=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression55.getTree());
                    char_literal56=(Token)match(input,45,FOLLOW_45_in_conditionalExpression745); 
                    pushFollow(FOLLOW_conditionalExpression_in_conditionalExpression748);
                    conditionalExpression57=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression57.getTree());

                    }
                    break;

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
        return retval;
    }
    // $ANTLR end "conditionalExpression"

    public static class conditionalOrExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "conditionalOrExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:217:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public final SGLParser.conditionalOrExpression_return conditionalOrExpression() throws RecognitionException {
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal59=null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression58 = null;

        SGLParser.conditionalAndExpression_return conditionalAndExpression60 = null;


        Object string_literal59_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:218:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:218:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression791);
            conditionalAndExpression58=conditionalAndExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalAndExpression58.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:218:34: ( '||' conditionalAndExpression )*
            loop12:
            do {
                int alt12=2;
                int LA12_0 = input.LA(1);

                if ( (LA12_0==46) ) {
                    alt12=1;
                }


                switch (alt12) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:218:36: '||' conditionalAndExpression
            	    {
            	    string_literal59=(Token)match(input,46,FOLLOW_46_in_conditionalOrExpression795); 
            	    string_literal59_tree = (Object)adaptor.create(string_literal59);
            	    root_0 = (Object)adaptor.becomeRoot(string_literal59_tree, root_0);

            	    pushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression798);
            	    conditionalAndExpression60=conditionalAndExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, conditionalAndExpression60.getTree());

            	    }
            	    break;

            	default :
            	    break loop12;
                }
            } while (true);


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
        return retval;
    }
    // $ANTLR end "conditionalOrExpression"

    public static class conditionalAndExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "conditionalAndExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:222:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public final SGLParser.conditionalAndExpression_return conditionalAndExpression() throws RecognitionException {
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal62=null;
        SGLParser.equalityExpression_return equalityExpression61 = null;

        SGLParser.equalityExpression_return equalityExpression63 = null;


        Object string_literal62_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:9: equalityExpression ( '&&' equalityExpression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression829);
            equalityExpression61=equalityExpression();

            state._fsp--;

            adaptor.addChild(root_0, equalityExpression61.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:28: ( '&&' equalityExpression )*
            loop13:
            do {
                int alt13=2;
                int LA13_0 = input.LA(1);

                if ( (LA13_0==47) ) {
                    alt13=1;
                }


                switch (alt13) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:223:30: '&&' equalityExpression
            	    {
            	    string_literal62=(Token)match(input,47,FOLLOW_47_in_conditionalAndExpression833); 
            	    string_literal62_tree = (Object)adaptor.create(string_literal62);
            	    root_0 = (Object)adaptor.becomeRoot(string_literal62_tree, root_0);

            	    pushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression836);
            	    equalityExpression63=equalityExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, equalityExpression63.getTree());

            	    }
            	    break;

            	default :
            	    break loop13;
                }
            } while (true);


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
        return retval;
    }
    // $ANTLR end "conditionalAndExpression"

    public static class equalityExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "equalityExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:227:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public final SGLParser.equalityExpression_return equalityExpression() throws RecognitionException {
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal65=null;
        Token string_literal66=null;
        SGLParser.relationalExpression_return relationalExpression64 = null;

        SGLParser.relationalExpression_return relationalExpression67 = null;


        Object string_literal65_tree=null;
        Object string_literal66_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_relationalExpression_in_equalityExpression863);
            relationalExpression64=relationalExpression();

            state._fsp--;

            adaptor.addChild(root_0, relationalExpression64.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:30: ( ( '==' | '!=' ) relationalExpression )*
            loop15:
            do {
                int alt15=2;
                int LA15_0 = input.LA(1);

                if ( ((LA15_0>=48 && LA15_0<=49)) ) {
                    alt15=1;
                }


                switch (alt15) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:32: ( '==' | '!=' ) relationalExpression
            	    {
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:32: ( '==' | '!=' )
            	    int alt14=2;
            	    int LA14_0 = input.LA(1);

            	    if ( (LA14_0==48) ) {
            	        alt14=1;
            	    }
            	    else if ( (LA14_0==49) ) {
            	        alt14=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 14, 0, input);

            	        throw nvae;
            	    }
            	    switch (alt14) {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:33: '=='
            	            {
            	            string_literal65=(Token)match(input,48,FOLLOW_48_in_equalityExpression868); 
            	            string_literal65_tree = (Object)adaptor.create(string_literal65);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal65_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:41: '!='
            	            {
            	            string_literal66=(Token)match(input,49,FOLLOW_49_in_equalityExpression873); 
            	            string_literal66_tree = (Object)adaptor.create(string_literal66);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal66_tree, root_0);


            	            }
            	            break;

            	    }

            	    pushFollow(FOLLOW_relationalExpression_in_equalityExpression877);
            	    relationalExpression67=relationalExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, relationalExpression67.getTree());

            	    }
            	    break;

            	default :
            	    break loop15;
                }
            } while (true);


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
        return retval;
    }
    // $ANTLR end "equalityExpression"

    public static class relationalExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "relationalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:232:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public final SGLParser.relationalExpression_return relationalExpression() throws RecognitionException {
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal69=null;
        Token char_literal70=null;
        Token string_literal71=null;
        Token string_literal72=null;
        SGLParser.additiveExpression_return additiveExpression68 = null;

        SGLParser.additiveExpression_return additiveExpression73 = null;


        Object char_literal69_tree=null;
        Object char_literal70_tree=null;
        Object string_literal71_tree=null;
        Object string_literal72_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_additiveExpression_in_relationalExpression908);
            additiveExpression68=additiveExpression();

            state._fsp--;

            adaptor.addChild(root_0, additiveExpression68.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            loop17:
            do {
                int alt17=2;
                int LA17_0 = input.LA(1);

                if ( ((LA17_0>=50 && LA17_0<=53)) ) {
                    alt17=1;
                }


                switch (alt17) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            	    {
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:29: ( '<' | '>' | '<=' | '>=' )
            	    int alt16=4;
            	    switch ( input.LA(1) ) {
            	    case 50:
            	        {
            	        alt16=1;
            	        }
            	        break;
            	    case 51:
            	        {
            	        alt16=2;
            	        }
            	        break;
            	    case 52:
            	        {
            	        alt16=3;
            	        }
            	        break;
            	    case 53:
            	        {
            	        alt16=4;
            	        }
            	        break;
            	    default:
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 16, 0, input);

            	        throw nvae;
            	    }

            	    switch (alt16) {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:30: '<'
            	            {
            	            char_literal69=(Token)match(input,50,FOLLOW_50_in_relationalExpression912); 
            	            char_literal69_tree = (Object)adaptor.create(char_literal69);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal69_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:35: '>'
            	            {
            	            char_literal70=(Token)match(input,51,FOLLOW_51_in_relationalExpression915); 
            	            char_literal70_tree = (Object)adaptor.create(char_literal70);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal70_tree, root_0);


            	            }
            	            break;
            	        case 3 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:40: '<='
            	            {
            	            string_literal71=(Token)match(input,52,FOLLOW_52_in_relationalExpression918); 
            	            string_literal71_tree = (Object)adaptor.create(string_literal71);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal71_tree, root_0);


            	            }
            	            break;
            	        case 4 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:233:46: '>='
            	            {
            	            string_literal72=(Token)match(input,53,FOLLOW_53_in_relationalExpression921); 
            	            string_literal72_tree = (Object)adaptor.create(string_literal72);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal72_tree, root_0);


            	            }
            	            break;

            	    }

            	    pushFollow(FOLLOW_additiveExpression_in_relationalExpression925);
            	    additiveExpression73=additiveExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, additiveExpression73.getTree());

            	    }
            	    break;

            	default :
            	    break loop17;
                }
            } while (true);


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
        return retval;
    }
    // $ANTLR end "relationalExpression"

    public static class additiveExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "additiveExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:237:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public final SGLParser.additiveExpression_return additiveExpression() throws RecognitionException {
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal75=null;
        Token char_literal76=null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression74 = null;

        SGLParser.multiplicativeExpression_return multiplicativeExpression77 = null;


        Object char_literal75_tree=null;
        Object char_literal76_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression963);
            multiplicativeExpression74=multiplicativeExpression();

            state._fsp--;

            adaptor.addChild(root_0, multiplicativeExpression74.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:34: ( ( '+' | '-' ) multiplicativeExpression )*
            loop19:
            do {
                int alt19=2;
                int LA19_0 = input.LA(1);

                if ( ((LA19_0>=54 && LA19_0<=55)) ) {
                    alt19=1;
                }


                switch (alt19) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:35: ( '+' | '-' ) multiplicativeExpression
            	    {
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:35: ( '+' | '-' )
            	    int alt18=2;
            	    int LA18_0 = input.LA(1);

            	    if ( (LA18_0==54) ) {
            	        alt18=1;
            	    }
            	    else if ( (LA18_0==55) ) {
            	        alt18=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 18, 0, input);

            	        throw nvae;
            	    }
            	    switch (alt18) {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:36: '+'
            	            {
            	            char_literal75=(Token)match(input,54,FOLLOW_54_in_additiveExpression967); 
            	            char_literal75_tree = (Object)adaptor.create(char_literal75);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal75_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:238:41: '-'
            	            {
            	            char_literal76=(Token)match(input,55,FOLLOW_55_in_additiveExpression970); 
            	            char_literal76_tree = (Object)adaptor.create(char_literal76);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal76_tree, root_0);


            	            }
            	            break;

            	    }

            	    pushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression974);
            	    multiplicativeExpression77=multiplicativeExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, multiplicativeExpression77.getTree());

            	    }
            	    break;

            	default :
            	    break loop19;
                }
            } while (true);


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
        return retval;
    }
    // $ANTLR end "additiveExpression"

    public static class multiplicativeExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "multiplicativeExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:1: multiplicativeExpression : negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* ;
    public final SGLParser.multiplicativeExpression_return multiplicativeExpression() throws RecognitionException {
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal79=null;
        Token char_literal80=null;
        Token char_literal81=null;
        SGLParser.negativeExpression_return negativeExpression78 = null;

        SGLParser.negativeExpression_return negativeExpression82 = null;


        Object char_literal79_tree=null;
        Object char_literal80_tree=null;
        Object char_literal81_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:243:5: ( negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:243:9: negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression1008);
            negativeExpression78=negativeExpression();

            state._fsp--;

            adaptor.addChild(root_0, negativeExpression78.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:5: ( ( '*' | '/' | '%' ) negativeExpression )*
            loop21:
            do {
                int alt21=2;
                int LA21_0 = input.LA(1);

                if ( ((LA21_0>=56 && LA21_0<=58)) ) {
                    alt21=1;
                }


                switch (alt21) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:6: ( '*' | '/' | '%' ) negativeExpression
            	    {
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:6: ( '*' | '/' | '%' )
            	    int alt20=3;
            	    switch ( input.LA(1) ) {
            	    case 56:
            	        {
            	        alt20=1;
            	        }
            	        break;
            	    case 57:
            	        {
            	        alt20=2;
            	        }
            	        break;
            	    case 58:
            	        {
            	        alt20=3;
            	        }
            	        break;
            	    default:
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 20, 0, input);

            	        throw nvae;
            	    }

            	    switch (alt20) {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:7: '*'
            	            {
            	            char_literal79=(Token)match(input,56,FOLLOW_56_in_multiplicativeExpression1016); 
            	            char_literal79_tree = (Object)adaptor.create(char_literal79);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal79_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:12: '/'
            	            {
            	            char_literal80=(Token)match(input,57,FOLLOW_57_in_multiplicativeExpression1019); 
            	            char_literal80_tree = (Object)adaptor.create(char_literal80);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal80_tree, root_0);


            	            }
            	            break;
            	        case 3 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:244:17: '%'
            	            {
            	            char_literal81=(Token)match(input,58,FOLLOW_58_in_multiplicativeExpression1022); 
            	            char_literal81_tree = (Object)adaptor.create(char_literal81);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal81_tree, root_0);


            	            }
            	            break;

            	    }

            	    pushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression1026);
            	    negativeExpression82=negativeExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, negativeExpression82.getTree());

            	    }
            	    break;

            	default :
            	    break loop21;
                }
            } while (true);


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
        return retval;
    }
    // $ANTLR end "multiplicativeExpression"

    public static class unaryExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "unaryExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public final SGLParser.unaryExpression_return unaryExpression() throws RecognitionException {
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal83=null;
        Token string_literal85=null;
        SGLParser.unaryExpression_return unaryExpression84 = null;

        SGLParser.unaryExpression_return unaryExpression86 = null;

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus87 = null;


        Object string_literal83_tree=null;
        Object string_literal85_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt22=3;
            switch ( input.LA(1) ) {
            case 59:
                {
                alt22=1;
                }
                break;
            case 60:
                {
                alt22=2;
                }
                break;
            case Identifier:
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case StringAtom:
            case 36:
            case 61:
            case 62:
                {
                alt22=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 22, 0, input);

                throw nvae;
            }

            switch (alt22) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:7: '++' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    string_literal83=(Token)match(input,59,FOLLOW_59_in_unaryExpression1049); 
                    string_literal83_tree = (Object)adaptor.create(string_literal83);
                    adaptor.addChild(root_0, string_literal83_tree);

                    pushFollow(FOLLOW_unaryExpression_in_unaryExpression1051);
                    unaryExpression84=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression84.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:249:9: '--' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    string_literal85=(Token)match(input,60,FOLLOW_60_in_unaryExpression1061); 
                    string_literal85_tree = (Object)adaptor.create(string_literal85);
                    adaptor.addChild(root_0, string_literal85_tree);

                    pushFollow(FOLLOW_unaryExpression_in_unaryExpression1063);
                    unaryExpression86=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression86.getTree());

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:250:9: unaryExpressionNotPlusMinus
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1073);
                    unaryExpressionNotPlusMinus87=unaryExpressionNotPlusMinus();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpressionNotPlusMinus87.getTree());

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
        return retval;
    }
    // $ANTLR end "unaryExpression"

    public static class unaryExpressionNotPlusMinus_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "unaryExpressionNotPlusMinus"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:254:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public final SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() throws RecognitionException {
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal88=null;
        Token set92=null;
        SGLParser.unaryExpression_return unaryExpression89 = null;

        SGLParser.castExpression_return castExpression90 = null;

        SGLParser.mathAtom_return mathAtom91 = null;


        Object char_literal88_tree=null;
        Object set92_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:255:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt24=3;
            switch ( input.LA(1) ) {
            case 61:
                {
                alt24=1;
                }
                break;
            case 36:
                {
                int LA24_2 = input.LA(2);

                if ( ((LA24_2>=IntType && LA24_2<=ObjectType)) ) {
                    alt24=2;
                }
                else if ( (LA24_2==Identifier||(LA24_2>=IntegerAtom && LA24_2<=BooleanAtom)||LA24_2==StringAtom||LA24_2==36||LA24_2==55||LA24_2==62) ) {
                    alt24=3;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 24, 2, input);

                    throw nvae;
                }
                }
                break;
            case Identifier:
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case StringAtom:
            case 62:
                {
                alt24=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 24, 0, input);

                throw nvae;
            }

            switch (alt24) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:255:9: '!' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    char_literal88=(Token)match(input,61,FOLLOW_61_in_unaryExpressionNotPlusMinus1094); 
                    char_literal88_tree = (Object)adaptor.create(char_literal88);
                    adaptor.addChild(root_0, char_literal88_tree);

                    pushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1096);
                    unaryExpression89=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression89.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:256:9: castExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus1106);
                    castExpression90=castExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, castExpression90.getTree());

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:258:9: mathAtom ( '++' | '--' )?
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus1121);
                    mathAtom91=mathAtom();

                    state._fsp--;

                    adaptor.addChild(root_0, mathAtom91.getTree());
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:258:18: ( '++' | '--' )?
                    int alt23=2;
                    int LA23_0 = input.LA(1);

                    if ( ((LA23_0>=59 && LA23_0<=60)) ) {
                        alt23=1;
                    }
                    switch (alt23) {
                        case 1 :
                            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
                            {
                            set92=(Token)input.LT(1);
                            if ( (input.LA(1)>=59 && input.LA(1)<=60) ) {
                                input.consume();
                                adaptor.addChild(root_0, (Object)adaptor.create(set92));
                                state.errorRecovery=false;
                            }
                            else {
                                MismatchedSetException mse = new MismatchedSetException(null,input);
                                throw mse;
                            }


                            }
                            break;

                    }


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
        return retval;
    }
    // $ANTLR end "unaryExpressionNotPlusMinus"

    public static class castExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "castExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:262:1: castExpression : '(' variableType ')' unaryExpression ;
    public final SGLParser.castExpression_return castExpression() throws RecognitionException {
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal93=null;
        Token char_literal95=null;
        SGLParser.variableType_return variableType94 = null;

        SGLParser.unaryExpression_return unaryExpression96 = null;


        Object char_literal93_tree=null;
        Object char_literal95_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:8: '(' variableType ')' unaryExpression
            {
            root_0 = (Object)adaptor.nil();

            char_literal93=(Token)match(input,36,FOLLOW_36_in_castExpression1154); 
            char_literal93_tree = (Object)adaptor.create(char_literal93);
            adaptor.addChild(root_0, char_literal93_tree);

            pushFollow(FOLLOW_variableType_in_castExpression1156);
            variableType94=variableType();

            state._fsp--;

            adaptor.addChild(root_0, variableType94.getTree());
            char_literal95=(Token)match(input,37,FOLLOW_37_in_castExpression1158); 
            char_literal95_tree = (Object)adaptor.create(char_literal95);
            adaptor.addChild(root_0, char_literal95_tree);

            pushFollow(FOLLOW_unaryExpression_in_castExpression1160);
            unaryExpression96=unaryExpression();

            state._fsp--;

            adaptor.addChild(root_0, unaryExpression96.getTree());

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
        return retval;
    }
    // $ANTLR end "castExpression"

    public static class negativeExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "negativeExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:1: negativeExpression : ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) );
    public final SGLParser.negativeExpression_return negativeExpression() throws RecognitionException {
        SGLParser.negativeExpression_return retval = new SGLParser.negativeExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal98=null;
        SGLParser.mathAtom_return mathAtom97 = null;

        SGLParser.mathAtom_return mathAtom99 = null;


        Object char_literal98_tree=null;
        RewriteRuleTokenStream stream_55=new RewriteRuleTokenStream(adaptor,"token 55");
        RewriteRuleSubtreeStream stream_mathAtom=new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:269:2: ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) )
            int alt25=2;
            int LA25_0 = input.LA(1);

            if ( (LA25_0==Identifier||(LA25_0>=IntegerAtom && LA25_0<=BooleanAtom)||LA25_0==StringAtom||LA25_0==36||LA25_0==62) ) {
                alt25=1;
            }
            else if ( (LA25_0==55) ) {
                alt25=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 25, 0, input);

                throw nvae;
            }
            switch (alt25) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:269:4: mathAtom
                    {
                    pushFollow(FOLLOW_mathAtom_in_negativeExpression1178);
                    mathAtom97=mathAtom();

                    state._fsp--;

                    stream_mathAtom.add(mathAtom97.getTree());


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
                    // 269:13: -> mathAtom
                    {
                        adaptor.addChild(root_0, stream_mathAtom.nextTree());

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:270:4: ( '-' ) mathAtom
                    {
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:270:4: ( '-' )
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:270:5: '-'
                    {
                    char_literal98=(Token)match(input,55,FOLLOW_55_in_negativeExpression1188);  
                    stream_55.add(char_literal98);


                    }

                    pushFollow(FOLLOW_mathAtom_in_negativeExpression1191);
                    mathAtom99=mathAtom();

                    state._fsp--;

                    stream_mathAtom.add(mathAtom99.getTree());


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
                    // 270:19: -> ^( NEGATE mathAtom )
                    {
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:270:22: ^( NEGATE mathAtom )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(NEGATE, "NEGATE"), root_1);

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
        return retval;
    }
    // $ANTLR end "negativeExpression"

    public static class mathAtom_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "mathAtom"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:273:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote );
    public final SGLParser.mathAtom_return mathAtom() throws RecognitionException {
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal100=null;
        Token char_literal102=null;
        Token IntegerAtom103=null;
        Token FloatAtom104=null;
        Token BooleanAtom105=null;
        Token string_literal106=null;
        Token SpriteAnimation107=null;
        Token Identifier109=null;
        Token Identifier110=null;
        SGLParser.conditionalExpression_return conditionalExpression101 = null;

        SGLParser.arguments_return arguments108 = null;

        SGLParser.arguments_return arguments111 = null;

        SGLParser.stringQuote_return stringQuote112 = null;


        Object char_literal100_tree=null;
        Object char_literal102_tree=null;
        Object IntegerAtom103_tree=null;
        Object FloatAtom104_tree=null;
        Object BooleanAtom105_tree=null;
        Object string_literal106_tree=null;
        Object SpriteAnimation107_tree=null;
        Object Identifier109_tree=null;
        Object Identifier110_tree=null;
        RewriteRuleTokenStream stream_SpriteAnimation=new RewriteRuleTokenStream(adaptor,"token SpriteAnimation");
        RewriteRuleTokenStream stream_62=new RewriteRuleTokenStream(adaptor,"token 62");
        RewriteRuleTokenStream stream_Identifier=new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments=new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:274:5: ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote )
            int alt26=8;
            alt26 = dfa26.predict(input);
            switch (alt26) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:274:7: '(' conditionalExpression ')'
                    {
                    root_0 = (Object)adaptor.nil();

                    char_literal100=(Token)match(input,36,FOLLOW_36_in_mathAtom1213); 
                    pushFollow(FOLLOW_conditionalExpression_in_mathAtom1216);
                    conditionalExpression101=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression101.getTree());
                    char_literal102=(Token)match(input,37,FOLLOW_37_in_mathAtom1218); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:275:9: IntegerAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    IntegerAtom103=(Token)match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom1229); 
                    IntegerAtom103_tree = (Object)adaptor.create(IntegerAtom103);
                    adaptor.addChild(root_0, IntegerAtom103_tree);


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:276:7: FloatAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    FloatAtom104=(Token)match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1237); 
                    FloatAtom104_tree = (Object)adaptor.create(FloatAtom104);
                    adaptor.addChild(root_0, FloatAtom104_tree);


                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:277:9: BooleanAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    BooleanAtom105=(Token)match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1247); 
                    BooleanAtom105_tree = (Object)adaptor.create(BooleanAtom105);
                    adaptor.addChild(root_0, BooleanAtom105_tree);


                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:279:9: 'new' SpriteAnimation arguments
                    {
                    string_literal106=(Token)match(input,62,FOLLOW_62_in_mathAtom1258);  
                    stream_62.add(string_literal106);

                    SpriteAnimation107=(Token)match(input,SpriteAnimation,FOLLOW_SpriteAnimation_in_mathAtom1260);  
                    stream_SpriteAnimation.add(SpriteAnimation107);

                    pushFollow(FOLLOW_arguments_in_mathAtom1262);
                    arguments108=arguments();

                    state._fsp--;

                    stream_arguments.add(arguments108.getTree());


                    // AST REWRITE
                    // elements: arguments, SpriteAnimation
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 279:41: -> ^( SpriteAnimation arguments )
                    {
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:279:44: ^( SpriteAnimation arguments )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        root_1 = (Object)adaptor.becomeRoot(stream_SpriteAnimation.nextNode(), root_1);

                        adaptor.addChild(root_1, stream_arguments.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:281:4: Identifier
                    {
                    Identifier109=(Token)match(input,Identifier,FOLLOW_Identifier_in_mathAtom1277);  
                    stream_Identifier.add(Identifier109);



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
                    // 281:15: -> Identifier
                    {
                        adaptor.addChild(root_0, stream_Identifier.nextNode());

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:282:4: Identifier arguments
                    {
                    Identifier110=(Token)match(input,Identifier,FOLLOW_Identifier_in_mathAtom1286);  
                    stream_Identifier.add(Identifier110);

                    pushFollow(FOLLOW_arguments_in_mathAtom1288);
                    arguments111=arguments();

                    state._fsp--;

                    stream_arguments.add(arguments111.getTree());


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
                    // 282:25: -> ^( LIBMETHOD Identifier ( arguments )? )
                    {
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:282:28: ^( LIBMETHOD Identifier ( arguments )? )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(LIBMETHOD, "LIBMETHOD"), root_1);

                        adaptor.addChild(root_1, stream_Identifier.nextNode());
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:282:51: ( arguments )?
                        if ( stream_arguments.hasNext() ) {
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:283:4: stringQuote
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_stringQuote_in_mathAtom1304);
                    stringQuote112=stringQuote();

                    state._fsp--;

                    adaptor.addChild(root_0, stringQuote112.getTree());

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
        return retval;
    }
    // $ANTLR end "mathAtom"

    public static class arguments_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "arguments"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:287:1: arguments : '(' ( expressionList )? ')' ;
    public final SGLParser.arguments_return arguments() throws RecognitionException {
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal113=null;
        Token char_literal115=null;
        SGLParser.expressionList_return expressionList114 = null;


        Object char_literal113_tree=null;
        Object char_literal115_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:288:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:288:9: '(' ( expressionList )? ')'
            {
            root_0 = (Object)adaptor.nil();

            char_literal113=(Token)match(input,36,FOLLOW_36_in_arguments1326); 
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:288:14: ( expressionList )?
            int alt27=2;
            int LA27_0 = input.LA(1);

            if ( (LA27_0==Identifier||(LA27_0>=IntegerAtom && LA27_0<=BooleanAtom)||LA27_0==StringAtom||LA27_0==36||LA27_0==55||LA27_0==62) ) {
                alt27=1;
            }
            switch (alt27) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:288:14: expressionList
                    {
                    pushFollow(FOLLOW_expressionList_in_arguments1329);
                    expressionList114=expressionList();

                    state._fsp--;

                    adaptor.addChild(root_0, expressionList114.getTree());

                    }
                    break;

            }

            char_literal115=(Token)match(input,37,FOLLOW_37_in_arguments1332); 

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
        return retval;
    }
    // $ANTLR end "arguments"

    public static class expressionList_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "expressionList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:291:1: expressionList : expression ( ',' expression )* ;
    public final SGLParser.expressionList_return expressionList() throws RecognitionException {
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal117=null;
        SGLParser.expression_return expression116 = null;

        SGLParser.expression_return expression118 = null;


        Object char_literal117_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:292:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:292:9: expression ( ',' expression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_expression_in_expressionList1356);
            expression116=expression();

            state._fsp--;

            adaptor.addChild(root_0, expression116.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:292:20: ( ',' expression )*
            loop28:
            do {
                int alt28=2;
                int LA28_0 = input.LA(1);

                if ( (LA28_0==39) ) {
                    alt28=1;
                }


                switch (alt28) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:292:21: ',' expression
            	    {
            	    char_literal117=(Token)match(input,39,FOLLOW_39_in_expressionList1359); 
            	    pushFollow(FOLLOW_expression_in_expressionList1362);
            	    expression118=expression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, expression118.getTree());

            	    }
            	    break;

            	default :
            	    break loop28;
                }
            } while (true);


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
        return retval;
    }
    // $ANTLR end "expressionList"

    public static class idList_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "idList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:295:1: idList : Identifier ( ',' Identifier )* -> ^( ID_LIST ( Identifier )+ ) ;
    public final SGLParser.idList_return idList() throws RecognitionException {
        SGLParser.idList_return retval = new SGLParser.idList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token Identifier119=null;
        Token char_literal120=null;
        Token Identifier121=null;

        Object Identifier119_tree=null;
        Object char_literal120_tree=null;
        Object Identifier121_tree=null;
        RewriteRuleTokenStream stream_Identifier=new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleTokenStream stream_39=new RewriteRuleTokenStream(adaptor,"token 39");

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:296:3: ( Identifier ( ',' Identifier )* -> ^( ID_LIST ( Identifier )+ ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:296:6: Identifier ( ',' Identifier )*
            {
            Identifier119=(Token)match(input,Identifier,FOLLOW_Identifier_in_idList1381);  
            stream_Identifier.add(Identifier119);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:296:17: ( ',' Identifier )*
            loop29:
            do {
                int alt29=2;
                int LA29_0 = input.LA(1);

                if ( (LA29_0==39) ) {
                    alt29=1;
                }


                switch (alt29) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:296:18: ',' Identifier
            	    {
            	    char_literal120=(Token)match(input,39,FOLLOW_39_in_idList1384);  
            	    stream_39.add(char_literal120);

            	    Identifier121=(Token)match(input,Identifier,FOLLOW_Identifier_in_idList1386);  
            	    stream_Identifier.add(Identifier121);


            	    }
            	    break;

            	default :
            	    break loop29;
                }
            } while (true);



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
            // 296:35: -> ^( ID_LIST ( Identifier )+ )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:296:38: ^( ID_LIST ( Identifier )+ )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(ID_LIST, "ID_LIST"), root_1);

                if ( !(stream_Identifier.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_Identifier.hasNext() ) {
                    adaptor.addChild(root_1, stream_Identifier.nextNode());

                }
                stream_Identifier.reset();

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
        return retval;
    }
    // $ANTLR end "idList"

    public static class literal_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "literal"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:299:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public final SGLParser.literal_return literal() throws RecognitionException {
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set122=null;

        Object set122_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:300:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            root_0 = (Object)adaptor.nil();

            set122=(Token)input.LT(1);
            if ( (input.LA(1)>=IntegerAtom && input.LA(1)<=BooleanAtom)||input.LA(1)==StringAtom||input.LA(1)==63 ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set122));
                state.errorRecovery=false;
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
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
        return retval;
    }
    // $ANTLR end "literal"

    public static class stringQuote_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "stringQuote"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:308:1: stringQuote : StringAtom -> StringAtom ;
    public final SGLParser.stringQuote_return stringQuote() throws RecognitionException {
        SGLParser.stringQuote_return retval = new SGLParser.stringQuote_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token StringAtom123=null;

        Object StringAtom123_tree=null;
        RewriteRuleTokenStream stream_StringAtom=new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:309:2: ( StringAtom -> StringAtom )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:309:8: StringAtom
            {
            StringAtom123=(Token)match(input,StringAtom,FOLLOW_StringAtom_in_stringQuote1492);  
            stream_StringAtom.add(StringAtom123);



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
            // 309:19: -> StringAtom
            {
                adaptor.addChild(root_0, stream_StringAtom.nextNode());

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
        return retval;
    }
    // $ANTLR end "stringQuote"

    // Delegated rules


    protected DFA26 dfa26 = new DFA26(this);
    static final String DFA26_eotS =
        "\12\uffff";
    static final String DFA26_eofS =
        "\12\uffff";
    static final String DFA26_minS =
        "\1\16\5\uffff\1\16\3\uffff";
    static final String DFA26_maxS =
        "\1\76\5\uffff\1\74\3\uffff";
    static final String DFA26_acceptS =
        "\1\uffff\1\1\1\2\1\3\1\4\1\5\1\uffff\1\10\1\6\1\7";
    static final String DFA26_specialS =
        "\12\uffff}>";
    static final String[] DFA26_transitionS = {
            "\1\6\5\uffff\1\2\1\3\1\4\1\uffff\1\7\13\uffff\1\1\31\uffff"+
            "\1\5",
            "",
            "",
            "",
            "",
            "",
            "\6\10\15\uffff\1\10\2\uffff\1\11\3\10\4\uffff\21\10",
            "",
            "",
            ""
    };

    static final short[] DFA26_eot = DFA.unpackEncodedString(DFA26_eotS);
    static final short[] DFA26_eof = DFA.unpackEncodedString(DFA26_eofS);
    static final char[] DFA26_min = DFA.unpackEncodedStringToUnsignedChars(DFA26_minS);
    static final char[] DFA26_max = DFA.unpackEncodedStringToUnsignedChars(DFA26_maxS);
    static final short[] DFA26_accept = DFA.unpackEncodedString(DFA26_acceptS);
    static final short[] DFA26_special = DFA.unpackEncodedString(DFA26_specialS);
    static final short[][] DFA26_transition;

    static {
        int numStates = DFA26_transitionS.length;
        DFA26_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA26_transition[i] = DFA.unpackEncodedString(DFA26_transitionS[i]);
        }
    }

    class DFA26 extends DFA {

        public DFA26(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 26;
            this.eot = DFA26_eot;
            this.eof = DFA26_eof;
            this.min = DFA26_min;
            this.max = DFA26_max;
            this.accept = DFA26_accept;
            this.special = DFA26_special;
            this.transition = DFA26_transition;
        }
        public String getDescription() {
            return "273:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote );";
        }
    }
 

    public static final BitSet FOLLOW_mainBlock_in_compilationUnit112 = new BitSet(new long[]{0x0000000000000000L});
    public static final BitSet FOLLOW_EOF_in_compilationUnit114 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mainStatement_in_mainBlock127 = new BitSet(new long[]{0x00000608000FC002L});
    public static final BitSet FOLLOW_methodDef_in_mainBlock131 = new BitSet(new long[]{0x00000608000FC002L});
    public static final BitSet FOLLOW_statement_in_block179 = new BitSet(new long[]{0x00000600000FC002L});
    public static final BitSet FOLLOW_semicolonStatement_in_singleBlock207 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_singleBlock_in_commonBlock233 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_33_in_commonBlock238 = new BitSet(new long[]{0x00000604000FC000L});
    public static final BitSet FOLLOW_block_in_commonBlock241 = new BitSet(new long[]{0x0000000400000000L});
    public static final BitSet FOLLOW_34_in_commonBlock243 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_35_in_methodDef277 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_Identifier_in_methodDef279 = new BitSet(new long[]{0x0000001000000000L});
    public static final BitSet FOLLOW_36_in_methodDef281 = new BitSet(new long[]{0x0000002000004000L});
    public static final BitSet FOLLOW_idList_in_methodDef283 = new BitSet(new long[]{0x0000002000000000L});
    public static final BitSet FOLLOW_37_in_methodDef286 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_statement_in_mainStatement315 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableDeclarationList_in_semicolonStatement328 = new BitSet(new long[]{0x0000004000000000L});
    public static final BitSet FOLLOW_variableAssignment_in_semicolonStatement334 = new BitSet(new long[]{0x0000004000000000L});
    public static final BitSet FOLLOW_38_in_semicolonStatement340 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_semicolonStatement_in_statement356 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ifStatement_in_statement361 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_whileLoop_in_statement366 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableType_in_variableDeclarationList382 = new BitSet(new long[]{0x00000000000FC000L});
    public static final BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList384 = new BitSet(new long[]{0x0000008000000002L});
    public static final BitSet FOLLOW_39_in_variableDeclarationList387 = new BitSet(new long[]{0x00000000000FC000L});
    public static final BitSet FOLLOW_variableDecAssignment_in_variableDeclarationList389 = new BitSet(new long[]{0x0000008000000002L});
    public static final BitSet FOLLOW_variableName_in_variableDecAssignment413 = new BitSet(new long[]{0x0000010000000002L});
    public static final BitSet FOLLOW_40_in_variableDecAssignment416 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_expression_in_variableDecAssignment418 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableName_in_variableAssignment439 = new BitSet(new long[]{0x0000010000000000L});
    public static final BitSet FOLLOW_40_in_variableAssignment441 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_expression_in_variableAssignment443 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_variableName474 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_variableType0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_41_in_whileLoop518 = new BitSet(new long[]{0x0000001000000000L});
    public static final BitSet FOLLOW_36_in_whileLoop520 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_expression_in_whileLoop522 = new BitSet(new long[]{0x0000002000000000L});
    public static final BitSet FOLLOW_37_in_whileLoop524 = new BitSet(new long[]{0x00000002000FC000L});
    public static final BitSet FOLLOW_commonBlock_in_whileLoop526 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_ifStat_in_ifStatement547 = new BitSet(new long[]{0x0000080000000002L});
    public static final BitSet FOLLOW_elseIfStat_in_ifStatement549 = new BitSet(new long[]{0x0000080000000002L});
    public static final BitSet FOLLOW_elseStat_in_ifStatement552 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_42_in_ifStat577 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_expression_in_ifStat579 = new BitSet(new long[]{0x00000002000FC000L});
    public static final BitSet FOLLOW_commonBlock_in_ifStat581 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_43_in_elseIfStat602 = new BitSet(new long[]{0x0000040000000000L});
    public static final BitSet FOLLOW_42_in_elseIfStat604 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_expression_in_elseIfStat606 = new BitSet(new long[]{0x00000002000FC000L});
    public static final BitSet FOLLOW_commonBlock_in_elseIfStat608 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_43_in_elseStat630 = new BitSet(new long[]{0x00000002000FC000L});
    public static final BitSet FOLLOW_commonBlock_in_elseStat632 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalExpression_in_expression695 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression736 = new BitSet(new long[]{0x0000100000000002L});
    public static final BitSet FOLLOW_44_in_conditionalExpression740 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_conditionalExpression_in_conditionalExpression743 = new BitSet(new long[]{0x0000200000000000L});
    public static final BitSet FOLLOW_45_in_conditionalExpression745 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_conditionalExpression_in_conditionalExpression748 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression791 = new BitSet(new long[]{0x0000400000000002L});
    public static final BitSet FOLLOW_46_in_conditionalOrExpression795 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression798 = new BitSet(new long[]{0x0000400000000002L});
    public static final BitSet FOLLOW_equalityExpression_in_conditionalAndExpression829 = new BitSet(new long[]{0x0000800000000002L});
    public static final BitSet FOLLOW_47_in_conditionalAndExpression833 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_equalityExpression_in_conditionalAndExpression836 = new BitSet(new long[]{0x0000800000000002L});
    public static final BitSet FOLLOW_relationalExpression_in_equalityExpression863 = new BitSet(new long[]{0x0003000000000002L});
    public static final BitSet FOLLOW_48_in_equalityExpression868 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_49_in_equalityExpression873 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_relationalExpression_in_equalityExpression877 = new BitSet(new long[]{0x0003000000000002L});
    public static final BitSet FOLLOW_additiveExpression_in_relationalExpression908 = new BitSet(new long[]{0x003C000000000002L});
    public static final BitSet FOLLOW_50_in_relationalExpression912 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_51_in_relationalExpression915 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_52_in_relationalExpression918 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_53_in_relationalExpression921 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_additiveExpression_in_relationalExpression925 = new BitSet(new long[]{0x003C000000000002L});
    public static final BitSet FOLLOW_multiplicativeExpression_in_additiveExpression963 = new BitSet(new long[]{0x00C0000000000002L});
    public static final BitSet FOLLOW_54_in_additiveExpression967 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_55_in_additiveExpression970 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_multiplicativeExpression_in_additiveExpression974 = new BitSet(new long[]{0x00C0000000000002L});
    public static final BitSet FOLLOW_negativeExpression_in_multiplicativeExpression1008 = new BitSet(new long[]{0x0700000000000002L});
    public static final BitSet FOLLOW_56_in_multiplicativeExpression1016 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_57_in_multiplicativeExpression1019 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_58_in_multiplicativeExpression1022 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_negativeExpression_in_multiplicativeExpression1026 = new BitSet(new long[]{0x0700000000000002L});
    public static final BitSet FOLLOW_59_in_unaryExpression1049 = new BitSet(new long[]{0x7800001001704000L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpression1051 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_60_in_unaryExpression1061 = new BitSet(new long[]{0x7800001001704000L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpression1063 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression1073 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_61_in_unaryExpressionNotPlusMinus1094 = new BitSet(new long[]{0x7800001001704000L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus1096 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus1106 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus1121 = new BitSet(new long[]{0x1800000000000002L});
    public static final BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus1123 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_36_in_castExpression1154 = new BitSet(new long[]{0x00000000000F8000L});
    public static final BitSet FOLLOW_variableType_in_castExpression1156 = new BitSet(new long[]{0x0000002000000000L});
    public static final BitSet FOLLOW_37_in_castExpression1158 = new BitSet(new long[]{0x7800001001704000L});
    public static final BitSet FOLLOW_unaryExpression_in_castExpression1160 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mathAtom_in_negativeExpression1178 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_55_in_negativeExpression1188 = new BitSet(new long[]{0x4000001001704000L});
    public static final BitSet FOLLOW_mathAtom_in_negativeExpression1191 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_36_in_mathAtom1213 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_conditionalExpression_in_mathAtom1216 = new BitSet(new long[]{0x0000002000000000L});
    public static final BitSet FOLLOW_37_in_mathAtom1218 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_IntegerAtom_in_mathAtom1229 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FloatAtom_in_mathAtom1237 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BooleanAtom_in_mathAtom1247 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_62_in_mathAtom1258 = new BitSet(new long[]{0x0000000000800000L});
    public static final BitSet FOLLOW_SpriteAnimation_in_mathAtom1260 = new BitSet(new long[]{0x0000001000000000L});
    public static final BitSet FOLLOW_arguments_in_mathAtom1262 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_mathAtom1277 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_mathAtom1286 = new BitSet(new long[]{0x0000001000000000L});
    public static final BitSet FOLLOW_arguments_in_mathAtom1288 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_stringQuote_in_mathAtom1304 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_36_in_arguments1326 = new BitSet(new long[]{0x4080003001704000L});
    public static final BitSet FOLLOW_expressionList_in_arguments1329 = new BitSet(new long[]{0x0000002000000000L});
    public static final BitSet FOLLOW_37_in_arguments1332 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_expression_in_expressionList1356 = new BitSet(new long[]{0x0000008000000002L});
    public static final BitSet FOLLOW_39_in_expressionList1359 = new BitSet(new long[]{0x4080001001704000L});
    public static final BitSet FOLLOW_expression_in_expressionList1362 = new BitSet(new long[]{0x0000008000000002L});
    public static final BitSet FOLLOW_Identifier_in_idList1381 = new BitSet(new long[]{0x0000008000000002L});
    public static final BitSet FOLLOW_39_in_idList1384 = new BitSet(new long[]{0x0000000000004000L});
    public static final BitSet FOLLOW_Identifier_in_idList1386 = new BitSet(new long[]{0x0000008000000002L});
    public static final BitSet FOLLOW_set_in_literal0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_StringAtom_in_stringQuote1492 = new BitSet(new long[]{0x0000000000000002L});

}