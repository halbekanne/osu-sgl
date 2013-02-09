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
    internal class AtomNode : AbstractNode
    {
        private readonly int line = -1;
        private readonly Value value;

        public AtomNode(object value, ValType type)
        {
            if (type == ValType.String)
            {
                // escape sequences
                var newString = (String) value;
                newString = newString.Replace("\\\\", "\\");
                newString = newString.Replace("\\\"", "\"");
                value = newString;
            }

            this.value = (value == null) ? Value.NULL : new Value(value, type);
        }

        public AtomNode(object value, ValType type, int line)
            : this(value, type)
        {
            this.line = line;
        }

        public override int Line
        {
            get { return line; }
        }

        protected override Value Invoke()
        {
            return value;
        }
    }
}