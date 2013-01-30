using SGL.Elements;

namespace SGL.Nodes.Operators
{
    /// <summary>
    /// Abstract class for all kind of operators which perform an action on 1 values, e.g. negation.
    /// </summary>
    public abstract class AbstractUnaryOperatorNode : AbstractNode
    {
        private readonly AbstractNode node;

        public AbstractUnaryOperatorNode(AbstractNode node)
        {
            this.node = node;
        }

        public override int Line
        {
            get { return node.Line; }
        }

        protected abstract Value Operate(Value value);

        protected override Value Invoke()
        {
            Value value = node.Evaluate();
            return Operate(value);

            //throw new CompilerException(Line, 201, Name, value.TypeString);
        }
    }
}