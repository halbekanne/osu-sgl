using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Methods
{
    public abstract class AbstractArgumentListNode : INode
    {

        private List<INode> nodes;

        public AbstractArgumentListNode(List<INode> nodes)
        {
            this.nodes = nodes;
        }

        public abstract Value Evaluate(List<Value> arguments, List<ValueType> types);

        public abstract bool CheckArguments(List<ValueType> types);


        public Value Evaluate()
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
                throw GetMissmatchedArgumentsException(values, types);
            }
        }

        public abstract CompilerException GetMissmatchedArgumentsException(List<Value> arguments, List<ValueType> types);

        public abstract String GetName();

        public int GetLine()
        {
            throw new NotImplementedException();
        }
    }
}
