using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Operators.Arithmetical
{
    class NegateBoolNode : AbstractUnaryOperatorNode
    {
        public NegateBoolNode(AbstractNode node) : base(node) { }

        protected override Value Operate(Value value)
        {
            if (value.Type == ValType.Boolean)
            {
                return new Value(!value.BoolValue, ValType.Boolean);
            }
            else
            {
                throw new CompilerException(Line, 201, "!", value.TypeString);
            }
        }
    }
}
