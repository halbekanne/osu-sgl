using System;
using System.Collections.Generic;
using System.Text;
using SGLOld.Nodes.Methods;

namespace SGLOld
{
    /// <summary>
    /// Singleton, where predefined methods and object methods can be registered.
    /// </summary>
    public class Global
    {
        private Global() { 
            //initializise empty Library
        }
        private static volatile Global instance;
        // Hilfsfeld für eine sichere Threadsynchronisierung
        private static object m_lock = new object();

        public static Global GetInstance()
        {
            // DoubleLock
            if (instance == null)
            {
                lock (m_lock)
                {
                    if (instance == null)
                    {
                        instance = new Global();
                    }
                }
            }
            return instance;
        }


        private Dictionary<String, Dictionary<int, IMethod>> methods = new Dictionary<String, Dictionary<int, IMethod>>();

        public void RegisterMethod(IMethod method)
        {
            if (methods.ContainsKey(method.GetName()))
            {
                // add another method to the dic
                if (methods[method.GetName()].ContainsKey(method.GetParameterNumer()))
                {
                    // If a method with the same name AND the same number of parameters exists, throw an error.

                }
                else
                {
                    methods[method.GetName()].Add(method.GetParameterNumer(), method);
                }
            }
            Dictionary<int, IMethod> tempDic = new Dictionary<int, IMethod>();
            tempDic.Add(method.GetParameterNumer(), method);
            methods.Add(method.GetName(), tempDic);
        }
        /*
        public void Empty()
        {
            methods = new Dictionary<String, IMethod>();
        }

        public Value TryExecuteMethod(String name, List<Value> arguments, int line)
        {
            methods.ContainsKey(name);
        }
         * */

    }
}
