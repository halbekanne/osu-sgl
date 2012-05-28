using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Blocks
{
    class WhileNode : INode
    {
        private INode expression;
        private INode block;

        public WhileNode(INode expression, INode block)
        {
            this.expression = expression;
            this.block = block;
        }

        public Value Evaluate()
        {
            Value exprV = expression.Evaluate();
            if (!exprV.IsBoolean())
            {
                throw new CompilerException(GetLine(), "type mismatch", "cannot convert from " + exprV.GetType() + " to boolean");
            }

            while (expression.Evaluate().AsBoolean())
            {
                Value returnValue = block.Evaluate();
                if (returnValue != Value.VOID)
                {
                    if (returnValue == Value.BREAK)
                    {
                        return Value.VOID;
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

            return Value.VOID;
        }

        public int GetLine()
        {
            return expression.GetLine();
        }

    }
}
