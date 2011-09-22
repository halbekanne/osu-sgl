using System;
using System.Collections.Generic;
using System.Text;
using SGL.Node.StaticMethod;

namespace SGL.Node
{
    class MethodCallNode : SGLNode
    {
        private String identifier;
        private List<SGLNode> parameters;
        private Dictionary<String, Method> methods;
        private StringBuilder sb;
        private Scope globalScope;
        private int line;
        private Random random;

        public MethodCallNode(String identifier, List<SGLNode> parameters, Dictionary<String, Method> methods, StringBuilder sb, Scope globalScope, Random random, int line)
        {
            this.identifier = identifier;
            this.parameters = parameters;
            this.methods = methods;
            this.sb = sb;
            this.random = random;
            this.globalScope = globalScope;
            this.line = line;
        }

        public SGLValue Evaluate()
        {
            
            String key = identifier;

            // Convert the list of Nodes into Values
            List<SGLValue> paramValues = new List<SGLValue>();
            foreach (SGLNode currentNode in parameters)
            {
                paramValues.Add(currentNode.Evaluate());
            }

            // Test if the type of parameters are the same as the identifiers
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
            }

            // Test if the method is a static, predefined SGL method and executes it
            try
            {
                SGLValue val = IsStaticMethod(key, paramValues, sb);
                if (val != SGLValue.INVALID) return val;
            }
            catch (SGLCompilerException sce)
            {
                sce.Line = GetLine();
                throw sce;
            }

            if (!methods.ContainsKey(key)) {
                // TODO: Think about convertion from int to float and vice versa
                throw new SGLCompilerException(GetLine(), "method undefined", "the method '" + identifier + "' is undefined or is not applicable for the arguments (" + argString + ")");
                
            }

            // Method is not static (user-defined) and exists
            Method m = methods[key];

            Method method = new Method(m);

            return method.Invoke(parameters, methods, sb, globalScope);
        }

        private SGLValue IsStaticMethod(String key, List<SGLValue> parameter, StringBuilder sb) {
            if (key.StartsWith("println-") && parameter.Count == 1)
            {
                return new PrintlnNode(sb, parameter[0]).Evaluate();
            }
            else if (key.Equals("rand-int-int"))
            {
                Console.WriteLine("called random method");
                return new RandomIntegerNode(parameter[0], parameter[1], this.random).Evaluate();
            }
            else if (key.StartsWith("pow-") && parameter.Count == 2 && parameter[0].IsNumber() && parameter[1].IsNumber())
            {
                return new PowNode(parameter[0], parameter[1]).Evaluate();
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
            

            return SGLValue.INVALID;

        }



        public int GetLine()
        {
            return line;
        }



    }
}
