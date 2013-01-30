using SGL.Elements;

namespace SGL.Nodes.Operators.Arithmetical
{
    internal class NegateBoolNode : AbstractUnaryOperatorNode
    {
        public NegateBoolNode(AbstractNode node) : base(node)
        {
        }

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