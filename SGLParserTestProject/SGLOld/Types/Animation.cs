using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Types
{
    class Animation : SpriteObject
    {
        private int frameCount;
        private int frameDelay;
        private String loopType;

        public Animation(int priority, String filepath, String layer, String origin, int frameCount, int frameDelay, String loopType)
        {

            this.priority = priority;
            this.filepath = filepath;
            this.layer = layer;
            this.origin = origin;
            this.frameCount = frameCount;
            this.frameDelay = frameDelay;
            this.loopType = loopType;
        
        }


        public void GenerateSbCode(StringBuilder storyboardCode)
        {
            // Start Sprite with this code
            storyboardCode.AppendLine("Animation," + layer + "," + origin + ",\"" + filepath + "\",320,240," + frameCount + "," + frameDelay + "," + loopType);
            // Add all the commands for this sprite
            //storyboardCode.Append(objectSbCode);
            GetCommandsSbCode(storyboardCode);
        }

    }
}
