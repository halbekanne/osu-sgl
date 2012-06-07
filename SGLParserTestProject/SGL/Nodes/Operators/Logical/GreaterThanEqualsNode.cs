using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Operators.Logical
{
    class GreaterThanEqualsNode : AbstractBinaryOperatorNode
    {

        public GreaterThanEqualsNode(AbstractNode node1, AbstractNode node2) : base(node1, node2) { }

        protected override Value Operate(Value value1, Value value2)
        {

            if (value1.TypeEquals(ValType.Double) && value2.TypeEquals(ValType.Double))
            {
                return new Value(value1.DoubleValue >= value2.DoubleValue, ValType.Boolean);
            }
            else if (value1.Type == ValType.String && value2.Type == ValType.String)
            {
                // Strings
                return new Value(value1.StringValue.CompareTo(value2.StringValue) >= 0, ValType.String);
            }
            else
            {
                throw new CompilerException(Line, 202, ">=", value1.TypeString, value2.TypeString);
            }
           
        }
    }
}
