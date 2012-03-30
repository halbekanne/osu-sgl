using System;
using System.Collections.Generic;
using System.Text;
using SGL;
using SGL.AntlrParser;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace SGL
{
    public class CheckerOTF
    {

        public class Error
        {
            public int line;
            public String msg;

            public Error(int l, String m)
            {
                line = l;
                msg = m;
            }
        }


        public List<Error> Check(String input)
        {
            try
            {
                //Lexing
                ANTLRStringStream sStream = new ANTLRStringStream(input);
                SGLLexer lexer = new SGLLexer(sStream);

                CommonTokenStream tStream = new CommonTokenStream(lexer);

                // Parsing
                SGLCheckerOTF parser = new SGLCheckerOTF(tStream);
                CommonTree t = (CommonTree)parser.main().Tree;

                // Printing tree
                Console.WriteLine("; " + t.ToStringTree());

                return parser.errors;
            }
            catch (Exception ex)
            {
                return new List<Error>();
            }

            
        }
    }
}
