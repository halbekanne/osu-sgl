using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Operators.Arithmetic
{
    class MultNode : AbstractBinaryOperatorNode
    {
        public MultNode(INode node1, INode node2) : base(node1, node2) { }

        public override String GetName()
        {
            return "*";
        }

        public override bool CheckArguments(ValueType type1, ValueType type2)
        {
            return (type1 == ValueType.Integer || type1 == ValueType.Float) && (type2 == ValueType.Integer || type2 == ValueType.Float);
        }

        public override Value Operate(Value value1, Value value2, ValueType type1, ValueType type2)
        {
            if (type1 == ValueType.Float || type2 == ValueType.Float)
            {
                // 1.423 * 2; => Float
                return new Value(value1.AsFloat() * value2.AsFloat());
            }
            else
            {
                // 5 * 4; => Integer
                return new Value(value1.AsInteger() * value2.AsInteger());
            }
        }
    }
}
