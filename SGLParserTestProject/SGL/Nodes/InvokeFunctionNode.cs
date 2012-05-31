using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGL.Elements;
using SGL.Library.Classes;
using SGL.Library.Functions;

namespace SGL.Nodes
{
    class InvokeFunctionNode : AbstractNode
    {
        private String funcName;
        private List<AbstractNode> parameters;
        private int line;

        public InvokeFunctionNode(String funcName, List<AbstractNode> parameters, int line)
        {
            // It's checked weather or not the function name itself exists in order to avoid typos at an early state
            if (!LibraryManager.Instance.IsFunctionKnown(funcName))
            {
                throw new CompilerException(line, 301, funcName);
            }
            this.funcName = funcName;
            this.parameters = parameters;
        }


        public override Value Invoke()
        {
            List<Value> values = new List<Value>();
            foreach (AbstractNode node in parameters)
            {
                values.Add(node.Evaluate());
            }

            Function function = LibraryManager.Instance.GetFunction(funcName, values);
            return function.Invoke(values);
        }

        public override int Line
        {
            get {
                return line;
            }
        }

    }
}
