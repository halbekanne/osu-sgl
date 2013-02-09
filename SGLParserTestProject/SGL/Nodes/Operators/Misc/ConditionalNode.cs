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

namespace SGL.Nodes.Operators.Misc
{
    /// <summary>
    /// This operator could implement the AbstractTernaryOperatorNode but is rather using AbstractNode because of performance reasons.
    /// </summary>
    internal class ConditionalNode : AbstractNode
    {
        private readonly AbstractNode conditionNode;
        private readonly AbstractNode elseNode;
        private readonly AbstractNode ifNode;

        public ConditionalNode(AbstractNode conditionNode, AbstractNode ifNode, AbstractNode elseNode)
        {
            this.conditionNode = conditionNode;
            this.ifNode = ifNode;
            this.elseNode = elseNode;
        }

        public override int Line
        {
            get { return conditionNode.Line; }
        }

        protected override Value Invoke()
        {
            Value condValue = conditionNode.Evaluate();

            if (condValue.Type != ValType.Boolean)
            {
                throw new CompilerException(Line, 206, condValue.TypeString);
            }

            return condValue.BoolValue ? ifNode.Evaluate() : elseNode.Evaluate();
        }
    }
}