using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class TernaryNode : SGLNode
    {
        private SGLNode condition;
        private SGLNode ifTrue;
        private SGLNode ifFalse;

        public TernaryNode(SGLNode condition, SGLNode ifTrue, SGLNode ifFalse)
        {
            this.condition = condition;
            this.ifTrue = ifTrue;
            this.ifFalse = ifFalse;
        }

        public SGLValue Evaluate()
        {

            SGLValue a = condition.Evaluate();

            if (!a.IsBoolean())
            {
                throw new Exception("not a boolean expression: " + condition + ", in: " + this);
            }

            return a.AsBoolean() ? ifTrue.Evaluate() : ifFalse.Evaluate();
        }


        public String ToString()
        {
            return condition.ToString() + " ? " + ifTrue.ToString() + " : " + ifFalse.ToString();
        }


    }
}
