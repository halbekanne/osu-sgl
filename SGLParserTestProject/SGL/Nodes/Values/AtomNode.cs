using System;
using SGL.Elements;

namespace SGL.Nodes.Values
{
    internal class AtomNode : AbstractNode
    {
        private readonly int line = -1;
        private readonly Value value;

        public AtomNode(object value, ValType type)
        {
            if (type == ValType.String)
            {
                // escape sequences
                var newString = (String) value;
                newString = newString.Replace("\\\\", "\\");
                newString = newString.Replace("\\\"", "\"");
                value = newString;
            }

            this.value = (value == null) ? Value.NULL : new Value(value, type);
        }

        public AtomNode(object value, ValType type, int line)
            : this(value, type)
        {
            this.line = line;
        }

        public override int Line
        {
            get { return line; }
        }

        protected override Value Invoke()
        {
            return value;
        }
    }
}