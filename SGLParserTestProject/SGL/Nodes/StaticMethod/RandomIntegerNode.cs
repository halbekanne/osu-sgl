using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes.StaticMethod
{
    class RandomIntegerNode : INode
    {
        Value start;
        Value end;
        Random random;

        public RandomIntegerNode(Value start, Value end,  Random random)
        {
            this.start = start;
            this.end = end;
            this.random = random;

        }

        public Value Evaluate() {
            // start must be lower than or equal to end
            if (start.AsInteger() > end.AsInteger()) throw new CompilerException(-1, "unexpected value", "'start' must be lower than or equal to 'end' in 'rand(start,end)'");

            Value randVal = new Value(random.Next(start.AsInteger(), end.AsInteger() + 1));
            //Console.WriteLine("start: " + start + ", end: " + end + " - rand Value: " + randVal.AsInteger());
            return randVal;
        }

        public int GetLine() { return -1; }

    }
}
