using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.StaticMethod
{
    class StringNode : INode
    {
        Value a;

        public StringNode(Value a)
        {
            this.a = a;

        }

        public Value Evaluate() {
            String type = a.GetType();
            if (type.Equals("string"))
            {
                return a;
            }
            else if (type.Equals("int") || type.Equals("float") || type.Equals("boolean"))
            {
                return new Value(a.ToString());
            }
            throw new CompilerException(-1, "type missmatch", "cannot convert from " + type + " to float (method float)");
        }

        public int GetLine() { return -1; }

    }
}
