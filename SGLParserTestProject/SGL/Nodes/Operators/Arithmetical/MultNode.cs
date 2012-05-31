using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes.Operators.Arithmetical
{
    class MultNode : AbstractBinaryOperatorNode
    {
        public MultNode(AbstractNode node1, AbstractNode node2) : base(node1, node2) { }

        public override String Name
        {
            get
            {
                return "*";
            }
        }

        public override bool CheckArguments(ValType type1, ValType type2)
        {
            return (type1 == ValType.Integer || type1 == ValType.Float) && (type2 == ValType.Integer || type2 == ValType.Float);
        }

        public override Value Operate(Value value1, Value value2, ValType type1, ValType type2)
        {
            if (type1 == ValType.Float || type2 == ValType.Float)
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
