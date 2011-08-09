using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class MNegateNode : SGLNode
    {
        private SGLNode child;

        public MNegateNode(SGLNode child)
        {
            this.child = child;
        }

        public SGLValue Evaluate()
        {

            SGLValue a = child.Evaluate();

            // integer 
            if (a.IsInteger())
            {
                return new SGLValue(a.AsInteger() * (-1));
            }

            // float
            if (a.IsFloat())
            {
                return new SGLValue(a.AsFloat() * (-1));
            }

            throw new Exception("illegal expression: " + this.ToString());
        }


        public String ToString()
        {
            return "Negate: (-1) * " + child.ToString();
        }


    }
}
