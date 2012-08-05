using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Operators.Arithmetical
{
    class DivNode : AbstractBinaryOperatorNode
    {

        public DivNode(AbstractNode node1, AbstractNode node2) : base(node1, node2) { }

        protected override Value Operate(Value value1, Value value2)
        {
            if (value1.Type == ValType.Integer && value2.Type == ValType.Integer)
            {
                // 5 / 4; => Integer (1)
                if (value2.IntValue == 0)
                {
                    // division by 0
                    throw new CompilerException(-1, 205);
                }
                return new Value(value1.IntValue / value2.IntValue, ValType.Integer);
            }
            else if (value1.TypeEquals(ValType.Double) && value2.TypeEquals(ValType.Double))
            {
                // 1.423 / 2; => Float
                if (value2.DoubleValue == 0)
                {
                    // division by 0
                    throw new CompilerException(-1, 205);
                }
                return new Value(value1.DoubleValue / value2.DoubleValue, ValType.Double);
            }

            else
            {
                throw new CompilerException(Line, 202, "/", value1.TypeString, value2.TypeString);
            }
        }


    }
}
