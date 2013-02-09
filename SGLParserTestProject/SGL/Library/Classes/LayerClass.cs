using SGL.Storyboard.Generators.Visual;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Library.Classes
{
    class LayerClass : AbstractVisualClass
    {
        List<AbstractVisualClass> LayerGenerators;

        public LayerClass(List<AbstractVisualClass> LayerGenerators)
        {
            this.LayerGenerators = LayerGenerators;
            visualObject = new LayerGenerator(LayerGenerators);
        }

        public LayerClass()
        {
            // TODO: Complete member initialization
        }

        public override string Name
        {
            get { return "Visual"; }
        }

        public override object CreateInstance(List<Elements.Value> parameters)
        {
            List<AbstractVisualClass> LayerGenerators = new List<AbstractVisualClass>();
            foreach (Elements.Value parameter in parameters) {
                LayerGenerators.Add((AbstractVisualClass)parameter.ObjectValue);
            }
            return new LayerClass(LayerGenerators);
        }
    }
}
