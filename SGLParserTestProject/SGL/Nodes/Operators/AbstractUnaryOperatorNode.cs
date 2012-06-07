using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Operators
{

    /// <summary>
    /// Abstract class for all kind of operators which perform an action on 1 values, e.g. negation.
    /// </summary>
    public abstract class AbstractUnaryOperatorNode : AbstractNode
    {
        private AbstractNode node;

        public AbstractUnaryOperatorNode(AbstractNode node)
        {
            this.node = node;
        }

        public abstract Value Operate(Value value, ValType type);

        public abstract bool CheckArguments(ValType type);

        protected override Value Invoke()
        {
            Value value = node.Evaluate();

            ValType type = value.Type;

            if (CheckArguments(type))
            {
                return Operate(value, type);
            }
            else
            {
                throw new CompilerException(Line, 201, Name, value.TypeString);
            }
        }

        public abstract String Name { get; }

        public override int Line {
            get
            {
                return node.Line;
            }
        }


    }
}
