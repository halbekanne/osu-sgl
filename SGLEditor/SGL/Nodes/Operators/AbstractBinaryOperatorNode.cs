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
    /// Abstract class for all kind of operators which perform an action on 2 values, e.g. addition.
    /// </summary>
    internal abstract class AbstractBinaryOperatorNode : AbstractNode
    {
        private readonly AbstractNode node1;
        private readonly AbstractNode node2;

        public AbstractBinaryOperatorNode(AbstractNode node1, AbstractNode node2)
        {
            this.node1 = node1;
            this.node2 = node2;
        }

        public override int Line
        {
            get { return node1.Line; }
        }

        protected abstract Value Operate(Value value1, Value value2);

        //public abstract bool CheckArguments(ValType type1, ValType type2);

        protected override Value Invoke()
        {
            Value value1 = node1.Evaluate();
            Value value2 = node2.Evaluate();

            return Operate(value1, value2);

            //throw new CompilerException(Line, 202, Name, value1.TypeString, value2.TypeString);
        }

        //public abstract String Name { get;}
    }
}