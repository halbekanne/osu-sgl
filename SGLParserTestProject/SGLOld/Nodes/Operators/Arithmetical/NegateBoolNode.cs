using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Operators.Arithmetic
{
    class NegateBoolNode : AbstractUnaryOperatorNode
    {
        public NegateBoolNode(INode node) : base(node) { }

        public override String GetName()
        {
            return "!";
        }

        public override bool CheckArguments(ValueType type)
        {
            return type == ValueType.Boolean;
        }

        public override Value Operate(Value value, ValueType type)
        {
            return new Value(!value.AsBoolean());
        }
    }
}
