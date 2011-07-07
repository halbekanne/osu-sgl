using System;
using System.Collections.Generic;
using System.Text;

namespace SGLParserTester
{
    /// <summary>
    /// Contains memory for all variable types
    /// </summary>
    class VariableScope
    {
        private Dictionary<string, int> intVars = new Dictionary<string, int>();
        private Dictionary<string, Boolean> boolVars = new Dictionary<string, Boolean>();


        public void addVariable(string type, string name, string value) {
            if (type.Equals("int"))
            {
                // Integer
                int intValue = Convert.ToInt32(value);
                intVars.Add(name,intValue);
            }

        }
    }
}
