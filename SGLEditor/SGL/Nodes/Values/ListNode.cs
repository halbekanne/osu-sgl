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
    internal class ListNode : AbstractNode
    {
        private readonly List<AbstractNode> expressionNodes;

        public ListNode(List<AbstractNode> nodes)
        {
            expressionNodes = (nodes == null) ? new List<AbstractNode>() : nodes;
        }

        public override int Line
        {
            get { return expressionNodes.Count > 0 ? expressionNodes[0].Line : -1; }
        }

        protected override Value Invoke()
        {
            var evaluated = new List<Value>();
            foreach (AbstractNode node in expressionNodes)
            {
                evaluated.Add(node.Evaluate());
            }
            return new Value(evaluated, ValType.List);
        }
    }
}