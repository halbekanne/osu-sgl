using System;
using System.Collections.Generic;

using System.Text;
using SGL.Storyboard;
using SGL.Elements;

namespace SGL.Library.Classes
{
    class Sprite : Class
    {
        private String layer = "Foreground";
        private String origin = "Centre";
        private String path;

        private SpriteObject sprite;

        // used for class registration
        public Sprite() { }

        private Sprite(String path)
        {
            this.path = path;
            InitializiseSpriteObject();
        }

        private void InitializiseSpriteObject()
        {
            sprite =new SpriteObject(layer, origin, path);
            // we need to save this object in order to generate the storyboard when all parsing processes finished
            GlobalMemory.Instance.RegisterVisualObject(sprite);
        }

        private Value fade(double opacity) {
            double[] startParams = new double[] { opacity };
            sprite.AddCommand(new Animation(AnimationType.Fade, startParams));
            return Value.VOID;
        }

        public override Class CreateObject(List<Value> param)
        {
            if (Value.TypeCompare(param, ValType.String)) return new Sprite(param[0].StringValue);
            else throw new CompilerException(-1, 312);
        }

        public override Value InvokeMethod(String name, List<Value> param)
        {
            if (name.Equals("fade"))
            {
                if (Value.TypeCompare(param, ValType.Integer)) return fade(param[0].DoubleValue);
            }
            //TODO: Exception
            throw new Exception();
        }

        public override string Name
        {
            get { return "Sprite"; }
        }

    }
}
