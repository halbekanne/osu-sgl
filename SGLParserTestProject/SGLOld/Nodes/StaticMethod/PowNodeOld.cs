using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.StaticMethod
{
    class PowNodeOld : INode
    {
        Value a;
        Value b;

        public PowNodeOld(Value a, Value b)
        {
            this.a = a;
            this.b = b;

        }

        public Value Evaluate()  {
            double x = Math.Pow(a.AsFloat(), b.AsFloat());
            //Console.WriteLine(x);
            if (x == Double.PositiveInfinity) {
                Console.WriteLine("too big");
            }
            else if (x == Double.NegativeInfinity)
            {
                Console.WriteLine("too small");
            }
            else if (x == Double.NaN)
            {
                Console.WriteLine("undefined");
            }
            return new Value(x);
        }

        public int GetLine() { return -1; }

    }
}
