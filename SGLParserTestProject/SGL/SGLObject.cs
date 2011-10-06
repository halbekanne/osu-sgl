using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    public class SGLObject : IComparable 
    {
        // Init
        protected int priority;
        protected String filepath;
        protected String layer;
        protected String origin;
        protected StringBuilder objectSbCode = new StringBuilder();

        // Last attributes
        public int x = 320, y = 240, red = 255, green = 255, blue = 255;
        public double opacity = 1, scaleX = 1, scaleY = 1, rotate = 1;

        // Lists of commands
        public List<SbCommand> moveCmds = new List<SbCommand>();
        public List<SbCommand> moveXCmds = new List<SbCommand>();
        public List<SbCommand> moveYCmds = new List<SbCommand>();
        public List<SbCommand> fadeCmds = new List<SbCommand>();
        public List<SbCommand> rotateCmds = new List<SbCommand>();
        public List<SbCommand> scaleCmds = new List<SbCommand>();
        public List<SbCommand> scaleVecCmds = new List<SbCommand>();
        public List<SbCommand> colorCmds = new List<SbCommand>();

        public int GetPriority()
        {
            return priority;
        }

        public String GetFilepath()
        {
            return filepath;
        }

        public String GetLayer()
        {
            return layer;
        }

        public String GetOrigin()
        {
            return origin;
        }


        public int CompareTo(Object o)
        {
            if (o is SGLObject)
            {
                return this.GetPriority() - ((SGLObject)o).GetPriority();
            }
            else
            {
                throw new Exception("SGLObject can't be compared");
            }

        }

        protected void GetCommandsSbCode(StringBuilder storyboardCode)
        {

            // Add all the commands for this sprite
            foreach (SbCommand cmd in moveCmds)
            {
                storyboardCode.Append(" M," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + (int)cmd.startParams[0] + "," + (int)cmd.startParams[1] + "," + (int)cmd.endParams[0] + "," + (int)cmd.endParams[1]);
            }
            foreach (SbCommand cmd in moveXCmds)
            {
                storyboardCode.Append(" MX," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + ((int)cmd.startParams[0]).ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + ((int)cmd.endParams[0]).ToString(System.Globalization.CultureInfo.InvariantCulture));
            }
            foreach (SbCommand cmd in moveYCmds)
            {
                storyboardCode.Append(" MY," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + ((int)cmd.startParams[0]).ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + ((int)cmd.endParams[0]).ToString(System.Globalization.CultureInfo.InvariantCulture));
            }
            foreach (SbCommand cmd in fadeCmds)
            {
                storyboardCode.Append(" F," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + cmd.startParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmd.endParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture));
            }
            foreach (SbCommand cmd in scaleCmds)
            {
                storyboardCode.Append(" S," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + cmd.startParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmd.endParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture));
            }
            foreach (SbCommand cmd in scaleVecCmds)
            {
                storyboardCode.Append(" V," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + cmd.startParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmd.startParams[1].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmd.endParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmd.endParams[1].ToString(System.Globalization.CultureInfo.InvariantCulture));
            }
            foreach (SbCommand cmd in rotateCmds)
            {
                storyboardCode.Append(" R," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + cmd.startParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmd.endParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture));
            }
            foreach (SbCommand cmd in colorCmds)
            {
                storyboardCode.Append(" C," + cmd.easing + "," + cmd.startTime + "," + cmd.endTime + "," + cmd.startParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmd.startParams[1].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmd.startParams[2].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmd.endParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmd.endParams[1].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmd.endParams[2].ToString(System.Globalization.CultureInfo.InvariantCulture));
            }

        }

        public void AddSbCode(String sbCode)
        {
            objectSbCode.AppendLine(sbCode);
        }

    }
}
