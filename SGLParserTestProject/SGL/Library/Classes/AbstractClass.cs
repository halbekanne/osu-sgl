using System;
using System.Collections.Generic;
using SGL.Elements;

namespace SGL.Library.Classes
{
    public abstract class AbstractClass
    {
        //public abstract void Test();
        public abstract String Name { get; }

        public abstract Value InvokeMethod(String name, List<Value> parameters);
        public abstract object CreateObject(List<Value> parameters);

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