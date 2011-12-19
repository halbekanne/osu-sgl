using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class AtNode : SGLNode
    {
        private SGLNode expression;
        private SGLNode block;

        public AtNode(SGLNode expression, SGLNode block)
        {
            this.expression = expression;
            this.block = block;
        }

        public SGLValue Evaluate()
        {
            SGLValue exprV = expression.Evaluate();
            if (!exprV.IsInteger())
            {
                throw new SGLCompilerException(expression.GetLine(), "ka", "blaa");
            }


            // Add the offset in the expression to the current offset in the scope
            ((BlockNode)block).AddOffset(exprV.AsInteger());
            //Console.WriteLine("At-Block changing offset: " + exprV.AsInteger());

            // Execute the block
            block.Evaluate();

            return SGLValue.VOID;


        }

        public int GetLine()
        {
            return expression.GetLine();
        }

    }
}
