using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes.Operators.Logical
{
    class GreaterThanEqualsNode : AbstractBinaryOperatorNode
    {

        public GreaterThanEqualsNode(AbstractNode node1, AbstractNode node2) : base(node1, node2) { }

        public override String GetName()
        {
            return ">=";
        }

        public override bool CheckArguments(ValType type1, ValType type2)
        {
            return (type1 == ValType.Float || type1 == ValType.Integer) && (type2 == ValType.Float || type2 == ValType.Integer) ||
                (type1 == ValType.String && type2 == ValType.String);
        }

        public override Value Operate(Value value1, Value value2, ValType type1, ValType type2)
        {

            if ((type1 == ValType.Float || type1 == ValType.Integer) && (type2 == ValType.Float || type2 == ValType.Integer))
            {
                return new Value(value1.AsFloat() >= value2.AsFloat());
            }
            else
            {
                // Strings
                return new Value(value1.AsString().CompareTo(value2.AsString()) >= 0);
            }
           
        }
    }
}
