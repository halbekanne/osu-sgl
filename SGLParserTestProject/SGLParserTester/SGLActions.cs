using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld
{
    /// <summary>
    /// This class handles all actions the SGLTreeWalker will invoke. It saves Variables and does all the technical SGL stuff.
    /// </summary>
    class SGLActions
    {
        // Memory for saving global variables
        VariableScope globalVariables = new VariableScope();

        // Stack-Memory for local variables, at the beginning of each code-block, a dic for variables is pushed and at the end, it will be popped again.
        Stack<VariableScope> localVariables = new Stack<VariableScope>();



        public SGLActions()
        {
            // Push a dic for local variables
            localVariables.Push(new VariableScope());
        }

        /// <summary>
        /// Creates a new local variable
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void NewLocalVariable(String type, String name, String value)
        {
            //Console.WriteLine("Push local variable: " + type + "," + name + "," + value);
            VariableScope currentDic = localVariables.Pop();
            currentDic.AddVariable(type,name,value);
            localVariables.Push(currentDic);
        }

        /// <summary>
        /// Creates a new local variable
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public void AssignVariable(String name, String value)
        {
            //Console.WriteLine("Assign variable: "  + name + " = " + value);
            foreach (VariableScope searchDic in localVariables)
            {
                if (searchDic.IsVariable(name))
                {
                    // If the variable is in the scope
                    searchDic.ChangeVariable(name, value);


                    break;
                }
                
            }
        }



        /// <summary>
        /// Searches for a local variable
        /// </summary>
        /// <param name="name"></param>
        public String GetVariable(String name)
        {
            //Console.WriteLine("Try to get variable: " + name);
            foreach (VariableScope searchDic in localVariables)
            {
                try
                {
                    String value = searchDic.GetVariable(name);
                    return value;
                }
                catch (Exception e)
                {
                }
            }
            throw new Exception("Variable " + name + " coudn't be found");
        }



        // Expression/Math Actions
        /// <summary>
        /// Add 2 numbers, stored in Strings
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public String Add(String a, String b)
        {
            if (IsInteger(a) && IsInteger(b))
            {
                // Both values are integers
                int va = Int32.Parse(a);
                int vb = Int32.Parse(b);
                return (va + vb).ToString();
            }
            throw new Exception("Unable to add " + a + " and " + b + " together");
        }



        public String Sub(String a, String b)
        {
            if (IsInteger(a) && IsInteger(b))
            {
                // Both values are integers
                int va = Int32.Parse(a);
                int vb = Int32.Parse(b);
                return (va - vb).ToString();
            }
            throw new Exception("Unable to subtract " + a + " from " + b);
        }


        public String Mult(String a, String b)
        {
            if (IsInteger(a) && IsInteger(b))
            {
                // Both values are integers
                int va = Int32.Parse(a);
                int vb = Int32.Parse(b);
                return (va * vb).ToString();
            }
            throw new Exception("Unable to multiply " + a + " with " + b);
        }

        public String Div(String a, String b)
        {
            if (IsInteger(a) && IsInteger(b))
            {
                // Both values are integers
                int va = Int32.Parse(a);
                int vb = Int32.Parse(b);
                return (va / vb).ToString();
            }
            throw new Exception("Unable to divide " + a + " through " + b);
        }

        public String Remainder(String a, String b)
        {
            if (IsInteger(a) && IsInteger(b))
            {
                // Both values are integers
                int va = Int32.Parse(a);
                int vb = Int32.Parse(b);
                return (va % vb).ToString();
            }
            throw new Exception("Unable to divide " + a + " through " + b + " and return the remaining value");
        }

        public String ConditionLess(String a, String b)
        {
            if (IsInteger(a) && IsInteger(b))
            {
                // Both values are integers
                int va = Int32.Parse(a);
                int vb = Int32.Parse(b);
                return va < vb ? "true" : "false";
            }
            throw new Exception("Unable check if " + a + " is less than " + b);
        }

        public String ConditionLessOrEqual(String a, String b)
        {
            if (IsInteger(a) && IsInteger(b))
            {
                // Both values are integers
                int va = Int32.Parse(a);
                int vb = Int32.Parse(b);
                return va <= vb ? "true" : "false";
            }
            throw new Exception("Unable check if " + a + " is less than or equal to " + b);
        }

        public String ConditionGreater(String a, String b)
        {
            if (IsInteger(a) && IsInteger(b))
            {
                // Both values are integers
                int va = Int32.Parse(a);
                int vb = Int32.Parse(b);
                return va > vb ? "true" : "false";
            }
            throw new Exception("Unable check if " + a + " is greater than " + b);
        }

        public String ConditionGreaterOrEqual(String a, String b)
        {
            if (IsInteger(a) && IsInteger(b))
            {
                // Both values are integers
                int va = Int32.Parse(a);
                int vb = Int32.Parse(b);
                return va >= vb ? "true" : "false";
            }
            throw new Exception("Unable check if " + a + " is greater than or equal to " + b);
        }

        public String ConditionEqual(String a, String b)
        {
            if (IsInteger(a) && IsInteger(b))
            {
                // Both values are integers
                int va = Int32.Parse(a);
                int vb = Int32.Parse(b);
                return va == vb ? "true" : "false";
            }
            throw new Exception("Unable check if " + a + " is equal to " + b);
        }

        public String ConditionNotEqual(String a, String b)
        {
            if (IsInteger(a) && IsInteger(b))
            {
                // Both values are integers
                int va = Int32.Parse(a);
                int vb = Int32.Parse(b);
                return va != vb ? "true" : "false";
            }
            throw new Exception("Unable check if " + a + " is not equal to " + b);
        }

        public String ConditionBranch(String a, String b, String c)
        {
            if (IsBoolean(a))
            {
                // First value is a boolean value
                return Boolean.Parse(a) ? b : c;
            }
            throw new Exception("Unable check if " + a + " is true or false");
        }

        public String ConnectiveAnd(String a, String b)
        {
            if (IsBoolean(a) && IsBoolean(b))
            {
                // Both values are boolean values
                return (Boolean.Parse(a) && Boolean.Parse(b)).ToString();
            }
            throw new Exception("Unable check connect " + a + " AND " + b);
        }

        public String ConnectiveOr(String a, String b)
        {
            if (IsBoolean(a) && IsBoolean(b))
            {
                // Both values are boolean values
                return (Boolean.Parse(a) || Boolean.Parse(b)).ToString();
            }
            throw new Exception("Unable check connect " + a + " OR " + b);
        }








        // Convertion and value checking


        /// <summary>
        /// Checks if a given string can be converted to an integer value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private Boolean IsInteger(String a)
        {
            try
            {
                Int32 value = Int32.Parse(a);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a given string can be converted to a double value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private Boolean IsFloat(String a) 
        {
            try
            {
                Double value = Double.Parse(a);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        /// <summary>
        /// Checks if a given string can be converted to a boolean value.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        private Boolean IsBoolean(String a)
        {
            try
            {
                Boolean value = Boolean.Parse(a);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }



    }
}
