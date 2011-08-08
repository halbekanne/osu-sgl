using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    class Scope
    {
        private Scope parent;
        private Dictionary<String, SGLValue> variables;// = new Dictionary<String, SGLValue>();

        public Scope()
        {
            // only for the global scope, the parent is null  
            parent = null;
            variables = new Dictionary<String, SGLValue>();
        }

        public Scope(Scope p)
        {
            parent = p;
            variables = new Dictionary<String, SGLValue>();
        }

        public void Assign(String var, SGLValue value, Boolean newVar)
        {
            if (Resolve(var) != null)
            {
                if (newVar) throw new Exception("There is already such a variable");
                // There is already such a variable, re-assign it  
                this.ReAssign(var, value);
            }
            else
            {
                if (!newVar) throw new Exception("The variable " + var + " doesn't exists.");
                // A newly declared variable  
                variables.Add(var, value);
                Console.WriteLine("Assigned new variable " + var + " = " + value.AsInteger().ToString() + " in the current variable scope.");
            }
        }

        public Scope Copy()
        {
            // Create a shallow copy of this scope. Used in case functions are  
            // recursively called. If we wouldn't create a copy in such cases,  
            // changing the variables would result in changes to the Maps from  
            // other "recursive scopes".  
            Scope s = new Scope();
            s.variables = new Dictionary<String, SGLValue>(this.variables);
            return s;
        }

        public Boolean IsGlobalScope()
        {
            return parent == null;
        }

        public Scope Parent()
        {
            return parent;
        }

        private void ReAssign(String identifier, SGLValue value)
        {
            if (variables.ContainsKey(identifier))
            {
                // The variable is declared in this scope  
                variables.Add(identifier, value);
            }
            else if (parent != null)
            {
                // The variable was not declared in this scope, so let  
                // the parent scope re-assign it  
                parent.ReAssign(identifier, value);
            }
        }


        public SGLValue Resolve(String var)
        {
            SGLValue value;
            variables.TryGetValue(var, out value);
            if (value != null)
            {
                // The variable resides in this scope  
                return value;
            }
            else if (!IsGlobalScope())
            {
                // Let the parent scope look for the variable  
                return parent.Resolve(var);
            }
            else
            {
                // Unknown variable  
                return null;
            }
        } 



    }
}
