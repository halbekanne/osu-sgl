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
        }

        public void AddStatement(SGLNode stat)
        {
            statements.Add(stat);
        }

        public void AddOffset(int offset)
        {
            scope.AddOffset(offset);
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
            try
            {
                spriteObjects.AddRange(scope.GetObjects());
            }
            catch (SGLCompilerException sce)
            {
                if (sce.ErrorType.Equals("undeclared object"))
                {
                    sce.Line = GetLine();
                    sce.Message = "declared object variable '" + sce.Message + "' has to be assigned at the end of the block (reported line number may be wrong)";
                    throw sce;
                }
            }

            // Clear variables in scope for reuse
            scope.ClearVariables();

            // return VOID if no return was done earlier
            return SGLValue.VOID;
        }

        public int GetLine()
        {
            // -1 could be returned here if no argument was given, but the line number will be retrieved later
            if (statements.Count > 0)
            {
                return statements[0].GetLine();
            }
            else
            {
                return -1;
            }
        }
    }
}
