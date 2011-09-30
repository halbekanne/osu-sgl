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

        public SGLValue Evaluate()  {
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
            return new SGLValue(x);
        }

        public int GetLine() { return -1; }

    }
}
