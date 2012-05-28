using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Methods
{
    public abstract class AbstractUserMethod : IMethod
    {

        private List<INode> nodes;

        public AbstractUserMethod(List<INode> nodes)
        {
            this.nodes = nodes;
        }

        public abstract Value Evaluate(List<Value> arguments, List<ValueType> types);
        public abstract bool CheckArguments(List<ValueType> types);


        public Value Invoke()
        {
            List<Value> values = new List<Value>();
            foreach (INode node in nodes)
            {
                values.Add(node.Evaluate());
            }

            List<ValueType> types = new List<ValueType>();
            foreach (Value value in values)
            {
                types.Add(value.GetType());
            }

            if (CheckArguments(types))
            {
                try
                {
                    return Evaluate(values, types);
                }
                catch (CompilerException sce)
                {
                    // Catch all CompilerExceptions and add the line number.
                    sce.SetLine(GetLine());
                    throw sce;
                }
            }
            else
            {
                throw new CompilerException(GetLine(), 201, new String[] { GetName(), Value.TypeToString(types[0]) });
            }
        }

        public abstract String GetName();

    }
}
