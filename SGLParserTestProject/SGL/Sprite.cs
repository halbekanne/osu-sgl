using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    class Sprite : SGLObject
    {


        public Sprite(int priority, String filepath, String layer, String origin)
        {

            this.priority = priority;
            this.filepath = filepath;
            this.layer = layer;
            this.origin = origin;

            Console.WriteLine("Sprite created");
        
        
        }


        public void GenerateSbCode(StringBuilder storyboardCode)
        {
            // Start Sprite with this code
            storyboardCode.AppendLine("Sprite," + layer + "," + origin + ",\"" + filepath + "\",320,240");
            // Add all the commands for this sprite
            storyboardCode.Append(objectSbCode);
        }

    }
}
