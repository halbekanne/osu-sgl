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
using System.Collections.Generic;
using SGL.Elements;

namespace SGL.Nodes.Actions
{
    internal class InstanciateClassNode : AbstractNode
    {
        private readonly String className;
        private readonly int line;
        private readonly List<AbstractNode> parameters;

        public InstanciateClassNode(String className, List<AbstractNode> parameters, int line)
        {
            // It's checked weather or not the classname itself exists in order to avoid typos at an early state
            if (!LibraryManager.Instance.IsClassKnown(className))
            {
                throw new CompilerException(line, 311, className);
            }
            this.className = className;
            this.parameters = parameters != null ? parameters : new List<AbstractNode>();
            this.line = line;
        }


        public override int Line
        {
            get { return line; }
        }

        protected override Value Invoke()
        {
            var values = new List<Value>();
            foreach (AbstractNode node in parameters)
            {
                values.Add(node.Evaluate());
            }

            object classObj = LibraryManager.Instance.GetClass(className, values);
            if (classObj is Value)
            {
                return (Value) classObj;
            }
            else
            {
                return new Value(classObj, ValType.Object);
            }
        }
    }
}