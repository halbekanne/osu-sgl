using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes.Operators.Logical
{
    class OrNode : AbstractBinaryOperatorNode
    {
        public OrNode(INode node1, INode node2) : base(node1, node2) { }

        public override String GetName()
        {
            return "||";
        }

        public override bool CheckArguments(ValueType type1, ValueType type2)
        {
            return type1 == ValueType.Boolean && type2 == ValueType.Boolean;
        }

        public override Value Operate(Value value1, Value value2, ValueType type1, ValueType type2)
        {
            return new Value(value1.AsBoolean() || value2.AsBoolean());
        }
    }
}
