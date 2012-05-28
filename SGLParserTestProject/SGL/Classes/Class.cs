using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGL.Elements;

namespace SGL.Classes
{
    public abstract class Class
    {
        //public abstract void Test();
        public abstract String GetClassName();

        public abstract Value InvokeMethod(String name, List<Value> parameters);
        public abstract Class CreateObject(List<Value> parameters);

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
