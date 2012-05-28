using System;
using System.Collections.Generic;
using System.Text;
using SGLOld;
using SGLOld.Parser;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using SGLOld.Nodes;

namespace SGLOld
{
    public class Method
    {

        private String id;
        private List<String> identifiers;
        private CommonTree code;
        private Scope scope;
        private Random random;

        public Method(String id, CommonTree identifiers, CommonTree block)
        {
            this.id = id;
            this.identifiers = ToList(identifiers);
            code = block;
            scope = new Scope();
            //Console.WriteLine("identifiers: " + this.identifiers.Count);
        }

        public Method(Method original)
        {
            // Used for recursively calling methods  
            id = original.id;
            identifiers = original.identifiers;
            code = original.code;
            scope = original.scope.Copy();
        }

        public Value Invoke(List<INode> parameters, Dictionary<String, Method> methods, Dictionary<String, ObjectMethod> objectMethods, StringBuilder sb, Scope globalScope, Random random)
        {
            // became useless: methods, objectMethods, 

            // Test if the amount of parameters are the same as the identifiers of this method
            if (parameters.Count != identifiers.Count)
            {
                throw new Exception("illegal function call: " + identifiers.Count +
                    " parameters expected for function `" + id + "`");
            }

            // Convert the list of Nodes into Values
            List<Value> paramValues = new List<Value>();
            foreach(INode currentNode in parameters) {
                paramValues.Add(currentNode.Evaluate());
            }

            // Test if the type of parameters are the same as the identifiers - no need for this anymore
            /*
            for (int i = 0; i < paramValues.Count; i++) {
                if (!paramValues[i].GetVarType().Equals(identTypes[i]))
                {
                    throw new Exception("illegal function call: " + paramValues.ToString() +
                    " does not match " + identTypes.ToString());
                }
            }*/

            // Add the methods scope as a child to the global scope
            scope = new Scope(globalScope);


            // Assign all expression parameters to this method's identifiers  
            for (int i = 0; i < identifiers.Count; i++)
            {
                scope.Assign(identifiers[i], paramValues[i]);
            }

            try
            {
                // Create a tree walker to evaluate this method's code block  
                CommonTreeNodeStream nodes = new CommonTreeNodeStream(code);
                SGLTreeWalker walker = new SGLTreeWalker(nodes, scope, methods, objectMethods);
                walker.SetRandomizer(random);

                // Ok executing the function then
                Value returnValue = walker.main().Evaluate();

                // Add Function's SB to the main SB
                sb.Append(walker.GetStoryboardCode().ToString());

                // we shouldn't check the return type
                /*if (!returnValue.GetVarType().Equals(this.returnType))
                {
                    throw new Exception("The method doesn't return the expected return type (" + returnValue.ToString()  + " is not from type " + this.returnType + ")");
                }*/
                return returnValue;
            }
            catch (RecognitionException e)
            {
                // do not recover from this  
                throw new Exception("something went wrong, terminating", e);
            }
        }

        private List<String> ToList(CommonTree tree)
        {
            List<String> ids = new List<String>();
            // convert the tree to a List of Strings
            //Console.WriteLine("1: " + childNum);
            if (tree.ChildCount > 0)
            {
                //Console.WriteLine("2: " + childNum);
                for (int i = 0; i < tree.ChildCount; i++)
                {
                    //Console.WriteLine("3: " + childNum);
                    CommonTree child = (CommonTree)tree.GetChild(i);
                    ids.Add(child.Text);
                    //Console.WriteLine("add to List (" + childNum + "): " + child.Text);
                }
                //Console.WriteLine("4: " + childNum);
            }
            return ids;
        }
    }
}
