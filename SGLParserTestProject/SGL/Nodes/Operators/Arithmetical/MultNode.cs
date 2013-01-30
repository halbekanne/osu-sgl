using SGL.Elements;

namespace SGL.Nodes.Operators.Arithmetical
{
    internal class MultNode : AbstractBinaryOperatorNode
    {
        public MultNode(AbstractNode node1, AbstractNode node2) : base(node1, node2)
        {
        }

        protected override Value Operate(Value value1, Value value2)
        {
            if (value1.TypeEquals(ValType.Double) && value2.TypeEquals(ValType.Double))
            {
                // 1.423 * 2; => Float
                return new Value(value1.DoubleValue*value2.DoubleValue, ValType.Double);
            }
            else if (value1.Type == ValType.Integer && value2.Type == ValType.Integer)
            {
                // 5 * 4; => Integer
                return new Value(value1.IntValue*value2.IntValue, ValType.Integer);
            }
            else
            {
                throw new CompilerException(Line, 202, "*", value1.TypeString, value2.TypeString);
            }
        }
    }
}