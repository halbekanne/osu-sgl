using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Operators.Arithmetical
{
    class SubNode : INode
    {
        private INode lhs;
        private INode rhs;

        public SubNode(INode lhs, INode rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public Value Evaluate()
        {

            Value a = lhs.Evaluate();
            Value b = rhs.Evaluate();

            // number + number  
            if (a.IsInteger() && b.IsInteger())
            {
                return new Value(a.AsInteger() - b.AsInteger());
            }

            // float + number / number + float  
            if (a.IsNumber() && b.IsNumber())
            {
                return new Value(a.AsFloat() - b.AsFloat());
            }

            throw new CompilerException(GetLine(), "operator undefined", "the operator '-' is undefined for the argument types '" + a.GetType() + ", " + b.GetType() + "'");
            
        }

        public int GetLine()
        {
            return lhs.GetLine();
        }


    }
}
