using System;
using System.Collections.Generic;
using SGL.Elements;
using SGL.Storyboard;

namespace SGL.Library.Classes
{
    internal class SpriteClass : AbstractVisualClass
    {
        private readonly String layer;
        private readonly String origin;
        private readonly String path;

        //private SpriteObject sprite;

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
            InitializiseSpriteObject();
        }

        public override string Name
        {
            get { return "Sprite"; }
        }

        private void InitializiseSpriteObject()
        {
            visualObject = new SpriteObject(layer, origin, path);
            // we need to save this object in order to generate the storyboard when all parsing processes finished
            GlobalMemory.Instance.RegisterVisualObject(visualObject);
        }


        public override object CreateObject(List<Value> param)
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