using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Operators.Logical
{
    class EqualsNode : AbstractBinaryOperatorNode
    {
        public EqualsNode(AbstractNode node1, AbstractNode node2) : base(node1, node2) { }

        public override Value Operate(Value value1, Value value2)
        {
            return new Value(value1.Equals(value2.BoolValue), ValType.Boolean);
        }
    }
}
