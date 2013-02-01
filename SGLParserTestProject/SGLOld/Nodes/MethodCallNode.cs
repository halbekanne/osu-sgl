using System;
using System.Collections.Generic;
using System.Text;
using SGLOld.Nodes.StaticMethod;

namespace SGLOld.Nodes
{
    class MethodCallNode : INode
    {
        private String identifier;
        private List<INode> parameters;
        private Dictionary<String, Method> methods;
        private Dictionary<String, ObjectMethod> objectMethods;
        private StringBuilder sb;
        private Scope globalScope;
        private int line;
        private Random random;

        public MethodCallNode(String identifier, List<INode> parameters, Dictionary<String, Method> methods, Dictionary<String, ObjectMethod> objectMethods, StringBuilder sb, Scope globalScope, Random random, int line)
        {
            this.identifier = identifier;
            this.parameters = (parameters == null) ? new List<INode>() : parameters;
            this.methods = methods;
            this.objectMethods = objectMethods;
            this.sb = sb;
            this.random = random;
            this.globalScope = globalScope;
            this.line = line;
            Console.WriteLine(identifier + " > parameters: " + parameters.Count);
        }

        public Value Evaluate()
        {
            Console.WriteLine(identifier + " > parameters: " + parameters.Count);
            //String key = identifier;

            // Convert the list of Nodes into Values
            List<Value> paramValues = new List<Value>();
            foreach (INode currentNode in parameters)
            {
                paramValues.Add(currentNode.Evaluate());
            }

            // Generate a key for a quicker match with static methods
            //String key = identifier + " " + paramValues.Count;

            /*
            String argString = "";
            for (int i = 0; i < paramValues.Count; i++)
            {
                String argType = paramValues[i].GetVarType();
                key += "-" + argType;
                argString += argType;
                if (i < paramValues.Count - 1)
                {
                    argString += ", ";
                }
            }*/

            // Test if the method is a static, predefined SGL method and executes it
            try
            {
                Value val = IsStaticMethod(identifier, paramValues, sb);
                if (val != Value.INVALID) return val;
            }
            catch (CompilerException sce)
            {
                //sce.Line = GetLine();
                throw sce;
            }

            if (!methods.ContainsKey(identifier)) {
                // TODO: arguments?
                //throw new CompilerException(GetLine(), "method undefined", "the method '" + identifier + "' is undefined");
                
            }

            // Method is not static (user-defined) and exists
            Method m = methods[identifier];

            Method method = new Method(m);

            return Value.VOID;

            //return method.Invoke(parameters, methods, objectMethods, sb, globalScope, random);
        }

        private Value IsStaticMethod(String key, List<Value> parameter, StringBuilder sb) {
            if (key.StartsWith("println") && parameter.Count == 1)
            {
                return new PrintlnNode(sb, parameter[0]).Evaluate();
            }
            else if (key.Equals("rand-int-int"))
            {
                //Console.WriteLine("called random method");
                return new RandomIntegerNode(parameter[0], parameter[1], this.random).Evaluate();
            }
            else if (key.StartsWith("pow-") && parameter.Count == 2 && parameter[0].IsNumber() && parameter[1].IsNumber())
            {
                return new PowNodeOld(parameter[0], parameter[1]).Evaluate();
            }
            else if (key.StartsWith("root-") && parameter.Count == 2 && parameter[0].IsNumber() && parameter[1].IsNumber())
            {
                return new RootNode(parameter[0], parameter[1]).Evaluate();
            }
            else if (key.StartsWith("toInt-") && parameter.Count == 1)
            {
                return new IntNode(parameter[0]).Evaluate();
            }
            else if (key.StartsWith("toFloat-") && parameter.Count == 1)
            {
                return new FloatNode(parameter[0]).Evaluate();
            }
            else if (key.StartsWith("toString-") && parameter.Count == 1)
            {
                return new StringNode(parameter[0]).Evaluate();
            }
            else if (key.StartsWith("toBoolean-") && parameter.Count == 1)
            {
                return new BooleanNode(parameter[0]).Evaluate();
            }
            

            return Value.INVALID;

        }



        public int GetLine()
        {
            return line;
        }



    }
}
