using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGL.Elements;
using SGL.Classes;

namespace SGL.Nodes
{
    class InstanciateObjectNode : INode
    {
        private String className;
        private List<INode> parameters;

        public InstanciateObjectNode(String className, List<INode> parameters)
        {
            // Es sollte schon hier geprüft werden, ob es die Klasse überhaupt gibt, damit Rechtschreibfehler vor dem Ausführen erkannt werden
            if (!Library.Instance.IsClassKnown(className))
            {
                throw new Exception();
            }
        }


        public Value Evaluate()
        {
            List<Value> values = new List<Value>();
            foreach (INode node in parameters)
            {
                values.Add(node.Evaluate());
            }
            Class classObj = Library.Instance.GetClass(className, values);
            return new Value(classObj, ValType.Object);
        }

        public int GetLine()
        {
            return -1;
        }

    }
}
