using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGL.Storyboard
{
    class SpriteObject : VisualObject
    {


        public SpriteObject(string layer, string origin, string filepath)
            : base(layer, origin, filepath)
        { } 
      


        override public String GetStoryboardInitCode()
        {
            return "Sprite," + layer + "," + origin + ",\"" + filepath + "\",320,240";
        }
    }
}
