using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.StaticMethod
{
    class FloatNode : SGLNode
    {
        SGLValue a;

        public FloatNode(SGLValue a)
        {
            this.a = a;

        }

        public SGLValue Evaluate() {
            String type = a.GetVarType();
            if (type.Equals("float"))
            {
                return a;
            }
            else if (type.Equals("string"))
            {
                try {
                    return new SGLValue(Double.Parse(a.AsString()));
                }
                catch (FormatException fe)
                {
                    throw new SGLCompilerException(-1, "wrong format", "Can't convert to float, because string has a wrong format");
                }
            }
            else if (type.Equals("int"))
            {
                return new SGLValue((float)a.AsInteger());
            }
            throw new SGLCompilerException(-1, "type missmatch", "cannot convert from " + type + " to float (method float)");
        }

        public int GetLine() { return -1; }

    }
}
