using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes.Operators.Arithmetical
{
    class NegateBoolNode : AbstractUnaryOperatorNode
    {
        public NegateBoolNode(AbstractNode node) : base(node) { }

        public override String Name
        {
            get
            {
                return "!";
            }
        }

        public override bool CheckArguments(ValType type)
        {
            return type == ValType.Boolean;
        }

        public override Value Operate(Value value, ValType type)
        {
            return new Value(!value.AsBoolean());
        }
    }
}
