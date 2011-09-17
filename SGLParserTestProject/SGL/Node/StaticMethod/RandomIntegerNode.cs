using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.StaticMethod
{
    class RandomIntegerNode : SGLNode
    {
        SGLValue start;
        SGLValue end;

        public RandomIntegerNode(SGLValue start, SGLValue end)
        {
            this.start = start;
            this.end = end;

        }

        public SGLValue Evaluate() {
            
            Random random = new Random();
            return new SGLValue(random.Next(start.AsInteger(), end.AsInteger() + 1));
        }

        public int GetLine() { return -1; }

    }
}
