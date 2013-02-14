//  Storyboard Generation Language
//  Copyright (C) 2013 Dominik Halfkann
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
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
                    return value;
                }
            }

            // Clear scope for reuse
            scope.Clear();

            // return VOID if no return was done earlier
            return Value.VOID;
        }
    }
}