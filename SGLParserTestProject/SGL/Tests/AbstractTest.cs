using System;
using System.Collections.Generic;
using System.Text;
using SGL.Antlr;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using SGL.Elements;

namespace SGL.Tests
{
    abstract class AbstractTest
    {
        private String result = "";
        protected String name = "unknown";
        protected bool testTree = false;
        protected bool testOutput = false;
        protected bool testDebug = false;

        public String Result { get { return result; } }

        public Boolean Run()
        {
            // run lexer on input
            SGLLexer lexer = new SGLLexer(new ANTLRStringStream(Input));
            CommonTokenStream tokenStream = new CommonTokenStream(lexer);

            // run parser on tokens
            SGLParser parser = new SGLParser(tokenStream);
            CommonTree ast = (CommonTree)parser.main().Tree;
            
            // maybe test the tree
            if (testTree)
            {
                if (!ast.ToStringTree().Trim().Equals(ExpectedTree.Trim()))
                {
                    result += "Test " + name + "failed! Tree comparison failed!";
                    result += "Expected tree: " + ExpectedTree.Trim();
                    result += "Given tree: " + ast.ToStringTree().Trim();
                    return false;
                }
            }

            CommonTreeNodeStream astStream = new CommonTreeNodeStream(ast);

            // run walker on AST
            GlobalMemory.Clear();
            SGLTreeWalker treewalker = new SGLTreeWalker(astStream, true);
            treewalker.main().Evaluate();
            //String output = treewalker.GetStoryboardCode().ToString();
            if (testOutput)
            {
                String output = GlobalMemory.Instance.StoryboardCode.ToString();
                if (!output.Trim().Equals(ExpectedOutput.Trim()))
                {
                    result += "Test " + name + "failed! Output comparison failed!";
                    result += "Expected output: \r\n" + ExpectedOutput.Trim();
                    result += "Given output: \r\n" + output.Trim();
                    return false;
                }
            }

            if (testDebug)
            {
                String debug = GlobalMemory.Instance.StoryboardCode.ToString();
                if (!debug.Trim().Equals(ExpectedDebug.Trim()))
                {
                    result += "Test " + name + "failed! Debug comparison failed!";
                    result += "Expected debug: \r\n" + ExpectedDebug.Trim();
                    result += "Given debug: \r\n" + debug.Trim();
                    return false;
                }
            }
            return true;
        }

        abstract protected String Input { get; }
        public String Name { get { return name; } }
        virtual protected String ExpectedTree { get { return ""; } }
        virtual protected String ExpectedOutput { get { return ""; } }
        virtual protected String ExpectedDebug { get { return ""; } }

    }
}
