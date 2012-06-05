using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Operators.Misc
{
    /// <summary>
    /// This operator could implement the AbstractTernaryOperatorNode but is rather using AbstractNode because of performance reasons.
    /// </summary>
    class ConditionalNode : AbstractNode
    {

        private AbstractNode conditionNode;
        private AbstractNode ifNode;
        private AbstractNode elseNode;

        public ConditionalNode(AbstractNode conditionNode, AbstractNode ifNode, AbstractNode elseNode) {
            this.conditionNode = conditionNode;
            this.ifNode = ifNode;
            this.elseNode = elseNode;
        }

        protected override Value Invoke()
        {

            Value condValue = conditionNode.Evaluate();

            if (condValue.Type != ValType.Boolean)
            {
                throw new CompilerException(GetLine(), 206, condValue.TypeString);
            }

            return condValue.BoolValue ? ifNode.Evaluate() : elseNode.Evaluate();
        }

        public override int Line
        {
            get
            {
                return conditionNode.Line;
            }
        }
    }
}
