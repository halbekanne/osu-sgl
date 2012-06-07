using System;
using System.Collections.Generic;

using System.Text;
using SGL.Storyboard;

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

    }
}
