using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node.StaticMethod
{
    class PrintlnNode : SGLNode
    {
        private StringBuilder sb;
        private SGLValue expression;

        public PrintlnNode(StringBuilder sb, SGLValue expression)
        {
            this.sb = sb;
            this.expression = expression;
        }

        public SGLValue Evaluate()
        {
            if (expression.IsString())
            {
                sb.Append(expression.AsString() + "\r\n");
            }
            else if (expression.IsInteger())
            {
                sb.Append(expression.AsInteger().ToString(System.Globalization.CultureInfo.InvariantCulture) + "\r\n");
            }
            else if (expression.IsFloat())
            {
                sb.Append(expression.AsFloat().ToString(System.Globalization.CultureInfo.InvariantCulture) + "\r\n");
            }
            else if (expression.IsBoolean())
            {
                sb.Append(expression.AsBoolean().ToString(System.Globalization.CultureInfo.InvariantCulture) + "\r\n");
            }
            else
            {
                throw new SGLCompilerException(GetLine(), "type mismatch", "cannot convert from " + expression.GetVarType() + " to string");
            }

            return SGLValue.VOID;
  
        }

        public int GetLine()
        {
            return -1;
        }

    }
}
