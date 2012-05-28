using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.StaticMethod
{
    class RootNode : INode
    {
        Value a;
        Value b;

        public RootNode(Value a, Value b)
        {
            this.a = a;
            this.b = b;

        }

        public Value Evaluate() {
            double power = 1.0 / a.AsFloat();
            return new Value(Math.Pow(b.AsFloat(), power));
        }

        public int GetLine() { return -1; }

    }
}
