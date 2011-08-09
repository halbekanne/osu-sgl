using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class IdentifierNode : SGLNode
    {
        private String identifier;
        private Scope scope;

        public IdentifierNode(String identifier, Scope scope)
        {
            this.identifier = identifier;
            this.scope = scope;
        }

        public SGLValue Evaluate()
        {

            SGLValue value = scope.Resolve(identifier);
            if (value == null)
            {
                throw new Exception("no such variable: " + this);
            }

            return value;
        }


        public String ToString()
        {
            return identifier;
        }


    }
}
