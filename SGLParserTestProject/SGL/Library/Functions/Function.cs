using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGL.Elements;

namespace SGL.Library.Functions
{
    abstract class Function
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

        public abstract bool TestPatameters(List<Value> parameters);

        

        

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
