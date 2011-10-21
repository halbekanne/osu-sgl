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

        // loop specific
        public Boolean loop = false;
        public SbLoop loopObj = null; 

        // List of commands
        public List<SbCommand> commands = new List<SbCommand>();

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
            foreach (SbCommand cmd in commands)
            {
                if (cmd is SbAnimation)
                {
                    //SbAnimation cmdAnim = (SbAnimation)cmd;
                    GetAnimationSbCode(storyboardCode, (SbAnimation)cmd);

                }
                else if (cmd is SbStandardLoop)
                {
                        SbStandardLoop cmdLoop = (SbStandardLoop)cmd;
                        storyboardCode.Append(" L," + cmdLoop.startTime + "," + cmdLoop.count);
                        storyboardCode.Append("\r\n");
                        foreach (SbAnimation cmdAnim in cmdLoop.GetAnimationList())
                        {
                            storyboardCode.Append(" "); // Loop additional whitespace
                            GetAnimationSbCode(storyboardCode, cmdAnim);
                        }
                }
                else if (cmd is SbTriggerLoop)
                {
                    SbTriggerLoop cmdLoop = (SbTriggerLoop)cmd;
                    storyboardCode.Append(" T," + cmdLoop.startTime + "," + cmdLoop.endTime + "," + cmdLoop.trigger);
                    storyboardCode.Append("\r\n");
                    foreach (SbAnimation cmdAnim in cmdLoop.GetAnimationList())
                    {
                        storyboardCode.Append(" "); // Loop additional whitespace
                        GetAnimationSbCode(storyboardCode, cmdAnim);
                    }
                }
                else
                {
                    throw new UnexpectedException("Unimplemented storyboard command type - Error should never occur", "");
                }

            }



        }


        /// <summary>
        /// Generates storyboard code for one animation command
        /// </summary>
        /// <param name="storyboardCode"></param>
        /// <param name="cmdAnim"></param>
        private void GetAnimationSbCode(StringBuilder storyboardCode, SbAnimation cmdAnim)
        {
            switch (cmdAnim.animationType)
            {
                case SbAnimation.AnimationType.move: storyboardCode.Append(" M," + cmdAnim.easing + "," + cmdAnim.startTime + "," + cmdAnim.endTime + "," + (int)cmdAnim.startParams[0] + "," + (int)cmdAnim.startParams[1] + "," + (int)cmdAnim.endParams[0] + "," + (int)cmdAnim.endParams[1]);
                    break;
                case SbAnimation.AnimationType.moveX: storyboardCode.Append(" MX," + cmdAnim.easing + "," + cmdAnim.startTime + "," + cmdAnim.endTime + "," + ((int)cmdAnim.startParams[0]).ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + ((int)cmdAnim.endParams[0]).ToString(System.Globalization.CultureInfo.InvariantCulture));
                    break;
                case SbAnimation.AnimationType.moveY: storyboardCode.Append(" MY," + cmdAnim.easing + "," + cmdAnim.startTime + "," + cmdAnim.endTime + "," + ((int)cmdAnim.startParams[0]).ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + ((int)cmdAnim.endParams[0]).ToString(System.Globalization.CultureInfo.InvariantCulture));
                    break;
                case SbAnimation.AnimationType.fade: storyboardCode.Append(" F," + cmdAnim.easing + "," + cmdAnim.startTime + "," + cmdAnim.endTime + "," + cmdAnim.startParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmdAnim.endParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture));
                    break;
                case SbAnimation.AnimationType.scale: storyboardCode.Append(" S," + cmdAnim.easing + "," + cmdAnim.startTime + "," + cmdAnim.endTime + "," + cmdAnim.startParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmdAnim.endParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture));
                    break;
                case SbAnimation.AnimationType.scaleVec: storyboardCode.Append(" V," + cmdAnim.easing + "," + cmdAnim.startTime + "," + cmdAnim.endTime + "," + cmdAnim.startParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmdAnim.startParams[1].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmdAnim.endParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmdAnim.endParams[1].ToString(System.Globalization.CultureInfo.InvariantCulture));
                    break;
                case SbAnimation.AnimationType.rotate: storyboardCode.Append(" R," + cmdAnim.easing + "," + cmdAnim.startTime + "," + cmdAnim.endTime + "," + cmdAnim.startParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmdAnim.endParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture));
                    break;
                case SbAnimation.AnimationType.color: storyboardCode.Append(" C," + cmdAnim.easing + "," + cmdAnim.startTime + "," + cmdAnim.endTime + "," + cmdAnim.startParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmdAnim.startParams[1].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmdAnim.startParams[2].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmdAnim.endParams[0].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmdAnim.endParams[1].ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + cmdAnim.endParams[2].ToString(System.Globalization.CultureInfo.InvariantCulture));
                    break;
                default: throw new UnexpectedException("Unimplemented animation type - Error should never occur", "");

            }
            storyboardCode.Append("\r\n");
        }


        public void AddSbCode(String sbCode)
        {
            objectSbCode.AppendLine(sbCode);
        }

    }
}
