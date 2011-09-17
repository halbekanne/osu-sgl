using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    public class SGLCompilerException : Exception
    {
        public int Line;
        public String ErrorType;
        new public String Message;

        public SGLCompilerException(int line, String errorType, String message)
        {
            this.Line = line;
            this.ErrorType = errorType;
            this.Message = message;
        }

        public String ToString()
        {
            if (this.ErrorType.Equals("Antlr.Parser"))
            {
                return "Error (wrong syntax) on " + this.Message;
            }
            else
            {
                return "Error (" + this.ErrorType + ") on line " + this.Line + ": " + this.Message;
            }
        }

    }
}
