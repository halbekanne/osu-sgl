//  Storyboard Generation Language
//  Copyright (C) 2013 Dominik Halfkann
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
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