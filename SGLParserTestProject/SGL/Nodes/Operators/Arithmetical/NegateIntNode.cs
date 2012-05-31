using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes.Operators.Arithmetical
{
    class NegateIntNode : AbstractUnaryOperatorNode
    {
        public NegateIntNode(AbstractNode node) : base(node) { }

        public override String Name
        {
            get
            {
                return "-";
            }
        }

        public override bool CheckArguments(ValType type)
        {
            return type == ValType.Integer || type == ValType.Float;
        }

        public override Value Operate(Value value, ValType type)
        {
            if (type == ValType.Integer)
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
