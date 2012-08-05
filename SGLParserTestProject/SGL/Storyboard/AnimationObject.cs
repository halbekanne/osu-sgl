using System;
using System.Collections.Generic;

using System.Text;

namespace SGL.Storyboard
{
    public class AnimationObject : VisualObject
    {
        private int frameCount;
        private int frameDelay;
        private string loopType;

        public AnimationObject(string layer, string origin, string filepath, int frameCount, int frameDelay, string loopType)
            : base(layer, origin, filepath)
        {
            this.frameCount = frameCount;
            this.frameDelay = frameDelay;
            this.loopType = loopType;
        } 
      


        override protected String GetStoryboardInitCode()
        {
            return "Animation," + layer + "," + origin + ",\"" + filepath + "\",320,240," + frameCount + "," + frameDelay + "," + loopType;
        }
    }
}
