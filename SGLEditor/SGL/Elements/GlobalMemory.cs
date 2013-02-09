//  Storyboard Generation Language
//  Copyright (C) 2013 Dominik Halfkann
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;
using System.Collections.Generic;
using System.Text;
using SGL.Library.Functions;
using SGL.Storyboard.Generators;

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
        private readonly List<AbstractGenerator> storyboardGenerators = new List<AbstractGenerator>();
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
                var storyboardCode = new StringBuilder();

                storyboardCode.Append("[Events]\r\n");
                storyboardCode.Append("//Background and Video events\r\n");
                foreach (AbstractGenerator storyboardGenerator in storyboardGenerators)
                {
                    storyboardGenerator.GenerateBackgroundVideoEvents(storyboardCode);
                }

                storyboardCode.Append("//Storyboard Layer 0 (Background)\r\n");
                foreach (AbstractGenerator storyboardGenerator in storyboardGenerators)
                {
                    storyboardGenerator.GenerateBackgroundSection(storyboardCode);
                }

                storyboardCode.Append("//Storyboard Layer 1 (Fail)\r\n");
                foreach (AbstractGenerator storyboardGenerator in storyboardGenerators)
                {
                    storyboardGenerator.GenerateFailSection(storyboardCode);
                }

                storyboardCode.Append("//Storyboard Layer 2 (Pass)\r\n");
                foreach (AbstractGenerator storyboardGenerator in storyboardGenerators)
                {
                    storyboardGenerator.GeneratePassSection(storyboardCode);
                }

                storyboardCode.Append("//Storyboard Layer 3 (Foreground)\r\n");
                foreach (AbstractGenerator storyboardGenerator in storyboardGenerators)
                {
                    storyboardGenerator.GenerateForegroundSection(storyboardCode);
                }

                storyboardCode.Append("//Storyboard Sound Samples\r\n");
                foreach (AbstractGenerator storyboardGenerator in storyboardGenerators)
                {
                    storyboardGenerator.GenerateSoundSamples(storyboardCode);
                }

                // TODO: make the storyboard code actually working
                return storyboardCode;
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


        public void RegisterStoryboardGenerator(AbstractGenerator generator)
        {
            storyboardGenerators.Add(generator);
        }
    }
}