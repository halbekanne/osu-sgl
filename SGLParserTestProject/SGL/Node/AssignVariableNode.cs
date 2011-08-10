using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class AssignVariableNode : SGLNode
    {
        private String name;
        private SGLNode expression;
        private Scope scope; 

        public AssignVariableNode(String name, SGLNode expression, Scope scope)
        {
            this.name = name;
            this.expression = expression;
            this.scope = scope;
        }

        public SGLValue Evaluate() {

            SGLValue exprV = expression.Evaluate();
            if (exprV == SGLValue.VOID)
            {
                throw new Exception("can't assign VOID to " + name);
            }

            scope.Assign(name, exprV, false, "");

            return SGLValue.VOID;
        }


    }
}
