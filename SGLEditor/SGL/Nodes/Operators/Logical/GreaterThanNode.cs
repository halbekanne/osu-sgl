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

namespace SGL.Nodes.Operators.Logical
{
    internal class GreaterThanNode : AbstractBinaryOperatorNode
    {
        public GreaterThanNode(AbstractNode node1, AbstractNode node2) : base(node1, node2)
        {
        }

        protected override Value Operate(Value value1, Value value2)
        {
            if (value1.TypeEquals(ValType.Double) && value2.TypeEquals(ValType.Double))
            {
                return new Value(value1.DoubleValue > value2.DoubleValue, ValType.Boolean);
            }
            else if (value1.Type == ValType.String && value2.Type == ValType.String)
            {
                // Strings
                return new Value(value1.StringValue.CompareTo(value2.StringValue) > 0, ValType.String);
            }
            else
            {
                throw new CompilerException(Line, 202, ">", value1.TypeString, value2.TypeString);
            }
        }
    }
}