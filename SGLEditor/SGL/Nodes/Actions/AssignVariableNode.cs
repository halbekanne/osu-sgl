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
using System;
using System.Collections.Generic;
using SGL.Elements;

namespace SGL.Nodes.Actions
{
    internal class AssignVariableNode : AbstractNode
    {
        private readonly AbstractNode expression;
        private readonly List<AbstractNode> indexes;
        private readonly int line;
        private readonly String name;
        private readonly Scope scope;

        public AssignVariableNode(String name, List<AbstractNode> indexes, AbstractNode expression, Scope scope,
                                  int line)
        {
            this.name = name;
            this.indexes = (indexes == null) ? new List<AbstractNode>() : indexes;
            this.expression = expression;
            this.scope = scope;
            this.line = line;
        }

        // global assign
        public AssignVariableNode(String name, List<AbstractNode> indexes, AbstractNode expression, int line)
        {
            this.name = name;
            this.indexes = (indexes == null) ? new List<AbstractNode>() : indexes;
            this.expression = expression;
            scope = GlobalMemory.Instance.GlobalScope;
            this.line = line;
        }

        public override int Line
        {
            get { return line; }
        }

        protected override Value Invoke()
        {
            Value exprV = expression == null ? Value.NULL : expression.Evaluate();

            if (indexes.Count < 1)
            {
                // a simple assignment
                //scope.SetSpriteGenerators(SpriteGenerators);
                scope.Assign(name, exprV);
            }
            else
            {
                // a possible list-lookup and reassignment
                Value list = scope.Resolve(name);

                // iterate up to `foo[x][y]` in case of `foo[x][y][z] = 42;`
                for (int i = 0; i < indexes.Count - 1 && list != null; i++)
                {
                    Value index = indexes[i].Evaluate();

                    if (!index.TypeEquals(ValType.Integer))
                    {
                        throw new CompilerException(line, 212, (i + 1).ToString(), name, index.TypeString);
                    }
                    else if (list.Type != ValType.List)
                    {
                        throw new CompilerException(line, 213, name, (i).ToString(), list.TypeString);
                    }

                    int position = index.IntValue;
                    list = list.ListValue[position];
                }
                // list is now pointing to `foo[x][y]` in case of `foo[x][y][z] = 42;`

                // get the value `z`: the last index, in `foo[x][y][z] = 42;`
                Value idx = indexes[indexes.Count - 1].Evaluate();

                if (!idx.TypeEquals(ValType.Integer))
                {
                    throw new CompilerException(line, 212, (indexes.Count).ToString(), name, idx.TypeString);
                }
                else if (list.Type != ValType.List)
                {
                    throw new CompilerException(line, 213, name, (indexes.Count - 1).ToString(), list.TypeString);
                }

                // re-assign `foo[x][y][z]`
                List<Value> existing = list.ListValue;
                // add elements if the index is out of range
                while (idx.IntValue >= existing.Count)
                {
                    existing.Add(Value.NULL);
                }
                existing[idx.IntValue] = exprV;
            }


            return Value.VOID;
        }
    }
}