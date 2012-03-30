using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes.Blocks
{
    class IfNode : INode
    {
        private List<Choice> choices;

        public IfNode()
        {
            choices = new List<Choice>();
        }

        private class Choice
        {

            public INode expression;
            public INode block;

            public Choice(INode e, INode b)
            {
                expression = e;
                block = b;
            }
        }

        public void AddChoice(INode e, INode b)
        {
            choices.Add(new Choice(e, b));
        } 
        

        public Value Evaluate()
        {

           foreach(Choice ch in choices) {  
              Value value = ch.expression.Evaluate();  
  
              if(!value.IsBoolean()) {  
                throw new CompilerException(GetLine(), "type mismatch", "cannot convert from " + value.GetType() + " to boolean");
              }  
  
              if(value.AsBoolean()) {  
                return ch.block.Evaluate();  
              }  
            }  
  
            return Value.VOID;  
        }

        public int GetLine()
        {
            // There must be at least one expression in the list
            return choices[0].expression.GetLine();
        }

    }
}
