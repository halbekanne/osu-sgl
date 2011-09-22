using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.StaticMethod
{
    class IntNode : SGLNode
    {
        SGLValue a;

        public IntNode(SGLValue a)
        {
            this.a = a;

        }

        public SGLValue Evaluate() {
            String type = a.GetVarType();
            if (type.Equals("float"))
            {
                return new SGLValue((int)a.AsFloat());
            }
            else if (type.Equals("string"))
            {
                try
                {
                    return new SGLValue(Int32.Parse(a.AsString()));
                }
                catch (FormatException fe)
                {
                    throw new SGLCompilerException(-1, "wrong format", "Can't convert to int, because string has a wrong format");
                }
            }
            else if (type.Equals("int"))
            {
                return a;
            }
            throw new SGLCompilerException(-1, "type missmatch", "cannot convert from " + type + " to int (method int)");
        }

        public int GetLine() { return -1; }

    }
}
