using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Operators
{

    /// <summary>
    /// Abstract class for all kind of operators which perform an action on 2 values, e.g. addition.
    /// </summary>
    public abstract class AbstractTernaryOperatorNode : INode
    {
        private INode node1;
        private INode node2;
        private INode node3;

        public AbstractTernaryOperatorNode(INode node1, INode node2, INode node3)
        {
            this.node1 = node1;
            this.node2 = node2;
            this.node2 = node3;
        }

        public abstract Value Operate(Value value1, Value value2, Value value3, ValueType type1, ValueType type2, ValueType type3);

        public abstract bool CheckArguments(ValueType type1, ValueType type2, ValueType type3);

        public Value Evaluate()
        {
            Value value1 = node1.Evaluate();
            Value value2 = node2.Evaluate();
            Value value3 = node3.Evaluate();

            ValueType type1 = value1.GetType();
            ValueType type2 = value2.GetType();
            ValueType type3 = value3.GetType();

            if (CheckArguments(type1, type2, type3))
            {
                try
                {
                    return Operate(value1, value2, value3, type1, type2, type3);
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
                throw new CompilerException(GetLine(), 203, new String[] { GetName(), Value.TypeToString(type1), Value.TypeToString(type2), Value.TypeToString(type3)});
            }
        }

        public abstract String GetName();

        public int GetLine() {
            return node1.GetLine();
        }


    }
}
