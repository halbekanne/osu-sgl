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
using System;
using System.Collections.Generic;
using SGL.Elements;
using SGL.Storyboard.Generators.Visual;

namespace SGL.Library.Classes
{
    internal class SpriteClass : AbstractVisualClass
    {
        private readonly String layer;
        private readonly String origin;
        private readonly String path;

        //private SpriteGenerator sprite;

        // used for class registration
        public SpriteClass()
        {
        }

        private SpriteClass(String path)
            : this(path, "Foreground", "Centre")
        {
        }

        private SpriteClass(String path, String layer)
            : this(path, layer, "Centre")
        {
        }

        private SpriteClass(String path, String layer, String origin)
        {
            this.path = path;
            this.layer = layer;
            this.origin = origin;
            InitializiseSpriteGenerator();
        }

        public override string Name
        {
            get { return "Sprite"; }
        }

        private void InitializiseSpriteGenerator()
        {
            visualObject = new SpriteGenerator(layer, origin, path);
            // we need to save this object in order to generate the storyboard when all parsing processes finished
            GlobalMemory.Instance.RegisterStoryboardGenerator(visualObject);
        }


        public override object CreateInstance(List<Value> param)
        {
            if (Value.TypeCompare(param, ValType.String)) return new SpriteClass(param[0].StringValue);
            else if (Value.TypeCompare(param, ValType.String, ValType.Layer))
                return new SpriteClass(param[0].StringValue, param[1].StringValue);
            else if (Value.TypeCompare(param, ValType.String, ValType.Layer, ValType.Origin))
                return new SpriteClass(param[0].StringValue, param[1].StringValue, param[2].StringValue);
            else throw new CompilerException(-1, 312);
        }
    }
}