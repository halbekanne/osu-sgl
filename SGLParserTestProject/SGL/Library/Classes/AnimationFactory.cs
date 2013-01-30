using System;
using System.Collections.Generic;
using SGL.Elements;
using SGL.Storyboard;

namespace SGL.Library.Classes
{
    internal class AnimationFactory : Visual
    {
        private readonly int frameCount;
        private readonly int frameDelay;
        private readonly String layer;
        private readonly string loopType;
        private readonly String origin;
        private readonly String path;

        //private AnimationObject sprite;

        // used for class registration
        public AnimationFactory()
        {
        }

        private AnimationFactory(String path, int frameCount, int frameDelay)
            : this(path, "Foreground", "Centre", frameCount, frameDelay, "LoopForever")
        {
        }

        private AnimationFactory(String path, String layer, int frameCount, int frameDelay)
            : this(path, layer, "Centre", frameCount, frameDelay, "LoopForever")
        {
        }

        private AnimationFactory(String path, String layer, String origin, int frameCount, int frameDelay)
            : this(path, layer, origin, frameCount, frameDelay, "LoopForever")
        {
        }

        private AnimationFactory(String path, String layer, String origin, int frameCount, int frameDelay, string loopType)
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
            Sprite = new AnimationObject(layer, origin, path, frameCount, frameDelay, loopType);
            // we need to save this object in order to generate the storyboard when all parsing processes finished
            GlobalMemory.Instance.RegisterSprite(Sprite);
        }


        public override object CreateNewInstance(List<Value> param)
        {
            if (Value.TypeCompare(param, ValType.String, ValType.Integer, ValType.Integer))
                return new AnimationFactory(param[0].StringValue, param[1].IntValue, param[2].IntValue);
            else if (Value.TypeCompare(param, ValType.String, ValType.Layer, ValType.Integer, ValType.Integer))
                return new AnimationFactory(param[0].StringValue, param[1].StringValue, param[2].IntValue,
                                     param[3].IntValue);
            else if (Value.TypeCompare(param, ValType.String, ValType.Layer, ValType.Origin, ValType.Integer,
                                       ValType.Integer))
                return new AnimationFactory(param[0].StringValue, param[1].StringValue, param[2].StringValue,
                                     param[3].IntValue, param[4].IntValue);
            else if (Value.TypeCompare(param, ValType.String, ValType.Layer, ValType.Origin, ValType.Integer,
                                       ValType.Integer, ValType.LoopType))
                return new AnimationFactory(param[0].StringValue, param[1].StringValue, param[2].StringValue,
                                     param[3].IntValue, param[4].IntValue, param[5].StringValue);
            else throw new CompilerException(-1, 312);
        }
    }
}