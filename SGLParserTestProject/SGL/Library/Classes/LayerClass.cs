using SGL.Storyboard;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Library.Classes
{
    class LayerClass : AbstractVisualClass
    {
        List<AbstractVisualClass> layerObjects;

        public LayerClass(List<AbstractVisualClass> layerObjects)
        {
            this.layerObjects = layerObjects;
            visualObject = new LayerObject(layerObjects);
        }

        public LayerClass()
        {
            // TODO: Complete member initialization
        }

        public override string Name
        {
            get { return "Visual"; }
        }

        public override object CreateObject(List<Elements.Value> parameters)
        {
            ListClass<AbstractVisualClass> layerObjects = new List<AbstractVisualClass>();
            foreach (Elements.Value parameter in parameters) {
                layerObjects.Add((AbstractVisualClass)parameter.ObjectValue);
            }
            return new LayerClass(layerObjects);
        }
    }
}
