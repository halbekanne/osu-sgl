using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes
{
    class AtomNode : INode
    {
        private Value value;
        private int line = -1;

        public AtomNode(Object v)
        {
            value = (v == null) ? Value.NULL : new Value(v);
        }

        public AtomNode(Object v, int line)
        {
            value = (v == null) ? Value.NULL : new Value(v);
            this.line = line;
        }

        public Value Evaluate()
        {
            return value;
        }

        public int GetLine()
        {
            return line;
        }

    }
}
