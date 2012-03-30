using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes.StaticMethod
{
    class PrintlnNode : INode
    {
        private StringBuilder sb;
        private Value expression;

        public PrintlnNode(StringBuilder sb, Value expression)
        {
            this.sb = sb;
            this.expression = expression;
        }

        public Value Evaluate()
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
                throw new CompilerException(GetLine(), "type mismatch", "cannot convert from " + expression.GetType() + " to string");
            }

            return Value.VOID;
  
        }

        public int GetLine()
        {
            return -1;
        }

    }
}
