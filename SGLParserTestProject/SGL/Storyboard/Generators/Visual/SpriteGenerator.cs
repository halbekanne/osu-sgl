using System;

namespace SGL.Storyboard.Generators.Visual
{
    public class SpriteGenerator : AbstractVisualGenerator
    {
        public SpriteGenerator(string layer, string origin, string filepath)
            : base(layer, origin, filepath)
        {
        }

        protected override String GetStoryboardInitCode()
        {
            return "Sprite," + layer + "," + origin + ",\"" + filepath + "\",320,240";
        }
    }
}