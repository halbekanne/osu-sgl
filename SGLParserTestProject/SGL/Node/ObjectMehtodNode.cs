using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class ObjectMehtodNode : SGLNode
    {
        private String variable;
        private String method;
        private List<SGLNode> arguments;
        private Scope scope;

        public ObjectMehtodNode(String variable, String method, List<SGLNode> arguments, Scope scope)
        {
            this.variable = variable;
            this.method = method;
            this.arguments = arguments;
            this.scope = scope;
        }

        public SGLValue Evaluate()
        {
            // resolve the sprite/animation object
            SGLValue sprite = scope.Resolve(variable);
            if (sprite == null)
            {
                throw new Exception("no such variable: " + this);
            }
            else if (!sprite.IsObject())
            {
                throw new Exception("variable is not an Object (Sprite/Animation): " + this);
            }
            SGLObject obj = sprite.AsObject();

            // resolve arguments
            List<SGLValue> values = new List<SGLValue>();
            foreach(SGLNode exprNode in arguments) {
                values.Add(exprNode.Evaluate());
            }

            // resolve current time from scope
            int time = scope.GetTime();

            // find method to execute
            if (method.Equals("move"))
            {
                if (values.Count == 2) {
                    obj.AddSbCode(" M,0," + time + "," + time + ",," + values[0].AsInteger() + "," + values[1].AsInteger());
                }
            }





            return SGLValue.VOID;
        }



    }
}
