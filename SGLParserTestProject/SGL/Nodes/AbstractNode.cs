using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes
{
    /// <summary>
    /// Interface for all kind of nodes. Nodes are classes which hold other nodes. 
    /// Their purpose is to perform a specific action to their children nodes and then return a value. This value can then be used by their parent nodes to perform another action and so forth.
    /// </summary>
    public abstract class AbstractNode
    {
        /// <summary>
        /// Evaluates this node which normally causes underlying nodes to evaluate first. The returning value can then be used by the parent nodes.
        /// This method is sealed because subclasses should allways override Invoke() instead!
        /// </summary>
        /// <returns>Returns the result of the evaluation.</returns>
        public sealed Value Evaluate()
        {
            try
            {
                return Invoke();
            }
            catch (CompilerException ce)
            {
                if (ce.Line == null || ce.Line <= 0)
                {
                    ce.Line = this.Line;
                }
                throw ce;
            }
        }

        abstract protected Value Invoke();

        /// <summary>
        /// Retrieves the line number from the corresponding code for this node. Very important for troubleshooting!
        /// It will try to get the line from lexer tokens.
        /// </summary>
        /// <returns>Returns the line number.</returns>
        abstract public int Line { get; }
    }
}
