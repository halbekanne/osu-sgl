using System;
using System.Collections.Generic;

using System.Text;
using SGL.Storyboard;
using SGL.Elements;

namespace SGL.Library.Classes
{
    class Sprite : Visual
    {
        private String layer;
        private String origin;
        private String path;

        //private SpriteObject sprite;

        // used for class registration
        public Sprite() { }

        private Sprite(String path)
            : this(path, "Foreground", "Centre")
        {
        }

        private Sprite(String path, String layer)
            : this(path, layer, "Centre")
        {
        }

        private Sprite(String path, String layer, String origin)
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
            if (Value.TypeCompare(param, ValType.String)) return new Sprite(param[0].StringValue);
            else if (Value.TypeCompare(param, ValType.String, ValType.Layer)) return new Sprite(param[0].StringValue, param[1].StringValue);
            else if (Value.TypeCompare(param, ValType.String, ValType.Layer, ValType.Origin)) return new Sprite(param[0].StringValue, param[1].StringValue, param[2].StringValue);
            else throw new CompilerException(-1, 312);
        }

    }
}
