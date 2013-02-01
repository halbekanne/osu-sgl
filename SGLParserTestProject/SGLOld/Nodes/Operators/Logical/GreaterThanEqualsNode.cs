using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Operators.Logical
{
    class GreaterThanEqualsNode : AbstractBinaryOperatorNode
    {

        public GreaterThanEqualsNode(INode node1, INode node2) : base(node1, node2) { }

        public override String GetName()
        {
            return ">=";
        }

        public override bool CheckArguments(ValueType type1, ValueType type2)
        {
            return (type1 == ValueType.Float || type1 == ValueType.Integer) && (type2 == ValueType.Float || type2 == ValueType.Integer) ||
                (type1 == ValueType.String && type2 == ValueType.String);
        }

        public override Value Operate(Value value1, Value value2, ValueType type1, ValueType type2)
        {

            if ((type1 == ValueType.Float || type1 == ValueType.Integer) && (type2 == ValueType.Float || type2 == ValueType.Integer))
            {
                return new Value(value1.AsFloat() >= value2.AsFloat());
            }
            else
            {
                // Strings
                return new Value(value1.AsString().CompareTo(value2.AsString()) >= 0);
            }
           
        }
    }
}
