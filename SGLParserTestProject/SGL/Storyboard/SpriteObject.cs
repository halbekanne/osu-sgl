using System;

namespace SGL.Storyboard
{
    public class SpriteObject : VisualObject
    {
        public SpriteObject(string layer, string origin, string filepath)
            : base(layer, origin, filepath)
        {
        }


        protected override String GetStoryboardInitCode()
        {
            return "Sprite," + layer + "," + origin + ",\"" + filepath + "\",320,240";
        }
    }
}