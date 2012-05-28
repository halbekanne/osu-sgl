using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes
{
    class ListNode : INode
    {
        private List<INode> expressionNodes;

        public ListNode(List<INode> nodes) {
            expressionNodes = (nodes == null) ? new List<INode>() : nodes;
        }

        public Value Evaluate() {
            List<Value> evaluated = new List<Value>();
            foreach(INode node in expressionNodes) {
                evaluated.Add(node.Evaluate());
            }
            return new Value(evaluated);
        }

        public int GetLine()
        {
            return -1;
        }
    }
}
