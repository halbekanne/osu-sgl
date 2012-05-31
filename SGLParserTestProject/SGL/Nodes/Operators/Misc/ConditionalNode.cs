using System;
using System.Collections.Generic;
using System.Text;

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

        public Value Evaluate()
        {

            Value a = conditionNode.Evaluate();
            ValType aType = a.GetType();

            if (aType != ValType.Boolean)
            {
                throw new CompilerException(GetLine(), 206, new String[] { Value.TypeToString(aType) });
            }

            return a.AsBoolean() ? ifNode.Evaluate() : elseNode.Evaluate();
        }

        public int GetLine()
        {
            return conditionNode.GetLine();
        }
        
    }
}
