using System;
using System.Collections.Generic;

using System.Text;
using SGL.Storyboard;
using SGL.Elements;

namespace SGL.Library.Classes
{
    class Animation : Visual
    {
        private String layer;
        private String origin;
        private String path;
        private int frameCount;
        private int frameDelay;
        private string loopType;

        //private AnimationObject sprite;

        // used for class registration
        public Animation() { }

        private Animation(String path, int frameCount, int frameDelay)
            : this(path, "Foreground", "Centre", frameCount, frameDelay, "LoopForever")
        {
        }

        private Animation(String path, String layer, int frameCount, int frameDelay)
            : this(path, layer, "Centre", frameCount, frameDelay, "LoopForever")
        {
        }

        private Animation(String path, String layer, String origin, int frameCount, int frameDelay)
            : this(path, layer, origin, frameCount, frameDelay, "LoopForever")
        {
        }

        private Animation(String path, String layer, String origin, int frameCount, int frameDelay, string loopType)
        {
            this.path = path;
            this.layer = layer;
            this.origin = origin;
            this.frameCount = frameCount;
            this.frameDelay = frameDelay;
            this.loopType = loopType;
            InitializiseAnimationObject();

        }

        public override string Name
        {
            get { return "Animation"; }
        }

        private void InitializiseAnimationObject()
        {
            visualObject = new AnimationObject(layer, origin, path, frameCount, frameDelay, loopType);
            // we need to save this object in order to generate the storyboard when all parsing processes finished
            GlobalMemory.Instance.RegisterVisualObject(visualObject);
        }


        public override object CreateObject(List<Value> param)
        {
            if (Value.TypeCompare(param, ValType.String, ValType.Integer, ValType.Integer)) return new Animation(param[0].StringValue, param[1].IntValue, param[2].IntValue);
            else if (Value.TypeCompare(param, ValType.String, ValType.Layer, ValType.Integer, ValType.Integer)) return new Animation(param[0].StringValue, param[1].StringValue, param[2].IntValue, param[3].IntValue);
            else if (Value.TypeCompare(param, ValType.String, ValType.Layer, ValType.Origin, ValType.Integer, ValType.Integer)) return new Animation(param[0].StringValue, param[1].StringValue, param[2].StringValue, param[3].IntValue, param[4].IntValue);
            else if (Value.TypeCompare(param, ValType.String, ValType.Layer, ValType.Origin, ValType.Integer, ValType.Integer, ValType.LoopType)) return new Animation(param[0].StringValue, param[1].StringValue, param[2].StringValue, param[3].IntValue, param[4].IntValue, param[5].StringValue);
            else throw new CompilerException(-1, 312);
        }

    }
}
