using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Operators.Arithmetical
{
    class NegateIntNode : AbstractUnaryOperatorNode
    {
        public NegateIntNode(INode node) : base(node) { }

        public override String GetName()
        {
            return "-";
        }

        public override bool CheckArguments(ValueType type)
        {
            return type == ValueType.Integer || type == ValueType.Float;
        }

        public override Value Operate(Value value, ValueType type)
        {
            if (type == ValueType.Integer)
            {
                return new Value(value.AsInteger() * (-1));
            }
            else
            {
                return new Value(value.AsFloat() * (-1));
            }
        }
    }
}
