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

namespace SGL.Nodes.Actions
{
    internal class DefineVariableNode : AbstractNode
    {
        private readonly int line;
        private readonly String name;
        private readonly Scope scope;

        public DefineVariableNode(String name, Scope scope, int line)
        {
            this.name = name;
            this.scope = scope;
            this.line = line;
        }

        // global assign
        public DefineVariableNode(String name, int line)
        {
            this.name = name;
            scope = GlobalMemory.Instance.GlobalScope;
            this.line = line;
        }

        public override int Line
        {
            get { return line; }
        }

        protected override Value Invoke()
        {
            // a simple assignment
            //scope.SetSpriteGenerators(SpriteGenerators);
            scope.Define(name);


            return Value.VOID;
        }
    }
}