using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class MAddNode : SGLNode
    {
        private SGLNode lhs;
        private SGLNode rhs;

        public MAddNode(SGLNode lhs, SGLNode rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public SGLValue Evaluate()
        {

            SGLValue a = lhs.Evaluate();
            SGLValue b = rhs.Evaluate();

            // number + number  
            if (a.IsInteger() && b.IsInteger())
            {
                return new SGLValue(a.AsInteger() + b.AsInteger());
            }

            // float + number / number + float  
            if (a.IsNumber() && b.IsNumber())
            {
                return new SGLValue(a.AsFloat() + b.AsFloat());
            }

            // string + any  
            if (a.IsString())
            {
                return new SGLValue(a.AsString() + "" + b.ToString());
            }

            // any + string  
            if (b.IsString())
            {
                return new SGLValue(a.ToString() + "" + b.AsString());
            }

            throw new Exception("illegal expression: " + this.ToString());
        }


        public String ToString()
        {
            return lhs.ToString() + " + " + rhs.ToString();
        }


    }
}
