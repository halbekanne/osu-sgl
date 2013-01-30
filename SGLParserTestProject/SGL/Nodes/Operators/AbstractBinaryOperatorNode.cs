using SGL.Elements;

namespace SGL.Nodes.Operators
{
    /// <summary>
    /// Abstract class for all kind of operators which perform an action on 2 values, e.g. addition.
    /// </summary>
    public abstract class AbstractBinaryOperatorNode : AbstractNode
    {
        private readonly AbstractNode node1;
        private readonly AbstractNode node2;

        public AbstractBinaryOperatorNode(AbstractNode node1, AbstractNode node2)
        {
            this.node1 = node1;
            this.node2 = node2;
        }

        public override int Line
        {
            get { return node1.Line; }
        }

        protected abstract Value Operate(Value value1, Value value2);

        //public abstract bool CheckArguments(ValType type1, ValType type2);

        protected override Value Invoke()
        {
            Value value1 = node1.Evaluate();
            Value value2 = node2.Evaluate();

            return Operate(value1, value2);

            //throw new CompilerException(Line, 202, Name, value1.TypeString, value2.TypeString);
        }

        //public abstract String Name { get;}
    }
}