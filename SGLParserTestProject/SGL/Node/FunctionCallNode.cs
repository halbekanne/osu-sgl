using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class FunctionCallNode : SGLNode
    {
        private String identifier;
        private List<SGLNode> parameters;
        private Dictionary<String, Function> functions;
        private StringBuilder sb;

        public FunctionCallNode(String identifier, List<SGLNode> parameters, Dictionary<String, Function> functions, StringBuilder sb)
        {
            this.identifier = identifier;
            this.parameters = parameters;
            this.functions = functions;
            this.sb = sb;
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
            for (int i = 0; i < paramValues.Count; i++)
            {
                key += "-" + paramValues[i].GetVarType();
            }

            Console.WriteLine("Ist Funktion mit key vorhanden? key: " + key);

            if (!functions.ContainsKey(key)) {
                throw new Exception("no function '" + identifier + "' with " + parameters.Count + " parameter(s)");
            }

            Console.WriteLine("Erzeuge funktion mit key:" + key);
            Function f = functions[key];

            Console.WriteLine("2");
            Function function = new Function(f);

            Console.WriteLine("Führe Funktion aus");
            return function.Invoke(parameters, functions, sb);
        }



    }
}
