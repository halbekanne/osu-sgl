using System.Collections.Generic;
using SGL.Elements;

namespace SGL.Nodes.Values
{
    internal class ListNode : AbstractNode
    {
        private readonly List<AbstractNode> expressionNodes;

        public ListNode(List<AbstractNode> nodes)
        {
            expressionNodes = (nodes == null) ? new List<AbstractNode>() : nodes;
        }

        public override int Line
        {
            get { return expressionNodes.Count > 0 ? expressionNodes[0].Line : -1; }
        }

        protected override Value Invoke()
        {
            var evaluated = new List<Value>();
            foreach (AbstractNode node in expressionNodes)
            {
                evaluated.Add(node.Evaluate());
            }
            return new Value(evaluated, ValType.List);
        }
    }
}