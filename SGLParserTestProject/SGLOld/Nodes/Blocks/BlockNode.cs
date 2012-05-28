using System;
using System.Collections.Generic;
using System.Text;
using SGLOld.Types;

namespace SGLOld.Nodes.Blocks
{
    class BlockNode : INode
    {
        private List<INode> statements;
        private List<SpriteObject> spriteObjects;
        private Scope scope;
        private int offset = 0;

        public BlockNode(List<SpriteObject> spriteObjects, Scope scope)
        {
            statements = new List<INode>();
            this.spriteObjects = spriteObjects;
            this.scope = scope;
        }

        public void AddStatement(INode stat)
        {
            statements.Add(stat);
        }

        public void AddOffset(int offset)
        {
            this.offset = offset;
            //scope.AddOffset(offset);
        }

        public Value Evaluate()
        {
            // handle offset
            //this.scope.ClearOffset();
            this.scope.AddOffset(offset);

            foreach (INode stat in statements)
            {
                Value value = stat.Evaluate();
                /*
                if (value != SGLValue.VOID)
                {
                    // return early from this block if value is a return statement  
                    return value;
                }*/
                if (value.IsReturn())
                {
                    // return early from this block if value is a return statement  
                    return value.AsReturn().value;
                }
            }

            // For adding local variables to the list of sprites and animations
            try
            {
                spriteObjects.AddRange(scope.GetObjects());
            }
            catch (CompilerException sce)
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
            return Value.VOID;
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
