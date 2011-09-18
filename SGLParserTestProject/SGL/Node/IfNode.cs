using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class IfNode : SGLNode
    {
        private List<Choice> choices;

        public IfNode()
        {
            choices = new List<Choice>();
        }

        private class Choice
        {

            public SGLNode expression;
            public SGLNode block;

            public Choice(SGLNode e, SGLNode b)
            {
                expression = e;
                block = b;
            }
        }

        public void AddChoice(SGLNode e, SGLNode b)
        {
            choices.Add(new Choice(e, b));
        } 
        

        public SGLValue Evaluate()
        {

           foreach(Choice ch in choices) {  
              SGLValue value = ch.expression.Evaluate();  
  
              if(!value.IsBoolean()) {  
                throw new SGLCompilerException(GetLine(), "type mismatch", "cannot convert from " + value.GetVarType() + " to boolean");
              }  
  
              if(value.AsBoolean()) {  
                return ch.block.Evaluate();  
              }  
            }  
  
            return SGLValue.VOID;  
        }

        public int GetLine()
        {
            // There must be at least one expression in the list
            return choices[0].expression.GetLine();
        }

    }
}
