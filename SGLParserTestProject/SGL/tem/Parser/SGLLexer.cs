// $ANTLR 3.2 Sep 23, 2009 12:02:23 D:\\sgl4c#\\NewSGLGramma\\SGL.g 2012-05-24 13:23:18

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
    public const int VAR_LIST = 16;
    public const int T__63 = 63;
    public const int IntAtom = 31;
    public const int Sprite = 39;
    public const int EXP_LIST = 15;
    public const int LoopTypeAtom = 36;
    public const int T__61 = 61;
    public const int UTF8Letter = 46;
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
    public const int OriginAtom = 35;
    public const int Null = 38;
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
    public const int T__84 = 84;
    public const int LIST = 14;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int T__89 = 89;
    public const int List = 41;
    public const int T__88 = 88;
    public const int BOOL_NEGATE = 8;
    public const int BooleanAtom = 33;
    public const int LOOKUP = 13;
    public const int T__71 = 71;
    public const int FORCOND = 25;
    public const int T__72 = 72;
    public const int VARIABLE = 11;
    public const int T__70 = 70;
    public const int BLOCK = 4;
    public const int ASSIGN = 5;
    public const int VarStartInit = 42;
    public const int OBJ_METH_CALL = 18;
    public const int T__76 = 76;
    public const int GLOBAL = 27;
    public const int FloatAtom = 32;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int VARINC = 9;
    public const int T__73 = 73;
    public const int EscapeSequence = 45;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int STRING = 6;
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
    	get { return "D:\\sgl4c#\\NewSGLGramma\\SGL.g";} 
    }

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:14:7: ( '{' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:14:9: '{'
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
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public void mT__51() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__51;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:15:7: ( '}' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:15:9: '}'
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
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public void mT__52() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__52;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:16:7: ( ';' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:16:9: ';'
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
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public void mT__53() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__53;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:17:7: ( ',' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:17:9: ','
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
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public void mT__54() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__54;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:18:7: ( 'global' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:18:9: 'global'
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
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:19:7: ( '=' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:19:9: '='
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
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:20:7: ( '[' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:20:9: '['
            {
            	Match('['); 

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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:21:7: ( ']' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:21:9: ']'
            {
            	Match(']'); 

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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:22:7: ( '.' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:22:9: '.'
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
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public void mT__59() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__59;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:23:7: ( '(' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:23:9: '('
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
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public void mT__60() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__60;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:24:7: ( ')' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:24:9: ')'
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
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public void mT__61() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__61;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:25:7: ( 'method' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:25:9: 'method'
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
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public void mT__62() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__62;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:26:7: ( 'object method' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:26:9: 'object method'
            {
            	Match("object method"); 


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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:27:7: ( '?' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:27:9: '?'
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
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:28:7: ( ':' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:28:9: ':'
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
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:29:7: ( '||' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:29:9: '||'
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
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:30:7: ( '&&' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:30:9: '&&'
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
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:31:7: ( '==' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:31:9: '=='
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
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:32:7: ( '!=' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:32:9: '!='
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
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:33:7: ( '<' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:33:9: '<'
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
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:34:7: ( '>' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:34:9: '>'
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
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:35:7: ( '<=' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:35:9: '<='
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
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:36:7: ( '>=' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:36:9: '>='
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
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:37:7: ( '+' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:37:9: '+'
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
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:38:7: ( '-' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:38:9: '-'
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
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:39:7: ( '*' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:39:9: '*'
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
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:40:7: ( '/' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:40:9: '/'
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
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public void mT__77() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__77;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:41:7: ( '%' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:41:9: '%'
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
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public void mT__78() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__78;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:42:7: ( '^' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:42:9: '^'
            {
            	Match('^'); 

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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:43:7: ( '!' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:43:9: '!'
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
    // $ANTLR end "T__79"

    // $ANTLR start "T__80"
    public void mT__80() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__80;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:44:7: ( '++' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:44:9: '++'
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
    // $ANTLR end "T__80"

    // $ANTLR start "T__81"
    public void mT__81() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__81;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:45:7: ( '--' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:45:9: '--'
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
    // $ANTLR end "T__81"

    // $ANTLR start "T__82"
    public void mT__82() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__82;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:46:7: ( 'new' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:46:9: 'new'
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
    // $ANTLR end "T__82"

    // $ANTLR start "T__83"
    public void mT__83() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__83;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:47:7: ( 'break' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:47:9: 'break'
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
    // $ANTLR end "T__83"

    // $ANTLR start "T__84"
    public void mT__84() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__84;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:48:7: ( 'return' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:48:9: 'return'
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
    // $ANTLR end "T__84"

    // $ANTLR start "T__85"
    public void mT__85() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__85;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:49:7: ( 'while' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:49:9: 'while'
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
    // $ANTLR end "T__85"

    // $ANTLR start "T__86"
    public void mT__86() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__86;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:50:7: ( 'for' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:50:9: 'for'
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
    // $ANTLR end "T__86"

    // $ANTLR start "T__87"
    public void mT__87() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__87;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:51:7: ( 'if' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:51:9: 'if'
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
    // $ANTLR end "T__87"

    // $ANTLR start "T__88"
    public void mT__88() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__88;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:52:7: ( 'else' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:52:9: 'else'
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
    // $ANTLR end "T__88"

    // $ANTLR start "T__89"
    public void mT__89() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__89;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:53:7: ( 'at' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:53:9: 'at'
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
    // $ANTLR end "T__89"

    // $ANTLR start "VarStartInit"
    public void mVarStartInit() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VarStartInit;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:429:2: ( 'var' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:429:4: 'var'
            {
            	Match("var"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "VarStartInit"

    // $ANTLR start "BooleanAtom"
    public void mBooleanAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = BooleanAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:434:5: ( 'true' | 'false' )
            int alt1 = 2;
            int LA1_0 = input.LA(1);

            if ( (LA1_0 == 't') )
            {
                alt1 = 1;
            }
            else if ( (LA1_0 == 'f') )
            {
                alt1 = 2;
            }
            else 
            {
                NoViableAltException nvae_d1s0 =
                    new NoViableAltException("", 1, 0, input);

                throw nvae_d1s0;
            }
            switch (alt1) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:434:9: 'true'
                    {
                    	Match("true"); 


                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:435:9: 'false'
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

    // $ANTLR start "Null"
    public void mNull() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Null;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:439:2: ( 'null' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:439:4: 'null'
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
    // $ANTLR end "Null"

    // $ANTLR start "Sprite"
    public void mSprite() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Sprite;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:445:2: ( 'Sprite' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:445:4: 'Sprite'
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
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:449:2: ( 'Animation' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:449:4: 'Animation'
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

    // $ANTLR start "Lyrics"
    public void mLyrics() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Lyrics;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:453:2: ( 'Lyrics' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:453:4: 'Lyrics'
            {
            	Match("Lyrics"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Lyrics"

    // $ANTLR start "List"
    public void mList() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = List;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:457:2: ( 'List' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:457:4: 'List'
            {
            	Match("List"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "List"

    // $ANTLR start "LayerAtom"
    public void mLayerAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LayerAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:461:2: ( 'Background' | 'Fail' | 'Pass' | 'Foreground' )
            int alt2 = 4;
            switch ( input.LA(1) ) 
            {
            case 'B':
            	{
                alt2 = 1;
                }
                break;
            case 'F':
            	{
                int LA2_2 = input.LA(2);

                if ( (LA2_2 == 'a') )
                {
                    alt2 = 2;
                }
                else if ( (LA2_2 == 'o') )
                {
                    alt2 = 4;
                }
                else 
                {
                    NoViableAltException nvae_d2s2 =
                        new NoViableAltException("", 2, 2, input);

                    throw nvae_d2s2;
                }
                }
                break;
            case 'P':
            	{
                alt2 = 3;
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:461:4: 'Background'
                    {
                    	Match("Background"); 


                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:462:4: 'Fail'
                    {
                    	Match("Fail"); 


                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:463:4: 'Pass'
                    {
                    	Match("Pass"); 


                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:464:4: 'Foreground'
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
    // $ANTLR end "LayerAtom"

    // $ANTLR start "OriginAtom"
    public void mOriginAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = OriginAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:468:2: ( 'TopLeft' | 'TopCentre' | 'TopRight' | 'CentreLeft' | 'Centre' | 'CentreRight' | 'BottomLeft' | 'BottomCentre' | 'BottomRight' )
            int alt3 = 9;
            alt3 = dfa3.Predict(input);
            switch (alt3) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:468:4: 'TopLeft'
                    {
                    	Match("TopLeft"); 


                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:469:4: 'TopCentre'
                    {
                    	Match("TopCentre"); 


                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:470:4: 'TopRight'
                    {
                    	Match("TopRight"); 


                    }
                    break;
                case 4 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:471:4: 'CentreLeft'
                    {
                    	Match("CentreLeft"); 


                    }
                    break;
                case 5 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:472:4: 'Centre'
                    {
                    	Match("Centre"); 


                    }
                    break;
                case 6 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:473:4: 'CentreRight'
                    {
                    	Match("CentreRight"); 


                    }
                    break;
                case 7 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:474:4: 'BottomLeft'
                    {
                    	Match("BottomLeft"); 


                    }
                    break;
                case 8 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:475:4: 'BottomCentre'
                    {
                    	Match("BottomCentre"); 


                    }
                    break;
                case 9 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:476:4: 'BottomRight'
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
    // $ANTLR end "OriginAtom"

    // $ANTLR start "LoopTypeAtom"
    public void mLoopTypeAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LoopTypeAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:480:2: ( 'LoopForever' | 'LoopOnce' )
            int alt4 = 2;
            int LA4_0 = input.LA(1);

            if ( (LA4_0 == 'L') )
            {
                int LA4_1 = input.LA(2);

                if ( (LA4_1 == 'o') )
                {
                    int LA4_2 = input.LA(3);

                    if ( (LA4_2 == 'o') )
                    {
                        int LA4_3 = input.LA(4);

                        if ( (LA4_3 == 'p') )
                        {
                            int LA4_4 = input.LA(5);

                            if ( (LA4_4 == 'F') )
                            {
                                alt4 = 1;
                            }
                            else if ( (LA4_4 == 'O') )
                            {
                                alt4 = 2;
                            }
                            else 
                            {
                                NoViableAltException nvae_d4s4 =
                                    new NoViableAltException("", 4, 4, input);

                                throw nvae_d4s4;
                            }
                        }
                        else 
                        {
                            NoViableAltException nvae_d4s3 =
                                new NoViableAltException("", 4, 3, input);

                            throw nvae_d4s3;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d4s2 =
                            new NoViableAltException("", 4, 2, input);

                        throw nvae_d4s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d4s1 =
                        new NoViableAltException("", 4, 1, input);

                    throw nvae_d4s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d4s0 =
                    new NoViableAltException("", 4, 0, input);

                throw nvae_d4s0;
            }
            switch (alt4) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:480:4: 'LoopForever'
                    {
                    	Match("LoopForever"); 


                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:481:4: 'LoopOnce'
                    {
                    	Match("LoopOnce"); 


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
    // $ANTLR end "LoopTypeAtom"

    // $ANTLR start "ColorAtom"
    public void mColorAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ColorAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:485:2: ( '#' HexDigit HexDigit HexDigit | '#' HexDigit HexDigit HexDigit HexDigit HexDigit HexDigit )
            int alt5 = 2;
            int LA5_0 = input.LA(1);

            if ( (LA5_0 == '#') )
            {
                int LA5_1 = input.LA(2);

                if ( ((LA5_1 >= '0' && LA5_1 <= '9') || (LA5_1 >= 'A' && LA5_1 <= 'F') || (LA5_1 >= 'a' && LA5_1 <= 'f')) )
                {
                    int LA5_2 = input.LA(3);

                    if ( ((LA5_2 >= '0' && LA5_2 <= '9') || (LA5_2 >= 'A' && LA5_2 <= 'F') || (LA5_2 >= 'a' && LA5_2 <= 'f')) )
                    {
                        int LA5_3 = input.LA(4);

                        if ( ((LA5_3 >= '0' && LA5_3 <= '9') || (LA5_3 >= 'A' && LA5_3 <= 'F') || (LA5_3 >= 'a' && LA5_3 <= 'f')) )
                        {
                            int LA5_4 = input.LA(5);

                            if ( ((LA5_4 >= '0' && LA5_4 <= '9') || (LA5_4 >= 'A' && LA5_4 <= 'F') || (LA5_4 >= 'a' && LA5_4 <= 'f')) )
                            {
                                alt5 = 2;
                            }
                            else 
                            {
                                alt5 = 1;}
                        }
                        else 
                        {
                            NoViableAltException nvae_d5s3 =
                                new NoViableAltException("", 5, 3, input);

                            throw nvae_d5s3;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d5s2 =
                            new NoViableAltException("", 5, 2, input);

                        throw nvae_d5s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d5s1 =
                        new NoViableAltException("", 5, 1, input);

                    throw nvae_d5s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d5s0 =
                    new NoViableAltException("", 5, 0, input);

                throw nvae_d5s0;
            }
            switch (alt5) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:485:4: '#' HexDigit HexDigit HexDigit
                    {
                    	Match('#'); 
                    	mHexDigit(); 
                    	mHexDigit(); 
                    	mHexDigit(); 

                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:486:4: '#' HexDigit HexDigit HexDigit HexDigit HexDigit HexDigit
                    {
                    	Match('#'); 
                    	mHexDigit(); 
                    	mHexDigit(); 
                    	mHexDigit(); 
                    	mHexDigit(); 
                    	mHexDigit(); 
                    	mHexDigit(); 

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
    // $ANTLR end "ColorAtom"

    // $ANTLR start "IntAtom"
    public void mIntAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = IntAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:490:5: ( ( '0' .. '9' )+ )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:490:7: ( '0' .. '9' )+
            {
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:490:7: ( '0' .. '9' )+
            	int cnt6 = 0;
            	do 
            	{
            	    int alt6 = 2;
            	    int LA6_0 = input.LA(1);

            	    if ( ((LA6_0 >= '0' && LA6_0 <= '9')) )
            	    {
            	        alt6 = 1;
            	    }


            	    switch (alt6) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:490:7: '0' .. '9'
            			    {
            			    	MatchRange('0','9'); 

            			    }
            			    break;

            			default:
            			    if ( cnt6 >= 1 ) goto loop6;
            		            EarlyExitException eee6 =
            		                new EarlyExitException(6, input);
            		            throw eee6;
            	    }
            	    cnt6++;
            	} while (true);

            	loop6:
            		;	// Stops C# compiler whining that label 'loop6' has no statements


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "IntAtom"

    // $ANTLR start "FloatAtom"
    public void mFloatAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = FloatAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:494:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ )
            int alt11 = 3;
            alt11 = dfa11.Predict(input);
            switch (alt11) 
            {
                case 1 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:494:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:494:9: ( '0' .. '9' )+
                    	int cnt7 = 0;
                    	do 
                    	{
                    	    int alt7 = 2;
                    	    int LA7_0 = input.LA(1);

                    	    if ( ((LA7_0 >= '0' && LA7_0 <= '9')) )
                    	    {
                    	        alt7 = 1;
                    	    }


                    	    switch (alt7) 
                    		{
                    			case 1 :
                    			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:494:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt7 >= 1 ) goto loop7;
                    		            EarlyExitException eee7 =
                    		                new EarlyExitException(7, input);
                    		            throw eee7;
                    	    }
                    	    cnt7++;
                    	} while (true);

                    	loop7:
                    		;	// Stops C# compiler whining that label 'loop7' has no statements

                    	Match('.'); 
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:494:25: ( '0' .. '9' )*
                    	do 
                    	{
                    	    int alt8 = 2;
                    	    int LA8_0 = input.LA(1);

                    	    if ( ((LA8_0 >= '0' && LA8_0 <= '9')) )
                    	    {
                    	        alt8 = 1;
                    	    }


                    	    switch (alt8) 
                    		{
                    			case 1 :
                    			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:494:26: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop8;
                    	    }
                    	} while (true);

                    	loop8:
                    		;	// Stops C# compiler whining that label 'loop8' has no statements


                    }
                    break;
                case 2 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:495:9: '.' ( '0' .. '9' )+
                    {
                    	Match('.'); 
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:495:13: ( '0' .. '9' )+
                    	int cnt9 = 0;
                    	do 
                    	{
                    	    int alt9 = 2;
                    	    int LA9_0 = input.LA(1);

                    	    if ( ((LA9_0 >= '0' && LA9_0 <= '9')) )
                    	    {
                    	        alt9 = 1;
                    	    }


                    	    switch (alt9) 
                    		{
                    			case 1 :
                    			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:495:14: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt9 >= 1 ) goto loop9;
                    		            EarlyExitException eee9 =
                    		                new EarlyExitException(9, input);
                    		            throw eee9;
                    	    }
                    	    cnt9++;
                    	} while (true);

                    	loop9:
                    		;	// Stops C# compiler whining that label 'loop9' has no statements


                    }
                    break;
                case 3 :
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:496:9: ( '0' .. '9' )+
                    {
                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:496:9: ( '0' .. '9' )+
                    	int cnt10 = 0;
                    	do 
                    	{
                    	    int alt10 = 2;
                    	    int LA10_0 = input.LA(1);

                    	    if ( ((LA10_0 >= '0' && LA10_0 <= '9')) )
                    	    {
                    	        alt10 = 1;
                    	    }


                    	    switch (alt10) 
                    		{
                    			case 1 :
                    			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:496:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt10 >= 1 ) goto loop10;
                    		            EarlyExitException eee10 =
                    		                new EarlyExitException(10, input);
                    		            throw eee10;
                    	    }
                    	    cnt10++;
                    	} while (true);

                    	loop10:
                    		;	// Stops C# compiler whining that label 'loop10' has no statements


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

    // $ANTLR start "StringAtom"
    public void mStringAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = StringAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:501:5: ( '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )* '\"' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:501:8: '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:501:12: ( EscapeSequence | ~ ( '\\\\' | '\"' ) )*
            	do 
            	{
            	    int alt12 = 3;
            	    int LA12_0 = input.LA(1);

            	    if ( (LA12_0 == '\\') )
            	    {
            	        alt12 = 1;
            	    }
            	    else if ( ((LA12_0 >= '\u0000' && LA12_0 <= '!') || (LA12_0 >= '#' && LA12_0 <= '[') || (LA12_0 >= ']' && LA12_0 <= '\uFFFF')) )
            	    {
            	        alt12 = 2;
            	    }


            	    switch (alt12) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:501:14: EscapeSequence
            			    {
            			    	mEscapeSequence(); 

            			    }
            			    break;
            			case 2 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:501:31: ~ ( '\\\\' | '\"' )
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
            			    goto loop12;
            	    }
            	} while (true);

            	loop12:
            		;	// Stops C# compiler whining that label 'loop12' has no statements

            	Match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "StringAtom"

    // $ANTLR start "Identifier"
    public void mIdentifier() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Identifier;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:506:5: ( UTF8Letter ( UTF8Letter | UTF8Digit )* )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:506:9: UTF8Letter ( UTF8Letter | UTF8Digit )*
            {
            	mUTF8Letter(); 
            	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:506:20: ( UTF8Letter | UTF8Digit )*
            	do 
            	{
            	    int alt13 = 2;
            	    int LA13_0 = input.LA(1);

            	    if ( ((LA13_0 >= '0' && LA13_0 <= '9') || (LA13_0 >= 'A' && LA13_0 <= 'Z') || LA13_0 == '_' || (LA13_0 >= 'a' && LA13_0 <= 'z') || (LA13_0 >= '\u00C0' && LA13_0 <= '\u00D6') || (LA13_0 >= '\u00D8' && LA13_0 <= '\u00F6') || (LA13_0 >= '\u00F8' && LA13_0 <= '\u1FFF') || (LA13_0 >= '\u3040' && LA13_0 <= '\u318F') || (LA13_0 >= '\u3300' && LA13_0 <= '\u337F') || (LA13_0 >= '\u3400' && LA13_0 <= '\u3D2D') || (LA13_0 >= '\u4E00' && LA13_0 <= '\u9FFF') || (LA13_0 >= '\uF900' && LA13_0 <= '\uFAFF')) )
            	    {
            	        alt13 = 1;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:
            			    {
            			    	if ( (input.LA(1) >= '0' && input.LA(1) <= '9') || (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u00C0' && input.LA(1) <= '\u00D6') || (input.LA(1) >= '\u00D8' && input.LA(1) <= '\u00F6') || (input.LA(1) >= '\u00F8' && input.LA(1) <= '\u1FFF') || (input.LA(1) >= '\u3040' && input.LA(1) <= '\u318F') || (input.LA(1) >= '\u3300' && input.LA(1) <= '\u337F') || (input.LA(1) >= '\u3400' && input.LA(1) <= '\u3D2D') || (input.LA(1) >= '\u4E00' && input.LA(1) <= '\u9FFF') || (input.LA(1) >= '\uF900' && input.LA(1) <= '\uFAFF') ) 
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


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Identifier"

    // $ANTLR start "Comment"
    public void mComment() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Comment;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:513:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:513:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match("//"); 

                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:513:14: (~ ( '\\n' | '\\r' ) )*
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
                    			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:513:14: ~ ( '\\n' | '\\r' )
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

                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:513:28: ( '\\r' )?
                    	int alt15 = 2;
                    	int LA15_0 = input.LA(1);

                    	if ( (LA15_0 == '\r') )
                    	{
                    	    alt15 = 1;
                    	}
                    	switch (alt15) 
                    	{
                    	    case 1 :
                    	        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:513:28: '\\r'
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
                    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:514:9: '/*' ( options {greedy=false; } : . )* '*/'
                    {
                    	Match("/*"); 

                    	// D:\\sgl4c#\\NewSGLGramma\\SGL.g:514:14: ( options {greedy=false; } : . )*
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
                    			    // D:\\sgl4c#\\NewSGLGramma\\SGL.g:514:42: .
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
    // $ANTLR end "Comment"

    // $ANTLR start "WhiteSpace"
    public void mWhiteSpace() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = WhiteSpace;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:518:2: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:518:6: ( ' ' | '\\t' | '\\r' | '\\n' )
            {
            	if ( (input.LA(1) >= '\t' && input.LA(1) <= '\n') || input.LA(1) == '\r' || input.LA(1) == ' ' ) 
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
    // $ANTLR end "WhiteSpace"

    // $ANTLR start "UTF8Letter"
    public void mUTF8Letter() // throws RecognitionException [2]
    {
    		try
    		{
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:532:5: ( '\\u0041' .. '\\u005a' | '\\u005f' | '\\u0061' .. '\\u007a' | '\\u00c0' .. '\\u00d6' | '\\u00d8' .. '\\u00f6' | '\\u00f8' .. '\\u00ff' | '\\u0100' .. '\\u1fff' | '\\u3040' .. '\\u318f' | '\\u3300' .. '\\u337f' | '\\u3400' .. '\\u3d2d' | '\\u4e00' .. '\\u9fff' | '\\uf900' .. '\\ufaff' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:
            {
            	if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z') || input.LA(1) == '_' || (input.LA(1) >= 'a' && input.LA(1) <= 'z') || (input.LA(1) >= '\u00C0' && input.LA(1) <= '\u00D6') || (input.LA(1) >= '\u00D8' && input.LA(1) <= '\u00F6') || (input.LA(1) >= '\u00F8' && input.LA(1) <= '\u1FFF') || (input.LA(1) >= '\u3040' && input.LA(1) <= '\u318F') || (input.LA(1) >= '\u3300' && input.LA(1) <= '\u337F') || (input.LA(1) >= '\u3400' && input.LA(1) <= '\u3D2D') || (input.LA(1) >= '\u4E00' && input.LA(1) <= '\u9FFF') || (input.LA(1) >= '\uF900' && input.LA(1) <= '\uFAFF') ) 
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
    // $ANTLR end "UTF8Letter"

    // $ANTLR start "UTF8Digit"
    public void mUTF8Digit() // throws RecognitionException [2]
    {
    		try
    		{
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:548:5: ( '\\u0030' .. '\\u0039' | '\\u0660' .. '\\u0669' | '\\u06f0' .. '\\u06f9' | '\\u0966' .. '\\u096f' | '\\u09e6' .. '\\u09ef' | '\\u0a66' .. '\\u0a6f' | '\\u0ae6' .. '\\u0aef' | '\\u0b66' .. '\\u0b6f' | '\\u0be7' .. '\\u0bef' | '\\u0c66' .. '\\u0c6f' | '\\u0ce6' .. '\\u0cef' | '\\u0d66' .. '\\u0d6f' | '\\u0e50' .. '\\u0e59' | '\\u0ed0' .. '\\u0ed9' | '\\u1040' .. '\\u1049' )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:
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
    // $ANTLR end "UTF8Digit"

    // $ANTLR start "HexDigit"
    public void mHexDigit() // throws RecognitionException [2]
    {
    		try
    		{
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:566:10: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:566:12: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
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
    // $ANTLR end "HexDigit"

    // $ANTLR start "EscapeSequence"
    public void mEscapeSequence() // throws RecognitionException [2]
    {
    		try
    		{
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:570:5: ( '\\\\' ( 'n' | 'r' | '\\\"' | '\\\\' ) )
            // D:\\sgl4c#\\NewSGLGramma\\SGL.g:570:9: '\\\\' ( 'n' | 'r' | '\\\"' | '\\\\' )
            {
            	Match('\\'); 
            	if ( input.LA(1) == '\"' || input.LA(1) == '\\' || input.LA(1) == 'n' || input.LA(1) == 'r' ) 
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
    // $ANTLR end "EscapeSequence"

    override public void mTokens() // throws RecognitionException 
    {
        // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:8: ( T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | T__86 | T__87 | T__88 | T__89 | VarStartInit | BooleanAtom | Null | Sprite | Animation | Lyrics | List | LayerAtom | OriginAtom | LoopTypeAtom | ColorAtom | IntAtom | FloatAtom | StringAtom | Identifier | Comment | WhiteSpace )
        int alt18 = 57;
        alt18 = dfa18.Predict(input);
        switch (alt18) 
        {
            case 1 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:10: T__50
                {
                	mT__50(); 

                }
                break;
            case 2 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:16: T__51
                {
                	mT__51(); 

                }
                break;
            case 3 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:22: T__52
                {
                	mT__52(); 

                }
                break;
            case 4 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:28: T__53
                {
                	mT__53(); 

                }
                break;
            case 5 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:34: T__54
                {
                	mT__54(); 

                }
                break;
            case 6 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:40: T__55
                {
                	mT__55(); 

                }
                break;
            case 7 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:46: T__56
                {
                	mT__56(); 

                }
                break;
            case 8 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:52: T__57
                {
                	mT__57(); 

                }
                break;
            case 9 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:58: T__58
                {
                	mT__58(); 

                }
                break;
            case 10 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:64: T__59
                {
                	mT__59(); 

                }
                break;
            case 11 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:70: T__60
                {
                	mT__60(); 

                }
                break;
            case 12 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:76: T__61
                {
                	mT__61(); 

                }
                break;
            case 13 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:82: T__62
                {
                	mT__62(); 

                }
                break;
            case 14 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:88: T__63
                {
                	mT__63(); 

                }
                break;
            case 15 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:94: T__64
                {
                	mT__64(); 

                }
                break;
            case 16 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:100: T__65
                {
                	mT__65(); 

                }
                break;
            case 17 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:106: T__66
                {
                	mT__66(); 

                }
                break;
            case 18 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:112: T__67
                {
                	mT__67(); 

                }
                break;
            case 19 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:118: T__68
                {
                	mT__68(); 

                }
                break;
            case 20 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:124: T__69
                {
                	mT__69(); 

                }
                break;
            case 21 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:130: T__70
                {
                	mT__70(); 

                }
                break;
            case 22 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:136: T__71
                {
                	mT__71(); 

                }
                break;
            case 23 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:142: T__72
                {
                	mT__72(); 

                }
                break;
            case 24 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:148: T__73
                {
                	mT__73(); 

                }
                break;
            case 25 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:154: T__74
                {
                	mT__74(); 

                }
                break;
            case 26 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:160: T__75
                {
                	mT__75(); 

                }
                break;
            case 27 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:166: T__76
                {
                	mT__76(); 

                }
                break;
            case 28 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:172: T__77
                {
                	mT__77(); 

                }
                break;
            case 29 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:178: T__78
                {
                	mT__78(); 

                }
                break;
            case 30 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:184: T__79
                {
                	mT__79(); 

                }
                break;
            case 31 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:190: T__80
                {
                	mT__80(); 

                }
                break;
            case 32 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:196: T__81
                {
                	mT__81(); 

                }
                break;
            case 33 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:202: T__82
                {
                	mT__82(); 

                }
                break;
            case 34 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:208: T__83
                {
                	mT__83(); 

                }
                break;
            case 35 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:214: T__84
                {
                	mT__84(); 

                }
                break;
            case 36 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:220: T__85
                {
                	mT__85(); 

                }
                break;
            case 37 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:226: T__86
                {
                	mT__86(); 

                }
                break;
            case 38 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:232: T__87
                {
                	mT__87(); 

                }
                break;
            case 39 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:238: T__88
                {
                	mT__88(); 

                }
                break;
            case 40 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:244: T__89
                {
                	mT__89(); 

                }
                break;
            case 41 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:250: VarStartInit
                {
                	mVarStartInit(); 

                }
                break;
            case 42 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:263: BooleanAtom
                {
                	mBooleanAtom(); 

                }
                break;
            case 43 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:275: Null
                {
                	mNull(); 

                }
                break;
            case 44 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:280: Sprite
                {
                	mSprite(); 

                }
                break;
            case 45 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:287: Animation
                {
                	mAnimation(); 

                }
                break;
            case 46 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:297: Lyrics
                {
                	mLyrics(); 

                }
                break;
            case 47 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:304: List
                {
                	mList(); 

                }
                break;
            case 48 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:309: LayerAtom
                {
                	mLayerAtom(); 

                }
                break;
            case 49 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:319: OriginAtom
                {
                	mOriginAtom(); 

                }
                break;
            case 50 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:330: LoopTypeAtom
                {
                	mLoopTypeAtom(); 

                }
                break;
            case 51 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:343: ColorAtom
                {
                	mColorAtom(); 

                }
                break;
            case 52 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:353: IntAtom
                {
                	mIntAtom(); 

                }
                break;
            case 53 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:361: FloatAtom
                {
                	mFloatAtom(); 

                }
                break;
            case 54 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:371: StringAtom
                {
                	mStringAtom(); 

                }
                break;
            case 55 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:382: Identifier
                {
                	mIdentifier(); 

                }
                break;
            case 56 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:393: Comment
                {
                	mComment(); 

                }
                break;
            case 57 :
                // D:\\sgl4c#\\NewSGLGramma\\SGL.g:1:401: WhiteSpace
                {
                	mWhiteSpace(); 

                }
                break;

        }

    }


    protected DFA3 dfa3;
    protected DFA11 dfa11;
    protected DFA18 dfa18;
	private void InitializeCyclicDFAs()
	{
	    this.dfa3 = new DFA3(this);
	    this.dfa11 = new DFA11(this);
	    this.dfa18 = new DFA18(this);
	}

    const string DFA3_eotS =
        "\x11\uffff\x01\x15\x07\uffff";
    const string DFA3_eofS =
        "\x19\uffff";
    const string DFA3_minS =
        "\x01\x42\x01\x6f\x01\x65\x01\x6f\x01\x70\x01\x6e\x01\x74\x01\x43"+
        "\x02\x74\x03\uffff\x01\x72\x01\x6f\x01\x65\x01\x6d\x01\x4c\x01\x43"+
        "\x06\uffff";
    const string DFA3_maxS =
        "\x01\x54\x01\x6f\x01\x65\x01\x6f\x01\x70\x01\x6e\x01\x74\x01\x52"+
        "\x02\x74\x03\uffff\x01\x72\x01\x6f\x01\x65\x01\x6d\x02\x52\x06\uffff";
    const string DFA3_acceptS =
        "\x0a\uffff\x01\x01\x01\x02\x01\x03\x06\uffff\x01\x04\x01\x06\x01"+
        "\x05\x01\x07\x01\x08\x01\x09";
    const string DFA3_specialS =
        "\x19\uffff}>";
    static readonly string[] DFA3_transitionS = {
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

    static readonly short[] DFA3_eot = DFA.UnpackEncodedString(DFA3_eotS);
    static readonly short[] DFA3_eof = DFA.UnpackEncodedString(DFA3_eofS);
    static readonly char[] DFA3_min = DFA.UnpackEncodedStringToUnsignedChars(DFA3_minS);
    static readonly char[] DFA3_max = DFA.UnpackEncodedStringToUnsignedChars(DFA3_maxS);
    static readonly short[] DFA3_accept = DFA.UnpackEncodedString(DFA3_acceptS);
    static readonly short[] DFA3_special = DFA.UnpackEncodedString(DFA3_specialS);
    static readonly short[][] DFA3_transition = DFA.UnpackEncodedStringArray(DFA3_transitionS);

    protected class DFA3 : DFA
    {
        public DFA3(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 3;
            this.eot = DFA3_eot;
            this.eof = DFA3_eof;
            this.min = DFA3_min;
            this.max = DFA3_max;
            this.accept = DFA3_accept;
            this.special = DFA3_special;
            this.transition = DFA3_transition;

        }

        override public string Description
        {
            get { return "467:1: OriginAtom : ( 'TopLeft' | 'TopCentre' | 'TopRight' | 'CentreLeft' | 'Centre' | 'CentreRight' | 'BottomLeft' | 'BottomCentre' | 'BottomRight' );"; }
        }

    }

    const string DFA11_eotS =
        "\x01\uffff\x01\x04\x03\uffff";
    const string DFA11_eofS =
        "\x05\uffff";
    const string DFA11_minS =
        "\x02\x2e\x03\uffff";
    const string DFA11_maxS =
        "\x02\x39\x03\uffff";
    const string DFA11_acceptS =
        "\x02\uffff\x01\x02\x01\x01\x01\x03";
    const string DFA11_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA11_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x03\x01\uffff\x0a\x01",
            "",
            "",
            ""
    };

    static readonly short[] DFA11_eot = DFA.UnpackEncodedString(DFA11_eotS);
    static readonly short[] DFA11_eof = DFA.UnpackEncodedString(DFA11_eofS);
    static readonly char[] DFA11_min = DFA.UnpackEncodedStringToUnsignedChars(DFA11_minS);
    static readonly char[] DFA11_max = DFA.UnpackEncodedStringToUnsignedChars(DFA11_maxS);
    static readonly short[] DFA11_accept = DFA.UnpackEncodedString(DFA11_acceptS);
    static readonly short[] DFA11_special = DFA.UnpackEncodedString(DFA11_specialS);
    static readonly short[][] DFA11_transition = DFA.UnpackEncodedStringArray(DFA11_transitionS);

    protected class DFA11 : DFA
    {
        public DFA11(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 11;
            this.eot = DFA11_eot;
            this.eof = DFA11_eof;
            this.min = DFA11_min;
            this.max = DFA11_max;
            this.accept = DFA11_accept;
            this.special = DFA11_special;
            this.transition = DFA11_transition;

        }

        override public string Description
        {
            get { return "493:1: FloatAtom : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ );"; }
        }

    }

    const string DFA18_eotS =
        "\x05\uffff\x01\x30\x01\x34\x02\uffff\x01\x35\x02\uffff\x02\x30"+
        "\x04\uffff\x01\x3a\x01\x3c\x01\x3e\x01\x40\x01\x42\x01\uffff\x01"+
        "\x44\x02\uffff\x12\x30\x01\uffff\x01\x5d\x03\uffff\x01\x30\x04\uffff"+
        "\x02\x30\x0c\uffff\x07\x30\x01\x68\x01\x30\x01\x6a\x0e\x30\x01\uffff"+
        "\x03\x30\x01\x7c\x04\x30\x01\u0081\x01\x30\x01\uffff\x01\x30\x01"+
        "\uffff\x01\u0084\x10\x30\x01\uffff\x01\u0097\x03\x30\x01\uffff\x01"+
        "\x30\x01\u009c\x01\uffff\x01\u009d\x03\x30\x01\u00a1\x03\x30\x01"+
        "\u00a6\x01\x30\x01\u00a6\x07\x30\x01\uffff\x01\u00af\x01\x30\x01"+
        "\u00b1\x01\u009d\x02\uffff\x03\x30\x01\uffff\x04\x30\x01\uffff\x05"+
        "\x30\x01\u00be\x01\u00bf\x01\x30\x01\uffff\x01\u00c1\x01\uffff\x01"+
        "\u00c2\x01\x30\x01\u00c4\x08\x30\x01\u00d1\x05\uffff\x01\x30\x01"+
        "\uffff\x07\x30\x01\u00d1\x04\x30\x01\uffff\x02\x30\x01\u00e0\x06"+
        "\x30\x01\u00d1\x02\x30\x01\u00e9\x01\x30\x01\uffff\x05\x30\x01\u00d1"+
        "\x02\x30\x01\uffff\x01\x30\x01\u00a6\x01\u00d1\x02\x30\x01\u00a6"+
        "\x01\u00d1\x01\x30\x01\u00e0\x01\x30\x03\u00d1";
    const string DFA18_eofS =
        "\u00f7\uffff";
    const string DFA18_minS =
        "\x01\x09\x04\uffff\x01\x6c\x01\x3d\x02\uffff\x01\x30\x02\uffff"+
        "\x01\x65\x01\x62\x04\uffff\x03\x3d\x01\x2b\x01\x2d\x01\uffff\x01"+
        "\x2a\x02\uffff\x01\x65\x01\x72\x01\x65\x01\x68\x01\x61\x01\x66\x01"+
        "\x6c\x01\x74\x01\x61\x01\x72\x01\x70\x01\x6e\x01\x69\x03\x61\x01"+
        "\x6f\x01\x65\x01\uffff\x01\x2e\x03\uffff\x01\x6f\x04\uffff\x01\x74"+
        "\x01\x6a\x0c\uffff\x01\x77\x01\x6c\x01\x65\x01\x74\x01\x69\x01\x72"+
        "\x01\x6c\x01\x30\x01\x73\x01\x30\x01\x72\x01\x75\x01\x72\x01\x69"+
        "\x01\x72\x01\x73\x01\x6f\x01\x63\x01\x74\x01\x69\x01\x72\x01\x73"+
        "\x01\x70\x01\x6e\x01\uffff\x01\x62\x01\x68\x01\x65\x01\x30\x01\x6c"+
        "\x01\x61\x01\x75\x01\x6c\x01\x30\x01\x73\x01\uffff\x01\x65\x01\uffff"+
        "\x01\x30\x01\x65\x01\x69\x01\x6d\x01\x69\x01\x74\x01\x70\x01\x6b"+
        "\x01\x74\x01\x6c\x01\x65\x01\x73\x01\x43\x01\x74\x01\x61\x01\x6f"+
        "\x01\x63\x01\uffff\x01\x30\x01\x6b\x01\x72\x01\x65\x01\uffff\x01"+
        "\x65\x01\x30\x01\uffff\x01\x30\x01\x74\x01\x61\x01\x63\x01\x30\x01"+
        "\x46\x01\x67\x01\x6f\x01\x30\x01\x67\x01\x30\x02\x65\x01\x69\x01"+
        "\x72\x01\x6c\x01\x64\x01\x74\x01\uffff\x01\x30\x01\x6e\x02\x30\x02"+
        "\uffff\x01\x65\x01\x74\x01\x73\x01\uffff\x01\x6f\x01\x6e\x01\x72"+
        "\x01\x6d\x01\uffff\x01\x72\x01\x66\x01\x6e\x01\x67\x01\x65\x02\x30"+
        "\x01\x20\x01\uffff\x01\x30\x01\uffff\x01\x30\x01\x69\x01\x30\x01"+
        "\x72\x01\x63\x01\x6f\x01\x43\x01\x6f\x02\x74\x01\x68\x01\x30\x05"+
        "\uffff\x01\x6f\x01\uffff\x02\x65\x01\x75\x02\x65\x01\x69\x01\x75"+
        "\x01\x30\x01\x72\x01\x74\x01\x65\x01\x69\x01\uffff\x01\x6e\x01\x76"+
        "\x01\x30\x01\x6e\x01\x66\x01\x6e\x01\x67\x01\x6e\x01\x65\x01\x30"+
        "\x01\x66\x01\x67\x01\x30\x01\x65\x01\uffff\x01\x64\x02\x74\x01\x68"+
        "\x01\x64\x01\x30\x01\x74\x01\x68\x01\uffff\x01\x72\x02\x30\x01\x72"+
        "\x01\x74\x02\x30\x01\x74\x01\x30\x01\x65\x03\x30";
    const string DFA18_maxS =
        "\x01\ufaff\x04\uffff\x01\x6c\x01\x3d\x02\uffff\x01\x39\x02\uffff"+
        "\x01\x65\x01\x62\x04\uffff\x03\x3d\x01\x2b\x01\x2d\x01\uffff\x01"+
        "\x2f\x02\uffff\x01\x75\x01\x72\x01\x65\x01\x68\x01\x6f\x01\x66\x01"+
        "\x6c\x01\x74\x01\x61\x01\x72\x01\x70\x01\x6e\x01\x79\x02\x6f\x01"+
        "\x61\x01\x6f\x01\x65\x01\uffff\x01\x39\x03\uffff\x01\x6f\x04\uffff"+
        "\x01\x74\x01\x6a\x0c\uffff\x01\x77\x01\x6c\x01\x65\x01\x74\x01\x69"+
        "\x01\x72\x01\x6c\x01\ufaff\x01\x73\x01\ufaff\x01\x72\x01\x75\x01"+
        "\x72\x01\x69\x01\x72\x01\x73\x01\x6f\x01\x63\x01\x74\x01\x69\x01"+
        "\x72\x01\x73\x01\x70\x01\x6e\x01\uffff\x01\x62\x01\x68\x01\x65\x01"+
        "\ufaff\x01\x6c\x01\x61\x01\x75\x01\x6c\x01\ufaff\x01\x73\x01\uffff"+
        "\x01\x65\x01\uffff\x01\ufaff\x01\x65\x01\x69\x01\x6d\x01\x69\x01"+
        "\x74\x01\x70\x01\x6b\x01\x74\x01\x6c\x01\x65\x01\x73\x01\x52\x01"+
        "\x74\x01\x61\x01\x6f\x01\x63\x01\uffff\x01\ufaff\x01\x6b\x01\x72"+
        "\x01\x65\x01\uffff\x01\x65\x01\ufaff\x01\uffff\x01\ufaff\x01\x74"+
        "\x01\x61\x01\x63\x01\ufaff\x01\x4f\x01\x67\x01\x6f\x01\ufaff\x01"+
        "\x67\x01\ufaff\x02\x65\x01\x69\x01\x72\x01\x6c\x01\x64\x01\x74\x01"+
        "\uffff\x01\ufaff\x01\x6e\x02\ufaff\x02\uffff\x01\x65\x01\x74\x01"+
        "\x73\x01\uffff\x01\x6f\x01\x6e\x01\x72\x01\x6d\x01\uffff\x01\x72"+
        "\x01\x66\x01\x6e\x01\x67\x01\x65\x02\ufaff\x01\x20\x01\uffff\x01"+
        "\ufaff\x01\uffff\x01\ufaff\x01\x69\x01\ufaff\x01\x72\x01\x63\x01"+
        "\x6f\x01\x52\x01\x6f\x02\x74\x01\x68\x01\ufaff\x05\uffff\x01\x6f"+
        "\x01\uffff\x02\x65\x01\x75\x02\x65\x01\x69\x01\x75\x01\ufaff\x01"+
        "\x72\x01\x74\x01\x65\x01\x69\x01\uffff\x01\x6e\x01\x76\x01\ufaff"+
        "\x01\x6e\x01\x66\x01\x6e\x01\x67\x01\x6e\x01\x65\x01\ufaff\x01\x66"+
        "\x01\x67\x01\ufaff\x01\x65\x01\uffff\x01\x64\x02\x74\x01\x68\x01"+
        "\x64\x01\ufaff\x01\x74\x01\x68\x01\uffff\x01\x72\x02\ufaff\x01\x72"+
        "\x01\x74\x02\ufaff\x01\x74\x01\ufaff\x01\x65\x03\ufaff";
    const string DFA18_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x02\uffff\x01\x07\x01"+
        "\x08\x01\uffff\x01\x0a\x01\x0b\x02\uffff\x01\x0e\x01\x0f\x01\x10"+
        "\x01\x11\x05\uffff\x01\x1a\x01\uffff\x01\x1c\x01\x1d\x12\uffff\x01"+
        "\x33\x01\uffff\x01\x36\x01\x37\x01\x39\x01\uffff\x01\x12\x01\x06"+
        "\x01\x09\x01\x35\x02\uffff\x01\x13\x01\x1e\x01\x16\x01\x14\x01\x17"+
        "\x01\x15\x01\x1f\x01\x18\x01\x20\x01\x19\x01\x38\x01\x1b\x18\uffff"+
        "\x01\x34\x0a\uffff\x01\x26\x01\uffff\x01\x28\x11\uffff\x01\x21\x04"+
        "\uffff\x01\x25\x02\uffff\x01\x29\x12\uffff\x01\x2b\x04\uffff\x01"+
        "\x27\x01\x2a\x03\uffff\x01\x2f\x04\uffff\x01\x30\x08\uffff\x01\x22"+
        "\x01\uffff\x01\x24\x0c\uffff\x01\x05\x01\x0c\x01\x0d\x01\x23\x01"+
        "\x2c\x01\uffff\x01\x2e\x0c\uffff\x01\x31\x0e\uffff\x01\x32\x08\uffff"+
        "\x01\x2d\x0d\uffff";
    const string DFA18_specialS =
        "\u00f7\uffff}>";
    static readonly string[] DFA18_transitionS = {
            "\x02\x31\x02\uffff\x01\x31\x12\uffff\x01\x31\x01\x12\x01\x2f"+
            "\x01\x2d\x01\uffff\x01\x19\x01\x11\x01\uffff\x01\x0a\x01\x0b"+
            "\x01\x17\x01\x15\x01\x04\x01\x16\x01\x09\x01\x18\x0a\x2e\x01"+
            "\x0f\x01\x03\x01\x13\x01\x06\x01\x14\x01\x0e\x01\uffff\x01\x26"+
            "\x01\x28\x01\x2c\x02\x30\x01\x29\x05\x30\x01\x27\x03\x30\x01"+
            "\x2a\x02\x30\x01\x25\x01\x2b\x06\x30\x01\x07\x01\uffff\x01\x08"+
            "\x01\x1a\x01\x30\x01\uffff\x01\x22\x01\x1c\x02\x30\x01\x21\x01"+
            "\x1f\x01\x05\x01\x30\x01\x20\x03\x30\x01\x0c\x01\x1b\x01\x0d"+
            "\x02\x30\x01\x1d\x01\x30\x01\x24\x01\x30\x01\x23\x01\x1e\x03"+
            "\x30\x01\x01\x01\x10\x01\x02\x42\uffff\x17\x30\x01\uffff\x1f"+
            "\x30\x01\uffff\u1f08\x30\u1040\uffff\u0150\x30\u0170\uffff\u0080"+
            "\x30\u0080\uffff\u092e\x30\u10d2\uffff\u5200\x30\u5900\uffff"+
            "\u0200\x30",
            "",
            "",
            "",
            "",
            "\x01\x32",
            "\x01\x33",
            "",
            "",
            "\x0a\x36",
            "",
            "",
            "\x01\x37",
            "\x01\x38",
            "",
            "",
            "",
            "",
            "\x01\x39",
            "\x01\x3b",
            "\x01\x3d",
            "\x01\x3f",
            "\x01\x41",
            "",
            "\x01\x43\x04\uffff\x01\x43",
            "",
            "",
            "\x01\x45\x0f\uffff\x01\x46",
            "\x01\x47",
            "\x01\x48",
            "\x01\x49",
            "\x01\x4b\x0d\uffff\x01\x4a",
            "\x01\x4c",
            "\x01\x4d",
            "\x01\x4e",
            "\x01\x4f",
            "\x01\x50",
            "\x01\x51",
            "\x01\x52",
            "\x01\x54\x05\uffff\x01\x55\x09\uffff\x01\x53",
            "\x01\x56\x0d\uffff\x01\x57",
            "\x01\x58\x0d\uffff\x01\x59",
            "\x01\x5a",
            "\x01\x5b",
            "\x01\x5c",
            "",
            "\x01\x36\x01\uffff\x0a\x2e",
            "",
            "",
            "",
            "\x01\x5e",
            "",
            "",
            "",
            "",
            "\x01\x5f",
            "\x01\x60",
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
            "\x01\x61",
            "\x01\x62",
            "\x01\x63",
            "\x01\x64",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\x69",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
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
            "",
            "\x01\x79",
            "\x01\x7a",
            "\x01\x7b",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\x7d",
            "\x01\x7e",
            "\x01\x7f",
            "\x01\u0080",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u0082",
            "",
            "\x01\u0083",
            "",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u0085",
            "\x01\u0086",
            "\x01\u0087",
            "\x01\u0088",
            "\x01\u0089",
            "\x01\u008a",
            "\x01\u008b",
            "\x01\u008c",
            "\x01\u008d",
            "\x01\u008e",
            "\x01\u008f",
            "\x01\u0091\x08\uffff\x01\u0090\x05\uffff\x01\u0092",
            "\x01\u0093",
            "\x01\u0094",
            "\x01\u0095",
            "\x01\u0096",
            "",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u0098",
            "\x01\u0099",
            "\x01\u009a",
            "",
            "\x01\u009b",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u009e",
            "\x01\u009f",
            "\x01\u00a0",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00a2\x08\uffff\x01\u00a3",
            "\x01\u00a4",
            "\x01\u00a5",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00a7",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00a8",
            "\x01\u00a9",
            "\x01\u00aa",
            "\x01\u00ab",
            "\x01\u00ac",
            "\x01\u00ad",
            "\x01\u00ae",
            "",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00b0",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "",
            "",
            "\x01\u00b2",
            "\x01\u00b3",
            "\x01\u00b4",
            "",
            "\x01\u00b5",
            "\x01\u00b6",
            "\x01\u00b7",
            "\x01\u00b8",
            "",
            "\x01\u00b9",
            "\x01\u00ba",
            "\x01\u00bb",
            "\x01\u00bc",
            "\x01\u00bd",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00c0",
            "",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00c3",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00c5",
            "\x01\u00c6",
            "\x01\u00c7",
            "\x01\u00c9\x08\uffff\x01\u00c8\x05\uffff\x01\u00ca",
            "\x01\u00cb",
            "\x01\u00cc",
            "\x01\u00cd",
            "\x01\u00ce",
            "\x0a\x30\x07\uffff\x0b\x30\x01\u00cf\x05\x30\x01\u00d0\x08"+
            "\x30\x04\uffff\x01\x30\x01\uffff\x1a\x30\x45\uffff\x17\x30\x01"+
            "\uffff\x1f\x30\x01\uffff\u1f08\x30\u1040\uffff\u0150\x30\u0170"+
            "\uffff\u0080\x30\u0080\uffff\u092e\x30\u10d2\uffff\u5200\x30"+
            "\u5900\uffff\u0200\x30",
            "",
            "",
            "",
            "",
            "",
            "\x01\u00d2",
            "",
            "\x01\u00d3",
            "\x01\u00d4",
            "\x01\u00d5",
            "\x01\u00d6",
            "\x01\u00d7",
            "\x01\u00d8",
            "\x01\u00d9",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00da",
            "\x01\u00db",
            "\x01\u00dc",
            "\x01\u00dd",
            "",
            "\x01\u00de",
            "\x01\u00df",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00e1",
            "\x01\u00e2",
            "\x01\u00e3",
            "\x01\u00e4",
            "\x01\u00e5",
            "\x01\u00e6",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00e7",
            "\x01\u00e8",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00ea",
            "",
            "\x01\u00eb",
            "\x01\u00ec",
            "\x01\u00ed",
            "\x01\u00ee",
            "\x01\u00ef",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00f0",
            "\x01\u00f1",
            "",
            "\x01\u00f2",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00f3",
            "\x01\u00f4",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00f5",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x01\u00f6",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30",
            "\x0a\x30\x07\uffff\x1a\x30\x04\uffff\x01\x30\x01\uffff\x1a"+
            "\x30\x45\uffff\x17\x30\x01\uffff\x1f\x30\x01\uffff\u1f08\x30"+
            "\u1040\uffff\u0150\x30\u0170\uffff\u0080\x30\u0080\uffff\u092e"+
            "\x30\u10d2\uffff\u5200\x30\u5900\uffff\u0200\x30"
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
            get { return "1:1: Tokens : ( T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | T__86 | T__87 | T__88 | T__89 | VarStartInit | BooleanAtom | Null | Sprite | Animation | Lyrics | List | LayerAtom | OriginAtom | LoopTypeAtom | ColorAtom | IntAtom | FloatAtom | StringAtom | Identifier | Comment | WhiteSpace );"; }
        }

    }

 
    
}
}