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
        private List<SGLObject> spriteObjects;

        public AssignVariableNode(String name, SGLNode expression,List<SGLObject> spriteObjects, Scope scope)
        {
            this.name = name;
            this.expression = expression;
            this.scope = scope;
            this.spriteObjects = spriteObjects;
        }

        public SGLValue Evaluate() {

            SGLValue exprV = expression.Evaluate();
            if (exprV == SGLValue.VOID)
            {
                throw new Exception("can't assign VOID to " + name);
            }

            scope.SetSpriteObjects(spriteObjects);
            scope.Assign(name, exprV, false, "");

            return SGLValue.VOID;
        }

        public int GetLine()
        {
            return expression.GetLine();
        }

    }
}
