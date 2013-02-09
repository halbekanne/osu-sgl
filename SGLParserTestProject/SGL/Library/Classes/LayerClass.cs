//  Storyboard Generation Language
//  Copyright (C) 2013 Dominik Halfkann
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
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
