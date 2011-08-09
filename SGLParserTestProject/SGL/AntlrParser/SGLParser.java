// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g 2011-08-09 22:45:37

	//using SGLParserTester;


import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;


import org.antlr.runtime.tree.*;

public class SGLParser extends Parser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BLOCK", "STATEMENTS", "ID_LIST", "VARDEF", "ASSIGN", "NEGATE", "LIBMETHOD", "STRING", "Identifier", "IntType", "BooleanType", "StringType", "FloatType", "ObjectType", "IntegerAtom", "FloatAtom", "BooleanAtom", "SpriteAnimation", "StringAtom", "EscapeSequence", "Letter", "SGLIDDigit", "UnicodeEscape", "OctalEscape", "HEX_DIGIT", "WS", "COMMENT", "'{'", "'}'", "'method'", "'('", "')'", "','", "'='", "'while'", "'?'", "':'", "'||'", "'&&'", "'=='", "'!='", "'<'", "'>'", "'<='", "'>='", "'+'", "'-'", "'*'", "'/'", "'%'", "'++'", "'--'", "'!'", "'new'", "'null'"
    };
    public static final int SGLIDDigit=25;
    public static final int IntType=13;
    public static final int ID_LIST=6;
    public static final int EOF=-1;
    public static final int Identifier=12;
    public static final int T__55=55;
    public static final int T__56=56;
    public static final int T__57=57;
    public static final int T__58=58;
    public static final int T__51=51;
    public static final int T__52=52;
    public static final int T__53=53;
    public static final int T__54=54;
    public static final int StringType=15;
    public static final int SpriteAnimation=21;
    public static final int COMMENT=30;
    public static final int VARDEF=7;
    public static final int T__50=50;
    public static final int BooleanType=14;
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
    public static final int LIBMETHOD=10;
    public static final int IntegerAtom=18;
    public static final int FloatType=16;
    public static final int StringAtom=22;
    public static final int HEX_DIGIT=28;
    public static final int NEGATE=9;
    public static final int BooleanAtom=20;
    public static final int T__31=31;
    public static final int T__32=32;
    public static final int WS=29;
    public static final int T__33=33;
    public static final int T__34=34;
    public static final int T__35=35;
    public static final int T__36=36;
    public static final int T__37=37;
    public static final int T__38=38;
    public static final int T__39=39;
    public static final int UnicodeEscape=26;
    public static final int BLOCK=4;
    public static final int ASSIGN=8;
    public static final int STATEMENTS=5;
    public static final int ObjectType=17;
    public static final int FloatAtom=19;
    public static final int OctalEscape=27;
    public static final int Letter=24;
    public static final int EscapeSequence=23;
    public static final int STRING=11;

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:75:1: compilationUnit : mainBlock EOF ;
    public final SGLParser.compilationUnit_return compilationUnit() throws RecognitionException {
        SGLParser.compilationUnit_return retval = new SGLParser.compilationUnit_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token EOF2=null;
        SGLParser.mainBlock_return mainBlock1 = null;


        Object EOF2_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:76:2: ( mainBlock EOF )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:76:4: mainBlock EOF
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_mainBlock_in_compilationUnit104);
            mainBlock1=mainBlock();

            state._fsp--;

            adaptor.addChild(root_0, mainBlock1.getTree());
            EOF2=(Token)match(input,EOF,FOLLOW_EOF_in_compilationUnit106); 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:79:1: mainBlock : ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) ;
    public final SGLParser.mainBlock_return mainBlock() throws RecognitionException {
        SGLParser.mainBlock_return retval = new SGLParser.mainBlock_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.mainStatement_return mainStatement3 = null;

        SGLParser.methodDef_return methodDef4 = null;


        RewriteRuleSubtreeStream stream_methodDef=new RewriteRuleSubtreeStream(adaptor,"rule methodDef");
        RewriteRuleSubtreeStream stream_mainStatement=new RewriteRuleSubtreeStream(adaptor,"rule mainStatement");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:80:2: ( ( mainStatement | methodDef )* -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:80:4: ( mainStatement | methodDef )*
            {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:80:4: ( mainStatement | methodDef )*
            loop1:
            do {
                int alt1=3;
                int LA1_0 = input.LA(1);

                if ( ((LA1_0>=Identifier && LA1_0<=ObjectType)||LA1_0==38) ) {
                    alt1=1;
                }
                else if ( (LA1_0==33) ) {
                    alt1=2;
                }


                switch (alt1) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:80:5: mainStatement
            	    {
            	    pushFollow(FOLLOW_mainStatement_in_mainBlock119);
            	    mainStatement3=mainStatement();

            	    state._fsp--;

            	    stream_mainStatement.add(mainStatement3.getTree());

            	    }
            	    break;
            	case 2 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:80:21: methodDef
            	    {
            	    pushFollow(FOLLOW_methodDef_in_mainBlock123);
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
            // 81:8: -> ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:81:11: ^( BLOCK ^( STATEMENTS ( mainStatement )* ) )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(BLOCK, "BLOCK"), root_1);

                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:81:19: ^( STATEMENTS ( mainStatement )* )
                {
                Object root_2 = (Object)adaptor.nil();
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(STATEMENTS, "STATEMENTS"), root_2);

                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:81:32: ( mainStatement )*
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:84:1: block : ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
    public final SGLParser.block_return block() throws RecognitionException {
        SGLParser.block_return retval = new SGLParser.block_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.statement_return statement5 = null;


        RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:2: ( ( statement )* -> ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:4: ( statement )*
            {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:4: ( statement )*
            loop2:
            do {
                int alt2=2;
                int LA2_0 = input.LA(1);

                if ( ((LA2_0>=Identifier && LA2_0<=ObjectType)||LA2_0==38) ) {
                    alt2=1;
                }


                switch (alt2) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:85:4: statement
            	    {
            	    pushFollow(FOLLOW_statement_in_block171);
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
            // 86:3: -> ^( BLOCK ^( STATEMENTS ( statement )* ) )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:86:6: ^( BLOCK ^( STATEMENTS ( statement )* ) )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(BLOCK, "BLOCK"), root_1);

                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:86:14: ^( STATEMENTS ( statement )* )
                {
                Object root_2 = (Object)adaptor.nil();
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(STATEMENTS, "STATEMENTS"), root_2);

                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:86:27: ( statement )*
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:89:1: singleBlock : statement -> ^( BLOCK ^( STATEMENTS statement ) ) ;
    public final SGLParser.singleBlock_return singleBlock() throws RecognitionException {
        SGLParser.singleBlock_return retval = new SGLParser.singleBlock_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.statement_return statement6 = null;


        RewriteRuleSubtreeStream stream_statement=new RewriteRuleSubtreeStream(adaptor,"rule statement");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:90:2: ( statement -> ^( BLOCK ^( STATEMENTS statement ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:90:4: statement
            {
            pushFollow(FOLLOW_statement_in_singleBlock199);
            statement6=statement();

            state._fsp--;

            stream_statement.add(statement6.getTree());


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
            // 91:3: -> ^( BLOCK ^( STATEMENTS statement ) )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:91:6: ^( BLOCK ^( STATEMENTS statement ) )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(BLOCK, "BLOCK"), root_1);

                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:91:14: ^( STATEMENTS statement )
                {
                Object root_2 = (Object)adaptor.nil();
                root_2 = (Object)adaptor.becomeRoot((Object)adaptor.create(STATEMENTS, "STATEMENTS"), root_2);

                adaptor.addChild(root_2, stream_statement.nextTree());

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:94:1: commonBlock : ( singleBlock | '{' block '}' );
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:95:2: ( singleBlock | '{' block '}' )
            int alt3=2;
            int LA3_0 = input.LA(1);

            if ( ((LA3_0>=Identifier && LA3_0<=ObjectType)||LA3_0==38) ) {
                alt3=1;
            }
            else if ( (LA3_0==31) ) {
                alt3=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 3, 0, input);

                throw nvae;
            }
            switch (alt3) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:95:4: singleBlock
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_singleBlock_in_commonBlock225);
                    singleBlock7=singleBlock();

                    state._fsp--;

                    adaptor.addChild(root_0, singleBlock7.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:96:4: '{' block '}'
                    {
                    root_0 = (Object)adaptor.nil();

                    char_literal8=(Token)match(input,31,FOLLOW_31_in_commonBlock230); 
                    char_literal8_tree = (Object)adaptor.create(char_literal8);
                    adaptor.addChild(root_0, char_literal8_tree);

                    pushFollow(FOLLOW_block_in_commonBlock232);
                    block9=block();

                    state._fsp--;

                    adaptor.addChild(root_0, block9.getTree());
                    char_literal10=(Token)match(input,32,FOLLOW_32_in_commonBlock234); 
                    char_literal10_tree = (Object)adaptor.create(char_literal10);
                    adaptor.addChild(root_0, char_literal10_tree);


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:100:1: methodDef : 'method' Identifier '(' ( idList )? ')' ;
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:101:3: ( 'method' Identifier '(' ( idList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:101:5: 'method' Identifier '(' ( idList )? ')'
            {
            root_0 = (Object)adaptor.nil();

            string_literal11=(Token)match(input,33,FOLLOW_33_in_methodDef267); 
            string_literal11_tree = (Object)adaptor.create(string_literal11);
            adaptor.addChild(root_0, string_literal11_tree);

            Identifier12=(Token)match(input,Identifier,FOLLOW_Identifier_in_methodDef269); 
            Identifier12_tree = (Object)adaptor.create(Identifier12);
            adaptor.addChild(root_0, Identifier12_tree);

            char_literal13=(Token)match(input,34,FOLLOW_34_in_methodDef271); 
            char_literal13_tree = (Object)adaptor.create(char_literal13);
            adaptor.addChild(root_0, char_literal13_tree);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:101:29: ( idList )?
            int alt4=2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0==Identifier) ) {
                alt4=1;
            }
            switch (alt4) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:101:29: idList
                    {
                    pushFollow(FOLLOW_idList_in_methodDef273);
                    idList14=idList();

                    state._fsp--;

                    adaptor.addChild(root_0, idList14.getTree());

                    }
                    break;

            }

            char_literal15=(Token)match(input,35,FOLLOW_35_in_methodDef276); 
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:105:1: mainStatement : statement ;
    public final SGLParser.mainStatement_return mainStatement() throws RecognitionException {
        SGLParser.mainStatement_return retval = new SGLParser.mainStatement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.statement_return statement16 = null;



        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:106:2: ( statement )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:106:4: statement
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_statement_in_mainStatement305);
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

    public static class statement_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "statement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:110:1: statement : ( variableDeclarationList | variableAssignment -> ^( ASSIGN variableAssignment ) | whileLoop );
    public final SGLParser.statement_return statement() throws RecognitionException {
        SGLParser.statement_return retval = new SGLParser.statement_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.variableDeclarationList_return variableDeclarationList17 = null;

        SGLParser.variableAssignment_return variableAssignment18 = null;

        SGLParser.whileLoop_return whileLoop19 = null;


        RewriteRuleSubtreeStream stream_variableAssignment=new RewriteRuleSubtreeStream(adaptor,"rule variableAssignment");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:112:2: ( variableDeclarationList | variableAssignment -> ^( ASSIGN variableAssignment ) | whileLoop )
            int alt5=3;
            switch ( input.LA(1) ) {
            case IntType:
            case BooleanType:
            case StringType:
            case FloatType:
            case ObjectType:
                {
                alt5=1;
                }
                break;
            case Identifier:
                {
                alt5=2;
                }
                break;
            case 38:
                {
                alt5=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 5, 0, input);

                throw nvae;
            }

            switch (alt5) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:112:4: variableDeclarationList
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_variableDeclarationList_in_statement320);
                    variableDeclarationList17=variableDeclarationList();

                    state._fsp--;

                    adaptor.addChild(root_0, variableDeclarationList17.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:113:4: variableAssignment
                    {
                    pushFollow(FOLLOW_variableAssignment_in_statement326);
                    variableAssignment18=variableAssignment();

                    state._fsp--;

                    stream_variableAssignment.add(variableAssignment18.getTree());


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
                    // 113:23: -> ^( ASSIGN variableAssignment )
                    {
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:113:26: ^( ASSIGN variableAssignment )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(ASSIGN, "ASSIGN"), root_1);

                        adaptor.addChild(root_1, stream_variableAssignment.nextTree());

                        adaptor.addChild(root_0, root_1);
                        }

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:114:4: whileLoop
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_whileLoop_in_statement339);
                    whileLoop19=whileLoop();

                    state._fsp--;

                    adaptor.addChild(root_0, whileLoop19.getTree());

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:121:1: variableDeclarationList : variableType variableAssignment ( ',' variableAssignment )* -> ( ^( VARDEF variableType variableAssignment ) )+ ;
    public final SGLParser.variableDeclarationList_return variableDeclarationList() throws RecognitionException {
        SGLParser.variableDeclarationList_return retval = new SGLParser.variableDeclarationList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal22=null;
        SGLParser.variableType_return variableType20 = null;

        SGLParser.variableAssignment_return variableAssignment21 = null;

        SGLParser.variableAssignment_return variableAssignment23 = null;


        Object char_literal22_tree=null;
        RewriteRuleTokenStream stream_36=new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleSubtreeStream stream_variableType=new RewriteRuleSubtreeStream(adaptor,"rule variableType");
        RewriteRuleSubtreeStream stream_variableAssignment=new RewriteRuleSubtreeStream(adaptor,"rule variableAssignment");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:2: ( variableType variableAssignment ( ',' variableAssignment )* -> ( ^( VARDEF variableType variableAssignment ) )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:4: variableType variableAssignment ( ',' variableAssignment )*
            {
            pushFollow(FOLLOW_variableType_in_variableDeclarationList355);
            variableType20=variableType();

            state._fsp--;

            stream_variableType.add(variableType20.getTree());
            pushFollow(FOLLOW_variableAssignment_in_variableDeclarationList357);
            variableAssignment21=variableAssignment();

            state._fsp--;

            stream_variableAssignment.add(variableAssignment21.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:36: ( ',' variableAssignment )*
            loop6:
            do {
                int alt6=2;
                int LA6_0 = input.LA(1);

                if ( (LA6_0==36) ) {
                    alt6=1;
                }


                switch (alt6) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:37: ',' variableAssignment
            	    {
            	    char_literal22=(Token)match(input,36,FOLLOW_36_in_variableDeclarationList360);  
            	    stream_36.add(char_literal22);

            	    pushFollow(FOLLOW_variableAssignment_in_variableDeclarationList362);
            	    variableAssignment23=variableAssignment();

            	    state._fsp--;

            	    stream_variableAssignment.add(variableAssignment23.getTree());

            	    }
            	    break;

            	default :
            	    break loop6;
                }
            } while (true);



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
            // 122:62: -> ( ^( VARDEF variableType variableAssignment ) )+
            {
                if ( !(stream_variableAssignment.hasNext()||stream_variableType.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_variableAssignment.hasNext()||stream_variableType.hasNext() ) {
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:122:65: ^( VARDEF variableType variableAssignment )
                    {
                    Object root_1 = (Object)adaptor.nil();
                    root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(VARDEF, "VARDEF"), root_1);

                    adaptor.addChild(root_1, stream_variableType.nextTree());
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
        return retval;
    }
    // $ANTLR end "variableDeclarationList"

    public static class variableAssignment_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableAssignment"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:125:1: variableAssignment : variableName ( '=' expression )? -> variableName ( expression )? ;
    public final SGLParser.variableAssignment_return variableAssignment() throws RecognitionException {
        SGLParser.variableAssignment_return retval = new SGLParser.variableAssignment_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal25=null;
        SGLParser.variableName_return variableName24 = null;

        SGLParser.expression_return expression26 = null;


        Object char_literal25_tree=null;
        RewriteRuleTokenStream stream_37=new RewriteRuleTokenStream(adaptor,"token 37");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_variableName=new RewriteRuleSubtreeStream(adaptor,"rule variableName");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:126:2: ( variableName ( '=' expression )? -> variableName ( expression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:126:4: variableName ( '=' expression )?
            {
            pushFollow(FOLLOW_variableName_in_variableAssignment386);
            variableName24=variableName();

            state._fsp--;

            stream_variableName.add(variableName24.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:126:17: ( '=' expression )?
            int alt7=2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0==37) ) {
                alt7=1;
            }
            switch (alt7) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:126:18: '=' expression
                    {
                    char_literal25=(Token)match(input,37,FOLLOW_37_in_variableAssignment389);  
                    stream_37.add(char_literal25);

                    pushFollow(FOLLOW_expression_in_variableAssignment391);
                    expression26=expression();

                    state._fsp--;

                    stream_expression.add(expression26.getTree());

                    }
                    break;

            }



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
            // 126:36: -> variableName ( expression )?
            {
                adaptor.addChild(root_0, stream_variableName.nextTree());
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:126:52: ( expression )?
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
    // $ANTLR end "variableAssignment"

    public static class variableName_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "variableName"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:132:1: variableName : Identifier ;
    public final SGLParser.variableName_return variableName() throws RecognitionException {
        SGLParser.variableName_return retval = new SGLParser.variableName_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token Identifier27=null;

        Object Identifier27_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:133:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:133:4: Identifier
            {
            root_0 = (Object)adaptor.nil();

            Identifier27=(Token)match(input,Identifier,FOLLOW_Identifier_in_variableName419); 
            Identifier27_tree = (Object)adaptor.create(Identifier27);
            adaptor.addChild(root_0, Identifier27_tree);


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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:136:1: variableType : ( IntType | BooleanType | StringType | FloatType | ObjectType );
    public final SGLParser.variableType_return variableType() throws RecognitionException {
        SGLParser.variableType_return retval = new SGLParser.variableType_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set28=null;

        Object set28_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:137:2: ( IntType | BooleanType | StringType | FloatType | ObjectType )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            root_0 = (Object)adaptor.nil();

            set28=(Token)input.LT(1);
            if ( (input.LA(1)>=IntType && input.LA(1)<=ObjectType) ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set28));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:145:1: whileLoop : 'while' '(' expression ')' commonBlock -> ^( 'while' expression commonBlock ) ;
    public final SGLParser.whileLoop_return whileLoop() throws RecognitionException {
        SGLParser.whileLoop_return retval = new SGLParser.whileLoop_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal29=null;
        Token char_literal30=null;
        Token char_literal32=null;
        SGLParser.expression_return expression31 = null;

        SGLParser.commonBlock_return commonBlock33 = null;


        Object string_literal29_tree=null;
        Object char_literal30_tree=null;
        Object char_literal32_tree=null;
        RewriteRuleTokenStream stream_35=new RewriteRuleTokenStream(adaptor,"token 35");
        RewriteRuleTokenStream stream_34=new RewriteRuleTokenStream(adaptor,"token 34");
        RewriteRuleTokenStream stream_38=new RewriteRuleTokenStream(adaptor,"token 38");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        RewriteRuleSubtreeStream stream_commonBlock=new RewriteRuleSubtreeStream(adaptor,"rule commonBlock");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:146:2: ( 'while' '(' expression ')' commonBlock -> ^( 'while' expression commonBlock ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:146:4: 'while' '(' expression ')' commonBlock
            {
            string_literal29=(Token)match(input,38,FOLLOW_38_in_whileLoop463);  
            stream_38.add(string_literal29);

            char_literal30=(Token)match(input,34,FOLLOW_34_in_whileLoop465);  
            stream_34.add(char_literal30);

            pushFollow(FOLLOW_expression_in_whileLoop467);
            expression31=expression();

            state._fsp--;

            stream_expression.add(expression31.getTree());
            char_literal32=(Token)match(input,35,FOLLOW_35_in_whileLoop469);  
            stream_35.add(char_literal32);

            pushFollow(FOLLOW_commonBlock_in_whileLoop471);
            commonBlock33=commonBlock();

            state._fsp--;

            stream_commonBlock.add(commonBlock33.getTree());


            // AST REWRITE
            // elements: 38, commonBlock, expression
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 146:43: -> ^( 'while' expression commonBlock )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:146:46: ^( 'while' expression commonBlock )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot(stream_38.nextNode(), root_1);

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

    public static class expression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "expression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:173:1: expression : conditionalExpression ;
    public final SGLParser.expression_return expression() throws RecognitionException {
        SGLParser.expression_return retval = new SGLParser.expression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        SGLParser.conditionalExpression_return conditionalExpression34 = null;



        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:5: ( conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:174:8: conditionalExpression
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_conditionalExpression_in_expression533);
            conditionalExpression34=conditionalExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalExpression34.getTree());

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:183:1: conditionalExpression : conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? ;
    public final SGLParser.conditionalExpression_return conditionalExpression() throws RecognitionException {
        SGLParser.conditionalExpression_return retval = new SGLParser.conditionalExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal36=null;
        Token char_literal38=null;
        SGLParser.conditionalOrExpression_return conditionalOrExpression35 = null;

        SGLParser.conditionalExpression_return conditionalExpression37 = null;

        SGLParser.conditionalExpression_return conditionalExpression39 = null;


        Object char_literal36_tree=null;
        Object char_literal38_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:184:5: ( conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )? )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:184:9: conditionalOrExpression ( '?' conditionalExpression ':' conditionalExpression )?
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression574);
            conditionalOrExpression35=conditionalOrExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalOrExpression35.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:184:33: ( '?' conditionalExpression ':' conditionalExpression )?
            int alt8=2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0==39) ) {
                alt8=1;
            }
            switch (alt8) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:184:35: '?' conditionalExpression ':' conditionalExpression
                    {
                    char_literal36=(Token)match(input,39,FOLLOW_39_in_conditionalExpression578); 
                    char_literal36_tree = (Object)adaptor.create(char_literal36);
                    root_0 = (Object)adaptor.becomeRoot(char_literal36_tree, root_0);

                    pushFollow(FOLLOW_conditionalExpression_in_conditionalExpression581);
                    conditionalExpression37=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression37.getTree());
                    char_literal38=(Token)match(input,40,FOLLOW_40_in_conditionalExpression583); 
                    pushFollow(FOLLOW_conditionalExpression_in_conditionalExpression586);
                    conditionalExpression39=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression39.getTree());

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:189:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public final SGLParser.conditionalOrExpression_return conditionalOrExpression() throws RecognitionException {
        SGLParser.conditionalOrExpression_return retval = new SGLParser.conditionalOrExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal41=null;
        SGLParser.conditionalAndExpression_return conditionalAndExpression40 = null;

        SGLParser.conditionalAndExpression_return conditionalAndExpression42 = null;


        Object string_literal41_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression629);
            conditionalAndExpression40=conditionalAndExpression();

            state._fsp--;

            adaptor.addChild(root_0, conditionalAndExpression40.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:34: ( '||' conditionalAndExpression )*
            loop9:
            do {
                int alt9=2;
                int LA9_0 = input.LA(1);

                if ( (LA9_0==41) ) {
                    alt9=1;
                }


                switch (alt9) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:190:36: '||' conditionalAndExpression
            	    {
            	    string_literal41=(Token)match(input,41,FOLLOW_41_in_conditionalOrExpression633); 
            	    string_literal41_tree = (Object)adaptor.create(string_literal41);
            	    root_0 = (Object)adaptor.becomeRoot(string_literal41_tree, root_0);

            	    pushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression636);
            	    conditionalAndExpression42=conditionalAndExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, conditionalAndExpression42.getTree());

            	    }
            	    break;

            	default :
            	    break loop9;
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:194:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public final SGLParser.conditionalAndExpression_return conditionalAndExpression() throws RecognitionException {
        SGLParser.conditionalAndExpression_return retval = new SGLParser.conditionalAndExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal44=null;
        SGLParser.equalityExpression_return equalityExpression43 = null;

        SGLParser.equalityExpression_return equalityExpression45 = null;


        Object string_literal44_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:195:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:195:9: equalityExpression ( '&&' equalityExpression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression667);
            equalityExpression43=equalityExpression();

            state._fsp--;

            adaptor.addChild(root_0, equalityExpression43.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:195:28: ( '&&' equalityExpression )*
            loop10:
            do {
                int alt10=2;
                int LA10_0 = input.LA(1);

                if ( (LA10_0==42) ) {
                    alt10=1;
                }


                switch (alt10) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:195:30: '&&' equalityExpression
            	    {
            	    string_literal44=(Token)match(input,42,FOLLOW_42_in_conditionalAndExpression671); 
            	    string_literal44_tree = (Object)adaptor.create(string_literal44);
            	    root_0 = (Object)adaptor.becomeRoot(string_literal44_tree, root_0);

            	    pushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression674);
            	    equalityExpression45=equalityExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, equalityExpression45.getTree());

            	    }
            	    break;

            	default :
            	    break loop10;
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:199:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public final SGLParser.equalityExpression_return equalityExpression() throws RecognitionException {
        SGLParser.equalityExpression_return retval = new SGLParser.equalityExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal47=null;
        Token string_literal48=null;
        SGLParser.relationalExpression_return relationalExpression46 = null;

        SGLParser.relationalExpression_return relationalExpression49 = null;


        Object string_literal47_tree=null;
        Object string_literal48_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_relationalExpression_in_equalityExpression701);
            relationalExpression46=relationalExpression();

            state._fsp--;

            adaptor.addChild(root_0, relationalExpression46.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:30: ( ( '==' | '!=' ) relationalExpression )*
            loop12:
            do {
                int alt12=2;
                int LA12_0 = input.LA(1);

                if ( ((LA12_0>=43 && LA12_0<=44)) ) {
                    alt12=1;
                }


                switch (alt12) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:32: ( '==' | '!=' ) relationalExpression
            	    {
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:32: ( '==' | '!=' )
            	    int alt11=2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0==43) ) {
            	        alt11=1;
            	    }
            	    else if ( (LA11_0==44) ) {
            	        alt11=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 11, 0, input);

            	        throw nvae;
            	    }
            	    switch (alt11) {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:33: '=='
            	            {
            	            string_literal47=(Token)match(input,43,FOLLOW_43_in_equalityExpression706); 
            	            string_literal47_tree = (Object)adaptor.create(string_literal47);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal47_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:200:41: '!='
            	            {
            	            string_literal48=(Token)match(input,44,FOLLOW_44_in_equalityExpression711); 
            	            string_literal48_tree = (Object)adaptor.create(string_literal48);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal48_tree, root_0);


            	            }
            	            break;

            	    }

            	    pushFollow(FOLLOW_relationalExpression_in_equalityExpression715);
            	    relationalExpression49=relationalExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, relationalExpression49.getTree());

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
    // $ANTLR end "equalityExpression"

    public static class relationalExpression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };

    // $ANTLR start "relationalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:204:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public final SGLParser.relationalExpression_return relationalExpression() throws RecognitionException {
        SGLParser.relationalExpression_return retval = new SGLParser.relationalExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal51=null;
        Token char_literal52=null;
        Token string_literal53=null;
        Token string_literal54=null;
        SGLParser.additiveExpression_return additiveExpression50 = null;

        SGLParser.additiveExpression_return additiveExpression55 = null;


        Object char_literal51_tree=null;
        Object char_literal52_tree=null;
        Object string_literal53_tree=null;
        Object string_literal54_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_additiveExpression_in_relationalExpression746);
            additiveExpression50=additiveExpression();

            state._fsp--;

            adaptor.addChild(root_0, additiveExpression50.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            loop14:
            do {
                int alt14=2;
                int LA14_0 = input.LA(1);

                if ( ((LA14_0>=45 && LA14_0<=48)) ) {
                    alt14=1;
                }


                switch (alt14) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:29: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            	    {
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:29: ( '<' | '>' | '<=' | '>=' )
            	    int alt13=4;
            	    switch ( input.LA(1) ) {
            	    case 45:
            	        {
            	        alt13=1;
            	        }
            	        break;
            	    case 46:
            	        {
            	        alt13=2;
            	        }
            	        break;
            	    case 47:
            	        {
            	        alt13=3;
            	        }
            	        break;
            	    case 48:
            	        {
            	        alt13=4;
            	        }
            	        break;
            	    default:
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 13, 0, input);

            	        throw nvae;
            	    }

            	    switch (alt13) {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:30: '<'
            	            {
            	            char_literal51=(Token)match(input,45,FOLLOW_45_in_relationalExpression750); 
            	            char_literal51_tree = (Object)adaptor.create(char_literal51);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal51_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:35: '>'
            	            {
            	            char_literal52=(Token)match(input,46,FOLLOW_46_in_relationalExpression753); 
            	            char_literal52_tree = (Object)adaptor.create(char_literal52);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal52_tree, root_0);


            	            }
            	            break;
            	        case 3 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:40: '<='
            	            {
            	            string_literal53=(Token)match(input,47,FOLLOW_47_in_relationalExpression756); 
            	            string_literal53_tree = (Object)adaptor.create(string_literal53);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal53_tree, root_0);


            	            }
            	            break;
            	        case 4 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:205:46: '>='
            	            {
            	            string_literal54=(Token)match(input,48,FOLLOW_48_in_relationalExpression759); 
            	            string_literal54_tree = (Object)adaptor.create(string_literal54);
            	            root_0 = (Object)adaptor.becomeRoot(string_literal54_tree, root_0);


            	            }
            	            break;

            	    }

            	    pushFollow(FOLLOW_additiveExpression_in_relationalExpression763);
            	    additiveExpression55=additiveExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, additiveExpression55.getTree());

            	    }
            	    break;

            	default :
            	    break loop14;
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:209:1: additiveExpression : multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* ;
    public final SGLParser.additiveExpression_return additiveExpression() throws RecognitionException {
        SGLParser.additiveExpression_return retval = new SGLParser.additiveExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal57=null;
        Token char_literal58=null;
        SGLParser.multiplicativeExpression_return multiplicativeExpression56 = null;

        SGLParser.multiplicativeExpression_return multiplicativeExpression59 = null;


        Object char_literal57_tree=null;
        Object char_literal58_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:5: ( multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:9: multiplicativeExpression ( ( '+' | '-' ) multiplicativeExpression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression801);
            multiplicativeExpression56=multiplicativeExpression();

            state._fsp--;

            adaptor.addChild(root_0, multiplicativeExpression56.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:34: ( ( '+' | '-' ) multiplicativeExpression )*
            loop16:
            do {
                int alt16=2;
                int LA16_0 = input.LA(1);

                if ( ((LA16_0>=49 && LA16_0<=50)) ) {
                    alt16=1;
                }


                switch (alt16) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:35: ( '+' | '-' ) multiplicativeExpression
            	    {
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:35: ( '+' | '-' )
            	    int alt15=2;
            	    int LA15_0 = input.LA(1);

            	    if ( (LA15_0==49) ) {
            	        alt15=1;
            	    }
            	    else if ( (LA15_0==50) ) {
            	        alt15=2;
            	    }
            	    else {
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 15, 0, input);

            	        throw nvae;
            	    }
            	    switch (alt15) {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:36: '+'
            	            {
            	            char_literal57=(Token)match(input,49,FOLLOW_49_in_additiveExpression805); 
            	            char_literal57_tree = (Object)adaptor.create(char_literal57);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal57_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:210:41: '-'
            	            {
            	            char_literal58=(Token)match(input,50,FOLLOW_50_in_additiveExpression808); 
            	            char_literal58_tree = (Object)adaptor.create(char_literal58);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal58_tree, root_0);


            	            }
            	            break;

            	    }

            	    pushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression812);
            	    multiplicativeExpression59=multiplicativeExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, multiplicativeExpression59.getTree());

            	    }
            	    break;

            	default :
            	    break loop16;
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:214:1: multiplicativeExpression : negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* ;
    public final SGLParser.multiplicativeExpression_return multiplicativeExpression() throws RecognitionException {
        SGLParser.multiplicativeExpression_return retval = new SGLParser.multiplicativeExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal61=null;
        Token char_literal62=null;
        Token char_literal63=null;
        SGLParser.negativeExpression_return negativeExpression60 = null;

        SGLParser.negativeExpression_return negativeExpression64 = null;


        Object char_literal61_tree=null;
        Object char_literal62_tree=null;
        Object char_literal63_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:215:5: ( negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:215:9: negativeExpression ( ( '*' | '/' | '%' ) negativeExpression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression846);
            negativeExpression60=negativeExpression();

            state._fsp--;

            adaptor.addChild(root_0, negativeExpression60.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:5: ( ( '*' | '/' | '%' ) negativeExpression )*
            loop18:
            do {
                int alt18=2;
                int LA18_0 = input.LA(1);

                if ( ((LA18_0>=51 && LA18_0<=53)) ) {
                    alt18=1;
                }


                switch (alt18) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:6: ( '*' | '/' | '%' ) negativeExpression
            	    {
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:6: ( '*' | '/' | '%' )
            	    int alt17=3;
            	    switch ( input.LA(1) ) {
            	    case 51:
            	        {
            	        alt17=1;
            	        }
            	        break;
            	    case 52:
            	        {
            	        alt17=2;
            	        }
            	        break;
            	    case 53:
            	        {
            	        alt17=3;
            	        }
            	        break;
            	    default:
            	        NoViableAltException nvae =
            	            new NoViableAltException("", 17, 0, input);

            	        throw nvae;
            	    }

            	    switch (alt17) {
            	        case 1 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:7: '*'
            	            {
            	            char_literal61=(Token)match(input,51,FOLLOW_51_in_multiplicativeExpression854); 
            	            char_literal61_tree = (Object)adaptor.create(char_literal61);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal61_tree, root_0);


            	            }
            	            break;
            	        case 2 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:12: '/'
            	            {
            	            char_literal62=(Token)match(input,52,FOLLOW_52_in_multiplicativeExpression857); 
            	            char_literal62_tree = (Object)adaptor.create(char_literal62);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal62_tree, root_0);


            	            }
            	            break;
            	        case 3 :
            	            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:216:17: '%'
            	            {
            	            char_literal63=(Token)match(input,53,FOLLOW_53_in_multiplicativeExpression860); 
            	            char_literal63_tree = (Object)adaptor.create(char_literal63);
            	            root_0 = (Object)adaptor.becomeRoot(char_literal63_tree, root_0);


            	            }
            	            break;

            	    }

            	    pushFollow(FOLLOW_negativeExpression_in_multiplicativeExpression864);
            	    negativeExpression64=negativeExpression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, negativeExpression64.getTree());

            	    }
            	    break;

            	default :
            	    break loop18;
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:219:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public final SGLParser.unaryExpression_return unaryExpression() throws RecognitionException {
        SGLParser.unaryExpression_return retval = new SGLParser.unaryExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token string_literal65=null;
        Token string_literal67=null;
        SGLParser.unaryExpression_return unaryExpression66 = null;

        SGLParser.unaryExpression_return unaryExpression68 = null;

        SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus69 = null;


        Object string_literal65_tree=null;
        Object string_literal67_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:220:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt19=3;
            switch ( input.LA(1) ) {
            case 54:
                {
                alt19=1;
                }
                break;
            case 55:
                {
                alt19=2;
                }
                break;
            case Identifier:
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case StringAtom:
            case 34:
            case 56:
            case 57:
                {
                alt19=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 19, 0, input);

                throw nvae;
            }

            switch (alt19) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:220:7: '++' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    string_literal65=(Token)match(input,54,FOLLOW_54_in_unaryExpression887); 
                    string_literal65_tree = (Object)adaptor.create(string_literal65);
                    adaptor.addChild(root_0, string_literal65_tree);

                    pushFollow(FOLLOW_unaryExpression_in_unaryExpression889);
                    unaryExpression66=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression66.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:221:9: '--' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    string_literal67=(Token)match(input,55,FOLLOW_55_in_unaryExpression899); 
                    string_literal67_tree = (Object)adaptor.create(string_literal67);
                    adaptor.addChild(root_0, string_literal67_tree);

                    pushFollow(FOLLOW_unaryExpression_in_unaryExpression901);
                    unaryExpression68=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression68.getTree());

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:222:9: unaryExpressionNotPlusMinus
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression911);
                    unaryExpressionNotPlusMinus69=unaryExpressionNotPlusMinus();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpressionNotPlusMinus69.getTree());

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:226:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public final SGLParser.unaryExpressionNotPlusMinus_return unaryExpressionNotPlusMinus() throws RecognitionException {
        SGLParser.unaryExpressionNotPlusMinus_return retval = new SGLParser.unaryExpressionNotPlusMinus_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal70=null;
        Token set74=null;
        SGLParser.unaryExpression_return unaryExpression71 = null;

        SGLParser.castExpression_return castExpression72 = null;

        SGLParser.mathAtom_return mathAtom73 = null;


        Object char_literal70_tree=null;
        Object set74_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:227:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt21=3;
            switch ( input.LA(1) ) {
            case 56:
                {
                alt21=1;
                }
                break;
            case 34:
                {
                int LA21_2 = input.LA(2);

                if ( (LA21_2==Identifier||(LA21_2>=IntegerAtom && LA21_2<=BooleanAtom)||LA21_2==StringAtom||LA21_2==34||LA21_2==50||LA21_2==57) ) {
                    alt21=3;
                }
                else if ( ((LA21_2>=IntType && LA21_2<=ObjectType)) ) {
                    alt21=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 21, 2, input);

                    throw nvae;
                }
                }
                break;
            case Identifier:
            case IntegerAtom:
            case FloatAtom:
            case BooleanAtom:
            case StringAtom:
            case 57:
                {
                alt21=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 21, 0, input);

                throw nvae;
            }

            switch (alt21) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:227:9: '!' unaryExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    char_literal70=(Token)match(input,56,FOLLOW_56_in_unaryExpressionNotPlusMinus932); 
                    char_literal70_tree = (Object)adaptor.create(char_literal70);
                    adaptor.addChild(root_0, char_literal70_tree);

                    pushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus934);
                    unaryExpression71=unaryExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, unaryExpression71.getTree());

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:228:9: castExpression
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus944);
                    castExpression72=castExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, castExpression72.getTree());

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:230:9: mathAtom ( '++' | '--' )?
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus959);
                    mathAtom73=mathAtom();

                    state._fsp--;

                    adaptor.addChild(root_0, mathAtom73.getTree());
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:230:18: ( '++' | '--' )?
                    int alt20=2;
                    int LA20_0 = input.LA(1);

                    if ( ((LA20_0>=54 && LA20_0<=55)) ) {
                        alt20=1;
                    }
                    switch (alt20) {
                        case 1 :
                            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
                            {
                            set74=(Token)input.LT(1);
                            if ( (input.LA(1)>=54 && input.LA(1)<=55) ) {
                                input.consume();
                                adaptor.addChild(root_0, (Object)adaptor.create(set74));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:234:1: castExpression : '(' variableType ')' unaryExpression ;
    public final SGLParser.castExpression_return castExpression() throws RecognitionException {
        SGLParser.castExpression_return retval = new SGLParser.castExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal75=null;
        Token char_literal77=null;
        SGLParser.variableType_return variableType76 = null;

        SGLParser.unaryExpression_return unaryExpression78 = null;


        Object char_literal75_tree=null;
        Object char_literal77_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:235:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:235:8: '(' variableType ')' unaryExpression
            {
            root_0 = (Object)adaptor.nil();

            char_literal75=(Token)match(input,34,FOLLOW_34_in_castExpression992); 
            char_literal75_tree = (Object)adaptor.create(char_literal75);
            adaptor.addChild(root_0, char_literal75_tree);

            pushFollow(FOLLOW_variableType_in_castExpression994);
            variableType76=variableType();

            state._fsp--;

            adaptor.addChild(root_0, variableType76.getTree());
            char_literal77=(Token)match(input,35,FOLLOW_35_in_castExpression996); 
            char_literal77_tree = (Object)adaptor.create(char_literal77);
            adaptor.addChild(root_0, char_literal77_tree);

            pushFollow(FOLLOW_unaryExpression_in_castExpression998);
            unaryExpression78=unaryExpression();

            state._fsp--;

            adaptor.addChild(root_0, unaryExpression78.getTree());

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:240:1: negativeExpression : ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) );
    public final SGLParser.negativeExpression_return negativeExpression() throws RecognitionException {
        SGLParser.negativeExpression_return retval = new SGLParser.negativeExpression_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal80=null;
        SGLParser.mathAtom_return mathAtom79 = null;

        SGLParser.mathAtom_return mathAtom81 = null;


        Object char_literal80_tree=null;
        RewriteRuleTokenStream stream_50=new RewriteRuleTokenStream(adaptor,"token 50");
        RewriteRuleSubtreeStream stream_mathAtom=new RewriteRuleSubtreeStream(adaptor,"rule mathAtom");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:241:2: ( mathAtom -> mathAtom | ( '-' ) mathAtom -> ^( NEGATE mathAtom ) )
            int alt22=2;
            int LA22_0 = input.LA(1);

            if ( (LA22_0==Identifier||(LA22_0>=IntegerAtom && LA22_0<=BooleanAtom)||LA22_0==StringAtom||LA22_0==34||LA22_0==57) ) {
                alt22=1;
            }
            else if ( (LA22_0==50) ) {
                alt22=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 22, 0, input);

                throw nvae;
            }
            switch (alt22) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:241:4: mathAtom
                    {
                    pushFollow(FOLLOW_mathAtom_in_negativeExpression1016);
                    mathAtom79=mathAtom();

                    state._fsp--;

                    stream_mathAtom.add(mathAtom79.getTree());


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
                    // 241:13: -> mathAtom
                    {
                        adaptor.addChild(root_0, stream_mathAtom.nextTree());

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:4: ( '-' ) mathAtom
                    {
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:4: ( '-' )
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:5: '-'
                    {
                    char_literal80=(Token)match(input,50,FOLLOW_50_in_negativeExpression1026);  
                    stream_50.add(char_literal80);


                    }

                    pushFollow(FOLLOW_mathAtom_in_negativeExpression1029);
                    mathAtom81=mathAtom();

                    state._fsp--;

                    stream_mathAtom.add(mathAtom81.getTree());


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
                    // 242:19: -> ^( NEGATE mathAtom )
                    {
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:242:22: ^( NEGATE mathAtom )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:245:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote );
    public final SGLParser.mathAtom_return mathAtom() throws RecognitionException {
        SGLParser.mathAtom_return retval = new SGLParser.mathAtom_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal82=null;
        Token char_literal84=null;
        Token IntegerAtom85=null;
        Token FloatAtom86=null;
        Token BooleanAtom87=null;
        Token string_literal88=null;
        Token SpriteAnimation89=null;
        Token Identifier91=null;
        Token Identifier92=null;
        SGLParser.conditionalExpression_return conditionalExpression83 = null;

        SGLParser.arguments_return arguments90 = null;

        SGLParser.arguments_return arguments93 = null;

        SGLParser.stringQuote_return stringQuote94 = null;


        Object char_literal82_tree=null;
        Object char_literal84_tree=null;
        Object IntegerAtom85_tree=null;
        Object FloatAtom86_tree=null;
        Object BooleanAtom87_tree=null;
        Object string_literal88_tree=null;
        Object SpriteAnimation89_tree=null;
        Object Identifier91_tree=null;
        Object Identifier92_tree=null;
        RewriteRuleTokenStream stream_SpriteAnimation=new RewriteRuleTokenStream(adaptor,"token SpriteAnimation");
        RewriteRuleTokenStream stream_57=new RewriteRuleTokenStream(adaptor,"token 57");
        RewriteRuleTokenStream stream_Identifier=new RewriteRuleTokenStream(adaptor,"token Identifier");
        RewriteRuleSubtreeStream stream_arguments=new RewriteRuleSubtreeStream(adaptor,"rule arguments");
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:246:5: ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote )
            int alt23=8;
            alt23 = dfa23.predict(input);
            switch (alt23) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:246:7: '(' conditionalExpression ')'
                    {
                    root_0 = (Object)adaptor.nil();

                    char_literal82=(Token)match(input,34,FOLLOW_34_in_mathAtom1051); 
                    pushFollow(FOLLOW_conditionalExpression_in_mathAtom1054);
                    conditionalExpression83=conditionalExpression();

                    state._fsp--;

                    adaptor.addChild(root_0, conditionalExpression83.getTree());
                    char_literal84=(Token)match(input,35,FOLLOW_35_in_mathAtom1056); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:247:9: IntegerAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    IntegerAtom85=(Token)match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom1067); 
                    IntegerAtom85_tree = (Object)adaptor.create(IntegerAtom85);
                    adaptor.addChild(root_0, IntegerAtom85_tree);


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:248:7: FloatAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    FloatAtom86=(Token)match(input,FloatAtom,FOLLOW_FloatAtom_in_mathAtom1075); 
                    FloatAtom86_tree = (Object)adaptor.create(FloatAtom86);
                    adaptor.addChild(root_0, FloatAtom86_tree);


                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:249:9: BooleanAtom
                    {
                    root_0 = (Object)adaptor.nil();

                    BooleanAtom87=(Token)match(input,BooleanAtom,FOLLOW_BooleanAtom_in_mathAtom1085); 
                    BooleanAtom87_tree = (Object)adaptor.create(BooleanAtom87);
                    adaptor.addChild(root_0, BooleanAtom87_tree);


                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:251:9: 'new' SpriteAnimation arguments
                    {
                    string_literal88=(Token)match(input,57,FOLLOW_57_in_mathAtom1096);  
                    stream_57.add(string_literal88);

                    SpriteAnimation89=(Token)match(input,SpriteAnimation,FOLLOW_SpriteAnimation_in_mathAtom1098);  
                    stream_SpriteAnimation.add(SpriteAnimation89);

                    pushFollow(FOLLOW_arguments_in_mathAtom1100);
                    arguments90=arguments();

                    state._fsp--;

                    stream_arguments.add(arguments90.getTree());


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
                    // 251:41: -> ^( SpriteAnimation arguments )
                    {
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:251:44: ^( SpriteAnimation arguments )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:253:4: Identifier
                    {
                    Identifier91=(Token)match(input,Identifier,FOLLOW_Identifier_in_mathAtom1115);  
                    stream_Identifier.add(Identifier91);



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
                    // 253:15: -> Identifier
                    {
                        adaptor.addChild(root_0, stream_Identifier.nextNode());

                    }

                    retval.tree = root_0;
                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:254:4: Identifier arguments
                    {
                    Identifier92=(Token)match(input,Identifier,FOLLOW_Identifier_in_mathAtom1124);  
                    stream_Identifier.add(Identifier92);

                    pushFollow(FOLLOW_arguments_in_mathAtom1126);
                    arguments93=arguments();

                    state._fsp--;

                    stream_arguments.add(arguments93.getTree());


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
                    // 254:25: -> ^( LIBMETHOD Identifier ( arguments )? )
                    {
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:254:28: ^( LIBMETHOD Identifier ( arguments )? )
                        {
                        Object root_1 = (Object)adaptor.nil();
                        root_1 = (Object)adaptor.becomeRoot((Object)adaptor.create(LIBMETHOD, "LIBMETHOD"), root_1);

                        adaptor.addChild(root_1, stream_Identifier.nextNode());
                        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:254:51: ( arguments )?
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:255:4: stringQuote
                    {
                    root_0 = (Object)adaptor.nil();

                    pushFollow(FOLLOW_stringQuote_in_mathAtom1142);
                    stringQuote94=stringQuote();

                    state._fsp--;

                    adaptor.addChild(root_0, stringQuote94.getTree());

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:259:1: arguments : '(' ( expressionList )? ')' ;
    public final SGLParser.arguments_return arguments() throws RecognitionException {
        SGLParser.arguments_return retval = new SGLParser.arguments_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal95=null;
        Token char_literal97=null;
        SGLParser.expressionList_return expressionList96 = null;


        Object char_literal95_tree=null;
        Object char_literal97_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:260:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:260:9: '(' ( expressionList )? ')'
            {
            root_0 = (Object)adaptor.nil();

            char_literal95=(Token)match(input,34,FOLLOW_34_in_arguments1164); 
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:260:14: ( expressionList )?
            int alt24=2;
            int LA24_0 = input.LA(1);

            if ( (LA24_0==Identifier||(LA24_0>=IntegerAtom && LA24_0<=BooleanAtom)||LA24_0==StringAtom||LA24_0==34||LA24_0==50||LA24_0==57) ) {
                alt24=1;
            }
            switch (alt24) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:260:14: expressionList
                    {
                    pushFollow(FOLLOW_expressionList_in_arguments1167);
                    expressionList96=expressionList();

                    state._fsp--;

                    adaptor.addChild(root_0, expressionList96.getTree());

                    }
                    break;

            }

            char_literal97=(Token)match(input,35,FOLLOW_35_in_arguments1170); 

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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:263:1: expressionList : expression ( ',' expression )* ;
    public final SGLParser.expressionList_return expressionList() throws RecognitionException {
        SGLParser.expressionList_return retval = new SGLParser.expressionList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token char_literal99=null;
        SGLParser.expression_return expression98 = null;

        SGLParser.expression_return expression100 = null;


        Object char_literal99_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:264:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:264:9: expression ( ',' expression )*
            {
            root_0 = (Object)adaptor.nil();

            pushFollow(FOLLOW_expression_in_expressionList1194);
            expression98=expression();

            state._fsp--;

            adaptor.addChild(root_0, expression98.getTree());
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:264:20: ( ',' expression )*
            loop25:
            do {
                int alt25=2;
                int LA25_0 = input.LA(1);

                if ( (LA25_0==36) ) {
                    alt25=1;
                }


                switch (alt25) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:264:21: ',' expression
            	    {
            	    char_literal99=(Token)match(input,36,FOLLOW_36_in_expressionList1197); 
            	    pushFollow(FOLLOW_expression_in_expressionList1200);
            	    expression100=expression();

            	    state._fsp--;

            	    adaptor.addChild(root_0, expression100.getTree());

            	    }
            	    break;

            	default :
            	    break loop25;
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:267:1: idList : Identifier ( ',' Identifier )* -> ^( ID_LIST ( Identifier )+ ) ;
    public final SGLParser.idList_return idList() throws RecognitionException {
        SGLParser.idList_return retval = new SGLParser.idList_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token Identifier101=null;
        Token char_literal102=null;
        Token Identifier103=null;

        Object Identifier101_tree=null;
        Object char_literal102_tree=null;
        Object Identifier103_tree=null;
        RewriteRuleTokenStream stream_36=new RewriteRuleTokenStream(adaptor,"token 36");
        RewriteRuleTokenStream stream_Identifier=new RewriteRuleTokenStream(adaptor,"token Identifier");

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:3: ( Identifier ( ',' Identifier )* -> ^( ID_LIST ( Identifier )+ ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:6: Identifier ( ',' Identifier )*
            {
            Identifier101=(Token)match(input,Identifier,FOLLOW_Identifier_in_idList1219);  
            stream_Identifier.add(Identifier101);

            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:17: ( ',' Identifier )*
            loop26:
            do {
                int alt26=2;
                int LA26_0 = input.LA(1);

                if ( (LA26_0==36) ) {
                    alt26=1;
                }


                switch (alt26) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:18: ',' Identifier
            	    {
            	    char_literal102=(Token)match(input,36,FOLLOW_36_in_idList1222);  
            	    stream_36.add(char_literal102);

            	    Identifier103=(Token)match(input,Identifier,FOLLOW_Identifier_in_idList1224);  
            	    stream_Identifier.add(Identifier103);


            	    }
            	    break;

            	default :
            	    break loop26;
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
            // 268:35: -> ^( ID_LIST ( Identifier )+ )
            {
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:268:38: ^( ID_LIST ( Identifier )+ )
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:271:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public final SGLParser.literal_return literal() throws RecognitionException {
        SGLParser.literal_return retval = new SGLParser.literal_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token set104=null;

        Object set104_tree=null;

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:272:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            root_0 = (Object)adaptor.nil();

            set104=(Token)input.LT(1);
            if ( (input.LA(1)>=IntegerAtom && input.LA(1)<=BooleanAtom)||input.LA(1)==StringAtom||input.LA(1)==58 ) {
                input.consume();
                adaptor.addChild(root_0, (Object)adaptor.create(set104));
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
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:280:1: stringQuote : StringAtom -> StringAtom ;
    public final SGLParser.stringQuote_return stringQuote() throws RecognitionException {
        SGLParser.stringQuote_return retval = new SGLParser.stringQuote_return();
        retval.start = input.LT(1);

        Object root_0 = null;

        Token StringAtom105=null;

        Object StringAtom105_tree=null;
        RewriteRuleTokenStream stream_StringAtom=new RewriteRuleTokenStream(adaptor,"token StringAtom");

        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:281:2: ( StringAtom -> StringAtom )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:281:8: StringAtom
            {
            StringAtom105=(Token)match(input,StringAtom,FOLLOW_StringAtom_in_stringQuote1330);  
            stream_StringAtom.add(StringAtom105);



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
            // 281:19: -> StringAtom
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


    protected DFA23 dfa23 = new DFA23(this);
    static final String DFA23_eotS =
        "\12\uffff";
    static final String DFA23_eofS =
        "\6\uffff\1\10\3\uffff";
    static final String DFA23_minS =
        "\1\14\5\uffff\1\14\3\uffff";
    static final String DFA23_maxS =
        "\1\71\5\uffff\1\67\3\uffff";
    static final String DFA23_acceptS =
        "\1\uffff\1\1\1\2\1\3\1\4\1\5\1\uffff\1\10\1\6\1\7";
    static final String DFA23_specialS =
        "\12\uffff}>";
    static final String[] DFA23_transitionS = {
            "\1\6\5\uffff\1\2\1\3\1\4\1\uffff\1\7\13\uffff\1\1\26\uffff"+
            "\1\5",
            "",
            "",
            "",
            "",
            "",
            "\6\10\16\uffff\2\10\1\11\2\10\1\uffff\22\10",
            "",
            "",
            ""
    };

    static final short[] DFA23_eot = DFA.unpackEncodedString(DFA23_eotS);
    static final short[] DFA23_eof = DFA.unpackEncodedString(DFA23_eofS);
    static final char[] DFA23_min = DFA.unpackEncodedStringToUnsignedChars(DFA23_minS);
    static final char[] DFA23_max = DFA.unpackEncodedStringToUnsignedChars(DFA23_maxS);
    static final short[] DFA23_accept = DFA.unpackEncodedString(DFA23_acceptS);
    static final short[] DFA23_special = DFA.unpackEncodedString(DFA23_specialS);
    static final short[][] DFA23_transition;

    static {
        int numStates = DFA23_transitionS.length;
        DFA23_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA23_transition[i] = DFA.unpackEncodedString(DFA23_transitionS[i]);
        }
    }

    class DFA23 extends DFA {

        public DFA23(BaseRecognizer recognizer) {
            this.recognizer = recognizer;
            this.decisionNumber = 23;
            this.eot = DFA23_eot;
            this.eof = DFA23_eof;
            this.min = DFA23_min;
            this.max = DFA23_max;
            this.accept = DFA23_accept;
            this.special = DFA23_special;
            this.transition = DFA23_transition;
        }
        public String getDescription() {
            return "245:1: mathAtom : ( '(' conditionalExpression ')' | IntegerAtom | FloatAtom | BooleanAtom | 'new' SpriteAnimation arguments -> ^( SpriteAnimation arguments ) | Identifier -> Identifier | Identifier arguments -> ^( LIBMETHOD Identifier ( arguments )? ) | stringQuote );";
        }
    }
 

    public static final BitSet FOLLOW_mainBlock_in_compilationUnit104 = new BitSet(new long[]{0x0000000000000000L});
    public static final BitSet FOLLOW_EOF_in_compilationUnit106 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mainStatement_in_mainBlock119 = new BitSet(new long[]{0x000000420003F002L});
    public static final BitSet FOLLOW_methodDef_in_mainBlock123 = new BitSet(new long[]{0x000000420003F002L});
    public static final BitSet FOLLOW_statement_in_block171 = new BitSet(new long[]{0x000000400003F002L});
    public static final BitSet FOLLOW_statement_in_singleBlock199 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_singleBlock_in_commonBlock225 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_31_in_commonBlock230 = new BitSet(new long[]{0x000000410003F000L});
    public static final BitSet FOLLOW_block_in_commonBlock232 = new BitSet(new long[]{0x0000000100000000L});
    public static final BitSet FOLLOW_32_in_commonBlock234 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_33_in_methodDef267 = new BitSet(new long[]{0x0000000000001000L});
    public static final BitSet FOLLOW_Identifier_in_methodDef269 = new BitSet(new long[]{0x0000000400000000L});
    public static final BitSet FOLLOW_34_in_methodDef271 = new BitSet(new long[]{0x0000000800001000L});
    public static final BitSet FOLLOW_idList_in_methodDef273 = new BitSet(new long[]{0x0000000800000000L});
    public static final BitSet FOLLOW_35_in_methodDef276 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_statement_in_mainStatement305 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableDeclarationList_in_statement320 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableAssignment_in_statement326 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_whileLoop_in_statement339 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_variableType_in_variableDeclarationList355 = new BitSet(new long[]{0x0000000000001000L});
    public static final BitSet FOLLOW_variableAssignment_in_variableDeclarationList357 = new BitSet(new long[]{0x0000001000000002L});
    public static final BitSet FOLLOW_36_in_variableDeclarationList360 = new BitSet(new long[]{0x0000000000001000L});
    public static final BitSet FOLLOW_variableAssignment_in_variableDeclarationList362 = new BitSet(new long[]{0x0000001000000002L});
    public static final BitSet FOLLOW_variableName_in_variableAssignment386 = new BitSet(new long[]{0x0000002000000002L});
    public static final BitSet FOLLOW_37_in_variableAssignment389 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_expression_in_variableAssignment391 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_variableName419 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_set_in_variableType0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_38_in_whileLoop463 = new BitSet(new long[]{0x0000000400000000L});
    public static final BitSet FOLLOW_34_in_whileLoop465 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_expression_in_whileLoop467 = new BitSet(new long[]{0x0000000800000000L});
    public static final BitSet FOLLOW_35_in_whileLoop469 = new BitSet(new long[]{0x000000408003F000L});
    public static final BitSet FOLLOW_commonBlock_in_whileLoop471 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalExpression_in_expression533 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression574 = new BitSet(new long[]{0x0000008000000002L});
    public static final BitSet FOLLOW_39_in_conditionalExpression578 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_conditionalExpression_in_conditionalExpression581 = new BitSet(new long[]{0x0000010000000000L});
    public static final BitSet FOLLOW_40_in_conditionalExpression583 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_conditionalExpression_in_conditionalExpression586 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression629 = new BitSet(new long[]{0x0000020000000002L});
    public static final BitSet FOLLOW_41_in_conditionalOrExpression633 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression636 = new BitSet(new long[]{0x0000020000000002L});
    public static final BitSet FOLLOW_equalityExpression_in_conditionalAndExpression667 = new BitSet(new long[]{0x0000040000000002L});
    public static final BitSet FOLLOW_42_in_conditionalAndExpression671 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_equalityExpression_in_conditionalAndExpression674 = new BitSet(new long[]{0x0000040000000002L});
    public static final BitSet FOLLOW_relationalExpression_in_equalityExpression701 = new BitSet(new long[]{0x0000180000000002L});
    public static final BitSet FOLLOW_43_in_equalityExpression706 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_44_in_equalityExpression711 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_relationalExpression_in_equalityExpression715 = new BitSet(new long[]{0x0000180000000002L});
    public static final BitSet FOLLOW_additiveExpression_in_relationalExpression746 = new BitSet(new long[]{0x0001E00000000002L});
    public static final BitSet FOLLOW_45_in_relationalExpression750 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_46_in_relationalExpression753 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_47_in_relationalExpression756 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_48_in_relationalExpression759 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_additiveExpression_in_relationalExpression763 = new BitSet(new long[]{0x0001E00000000002L});
    public static final BitSet FOLLOW_multiplicativeExpression_in_additiveExpression801 = new BitSet(new long[]{0x0006000000000002L});
    public static final BitSet FOLLOW_49_in_additiveExpression805 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_50_in_additiveExpression808 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_multiplicativeExpression_in_additiveExpression812 = new BitSet(new long[]{0x0006000000000002L});
    public static final BitSet FOLLOW_negativeExpression_in_multiplicativeExpression846 = new BitSet(new long[]{0x0038000000000002L});
    public static final BitSet FOLLOW_51_in_multiplicativeExpression854 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_52_in_multiplicativeExpression857 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_53_in_multiplicativeExpression860 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_negativeExpression_in_multiplicativeExpression864 = new BitSet(new long[]{0x0038000000000002L});
    public static final BitSet FOLLOW_54_in_unaryExpression887 = new BitSet(new long[]{0x03C00004005C1000L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpression889 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_55_in_unaryExpression899 = new BitSet(new long[]{0x03C00004005C1000L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpression901 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression911 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_56_in_unaryExpressionNotPlusMinus932 = new BitSet(new long[]{0x03C00004005C1000L});
    public static final BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus934 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus944 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus959 = new BitSet(new long[]{0x00C0000000000002L});
    public static final BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus961 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_34_in_castExpression992 = new BitSet(new long[]{0x000000000003E000L});
    public static final BitSet FOLLOW_variableType_in_castExpression994 = new BitSet(new long[]{0x0000000800000000L});
    public static final BitSet FOLLOW_35_in_castExpression996 = new BitSet(new long[]{0x03C00004005C1000L});
    public static final BitSet FOLLOW_unaryExpression_in_castExpression998 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_mathAtom_in_negativeExpression1016 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_50_in_negativeExpression1026 = new BitSet(new long[]{0x02000004005C1000L});
    public static final BitSet FOLLOW_mathAtom_in_negativeExpression1029 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_34_in_mathAtom1051 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_conditionalExpression_in_mathAtom1054 = new BitSet(new long[]{0x0000000800000000L});
    public static final BitSet FOLLOW_35_in_mathAtom1056 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_IntegerAtom_in_mathAtom1067 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_FloatAtom_in_mathAtom1075 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_BooleanAtom_in_mathAtom1085 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_57_in_mathAtom1096 = new BitSet(new long[]{0x0000000000200000L});
    public static final BitSet FOLLOW_SpriteAnimation_in_mathAtom1098 = new BitSet(new long[]{0x0000000400000000L});
    public static final BitSet FOLLOW_arguments_in_mathAtom1100 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_mathAtom1115 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_Identifier_in_mathAtom1124 = new BitSet(new long[]{0x0000000400000000L});
    public static final BitSet FOLLOW_arguments_in_mathAtom1126 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_stringQuote_in_mathAtom1142 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_34_in_arguments1164 = new BitSet(new long[]{0x0204000C005C1000L});
    public static final BitSet FOLLOW_expressionList_in_arguments1167 = new BitSet(new long[]{0x0000000800000000L});
    public static final BitSet FOLLOW_35_in_arguments1170 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_expression_in_expressionList1194 = new BitSet(new long[]{0x0000001000000002L});
    public static final BitSet FOLLOW_36_in_expressionList1197 = new BitSet(new long[]{0x02040004005C1000L});
    public static final BitSet FOLLOW_expression_in_expressionList1200 = new BitSet(new long[]{0x0000001000000002L});
    public static final BitSet FOLLOW_Identifier_in_idList1219 = new BitSet(new long[]{0x0000001000000002L});
    public static final BitSet FOLLOW_36_in_idList1222 = new BitSet(new long[]{0x0000000000001000L});
    public static final BitSet FOLLOW_Identifier_in_idList1224 = new BitSet(new long[]{0x0000001000000002L});
    public static final BitSet FOLLOW_set_in_literal0 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_StringAtom_in_stringQuote1330 = new BitSet(new long[]{0x0000000000000002L});

}