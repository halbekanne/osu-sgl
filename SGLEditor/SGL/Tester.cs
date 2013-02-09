using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGL.Elements;
using SGL.Library.Classes;

namespace SGL
{
    class Tester
    {
        static void Main(string[] args)
        {
            Library lib = Library.Instance;
            lib.RegisterClass("test", typeof(Subclass));
            Class testclass = (Class)lib.GetClass("test", 1, 2);
            testclass.Test();
            Console.WriteLine("ende");
            int i = 1;
        }
    }
}
