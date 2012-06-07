using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;


namespace SGL.Nodes.Values
{
    class LookupNode : AbstractNode
    {
        private AbstractNode expression;
        private List<AbstractNode> indexes;

        public LookupNode(AbstractNode e, List<AbstractNode> i)
        {
            expression = e;
            indexes = i;
        }

        protected override Value Invoke()
        {

            Value value = expression.Evaluate();

            List<Value> indexValues = new List<Value>();

            foreach (AbstractNode indexNode in indexes)
            {
                indexValues.Add(indexNode.Evaluate());
            }

            foreach (Value index in indexValues)
            {

                if (!index.TypeEquals(ValType.Integer))
                {
                    throw new CompilerException(Line, 214, index.TypeString);
                }
                else if (value.Type != ValType.List /* || value.IsString()*/)
                {
                    throw new CompilerException(Line, 215, value.TypeString);
                }

                int idx = index.IntValue;
                value = value.ListValue[idx];
            }

            return value;
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
