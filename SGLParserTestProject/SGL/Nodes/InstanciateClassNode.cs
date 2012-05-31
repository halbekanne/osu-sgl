using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGL.Elements;
using SGL.Library.Classes;

namespace SGL.Nodes
{
    class InstanciateObjectNode : AbstractNode
    {
        private String className;
        private List<AbstractNode> parameters;

        public InstanciateObjectNode(String className, List<AbstractNode> parameters)
        {
            // Es sollte schon hier geprüft werden, ob es die Klasse überhaupt gibt, damit Rechtschreibfehler vor dem Ausführen erkannt werden
            if (!LibraryManager.Instance.IsClassKnown(className))
            {
                throw new Exception();
            }
        }


        public override Value Invoke()
        {
            try {
            List<Value> values = new List<Value>();
            foreach (AbstractNode node in parameters)
            {
                values.Add(node.Evaluate());
            }
            Class classObj = LibraryManager.Instance.GetClass(className, values);
            return new Value(classObj, ValType.Object);
        }

        public int GetLine()
        {
            return -1;
        }

    }
}
