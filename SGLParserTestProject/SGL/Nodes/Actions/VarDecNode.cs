using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Actions
{
    class VarDecNode : AbstractNode
    {
        private String identifier;
        private Scope scope;
        private int line;

        public VarDecNode(String identifier, Scope scope, int line)
        {
            this.identifier = identifier;
            this.scope = scope;
            this.line = line;
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
                Value newValue = new Value(value.IntValue - 1, ValType.Integer);
                scope.Assign(identifier, newValue);
                return newValue;
            }

            // double  
            else if (value.Type == ValType.Double)
            {
                Value newValue = new Value(value.DoubleValue - 1, ValType.Double);
                scope.Assign(identifier, newValue);
                return newValue;
            }
            else
            {
                throw new CompilerException(Line, 216, "Integer/Double", value.TypeString);
            }
        }

        public override int Line
        {
            get
            {
                // -1 could be returned here if no argument was given, but the line number will be retrieved later
                return line;
            }
        }

    }
}
