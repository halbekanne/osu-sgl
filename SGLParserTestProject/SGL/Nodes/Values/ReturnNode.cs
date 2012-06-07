using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Values
{
    class ReturnNode : AbstractNode
    {
        private AbstractNode expression;

        public ReturnNode(AbstractNode expression)
        {
            this.expression = expression;
        }

        protected override Value Invoke()
        {
            Value exprVal = expression.Evaluate();
            return new Value(exprVal, ValType.Return);
        }

        public override int Line
        {
            get
            {
                return expression.Line;
            }
        }



    }
}
