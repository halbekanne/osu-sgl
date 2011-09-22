using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.StaticMethod
{
    class StringNode : SGLNode
    {
        SGLValue a;

        public StringNode(SGLValue a)
        {
            this.a = a;

        }

        public SGLValue Evaluate() {
            String type = a.GetVarType();
            if (type.Equals("string"))
            {
                return a;
            }
            else if (type.Equals("int") || type.Equals("float") || type.Equals("boolean"))
            {
                return new SGLValue(a.ToString());
            }
            throw new SGLCompilerException(-1, "type missmatch", "cannot convert from " + type + " to float (method float)");
        }

        public int GetLine() { return -1; }

    }
}
