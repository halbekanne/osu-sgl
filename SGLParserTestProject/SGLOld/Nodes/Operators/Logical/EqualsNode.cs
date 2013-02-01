using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Operators.Logical
{
    class EqualsNode : AbstractBinaryOperatorNode
    {
        public EqualsNode(INode node1, INode node2) : base(node1, node2) { }

        public override String GetName()
        {
            return "==";
        }

        public override bool CheckArguments(ValueType type1, ValueType type2)
        {
            return true;
        }

        public override Value Operate(Value value1, Value value2, ValueType type1, ValueType type2)
        {
            return new Value(value1.Equals(value2));
        }
    }
}
