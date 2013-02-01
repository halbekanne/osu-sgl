using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Operators
{

    /// <summary>
    /// Abstract class for all kind of operators which perform an action on 2 values, e.g. addition.
    /// </summary>
    public abstract class AbstractBinaryOperatorNode : INode
    {
        private INode node1;
        private INode node2;

        public AbstractBinaryOperatorNode(INode node1, INode node2)
        {
            this.node1 = node1;
            this.node2 = node2;
        }

        public abstract Value Operate(Value value1, Value value2, ValueType type1, ValueType type2);

        public abstract bool CheckArguments(ValueType type1, ValueType type2);

        public Value Evaluate()
        {
            Value value1 = node1.Evaluate();
            Value value2 = node2.Evaluate();

            ValueType type1 = value1.GetType();
            ValueType type2 = value2.GetType();

            if (CheckArguments(type1, type2))
            {
                try
                {
                    return Operate(value1, value2, type1, type2);
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
                throw new CompilerException(GetLine(), 202, new String[] {GetName(), Value.TypeToString(type1), Value.TypeToString(type2)});
            }
        }

        public abstract String GetName();

        public int GetLine() {
            return node1.GetLine();
        }


    }
}
