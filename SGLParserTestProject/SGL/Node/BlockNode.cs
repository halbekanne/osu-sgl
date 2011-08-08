using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class BlockNode : SGLNode
    {
        private List<SGLNode> statements;

        public BlockNode()
        {
            statements = new List<SGLNode>();
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

            // return VOID if no return was done earlier
            return SGLValue.VOID;
        }

    }
}
