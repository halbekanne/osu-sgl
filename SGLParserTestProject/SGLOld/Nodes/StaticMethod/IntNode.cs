using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.StaticMethod
{
    class IntNode : INode
    {
        Value a;

        public IntNode(Value a)
        {
            this.a = a;

        }

        public Value Evaluate() {
            String type = a.GetType();
            if (type.Equals("float"))
            {
                return new Value((int)a.AsFloat());
            }
            else if (type.Equals("string"))
            {
                try
                {
                    return new Value(Int32.Parse(a.AsString()));
                }
                catch (FormatException fe)
                {
                    throw new CompilerException(-1, "wrong format", "Can't convert to int, because string has a wrong format");
                }
            }
            else if (type.Equals("int"))
            {
                return a;
            }
            throw new CompilerException(-1, "type missmatch", "cannot convert from " + type + " to int (method int)");
        }

        public int GetLine() { return -1; }

    }
}
