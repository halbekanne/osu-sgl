using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.Expression
{
    class NotEqualsNode : SGLNode
    {
        private SGLNode lhs;
        private SGLNode rhs;

        public NotEqualsNode(SGLNode lhs, SGLNode rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public SGLValue Evaluate()
        {

            SGLValue a = lhs.Evaluate();
            SGLValue b = rhs.Evaluate();

            try
            {
                return new SGLValue(!a.Equals(b));
            }
            catch (SGLCompilerException sce)
            {
                sce.Line = GetLine();
                throw sce;
            }
        }

        public int GetLine()
        {
            return lhs.GetLine();
        }
    }
}
