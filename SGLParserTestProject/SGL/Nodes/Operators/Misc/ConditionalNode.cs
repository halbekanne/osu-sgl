using SGL.Elements;

namespace SGL.Nodes.Operators.Misc
{
    /// <summary>
    /// This operator could implement the AbstractTernaryOperatorNode but is rather using AbstractNode because of performance reasons.
    /// </summary>
    internal class ConditionalNode : AbstractNode
    {
        private readonly AbstractNode conditionNode;
        private readonly AbstractNode elseNode;
        private readonly AbstractNode ifNode;

        public ConditionalNode(AbstractNode conditionNode, AbstractNode ifNode, AbstractNode elseNode)
        {
            this.conditionNode = conditionNode;
            this.ifNode = ifNode;
            this.elseNode = elseNode;
        }

        public override int Line
        {
            get { return conditionNode.Line; }
        }

        protected override Value Invoke()
        {
            Value condValue = conditionNode.Evaluate();

            if (condValue.Type != ValType.Boolean)
            {
                throw new CompilerException(Line, 206, condValue.TypeString);
            }

            return condValue.BoolValue ? ifNode.Evaluate() : elseNode.Evaluate();
        }
    }
}