using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes.Operators.Logical
{
    class NotEqualsNode : AbstractBinaryOperatorNode
    {
        public NotEqualsNode(AbstractNode node1, AbstractNode node2) : base(node1, node2) { }

        public override String GetName()
        {
            return "!=";
        }

        public override bool CheckArguments(ValType type1, ValType type2)
        {
            return true;
        }

        public override Value Operate(Value value1, Value value2, ValType type1, ValType type2)
        {
            return new Value(!value1.Equals(value2));
        }
    }
}
