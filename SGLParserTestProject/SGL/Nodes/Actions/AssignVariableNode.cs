using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Actions
{
    class AssignVariableNode : AbstractNode
    {
        private String name;
        private List<AbstractNode> indexes;
        private AbstractNode expression;
        private Scope scope;
        private int line;

        public AssignVariableNode(String name, List<AbstractNode> indexes, AbstractNode expression, Scope scope, int line)
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
            this.scope = GlobalMemory.Instance.GlobalScope;
            this.line = line;
        }

        protected override Value Invoke()
        {
            Value exprV = expression.Evaluate();

            if (indexes.Count < 1)
            {
                // a simple assignment
                //scope.SetSpriteObjects(spriteObjects);
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

        public override int Line
        {
            get
            {
                return line;
            }
        }

    }
}
