using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes.Blocks
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

        public void SetInit(INode init)
        {
            this.init = init;
        }

        public void SetCondition(INode condition)
        {
            this.condition = condition;
        }

        public void SetIteration(INode iteration)
        {
            this.iteration = iteration;
        }

        public void SetBlock(INode block)
        {
            this.block = block;
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

        public int GetLine()
        {
            return condition.GetLine();
        }

    }
}
