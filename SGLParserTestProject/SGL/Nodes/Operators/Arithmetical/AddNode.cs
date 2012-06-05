using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Operators.Arithmetical
{
    class AddNode : AbstractBinaryOperatorNode
    {

        public AddNode(AbstractNode node1, AbstractNode node2) : base(node1, node2) {}

        public override Value Operate(Value value1, Value value2)
        {
            if (value1.Type == ValType.Integer && value2.Type == ValType.Integer)
            {
                // both integer
                return new Value(value1.IntValue + value2.IntValue, ValType.Integer);
            }
            else if (value1.TypeEquals(ValType.Double) && value2.TypeEquals(ValType.Double))
            {
                // both double or integer
                return new Value(value1.DoubleValue + value2.DoubleValue, ValType.Double);
            }
            else if (value1.Type == ValType.String || value2.Type == ValType.String)
            {
                // "Hello " + 1 => String
                return new Value(value1.ToString() + "" + value2.ToString(), ValType.String);
            }
            else
            {
                throw new CompilerException(Line, 202, "+", value1.TypeString, value2.TypeString);
            }
        }
    }
}
