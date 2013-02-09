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

namespace SGL.Library.Classes
{
    internal class ListClass : AbstractClass
    {
        public override string Name
        {
            get { return "List"; }
        }

        public override object CreateInstance(List<Value> param)
        {
            return new Value(param, ValType.List);
            //else throw new CompilerException(-1, 312);
        }

        public override Value InvokeMethod(String name, List<Value> param)
        {
            throw new CompilerException(-1, 314, Name, name);
        }
    }
}