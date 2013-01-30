using System;
using SGL.Elements;

namespace SGL.Nodes.Actions
{
    internal class VarDecNode : AbstractNode
    {
        private readonly String identifier;
        private readonly int line;
        private readonly Scope scope;

        public VarDecNode(String identifier, Scope scope, int line)
        {
            this.identifier = identifier;
            this.scope = scope;
            this.line = line;
        }

        public override int Line
        {
            get
            {
                // -1 could be returned here if no argument was given, but the line number will be retrieved later
                return line;
            }
        }

        protected override Value Invoke()
        {
            // Resolve value
            Value value = scope.Resolve(identifier);
            if (value == null)
            {
                throw new CompilerException(Line, 211, identifier);
            }

                // integer  
            else if (value.Type == ValType.Integer)
            {
                var newValue = new Value(value.IntValue - 1, ValType.Integer);
                scope.Assign(identifier, newValue);
                return newValue;
            }

                // double  
            else if (value.Type == ValType.Double)
            {
                var newValue = new Value(value.DoubleValue - 1, ValType.Double);
                scope.Assign(identifier, newValue);
                return newValue;
            }
            else
            {
                throw new CompilerException(Line, 216, "Integer/Double", value.TypeString);
            }
        }
    }
}