// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g 2011-08-25 18:21:45

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;


public partial class SGLLexer : Lexer {
    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int T__62 = 62;
    public const int OBJMETHOD = 13;
    public const int T__63 = 63;
    public const int SGLIDDigit = 31;
    public const int IntType = 19;
    public const int ID_LIST = 8;
    public const int T__61 = 61;
    public const int T__60 = 60;
    public const int EOF = -1;
    public const int Identifier = 18;
    public const int IF = 6;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int EXP = 7;
    public const int FORITER = 17;
    public const int StringType = 21;
    public const int T__59 = 59;
    public const int SpriteAnimation = 27;
    public const int COMMENT = 36;
    public const int VARDEF = 9;
    public const int T__50 = 50;
    public const int BooleanType = 20;
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
    public const int LIBMETHOD = 12;
    public const int IntegerAtom = 24;
    public const int FORDEC = 15;
    public const int FloatType = 22;
    public const int StringAtom = 28;
    public const int NEGATE = 11;
    public const int HEX_DIGIT = 34;
    public const int BooleanAtom = 26;
    public const int FORCOND = 16;
    public const int WS = 35;
    public const int T__37 = 37;
    public const int T__38 = 38;
    public const int T__39 = 39;
    public const int UnicodeEscape = 32;
    public const int BLOCK = 4;
    public const int ASSIGN = 10;
    public const int STATEMENTS = 5;
    public const int ObjectType = 23;
    public const int FloatAtom = 25;
    public const int EscapeSequence = 29;
    public const int Letter = 30;
    public const int OctalEscape = 33;
    public const int STRING = 14;

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

    // $ANTLR start "T__37"
    public void mT__37() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__37;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:7:7: ( '{' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:7:9: '{'
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
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public void mT__38() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__38;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:8:7: ( '}' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:8:9: '}'
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
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public void mT__39() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__39;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:9:7: ( 'method' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:9:9: 'method'
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
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public void mT__40() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__40;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:10:7: ( '(' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:10:9: '('
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
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public void mT__41() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__41;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:11:7: ( ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:11:9: ')'
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
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public void mT__42() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__42;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:12:7: ( ';' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:12:9: ';'
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
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public void mT__43() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__43;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:13:7: ( ',' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:13:9: ','
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
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public void mT__44() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__44;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:14:7: ( '=' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:14:9: '='
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
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public void mT__45() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__45;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:15:7: ( '.' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:15:9: '.'
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
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public void mT__46() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__46;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:16:7: ( 'while' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:16:9: 'while'
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
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public void mT__47() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__47;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:17:7: ( 'for' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:17:9: 'for'
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
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public void mT__48() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__48;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:18:7: ( 'if' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:18:9: 'if'
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
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public void mT__49() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__49;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:19:7: ( 'else' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:19:9: 'else'
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
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:20:7: ( '?' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:20:9: '?'
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
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:21:7: ( ':' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:21:9: ':'
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
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:22:7: ( '||' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:22:9: '||'
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
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:23:7: ( '&&' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:23:9: '&&'
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
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:24:7: ( '==' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:24:9: '=='
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
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:25:7: ( '!=' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:25:9: '!='
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
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:26:7: ( '<' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:26:9: '<'
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
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public void mT__57() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__57;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:27:7: ( '>' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:27:9: '>'
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
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public void mT__58() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__58;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:28:7: ( '<=' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:28:9: '<='
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
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:29:7: ( '>=' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:29:9: '>='
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
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:30:7: ( '+' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:30:9: '+'
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
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:31:7: ( '-' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:31:9: '-'
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
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:32:7: ( '*' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:32:9: '*'
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
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:33:7: ( '/' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:33:9: '/'
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
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:34:7: ( '%' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:34:9: '%'
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
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:35:7: ( '++' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:35:9: '++'
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
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:36:7: ( '--' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:36:9: '--'
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
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:37:7: ( '!' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:37:9: '!'
            {
            	Match('!'); 

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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:38:7: ( 'new' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:38:9: 'new'
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
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:39:7: ( 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:39:9: 'null'
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
    // $ANTLR end "T__69"

    // $ANTLR start "IntegerAtom"
    public void mIntegerAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IntegerAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:343:5: ( ( '0' .. '9' )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:343:7: ( '0' .. '9' )+
            {
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:343:7: ( '0' .. '9' )+
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:343:7: '0' .. '9'
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:347:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ )
            int alt6 = 3;
            alt6 = dfa6.Predict(input);
            switch (alt6) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:347:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:347:9: ( '0' .. '9' )+
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
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:347:10: '0' .. '9'
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
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:347:25: ( '0' .. '9' )*
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
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:347:26: '0' .. '9'
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:348:9: '.' ( '0' .. '9' )+
                    {
                    	Match('.'); 
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:348:13: ( '0' .. '9' )+
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
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:348:14: '0' .. '9'
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:349:9: ( '0' .. '9' )+
                    {
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:349:9: ( '0' .. '9' )+
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
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:349:10: '0' .. '9'
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:354:5: ( 'true' | 'false' )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:354:9: 'true'
                    {
                    	Match("true"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:355:9: 'false'
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:363:5: ( '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )+ '\"' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:363:9: '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )+ '\"'
            {
            	Match('\"'); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:363:13: ( EscapeSequence | ~ ( '\\\\' | '\"' ) )+
            	int cnt8 = 0;
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
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:363:15: EscapeSequence
            			    {
            			    	mEscapeSequence(); 

            			    }
            			    break;
            			case 2 :
            			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:363:32: ~ ( '\\\\' | '\"' )
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
            			    if ( cnt8 >= 1 ) goto loop8;
            		            EarlyExitException eee8 =
            		                new EarlyExitException(8, input);
            		            throw eee8;
            	    }
            	    cnt8++;
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;

              //Text = (Text.Substring(1, Text.Length-2).Replace("\\\\(.)", "$1"));
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:368:2: ( 'int' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:368:4: 'int'
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:372:2: ( 'boolean' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:372:4: 'boolean'
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:376:2: ( 'string' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:376:4: 'string'
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:380:2: ( 'float' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:380:4: 'float'
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:386:2: ( 'Object' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:386:4: 'Object'
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

    // $ANTLR start "SpriteAnimation"
    public void mSpriteAnimation() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = SpriteAnimation;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:390:2: ( 'Sprite' | 'Animation' )
            int alt9 = 2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0 == 'S') )
            {
                alt9 = 1;
            }
            else if ( (LA9_0 == 'A') )
            {
                alt9 = 2;
            }
            else 
            {
                NoViableAltException nvae_d9s0 =
                    new NoViableAltException("", 9, 0, input);

                throw nvae_d9s0;
            }
            switch (alt9) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:390:4: 'Sprite'
                    {
                    	Match("Sprite"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:391:4: 'Animation'
                    {
                    	Match("Animation"); 


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
    // $ANTLR end "SpriteAnimation"

    // $ANTLR start "Identifier"
    public void mIdentifier() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Identifier;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:397:5: ( Letter ( Letter | SGLIDDigit )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:397:9: Letter ( Letter | SGLIDDigit )*
            {
            	mLetter(); 
            	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:397:16: ( Letter | SGLIDDigit )*
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == '$' || (LA10_0 >= '0' && LA10_0 <= '9') || (LA10_0 >= 'A' && LA10_0 <= 'Z') || LA10_0 == '_' || (LA10_0 >= 'a' && LA10_0 <= 'z') || (LA10_0 >= '\u00C0' && LA10_0 <= '\u00D6') || (LA10_0 >= '\u00D8' && LA10_0 <= '\u00F6') || (LA10_0 >= '\u00F8' && LA10_0 <= '\u1FFF') || (LA10_0 >= '\u3040' && LA10_0 <= '\u318F') || (LA10_0 >= '\u3300' && LA10_0 <= '\u337F') || (LA10_0 >= '\u3400' && LA10_0 <= '\u3D2D') || (LA10_0 >= '\u4E00' && LA10_0 <= '\u9FFF') || (LA10_0 >= '\uF900' && LA10_0 <= '\uFAFF')) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
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
            			    goto loop10;
            	    }
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements


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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:409:5: ( '\\u0024' | '\\u0041' .. '\\u005a' | '\\u005f' | '\\u0061' .. '\\u007a' | '\\u00c0' .. '\\u00d6' | '\\u00d8' .. '\\u00f6' | '\\u00f8' .. '\\u00ff' | '\\u0100' .. '\\u1fff' | '\\u3040' .. '\\u318f' | '\\u3300' .. '\\u337f' | '\\u3400' .. '\\u3d2d' | '\\u4e00' .. '\\u9fff' | '\\uf900' .. '\\ufaff' )
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:426:5: ( '\\u0030' .. '\\u0039' | '\\u0660' .. '\\u0669' | '\\u06f0' .. '\\u06f9' | '\\u0966' .. '\\u096f' | '\\u09e6' .. '\\u09ef' | '\\u0a66' .. '\\u0a6f' | '\\u0ae6' .. '\\u0aef' | '\\u0b66' .. '\\u0b6f' | '\\u0be7' .. '\\u0bef' | '\\u0c66' .. '\\u0c6f' | '\\u0ce6' .. '\\u0cef' | '\\u0d66' .. '\\u0d6f' | '\\u0e50' .. '\\u0e59' | '\\u0ed0' .. '\\u0ed9' | '\\u1040' .. '\\u1049' )
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:446:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) | UnicodeEscape | OctalEscape )
            int alt11 = 3;
            int LA11_0 = input.LA(1);

            if ( (LA11_0 == '\\') )
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
                    alt11 = 1;
                    }
                    break;
                case 'u':
                	{
                    alt11 = 2;
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
                    alt11 = 3;
                    }
                    break;
                	default:
                	    NoViableAltException nvae_d11s1 =
                	        new NoViableAltException("", 11, 1, input);

                	    throw nvae_d11s1;
                }

            }
            else 
            {
                NoViableAltException nvae_d11s0 =
                    new NoViableAltException("", 11, 0, input);

                throw nvae_d11s0;
            }
            switch (alt11) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:446:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:447:9: UnicodeEscape
                    {
                    	mUnicodeEscape(); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:448:9: OctalEscape
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:453:5: ( '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) )
            int alt12 = 3;
            int LA12_0 = input.LA(1);

            if ( (LA12_0 == '\\') )
            {
                int LA12_1 = input.LA(2);

                if ( ((LA12_1 >= '0' && LA12_1 <= '3')) )
                {
                    int LA12_2 = input.LA(3);

                    if ( ((LA12_2 >= '0' && LA12_2 <= '7')) )
                    {
                        int LA12_4 = input.LA(4);

                        if ( ((LA12_4 >= '0' && LA12_4 <= '7')) )
                        {
                            alt12 = 1;
                        }
                        else 
                        {
                            alt12 = 2;}
                    }
                    else 
                    {
                        alt12 = 3;}
                }
                else if ( ((LA12_1 >= '4' && LA12_1 <= '7')) )
                {
                    int LA12_3 = input.LA(3);

                    if ( ((LA12_3 >= '0' && LA12_3 <= '7')) )
                    {
                        alt12 = 2;
                    }
                    else 
                    {
                        alt12 = 3;}
                }
                else 
                {
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:453:9: '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:453:14: ( '0' .. '3' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:453:15: '0' .. '3'
                    	{
                    		MatchRange('0','3'); 

                    	}

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:453:25: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:453:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:453:36: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:453:37: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:454:9: '\\\\' ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:454:14: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:454:15: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:454:25: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:454:26: '0' .. '7'
                    	{
                    		MatchRange('0','7'); 

                    	}


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:455:9: '\\\\' ( '0' .. '7' )
                    {
                    	Match('\\'); 
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:455:14: ( '0' .. '7' )
                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:455:15: '0' .. '7'
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:460:5: ( '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:460:9: '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:464:11: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:464:13: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:470:5: ( ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:470:8: ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' )
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
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:475:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
            int alt16 = 2;
            int LA16_0 = input.LA(1);

            if ( (LA16_0 == '/') )
            {
                int LA16_1 = input.LA(2);

                if ( (LA16_1 == '/') )
                {
                    alt16 = 1;
                }
                else if ( (LA16_1 == '*') )
                {
                    alt16 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d16s1 =
                        new NoViableAltException("", 16, 1, input);

                    throw nvae_d16s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d16s0 =
                    new NoViableAltException("", 16, 0, input);

                throw nvae_d16s0;
            }
            switch (alt16) 
            {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:475:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match("//"); 

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:475:14: (~ ( '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt13 = 2;
                    	    int LA13_0 = input.LA(1);

                    	    if ( ((LA13_0 >= '\u0000' && LA13_0 <= '\t') || (LA13_0 >= '\u000B' && LA13_0 <= '\f') || (LA13_0 >= '\u000E' && LA13_0 <= '\uFFFF')) )
                    	    {
                    	        alt13 = 1;
                    	    }


                    	    switch (alt13) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:475:14: ~ ( '\\n' | '\\r' )
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
                    			    goto loop13;
                    	    }
                    	} while (true);

                    	loop13:
                    		;	// Stops C# compiler whining that label 'loop13' has no statements

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:475:28: ( '\\r' )?
                    	int alt14 = 2;
                    	int LA14_0 = input.LA(1);

                    	if ( (LA14_0 == '\r') )
                    	{
                    	    alt14 = 1;
                    	}
                    	switch (alt14) 
                    	{
                    	    case 1 :
                    	        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:475:28: '\\r'
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
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:476:9: '/*' ( options {greedy=false; } : . )* '*/'
                    {
                    	Match("/*"); 

                    	// C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:476:14: ( options {greedy=false; } : . )*
                    	do 
                    	{
                    	    int alt15 = 2;
                    	    int LA15_0 = input.LA(1);

                    	    if ( (LA15_0 == '*') )
                    	    {
                    	        int LA15_1 = input.LA(2);

                    	        if ( (LA15_1 == '/') )
                    	        {
                    	            alt15 = 2;
                    	        }
                    	        else if ( ((LA15_1 >= '\u0000' && LA15_1 <= '.') || (LA15_1 >= '0' && LA15_1 <= '\uFFFF')) )
                    	        {
                    	            alt15 = 1;
                    	        }


                    	    }
                    	    else if ( ((LA15_0 >= '\u0000' && LA15_0 <= ')') || (LA15_0 >= '+' && LA15_0 <= '\uFFFF')) )
                    	    {
                    	        alt15 = 1;
                    	    }


                    	    switch (alt15) 
                    		{
                    			case 1 :
                    			    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:476:42: .
                    			    {
                    			    	MatchAny(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop15;
                    	    }
                    	} while (true);

                    	loop15:
                    		;	// Stops C# compiler whining that label 'loop15' has no statements

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
        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:8: ( T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | IntegerAtom | FloatAtom | BooleanAtom | StringAtom | IntType | BooleanType | StringType | FloatType | ObjectType | SpriteAnimation | Identifier | EscapeSequence | WS | COMMENT )
        int alt17 = 47;
        alt17 = dfa17.Predict(input);
        switch (alt17) 
        {
            case 1 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:10: T__37
                {
                	mT__37(); 

                }
                break;
            case 2 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:16: T__38
                {
                	mT__38(); 

                }
                break;
            case 3 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:22: T__39
                {
                	mT__39(); 

                }
                break;
            case 4 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:28: T__40
                {
                	mT__40(); 

                }
                break;
            case 5 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:34: T__41
                {
                	mT__41(); 

                }
                break;
            case 6 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:40: T__42
                {
                	mT__42(); 

                }
                break;
            case 7 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:46: T__43
                {
                	mT__43(); 

                }
                break;
            case 8 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:52: T__44
                {
                	mT__44(); 

                }
                break;
            case 9 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:58: T__45
                {
                	mT__45(); 

                }
                break;
            case 10 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:64: T__46
                {
                	mT__46(); 

                }
                break;
            case 11 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:70: T__47
                {
                	mT__47(); 

                }
                break;
            case 12 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:76: T__48
                {
                	mT__48(); 

                }
                break;
            case 13 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:82: T__49
                {
                	mT__49(); 

                }
                break;
            case 14 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:88: T__50
                {
                	mT__50(); 

                }
                break;
            case 15 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:94: T__51
                {
                	mT__51(); 

                }
                break;
            case 16 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:100: T__52
                {
                	mT__52(); 

                }
                break;
            case 17 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:106: T__53
                {
                	mT__53(); 

                }
                break;
            case 18 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:112: T__54
                {
                	mT__54(); 

                }
                break;
            case 19 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:118: T__55
                {
                	mT__55(); 

                }
                break;
            case 20 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:124: T__56
                {
                	mT__56(); 

                }
                break;
            case 21 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:130: T__57
                {
                	mT__57(); 

                }
                break;
            case 22 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:136: T__58
                {
                	mT__58(); 

                }
                break;
            case 23 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:142: T__59
                {
                	mT__59(); 

                }
                break;
            case 24 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:148: T__60
                {
                	mT__60(); 

                }
                break;
            case 25 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:154: T__61
                {
                	mT__61(); 

                }
                break;
            case 26 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:160: T__62
                {
                	mT__62(); 

                }
                break;
            case 27 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:166: T__63
                {
                	mT__63(); 

                }
                break;
            case 28 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:172: T__64
                {
                	mT__64(); 

                }
                break;
            case 29 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:178: T__65
                {
                	mT__65(); 

                }
                break;
            case 30 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:184: T__66
                {
                	mT__66(); 

                }
                break;
            case 31 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:190: T__67
                {
                	mT__67(); 

                }
                break;
            case 32 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:196: T__68
                {
                	mT__68(); 

                }
                break;
            case 33 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:202: T__69
                {
                	mT__69(); 

                }
                break;
            case 34 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:208: IntegerAtom
                {
                	mIntegerAtom(); 

                }
                break;
            case 35 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:220: FloatAtom
                {
                	mFloatAtom(); 

                }
                break;
            case 36 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:230: BooleanAtom
                {
                	mBooleanAtom(); 

                }
                break;
            case 37 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:242: StringAtom
                {
                	mStringAtom(); 

                }
                break;
            case 38 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:253: IntType
                {
                	mIntType(); 

                }
                break;
            case 39 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:261: BooleanType
                {
                	mBooleanType(); 

                }
                break;
            case 40 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:273: StringType
                {
                	mStringType(); 

                }
                break;
            case 41 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:284: FloatType
                {
                	mFloatType(); 

                }
                break;
            case 42 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:294: ObjectType
                {
                	mObjectType(); 

                }
                break;
            case 43 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:305: SpriteAnimation
                {
                	mSpriteAnimation(); 

                }
                break;
            case 44 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:321: Identifier
                {
                	mIdentifier(); 

                }
                break;
            case 45 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:332: EscapeSequence
                {
                	mEscapeSequence(); 

                }
                break;
            case 46 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:347: WS
                {
                	mWS(); 

                }
                break;
            case 47 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:350: COMMENT
                {
                	mCOMMENT(); 

                }
                break;

        }

    }


    protected DFA6 dfa6;
    protected DFA17 dfa17;
	private void InitializeCyclicDFAs()
	{
	    this.dfa6 = new DFA6(this);
	    this.dfa17 = new DFA17(this);
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
            get { return "346:1: FloatAtom : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ );"; }
        }

    }

    const string DFA17_eotS =
        "\x03\uffff\x01\x23\x04\uffff\x01\x28\x01\x29\x04\x23\x04\uffff"+
        "\x01\x33\x01\x35\x01\x37\x01\x39\x01\x3b\x01\uffff\x01\x3d\x01\uffff"+
        "\x01\x23\x01\x40\x01\x23\x01\uffff\x05\x23\x03\uffff\x01\x23\x04"+
        "\uffff\x04\x23\x01\x4c\x02\x23\x0c\uffff\x02\x23\x01\uffff\x08\x23"+
        "\x01\x59\x02\x23\x01\uffff\x01\x5c\x01\x23\x01\x5e\x09\x23\x01\uffff"+
        "\x02\x23\x01\uffff\x01\x6a\x01\uffff\x01\x6b\x01\x6c\x06\x23\x01"+
        "\x73\x01\x6c\x01\x74\x03\uffff\x05\x23\x01\x7a\x02\uffff\x01\x23"+
        "\x01\x7c\x01\x7d\x01\x7e\x01\x23\x01\uffff\x01\u0080\x03\uffff\x01"+
        "\x23\x01\uffff\x01\x23\x01\x7e";
    const string DFA17_eofS =
        "\u0083\uffff";
    const string DFA17_minS =
        "\x01\x09\x02\uffff\x01\x65\x04\uffff\x01\x3d\x01\x30\x01\x68\x01"+
        "\x61\x01\x66\x01\x6c\x04\uffff\x03\x3d\x01\x2b\x01\x2d\x01\uffff"+
        "\x01\x2a\x01\uffff\x01\x65\x01\x2e\x01\x72\x01\uffff\x01\x6f\x01"+
        "\x74\x01\x62\x01\x70\x01\x6e\x03\uffff\x01\x74\x04\uffff\x01\x69"+
        "\x01\x72\x01\x6c\x01\x6f\x01\x24\x01\x74\x01\x73\x0c\uffff\x01\x77"+
        "\x01\x6c\x01\uffff\x01\x75\x01\x6f\x01\x72\x01\x6a\x01\x72\x01\x69"+
        "\x01\x68\x01\x6c\x01\x24\x01\x73\x01\x61\x01\uffff\x01\x24\x01\x65"+
        "\x01\x24\x01\x6c\x01\x65\x01\x6c\x01\x69\x01\x65\x01\x69\x01\x6d"+
        "\x01\x6f\x01\x65\x01\uffff\x01\x65\x01\x74\x01\uffff\x01\x24\x01"+
        "\uffff\x02\x24\x01\x65\x01\x6e\x01\x63\x01\x74\x01\x61\x01\x64\x03"+
        "\x24\x03\uffff\x01\x61\x01\x67\x01\x74\x01\x65\x01\x74\x01\x24\x02"+
        "\uffff\x01\x6e\x03\x24\x01\x69\x01\uffff\x01\x24\x03\uffff\x01\x6f"+
        "\x01\uffff\x01\x6e\x01\x24";
    const string DFA17_maxS =
        "\x01\ufaff\x02\uffff\x01\x65\x04\uffff\x01\x3d\x01\x39\x01\x68"+
        "\x01\x6f\x01\x6e\x01\x6c\x04\uffff\x03\x3d\x01\x2b\x01\x2d\x01\uffff"+
        "\x01\x2f\x01\uffff\x01\x75\x01\x39\x01\x72\x01\uffff\x01\x6f\x01"+
        "\x74\x01\x62\x01\x70\x01\x6e\x03\uffff\x01\x74\x04\uffff\x01\x69"+
        "\x01\x72\x01\x6c\x01\x6f\x01\ufaff\x01\x74\x01\x73\x0c\uffff\x01"+
        "\x77\x01\x6c\x01\uffff\x01\x75\x01\x6f\x01\x72\x01\x6a\x01\x72\x01"+
        "\x69\x01\x68\x01\x6c\x01\ufaff\x01\x73\x01\x61\x01\uffff\x01\ufaff"+
        "\x01\x65\x01\ufaff\x01\x6c\x01\x65\x01\x6c\x01\x69\x01\x65\x01\x69"+
        "\x01\x6d\x01\x6f\x01\x65\x01\uffff\x01\x65\x01\x74\x01\uffff\x01"+
        "\ufaff\x01\uffff\x02\ufaff\x01\x65\x01\x6e\x01\x63\x01\x74\x01\x61"+
        "\x01\x64\x03\ufaff\x03\uffff\x01\x61\x01\x67\x01\x74\x01\x65\x01"+
        "\x74\x01\ufaff\x02\uffff\x01\x6e\x03\ufaff\x01\x69\x01\uffff\x01"+
        "\ufaff\x03\uffff\x01\x6f\x01\uffff\x01\x6e\x01\ufaff";
    const string DFA17_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\uffff\x01\x04\x01\x05\x01\x06\x01"+
        "\x07\x06\uffff\x01\x0e\x01\x0f\x01\x10\x01\x11\x05\uffff\x01\x1a"+
        "\x01\uffff\x01\x1c\x03\uffff\x01\x25\x05\uffff\x01\x2c\x01\x2d\x01"+
        "\x2e\x01\uffff\x01\x12\x01\x08\x01\x09\x01\x23\x07\uffff\x01\x13"+
        "\x01\x1f\x01\x16\x01\x14\x01\x17\x01\x15\x01\x1d\x01\x18\x01\x1e"+
        "\x01\x19\x01\x2f\x01\x1b\x02\uffff\x01\x22\x0b\uffff\x01\x0c\x0c"+
        "\uffff\x01\x0b\x02\uffff\x01\x26\x01\uffff\x01\x20\x0b\uffff\x01"+
        "\x0d\x01\x21\x01\x24\x06\uffff\x01\x0a\x01\x29\x05\uffff\x01\x03"+
        "\x01\uffff\x01\x28\x01\x2a\x01\x2b\x01\uffff\x01\x27\x02\uffff";
    const string DFA17_specialS =
        "\u0083\uffff}>";
    static readonly string[] DFA17_transitionS = {
            "\x02\x25\x01\uffff\x02\x25\x12\uffff\x01\x25\x01\x12\x01\x1d"+
            "\x01\uffff\x01\x23\x01\x19\x01\x11\x01\uffff\x01\x04\x01\x05"+
            "\x01\x17\x01\x15\x01\x07\x01\x16\x01\x09\x01\x18\x0a\x1b\x01"+
            "\x0f\x01\x06\x01\x13\x01\x08\x01\x14\x01\x0e\x01\uffff\x01\x22"+
            "\x0d\x23\x01\x20\x03\x23\x01\x21\x07\x23\x01\uffff\x01\x24\x02"+
            "\uffff\x01\x23\x01\uffff\x01\x23\x01\x1e\x02\x23\x01\x0d\x01"+
            "\x0b\x02\x23\x01\x0c\x03\x23\x01\x03\x01\x1a\x04\x23\x01\x1f"+
            "\x01\x1c\x02\x23\x01\x0a\x03\x23\x01\x01\x01\x10\x01\x02\x42"+
            "\uffff\x17\x23\x01\uffff\x1f\x23\x01\uffff\u1f08\x23\u1040\uffff"+
            "\u0150\x23\u0170\uffff\u0080\x23\u0080\uffff\u092e\x23\u10d2"+
            "\uffff\u5200\x23\u5900\uffff\u0200\x23",
            "",
            "",
            "\x01\x26",
            "",
            "",
            "",
            "",
            "\x01\x27",
            "\x0a\x2a",
            "\x01\x2b",
            "\x01\x2d\x0a\uffff\x01\x2e\x02\uffff\x01\x2c",
            "\x01\x2f\x07\uffff\x01\x30",
            "\x01\x31",
            "",
            "",
            "",
            "",
            "\x01\x32",
            "\x01\x34",
            "\x01\x36",
            "\x01\x38",
            "\x01\x3a",
            "",
            "\x01\x3c\x04\uffff\x01\x3c",
            "",
            "\x01\x3e\x0f\uffff\x01\x3f",
            "\x01\x2a\x01\uffff\x0a\x1b",
            "\x01\x41",
            "",
            "\x01\x42",
            "\x01\x43",
            "\x01\x44",
            "\x01\x45",
            "\x01\x46",
            "",
            "",
            "",
            "\x01\x47",
            "",
            "",
            "",
            "",
            "\x01\x48",
            "\x01\x49",
            "\x01\x4a",
            "\x01\x4b",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "\x01\x4d",
            "\x01\x4e",
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
            "",
            "",
            "\x01\x4f",
            "\x01\x50",
            "",
            "\x01\x51",
            "\x01\x52",
            "\x01\x53",
            "\x01\x54",
            "\x01\x55",
            "\x01\x56",
            "\x01\x57",
            "\x01\x58",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "\x01\x5a",
            "\x01\x5b",
            "",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "\x01\x5d",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "\x01\x5f",
            "\x01\x60",
            "\x01\x61",
            "\x01\x62",
            "\x01\x63",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "",
            "\x01\x68",
            "\x01\x69",
            "",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "\x01\x6d",
            "\x01\x6e",
            "\x01\x6f",
            "\x01\x70",
            "\x01\x71",
            "\x01\x72",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "",
            "",
            "",
            "\x01\x75",
            "\x01\x76",
            "\x01\x77",
            "\x01\x78",
            "\x01\x79",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "",
            "",
            "\x01\x7b",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "\x01\x7f",
            "",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23",
            "",
            "",
            "",
            "\x01\u0081",
            "",
            "\x01\u0082",
            "\x01\x23\x0b\uffff\x0a\x23\x07\uffff\x1a\x23\x04\uffff\x01"+
            "\x23\x01\uffff\x1a\x23\x45\uffff\x17\x23\x01\uffff\x1f\x23\x01"+
            "\uffff\u1f08\x23\u1040\uffff\u0150\x23\u0170\uffff\u0080\x23"+
            "\u0080\uffff\u092e\x23\u10d2\uffff\u5200\x23\u5900\uffff\u0200"+
            "\x23"
    };

    static readonly short[] DFA17_eot = DFA.UnpackEncodedString(DFA17_eotS);
    static readonly short[] DFA17_eof = DFA.UnpackEncodedString(DFA17_eofS);
    static readonly char[] DFA17_min = DFA.UnpackEncodedStringToUnsignedChars(DFA17_minS);
    static readonly char[] DFA17_max = DFA.UnpackEncodedStringToUnsignedChars(DFA17_maxS);
    static readonly short[] DFA17_accept = DFA.UnpackEncodedString(DFA17_acceptS);
    static readonly short[] DFA17_special = DFA.UnpackEncodedString(DFA17_specialS);
    static readonly short[][] DFA17_transition = DFA.UnpackEncodedStringArray(DFA17_transitionS);

    protected class DFA17 : DFA
    {
        public DFA17(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 17;
            this.eot = DFA17_eot;
            this.eof = DFA17_eof;
            this.min = DFA17_min;
            this.max = DFA17_max;
            this.accept = DFA17_accept;
            this.special = DFA17_special;
            this.transition = DFA17_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | IntegerAtom | FloatAtom | BooleanAtom | StringAtom | IntType | BooleanType | StringType | FloatType | ObjectType | SpriteAnimation | Identifier | EscapeSequence | WS | COMMENT );"; }
        }

    }

 
    
}
