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
        private int frameCount;
        private int frameDelay;
        private String loopType;
        private int line = -1;
        List<SGLNode> arguments;


        public AnimationNode(List<SGLNode> arguments)
        {
            this.arguments = arguments;
        }

        private void CheckParameters(String ident, List<SGLValue> values, String[] expected)
        {
            int a = 0;
            foreach (SGLValue val in values)
            {
                if (!val.GetVarType().Equals(expected[a]))
                {
                    if (!expected[a].Equals("number") || (!val.GetVarType().Equals("int") && !val.GetVarType().Equals("float")))
                    {
                        throw new SGLCompilerException(GetLine(), "type mismatch", "the constructor '" + ident + "' is not applicable for the arguments (" + GetArgString(values) + ")");
                    }
                }

                a++;
            }
        }


        private String GetArgString(List<SGLValue> values)
        {
            String argString = "";
            for (int i = 0; i < values.Count; i++)
            {
                argString += values[i].GetVarType();
                if (i < values.Count - 1)
                {
                    argString += ", ";
                }
            }
            return argString;
        }

        public int GetLine()
        {
            // -1 could be returned here if no argument was given, but the line number will be retrieved later
            return line;
        }


        public SGLValue Evaluate()
        {
            // If at least one argument is in the list, we can define the line number
            if (arguments.Count > 0)
            {
                line = arguments[0].GetLine();
            }

            // resolve arguments
            List<SGLValue> values = new List<SGLValue>();

            foreach (SGLNode exprNode in arguments)
            {
                values.Add(exprNode.Evaluate());
            }

            if (values.Count == 7)
            {
                CheckParameters("Animation", values, new String[] { "int", "string", "Layer", "Origin", "int", "int", "LoopType" });
                this.priority = values[0].AsInteger();
                this.filepath = values[1].AsString();
                this.layer = values[2].AsString();
                this.origin = values[3].AsString();
                this.frameCount = values[4].AsInteger();
                this.frameDelay = values[5].AsInteger();
                this.loopType = values[6].AsString();
            }

            return new SGLValue(new Animation(priority, filepath, layer, origin, frameCount, frameDelay, loopType));

        }

    }
}
