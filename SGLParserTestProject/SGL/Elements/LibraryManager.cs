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
<<<<<<< HEAD
        private readonly Dictionary<string, AbstractObjectFactory> classes = new Dictionary<string, AbstractObjectFactory>();
=======
        private readonly Dictionary<string, Class> classes = new Dictionary<string, Class>();
>>>>>>> acd057c2e1cb7c9ab7790ac768f8e71ba04f5e58

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
<<<<<<< HEAD
            RegisterClass("List", new ListFactory());
            RegisterClass("Sprite", new SpriteFactory());
            RegisterClass("Animation", new AnimationFactory());
            RegisterClass("Layer", new LayerFactory());
=======
            RegisterClass("List", new List());
            RegisterClass("Sprite", new Sprite());
            RegisterClass("Animation", new Animation());
            RegisterClass("Layer", new Layer());
>>>>>>> acd057c2e1cb7c9ab7790ac768f8e71ba04f5e58
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
<<<<<<< HEAD

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



=======
>>>>>>> acd057c2e1cb7c9ab7790ac768f8e71ba04f5e58
    }
}