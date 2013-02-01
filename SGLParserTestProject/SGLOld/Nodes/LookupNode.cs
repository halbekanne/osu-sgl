using System;
using System.Collections.Generic;
using System.Text;
using SGLOld.Types;

namespace SGLOld.Nodes
{
    class LookupNode : INode
    {
        private INode expression;
        private List<INode> indexes;

        public LookupNode(INode e, List<INode> i)
        {
            expression = e;
            indexes = i;
        }

        public Value Evaluate() {

            try
            {
                Value value = expression.Evaluate();

                List<Value> indexValues = new List<Value>();

                foreach (INode indexNode in indexes)
                {
                    indexValues.Add(indexNode.Evaluate());
                }

                foreach (Value index in indexValues)
                {

                    if (!index.IsNumber() || !(value.IsList()/* || value.IsString()*/))
                    {
                        throw new CompilerException(GetLine(), "illegal expression", "illegal expresson '" + expression + "[" + index + "]" + "'");
                    }

                    int idx = index.AsInteger();

                    if (value.IsList())
                    {
                        value = value.AsList()[idx];
                    }
                    /*else if(value.isString()) {
                        value = new SGLValue(String.valueOf(value.asString().charAt(idx)));
                    }*/
                }

                return value;


            }
            catch (CompilerException sce)
            {
                sce.Line = GetLine();
                throw sce;
            }

            return Value.VOID;
        }

        public int GetLine()
        {
            return expression.GetLine();
        }

    }
}
