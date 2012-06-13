using System;
using System.Collections.Generic;

using System.Text;
using SGL.Elements;
using SGL.Library.Classes;
using SGL.Library.Functions;

namespace SGL.Nodes.Actions
{
    class InvokeFunctionNode : AbstractNode
    {
        private String objectVar;
        private String funcName;
        private List<AbstractNode> parameters;
        private Scope scope;
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

        public InvokeFunctionNode(String objectVar, List<AbstractNode> indexes, String funcName, List<AbstractNode> parameters, Scope scope, int line)
        {
            // TODO: Do stuff
            // It's checked weather or not the function name itself exists in order to avoid typos at an early state
            /*if (!LibraryManager.Instance.IsFunctionKnown(funcName))
            {
                throw new CompilerException(line, 301, funcName);
            }*/
            this.funcName = funcName;
            this.parameters = parameters;
            this.objectVar = objectVar;
            this.scope = scope;
        }

        protected override Value Invoke()
        {
            if (objectVar != null && scope != null)
            {
                List<Value> values = new List<Value>();
                foreach (AbstractNode node in parameters)
                {
                    values.Add(node.Evaluate());
                }

                Value resolvedValue = scope.Resolve(objectVar);
                if (resolvedValue.Type == ValType.Object)
                {
                    Class objectInstance = resolvedValue.ObjectValue;
                    return objectInstance.InvokeMethod(funcName, values);
                }
                throw new Exception("bla");
            }
            else
            {
                List<Value> values = new List<Value>();
                foreach (AbstractNode node in parameters)
                {
                    values.Add(node.Evaluate());
                }

                Function function = LibraryManager.Instance.GetFunction(funcName, values);
                return function.Invoke(values);
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
