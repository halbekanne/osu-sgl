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

namespace SGL.Nodes.Values
{
    internal class LookupNode : AbstractNode
    {
        private readonly AbstractNode expression;
        private readonly List<AbstractNode> indexes;

        public LookupNode(AbstractNode e, List<AbstractNode> i)
        {
            expression = e;
            indexes = i;
        }

        public override int Line
        {
            get { return expression.Line; }
        }

        protected override Value Invoke()
        {
            Value value = expression.Evaluate();

            var indexValues = new List<Value>();

            foreach (AbstractNode indexNode in indexes)
            {
                indexValues.Add(indexNode.Evaluate());
            }

            foreach (Value index in indexValues)
            {
                if (!index.TypeEquals(ValType.Integer))
                {
                    throw new CompilerException(Line, 214, index.TypeString);
                }
                else if (value.Type != ValType.List /* || value.IsString()*/)
                {
                    throw new CompilerException(Line, 215, value.TypeString);
                }

                int idx = index.IntValue;
                value = value.ListValue[idx];
            }

            return value;
        }
    }
}