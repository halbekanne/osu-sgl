using System;
using System.Collections.Generic;
using SGL.Elements;
using System.Reflection;

namespace SGL.Library.Classes
{
    public abstract class AbstractObjectFactory
    {
        //public abstract void Test();
        public abstract String Name { get; }

        public abstract object CreateNewInstance(List<Value> parameters);

        /*
        public abstract List<...> GetConstructors();
        public abstract List<...> GetMethods();
        public abstract List<...> GetPublicVariables();
    
        public Value invokeMethod(String name, List<Value> parameters) {
            ...
            }
         * */
    }
}