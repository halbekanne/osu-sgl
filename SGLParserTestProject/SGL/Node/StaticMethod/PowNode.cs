using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.StaticMethod
{
    class PowNode : SGLNode
    {
        SGLValue a;
        SGLValue b;

        public PowNode(SGLValue a, SGLValue b)
        {
            this.a = a;
            this.b = b;

        }

        public SGLValue Evaluate() {
            
            return new SGLValue(Math.Pow(a.AsFloat(), b.AsFloat()));
        }

        public int GetLine() { return -1; }

    }
}
