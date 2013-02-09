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

namespace SGL.Library.Functions
{
    internal abstract class Function
    {
        /*
        protected Function(string name)
        {
            this.name = name;
        }

        protected String name;

        public string Name
        {
            get
            {
                return name;
            }
        }*/

        public abstract Value Invoke(List<Value> parameters);

        //public abstract bool TestPatameters(List<Value> parameters);


        /*
        protected ValType returnType;
        protected List<ValType> parameterTypes;

        protected Method(String name)
        {
            this.name = name;
        }

        string Name
        {
            get { return name; }
        }

        ValType ReturnType
        {
            get { return returnType; }
        }

        List<ValType> ParameterTypes
        {
            get { return parameterTypes; }
        }

        abstract public 
        */
    }
}