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
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using SGL.Antlr;
using SGL.Elements;
using SGL.Nodes;

namespace SGL.Tests
{
    internal class Unit
    {
        private readonly bool debug;
        private readonly String input;
        private readonly String name;
        private readonly String output;
        private String realOutput = "";

        public Unit(String name, String input, String output)
        {
            this.name = name;
            this.input = input;
            this.output = output;
        }

        public Unit(String name, String input, String output, bool debug)
            : this(name, input, output)
        {
            this.debug = debug;
        }

        public String GetInput()
        {
            return input;
        }

        public String GetOutput()
        {
            return output;
        }

        public String GetRealOutput()
        {
            return realOutput;
        }

        public String GetName()
        {
            return name;
        }


        public Boolean RunTest()
        {
            try
            {
                GlobalMemory.Clear();

                var sStream = new ANTLRStringStream(input);
                var lexer = new SGLLexer(sStream);

                var tStream = new CommonTokenStream(lexer);

                // Parsing
                var parser = new SGLParser(tStream);
                var t = (CommonTree) parser.main().Tree;

                // Printing tree
                Console.WriteLine("; " + t.ToStringTree());

                // TreeWalking
                var treeStream = new CommonTreeNodeStream(t);

                var tw = new SGLTreeWalker(treeStream, true);
                AbstractNode returned = tw.main();
                returned.Evaluate();

                if (debug)
                {
                    realOutput = GlobalMemory.Instance.DebugString;
                }
                else
                {
                    realOutput = GlobalMemory.Instance.StoryboardCode.ToString();
                }

                // comparison
                realOutput = realOutput.Trim();
                output.Trim();

                if (output.Equals(realOutput))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (CompilerException ce)
            {
                Console.WriteLine(ce.GetExceptionAsString());
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Es ist ein Fehler aufgetreten.");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }
    }
}