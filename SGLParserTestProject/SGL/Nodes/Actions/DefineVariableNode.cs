using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Nodes.Actions
{
    class DefineVariableNode : AbstractNode
    {
        private String name;
        private Scope scope;
        private int line;

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
            this.scope = GlobalMemory.Instance.GlobalScope;
            this.line = line;
        }

        protected override Value Invoke()
        {

            // a simple assignment
            //scope.SetSpriteObjects(spriteObjects);
            scope.Define(name);



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
