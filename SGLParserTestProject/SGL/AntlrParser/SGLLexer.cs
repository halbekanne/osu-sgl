// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g 2011-09-17 14:22:14

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


// -------------------------------------------------------------------------------------------------
//                This is a generated file, please don't change anything in here!
// -------------------------------------------------------------------------------------------------


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


namespace  SGL.AntlrParser 
{
public partial class SGLLexer : Lexer {
    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int OBJMETHOD = 14;
    public const int T__63 = 63;
    public const int Origin = 39;
    public const int Sprite = 36;
    public const int SGLIDDigit = 43;
    public const int PARAM_NAME_LIST = 24;
    public const int IntType = 28;
    public const int T__61 = 61;
    public const int ID_LIST = 9;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int BREAK = 22;
    public const int Identifier = 27;
    public const int IF = 7;
    public const int T__55 = 55;
    public const int AT = 6;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int Animation = 37;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int EXP = 8;
    public const int FORITER = 18;
    public const int StringType = 30;
    public const int T__59 = 59;
    public const int RETURN = 26;
    public const int COMMENT = 48;
    public const int STRINGNOQUOTES = 19;
    public const int VARDEF = 10;
    public const int T__50 = 50;
    public const int GLOBVARDEF = 11;
    public const int VARDEC = 21;
    public const int BooleanType = 29;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int T__49 = 49;
    public const int IntegerAtom = 33;
    public const int FORDEC = 16;
    public const int FloatType = 31;
    public const int PARAM_TYPE_LIST = 23;
    public const int StringAtom = 40;
    public const int METH_CALL = 25;
    public const int NEGATE = 13;
    public const int HEX_DIGIT = 46;
    public const int T__85 = 85;
    public const int T__84 = 84;
    public const int BooleanAtom = 35;
    public const int T__71 = 71;
    public const int FORCOND = 17;
    public const int WS = 47;
    public const int T__72 = 72;
    public const int T__70 = 70;
    public const int UnicodeEscape = 44;
    public const int BLOCK = 4;
    public const int ASSIGN = 12;
    public const int Layer = 38;
    public const int STATEMENTS = 5;
    public const int ObjectType = 32;
    public const int T__76 = 76;
    public const int FloatAtom = 34;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int VARINC = 20;
    public const int T__73 = 73;
    public const int EscapeSequence = 41;
    public const int Letter = 42;
    public const int OctalEscape = 45;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int STRING = 15;
    public const int T__77 = 77;

    // delegates
    // delegators

    public SGLLexer() 
    {
		InitializeCyclicDFAs();
    }
    public SGLLexer(ICharStream input)
		: this(input, null) {
    }
    public SGLLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state) {
		InitializeCyclicDFAs(); 

    }
    
    override public string GrammarFileName
    {
    	get { return "C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g";} 
    }

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:14:7: ( '{' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:14:9: '{'
            {
            	Match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:15:7: ( '}' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:15:9: '}'
            {
            	Match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:16:7: ( 'method' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:16:9: 'method'
            {
            	Match("method"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:17:7: ( '(' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:17:9: '('
            {
            	Match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:18:7: ( ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:18:9: ')'
            {
            	Match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:19:7: ( 'void' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:19:9: 'void'
            {
            	Match("void"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:20:7: ( ';' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:20:9: ';'
            {
            	Match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:21:7: ( ',' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:21:9: ','
            {
            	Match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:22:7: ( 'global' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:22:9: 'global'
            {
            	Match("global"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:23:7: ( '=' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:23:9: '='
            {
            	Match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:24:7: ( '.' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:24:9: '.'
            {
            	Match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:25:7: ( 'while' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:25:9: 'while'
            {
            	Match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:26:7: ( 'for' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:26:9: 'for'
            {
            	Match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:27:7: ( 'if' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:27:9: 'if'
            {
            	Match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:28:7: ( 'else' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:28:9: 'else'
            {
            	Match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:29:7: ( 'at' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:29:9: 'at'
            {
            	Match("at"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:30:7: ( 'break' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:30:9: 'break'
            {
            	Match("break"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:31:7: ( 'return' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:31:9: 'return'
            {
            	Match("return"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:32:7: ( '?' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:32:9: '?'
            {
            	Match('?'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:33:7: ( ':' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:33:9: ':'
            {
            	Match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:34:7: ( '||' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:34:9: '||'
            {
            	Match("||"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:35:7: ( '&&' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:35:9: '&&'
            {
            	Match("&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:36:7: ( '==' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:36:9: '=='
            {
            	Match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:37:7: ( '!=' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:37:9: '!='
            {
            	Match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:38:7: ( '<' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:38:9: '<'
            {
            	Match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:39:7: ( '>' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:39:9: '>'
            {
            	Match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:40:7: ( '<=' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:40:9: '<='
            {
            	Match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:41:7: ( '>=' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:41:9: '>='
            {
            	Match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public void mT__77() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__77;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:42:7: ( '+' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:42:9: '+'
            {
            	Match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public void mT__78() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__78;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:43:7: ( '-' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:43:9: '-'
            {
            	Match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__78"

    // $ANTLR start "T__79"
    public void mT__79() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__79;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:44:7: ( '*' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:44:9: '*'
            {
            	Match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__79"

    // $ANTLR start "T__80"
    public void mT__80() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__80;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:45:7: ( '/' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:45:9: '/'
            {
            	Match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__80"

    // $ANTLR start "T__81"
    public void mT__81() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__81;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:46:7: ( '%' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:46:9: '%'
            {
            	Match('%'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__81"

    // $ANTLR start "T__82"
    public void mT__82() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__82;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:47:7: ( '++' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:47:9: '++'
            {
            	Match("++"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__82"

    // $ANTLR start "T__83"
    public void mT__83() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__83;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:48:7: ( '--' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:48:9: '--'
            {
            	Match("--"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__83"

    // $ANTLR start "T__84"
    public void mT__84() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__84;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:49:7: ( 'new' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:49:9: 'new'
            {
            	Match("new"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__84"

    // $ANTLR start "T__85"
    public void mT__85() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__85;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:50:7: ( 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:50:9: 'null'
            {
            	Match("null"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "T__85"

    // $ANTLR start "IntegerAtom"
    public void mIntegerAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IntegerAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:438:5: ( ( '0' .. '9' )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:438:7: ( '0' .. '9' )+
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:438:7: ( '0' .. '9' )+
            	int cnt1 = 0;
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( ((LA1_0 >= '0' && LA1_0 <= '9')) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:438:7: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt1 >= 1 ) goto loop1;
            		            EarlyExitException eee1 =
            		                new EarlyExitException(1, input);
            		            throw eee1;
            	    }
            	    cnt1++;
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IntegerAtom"

    // $ANTLR start "FloatAtom"
    public void mFloatAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FloatAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:442:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ )
            int alt6 = 3;
            alt6 = dfa6.Predict(input);
            switch (alt6) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:442:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:442:9: ( '0' .. '9' )+
                    	int cnt2 = 0;
                    	do 
                    	{
                    	    int alt2 = 2;
                    	    int LA2_0 = input.LA(1);

                    	    if ( ((LA2_0 >= '0' && LA2_0 <= '9')) )
                    	    {
                    	        alt2 = 1;
                    	    }


                    	    switch (alt2) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:442:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt2 >= 1 ) goto loop2;
                    		            EarlyExitException eee2 =
                    		                new EarlyExitException(2, input);
                    		            throw eee2;
                    	    }
                    	    cnt2++;
                    	} while (true);

                    	loop2:
                    		;	// Stops C# compiler whining that label 'loop2' has no statements

                    	Match('.'); 
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:442:25: ( '0' .. '9' )*
                    	do 
                    	{
                    	    int alt3 = 2;
                    	    int LA3_0 = input.LA(1);

                    	    if ( ((LA3_0 >= '0' && LA3_0 <= '9')) )
                    	    {
                    	        alt3 = 1;
                    	    }


                    	    switch (alt3) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:442:26: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop3;
                    	    }
                    	} while (true);

                    	loop3:
                    		;	// Stops C# compiler whining that label 'loop3' has no statements


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:443:9: '.' ( '0' .. '9' )+
                    {
                    	Match('.'); 
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:443:13: ( '0' .. '9' )+
                    	int cnt4 = 0;
                    	do 
                    	{
                    	    int alt4 = 2;
                    	    int LA4_0 = input.LA(1);

                    	    if ( ((LA4_0 >= '0' && LA4_0 <= '9')) )
                    	    {
                    	        alt4 = 1;
                    	    }


                    	    switch (alt4) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:443:14: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt4 >= 1 ) goto loop4;
                    		            EarlyExitException eee4 =
                    		                new EarlyExitException(4, input);
                    		            throw eee4;
                    	    }
                    	    cnt4++;
                    	} while (true);

                    	loop4:
                    		;	// Stops C# compiler whining that label 'loop4' has no statements


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:444:9: ( '0' .. '9' )+
                    {
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:444:9: ( '0' .. '9' )+
                    	int cnt5 = 0;
                    	do 
                    	{
                    	    int alt5 = 2;
                    	    int LA5_0 = input.LA(1);

                    	    if ( ((LA5_0 >= '0' && LA5_0 <= '9')) )
                    	    {
                    	        alt5 = 1;
                    	    }


                    	    switch (alt5) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:444:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt5 >= 1 ) goto loop5;
                    		            EarlyExitException eee5 =
                    		                new EarlyExitException(5, input);
                    		            throw eee5;
                    	    }
                    	    cnt5++;
                    	} while (true);

                    	loop5:
                    		;	// Stops C# compiler whining that label 'loop5' has no statements


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FloatAtom"

    // $ANTLR start "BooleanAtom"
    public void mBooleanAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BooleanAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:449:5: ( 'true' | 'false' )
            int alt7 = 2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0 == 't') )
            {
                alt7 = 1;
            }
            else if ( (LA7_0 == 'f') )
            {
                alt7 = 2;
            }
            else 
            {
                NoViableAltException nvae_d7s0 =
                    new NoViableAltException("", 7, 0, input);

                throw nvae_d7s0;
            }
            switch (alt7) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:449:9: 'true'
                    {
                    	Match("true"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:450:9: 'false'
                    {
                    	Match("false"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BooleanAtom"

    // $ANTLR start "StringAtom"
    public void mStringAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = StringAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:458:5: ( '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )* '\"' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:458:9: '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:458:13: ( EscapeSequence | ~ ( '\\\\' | '\"' ) )*
            	do 
            	{
            	    int alt8 = 3;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == '\\') )
            	    {
            	        alt8 = 1;
            	    }
            	    else if ( ((LA8_0 >= '\u0000' && LA8_0 <= '!') || (LA8_0 >= '#' && LA8_0 <= '[') || (LA8_0 >= ']' && LA8_0 <= '\uFFFF')) )
            	    {
            	        alt8 = 2;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:458:15: EscapeSequence
            			    {
            			    	mEscapeSequence(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:458:32: ~ ( '\\\\' | '\"' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '[') || (input.LA(1) >= ']' && input.LA(1) <= '\uFFFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;

              //Text = (Text.Substring(0, Text.Length-1).Replace("\\\\(.)", "$1"));
              //setText(getText().substring(1, getText().length()-1).replaceAll("\\\\(.)", "$1"));
        }
        finally 
    	{
        }
    }
    // $ANTLR end "StringAtom"

    // $ANTLR start "IntType"
    public void mIntType() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IntType;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:463:2: ( 'int' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:463:4: 'int'
            {
            	Match("int"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IntType"

    // $ANTLR start "BooleanType"
    public void mBooleanType() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BooleanType;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:467:2: ( 'boolean' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:467:4: 'boolean'
            {
            	Match("boolean"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "BooleanType"

    // $ANTLR start "StringType"
    public void mStringType() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = StringType;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:471:2: ( 'string' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:471:4: 'string'
            {
            	Match("string"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "StringType"

    // $ANTLR start "FloatType"
    public void mFloatType() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FloatType;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:475:2: ( 'float' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:475:4: 'float'
            {
            	Match("float"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "FloatType"

    // $ANTLR start "ObjectType"
    public void mObjectType() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ObjectType;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:481:2: ( 'Object' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:481:4: 'Object'
            {
            	Match("Object"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "ObjectType"

    // $ANTLR start "Sprite"
    public void mSprite() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Sprite;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:485:2: ( 'Sprite' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:485:4: 'Sprite'
            {
            	Match("Sprite"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Sprite"

    // $ANTLR start "Animation"
    public void mAnimation() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Animation;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:489:2: ( 'Animation' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:489:4: 'Animation'
            {
            	Match("Animation"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Animation"

    // $ANTLR start "Layer"
    public void mLayer() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Layer;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:493:2: ( 'Background' | 'Fail' | 'Pass' | 'Foreground' )
            int alt9 = 4;
            switch ( input.LA(1) ) 
            {
            case 'B':
            	{
                alt9 = 1;
                }
                break;
            case 'F':
            	{
                int LA9_2 = input.LA(2);

                if ( (LA9_2 == 'a') )
                {
                    alt9 = 2;
                }
                else if ( (LA9_2 == 'o') )
                {
                    alt9 = 4;
                }
                else 
                {
                    NoViableAltException nvae_d9s2 =
                        new NoViableAltException("", 9, 2, input);

                    throw nvae_d9s2;
                }
                }
                break;
            case 'P':
            	{
                alt9 = 3;
                }
                break;
            	default:
            	    NoViableAltException nvae_d9s0 =
            	        new NoViableAltException("", 9, 0, input);

            	    throw nvae_d9s0;
            }

            switch (alt9) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:493:4: 'Background'
                    {
                    	Match("Background"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:494:4: 'Fail'
                    {
                    	Match("Fail"); 


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:495:4: 'Pass'
                    {
                    	Match("Pass"); 


                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:496:4: 'Foreground'
                    {
                    	Match("Foreground"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Layer"

    // $ANTLR start "Origin"
    public void mOrigin() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Origin;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:500:2: ( 'TopLeft' | 'TopCentre' | 'TopRight' | 'CentreLeft' | 'Centre' | 'CentreRight' | 'BottomLeft' | 'BottomCentre' | 'BottomRight' )
            int alt10 = 9;
            alt10 = dfa10.Predict(input);
            switch (alt10) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:500:4: 'TopLeft'
                    {
                    	Match("TopLeft"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:501:4: 'TopCentre'
                    {
                    	Match("TopCentre"); 


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:502:4: 'TopRight'
                    {
                    	Match("TopRight"); 


                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:503:4: 'CentreLeft'
                    {
                    	Match("CentreLeft"); 


                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:504:4: 'Centre'
                    {
                    	Match("Centre"); 


                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:505:4: 'CentreRight'
                    {
                    	Match("CentreRight"); 


                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:506:4: 'BottomLeft'
                    {
                    	Match("BottomLeft"); 


                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:507:4: 'BottomCentre'
                    {
                    	Match("BottomCentre"); 


                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:508:4: 'BottomRight'
                    {
                    	Match("BottomRight"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Origin"

    // $ANTLR start "Identifier"
    public void mIdentifier() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Identifier;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:513:5: ( Letter ( Letter | SGLIDDigit )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:513:9: Letter ( Letter | SGLIDDigit )*
            {
            	mLetter(); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:513:16: ( Letter | SGLIDDigit )*
            	do 
            	{
            	    int alt11 = 2;
            	    int LA11_0 = input.LA(1);

            	    if ( (LA11_0 == '$' || (LA11_0 >= '0' && LA11_0 <= '9') || (LA11_0 >= 'A' && LA11_0 <= 'Z') || LA11_0 == '_' || (LA11_0 >= 'a' && LA11_0 <= 'z') || (LA11_0 >= '\u00C0' && LA11_0 <= '\u00D6') || (LA11_0 >= '\u00D8' && LA11_0 <= '\u00F6') || (LA11_0 >= '\u00F8' && LA11_0 <= '\u1FFF') || (LA11_0 >= '\u3040' && LA11_0 <= '\u318F') || (LA11_0 >= '\u3300' && LA11_0 <= '\u337F') || (LA11_0 >= '\u3400' && LA11_0 <= '\u3D2D') || (LA11_0 >= '\u4E00' && LA11_0 <= '\u9FFF') || (LA11_0 >= '\uF900' && LA11_0 <= '\uFAFF')) )
            	    {
            	        alt11 = 1;
            	    }


            	    switch (alt11) 
            		{
            			case 1 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            			    {
            			    	if ( input.LA(1) == '$' || (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u00C0' && input.LA(1) <= '\u00D6') || (input.LA(1) >= '\u00D8' && input.LA(1) <= '\u00F6') || (input.LA(1) >= '\u00F8' && input.LA(1) <= '\u1FFF') || (input.LA(1) >= '\u3040' && input.LA(1) <= '\u318F') || (input.LA(1) >= '\u3300' && input.LA(1) <= '\u337F') || (input.LA(1) >= '\u3400' && input.LA(1) <= '\u3D2D') || (input.LA(1) >= '\u4E00' && input.LA(1) <= '\u9FFF') || (input.LA(1) >= '\uF900' && input.LA(1) <= '\uFAFF') ) 
            			    	{
            			    	    input.Consume();

            			    	}
            			    	else 
            			    	{
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    Recover(mse);
            			    	    throw mse;}


            			    }
            			    break;

            			default:
            			    goto loop11;
            	    }
            	} while (true);

            	loop11:
            		;	// Stops C# compiler whining that label 'loop11' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Identifier"

    // $ANTLR start "Letter"
    public void mLetter() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:525:5: ( '\\u0024' | '\\u0041' .. '\\u005a' | '\\u005f' | '\\u0061' .. '\\u007a' | '\\u00c0' .. '\\u00d6' | '\\u00d8' .. '\\u00f6' | '\\u00f8' .. '\\u00ff' | '\\u0100' .. '\\u1fff' | '\\u3040' .. '\\u318f' | '\\u3300' .. '\\u337f' | '\\u3400' .. '\\u3d2d' | '\\u4e00' .. '\\u9fff' | '\\uf900' .. '\\ufaff' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            	if ( input.LA(1) == '$' || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u00C0' && input.LA(1) <= '\u00D6') || (input.LA(1) >= '\u00D8' && input.LA(1) <= '\u00F6') || (input.LA(1) >= '\u00F8' && input.LA(1) <= '\u1FFF') || (input.LA(1) >= '\u3040' && input.LA(1) <= '\u318F') || (input.LA(1) >= '\u3300' && input.LA(1) <= '\u337F') || (input.LA(1) >= '\u3400' && input.LA(1) <= '\u3D2D') || (input.LA(1) >= '\u4E00' && input.LA(1) <= '\u9FFF') || (input.LA(1) >= '\uF900' && input.LA(1) <= '\uFAFF') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "Letter"

    // $ANTLR start "SGLIDDigit"
    public void mSGLIDDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:542:5: ( '\\u0030' .. '\\u0039' | '\\u0660' .. '\\u0669' | '\\u06f0' .. '\\u06f9' | '\\u0966' .. '\\u096f' | '\\u09e6' .. '\\u09ef' | '\\u0a66' .. '\\u0a6f' | '\\u0ae6' .. '\\u0aef' | '\\u0b66' .. '\\u0b6f' | '\\u0be7' .. '\\u0bef' | '\\u0c66' .. '\\u0c6f' | '\\u0ce6' .. '\\u0cef' | '\\u0d66' .. '\\u0d6f' | '\\u0e50' .. '\\u0e59' | '\\u0ed0' .. '\\u0ed9' | '\\u1040' .. '\\u1049' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= '\u0660' && input.LA(1) <= '\u0669') || (input.LA(1) >= '\u06F0' && input.LA(1) <= '\u06F9') || (input.LA(1) >= '\u0966' && input.LA(1) <= '\u096F') || (input.LA(1) >= '\u09E6' && input.LA(1) <= '\u09EF') || (input.LA(1) >= '\u0A66' && input.LA(1) <= '\u0A6F') || (input.LA(1) >= '\u0AE6' && input.LA(1) <= '\u0AEF') || (input.LA(1) >= '\u0B66' && input.LA(1) <= '\u0B6F') || (input.LA(1) >= '\u0BE7' && input.LA(1) <= '\u0BEF') || (input.LA(1) >= '\u0C66' && input.LA(1) <= '\u0C6F') || (input.LA(1) >= '\u0CE6' && input.LA(1) <= '\u0CEF') || (input.LA(1) >= '\u0D66' && input.LA(1) <= '\u0D6F') || (input.LA(1) >= '\u0E50' && input.LA(1) <= '\u0E59') || (input.LA(1) >= '\u0ED0' && input.LA(1) <= '\u0ED9') || (input.LA(1) >= '\u1040' && input.LA(1) <= '\u1049') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "SGLIDDigit"

    // $ANTLR start "EscapeSequence"
    public void mEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = EscapeSequence;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:562:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) | UnicodeEscape | OctalEscape )
            int alt12 = 3;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == '\\') )
            {
                switch ( input.LA(2) ) 
                {
                case '\"':
                case '\'':
                case '\\':
                case 'b':
                case 'f':
                case 'n':
                case 'r':
                case 't':
                	{
                    alt12 = 1;
                    }
                    break;
                case 'u':
                	{
                    alt12 = 2;
                    }
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                	{
                    alt12 = 3;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d12s1 =
                	        new NoViableAltException("", 12, 1, input);

                	    throw nvae_d12s1;
                }

            }
            else 
            {
                NoViableAltException nvae_d12s0 =
                    new NoViableAltException("", 12, 0, input);

                throw nvae_d12s0;
            }
            switch (alt12) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:562:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
                    {
                    	Match('\\'); 
                    	if ( input.LA(1) == '\"' || input.LA(1) == '\'' || input.LA(1) == '\\' || input.LA(1) == 'b' || input.LA(1) == 'f' || input.LA(1) == 'n' || input.LA(1) == 'r' || input.LA(1) == 't' ) 
                    	{
                    	    input.Consume();

                    	}
                    	else 
                    	{
                    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    	    Recover(mse);
                    	    throw mse;}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:563:9: UnicodeEscape
                    {
                    	mUnicodeEscape(); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:564:9: OctalEscape
                    {
                    	mOctalEscape(); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "EscapeSequence"

    // $ANTLR start "OctalEscape"
    public void mOctalEscape() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:569:5: ( '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) )
            int alt13 = 3;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == '\\') )
            {
                int LA13_1 = input.LA(2);

                if ( ((LA13_1 >= '0' && LA13_1 <= '3')) )
                {
                    int LA13_2 = input.LA(3);

                    if ( ((LA13_2 >= '0' && LA13_2 <= '7')) )
                    {
                        int LA13_4 = input.LA(4);

                        if ( ((LA13_4 >= '0' && LA13_4 <= '7')) )
                        {
                            alt13 = 1;
                        }
                        else 
                        {
                            alt13 = 2;}
                    }
                    else 
                    {
                        alt13 = 3;}
                }
                else if ( ((LA13_1 >= '4' && LA13_1 <= '7')) )
                {
                    int LA13_3 = input.LA(3);

                    if ( ((LA13_3 >= '0' && LA13_3 <= '7')) )
                    {
                        alt13 = 2;
                    }
                    else 
                    {
                        alt13 = 3;}
                }
                else 
                {
                    NoViableAltException nvae_d13s1 =
                        new NoViableAltException("", 13, 1, input);

                    throw nvae_d13s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:569:9: '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:569:14: ( '0' .. '3' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:569:15: '0' .. '3'
                    	{
                    		MatchRange('0','3'); 

                    	}

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:569:25: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:569:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:569:36: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:569:37: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:570:9: '\\\\' ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:570:14: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:570:15: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:570:25: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:570:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:571:9: '\\\\' ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:571:14: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:571:15: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;

            }
        }
        finally 
    	{
        }
    }
    // $ANTLR end "OctalEscape"

    // $ANTLR start "UnicodeEscape"
    public void mUnicodeEscape() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:576:5: ( '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:576:9: '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
            {
            	Match('\\'); 
            	Match('u'); 
            	mHEX_DIGIT(); 
            	mHEX_DIGIT(); 
            	mHEX_DIGIT(); 
            	mHEX_DIGIT(); 

            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "UnicodeEscape"

    // $ANTLR start "HEX_DIGIT"
    public void mHEX_DIGIT() // throws RecognitionException [2]
    {
    		try
    		{
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:580:11: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:580:13: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
            {
            	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'F') || (input.LA(1) >= 'a' && input.LA(1) <= 'f') ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}


            }

        }
        finally 
    	{
        }
    }
    // $ANTLR end "HEX_DIGIT"

    // $ANTLR start "WS"
    public void mWS() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WS;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:586:5: ( ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:586:8: ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || (input.LA(1) >= '\f' && input.LA(1) <= '\r') || input.LA(1) == ' ' ) 
            	{
            	    input.Consume();

            	}
            	else 
            	{
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    Recover(mse);
            	    throw mse;}

            	_channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "COMMENT"
    public void mCOMMENT() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = COMMENT;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:591:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
            int alt17 = 2;
            int LA17_0 = input.LA(1);

            if ( (LA17_0 == '/') )
            {
                int LA17_1 = input.LA(2);

                if ( (LA17_1 == '/') )
                {
                    alt17 = 1;
                }
                else if ( (LA17_1 == '*') )
                {
                    alt17 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d17s1 =
                        new NoViableAltException("", 17, 1, input);

                    throw nvae_d17s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d17s0 =
                    new NoViableAltException("", 17, 0, input);

                throw nvae_d17s0;
            }
            switch (alt17) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:591:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match("//"); 

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:591:14: (~ ( '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt14 = 2;
                    	    int LA14_0 = input.LA(1);

                    	    if ( ((LA14_0 >= '\u0000' && LA14_0 <= '\t') || (LA14_0 >= '\u000B' && LA14_0 <= '\f') || (LA14_0 >= '\u000E' && LA14_0 <= '\uFFFF')) )
                    	    {
                    	        alt14 = 1;
                    	    }


                    	    switch (alt14) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:591:14: ~ ( '\\n' | '\\r' )
                    			    {
                    			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '\t') || (input.LA(1) >= '\u000B' && input.LA(1) <= '\f') || (input.LA(1) >= '\u000E' && input.LA(1) <= '\uFFFF') ) 
                    			    	{
                    			    	    input.Consume();

                    			    	}
                    			    	else 
                    			    	{
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    Recover(mse);
                    			    	    throw mse;}


                    			    }
                    			    break;

                    			default:
                    			    goto loop14;
                    	    }
                    	} while (true);

                    	loop14:
                    		;	// Stops C# compiler whining that label 'loop14' has no statements

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:591:28: ( '\\r' )?
                    	int alt15 = 2;
                    	int LA15_0 = input.LA(1);

                    	if ( (LA15_0 == '\r') )
                    	{
                    	    alt15 = 1;
                    	}
                    	switch (alt15) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:591:28: '\\r'
                    	        {
                    	        	Match('\r'); 

                    	        }
                    	        break;

                    	}

                    	Match('\n'); 
                    	_channel=HIDDEN;

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:592:9: '/*' ( options {greedy=false; } : . )* '*/'
                    {
                    	Match("/*"); 

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:592:14: ( options {greedy=false; } : . )*
                    	do 
                    	{
                    	    int alt16 = 2;
                    	    int LA16_0 = input.LA(1);

                    	    if ( (LA16_0 == '*') )
                    	    {
                    	        int LA16_1 = input.LA(2);

                    	        if ( (LA16_1 == '/') )
                    	        {
                    	            alt16 = 2;
                    	        }
                    	        else if ( ((LA16_1 >= '\u0000' && LA16_1 <= '.') || (LA16_1 >= '0' && LA16_1 <= '\uFFFF')) )
                    	        {
                    	            alt16 = 1;
                    	        }


                    	    }
                    	    else if ( ((LA16_0 >= '\u0000' && LA16_0 <= ')') || (LA16_0 >= '+' && LA16_0 <= '\uFFFF')) )
                    	    {
                    	        alt16 = 1;
                    	    }


                    	    switch (alt16) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:592:42: .
                    			    {
                    			    	MatchAny(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop16;
                    	    }
                    	} while (true);

                    	loop16:
                    		;	// Stops C# compiler whining that label 'loop16' has no statements

                    	Match("*/"); 

                    	_channel=HIDDEN;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "COMMENT"

    override public void mTokens() // throws RecognitionException 
    {
        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:8: ( T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | IntegerAtom | FloatAtom | BooleanAtom | StringAtom | IntType | BooleanType | StringType | FloatType | ObjectType | Sprite | Animation | Layer | Origin | Identifier | EscapeSequence | WS | COMMENT )
        int alt18 = 54;
        alt18 = dfa18.Predict(input);
        switch (alt18) 
        {
            case 1 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:10: T__49
                {
                	mT__49(); 

                }
                break;
            case 2 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:16: T__50
                {
                	mT__50(); 

                }
                break;
            case 3 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:22: T__51
                {
                	mT__51(); 

                }
                break;
            case 4 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:28: T__52
                {
                	mT__52(); 

                }
                break;
            case 5 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:34: T__53
                {
                	mT__53(); 

                }
                break;
            case 6 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:40: T__54
                {
                	mT__54(); 

                }
                break;
            case 7 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:46: T__55
                {
                	mT__55(); 

                }
                break;
            case 8 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:52: T__56
                {
                	mT__56(); 

                }
                break;
            case 9 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:58: T__57
                {
                	mT__57(); 

                }
                break;
            case 10 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:64: T__58
                {
                	mT__58(); 

                }
                break;
            case 11 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:70: T__59
                {
                	mT__59(); 

                }
                break;
            case 12 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:76: T__60
                {
                	mT__60(); 

                }
                break;
            case 13 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:82: T__61
                {
                	mT__61(); 

                }
                break;
            case 14 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:88: T__62
                {
                	mT__62(); 

                }
                break;
            case 15 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:94: T__63
                {
                	mT__63(); 

                }
                break;
            case 16 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:100: T__64
                {
                	mT__64(); 

                }
                break;
            case 17 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:106: T__65
                {
                	mT__65(); 

                }
                break;
            case 18 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:112: T__66
                {
                	mT__66(); 

                }
                break;
            case 19 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:118: T__67
                {
                	mT__67(); 

                }
                break;
            case 20 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:124: T__68
                {
                	mT__68(); 

                }
                break;
            case 21 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:130: T__69
                {
                	mT__69(); 

                }
                break;
            case 22 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:136: T__70
                {
                	mT__70(); 

                }
                break;
            case 23 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:142: T__71
                {
                	mT__71(); 

                }
                break;
            case 24 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:148: T__72
                {
                	mT__72(); 

                }
                break;
            case 25 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:154: T__73
                {
                	mT__73(); 

                }
                break;
            case 26 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:160: T__74
                {
                	mT__74(); 

                }
                break;
            case 27 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:166: T__75
                {
                	mT__75(); 

                }
                break;
            case 28 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:172: T__76
                {
                	mT__76(); 

                }
                break;
            case 29 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:178: T__77
                {
                	mT__77(); 

                }
                break;
            case 30 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:184: T__78
                {
                	mT__78(); 

                }
                break;
            case 31 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:190: T__79
                {
                	mT__79(); 

                }
                break;
            case 32 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:196: T__80
                {
                	mT__80(); 

                }
                break;
            case 33 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:202: T__81
                {
                	mT__81(); 

                }
                break;
            case 34 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:208: T__82
                {
                	mT__82(); 

                }
                break;
            case 35 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:214: T__83
                {
                	mT__83(); 

                }
                break;
            case 36 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:220: T__84
                {
                	mT__84(); 

                }
                break;
            case 37 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:226: T__85
                {
                	mT__85(); 

                }
                break;
            case 38 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:232: IntegerAtom
                {
                	mIntegerAtom(); 

                }
                break;
            case 39 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:244: FloatAtom
                {
                	mFloatAtom(); 

                }
                break;
            case 40 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:254: BooleanAtom
                {
                	mBooleanAtom(); 

                }
                break;
            case 41 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:266: StringAtom
                {
                	mStringAtom(); 

                }
                break;
            case 42 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:277: IntType
                {
                	mIntType(); 

                }
                break;
            case 43 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:285: BooleanType
                {
                	mBooleanType(); 

                }
                break;
            case 44 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:297: StringType
                {
                	mStringType(); 

                }
                break;
            case 45 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:308: FloatType
                {
                	mFloatType(); 

                }
                break;
            case 46 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:318: ObjectType
                {
                	mObjectType(); 

                }
                break;
            case 47 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:329: Sprite
                {
                	mSprite(); 

                }
                break;
            case 48 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:336: Animation
                {
                	mAnimation(); 

                }
                break;
            case 49 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:346: Layer
                {
                	mLayer(); 

                }
                break;
            case 50 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:352: Origin
                {
                	mOrigin(); 

                }
                break;
            case 51 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:359: Identifier
                {
                	mIdentifier(); 

                }
                break;
            case 52 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:370: EscapeSequence
                {
                	mEscapeSequence(); 

                }
                break;
            case 53 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:385: WS
                {
                	mWS(); 

                }
                break;
            case 54 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:388: COMMENT
                {
                	mCOMMENT(); 

                }
                break;

        }

    }


    protected DFA6 dfa6;
    protected DFA10 dfa10;
    protected DFA18 dfa18;
	private void InitializeCyclicDFAs()
	{
	    this.dfa6 = new DFA6(this);
	    this.dfa10 = new DFA10(this);
	    this.dfa18 = new DFA18(this);
	}

    const string DFA6_eotS =
        "\x01\uffff\x01\x03\x03\uffff";
    const string DFA6_eofS =
        "\x05\uffff";
    const string DFA6_minS =
        "\x02\x2e\x03\uffff";
    const string DFA6_maxS =
        "\x02\x39\x03\uffff";
    const string DFA6_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x01";
    const string DFA6_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA6_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x04\x01\uffff\x0a\x01",
            "",
            "",
            ""
    };

    static readonly short[] DFA6_eot = DFA.UnpackEncodedString(DFA6_eotS);
    static readonly short[] DFA6_eof = DFA.UnpackEncodedString(DFA6_eofS);
    static readonly char[] DFA6_min = DFA.UnpackEncodedStringToUnsignedChars(DFA6_minS);
    static readonly char[] DFA6_max = DFA.UnpackEncodedStringToUnsignedChars(DFA6_maxS);
    static readonly short[] DFA6_accept = DFA.UnpackEncodedString(DFA6_acceptS);
    static readonly short[] DFA6_special = DFA.UnpackEncodedString(DFA6_specialS);
    static readonly short[][] DFA6_transition = DFA.UnpackEncodedStringArray(DFA6_transitionS);

    protected class DFA6 : DFA
    {
        public DFA6(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 6;
            this.eot = DFA6_eot;
            this.eof = DFA6_eof;
            this.min = DFA6_min;
            this.max = DFA6_max;
            this.accept = DFA6_accept;
            this.special = DFA6_special;
            this.transition = DFA6_transition;

        }

        override public string Description
        {
            get { return "441:1: FloatAtom : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ );"; }
        }

    }

    const string DFA10_eotS =
        "\x11\uffff\x01\x15\x07\uffff";
    const string DFA10_eofS =
        "\x19\uffff";
    const string DFA10_minS =
        "\x01\x42\x01\x6f\x01\x65\x01\x6f\x01\x70\x01\x6e\x01\x74\x01\x43"+
        "\x02\x74\x03\uffff\x01\x72\x01\x6f\x01\x65\x01\x6d\x01\x4c\x01\x43"+
        "\x06\uffff";
    const string DFA10_maxS =
        "\x01\x54\x01\x6f\x01\x65\x01\x6f\x01\x70\x01\x6e\x01\x74\x01\x52"+
        "\x02\x74\x03\uffff\x01\x72\x01\x6f\x01\x65\x01\x6d\x02\x52\x06\uffff";
    const string DFA10_acceptS =
        "\x0a\uffff\x01\x01\x01\x02\x01\x03\x06\uffff\x01\x04\x01\x06\x01"+
        "\x05\x01\x07\x01\x08\x01\x09";
    const string DFA10_specialS =
        "\x19\uffff}>";
    static readonly string[] DFA10_transitionS = {
            "\x01\x03\x01\x02\x10\uffff\x01\x01",
            "\x01\x04",
            "\x01\x05",
            "\x01\x06",
            "\x01\x07",
            "\x01\x08",
            "\x01\x09",
            "\x01\x0b\x08\uffff\x01\x0a\x05\uffff\x01\x0c",
            "\x01\x0d",
            "\x01\x0e",
            "",
            "",
            "",
            "\x01\x0f",
            "\x01\x10",
            "\x01\x11",
            "\x01\x12",
            "\x01\x13\x05\uffff\x01\x14",
            "\x01\x17\x08\uffff\x01\x16\x05\uffff\x01\x18",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
    static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
    static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
    static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
    static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
    static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
    static readonly short[][] DFA10_transition = DFA.UnpackEncodedStringArray(DFA10_transitionS);

    protected class DFA10 : DFA
    {
        public DFA10(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 10;
            this.eot = DFA10_eot;
            this.eof = DFA10_eof;
            this.min = DFA10_min;
            this.max = DFA10_max;
            this.accept = DFA10_accept;
            this.special = DFA10_special;
            this.transition = DFA10_transition;

        }

        override public string Description
        {
            get { return "499:1: Origin : ( 'TopLeft' | 'TopCentre' | 'TopRight' | 'CentreLeft' | 'Centre' | 'CentreRight' | 'BottomLeft' | 'BottomCentre' | 'BottomRight' );"; }
        }

    }

    const string DFA18_eotS =
        "\x03\uffff\x01\x2c\x02\uffff\x01\x2c\x02\uffff\x01\x2c\x01\x33"+
        "\x01\x35\x07\x2c\x05\uffff\x01\x42\x01\x44\x01\x46\x01\x48\x01\uffff"+
        "\x01\x4a\x01\uffff\x01\x2c\x01\x4d\x01\x2c\x01\uffff\x09\x2c\x03"+
        "\uffff\x03\x2c\x04\uffff\x04\x2c\x01\x61\x02\x2c\x01\x64\x03\x2c"+
        "\x0a\uffff\x02\x2c\x01\uffff\x10\x2c\x01\x7a\x02\x2c\x01\uffff\x01"+
        "\x7d\x01\x2c\x01\uffff\x03\x2c\x01\u0082\x0e\x2c\x01\u0093\x02\x2c"+
        "\x01\uffff\x02\x2c\x01\uffff\x01\u0098\x03\x2c\x01\uffff\x01\u009c"+
        "\x01\u009d\x06\x2c\x01\u00a4\x01\x2c\x01\u00a4\x05\x2c\x01\uffff"+
        "\x01\x2c\x01\u00ac\x01\u009d\x01\u00ad\x01\uffff\x01\u00ae\x02\x2c"+
        "\x02\uffff\x06\x2c\x01\uffff\x05\x2c\x01\u00bc\x01\u00bd\x03\uffff"+
        "\x01\x2c\x01\u00bf\x01\u00c0\x01\u00c1\x01\u00c2\x07\x2c\x01\u00ce"+
        "\x02\uffff\x01\u00cf\x04\uffff\x06\x2c\x01\u00ce\x04\x2c\x02\uffff"+
        "\x07\x2c\x01\u00ce\x02\x2c\x01\u00e3\x05\x2c\x01\u00ce\x02\x2c\x01"+
        "\uffff\x01\u00a4\x01\u00ce\x02\x2c\x01\u00a4\x01\u00ce\x02\x2c\x03"+
        "\u00ce";
    const string DFA18_eofS =
        "\u00ef\uffff";
    const string DFA18_minS =
        "\x01\x09\x02\uffff\x01\x65\x02\uffff\x01\x6f\x02\uffff\x01\x6c"+
        "\x01\x3d\x01\x30\x01\x68\x01\x61\x01\x66\x01\x6c\x01\x74\x01\x6f"+
        "\x01\x65\x05\uffff\x02\x3d\x01\x2b\x01\x2d\x01\uffff\x01\x2a\x01"+
        "\uffff\x01\x65\x01\x2e\x01\x72\x01\uffff\x01\x74\x01\x62\x01\x70"+
        "\x01\x6e\x03\x61\x01\x6f\x01\x65\x03\uffff\x01\x74\x01\x69\x01\x6f"+
        "\x04\uffff\x01\x69\x01\x72\x01\x6c\x01\x6f\x01\x24\x01\x74\x01\x73"+
        "\x01\x24\x01\x65\x01\x6f\x01\x74\x0a\uffff\x01\x77\x01\x6c\x01\uffff"+
        "\x01\x75\x01\x72\x01\x6a\x01\x72\x01\x69\x01\x63\x01\x74\x01\x69"+
        "\x01\x72\x01\x73\x01\x70\x01\x6e\x01\x68\x01\x64\x01\x62\x01\x6c"+
        "\x01\x24\x01\x73\x01\x61\x01\uffff\x01\x24\x01\x65\x01\uffff\x01"+
        "\x61\x01\x6c\x01\x75\x01\x24\x01\x6c\x01\x65\x01\x69\x01\x65\x01"+
        "\x69\x01\x6d\x01\x6b\x01\x74\x01\x6c\x01\x65\x01\x73\x01\x43\x01"+
        "\x74\x01\x6f\x01\x24\x01\x61\x01\x65\x01\uffff\x01\x65\x01\x74\x01"+
        "\uffff\x01\x24\x01\x6b\x01\x65\x01\x72\x01\uffff\x02\x24\x01\x6e"+
        "\x01\x63\x01\x74\x01\x61\x01\x67\x01\x6f\x01\x24\x01\x67\x01\x24"+
        "\x02\x65\x01\x69\x01\x72\x01\x64\x01\uffff\x01\x6c\x03\x24\x01\uffff"+
        "\x01\x24\x01\x61\x01\x6e\x02\uffff\x01\x67\x01\x74\x01\x65\x01\x74"+
        "\x01\x72\x01\x6d\x01\uffff\x01\x72\x01\x66\x01\x6e\x01\x67\x01\x65"+
        "\x02\x24\x03\uffff\x01\x6e\x04\x24\x01\x69\x01\x6f\x01\x43\x01\x6f"+
        "\x02\x74\x01\x68\x01\x24\x02\uffff\x01\x24\x04\uffff\x01\x6f\x01"+
        "\x75\x02\x65\x01\x69\x01\x75\x01\x24\x01\x72\x01\x74\x01\x65\x01"+
        "\x69\x02\uffff\x02\x6e\x01\x66\x01\x6e\x01\x67\x01\x6e\x01\x65\x01"+
        "\x24\x01\x66\x01\x67\x01\x24\x01\x64\x02\x74\x01\x68\x01\x64\x01"+
        "\x24\x01\x74\x01\x68\x01\uffff\x02\x24\x01\x72\x01\x74\x02\x24\x01"+
        "\x74\x01\x65\x03\x24";
    const string DFA18_maxS =
        "\x01\ufaff\x02\uffff\x01\x65\x02\uffff\x01\x6f\x02\uffff\x01\x6c"+
        "\x01\x3d\x01\x39\x01\x68\x01\x6f\x01\x6e\x01\x6c\x01\x74\x01\x72"+
        "\x01\x65\x05\uffff\x02\x3d\x01\x2b\x01\x2d\x01\uffff\x01\x2f\x01"+
        "\uffff\x01\x75\x01\x39\x01\x72\x01\uffff\x01\x74\x01\x62\x01\x70"+
        "\x01\x6e\x02\x6f\x01\x61\x01\x6f\x01\x65\x03\uffff\x01\x74\x01\x69"+
        "\x01\x6f\x04\uffff\x01\x69\x01\x72\x01\x6c\x01\x6f\x01\ufaff\x01"+
        "\x74\x01\x73\x01\ufaff\x01\x65\x01\x6f\x01\x74\x0a\uffff\x01\x77"+
        "\x01\x6c\x01\uffff\x01\x75\x01\x72\x01\x6a\x01\x72\x01\x69\x01\x63"+
        "\x01\x74\x01\x69\x01\x72\x01\x73\x01\x70\x01\x6e\x01\x68\x01\x64"+
        "\x01\x62\x01\x6c\x01\ufaff\x01\x73\x01\x61\x01\uffff\x01\ufaff\x01"+
        "\x65\x01\uffff\x01\x61\x01\x6c\x01\x75\x01\ufaff\x01\x6c\x01\x65"+
        "\x01\x69\x01\x65\x01\x69\x01\x6d\x01\x6b\x01\x74\x01\x6c\x01\x65"+
        "\x01\x73\x01\x52\x01\x74\x01\x6f\x01\ufaff\x01\x61\x01\x65\x01\uffff"+
        "\x01\x65\x01\x74\x01\uffff\x01\ufaff\x01\x6b\x01\x65\x01\x72\x01"+
        "\uffff\x02\ufaff\x01\x6e\x01\x63\x01\x74\x01\x61\x01\x67\x01\x6f"+
        "\x01\ufaff\x01\x67\x01\ufaff\x02\x65\x01\x69\x01\x72\x01\x64\x01"+
        "\uffff\x01\x6c\x03\ufaff\x01\uffff\x01\ufaff\x01\x61\x01\x6e\x02"+
        "\uffff\x01\x67\x01\x74\x01\x65\x01\x74\x01\x72\x01\x6d\x01\uffff"+
        "\x01\x72\x01\x66\x01\x6e\x01\x67\x01\x65\x02\ufaff\x03\uffff\x01"+
        "\x6e\x04\ufaff\x01\x69\x01\x6f\x01\x52\x01\x6f\x02\x74\x01\x68\x01"+
        "\ufaff\x02\uffff\x01\ufaff\x04\uffff\x01\x6f\x01\x75\x02\x65\x01"+
        "\x69\x01\x75\x01\ufaff\x01\x72\x01\x74\x01\x65\x01\x69\x02\uffff"+
        "\x02\x6e\x01\x66\x01\x6e\x01\x67\x01\x6e\x01\x65\x01\ufaff\x01\x66"+
        "\x01\x67\x01\ufaff\x01\x64\x02\x74\x01\x68\x01\x64\x01\ufaff\x01"+
        "\x74\x01\x68\x01\uffff\x02\ufaff\x01\x72\x01\x74\x02\ufaff\x01\x74"+
        "\x01\x65\x03\ufaff";
    const string DFA18_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\uffff\x01\x04\x01\x05\x01\uffff"+
        "\x01\x07\x01\x08\x0a\uffff\x01\x13\x01\x14\x01\x15\x01\x16\x01\x18"+
        "\x04\uffff\x01\x1f\x01\uffff\x01\x21\x03\uffff\x01\x29\x09\uffff"+
        "\x01\x33\x01\x34\x01\x35\x03\uffff\x01\x17\x01\x0a\x01\x27\x01\x0b"+
        "\x0b\uffff\x01\x1b\x01\x19\x01\x1c\x01\x1a\x01\x22\x01\x1d\x01\x23"+
        "\x01\x1e\x01\x36\x01\x20\x02\uffff\x01\x26\x13\uffff\x01\x0e\x02"+
        "\uffff\x01\x10\x15\uffff\x01\x0d\x02\uffff\x01\x2a\x04\uffff\x01"+
        "\x24\x10\uffff\x01\x06\x04\uffff\x01\x0f\x03\uffff\x01\x25\x01\x28"+
        "\x06\uffff\x01\x31\x07\uffff\x01\x0c\x01\x2d\x01\x11\x0d\uffff\x01"+
        "\x03\x01\x09\x01\uffff\x01\x12\x01\x2c\x01\x2e\x01\x2f\x0b\uffff"+
        "\x01\x32\x01\x2b\x13\uffff\x01\x30\x0b\uffff";
    const string DFA18_specialS =
        "\u00ef\uffff}>";
    static readonly string[] DFA18_transitionS = {
            "\x02\x2e\x01\uffff\x02\x2e\x12\uffff\x01\x2e\x01\x17\x01\x22"+
            "\x01\uffff\x01\x2c\x01\x1e\x01\x16\x01\uffff\x01\x04\x01\x05"+
            "\x01\x1c\x01\x1a\x01\x08\x01\x1b\x01\x0b\x01\x1d\x0a\x20\x01"+
            "\x14\x01\x07\x01\x18\x01\x0a\x01\x19\x01\x13\x01\uffff\x01\x26"+
            "\x01\x27\x01\x2b\x02\x2c\x01\x28\x08\x2c\x01\x24\x01\x29\x02"+
            "\x2c\x01\x25\x01\x2a\x06\x2c\x01\uffff\x01\x2d\x02\uffff\x01"+
            "\x2c\x01\uffff\x01\x10\x01\x11\x02\x2c\x01\x0f\x01\x0d\x01\x09"+
            "\x01\x2c\x01\x0e\x03\x2c\x01\x03\x01\x1f\x03\x2c\x01\x12\x01"+
            "\x23\x01\x21\x01\x2c\x01\x06\x01\x0c\x03\x2c\x01\x01\x01\x15"+
            "\x01\x02\x42\uffff\x17\x2c\x01\uffff\x1f\x2c\x01\uffff\u1f08"+
            "\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c\u0080\uffff"+
            "\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200\x2c",
            "",
            "",
            "\x01\x2f",
            "",
            "",
            "\x01\x30",
            "",
            "",
            "\x01\x31",
            "\x01\x32",
            "\x0a\x34",
            "\x01\x36",
            "\x01\x38\x0a\uffff\x01\x39\x02\uffff\x01\x37",
            "\x01\x3a\x07\uffff\x01\x3b",
            "\x01\x3c",
            "\x01\x3d",
            "\x01\x3f\x02\uffff\x01\x3e",
            "\x01\x40",
            "",
            "",
            "",
            "",
            "",
            "\x01\x41",
            "\x01\x43",
            "\x01\x45",
            "\x01\x47",
            "",
            "\x01\x49\x04\uffff\x01\x49",
            "",
            "\x01\x4b\x0f\uffff\x01\x4c",
            "\x01\x34\x01\uffff\x0a\x20",
            "\x01\x4e",
            "",
            "\x01\x4f",
            "\x01\x50",
            "\x01\x51",
            "\x01\x52",
            "\x01\x53\x0d\uffff\x01\x54",
            "\x01\x55\x0d\uffff\x01\x56",
            "\x01\x57",
            "\x01\x58",
            "\x01\x59",
            "",
            "",
            "",
            "\x01\x5a",
            "\x01\x5b",
            "\x01\x5c",
            "",
            "",
            "",
            "",
            "\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
            "\x01\x60",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x62",
            "\x01\x63",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x01\x68",
            "\x01\x69",
            "",
            "\x01\x6a",
            "\x01\x6b",
            "\x01\x6c",
            "\x01\x6d",
            "\x01\x6e",
            "\x01\x6f",
            "\x01\x70",
            "\x01\x71",
            "\x01\x72",
            "\x01\x73",
            "\x01\x74",
            "\x01\x75",
            "\x01\x76",
            "\x01\x77",
            "\x01\x78",
            "\x01\x79",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x7b",
            "\x01\x7c",
            "",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x7e",
            "",
            "\x01\x7f",
            "\x01\u0080",
            "\x01\u0081",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0083",
            "\x01\u0084",
            "\x01\u0085",
            "\x01\u0086",
            "\x01\u0087",
            "\x01\u0088",
            "\x01\u0089",
            "\x01\u008a",
            "\x01\u008b",
            "\x01\u008c",
            "\x01\u008d",
            "\x01\u008f\x08\uffff\x01\u008e\x05\uffff\x01\u0090",
            "\x01\u0091",
            "\x01\u0092",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0094",
            "\x01\u0095",
            "",
            "\x01\u0096",
            "\x01\u0097",
            "",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u0099",
            "\x01\u009a",
            "\x01\u009b",
            "",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u009e",
            "\x01\u009f",
            "\x01\u00a0",
            "\x01\u00a1",
            "\x01\u00a2",
            "\x01\u00a3",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00a5",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00a6",
            "\x01\u00a7",
            "\x01\u00a8",
            "\x01\u00a9",
            "\x01\u00aa",
            "",
            "\x01\u00ab",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00af",
            "\x01\u00b0",
            "",
            "",
            "\x01\u00b1",
            "\x01\u00b2",
            "\x01\u00b3",
            "\x01\u00b4",
            "\x01\u00b5",
            "\x01\u00b6",
            "",
            "\x01\u00b7",
            "\x01\u00b8",
            "\x01\u00b9",
            "\x01\u00ba",
            "\x01\u00bb",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "",
            "",
            "\x01\u00be",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00c3",
            "\x01\u00c4",
            "\x01\u00c6\x08\uffff\x01\u00c5\x05\uffff\x01\u00c7",
            "\x01\u00c8",
            "\x01\u00c9",
            "\x01\u00ca",
            "\x01\u00cb",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x0b\x2c\x01\u00cc\x05"+
            "\x2c\x01\u00cd\x08\x2c\x04\uffff\x01\x2c\x01\uffff\x1a\x2c\x45"+
            "\uffff\x17\x2c\x01\uffff\x1f\x2c\x01\uffff\u1f08\x2c\u1040\uffff"+
            "\u0150\x2c\u0170\uffff\u0080\x2c\u0080\uffff\u092e\x2c\u10d2"+
            "\uffff\u5200\x2c\u5900\uffff\u0200\x2c",
            "",
            "",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "",
            "",
            "",
            "",
            "\x01\u00d0",
            "\x01\u00d1",
            "\x01\u00d2",
            "\x01\u00d3",
            "\x01\u00d4",
            "\x01\u00d5",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00d6",
            "\x01\u00d7",
            "\x01\u00d8",
            "\x01\u00d9",
            "",
            "",
            "\x01\u00da",
            "\x01\u00db",
            "\x01\u00dc",
            "\x01\u00dd",
            "\x01\u00de",
            "\x01\u00df",
            "\x01\u00e0",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00e1",
            "\x01\u00e2",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00e4",
            "\x01\u00e5",
            "\x01\u00e6",
            "\x01\u00e7",
            "\x01\u00e8",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00e9",
            "\x01\u00ea",
            "",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00eb",
            "\x01\u00ec",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\u00ed",
            "\x01\u00ee",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c",
            "\x01\x2c\x0b\uffff\x0a\x2c\x07\uffff\x1a\x2c\x04\uffff\x01"+
            "\x2c\x01\uffff\x1a\x2c\x45\uffff\x17\x2c\x01\uffff\x1f\x2c\x01"+
            "\uffff\u1f08\x2c\u1040\uffff\u0150\x2c\u0170\uffff\u0080\x2c"+
            "\u0080\uffff\u092e\x2c\u10d2\uffff\u5200\x2c\u5900\uffff\u0200"+
            "\x2c"
    };

    static readonly short[] DFA18_eot = DFA.UnpackEncodedString(DFA18_eotS);
    static readonly short[] DFA18_eof = DFA.UnpackEncodedString(DFA18_eofS);
    static readonly char[] DFA18_min = DFA.UnpackEncodedStringToUnsignedChars(DFA18_minS);
    static readonly char[] DFA18_max = DFA.UnpackEncodedStringToUnsignedChars(DFA18_maxS);
    static readonly short[] DFA18_accept = DFA.UnpackEncodedString(DFA18_acceptS);
    static readonly short[] DFA18_special = DFA.UnpackEncodedString(DFA18_specialS);
    static readonly short[][] DFA18_transition = DFA.UnpackEncodedStringArray(DFA18_transitionS);

    protected class DFA18 : DFA
    {
        public DFA18(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 18;
            this.eot = DFA18_eot;
            this.eof = DFA18_eof;
            this.min = DFA18_min;
            this.max = DFA18_max;
            this.accept = DFA18_accept;
            this.special = DFA18_special;
            this.transition = DFA18_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | IntegerAtom | FloatAtom | BooleanAtom | StringAtom | IntType | BooleanType | StringType | FloatType | ObjectType | Sprite | Animation | Layer | Origin | Identifier | EscapeSequence | WS | COMMENT );"; }
        }

    }

 
    
}
}