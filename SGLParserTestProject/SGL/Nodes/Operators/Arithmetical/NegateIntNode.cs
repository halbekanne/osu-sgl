using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Operators.Arithmetical
{
    class NegateIntNode : AbstractUnaryOperatorNode
    {
        public NegateIntNode(AbstractNode node) : base(node) { }

        public override Value Operate(Value value)
        {
            if (value.Type == ValType.Integer)
            {
                return new Value(value.IntValue* (-1), ValType.Integer);
            }
            else if (value.Type == ValType.Double)
            {
                return new Value(value.DoubleValue * (-1), ValType.Double);
            }
            else
            {
                throw new CompilerException(Line, 201, "-", value.TypeString);
            }
        }
    }
}
