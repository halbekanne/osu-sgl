using SGL.Elements;

namespace SGL.Nodes.ControlFlow
{
    internal class AtNode : AbstractNode
    {
        private readonly AbstractNode block;
        private readonly AbstractNode expression;

        public AtNode(AbstractNode expression, AbstractNode block)
        {
            this.expression = expression;
            this.block = block;
        }

        public override int Line
        {
            get { return expression.Line; }
        }

        protected override Value Invoke()
        {
            Value exprV = expression.Evaluate();

            if (exprV.TypeEquals(ValType.Integer))
            {
                ((BlockNode) block).AddOffset(exprV.IntValue);
                // Execute the block
                return block.Evaluate();
            }
            else
            {
                throw new CompilerException(Line, 217, "offset", "AT", "Integer/Double", exprV.TypeString);
            }
        }
    }
}