using System;
using System.Collections.Generic;

using System.Text;
using SGL.Elements;
using SGL.Library.Classes;

namespace SGL.Nodes.Actions
{
    class InstanciateClassNode : AbstractNode
    {
        private String className;
        private List<AbstractNode> parameters;
        private int line;

        public InstanciateClassNode(String className, List<AbstractNode> parameters, int line)
        {
            // It's checked weather or not the classname itself exists in order to avoid typos at an early state
            if (!LibraryManager.Instance.IsClassKnown(className))
            {
                throw new CompilerException(line, 311, className);
            }
            this.className = className;
            this.parameters = parameters != null ? parameters : new List<AbstractNode>();
            this.line = line;
        }


        protected override Value Invoke()
        {
            List<Value> values = new List<Value>();
            foreach (AbstractNode node in parameters)
            {
                values.Add(node.Evaluate());
            }

            object classObj = LibraryManager.Instance.GetClass(className, values);
            if (classObj is Value)
            {
                return (Value)classObj;
            } else {
                return new Value(classObj, ValType.Object);
            }
        }

        public override int Line
        {
            get {
                return line;
            }
        }

    }
}
