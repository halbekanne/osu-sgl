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
using System.Diagnostics;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using SGL.Antlr;
using SGL.Elements;

namespace SGL
{
    /// <summary>
    /// The main compiler class for SGL. Use it for creating osu! storyboard code out of SGL code.
    /// </summary>
    /// <remarks>
    /// In order to create storyboard code, simply call the <c>Run</c> method and pass SGL code as input.
    /// <example>
    /// <code>
    /// SGL.Compiler compiler = new SGL.Compiler();
    /// String sbCode = compiler.Run(sglCode);
    /// </code>
    /// </example>
    /// </remarks>
    public class Compiler
    {
        private Boolean timeRecording = true;
        private String treeString = "undefined";

        /// <summary>
        /// Compiles SGL code into osu! storyboard code.
        /// </summary>
        /// <param name="input">A string containing SGL code.</param>
        /// <returns>A string containing osu! storyboard code.</returns>
        /// <exception cref="CompilerException">Throws when the passed SGL code contains syntax or runtime exceptions.</exception>
        /// <exception cref="UnexpectedException">Throws when unexpected Exceptions occured during the parsing process.</exception>
        /// <seealso cref="System.String"/>
        public String Run(String input)
        {
            try
            {
                //Console.WriteLine("Input:" + input);
                // Step 1: Converting the input stream into tokens
                CommonTokenStream tokens = GenerateTokens(input);

                // Preparation: Clearing the GlobalMemory
                Clear();

                //Console.WriteLine("Tokens:" + tokens.ToString());
                // Step 2: Converting the tokens into a tree
                CommonTreeNodeStream tree = GenerateTree(tokens);

                // Step 3: Compiling the tree into storyboard code
                String output = GenerateStoryboardCode(tree);
                String debug = GlobalMemory.Instance.DebugString;

                if (!debug.Equals(""))
                {
                    output = "Debug:\r\n" + debug + "\r\nStoryboard:\r\n" + output;
                }


                return output;
            }
            catch (CompilerException sce)
            {
                throw sce;
            }
            catch (Exception ex)
            {
                /*
                ErrorReporter errObj = new ErrorReporter(ex, input, treeString);
                Thread errorReporter = new Thread(errObj.DoWork);
                errorReporter.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                errorReporter.Start();*/
                Console.WriteLine("-----------------------------------------------------------------------");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }

        /// <summary>
        /// Sets the option to print out some information about the compiling speed in the console. Should be for testing purposes only.
        /// </summary>
        /// <param name="timeRecording"></param>
        /// <seealso cref="Stopwatch"/>
        public void SetTimeRecording(Boolean timeRecording)
        {
            this.timeRecording = timeRecording;
        }

        /// <summary>
        /// Returns a string representation of the parsed tree.
        /// </summary>
        /// <returns></returns>
        public String GetTreeString()
        {
            return treeString;
        }


        private CommonTokenStream GenerateTokens(String input)
        {
            try
            {
                Stopwatch timeNeeded = timeRecording ? new Stopwatch() : null;
                if (timeRecording) timeNeeded.Start();

                // Lexer: Converting the string into tokens

                var lexer = new SGLLexer(new ANTLRStringStream(input));

                var tokenStream = new CommonTokenStream(lexer);

                if (timeRecording)
                {
                    timeNeeded.Stop();
                    Console.WriteLine("Time needed for converting the string into tokens: " +
                                      timeNeeded.ElapsedMilliseconds + " ms (" + timeNeeded.Elapsed + ")");
                }
                return tokenStream;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        private CommonTreeNodeStream GenerateTree(CommonTokenStream input)
        {
            Stopwatch timeNeeded = timeRecording ? new Stopwatch() : null;
            if (timeRecording) timeNeeded.Start();

            // Treewalker: Compiling the abstract syntax tree to storyboard code
            var parser = new SGLParser(input);
            var ast = (CommonTree) parser.main().Tree;
            treeString = ast.ToStringTree();
            var astStream = new CommonTreeNodeStream(ast);

            // Saving the methods for the treewalker
            /*this.methods = parser.methods;
            this.objectMethods = parser.objectMethods;*/

            // Print tree
            Console.WriteLine("Tree:" + ast.ToStringTree());

            if (timeRecording)
            {
                timeNeeded.Stop();
                Console.WriteLine("Time needed for converting the tokens into a tree: " + timeNeeded.ElapsedMilliseconds +
                                  " ms (" + timeNeeded.Elapsed + ")");
            }
            return astStream;
        }


        private String GenerateStoryboardCode(CommonTreeNodeStream input)
        {
            Stopwatch timeNeeded = timeRecording ? new Stopwatch() : null;
            if (timeRecording) timeNeeded.Start();

            // Parser: Converting the tokens into an abstract syntax tree
            var treewalker = new SGLTreeWalker(input, true);
            treewalker.main().Evaluate();
            //String output = treewalker.GetStoryboardCode().ToString();
            String output = GlobalMemory.Instance.StoryboardCode.ToString();

            if (timeRecording)
            {
                timeNeeded.Stop();
                Console.WriteLine("Time needed for converting the tree into storyboard code: " +
                                  timeNeeded.ElapsedMilliseconds + " ms (" + timeNeeded.Elapsed + ")");
            }
            return output;
        }


        private void Clear()
        {
            GlobalMemory.Clear();
            /*
            // get the library
            Global library = Global.GetInstance();

            // empty library
            library.Empty();

            // register methods
            library.RegisterMethod();*/
        }
    }
}