using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Types
{
    class Sprite : SpriteObject
    {


        public Sprite(int priority, String filepath, String layer, String origin)
        {

            this.priority = priority;
            this.filepath = filepath;
            this.layer = layer;
            this.origin = origin;
        
        }


        public void GenerateSbCode(StringBuilder storyboardCode)
        {
            // Start Sprite with this code
            storyboardCode.AppendLine("Sprite," + layer + "," + origin + ",\"" + filepath + "\",320,240");

            GetCommandsSbCode(storyboardCode);

            //storyboardCode.Append(objectSbCode);
        }

    }
}
