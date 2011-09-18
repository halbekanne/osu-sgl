using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class VarIncNode : SGLNode
    {
        private String identifier;
        private Scope scope;
        private Boolean returnValue;
        private int line;

        public VarIncNode(String identifier, Scope scope, Boolean returnValue, int line)
        {
            this.identifier = identifier;
            this.scope = scope;
            this.returnValue = returnValue;
            this.line = line;
        }

        public SGLValue Evaluate()
        {

            // Resolve value
            SGLValue value = scope.Resolve(identifier);
            if (value == null)
            {
                throw new SGLCompilerException(GetLine(), "unknown variable", "'" + value + "' cannot be resolved to a variable");
            }


            // integer  
            if (value.IsInteger())
            {
                SGLValue newValue = new SGLValue(value.AsInteger() + 1);
                scope.Assign(identifier, newValue, false, "");
                if (returnValue)
                {
                    return newValue;
                }
                else
                {
                    return SGLValue.VOID;
                }
            }

            // float  
            if (value.IsFloat())
            {
                SGLValue newValue = new SGLValue(value.AsFloat() + 1);
                scope.Assign(identifier, newValue, false, "");
                if (returnValue)
                {
                    return newValue;
                }
                else
                {
                    return SGLValue.VOID;
                }
            }

            throw new SGLCompilerException(GetLine(), "type mismatch", "cannot convert from " + value.GetVarType() + " to int");
        }

        public int GetLine()
        {
            return line;
        }

    }
}
