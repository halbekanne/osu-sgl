using System;
using SGL.Elements;

namespace SGL.Nodes.Values
{
    internal class IdentifierNode : AbstractNode
    {
        private readonly String identifier;
        private readonly int line;
        private readonly Scope scope;

        public IdentifierNode(String identifier, Scope scope, int line)
        {
            this.identifier = identifier;
            this.scope = scope;
            this.line = line;
        }


        public override int Line
        {
            get { return line; }
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
    }
}