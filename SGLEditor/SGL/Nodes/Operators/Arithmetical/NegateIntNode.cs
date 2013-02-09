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

namespace SGL.Nodes.Operators.Arithmetical
{
    internal class NegateIntNode : AbstractUnaryOperatorNode
    {
        public NegateIntNode(AbstractNode node) : base(node)
        {
        }

        protected override Value Operate(Value value)
        {
            if (value.Type == ValType.Integer)
            {
                return new Value(value.IntValue*(-1), ValType.Integer);
            }
            else if (value.Type == ValType.Double)
            {
                return new Value(value.DoubleValue*(-1), ValType.Double);
            }
            else
            {
                throw new CompilerException(Line, 201, "-", value.TypeString);
            }
        }
    }
}