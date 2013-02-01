using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes
{
    /// <summary>
    /// Interface for all kind of nodes. Nodes are classes which hold other nodes. 
    /// Their purpose is to perform a specific action to their children nodes and then return a value. This value can then be used by their parent nodes to perform another action and so forth.
    /// </summary>
    public interface INode
    {
        /// <summary>
        /// Evaluates this node which normally causes underlying nodes to evaluate first. The returning value can then be used by the parent nodes.
        /// </summary>
        /// <returns>Returns the result of the evaluation.</returns>
        Value Evaluate();

        /// <summary>
        /// Retrieves the line number from the corresponding code for this node. Very important for troubleshooting!
        /// It will try to get the line from lexer tokens.
        /// </summary>
        /// <returns>Returns the line number.</returns>
        int GetLine();
    }
}
