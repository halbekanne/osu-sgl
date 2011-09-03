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


    }
}
