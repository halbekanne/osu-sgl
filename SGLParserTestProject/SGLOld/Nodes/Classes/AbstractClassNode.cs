using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Class
{
    public abstract class AbstractClassNode : INode
    {
        private List<INode> arguments;

        protected AbstractClassNode(List<INode> arguments)
        {
            this.arguments = (arguments == null) ? new List<INode>() : arguments;
        }

        public abstract bool CheckArguments(List<ValueType> typeList);

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
