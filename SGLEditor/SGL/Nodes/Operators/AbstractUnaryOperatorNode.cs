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

namespace SGL.Nodes.Operators
{
    /// <summary>
    /// Abstract class for all kind of operators which perform an action on 1 values, e.g. negation.
    /// </summary>
    internal abstract class AbstractUnaryOperatorNode : AbstractNode
    {
        private readonly AbstractNode node;

        public AbstractUnaryOperatorNode(AbstractNode node)
        {
            this.node = node;
        }

        public override int Line
        {
            get { return node.Line; }
        }

        protected abstract Value Operate(Value value);

        protected override Value Invoke()
        {
            Value value = node.Evaluate();
            return Operate(value);

            //throw new CompilerException(Line, 201, Name, value.TypeString);
        }
    }
}