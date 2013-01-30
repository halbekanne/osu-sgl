using SGL.Elements;

namespace SGL.Nodes.Operators.Logical
{
    internal class NotEqualsNode : AbstractBinaryOperatorNode
    {
        public NotEqualsNode(AbstractNode node1, AbstractNode node2) : base(node1, node2)
        {
        }

        protected override Value Operate(Value value1, Value value2)
        {
            return new Value(!value1.Equals(value2), ValType.Boolean);
        }
    }
}