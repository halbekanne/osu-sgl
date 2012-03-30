using System;
using System.Collections.Generic;
using System.Text;
using SGL.Types;

namespace SGL.Nodes
{
    class SpriteNode : INode
    {
        private int priority;
        private String filepath;
        private String layer;
        private String origin;
        private int line = -1;
        List<INode> arguments;

        public SpriteNode(List<INode> arguments)
        {
            this.arguments = (arguments == null) ? new List<INode>() : arguments;   
        }

        public int GetLine()
        {
            // -1 could be returned here if no argument was given, but the line number will be retrieved later
            return line;
        }


        public Value Evaluate()
        {

            // If at least one argument is in the list, we can define the line number
            if (arguments.Count > 0)
            {
                line = arguments[0].GetLine();
            }

            // resolve arguments
            List<Value> values = new List<Value>();

            foreach (INode exprNode in arguments)
            {
                values.Add(exprNode.Evaluate());
            }

            if (values.Count == 1)
            {
                CheckParameters("Sprite", values, new String[] { "string" });
                this.priority = 0;
                this.filepath = values[0].AsString();
                this.layer = "Foreground";
                this.origin = "Centre";
            }
            else if (values.Count == 2)
            {
                CheckParameters("Sprite", values, new String[] { "int", "string" });
                this.priority = values[0].AsInteger();
                this.filepath = values[1].AsString();
                this.layer = "Foreground";
                this.origin = "Centre";
            }
            else if (values.Count == 3)
            {
                CheckParameters("Sprite", values, new String[] { "int", "string", "Layer" });
                this.priority = values[0].AsInteger();
                this.filepath = values[1].AsString();
                this.layer = values[2].AsString();
                this.origin = "Centre";
            }
            else if (values.Count == 4)
            {
                CheckParameters("Sprite", values, new String[] { "int", "string", "Layer", "Origin" });
                this.priority = values[0].AsInteger();
                this.filepath = values[1].AsString();
                this.layer = values[2].AsString();
                this.origin = values[3].AsString();
            }



        

            return new Value(new Sprite(priority, filepath, layer, origin));

        }

        private void CheckParameters(String ident, List<Value> values, String[] expected)
        {
            int a = 0;
            foreach (Value val in values)
            {
                if (!val.GetType().Equals(expected[a]))
                {
                    if (!expected[a].Equals("number") || (!val.GetType().Equals("int") && !val.GetType().Equals("float")))
                    {
                        throw new CompilerException(GetLine(), "type mismatch", "the constructor '" + ident + "' is not applicable for the arguments (" + GetArgString(values) + ")");
                    }
                }

                a++;
            }
        }


        private String GetArgString(List<Value> values)
        {
            String argString = "";
            for (int i = 0; i < values.Count; i++)
            {
                argString += values[i].GetType();
                if (i < values.Count - 1)
                {
                    argString += ", ";
                }
            }
            return argString;
        }

    }
}
