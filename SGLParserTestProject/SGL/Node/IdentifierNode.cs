using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class IdentifierNode : SGLNode
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

        public SGLValue Evaluate()
        {

            SGLValue value = scope.Resolve(identifier);
            if (value == null)
            {
                throw new SGLCompilerException(GetLine(), "unknown variable","'" + identifier + "' cannot be resolved to a variable");
                
            }

            return value;
        }


        public int GetLine()
        {
            return this.line;
        }


    }
}
