using System;
using System.Collections.Generic;
using System.Text;
using SGL.Nodes;
using SGL.Elements;

namespace SGL.Nodes.Values
{
    class BreakNode : AbstractNode
    {
        int line;

        public BreakNode(int line)
        {
            this.line = line;
        }

        protected override Value Invoke()
        {
            return Value.BREAK;
        }

        public override int Line
        {
            get
            {
                return line;
            }
        }

    }
}
