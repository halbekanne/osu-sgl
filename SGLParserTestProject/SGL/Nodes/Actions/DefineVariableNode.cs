using System;
using SGL.Elements;

namespace SGL.Nodes.Actions
{
    internal class DefineVariableNode : AbstractNode
    {
        private readonly int line;
        private readonly String name;
        private readonly Scope scope;

        public DefineVariableNode(String name, Scope scope, int line)
        {
            this.name = name;
            this.scope = scope;
            this.line = line;
        }

        // global assign
        public DefineVariableNode(String name, int line)
        {
            this.name = name;
            scope = GlobalMemory.Instance.GlobalScope;
            this.line = line;
        }

        public override int Line
        {
            get { return line; }
        }

        protected override Value Invoke()
        {
            // a simple assignment
            //scope.SetSpriteObjects(spriteObjects);
            scope.Define(name);


            return Value.VOID;
        }
    }
}