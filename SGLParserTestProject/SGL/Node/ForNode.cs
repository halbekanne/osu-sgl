using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class ForNode : SGLNode
    {
        private SGLNode init;
        private SGLNode condition;
        private SGLNode iteration;
        private SGLNode block;

        public ForNode()
        {

        }

        public void SetInit(SGLNode init)
        {
            this.init = init;
        }

        public void SetCondition(SGLNode condition)
        {
            this.condition = condition;
        }

        public void SetIteration(SGLNode iteration)
        {
            this.iteration = iteration;
        }

        public void SetBlock(SGLNode block)
        {
            this.block = block;
        }

        public SGLValue Evaluate()
        {
            /*
            Console.WriteLine("init: " + init.Evaluate());
            Console.WriteLine("cond: " + condition.Evaluate());
            Console.WriteLine("iteration: " + iteration.Evaluate());
            */
              
            Console.WriteLine("--------------------------------------");
            for (init.Evaluate(); condition.Evaluate().AsBoolean(); iteration.Evaluate()) {
                block.Evaluate();
            }

            return SGLValue.VOID;
        }

        public int GetLine()
        {
            return condition.GetLine();
        }

    }
}
