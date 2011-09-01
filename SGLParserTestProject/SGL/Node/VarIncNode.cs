using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class VarIncNode : SGLNode
    {
        private String identifier;
        private Scope scope;

        public VarIncNode(String identifier, Scope scope)
        {
            this.identifier = identifier;
            this.scope = scope;
        }

        public SGLValue Evaluate()
        {

            // Resolve value
            SGLValue value = scope.Resolve(identifier);
            if (value == null)
            {
                throw new Exception("no such variable: " + this);
            }


            // integer  
            if (value.IsInteger())
            {
                SGLValue newValue = new SGLValue(value.AsInteger() + 1);
                scope.Assign(identifier, newValue, false, "");
                return newValue;
            }

            // float  
            if (value.IsFloat())
            {
                SGLValue newValue = new SGLValue(value.AsFloat() + 1);
                scope.Assign(identifier, newValue, false, "");
                return newValue;
            }

            throw new Exception("illegal expression: " + this.ToString());
        }


    }
}
