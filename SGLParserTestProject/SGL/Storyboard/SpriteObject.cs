using System;
using System.Collections.Generic;

using System.Text;

namespace SGL.Storyboard
{
    public class SpriteObject : VisualObject
    {


        public SpriteObject(string layer, string origin, string filepath)
            : base(layer, origin, filepath)
        { } 
      


        override protected String GetStoryboardInitCode()
        {
            return "Sprite," + layer + "," + origin + ",\"" + filepath + "\",320,240";
        }
    }
}
