using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class WhileNode : SGLNode
    {
        private SGLNode expression;
        private SGLNode block;

        public WhileNode(SGLNode expression, SGLNode block)
        {
            this.expression = expression;
            this.block = block;
        }

        public SGLValue Evaluate()
        {

            while (expression.Evaluate().AsBoolean())
            {
                SGLValue returnValue = block.Evaluate();
                if (returnValue != SGLValue.VOID)
                {
                    if (returnValue == SGLValue.BREAK)
                    {
                        Console.WriteLine("Break!");
                        return SGLValue.VOID;
                    }
                }

                /*
                SGLValue returnValue = block.Evaluate();

                if (returnValue != SGLValue.VOID)
                {
                    return returnValue;
                }
                 * */
            }

            return SGLValue.VOID;
        }

    }
}
