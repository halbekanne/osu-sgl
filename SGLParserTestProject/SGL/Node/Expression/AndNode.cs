using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.Expression
{
    class AndNode : SGLNode
    {
        private SGLNode lhs;
        private SGLNode rhs;

        public AndNode(SGLNode lhs, SGLNode rhs)
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
                throw new SGLCompilerException(GetLine(), "operator undefined", "the operator '&&' is undefined for the argument types '" + a.GetVarType() + ", " + b.GetVarType() + "'");
            }

            return new SGLValue(a.AsBoolean() && b.AsBoolean());
        }

        public int GetLine()
        {
            return lhs.GetLine();
        }

    }
}
