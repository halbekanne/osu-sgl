using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes
{
    class AtomNode<T> : INode
    {
        private Value value;
        private int line = -1;

        public AtomNode(T value, ValueType type)
        {
            value = (value == null) ? Value.NULL : new Value<T>(value,type);
        }

        public AtomNode(T value, ValueType type, int line)
        {
            value = (value == null) ? Value.NULL : new Value<T>(value,type);
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
