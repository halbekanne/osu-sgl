using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.StaticMethod
{
    class FloatNode : INode
    {
        Value a;

        public FloatNode(Value a)
        {
            this.a = a;

        }

        public Value Evaluate() {
            String type = a.GetType();
            if (type.Equals("float"))
            {
                return a;
            }
            else if (type.Equals("string"))
            {
                try {
                    return new Value(Double.Parse(a.AsString()));
                }
                catch (FormatException fe)
                {
                    throw new CompilerException(-1, "wrong format", "Can't convert to float, because string has a wrong format");
                }
            }
            else if (type.Equals("int"))
            {
                return new Value((float)a.AsInteger());
            }
            throw new CompilerException(-1, "type missmatch", "cannot convert from " + type + " to float (method float)");
        }

        public int GetLine() { return -1; }

    }
}
