using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.Expression
{
    class LTNode : SGLNode
    {
        private SGLNode lhs;
        private SGLNode rhs;

        public LTNode(SGLNode lhs, SGLNode rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public SGLValue Evaluate()
        {

            SGLValue a = lhs.Evaluate();
            SGLValue b = rhs.Evaluate();

            // number + number  
            if (a.IsNumber() && b.IsNumber())
            {
                return new SGLValue(a.AsFloat() < b.AsFloat());
            }

            // string + string
            if (a.IsString() && b.IsString())
            {
                return new SGLValue(a.AsString().CompareTo(b.AsString()) < -1);
            }

            throw new SGLCompilerException(GetLine(), "operator undefined", "the operator '<' is undefined for the argument types '" + a.GetVarType() + ", " + b.GetVarType() + "'");
        }

        public int GetLine()
        {
            return lhs.GetLine();
        }

    }
}
