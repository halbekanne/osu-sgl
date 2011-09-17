using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.Expression
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
                throw new SGLCompilerException(GetLine(), "type mismatch", "cannot convert from " + a.GetVarType() + " to boolean");
            }

            return a.AsBoolean() ? ifTrue.Evaluate() : ifFalse.Evaluate();
        }

        public int GetLine()
        {
            return condition.GetLine();
        }


    }
}
