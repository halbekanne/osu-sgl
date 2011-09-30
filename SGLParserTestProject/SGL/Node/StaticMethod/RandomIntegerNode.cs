using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.StaticMethod
{
    class RandomIntegerNode : SGLNode
    {
        SGLValue start;
        SGLValue end;
        Random random;

        public RandomIntegerNode(SGLValue start, SGLValue end,  Random random)
        {
            this.start = start;
            this.end = end;
            this.random = random;

        }

        public SGLValue Evaluate() {

            SGLValue randVal = new SGLValue(random.Next(start.AsInteger(), end.AsInteger() + 1));
            //Console.WriteLine("start: " + start + ", end: " + end + " - rand Value: " + randVal.AsInteger());
            return randVal;
        }

        public int GetLine() { return -1; }

    }
}
