using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.ControlFlow
{
    class ForNode : AbstractNode
    {
        private AbstractNode init;
        private AbstractNode condition;
        private AbstractNode iteration;
        private AbstractNode block;

        public ForNode()
        {

        }

        public AbstractNode Init {
            set {
                this.init = value;
            }
        }

        public AbstractNode Condition
        {
            set
            {
                this.condition = value;
            }
        }

        public AbstractNode Iteration
        {
            set
            {
                this.iteration = value;
            }
        }

        public AbstractNode Block
        {
            set
            {
                this.block = value;
            }
        }

        public override Value Invoke()
        {
            /*
            Console.WriteLine("init: " + init.Evaluate());
            Console.WriteLine("cond: " + condition.Evaluate());
            Console.WriteLine("iteration: " + iteration.Evaluate());
            */
              
            //Console.WriteLine("--------------------------------------");
            for (init.Evaluate(); condition.Evaluate().BoolValue; iteration.Evaluate()) {
                block.Evaluate();
            }

            return Value.VOID;
        }

        public int Line
        {
            get
            {
                return condition.Line;
            }
        }

    }
}
