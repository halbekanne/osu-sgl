using System;
using System.Collections.Generic;
using System.Text;
using SGL;
using SGL.AntlrParser;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace SGL
{
    public class Function
    {

        private String id;
        private String returnType;
        private List<String> identTypes;
        private List<String> identifiers;
        private CommonTree code;
        private Scope scope;

        public Function(String id, String type, CommonTree identifiers, CommonTree block)
        {
            this.id = id;
            this.returnType = type;
            this.identTypes = ToList(identifiers,0);
            this.identifiers = ToList(identifiers,1);
            code = block;
            scope = new Scope();
        }

        public Function(Function original)
        {
            // Used for recursively calling functions  
            id = original.id;
            returnType = original.returnType;
            identTypes = original.identTypes;
            identifiers = original.identifiers;
            code = original.code;
            scope = original.scope.Copy();
        }

        public SGLValue Invoke(List<SGLNode> parameters, Dictionary<String, Function> functions, StringBuilder sb)
        {
            // Test if the amount of parameters are the same as the identifiers of this function
            if (parameters.Count != identifiers.Count)
            {
                throw new Exception("illegal function call: " + identifiers.Count +
                    " parameters expected for function `" + id + "`");
            }

            // Convert the list of Nodes into Values
            List<SGLValue> paramValues = new List<SGLValue>();
            foreach(SGLNode currentNode in parameters) {
                paramValues.Add(currentNode.Evaluate());
            }

            // Test if the type of parameters are the same as the identifiers
            for (int i = 0; i < paramValues.Count; i++) {
                if (!paramValues[i].GetVarType().Equals(identTypes[i]))
                {
                    throw new Exception("illegal function call: " + paramValues.ToString() +
                    " does not match " + identTypes.ToString());
                }
            }


            // Assign all expression parameters to this function's identifiers  
            for (int i = 0; i < identifiers.Count; i++)
            {
                scope.Assign(identifiers[i], paramValues[i], true, identTypes[i]);
            }

            try
            {
                // Create a tree walker to evaluate this function's code block  
                CommonTreeNodeStream nodes = new CommonTreeNodeStream(code);
                SGLTreeWalker walker = new SGLTreeWalker(nodes, scope, functions);

                // Ok executing the function then
                SGLValue returnValue = walker.compilationUnit().Evaluate();

                // Add Function's SB to the main SB
                Console.WriteLine("OK method finished, SB Code is: " + walker.GetStoryboardCode().ToString());
                sb.Append(walker.GetStoryboardCode().ToString());

                return returnValue;
            }
            catch (RecognitionException e)
            {
                // do not recover from this  
                throw new Exception("something went wrong, terminating", e);
            }
            return SGLValue.VOID;
        }

        private List<String> ToList(CommonTree tree, int childNum)
        {
            List<String> ids = new List<String>();

            // convert the tree to a List of Strings  
            for (int i = 0; i < tree.GetChild(childNum).ChildCount; i++)
            {
                CommonTree child = (CommonTree)tree.GetChild(childNum).GetChild(i);
                ids.Add(child.Text);
            }
            return ids;
        }
    }
}
