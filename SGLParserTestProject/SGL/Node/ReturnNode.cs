using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class ReturnNode : SGLNode
    {
        private SGLNode expression;

        public ReturnNode(SGLNode expression)
        {
            this.expression = expression;
        }

        public SGLValue Evaluate()
        {
            SGLValue exprVal = expression.Evaluate();
            return exprVal;
        }

        public int GetLine()
        {
            return expression.GetLine();
        }



    }
}
