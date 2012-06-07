using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Values
{
    class IdentifierNode : AbstractNode
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

        protected override Value Invoke()
        {

            Value value = scope.Resolve(identifier);
            if (value == null)
            {
                throw new CompilerException(Line, 211, identifier);
            }

            return value;
        }


        public override int Line
        {
            get
            {
                return line;
            }
        }


    }
}
