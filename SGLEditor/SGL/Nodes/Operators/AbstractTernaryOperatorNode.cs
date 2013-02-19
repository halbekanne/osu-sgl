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

namespace SGL.Nodes.Operators
{
    /// <summary>
    /// Abstract class for all kind of operators which perform an action on 2 values, e.g. addition.
    /// </summary>
    internal abstract class AbstractTernaryOperatorNode : AbstractNode
    {
        private readonly AbstractNode node1;
        private readonly AbstractNode node2;
        private AbstractNode node3;

        public AbstractTernaryOperatorNode(AbstractNode node1, AbstractNode node2, AbstractNode node3)
        {
            this.node1 = node1;
            this.node2 = node2;
            this.node2 = node3;
        }

        public abstract String Name { get; }

        public override int Line
        {
            get { return node1.Line; }
        }

        public abstract Value Operate(Value value1, Value value2, Value value3, ValType type1, ValType type2,
                                      ValType type3);

        public abstract bool CheckArguments(ValType type1, ValType type2, ValType type3);

        protected override Value Invoke()
        {
            Value value1 = node1.Evaluate();
            Value value2 = node2.Evaluate();
            Value value3 = node3.Evaluate();

            ValType type1 = value1.Type;
            ValType type2 = value2.Type;
            ValType type3 = value3.Type;

            if (CheckArguments(type1, type2, type3))
            {
                try
                {
                    return Operate(value1, value2, value3, type1, type2, type3);
                }
                catch (CompilerException sce)
                {
                    // Catch all CompilerExceptions and add the line number.
                    sce.Line = Line;
                    throw;
                }
            }
            else
            {
                throw new CompilerException(Line, 203, Name, value1.TypeString, value2.TypeString, value3.TypeString);
            }
        }
    }
}