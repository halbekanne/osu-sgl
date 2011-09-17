using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class AnimationNode : SGLNode
    {
        private int priority;
        private String filepath;
        private String layer;
        private String origin;
        private int line = -1;


        public AnimationNode(List<SGLNode> arguments)
        {
            // resolve arguments
            List<SGLValue> values = new List<SGLValue>();
            
            foreach (SGLNode exprNode in arguments)
            {
                values.Add(exprNode.Evaluate());
            }

            if (values.Count == 1)
            {
                this.priority = 0;
                this.filepath = values[0].AsString();
                this.layer = "Foreground";
                this.origin = "Centre";
            }
            else if (values.Count == 2)
            {
                this.priority = values[0].AsInteger();
                this.filepath = values[1].AsString();
                this.layer = "Foreground";
                this.origin = "Centre";
            }
            else if (values.Count == 3)
            {
                this.priority = values[0].AsInteger();
                this.filepath = values[1].AsString();
                if (!values[2].IsLayer()) throw new Exception(values[2].AsString() + " is not a valid layer");
                this.layer = values[2].AsString();
                this.origin = "Centre";
            }
            else if (values.Count == 4)
            {
                this.priority = values[0].AsInteger();
                this.filepath = values[1].AsString();
                if (!values[2].IsLayer()) throw new Exception(values[2].AsString() + " is not a valid layer");
                this.layer = values[2].AsString();
                if (!values[3].IsOrigin()) throw new Exception(values[3].AsString() + " is not a valid origin");
                this.origin = values[3].AsString();
            }

            

            // If at least one argument is in the list, we can define the line number
            if (arguments.Count > 0)
            {
                line = arguments[0].GetLine();
            }
        }

        public int GetLine()
        {
            // -1 could be returned here if no argument was given, but the line number will be retrieved later
            return line;
        }


        public SGLValue Evaluate()
        {
            return new SGLValue(new Sprite(priority, filepath, layer, origin));

        }

    }
}
