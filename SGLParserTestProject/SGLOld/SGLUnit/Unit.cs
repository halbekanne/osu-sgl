using System;
using System.Collections.Generic;
using System.Text;
using SGLOld;
using SGLOld.AntlrParser;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace SGLOld.SGLUnit
{
    public class Unit
    {
        String name;
        String input;
        String output;
        String realOutput = "";

        public Unit(String name, String input, String output)
        {
            this.name = name;
            this.input = input;
            this.output = output;
        }

        public String GetInput()
        {
            return input;
        }

        public String GetOutput()
        {
            return output;
        }

        public String GetRealOutput()
        {
            return realOutput;
        }

        public String GetName()
        {
            return name;
        }


        public Boolean RunTest()
        {
            try
            {
            ANTLRStringStream sStream = new ANTLRStringStream(input);
            SGLLexer lexer = new SGLLexer(sStream);

            CommonTokenStream tStream = new CommonTokenStream(lexer);

            // Parsing
            SGLParser parser = new SGLParser(tStream);
            CommonTree t = (CommonTree)parser.main().Tree;

            // Printing tree
            Console.WriteLine("; " + t.ToStringTree());

            // TreeWalking
            CommonTreeNodeStream treeStream = new CommonTreeNodeStream(t);

            SGLTreeWalker tw = new SGLTreeWalker(treeStream);
            Node returned = tw.main();
            returned.Evaluate();


            realOutput = tw.GetStoryboardCode().ToString();


            // comparison
            realOutput = realOutput.Trim();
            output.Trim();

            if (output.Equals(realOutput))
            {
                return true;
            }
            else
            {
                return false;
            }

            }
            catch (CompilerException ce)
            {
                if (ce.ErrorType.Equals("Antlr.Parser"))
                {
                    Console.WriteLine("Error (wrong syntax) on " + ce.Message);
                }
                else
                {
                    Console.WriteLine("Error (" + ce.ErrorType + ") on line " + ce.Line + ": " + ce.Message);
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten.");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

    }
}
