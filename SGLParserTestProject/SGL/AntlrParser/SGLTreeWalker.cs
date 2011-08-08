// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g 2011-08-08 22:43:56

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


	using System.Collections.Generic;
	using SGL.Node;


using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  SGL.AntlrParser 
{
public partial class SGLTreeWalker : TreeParser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"BLOCK", 
		"STATEMENTS", 
		"ID_LIST", 
		"VARDEF", 
		"ASSIGN", 
		"NEGATE", 
		"LIBMETHOD", 
		"STRING", 
		"Identifier", 
		"IntType", 
		"BooleanType", 
		"StringType", 
		"FloatType", 
		"ObjectType", 
		"IntegerAtom", 
		"FloatAtom", 
		"BooleanAtom", 
		"SpriteAnimation", 
		"StringAtom", 
		"EscapeSequence", 
		"Letter", 
		"SGLIDDigit", 
		"UnicodeEscape", 
		"OctalEscape", 
		"HEX_DIGIT", 
		"WS", 
		"COMMENT", 
		"'{'", 
		"'}'", 
		"'method'", 
		"'('", 
		"')'", 
		"','", 
		"'='", 
		"'while'", 
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
		"'++'", 
		"'--'", 
		"'!'", 
		"'new'", 
		"'null'"
    };

    public const int SGLIDDigit = 25;
    public const int IntType = 13;
    public const int ID_LIST = 6;
    public const int EOF = -1;
    public const int Identifier = 12;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int StringType = 15;
    public const int SpriteAnimation = 21;
    public const int VARDEF = 7;
    public const int COMMENT = 30;
    public const int T__50 = 50;
    public const int BooleanType = 14;
    public const int T__42 = 42;
    public const int T__43 = 43;
    public const int T__40 = 40;
    public const int T__41 = 41;
    public const int T__46 = 46;
    public const int T__47 = 47;
    public const int T__44 = 44;
    public const int T__45 = 45;
    public const int T__48 = 48;
    public const int T__49 = 49;
    public const int LIBMETHOD = 10;
    public const int IntegerAtom = 18;
    public const int FloatType = 16;
    public const int StringAtom = 22;
    public const int HEX_DIGIT = 28;
    public const int NEGATE = 9;
    public const int BooleanAtom = 20;
    public const int T__31 = 31;
    public const int T__32 = 32;
    public const int WS = 29;
    public const int T__33 = 33;
    public const int T__34 = 34;
    public const int T__35 = 35;
    public const int T__36 = 36;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 26;
    public const int BLOCK = 4;
    public const int ASSIGN = 8;
    public const int STATEMENTS = 5;
    public const int ObjectType = 17;
    public const int FloatAtom = 19;
    public const int EscapeSequence = 23;
    public const int Letter = 24;
    public const int OctalEscape = 27;
    public const int STRING = 11;

    // delegates
    // delegators



        public SGLTreeWalker(ITreeNodeStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SGLTreeWalker(ITreeNodeStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        

    override public string[] TokenNames {
		get { return SGLTreeWalker.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g"; }
    }


    	Scope currentScope = null;
    	// Error reporting
        //private StdErrReporter errorReporter = new StdErrReporter();
        //public override void EmitErrorMessage(String msg)
        //{
        //	errorReporter.ReportError(msg);
        //}

    	// For global variables (accessable anywhere)
    	//NullableDictionnary globalVariables = new NullableDictionnary();
    	
    	// For main variables (accessable anywhere but methods)
    	
    	
    	
    	//NullableDictionnary mainVariables = new NullableDictionnary();
    	
    	// This should tell the statements where they have to look up variables
    	//NullableDictionnary variableAccess = mainVariables;

    	//String output;
    	//public String GetOutput() {
    	//	return output;
    	//}



    // $ANTLR start "compilationUnit"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:42:1: compilationUnit returns [SGLNode node] : block ;
    public SGLNode compilationUnit() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode block1 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:43:2: ( block )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:43:4: block
            {
            	PushFollow(FOLLOW_block_in_compilationUnit60);
            	block1 = block();
            	state.followingStackPointer--;

            	 node = block1; 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "compilationUnit"


    // $ANTLR start "block"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:53:1: block returns [SGLNode node] : ^( BLOCK ^( STATEMENTS ( statement )* ) ) ;
    public SGLNode block() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode statement2 = default(SGLNode);


         
          BlockNode bn = new BlockNode(); 
          node = bn; 
          Scope scope = new Scope(currentScope); 
          currentScope = scope; 

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:63:2: ( ^( BLOCK ^( STATEMENTS ( statement )* ) ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:63:4: ^( BLOCK ^( STATEMENTS ( statement )* ) )
            {
            	Match(input,BLOCK,FOLLOW_BLOCK_in_block95); 

            	Match(input, Token.DOWN, null); 
            	Match(input,STATEMENTS,FOLLOW_STATEMENTS_in_block111); 

            	if ( input.LA(1) == Token.DOWN )
            	{
            	    Match(input, Token.DOWN, null); 
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:64:24: ( statement )*
            	    do 
            	    {
            	        int alt1 = 2;
            	        int LA1_0 = input.LA(1);

            	        if ( (LA1_0 == VARDEF) )
            	        {
            	            alt1 = 1;
            	        }


            	        switch (alt1) 
            	    	{
            	    		case 1 :
            	    		    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:64:25: statement
            	    		    {
            	    		    	PushFollow(FOLLOW_statement_in_block114);
            	    		    	statement2 = statement();
            	    		    	state.followingStackPointer--;

            	    		    	bn.AddStatement(statement2);

            	    		    }
            	    		    break;

            	    		default:
            	    		    goto loop1;
            	        }
            	    } while (true);

            	    loop1:
            	    	;	// Stops C# compiler whining that label 'loop1' has no statements


            	    Match(input, Token.UP, null); 
            	}

            	Match(input, Token.UP, null); 

            }

             
              currentScope = currentScope.Parent(); 

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "block"


    // $ANTLR start "statement"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:68:1: statement returns [SGLNode node] : variableDeclaration ;
    public SGLNode statement() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        SGLNode variableDeclaration3 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:70:2: ( variableDeclaration )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:70:4: variableDeclaration
            {
            	PushFollow(FOLLOW_variableDeclaration_in_statement155);
            	variableDeclaration3 = variableDeclaration();
            	state.followingStackPointer--;

            	 node = variableDeclaration3; 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "statement"


    // $ANTLR start "variableDeclaration"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:86:1: variableDeclaration returns [SGLNode node] : ^( VARDEF variableType variableName expression ) ;
    public SGLNode variableDeclaration() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        String variableType4 = default(String);

        String variableName5 = default(String);

        SGLNode expression6 = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:87:2: ( ^( VARDEF variableType variableName expression ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:87:4: ^( VARDEF variableType variableName expression )
            {
            	Match(input,VARDEF,FOLLOW_VARDEF_in_variableDeclaration186); 

            	Match(input, Token.DOWN, null); 
            	PushFollow(FOLLOW_variableType_in_variableDeclaration188);
            	variableType4 = variableType();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_variableName_in_variableDeclaration190);
            	variableName5 = variableName();
            	state.followingStackPointer--;

            	PushFollow(FOLLOW_expression_in_variableDeclaration192);
            	expression6 = expression();
            	state.followingStackPointer--;


            	Match(input, Token.UP, null); 
            	 	
            			node = new NewLocalVariableNode(variableType4,variableName5,expression6,currentScope); 
            		

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "variableDeclaration"


    // $ANTLR start "variableName"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:104:1: variableName returns [String txt] : Identifier ;
    public String variableName() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree Identifier7 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:105:2: ( Identifier )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:105:4: Identifier
            {
            	Identifier7=(CommonTree)Match(input,Identifier,FOLLOW_Identifier_in_variableName220); 
            	 txt = ((Identifier7 != null) ? Identifier7.Text : null); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return txt;
    }
    // $ANTLR end "variableName"


    // $ANTLR start "variableType"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:108:1: variableType returns [String txt] : ( IntType | BooleanType | StringType | FloatType );
    public String variableType() // throws RecognitionException [1]
    {   
        String txt = default(String);

        CommonTree IntType8 = null;
        CommonTree BooleanType9 = null;
        CommonTree StringType10 = null;
        CommonTree FloatType11 = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:109:2: ( IntType | BooleanType | StringType | FloatType )
            int alt2 = 4;
            switch ( input.LA(1) ) 
            {
            case IntType:
            	{
                alt2 = 1;
                }
                break;
            case BooleanType:
            	{
                alt2 = 2;
                }
                break;
            case StringType:
            	{
                alt2 = 3;
                }
                break;
            case FloatType:
            	{
                alt2 = 4;
                }
                break;
            	default:
            	    NoViableAltException nvae_d2s0 =
            	        new NoViableAltException("", 2, 0, input);

            	    throw nvae_d2s0;
            }

            switch (alt2) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:109:4: IntType
                    {
                    	IntType8=(CommonTree)Match(input,IntType,FOLLOW_IntType_in_variableType238); 
                    	 txt = ((IntType8 != null) ? IntType8.Text : null); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:110:4: BooleanType
                    {
                    	BooleanType9=(CommonTree)Match(input,BooleanType,FOLLOW_BooleanType_in_variableType245); 
                    	 txt = ((BooleanType9 != null) ? BooleanType9.Text : null); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:111:4: StringType
                    {
                    	StringType10=(CommonTree)Match(input,StringType,FOLLOW_StringType_in_variableType252); 
                    	 txt = ((StringType10 != null) ? StringType10.Text : null); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:112:4: FloatType
                    {
                    	FloatType11=(CommonTree)Match(input,FloatType,FOLLOW_FloatType_in_variableType259); 
                    	 txt = ((FloatType11 != null) ? FloatType11.Text : null); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return txt;
    }
    // $ANTLR end "variableType"


    // $ANTLR start "expression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:122:1: expression returns [SGLNode node] : ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | Identifier | IntegerAtom | FloatAtom | BooleanAtom );
    public SGLNode expression() // throws RecognitionException [1]
    {   
        SGLNode node = default(SGLNode);

        CommonTree IntegerAtom12 = null;
        CommonTree FloatAtom13 = null;
        CommonTree BooleanAtom14 = null;
        SGLNode a = default(SGLNode);

        SGLNode b = default(SGLNode);

        SGLNode c = default(SGLNode);


        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:123:2: ( ^( '+' a= expression b= expression ) | ^( '-' a= expression b= expression ) | ^( '*' a= expression b= expression ) | ^( '/' a= expression b= expression ) | ^( '%' a= expression b= expression ) | ^( NEGATE a= expression ) | ^( '<' a= expression b= expression ) | ^( '<=' a= expression b= expression ) | ^( '>' a= expression b= expression ) | ^( '>=' a= expression b= expression ) | ^( '!=' a= expression b= expression ) | ^( '==' a= expression b= expression ) | ^( '&&' a= expression b= expression ) | ^( '||' a= expression b= expression ) | ^( '?' a= expression b= expression c= expression ) | Identifier | IntegerAtom | FloatAtom | BooleanAtom )
            int alt3 = 19;
            switch ( input.LA(1) ) 
            {
            case 49:
            	{
                alt3 = 1;
                }
                break;
            case 50:
            	{
                alt3 = 2;
                }
                break;
            case 51:
            	{
                alt3 = 3;
                }
                break;
            case 52:
            	{
                alt3 = 4;
                }
                break;
            case 53:
            	{
                alt3 = 5;
                }
                break;
            case NEGATE:
            	{
                alt3 = 6;
                }
                break;
            case 45:
            	{
                alt3 = 7;
                }
                break;
            case 47:
            	{
                alt3 = 8;
                }
                break;
            case 46:
            	{
                alt3 = 9;
                }
                break;
            case 48:
            	{
                alt3 = 10;
                }
                break;
            case 44:
            	{
                alt3 = 11;
                }
                break;
            case 43:
            	{
                alt3 = 12;
                }
                break;
            case 42:
            	{
                alt3 = 13;
                }
                break;
            case 41:
            	{
                alt3 = 14;
                }
                break;
            case 39:
            	{
                alt3 = 15;
                }
                break;
            case Identifier:
            	{
                alt3 = 16;
                }
                break;
            case IntegerAtom:
            	{
                alt3 = 17;
                }
                break;
            case FloatAtom:
            	{
                alt3 = 18;
                }
                break;
            case BooleanAtom:
            	{
                alt3 = 19;
                }
                break;
            	default:
            	    NoViableAltException nvae_d3s0 =
            	        new NoViableAltException("", 3, 0, input);

            	    throw nvae_d3s0;
            }

            switch (alt3) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:123:4: ^( '+' a= expression b= expression )
                    {
                    	Match(input,49,FOLLOW_49_in_expression299); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression303);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression307);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new AddNode(a, b); 

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:124:4: ^( '-' a= expression b= expression )
                    {
                    	Match(input,50,FOLLOW_50_in_expression316); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression320);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression324);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new SubNode(a, b); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:125:4: ^( '*' a= expression b= expression )
                    {
                    	Match(input,51,FOLLOW_51_in_expression333); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression337);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression341);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new MultNode(a, b); 

                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:126:4: ^( '/' a= expression b= expression )
                    {
                    	Match(input,52,FOLLOW_52_in_expression350); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression354);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression358);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 
                    	 node = new DivNode(a, b); 

                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:127:4: ^( '%' a= expression b= expression )
                    {
                    	Match(input,53,FOLLOW_53_in_expression367); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression371);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression375);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:128:4: ^( NEGATE a= expression )
                    {
                    	Match(input,NEGATE,FOLLOW_NEGATE_in_expression383); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression387);
                    	a = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:129:4: ^( '<' a= expression b= expression )
                    {
                    	Match(input,45,FOLLOW_45_in_expression394); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression398);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression402);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:130:4: ^( '<=' a= expression b= expression )
                    {
                    	Match(input,47,FOLLOW_47_in_expression409); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression413);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression417);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:131:4: ^( '>' a= expression b= expression )
                    {
                    	Match(input,46,FOLLOW_46_in_expression424); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression428);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression432);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 10 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:132:4: ^( '>=' a= expression b= expression )
                    {
                    	Match(input,48,FOLLOW_48_in_expression439); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression443);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression447);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 11 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:133:4: ^( '!=' a= expression b= expression )
                    {
                    	Match(input,44,FOLLOW_44_in_expression454); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression458);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression462);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 12 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:134:4: ^( '==' a= expression b= expression )
                    {
                    	Match(input,43,FOLLOW_43_in_expression469); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression473);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression477);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 13 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:135:4: ^( '&&' a= expression b= expression )
                    {
                    	Match(input,42,FOLLOW_42_in_expression484); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression488);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression492);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 14 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:136:4: ^( '||' a= expression b= expression )
                    {
                    	Match(input,41,FOLLOW_41_in_expression499); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression503);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression507);
                    	b = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 15 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:137:4: ^( '?' a= expression b= expression c= expression )
                    {
                    	Match(input,39,FOLLOW_39_in_expression514); 

                    	Match(input, Token.DOWN, null); 
                    	PushFollow(FOLLOW_expression_in_expression518);
                    	a = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression522);
                    	b = expression();
                    	state.followingStackPointer--;

                    	PushFollow(FOLLOW_expression_in_expression526);
                    	c = expression();
                    	state.followingStackPointer--;


                    	Match(input, Token.UP, null); 

                    }
                    break;
                case 16 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:138:4: Identifier
                    {
                    	Match(input,Identifier,FOLLOW_Identifier_in_expression532); 

                    }
                    break;
                case 17 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:139:6: IntegerAtom
                    {
                    	IntegerAtom12=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_expression539); 
                    	 node = new AtomNode(int.Parse(((IntegerAtom12 != null) ? IntegerAtom12.Text : null))); 

                    }
                    break;
                case 18 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:140:4: FloatAtom
                    {
                    	FloatAtom13=(CommonTree)Match(input,FloatAtom,FOLLOW_FloatAtom_in_expression546); 
                    	 node = new AtomNode(int.Parse(((FloatAtom13 != null) ? FloatAtom13.Text : null))); 

                    }
                    break;
                case 19 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:141:6: BooleanAtom
                    {
                    	BooleanAtom14=(CommonTree)Match(input,BooleanAtom,FOLLOW_BooleanAtom_in_expression555); 
                    	 node = new AtomNode(int.Parse(((BooleanAtom14 != null) ? BooleanAtom14.Text : null))); 

                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return node;
    }
    // $ANTLR end "expression"


    // $ANTLR start "conditionalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:150:1: conditionalExpression : conditionalOrExpression '?' conditionalExpression ':' conditionalExpression ;
    public void conditionalExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:151:5: ( conditionalOrExpression '?' conditionalExpression ':' conditionalExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:151:10: conditionalOrExpression '?' conditionalExpression ':' conditionalExpression
            {
            	PushFollow(FOLLOW_conditionalOrExpression_in_conditionalExpression599);
            	conditionalOrExpression();
            	state.followingStackPointer--;

            	Match(input,39,FOLLOW_39_in_conditionalExpression601); 
            	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression603);
            	conditionalExpression();
            	state.followingStackPointer--;

            	Match(input,40,FOLLOW_40_in_conditionalExpression605); 
            	PushFollow(FOLLOW_conditionalExpression_in_conditionalExpression606);
            	conditionalExpression();
            	state.followingStackPointer--;


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "conditionalExpression"


    // $ANTLR start "conditionalOrExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:156:1: conditionalOrExpression : conditionalAndExpression ( '||' conditionalAndExpression )* ;
    public void conditionalOrExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:157:5: ( conditionalAndExpression ( '||' conditionalAndExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:157:9: conditionalAndExpression ( '||' conditionalAndExpression )*
            {
            	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression646);
            	conditionalAndExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:157:34: ( '||' conditionalAndExpression )*
            	do 
            	{
            	    int alt4 = 2;
            	    int LA4_0 = input.LA(1);

            	    if ( (LA4_0 == 41) )
            	    {
            	        alt4 = 1;
            	    }


            	    switch (alt4) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:157:36: '||' conditionalAndExpression
            			    {
            			    	Match(input,41,FOLLOW_41_in_conditionalOrExpression650); 
            			    	PushFollow(FOLLOW_conditionalAndExpression_in_conditionalOrExpression652);
            			    	conditionalAndExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop4;
            	    }
            	} while (true);

            	loop4:
            		;	// Stops C# compiler whining that label 'loop4' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "conditionalOrExpression"


    // $ANTLR start "conditionalAndExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:161:1: conditionalAndExpression : equalityExpression ( '&&' equalityExpression )* ;
    public void conditionalAndExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:162:5: ( equalityExpression ( '&&' equalityExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:162:9: equalityExpression ( '&&' equalityExpression )*
            {
            	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression683);
            	equalityExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:162:28: ( '&&' equalityExpression )*
            	do 
            	{
            	    int alt5 = 2;
            	    int LA5_0 = input.LA(1);

            	    if ( (LA5_0 == 42) )
            	    {
            	        alt5 = 1;
            	    }


            	    switch (alt5) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:162:30: '&&' equalityExpression
            			    {
            			    	Match(input,42,FOLLOW_42_in_conditionalAndExpression687); 
            			    	PushFollow(FOLLOW_equalityExpression_in_conditionalAndExpression689);
            			    	equalityExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop5;
            	    }
            	} while (true);

            	loop5:
            		;	// Stops C# compiler whining that label 'loop5' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "conditionalAndExpression"


    // $ANTLR start "equalityExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:166:1: equalityExpression : relationalExpression ( ( '==' | '!=' ) relationalExpression )* ;
    public void equalityExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:167:5: ( relationalExpression ( ( '==' | '!=' ) relationalExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:167:9: relationalExpression ( ( '==' | '!=' ) relationalExpression )*
            {
            	PushFollow(FOLLOW_relationalExpression_in_equalityExpression716);
            	relationalExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:167:30: ( ( '==' | '!=' ) relationalExpression )*
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= 43 && LA6_0 <= 44)) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:167:32: ( '==' | '!=' ) relationalExpression
            			    {
            			    	if ( (input.LA(1) >= 43 && input.LA(1) <= 44) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_relationalExpression_in_equalityExpression728);
            			    	relationalExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop6;
            	    }
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "equalityExpression"


    // $ANTLR start "relationalExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:171:1: relationalExpression : additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* ;
    public void relationalExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:172:5: ( additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:172:9: additiveExpression ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            {
            	PushFollow(FOLLOW_additiveExpression_in_relationalExpression759);
            	additiveExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:172:28: ( ( '<' | '>' | '<=' | '>=' ) additiveExpression )*
            	do 
            	{
            	    int alt7 = 2;
            	    int LA7_0 = input.LA(1);

            	    if ( ((LA7_0 >= 45 && LA7_0 <= 48)) )
            	    {
            	        alt7 = 1;
            	    }


            	    switch (alt7) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:172:30: ( '<' | '>' | '<=' | '>=' ) additiveExpression
            			    {
            			    	if ( (input.LA(1) >= 45 && input.LA(1) <= 48) ) 
            			    	{
            			    	    input.Consume();
            			    	    state.errorRecovery = false;
            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_additiveExpression_in_relationalExpression773);
            			    	additiveExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop7;
            	    }
            	} while (true);

            	loop7:
            		;	// Stops C# compiler whining that label 'loop7' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "relationalExpression"


    // $ANTLR start "additiveExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:176:1: additiveExpression : e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )* ;
    public void additiveExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:177:5: (e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:177:9: e= multiplicativeExpression ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )*
            {
            	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression814);
            	multiplicativeExpression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:178:5: ( '+' e= multiplicativeExpression | '-' e= multiplicativeExpression )*
            	do 
            	{
            	    int alt8 = 3;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == 49) )
            	    {
            	        alt8 = 1;
            	    }
            	    else if ( (LA8_0 == 50) )
            	    {
            	        alt8 = 2;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:178:7: '+' e= multiplicativeExpression
            			    {
            			    	Match(input,49,FOLLOW_49_in_additiveExpression822); 
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression826);
            			    	multiplicativeExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:179:7: '-' e= multiplicativeExpression
            			    {
            			    	Match(input,50,FOLLOW_50_in_additiveExpression835); 
            			    	PushFollow(FOLLOW_multiplicativeExpression_in_additiveExpression839);
            			    	multiplicativeExpression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "additiveExpression"


    // $ANTLR start "multiplicativeExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:184:1: multiplicativeExpression : e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* ;
    public void multiplicativeExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:185:5: (e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:185:9: e= mathAtom ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            {
            	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression880);
            	mathAtom();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:186:5: ( '*' e= mathAtom | '/' e= mathAtom | '%' e= mathAtom )*
            	do 
            	{
            	    int alt9 = 4;
            	    switch ( input.LA(1) ) 
            	    {
            	    case 51:
            	    	{
            	        alt9 = 1;
            	        }
            	        break;
            	    case 52:
            	    	{
            	        alt9 = 2;
            	        }
            	        break;
            	    case 53:
            	    	{
            	        alt9 = 3;
            	        }
            	        break;

            	    }

            	    switch (alt9) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:186:7: '*' e= mathAtom
            			    {
            			    	Match(input,51,FOLLOW_51_in_multiplicativeExpression888); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression892);
            			    	mathAtom();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:187:7: '/' e= mathAtom
            			    {
            			    	Match(input,52,FOLLOW_52_in_multiplicativeExpression900); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression904);
            			    	mathAtom();
            			    	state.followingStackPointer--;


            			    }
            			    break;
            			case 3 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:188:7: '%' e= mathAtom
            			    {
            			    	Match(input,53,FOLLOW_53_in_multiplicativeExpression912); 
            			    	PushFollow(FOLLOW_mathAtom_in_multiplicativeExpression916);
            			    	mathAtom();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop9;
            	    }
            	} while (true);

            	loop9:
            		;	// Stops C# compiler whining that label 'loop9' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "multiplicativeExpression"


    // $ANTLR start "unaryExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:192:1: unaryExpression : ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus );
    public void unaryExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:193:5: ( '++' unaryExpression | '--' unaryExpression | unaryExpressionNotPlusMinus )
            int alt10 = 3;
            switch ( input.LA(1) ) 
            {
            case 54:
            	{
                alt10 = 1;
                }
                break;
            case 55:
            	{
                alt10 = 2;
                }
                break;
            case IntegerAtom:
            case 34:
            case 50:
            case 56:
            	{
                alt10 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d10s0 =
            	        new NoViableAltException("", 10, 0, input);

            	    throw nvae_d10s0;
            }

            switch (alt10) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:193:7: '++' unaryExpression
                    {
                    	Match(input,54,FOLLOW_54_in_unaryExpression944); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression946);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:194:9: '--' unaryExpression
                    {
                    	Match(input,55,FOLLOW_55_in_unaryExpression956); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpression958);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:195:9: unaryExpressionNotPlusMinus
                    {
                    	PushFollow(FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression968);
                    	unaryExpressionNotPlusMinus();
                    	state.followingStackPointer--;


                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "unaryExpression"


    // $ANTLR start "unaryExpressionNotPlusMinus"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:199:1: unaryExpressionNotPlusMinus : ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? );
    public void unaryExpressionNotPlusMinus() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:200:5: ( '!' unaryExpression | castExpression | mathAtom ( '++' | '--' )? )
            int alt12 = 3;
            switch ( input.LA(1) ) 
            {
            case 56:
            	{
                alt12 = 1;
                }
                break;
            case 34:
            	{
                int LA12_2 = input.LA(2);

                if ( (LA12_2 == IntegerAtom || LA12_2 == 34 || LA12_2 == 50) )
                {
                    alt12 = 3;
                }
                else if ( ((LA12_2 >= IntType && LA12_2 <= FloatType)) )
                {
                    alt12 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d12s2 =
                        new NoViableAltException("", 12, 2, input);

                    throw nvae_d12s2;
                }
                }
                break;
            case IntegerAtom:
            case 50:
            	{
                alt12 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d12s0 =
            	        new NoViableAltException("", 12, 0, input);

            	    throw nvae_d12s0;
            }

            switch (alt12) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:200:9: '!' unaryExpression
                    {
                    	Match(input,56,FOLLOW_56_in_unaryExpressionNotPlusMinus989); 
                    	PushFollow(FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus991);
                    	unaryExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:201:9: castExpression
                    {
                    	PushFollow(FOLLOW_castExpression_in_unaryExpressionNotPlusMinus1001);
                    	castExpression();
                    	state.followingStackPointer--;


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:203:9: mathAtom ( '++' | '--' )?
                    {
                    	PushFollow(FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus1016);
                    	mathAtom();
                    	state.followingStackPointer--;

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:203:18: ( '++' | '--' )?
                    	int alt11 = 2;
                    	int LA11_0 = input.LA(1);

                    	if ( ((LA11_0 >= 54 && LA11_0 <= 55)) )
                    	{
                    	    alt11 = 1;
                    	}
                    	switch (alt11) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:
                    	        {
                    	        	if ( (input.LA(1) >= 54 && input.LA(1) <= 55) ) 
                    	        	{
                    	        	    input.Consume();
                    	        	    state.errorRecovery = false;
                    	        	}
                    	        	else 
                    	        	{
                    	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        	    throw mse;
                    	        	}


                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "unaryExpressionNotPlusMinus"


    // $ANTLR start "castExpression"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:207:1: castExpression : '(' variableType ')' unaryExpression ;
    public void castExpression() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:208:5: ( '(' variableType ')' unaryExpression )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:208:8: '(' variableType ')' unaryExpression
            {
            	Match(input,34,FOLLOW_34_in_castExpression1049); 
            	PushFollow(FOLLOW_variableType_in_castExpression1051);
            	variableType();
            	state.followingStackPointer--;

            	Match(input,35,FOLLOW_35_in_castExpression1053); 
            	PushFollow(FOLLOW_unaryExpression_in_castExpression1055);
            	unaryExpression();
            	state.followingStackPointer--;


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "castExpression"


    // $ANTLR start "mathAtom"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:212:1: mathAtom : ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) ;
    public void mathAtom() // throws RecognitionException [1]
    {   
        CommonTree i = null;

        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:213:5: ( ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:213:9: ( '-' )? ( '(' e= additiveExpression ')' | i= IntegerAtom )
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:213:9: ( '-' )?
            	int alt13 = 2;
            	int LA13_0 = input.LA(1);

            	if ( (LA13_0 == 50) )
            	{
            	    alt13 = 1;
            	}
            	switch (alt13) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:213:10: '-'
            	        {
            	        	Match(input,50,FOLLOW_50_in_mathAtom1078); 

            	        }
            	        break;

            	}

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:214:5: ( '(' e= additiveExpression ')' | i= IntegerAtom )
            	int alt14 = 2;
            	int LA14_0 = input.LA(1);

            	if ( (LA14_0 == 34) )
            	{
            	    alt14 = 1;
            	}
            	else if ( (LA14_0 == IntegerAtom) )
            	{
            	    alt14 = 2;
            	}
            	else 
            	{
            	    NoViableAltException nvae_d14s0 =
            	        new NoViableAltException("", 14, 0, input);

            	    throw nvae_d14s0;
            	}
            	switch (alt14) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:214:7: '(' e= additiveExpression ')'
            	        {
            	        	Match(input,34,FOLLOW_34_in_mathAtom1089); 
            	        	PushFollow(FOLLOW_additiveExpression_in_mathAtom1093);
            	        	additiveExpression();
            	        	state.followingStackPointer--;

            	        	Match(input,35,FOLLOW_35_in_mathAtom1095); 

            	        }
            	        break;
            	    case 2 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:215:9: i= IntegerAtom
            	        {
            	        	i=(CommonTree)Match(input,IntegerAtom,FOLLOW_IntegerAtom_in_mathAtom1107); 

            	        }
            	        break;

            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "mathAtom"


    // $ANTLR start "arguments"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:223:1: arguments : '(' ( expressionList )? ')' ;
    public void arguments() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:224:5: ( '(' ( expressionList )? ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:224:9: '(' ( expressionList )? ')'
            {
            	Match(input,34,FOLLOW_34_in_arguments1144); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:224:13: ( expressionList )?
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == NEGATE || LA15_0 == Identifier || (LA15_0 >= IntegerAtom && LA15_0 <= BooleanAtom) || LA15_0 == 39 || (LA15_0 >= 41 && LA15_0 <= 53)) )
            	{
            	    alt15 = 1;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:224:13: expressionList
            	        {
            	        	PushFollow(FOLLOW_expressionList_in_arguments1146);
            	        	expressionList();
            	        	state.followingStackPointer--;


            	        }
            	        break;

            	}

            	Match(input,35,FOLLOW_35_in_arguments1149); 

            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "arguments"


    // $ANTLR start "expressionList"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:227:1: expressionList : expression ( ',' expression )* ;
    public void expressionList() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:228:5: ( expression ( ',' expression )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:228:9: expression ( ',' expression )*
            {
            	PushFollow(FOLLOW_expression_in_expressionList1168);
            	expression();
            	state.followingStackPointer--;

            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:228:20: ( ',' expression )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( (LA16_0 == 36) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:228:21: ',' expression
            			    {
            			    	Match(input,36,FOLLOW_36_in_expressionList1171); 
            			    	PushFollow(FOLLOW_expression_in_expressionList1173);
            			    	expression();
            			    	state.followingStackPointer--;


            			    }
            			    break;

            			default:
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "expressionList"


    // $ANTLR start "literal"
    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:233:1: literal : ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' );
    public void literal() // throws RecognitionException [1]
    {   
        try 
    	{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:234:5: ( IntegerAtom | FloatAtom | StringAtom | BooleanAtom | 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGLTreeWalker.g:
            {
            	if ( (input.LA(1) >= IntegerAtom && input.LA(1) <= BooleanAtom) || input.LA(1) == StringAtom || input.LA(1) == 58 ) 
            	{
            	    input.Consume();
            	    state.errorRecovery = false;
            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
        }
        finally 
    	{
        }
        return ;
    }
    // $ANTLR end "literal"

    // Delegated rules


	private void InitializeCyclicDFAs()
	{
	}

 

    public static readonly BitSet FOLLOW_block_in_compilationUnit60 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BLOCK_in_block95 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_STATEMENTS_in_block111 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_statement_in_block114 = new BitSet(new ulong[]{0x0000000000000088UL});
    public static readonly BitSet FOLLOW_variableDeclaration_in_statement155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_VARDEF_in_variableDeclaration186 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_variableType_in_variableDeclaration188 = new BitSet(new ulong[]{0x0000000000001000UL});
    public static readonly BitSet FOLLOW_variableName_in_variableDeclaration190 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_variableDeclaration192 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Identifier_in_variableName220 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntType_in_variableType238 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanType_in_variableType245 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_StringType_in_variableType252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatType_in_variableType259 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_49_in_expression299 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression303 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression307 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_50_in_expression316 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression320 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression324 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_51_in_expression333 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression337 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression341 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_52_in_expression350 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression354 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression358 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_53_in_expression367 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression371 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression375 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_NEGATE_in_expression383 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression387 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_45_in_expression394 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression398 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression402 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_47_in_expression409 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression413 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression417 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_46_in_expression424 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression428 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression432 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_48_in_expression439 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression443 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression447 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_44_in_expression454 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression458 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression462 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_43_in_expression469 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression473 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression477 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_42_in_expression484 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression488 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression492 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_41_in_expression499 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression503 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression507 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_39_in_expression514 = new BitSet(new ulong[]{0x0000000000000004UL});
    public static readonly BitSet FOLLOW_expression_in_expression518 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression522 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expression526 = new BitSet(new ulong[]{0x0000000000000008UL});
    public static readonly BitSet FOLLOW_Identifier_in_expression532 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_expression539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FloatAtom_in_expression546 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BooleanAtom_in_expression555 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalOrExpression_in_conditionalExpression599 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_39_in_conditionalExpression601 = new BitSet(new ulong[]{0x0004000400040000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression603 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_40_in_conditionalExpression605 = new BitSet(new ulong[]{0x0004000400040000UL});
    public static readonly BitSet FOLLOW_conditionalExpression_in_conditionalExpression606 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression646 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_41_in_conditionalOrExpression650 = new BitSet(new ulong[]{0x0004000400040000UL});
    public static readonly BitSet FOLLOW_conditionalAndExpression_in_conditionalOrExpression652 = new BitSet(new ulong[]{0x0000020000000002UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression683 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_42_in_conditionalAndExpression687 = new BitSet(new ulong[]{0x0004000400040000UL});
    public static readonly BitSet FOLLOW_equalityExpression_in_conditionalAndExpression689 = new BitSet(new ulong[]{0x0000040000000002UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression716 = new BitSet(new ulong[]{0x0000180000000002UL});
    public static readonly BitSet FOLLOW_set_in_equalityExpression720 = new BitSet(new ulong[]{0x0004000400040000UL});
    public static readonly BitSet FOLLOW_relationalExpression_in_equalityExpression728 = new BitSet(new ulong[]{0x0000180000000002UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression759 = new BitSet(new ulong[]{0x0001E00000000002UL});
    public static readonly BitSet FOLLOW_set_in_relationalExpression763 = new BitSet(new ulong[]{0x0004000400040000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_relationalExpression773 = new BitSet(new ulong[]{0x0001E00000000002UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression814 = new BitSet(new ulong[]{0x0006000000000002UL});
    public static readonly BitSet FOLLOW_49_in_additiveExpression822 = new BitSet(new ulong[]{0x0004000400040000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression826 = new BitSet(new ulong[]{0x0006000000000002UL});
    public static readonly BitSet FOLLOW_50_in_additiveExpression835 = new BitSet(new ulong[]{0x0004000400040000UL});
    public static readonly BitSet FOLLOW_multiplicativeExpression_in_additiveExpression839 = new BitSet(new ulong[]{0x0006000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression880 = new BitSet(new ulong[]{0x0038000000000002UL});
    public static readonly BitSet FOLLOW_51_in_multiplicativeExpression888 = new BitSet(new ulong[]{0x0004000400040000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression892 = new BitSet(new ulong[]{0x0038000000000002UL});
    public static readonly BitSet FOLLOW_52_in_multiplicativeExpression900 = new BitSet(new ulong[]{0x0004000400040000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression904 = new BitSet(new ulong[]{0x0038000000000002UL});
    public static readonly BitSet FOLLOW_53_in_multiplicativeExpression912 = new BitSet(new ulong[]{0x0004000400040000UL});
    public static readonly BitSet FOLLOW_mathAtom_in_multiplicativeExpression916 = new BitSet(new ulong[]{0x0038000000000002UL});
    public static readonly BitSet FOLLOW_54_in_unaryExpression944 = new BitSet(new ulong[]{0x01C4000400040000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression946 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_55_in_unaryExpression956 = new BitSet(new ulong[]{0x01C4000400040000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpression958 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_unaryExpressionNotPlusMinus_in_unaryExpression968 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_56_in_unaryExpressionNotPlusMinus989 = new BitSet(new ulong[]{0x01C4000400040000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_unaryExpressionNotPlusMinus991 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_castExpression_in_unaryExpressionNotPlusMinus1001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_mathAtom_in_unaryExpressionNotPlusMinus1016 = new BitSet(new ulong[]{0x00C0000000000002UL});
    public static readonly BitSet FOLLOW_set_in_unaryExpressionNotPlusMinus1018 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_castExpression1049 = new BitSet(new ulong[]{0x000000000001E000UL});
    public static readonly BitSet FOLLOW_variableType_in_castExpression1051 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_castExpression1053 = new BitSet(new ulong[]{0x01C4000400040000UL});
    public static readonly BitSet FOLLOW_unaryExpression_in_castExpression1055 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_50_in_mathAtom1078 = new BitSet(new ulong[]{0x0000000400040000UL});
    public static readonly BitSet FOLLOW_34_in_mathAtom1089 = new BitSet(new ulong[]{0x0004000400040000UL});
    public static readonly BitSet FOLLOW_additiveExpression_in_mathAtom1093 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_mathAtom1095 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IntegerAtom_in_mathAtom1107 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_34_in_arguments1144 = new BitSet(new ulong[]{0x003FFE88001C1200UL});
    public static readonly BitSet FOLLOW_expressionList_in_arguments1146 = new BitSet(new ulong[]{0x0000000800000000UL});
    public static readonly BitSet FOLLOW_35_in_arguments1149 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1168 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_36_in_expressionList1171 = new BitSet(new ulong[]{0x003FFE80001C1200UL});
    public static readonly BitSet FOLLOW_expression_in_expressionList1173 = new BitSet(new ulong[]{0x0000001000000002UL});
    public static readonly BitSet FOLLOW_set_in_literal0 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}