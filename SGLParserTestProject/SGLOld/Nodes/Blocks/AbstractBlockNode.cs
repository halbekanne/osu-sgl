using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Blocks
{
    /// <summary>
    /// Abstract class for all nodes which will eventually execute a block (under certain conditions).
    /// </summary>
    class AbstractBlockNode : INode
    {
        private INode block;

        protected Value ExecuteBlock()
        {
            return block.Evaluate();
        }

        public Value Evaluate()
        {
            throw new NotImplementedException();
        }

        public int GetLine()
        {
            throw new NotImplementedException();
        }
    }
}
