using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Values
{
    class ListNode : AbstractNode
    {
        private List<AbstractNode> expressionNodes;

        public ListNode(List<AbstractNode> nodes)
        {
            expressionNodes = (nodes == null) ? new List<AbstractNode>() : nodes;
        }

        protected override Value Invoke() {
            List<Value> evaluated = new List<Value>();
            foreach (AbstractNode node in expressionNodes)
            {
                evaluated.Add(node.Evaluate());
            }
            return new Value(evaluated, ValType.List);
        }

        public override int Line
        {
            get
            {
                return expressionNodes.Count > 0 ? expressionNodes[0].Line : -1;
            }
        }
    }
}
