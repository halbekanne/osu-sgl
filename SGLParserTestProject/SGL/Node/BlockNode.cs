using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class BlockNode : SGLNode
    {
        private List<SGLNode> statements;
        private List<SGLObject> spriteObjects;
        private Scope scope;

        public BlockNode(List<SGLObject> spriteObjects, Scope scope)
        {
            statements = new List<SGLNode>();
            this.spriteObjects = spriteObjects;
            this.scope = scope;
            Console.WriteLine("Created Block node with Scope (Parents: " + scope.getParentNumber() + ")");
        }

        public void AddStatement(SGLNode stat)
        {
            statements.Add(stat);
        }

        public SGLValue Evaluate()
        {
            foreach (SGLNode stat in statements)
            {
                SGLValue value = stat.Evaluate();
                if (value != SGLValue.VOID)
                {
                    // return early from this block if value is a return statement  
                    return value;
                }
            }

            // For adding local variables to the list of sprites and animations
            spriteObjects.AddRange(scope.GetObjects());

            // Clear variables in scope for reuse
            scope.ClearVariables();
            Console.WriteLine("Cleared all variables in Scope (Parents: " + scope.getParentNumber() + ")");

            // return VOID if no return was done earlier
            return SGLValue.VOID;
        }

    }
}
