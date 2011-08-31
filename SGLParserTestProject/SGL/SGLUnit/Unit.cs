using System;
using System.Collections.Generic;
using System.Text;
using SGL;
using SGL.AntlrParser;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace SGL.SGLUnit
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

            ANTLRStringStream sStream = new ANTLRStringStream(input);
            SGLLexer lexer = new SGLLexer(sStream);

            CommonTokenStream tStream = new CommonTokenStream(lexer);

            // Parsing
            SGLParser parser = new SGLParser(tStream);
            CommonTree t = (CommonTree)parser.compilationUnit().Tree;

            // Printing tree
            Console.WriteLine("; " + t.ToStringTree());

            // TreeWalking
            CommonTreeNodeStream treeStream = new CommonTreeNodeStream(t);

            SGLTreeWalker tw = new SGLTreeWalker(treeStream);
            SGLNode returned = tw.compilationUnit();
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

    }
}
