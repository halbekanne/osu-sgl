using System;
using System.Collections.Generic;
using System.Text;
using SGL.Types;

namespace SGL.Nodes
{
    class AssignVariableNode : INode
    {
        private String name;
        private List<INode> indexes;
        private INode expression;
        private Scope scope;
        private List<SpriteObject> spriteObjects;

        public AssignVariableNode(String name, List<INode> indexes, INode expression,List<SpriteObject> spriteObjects, Scope scope)
        {
            this.name = name;
            this.indexes = (indexes == null) ? new List<INode>() : indexes;
            this.expression = expression;
            this.scope = scope;
            this.spriteObjects = spriteObjects;
        }

        public Value Evaluate() {

            try
            {

                Value exprV = expression.Evaluate();
                if (exprV == Value.VOID)
                {
                    throw new CompilerException(GetLine(), "assignment impossible", "Unable to assign VOID to a variable (" + name + ")");
                }

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

                        if (!index.IsNumber() || !list.IsList())
                        { // sanity checks
                            throw new CompilerException(GetLine(), "assignment impossible", name + " is not a list or one of the identifiers is not a Number");
                        }

                        int position = index.AsInteger();
                        list = list.AsList()[position];
                    }
                    // list is now pointing to `foo[x][y]` in case of `foo[x][y][z] = 42;`

                    // get the value `z`: the last index, in `foo[x][y][z] = 42;`
                    Value idx = indexes[indexes.Count - 1].Evaluate();

                    if (!idx.IsNumber() || /*list == null ||*/ !list.IsList())
                    { // sanity checks
                        throw new CompilerException(GetLine(), "assignment impossible", name + " is not a list or one of the identifiers is not a Number");
                    }

                    // re-assign `foo[x][y][z]`
                    List<Value> existing = list.AsList();
                    // add elements if the index is out of range
                    while (idx.AsInteger() >= existing.Count)
                    {
                        existing.Add(Value.NULL);
                    }
                    existing[idx.AsInteger()] = exprV;
                }

            }
            catch (CompilerException sce)
            {
                sce.Line = GetLine();
                throw sce;
            }

            return Value.VOID;
        }

        public int GetLine()
        {
            return expression.GetLine();
        }

    }
}
