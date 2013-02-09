using System;

namespace SGL.Storyboard
{
    public class AnimationObject : Sprite
    {
        private readonly int frameCount;
        private readonly int frameDelay;
        private readonly string loopType;

        public AnimationObject(string layer, string origin, string filepath, int frameCount, int frameDelay,
                               string loopType)
            : base(layer, origin, filepath)
        {
            this.frameCount = frameCount;
            this.frameDelay = frameDelay;
            this.loopType = loopType;
        }


        protected override String GetStoryboardInitCode()
        {
            return "Animation," + layer + "," + origin + ",\"" + filepath + "\",320,240," + frameCount + "," +
                   frameDelay + "," + loopType;
        }
    }
}