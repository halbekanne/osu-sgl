// $ANTLR 3.2 Sep 23, 2009 12:02:23 E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g 2013-02-20 00:37:16

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


namespace  SGL.Antlr 
{
internal partial class SGLLexer : Lexer {
    public const int T__68 = 68;
    public const int T__69 = 69;
    public const int T__66 = 66;
    public const int T__67 = 67;
    public const int CLASS = 30;
    public const int T__64 = 64;
    public const int T__65 = 65;
    public const int DEF = 5;
    public const int T__62 = 62;
    public const int VAR_LIST = 18;
    public const int T__63 = 63;
    public const int Array = 43;
    public const int IntAtom = 33;
    public const int EXP_LIST = 17;
    public const int LoopTypeAtom = 38;
    public const int UTF8Letter = 46;
    public const int T__61 = 61;
    public const int EOF = -1;
    public const int T__60 = 60;
    public const int HexDigit = 44;
    public const int BREAK = 21;
    public const int Identifier = 31;
    public const int IF = 24;
    public const int FUNC_CALL = 19;
    public const int AT = 23;
    public const int T__55 = 55;
    public const int T__56 = 56;
    public const int T__57 = 57;
    public const int T__58 = 58;
    public const int T__51 = 51;
    public const int T__52 = 52;
    public const int T__53 = 53;
    public const int T__54 = 54;
    public const int Comment = 48;
    public const int EXP = 25;
    public const int OBJ_FUNC_CALL = 20;
    public const int FORITER = 28;
    public const int T__59 = 59;
    public const int INT_NEGATE = 9;
    public const int RETURN = 22;
    public const int UTF8Digit = 47;
    public const int WhiteSpace = 49;
    public const int T__50 = 50;
    public const int VARDEC = 12;
    public const int OriginAtom = 37;
    public const int Null = 41;
    public const int LayerAtom = 36;
    public const int GLOBAL_ASSIGN = 29;
    public const int T__80 = 80;
    public const int T__81 = 81;
    public const int T__82 = 82;
    public const int T__83 = 83;
    public const int FORDEC = 26;
    public const int StringAtom = 32;
    public const int INDEXES = 14;
    public const int LoopTriggerAtom = 39;
    public const int ColorAtom = 40;
    public const int T__85 = 85;
    public const int T__84 = 84;
    public const int LIST = 16;
    public const int T__87 = 87;
    public const int T__86 = 86;
    public const int T__88 = 88;
    public const int BOOL_NEGATE = 10;
    public const int BooleanAtom = 35;
    public const int LOOKUP = 15;
    public const int T__71 = 71;
    public const int FORCOND = 27;
    public const int T__72 = 72;
    public const int VARIABLE = 13;
    public const int T__70 = 70;
    public const int BLOCK = 4;
    public const int ASSIGN = 7;
    public const int VarStartInit = 42;
    public const int GLOBALDEF = 6;
    public const int T__76 = 76;
    public const int FloatAtom = 34;
    public const int T__75 = 75;
    public const int T__74 = 74;
    public const int VARINC = 11;
    public const int T__73 = 73;
    public const int EscapeSequence = 45;
    public const int T__79 = 79;
    public const int T__78 = 78;
    public const int STRING = 8;
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
    	get { return "E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g";} 
    }

    // $ANTLR start "T__50"
    public void mT__50() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__50;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:14:7: ( '{' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:14:9: '{'
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:15:7: ( '}' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:15:9: '}'
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:16:7: ( ';' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:16:9: ';'
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:17:7: ( ',' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:17:9: ','
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:18:7: ( '=' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:18:9: '='
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
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public void mT__55() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__55;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:19:7: ( 'global' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:19:9: 'global'
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
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public void mT__56() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__56;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:20:7: ( '[' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:20:9: '['
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:21:7: ( ']' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:21:9: ']'
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:22:7: ( '.' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:22:9: '.'
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:23:7: ( '(' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:23:9: '('
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:24:7: ( ')' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:24:9: ')'
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:25:7: ( 'function' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:25:9: 'function'
            {
            	Match("function"); 


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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:26:7: ( '?' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:26:9: '?'
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
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public void mT__63() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__63;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:27:7: ( ':' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:27:9: ':'
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
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public void mT__64() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__64;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:28:7: ( '||' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:28:9: '||'
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
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public void mT__65() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__65;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:29:7: ( '&&' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:29:9: '&&'
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
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public void mT__66() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__66;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:30:7: ( '==' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:30:9: '=='
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
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public void mT__67() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__67;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:31:7: ( '!=' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:31:9: '!='
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
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public void mT__68() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__68;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:32:7: ( '<' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:32:9: '<'
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
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public void mT__69() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__69;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:33:7: ( '>' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:33:9: '>'
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
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public void mT__70() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__70;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:34:7: ( '<=' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:34:9: '<='
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
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public void mT__71() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__71;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:35:7: ( '>=' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:35:9: '>='
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
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public void mT__72() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__72;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:36:7: ( '+' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:36:9: '+'
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
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public void mT__73() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__73;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:37:7: ( '-' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:37:9: '-'
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
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public void mT__74() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__74;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:38:7: ( '*' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:38:9: '*'
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
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public void mT__75() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__75;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:39:7: ( '/' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:39:9: '/'
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
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public void mT__76() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__76;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:40:7: ( '%' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:40:9: '%'
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
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public void mT__77() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__77;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:41:7: ( '^' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:41:9: '^'
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
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public void mT__78() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__78;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:42:7: ( '!' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:42:9: '!'
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
    // $ANTLR end "T__78"

    // $ANTLR start "T__79"
    public void mT__79() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__79;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:43:7: ( '++' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:43:9: '++'
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
    // $ANTLR end "T__79"

    // $ANTLR start "T__80"
    public void mT__80() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__80;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:44:7: ( '--' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:44:9: '--'
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
    // $ANTLR end "T__80"

    // $ANTLR start "T__81"
    public void mT__81() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__81;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:45:7: ( 'new' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:45:9: 'new'
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
    // $ANTLR end "T__81"

    // $ANTLR start "T__82"
    public void mT__82() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__82;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:46:7: ( 'break' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:46:9: 'break'
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
    // $ANTLR end "T__82"

    // $ANTLR start "T__83"
    public void mT__83() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__83;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:47:7: ( 'return' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:47:9: 'return'
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
    // $ANTLR end "T__83"

    // $ANTLR start "T__84"
    public void mT__84() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__84;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:48:7: ( 'while' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:48:9: 'while'
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
    // $ANTLR end "T__84"

    // $ANTLR start "T__85"
    public void mT__85() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__85;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:49:7: ( 'for' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:49:9: 'for'
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
    // $ANTLR end "T__85"

    // $ANTLR start "T__86"
    public void mT__86() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__86;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:50:7: ( 'if' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:50:9: 'if'
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
    // $ANTLR end "T__86"

    // $ANTLR start "T__87"
    public void mT__87() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__87;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:51:7: ( 'else' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:51:9: 'else'
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
    // $ANTLR end "T__87"

    // $ANTLR start "T__88"
    public void mT__88() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = T__88;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:52:7: ( 'at' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:52:9: 'at'
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
    // $ANTLR end "T__88"

    // $ANTLR start "VarStartInit"
    public void mVarStartInit() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = VarStartInit;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:446:2: ( 'var' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:446:4: 'var'
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:451:5: ( 'true' | 'false' )
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
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:451:9: 'true'
                    {
                    	Match("true"); 


                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:452:9: 'false'
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:456:2: ( 'null' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:456:4: 'null'
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

    // $ANTLR start "Array"
    public void mArray() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = Array;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:475:2: ( 'Array' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:475:4: 'Array'
            {
            	Match("Array"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally 
    	{
        }
    }
    // $ANTLR end "Array"

    // $ANTLR start "LayerAtom"
    public void mLayerAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LayerAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:479:2: ( 'Background' | 'Fail' | 'Pass' | 'Foreground' )
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
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:479:4: 'Background'
                    {
                    	Match("Background"); 


                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:480:4: 'Fail'
                    {
                    	Match("Fail"); 


                    }
                    break;
                case 3 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:481:4: 'Pass'
                    {
                    	Match("Pass"); 


                    }
                    break;
                case 4 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:482:4: 'Foreground'
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:486:2: ( 'TopLeft' | 'TopCentre' | 'TopRight' | 'CentreLeft' | 'Centre' | 'CentreRight' | 'BottomLeft' | 'BottomCentre' | 'BottomRight' )
            int alt3 = 9;
            alt3 = dfa3.Predict(input);
            switch (alt3) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:486:4: 'TopLeft'
                    {
                    	Match("TopLeft"); 


                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:487:4: 'TopCentre'
                    {
                    	Match("TopCentre"); 


                    }
                    break;
                case 3 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:488:4: 'TopRight'
                    {
                    	Match("TopRight"); 


                    }
                    break;
                case 4 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:489:4: 'CentreLeft'
                    {
                    	Match("CentreLeft"); 


                    }
                    break;
                case 5 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:490:4: 'Centre'
                    {
                    	Match("Centre"); 


                    }
                    break;
                case 6 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:491:4: 'CentreRight'
                    {
                    	Match("CentreRight"); 


                    }
                    break;
                case 7 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:492:4: 'BottomLeft'
                    {
                    	Match("BottomLeft"); 


                    }
                    break;
                case 8 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:493:4: 'BottomCentre'
                    {
                    	Match("BottomCentre"); 


                    }
                    break;
                case 9 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:494:4: 'BottomRight'
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:498:2: ( 'LoopForever' | 'LoopOnce' )
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
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:498:4: 'LoopForever'
                    {
                    	Match("LoopForever"); 


                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:499:4: 'LoopOnce'
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

    // $ANTLR start "LoopTriggerAtom"
    public void mLoopTriggerAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = LoopTriggerAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:503:2: ( 'HitSoundClap' | 'HitSoundFinish' | 'HitSoundWhistle' | 'Passing' | 'Failing' )
            int alt5 = 5;
            alt5 = dfa5.Predict(input);
            switch (alt5) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:503:4: 'HitSoundClap'
                    {
                    	Match("HitSoundClap"); 


                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:504:4: 'HitSoundFinish'
                    {
                    	Match("HitSoundFinish"); 


                    }
                    break;
                case 3 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:505:4: 'HitSoundWhistle'
                    {
                    	Match("HitSoundWhistle"); 


                    }
                    break;
                case 4 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:506:4: 'Passing'
                    {
                    	Match("Passing"); 


                    }
                    break;
                case 5 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:507:4: 'Failing'
                    {
                    	Match("Failing"); 


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
    // $ANTLR end "LoopTriggerAtom"

    // $ANTLR start "ColorAtom"
    public void mColorAtom() // throws RecognitionException [2]
    {
    		try
    		{
            int _type = ColorAtom;
    	int _channel = DEFAULT_TOKEN_CHANNEL;
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:511:2: ( '#' HexDigit HexDigit HexDigit | '#' HexDigit HexDigit HexDigit HexDigit HexDigit HexDigit )
            int alt6 = 2;
            int LA6_0 = input.LA(1);

            if ( (LA6_0 == '#') )
            {
                int LA6_1 = input.LA(2);

                if ( ((LA6_1 >= '0' && LA6_1 <= '9') || (LA6_1 >= 'A' && LA6_1 <= 'F') || (LA6_1 >= 'a' && LA6_1 <= 'f')) )
                {
                    int LA6_2 = input.LA(3);

                    if ( ((LA6_2 >= '0' && LA6_2 <= '9') || (LA6_2 >= 'A' && LA6_2 <= 'F') || (LA6_2 >= 'a' && LA6_2 <= 'f')) )
                    {
                        int LA6_3 = input.LA(4);

                        if ( ((LA6_3 >= '0' && LA6_3 <= '9') || (LA6_3 >= 'A' && LA6_3 <= 'F') || (LA6_3 >= 'a' && LA6_3 <= 'f')) )
                        {
                            int LA6_4 = input.LA(5);

                            if ( ((LA6_4 >= '0' && LA6_4 <= '9') || (LA6_4 >= 'A' && LA6_4 <= 'F') || (LA6_4 >= 'a' && LA6_4 <= 'f')) )
                            {
                                alt6 = 2;
                            }
                            else 
                            {
                                alt6 = 1;}
                        }
                        else 
                        {
                            NoViableAltException nvae_d6s3 =
                                new NoViableAltException("", 6, 3, input);

                            throw nvae_d6s3;
                        }
                    }
                    else 
                    {
                        NoViableAltException nvae_d6s2 =
                            new NoViableAltException("", 6, 2, input);

                        throw nvae_d6s2;
                    }
                }
                else 
                {
                    NoViableAltException nvae_d6s1 =
                        new NoViableAltException("", 6, 1, input);

                    throw nvae_d6s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d6s0 =
                    new NoViableAltException("", 6, 0, input);

                throw nvae_d6s0;
            }
            switch (alt6) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:511:4: '#' HexDigit HexDigit HexDigit
                    {
                    	Match('#'); 
                    	mHexDigit(); 
                    	mHexDigit(); 
                    	mHexDigit(); 

                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:512:4: '#' HexDigit HexDigit HexDigit HexDigit HexDigit HexDigit
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:516:5: ( ( '0' .. '9' )+ )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:516:7: ( '0' .. '9' )+
            {
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:516:7: ( '0' .. '9' )+
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
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:516:7: '0' .. '9'
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:520:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ )
            int alt12 = 3;
            alt12 = dfa12.Predict(input);
            switch (alt12) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:520:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:520:9: ( '0' .. '9' )+
                    	int cnt8 = 0;
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
                    			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:520:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

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

                    	Match('.'); 
                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:520:25: ( '0' .. '9' )*
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
                    			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:520:26: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop9;
                    	    }
                    	} while (true);

                    	loop9:
                    		;	// Stops C# compiler whining that label 'loop9' has no statements


                    }
                    break;
                case 2 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:521:9: '.' ( '0' .. '9' )+
                    {
                    	Match('.'); 
                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:521:13: ( '0' .. '9' )+
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
                    			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:521:14: '0' .. '9'
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
                case 3 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:522:9: ( '0' .. '9' )+
                    {
                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:522:9: ( '0' .. '9' )+
                    	int cnt11 = 0;
                    	do 
                    	{
                    	    int alt11 = 2;
                    	    int LA11_0 = input.LA(1);

                    	    if ( ((LA11_0 >= '0' && LA11_0 <= '9')) )
                    	    {
                    	        alt11 = 1;
                    	    }


                    	    switch (alt11) 
                    		{
                    			case 1 :
                    			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:522:10: '0' .. '9'
                    			    {
                    			    	MatchRange('0','9'); 

                    			    }
                    			    break;

                    			default:
                    			    if ( cnt11 >= 1 ) goto loop11;
                    		            EarlyExitException eee11 =
                    		                new EarlyExitException(11, input);
                    		            throw eee11;
                    	    }
                    	    cnt11++;
                    	} while (true);

                    	loop11:
                    		;	// Stops C# compiler whining that label 'loop11' has no statements


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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:527:5: ( '\"' ( EscapeSequence | '\\\\' | ~ ( '\"' ) )* '\"' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:527:8: '\"' ( EscapeSequence | '\\\\' | ~ ( '\"' ) )* '\"'
            {
            	Match('\"'); 
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:527:12: ( EscapeSequence | '\\\\' | ~ ( '\"' ) )*
            	do 
            	{
            	    int alt13 = 4;
            	    int LA13_0 = input.LA(1);

            	    if ( (LA13_0 == '\\') )
            	    {
            	        int LA13_2 = input.LA(2);

            	        if ( (LA13_2 == '\"') )
            	        {
            	            int LA13_4 = input.LA(3);

            	            if ( ((LA13_4 >= '\u0000' && LA13_4 <= '\uFFFF')) )
            	            {
            	                alt13 = 1;
            	            }

            	            else 
            	            {
            	                alt13 = 2;
            	            }

            	        }
            	        else if ( (LA13_2 == '\\') )
            	        {
            	            alt13 = 1;
            	        }
            	        else if ( (LA13_2 == 'n' || LA13_2 == 'r') )
            	        {
            	            alt13 = 1;
            	        }
            	        else if ( ((LA13_2 >= '\u0000' && LA13_2 <= '!') || (LA13_2 >= '#' && LA13_2 <= '[') || (LA13_2 >= ']' && LA13_2 <= 'm') || (LA13_2 >= 'o' && LA13_2 <= 'q') || (LA13_2 >= 's' && LA13_2 <= '\uFFFF')) )
            	        {
            	            alt13 = 2;
            	        }


            	    }
            	    else if ( ((LA13_0 >= '\u0000' && LA13_0 <= '!') || (LA13_0 >= '#' && LA13_0 <= '[') || (LA13_0 >= ']' && LA13_0 <= '\uFFFF')) )
            	    {
            	        alt13 = 3;
            	    }


            	    switch (alt13) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:527:14: EscapeSequence
            			    {
            			    	mEscapeSequence(); 

            			    }
            			    break;
            			case 2 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:527:31: '\\\\'
            			    {
            			    	Match('\\'); 

            			    }
            			    break;
            			case 3 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:527:38: ~ ( '\"' )
            			    {
            			    	if ( (input.LA(1) >= '\u0000' && input.LA(1) <= '!') || (input.LA(1) >= '#' && input.LA(1) <= '\uFFFF') ) 
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:532:5: ( UTF8Letter ( UTF8Letter | UTF8Digit )* )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:532:9: UTF8Letter ( UTF8Letter | UTF8Digit )*
            {
            	mUTF8Letter(); 
            	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:532:20: ( UTF8Letter | UTF8Digit )*
            	do 
            	{
            	    int alt14 = 2;
            	    int LA14_0 = input.LA(1);

            	    if ( ((LA14_0 >= '0' && LA14_0 <= '9') || (LA14_0 >= 'A' && LA14_0 <= 'Z') || LA14_0 == '_' || (LA14_0 >= 'a' && LA14_0 <= 'z') || (LA14_0 >= '\u00C0' && LA14_0 <= '\u00D6') || (LA14_0 >= '\u00D8' && LA14_0 <= '\u00F6') || (LA14_0 >= '\u00F8' && LA14_0 <= '\u1FFF') || (LA14_0 >= '\u3040' && LA14_0 <= '\u318F') || (LA14_0 >= '\u3300' && LA14_0 <= '\u337F') || (LA14_0 >= '\u3400' && LA14_0 <= '\u3D2D') || (LA14_0 >= '\u4E00' && LA14_0 <= '\u9FFF') || (LA14_0 >= '\uF900' && LA14_0 <= '\uFAFF')) )
            	    {
            	        alt14 = 1;
            	    }


            	    switch (alt14) 
            		{
            			case 1 :
            			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:
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
            			    goto loop14;
            	    }
            	} while (true);

            	loop14:
            		;	// Stops C# compiler whining that label 'loop14' has no statements


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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:539:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
            int alt18 = 2;
            int LA18_0 = input.LA(1);

            if ( (LA18_0 == '/') )
            {
                int LA18_1 = input.LA(2);

                if ( (LA18_1 == '/') )
                {
                    alt18 = 1;
                }
                else if ( (LA18_1 == '*') )
                {
                    alt18 = 2;
                }
                else 
                {
                    NoViableAltException nvae_d18s1 =
                        new NoViableAltException("", 18, 1, input);

                    throw nvae_d18s1;
                }
            }
            else 
            {
                NoViableAltException nvae_d18s0 =
                    new NoViableAltException("", 18, 0, input);

                throw nvae_d18s0;
            }
            switch (alt18) 
            {
                case 1 :
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:539:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    	Match("//"); 

                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:539:14: (~ ( '\\n' | '\\r' ) )*
                    	do 
                    	{
                    	    int alt15 = 2;
                    	    int LA15_0 = input.LA(1);

                    	    if ( ((LA15_0 >= '\u0000' && LA15_0 <= '\t') || (LA15_0 >= '\u000B' && LA15_0 <= '\f') || (LA15_0 >= '\u000E' && LA15_0 <= '\uFFFF')) )
                    	    {
                    	        alt15 = 1;
                    	    }


                    	    switch (alt15) 
                    		{
                    			case 1 :
                    			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:539:14: ~ ( '\\n' | '\\r' )
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
                    			    goto loop15;
                    	    }
                    	} while (true);

                    	loop15:
                    		;	// Stops C# compiler whining that label 'loop15' has no statements

                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:539:28: ( '\\r' )?
                    	int alt16 = 2;
                    	int LA16_0 = input.LA(1);

                    	if ( (LA16_0 == '\r') )
                    	{
                    	    alt16 = 1;
                    	}
                    	switch (alt16) 
                    	{
                    	    case 1 :
                    	        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:539:28: '\\r'
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
                    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:540:9: '/*' ( options {greedy=false; } : . )* '*/'
                    {
                    	Match("/*"); 

                    	// E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:540:14: ( options {greedy=false; } : . )*
                    	do 
                    	{
                    	    int alt17 = 2;
                    	    int LA17_0 = input.LA(1);

                    	    if ( (LA17_0 == '*') )
                    	    {
                    	        int LA17_1 = input.LA(2);

                    	        if ( (LA17_1 == '/') )
                    	        {
                    	            alt17 = 2;
                    	        }
                    	        else if ( ((LA17_1 >= '\u0000' && LA17_1 <= '.') || (LA17_1 >= '0' && LA17_1 <= '\uFFFF')) )
                    	        {
                    	            alt17 = 1;
                    	        }


                    	    }
                    	    else if ( ((LA17_0 >= '\u0000' && LA17_0 <= ')') || (LA17_0 >= '+' && LA17_0 <= '\uFFFF')) )
                    	    {
                    	        alt17 = 1;
                    	    }


                    	    switch (alt17) 
                    		{
                    			case 1 :
                    			    // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:540:42: .
                    			    {
                    			    	MatchAny(); 

                    			    }
                    			    break;

                    			default:
                    			    goto loop17;
                    	    }
                    	} while (true);

                    	loop17:
                    		;	// Stops C# compiler whining that label 'loop17' has no statements

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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:544:2: ( ( ' ' | '\\t' | '\\r' | '\\n' ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:544:6: ( ' ' | '\\t' | '\\r' | '\\n' )
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:558:5: ( '\\u0041' .. '\\u005a' | '\\u005f' | '\\u0061' .. '\\u007a' | '\\u00c0' .. '\\u00d6' | '\\u00d8' .. '\\u00f6' | '\\u00f8' .. '\\u00ff' | '\\u0100' .. '\\u1fff' | '\\u3040' .. '\\u318f' | '\\u3300' .. '\\u337f' | '\\u3400' .. '\\u3d2d' | '\\u4e00' .. '\\u9fff' | '\\uf900' .. '\\ufaff' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:574:5: ( '\\u0030' .. '\\u0039' | '\\u0660' .. '\\u0669' | '\\u06f0' .. '\\u06f9' | '\\u0966' .. '\\u096f' | '\\u09e6' .. '\\u09ef' | '\\u0a66' .. '\\u0a6f' | '\\u0ae6' .. '\\u0aef' | '\\u0b66' .. '\\u0b6f' | '\\u0be7' .. '\\u0bef' | '\\u0c66' .. '\\u0c6f' | '\\u0ce6' .. '\\u0cef' | '\\u0d66' .. '\\u0d6f' | '\\u0e50' .. '\\u0e59' | '\\u0ed0' .. '\\u0ed9' | '\\u1040' .. '\\u1049' )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:592:10: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:592:12: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
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
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:596:5: ( '\\\\' ( 'n' | 'r' | '\\\"' | '\\\\' ) )
            // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:596:9: '\\\\' ( 'n' | 'r' | '\\\"' | '\\\\' )
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
        // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:8: ( T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | T__86 | T__87 | T__88 | VarStartInit | BooleanAtom | Null | Array | LayerAtom | OriginAtom | LoopTypeAtom | LoopTriggerAtom | ColorAtom | IntAtom | FloatAtom | StringAtom | Identifier | Comment | WhiteSpace )
        int alt19 = 54;
        alt19 = dfa19.Predict(input);
        switch (alt19) 
        {
            case 1 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:10: T__50
                {
                	mT__50(); 

                }
                break;
            case 2 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:16: T__51
                {
                	mT__51(); 

                }
                break;
            case 3 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:22: T__52
                {
                	mT__52(); 

                }
                break;
            case 4 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:28: T__53
                {
                	mT__53(); 

                }
                break;
            case 5 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:34: T__54
                {
                	mT__54(); 

                }
                break;
            case 6 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:40: T__55
                {
                	mT__55(); 

                }
                break;
            case 7 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:46: T__56
                {
                	mT__56(); 

                }
                break;
            case 8 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:52: T__57
                {
                	mT__57(); 

                }
                break;
            case 9 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:58: T__58
                {
                	mT__58(); 

                }
                break;
            case 10 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:64: T__59
                {
                	mT__59(); 

                }
                break;
            case 11 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:70: T__60
                {
                	mT__60(); 

                }
                break;
            case 12 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:76: T__61
                {
                	mT__61(); 

                }
                break;
            case 13 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:82: T__62
                {
                	mT__62(); 

                }
                break;
            case 14 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:88: T__63
                {
                	mT__63(); 

                }
                break;
            case 15 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:94: T__64
                {
                	mT__64(); 

                }
                break;
            case 16 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:100: T__65
                {
                	mT__65(); 

                }
                break;
            case 17 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:106: T__66
                {
                	mT__66(); 

                }
                break;
            case 18 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:112: T__67
                {
                	mT__67(); 

                }
                break;
            case 19 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:118: T__68
                {
                	mT__68(); 

                }
                break;
            case 20 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:124: T__69
                {
                	mT__69(); 

                }
                break;
            case 21 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:130: T__70
                {
                	mT__70(); 

                }
                break;
            case 22 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:136: T__71
                {
                	mT__71(); 

                }
                break;
            case 23 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:142: T__72
                {
                	mT__72(); 

                }
                break;
            case 24 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:148: T__73
                {
                	mT__73(); 

                }
                break;
            case 25 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:154: T__74
                {
                	mT__74(); 

                }
                break;
            case 26 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:160: T__75
                {
                	mT__75(); 

                }
                break;
            case 27 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:166: T__76
                {
                	mT__76(); 

                }
                break;
            case 28 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:172: T__77
                {
                	mT__77(); 

                }
                break;
            case 29 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:178: T__78
                {
                	mT__78(); 

                }
                break;
            case 30 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:184: T__79
                {
                	mT__79(); 

                }
                break;
            case 31 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:190: T__80
                {
                	mT__80(); 

                }
                break;
            case 32 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:196: T__81
                {
                	mT__81(); 

                }
                break;
            case 33 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:202: T__82
                {
                	mT__82(); 

                }
                break;
            case 34 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:208: T__83
                {
                	mT__83(); 

                }
                break;
            case 35 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:214: T__84
                {
                	mT__84(); 

                }
                break;
            case 36 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:220: T__85
                {
                	mT__85(); 

                }
                break;
            case 37 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:226: T__86
                {
                	mT__86(); 

                }
                break;
            case 38 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:232: T__87
                {
                	mT__87(); 

                }
                break;
            case 39 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:238: T__88
                {
                	mT__88(); 

                }
                break;
            case 40 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:244: VarStartInit
                {
                	mVarStartInit(); 

                }
                break;
            case 41 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:257: BooleanAtom
                {
                	mBooleanAtom(); 

                }
                break;
            case 42 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:269: Null
                {
                	mNull(); 

                }
                break;
            case 43 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:274: Array
                {
                	mArray(); 

                }
                break;
            case 44 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:280: LayerAtom
                {
                	mLayerAtom(); 

                }
                break;
            case 45 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:290: OriginAtom
                {
                	mOriginAtom(); 

                }
                break;
            case 46 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:301: LoopTypeAtom
                {
                	mLoopTypeAtom(); 

                }
                break;
            case 47 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:314: LoopTriggerAtom
                {
                	mLoopTriggerAtom(); 

                }
                break;
            case 48 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:330: ColorAtom
                {
                	mColorAtom(); 

                }
                break;
            case 49 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:340: IntAtom
                {
                	mIntAtom(); 

                }
                break;
            case 50 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:348: FloatAtom
                {
                	mFloatAtom(); 

                }
                break;
            case 51 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:358: StringAtom
                {
                	mStringAtom(); 

                }
                break;
            case 52 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:369: Identifier
                {
                	mIdentifier(); 

                }
                break;
            case 53 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:380: Comment
                {
                	mComment(); 

                }
                break;
            case 54 :
                // E:\\SGL\\sgl4c#\\NewSGLGramma\\SGL.g:1:388: WhiteSpace
                {
                	mWhiteSpace(); 

                }
                break;

        }

    }


    protected DFA3 dfa3;
    protected DFA5 dfa5;
    protected DFA12 dfa12;
    protected DFA19 dfa19;
	private void InitializeCyclicDFAs()
	{
	    this.dfa3 = new DFA3(this);
	    this.dfa5 = new DFA5(this);
	    this.dfa12 = new DFA12(this);
	    this.dfa19 = new DFA19(this);
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
            get { return "485:1: OriginAtom : ( 'TopLeft' | 'TopCentre' | 'TopRight' | 'CentreLeft' | 'Centre' | 'CentreRight' | 'BottomLeft' | 'BottomCentre' | 'BottomRight' );"; }
        }

    }

    const string DFA5_eotS =
        "\x0e\uffff";
    const string DFA5_eofS =
        "\x0e\uffff";
    const string DFA5_minS =
        "\x01\x46\x01\x69\x02\uffff\x01\x74\x01\x53\x01\x6f\x01\x75\x01"+
        "\x6e\x01\x64\x01\x43\x03\uffff";
    const string DFA5_maxS =
        "\x01\x50\x01\x69\x02\uffff\x01\x74\x01\x53\x01\x6f\x01\x75\x01"+
        "\x6e\x01\x64\x01\x57\x03\uffff";
    const string DFA5_acceptS =
        "\x02\uffff\x01\x04\x01\x05\x07\uffff\x01\x01\x01\x02\x01\x03";
    const string DFA5_specialS =
        "\x0e\uffff}>";
    static readonly string[] DFA5_transitionS = {
            "\x01\x03\x01\uffff\x01\x01\x07\uffff\x01\x02",
            "\x01\x04",
            "",
            "",
            "\x01\x05",
            "\x01\x06",
            "\x01\x07",
            "\x01\x08",
            "\x01\x09",
            "\x01\x0a",
            "\x01\x0b\x02\uffff\x01\x0c\x10\uffff\x01\x0d",
            "",
            "",
            ""
    };

    static readonly short[] DFA5_eot = DFA.UnpackEncodedString(DFA5_eotS);
    static readonly short[] DFA5_eof = DFA.UnpackEncodedString(DFA5_eofS);
    static readonly char[] DFA5_min = DFA.UnpackEncodedStringToUnsignedChars(DFA5_minS);
    static readonly char[] DFA5_max = DFA.UnpackEncodedStringToUnsignedChars(DFA5_maxS);
    static readonly short[] DFA5_accept = DFA.UnpackEncodedString(DFA5_acceptS);
    static readonly short[] DFA5_special = DFA.UnpackEncodedString(DFA5_specialS);
    static readonly short[][] DFA5_transition = DFA.UnpackEncodedStringArray(DFA5_transitionS);

    protected class DFA5 : DFA
    {
        public DFA5(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 5;
            this.eot = DFA5_eot;
            this.eof = DFA5_eof;
            this.min = DFA5_min;
            this.max = DFA5_max;
            this.accept = DFA5_accept;
            this.special = DFA5_special;
            this.transition = DFA5_transition;

        }

        override public string Description
        {
            get { return "502:1: LoopTriggerAtom : ( 'HitSoundClap' | 'HitSoundFinish' | 'HitSoundWhistle' | 'Passing' | 'Failing' );"; }
        }

    }

    const string DFA12_eotS =
        "\x01\uffff\x01\x03\x03\uffff";
    const string DFA12_eofS =
        "\x05\uffff";
    const string DFA12_minS =
        "\x02\x2e\x03\uffff";
    const string DFA12_maxS =
        "\x02\x39\x03\uffff";
    const string DFA12_acceptS =
        "\x02\uffff\x01\x02\x01\x03\x01\x01";
    const string DFA12_specialS =
        "\x05\uffff}>";
    static readonly string[] DFA12_transitionS = {
            "\x01\x02\x01\uffff\x0a\x01",
            "\x01\x04\x01\uffff\x0a\x01",
            "",
            "",
            ""
    };

    static readonly short[] DFA12_eot = DFA.UnpackEncodedString(DFA12_eotS);
    static readonly short[] DFA12_eof = DFA.UnpackEncodedString(DFA12_eofS);
    static readonly char[] DFA12_min = DFA.UnpackEncodedStringToUnsignedChars(DFA12_minS);
    static readonly char[] DFA12_max = DFA.UnpackEncodedStringToUnsignedChars(DFA12_maxS);
    static readonly short[] DFA12_accept = DFA.UnpackEncodedString(DFA12_acceptS);
    static readonly short[] DFA12_special = DFA.UnpackEncodedString(DFA12_specialS);
    static readonly short[][] DFA12_transition = DFA.UnpackEncodedStringArray(DFA12_transitionS);

    protected class DFA12 : DFA
    {
        public DFA12(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 12;
            this.eot = DFA12_eot;
            this.eof = DFA12_eof;
            this.min = DFA12_min;
            this.max = DFA12_max;
            this.accept = DFA12_accept;
            this.special = DFA12_special;
            this.transition = DFA12_transition;

        }

        override public string Description
        {
            get { return "519:1: FloatAtom : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ );"; }
        }

    }

    const string DFA19_eotS =
        "\x05\uffff\x01\x31\x01\x2e\x02\uffff\x01\x33\x02\uffff\x01\x2e"+
        "\x04\uffff\x01\x39\x01\x3b\x01\x3d\x01\x3f\x01\x41\x01\uffff\x01"+
        "\x43\x02\uffff\x11\x2e\x01\uffff\x01\x58\x05\uffff\x01\x2e\x02\uffff"+
        "\x03\x2e\x0c\uffff\x05\x2e\x01\x62\x01\x2e\x01\x64\x0c\x2e\x01\uffff"+
        "\x02\x2e\x01\x73\x01\x2e\x01\x75\x04\x2e\x01\uffff\x01\x2e\x01\uffff"+
        "\x01\x7b\x0d\x2e\x01\uffff\x01\x2e\x01\uffff\x01\u008c\x03\x2e\x01"+
        "\u0090\x01\uffff\x01\u0091\x03\x2e\x01\u0096\x01\x2e\x01\u0096\x08"+
        "\x2e\x01\u0091\x01\uffff\x01\u00a2\x01\x2e\x01\u00a4\x02\uffff\x01"+
        "\u00a5\x03\x2e\x01\uffff\x09\x2e\x01\u00b2\x01\x2e\x01\uffff\x01"+
        "\u00b4\x02\uffff\x08\x2e\x01\u00c1\x03\x2e\x01\uffff\x01\x2e\x01"+
        "\uffff\x04\x2e\x01\u00ca\x01\x2e\x01\u00ca\x01\u00c1\x04\x2e\x01"+
        "\uffff\x03\x2e\x01\u00d3\x04\x2e\x01\uffff\x02\x2e\x01\u00c1\x03"+
        "\x2e\x01\u00dd\x01\x2e\x01\uffff\x05\x2e\x01\u00c1\x03\x2e\x01\uffff"+
        "\x03\x2e\x01\u0096\x01\u00c1\x02\x2e\x01\u0096\x01\u00c1\x06\x2e"+
        "\x02\u00c1\x01\u00dd\x03\x2e\x01\u00c1\x01\u00ca\x04\x2e\x01\u00ca"+
        "\x01\x2e\x01\u00ca";
    const string DFA19_eofS =
        "\u00fc\uffff";
    const string DFA19_minS =
        "\x01\x09\x04\uffff\x01\x3d\x01\x6c\x02\uffff\x01\x30\x02\uffff"+
        "\x01\x61\x04\uffff\x03\x3d\x01\x2b\x01\x2d\x01\uffff\x01\x2a\x02"+
        "\uffff\x01\x65\x01\x72\x01\x65\x01\x68\x01\x66\x01\x6c\x01\x74\x01"+
        "\x61\x02\x72\x03\x61\x01\x6f\x01\x65\x01\x6f\x01\x69\x01\uffff\x01"+
        "\x2e\x05\uffff\x01\x6f\x02\uffff\x01\x6e\x01\x72\x01\x6c\x0c\uffff"+
        "\x01\x77\x01\x6c\x01\x65\x01\x74\x01\x69\x01\x30\x01\x73\x01\x30"+
        "\x01\x72\x01\x75\x01\x72\x01\x63\x01\x74\x01\x69\x01\x72\x01\x73"+
        "\x01\x70\x01\x6e\x01\x6f\x01\x74\x01\uffff\x01\x62\x01\x63\x01\x30"+
        "\x01\x73\x01\x30\x01\x6c\x01\x61\x01\x75\x01\x6c\x01\uffff\x01\x65"+
        "\x01\uffff\x01\x30\x01\x65\x01\x61\x01\x6b\x01\x74\x01\x6c\x01\x65"+
        "\x01\x73\x01\x43\x01\x74\x01\x70\x01\x53\x01\x61\x01\x74\x01\uffff"+
        "\x01\x65\x01\uffff\x01\x30\x01\x6b\x01\x72\x01\x65\x01\x30\x01\uffff"+
        "\x01\x30\x01\x79\x01\x67\x01\x6f\x01\x30\x01\x67\x01\x30\x02\x65"+
        "\x01\x69\x01\x72\x01\x46\x01\x6f\x01\x6c\x01\x69\x01\x30\x01\uffff"+
        "\x01\x30\x01\x6e\x01\x30\x02\uffff\x01\x30\x01\x72\x01\x6d\x01\x6e"+
        "\x01\uffff\x01\x72\x01\x6e\x01\x66\x01\x6e\x01\x67\x01\x65\x01\x6f"+
        "\x01\x6e\x01\x75\x01\x30\x01\x6f\x01\uffff\x01\x30\x02\uffff\x01"+
        "\x6f\x01\x43\x01\x67\x01\x6f\x01\x67\x02\x74\x01\x68\x01\x30\x01"+
        "\x72\x01\x63\x01\x6e\x01\uffff\x01\x6e\x01\uffff\x01\x75\x02\x65"+
        "\x01\x69\x01\x30\x01\x75\x02\x30\x01\x72\x01\x74\x01\x65\x01\x69"+
        "\x01\uffff\x02\x65\x01\x64\x01\x30\x01\x6e\x01\x66\x01\x6e\x01\x67"+
        "\x01\uffff\x01\x6e\x01\x65\x01\x30\x01\x66\x01\x67\x01\x76\x01\x30"+
        "\x01\x43\x01\uffff\x01\x64\x02\x74\x01\x68\x01\x64\x01\x30\x01\x74"+
        "\x01\x68\x01\x65\x01\uffff\x01\x6c\x01\x69\x01\x68\x02\x30\x01\x72"+
        "\x01\x74\x02\x30\x01\x74\x01\x72\x01\x61\x01\x6e\x01\x69\x01\x65"+
        "\x03\x30\x01\x70\x01\x69\x01\x73\x02\x30\x01\x73\x01\x74\x01\x68"+
        "\x01\x6c\x01\x30\x01\x65\x01\x30";
    const string DFA19_maxS =
        "\x01\ufaff\x04\uffff\x01\x3d\x01\x6c\x02\uffff\x01\x39\x02\uffff"+
        "\x01\x75\x04\uffff\x03\x3d\x01\x2b\x01\x2d\x01\uffff\x01\x2f\x02"+
        "\uffff\x01\x75\x01\x72\x01\x65\x01\x68\x01\x66\x01\x6c\x01\x74\x01"+
        "\x61\x02\x72\x02\x6f\x01\x61\x01\x6f\x01\x65\x01\x6f\x01\x69\x01"+
        "\uffff\x01\x39\x05\uffff\x01\x6f\x02\uffff\x01\x6e\x01\x72\x01\x6c"+
        "\x0c\uffff\x01\x77\x01\x6c\x01\x65\x01\x74\x01\x69\x01\ufaff\x01"+
        "\x73\x01\ufaff\x01\x72\x01\x75\x01\x72\x01\x63\x01\x74\x01\x69\x01"+
        "\x72\x01\x73\x01\x70\x01\x6e\x01\x6f\x01\x74\x01\uffff\x01\x62\x01"+
        "\x63\x01\ufaff\x01\x73\x01\ufaff\x01\x6c\x01\x61\x01\x75\x01\x6c"+
        "\x01\uffff\x01\x65\x01\uffff\x01\ufaff\x01\x65\x01\x61\x01\x6b\x01"+
        "\x74\x01\x6c\x01\x65\x01\x73\x01\x52\x01\x74\x01\x70\x01\x53\x01"+
        "\x61\x01\x74\x01\uffff\x01\x65\x01\uffff\x01\ufaff\x01\x6b\x01\x72"+
        "\x01\x65\x01\ufaff\x01\uffff\x01\ufaff\x01\x79\x01\x67\x01\x6f\x01"+
        "\ufaff\x01\x67\x01\ufaff\x02\x65\x01\x69\x01\x72\x01\x4f\x01\x6f"+
        "\x01\x6c\x01\x69\x01\ufaff\x01\uffff\x01\ufaff\x01\x6e\x01\ufaff"+
        "\x02\uffff\x01\ufaff\x01\x72\x01\x6d\x01\x6e\x01\uffff\x01\x72\x01"+
        "\x6e\x01\x66\x01\x6e\x01\x67\x01\x65\x01\x6f\x01\x6e\x01\x75\x01"+
        "\ufaff\x01\x6f\x01\uffff\x01\ufaff\x02\uffff\x01\x6f\x01\x52\x01"+
        "\x67\x01\x6f\x01\x67\x02\x74\x01\x68\x01\ufaff\x01\x72\x01\x63\x01"+
        "\x6e\x01\uffff\x01\x6e\x01\uffff\x01\x75\x02\x65\x01\x69\x01\ufaff"+
        "\x01\x75\x02\ufaff\x01\x72\x01\x74\x01\x65\x01\x69\x01\uffff\x02"+
        "\x65\x01\x64\x01\ufaff\x01\x6e\x01\x66\x01\x6e\x01\x67\x01\uffff"+
        "\x01\x6e\x01\x65\x01\ufaff\x01\x66\x01\x67\x01\x76\x01\ufaff\x01"+
        "\x57\x01\uffff\x01\x64\x02\x74\x01\x68\x01\x64\x01\ufaff\x01\x74"+
        "\x01\x68\x01\x65\x01\uffff\x01\x6c\x01\x69\x01\x68\x02\ufaff\x01"+
        "\x72\x01\x74\x02\ufaff\x01\x74\x01\x72\x01\x61\x01\x6e\x01\x69\x01"+
        "\x65\x03\ufaff\x01\x70\x01\x69\x01\x73\x02\ufaff\x01\x73\x01\x74"+
        "\x01\x68\x01\x6c\x01\ufaff\x01\x65\x01\ufaff";
    const string DFA19_acceptS =
        "\x01\uffff\x01\x01\x01\x02\x01\x03\x01\x04\x02\uffff\x01\x07\x01"+
        "\x08\x01\uffff\x01\x0a\x01\x0b\x01\uffff\x01\x0d\x01\x0e\x01\x0f"+
        "\x01\x10\x05\uffff\x01\x19\x01\uffff\x01\x1b\x01\x1c\x11\uffff\x01"+
        "\x30\x01\uffff\x01\x33\x01\x34\x01\x36\x01\x11\x01\x05\x01\uffff"+
        "\x01\x09\x01\x32\x03\uffff\x01\x12\x01\x1d\x01\x15\x01\x13\x01\x16"+
        "\x01\x14\x01\x1e\x01\x17\x01\x1f\x01\x18\x01\x35\x01\x1a\x14\uffff"+
        "\x01\x31\x09\uffff\x01\x25\x01\uffff\x01\x27\x0e\uffff\x01\x24\x01"+
        "\uffff\x01\x20\x05\uffff\x01\x28\x10\uffff\x01\x2a\x03\uffff\x01"+
        "\x26\x01\x29\x04\uffff\x01\x2c\x0b\uffff\x01\x21\x01\uffff\x01\x23"+
        "\x01\x2b\x0c\uffff\x01\x06\x01\uffff\x01\x22\x0c\uffff\x01\x2d\x08"+
        "\uffff\x01\x2f\x08\uffff\x01\x0c\x09\uffff\x01\x2e\x1e\uffff";
    const string DFA19_specialS =
        "\u00fc\uffff}>";
    static readonly string[] DFA19_transitionS = {
            "\x02\x2f\x02\uffff\x01\x2f\x12\uffff\x01\x2f\x01\x11\x01\x2d"+
            "\x01\x2b\x01\uffff\x01\x18\x01\x10\x01\uffff\x01\x0a\x01\x0b"+
            "\x01\x16\x01\x14\x01\x04\x01\x15\x01\x09\x01\x17\x0a\x2c\x01"+
            "\x0e\x01\x03\x01\x12\x01\x05\x01\x13\x01\x0d\x01\uffff\x01\x23"+
            "\x01\x24\x01\x28\x02\x2e\x01\x25\x01\x2e\x01\x2a\x03\x2e\x01"+
            "\x29\x03\x2e\x01\x26\x03\x2e\x01\x27\x06\x2e\x01\x07\x01\uffff"+
            "\x01\x08\x01\x19\x01\x2e\x01\uffff\x01\x20\x01\x1b\x02\x2e\x01"+
            "\x1f\x01\x0c\x01\x06\x01\x2e\x01\x1e\x04\x2e\x01\x1a\x03\x2e"+
            "\x01\x1c\x01\x2e\x01\x22\x01\x2e\x01\x21\x01\x1d\x03\x2e\x01"+
            "\x01\x01\x0f\x01\x02\x42\uffff\x17\x2e\x01\uffff\x1f\x2e\x01"+
            "\uffff\u1f08\x2e\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e"+
            "\u0080\uffff\u092e\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200"+
            "\x2e",
            "",
            "",
            "",
            "",
            "\x01\x30",
            "\x01\x32",
            "",
            "",
            "\x0a\x34",
            "",
            "",
            "\x01\x37\x0d\uffff\x01\x36\x05\uffff\x01\x35",
            "",
            "",
            "",
            "",
            "\x01\x38",
            "\x01\x3a",
            "\x01\x3c",
            "\x01\x3e",
            "\x01\x40",
            "",
            "\x01\x42\x04\uffff\x01\x42",
            "",
            "",
            "\x01\x44\x0f\uffff\x01\x45",
            "\x01\x46",
            "\x01\x47",
            "\x01\x48",
            "\x01\x49",
            "\x01\x4a",
            "\x01\x4b",
            "\x01\x4c",
            "\x01\x4d",
            "\x01\x4e",
            "\x01\x4f\x0d\uffff\x01\x50",
            "\x01\x51\x0d\uffff\x01\x52",
            "\x01\x53",
            "\x01\x54",
            "\x01\x55",
            "\x01\x56",
            "\x01\x57",
            "",
            "\x01\x34\x01\uffff\x0a\x2c",
            "",
            "",
            "",
            "",
            "",
            "\x01\x59",
            "",
            "",
            "\x01\x5a",
            "\x01\x5b",
            "\x01\x5c",
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
            "\x01\x5d",
            "\x01\x5e",
            "\x01\x5f",
            "\x01\x60",
            "\x01\x61",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\x63",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\x65",
            "\x01\x66",
            "\x01\x67",
            "\x01\x68",
            "\x01\x69",
            "\x01\x6a",
            "\x01\x6b",
            "\x01\x6c",
            "\x01\x6d",
            "\x01\x6e",
            "\x01\x6f",
            "\x01\x70",
            "",
            "\x01\x71",
            "\x01\x72",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\x74",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\x76",
            "\x01\x77",
            "\x01\x78",
            "\x01\x79",
            "",
            "\x01\x7a",
            "",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\x7c",
            "\x01\x7d",
            "\x01\x7e",
            "\x01\x7f",
            "\x01\u0080",
            "\x01\u0081",
            "\x01\u0082",
            "\x01\u0084\x08\uffff\x01\u0083\x05\uffff\x01\u0085",
            "\x01\u0086",
            "\x01\u0087",
            "\x01\u0088",
            "\x01\u0089",
            "\x01\u008a",
            "",
            "\x01\u008b",
            "",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u008d",
            "\x01\u008e",
            "\x01\u008f",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u0092",
            "\x01\u0093",
            "\x01\u0094",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x08"+
            "\x2e\x01\u0095\x11\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01"+
            "\uffff\u1f08\x2e\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e"+
            "\u0080\uffff\u092e\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200"+
            "\x2e",
            "\x01\u0097",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x08"+
            "\x2e\x01\u0098\x11\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01"+
            "\uffff\u1f08\x2e\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e"+
            "\u0080\uffff\u092e\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200"+
            "\x2e",
            "\x01\u0099",
            "\x01\u009a",
            "\x01\u009b",
            "\x01\u009c",
            "\x01\u009d\x08\uffff\x01\u009e",
            "\x01\u009f",
            "\x01\u00a0",
            "\x01\u00a1",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00a3",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "",
            "",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00a6",
            "\x01\u00a7",
            "\x01\u00a8",
            "",
            "\x01\u00a9",
            "\x01\u00aa",
            "\x01\u00ab",
            "\x01\u00ac",
            "\x01\u00ad",
            "\x01\u00ae",
            "\x01\u00af",
            "\x01\u00b0",
            "\x01\u00b1",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00b3",
            "",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "",
            "",
            "\x01\u00b5",
            "\x01\u00b7\x08\uffff\x01\u00b6\x05\uffff\x01\u00b8",
            "\x01\u00b9",
            "\x01\u00ba",
            "\x01\u00bb",
            "\x01\u00bc",
            "\x01\u00bd",
            "\x01\u00be",
            "\x0a\x2e\x07\uffff\x0b\x2e\x01\u00bf\x05\x2e\x01\u00c0\x08"+
            "\x2e\x04\uffff\x01\x2e\x01\uffff\x1a\x2e\x45\uffff\x17\x2e\x01"+
            "\uffff\x1f\x2e\x01\uffff\u1f08\x2e\u1040\uffff\u0150\x2e\u0170"+
            "\uffff\u0080\x2e\u0080\uffff\u092e\x2e\u10d2\uffff\u5200\x2e"+
            "\u5900\uffff\u0200\x2e",
            "\x01\u00c2",
            "\x01\u00c3",
            "\x01\u00c4",
            "",
            "\x01\u00c5",
            "",
            "\x01\u00c6",
            "\x01\u00c7",
            "\x01\u00c8",
            "\x01\u00c9",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00cb",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00cc",
            "\x01\u00cd",
            "\x01\u00ce",
            "\x01\u00cf",
            "",
            "\x01\u00d0",
            "\x01\u00d1",
            "\x01\u00d2",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00d4",
            "\x01\u00d5",
            "\x01\u00d6",
            "\x01\u00d7",
            "",
            "\x01\u00d8",
            "\x01\u00d9",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00da",
            "\x01\u00db",
            "\x01\u00dc",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00de\x02\uffff\x01\u00df\x10\uffff\x01\u00e0",
            "",
            "\x01\u00e1",
            "\x01\u00e2",
            "\x01\u00e3",
            "\x01\u00e4",
            "\x01\u00e5",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00e6",
            "\x01\u00e7",
            "\x01\u00e8",
            "",
            "\x01\u00e9",
            "\x01\u00ea",
            "\x01\u00eb",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00ec",
            "\x01\u00ed",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00ee",
            "\x01\u00ef",
            "\x01\u00f0",
            "\x01\u00f1",
            "\x01\u00f2",
            "\x01\u00f3",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00f4",
            "\x01\u00f5",
            "\x01\u00f6",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00f7",
            "\x01\u00f8",
            "\x01\u00f9",
            "\x01\u00fa",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e",
            "\x01\u00fb",
            "\x0a\x2e\x07\uffff\x1a\x2e\x04\uffff\x01\x2e\x01\uffff\x1a"+
            "\x2e\x45\uffff\x17\x2e\x01\uffff\x1f\x2e\x01\uffff\u1f08\x2e"+
            "\u1040\uffff\u0150\x2e\u0170\uffff\u0080\x2e\u0080\uffff\u092e"+
            "\x2e\u10d2\uffff\u5200\x2e\u5900\uffff\u0200\x2e"
    };

    static readonly short[] DFA19_eot = DFA.UnpackEncodedString(DFA19_eotS);
    static readonly short[] DFA19_eof = DFA.UnpackEncodedString(DFA19_eofS);
    static readonly char[] DFA19_min = DFA.UnpackEncodedStringToUnsignedChars(DFA19_minS);
    static readonly char[] DFA19_max = DFA.UnpackEncodedStringToUnsignedChars(DFA19_maxS);
    static readonly short[] DFA19_accept = DFA.UnpackEncodedString(DFA19_acceptS);
    static readonly short[] DFA19_special = DFA.UnpackEncodedString(DFA19_specialS);
    static readonly short[][] DFA19_transition = DFA.UnpackEncodedStringArray(DFA19_transitionS);

    protected class DFA19 : DFA
    {
        public DFA19(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 19;
            this.eot = DFA19_eot;
            this.eof = DFA19_eof;
            this.min = DFA19_min;
            this.max = DFA19_max;
            this.accept = DFA19_accept;
            this.special = DFA19_special;
            this.transition = DFA19_transition;

        }

        override public string Description
        {
            get { return "1:1: Tokens : ( T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | T__82 | T__83 | T__84 | T__85 | T__86 | T__87 | T__88 | VarStartInit | BooleanAtom | Null | Array | LayerAtom | OriginAtom | LoopTypeAtom | LoopTriggerAtom | ColorAtom | IntAtom | FloatAtom | StringAtom | Identifier | Comment | WhiteSpace );"; }
        }

    }

 
    
}
}