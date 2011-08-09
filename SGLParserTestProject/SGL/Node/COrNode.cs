using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class COrNode : SGLNode
    {
        private SGLNode lhs;
        private SGLNode rhs;

        public COrNode(SGLNode lhs, SGLNode rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public SGLValue Evaluate()
        {

            SGLValue a = lhs.Evaluate();
            SGLValue b = rhs.Evaluate();

            if (!a.IsBoolean() || !b.IsBoolean())
            {
                throw new Exception("illegal expression: " + this.ToString());
            }

            return new SGLValue(a.AsBoolean() || b.AsBoolean());
        }


        public String ToString()
        {
            return lhs.ToString() + " || " + rhs.ToString();
        }


    }
}
