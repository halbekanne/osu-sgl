using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.ControlFlow
{
    class BlockNode : AbstractNode
    {
        private List<AbstractNode> statements;
        private Scope scope;
        private int addOffset = 0;

        public BlockNode(Scope scope)
        {
            statements = new List<AbstractNode>();
            this.scope = scope;
        }

        public void AddStatement(AbstractNode stat)
        {
            statements.Add(stat);
        }

        public void AddOffset(int offset)
        {
            this.addOffset = offset;
            //scope.AddOffset(offset);
        }

        protected override Value Invoke()
        {
            // handle offset
            //this.scope.ClearScope();
            this.scope.AddOffset(addOffset);

            foreach (AbstractNode stat in statements)
            {
                Value value = stat.Evaluate();
                /*
                if (value != SGLValue.VOID)
                {
                    // return early from this block if value is a return statement  
                    return value;
                }*/
                if (value.Type == ValType.Return)
                {
                    // return early from this block if value is a return statement  
                    return value.ReturnValue;
                }
            }

            // Clear scope for reuse
            scope.ClearScope();

            // return VOID if no return was done earlier
            return Value.VOID;
        }

        public override int Line
        {
            get
            {
                // -1 could be returned here if no argument was given, but the line number will be retrieved later
                return statements.Count > 0 ? statements[0].Line : -1;
            }
        }
    }
}
