// $ANTLR 3.2 Sep 23, 2009 12:02:23 C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g 2011-08-03 23:27:24

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

public class SGLLexer extends Lexer {
    public static final int T__29=29;
    public static final int T__28=28;
    public static final int SGLIDDigit=22;
    public static final int IntType=10;
    public static final int EOF=-1;
    public static final int Identifier=9;
    public static final int T__51=51;
    public static final int T__52=52;
    public static final int T__53=53;
    public static final int T__54=54;
    public static final int StringType=12;
    public static final int SpriteAnimation=18;
    public static final int VARDEF=4;
    public static final int COMMENT=27;
    public static final int T__50=50;
    public static final int BooleanType=11;
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
    public static final int LIBMETHOD=7;
    public static final int IntegerAtom=15;
    public static final int FloatType=13;
    public static final int StringAtom=19;
    public static final int HEX_DIGIT=25;
    public static final int NEGATE=6;
    public static final int BooleanAtom=17;
    public static final int T__30=30;
    public static final int T__31=31;
    public static final int T__32=32;
    public static final int WS=26;
    public static final int T__33=33;
    public static final int T__34=34;
    public static final int T__35=35;
    public static final int T__36=36;
    public static final int T__37=37;
    public static final int T__38=38;
    public static final int T__39=39;
    public static final int UnicodeEscape=23;
    public static final int ASSIGN=5;
    public static final int ObjectType=14;
    public static final int FloatAtom=16;
    public static final int EscapeSequence=20;
    public static final int Letter=21;
    public static final int OctalEscape=24;
    public static final int STRING=8;

    // delegates
    // delegators

    public SGLLexer() {;} 
    public SGLLexer(CharStream input) {
        this(input, new RecognizerSharedState());
    }
    public SGLLexer(CharStream input, RecognizerSharedState state) {
        super(input,state);

    }
    public String getGrammarFileName() { return "C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g"; }

    // $ANTLR start "T__28"
    public final void mT__28() throws RecognitionException {
        try {
            int _type = T__28;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:3:7: ( ',' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:3:9: ','
            {
            match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__28"

    // $ANTLR start "T__29"
    public final void mT__29() throws RecognitionException {
        try {
            int _type = T__29;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:4:7: ( '=' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:4:9: '='
            {
            match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__29"

    // $ANTLR start "T__30"
    public final void mT__30() throws RecognitionException {
        try {
            int _type = T__30;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:5:7: ( 'while' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:5:9: 'while'
            {
            match("while"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__30"

    // $ANTLR start "T__31"
    public final void mT__31() throws RecognitionException {
        try {
            int _type = T__31;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:6:7: ( '(' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:6:9: '('
            {
            match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__31"

    // $ANTLR start "T__32"
    public final void mT__32() throws RecognitionException {
        try {
            int _type = T__32;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:7:7: ( ')' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:7:9: ')'
            {
            match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__32"

    // $ANTLR start "T__33"
    public final void mT__33() throws RecognitionException {
        try {
            int _type = T__33;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:8:7: ( '{' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:8:9: '{'
            {
            match('{'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__33"

    // $ANTLR start "T__34"
    public final void mT__34() throws RecognitionException {
        try {
            int _type = T__34;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:9:7: ( '}' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:9:9: '}'
            {
            match('}'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__34"

    // $ANTLR start "T__35"
    public final void mT__35() throws RecognitionException {
        try {
            int _type = T__35;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:10:7: ( '?' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:10:9: '?'
            {
            match('?'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__35"

    // $ANTLR start "T__36"
    public final void mT__36() throws RecognitionException {
        try {
            int _type = T__36;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:11:7: ( ':' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:11:9: ':'
            {
            match(':'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__36"

    // $ANTLR start "T__37"
    public final void mT__37() throws RecognitionException {
        try {
            int _type = T__37;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:12:7: ( '||' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:12:9: '||'
            {
            match("||"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__37"

    // $ANTLR start "T__38"
    public final void mT__38() throws RecognitionException {
        try {
            int _type = T__38;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:13:7: ( '&&' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:13:9: '&&'
            {
            match("&&"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__38"

    // $ANTLR start "T__39"
    public final void mT__39() throws RecognitionException {
        try {
            int _type = T__39;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:14:7: ( '==' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:14:9: '=='
            {
            match("=="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__39"

    // $ANTLR start "T__40"
    public final void mT__40() throws RecognitionException {
        try {
            int _type = T__40;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:15:7: ( '!=' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:15:9: '!='
            {
            match("!="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__40"

    // $ANTLR start "T__41"
    public final void mT__41() throws RecognitionException {
        try {
            int _type = T__41;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:16:7: ( '<' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:16:9: '<'
            {
            match('<'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__41"

    // $ANTLR start "T__42"
    public final void mT__42() throws RecognitionException {
        try {
            int _type = T__42;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:17:7: ( '>' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:17:9: '>'
            {
            match('>'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__42"

    // $ANTLR start "T__43"
    public final void mT__43() throws RecognitionException {
        try {
            int _type = T__43;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:18:7: ( '<=' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:18:9: '<='
            {
            match("<="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__43"

    // $ANTLR start "T__44"
    public final void mT__44() throws RecognitionException {
        try {
            int _type = T__44;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:19:7: ( '>=' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:19:9: '>='
            {
            match(">="); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__44"

    // $ANTLR start "T__45"
    public final void mT__45() throws RecognitionException {
        try {
            int _type = T__45;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:20:7: ( '+' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:20:9: '+'
            {
            match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__45"

    // $ANTLR start "T__46"
    public final void mT__46() throws RecognitionException {
        try {
            int _type = T__46;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:21:7: ( '-' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:21:9: '-'
            {
            match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__46"

    // $ANTLR start "T__47"
    public final void mT__47() throws RecognitionException {
        try {
            int _type = T__47;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:22:7: ( '*' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:22:9: '*'
            {
            match('*'); 

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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:23:7: ( '/' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:23:9: '/'
            {
            match('/'); 

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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:24:7: ( '%' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:24:9: '%'
            {
            match('%'); 

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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:25:7: ( '++' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:25:9: '++'
            {
            match("++"); 


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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:26:7: ( '--' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:26:9: '--'
            {
            match("--"); 


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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:27:7: ( '!' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:27:9: '!'
            {
            match('!'); 

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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:28:7: ( 'new' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:28:9: 'new'
            {
            match("new"); 


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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:29:7: ( 'null' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:29:9: 'null'
            {
            match("null"); 


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "T__54"

    // $ANTLR start "IntegerAtom"
    public final void mIntegerAtom() throws RecognitionException {
        try {
            int _type = IntegerAtom;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:267:5: ( ( '0' .. '9' )+ )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:267:7: ( '0' .. '9' )+
            {
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:267:7: ( '0' .. '9' )+
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
            	    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:267:7: '0' .. '9'
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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:271:5: ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ )
            int alt6=3;
            alt6 = dfa6.predict(input);
            switch (alt6) {
                case 1 :
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:271:9: ( '0' .. '9' )+ '.' ( '0' .. '9' )*
                    {
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:271:9: ( '0' .. '9' )+
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
                    	    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:271:10: '0' .. '9'
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
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:271:25: ( '0' .. '9' )*
                    loop3:
                    do {
                        int alt3=2;
                        int LA3_0 = input.LA(1);

                        if ( ((LA3_0>='0' && LA3_0<='9')) ) {
                            alt3=1;
                        }


                        switch (alt3) {
                    	case 1 :
                    	    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:271:26: '0' .. '9'
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
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:272:9: '.' ( '0' .. '9' )+
                    {
                    match('.'); 
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:272:13: ( '0' .. '9' )+
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
                    	    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:272:14: '0' .. '9'
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
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:273:9: ( '0' .. '9' )+
                    {
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:273:9: ( '0' .. '9' )+
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
                    	    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:273:10: '0' .. '9'
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

    // $ANTLR start "StringAtom"
    public final void mStringAtom() throws RecognitionException {
        try {
            int _type = StringAtom;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:277:5: ( '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )+ '\"' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:277:8: '\"' ( EscapeSequence | ~ ( '\\\\' | '\"' ) )+ '\"'
            {
            match('\"'); 
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:277:12: ( EscapeSequence | ~ ( '\\\\' | '\"' ) )+
            int cnt7=0;
            loop7:
            do {
                int alt7=3;
                int LA7_0 = input.LA(1);

                if ( (LA7_0=='\\') ) {
                    alt7=1;
                }
                else if ( ((LA7_0>='\u0000' && LA7_0<='!')||(LA7_0>='#' && LA7_0<='[')||(LA7_0>=']' && LA7_0<='\uFFFF')) ) {
                    alt7=2;
                }


                switch (alt7) {
            	case 1 :
            	    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:277:14: EscapeSequence
            	    {
            	    mEscapeSequence(); 

            	    }
            	    break;
            	case 2 :
            	    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:277:31: ~ ( '\\\\' | '\"' )
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
            	    if ( cnt7 >= 1 ) break loop7;
                        EarlyExitException eee =
                            new EarlyExitException(7, input);
                        throw eee;
                }
                cnt7++;
            } while (true);

            match('\"'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "StringAtom"

    // $ANTLR start "BooleanAtom"
    public final void mBooleanAtom() throws RecognitionException {
        try {
            int _type = BooleanAtom;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:281:5: ( 'true' | 'false' )
            int alt8=2;
            int LA8_0 = input.LA(1);

            if ( (LA8_0=='t') ) {
                alt8=1;
            }
            else if ( (LA8_0=='f') ) {
                alt8=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 8, 0, input);

                throw nvae;
            }
            switch (alt8) {
                case 1 :
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:281:9: 'true'
                    {
                    match("true"); 


                    }
                    break;
                case 2 :
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:282:9: 'false'
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

    // $ANTLR start "IntType"
    public final void mIntType() throws RecognitionException {
        try {
            int _type = IntType;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:286:2: ( 'int' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:286:4: 'int'
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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:290:2: ( 'boolean' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:290:4: 'boolean'
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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:294:2: ( 'string' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:294:4: 'string'
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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:298:2: ( 'float' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:298:4: 'float'
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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:304:2: ( 'Object' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:304:4: 'Object'
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

    // $ANTLR start "SpriteAnimation"
    public final void mSpriteAnimation() throws RecognitionException {
        try {
            int _type = SpriteAnimation;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:308:2: ( 'Sprite' | 'Animation' )
            int alt9=2;
            int LA9_0 = input.LA(1);

            if ( (LA9_0=='S') ) {
                alt9=1;
            }
            else if ( (LA9_0=='A') ) {
                alt9=2;
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 9, 0, input);

                throw nvae;
            }
            switch (alt9) {
                case 1 :
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:308:4: 'Sprite'
                    {
                    match("Sprite"); 


                    }
                    break;
                case 2 :
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:309:4: 'Animation'
                    {
                    match("Animation"); 


                    }
                    break;

            }
            state.type = _type;
            state.channel = _channel;
        }
        finally {
        }
    }
    // $ANTLR end "SpriteAnimation"

    // $ANTLR start "Identifier"
    public final void mIdentifier() throws RecognitionException {
        try {
            int _type = Identifier;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:315:5: ( Letter ( Letter | SGLIDDigit )* )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:315:9: Letter ( Letter | SGLIDDigit )*
            {
            mLetter(); 
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:315:16: ( Letter | SGLIDDigit )*
            loop10:
            do {
                int alt10=2;
                int LA10_0 = input.LA(1);

                if ( (LA10_0=='$'||(LA10_0>='0' && LA10_0<='9')||(LA10_0>='A' && LA10_0<='Z')||LA10_0=='_'||(LA10_0>='a' && LA10_0<='z')||(LA10_0>='\u00C0' && LA10_0<='\u00D6')||(LA10_0>='\u00D8' && LA10_0<='\u00F6')||(LA10_0>='\u00F8' && LA10_0<='\u1FFF')||(LA10_0>='\u3040' && LA10_0<='\u318F')||(LA10_0>='\u3300' && LA10_0<='\u337F')||(LA10_0>='\u3400' && LA10_0<='\u3D2D')||(LA10_0>='\u4E00' && LA10_0<='\u9FFF')||(LA10_0>='\uF900' && LA10_0<='\uFAFF')) ) {
                    alt10=1;
                }


                switch (alt10) {
            	case 1 :
            	    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
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
            	    break loop10;
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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:327:5: ( '\\u0024' | '\\u0041' .. '\\u005a' | '\\u005f' | '\\u0061' .. '\\u007a' | '\\u00c0' .. '\\u00d6' | '\\u00d8' .. '\\u00f6' | '\\u00f8' .. '\\u00ff' | '\\u0100' .. '\\u1fff' | '\\u3040' .. '\\u318f' | '\\u3300' .. '\\u337f' | '\\u3400' .. '\\u3d2d' | '\\u4e00' .. '\\u9fff' | '\\uf900' .. '\\ufaff' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:344:5: ( '\\u0030' .. '\\u0039' | '\\u0660' .. '\\u0669' | '\\u06f0' .. '\\u06f9' | '\\u0966' .. '\\u096f' | '\\u09e6' .. '\\u09ef' | '\\u0a66' .. '\\u0a6f' | '\\u0ae6' .. '\\u0aef' | '\\u0b66' .. '\\u0b6f' | '\\u0be7' .. '\\u0bef' | '\\u0c66' .. '\\u0c6f' | '\\u0ce6' .. '\\u0cef' | '\\u0d66' .. '\\u0d6f' | '\\u0e50' .. '\\u0e59' | '\\u0ed0' .. '\\u0ed9' | '\\u1040' .. '\\u1049' )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:
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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:365:5: ( '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' ) | UnicodeEscape | OctalEscape )
            int alt11=3;
            int LA11_0 = input.LA(1);

            if ( (LA11_0=='\\') ) {
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
                    alt11=1;
                    }
                    break;
                case 'u':
                    {
                    alt11=2;
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
                    alt11=3;
                    }
                    break;
                default:
                    NoViableAltException nvae =
                        new NoViableAltException("", 11, 1, input);

                    throw nvae;
                }

            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 11, 0, input);

                throw nvae;
            }
            switch (alt11) {
                case 1 :
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:365:9: '\\\\' ( 'b' | 't' | 'n' | 'f' | 'r' | '\\\"' | '\\'' | '\\\\' )
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
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:366:9: UnicodeEscape
                    {
                    mUnicodeEscape(); 

                    }
                    break;
                case 3 :
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:367:9: OctalEscape
                    {
                    mOctalEscape(); 

                    }
                    break;

            }
        }
        finally {
        }
    }
    // $ANTLR end "EscapeSequence"

    // $ANTLR start "OctalEscape"
    public final void mOctalEscape() throws RecognitionException {
        try {
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:372:5: ( '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) ( '0' .. '7' ) | '\\\\' ( '0' .. '7' ) )
            int alt12=3;
            int LA12_0 = input.LA(1);

            if ( (LA12_0=='\\') ) {
                int LA12_1 = input.LA(2);

                if ( ((LA12_1>='0' && LA12_1<='3')) ) {
                    int LA12_2 = input.LA(3);

                    if ( ((LA12_2>='0' && LA12_2<='7')) ) {
                        int LA12_4 = input.LA(4);

                        if ( ((LA12_4>='0' && LA12_4<='7')) ) {
                            alt12=1;
                        }
                        else {
                            alt12=2;}
                    }
                    else {
                        alt12=3;}
                }
                else if ( ((LA12_1>='4' && LA12_1<='7')) ) {
                    int LA12_3 = input.LA(3);

                    if ( ((LA12_3>='0' && LA12_3<='7')) ) {
                        alt12=2;
                    }
                    else {
                        alt12=3;}
                }
                else {
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
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:372:9: '\\\\' ( '0' .. '3' ) ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    match('\\'); 
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:372:14: ( '0' .. '3' )
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:372:15: '0' .. '3'
                    {
                    matchRange('0','3'); 

                    }

                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:372:25: ( '0' .. '7' )
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:372:26: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }

                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:372:36: ( '0' .. '7' )
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:372:37: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }


                    }
                    break;
                case 2 :
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:373:9: '\\\\' ( '0' .. '7' ) ( '0' .. '7' )
                    {
                    match('\\'); 
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:373:14: ( '0' .. '7' )
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:373:15: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }

                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:373:25: ( '0' .. '7' )
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:373:26: '0' .. '7'
                    {
                    matchRange('0','7'); 

                    }


                    }
                    break;
                case 3 :
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:374:9: '\\\\' ( '0' .. '7' )
                    {
                    match('\\'); 
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:374:14: ( '0' .. '7' )
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:374:15: '0' .. '7'
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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:379:5: ( '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:379:9: '\\\\' 'u' HEX_DIGIT HEX_DIGIT HEX_DIGIT HEX_DIGIT
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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:383:11: ( ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' ) )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:383:13: ( '0' .. '9' | 'a' .. 'f' | 'A' .. 'F' )
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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:389:5: ( ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' ) )
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:389:8: ( ' ' | '\\r' | '\\t' | '\\u000C' | '\\n' )
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
            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:394:5: ( '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n' | '/*' ( options {greedy=false; } : . )* '*/' )
            int alt16=2;
            int LA16_0 = input.LA(1);

            if ( (LA16_0=='/') ) {
                int LA16_1 = input.LA(2);

                if ( (LA16_1=='/') ) {
                    alt16=1;
                }
                else if ( (LA16_1=='*') ) {
                    alt16=2;
                }
                else {
                    NoViableAltException nvae =
                        new NoViableAltException("", 16, 1, input);

                    throw nvae;
                }
            }
            else {
                NoViableAltException nvae =
                    new NoViableAltException("", 16, 0, input);

                throw nvae;
            }
            switch (alt16) {
                case 1 :
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:394:9: '//' (~ ( '\\n' | '\\r' ) )* ( '\\r' )? '\\n'
                    {
                    match("//"); 

                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:394:14: (~ ( '\\n' | '\\r' ) )*
                    loop13:
                    do {
                        int alt13=2;
                        int LA13_0 = input.LA(1);

                        if ( ((LA13_0>='\u0000' && LA13_0<='\t')||(LA13_0>='\u000B' && LA13_0<='\f')||(LA13_0>='\u000E' && LA13_0<='\uFFFF')) ) {
                            alt13=1;
                        }


                        switch (alt13) {
                    	case 1 :
                    	    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:394:14: ~ ( '\\n' | '\\r' )
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
                    	    break loop13;
                        }
                    } while (true);

                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:394:28: ( '\\r' )?
                    int alt14=2;
                    int LA14_0 = input.LA(1);

                    if ( (LA14_0=='\r') ) {
                        alt14=1;
                    }
                    switch (alt14) {
                        case 1 :
                            // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:394:28: '\\r'
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
                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:395:9: '/*' ( options {greedy=false; } : . )* '*/'
                    {
                    match("/*"); 

                    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:395:14: ( options {greedy=false; } : . )*
                    loop15:
                    do {
                        int alt15=2;
                        int LA15_0 = input.LA(1);

                        if ( (LA15_0=='*') ) {
                            int LA15_1 = input.LA(2);

                            if ( (LA15_1=='/') ) {
                                alt15=2;
                            }
                            else if ( ((LA15_1>='\u0000' && LA15_1<='.')||(LA15_1>='0' && LA15_1<='\uFFFF')) ) {
                                alt15=1;
                            }


                        }
                        else if ( ((LA15_0>='\u0000' && LA15_0<=')')||(LA15_0>='+' && LA15_0<='\uFFFF')) ) {
                            alt15=1;
                        }


                        switch (alt15) {
                    	case 1 :
                    	    // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:395:42: .
                    	    {
                    	    matchAny(); 

                    	    }
                    	    break;

                    	default :
                    	    break loop15;
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
        // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:8: ( T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | IntegerAtom | FloatAtom | StringAtom | BooleanAtom | IntType | BooleanType | StringType | FloatType | ObjectType | SpriteAnimation | Identifier | WS | COMMENT )
        int alt17=40;
        alt17 = dfa17.predict(input);
        switch (alt17) {
            case 1 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:10: T__28
                {
                mT__28(); 

                }
                break;
            case 2 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:16: T__29
                {
                mT__29(); 

                }
                break;
            case 3 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:22: T__30
                {
                mT__30(); 

                }
                break;
            case 4 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:28: T__31
                {
                mT__31(); 

                }
                break;
            case 5 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:34: T__32
                {
                mT__32(); 

                }
                break;
            case 6 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:40: T__33
                {
                mT__33(); 

                }
                break;
            case 7 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:46: T__34
                {
                mT__34(); 

                }
                break;
            case 8 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:52: T__35
                {
                mT__35(); 

                }
                break;
            case 9 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:58: T__36
                {
                mT__36(); 

                }
                break;
            case 10 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:64: T__37
                {
                mT__37(); 

                }
                break;
            case 11 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:70: T__38
                {
                mT__38(); 

                }
                break;
            case 12 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:76: T__39
                {
                mT__39(); 

                }
                break;
            case 13 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:82: T__40
                {
                mT__40(); 

                }
                break;
            case 14 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:88: T__41
                {
                mT__41(); 

                }
                break;
            case 15 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:94: T__42
                {
                mT__42(); 

                }
                break;
            case 16 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:100: T__43
                {
                mT__43(); 

                }
                break;
            case 17 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:106: T__44
                {
                mT__44(); 

                }
                break;
            case 18 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:112: T__45
                {
                mT__45(); 

                }
                break;
            case 19 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:118: T__46
                {
                mT__46(); 

                }
                break;
            case 20 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:124: T__47
                {
                mT__47(); 

                }
                break;
            case 21 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:130: T__48
                {
                mT__48(); 

                }
                break;
            case 22 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:136: T__49
                {
                mT__49(); 

                }
                break;
            case 23 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:142: T__50
                {
                mT__50(); 

                }
                break;
            case 24 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:148: T__51
                {
                mT__51(); 

                }
                break;
            case 25 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:154: T__52
                {
                mT__52(); 

                }
                break;
            case 26 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:160: T__53
                {
                mT__53(); 

                }
                break;
            case 27 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:166: T__54
                {
                mT__54(); 

                }
                break;
            case 28 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:172: IntegerAtom
                {
                mIntegerAtom(); 

                }
                break;
            case 29 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:184: FloatAtom
                {
                mFloatAtom(); 

                }
                break;
            case 30 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:194: StringAtom
                {
                mStringAtom(); 

                }
                break;
            case 31 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:205: BooleanAtom
                {
                mBooleanAtom(); 

                }
                break;
            case 32 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:217: IntType
                {
                mIntType(); 

                }
                break;
            case 33 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:225: BooleanType
                {
                mBooleanType(); 

                }
                break;
            case 34 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:237: StringType
                {
                mStringType(); 

                }
                break;
            case 35 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:248: FloatType
                {
                mFloatType(); 

                }
                break;
            case 36 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:258: ObjectType
                {
                mObjectType(); 

                }
                break;
            case 37 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:269: SpriteAnimation
                {
                mSpriteAnimation(); 

                }
                break;
            case 38 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:285: Identifier
                {
                mIdentifier(); 

                }
                break;
            case 39 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:296: WS
                {
                mWS(); 

                }
                break;
            case 40 :
                // C:\\Austausch\\Visual Studio 2010\\Projects\\SGLParserTester\\SGLParserTester\\SGL.g:1:299: COMMENT
                {
                mCOMMENT(); 

                }
                break;

        }

    }


    protected DFA6 dfa6 = new DFA6(this);
    protected DFA17 dfa17 = new DFA17(this);
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
            return "270:1: FloatAtom : ( ( '0' .. '9' )+ '.' ( '0' .. '9' )* | '.' ( '0' .. '9' )+ | ( '0' .. '9' )+ );";
        }
    }
    static final String DFA17_eotS =
        "\2\uffff\1\43\1\40\10\uffff\1\46\1\50\1\52\1\54\1\56\1\uffff\1"+
        "\60\1\uffff\1\40\1\63\2\uffff\10\40\4\uffff\1\40\14\uffff\2\40\1"+
        "\uffff\12\40\1\112\4\40\1\117\6\40\1\uffff\1\126\1\127\2\40\1\uffff"+
        "\5\40\1\137\2\uffff\1\127\1\140\5\40\2\uffff\1\40\1\147\1\150\1"+
        "\151\1\40\1\153\3\uffff\1\40\1\uffff\1\40\1\151";
    static final String DFA17_eofS =
        "\156\uffff";
    static final String DFA17_minS =
        "\1\11\1\uffff\1\75\1\150\10\uffff\3\75\1\53\1\55\1\uffff\1\52\1"+
        "\uffff\1\145\1\56\2\uffff\1\162\1\141\1\156\1\157\1\164\1\142\1"+
        "\160\1\156\4\uffff\1\151\14\uffff\1\167\1\154\1\uffff\1\165\1\154"+
        "\1\157\1\164\1\157\1\162\1\152\1\162\1\151\1\154\1\44\1\154\1\145"+
        "\1\163\1\141\1\44\1\154\1\151\1\145\1\151\1\155\1\145\1\uffff\2"+
        "\44\1\145\1\164\1\uffff\1\145\1\156\1\143\1\164\1\141\1\44\2\uffff"+
        "\2\44\1\141\1\147\1\164\1\145\1\164\2\uffff\1\156\3\44\1\151\1\44"+
        "\3\uffff\1\157\1\uffff\1\156\1\44";
    static final String DFA17_maxS =
        "\1\ufaff\1\uffff\1\75\1\150\10\uffff\3\75\1\53\1\55\1\uffff\1\57"+
        "\1\uffff\1\165\1\71\2\uffff\1\162\1\154\1\156\1\157\1\164\1\142"+
        "\1\160\1\156\4\uffff\1\151\14\uffff\1\167\1\154\1\uffff\1\165\1"+
        "\154\1\157\1\164\1\157\1\162\1\152\1\162\1\151\1\154\1\ufaff\1\154"+
        "\1\145\1\163\1\141\1\ufaff\1\154\1\151\1\145\1\151\1\155\1\145\1"+
        "\uffff\2\ufaff\1\145\1\164\1\uffff\1\145\1\156\1\143\1\164\1\141"+
        "\1\ufaff\2\uffff\2\ufaff\1\141\1\147\1\164\1\145\1\164\2\uffff\1"+
        "\156\3\ufaff\1\151\1\ufaff\3\uffff\1\157\1\uffff\1\156\1\ufaff";
    static final String DFA17_acceptS =
        "\1\uffff\1\1\2\uffff\1\4\1\5\1\6\1\7\1\10\1\11\1\12\1\13\5\uffff"+
        "\1\24\1\uffff\1\26\2\uffff\1\35\1\36\10\uffff\1\46\1\47\1\14\1\2"+
        "\1\uffff\1\15\1\31\1\20\1\16\1\21\1\17\1\27\1\22\1\30\1\23\1\50"+
        "\1\25\2\uffff\1\34\26\uffff\1\32\4\uffff\1\40\6\uffff\1\33\1\37"+
        "\7\uffff\1\3\1\43\6\uffff\1\42\1\44\1\45\1\uffff\1\41\2\uffff";
    static final String DFA17_specialS =
        "\156\uffff}>";
    static final String[] DFA17_transitionS = {
            "\2\41\1\uffff\2\41\22\uffff\1\41\1\14\1\27\1\uffff\1\40\1\23"+
            "\1\13\1\uffff\1\4\1\5\1\21\1\17\1\1\1\20\1\26\1\22\12\25\1\11"+
            "\1\uffff\1\15\1\2\1\16\1\10\1\uffff\1\37\15\40\1\35\3\40\1\36"+
            "\7\40\4\uffff\1\40\1\uffff\1\40\1\33\3\40\1\31\2\40\1\32\4\40"+
            "\1\24\4\40\1\34\1\30\2\40\1\3\3\40\1\6\1\12\1\7\102\uffff\27"+
            "\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff\u0150\40\u0170"+
            "\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff\u5200\40\u5900"+
            "\uffff\u0200\40",
            "",
            "\1\42",
            "\1\44",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\1\45",
            "\1\47",
            "\1\51",
            "\1\53",
            "\1\55",
            "",
            "\1\57\4\uffff\1\57",
            "",
            "\1\61\17\uffff\1\62",
            "\1\26\1\uffff\12\25",
            "",
            "",
            "\1\64",
            "\1\65\12\uffff\1\66",
            "\1\67",
            "\1\70",
            "\1\71",
            "\1\72",
            "\1\73",
            "\1\74",
            "",
            "",
            "",
            "",
            "\1\75",
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
            "\1\76",
            "\1\77",
            "",
            "\1\100",
            "\1\101",
            "\1\102",
            "\1\103",
            "\1\104",
            "\1\105",
            "\1\106",
            "\1\107",
            "\1\110",
            "\1\111",
            "\1\40\13\uffff\12\40\7\uffff\32\40\4\uffff\1\40\1\uffff\32"+
            "\40\105\uffff\27\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff"+
            "\u0150\40\u0170\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff"+
            "\u5200\40\u5900\uffff\u0200\40",
            "\1\113",
            "\1\114",
            "\1\115",
            "\1\116",
            "\1\40\13\uffff\12\40\7\uffff\32\40\4\uffff\1\40\1\uffff\32"+
            "\40\105\uffff\27\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff"+
            "\u0150\40\u0170\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff"+
            "\u5200\40\u5900\uffff\u0200\40",
            "\1\120",
            "\1\121",
            "\1\122",
            "\1\123",
            "\1\124",
            "\1\125",
            "",
            "\1\40\13\uffff\12\40\7\uffff\32\40\4\uffff\1\40\1\uffff\32"+
            "\40\105\uffff\27\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff"+
            "\u0150\40\u0170\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff"+
            "\u5200\40\u5900\uffff\u0200\40",
            "\1\40\13\uffff\12\40\7\uffff\32\40\4\uffff\1\40\1\uffff\32"+
            "\40\105\uffff\27\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff"+
            "\u0150\40\u0170\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff"+
            "\u5200\40\u5900\uffff\u0200\40",
            "\1\130",
            "\1\131",
            "",
            "\1\132",
            "\1\133",
            "\1\134",
            "\1\135",
            "\1\136",
            "\1\40\13\uffff\12\40\7\uffff\32\40\4\uffff\1\40\1\uffff\32"+
            "\40\105\uffff\27\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff"+
            "\u0150\40\u0170\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff"+
            "\u5200\40\u5900\uffff\u0200\40",
            "",
            "",
            "\1\40\13\uffff\12\40\7\uffff\32\40\4\uffff\1\40\1\uffff\32"+
            "\40\105\uffff\27\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff"+
            "\u0150\40\u0170\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff"+
            "\u5200\40\u5900\uffff\u0200\40",
            "\1\40\13\uffff\12\40\7\uffff\32\40\4\uffff\1\40\1\uffff\32"+
            "\40\105\uffff\27\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff"+
            "\u0150\40\u0170\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff"+
            "\u5200\40\u5900\uffff\u0200\40",
            "\1\141",
            "\1\142",
            "\1\143",
            "\1\144",
            "\1\145",
            "",
            "",
            "\1\146",
            "\1\40\13\uffff\12\40\7\uffff\32\40\4\uffff\1\40\1\uffff\32"+
            "\40\105\uffff\27\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff"+
            "\u0150\40\u0170\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff"+
            "\u5200\40\u5900\uffff\u0200\40",
            "\1\40\13\uffff\12\40\7\uffff\32\40\4\uffff\1\40\1\uffff\32"+
            "\40\105\uffff\27\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff"+
            "\u0150\40\u0170\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff"+
            "\u5200\40\u5900\uffff\u0200\40",
            "\1\40\13\uffff\12\40\7\uffff\32\40\4\uffff\1\40\1\uffff\32"+
            "\40\105\uffff\27\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff"+
            "\u0150\40\u0170\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff"+
            "\u5200\40\u5900\uffff\u0200\40",
            "\1\152",
            "\1\40\13\uffff\12\40\7\uffff\32\40\4\uffff\1\40\1\uffff\32"+
            "\40\105\uffff\27\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff"+
            "\u0150\40\u0170\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff"+
            "\u5200\40\u5900\uffff\u0200\40",
            "",
            "",
            "",
            "\1\154",
            "",
            "\1\155",
            "\1\40\13\uffff\12\40\7\uffff\32\40\4\uffff\1\40\1\uffff\32"+
            "\40\105\uffff\27\40\1\uffff\37\40\1\uffff\u1f08\40\u1040\uffff"+
            "\u0150\40\u0170\uffff\u0080\40\u0080\uffff\u092e\40\u10d2\uffff"+
            "\u5200\40\u5900\uffff\u0200\40"
    };

    static final short[] DFA17_eot = DFA.unpackEncodedString(DFA17_eotS);
    static final short[] DFA17_eof = DFA.unpackEncodedString(DFA17_eofS);
    static final char[] DFA17_min = DFA.unpackEncodedStringToUnsignedChars(DFA17_minS);
    static final char[] DFA17_max = DFA.unpackEncodedStringToUnsignedChars(DFA17_maxS);
    static final short[] DFA17_accept = DFA.unpackEncodedString(DFA17_acceptS);
    static final short[] DFA17_special = DFA.unpackEncodedString(DFA17_specialS);
    static final short[][] DFA17_transition;

    static {
        int numStates = DFA17_transitionS.length;
        DFA17_transition = new short[numStates][];
        for (int i=0; i<numStates; i++) {
            DFA17_transition[i] = DFA.unpackEncodedString(DFA17_transitionS[i]);
        }
    }

    class DFA17 extends DFA {

        public DFA17(BaseRecognizer recognizer) {
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
        public String getDescription() {
            return "1:1: Tokens : ( T__28 | T__29 | T__30 | T__31 | T__32 | T__33 | T__34 | T__35 | T__36 | T__37 | T__38 | T__39 | T__40 | T__41 | T__42 | T__43 | T__44 | T__45 | T__46 | T__47 | T__48 | T__49 | T__50 | T__51 | T__52 | T__53 | T__54 | IntegerAtom | FloatAtom | StringAtom | BooleanAtom | IntType | BooleanType | StringType | FloatType | ObjectType | SpriteAnimation | Identifier | WS | COMMENT );";
        }
    }
 

}