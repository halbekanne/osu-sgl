using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes
{
    class VarIncNode : INode
    {
        private String identifier;
        private Scope scope;
        private int line;

        public VarIncNode(String identifier, Scope scope, int line)
        {
            this.identifier = identifier;
            this.scope = scope;
            this.line = line;
        }

        public Value Evaluate()
        {

            // Resolve value
            Value value = scope.Resolve(identifier);
            if (value == null)
            {
                throw new CompilerException(GetLine(), "unknown variable", "'" + value + "' cannot be resolved to a variable");
            }


            // integer  
            if (value.IsInteger())
            {
                Value newValue = new Value(value.AsInteger() + 1);
                scope.Assign(identifier, newValue);
                return newValue;
            }

            // float  
            if (value.IsFloat())
            {
                Value newValue = new Value(value.AsFloat() + 1);
                scope.Assign(identifier, newValue);
                return newValue;
            }

            throw new CompilerException(GetLine(), "type mismatch", "cannot convert from " + value.GetType() + " to int");
        }

        public int GetLine()
        {
            return line;
        }

    }
}
