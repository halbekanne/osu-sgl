using System;
using System.Collections.Generic;

using System.Text;
using SGL.Storyboard;
using SGL.Library.Functions;

namespace SGL.Elements
{

    /// <summary>
    /// Singleton containing methods which can be used in SGL
    /// </summary>
    class GlobalMemory
    {
        private static GlobalMemory instance = new GlobalMemory();

        private GlobalMemory() { }

        public static GlobalMemory Instance
        {
            get
            {
                return instance;
            }
        }

        public static void Clear()
        {
            instance = new GlobalMemory();
        }

        private Random random = new Random();
        private Scope globalScope = new Scope();
        private Stack<CallItem> callStack = new Stack<CallItem>();
        private String currentCall = "main";
        private List<VisualObject> storyboardObjects = new List<VisualObject>();
        private Dictionary<string, Function> functions = new Dictionary<string, Function>();

        private String debug = "";

        public void debugAddLine(String line)
        {
            debug += line + "\r\n";
        }

        public String DebugString
        {
            get
            {
                return debug;
            }
        }

        public void RegisterFunction(string name, Function func)
        {
            functions.Add(name, func);
        }

        public bool IsFunctionKnown(String funcName)
        {
            if (functions.ContainsKey(funcName))
            {
                return true;
            }
            return false;
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

        public String CurrentCall
        {
            get
            {
                return currentCall;
            }
        }

        public void AddCallToStack(CallItem callItem)
        {
            callStack.Push(new CallItem(currentCall, callItem.Line));
            currentCall = callItem.Call;
        }

        public void PopLastCall()
        {
            CallItem lastCall = callStack.Pop();
            currentCall = lastCall.Call;
        }

        public Stack<CallItem> CallStack
        {
            get
            {
                return callStack;
            }
        }


        public void RegisterVisualObject(VisualObject vo)
        {
            storyboardObjects.Add(vo);
        }

        public Random Random
        {
            get
            {
                return random;
            }
        }

        public Scope GlobalScope
        {
            get
            {
                return globalScope;
            }
        }

        public StringBuilder StoryboardCode
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("//Background and Video events\r\n");

                // sort all sbObjects: 1. layer, 2. priority
                storyboardObjects.Sort();

                int layer = -1;
                foreach (VisualObject storyboardObject in storyboardObjects)
                {
                    while (layer < storyboardObject.LayerToInt())
                    {
                        layer++;
                        switch (layer)
                        {
                            case 0: sb.Append("//Storyboard Layer 0 (Background)\r\n"); break;
                            case 1: sb.Append("//Storyboard Layer 1 (Fail)\r\n"); break;
                            case 2: sb.Append("//Storyboard Layer 2 (Pass)\r\n"); break;
                            case 3: sb.Append("//Storyboard Layer 3 (Foreground)\r\n"); break;
                        }
                    }
                    storyboardObject.GenerateSbCode(sb);
                }

                while (layer < 3)
                {
                    layer++;
                    switch (layer)
                    {
                        case 0: sb.Append("//Storyboard Layer 0 (Background)\r\n"); break;
                        case 1: sb.Append("//Storyboard Layer 1 (Fail)\r\n"); break;
                        case 2: sb.Append("//Storyboard Layer 2 (Pass)\r\n"); break;
                        case 3: sb.Append("//Storyboard Layer 3 (Foreground)\r\n"); break;
                    }
                }

                sb.Append("//Storyboard Sound Samples");

                // TODO: make the storyboard code actually working
                return sb;
            }
        }

    }
}
