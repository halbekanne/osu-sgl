using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGL.Classes;
using System.Reflection;
using SGL.Methods;

namespace SGL.Elements
{

    /// <summary>
    /// Singleton containing classes which can be used in SGL
    /// </summary>
    class Library
    {
        private static readonly Library instance = new Library();

        private Library() { }

        public static Library Instance
        {
            get
            {
                return instance;
            }
        }

        // memory for classes
        private Dictionary<string, Class> classes = new Dictionary<string, Class>();

        // memory for methods
        private Dictionary<string, Method> methods = new Dictionary<string, Method>();


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


        /// <summary>
        /// Edit: No more Types due to the performance issues
        /// </summary>
        /// <param name="name"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public Class GetClass(string name, List<Value> parameters)
        {
            // look if the class exists
            if (classes.ContainsKey(name)) {
                return classes[name].CreateObject(parameters);
            }

            throw new Exception();
        }








    }
}
