using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class ForNode : SGLNode
    {
        private String identifier;
        private SGLNode startExpr;
        private SGLNode stopExpr;
        private SGLNode block;
        protected Scope scope;

        public ForNode(String identifier, SGLNode startExpr)
        {
            //this.expression = expression;
            //this.block = block;
        }

        public SGLValue Evaluate()
        {

            /*while (expression.Evaluate().AsBoolean())
            {

                SGLValue returnValue = block.Evaluate();

                if (returnValue != SGLValue.VOID)
                {
                    return returnValue;
                }
            }
            */
            return SGLValue.VOID;
        }

    }
}
