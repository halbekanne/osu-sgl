using System.Collections.Generic;
using SGL.Elements;

namespace SGL.Nodes.ControlFlow
{
    internal class IfNode : AbstractNode
    {
        private readonly List<Choice> choices;

        public IfNode()
        {
            choices = new List<Choice>();
        }

        public override int Line
        {
            get
            {
                // There should be at least one expression in the list
                return choices.Count > 0 ? choices[0].expression.Line : -1;
            }
        }

        public void AddChoice(AbstractNode expression, AbstractNode block)
        {
            choices.Add(new Choice(expression, block));
        }


        protected override Value Invoke()
        {
            foreach (Choice choice in choices)
            {
                Value value = choice.expression.Evaluate();

                if (value.Type != ValType.Boolean)
                {
                    throw new CompilerException(Line, 217, "condition", "IF", "Boolean", value.TypeString);
                }

                if (value.BoolValue)
                {
                    return choice.block.Evaluate();
                }
            }

            return Value.VOID;
        }

        #region Nested type: Choice

        private class Choice
        {
            public readonly AbstractNode block;
            public readonly AbstractNode expression;

            public Choice(AbstractNode expression, AbstractNode block)
            {
                this.expression = expression;
                this.block = block;
            }
        }

        #endregion
    }
}