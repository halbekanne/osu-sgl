using SGL.Storyboard;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Library.Classes
{
    class LayerFactory : Visual
    {
        List<Visual> layerObjects;

        public LayerFactory(List<Visual> layerObjects)
        {
            this.layerObjects = layerObjects;
            Sprite = new LayerFactory(layerObjects);
        }

        public LayerFactory()
        {
            // TODO: Complete member initialization
        }

        public override string Name
        {
            get { return "Visual"; }
        }

        public override object CreateNewInstance(List<Elements.Value> parameters)
        {
            ListFactory<Visual> layerObjects = new List<Visual>();
            foreach (Elements.Value parameter in parameters) {
                layerObjects.Add((Visual)parameter.ObjectValue);
            }
            return new LayerFactory(layerObjects);
        }
    }
}
