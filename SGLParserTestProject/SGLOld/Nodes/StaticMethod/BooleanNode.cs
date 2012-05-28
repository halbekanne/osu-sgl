using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.StaticMethod
{
    class BooleanNode : INode
    {
        Value a;

        public BooleanNode(Value a)
        {
            this.a = a;

        }

        public Value Evaluate() {
            String type = a.GetType();
            if (type.Equals("string"))
            {
                try {
                return new Value(Boolean.Parse(a.AsString()));
                }
                catch (FormatException fe)
                {
                    throw new CompilerException(-1, "wrong format", "Can't convert to boolean, because string has a wrong format");
                }
            }
            else if (type.Equals("boolean"))
            {
                return a;
            }
            throw new CompilerException(-1, "type missmatch", "cannot convert from " + type + " to float (method float)");
        }

        public int GetLine() { return -1; }

    }
}
