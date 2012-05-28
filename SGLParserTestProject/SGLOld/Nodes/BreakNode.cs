using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes
{
    class BreakNode : INode
    {

        public BreakNode()
        {
        }

        public Value Evaluate()
        {
            return Value.BREAK;
        }

        public int GetLine()
        {
            // This call should never occur
            return -1;
        }

    }
}
