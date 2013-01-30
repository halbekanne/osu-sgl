using SGL.Elements;

namespace SGL.Nodes.ControlFlow
{
    internal class WhileNode : AbstractNode
    {
        private readonly AbstractNode block;
        private readonly AbstractNode expression;

        public WhileNode(AbstractNode expression, AbstractNode block)
        {
            this.expression = expression;
            this.block = block;
        }

        public override int Line
        {
            get { return expression.Line; }
        }

        protected override Value Invoke()
        {
            Value exprV = expression.Evaluate();
            if (exprV.Type != ValType.Boolean)
            {
                throw new CompilerException(Line, 217, "condition", "IF", "Boolean", exprV.TypeString);
            }

            while (expression.Evaluate().BoolValue)
            {
                Value returnValue = block.Evaluate();
                if (returnValue != Value.VOID)
                {
                    if (returnValue == Value.BREAK)
                    {
                        return Value.VOID;
                    }
                    else if (returnValue.Type == ValType.Return)
                    {
                        // return early from this block if value is a return statement  
                        return returnValue.ReturnValue;
                    }
                }
            }

            return Value.VOID;
        }
    }
}