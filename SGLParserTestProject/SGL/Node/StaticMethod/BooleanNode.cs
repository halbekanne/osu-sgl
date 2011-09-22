using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.StaticMethod
{
    class BooleanNode : SGLNode
    {
        SGLValue a;

        public BooleanNode(SGLValue a)
        {
            this.a = a;

        }

        public SGLValue Evaluate() {
            String type = a.GetVarType();
            if (type.Equals("string"))
            {
                try {
                return new SGLValue(Boolean.Parse(a.AsString()));
                }
                catch (FormatException fe)
                {
                    throw new SGLCompilerException(-1, "wrong format", "Can't convert to boolean, because string has a wrong format");
                }
            }
            else if (type.Equals("boolean"))
            {
                return a;
            }
            throw new SGLCompilerException(-1, "type missmatch", "cannot convert from " + type + " to float (method float)");
        }

        public int GetLine() { return -1; }

    }
}
