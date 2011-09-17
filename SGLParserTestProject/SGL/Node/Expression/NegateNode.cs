using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.Expression
{
    class NegateNode : SGLNode
    {
        private SGLNode child;

        public NegateNode(SGLNode child)
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

            throw new SGLCompilerException(GetLine(), "operator undefined", "the operator '-' is undefined for the argument type '" + a.GetVarType() + "'");
            
        }

        public int GetLine()
        {
            return child.GetLine();
        }

    }
}
