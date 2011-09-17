// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g 2011-09-14 19:27:43

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

public class SGLLexer extends Lexer {
    public static final int T__68=68;
    public static final int T__69=69;
    public static final int T__66=66;
    public static final int T__67=67;
    public static final int T__64=64;
    public static final int T__65=65;
    public static final int T__62=62;
    public static final int OBJMETHOD=12;
    public static final int T__63=63;
    public static final int Origin=37;
    public static final int Sprite=34;
    public static final int SGLIDDigit=41;
    public static final int PARAM_NAME_LIST=22;
    public static final int IntType=26;
    public static final int ID_LIST=8;
    public static final int T__61=61;
    public static final int EOF=-1;
    public static final int T__60=60;
    public static final int BREAK=20;
    public static final int Identifier=25;
    public static final int IF=6;
    public static final int T__55=55;
    public static final int T__56=56;
    public static final int T__57=57;
    public static final int T__58=58;
    public static final int T__51=51;
    public static final int Animation=35;
    public static final int T__52=52;
    public static final int T__53=53;
    public static final int T__54=54;
    public static final int EXP=7;
    public static final int FORITER=16;
    public static final int StringType=28;
    public static final int T__59=59;
    public static final int RETURN=24;
    public static final int COMMENT=46;
    public static final int STRINGNOQUOTES=17;
    public static final int VARDEF=9;
    public static final int T__50=50;
    public static final int BooleanType=27;
    public static final int VARDEC=19;
    public static final int T__80=80;
    public static final int T__81=81;
    public static final int T__47=47;
    public static final int T__48=48;
    public static final int T__49=49;
    public static final int IntegerAtom=31;
    public static final int FORDEC=14;
    public static final int FloatType=29;
    public static final int PARAM_TYPE_LIST=21;
    public static final int StringAtom=38;
    public static final int METH_CALL=23;
    public static final int NEGATE=11;
    public static final int HEX_DIGIT=44;
    public static final int BooleanAtom=33;
    public static final int T__71=71;
    public static final int FORCOND=15;
    public static final int WS=45;
    public static final int T__72=72;
    public static final int T__70=70;
    public static final int UnicodeEscape=42;
    public static final int BLOCK=4;
    public static final int ASSIGN=10;
    public static final int Layer=36;
    public static final int STATEMENTS=5;
    public static final int ObjectType=30;
    public static final int T__76=76;
    public static final int FloatAtom=32;
    public static final int T__75=75;
    public static final int T__74=74;
    public static final int VARINC=18;
    public static final int T__73=73;
    public static final int EscapeSequence=39;
    public static final int Letter=40;
    public static final int OctalEscape=43;
    public static final int T__79=79;
    public static final int T__78=78;
    public static final int STRING=13;
    public static final int T__77=77;

    // delegates
    // delegators

    public SGLLexer() {;} 
    public SGLLexer(CharStream input) {
        this(input, new RecognizerSharedState());
    }
    public SGLLexer(CharStream input, RecognizerSharedState state) {
        super(input,state);

    }
    public String getGrammarFileName() { return "C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g"; }

    // $ANTLR start "T__47"
    public final void mT__47() throws RecognitionException {
        try {
            int _type = T__47;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:3:7: ( '{' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:3:9: '{'
            {
            match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__47"

    // $ANTLR start "T__48"
    public final void mT__48() throws RecognitionException {
        try {
            int _type = T__48;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:4:7: ( '}' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:4:9: '}'
            {
            match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__48"

    // $ANTLR start "T__49"
    public final void mT__49() throws RecognitionException {
        try {
            int _type = T__49;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:5:7: ( 'method' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:5:9: 'method'
            {
            match("method"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__49"

    // $ANTLR start "T__50"
    public final void mT__50() throws RecognitionException {
        try {
            int _type = T__50;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:6:7: ( '(' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:6:9: '('
            {
            match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__50"

    // $ANTLR start "T__51"
    public final void mT__51() throws RecognitionException {
        try {
            int _type = T__51;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:7:7: ( ')' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:7:9: ')'
            {
            match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__51"

    // $ANTLR start "T__52"
    public final void mT__52() throws RecognitionException {
        try {
            int _type = T__52;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:8:7: ( 'void' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:8:9: 'void'
            {
            match("void"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__52"

    // $ANTLR start "T__53"
    public final void mT__53() throws RecognitionException {
        try {
            int _type = T__53;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:9:7: ( ';' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:9:9: ';'
            {
            match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__53"

    // $ANTLR start "T__54"
    public final void mT__54() throws RecognitionException {
        try {
            int _type = T__54;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:10:7: ( ',' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:10:9: ','
            {
            match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "T__55"
    public final void mT__55() throws RecognitionException {
        try {
            int _type = T__55;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:11:7: ( '=' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:11:9: '='
            {
            match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__55"

    // $ANTLR start "T__56"
    public final void mT__56() throws RecognitionException {
        try {
            int _type = T__56;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:12:7: ( '.' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:12:9: '.'
            {
            match('.'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__56"

    // $ANTLR start "T__57"
    public final void mT__57() throws RecognitionException {
        try {
            int _type = T__57;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:13:7: ( 'while' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:13:9: 'while'
            {
            match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__57"

    // $ANTLR start "T__58"
    public final void mT__58() throws RecognitionException {
        try {
            int _type = T__58;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:14:7: ( 'for' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:14:9: 'for'
            {
            match("for"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__58"

    // $ANTLR start "T__59"
    public final void mT__59() throws RecognitionException {
        try {
            int _type = T__59;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:15:7: ( 'if' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:15:9: 'if'
            {
            match("if"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__59"

    // $ANTLR start "T__60"
    public final void mT__60() throws RecognitionException {
        try {
            int _type = T__60;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:16:7: ( 'else' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:16:9: 'else'
            {
            match("else"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__60"

    // $ANTLR start "T__61"
    public final void mT__61() throws RecognitionException {
        try {
            int _type = T__61;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:17:7: ( 'break' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:17:9: 'break'
            {
            match("break"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__61"

    // $ANTLR start "T__62"
    public final void mT__62() throws RecognitionException {
        try {
            int _type = T__62;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:18:7: ( 'return' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:18:9: 'return'
            {
            match("return"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__62"

    // $ANTLR start "T__63"
    public final void mT__63() throws RecognitionException {
        try {
            int _type = T__63;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:19:7: ( '?' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:19:9: '?'
            {
            match('?'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__63"

    // $ANTLR start "T__64"
    public final void mT__64() throws RecognitionException {
        try {
            int _type = T__64;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:20:7: ( ':' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:20:9: ':'
            {
            match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__64"

    // $ANTLR start "T__65"
    public final void mT__65() throws RecognitionException {
        try {
            int _type = T__65;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:21:7: ( '||' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:21:9: '||'
            {
            match("||"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__65"

    // $ANTLR start "T__66"
    public final void mT__66() throws RecognitionException {
        try {
            int _type = T__66;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:22:7: ( '&&' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:22:9: '&&'
            {
            match("&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__66"

    // $ANTLR start "T__67"
    public final void mT__67() throws RecognitionException {
        try {
            int _type = T__67;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:23:7: ( '==' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:23:9: '=='
            {
            match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__67"

    // $ANTLR start "T__68"
    public final void mT__68() throws RecognitionException {
        try {
            int _type = T__68;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:24:7: ( '!=' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:24:9: '!='
            {
            match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__68"

    // $ANTLR start "T__69"
    public final void mT__69() throws RecognitionException {
        try {
            int _type = T__69;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:25:7: ( '<' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:25:9: '<'
            {
            match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__69"

    // $ANTLR start "T__70"
    public final void mT__70() throws RecognitionException {
        try {
            int _type = T__70;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:26:7: ( '>' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:26:9: '>'
            {
            match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__70"

    // $ANTLR start "T__71"
    public final void mT__71() throws RecognitionException {
        try {
            int _type = T__71;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:27:7: ( '<=' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:27:9: '<='
            {
            match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__71"

    // $ANTLR start "T__72"
    public final void mT__72() throws RecognitionException {
        try {
            int _type = T__72;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:28:7: ( '>=' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:28:9: '>='
            {
            match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__72"

    // $ANTLR start "T__73"
    public final void mT__73() throws RecognitionException {
        try {
            int _type = T__73;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:29:7: ( '+' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:29:9: '+'
            {
            match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__73"

    // $ANTLR start "T__74"
    public final void mT__74() throws RecognitionException {
        try {
            int _type = T__74;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:30:7: ( '-' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:30:9: '-'
            {
            match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__74"

    // $ANTLR start "T__75"
    public final void mT__75() throws RecognitionException {
        try {
            int _type = T__75;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:31:7: ( '*' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:31:9: '*'
            {
            match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__75"

    // $ANTLR start "T__76"
    public final void mT__76() throws RecognitionException {
        try {
            int _type = T__76;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:32:7: ( '/' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:32:9: '/'
            {
            match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__76"

    // $ANTLR start "T__77"
    public final void mT__77() throws RecognitionException {
        try {
            int _type = T__77;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:33:7: ( '%' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:33:9: '%'
            {
            match('%'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__77"

    // $ANTLR start "T__78"
    public final void mT__78() throws RecognitionException {
        try {
            int _type = T__78;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:34:7: ( '++' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:34:9: '++'
            {
            match("++"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__78"

    // $ANTLR start "T__79"
    public final void mT__79() throws RecognitionException {
        try {
            int _type = T__79;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:35:7: ( '--' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:35:9: '--'
            {
            match("--"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__79"

    // $ANTLR start "T__80"
    public final void mT__80() throws RecognitionException {
        try {
            int _type = T__80;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:36:7: ( 'new' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:36:9: 'new'
            {
            match("new"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__80"

    // $ANTLR start "T__81"
    public final void mT__81() throws RecognitionException {
        try {
            int _type = T__81;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:37:7: ( 'null' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:37:9: 'null'
            {
            match("null"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__81"

    // $ANTLR start "IntegerAtom"
    public final void mIntegerAtom() throws RecognitionException {
        try {
            int _type = IntegerAtom;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:417:5: ( ( '0' .. '9' )+ )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:417:7: ( '0' .. '9' )+
            {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:417:7: ( '0' .. '9' )+
            int cnt1=0;
            loop1:
            do {
                int alt1=2;
                int LA1_0 = input.LA(1);

                if ( ((LA1_0>='0' && LA1_0<='9')) ) {
                    alt1=1;
                }


                switch (alt1) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:417:7: '0' .. '9'
            	    {
            	    matchRange('0','9'); 

            	    }
            	    break;

            	default :
            	    if ( cnt1 >= 1 ) break loop1;
                        EarlyExitException eee =
                            new EarlyExitException(1, input);
                        throw eee;
                }
                cnt1++;
            } while (true);


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "IntegerAtom"

    // $ANTLR start "FloatAtom"
    public final void mFloatAtom() throws RecognitionException {
        try {
            int _type = FloatAtom;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:421:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ )
            int alt6=3;
            alt6 = dfa6.predict(input);
            switch (alt6) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:421:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:421:9: ( '0' .. '9' )+
                    int cnt2=0;
                    loop2:
                    do {
                        int alt2=2;
                        int LA2_0 = input.LA(1);

                        if ( ((LA2_0>='0' && LA2_0<='9')) ) {
                            alt2=1;
                        }


                        switch (alt2) {
                    	case 1 :
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:421:10: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt2 >= 1 ) break loop2;
                                EarlyExitException eee =
                                    new EarlyExitException(2, input);
                                throw eee;
                        }
                        cnt2++;
                    } while (true);

                    match('.'); 
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:421:25: ( '0' .. '9' )*
                    loop3:
                    do {
                        int alt3=2;
                        int LA3_0 = input.LA(1);

                        if ( ((LA3_0>='0' && LA3_0<='9')) ) {
                            alt3=1;
                        }


                        switch (alt3) {
                    	case 1 :
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:421:26: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    break loop3;
                        }
                    } while (true);


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:422:9: '.' ( '0' .. '9' )+
                    {
                    match('.'); 
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:422:13: ( '0' .. '9' )+
                    int cnt4=0;
                    loop4:
                    do {
                        int alt4=2;
                        int LA4_0 = input.LA(1);

                        if ( ((LA4_0>='0' && LA4_0<='9')) ) {
                            alt4=1;
                        }


                        switch (alt4) {
                    	case 1 :
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:422:14: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt4 >= 1 ) break loop4;
                                EarlyExitException eee =
                                    new EarlyExitException(4, input);
                                throw eee;
                        }
                        cnt4++;
                    } while (true);


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:423:9: ( '0' .. '9' )+
                    {
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:423:9: ( '0' .. '9' )+
                    int cnt5=0;
                    loop5:
                    do {
                        int alt5=2;
                        int LA5_0 = input.LA(1);

                        if ( ((LA5_0>='0' && LA5_0<='9')) ) {
                            alt5=1;
                        }


                        switch (alt5) {
                    	case 1 :
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:423:10: '0' .. '9'
                    	    {
                    	    matchRange('0','9'); 

                    	    }
                    	    break;

                    	default :
                    	    if ( cnt5 >= 1 ) break loop5;
                                EarlyExitException eee =
                                    new EarlyExitException(5, input);
                                throw eee;
                        }
                        cnt5++;
                    } while (true);


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "FloatAtom"

    // $ANTLR start "BooleanAtom"
    public final void mBooleanAtom() throws RecognitionException {
        try {
            int _type = BooleanAtom;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:428:5: ( 'true' | 'false' )
            int alt7=2;
            int LA7_0 = input.LA(1);

            if ( (LA7_0=='t') ) {
                alt7=1;
            }
            else if ( (LA7_0=='f') ) {
                alt7=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 7, 0, input);

                throw nvae;
            }
            switch (alt7) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:428:9: 'true'
                    {
                    match("true"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:429:9: 'false'
                    {
                    match("false"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "BooleanAtom"

    // $ANTLR start "StringAtom"
    public final void mStringAtom() throws RecognitionException {
        try {
            int _type = StringAtom;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:437:5: ( '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )* '\"' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:437:9: '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )* '\"'
            {
            match('\"'); 
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:437:13: ( EscapeSequence | ~ ( '\\\\' | '\"' ) )*
            loop8:
            do {
                int alt8=3;
                int LA8_0 = input.LA(1);

                if ( (LA8_0=='\\') ) {
                    alt8=1;
                }
                else if ( ((LA8_0>='\u0000' && LA8_0<='!')||(LA8_0>='#' && LA8_0<='[')||(LA8_0>=']' && LA8_0<='\uFFFF')) ) {
                    alt8=2;
                }


                switch (alt8) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:437:15: EscapeSequence
            	    {
            	    mEscapeSequence(); 

            	    }
            	    break;
            	case 2 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:437:32: ~ ( '\\\\' | '\"' )
            	    {
            	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='!')||(input.LA(1)>='#' && input.LA(1)<='[')||(input.LA(1)>=']' && input.LA(1)<='\uFFFF') ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    break loop8;
                }
            } while (true);

            match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;

              //Text = (Text.Substring(0, Text.Length-1).Replace("\\\\(.)", "$1"));
              //setText(getText().substring(1, getText().length()-1).replaceAll("\\\\(.)", "$1"));
        }
        finally {
        }
    }
    // $ANTLR end "StringAtom"

    // $ANTLR start "IntType"
    public final void mIntType() throws RecognitionException {
        try {
            int _type = IntType;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:442:2: ( 'int' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:442:4: 'int'
            {
            match("int"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "IntType"

    // $ANTLR start "BooleanType"
    public final void mBooleanType() throws RecognitionException {
        try {
            int _type = BooleanType;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:446:2: ( 'boolean' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:446:4: 'boolean'
            {
            match("boolean"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "BooleanType"

    // $ANTLR start "StringType"
    public final void mStringType() throws RecognitionException {
        try {
            int _type = StringType;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:450:2: ( 'string' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:450:4: 'string'
            {
            match("string"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "StringType"

    // $ANTLR start "FloatType"
    public final void mFloatType() throws RecognitionException {
        try {
            int _type = FloatType;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:454:2: ( 'float' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:454:4: 'float'
            {
            match("float"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "FloatType"

    // $ANTLR start "ObjectType"
    public final void mObjectType() throws RecognitionException {
        try {
            int _type = ObjectType;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:460:2: ( 'Object' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:460:4: 'Object'
            {
            match("Object"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "ObjectType"

    // $ANTLR start "Sprite"
    public final void mSprite() throws RecognitionException {
        try {
            int _type = Sprite;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:464:2: ( 'Sprite' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:464:4: 'Sprite'
            {
            match("Sprite"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "Sprite"

    // $ANTLR start "Animation"
    public final void mAnimation() throws RecognitionException {
        try {
            int _type = Animation;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:468:2: ( 'Animation' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:468:4: 'Animation'
            {
            match("Animation"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "Animation"

    // $ANTLR start "Layer"
    public final void mLayer() throws RecognitionException {
        try {
            int _type = Layer;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:472:2: ( 'Background' | 'Fail' | 'Pass' | 'Foreground' )
            int alt9=4;
            switch ( input.LA(1) ) {
            case 'B':
                {
                alt9=1;
                }
                break;
            case 'F':
                {
                int LA9_2 = input.LA(2);

                if ( (LA9_2=='a') ) {
                    alt9=2;
                }
                else if ( (LA9_2=='o') ) {
                    alt9=4;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 9, 2, input);

                    throw nvae;
                }
                }
                break;
            case 'P':
                {
                alt9=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 9, 0, input);

                throw nvae;
            }

            switch (alt9) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:472:4: 'Background'
                    {
                    match("Background"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:473:4: 'Fail'
                    {
                    match("Fail"); 


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:474:4: 'Pass'
                    {
                    match("Pass"); 


                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:475:4: 'Foreground'
                    {
                    match("Foreground"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "Layer"

    // $ANTLR start "Origin"
    public final void mOrigin() throws RecognitionException {
        try {
            int _type = Origin;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:479:2: ( 'TopLeft' | 'TopCentre' | 'TopRight' | 'CentreLeft' | 'Centre' | 'CentreRight' | 'BottomLeft' | 'BottomCentre' | 'BottomRight' )
            int alt10=9;
            alt10 = dfa10.predict(input);
            switch (alt10) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:479:4: 'TopLeft'
                    {
                    match("TopLeft"); 


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:480:4: 'TopCentre'
                    {
                    match("TopCentre"); 


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:481:4: 'TopRight'
                    {
                    match("TopRight"); 


                    }
                    break;
                case 4 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:482:4: 'CentreLeft'
                    {
                    match("CentreLeft"); 


                    }
                    break;
                case 5 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:483:4: 'Centre'
                    {
                    match("Centre"); 


                    }
                    break;
                case 6 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:484:4: 'CentreRight'
                    {
                    match("CentreRight"); 


                    }
                    break;
                case 7 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:485:4: 'BottomLeft'
                    {
                    match("BottomLeft"); 


                    }
                    break;
                case 8 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:486:4: 'BottomCentre'
                    {
                    match("BottomCentre"); 


                    }
                    break;
                case 9 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:487:4: 'BottomRight'
                    {
                    match("BottomRight"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "Origin"

    // $ANTLR start "Identifier"
    public final void mIdentifier() throws RecognitionException {
        try {
            int _type = Identifier;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:492:5: ( Letter ( Letter | SGLIDDigit )* )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:492:9: Letter ( Letter | SGLIDDigit )*
            {
            mLetter(); 
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:492:16: ( Letter | SGLIDDigit )*
            loop11:
            do {
                int alt11=2;
                int LA11_0 = input.LA(1);

                if ( (LA11_0=='$'||(LA11_0>='0' && LA11_0<='9')||(LA11_0>='A' && LA11_0<='Z')||LA11_0=='_'||(LA11_0>='a' && LA11_0<='z')||(LA11_0>='\u00C0' && LA11_0<='\u00D6')||(LA11_0>='\u00D8' && LA11_0<='\u00F6')||(LA11_0>='\u00F8' && LA11_0<='\u1FFF')||(LA11_0>='\u3040' && LA11_0<='\u318F')||(LA11_0>='\u3300' && LA11_0<='\u337F')||(LA11_0>='\u3400' && LA11_0<='\u3D2D')||(LA11_0>='\u4E00' && LA11_0<='\u9FFF')||(LA11_0>='\uF900' && LA11_0<='\uFAFF')) ) {
                    alt11=1;
                }


                switch (alt11) {
            	case 1 :
            	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            	    {
            	    if ( input.LA(1)=='$'||(input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z')||(input.LA(1)>='\u00C0' && input.LA(1)<='\u00D6')||(input.LA(1)>='\u00D8' && input.LA(1)<='\u00F6')||(input.LA(1)>='\u00F8' && input.LA(1)<='\u1FFF')||(input.LA(1)>='\u3040' && input.LA(1)<='\u318F')||(input.LA(1)>='\u3300' && input.LA(1)<='\u337F')||(input.LA(1)>='\u3400' && input.LA(1)<='\u3D2D')||(input.LA(1)>='\u4E00' && input.LA(1)<='\u9FFF')||(input.LA(1)>='\uF900' && input.LA(1)<='\uFAFF') ) {
            	        input.consume();

            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;}


            	    }
            	    break;

            	default :
            	    break loop11;
                }
            } while (true);


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "Identifier"

    // $ANTLR start "Letter"
    public final void mLetter() throws RecognitionException {
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:504:5: ( '\\u0024' | '\\u0041' .. '\\u005a' | '\\u005f' | '\\u0061' .. '\\u007a' | '\\u00c0' .. '\\u00d6' | '\\u00d8' .. '\\u00f6' | '\\u00f8' .. '\\u00ff' | '\\u0100' .. '\\u1fff' | '\\u3040' .. '\\u318f' | '\\u3300' .. '\\u337f' | '\\u3400' .. '\\u3d2d' | '\\u4e00' .. '\\u9fff' | '\\uf900' .. '\\ufaff' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            if ( input.LA(1)=='$'||(input.LA(1)>='A' && input.LA(1)<='Z')||input.LA(1)=='_'||(input.LA(1)>='a' && input.LA(1)<='z')||(input.LA(1)>='\u00C0' && input.LA(1)<='\u00D6')||(input.LA(1)>='\u00D8' && input.LA(1)<='\u00F6')||(input.LA(1)>='\u00F8' && input.LA(1)<='\u1FFF')||(input.LA(1)>='\u3040' && input.LA(1)<='\u318F')||(input.LA(1)>='\u3300' && input.LA(1)<='\u337F')||(input.LA(1)>='\u3400' && input.LA(1)<='\u3D2D')||(input.LA(1)>='\u4E00' && input.LA(1)<='\u9FFF')||(input.LA(1)>='\uF900' && input.LA(1)<='\uFAFF') ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}


            }

        }
        finally {
        }
    }
    // $ANTLR end "Letter"

    // $ANTLR start "SGLIDDigit"
    public final void mSGLIDDigit() throws RecognitionException {
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:521:5: ( '\\u0030' .. '\\u0039' | '\\u0660' .. '\\u0669' | '\\u06f0' .. '\\u06f9' | '\\u0966' .. '\\u096f' | '\\u09e6' .. '\\u09ef' | '\\u0a66' .. '\\u0a6f' | '\\u0ae6' .. '\\u0aef' | '\\u0b66' .. '\\u0b6f' | '\\u0be7' .. '\\u0bef' | '\\u0c66' .. '\\u0c6f' | '\\u0ce6' .. '\\u0cef' | '\\u0d66' .. '\\u0d6f' | '\\u0e50' .. '\\u0e59' | '\\u0ed0' .. '\\u0ed9' | '\\u1040' .. '\\u1049' )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:
            {
            if ( (input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='\u0660' && input.LA(1)<='\u0669')||(input.LA(1)>='\u06F0' && input.LA(1)<='\u06F9')||(input.LA(1)>='\u0966' && input.LA(1)<='\u096F')||(input.LA(1)>='\u09E6' && input.LA(1)<='\u09EF')||(input.LA(1)>='\u0A66' && input.LA(1)<='\u0A6F')||(input.LA(1)>='\u0AE6' && input.LA(1)<='\u0AEF')||(input.LA(1)>='\u0B66' && input.LA(1)<='\u0B6F')||(input.LA(1)>='\u0BE7' && input.LA(1)<='\u0BEF')||(input.LA(1)>='\u0C66' && input.LA(1)<='\u0C6F')||(input.LA(1)>='\u0CE6' && input.LA(1)<='\u0CEF')||(input.LA(1)>='\u0D66' && input.LA(1)<='\u0D6F')||(input.LA(1)>='\u0E50' && input.LA(1)<='\u0E59')||(input.LA(1)>='\u0ED0' && input.LA(1)<='\u0ED9')||(input.LA(1)>='\u1040' && input.LA(1)<='\u1049') ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}


            }

        }
        finally {
        }
    }
    // $ANTLR end "SGLIDDigit"

    // $ANTLR start "EscapeSequence"
    public final void mEscapeSequence() throws RecognitionException {
        try {
            int _type = EscapeSequence;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:541:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) | UnicodeEscape | OctalEscape )
            int alt12=3;
            int LA12_0 = input.LA(1);

            if ( (LA12_0=='\\') ) {
                switch ( input.LA(2) ) {
                case '\"':
                case '\'':
                case '\\':
                case 'b':
                case 'f':
                case 'n':
                case 'r':
                case 't':
                    {
                    alt12=1;
                    }
                    break;
                case 'u':
                    {
                    alt12=2;
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
                    alt12=3;
                    }
                    break;
                default:
                    NoViableAltException nvae =
                        new NoViableAltException("", 12, 1, input);

                    throw nvae;
                }

            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 12, 0, input);

                throw nvae;
            }
            switch (alt12) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:541:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
                    {
                    match('\\'); 
                    if ( input.LA(1)=='\"'||input.LA(1)=='\''||input.LA(1)=='\\'||input.LA(1)=='b'||input.LA(1)=='f'||input.LA(1)=='n'||input.LA(1)=='r'||input.LA(1)=='t' ) {
                        input.consume();

                    }
                    else {
                        MismatchedSetException mse = new MismatchedSetException(null,input);
                        recover(mse);
                        throw mse;}


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:542:9: UnicodeEscape
                    {
                    mUnicodeEscape(); 

                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:543:9: OctalEscape
                    {
                    mOctalEscape(); 

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "EscapeSequence"

    // $ANTLR start "OctalEscape"
    public final void mOctalEscape() throws RecognitionException {
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:548:5: ( '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) )
            int alt13=3;
            int LA13_0 = input.LA(1);

            if ( (LA13_0=='\\') ) {
                int LA13_1 = input.LA(2);

                if ( ((LA13_1>='0' && LA13_1<='3')) ) {
                    int LA13_2 = input.LA(3);

                    if ( ((LA13_2>='0' && LA13_2<='7')) ) {
                        int LA13_4 = input.LA(4);

                        if ( ((LA13_4>='0' && LA13_4<='7')) ) {
                            alt13=1;
                        }
                        else {
                            alt13=2;}
                    }
                    else {
                        alt13=3;}
                }
                else if ( ((LA13_1>='4' && LA13_1<='7')) ) {
                    int LA13_3 = input.LA(3);

                    if ( ((LA13_3>='0' && LA13_3<='7')) ) {
                        alt13=2;
                    }
                    else {
                        alt13=3;}
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 13, 1, input);

                    throw nvae;
                }
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 13, 0, input);

                throw nvae;
            }
            switch (alt13) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:548:9: '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    match('\\'); 
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:548:14: ( '0' .. '3' )
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:548:15: '0' .. '3'
                    {
                    matchRange('0','3'); 

                    }

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:548:25: ( '0' .. '7' )
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:548:26: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:548:36: ( '0' .. '7' )
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:548:37: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }


                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:549:9: '\\\\' ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    match('\\'); 
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:549:14: ( '0' .. '7' )
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:549:15: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:549:25: ( '0' .. '7' )
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:549:26: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }


                    }
                    break;
                case 3 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:550:9: '\\\\' ( '0' .. '7' )
                    {
                    match('\\'); 
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:550:14: ( '0' .. '7' )
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:550:15: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }


                    }
                    break;

            }
        }
        finally {
        }
    }
    // $ANTLR end "OctalEscape"

    // $ANTLR start "UnicodeEscape"
    public final void mUnicodeEscape() throws RecognitionException {
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:555:5: ( '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:555:9: '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
            {
            match('\\'); 
            match('u'); 
            mHEX_DIGIT(); 
            mHEX_DIGIT(); 
            mHEX_DIGIT(); 
            mHEX_DIGIT(); 

            }

        }
        finally {
        }
    }
    // $ANTLR end "UnicodeEscape"

    // $ANTLR start "HEX_DIGIT"
    public final void mHEX_DIGIT() throws RecognitionException {
        try {
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:559:11: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:559:13: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
            {
            if ( (input.LA(1)>='0' && input.LA(1)<='9')||(input.LA(1)>='A' && input.LA(1)<='F')||(input.LA(1)>='a' && input.LA(1)<='f') ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}


            }

        }
        finally {
        }
    }
    // $ANTLR end "HEX_DIGIT"

    // $ANTLR start "WS"
    public final void mWS() throws RecognitionException {
        try {
            int _type = WS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:565:5: ( ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' ) )
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:565:8: ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' )
            {
            if ( (input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ' ) {
                input.consume();

            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;}

            _channel=HIDDEN;

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "WS"

    // $ANTLR start "COMMENT"
    public final void mCOMMENT() throws RecognitionException {
        try {
            int _type = COMMENT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:570:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
            int alt17=2;
            int LA17_0 = input.LA(1);

            if ( (LA17_0=='/') ) {
                int LA17_1 = input.LA(2);

                if ( (LA17_1=='/') ) {
                    alt17=1;
                }
                else if ( (LA17_1=='*') ) {
                    alt17=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 17, 1, input);

                    throw nvae;
                }
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 17, 0, input);

                throw nvae;
            }
            switch (alt17) {
                case 1 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:570:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    match("//"); 

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:570:14: (~ ( '\\n' | '\\r' ) )*
                    loop14:
                    do {
                        int alt14=2;
                        int LA14_0 = input.LA(1);

                        if ( ((LA14_0>='\u0000' && LA14_0<='\t')||(LA14_0>='\u000B' && LA14_0<='\f')||(LA14_0>='\u000E' && LA14_0<='\uFFFF')) ) {
                            alt14=1;
                        }


                        switch (alt14) {
                    	case 1 :
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:570:14: ~ ( '\\n' | '\\r' )
                    	    {
                    	    if ( (input.LA(1)>='\u0000' && input.LA(1)<='\t')||(input.LA(1)>='\u000B' && input.LA(1)<='\f')||(input.LA(1)>='\u000E' && input.LA(1)<='\uFFFF') ) {
                    	        input.consume();

                    	    }
                    	    else {
                    	        MismatchedSetException mse = new MismatchedSetException(null,input);
                    	        recover(mse);
                    	        throw mse;}


                    	    }
                    	    break;

                    	default :
                    	    break loop14;
                        }
                    } while (true);

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:570:28: ( '\\r' )?
                    int alt15=2;
                    int LA15_0 = input.LA(1);

                    if ( (LA15_0=='\r') ) {
                        alt15=1;
                    }
                    switch (alt15) {
                        case 1 :
                            // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:570:28: '\\r'
                            {
                            match('\r'); 

                            }
                            break;

                    }

                    match('\n'); 
                    _channel=HIDDEN;

                    }
                    break;
                case 2 :
                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:571:9: '/*' ( options {greedy=false; } : . )* '*/'
                    {
                    match("/*"); 

                    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:571:14: ( options {greedy=false; } : . )*
                    loop16:
                    do {
                        int alt16=2;
                        int LA16_0 = input.LA(1);

                        if ( (LA16_0=='*') ) {
                            int LA16_1 = input.LA(2);

                            if ( (LA16_1=='/') ) {
                                alt16=2;
                            }
                            else if ( ((LA16_1>='\u0000' && LA16_1<='.')||(LA16_1>='0' && LA16_1<='\uFFFF')) ) {
                                alt16=1;
                            }


                        }
                        else if ( ((LA16_0>='\u0000' && LA16_0<=')')||(LA16_0>='+' && LA16_0<='\uFFFF')) ) {
                            alt16=1;
                        }


                        switch (alt16) {
                    	case 1 :
                    	    // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:571:42: .
                    	    {
                    	    matchAny(); 

                    	    }
                    	    break;

                    	default :
                    	    break loop16;
                        }
                    } while (true);

                    match("*/"); 

                    _channel=HIDDEN;

                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "COMMENT"

    public void mTokens() throws RecognitionException {
        // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:8: ( T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | IntegerAtom | FloatAtom | BooleanAtom | StringAtom | IntType | BooleanType | StringType | FloatType | ObjectType | Sprite | Animation | Layer | Origin | Identifier | EscapeSequence | WS | COMMENT )
        int alt18=52;
        alt18 = dfa18.predict(input);
        switch (alt18) {
            case 1 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:10: T__47
                {
                mT__47(); 

                }
                break;
            case 2 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:16: T__48
                {
                mT__48(); 

                }
                break;
            case 3 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:22: T__49
                {
                mT__49(); 

                }
                break;
            case 4 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:28: T__50
                {
                mT__50(); 

                }
                break;
            case 5 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:34: T__51
                {
                mT__51(); 

                }
                break;
            case 6 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:40: T__52
                {
                mT__52(); 

                }
                break;
            case 7 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:46: T__53
                {
                mT__53(); 

                }
                break;
            case 8 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:52: T__54
                {
                mT__54(); 

                }
                break;
            case 9 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:58: T__55
                {
                mT__55(); 

                }
                break;
            case 10 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:64: T__56
                {
                mT__56(); 

                }
                break;
            case 11 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:70: T__57
                {
                mT__57(); 

                }
                break;
            case 12 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:76: T__58
                {
                mT__58(); 

                }
                break;
            case 13 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:82: T__59
                {
                mT__59(); 

                }
                break;
            case 14 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:88: T__60
                {
                mT__60(); 

                }
                break;
            case 15 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:94: T__61
                {
                mT__61(); 

                }
                break;
            case 16 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:100: T__62
                {
                mT__62(); 

                }
                break;
            case 17 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:106: T__63
                {
                mT__63(); 

                }
                break;
            case 18 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:112: T__64
                {
                mT__64(); 

                }
                break;
            case 19 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:118: T__65
                {
                mT__65(); 

                }
                break;
            case 20 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:124: T__66
                {
                mT__66(); 

                }
                break;
            case 21 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:130: T__67
                {
                mT__67(); 

                }
                break;
            case 22 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:136: T__68
                {
                mT__68(); 

                }
                break;
            case 23 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:142: T__69
                {
                mT__69(); 

                }
                break;
            case 24 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:148: T__70
                {
                mT__70(); 

                }
                break;
            case 25 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:154: T__71
                {
                mT__71(); 

                }
                break;
            case 26 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:160: T__72
                {
                mT__72(); 

                }
                break;
            case 27 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:166: T__73
                {
                mT__73(); 

                }
                break;
            case 28 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:172: T__74
                {
                mT__74(); 

                }
                break;
            case 29 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:178: T__75
                {
                mT__75(); 

                }
                break;
            case 30 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:184: T__76
                {
                mT__76(); 

                }
                break;
            case 31 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:190: T__77
                {
                mT__77(); 

                }
                break;
            case 32 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:196: T__78
                {
                mT__78(); 

                }
                break;
            case 33 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:202: T__79
                {
                mT__79(); 

                }
                break;
            case 34 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:208: T__80
                {
                mT__80(); 

                }
                break;
            case 35 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:214: T__81
                {
                mT__81(); 

                }
                break;
            case 36 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:220: IntegerAtom
                {
                mIntegerAtom(); 

                }
                break;
            case 37 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:232: FloatAtom
                {
                mFloatAtom(); 

                }
                break;
            case 38 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:242: BooleanAtom
                {
                mBooleanAtom(); 

                }
                break;
            case 39 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:254: StringAtom
                {
                mStringAtom(); 

                }
                break;
            case 40 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:265: IntType
                {
                mIntType(); 

                }
                break;
            case 41 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:273: BooleanType
                {
                mBooleanType(); 

                }
                break;
            case 42 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:285: StringType
                {
                mStringType(); 

                }
                break;
            case 43 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:296: FloatType
                {
                mFloatType(); 

                }
                break;
            case 44 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:306: ObjectType
                {
                mObjectType(); 

                }
                break;
            case 45 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:317: Sprite
                {
                mSprite(); 

                }
                break;
            case 46 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:324: Animation
                {
                mAnimation(); 

                }
                break;
            case 47 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:334: Layer
                {
                mLayer(); 

                }
                break;
            case 48 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:340: Origin
                {
                mOrigin(); 

                }
                break;
            case 49 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:347: Identifier
                {
                mIdentifier(); 

                }
                break;
            case 50 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:358: EscapeSequence
                {
                mEscapeSequence(); 

                }
                break;
            case 51 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:373: WS
                {
                mWS(); 

                }
                break;
            case 52 :
                // C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\SGL.g:1:376: COMMENT
                {
                mCOMMENT(); 

                }
                break;

        }

    }


    protected DFA6 dfa6 = new DFA6(this);
    protected DFA10 dfa10 = new DFA10(this);
    protected DFA18 dfa18 = new DFA18(this);
    static final String DFA6_eotS =
        "\1\uffff\1\3\3\uffff";
    static final String DFA6_eofS =
        "\5\uffff";
    static final String DFA6_minS =
        "\2\56\3\uffff";
    static final String DFA6_maxS =
        "\2\71\3\uffff";
    static final String DFA6_acceptS =
        "\2\uffff\1\2\1\3\1\1";
    static final String DFA6_specialS =
        "\5\uffff}>";
    static final String[] DFA6_transitionS = {
            "\1\2\1\uffff\12\1",
            "\1\4\1\uffff\12\1",
            "",
            "",
            ""
    };

    static final short[] DFA6_eot = DFA.unpackEncodedString(DFA6_eotS);
    static final short[] DFA6_eof = DFA.unpackEncodedString(DFA6_eofS);
    static final char[] DFA6_min = DFA.unpackEncodedStringToUnsignedChars(DFA6_minS);
    static final char[] DFA6_max = DFA.unpackEncodedStringToUnsignedChars(DFA6_maxS);
    static final short[] DFA6_accept = DFA.unpackEncodedString(DFA6_acceptS);
    static final short[] DFA6_special = DFA.unpackEncodedString(DFA6_specialS);
    static final short[][] DFA6_transition;

    static {
        int numStates = DFA6_transitionS.length;
        DFA6_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA6_transition[i] = DFA.unpackEncodedString(DFA6_transitionS[i]);
        }
    }

    class DFA6 extends DFA {

        public DFA6(BaseRecognizer recognizer) {
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
        public String getDescription() {
            return "420:1: FloatAtom : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ );";
        }
    }
    static final String DFA10_eotS =
        "\21\uffff\1\25\7\uffff";
    static final String DFA10_eofS =
        "\31\uffff";
    static final String DFA10_minS =
        "\1\102\1\157\1\145\1\157\1\160\1\156\1\164\1\103\2\164\3\uffff"+
        "\1\162\1\157\1\145\1\155\1\114\1\103\6\uffff";
    static final String DFA10_maxS =
        "\1\124\1\157\1\145\1\157\1\160\1\156\1\164\1\122\2\164\3\uffff"+
        "\1\162\1\157\1\145\1\155\2\122\6\uffff";
    static final String DFA10_acceptS =
        "\12\uffff\1\1\1\2\1\3\6\uffff\1\4\1\6\1\5\1\7\1\10\1\11";
    static final String DFA10_specialS =
        "\31\uffff}>";
    static final String[] DFA10_transitionS = {
            "\1\3\1\2\20\uffff\1\1",
            "\1\4",
            "\1\5",
            "\1\6",
            "\1\7",
            "\1\10",
            "\1\11",
            "\1\13\10\uffff\1\12\5\uffff\1\14",
            "\1\15",
            "\1\16",
            "",
            "",
            "",
            "\1\17",
            "\1\20",
            "\1\21",
            "\1\22",
            "\1\23\5\uffff\1\24",
            "\1\27\10\uffff\1\26\5\uffff\1\30",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static final short[] DFA10_eot = DFA.unpackEncodedString(DFA10_eotS);
    static final short[] DFA10_eof = DFA.unpackEncodedString(DFA10_eofS);
    static final char[] DFA10_min = DFA.unpackEncodedStringToUnsignedChars(DFA10_minS);
    static final char[] DFA10_max = DFA.unpackEncodedStringToUnsignedChars(DFA10_maxS);
    static final short[] DFA10_accept = DFA.unpackEncodedString(DFA10_acceptS);
    static final short[] DFA10_special = DFA.unpackEncodedString(DFA10_specialS);
    static final short[][] DFA10_transition;

    static {
        int numStates = DFA10_transitionS.length;
        DFA10_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA10_transition[i] = DFA.unpackEncodedString(DFA10_transitionS[i]);
        }
    }

    class DFA10 extends DFA {

        public DFA10(BaseRecognizer recognizer) {
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
        public String getDescription() {
            return "478:1: Origin : ( 'TopLeft' | 'TopCentre' | 'TopRight' | 'CentreLeft' | 'Centre' | 'CentreRight' | 'BottomLeft' | 'BottomCentre' | 'BottomRight' );";
        }
    }
    static final String DFA18_eotS =
        "\3\uffff\1\52\2\uffff\1\52\2\uffff\1\60\1\61\6\52\5\uffff\1\76"+
        "\1\100\1\102\1\104\1\uffff\1\106\1\uffff\1\52\1\111\1\52\1\uffff"+
        "\11\52\3\uffff\2\52\4\uffff\4\52\1\134\5\52\12\uffff\2\52\1\uffff"+
        "\17\52\1\163\2\52\1\uffff\1\166\4\52\1\173\16\52\1\u008c\1\52\1"+
        "\uffff\2\52\1\uffff\1\u0090\3\52\1\uffff\1\u0094\1\u0095\6\52\1"+
        "\u009c\1\52\1\u009c\5\52\1\uffff\1\u00a3\1\u0095\1\u00a4\1\uffff"+
        "\1\u00a5\2\52\2\uffff\6\52\1\uffff\5\52\1\u00b3\3\uffff\1\52\1\u00b5"+
        "\1\u00b6\1\u00b7\1\u00b8\7\52\1\u00c4\1\uffff\1\u00c5\4\uffff\6"+
        "\52\1\u00c4\4\52\2\uffff\7\52\1\u00c4\2\52\1\u00d9\5\52\1\u00c4"+
        "\2\52\1\uffff\1\u009c\1\u00c4\2\52\1\u009c\1\u00c4\2\52\3\u00c4";
    static final String DFA18_eofS =
        "\u00e5\uffff";
    static final String DFA18_minS =
        "\1\11\2\uffff\1\145\2\uffff\1\157\2\uffff\1\75\1\60\1\150\1\141"+
        "\1\146\1\154\1\157\1\145\5\uffff\2\75\1\53\1\55\1\uffff\1\52\1\uffff"+
        "\1\145\1\56\1\162\1\uffff\1\164\1\142\1\160\1\156\3\141\1\157\1"+
        "\145\3\uffff\1\164\1\151\4\uffff\1\151\1\162\1\154\1\157\1\44\1"+
        "\164\1\163\1\145\1\157\1\164\12\uffff\1\167\1\154\1\uffff\1\165"+
        "\1\162\1\152\1\162\1\151\1\143\1\164\1\151\1\162\1\163\1\160\1\156"+
        "\1\150\1\144\1\154\1\44\1\163\1\141\1\uffff\1\44\1\145\1\141\1\154"+
        "\1\165\1\44\1\154\1\145\1\151\1\145\1\151\1\155\1\153\1\164\1\154"+
        "\1\145\1\163\1\103\1\164\1\157\1\44\1\145\1\uffff\1\145\1\164\1"+
        "\uffff\1\44\1\153\1\145\1\162\1\uffff\2\44\1\156\1\143\1\164\1\141"+
        "\1\147\1\157\1\44\1\147\1\44\2\145\1\151\1\162\1\144\1\uffff\3\44"+
        "\1\uffff\1\44\1\141\1\156\2\uffff\1\147\1\164\1\145\1\164\1\162"+
        "\1\155\1\uffff\1\162\1\146\1\156\1\147\1\145\1\44\3\uffff\1\156"+
        "\4\44\1\151\1\157\1\103\1\157\2\164\1\150\1\44\1\uffff\1\44\4\uffff"+
        "\1\157\1\165\2\145\1\151\1\165\1\44\1\162\1\164\1\145\1\151\2\uffff"+
        "\2\156\1\146\1\156\1\147\1\156\1\145\1\44\1\146\1\147\1\44\1\144"+
        "\2\164\1\150\1\144\1\44\1\164\1\150\1\uffff\2\44\1\162\1\164\2\44"+
        "\1\164\1\145\3\44";
    static final String DFA18_maxS =
        "\1\ufaff\2\uffff\1\145\2\uffff\1\157\2\uffff\1\75\1\71\1\150\1"+
        "\157\1\156\1\154\1\162\1\145\5\uffff\2\75\1\53\1\55\1\uffff\1\57"+
        "\1\uffff\1\165\1\71\1\162\1\uffff\1\164\1\142\1\160\1\156\2\157"+
        "\1\141\1\157\1\145\3\uffff\1\164\1\151\4\uffff\1\151\1\162\1\154"+
        "\1\157\1\ufaff\1\164\1\163\1\145\1\157\1\164\12\uffff\1\167\1\154"+
        "\1\uffff\1\165\1\162\1\152\1\162\1\151\1\143\1\164\1\151\1\162\1"+
        "\163\1\160\1\156\1\150\1\144\1\154\1\ufaff\1\163\1\141\1\uffff\1"+
        "\ufaff\1\145\1\141\1\154\1\165\1\ufaff\1\154\1\145\1\151\1\145\1"+
        "\151\1\155\1\153\1\164\1\154\1\145\1\163\1\122\1\164\1\157\1\ufaff"+
        "\1\145\1\uffff\1\145\1\164\1\uffff\1\ufaff\1\153\1\145\1\162\1\uffff"+
        "\2\ufaff\1\156\1\143\1\164\1\141\1\147\1\157\1\ufaff\1\147\1\ufaff"+
        "\2\145\1\151\1\162\1\144\1\uffff\3\ufaff\1\uffff\1\ufaff\1\141\1"+
        "\156\2\uffff\1\147\1\164\1\145\1\164\1\162\1\155\1\uffff\1\162\1"+
        "\146\1\156\1\147\1\145\1\ufaff\3\uffff\1\156\4\ufaff\1\151\1\157"+
        "\1\122\1\157\2\164\1\150\1\ufaff\1\uffff\1\ufaff\4\uffff\1\157\1"+
        "\165\2\145\1\151\1\165\1\ufaff\1\162\1\164\1\145\1\151\2\uffff\2"+
        "\156\1\146\1\156\1\147\1\156\1\145\1\ufaff\1\146\1\147\1\ufaff\1"+
        "\144\2\164\1\150\1\144\1\ufaff\1\164\1\150\1\uffff\2\ufaff\1\162"+
        "\1\164\2\ufaff\1\164\1\145\3\ufaff";
    static final String DFA18_acceptS =
        "\1\uffff\1\1\1\2\1\uffff\1\4\1\5\1\uffff\1\7\1\10\10\uffff\1\21"+
        "\1\22\1\23\1\24\1\26\4\uffff\1\35\1\uffff\1\37\3\uffff\1\47\11\uffff"+
        "\1\61\1\62\1\63\2\uffff\1\25\1\11\1\12\1\45\12\uffff\1\31\1\27\1"+
        "\32\1\30\1\40\1\33\1\41\1\34\1\64\1\36\2\uffff\1\44\22\uffff\1\15"+
        "\26\uffff\1\14\2\uffff\1\50\4\uffff\1\42\20\uffff\1\6\3\uffff\1"+
        "\16\3\uffff\1\43\1\46\6\uffff\1\57\6\uffff\1\13\1\53\1\17\15\uffff"+
        "\1\3\1\uffff\1\20\1\52\1\54\1\55\13\uffff\1\60\1\51\23\uffff\1\56"+
        "\13\uffff";
    static final String DFA18_specialS =
        "\u00e5\uffff}>";
    static final String[] DFA18_transitionS = {
            "\2\54\1\uffff\2\54\22\uffff\1\54\1\25\1\40\1\uffff\1\52\1\34"+
            "\1\24\1\uffff\1\4\1\5\1\32\1\30\1\10\1\31\1\12\1\33\12\36\1"+
            "\22\1\7\1\26\1\11\1\27\1\21\1\uffff\1\44\1\45\1\51\2\52\1\46"+
            "\10\52\1\42\1\47\2\52\1\43\1\50\6\52\1\uffff\1\53\2\uffff\1"+
            "\52\1\uffff\1\52\1\17\2\52\1\16\1\14\2\52\1\15\3\52\1\3\1\35"+
            "\3\52\1\20\1\41\1\37\1\52\1\6\1\13\3\52\1\1\1\23\1\2\102\uffff"+
            "\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff\u0150\52\u0170"+
            "\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff\u5200\52\u5900"+
            "\uffff\u0200\52",
            "",
            "",
            "\1\55",
            "",
            "",
            "\1\56",
            "",
            "",
            "\1\57",
            "\12\62",
            "\1\63",
            "\1\65\12\uffff\1\66\2\uffff\1\64",
            "\1\67\7\uffff\1\70",
            "\1\71",
            "\1\73\2\uffff\1\72",
            "\1\74",
            "",
            "",
            "",
            "",
            "",
            "\1\75",
            "\1\77",
            "\1\101",
            "\1\103",
            "",
            "\1\105\4\uffff\1\105",
            "",
            "\1\107\17\uffff\1\110",
            "\1\62\1\uffff\12\36",
            "\1\112",
            "",
            "\1\113",
            "\1\114",
            "\1\115",
            "\1\116",
            "\1\117\15\uffff\1\120",
            "\1\121\15\uffff\1\122",
            "\1\123",
            "\1\124",
            "\1\125",
            "",
            "",
            "",
            "\1\126",
            "\1\127",
            "",
            "",
            "",
            "",
            "\1\130",
            "\1\131",
            "\1\132",
            "\1\133",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\135",
            "\1\136",
            "\1\137",
            "\1\140",
            "\1\141",
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
            "\1\142",
            "\1\143",
            "",
            "\1\144",
            "\1\145",
            "\1\146",
            "\1\147",
            "\1\150",
            "\1\151",
            "\1\152",
            "\1\153",
            "\1\154",
            "\1\155",
            "\1\156",
            "\1\157",
            "\1\160",
            "\1\161",
            "\1\162",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\164",
            "\1\165",
            "",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\167",
            "\1\170",
            "\1\171",
            "\1\172",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\174",
            "\1\175",
            "\1\176",
            "\1\177",
            "\1\u0080",
            "\1\u0081",
            "\1\u0082",
            "\1\u0083",
            "\1\u0084",
            "\1\u0085",
            "\1\u0086",
            "\1\u0088\10\uffff\1\u0087\5\uffff\1\u0089",
            "\1\u008a",
            "\1\u008b",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u008d",
            "",
            "\1\u008e",
            "\1\u008f",
            "",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u0091",
            "\1\u0092",
            "\1\u0093",
            "",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u0096",
            "\1\u0097",
            "\1\u0098",
            "\1\u0099",
            "\1\u009a",
            "\1\u009b",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u009d",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u009e",
            "\1\u009f",
            "\1\u00a0",
            "\1\u00a1",
            "\1\u00a2",
            "",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u00a6",
            "\1\u00a7",
            "",
            "",
            "\1\u00a8",
            "\1\u00a9",
            "\1\u00aa",
            "\1\u00ab",
            "\1\u00ac",
            "\1\u00ad",
            "",
            "\1\u00ae",
            "\1\u00af",
            "\1\u00b0",
            "\1\u00b1",
            "\1\u00b2",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "",
            "",
            "",
            "\1\u00b4",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u00b9",
            "\1\u00ba",
            "\1\u00bc\10\uffff\1\u00bb\5\uffff\1\u00bd",
            "\1\u00be",
            "\1\u00bf",
            "\1\u00c0",
            "\1\u00c1",
            "\1\52\13\uffff\12\52\7\uffff\13\52\1\u00c2\5\52\1\u00c3\10"+
            "\52\4\uffff\1\52\1\uffff\32\52\105\uffff\27\52\1\uffff\37\52"+
            "\1\uffff\u1f08\52\u1040\uffff\u0150\52\u0170\uffff\u0080\52"+
            "\u0080\uffff\u092e\52\u10d2\uffff\u5200\52\u5900\uffff\u0200"+
            "\52",
            "",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "",
            "",
            "",
            "",
            "\1\u00c6",
            "\1\u00c7",
            "\1\u00c8",
            "\1\u00c9",
            "\1\u00ca",
            "\1\u00cb",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u00cc",
            "\1\u00cd",
            "\1\u00ce",
            "\1\u00cf",
            "",
            "",
            "\1\u00d0",
            "\1\u00d1",
            "\1\u00d2",
            "\1\u00d3",
            "\1\u00d4",
            "\1\u00d5",
            "\1\u00d6",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u00d7",
            "\1\u00d8",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u00da",
            "\1\u00db",
            "\1\u00dc",
            "\1\u00dd",
            "\1\u00de",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u00df",
            "\1\u00e0",
            "",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u00e1",
            "\1\u00e2",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\u00e3",
            "\1\u00e4",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52",
            "\1\52\13\uffff\12\52\7\uffff\32\52\4\uffff\1\52\1\uffff\32"+
            "\52\105\uffff\27\52\1\uffff\37\52\1\uffff\u1f08\52\u1040\uffff"+
            "\u0150\52\u0170\uffff\u0080\52\u0080\uffff\u092e\52\u10d2\uffff"+
            "\u5200\52\u5900\uffff\u0200\52"
    };

    static final short[] DFA18_eot = DFA.unpackEncodedString(DFA18_eotS);
    static final short[] DFA18_eof = DFA.unpackEncodedString(DFA18_eofS);
    static final char[] DFA18_min = DFA.unpackEncodedStringToUnsignedChars(DFA18_minS);
    static final char[] DFA18_max = DFA.unpackEncodedStringToUnsignedChars(DFA18_maxS);
    static final short[] DFA18_accept = DFA.unpackEncodedString(DFA18_acceptS);
    static final short[] DFA18_special = DFA.unpackEncodedString(DFA18_specialS);
    static final short[][] DFA18_transition;

    static {
        int numStates = DFA18_transitionS.length;
        DFA18_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA18_transition[i] = DFA.unpackEncodedString(DFA18_transitionS[i]);
        }
    }

    class DFA18 extends DFA {

        public DFA18(BaseRecognizer recognizer) {
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
        public String getDescription() {
            return "1:1: Tokens : ( T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | T__55 | T__56 | T__57 | T__58 | T__59 | T__60 | T__61 | T__62 | T__63 | T__64 | T__65 | T__66 | T__67 | T__68 | T__69 | T__70 | T__71 | T__72 | T__73 | T__74 | T__75 | T__76 | T__77 | T__78 | T__79 | T__80 | T__81 | IntegerAtom | FloatAtom | BooleanAtom | StringAtom | IntType | BooleanType | StringType | FloatType | ObjectType | Sprite | Animation | Layer | Origin | Identifier | EscapeSequence | WS | COMMENT );";
        }
    }
 

}