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
using SGL.Elements;

namespace SGL.Nodes.ControlFlow
{
    internal class AtNode : AbstractNode
    {
        private readonly AbstractNode block;
        private readonly AbstractNode expression;

        public AtNode(AbstractNode expression, AbstractNode block)
        {
            this.expression = expression;
            this.block = block;
        }

        public override int Line
        {
            get { return expression.Line; }
        }

        protected override Value Invoke()
        {
            Value exprV = expression.Evaluate();

            if (exprV.TypeEquals(ValType.Integer))
            {
                ((BlockNode) block).AddOffset(exprV.IntValue);
                // Execute the block
                return block.Evaluate();
            }
            else
            {
                throw new CompilerException(Line, 217, "offset", "AT", "Integer/Double", exprV.TypeString);
            }
        }
    }
}