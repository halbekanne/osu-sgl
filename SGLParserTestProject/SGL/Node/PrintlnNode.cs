using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class PrintlnNode : SGLNode
    {
        private StringBuilder sb;
        private SGLNode expression;

        public PrintlnNode(StringBuilder sb, SGLNode expression)
        {
            this.sb = sb;
            this.expression = expression;
        }

        public SGLValue Evaluate()
        {
            SGLValue expr = expression.Evaluate();

            if (expr.IsString())
            {
                sb.Append(expr.AsString() + "\r\n");
            }
            else if (expr.IsInteger())
            {
                sb.Append(expr.AsInteger().ToString(System.Globalization.CultureInfo.InvariantCulture) + "\r\n");
            }
            else if (expr.IsFloat())
            {
                sb.Append(expr.AsFloat().ToString(System.Globalization.CultureInfo.InvariantCulture) + "\r\n");
            }
            else if (expr.IsBoolean())
            {
                sb.Append(expr.AsBoolean().ToString(System.Globalization.CultureInfo.InvariantCulture) + "\r\n");
            }
            else
            {
                throw new Exception("illegal println expression: " + this.ToString());
            }

            return SGLValue.VOID;
  
        }

    }
}
