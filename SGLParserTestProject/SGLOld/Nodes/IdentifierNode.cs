using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes
{
    class IdentifierNode : INode
    {
        private String identifier;
        private Scope scope;
        private int line;

        public IdentifierNode(String identifier, Scope scope, int line)
        {
            this.identifier = identifier;
            this.scope = scope;
            this.line = line;
        }

        public Value Evaluate()
        {

            Value value = scope.Resolve(identifier);
            if (value == null)
            {
                throw new CompilerException(GetLine(), 211, new String[] { identifier });
            }

            return value;
        }


        public int GetLine()
        {
            return this.line;
        }


    }
}
