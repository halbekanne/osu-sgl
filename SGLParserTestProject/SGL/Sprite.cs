using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    class Sprite : SGLObject
    {


        public Sprite(SGLValue priority, SGLValue filepath, SGLValue layer, SGLValue origin)
        {
            if (!priority.IsInteger())
            {
                throw new Exception("Priority must be an integer value");
            }

            if (!filepath.IsString())
            {
                throw new Exception("Filepath must be a string value");
            }

            if (!layer.IsString())
            {
                throw new Exception("Layer must be a string value");
            }

            if (!origin.IsString())
            {
                throw new Exception("Origin must be a string value");
            }

            this.priority = priority.AsInteger();
            this.filepath = filepath;
            this.layer = layer;
            this.origin = origin;

            Console.WriteLine("Sprite created");
        
        
        }


        public void GenerateSbCode(StringBuilder storyboardCode)
        {
            // Start Sprite with this code
            storyboardCode.AppendLine("Sprite," + layer.AsString() + "," + origin.AsString() + ",\"" + filepath.AsString() + "\",320,240");
            // Add all the commands for this sprite
            storyboardCode.Append(objectSbCode);
        }

    }
}
