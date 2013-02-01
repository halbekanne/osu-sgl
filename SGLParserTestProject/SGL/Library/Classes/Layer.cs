using SGL.Storyboard;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Library.Classes
{
    class Layer : Visual
    {
        List<Visual> layerObjects;

        public Layer(List<Visual> layerObjects)
        {
            this.layerObjects = layerObjects;
            visualObject = new LayerObject(layerObjects);
        }

        public Layer()
        {
            // TODO: Complete member initialization
        }

        public override string Name
        {
            get { return "Visual"; }
        }

        public override object CreateObject(List<Elements.Value> parameters)
        {
            List<Visual> layerObjects = new List<Visual>();
            foreach (Elements.Value parameter in parameters) {
                layerObjects.Add((Visual)parameter.ObjectValue);
            }
            return new Layer(layerObjects);
        }
    }
}
