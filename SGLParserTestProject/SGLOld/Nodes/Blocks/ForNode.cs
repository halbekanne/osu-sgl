using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Nodes.Blocks
{
    class ForNode : INode
    {
        private INode init;
        private INode condition;
        private INode iteration;
        private INode block;

        public ForNode()
        {

        }

        public INode Init {
            set {
                this.init = value;
            }
        }

        public INode Condition
        {
            set
            {
                this.condition = value;
            }
        }

        public INode Iteration
        {
            set
            {
                this.iteration = value;
            }
        }

        public INode Block
        {
            set
            {
                this.block = value;
            }
        }

        public Value Evaluate()
        {
            /*
            Console.WriteLine("init: " + init.Evaluate());
            Console.WriteLine("cond: " + condition.Evaluate());
            Console.WriteLine("iteration: " + iteration.Evaluate());
            */
              
            //Console.WriteLine("--------------------------------------");
            for (init.Evaluate(); condition.Evaluate().AsBoolean(); iteration.Evaluate()) {
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
