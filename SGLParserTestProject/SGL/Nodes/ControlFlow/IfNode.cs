using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.ControlFlow
{
    class IfNode : AbstractNode
    {
        private List<Choice> choices;

        public IfNode()
        {
            choices = new List<Choice>();
        }

        private class Choice
        {
            public AbstractNode expression;
            public AbstractNode block;

            public Choice(AbstractNode expression, AbstractNode block)
            {
                this.expression = expression;
                this.block = block;
            }
        }

        public void AddChoice(AbstractNode expression, AbstractNode block)
        {
            choices.Add(new Choice(expression, block));
        }


        protected override Value Invoke()
        {

           foreach(Choice choice in choices) {
              Value value = choice.expression.Evaluate();  
  
              if(value.Type != ValType.Boolean) {
                  throw new CompilerException(Line, 217, "condition", "IF", "Boolean", value.TypeString);
              }  
  
              if(value.BoolValue) {
                  return choice.block.Evaluate();  
              }  
            }  
  
            return Value.VOID;  
        }

        public override int Line
        {
            get
            {
                // There should be at least one expression in the list
                return choices.Count > 0 ? choices[0].expression.Line : -1;
            }
        }

    }
}
