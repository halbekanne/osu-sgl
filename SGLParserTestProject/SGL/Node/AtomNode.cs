using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class AtomNode : SGLNode
    {
        private SGLValue value;
        private int line = -1;

        public AtomNode(Object v)
        {
            value = (v == null) ? SGLValue.NULL : new SGLValue(v);
        }

        public AtomNode(Object v, int line)
        {
            value = (v == null) ? SGLValue.NULL : new SGLValue(v);
            this.line = line;
        }

        public SGLValue Evaluate()
        {
            return value;
        }

        public int GetLine()
        {
            return line;
        }

    }
}
