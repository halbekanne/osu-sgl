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

        public override object CreateObject(List<Value> param)
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