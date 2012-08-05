using System;
using System.Collections.Generic;
using System.Text;
using SGL;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using SGL.Antlr;
using SGL.Nodes;
using SGL.Elements;

namespace SGL.Tests
{
    public class Unit
    {
        String name;
        String input;
        String output;
        bool debug = false;
        String realOutput = "";

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

                SGLTreeWalker tw = new SGLTreeWalker(treeStream, true);
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
