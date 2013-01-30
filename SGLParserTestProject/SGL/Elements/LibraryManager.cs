using System;
using System.Collections.Generic;
using SGL.Library.Classes;
using SGL.Library.Functions;
using SGL.Library.Functions.Calculation;
using SGL.Library.Functions.IO;
using System.Reflection;

namespace SGL.Elements
{
    /// <summary>
    /// Singleton containing classes which can be used in SGL
    /// </summary>
    internal class LibraryManager
    {
        private static readonly LibraryManager instance = new LibraryManager();
        private readonly Dictionary<string, AbstractObjectFactory> classes = new Dictionary<string, AbstractObjectFactory>();

        // memory for methods
        private readonly Dictionary<string, Function> functions = new Dictionary<string, Function>();

        private LibraryManager()
        {
            RegisterClasses();
            RegisterFunctions();
        }

        public static LibraryManager Instance
        {
            get { return instance; }
        }

        private void RegisterClasses()
        {
            RegisterClass("List", new ListFactory());
            RegisterClass("Sprite", new SpriteFactory());
            RegisterClass("Animation", new AnimationFactory());
            RegisterClass("Layer", new LayerFactory());
        }

        private void RegisterFunctions()
        {
            RegisterFunction("sin", new SinFunction());
            RegisterFunction("rand", new RandFunction());
            RegisterFunction("println", new PrintFunction());
        }

        // memory for classes

        //public Function GetFunction(string name, List<Value> parameters);

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

        public bool IsFunctionKnown(String funcName)
        {
            if (functions.ContainsKey(funcName))
            {
                return true;
            }
            return false;
        }

        public void RegisterClass(string name, AbstractObjectFactory cls)
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
        public object GetClass(string name, List<Value> parameters)
        {
            // look if the class exists
            if (classes.ContainsKey(name))
            {
                try
                {
                    return classes[name].CreateNewInstance(parameters);
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


        public Function GetFunction(string name, List<Value> parameters)
        {
            // look if the function exists
            if (functions.ContainsKey(name))
            {
                try
                {
                    return functions[name];
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

        public Value InvokeMethod(object instance, String methodName, List<Value> parameters)
        {
            List<Type> parameterTypes = new List<Type>();
            foreach (Value parameter in parameters) {
                parameterTypes.Add(parameter.GetType());
            }

            // Get the desired method by name
            MethodInfo methodInfo = instance.GetType().GetMethod(methodName, parameterTypes.ToArray());

            // Use the instance to call the method
            if (methodInfo != null)
            {
                return (Value)methodInfo.Invoke(instance, parameters.ToArray());
            }
            else
            {
                return null;
            }

        }



    }
}