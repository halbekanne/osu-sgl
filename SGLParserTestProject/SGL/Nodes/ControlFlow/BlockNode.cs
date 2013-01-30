using System.Collections.Generic;
using SGL.Elements;

namespace SGL.Nodes.ControlFlow
{
    internal class BlockNode : AbstractNode
    {
        private readonly Scope scope;
        private readonly List<AbstractNode> statements;
        private int addOffset;

        public BlockNode(Scope scope)
        {
            statements = new List<AbstractNode>();
            this.scope = scope;
        }

        public override int Line
        {
            get
            {
                // -1 could be returned here if no argument was given, but the line number will be retrieved later
                return statements.Count > 0 ? statements[0].Line : -1;
            }
        }

        public void AddStatement(AbstractNode stat)
        {
            statements.Add(stat);
        }

        public void AddOffset(int offset)
        {
            addOffset = offset;
            //scope.AddOffset(offset);
        }

        protected override Value Invoke()
        {
            // handle offset
            //this.scope.ClearScope();
            scope.Offset += addOffset;

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
            scope.Clear();

            // return VOID if no return was done earlier
            return Value.VOID;
        }
    }
}