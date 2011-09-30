using System;
using System.Collections.Generic;
using System.Text;
using SGL;
using SGL.AntlrParser;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace SGL
{
    public class Method
    {

        private String id;
        private String returnType;
        private List<String> identTypes;
        private List<String> identifiers;
        private CommonTree code;
        private Scope scope;

        public Method(String id, String type, CommonTree identifiers, CommonTree block)
        {
            this.id = id;
            this.returnType = type;
            this.identTypes = ToList(identifiers,0);
            this.identifiers = ToList(identifiers,1);
            code = block;
            scope = new Scope();
            //Console.WriteLine("identifiers: " + this.identifiers.Count);
        }

        public Method(Method original)
        {
            // Used for recursively calling methods  
            id = original.id;
            returnType = original.returnType;
            identTypes = original.identTypes;
            identifiers = original.identifiers;
            code = original.code;
            scope = original.scope.Copy();
        }

        public SGLValue Invoke(List<SGLNode> parameters, Dictionary<String, Method> functions, StringBuilder sb, Scope globalScope)
        {
            // Test if the amount of parameters are the same as the identifiers of this method
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

            // Add the methods scope as a child to the global scope
            scope = new Scope(globalScope);


            // Assign all expression parameters to this method's identifiers  
            for (int i = 0; i < identifiers.Count; i++)
            {
                scope.Assign(identifiers[i], paramValues[i], true, identTypes[i]);
            }

            try
            {
                // Create a tree walker to evaluate this method's code block  
                CommonTreeNodeStream nodes = new CommonTreeNodeStream(code);
                SGLTreeWalker walker = new SGLTreeWalker(nodes, scope, functions);

                // Ok executing the function then
                SGLValue returnValue = walker.compilationUnit().Evaluate();

                // Add Function's SB to the main SB
                sb.Append(walker.GetStoryboardCode().ToString());

                if (!returnValue.GetVarType().Equals(this.returnType))
                {
                    throw new Exception("The method doesn't return the expected return type (" + returnValue.ToString()  + " is not from type " + this.returnType + ")");
                }
                return returnValue;
            }
            catch (RecognitionException e)
            {
                // do not recover from this  
                throw new Exception("something went wrong, terminating", e);
            }
        }

        private List<String> ToList(CommonTree tree, int childNum)
        {
            List<String> ids = new List<String>();

            // convert the tree to a List of Strings
            //Console.WriteLine("1: " + childNum);
            if (tree.ChildCount > 0)
            {
                //Console.WriteLine("2: " + childNum);
                for (int i = 0; i < tree.GetChild(childNum).ChildCount; i++)
                {
                    //Console.WriteLine("3: " + childNum);
                    CommonTree child = (CommonTree)tree.GetChild(childNum).GetChild(i);
                    ids.Add(child.Text);
                    //Console.WriteLine("add to List (" + childNum + "): " + child.Text);
                }
                //Console.WriteLine("4: " + childNum);
            }
            return ids;
        }
    }
}
