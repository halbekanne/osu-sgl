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

namespace SGL.Nodes.Values
{
    internal class IdentifierNode : AbstractNode
    {
        private readonly String identifier;
        private readonly int line;
        private readonly Scope scope;

        public IdentifierNode(String identifier, Scope scope, int line)
        {
            this.identifier = identifier;
            this.scope = scope;
            this.line = line;
        }


        public override int Line
        {
            get { return line; }
        }

        protected override Value Invoke()
        {
            Value value = scope.Resolve(identifier);
            if (value == null)
            {
                throw new CompilerException(Line, 211, identifier);
            }

            return value;
        }
    }
}