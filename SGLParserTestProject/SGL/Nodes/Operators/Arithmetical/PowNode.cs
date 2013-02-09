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
using System;
using SGL.Elements;

namespace SGL.Nodes.Operators.Arithmetical
{
    internal class PowNode : AbstractBinaryOperatorNode
    {
        private AbstractNode lhs;
        private AbstractNode rhs;

        public PowNode(AbstractNode node1, AbstractNode node2) : base(node1, node2)
        {
        }

        protected override Value Operate(Value value1, Value value2)
        {
            // number + number
            if (value1.Type == ValType.Integer && value2.Type == ValType.Integer)
            {
                double x = Math.Pow(value1.DoubleValue, value1.DoubleValue);
                //Console.WriteLine(x);
                if (x == Double.PositiveInfinity)
                {
                    throw new CompilerException(Line, 402, "Double");
                }
                else if (x == Double.NegativeInfinity)
                {
                    throw new CompilerException(Line, 401, "Double");
                }
                else if (x == Double.NaN)
                {
                    throw new CompilerException(Line, 403, "Double");
                }

                int Int;
                bool isInt = Int32.TryParse(x.ToString(), out Int);
                if (isInt)
                    return new Value(Int, ValType.Integer);
                else
                    return new Value(x, ValType.Double);
            }
                // float + number / number + float  
            else if (value1.TypeEquals(ValType.Double) && value2.TypeEquals(ValType.Double))
            {
                double x = Math.Pow(value1.DoubleValue, value1.DoubleValue);
                //Console.WriteLine(x);
                if (x == Double.PositiveInfinity)
                {
                    throw new CompilerException(Line, 402, "Double");
                }
                else if (x == Double.NegativeInfinity)
                {
                    throw new CompilerException(Line, 401, "Double");
                }
                else if (x == Double.NaN)
                {
                    throw new CompilerException(Line, 403, "Double");
                }
                return new Value(x, ValType.Double);
            }
            else
            {
                throw new CompilerException(Line, 202, "^", value1.TypeString, value2.TypeString);
            }
        }
    }
}