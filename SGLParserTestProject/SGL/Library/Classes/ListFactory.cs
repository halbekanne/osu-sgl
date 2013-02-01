using System;
using System.Collections.Generic;
using SGL.Elements;

namespace SGL.Library.Classes
{
<<<<<<< HEAD:SGLParserTestProject/SGL/Library/Classes/ListFactory.cs
    internal class ListFactory : AbstractObjectFactory
=======
    internal class List : Class
>>>>>>> acd057c2e1cb7c9ab7790ac768f8e71ba04f5e58:SGLParserTestProject/SGL/Library/Classes/List.cs
    {
        public override string Name
        {
            get { return "List"; }
        }

<<<<<<< HEAD:SGLParserTestProject/SGL/Library/Classes/ListFactory.cs
        public override object CreateNewInstance(List<Value> param)
=======
        public override object CreateObject(List<Value> param)
>>>>>>> acd057c2e1cb7c9ab7790ac768f8e71ba04f5e58:SGLParserTestProject/SGL/Library/Classes/List.cs
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