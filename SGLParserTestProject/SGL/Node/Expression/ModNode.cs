using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.Expression
{
    class ModNode : SGLNode
    {
        private SGLNode lhs;
        private SGLNode rhs;

        public ModNode(SGLNode lhs, SGLNode rhs)
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
                return new SGLValue(a.AsInteger() % b.AsInteger());
            }

            // float + number / number + float  
            if (a.IsNumber() && b.IsNumber())
            {
                return new SGLValue(a.AsFloat() % b.AsFloat());
            }

            throw new SGLCompilerException(GetLine(), "operator undefined", "the operator '%' is undefined for the argument types '" + a.GetVarType() + ", " + b.GetVarType() + "'");
            
        }

        public int GetLine()
        {
            return lhs.GetLine();
        }

    }
}
