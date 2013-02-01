using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Operators.Arithmetical
{
    class PowNode : INode
    {
        private INode lhs;
        private INode rhs;

        public PowNode(INode lhs, INode rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public Value Evaluate()
        {

            Value a = lhs.Evaluate();
            Value b = rhs.Evaluate();
            
            // number + number  
            if (a.IsInteger() && b.IsInteger())
            {
                double x = Math.Pow(a.AsFloat(), b.AsFloat());
                //Console.WriteLine(x);
                if (x == Double.PositiveInfinity)
                {
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

                int Int;
                bool isInt = Int32.TryParse(x.ToString(), out Int);
                if (isInt)
                    return new Value(Int);
                else
                    return new Value(x);
            }

            // float + number / number + float  
            if (a.IsNumber() && b.IsNumber())
            {
                double x = Math.Pow(a.AsFloat(), b.AsFloat());
                //Console.WriteLine(x);
                if (x == Double.PositiveInfinity)
                {
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

            throw new CompilerException(GetLine(), "operator undefined", "the operator '*' is undefined for the argument types '" + a.GetType() + ", " + b.GetType() + "'");
            
        }

        public int GetLine()
        {
            return lhs.GetLine();
        }

    }
}
