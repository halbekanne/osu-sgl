using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using SGL.Antlr;
using SGL.Elements;
using SGL.Nodes;

namespace SGL.Tests
{
    public class Unit
    {
        private readonly bool debug;
        private readonly String input;
        private readonly String name;
        private readonly String output;
        private String realOutput = "";

        public Unit(String name, String input, String output)
        {
            this.name = name;
            this.input = input;
            this.output = output;
        }

        public Unit(String name, String input, String output, bool debug)
            : this(name, input, output)
        {
            this.debug = debug;
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
                GlobalMemory.Clear();

                var sStream = new ANTLRStringStream(input);
                var lexer = new SGLLexer(sStream);

                var tStream = new CommonTokenStream(lexer);

                // Parsing
                var parser = new SGLParser(tStream);
                var t = (CommonTree) parser.main().Tree;

                // Printing tree
                Console.WriteLine("; " + t.ToStringTree());

                // TreeWalking
                var treeStream = new CommonTreeNodeStream(t);

                var tw = new SGLTreeWalker(treeStream, true);
                AbstractNode returned = tw.main();
                returned.Evaluate();

                if (debug)
                {
                    realOutput = GlobalMemory.Instance.DebugString;
                }
                else
                {
                    realOutput = GlobalMemory.Instance.StoryboardCode.ToString();
                }

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
                Console.WriteLine(ce.GetExceptionAsString());
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