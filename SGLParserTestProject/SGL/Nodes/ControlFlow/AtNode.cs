using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.ControlFlow
{
    class AtNode : AbstractNode
    {
        private AbstractNode expression;
        private AbstractNode block;

        public AtNode(AbstractNode expression, AbstractNode block)
        {
            this.expression = expression;
            this.block = block;
        }

        protected override Value Invoke()
        {
            Value exprV = expression.Evaluate();

            if (exprV.TypeEquals(ValType.Integer))
            {
                ((BlockNode)block).AddOffset(exprV.IntValue);
                // Execute the block
                return block.Evaluate();
            }
            else
            {
                throw new CompilerException(Line, 217, "offset", "AT", "Integer/Double", exprV.TypeString);
            }
        }

        public override int Line
        {
            get
            {
                return expression.Line;
            }
        }

    }
}
