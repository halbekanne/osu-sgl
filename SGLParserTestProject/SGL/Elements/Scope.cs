using System;
using System.Collections.Generic;

namespace SGL.Elements
{
    public class Scope
    {
        private readonly Scope parent;
        private int offset;
        private Dictionary<String, Value> variables; // = new Dictionary<String, SGLValue>();

        public Scope()
        {
            // only for the main scope, the parent is null  
            parent = null;
            variables = new Dictionary<String, Value>();
        }

        public Scope(Scope p)
        {
            parent = p;
            variables = new Dictionary<String, Value>();
            offset = p.Offset;
        }

        public int Offset
        {
            get { return offset; }
            set { offset = value; }
        }

        public Scope Parent
        {
            get { return parent; }
        }

        public void ClearOffset()
        {
            offset = 0;
        }

        /// <summary>
        /// Define a variable for the first time.
        /// </summary>
        /// <param name="varName"></param>
        public void Define(String varName)
        {
            if (Resolve(varName) != null)
            {
                // the variable was already declared
                throw new CompilerException(-1, 219, varName);
            }
            else
            {
                variables.Add(varName, Value.NULL);
            }
        }

        /// <summary>
        /// Assign a value to an already defined variable.
        /// </summary>
        /// <param name="varName"></param>
        /// <param name="value"></param>
        public void Assign(String varName, Value value)
        {
            if (variables.ContainsKey(varName))
            {
                variables[varName] = value;
            }
            else if (HasParent())
            {
                // The variable was not declared in this scope, so let  
                // the parent scope re-assign it  
                parent.Assign(varName, value);
            }
            else
            {
                // The variable was not declared at all
                throw new CompilerException(-1, 218, varName);
            }
        }

        /// <summary>
        /// Resolves the value to a parameter name. May return null.
        /// </summary>
        /// <param name="var"></param>
        /// <returns></returns>
        public Value Resolve(String var)
        {
            Value value;
            variables.TryGetValue(var, out value);
            if (value != null)
            {
                // The variable resides in this scope  
                return value;
            }
            else if (HasParent())
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

        public Boolean HasParent()
        {
            return parent != null;
        }

        public int CountParents()
        {
            Scope current = this;
            int parentNum = 0;
            while (current.parent != null)
            {
                parentNum++;
                current = current.parent;
            }
            return parentNum;
        }

        public void Clear()
        {
            variables = new Dictionary<String, Value>();
        }
    }
}