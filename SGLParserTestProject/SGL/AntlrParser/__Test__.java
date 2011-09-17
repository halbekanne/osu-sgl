import java.io.*;
import org.antlr.runtime.*;
import org.antlr.runtime.debug.DebugEventSocketProxy;


public class __Test__ {

    public static void main(String args[]) throws Exception {
        SGLLexer lex = new SGLLexer(new ANTLRFileStream("C:\\Users\\Dominik Halfkann\\Documents\\Visual Studio 2010\\Projects\\SGLParserTester\\SGL\\AntlrParser\\__Test___input.txt", "UTF8"));
        CommonTokenStream tokens = new CommonTokenStream(lex);

        SGLParser g = new SGLParser(tokens, 60, null);
        try {
            g.compilationUnit();
        } catch (RecognitionException e) {
            e.printStackTrace();
        }
    }
}