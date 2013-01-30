using System;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using SGL.Antlr;
using SGL.Elements;

namespace SGL.Tests
{
    internal abstract class AbstractTest
    {
        protected String name = "unknown";
        private String result = "";
        protected bool testDebug = false;
        protected bool testOutput = false;
        protected bool testTree = false;

        public String Result
        {
            get { return result; }
        }

        protected abstract String Input { get; }

        public String Name
        {
            get { return name; }
        }

        protected virtual String ExpectedTree
        {
            get { return ""; }
        }

        protected virtual String ExpectedOutput
        {
            get { return ""; }
        }

        protected virtual String ExpectedDebug
        {
            get { return ""; }
        }

        public Boolean Run()
        {
            // run lexer on input
            var lexer = new SGLLexer(new ANTLRStringStream(Input));
            var tokenStream = new CommonTokenStream(lexer);

            // run parser on tokens
            var parser = new SGLParser(tokenStream);
            var ast = (CommonTree) parser.main().Tree;

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

            var astStream = new CommonTreeNodeStream(ast);

            // run walker on AST
            GlobalMemory.Clear();
            var treewalker = new SGLTreeWalker(astStream, true);
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
    }
}