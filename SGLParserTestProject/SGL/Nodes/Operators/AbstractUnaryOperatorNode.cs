using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes.Operators
{

    /// <summary>
    /// Abstract class for all kind of operators which perform an action on 1 values, e.g. negation.
    /// </summary>
    public abstract class AbstractUnaryOperatorNode : INode
    {
        private INode node;

        public AbstractUnaryOperatorNode(INode node)
        {
            this.node = node;
        }

        public abstract Value Operate(Value value, ValueType type);

        public abstract bool CheckArguments(ValueType type);

        public Value Evaluate()
        {
            Value value = node.Evaluate();

            ValueType type = value.GetType();

            if (CheckArguments(type))
            {
                try
                {
                    return Operate(value, type);
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
                throw new CompilerException(GetLine(), 201, new String[] {GetName(), Value.TypeToString(type)});
            }
        }

        public abstract String GetName();

        public int GetLine() {
            return node.GetLine();
        }


    }
}
