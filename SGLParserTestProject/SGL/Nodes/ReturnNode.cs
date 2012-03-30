using System;
using System.Collections.Generic;
using System.Text;
using SGL.Types;

namespace SGL.Nodes
{
    class ReturnNode : INode
    {
        private INode expression;

        public ReturnNode(INode expression)
        {
            this.expression = expression;
        }

        public Value Evaluate()
        {
            Value exprVal = expression.Evaluate();
            return new Value(new ReturnValue(exprVal));
        }

        public int GetLine()
        {
            return expression.GetLine();
        }



    }
}
