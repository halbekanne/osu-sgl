using SGL.Elements;

namespace SGL.Nodes.Values
{
    internal class ReturnNode : AbstractNode
    {
        private readonly AbstractNode expression;

        public ReturnNode(AbstractNode expression)
        {
            this.expression = expression;
        }

        public override int Line
        {
            get { return expression.Line; }
        }

        protected override Value Invoke()
        {
            Value exprVal = expression.Evaluate();
            return new Value(exprVal, ValType.Return);
        }
    }
}