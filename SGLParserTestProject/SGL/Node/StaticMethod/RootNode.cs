using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.StaticMethod
{
    class RootNode : SGLNode
    {
        SGLValue a;
        SGLValue b;

        public RootNode(SGLValue a, SGLValue b)
        {
            this.a = a;
            this.b = b;

        }

        public SGLValue Evaluate() {
            double power = 1.0 / a.AsFloat();
            return new SGLValue(Math.Pow(b.AsFloat(), power));
        }

        public int GetLine() { return -1; }

    }
}
