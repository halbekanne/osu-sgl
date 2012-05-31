using System;
using System.Collections.Generic;
using System.Text;
using SGL.Nodes;
using SGL.Elements;

namespace SGL.Nodes
{
    class AtomNode : AbstractNode
    {
        private Value value;
        private int line = -1;

        public AtomNode(Value value, ValType type)
        {
            if (type == ValType.String)
            {
                // escape sequences
                String newString = value.StringValue;
                newString = newString.Replace("\\\\", "\\");
                newString = newString.Replace("\\\"", "\"");
                value = new Value(newString, ValType.String);
            }

            value = (value == null) ? Value.NULL : new Value(value,type);
        }

        public AtomNode(Value value, ValType type, int line)
            : this(value, type)
        {
            this.line = line;
        }

        public Value Invoke()
        {
            return value;
        }

        public int GetLine()
        {
            return line;
        }

    }
}
