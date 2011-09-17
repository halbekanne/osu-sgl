using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class BreakNode : SGLNode
    {

        public BreakNode()
        {
        }

        public SGLValue Evaluate()
        {
            return SGLValue.BREAK;
        }

        public int GetLine()
        {
            // This call should never occur
            return -1;
        }

    }
}
