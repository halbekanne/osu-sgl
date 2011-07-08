using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
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
            Console.WriteLine("OK: init the loc. variable scope");
        }

        public void NewLocalVariable(String type, String name, String value)
        {
            Console.WriteLine("Push local variable: " + type + "," + name + "," + value);
            VariableScope currentDic = localVariables.Pop();
            currentDic.addVariable(type,name,value);
            localVariables.Push(currentDic);
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


    }
}
