using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Blocks
{
    class AtNode : INode
    {
        private INode expression;
        private INode block;

        public AtNode(INode expression, INode block)
        {
            this.expression = expression;
            this.block = block;
        }

        public Value Evaluate()
        {
            Value exprV = expression.Evaluate();
            if (!exprV.IsInteger())
            {
                throw new CompilerException(expression.GetLine(), "ka", "blaa");
            }


            // Add the offset in the expression to the current offset in the scope
            ((BlockNode)block).AddOffset(exprV.AsInteger());
            //Console.WriteLine("At-Block changing offset: " + exprV.AsInteger());

            // Execute the block
            block.Evaluate();

            return Value.VOID;


        }

        public int GetLine()
        {
            return expression.GetLine();
        }

    }
}
