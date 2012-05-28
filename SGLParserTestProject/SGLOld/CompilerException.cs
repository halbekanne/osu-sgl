using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld
{
    public class CompilerException : Exception
    {
        private int line = -1;
        
        private int errorCode;
        private String[] args;
        private List<TraceItem> stackTrace = new List<TraceItem>();

        private class TraceItem
        {
            public TraceItem(String call, int line)
            {
                this.call = call;
                this.line = line;
            }
            public String call
            {
                get { return call; }
                set { call = value; }
            }
            public int line
            {
                get { return line; }
                set { line = value; }
            }
        }
        /*
        public CompilerException(int line, String errorType, String message)
        {
            this.Line = line;
            this.ErrorType = errorType;
            this.Message = message;
        }*/

        public CompilerException(int line, int errorCode, params String[] args)
        {
            this.line = line;
            this.errorCode = errorCode;
            this.args = args;
        }

        private String GetErrorMessage(int errorCode, String[] args) {
            switch (errorCode) {
                // Antlr specific
                case 101: return "Wrong syntax: " + args[0];

                // Operators and variable assignments
                case 201: return "The operator " + args[0] + " is undefined for the argument type " + args[1];
                case 202: return "The operator " + args[0] + " is undefined for the argument types " + args[1] + ", " + args[2];
                case 203: return "The operator " + args[0] + " is undefined for the argument types " + args[1] + ", " + args[2] + ", " + args[3];
                case 204: return "You can't compare a value of type " + args[0] + " with a value of type " + args[1] + ", they should normally be from the same type.";
                case 205: return "You can't divide by 0 unless you are Chuck Norris";
                case 206: return "The conditional operator (? :) expexted the first argument type to be Boolean but was " + args[0];
                case 211: return args[0] + " cannot be resolved to a variable. Check if the variable name is spelled correctly.";

                // Methods and Object Methods
                case 301: return "The method " + args[0] + " doesn't exist.";
                case 302: return "The method " + args[0] + " isn't defined for that number of arguments (" + args[1] + ").";
                case 303: return "The method " + args[0] + " already exists with that number of arguments (" + args[1] + "), to register a new method with the same number of arguments would be ambiguous.";

                // Should never occur
                default: return "Unknown exception - An error message for the error code '" + errorCode + "' isn't specified.";

            }
        }

        public void SetLine(int line)
        {
            // Add line information only if previous nodes didn't add this information
            if (this.line != -1)
            {
                this.line = line;
            }
        }

        public String GetExceptionAsString()
        {
            if (this.errorCode < 200)
            {
                return GetErrorMessage(errorCode, args);
            }
            else
            {
                String trace = GetStackTrace();
                if (trace != null)
                {
                    return "Error on line " + this.line + ": " + GetErrorMessage(errorCode, args) + "\r\n" + trace;
                }
                else
                {
                    return "Error on line " + this.line + ": " + GetErrorMessage(errorCode, args);
                }
            }
        }

        public void AddToStackTrace(String call, int line)
        {
            stackTrace.Add(new TraceItem(call, line));
        }

        /// <summary>
        /// Returns a String representation of the stacktrace or null.
        /// </summary>
        /// <returns></returns>
        private String GetStackTrace()
        {
            if (stackTrace.Count > 0)
            {
                String traceRoute = "";
                foreach (TraceItem item in stackTrace) {
                    traceRoute += " arising from " + item.call + " at line " + item.line + "\r\n";
                }
                return traceRoute;
            }
            else
            {
                return null;
            }
        }

    }
}
