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
using SGL.Elements;

namespace SGL.Nodes
{
    /// <summary>
    /// Interface for all kind of nodes. Nodes are classes which hold other nodes. 
    /// Their purpose is to perform a specific action to their children nodes and then return a value. This value can then be used by their parent nodes to perform another action and so forth.
    /// </summary>
    internal abstract class AbstractNode
    {
        /// <summary>
        /// Retrieves the line number from the corresponding code for this node. Very important for troubleshooting!
        /// It will try to get the line from lexer tokens.
        /// </summary>
        /// <returns>Returns the line number.</returns>
        public abstract int Line { get; }

        /// <summary>
        /// Evaluates this node which normally causes underlying nodes to evaluate first. The returning value can then be used by the parent nodes.
        /// This method is sealed because subclasses should allways override Invoke() instead!
        /// </summary>
        /// <returns>Returns the result of the evaluation.</returns>
        public Value Evaluate()
        {
            try
            {
                return Invoke();
            }
            catch (CompilerException ce)
            {
                if (ce.Line < 1)
                {
                    ce.Line = Line;
                }
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured at line " + Line);
                throw;
            }
        }

        protected abstract Value Invoke();
    }
}