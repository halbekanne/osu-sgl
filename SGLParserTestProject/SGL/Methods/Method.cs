using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGL.Elements;

namespace SGL.Methods
{
    abstract class Method
    {

        public abstract Value InvokeMethod(List<Value> parameters);
        
        /*
        protected String name;
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
