using System.Collections.Generic;
using SGL.Elements;

namespace SGL.Nodes.ControlFlow
{
    internal class ForNode : AbstractNode
    {
        private readonly List<AbstractNode> init = new List<AbstractNode>();
        private AbstractNode block;
        private AbstractNode condition;
        private AbstractNode iteration;

        public AbstractNode Init
        {
            set { init.Add(value); }
        }

        public AbstractNode Condition
        {
            set { condition = value; }
        }

        public AbstractNode Iteration
        {
            set { iteration = value; }
        }

        public AbstractNode Block
        {
            set { block = value; }
        }

        public override int Line
        {
            get { return condition.Line; }
        }

        protected override Value Invoke()
        {
            /*
            Console.WriteLine("init: " + init.Evaluate());
            Console.WriteLine("cond: " + condition.Evaluate());
            Console.WriteLine("iteration: " + iteration.Evaluate());
            */

            //Console.WriteLine("--------------------------------------");
            for (EvaluateInit(); condition.Evaluate().BoolValue; iteration.Evaluate())
            {
                block.Evaluate();
            }

            return Value.VOID;
        }

        private void EvaluateInit()
        {
            foreach (AbstractNode initStatement in init)
            {
                initStatement.Evaluate();
            }
        }
    }
}