using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGL.Library.Classes;
using System.Reflection;
using SGL.Library.Functions;

namespace SGL.Elements
{

    /// <summary>
    /// Singleton containing classes which can be used in SGL
    /// </summary>
    class LibraryManager
    {
        private static readonly LibraryManager instance = new LibraryManager();

        private LibraryManager() { 
            RegisterClasses();
        }

        public static LibraryManager Instance
        {
            get
            {
                return instance;
            }
        }

        private void RegisterClasses() {
            this.RegisterClass("Sprite", new Sprite());
        }

        private void RegisterFunctions()
        {
            this.RegisterFunction("sin", new SinFunction());
        }

        // memory for classes
        private Dictionary<string, Class> classes = new Dictionary<string, Class>();

        // memory for methods
        private Dictionary<string, Function> functions = new Dictionary<string, Function>();

        public Function GetFunction(string name, List<Value> parameters);

        /// <summary>
        /// Tests if a class is known by the Library and was registered before.
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public bool IsClassKnown(String className)
        {
            if (classes.ContainsKey(className))
            {
                return true;
            }
            return false;
        }

        public void RegisterClass(string name, Class cls)
        {
            classes.Add(name, cls);
        }

        public void RegisterFunction(string name, Function func)
        {
            functions.Add(name, func);
        }


        /// <summary>
        /// Returns the class 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Class GetClass(string name, List<Value> parameters)
        {
            // look if the class exists
            if (classes.ContainsKey(name))
            {
                try
                {
                    return classes[name].CreateObject(parameters);
                }
                catch (CompilerException ce)
                {
                    if (ce.ErrorCode == 312)
                    {
                        ce.SetArguments(name, Value.PrintTypeList(parameters));
                    }
                    throw ce;
                }
            }
            else
            {
                throw new CompilerException(-1, 311, name, Value.PrintTypeList(parameters));
            }
        }








    }
}
