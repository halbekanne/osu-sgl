using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Operators.Misc
{
    /// <summary>
    /// This operator could implement the AbstractTernaryOperatorNode but is rather using INode because of performance reasons.
    /// </summary>
    class ConditionalNode : INode
    {

        private INode conditionNode;
        private INode ifNode;
        private INode elseNode;

        public ConditionalNode(INode conditionNode, INode ifNode, INode elseNode) {
            this.conditionNode = conditionNode;
            this.ifNode = ifNode;
            this.elseNode = elseNode;
        }

        public Value Evaluate()
        {

            Value a = conditionNode.Evaluate();
            ValueType aType = a.GetType();

            if (aType != ValueType.Boolean)
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
