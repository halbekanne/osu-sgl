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
        
        }


        public void GenerateSbCode(StringBuilder storyboardCode)
        {
            // Start Sprite with this code
            storyboardCode.AppendLine("Sprite," + layer + "," + origin + ",\"" + filepath + "\",320,240");

            // Add all the commands for this sprite
            foreach (SbCommand cmd in moveCmds)
            {
                storyboardCode.Append(" M," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + (int)cmd.startParams[0] + "," + (int)cmd.startParams[1] + "," + (int)cmd.endParams[0] + "," + (int)cmd.endParams[1]);
            }
            foreach (SbCommand cmd in moveXCmds)
            {
                storyboardCode.Append(" MX," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + (int)cmd.startParams[0] + "," + (int)cmd.endParams[0]);
            }
            foreach (SbCommand cmd in moveYCmds)
            {
                storyboardCode.Append(" MY," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + (int)cmd.startParams[0] + "," + (int)cmd.endParams[0]);
            }
            foreach (SbCommand cmd in fadeCmds)
            {
                storyboardCode.Append(" F," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + cmd.startParams[0] + "," + cmd.endParams[0]);
            }
            foreach (SbCommand cmd in scaleCmds)
            {
                storyboardCode.Append(" S," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + cmd.startParams[0] + "," + cmd.endParams[0]);
            }
            foreach (SbCommand cmd in rotateCmds)
            {
                storyboardCode.Append(" R," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + cmd.startParams[0] + "," + cmd.endParams[0]);
            }
            foreach (SbCommand cmd in colorCmds)
            {
                storyboardCode.Append(" C," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + cmd.startParams[0] + "," + cmd.startParams[1] + "," + cmd.startParams[2] + "," + cmd.endParams[0] + "," + cmd.endParams[1] + "," + cmd.endParams[2]);
            }



            //storyboardCode.Append(objectSbCode);
        }

    }
}
