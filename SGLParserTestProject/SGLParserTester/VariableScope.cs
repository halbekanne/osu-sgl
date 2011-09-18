using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    /// <summary>
    /// Contains memory for all variable types
    /// </summary>
    class VariableScope
    {
        private Dictionary<String, int> intVars = new Dictionary<String, int>();
        private Dictionary<String, bool> boolVars = new Dictionary<String, bool>();


        public void AddVariable(String type, String name, String value) {
            if (type.Equals("int"))
            {
                // Integer
                int intValue = 0;
                try
                {
                    intValue = Convert.ToInt32(value);
                }
                catch (Exception e)
                {
                    throw new Exception("Variable " + name + " is defined as " + type + ", but " + value + " can't be converted to this variable type.");
                }
                intVars.Add(name,intValue);
            }
            else if (type.Equals("boolean"))
            {
                // Boolean
                Boolean booleanValue = false;
                try
                {
                    booleanValue = Boolean.Parse(value);
                }
                catch (Exception e)
                {
                    throw new Exception("Variable " + name + " is defined as " + type + ", but " + value + " can't be converted to this variable type.");
                }
                boolVars.Add(name, booleanValue);
            }

        }


        public void ChangeVariable(string name, string value)
        {
            if (intVars.ContainsKey(name))
            {
                // Change integer variable
                intVars[name] = Int32.Parse(value);

            }
            else if (boolVars.ContainsKey(name))
            {
                // Change integer variable
                boolVars[name] = Boolean.Parse(value);
            }
        }




        /// <summary>
        /// True if variable exists in this scope, false otherwise
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Boolean IsVariable(String name)
        {
            return intVars.ContainsKey(name) || boolVars.ContainsKey(name);
        }

        public String GetVariable(String name)
        {
            // Integer?
            try
            {
                int result;
                intVars.TryGetValue(name, out result);
                return result.ToString();
            } 
            catch (Exception e)
            {

            }

            // Boolean?
            try
            {
                bool result;
                boolVars.TryGetValue(name, out result);
                return result.ToString();
            }
            catch (Exception e)
            {

            }


            // Nothing found? Exception
            throw new Exception("Variable " + name + " coudn't be found");


            
        }


        
    }
}
