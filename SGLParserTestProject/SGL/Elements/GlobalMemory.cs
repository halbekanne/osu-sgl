using System;
using System.Collections.Generic;
using System.Text;
using SGL.Library.Functions;
using SGL.Storyboard;

namespace SGL.Elements
{
    /// <summary>
    /// Singleton containing methods which can be used in SGL
    /// </summary>
    internal class GlobalMemory
    {
        private static GlobalMemory instance = new GlobalMemory();

        private readonly Stack<CallItem> callStack = new Stack<CallItem>();
        private readonly Dictionary<string, Function> functions = new Dictionary<string, Function>();
        private readonly Scope globalScope = new Scope();
        private readonly Random random = new Random();
        private readonly List<VisualGenerator> storyboardObjects = new List<VisualGenerator>();
        private String currentCall = "main";

        private String debug = "";

        private GlobalMemory()
        {
        }

        public static GlobalMemory Instance
        {
            get { return instance; }
        }

        public String DebugString
        {
            get { return debug; }
        }

        public String CurrentCall
        {
            get { return currentCall; }
        }

        public Stack<CallItem> CallStack
        {
            get { return callStack; }
        }

        public Random Random
        {
            get { return random; }
        }

        public Scope GlobalScope
        {
            get { return globalScope; }
        }

        public StringBuilder StoryboardCode
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append("//Background and Video events\r\n");

                // sort all sbObjects: 1. layer, 2. priority
                storyboardObjects.Sort();

                int layer = -1;
                foreach (VisualGenerator storyboardObject in storyboardObjects)
                {
                    while (layer < storyboardObject.LayerToInt())
                    {
                        layer++;
                        switch (layer)
                        {
                            case 0:
                                sb.Append("//Storyboard Layer 0 (Background)\r\n");
                                break;
                            case 1:
                                sb.Append("//Storyboard Layer 1 (Fail)\r\n");
                                break;
                            case 2:
                                sb.Append("//Storyboard Layer 2 (Pass)\r\n");
                                break;
                            case 3:
                                sb.Append("//Storyboard Layer 3 (Foreground)\r\n");
                                break;
                        }
                    }
                    storyboardObject.GenerateSbCode(sb);
                }

                while (layer < 3)
                {
                    layer++;
                    switch (layer)
                    {
                        case 0:
                            sb.Append("//Storyboard Layer 0 (Background)\r\n");
                            break;
                        case 1:
                            sb.Append("//Storyboard Layer 1 (Fail)\r\n");
                            break;
                        case 2:
                            sb.Append("//Storyboard Layer 2 (Pass)\r\n");
                            break;
                        case 3:
                            sb.Append("//Storyboard Layer 3 (Foreground)\r\n");
                            break;
                    }
                }

                sb.Append("//Storyboard Sound Samples");

                // TODO: make the storyboard code actually working
                return sb;
            }
        }

        public static void Clear()
        {
            instance = new GlobalMemory();
        }

        public void debugAddLine(String line)
        {
            debug += line + "\r\n";
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


        public void RegisterVisualObject(VisualGenerator vo)
        {
            storyboardObjects.Add(vo);
        }
    }
}