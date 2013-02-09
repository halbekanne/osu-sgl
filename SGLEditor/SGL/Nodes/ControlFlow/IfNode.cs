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
    internal class IfNode : AbstractNode
    {
        private readonly List<Choice> choices;

        public IfNode()
        {
            choices = new List<Choice>();
        }

        public override int Line
        {
            get
            {
                // There should be at least one expression in the list
                return choices.Count > 0 ? choices[0].expression.Line : -1;
            }
        }

        public void AddChoice(AbstractNode expression, AbstractNode block)
        {
            choices.Add(new Choice(expression, block));
        }


        protected override Value Invoke()
        {
            foreach (Choice choice in choices)
            {
                Value value = choice.expression.Evaluate();

                if (value.Type != ValType.Boolean)
                {
                    throw new CompilerException(Line, 217, "condition", "IF", "Boolean", value.TypeString);
                }

                if (value.BoolValue)
                {
                    return choice.block.Evaluate();
                }
            }

            return Value.VOID;
        }

        #region Nested type: Choice

        private class Choice
        {
            public readonly AbstractNode block;
            public readonly AbstractNode expression;

            public Choice(AbstractNode expression, AbstractNode block)
            {
                this.expression = expression;
                this.block = block;
            }
        }

        #endregion
    }
}